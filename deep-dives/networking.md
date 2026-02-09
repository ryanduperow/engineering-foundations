# Networking

## TCP and Sockets
*Added: 2026-02-09 | Source: Project 1, Milestone 1*

### What Is It?
TCP (Transmission Control Protocol) is the reliable delivery layer of the internet — it guarantees bytes arrive in order and nothing gets lost. A **socket** is the OS's handle for a network connection, like how a `FileStream` is a handle for a file on disk. When you call `TcpListener.Start()`, you're asking the OS: "reserve a socket on this port and start queueing incoming connections for me."

### Why Does It Matter?
Every HTTP request in your ASP.NET apps travels over TCP. Kestrel opens a socket, accepts connections, and reads bytes — exactly what you did with `TcpListener` in M1. Understanding this layer explains why servers can "run out of connections" under load, why ports matter, and why `netstat` is useful for debugging.

### How It Works
A TCP connection starts with a **three-way handshake** — a quick back-and-forth before any data flows:

```
Client                     Server
  |  ---- SYN ---------->  |    "I want to connect"
  |  <--- SYN-ACK -------  |    "OK, I acknowledge"
  |  ---- ACK ---------->  |    "Great, we're connected"
  |                         |
  |  ---- data --------->  |    Now HTTP bytes flow
```

The OS handles this entirely. By the time `AcceptTcpClient()` returns, the handshake is done and you have a ready-to-use stream. `AcceptTcpClient()` **blocks** — your code pauses on that line until a client connects, like `Console.ReadLine()` pauses until you type something.

**Ports** are how the OS routes traffic to the right program. Port 80 = HTTP, 443 = HTTPS, but anything above 1023 works for development. You hit a port conflict in M1 because IIS was already sitting on 8080 — two programs can't listen on the same port.

> **Watch out:** `AcceptTcpClient()` blocks the entire thread. If you're handling one client, nobody else can connect. This is why M5 introduces async — and why Kestrel uses async I/O everywhere.

### Key Mental Model
A socket is a phone line. `TcpListener.Start()` plugs in the phone. `AcceptTcpClient()` waits for it to ring. The handshake is the "hello? — hi! — great" before the conversation starts.

---

## HTTP Request/Response Format
*Added: 2026-02-09 | Source: Project 1, Milestones 2-3*

### What Is It?
HTTP is a **text protocol** that rides on top of TCP. Every request and response is plain text with a strict format — not binary, not encrypted (that's HTTPS/TLS on top). The same format has been used since the 1990s.

### Why Does It Matter?
When you write `HttpContext.Request.Method` or `Results.Ok("hello")` in ASP.NET, something had to parse or build this text. That something is Kestrel. You wrote a simplified version in M2 (parsing) and M3 (building responses).

### How It Works
**Request** (what the client sends):
```
GET /hello HTTP/1.1\r\n          ← request line: method, path, version
Host: 127.0.0.1:5000\r\n        ← headers (key: value, one per line)
User-Agent: curl/8.16.0\r\n
Accept: */*\r\n
\r\n                             ← blank line = headers are done
name=ryan                        ← body (optional, usually POST/PUT only)
```

**Response** (what the server sends back):
```
HTTP/1.1 200 OK\r\n             ← status line: version, code, reason
Content-Length: 13\r\n           ← headers
\r\n                             ← blank line
Hello, world!                    ← body
```

Three sections every time, always in order: **line 1** (request/status line), **headers** (until blank line), **body** (everything after).

`\r\n` (CRLF) is required by the HTTP spec — not just `\n`. This dates back to old teletype machines and is one of those "it's in the spec so everyone does it" things.

**`Content-Length`** tells the other side how many bytes of body to expect. Without it, the client wouldn't know when the response is finished. Your `ToBytes()` method sets this automatically.

> **Watch out:** In your M2 parser, you read into a fixed 1024-byte buffer. If a request is larger (big POST body, lots of headers), you'd miss the rest. Real servers read in a loop until they've consumed exactly `Content-Length` bytes. This is fine for learning — just know it's a simplification.

### Key Mental Model
HTTP is a letter format. Line 1 is the subject line, headers are the metadata (from, date, priority), the blank line is the fold in the envelope, and the body is the actual message.

---

## Routing
*Added: 2026-02-09 | Source: Project 1, Milestone 3*

### What Is It?
Routing is matching an incoming request to a handler function. At its core, it's a dictionary lookup: the key is `"GET /hello"` (method + path), the value is a function that returns a response.

### Why Does It Matter?
Every `app.MapGet("/hello", ...)` call in ASP.NET registers an entry in a route table — the same concept as your `router.AddRoute()`. ASP.NET's router is more powerful (it supports path parameters like `/users/{id}`, constraints, middleware), but the foundation is the same dictionary lookup.

### How It Works
```csharp
// Your code (M3)
router.AddRoute("GET", "/hello", _ => new HttpResponse { Body = "Hello!" });

// ASP.NET equivalent
app.MapGet("/hello", () => "Hello!");
```

Both register a function under a key. When a request arrives:
1. Extract method + path from the parsed request
2. Look it up in the dictionary
3. Match → call the handler, return its response
4. No match → return 404

> **Watch out:** Your router uses exact string matching — `GET /hello` and `GET /Hello` are different routes. ASP.NET's router is case-insensitive and supports patterns. You could add case-insensitive lookup by normalizing the key to lowercase.

### Key Mental Model
A router is a phone switchboard. The request says "I need GET /hello" and the router plugs the call into the right handler. If nobody's registered for that number, you get a 404 — "this number is not in service."

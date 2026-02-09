# Learning Log

## Session: 2026-02-09

### What I Built
- M1: TCP listener that accepts connections and prints raw HTTP bytes to console
- M2: HTTP request parser — splits raw text into method, path, headers, body
- M3: Router + HTTP response builder — server now routes requests and sends proper responses
- 4 source files: Program.cs, HttpRequest.cs, HttpResponse.cs, Router.cs

### What I Learned
- HTTP is plain text over TCP — same format since the 1990s (see [deep-dives/networking.md](../../deep-dives/networking.md))
- A socket is the OS's handle for a network connection, like FileStream for files
- `AcceptTcpClient()` blocks until a client connects — the OS handles the TCP handshake before your code sees anything
- Routing is just a dictionary lookup: `"GET /hello"` → handler function — same concept as `app.MapGet()`
- `Content-Length` header tells the client how many body bytes to expect
- Shell splits unquoted spaces into separate arguments — that's why URLs use `%20`

### What's Next
- M4: Serve static files from disk (HTML, CSS, images)
- M5: Handle multiple concurrent connections with async/await
- Consider `/deep-dive concurrency` when M5 comes up

### Time Spent
- ~2 hours

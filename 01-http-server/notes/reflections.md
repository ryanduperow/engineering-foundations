# Reflections

## M1: Accept a TCP connection, read raw bytes, print to console
*Completed: 2026-02-09*

**What clicked:** Understanding what TcpListener.Start() actually asks the OS to do. Seeing that an HTTP request is literally plain text over a TCP connection.

**What was hard:** I'm a little confused about the blocking aspect of listener.AcceptTcpClient and the handshake.

**In my own words:** The TCP listener reserves a socket on the OS and waits for HTTP requests to come through.

## M2: Parse an HTTP/1.1 request (method, path, headers, body)
*Completed: 2026-02-09*

**What clicked:** Seeing that HttpContext.Request.Method/Path/Headers in ASP.NET are just parsed from this raw text.

**What was hard:** Understanding when a body exists and how to know where headers end.

**In my own words:** HTTP request parsing takes the raw data from the request and maps it to structured data so that the request can be properly routed/processed.

## M3: Route requests to handlers, return proper HTTP responses
*Completed: 2026-02-09*

**What clicked:** Seeing that app.MapGet in ASP.NET is doing the same thing as our AddRoute.

**What was hard:** Nothing hard — this milestone was pretty straightforward.

**In my own words:** Routing takes the request, extracts the routing section and checks the value against the routing dictionary. If there is a match, the corresponding function is called, if not we get a 404 no matching route.

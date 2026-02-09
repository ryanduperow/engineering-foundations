# Project 1: HTTP Server from Scratch

Build a basic HTTP/1.1 server in C# using raw `TcpListener`. No ASP.NET, no frameworks.

## Why This Project
This one project forces you through: how computers work, networking, I/O fundamentals, concurrency, and terminal/shell skills. By building what Kestrel does for you, you understand every layer beneath your daily work.

## Milestones

- [ ] **M1:** Accept a TCP connection, read raw bytes, print to console
- [ ] **M2:** Parse an HTTP/1.1 request (method, path, headers, body)
- [ ] **M3:** Route requests to handlers, return proper HTTP responses
- [ ] **M4:** Serve static files from disk
- [ ] **M5:** Handle multiple concurrent connections with async/await
- [ ] **M6:** Add simple logging

## Learning Triggers

Ask Claude Code these questions when you hit them:

| Trigger | Concepts |
|---------|----------|
| "What actually happens when I call `TcpListener.Start()`?" | OS, sockets, ports, file descriptors |
| "Why does my server hang with multiple clients?" | Threading, async I/O, event loops |
| "What's the difference between my server and Kestrel?" | Production-grade concerns |
| "How does HTTP actually work over TCP?" | Protocol layers, framing, keep-alive |

## Deep Dives to Write
- `deep-dives/networking.md` — TCP, HTTP, DNS, TLS
- `deep-dives/concurrency.md` — threads, async, I/O models

## Reference (use when curious, not required)
- *High Performance Browser Networking* (free online)
- *Code* by Charles Petzold
- Julia Evans networking zines

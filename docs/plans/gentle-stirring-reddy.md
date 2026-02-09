# Engineering Foundations — Project-Driven Learning with Claude Code

## Context
Developer with 3.5 yrs experience (bootcamp > enterprise > dev shop). Stack: ASP.NET Core, React, SQL Server, Azure. Uses Git Bash on Windows, has Mac mini available as personal server. Goal: fill foundational gaps to build products independently and be a stronger engineer. Uses Claude Code as primary learning tool.

## Philosophy
Traditional curriculum: read chapter > do exercise > next chapter. That's slow and context-free.

**This plan: build real things > hit gaps > go deep with Claude Code on exactly what you need > document what you learned > repeat.**

Claude Code changes the learning equation. You don't need to memorize syntax or grind exercises. You need **mental models** — understanding *why* things work so you can make good decisions, ask the right questions, and evaluate AI-generated code critically.

The Mac mini is your lab. You'll deploy to it, SSH into it, break it, fix it. Real ops experience beats any tutorial.

## How to Use Claude Code for Learning
- **"Explain like I'm missing CS fundamentals"** — tell Claude your context, ask it to fill gaps
- **"Why does this work?"** — after Claude generates code, ask it to explain the underlying concepts
- **"What could go wrong?"** — forces discussion of edge cases, security, performance
- **"Show me what's happening at the OS/network/memory level"** — go beneath the abstraction
- **Build first, understand second** — get something working, then interrogate every layer
- **Keep a `notes/` folder** — write down what you learn in your own words. If you can't explain it, you don't know it yet.

## Repo Structure
```
engineering-foundations/
  README.md                   # Progress tracker + links
  CLAUDE.md                   # Context for Claude Code sessions

  01-http-server/             # Project 1: raw HTTP server
    src/
    notes/
    README.md

  02-deploy-to-mac/           # Project 2: deploy to Mac mini
    infra/
    notes/
    README.md

  03-url-shortener/           # Project 3: full-stack product
    src/
    tests/
    infra/
    notes/
    README.md

  04-ai-assistant/            # Project 4: AI-powered tool
    src/
    tests/
    notes/
    README.md

  deep-dives/                 # Concept notes triggered by projects
    networking.md
    concurrency.md
    database-internals.md
    security.md
    ...

  resources/bookshelf.md      # Reference books (use on-demand, not sequential)
```

---

## Project 1: HTTP Server from Scratch (Weeks 1-4)
**Build a basic HTTP/1.1 server in C# using raw TcpListener. No ASP.NET, no frameworks.**

This one project forces you through:
- **How computers work**: memory, processes, what the OS does when you listen on a port
- **Networking**: TCP handshake, HTTP protocol parsing, DNS, sockets
- **I/O fundamentals**: blocking vs non-blocking, streams, buffering
- **Concurrency**: handling multiple connections (threads first, then async)
- **Terminal/shell**: running, testing, and debugging from the command line

### Milestones
1. Accept a TCP connection, read raw bytes, print to console
2. Parse an HTTP/1.1 request (method, path, headers, body)
3. Route requests to handlers, return proper HTTP responses with correct status codes/headers
4. Serve static files from disk
5. Handle multiple concurrent connections with async/await
6. Add simple logging

### Learning triggers (go deep with Claude Code when you hit these)
- "What actually happens when I call `TcpListener.Start()`?" → OS, sockets, ports, file descriptors
- "Why does my server hang with multiple clients?" → threading, async I/O, event loops
- "What's the difference between my server and Kestrel?" → production-grade concerns
- "How does HTTP actually work over TCP?" → protocol layers, framing, keep-alive

### Reference (not required reading — use when curious)
- *High Performance Browser Networking* (free online) — HTTP/networking chapters
- *Code* by Charles Petzold — if you want the "how computers work" foundation
- Julia Evans networking zines — fast visual explanations

---

## Project 2: Deploy to Your Mac Mini (Weeks 5-8)
**Take your HTTP server (or a real ASP.NET Core app) and deploy it to your Mac mini as a real server.**

This forces you through:
- **Linux/macOS fundamentals**: file system, permissions, processes, services
- **Terminal mastery**: SSH, shell scripting, environment management
- **Deployment**: what "deploy" actually means at every step
- **Docker**: containerize your app, run it on the Mac
- **Networking (applied)**: DNS, ports, firewall, reverse proxy
- **Security**: SSH keys, firewalls, non-root users, HTTPS with Let's Encrypt

### Milestones
1. SSH into Mac mini, explore the OS (processes, file system, users)
2. Install .NET runtime, manually copy and run your app
3. Set it up as a background service that survives reboots (launchd or systemd if Linux VM)
4. Dockerize the app, run it via Docker on the Mac
5. Put Nginx or Caddy in front as reverse proxy
6. Get a domain, point DNS to your Mac, add HTTPS
7. Write a bash script that deploys a new version (build > copy > restart)

### Learning triggers
- "What is SSH actually doing?" → public key crypto, tunneling, agent forwarding
- "Why can't I bind to port 80?" → Unix permissions, privileged ports
- "What does Docker actually do under the hood?" → namespaces, cgroups, images vs containers
- "How does HTTPS work?" → TLS, certificates, certificate authorities
- "How do I keep this running when I close my terminal?" → process management, services, signals

### Reference
- *The Linux Command Line* by Shotts — shell/terminal chapters
- *Docker Deep Dive* by Poulton — if Docker concepts feel fuzzy
- MIT Missing Semester — lectures on shell, version control, security

---

## Project 3: URL Shortener — Full Product (Weeks 9-20)
**Build a complete, production-grade URL shortener. This is your "learn everything" project.**

Built in phases, each adding a layer of engineering depth:

### Phase A: Core API (Weeks 9-12)
- ASP.NET Core Web API, **PostgreSQL** (new DB for you — learn it)
- Proper REST: status codes, RFC 7807 errors, cursor-based pagination
- OpenAPI spec (design-first)
- **Triggers:** database internals, query plans, indexes, connection pooling, API design patterns

### Phase B: Testing & Quality (Weeks 13-14)
- Unit tests + integration tests with WebApplicationFactory + Testcontainers
- GitHub Actions CI pipeline (build > test > analyze)
- **Triggers:** testing strategy, mocking vs integration, test pyramid, CI/CD concepts

### Phase C: Production Hardening (Weeks 15-18)
- Rate limiting, authentication (JWT), input validation
- Structured logging (Serilog), OpenTelemetry tracing
- Health checks, error handling
- Security audit against OWASP Top 10
- **Triggers:** security fundamentals, observability, performance profiling

### Phase D: Deploy & Operate (Weeks 19-20)
- Docker Compose: API + PostgreSQL + Redis (caching layer)
- Deploy to Mac mini (and optionally Azure Container Apps)
- Basic monitoring dashboard
- Load test with k6, find and fix bottlenecks
- **Triggers:** infrastructure as code, caching strategies, performance optimization, system design

### Learning triggers
- "Why is PostgreSQL different from SQL Server?" → database internals, MVCC vs locking, isolation levels
- "How should I handle concurrent short-code generation?" → concurrency, race conditions, distributed ID generation
- "What happens under load?" → connection pooling, caching, async I/O, bottleneck analysis
- "Is this secure?" → OWASP Top 10, parameterized queries, CORS, CSRF, secrets management
- "How do I know it's working in production?" → observability, structured logging, tracing, alerting

### Reference
- ***Designing Data-Intensive Applications*** by Kleppmann — THE book. Read chapters as they become relevant (Ch 1-3 for DB, Ch 5-6 for replication/partitioning, Ch 7 for transactions)
- *Unit Testing Principles* by Khorikov — testing strategy
- *Concurrency in C# Cookbook* by Cleary — async/concurrency patterns
- Stripe API docs — gold standard API design reference

---

## Project 4: AI-Powered Tool (Weeks 21-28)
**Build an AI documentation assistant that indexes a codebase and answers questions about it.**

This is where your AI/LLM fundamentals come in, plus it's a genuine product idea.

### Milestones
1. Index a repo: read files, chunk content, generate embeddings
2. Store embeddings in a vector database (Qdrant or pgvector in PostgreSQL)
3. RAG query pipeline: embed question > retrieve relevant chunks > send to LLM > return answer
4. ASP.NET Core API backend with React frontend
5. Add function calling: LLM can search code, read files, query git history
6. Deploy to Mac mini

### Learning triggers
- "What are embeddings and why do they enable semantic search?" → vector math, similarity, embedding models
- "How do I choose chunk size and overlap?" → RAG architecture, retrieval quality
- "How do I control cost?" → token counting, caching, model selection
- "What about hallucination?" → evaluation, grounding, prompt engineering
- "How does function calling work?" → tool use, structured output, agent patterns

### Reference
- Andrej Karpathy "Intro to LLMs" (YouTube)
- Simon Willison's blog — practical LLM development
- Anthropic/OpenAI API docs

---

## Architecture & Design Patterns — Woven In, Not Separate
Don't study these in isolation. Encounter them through the projects:

| Concept | Where you'll hit it |
|---------|-------------------|
| Design patterns | Middleware=Chain of Responsibility, DI everywhere, Strategy for URL generation |
| Software architecture | URL shortener evolves from simple to modular monolith |
| System design | Load testing forces you to think about scaling, caching, queues |
| CQRS/event-driven | Analytics read model vs write model in URL shortener |
| DDD tactical patterns | Domain modeling in the AI assistant |

When you encounter an architectural decision, ask Claude Code to explain the pattern, alternatives, and tradeoffs. Write it up in `deep-dives/`.

### Reference (read when the concept comes up, not before)
- *A Philosophy of Software Design* by Ousterhout — short, opinionated, read anytime
- *Fundamentals of Software Architecture* by Richards & Ford — overview reference
- refactoring.guru — pattern catalog with C# examples

---

## Deep Dives Folder
As you build, you'll accumulate concept notes in `deep-dives/`. Expected files:

```
deep-dives/
  networking.md          # TCP, HTTP, DNS, TLS — from Project 1
  os-fundamentals.md     # Processes, memory, file systems — from Project 2
  terminal-and-shell.md  # Bash, SSH, scripting — from Project 2
  concurrency.md         # Async, threads, race conditions — from Projects 1 & 3
  database-internals.md  # Indexes, query plans, isolation — from Project 3
  security.md            # OWASP, auth, crypto basics — from Project 3
  testing.md             # Strategy, test types, tooling — from Project 3
  deployment.md          # Docker, CI/CD, monitoring — from Projects 2 & 3
  performance.md         # Profiling, caching, optimization — from Project 3
  architecture.md        # Patterns, tradeoffs, decisions — from Projects 3 & 4
  ai-fundamentals.md     # Embeddings, RAG, prompting — from Project 4
```

These are YOUR notes, in YOUR words. The act of writing them is the learning.

---

## Top Books (on-demand reference, not sequential reading)
| Book | When to read |
|------|-------------|
| *Designing Data-Intensive Applications* (Kleppmann) | When you start Project 3 Phase A |
| *A Philosophy of Software Design* (Ousterhout) | Anytime — it's short and changes how you think about code |
| *Code* (Petzold) | If you want deeper "how computers work" during Project 1 |
| *Concurrency in C# Cookbook* (Cleary) | When you hit async/concurrency questions |
| *Unit Testing Principles* (Khorikov) | When you start Project 3 Phase B |

## Skills — Making Learning Repeatable

### Custom Skills to Create (project-local in `.claude/skills/`)

**`/deep-dive <topic>`**
- After a build session, generates a structured deep-dive document
- Writes to `deep-dives/<topic>.md` (appends if exists)
- Format: concept summary, why it matters, how it connects to your stack, common pitfalls, key mental model
- Uses conversation context to extract what you actually encountered

**`/checkpoint`**
- End-of-session progress snapshot
- Updates project README with current milestone status
- Summarizes what was learned and what's next
- Appends to a `learning-log.md` in the project folder

**`/explain-layers <file-or-code>`**
- Takes code you wrote or are reading and explains it at 4 layers:
  1. **What** — what does this code do?
  2. **How** — how does it work mechanically?
  3. **Why** — why is it designed this way? What are the tradeoffs?
  4. **Under the hood** — what's happening at the OS/network/memory level?
- Designed to build the mental models bootcamps skip

**`/compare <concept-a> <concept-b>`**
- Side-by-side comparison of two related concepts
- e.g., `/compare "threads vs tasks"`, `/compare "SQL Server vs PostgreSQL isolation"`
- Outputs a structured comparison: similarities, differences, when to use each, common misconceptions

**`/new-project <name>`**
- Scaffolds a new project into the curriculum
- Creates folder structure (`NN-name/src/`, `notes/`, `README.md`)
- Asks what fundamentals you want to target, generates milestones and learning triggers
- Updates the root README progress tracker
- e.g., `/new-project real-time-chat` → creates project focused on WebSockets, concurrency, message queues

Skills will be project-local markdown files in `.claude/skills/`. Created as part of initial repo setup.

---

## Extending the Curriculum

This is a living plan. Add projects and topics as interests evolve.

**To add a new project:**
1. Create `NN-project-name/` folder with `src/`, `notes/`, `README.md`
2. Define milestones and learning triggers in the README
3. Run `/checkpoint` when done to log what you learned

**To add a topic without a full project:**
1. Add a file to `deep-dives/` — e.g., `deep-dives/message-queues.md`
2. Use `/deep-dive message-queues` during any session where the topic comes up

**To swap a project:**
The 4 projects aren't sacred. If you have a product idea that covers the same fundamentals, swap it in. The key constraint: each project should force you into concepts you don't already know. Good substitutions:
- Project 1 alt: CLI tool that wraps a complex API (forces I/O, parsing, error handling)
- Project 3 alt: any CRUD product with auth, caching, real deployment
- Project 4 alt: any project that integrates an LLM API with your backend

**To reorder:**
Projects 1 and 2 should stay first (foundational). Projects 3 and 4 can be swapped or run in parallel.

---

## Verification
- Each project produces working, deployed software
- `deep-dives/` folder grows with genuine understanding (not copy-paste)
- URL shortener is portfolio-worthy: tested, deployed, observable, secure
- AI assistant demonstrates ability to integrate new tech independently
- You can explain to a colleague *why* you made each architectural decision
- Skills produce consistent, repeatable learning artifacts across sessions

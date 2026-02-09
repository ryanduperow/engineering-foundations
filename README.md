# Engineering Foundations

Project-driven learning path for software engineering fundamentals. Build real things, hit knowledge gaps, go deep with Claude Code, document what you learn.

## How This Works

Build things, hit knowledge gaps, go deep, write about what you learned.

### The Loop

1. **Build** a milestone with Claude Code — ask *why* at every step
2. **Go deep** when something is unclear — `/explain-layers` or `/compare`
3. **Capture** what you learned — `/reflect` after milestones, `/deep-dive` for concepts
4. **Checkpoint** at end of session — `/checkpoint` to log progress

### Skills — When to Use Each

| When... | Run this | What it does |
|---------|----------|--------------|
| Starting a session | `/resume-learning` | Shows where you left off and what's next |
| Code doesn't make sense | `/explain-layers <code>` | Explains at 1-4 depth layers, adapted to complexity |
| Two things seem similar | `/compare <a> <b>` | Side-by-side breakdown with tradeoffs |
| You finished a milestone | `/reflect` | 2-minute reflection: what clicked, what was hard |
| A concept came up you want to understand | `/deep-dive <topic>` | Reference note in `deep-dives/` (e.g., tcp, async-io, docker) |
| End of session | `/checkpoint` | Updates progress, logs session, suggests next steps |
| Want a new project | `/new-project <name>` | Scaffolds project folder with milestones |

### What Goes Where

| Location | What's in it |
|----------|-------------|
| `NN-project/src/` | Code you build |
| `NN-project/notes/reflections.md` | Milestone reflections (created by `/reflect`) |
| `NN-project/notes/learning-log.md` | Session log (created by `/checkpoint`) |
| `deep-dives/` | Concept notes in your own words (created by `/deep-dive`) |
| `resources/bookshelf.md` | Books to reference when a topic comes up |

### The Key Rule

**Writing is learning.** Your `deep-dives/` and milestone reflections are the real output — not the code.

---

## Progress

| # | Project | Status | Weeks | Key Concepts |
|---|---------|--------|-------|-------------|
| 01 | [HTTP Server from Scratch](01-http-server/) | In Progress (M3/M6) | 1-4 | Networking, I/O, concurrency, OS fundamentals |
| 02 | [Deploy to Mac Mini](02-deploy-to-mac/) | Not Started | 5-8 | Linux/macOS, terminal, Docker, deployment, security |
| 03 | [URL Shortener](03-url-shortener/) | Not Started | 9-20 | Database internals, testing, API design, observability, performance |
| 04 | [AI Assistant](04-ai-assistant/) | Not Started | 21-32 | Embeddings, RAG, LLM APIs, worker services, message queues, background processing |

## Deep Dives

Concept notes accumulated through building. See [deep-dives/](deep-dives/).

## Resources

- [Bookshelf](resources/bookshelf.md) — reference books, use on-demand
- [Plan](docs/plans/gentle-stirring-reddy.md) — full learning plan

# Engineering Foundations

Project-driven learning path for software engineering fundamentals. Build real things, hit knowledge gaps, go deep with Claude Code, document what you learn.

## How This Works

This isn't a textbook curriculum. It's a build-and-learn loop powered by Claude Code.

### The Loop

1. **Pick a project milestone** — each project README has a checklist of milestones
2. **Build it with Claude Code** — let Claude write code, but ask *why* at every step
3. **Hit a knowledge gap** — something doesn't make sense, or you want to go deeper
4. **Go deep** — use `/explain-layers` on the code, or ask Claude to explain the concept
5. **Capture what you learned** — use `/deep-dive <topic>` to write it up in your own words
6. **End the session** — use `/checkpoint` to log progress and plan your next session

### How to Use the Skills

These are Claude Code slash commands. Run them during any session in this repo.

**During a session:**
- `/explain-layers src/Server.cs` — after writing code, understand it at 4 depths (what it does, how, why, and what's happening at the OS/memory level)
- `/compare threads tasks` — when two concepts seem similar, get a structured breakdown of the differences
- `/deep-dive networking` — capture a concept you just encountered into `deep-dives/networking.md`

**At the end of a session:**
- `/checkpoint` — updates milestone checkboxes, logs what you learned, suggests what to tackle next

**When you want to expand:**
- `/new-project real-time-chat` — scaffolds a new project with milestones and learning triggers

### What Goes Where

| Location | What's in it |
|----------|-------------|
| `NN-project/src/` | Code you build |
| `NN-project/notes/learning-log.md` | Session-by-session log (created by `/checkpoint`) |
| `deep-dives/` | Concept notes in your own words (created by `/deep-dive`) |
| `resources/bookshelf.md` | Books to reference when a topic comes up |

### The Key Rule

**Writing is learning.** The `deep-dives/` folder is the real output of this repo — not the code. Anyone can generate code with AI. The notes you write, in your own words, about *why* things work the way they do — that's the knowledge that compounds.

---

## Progress

| # | Project | Status | Weeks | Key Concepts |
|---|---------|--------|-------|-------------|
| 01 | [HTTP Server from Scratch](01-http-server/) | Not Started | 1-4 | Networking, I/O, concurrency, OS fundamentals |
| 02 | [Deploy to Mac Mini](02-deploy-to-mac/) | Not Started | 5-8 | Linux/macOS, terminal, Docker, deployment, security |
| 03 | [URL Shortener](03-url-shortener/) | Not Started | 9-20 | Database internals, testing, API design, observability, performance |
| 04 | [AI Assistant](04-ai-assistant/) | Not Started | 21-28 | Embeddings, RAG, LLM APIs, function calling |

## Deep Dives

Concept notes accumulated through building. See [deep-dives/](deep-dives/).

## Resources

- [Bookshelf](resources/bookshelf.md) — reference books, use on-demand
- [Plan](docs/plans/gentle-stirring-reddy.md) — full learning plan

## Custom Skills

| Skill | Purpose | When to Use |
|-------|---------|-------------|
| `/deep-dive <topic>` | Structured concept notes into deep-dives/ | After encountering a new concept |
| `/checkpoint` | Progress snapshot + learning log | End of every session |
| `/explain-layers` | 4-layer code explanation | After writing or reading code |
| `/compare <a> <b>` | Side-by-side concept comparison | When two things seem confusingly similar |
| `/new-project <name>` | Scaffold a new curriculum project | When you want to explore something new |

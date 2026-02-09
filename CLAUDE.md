# Engineering Foundations — Claude Code Context

## About This Repo
Project-driven learning curriculum for a developer with 3.5 years experience (ASP.NET Core, React, SQL Server, Azure). Filling foundational CS/engineering gaps through building.

## Learning Philosophy
- Build first, understand second
- When a concept comes up, explain the WHY, not just the HOW
- Assume bootcamp-level CS fundamentals — fill gaps without being condescending
- Connect new concepts to the user's existing stack (ASP.NET Core, C#, SQL Server)
- Encourage writing notes in own words after explanations

## Environment
- Windows 11 + Git Bash (MINGW64)
- .NET 10, Node.js, C#, JavaScript/TypeScript
- Mac mini available as deployment target (SSH)
- Use forward slashes in paths

## Repo Structure
- `01-http-server/` through `04-ai-assistant/` — project folders
- `deep-dives/` — concept notes (networking, concurrency, security, etc.)
- `resources/bookshelf.md` — reference books
- `.claude/skills/` — custom learning skills

## How to Explain Things
- **Lead with a one-sentence plain English summary** before any detail
- **Use analogies the user already knows** — compare new concepts to ASP.NET Core, C#, SQL Server, or everyday things
- **Define jargon inline** the first time it appears (e.g., "a socket — the OS's handle for a network connection")
- **Keep paragraphs short** — 2-3 sentences max. Use bullet points over walls of text.
- **One concept at a time** — don't explain 3 things in one answer. If they're connected, explain them sequentially with clear breaks.
- **Skip what they already know** — don't re-explain C#, async/await basics, or HTTP status codes unless asked
- **Say "you don't need to worry about this yet" when appropriate** — not everything needs a deep explanation on first encounter

## When Helping with Projects
- After generating code, briefly explain what's happening at the layer below — keep it to 2-3 sentences unless the user asks for more
- Point out design decisions and their tradeoffs
- Flag concepts that connect to the deep-dives/ topics
- Suggest `/reflect` after completing a milestone, `/deep-dive` after covering a significant concept

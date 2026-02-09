---
name: deep-dive
description: Write a reference note about a concept (not a milestone). Use when a topic like TCP, async, or Docker comes up and you want a permanent note explaining it. Writes to deep-dives/.
---

# Deep Dive

Write a reference note about a **concept** you encountered while building.

This is NOT for reflecting on milestones (use `/reflect` for that). This is for when a topic comes up — like TCP, async/await internals, or Docker namespaces — and you want a permanent note that explains it.

## When to Use This Skill

Use `/deep-dive <topic>` when:
- A concept came up during building and you want to understand it properly (e.g., "what actually is a socket?")
- Claude explained something and you want a permanent reference you can revisit
- You keep running into a term or idea and want it written down clearly
- `/reflect` suggested a deep-dive topic after a milestone

**You can run it anytime** — mid-session, after a milestone, between sessions. It doesn't have to be at the end.

**What counts as a topic?** Anything that's a *concept*, not a *task*:
- Good: `/deep-dive tcp`, `/deep-dive async-io`, `/deep-dive docker-networking`
- Not a deep-dive: "how I built the HTTP parser" (that's a `/reflect`)

## Arguments

The topic name, which maps to a file in `deep-dives/`. The file grows over time — each time you run `/deep-dive networking`, a new section gets appended.

Examples:
- `/deep-dive networking` — after learning about TCP and sockets
- `/deep-dive concurrency` — after hitting async/await questions
- `/deep-dive database-internals` — after discovering how indexes work

## Behavior

1. **Check for existing file** at `deep-dives/<topic>.md`
   - If it exists, read it and append a new section (don't overwrite previous content)
   - If it doesn't exist, create it with the template below

2. **Use conversation context** to identify what concepts were just discussed or encountered

3. **Write the deep-dive** using this structure:

```markdown
## <Concept Name>
*Added: <date> | Source: Project <N>, Milestone <M>*

### What Is It?
One paragraph in plain language. No jargon without defining it.

### Why Does It Matter?
How this affects your work. Connect to ASP.NET Core, React, SQL Server, or Azure where relevant.

### How It Works
The mechanics. Include a code snippet, ASCII diagram, or analogy.
Go one layer deeper than the surface explanation.

> **Watch out:** Common mistakes or gotchas related to this concept.

### Key Mental Model
One sentence or image that makes this click. What would you tell a colleague?
```

4. **After writing**, confirm what was added and suggest related topics to explore next

## Important
- Write in second person ("you") — these are notes for the user
- Keep it practical, not academic
- **Lead every section with a plain English sentence before any technical detail**
- **Use analogies** — compare to things the user already knows (ASP.NET Core, SQL Server, C#)
- **Define jargon inline** the first time it appears
- Always connect back to the user's existing stack knowledge
- If the topic was covered in conversation, reference specific code or examples from the session
- For small concepts, the whole deep-dive can be 10-15 lines. Don't pad it.
- "Common Pitfalls" and "Connection to Your Stack" are not separate sections — weave them into the sections above

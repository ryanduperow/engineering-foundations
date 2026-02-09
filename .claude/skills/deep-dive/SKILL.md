---
name: deep-dive
description: After a build or learning session, generates a structured deep-dive document about a concept into the deep-dives/ folder. Use when you've encountered a new concept and want to solidify understanding.
---

# Deep Dive

Generate a structured deep-dive document about a concept you encountered while building.

## When to Use This Skill

Use `/deep-dive <topic>` when:
- You've just worked through a concept while building (networking, concurrency, etc.)
- You want to capture your understanding before it fades
- Claude explained something and you want a permanent reference

## Arguments

The first argument is the topic name, which maps to a file in `deep-dives/`.

Examples:
- `/deep-dive networking`
- `/deep-dive concurrency`
- `/deep-dive database-internals`

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
One paragraph explanation in plain language. No jargon without defining it.

### Why Does It Matter?
How this concept affects your work. Connect to ASP.NET Core, React, SQL Server, or Azure where relevant.

### How It Works
The mechanics. Include diagrams (ASCII), code snippets, or analogies. Go one layer deeper than the surface explanation.

### Key Mental Model
The one sentence or image that makes this concept click. What would you tell a colleague?

### Common Pitfalls
What goes wrong if you don't understand this. Real-world bugs or mistakes this knowledge prevents.

### Connection to Your Stack
How this shows up in your daily work with ASP.NET Core, C#, SQL Server, React, or Azure.
```

4. **After writing**, confirm what was added and suggest related topics to explore next

## Important
- Write in second person ("you") — these are notes for the user
- Keep it practical, not academic
- Always connect back to the user's existing stack knowledge
- If the topic was covered in conversation, reference specific code or examples from the session

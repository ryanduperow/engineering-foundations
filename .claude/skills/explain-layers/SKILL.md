---
name: explain-layers
description: Explains code at 4 progressively deeper layers — what it does, how it works, why it's designed that way, and what's happening at the OS/network/memory level. Designed to build the mental models that bootcamps skip.
---

# Explain Layers

Explain code at 4 depths to build foundational understanding.

## When to Use This Skill

Use `/explain-layers` when:
- You wrote code (or Claude generated code) and want to understand it deeply
- You're reading unfamiliar code and want to learn from it
- You want to understand what's happening beneath an abstraction

## Arguments

Pass a file path, code snippet reference, or describe what to explain.

Examples:
- `/explain-layers src/Server.cs` — explain a specific file
- `/explain-layers the async handler we just wrote` — reference recent work
- `/explain-layers HttpClient` — explain a framework concept

## Behavior

For the given code or concept, explain it at 4 layers:

### Layer 1: What
*What does this code do?*
- Plain English description of behavior
- Inputs, outputs, side effects
- A non-developer could understand this level

### Layer 2: How
*How does it work mechanically?*
- Step through the execution flow
- Key data structures and algorithms involved
- Control flow, error paths, edge cases
- What each significant line/block contributes

### Layer 3: Why
*Why is it designed this way?*
- Design decisions and their tradeoffs
- What alternatives exist and why this approach was chosen
- What design patterns are in play (name them)
- What would break or degrade if designed differently

### Layer 4: Under the Hood
*What's happening at the OS/network/memory level?*
- What system calls are being made
- What's happening in memory (stack, heap, allocations)
- Network activity (if applicable): packets, connections, handshakes
- How the .NET runtime, OS, or hardware handles this
- Performance implications at this level

## Important
- **Start each layer with one plain sentence** — no jargon in the opening line
- **Define technical terms inline** the first time they appear
- **Keep each layer to 3-5 bullet points** unless the user asks for more
- Connect every layer to the user's existing knowledge (ASP.NET Core, C#, SQL Server)
- Use concrete examples and analogies, not abstract descriptions
- Format with clear headers so it's easy to scan and reference later
- **Adapt depth to complexity:**
  - For simple code: combine Layers 1-2 into a quick summary, keep Layer 4 to one sentence or skip it
  - For complex code (I/O, networking, concurrency): go deep on all 4 layers
  - A 10-line explanation of simple code is better than a forced 4-layer essay
  - Ask: "Would Layer 4 help the user debug a problem?" If not, keep it brief.

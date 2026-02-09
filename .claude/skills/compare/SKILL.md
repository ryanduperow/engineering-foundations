---
name: compare
description: Side-by-side comparison of two related technical concepts. Outputs structured comparison with similarities, differences, when to use each, and common misconceptions. Use when you encounter two things that seem similar but different.
---

# Compare

Generate a structured comparison between two related concepts.

## When to Use This Skill

Use `/compare <concept-a> <concept-b>` when:
- Two concepts seem similar and you want to understand the difference
- You need to choose between two approaches
- You keep mixing up two related things

## Arguments

Two concepts to compare, separated by a space or "vs".

Examples:
- `/compare threads tasks`
- `/compare "SQL Server" PostgreSQL`
- `/compare "async/await" "Task.Run"`
- `/compare "integration tests" "unit tests"`
- `/compare REST GraphQL`

## Behavior

Generate a comparison using this structure:

```markdown
# <Concept A> vs <Concept B>

## One-Sentence Summary
What's the essential difference in one sentence.

## Quick Reference

| Aspect | <Concept A> | <Concept B> |
|--------|-------------|-------------|
| What it is | ... | ... |
| Best for | ... | ... |
| Avoid when | ... | ... |
| Used in your stack | ... | ... |

## How They're Similar
- Bullet list of shared characteristics

## How They're Different
The key differences, explained with examples. Not just a list — explain WHY they differ.

## When to Use Each
Concrete decision criteria. "Use A when... Use B when..."

## Common Misconceptions
Things people (including you) often get wrong about these two concepts.

## In Your Stack
How each shows up in ASP.NET Core, C#, React, SQL Server, or Azure. Concrete code examples if applicable.
```

## Important
- Always connect to the user's stack (ASP.NET Core, C#, SQL Server, React, Azure)
- Use concrete code examples, not abstract descriptions
- Be opinionated — give a recommendation when there's a clear winner for common cases
- Call out when the "right answer" is "it depends" and explain what it depends on
- Keep it practical — skip history and trivia unless it aids understanding

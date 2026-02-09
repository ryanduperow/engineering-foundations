---
name: reflect
description: Quick milestone reflection — captures what clicked, what was hard, and how you'd explain it. Run after completing a milestone. Takes under 2 minutes.
---

# Reflect

Write a short reflection after completing a milestone.

## When to Use This Skill

Use `/reflect` when:
- You just finished a project milestone and got something working
- You want to capture what you learned before moving on

## Arguments

Optional: milestone identifier (e.g., "M1", "Phase A"). If omitted, infer from conversation context or ask.

Examples:
- `/reflect` — auto-detect which milestone was just completed
- `/reflect M3` — reflect on milestone 3
- `/reflect Phase B` — reflect on a phase (for Project 3)

## Behavior

1. **Identify the project and milestone** from git status, conversation context, or the argument

2. **Ask the user 3 questions:**
   - What clicked for you in this milestone?
   - What was harder than expected?
   - If a coworker asked "what does [milestone topic] actually do?", what would you tell them in 2 sentences?

3. **Write the reflection** to `NN-project/notes/reflections.md` (append if file exists, create if not):

```markdown
## M<N>: <Milestone Title>
*Completed: <date>*

**What clicked:** <user's answer>

**What was hard:** <user's answer>

**In my own words:** <user's 2-sentence explanation>
```

4. **Suggest a `/deep-dive`** if the milestone touched a concept not yet captured in `deep-dives/`

## Important
- Keep it SHORT. 3 fields, not 6. This should take under 2 minutes.
- Write in first person — these are the user's words, not Claude's explanation.
- Don't editorialize or expand on the user's answers. Capture them as-is.
- If the user gives a brief answer, that's fine. Don't push for more.
- For Project 3 (URL Shortener), reflect per-phase (A, B, C, D), not per-checkbox item.

---
name: resume-learning
description: Start a learning session by picking up where you left off. Reads your latest checkpoint and project progress, then tells you where you are and what's next.
---

# Resume Learning

Pick up where you left off.

## When to Use This Skill

Use `/resume-learning` at the **start of a session** — before you start building.

## Behavior

1. **Find the active project** by scanning project READMEs for milestones that are partially complete (some checked, some not). If all projects are "Not Started", suggest starting with Project 1 M1.

2. **Read the latest learning log** at `NN-project/notes/learning-log.md` (the most recent session entry). If no log exists, skip this step.

3. **Read the latest reflections** at `NN-project/notes/reflections.md` (the most recent entry). If none exist, skip this step.

4. **Summarize in this format:**

```
**Project:** <name>
**Last session:** <date from learning log>
**Completed:** M1, M2, M3
**Next up:** M4 — <milestone description>

**Where you left off:**
- <1-2 bullets from "What's Next" in the learning log>

**Open questions from last time:**
- <any questions listed in the learning log>
```

5. **Ask:** "Ready to start M<N>, or want to do something else?"

## Important
- This is **read-only** — don't modify any files
- Keep the summary short — 10 lines max
- If there's no learning log yet (first session ever), just show which milestone to start and skip the "where you left off" section
- If multiple projects have progress, ask which one to continue

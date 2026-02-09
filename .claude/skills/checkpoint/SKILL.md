---
name: checkpoint
description: End-of-session progress snapshot. Updates project README milestone status, summarizes what was learned, and appends to a learning log. Use at the end of a work session to track progress.
---

# Checkpoint

Capture progress at the end of a learning/build session.

## When to Use This Skill

Use `/checkpoint` when:
- You're wrapping up a work session
- You've completed a milestone or made significant progress
- You want to record what you learned before closing the session

## Behavior

1. **Identify the current project** by looking at what files were modified in this session (check git status or conversation context)

2. **Update the project README** (`NN-project-name/README.md`):
   - Check off completed milestones (change `- [ ]` to `- [x]`)
   - Only check items that are genuinely complete

3. **Update the root README** (`README.md`):
   - Update the project status (Not Started → In Progress → Complete)

4. **Create or append to the learning log** (`NN-project-name/notes/learning-log.md`):

```markdown
## Session: <date>

### What I Built
- Bullet list of what was accomplished this session

### What I Learned
- Key concepts encountered (link to deep-dives if they exist)
- "Aha moments" or things that clicked

### What's Next
- Next milestone to tackle
- Questions to explore in the next session

### Time Spent
- Approximate hours
```

5. **Summarize** to the user: what was checked off, what was logged, and suggest what to tackle next time

## Important
- Don't inflate progress — only check off milestones that are truly done
- Keep learning log entries concise — 3-5 bullets per section
- If no deep-dive notes were written during the session, suggest topics that should be captured

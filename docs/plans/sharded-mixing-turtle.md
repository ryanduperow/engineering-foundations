# Plan: Improve Learning Loop — Reflections, Simpler Skills, Better README

## Context
User tried Project 1 and found: (1) no mechanism to reflect after milestones, (2) explanations could be simpler, (3) unclear how skills fit together, (4) README doesn't explain the workflow well enough. All projects are still at "Not Started" — good time to fix the scaffolding.

## Changes

### 1. New `/reflect` skill — `.claude/skills/reflect/SKILL.md`
- Short milestone reflection (under 2 minutes)
- Asks 3 simple questions: what clicked, what was hard, explain it in your own words
- Writes to `NN-project/notes/reflections.md` (append per milestone)
- Suggests a `/deep-dive` if the milestone touched an unwritten concept

### 2. Simplify `/deep-dive` template
- Merge "Common Pitfalls" into "How It Works" as a `> Watch out:` callout
- Merge "Connection to Your Stack" into "Why Does It Matter?"
- 6 sections → 4 sections
- Add rule: "For small concepts, 10-15 lines is fine. Don't pad."

### 3. Add adaptive guidance to `/explain-layers`
- Add to Important section: combine Layers 1-2 for simple code, skip Layer 4 if nothing interesting at OS level
- Keep 4-layer structure as the max, not the minimum
- Already has "if simple, Layer 4 can be brief" on line 62 — expand on this

### 4. Update `/checkpoint` to suggest `/reflect`
- Add step: if milestones were completed this session, prompt "Want to `/reflect` on M<N> before wrapping up?"
- Don't auto-run — just suggest

### 5. Update `/new-project` template
- Add `> After each milestone, run /reflect` hint to the generated README template

### 6. Rewrite root `README.md` skills section
- Replace duplicated skills info (lines 18-31 prose + lines 67-74 table) with one clear reference
- Simplify "The Loop" to 4 steps: Build → Go deep → Capture → Checkpoint
- Add "Skills — When to Use Each" table grouped by *moment* (not alphabetically)
- Add reflections to "What Goes Where" table
- Simplify "The Key Rule" to include reflections alongside deep-dives

### 7. Add `/reflect` hint to all 4 project READMEs
- One line after Milestones section: `> After completing each milestone, run /reflect`

## Files to modify
| File | Change |
|------|--------|
| `.claude/skills/reflect/SKILL.md` | **New** — milestone reflection skill |
| `.claude/skills/deep-dive/SKILL.md` | Simplify template 6→4 sections |
| `.claude/skills/explain-layers/SKILL.md` | Add adaptive depth guidance |
| `.claude/skills/checkpoint/SKILL.md` | Add reflect suggestion step |
| `.claude/skills/new-project/SKILL.md` | Add reflect hint to README template |
| `README.md` | Rewrite skills/loop section |
| `01-http-server/README.md` | Add reflect hint |
| `02-deploy-to-mac/README.md` | Add reflect hint |
| `03-url-shortener/README.md` | Add reflect hint |
| `04-ai-assistant/README.md` | Add reflect hint |

## Verification
- Run each skill command to confirm formatting and output
- Check that `/checkpoint` suggests `/reflect` when milestones are marked done
- Confirm README reads clearly end-to-end

## Resolved
- Project 3: reflect per-phase (A, B, C, D), not per-checkbox
- Reflect format: 3 guided questions (what clicked, what was hard, explain in your own words)

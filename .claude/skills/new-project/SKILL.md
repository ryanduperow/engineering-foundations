---
name: new-project
description: Scaffolds a new project into the engineering-foundations curriculum. Creates folder structure, README with milestones and learning triggers, and updates the root progress tracker. Use when you want to add a new learning project.
---

# New Project

Add a new project to the engineering foundations curriculum.

## When to Use This Skill

Use `/new-project <name>` when:
- You have a product idea that would teach you new concepts
- You want to explore a topic area not covered by existing projects
- You finished the existing projects and want to keep going

## Arguments

The project name (kebab-case).

Examples:
- `/new-project real-time-chat`
- `/new-project personal-blog`
- `/new-project cli-task-runner`

## Behavior

1. **Determine the next project number** by reading the root directory for existing `NN-*` folders

2. **Ask the user** (using AskUserQuestion or conversation):
   - What do you want to build? (brief description)
   - What fundamentals do you want this project to target? (suggest options based on what deep-dives/ already covers vs gaps)

3. **Create the folder structure:**
   ```
   NN-<project-name>/
     src/
     notes/
     README.md
   ```
   Add `tests/` and `infra/` folders if the project scope warrants them.

4. **Generate the project README** following the same format as existing projects:

   ```markdown
   # Project <N>: <Project Title>

   <One sentence description>

   ## Why This Project
   What concepts this forces you through. Why it's worth building.

   ## Milestones
   - [ ] **M1:** ...
   - [ ] **M2:** ...
   (4-8 milestones, progressively more complex)

   > After completing each milestone, run `/reflect` to capture a quick reflection.

   ## Learning Triggers
   | Trigger | Concepts |
   |---------|----------|
   | "question to ask Claude Code" | concept areas |

   ## Deep Dives to Write
   - `deep-dives/<topic>.md` — description

   ## Reference
   - Relevant books/resources from bookshelf.md or new ones
   ```

5. **Update the root README.md** — add a new row to the Progress table

6. **Confirm** what was created and suggest which milestone to start with

## Important
- Milestones should be small enough to complete in 1-2 sessions
- Each project should force the user into at least 2-3 concepts they don't already know
- Connect learning triggers to concepts from the existing deep-dives/ when possible
- Don't duplicate what existing projects already cover — build on top of them
- Keep the scope realistic — 4-8 week projects, not 6-month moonshots

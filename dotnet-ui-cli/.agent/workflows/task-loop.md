---
id: task-loop
kind: workflow
version: 1
appliesTo: [all]
invokes: [task-planner]
requires: []
binding: [one-task-in-flight, never-weaken, evidence-before-done, autonomy-boundary, emit-do-not-creep]
---

# task-loop — the outer loop

The single entry point. Every session starts here. Every other workflow is reached
by routing from SELECT.

## ORIENT — every session, in order

1. `RUN python3 .agent/tools/harness.py doctor` — contract valid, tools present, no drift
2. `RUN python3 .agent/tools/harness.py verify` — control plane matches HARNESS-LOCK.json
3. `READ_FILE .agent/PROJECT-STATE.md` — phase, open decisions, blockers
4. `READ_FILE .agent/DECISIONS-REQUIRED.md` — anything a human has now answered
5. `READ_FILE .agent/project-context.md` — architecture, conventions, boundaries
6. `RUN python3 .agent/tools/task.py status`

If `doctor` reports drift or `verify` reports a control-plane mismatch, **stop and
tell the user.** Working against a stale contract produces work that has to be redone.

## PHASE — bootstrap or steady state

If `PROJECT-STATE.md` has no frozen roadmap, run `project-bootstrap`, which ends at
**CHECKPOINT 1 (human): roadmap scope approval**. Otherwise continue to SELECT.

## SELECT

`RUN python3 .agent/tools/task.py next`

Picks the first ready task whose dependencies are done and which no parked decision
blocks. Read its output carefully — "nothing eligible" has four distinct causes:

| Cause | Response |
|---|---|
| waiting on dependencies | work the dependency instead |
| deadlocked behind a blocked task | run `escalation`, or park the blocker |
| async gates pending | `harness.py gate poll`; meanwhile take unaffected work |
| backlog only | promote or `defer <id> "<reason>"` each item, then `milestone` |

If **every** remaining task is blocked by a parked decision → **CHECKPOINT 2**.

## ROUTE — pick the workflow for this task type

| Task type | Workflow |
|---|---|
| new capability | `feature` |
| defect | `bugfix` |
| structure change, no behaviour change | `refactor` |
| public signature change | `api-change` |
| vulnerability, authz, secrets, crypto | `security` |
| latency, memory, bundle, throughput | `performance` |
| package or framework version bump | `dependency-upgrade` |
| adding tests to untested code | `test-backfill` |
| wizard, prompt or terminal rendering change | `wizard-change` (plus the base workflow) |
| any `src/**` change | `cli-change-verification` (inside the base workflow) |
| production failure | `incident` |

The task file's `## What` states the type. If it does not, the task was not specced —
go back to SPEC.

## EXECUTE

The routed workflow runs. All of them share three guardrails, which the workflow
restates because they are the ones that get skipped:

1. **Consult sources before implementing.** Cite the deciding rank
   (`references/oracles.md`). Never invent framework behaviour from memory.
2. **Derive tests from the specification, before implementing.** A test written after
   the code tests the code, not the requirement.
3. **One change set.** Follow-up work becomes a new task, never scope creep.

## CLOSE

`RUN python3 .agent/tools/harness.py gate run --lane inner --scope diff`

| Result | Next |
|---|---|
| all pass | definition-of-done checklist |
| fail, attempts < 3 | bounded retry — a **substantively different** hypothesis |
| fail, attempts = 3 | `escalation` once, then block the task with evidence |

Then `checklists/definition-of-done.md`. Unsatisfied → back to EXECUTE, not forward.

## COMMIT and INTEGRATE

Commit, `task.py done`, update `PROJECT-STATE.md`. Then run the outer lane —
synchronously if it is fast, or `gate submit` + `task.py verify-submit` if it is not,
which frees the loop to take independent work while it runs.

## EMIT

File discovered work as **new task files**: `task.py add "..." --needs T-current`.
Never widen the current task. This is the step that keeps change sets reviewable.

## NEXT

Back to SELECT. When the roadmap is exhausted → `milestone`, then `release`, which
ends at **CHECKPOINT 3 (human): GO / NO-GO**.

## Loop invariants

- One task in flight (`maxActive`); `verifying` tasks do not count
- A task reaches `done` only with passing evidence at the current commit
- `NOT RUN` is never `PASS` — an unrun gate makes the verdict `partial`, which blocks
- Never block the whole project on one question — park it and take the next task

---
id: milestone
kind: workflow
version: 1
appliesTo: [all]
invokes: [task-planner, release-manager]
requires: []
binding: [evidence-before-done, not-run-is-not-pass]
---

# milestone — a phase completes

Runs when the ready queue empties. **No human sign-off** — write the report and
advance. Per-phase approval reintroduces the bottleneck the harness removes.

## 1. VERIFY AT FULL SCOPE

```bash
python3 .agent/tools/harness.py gate run --lane all --scope full
python3 .agent/tools/harness.py doctor
python3 .agent/tools/harness.py verify
python3 .agent/tools/task.py doctor
```

Diff-scoped gates passing per task does not mean the project is green. Composition
failures only show up at full scope, and this is the only place they are caught.

## 2. ACCOUNT FOR EVERY TASK

Each must be `done`, or `blocked` with a reason, or `deferred` with a reason. **An
unevaluated backlog is not a completed phase** — `task.py defer <id> "<reason>"` is a
decision and takes one.

## 3. RECORD THE NOT-RUN LIST

Every gate that did not run, and why. `NOT RUN` is never `PASS`; carry each as a
release blocker until it runs or is deliberately waived by a named human.

A phase report claiming success while three gates never executed is the failure mode
this section exists to prevent.

## 4. WRITE THE REPORT — `templates/milestone-report.md`

Delivered · not delivered and why · blocked, with what would unblock · deferred, with
rationale · **gate results including the not-run list** · tier and whether it moved ·
ratchet proposals · decisions made · decisions parked · harness changes.

## 5. RATCHET

`harness.py ratchet` — a phase boundary is the natural point to convert achieved
quality into enforced quality.

## 6. ADVANCE

Update `PROJECT-STATE.md` with the new phase and continue to SELECT. If the roadmap
is exhausted → `release`.

## Definition of done

- [ ] Full-scope gates run and recorded, including the not-run list
- [ ] Every task accounted for: done, blocked, or deferred with a reason
- [ ] Report written
- [ ] Ratchet evaluated
- [ ] `PROJECT-STATE.md` reflects the new phase

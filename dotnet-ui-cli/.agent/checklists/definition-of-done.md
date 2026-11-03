---
id: definition-of-done
kind: checklist
version: 1
appliesTo: [all]
usedBy: [feature, bugfix, refactor, api-change, security, performance, test-backfill, dependency-upgrade, incident]
---

# Definition of done

Every box, every task. An unchecked box sends the task back to EXECUTE, not forward.
"Mostly done" is `active`.

## Specification
- [ ] `## What` states behaviour, scope boundary, and acceptance criteria
- [ ] Every acceptance criterion is checkable by a tool or a test
- [ ] Open questions recorded with an assumption, a pinning test, and a `PROJECT-STATE.md` entry

## Implementation
- [ ] Every `## Plan` subtask is ticked
- [ ] The diff does what `## What` says — and **nothing more**
- [ ] No path under **Boundaries** was modified
- [ ] Framework behaviour was looked up, not recalled; sources cited
- [ ] Complete files; no ellipsis, no "rest unchanged"

## Tests
- [ ] Every acceptance criterion has a test that names it
- [ ] Tests were derived from the spec, before implementation
- [ ] No test was deleted, skipped, or weakened
- [ ] Assertions can actually fail — no `NotNull`-only checks on meaningful values
- [ ] New flaky tests quarantined **and** filed as tasks

## Gates
- [ ] Inner lane passes at the current commit
- [ ] Outer lane passes, or is in `verifying` with a recorded job id
- [ ] **The not-run list is empty**, or each entry is recorded as a blocker
- [ ] Diff coverage meets the tier threshold
- [ ] No threshold, suppression, or exclusion was added to make a gate pass

## Review
- [ ] `code-reviewer` ran with the diff, spec, context, and gate evidence
- [ ] Every finding resolved, or filed as a task with its id in `## Review`
- [ ] Findings the reviewer marked `UNVERIFIED` are recorded as such

## Record
- [ ] `## Log` has decisions, dead ends, and the reasoning
- [ ] `PROJECT-STATE.md` updated
- [ ] `project-context.md` updated if architecture changed
- [ ] Discovered work filed as new tasks
- [ ] Commit message is conventional and describes user-visible effect

## Risk
- [ ] If a risk-gated path was touched, `--approved-by` records a named human
- [ ] No credential appears in source, tests, logs, task files, or commit messages

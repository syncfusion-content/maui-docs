---
id: bugfix
kind: workflow
version: 1
appliesTo: [all]
invokes: [test-engineer, implementer, code-reviewer, wizard-consistency-reviewer, generated-project-validator, package-integrity-auditor]
requires: [definition-of-done, pr-review]
binding: [reproduce-before-fix, tests-from-spec, never-weaken, root-cause-not-symptom, emit-do-not-creep, verify-generated-output, preserve-user-files, no-unrelated-change]
---

# bugfix — a defect

The one workflow with a hard ordering constraint: **the failing test comes first.**

## 1. REPRODUCE — `test-engineer`

Write a test that **fails for the reported reason**, and run it to watch it fail.

This is not optional and not reorderable. Without it you cannot distinguish "fixed"
from "no longer reproduces on my machine", and you have no regression guard. An agent
that skips this will report a fix it cannot demonstrate.

Record in `## Log`: the exact reproduction, the observed behaviour, the expected
behaviour, and the failing assertion.

If it will not reproduce: do not guess. Record what you tried, mark the task blocked,
and request the missing input (version, data, config, environment).

## 2. DIAGNOSE

Find the **root cause**, not the symptom. Record the causal chain in `## Log`.

Signals that you have the symptom, not the cause:

- the fix is a null check at the point of the crash
- the fix is a `try/catch` around the failing call
- you cannot explain why the bug appeared when it did
- the fix works but you cannot say which input class it covers

## 3. ASSESS BLAST RADIUS

Does the same cause exist elsewhere? Search for the pattern. Other instances become
**new tasks**, not additions to this one.

## 4. FIX — `implementer`

The smallest change that addresses the cause. A bugfix is not a refactor; if the code
needs restructuring, file a `refactor` task.

## 5. VERIFY

- The reproduction test now passes
- **Every other test still passes** — a bugfix that breaks a test is a trade, and the
  trade needs to be stated, not absorbed
- Inner and outer gates pass

## 6. REVIEW — `code-reviewer`

Reviewer must confirm the test actually fails without the fix. Reverting the source
change and watching the test go red is the cheapest way to check.

## Definition of done

- [ ] A test reproduces the defect and failed before the fix
- [ ] Root cause recorded in `## Log`, not just the symptom
- [ ] Blast radius assessed; other instances filed as tasks
- [ ] All gates pass at the current commit
- [ ] No test was weakened, skipped, or deleted to make it pass

---
id: test-backfill
kind: workflow
version: 1
appliesTo: [all]
invokes: [test-engineer, code-reviewer]
requires: [definition-of-done]
binding: [characterize-do-not-correct, never-weaken]
---

# test-backfill — adding tests to untested code

The workflow that moves a project from **L0 to L1**, and the prerequisite for
refactoring anything legacy.

## The defining rule

> **Characterize current behaviour. Do not correct it.**

A characterization test pins what the code *does today* — bugs, quirks, and all. If
you find a bug while writing one, you **pin the buggy behaviour** and file a separate
`bugfix` task.

This feels wrong and is correct. The test's job here is to make change safe, and you
cannot know a change is safe unless you know what the behaviour was. Fixing while
characterizing means you never had a baseline.

## 1. SCOPE

Backfill the code a real task needs to touch, not the whole module.

Priority order:

1. Code the current or next task will modify
2. Change hotspots — high churn means high defect density
3. Code on a risk-gated path (auth, payment, migrations, public API)
4. Everything else — usually never, and that is fine

An untested module nobody is changing is not a risk. Treat backfill as a means, not a
coverage-percentage exercise.

## 2. OBSERVE — `test-engineer`

Determine actual behaviour by **running the code**, not by reading it. Reading gives
you what the author intended; running gives you what ships.

Cover, for each unit: the happy path, boundaries, empty/null, error paths, and any
observable side effect (writes, calls, mutation of shared state).

## 3. PIN

Write assertions on **observed** output. Where a value is inscrutable — a serialised
blob, a rendered tree — an approval/snapshot test is legitimate here even where it
would not be elsewhere: it pins the shape without requiring you to understand it yet.

Name each test for the behaviour, not the method: `Rounds_HalfUp_At_Two_Decimals`
beats `TestRound2`.

## 4. RECORD SURPRISES

Anything that looks wrong goes in `## Log` and becomes a `bugfix` task. The test still
pins the current behaviour, with a comment naming the task:

```
// Pins current behaviour. This looks wrong — see T-042.
// Do not "fix" this test; fix the code under T-042, then update the pin.
```

That comment is what stops a future agent from "correcting" the test to match its
expectations and destroying the baseline.

## 5. VERIFY

- Tests pass against unmodified source
- **Mutation score on the backfilled code is meaningful** — characterization tests
  that assert nothing are the exact failure this workflow can produce at scale
- Diff coverage on the target module meets the tier threshold

## Definition of done

- [ ] Target scope justified by an actual task, hotspot, or risk path
- [ ] Behaviour determined by execution, not by reading
- [ ] Current behaviour pinned, including anything that looks wrong
- [ ] Surprises filed as separate `bugfix` tasks and referenced in comments
- [ ] Mutation score confirms the tests are sensitive
- [ ] Source unchanged — a diff on source means this was not a backfill

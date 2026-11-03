---
id: refactor
kind: workflow
version: 1
appliesTo: [all]
invokes: [implementer, code-reviewer, wizard-consistency-reviewer, generated-project-validator, package-integrity-auditor]
requires: [definition-of-done, pr-review]
binding: [no-behaviour-change, never-weaken, one-task-in-flight, design-system, verify-generated-output, preserve-user-files, no-unrelated-change]
---

# refactor — structure changes, behaviour does not

## The defining constraint

**A refactor that changes behaviour is not a refactor.** If behaviour must change,
that is a `feature` or a `bugfix`, and it gets specced as one.

The tests are the contract. They must pass **unchanged** before and after.

## 1. ESTABLISH THE BASELINE

Run the full suite and record the result in `## Log`.

**If the code being refactored is not covered, stop.** Refactoring untested code is
rewriting it and hoping. Run `test-backfill` first to add characterization tests that
pin current behaviour — whatever that behaviour is, bugs included.

This is the step that gets skipped, and it is the reason refactors break things.

## 2. STATE THE GOAL

In `## What`, one sentence on what improves, and how you would know:

| Goal | Observable |
|---|---|
| Remove duplication | N call sites collapse to one |
| Reduce coupling | dependency-cruiser / ArchUnit rule now passes |
| Improve testability | a seam exists where a test can substitute a dependency |
| Reduce complexity | cyclomatic complexity below threshold |
| Enable planned work | task T-XXX becomes possible |

"Make the code cleaner" is not a goal. If you cannot name the observable, the refactor
has no success condition and no stopping point.

## 3. TRANSFORM INCREMENTALLY — `implementer`

One transformation per commit. Run the tests after each. Never batch.

The value of a refactor branch is bisectability: when something breaks two weeks
later, one commit is the answer. A single "refactor auth module" commit throws that
away.

**Do not change tests.** A test that must change means behaviour changed — stop and
reclassify the task.

## 4. VERIFY

- Full suite green, **tests unmodified**
- `git diff` on test files is empty (or the change is whitespace only, and is stated)
- Public API unchanged — `api-change` workflow if not
- Performance not regressed if a budget exists
- The stated observable is now true

## 5. REVIEW — `code-reviewer`

Reviewer checks the test diff **first**. A non-empty test diff in a refactor is the
finding, before anything about the source.

## Definition of done

- [ ] Coverage existed before the change, or was added first via `test-backfill`
- [ ] Tests pass unmodified
- [ ] The stated observable is achieved
- [ ] Public API unchanged
- [ ] One transformation per commit

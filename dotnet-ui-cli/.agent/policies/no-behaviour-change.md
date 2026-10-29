---
id: no-behaviour-change
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [refactor, code-reviewer]
---

# no-behaviour-change — a refactor changes structure only

## Rule

During a `refactor`, tests pass **unmodified**. A non-empty diff on test files means behaviour changed, and the task must be reclassified.

## Why

'Refactor' is the most common label for a change that quietly alters behaviour, because the author believed the old behaviour was wrong. That may be true — but it is a bugfix, and it needs a spec and a reproduction test.

## Enforced by

The `refactor` workflow requires a clean test diff; the reviewer checks the test diff **first**.

## Violation

Reclassify as `feature` or `bugfix` and spec it. Or revert the behavioural part and keep the structural part.

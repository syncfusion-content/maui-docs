---
id: no-unrelated-change
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [code-reviewer]
---

# no-unrelated-change — preserve working behaviour, avoid churn

## Rule

Change only what the task requires. No drive-by refactors, no new dependency without a recorded reason, no second implementation of something that already exists (check Core and the other platform providers first). Existing working behaviour is preserved.

## Why

The five platforms share Core services deliberately. A parallel implementation in one platform recreates the inconsistency the wizard and catalog work removed.

## Enforced by

The reviewer compares the diff against `## What`. Any new `PackageReference` or `PackageVersion` is a risk-gated path and needs human approval.

## Violation

Revert the unrelated hunk and file it as its own task with `task.py add`.

---
id: preserve-user-files
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [e2e-workflows, area-package-operations, package-integrity-auditor]
---

# preserve-user-files — never destroy what the customer changed

## Rule

No add, remove or update operation may delete, overwrite or reorder content the customer authored. A failed or cancelled operation leaves the project exactly as it was.

## Why

Customers edit generated files. The manifest records SHA-256 hashes so the CLI can tell its output from theirs; weakening that check, or removing code by pattern match, destroys work.

## Enforced by

`e2e-workflows` edits a project file and a source file, runs add and remove, and asserts both are intact. `FileRollbackTests`, `UntrackedDuplicateNavigationMarker_BlocksRemovalWithoutDeletingCustomerCode` and the package-operations area gate guard the internals.

## Violation

Stop and restore the transactional path. Do not widen what an operation may delete.

---
id: characterize-do-not-correct
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [test-backfill]
---

# characterize-do-not-correct — pin current behaviour, bugs included

## Rule

When backfilling tests onto untested code, pin what the code **does today**, including behaviour that looks wrong. Surprises are filed as separate `bugfix` tasks and referenced in a comment on the pinning test.

## Why

The purpose of a characterization test is to make change safe, and that requires knowing what the behaviour was. Fixing while characterizing means there was never a baseline, so the refactor that follows is unguarded.

The comment matters: it stops a future agent 'correcting' the test to match its expectations.

## Enforced by

The `test-backfill` workflow requires an unchanged source diff — any source change means it was not a backfill.

## Violation

Revert the source change. Pin the current behaviour, file the bug separately.

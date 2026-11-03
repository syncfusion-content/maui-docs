---
id: one-task-in-flight
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [task.py next, task.py doctor]
---

# one-task-in-flight — finish, block, or verify before starting another

## Rule

At most `maxActive` tasks (default 1) may be `active`. Tasks in `verifying` do not count against this — that is the point of the async lane.

## Why

Concurrent edits on a shared working tree conflict, and interleaved change sets are unreviewable. The limit also makes failure attributable: when a gate breaks, one task caused it.

## Enforced by

`task.py next` refuses beyond `maxActive`; `task.py doctor` reports a violation.

## Violation

Finish the active task, block it with a reason, or submit it to the outer lane before picking up new work.

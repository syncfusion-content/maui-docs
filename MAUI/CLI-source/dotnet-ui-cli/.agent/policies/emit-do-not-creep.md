---
id: emit-do-not-creep
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [task-loop, task-planner, code-reviewer]
---

# emit-do-not-creep — discovered work becomes a new task

## Rule

Work discovered during implementation or review is filed as a new task with `task.py add`. It is never added to the task in flight.

## Why

Scope creep makes change sets unreviewable and gate results unattributable — when something breaks, nobody can say which part of a sprawling diff caused it.

It is also invisible to every gate: a diff that does more than its spec describes still passes coverage, lint, and tests.

## Enforced by

The reviewer checks the diff against `## What` and flags anything the spec does not describe.

## Violation

File the extra work as a task and revert it from this change set.

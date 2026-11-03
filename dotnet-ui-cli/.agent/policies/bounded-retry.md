---
id: bounded-retry
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [escalation, implementer]
---

# bounded-retry — three substantively different attempts, then escalate

## Rule

On gate failure: at most three attempts, each a **substantively different hypothesis**. Then run `escalation` once and block the task with evidence.

## Why

Past three genuinely different ideas, further attempts are usually variations, and the loop is burning budget rather than making progress. Escalating cleanly and moving to the next task is a better outcome than an hour of spinning.

'Substantively different' is the load-bearing constraint — three tweaks of one idea is one attempt.

## Enforced by

The `escalation` workflow requires the three hypotheses to be stated and distinct; `task.py` records attempts in the journal.

## Violation

Escalate. Blocking a task with good evidence is a success condition, not a failure.

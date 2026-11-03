---
id: evidence-before-done
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [task.py done, harness.py gate run]
---

# evidence-before-done — a task is done when tools say so

## Rule

A task reaches `done` only when `.agent/evidence/<TASK>/gate-summary.json` has verdict `pass` **and** its recorded commit matches HEAD.

## Why

An agent's report that work is complete is an assertion. The evidence file is a measurement. The commit match matters as much as the verdict: without it an agent can run gates early and keep committing.

## Enforced by

`task.py done` refuses and exits 2. `--override` requires a reason and is journalled.

## Violation

Run the gates. If they fail, fix the cause. `--override` is for a genuine tooling outage, not for a real failure.

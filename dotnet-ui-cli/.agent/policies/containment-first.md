---
id: containment-first
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [incident]
---

# containment-first — stop the bleeding before diagnosing

## Rule

During an incident, containment precedes diagnosis. Evidence is preserved before any restart. Exposed credentials are rotated immediately.

## Why

An agent's instinct is to understand before acting. During a live incident that ordering costs user impact for every minute it takes.

Evidence preservation is the counterpart: a restart usually destroys the state that explains the failure, and it is the second thing reached for after rollback.

## Enforced by

The `incident` workflow orders it; rollback requires CHECKPOINT 3 because it is itself a production change with risk.

## Violation

Contain, then preserve, then diagnose. An incident that produces only a code fix and no harness change will recur.

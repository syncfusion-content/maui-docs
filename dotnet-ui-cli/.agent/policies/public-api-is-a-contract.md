---
id: public-api-is-a-contract
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [api-change, api-steward, api-baseline gate]
---

# public-api-is-a-contract — breaking changes need a human

## Rule

Any breaking or behavioural change to the public surface is a lane-3 park. The API baseline is updated in the **same commit** as the change.

## Why

Consumers depend on signatures and on semantics. Behavioural changes are the dangerous class because no tool flags them at the call site — the code still compiles and the behaviour is different.

A baseline updated in a separate commit drifts, and then it stops catching anything.

## Enforced by

The `api-baseline` gate (PublicApiAnalyzers, api-extractor, OpenAPI diff) blocks; `api-steward` classifies; `task.py done` halts on risk-gated API paths.

## Violation

Park the decision with an impact analysis and a recommendation. After approval, ship with a migration path and a deprecation period.

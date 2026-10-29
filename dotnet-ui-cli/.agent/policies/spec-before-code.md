---
id: spec-before-code
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [feature, api-change, code-reviewer]
---

# spec-before-code — write ## What before implementing

## Rule

No implementation begins before `## What` states the behaviour, the scope boundary, and acceptance criteria that a tool or a test can check.

## Why

Without acceptance criteria, there is nothing for a gate to verify against and nothing for a reviewer to check conformance to. 'Done' becomes whatever the implementer decided it meant.

The scope boundary matters as much as the criteria — it is what makes scope creep visible.

## Enforced by

The `feature` and `api-change` workflows require it; the reviewer checks conformance and flags anything the diff does that the spec does not describe.

## Violation

Return to SPEC. A trivial task still needs one sentence, but 'trivial' is a judgement the spec makes explicit rather than assumes.

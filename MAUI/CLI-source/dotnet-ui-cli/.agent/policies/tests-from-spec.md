---
id: tests-from-spec
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [feature, bugfix, security, test-engineer]
---

# tests-from-spec — derive tests from the specification, before implementing

## Rule

Tests are written from the specification, before the implementation exists. Each test names the acceptance criterion it covers.

## Why

A test written after the code encodes what the code does, and passes whether or not the code is right. Reversing the order is not ceremony — it is the difference between testing the requirement and testing the implementation.

## Enforced by

The `feature`, `bugfix`, and `security` workflows order it explicitly. `bugfix` and `security` additionally require the test to be observed **failing** first.

## Violation

Write the test, watch it fail, then implement. If the test passes before implementation, it is testing the wrong thing.

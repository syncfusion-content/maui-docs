---
id: matched-versions
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [dependency-upgrade, version-consistency gate]
---

# matched-versions — related packages move together

## Rule

Packages that ship as a matched set are upgraded together, on one version, across every project in the solution or workspace.

## Why

Mixed versions of a matched set produce runtime failures that present as application bugs — `MissingMethodException`, missing exports, rendering faults — and cost days to diagnose because the symptom is nowhere near the cause.

This applies to Syncfusion packages, Angular packages, the .NET SDK and its analyzers, and any framework shipping multiple coordinated artifacts.

## Enforced by

The `version-consistency` gate blocks; Central Package Management or an npm `overrides` block prevents recurrence.

## Violation

Align the versions. Adopt central version management so the class cannot recur.

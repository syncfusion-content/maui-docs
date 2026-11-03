---
id: measure-before-optimising
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [performance, performance-analyst]
---

# measure-before-optimising — no optimisation without numbers

## Rule

Every performance change is preceded by a recorded baseline and followed by a confirming measurement, taken the same way.

## Why

An agent asked to make something faster will produce plausible changes with no effect, or a regression. Both are indistinguishable from success without numbers — and the code is less readable either way.

A measurement includes the workload, the environment, the run count, and the variance. A single run is not a measurement.

## Enforced by

The `performance` workflow requires baseline and confirmation in `## Log`; budget gates guard the result afterwards.

## Violation

Measure first. An unmeasured optimisation is reverted, not merged.

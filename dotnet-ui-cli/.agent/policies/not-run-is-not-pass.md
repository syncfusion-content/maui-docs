---
id: not-run-is-not-pass
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [harness.py gate run, milestone, release]
---

# not-run-is-not-pass — an unrun gate is not a passing gate

## Rule

A gate that did not run is recorded as `NOT RUN`. It is never `PASS`, never omitted, and never inferred from other gates. Any not-run gate makes the overall verdict `partial`, which blocks completion.

## Why

The most comfortable lie a quality system can tell is silence about what it did not check. A summary saying '12/12 passed' while four gates never executed reads as stronger evidence than '12/16 ran, 12 passed' — and is worth much less.

## Enforced by

`gate-summary.json` carries `gatesNotRun`; the verdict becomes `partial` and `task.py done` refuses. `milestone` and `release` print the not-run list explicitly.

## Violation

Run the gate. If it cannot run in this environment, a named human waives it in writing and the waiver is recorded — it does not silently become a pass.

---
id: root-cause-not-symptom
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [bugfix, code-reviewer]
---

# root-cause-not-symptom — fix the cause

## Rule

A defect fix addresses the cause. The causal chain is recorded in `## Log`.

## Why

Symptom fixes accumulate. Each one makes the next defect harder to diagnose because the code now contains defensive scar tissue whose purpose nobody remembers.

Signals you have the symptom: the fix is a null check at the crash site; the fix is a try/catch around the failing call; you cannot explain why the bug appeared when it did.

## Enforced by

The `bugfix` workflow requires the causal chain; the reviewer checks it is present and plausible.

## Violation

Diagnose further. If the cause is out of scope, fix the symptom deliberately, say so in `## Log`, and file the cause as a task.

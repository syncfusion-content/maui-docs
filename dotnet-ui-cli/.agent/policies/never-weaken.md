---
id: never-weaken
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [ratchet-floor, harness-verify, check-suppressions, code-reviewer, mutation-gate]
---

# never-weaken — do not weaken a gate to pass it

## Rule

**Never disable, weaken, skip, narrow, or delete a test, gate, assertion, threshold, or policy in order to make a gate pass.**

This covers: lowering a threshold in `harness.yaml`; adding `[ExcludeFromCodeCoverage]`, `# pragma: no cover`, or `istanbul ignore`; adding `eslint-disable`, `#pragma warning disable`, or `@ts-ignore` without a written justification; deleting, skipping, or `[Ignore]`-ing a test; weakening an assertion to something that cannot fail; marking a surviving mutant as equivalent.

## Why

This is the cheapest available path for an agent instructed to make things green, so it is the one that will be taken by default. Every other guarantee in the harness rests on this rule holding.

A gate that can be adjusted by the thing it measures is not a gate.

## Enforced by

- Thresholds: ratchet floor in `harness.lock`; `harness.py validate` fails in CI
- Control plane: SHA-256 in `HARNESS-LOCK.json`; `harness.py verify` fails in the gate
- Tests: the mutation gate; the reviewer inspects the diff for removals and skips
- Suppressions: `check-suppressions.sh` requires a written justification
- Overrides: `--override` requires a reason, written to `journal.jsonl`

## Violation

Revert the weakening. If the gate is genuinely wrong, say so in `## Log` and report BLOCKED. Changing a gate is a task with a human in the loop, never a side effect of another task.

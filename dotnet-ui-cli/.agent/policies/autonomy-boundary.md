---
id: autonomy-boundary
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [task.py done, DECISIONS-REQUIRED.md, escalation]
---

# autonomy-boundary — what the agent may decide alone

## Rule

Decisions fall in three lanes: **decide alone** (reversible and local), **assume-pin-record** (sources silent, reversal costs one change), **park for a human** (scope, irreversible public API, licensing, weakening security, budget regression).

**Prime directive: never block the whole project on one question.** Park it, mark the affected tasks blocked, take the next ready task.

## Why

Without a boundary you get an agent that asks about everything, or one that quietly makes an irreversible product decision unattended. Both destroy trust in the loop.

The prime directive matters because a single unanswered question otherwise stalls an overnight run that could have completed nine other tasks.

## Enforced by

`task.py done` halts on risk-gated paths and requires `--approved-by`. Lane-2 assumptions require a pinning test. Lane-3 parks require an entry in `DECISIONS-REQUIRED.md` **with a recommendation**.

## Violation

See `references/autonomy-boundary.md`. A park with no recommendation is incomplete — it hands all the analysis back to the human.

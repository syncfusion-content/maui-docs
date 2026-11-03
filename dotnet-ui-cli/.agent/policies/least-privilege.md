---
id: least-privilege
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [security, security-auditor, code-reviewer, sast]
---

# least-privilege — grant the minimum, and never widen to make something work

## Rule

Every permission, scope, role, network rule, and file mode is the narrowest that lets
the operation succeed.

**Never widen access to make something work, reproduce an issue, or unblock a test.**
Widening a permission is a lane-3 decision — park it for a human.

This covers: adding a broad role instead of a specific claim; making a member public
to reach it from a test; disabling certificate validation "temporarily"; broadening
CORS to `*`; opening a network rule to `0.0.0.0/0`; running a container as root;
granting a service account admin because the specific permission was unclear.

## Why

Widened access is permanent in practice. It is added under time pressure with a
comment saying *temporary*, and nothing ever triggers its removal — there is no test
that fails because a permission is too broad.

The agent-specific risk is sharper: when a task is blocked by a permission error, the
fastest path to green is to remove the restriction. That path must be closed
explicitly, because it looks like progress.

## Enforced by

- The `security` workflow requires reproduction at the narrowest privilege that shows
  the issue
- `security-auditor` classifies any proposed weakening as a lane-3 park
- SAST rules cover the mechanical cases: disabled certificate validation, wildcard
  CORS, over-permissive policies
- The reviewer checks the diff for widened modifiers, roles, and scopes
- `checklists/security-review.md` asks the question directly

## Violation

Revert the widening. Find the specific permission the operation actually needs. If it
genuinely requires broader access, park it with the justification — the trade is a
human's to make, and it should be recorded where someone can revisit it.

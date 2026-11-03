---
id: security
kind: workflow
version: 1
appliesTo: [all]
invokes: [security-auditor, implementer, test-engineer, code-reviewer]
requires: [security-review, definition-of-done]
binding: [no-secrets-in-source, least-privilege, never-weaken, autonomy-boundary, reproduce-before-fix]
---

# security — vulnerability, authz, secrets, crypto

## Handling constraints, before anything else

- **Never commit, echo, log, or paste a real credential, token, or key** — not in a
  task file, not in `## Log`, not in a test fixture, not in a commit message.
- **Never widen access to reproduce an issue.** Reproduce with the narrowest
  privilege that shows the problem.
- If the finding is a live exploitable vulnerability in production, run `incident`
  first — containment precedes root-cause work.

## 1. CLASSIFY — `security-auditor`

| Class | Meaning | Response |
|---|---|---|
| **Exploitable now** | reachable from untrusted input in a deployed environment | `incident` first, then this workflow |
| **Latent** | the flaw exists but is not currently reachable | this workflow, prioritised |
| **Hardening** | no known flaw; reduces future risk | normal queue |
| **Dependency CVE** | in a package, not your code | `dependency-upgrade` unless you must patch around it |

## 2. ESTABLISH REACHABILITY

Trace the path from untrusted input to the vulnerable code. Record it in `## Log`.

Reachability is what separates a real finding from a scanner artifact, and stating it
is what makes the fix reviewable. "Semgrep flagged line 42" is not reachability.

## 3. WRITE THE FAILING SECURITY TEST — `test-engineer`

A test that demonstrates the flaw and fails before the fix. Same rule as `bugfix`,
and for the same reason: without it, "fixed" is an assertion.

For an injection or authz flaw the test asserts the attack **fails**, not merely that
the happy path works.

## 4. FIX — `implementer`

Fix the class, not the instance, where you can:

| Instance fix | Class fix |
|---|---|
| escape this query | parameterised queries enforced by an analyzer (CA2100 / CA3001) |
| add authz here | authorization required by default; opt out explicitly |
| validate this input | validation at the boundary, enforced by a schema |
| remove this secret | secret scanning in the gate + a secret store |

**Any weakening of a security control is a lane-3 decision — park it.** That includes
disabling certificate validation "temporarily", broadening CORS, and relaxing a
Content-Security-Policy.

## 5. VERIFY

- The security test passes; **revert the fix and confirm it fails again**
- SAST and secret-scanning gates pass
- No new permission, scope, or exposed surface was introduced
- `checklists/security-review.md` satisfied

## 6. SWEEP

Search for the same pattern elsewhere. Other instances are **new tasks**, filed
immediately — a vulnerability class fixed in one place and left in three is not fixed.

## Definition of done

- [ ] Reachability from untrusted input established and recorded
- [ ] A test demonstrates the flaw and fails without the fix
- [ ] Fixed at the class level where a mechanism exists
- [ ] SAST and secret gates pass
- [ ] Codebase swept for the same pattern; instances filed
- [ ] No secret in source, logs, tests, or task files

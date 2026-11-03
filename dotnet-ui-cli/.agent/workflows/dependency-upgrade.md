---
id: dependency-upgrade
kind: workflow
version: 1
appliesTo: [all]
invokes: [implementer, test-engineer, security-auditor, code-reviewer, package-integrity-auditor, generated-project-validator]
requires: [definition-of-done, pr-review]
binding: [autonomy-boundary, never-weaken, matched-versions, verify-generated-output, preserve-user-files, no-unrelated-change]
---

# dependency-upgrade — package or framework version change

Risk-gated: manifest files are on `requiresHumanApproval`, so this workflow ends at a
human regardless of gate status. A dependency change is never local.

## 1. CLASSIFY

| Class | Response |
|---|---|
| **Patch, security** | highest priority; usually mechanical |
| **Patch / minor, routine** | batch these; do not spend a task each |
| **Major** | its own task, with a migration plan |
| **Framework version** | its own task, plus a `milestone` — this is a project event |
| **New dependency** | **lane-3 decision, park it** — see below |

## 2. NEW DEPENDENCIES ARE A HUMAN DECISION

Adding a dependency is a durable commitment. Park it with an analysis covering:
what it does, why the platform or an existing dependency cannot, **its licence**,
maintenance signals, transitive weight, and the cost of removing it later.

Licence is the part agents skip and legal cares about most.

## 3. READ THE CHANGELOG — do not infer

Read the release notes and migration guide for **every** intervening version, not
just the target. Record breaking changes affecting this codebase in `## Log`.

An agent inferring a migration from the new API surface will miss behavioural changes
entirely, and those are the ones that reach production.

## 4. UPGRADE

- **Matched sets move together.** Syncfusion packages, Angular packages, the .NET SDK
  and its analyzers — a partial upgrade produces failures that look like application
  bugs. The `version-consistency` gate enforces this.
- One dependency (or one matched set) per commit
- Update lock files in the same commit

## 5. VERIFY — the full suite, not the diff

The exception to diff-scoped verification. A dependency change can affect any code
path, so scope is `full`:

```bash
python3 .agent/tools/harness.py gate run --lane all --scope full
```

Also check: no new CVEs introduced, no new analyzer warnings, no bundle-size or
performance regression, no deprecation warnings left unaddressed.

## 6. RE-LOCK

`harness.py lock` — tool versions changed, so the lock must be regenerated. Then
`harness.py doctor` to confirm the fingerprint is consistent.

## Definition of done

- [ ] Changelogs read for every intervening version, breaking changes recorded
- [ ] Matched sets upgraded together
- [ ] **Full-scope** gates pass, not diff-scoped
- [ ] No new CVEs, warnings, or budget regressions
- [ ] `harness.lock` regenerated
- [ ] New dependencies approved by a named human, with licence recorded

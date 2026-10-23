---
id: release
kind: workflow
version: 1
appliesTo: [all]
invokes: [release-manager, security-auditor, api-steward, docs-writer, generated-project-validator, package-integrity-auditor]
requires: [release-readiness, api-review, security-review]
binding: [not-run-is-not-pass, evidence-before-done, autonomy-boundary, verify-generated-output]
---

# release — ship it

Ends at **CHECKPOINT 3 (human): GO / NO-GO**. The agent may prepare everything and
may not publish.

## 1. FREEZE

No new features. Only release-blocking fixes, each its own task.

## 2. FULL VERIFICATION

```bash
python3 .agent/tools/harness.py gate run --lane all --scope full
python3 .agent/tools/harness.py doctor
python3 .agent/tools/harness.py verify
```

Every gate, full scope, **from a clean checkout**. A green local tree is not evidence
that the shipped artifact builds — uncommitted files and stale build output hide real
failures.

## 3. THE NOT-RUN LIST IS THE RELEASE BLOCKER LIST

Any gate that did not run is a blocker until it runs or a **named human waives it in
writing**. An unwaived not-run is a NO-GO.

This is the single most important line in the workflow. It is where "we didn't have
time to run the E2E suite" becomes a recorded decision instead of a silent omission.

## 4. AUDIT THE SURFACE

- `api-steward` — API baseline diff matches the intended change, and only that
- `security-auditor` — no unresolved findings; dependency CVEs clean; secret scan clean
- Licence compliance: every dependency's licence recorded and permitted
- `docs-writer` — changelog, migration notes, samples updated

## 5. ARTIFACT INTEGRITY

Build from a clean checkout. Verify the artifact contains what it should — and does
**not** contain what it should not: source maps, test fixtures, internal docs,
`.env` files, licence keys.

For a client-shipped bundle, inspect the actual contents. This is where secrets leak.

## 6. PREPARE, DO NOT PUBLISH

Version bumped per semver, changelog complete, tag prepared but **not pushed**,
release notes drafted, rollback plan written and tested.

The rollback plan is not optional and is not "revert the commit". Name the exact
steps, including data.

## 7. CHECKPOINT 3

Present: what ships, the gate summary **with the not-run list**, the API diff, the
security posture, known issues, the rollback plan.

Wait for an explicit go from a named human. Record who and when.

## 8. AFTER GO

Publish, push the tag, verify the published artifact resolves and installs, monitor,
and update `PROJECT-STATE.md`.

## Definition of done

- [ ] Full-scope gates from a clean checkout
- [ ] Not-run list empty, or every entry waived in writing by a named human
- [ ] API diff reviewed and intentional
- [ ] Security and licence audit clean
- [ ] Artifact contents verified — no secrets, no fixtures, no source maps
- [ ] Rollback plan written
- [ ] CHECKPOINT 3 recorded with approver and timestamp

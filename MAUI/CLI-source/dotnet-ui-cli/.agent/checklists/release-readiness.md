---
id: release-readiness
kind: checklist
version: 1
appliesTo: [all]
usedBy: [release]
---

# Release readiness

Presented at **CHECKPOINT 3**. Any unchecked box is a NO-GO unless a named human
waives it in writing.

## Verification
- [ ] Full-scope gates run **from a clean checkout**
- [ ] `harness.py doctor` healthy — no drift, all tools resolve
- [ ] `harness.py verify` passes — control plane matches `HARNESS-LOCK.json`
- [ ] `task.py doctor` — task state consistent
- [ ] **Not-run list empty, or every entry waived in writing with an approver named**

## Scope
- [ ] Every task accounted for: done, blocked with a reason, or deferred with a reason
- [ ] Known issues listed with severity and workaround
- [ ] No unreviewed commits on the release branch

## Surface
- [ ] `checklists/api-review.md` complete
- [ ] API baseline diff intentional and only the intended change
- [ ] `checklists/security-review.md` complete
- [ ] Dependency CVE scan clean
- [ ] Every dependency licence recorded and permitted

## Artifact
- [ ] Built from a clean checkout
- [ ] **No secrets, licence keys, or `.env` files in the artifact**
- [ ] No test fixtures, sample data, or internal docs
- [ ] No source maps unless deliberately shipped
- [ ] Artifact resolves and installs in a clean environment
- [ ] Size within budget

## Documentation
- [ ] Changelog complete, describing user-visible effects
- [ ] Migration notes for every breaking or behavioural change
- [ ] Samples updated and **executed**
- [ ] Version bumped per semver; a breaking change is a major

## Operations
- [ ] **Rollback plan written**, including data — not "revert the commit"
- [ ] Rollback tested where feasible
- [ ] Monitoring and alerting cover the new surface
- [ ] Support informed of known issues

## Approval
- [ ] CHECKPOINT 3 presented with the not-run list visible
- [ ] Approver named and timestamp recorded

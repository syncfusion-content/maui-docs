---
id: incident
kind: workflow
version: 1
appliesTo: [all]
invokes: [security-auditor, implementer, test-engineer, release-manager]
requires: [definition-of-done]
binding: [containment-first, no-secrets-in-source, never-weaken]
---

# incident — a production failure

The one workflow that legitimately suspends the normal loop, and the only one where
**containment outranks root cause**.

## 0. IS THIS AN INCIDENT?

Yes if: users are affected now, data is at risk, or a vulnerability is actively
exploitable. Otherwise it is a `bugfix` or a `security` task — do not spend incident
process on a non-incident, and do not run a real incident through `bugfix`.

## 1. CONTAIN — before diagnosing

Stop the bleeding: roll back, disable the feature flag, revoke the credential, block
the input. Record the time and the action.

**Diagnosis comes after containment.** An agent's instinct is to understand first;
during an incident that is the wrong order and it costs user impact.

Rollback is a `release-manager` action and needs a named human — **CHECKPOINT 3**
applies to rolling back as much as to shipping.

## 2. ESTABLISH THE TIMELINE

First occurrence, detection, containment. What changed immediately before — deploy,
config, dependency, data, traffic. State facts with timestamps and keep speculation
in a separate section, clearly labelled.

## 3. PRESERVE EVIDENCE FIRST

Logs, traces, heap or core dumps, the failing request, the deployed commit SHA.
Capture before restarting anything: a restart usually destroys the state that explains
the failure, and it is the second thing an agent reaches for after rollback.

**If credentials were exposed: rotate them.** Never paste the exposed value anywhere,
including the incident record.

## 4. ROOT CAUSE

Same standard as `bugfix`: the causal chain, not the symptom. Then the second
question, which is the more valuable one: **why did no gate catch this?**

Every incident is a gap in the harness. The output is at minimum one new gate, one new
test, or one new policy. An incident that produces only a code fix will recur.

## 5. FIX FORWARD

A test that reproduces the failure, then the fix, then the full suite at full scope.
Expedited, not skipped — an incident fix that breaks something else is a second
incident.

## 6. WRITE IT UP AND CLOSE THE GAP

`templates/incident.md`: timeline, impact, root cause, containment, permanent fix,
**and the harness change that would have caught it**.

File that harness change as a task before closing. This is the step that makes the
incident worth something.

## Definition of done

- [ ] Contained, with the time and action recorded
- [ ] Evidence preserved before any restart
- [ ] Exposed credentials rotated
- [ ] Root cause established, not just the symptom
- [ ] A test reproduces the failure
- [ ] Full-scope gates pass
- [ ] Incident record written
- [ ] **A harness gap was identified and filed as a task**

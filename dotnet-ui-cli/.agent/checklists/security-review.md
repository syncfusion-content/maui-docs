---
id: security-review
kind: checklist
version: 1
appliesTo: [all]
usedBy: [security, incident, release]
---

# Security review

## Finding
- [ ] **Reachability traced**: untrusted input → path → vulnerable operation
- [ ] What the attacker controls is stated precisely
- [ ] Classified: exploitable now / latent / hardening / dependency CVE
- [ ] A test demonstrates the flaw and **failed before the fix**
- [ ] Reverting the fix makes that test fail again

## Fix
- [ ] Root cause addressed, not the reachable instance only
- [ ] Fixed at the class level where a mechanism exists, or the reason not is recorded
- [ ] No security control weakened — any weakening is a lane-3 park
- [ ] Codebase swept for the same pattern; other instances filed as tasks

## Input and output
- [ ] Untrusted input validated at the boundary, against a schema where possible
- [ ] Queries parameterised — no string concatenation into SQL, LDAP, or shell
- [ ] Output encoded for its sink; no raw HTML from user input
- [ ] File paths canonicalised and constrained; no traversal
- [ ] Redirects validated against an allowlist

## Authentication and authorization
- [ ] Every endpoint or action requires authorization, or is deliberately anonymous
- [ ] Ownership checked on every resource fetched by id — no IDOR
- [ ] Privilege is least-necessary; no broad role added for convenience
- [ ] Session and token lifetimes bounded; revocation possible

## Secrets and crypto
- [ ] No credential in source, config, tests, fixtures, logs, or task files
- [ ] Secrets read from a store or the environment
- [ ] Exposed credentials **rotated**, not merely removed
- [ ] No weak or deprecated algorithms; no disabled certificate validation

## Dependencies and gates
- [ ] No new CVEs introduced
- [ ] New dependencies' licences recorded and permitted
- [ ] SAST and secret-scanning gates pass
- [ ] What was **not** covered by scanning is stated

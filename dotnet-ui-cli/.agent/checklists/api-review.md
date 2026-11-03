---
id: api-review
kind: checklist
version: 1
appliesTo: [all]
usedBy: [api-change, release]
---

# API review

Run by `api-steward` on any change to the public surface. What counts as public is
recorded in `project-context.md`.

## Classification
- [ ] Change classified: **additive**, **behavioural**, or **breaking**
- [ ] Behavioural changes called out explicitly — no tool flags them at the call site
- [ ] Breaking or behavioural change approved by a **named human**, recorded

## Surface
- [ ] Every new public member is intentional — nothing leaked by widening a modifier
- [ ] Naming matches project convention and reads correctly at the call site
- [ ] Nullability, optionality, and default values are deliberate and documented
- [ ] Error contract stated: what it throws or returns on failure
- [ ] Async surface is consistent — no sync-over-async, cancellation accepted

## Compatibility
- [ ] Existing callers still compile
- [ ] Existing callers still **behave** the same
- [ ] Persisted data shapes unchanged, or a migration is specified in both directions
- [ ] Serialisation compatible in both directions where relevant

## Baseline
- [ ] API baseline updated **in the same commit**
- [ ] The baseline diff contains the intended change and **only** that
- [ ] The API gate passes

## Deprecation
- [ ] Deprecated members carry a message naming the replacement
- [ ] The removal version is stated
- [ ] The replacement exists and is documented

## Documentation
- [ ] Reference documentation updated
- [ ] A working, executed example exists
- [ ] Migration note with before/after code
- [ ] Changelog entry describes the user-visible effect

---
id: cite-the-source
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [spec-writer, implementer, oracles]
---

# cite-the-source — name the source that decided

## Rule

Every non-obvious decision about correct behaviour names the source that settled it and its rank in the authority hierarchy. Framework behaviour is looked up, never recalled.

## Why

A model's recollection of a framework is a snapshot of its training data blended across versions and adjacent frameworks, delivered with full confidence. It is the single largest source of plausible-but-wrong generated code.

Ranks 1–3 are normative; 4–5 are binding; 6–8 are evidence only. 'Chrome does it this way' is an observation, not a citation.

## Enforced by

`.agent/knowledge/` files require `Source:` lines with retrieval dates, hashed into the lock; `harness.py doctor` flags uncited files. Vendor skill packs are installed where they exist.

## Violation

Look it up. If it cannot be looked up, mark the claim `UNVERIFIED` in `## Log` rather than asserting it.

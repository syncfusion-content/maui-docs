---
id: api-change
kind: workflow
version: 1
appliesTo: [all]
invokes: [api-steward, spec-writer, implementer, test-engineer, code-reviewer, docs-writer, wizard-consistency-reviewer, generated-project-validator, package-integrity-auditor]
requires: [api-review, definition-of-done, pr-review]
binding: [public-api-is-a-contract, autonomy-boundary, never-weaken, cite-the-source, verify-generated-output, preserve-user-files, no-unrelated-change]
---

# api-change — a public signature changes

## This workflow always touches the autonomy boundary

**An irreversible public API change is a lane-3 decision: park it for a human.** The
agent produces the analysis and the recommendation; a human decides.

What counts as public depends on the deliverable, and the generator fills this in:

| Deliverable | Public surface |
|---|---|
| Component library | every exported type, prop, event, slot, and CSS custom property |
| Service | every route, request/response shape, status code, and header |
| Internal package | everything importable across a package boundary |
| Application | URLs, persisted data shapes, config keys, CLI flags |

## 1. CLASSIFY — `api-steward`

| Class | Definition | Path |
|---|---|---|
| **Additive** | new optional surface; every existing caller still compiles and behaves | proceed |
| **Behavioural** | signature identical, semantics differ | **park** — the worst kind, invisible to callers |
| **Breaking** | an existing caller stops working | **park** |

Behavioural changes are the dangerous class precisely because no tool flags them at
the call site. Say so explicitly in the analysis.

## 2. ANALYSE IMPACT

- Count call sites: in-repo and, where knowable, downstream
- Name the migration path for each affected caller
- Estimate the blast radius honestly — "probably fine" is not an estimate

## 3. PARK — if breaking or behavioural

Append to `DECISIONS-REQUIRED.md` using `templates/decision-required.md`:
the change, the class, the impact, **the recommendation**, alternatives considered,
and the cost of not doing it.

Mark affected tasks blocked. **Take the next ready task.** Do not stall the loop.

## 4. AFTER APPROVAL — implement with a migration path

- Additive first, wherever possible: add the new surface, deprecate the old, remove
  in a later major
- Deprecation carries a message naming the replacement and the removal version
- Update the API baseline (`PublicAPI.Shipped.txt`, api-extractor report, OpenAPI
  document) **in the same commit** — a baseline updated separately is a baseline that
  drifts
- Write the migration note in the same change set

## 5. VERIFY

- API baseline gate passes with the intended diff, and only that diff
- Deprecation warnings appear where expected
- `checklists/api-review.md` satisfied
- Docs and samples updated — `docs-writer`

## Definition of done

- [ ] Change classified; behavioural changes explicitly flagged
- [ ] Breaking or behavioural change approved by a named human
- [ ] API baseline updated in the same commit
- [ ] Migration path documented with before/after
- [ ] `checklists/api-review.md` complete

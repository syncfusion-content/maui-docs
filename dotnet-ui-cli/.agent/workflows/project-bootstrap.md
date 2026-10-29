---
id: project-bootstrap
kind: workflow
version: 1
appliesTo: [all]
invokes: [requirements-analyst, spec-writer, task-planner]
requires: []
binding: [autonomy-boundary, spec-before-code, cite-the-source]
---

# project-bootstrap — from nothing to a frozen roadmap

Runs once. Ends at **CHECKPOINT 1 (human): roadmap scope approval**. No production
code is written until that approval.

## 1. GATHER REQUIREMENTS — `requirements-analyst`

One question at a time, never a questionnaire — each answer changes what to ask next.

1. What are you building, in one sentence?
2. Who uses it, and what do they do today instead?
3. What must be true for v1 to be worth shipping?
4. What is explicitly **out** of scope for v1?
5. Which constraints are fixed — stack, platform, compliance, deadline?
6. What does failure look like?

Question 4 does the most work. A scope with no stated exclusions is not a scope, and
it is what turns a two-week project into a six-month one.

## 2. CURATE THE CORPUS

Assemble the authoritative sources **before** any specification is written:

- the authority precedence list for this stack (`references/oracles.md`)
- first-party documentation, fetched and cited with retrieval dates
- vendor skill packs where they exist
- existing internal standards

Populate `.agent/knowledge/`. **Every rule carries a `Source:` line.** An uncited rule
is model memory wearing a citation's clothes.

## 3. WRITE REQUIREMENTS — `templates/requirement.md`

Each requirement: id, statement, rationale, acceptance criteria that a tool or test
can check, priority, and out-of-scope notes.

## 4. TECHNICAL SPECIFICATION — `spec-writer`

Architecture and why, with alternatives considered. Component boundaries. Data shapes.
External interfaces. Non-functional budgets as **numbers**. Risks, with mitigations.

Each significant choice becomes an ADR — `templates/adr.md`.

## 5. PROPOSE THE HARNESS

Run the harness-creator PROPOSE stage: profile, tier, gates, lane budgets, oracle
coverage, what is deliberately not proposed and why.

Bootstrap is the cheapest moment in a project's life to start at a high tier.
Greenfield has no legacy excuse.

## 6. PLAN THE ROADMAP — `task-planner`

Phases with an observable exit criterion each. Tasks with dependencies. A critical
path. Explicit sequencing rationale.

Phase 1 is always: **make the loop work end to end on one thin vertical slice.** A
roadmap whose first phase is "set up infrastructure" cannot demonstrate anything for
weeks.

## 7. CHECKPOINT 1

Present: requirements, scope boundary, architecture with its ADRs, the proposed
harness and tier, the phased roadmap with the critical path, risks, and the open
questions parked so far.

**Wait for explicit approval.** Then freeze the roadmap in `PROJECT-STATE.md` and
enter the loop.

## Definition of done

- [ ] Requirements written with checkable acceptance criteria
- [ ] Scope boundary states what is explicitly out
- [ ] Corpus curated and cited in `.agent/knowledge/`
- [ ] Architecture specified; significant choices are ADRs
- [ ] Harness generated, validated, and locked
- [ ] Roadmap phased with observable exit criteria
- [ ] CHECKPOINT 1 approval recorded

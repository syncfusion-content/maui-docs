---
id: task
kind: template
version: 1
---
# {{ID}} — {{TITLE}}

**Type**: feature | bugfix | refactor | api-change | security | performance | dependency-upgrade | test-backfill | incident
**Workflow**: `.agent/workflows/<type>.md`   **Base**: {{BASE_SHA}}

## What

<!-- SPEC. Behaviour, scope boundary, acceptance criteria.
     Every criterion must be checkable by a tool or a test. -->

**Behaviour**:

**Explicitly out of scope**:

**Acceptance criteria**:
- [ ] AC1 — <statement> · verified by: <test or gate>

**Sources consulted** (rank per `references/oracles.md`):
- <url or file> — rank N — decided: <what>

**Open questions** (assumption + pinning test + PROJECT-STATE entry):
- <question> → assumed: <choice> → pinned by: <test> → logged: yes/no

## Plan

<!-- Dependency-ordered. One commit each. Each names its test. -->

- [ ] <subtask> — test: <name>

## Evidence

<!-- From .agent/evidence/{{ID}}/. Cite artifacts. Never write a conclusion
     here that no tool produced. -->

| Gate | Verdict | Measured | Artifact |
|---|---|---|---|

**Not run**: <list, or none>

## Review

<!-- Findings from code-reviewer. Six lines each; Verify is mandatory. -->

## Security

<!-- Only if a risk-gated path was touched. Reachability, not scanner output. -->

## Log

<!-- Decisions, dead ends, what a future session needs. Dead ends matter most. -->

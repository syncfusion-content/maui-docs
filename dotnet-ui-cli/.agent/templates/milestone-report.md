---
id: milestone-report
kind: template
version: 1
---
# Milestone: {{PHASE}}

**Date**: {{DATE}}   **Commit**: {{SHA}}   **Tier**: {{TIER}}

## Delivered

| Task | Title | Evidence |
|---|---|---|

## Not delivered

| Task | Status | Why | What would unblock it |
|---|---|---|---|

<!-- Every task must appear here or above. An unevaluated backlog is not
     a completed phase. -->

## Deferred

| Task | Rationale for deferring |
|---|---|

## Gate results — full scope

| Gate | Verdict | Measured |
|---|---|---|

### NOT RUN

<!-- Carried as release blockers. NOT RUN is never PASS. -->

| Gate | Why it did not run | Blocker? |
|---|---|---|

## Tier

**Current**: {{TIER}}   **Moved this phase**: yes / no
**To reach the next tier**: <from `harness.py tier`>

## Ratchet

<!-- From `harness.py ratchet`. Convert achieved quality into enforced quality. -->

| Gate | Current | Proposed | Applied |
|---|---|---|---|

## Decisions

**Made** (ADRs written): <ids>
**Parked** (still open): <ids from DECISIONS-REQUIRED.md>

## Harness changes

<!-- Gates added, policies changed, knowledge refreshed. Every incident and
     escaped defect should produce one. -->

## Next phase

**Goal**:   **Exit criterion**:   **First task**:

---
id: decision-required
kind: template
version: 1
---
## DECISION {{NUMBER}}: {{TITLE}}

**Raised**: {{DATE}}   **Task**: {{TASK_ID}}   **Status**: open | answered | withdrawn
**Category**: scope | public-API | licensing-legal | security-weakening | budget-regression

### The question

<!-- One sentence a non-specialist can answer. -->

### Why this is not the agent's call

<!-- Which lane-3 category, and why it is irreversible or out of scope. -->

### Context

<!-- What the agent already established. Do not make the human re-derive it. -->

### Options

| # | Option | Cost | Risk | Reversibility |
|---|---|---|---|---|
| 1 | | | | |
| 2 | | | | |

### Recommendation

<!-- MANDATORY. A parked question with no recommendation hands all the analysis
     back and wastes the work already done. State a preference and why. -->

**Recommended**: option N — because ...

### Impact while unanswered

**Blocked tasks**: <ids>
**Still proceeding**: <ids>   ← the loop must not have stopped
**Blocks everything?**: yes / no   ← if yes, this triggers CHECKPOINT 2

### Answer

**Decided**: <option>   **By**: <name>   **Date**:
**Rationale**:
**Follow-up tasks filed**: <ids>

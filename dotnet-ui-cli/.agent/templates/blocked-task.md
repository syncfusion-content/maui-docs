---
id: blocked-task
kind: template
version: 1
---
# BLOCKED: {{TASK_ID}} — {{TITLE}}

**Blocked at**: {{DATE}}   **Commit**: {{SHA}}   **Attempts used**: 3

## Goal

<!-- What this task was trying to achieve, in one sentence. -->

## Attempts

### Attempt 1
**Hypothesis**:
**Change made**:
**Result** (verbatim failure output):
```
```

### Attempt 2
**Hypothesis**:
**How it differed from attempt 1**:
**Result**:
```
```

### Attempt 3
**Hypothesis**:
**How it differed from attempts 1 and 2**:
**Result**:
```
```

## Invariant

<!-- THE MOST IMPORTANT SECTION. What was true across all three failures?
     Three different fixes failing the same way means the model of the problem
     is wrong, not the fix. -->

## Ruled out

<!-- What these attempts eliminated. Saves the next session repeating them. -->

## Needed to unblock

<!-- SPECIFIC. "More information" is useless.
     "The schema version production is actually on" is actionable. -->

## Classification

- [ ] Missing information — needed: <what>
- [ ] Product decision — parked in DECISIONS-REQUIRED.md
- [ ] Upstream defect — link: <url>
- [ ] Environment or tooling — tool and version: <what>
- [ ] Task was mis-specced — returning to SPEC

## Reproduction

```bash
# exact command that shows the failure
```

## Evidence

<!-- Paths to gate logs and artifacts. A blocked task without runnable
     evidence means the next session starts over. -->

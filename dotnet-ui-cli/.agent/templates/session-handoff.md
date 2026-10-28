---
id: session-handoff
kind: template
version: 1
---
# Session handoff — {{DATE}}

## In two sentences

<!-- What a human reads first: where things stand and what needs attention. -->

## Tree state

**Committed**: yes / no   **Commit**: {{SHA}}   **Branch**: {{BRANCH}}
**Gates at this commit**: pass / fail / partial — <detail>
**If uncommitted, why**:

## Active task

**Task**: {{TASK_ID}} — {{TITLE}}
**Stage**: spec | plan | build | inner-gates | outer-gates | review
**Exact next step**:

## What was tried

**Worked**:

**Did not work, and why** ← the section that saves the next session the most time:

**Current hypothesis**:

## Gate state

| Gate | Last run at | Result |
|---|---|---|

**Async jobs in flight**: <gate, job id> — must be polled or the task strands in `verifying`

## Open decisions

<!-- From DECISIONS-REQUIRED.md — anything a human may have answered since. -->

## Filed this session

**New tasks**: <ids>   **Blocked**: <ids>   **Completed**: <ids>

## Resumability check

- [ ] `PROJECT-STATE.md` current
- [ ] Active task `## Log` has dead ends and the exact next step
- [ ] Async job ids recorded
- [ ] Discovered work filed as tasks
- [ ] **A fresh session could resume from the files alone**

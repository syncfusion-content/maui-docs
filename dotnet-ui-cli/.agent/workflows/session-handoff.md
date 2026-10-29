---
id: session-handoff
kind: workflow
version: 1
appliesTo: [all]
invokes: []
requires: []
binding: [state-is-durable]
---

# session-handoff — ending a session cleanly

An autonomous loop runs across many sessions with no shared memory. Everything the
next session needs must be **on disk**. Run this before ending any session with work
in progress.

## The test

> Could a fresh session with no conversation history resume this work correctly from
> the files alone?

If not, the handoff is incomplete. That is the whole standard.

## 1. LEAVE THE TREE IN A KNOWN STATE

Best: committed and gates green. Acceptable: committed and gates red, **with the
failure recorded**. Bad: uncommitted changes with no note — the next session cannot
tell deliberate work-in-progress from an abandoned experiment.

Never leave a task `active` with no `## Log` entry.

## 2. UPDATE PROJECT-STATE.md

Current phase · the active task and its exact stage · what was just completed · what
is next and why · open decisions · blockers with what would unblock them.

## 3. WRITE THE TASK LOG

In `## Log` of the active task: what was tried, what worked, **what did not and why**,
the current hypothesis, and the exact next step.

The dead ends matter most. Without them the next session repeats them, which is the
most common waste in multi-session agent work.

## 4. RECORD GATE STATE

Which gates last ran, at which commit, with what result. Any async gate still in
flight, with its job id — otherwise the next session cannot poll it and the task
strands in `verifying`.

## 5. FILE DISCOVERED WORK

Anything noticed but not actioned becomes a task now. Observations left only in
conversation are lost when the session ends.

## 6. HANDOFF NOTE — `templates/session-handoff.md`

Two or three sentences a human reads first: where things stand, what needs attention,
and any judgement call the next session should know about.

## Definition of done

- [ ] Tree committed, or the reason it is not is recorded
- [ ] `PROJECT-STATE.md` current
- [ ] Active task `## Log` includes dead ends and the exact next step
- [ ] Gate state and any in-flight job ids recorded
- [ ] Discovered work filed as tasks
- [ ] A fresh session could resume from the files alone

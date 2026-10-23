---
id: state-is-durable
kind: policy
version: 1
appliesTo: [all]
severity: standard
enforcedBy: [session-handoff, PROJECT-STATE.md]
---

# state-is-durable — the next session reads files, not conversation

## Rule

Everything a future session needs is written to disk before a session ends: `PROJECT-STATE.md`, the active task's `## Log` including dead ends, gate state, and any in-flight async job id.

## Why

An autonomous loop runs across many sessions with no shared memory. Knowledge left in conversation is lost.

Dead ends matter most: without them the next session repeats them, which is the largest single waste in multi-session agent work.

## Enforced by

The `session-handoff` workflow; `task.py` journals every transition. The standard is: could a fresh session with no history resume correctly from the files alone?

## Violation

Run `session-handoff` before ending. A task left `active` with no `## Log` entry is an incomplete handoff.

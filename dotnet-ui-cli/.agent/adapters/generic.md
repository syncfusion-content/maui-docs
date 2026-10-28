# Host Adapter — Generic (Cursor, Codex, Copilot, or no delegation)

| Capability | Binding |
|---|---|
| `DELEGATE` | **not available** — see below |
| `READ_FILE` | the host's file read |
| `RUN` | the host's terminal |
| `PARALLEL` | not available |

## Running without delegation

Run BUILD inline, with two compensating rules — a single context doing both
orchestration and building degrades as the task grows:

1. **One task per session.** Complete PICK through LEARN, then start a fresh
   session. `.agent/tasks/<ID>.md` and `.agent/progress.md` carry state across
   sessions; that is what they are for.
2. **Re-read `.agent/instructions.md` and `.agent/project-context.md` at the start
   of every session.** Without delegation there is no fresh-context guarantee, so
   this is manual and it matters.

## What does not change

The gate system is identical. `harness.py gate run`, the evidence files, and
`task.py done`'s refusal all behave exactly as they do under a delegating host.

This is the main practical argument for keeping evidence in files rather than in an
agent's context: verification does not depend on the host's capabilities. A team on
Cursor and a team on Code Studio produce the same evidence trail against the same
contract.

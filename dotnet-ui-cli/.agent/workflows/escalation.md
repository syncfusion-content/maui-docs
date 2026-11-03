---
id: escalation
kind: workflow
version: 1
appliesTo: [all]
invokes: [escalation-analyst]
requires: []
binding: [bounded-retry, never-weaken, autonomy-boundary]
---

# escalation — three attempts exhausted

Runs **once** per task. Its output is a blocked task with enough evidence that a
human, or a later session, can resume without re-deriving anything.

Escalation is a success condition, not a failure. A loop that escalates cleanly and
moves on beats one that spins for an hour.

## 1. STOP

No fourth attempt. The retry budget exists because past three substantively different
hypotheses, additional attempts are usually variations rather than ideas.

## 2. RECONSTRUCT — `escalation-analyst`

Fill `templates/blocked-task.md`:

| Section | Content |
|---|---|
| **Goal** | what the task was trying to achieve |
| **Attempt 1** | hypothesis, change made, exact failure output |
| **Attempt 2** | hypothesis, **how it differed**, exact failure output |
| **Attempt 3** | hypothesis, **how it differed**, exact failure output |
| **Invariant** | what is true across all three failures — usually the real finding |
| **Ruled out** | what these attempts eliminated |
| **Needed** | the specific input that would unblock this |

The **Invariant** row does the work. Three different fixes failing the same way says
the model of the problem is wrong, not the fix.

**"Needed" must be specific.** "More information" is useless; "the schema version the
production database is actually on" is actionable.

## 3. CHECK THE HYPOTHESES WERE REALLY DIFFERENT

If attempts 2 and 3 were tweaks of attempt 1, the retry budget was wasted — and the
honest move is to say so and generate one genuinely different hypothesis before
blocking. Record that this happened.

## 4. PRESERVE EVIDENCE

Attach: the failing gate output verbatim, the relevant evidence artifacts, the
reproduction command, and the commit SHA. A blocked task without runnable evidence
means the next session starts over.

## 5. CLASSIFY THE BLOCKER

| Type | Route |
|---|---|
| Missing information | `task.py block`; note exactly what is needed |
| A product decision | `DECISIONS-REQUIRED.md` with a recommendation |
| An upstream defect | file upstream, link it, note any workaround |
| Environment or tooling | `task.py block`; name the tool and version |
| The task was mis-specced | return it to SPEC rather than blocking it |

That last row matters: a surprising share of exhausted retries are a specification
problem wearing an implementation problem's clothes.

## 6. BLOCK AND MOVE ON

```bash
python3 .agent/tools/task.py block "<one-line reason>" 
python3 .agent/tools/task.py next
```

`block` reports which tasks are now unreachable. If **all** remaining work is blocked
→ **CHECKPOINT 2**.

## Definition of done

- [ ] Three attempts recorded with their distinct hypotheses
- [ ] The invariant across failures identified
- [ ] Failing evidence attached and reproducible
- [ ] Blocker classified and routed
- [ ] Loop continued, or CHECKPOINT 2 raised

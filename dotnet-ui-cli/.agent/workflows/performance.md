---
id: performance
kind: workflow
version: 1
appliesTo: [all]
invokes: [performance-analyst, implementer, test-engineer, code-reviewer]
requires: [performance-review, definition-of-done]
binding: [measure-before-optimising, never-weaken]
---

# performance — latency, memory, bundle, throughput

## The binding rule

> **No optimisation without a measurement that motivated it, and a measurement that
> confirms it.**

An agent asked to "make this faster" will produce plausible-looking changes with no
effect, or a regression. Both are indistinguishable from success without numbers.

## 1. MEASURE THE BASELINE — `performance-analyst`

Record in `## Log`, before changing anything:

- the metric and its **budget** (p95 latency, heap growth ratio, bundle bytes, ops/sec)
- the current value, from a real tool
- the workload, stated precisely enough to repeat
- variance across runs — a single run is not a measurement

| Concern | Tool of record | Licence |
|---|---|---|
| .NET micro-benchmark | BenchmarkDotNet | MIT |
| .NET memory | dotnet-gcdump, dotnet-counters | MIT |
| Web runtime | Lighthouse CI | Apache-2.0 |
| Web heap | memlab | MIT |
| Bundle size | size-limit, Angular CLI budgets | MIT |
| HTTP throughput | k6 | AGPL-3.0 (standalone tool) |
| Database | query plans, EF warning gates | free |

## 2. PROFILE — find where the time or memory actually goes

**Do not skip to step 3.** The characteristic failure here is optimising the part
that felt slow. Attach the profile output as evidence.

State the bottleneck as a proportion: "72% of p95 is in the serialiser" is
actionable; "the serialiser is slow" is not.

## 3. SET THE TARGET

A number and a rationale. "As fast as possible" gives the loop no stopping condition,
so it will keep going and start trading correctness for speed.

## 4. OPTIMISE — `implementer`

One change at a time, **measured after each**. An unmeasured change in a batch of
five is a change nobody can attribute.

Cheapest first: algorithmic complexity, then unnecessary work, then caching, then
micro-optimisation. Reach for the last one only when the first three are exhausted —
it is where readability goes to die for the smallest return.

## 5. VERIFY

- The metric meets the target, measured the same way as the baseline
- **Correctness gates all still pass** — this is where speed/correctness trades hide
- No other budget regressed
- The result is recorded next to the baseline

## 6. GUARD IT

Add or tighten the budget gate so the improvement cannot silently erode. An
optimisation with no guard is a temporary optimisation.

## Definition of done

- [ ] Baseline measured and recorded before any change
- [ ] Bottleneck identified by profiling, stated as a proportion
- [ ] Target stated as a number with a rationale
- [ ] Improvement measured the same way as the baseline
- [ ] All correctness gates still pass
- [ ] A budget gate now guards the result

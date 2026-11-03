---
id: performance-review
kind: checklist
version: 1
appliesTo: [all]
usedBy: [performance, release]
---

# Performance review

## Measurement
- [ ] Baseline recorded **before** any change
- [ ] Metric, workload, environment, run count, and **variance** all stated
- [ ] p50 and p95 reported — not a mean
- [ ] Confirming measurement taken **the same way** as the baseline

## Diagnosis
- [ ] Bottleneck identified by profiling, not by inspection
- [ ] Stated as a proportion — "72% of p95 is in X", not "X is slow"
- [ ] Profile output attached as evidence

## Target
- [ ] Target is a number with a rationale
- [ ] The workload is representative of real use
- [ ] The target is achievable without a correctness trade

## Change
- [ ] One optimisation at a time, measured after each
- [ ] Cheapest first: complexity → unnecessary work → caching → micro-optimisation
- [ ] Caching, if added, has a stated invalidation strategy
- [ ] Readability cost is acknowledged where it was paid

## Verification
- [ ] Target met, measured comparably
- [ ] **All correctness gates still pass** — this is where speed/correctness trades hide
- [ ] No other budget regressed: memory, bundle, startup, throughput
- [ ] Result recorded next to the baseline

## Guard
- [ ] A budget gate now guards the improvement
- [ ] The budget is set with headroom, not exactly at the achieved value

---
id: test-plan
kind: template
version: 1
---
# Test plan — {{TITLE}}

**Task**: {{TASK_ID}}   **Spec**: {{SPEC}}

## Oracle ceiling

<!-- Per references/oracles.md. Naming the ceiling is the honest move. -->

| Rank | Oracle | Available here |
|---|---|---|
| 1 | Specification | |
| 2 | Independent validator | |
| 3 | Independent producer / consumer round-trip | |
| 4 | Own test suite | yes |

**Correctness evidence here tops out at rank**: N

## Coverage of acceptance criteria

| AC | Test | Type | Oracle rank |
|---|---|---|---|

## Cases

| Class | Case | Expected |
|---|---|---|
| happy path | | |
| boundary | | |
| null / empty | | |
| error | | |
| side effect | | |
| concurrency | | |

## Not tested, and why

<!-- Deliberate gaps, stated. An untested case nobody named is an oversight;
     one named here is a decision. -->

## Sensitivity

**Mutation score target**:   **Achieved**:
**Survivors**: <list — strengthen the test, never reclassify>

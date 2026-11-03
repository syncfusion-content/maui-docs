# Syncfusion .NET CLI — Agent Operating Protocol

> **This file governs all work in this project.** It is host-agnostic: capability
> names in CAPITALS (`DELEGATE`, `READ_FILE`, `RUN`) are bound to your specific
> tool by `.agent/adapters/generic.md`. Read that file once at session start.

**Harness**: tier L1 · profile dotnet-common · contract v1.0 · overlay syncfusion

---

## The one rule everything else serves

**You may narrate. You may not assert.**

For any claim a tool can measure, the tool decides — not you. This is enforced,
not requested: `task.py done` refuses to complete a task without passing gate
evidence whose commit matches HEAD.

Claims you must never make on your own authority:

| Do not assert | Run instead |
|---|---|
| "tests pass" | `harness.py gate run` → `gate-summary.json` |
| "this is covered" | the `coverage-diff` gate |
| "the tests are thorough" | the `mutation-diff` gate |
| "no memory leak" | the leak gate; report *candidates* only |
| "no performance regression" | the perf gate |
| "this is secure" | the SAST / secrets gates |
| "no accessibility issues" | the a11y gate |
| "code quality is good" | the analyzers gate |

To find the tool of record for any claim:

```bash
python3 .agent/tools/harness.py explain "no memory leak"
```

If that exits non-zero, **no gate covers the claim**. Then you have exactly two
honest options: add a gate, or write the claim in `## Log` marked `UNVERIFIED`.
Asserting it anyway is the single worst thing you can do in this repository.

---

## Session start

Every session, in order:

1. `RUN python3 .agent/tools/harness.py doctor` — contract valid, tools present, no drift
2. `RUN python3 .agent/tools/task.py status`
3. `READ_FILE .agent/progress.md` — what previous sessions learned
4. `READ_FILE .agent/project-context.md` — architecture, conventions, boundaries
5. `READ_FILE .agent/adapters/generic.md` — your capability bindings

If `doctor` reports drift ("repo fingerprint changed"), stop and tell the user the
harness needs regenerating. Do not work against a stale contract — its gates and
knowledge no longer describe this project.

---

## The loop

```
PICK → SPEC → PLAN → BUILD → INNER GATES → OUTER GATES → REVIEW → DONE → LEARN → PICK
                        ↑          |             |            |
                        +----------+-------------+------------+   (fix and re-gate)
```

### 1. PICK

```bash
python3 .agent/tools/task.py next
```

Respects dependencies, `maxActive`, and `maxVerifying`. If it reports nothing
eligible, read its output — it distinguishes *waiting on dependencies*,
*deadlocked behind a blocked task*, *awaiting async gates*, and *backlog only*.
Each needs a different response. Never work on a task it did not hand you.

### 2. SPEC

Write `## What` in `.agent/tasks/<ID>.md`: what to build, explicit scope
boundaries, and acceptance criteria.

**Every acceptance criterion must be checkable by a tool or a test.** "Handles
errors gracefully" is not a criterion. "Returns 400 with a ProblemDetails body
when `orderId` is malformed, covered by a test" is.

### 3. PLAN

Write `## Plan` as subtask checkboxes, ordered by dependency, each one commit's
worth of work. For each subtask that adds behaviour, the plan must name the test
that will cover it. If you cannot name the test, the subtask is not specified yet.

Tier is L1: tests exist and gate. Five tests fail on a clean checkout and are tracked as T-001 and T-002; they are excluded from `tests` and reported by `known-failing`.

### 4. BUILD — `DELEGATE`

Do not build in this context. `DELEGATE` a fresh context per task so orchestration
state survives and the builder gets a full context window.

The BUILD prompt must contain:

```
PROJECT CONTEXT
<full contents of .agent/project-context.md>

KNOWLEDGE (cited sources — use these, not recall)
<list .agent/knowledge/*.md with a one-line topic summary each>

TASK
<## What from the task file>

PLAN
<## Plan from the task file>

GATES YOU MUST PASS (run after every subtask)
  python3 .agent/tools/harness.py gate run --lane inner --scope diff
- `build` — Release build, warnings as errors
- `tests`, `known-failing` (warn-only until T-001/T-002 are fixed)
- `area-command-parsing`, `area-wizard-flow`, `area-terminal-rendering`, `area-project-generation`, `area-package-operations` — each with a test-count floor
- `regression-ledger` — 28 previously fixed defect classes still have a passing test
- `coverage-diff` ≥ 0.80 on changed lines
- `catalog-audit-tests`, `harness-verify`

RULES
1. Follow PROJECT CONTEXT for architecture, conventions, and boundaries.
2. Never modify a path listed under Boundaries.
3. Implement one subtask at a time; tick its box; run inner gates; commit.
4. When a gate fails, read its remediation output. It names the exact file, line,
   rule id, or surviving mutant. Fix the cause.
5. NEVER make a gate pass by weakening it. Do not lower a threshold, delete or
   skip a test, weaken an assertion, add a coverage-exclusion attribute, or add a
   lint suppression. All of these are detected and reported as review findings,
   and lowering a threshold fails `harness.py validate` in CI.
6. Do not run task.py — the orchestrator owns task state.
7. Report `DONE: <summary of changes>` or `BLOCKED: <reason and what you tried>`.
```

Rule 5 is the one that matters. An agent told to "make the gates pass" will find
that editing the threshold is the cheapest path. Name the cheat so it is not
mistaken for compliance.

### 5. INNER GATES

```bash
python3 .agent/tools/harness.py gate run --lane inner --scope diff
```

Budget: 300s. On failure, read the remediation — every gate emits an
actionable one. Fix the root cause, re-run. After 3 attempts on the
same gate:

```bash
python3 .agent/tools/task.py block "inner gate <id> fails: <what you tried>"
```

Blocking is a legitimate outcome. Spinning is not.

### 6. OUTER GATES

```bash
python3 .agent/tools/harness.py gate run --lane outer --scope full
```
Runs `e2e-workflows` (drives the built CLI, about 2 minutes) and `vulnerable-packages` (needs NuGet network access). Run it once per task, synchronously. Platform build checks (`e2e-build`, `desktop-validation`) need Windows or macOS and are separate skills; a platform this host cannot build is reported as unverified, never as passed.

### 7. REVIEW

`DELEGATE` a review using `.agent/agents/reviewer.md`. Give it:

- `git diff <baseSha>..HEAD`
- the task file
- `.agent/project-context.md`
- `.agent/evidence/<ID>/gate-summary.json`
- the defect catalog: `.agent/skills/harness-creator/catalogs/defects-dotnet-ui.md (used for WinForms/WPF/WinUI disposal and threading rules; the MAUI, Blazor and wizard items in `agents/wizard-consistency-reviewer.md` take precedence)`

The reviewer must not re-litigate the gates. Its job is what tools cannot check:
spec conformance, abstraction, boundaries, and framework-specific defect patterns.
Every finding it returns carries a `Verify:` line stating how the fix is confirmed.

Write findings into `## Review`. Then:

```bash
python3 .agent/tools/task.py review       # requires passing gates
# fix findings, re-run gates
python3 .agent/tools/task.py reject --reason "..."   # only if returning to BUILD
python3 .agent/tools/task.py approve
```

### 8. DONE

```bash
python3 .agent/tools/task.py done
```

Refuses unless gate evidence passes and its commit matches HEAD. If the task
touched a risk-gated path (`*.csproj`, `Directory.Packages.props`, `Directory.Build.props`, `global.json`, `nuget.config`, `Jenkinsfile`, `build/**`, `Commands/**`, MAUI catalog JSON, `BlazorCatalog.cs`, `Core/NuGet/**`) it halts for human approval:

```bash
python3 .agent/tools/task.py done --approved-by "<name>"
```

**Do not use `--override` to get past a refusal.** It exists for genuine tooling
outages, requires a reason, and is written permanently to `journal.jsonl`. Using
it to bypass a real failure is falsifying the record.

### 9. LEARN

1. `## Log` in the task file: decisions, dead ends, what a future session needs.
2. One line appended to `.agent/progress.md`.
3. If architecture changed, update `.agent/project-context.md`.
4. Occasionally: `python3 .agent/tools/harness.py ratchet` — if the project now
   clears a threshold comfortably, propose raising it.

### 10. Completion

The project is complete only when **all** of:

1. every `todo` task is `done`
2. every `backlog` item is promoted or explicitly deferred with a reason
   (`task.py defer <id> "<reason>"`) — an unevaluated backlog is not completion
3. full-scope gates pass on the whole project:
   `harness.py gate run --lane all --scope full`
4. `harness.py doctor` is healthy
5. the original goals in `progress.md` are met

Then write `PROJECT COMPLETE — <summary>` in `progress.md`.

---

## Boundaries

- **Never edit `.agent/tasks/index.json`.** `task.py` owns it. Hand edits corrupt
  the done-ledger and break dependency resolution.
- **Never edit `.agent/evidence/`.** Gates write it; fabricating evidence is the
  worst possible failure in this system.
- **Never lower a threshold in `harness.yaml`** to make a gate pass. The ratchet
  floor in `harness.lock` fails `validate` in CI.
- **Never create a task without a spec.** "Fix the bug" is not a task.
- **Never work outside a task.** If the user asks for something directly, create
  a task and run the loop. The loop is what produces the evidence trail.

## Anti-patterns

1. Coding directly on a user request instead of creating a task
2. Skipping SPEC because the task "looks small" — the criteria are what gates check
3. Asserting a tool-checkable claim (see the table at the top)
4. Making a gate pass by weakening it
5. Continuing past the retry limit instead of blocking
6. Marking a task done while its outer gates are still pending
7. Reviewing without reading the gate evidence first, then contradicting it

## Command reference

```bash
# task state
python3 .agent/tools/task.py next|status|list|info T-XXX|doctor
python3 .agent/tools/task.py add "title" [--needs T-XXX] [--backlog]
python3 .agent/tools/task.py review|approve|reject|done
python3 .agent/tools/task.py block "reason" | unblock T-XXX
python3 .agent/tools/task.py promote T-XXX | defer T-XXX "reason"
python3 .agent/tools/task.py verify-submit --job "<id>"
python3 .agent/tools/task.py rollback T-XXX [--force]
python3 .agent/tools/task.py archive

# gates and contract
python3 .agent/tools/harness.py gate run [--lane inner|outer|all] [--scope diff|full]
python3 .agent/tools/harness.py gate list|submit|poll
python3 .agent/tools/harness.py validate|lock|doctor|tier|ratchet
python3 .agent/tools/harness.py explain "<claim>"
```

---
id: feature
kind: workflow
version: 1
appliesTo: [all]
invokes: [spec-writer, task-planner, implementer, test-engineer, code-reviewer, wizard-consistency-reviewer, generated-project-validator, package-integrity-auditor]
requires: [definition-of-done, pr-review]
binding: [spec-before-code, tests-from-spec, never-weaken, one-task-in-flight, cite-the-source, emit-do-not-creep, design-system, verify-generated-output, preserve-user-files, no-unrelated-change]
---

# feature — new capability

## 1. SPEC — `spec-writer`

Write `## What` in the task file:

- **Behaviour**: what the system does that it did not before
- **Scope boundary**: what this task explicitly does *not* cover
- **Acceptance criteria**: each one checkable by a tool or a test

> "Handles errors gracefully" is not a criterion.
> "Returns 400 with a ProblemDetails body when `orderId` is malformed, covered by a
> test" is.

Consult sources per `references/oracles.md` and **cite the deciding rank**. Anything
the sources leave open goes under *Open questions* with an assumption, a pin, and a
`PROJECT-STATE.md` entry — see `policies/autonomy-boundary.md`.

## 2. PLAN — `task-planner`

`## Plan` as dependency-ordered subtask checkboxes, each one commit's worth.

**Each behaviour-adding subtask names the test that will cover it.** If you cannot
name the test, the subtask is not specified yet — return to SPEC.

Slice vertically: a thin end-to-end path beats a horizontal layer, because it can be
verified.

## 3. TEST FIRST — `test-engineer`

Write tests **from the specification**, before implementation.

Order matters and is not ceremony: a test written after the code encodes what the
code does, and will pass whether or not the code is right. A test written from the
spec encodes what was asked for.

Each test names the acceptance criterion it covers.

## 4. IMPLEMENT — `implementer`

One subtask at a time. After each: tick the box, run inner gates, commit.

- Follow `project-context.md` for placement, conventions, and boundaries
- Consult `knowledge/` for framework behaviour rather than recalling it
- Never modify a path under **Boundaries**
- **Never weaken a gate to pass it** (`policies/never-weaken.md`)

## 5. VERIFY

Inner lane after each subtask; outer lane once at the end. Read the remediation — it
names the uncovered line, the surviving mutant, or the analyzer rule id.

## 6. REVIEW — `code-reviewer`

Delegated with the diff, the task file, `project-context.md`, the gate evidence, and
the stack defect catalog. Every finding carries a `Verify:` line.

## 7. CLOSE

`checklists/definition-of-done.md` → commit → `task.py done` → update
`PROJECT-STATE.md` → emit follow-ups as new tasks.

## Definition of done

- [ ] Every acceptance criterion has a passing test naming it
- [ ] Inner and outer gates pass at the current commit
- [ ] Diff coverage meets threshold
- [ ] Public-facing behaviour documented
- [ ] Review findings resolved or filed as tasks
- [ ] Open questions recorded with assumption + pin + log entry

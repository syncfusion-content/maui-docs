# Progress — Syncfusion .NET CLI

<!-- Cross-session memory. One line per completed task, plus a Goals section that
     the completion check reads. Written during LEARN. -->

## Goals

<!-- The original objective. Task 10's completion criteria are judged against
     this, so state it concretely. -->

Keep `sf` command parsing, the interactive wizard, project generation for MAUI/WPF/WinForms/WinUI/Blazor, package add/remove/update and terminal rendering correct, verified by generated output and not by unit tests alone.

## Harness

- Created 2026-10-14 · tier L1 · profile dotnet-common · overlay syncfusion
- Contract v1.0 · 14 gates
- Baseline red on arrival: 5 tests (see PROJECT-STATE.md). Not hidden: `known-failing` reports them.

## Log

<!-- Format: DATE  T-XXX  what changed  |  evidence verdict  |  anything learned -->
- 2026-10-28 T-011: Removed home-menu height-based paging and enabled visible overflow so all choices render in each frame. Build, all 25 home-menu tests, helper tests and integrity gate passed. Packed and smoke-tested preview.3. Broader T-008 acceptance blockers remain unchanged.
- 2026-10-28 T-010: Added one blank row between menu categories and deeper aligned option/continuation indentation; adjusted page capacity. Release build and all 20 home-menu tests passed. Packed preview.2 and verified archive, isolated installation and sf --help. Full-suite blockers from T-008 remain; no gate override.
- 2026-10-28 T-009: Packed Syncfusion.DotNet.CLI 0.1.0-preview.1 locally (2,563,071 bytes); archive metadata/content validation, isolated installation and installed sf --help all succeeded. No publication or global install. Full release acceptance remains blocked by T-008 gate failures.
- 2026-10-28 T-008: Repaired portable harness helpers, lock paths, policy hashing and E2E assembly target; added bold uppercase home-menu headings with icons. Build, 16 home-menu checks, 10 helper tests, policy integrity and package audit passed; doctor HEALTHY. BLOCKED: broader suite 89 failures, workflow E2E 13 failures, interactive E2E requires POSIX termios. No thresholds lowered or completion override used.

# Project state

**Project**: Syncfusion .NET CLI (`sfdotnet`), .NET 10, five platform providers (MAUI, Blazor, WPF, WinForms, WinUI)
**Phase**: harness established; brownfield, no frozen roadmap
**Tier**: L1 (tests exist; one known-red group tracked in tasks)
**Harness generated**: 2026-10-14

## Baseline measured on arrival (Linux, .NET 10.0.100)

- Unit suite: 1019 tests, 1014 pass, **5 fail** (4 distinct tests, 2 are theories), about 5 s
- Regression ledger: 28 entries, all present and passing
- E2E workflows: 100 checks across WPF/WinForms/WinUI/Blazor, all pass; MAUI skipped (template and workloads not installed here)
- `dotnet list package --vulnerable`: none
- `dotnet format --verify-no-changes`: **fails on untouched code** (no `.editorconfig`), so no format gate was emitted

## Known failures (tasks T-001, T-002)

| Test | Cause observed |
|---|---|
| `PdfViewerResourcesMatchCatalogNames`, `ProjectEmbeddingExcludesMacMetadata...` | resolve `src/...` from `[CallerFilePath]` with `..\..`, which is one level too far in `tests/` (found `/home/user/src/...`) |
| `InvalidExplicitTargetFramework_FailsBeforeProjectNameQuestion` | message text differs from "is not a valid value for --framework" when the MAUI template is absent |
| `NameConflictAllowsReentryWithoutChangingExistingDestination` (file, dir) | rendered text assertion fails; cause not yet diagnosed |

## Unverified on this host

- WPF, WinForms, WinUI: generation verified, **build not run** (needs Windows)
- MAUI: generation, workloads and Xcode validation not run (needs MAUI workloads; Apple targets need macOS)
- Live terminal behaviour on Windows conhost and macOS Terminal

## Open decisions

See `DECISIONS-REQUIRED.md` (1 open: CI system).

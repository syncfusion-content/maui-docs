# Project Context — Syncfusion .NET CLI

**Stack**: .NET 10 (`global.json` 10.0.100), C#, System.CommandLine, Spectre.Console, xUnit, central package management
**Profile**: dotnet-common · overlay syncfusion
**Tier**: L1 — tests exist and gate; the test suite is the main oracle, so generated output is verified separately (`policies/verify-generated-output.md`)

This is a CLI tool that writes files into customers' projects. It is not a UI application, so the UI profiles do not apply.

## Architecture

<!-- GENERATED from `dotnet list reference` on 2026-10-14, not inferred. -->

```
Syncfusion.DotNet.CLI  (executable: commands, wizard, presentation)
  ├─> Core        (contracts, paths, NuGet runner, Core/Desktop shared orchestration)
  ├─> Maui        ─> Core
  ├─> Blazor      ─> Core
  ├─> WPF         ─> Core
  ├─> WinForms    ─> Core
  └─> WinUI       ─> Core
Tests ─> Syncfusion.DotNet.CLI
```

Platform assemblies reference only Core and never each other. Core references no platform assembly.

### Where things go

| Change | Location |
|---|---|
| command definitions, options, parsing | `src/Syncfusion.DotNet.CLI/Commands/`, `Options/`, `Parsing/` |
| wizard prompts and navigation | `src/Syncfusion.DotNet.CLI/Wizard/` |
| console output, progress, previews | `src/Syncfusion.DotNet.CLI/Presentation/` |
| logic shared by every platform | `src/Syncfusion.DotNet.CLI.Core/` |
| shared desktop (WPF/WinForms/WinUI) orchestration | `Core/Desktop/` |
| platform catalogs, themes, templates, generation | the platform's own project |
| MAUI package/template catalogs | `Syncfusion.DotNet.CLI.Maui/Catalog/*.json` (descriptive data, not a service) |
| tests | `tests/` (one project; add to the class for the area) |

Before adding code to one platform, check Core and the other providers: duplicated implementations are how the platforms drifted apart. See `docs/architecture.md`.

### Change hotspots

The repository has a single commit, so there is no churn history to rank files by. Defect history comes from the regression ledger instead: `scripts/harness/regression-ledger.json` (28 classes, wizard/terminal and package-operation areas dominate).

## Conventions

### Enforced by tooling

- `TreatWarningsAsErrors`, `Nullable`, `EnforceCodeStyleInBuild`, `AnalysisLevel=latest` (Directory.Build.props) — `build` gate
- central package versions only in `Directory.Packages.props` — `ManagePackageVersionsCentrally`
- 28 regression classes still have a passing test — `regression-ledger` gate
- test-count floors per area — `area-*` gates

### Not yet enforced

- No `.editorconfig`, so formatting is not enforced (`dotnet format --verify-no-changes` fails on untouched code). Adding one is a separate task.
- Terminal behaviour on real Windows and macOS terminals is not testable on Linux CI.

## Boundaries

**Never modify:** `.agent/policies/`, `.agent/workflows/`, `.agent/agents/`, `.agent/checklists/` without re-locking (`harness.py cp-lock`); `scripts/harness/regression-ledger.json` rows may be added, never removed to make a gate pass.

**Requires human approval** (`task.py done` halts on these): `*.csproj`, `Directory.Packages.props`, `Directory.Build.props`, `global.json`, `nuget.config`, `Jenkinsfile`, `build/**`, `Commands/**`, MAUI catalog JSON, `BlazorCatalog.cs`, `Core/NuGet/**`.

## Verification

Do not run these ad hoc; `harness.py` runs them and records evidence.

### Inner lane (budget 300 s; measured about 40 s for build + tests)

`build`, `tests`, `known-failing` (warn), `area-command-parsing`, `area-wizard-flow`, `area-project-creation-flow`, `area-terminal-rendering`, `area-project-generation`, `area-package-operations`, `regression-ledger`, `coverage-diff`, `catalog-audit-tests`, `harness-verify`.

### Outer lane (once per task)

`e2e-workflows` (about 2 minutes, drives the built CLI), `e2e-interactive-wizard` (about 2 minutes, drives the interactive wizard through a pty on all five platforms), `vulnerable-packages` (needs network).

Not in either lane because they need another OS: `e2e-build` (generated-project build) and `desktop-validation` (Windows). A platform not built on this host is **unverified on this host**, never passed.

```bash
python3 .agent/tools/harness.py gate run --lane inner --scope diff
python3 .agent/tools/harness.py gate run --lane outer --scope full
python3 scripts/harness/e2e_workflows.py --platforms wpf --out /tmp/wpf.json   # one platform
```

## Knowledge

`.agent/knowledge/` holds guidance cited to this repository's own documents. No external documentation was fetched; see the stub files for what remains unretrieved.

## Testing approach

- Behaviour tests drive the real command tree and the wizard through injected key queues and `AnsiConsole.Create`, with `ConsoleCapture` for stdout/stderr (see `tests/FlowPresentationTests.cs`).
- A fixed bug gets a test that fails for the original reason, plus a row in the regression ledger.
- Generated output is checked by `scripts/harness/e2e_workflows.py`, which runs the built `sf.dll` in a temp directory and asserts on files.
- Fakes (`FakeNuGetRunner`, `FakeDotNetRunner`) replace process execution in unit tests, so unit tests cannot show that a real `dotnet new` or restore works.

## Known debt

- 5 failing tests on a clean checkout (T-001, T-002); excluded from `tests`, reported by `known-failing`.
- No `.editorconfig`; no formatting gate.
- Docs reference `.github/workflows/desktop-validation.yml`, which does not exist in this repository.
- `tools/catalog-audit/__pycache__/` was committed.
- `docs/architecture.md` lists the test project as a directory `tests/Syncfusion.DotNet.CLI.Tests/`; it is `tests/` itself.
- CI for the PR lane and the OS matrix is undecided (DECISIONS-REQUIRED.md #1).

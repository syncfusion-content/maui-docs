# CLI presentation changes and validation

This change starts from `5422063` (the existing project/control and final-review fixes). It changes console presentation and adds optional stage observers; commands, argument defaults, service result messages, JSON serializers, and generated app templates remain compatible.

## Changes by phase

1. **Presentation primitives:** [ColorPolicy](../../src/Syncfusion.DotNet.CLI/Presentation/ColorPolicy.cs) centralizes color/live-output decisions. [ConsolePresenter](../../src/Syncfusion.DotNet.CLI/Presentation/ConsolePresenter.cs) provides green `✓` success messages and stderr `Warning:`/`Error:` messages with one prefix. [SummaryRows](../../src/Syncfusion.DotNet.CLI/Presentation/SummaryRows.cs) extracts the existing final-review alignment and lossless wrapping, retaining the review's output.
2. **Progress:** [ConsoleProgress](../../src/Syncfusion.DotNet.CLI/Presentation/ConsoleProgress.cs) prints `[n/N] label` without a percentage. [OperationProgress](../../src/Syncfusion.DotNet.CLI/Presentation/OperationProgress.cs) uses an indeterminate status spinner only on a color-enabled terminal, plain stage lines otherwise, and no progress stdout for JSON/internal silent mode. Optional observers in [PackageOperationService](../../src/Platforms/Syncfusion.DotNet.CLI.Maui/Packages/PackageOperationService.cs), [ControlInstaller](../../src/Platforms/Syncfusion.DotNet.CLI.Maui/Packages/ControlInstaller.cs), [ControlRemovalService](../../src/Platforms/Syncfusion.DotNet.CLI.Maui/Packages/ControlRemovalService.cs), and legacy removal report work that actually occurs. [NuGetRunner](../../src/Syncfusion.DotNet.CLI.Core/NuGet/NuGetRunner.cs) observes restore messages while preserving the captured diagnostic text. New-project console output hides inactive package/registration/restore/build steps, retaining the public seven-step callback contract and its planned step numbers.
3. **Messages and summaries:** [CommandOperations](../../src/Syncfusion.DotNet.CLI/Commands/Operations/CommandOperations.cs) uses `Apply these changes?` with the original confirmation defaults. Prompt declines/Escape use `Cancelled. No changes made.` and retain cancellation code 130. [CompletionSummary](../../src/Syncfusion.DotNet.CLI/Presentation/CompletionSummary.cs) formats existing package/sample/build/deletion/retention/version facts exclusively in non-JSON output. Warnings go through `WriteWarning`. [NewCommand](../../src/Syncfusion.DotNet.CLI/Commands/NewCommand.cs) gives a retained-project build failure one headline, its generated location, an actionable cause, and next commands.
4. **Errors:** [ConsoleDiagnostics](../../src/Syncfusion.DotNet.CLI/Presentation/ConsoleDiagnostics.cs) gives short version, SDK/workload/feed, framework, ownership, and unexpected-error guidance. Raw tool/stack diagnostics are verbose-only; explicit NuGet source/config values are redacted even there and in dry-run console commands. Rollback is not inferred merely from a planned command. Unexpected invocation errors retain the parser's existing exit code 1 and existing JSON stdout; the entry-point fallback still returns 70. JSON result messages and diagnostic fields are not reformatted.
5. **Flow and discovery:** [InteractivePrompt](../../src/Syncfusion.DotNet.CLI/Wizard/InteractivePrompt.cs) can validate a custom name against a known destination during entry. If the parent is selected later, the wizard returns to name entry on a collision. Default suffix resolution is unchanged. [ListCommand](../../src/Syncfusion.DotNet.CLI/Commands/ListCommand.cs) uses [TableRows](../../src/Syncfusion.DotNet.CLI/Presentation/TableRows.cs) for one content-sized header and aligned installed-package/control columns, including unknown aliases. [PackageListRenderer](../../src/Syncfusion.DotNet.CLI/Presentation/PackageListRenderer.cs) says `More packages? (Enter = more)` without changing pagination defaults. [InfoCommand](../../src/Syncfusion.DotNet.CLI/Commands/InfoCommand.cs) aligns existing labels without adding fields.

`PlainPromptConsole` filters style and cursor segments while retaining selection, multiple-selection, and text input. `ProjectWizardOutput` erases owned completed rows only in live mode. On Unix, native runtimes and child SDK commands can emit keypad ANSI through the controlling terminal despite captured stdout/stderr. The entry point therefore scopes `TERM=dumb` and `NO_COLOR` to plain-mode execution, including child tools; interactive input remains enabled. Settings are restored on scope disposal, including failure.

## Before and after

| Before | After |
| --- | --- |
| `[2/7] Creating project from MAUI template (29%)` | `[2/7] Creating project from MAUI template` |
| `Would you like to add these controls?` | `Apply these changes?` |
| `Package addition declined.` | `Cancelled. No changes made.` |
| `warning: Retained package ...` on the error/info path | `Warning: Retained package ...` on stderr |
| Invalid-version text embedding the child diagnostic | `Error: '1.x' is not a valid NuGet version. No changes made. Use a value such as 32.1.29 with --version.` |
| Success headline followed by a failed-build headline and repeated creation story | `Error: Project created, but the build failed.` followed by location, retained-project guidance, cause, and commands |

Example control completion, with a shortened fixture path for readability:

```text
  Adding packages
  Restoring
  Generating files
  Registering in MauiProgram.cs
  Building
✓ Control add completed.
Project:  /tmp/parent with spaces/App/App.csproj
Controls: DataGrid
Packages: restored required references
Samples:  applied 1 control(s)
Build:    succeeded (all configured targets).
```

Example build failure:

```text
Error: Project created, but the build failed.
Generated location: /tmp/parent with spaces/App
The generated project is available for fixing and rebuilding.
Error: Required .NET workloads are missing (NETSDK1147). Run dotnet workload restore for the project, then retry.
Next commands:
  cd "/tmp/parent with spaces/App"
  dotnet build "/tmp/parent with spaces/App/App.csproj"
```

Example installed-package alignment, including a package without a catalog alias:

```text
Installed Syncfusion MAUI packages:
  Alias     NuGet                     Version
  datagrid  Syncfusion.Maui.DataGrid   32.1.29
            Syncfusion.Maui.Unlisted  1.0.0
```

The existing available-package heading, `Alias`, `Name`, `NuGet` columns, grouping, blank lines, MCP listing filter, and metadata are unchanged.

## Automated validation

Commands used after each phase:

```sh
dotnet build sf-net-cli.slnx --artifacts-path /workspace/setup/artifacts \
  -p:RestorePackagesPath=/workspace/setup/nuget/packages
dotnet test sf-net-cli.slnx --no-build --artifacts-path /workspace/setup/artifacts
```

| Checkpoint | Build | Tests |
| --- | --- | --- |
| Original baseline | Passed | 471 passed |
| Phase 1 | 0 warnings, 0 errors | 479 passed |
| Phase 2 | 0 warnings, 0 errors | 497 passed |
| Phase 3 | 0 warnings, 0 errors | 499 passed |
| Phase 4 | 0 warnings, 0 errors | 503 passed |
| Phase 5 | 0 warnings, 0 errors | 507 passed |
| Final terminal/error compatibility checks | 0 warnings, 0 errors | 512 passed, 0 failed, 0 skipped |

Coverage includes color-policy flags/redirection/environment; plain prompt input; no ANSI/percentage output; stage ordering and no-restore/no-build/shared-package/no-op variants; retained-project build failure; default versus verbose diagnostics; source/config redaction; exact package JSON; aligned installed tables; name retries against files/directories; skipped blank-generation stages; terminal-setting restoration; and preflight failures that must not claim a rollback. Existing live prompt tests still assert wrapped-hint cleanup and preservation of unrelated terminal output; they explicitly run with color/live output allowed. Their remaining assertions were retained.

A Release NuGet tool package was created and installed into a fresh isolated local tool directory. The installed `sf` passed `info --json`, package-list heading/header/filter checks, and invalid-version guidance checks.

## Manual validation

- **67 command captures using a deterministic child-host fixture**, across TTY, redirected output, `--no-color`, and `--json`: new with arguments; forced post-creation build failure; package inputs add/update/remove; control add/remove; available/installed package lists; available/installed control lists; interactive name-conflict retry and decline; missing arguments; `NO_COLOR`; and invalid-version output. This covers presentation/error handling without depending on live NuGet availability or unavailable Apple tools.
- **13 byte-for-byte JSON stdout and exit-code comparisons** against a separately built original CLI at `5422063`, using the same project paths and restored fixture snapshots: new, info, package add/update/remove, control add/remove, installed packages/controls, available packages/controls, search, and partial creation/build failure. These comparisons are included in the capture set, not an additional 67 runs.
- **Six native TTY captures**: arrows and Space selected two controls and generated both samples in live and no-color modes; Escape and Ctrl+C retained code 130 in both modes. Live completed hints/options were cleared. Plain modes had no ANSI.
- **18 real SDK captures** with .NET SDK 10.0.100: blank MAUI generation and package no-restore add/update/remove in all four modes, plus real DataGrid restore/generation/build and removal/build from a project directory containing spaces. The real control fixture was explicitly restricted to `net10.0-android` before these operations because this Linux environment cannot build Apple targets. Both default builds succeeded for that fixture's configured target; production project configuration was not changed.
- A parent-directory argument pointing to an existing file retained the file and showed its directory-selection fix. A further byte-for-byte JSON/exit-code comparison matched the original CLI (14 payload comparisons in total).
- A non-executable child host verified an unexpected launch failure against the original CLI: unchanged exit code 1 and unchanged empty JSON stdout, raw exception details only under verbose, and source/config redaction in both normal and verbose output.
- Fixture command logs confirmed default builds were exactly `build <full-project.csproj>` with no `-f` or forced framework property. Existing default/explicit/OS-conditioned build tests remain passing. No progress lines contained percentages.

Build/test, fixture, real SDK, navigation, package, and local-tool logs were kept in `/workspace/setup/presentation-*` for review.

## Limits and changes deliberately avoided

- Native Windows, iOS, and Mac Catalyst execution was not available in this Linux environment. Android compilation was verified; app UI/layout and emulator screenshots were not repeated for this presentation-only change. Build-command/OS-condition behavior remains covered by the existing tests.
- Plain append-only output cannot erase previous prompt frames/hints or replace completed wizard rows without cursor control. Those modes therefore retain their input transcript; live terminals still clear temporary content and show one final configuration block. This follows the explicit no-ANSI/append-only constraint.
- This CLI has no `--silent` option. Internal progress helpers honor silent suppression, but no new CLI option was added.
- `sf list maui controls` is not an existing category. Its error behavior was preserved in all four modes. Available controls remain accessible via `sf list maui templates`; installed controls use `sf list maui --template --installed`. No alias was added.
- Package removal does not perform a standalone restore, so no fictitious `Restoring` stage or new restore call was added. Existing restore order and all build/restore defaults were retained.
- Ctrl+C can occur after mutation or successful creation, so its general cancellation message was retained rather than falsely claiming that no changes were made. Prompt declines and Escape use the standardized no-changes message.
- JSON schemas, serialized `Message` strings, catalog metadata, generated app templates, command defaults, confirmation defaults, and service execution/rollback behavior were not changed to simplify presentation. No options, integrations, or MCP/skill implementation were added.

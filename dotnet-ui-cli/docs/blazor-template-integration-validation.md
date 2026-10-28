# Blazor template integration and verification

The new Web and Wasm feature templates are now the actual embedded CLI sources.
The previous Grid, Charts, Scheduler, Gantt, Diagram, Rich Text Editor and File
Manager templates were replaced. Document Editor, PDF Viewer, Spreadsheet,
Kanban and Query Builder remain under Shared because no replacements were supplied.
AI AssistView, Block Editor and Pivot Table were added to the catalog. There are
now 15 selectable controls and 17 catalog packages, including Core and Themes.

## Source layout

`src/Syncfusion.DotNet.CLI.Blazor/Templates/Controls/{Web,Wasm,Shared}/<alias>/`
contains consistently named `*Demo.razor` pages and matching C# partial classes
where logic/data exists. Routes use catalog aliases (for example `/grid`,
`/charts`, `/pivot-table`); welcome links and navigation use those same aliases.
Web App selects Web resources, including WebAssembly/Auto render modes;
standalone WebAssembly selects Wasm resources. Shared resources supply only the
five controls with no app-specific replacement. Render directives are resolved
for per-page/global modes and omitted for standalone WebAssembly.

The Razor/C# payloads preserve the supplied features and datasets. BOMs, editor
annotations and trailing whitespace were removed. New samples are embedded in
the CLI assembly, not loaded from a checkout or downloaded at generation time.
Pivot Table uses the official `Syncfusion.Blazor.PivotTable` NuGet package
(the namespace is PivotView). Diagram adds Inputs; Rich Text Editor adds
DropDowns. These dependencies are included even when selecting either sample alone.

## Measured proof

Executed on Linux with .NET SDK 10.0.100, official Microsoft templates and
Syncfusion 35.1.40 packages restored explicitly from nuget.org. This is coverage
of every offered option value on this SDK, not a guarantee for every machine,
all combinations of options, or all third-party control features.

| Check | Result | Evidence |
|---|---|---|
| Complete xUnit regression suite | 1,166 passed, zero failed/skipped | [test log](validation/blazor-templates/build-logs/regression-tests.txt) |
| Real terminal interactive wizard | 44 scenarios passed | [option results](validation/blazor-templates/interactive-results.json), [captured screens](validation/blazor-templates/terminal-screens) |
| Fresh CLI-generated app matrix, all 15 controls | 7 generated and built, zero warnings/errors | [matrix](validation/blazor-templates/build-results.json), [logs](validation/blazor-templates/build-logs) |
| Diagram and Editor independently, both app types | 4 generated and built | [isolated results](validation/blazor-templates/isolated-results.json) |
| Chromium runtime checks | 30/30 routes HTTP 200, rendered Syncfusion elements, no visible Blazor error UI or uncaught page errors | [browser results](validation/blazor-templates/browser-results.json) |
| Resource/source consistency | Both app variants and all 15 controls tested | BlazorPlatformTests.EmbeddedControlPayloadMatchesTheSelectedAppTypeSources |

The seven build cases cover Server, WebAssembly and Auto, each with per-page
and global interactivity, plus standalone WASM. Server/global also includes
Individual Accounts. Every case contains all 15 controls; generated server/client
placement and resource names therefore pass Razor/C# compilation together.
The four isolated cases prevent the all-controls project from masking missing
dependencies. Browser runtime checks used Server/per-page and standalone WASM.

## Interactive option coverage

| Option | Selected and reviewed |
|---|---|
| Application type | Web App, WebAssembly Standalone |
| Framework | net10.0, the only framework offered by the installed templates; automatically recorded |
| Render mode | Server, WebAssembly, Auto |
| Interactivity | Per page/component, Global |
| Authentication | None, Individual Accounts; HTTPS automatically required for Individual |
| HTTPS | Yes and No for both app types where selectable |
| Project name/location | Explicit parent location and typed unique names |
| Setup | Empty and Include Syncfusion controls for both app types |
| Controls | All 15 individually; all 15 together in Web App and WASM; picker initially empty |
| Theme | All five themes, both app types |
| Post-create | Generate only and Build project, both app types |
| Final review/cancellation | No Language row; controls precede Theme; answer No cancels without project files |

The interactive scenarios cancel at final confirmation to avoid creating dozens
of duplicate applications. They prove selection/review behavior; the separate
fresh generation/build matrix verifies resulting project compilation. They do
not claim that each interactive case executed its post-create operation.

## Reproduce the terminal checks

Build the CLI, install Python's `pexpect` and `pyte`, then run from the repository:

```sh
python scripts/validate-blazor-interactive.py \
  --cli src/Syncfusion.DotNet.CLI/bin/Debug/net10.0/sf.dll \
  --output /tmp/blazor-option-evidence
```

Use `--dotnet /path/to/dotnet` or an alternate built CLI path as needed. The
script records ANSI transcripts, terminal screen projections and JSON results,
returns nonzero on failure, and checks that cancellation creates no project files.
`--case-name` can select named scenarios. The recorded run used 41 scenarios
plus the three additional standalone cases; the default script includes all 44.

## Limits

Windows/macOS native terminal checks were not run here. The existing three-OS
GitHub terminal workflow was previously blocked before execution by the account
billing/spending limit; it must run successfully before claiming native OS parity.
Other target frameworks were not offered by this SDK's templates. External
service operations (file upload/download, document conversion, AI backend
integration), account registration/database migration, every theme/control/render
combination and complete feature-level interaction were not exhaustively tested.
The supplied remote demo URLs remain in the samples; AI returns a local example
response until connected to an AI provider. Production use requires a Syncfusion
license. AGENTS.md references an absent `.agent` harness; normal build/test checks
were used.

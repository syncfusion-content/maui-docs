# WinUI control templates

Five opt-in templates are embedded in the WinUI platform assembly and copied by
both project generation and managed-project `sfdotnet add`:

| Interactive label | Alias | Generated page | Package |
|---|---|---|---|
| Charts | `chart` | `Chart/ChartPage.xaml` | `Syncfusion.Chart.WinUI` |
| DataGrid | `datagrid` | `DataGrid/DataGridPage.xaml` | `Syncfusion.Grid.WinUI` |
| DockingManager | `docking-manager` | `DockingManager/DockingManagerPage.xaml` | `Syncfusion.DockingManager.WinUI` |
| Ribbon | `ribbon` | `Ribbon/RibbonPage.xaml` | `Syncfusion.Ribbon.WinUI` |
| TreeGrid | `treegrid` | `TreeGrid/TreeGridPage.xaml` | `Syncfusion.Grid.WinUI` |

Each page has a `.xaml.cs` file. Charts, DataGrid and TreeGrid also have independent
view models, with 12 monthly data points, 50 orders/eight columns, and 21 employees
in three teams respectively. Ribbon commands operate on its document editor.
DockingManager includes a document and movable/resizable tool panes. Welcome
sample buttons wrap as available width changes. Samples use
bounded, stretched layouts without background or foreground overrides.

The existing `chart` alias is preserved. Welcome buttons and Pivot items use
control aliases for navigation rather than positional indexes. The provider uses
the shared desktop lifecycle for owned source generation, collision checks,
rollback and dependency alignment. DataGrid and TreeGrid share one package;
adding by that ambiguous package ID requires a control alias. Updates preserve
sample edits. Public removal remains temporarily disabled; internal lifecycle
coverage continues to check safe removal and shared-dependency retention.

## Verification on Linux

- CLI build: zero warnings/errors.
- Full suite: **1,226 passed, one failed, zero skipped**. The failure is
  `MauiControlLayoutTests.ControlSourcesDoNotCreateCustomColorsOrBrushes`:
  MAUI Diagram uses `Color.FromArgb`. The same test fails on a separate, clean
  `development` checkout at `07aa9cc`; this change does not modify MAUI sources.
- Generation tests cover all **32 control combinations across three target
  frameworks**. They check complete XAML/code-behind pairs, class/namespace
  matching, welcome/navigation registration and unique dependency selection.
- Picker tests select each of the five controls independently from an empty
  selection. A real terminal check displays all five unchecked, selects all five,
  reaches confirmation and cancels without creating a project.
- Shared lifecycle tests now include WinUI: sequential add/update, preservation
  of edits, rollback after failed restore, dry-run, unowned-file collisions,
  migration of an earlier owned host and retention of the shared Grid package.
- Live CLI generation with all controls passed for `net8.0`, `net9.0` and
  `net10.0`. A blank project's five sequential adds and five updates passed;
  customized source survived updates. Public removal was rejected.
- A fresh all-controls project restored from **nuget.org**, using explicit
  Syncfusion version **35.1.40**. Syncfusion XAML types, 100 members and enum
  values were resolved against the restored assembly metadata.
- All generated C# sources compiled against the restored references with stubs
  only for XAML-generated fields and `InitializeComponent`. This checks source
  API compatibility, but does not replace native XAML compilation. Compiler
  warnings included the Windows App SDK's older System.Runtime reference and
  unused stub fields.
- Generated models were compiled and executed separately: 50 orders, 12 monthly
  sales points and 21 employees with valid parent/child relationships.

The existing Windows desktop CI script now includes each of the five controls,
blank projects, the existing Chart/DataGrid pair and an all-controls project
for each supported target framework. These native CI results remain pending.
After opening PR #45, GitHub terminal jobs did not start: their check annotation
reports failed account payments or a spending limit that needs to be increased.
No native validation success is claimed from CI.

## Windows checks still required

A native build was attempted and stopped at the Windows-only `XamlCompiler.exe`
with an execution-format error on Linux. Windows XAML compilation, application
launch, visual sizing/resizing, light/dark rendering, keyboard/accessibility,
Ribbon clipboard actions and DockingManager drag/float behavior could not be
verified here. macOS/Linux cannot run native WinUI applications.

API/package references were checked against the official
[Syncfusion WinUI demos](https://github.com/syncfusion/winui-demos), including
TreeGrid SelfRelational, RibbonView and DockingManager GettingStartedView, and the
35.1.40 package metadata from nuget.org.

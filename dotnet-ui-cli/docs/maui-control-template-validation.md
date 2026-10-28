# MAUI control template layout and data validation

The actual embedded CLI templates under `src/Syncfusion.DotNet.CLI.Maui/Templates/`
were updated for all 10 selectable controls. Each primary control occupies a
star-sized Grid with fill alignment. Custom page backgrounds, label colors,
card indicators, appointment brushes, and the PDF border were removed. Sample
pages inherit standard MAUI resources and the controls' default theme styling.
This means filling the available page content area; native navigation and
platform chrome keep their normal behavior.

| Sample | Data / behavior |
|---|---|
| Cartesian Chart | 12 monthly revenue points |
| Circular Chart | 12 product categories |
| ListView | 75 unique entries; dynamic row height and wrapped text |
| DataGrid | 50 unique orders across 10 customers; 10 explicitly mapped columns |
| Scheduler | 21 appointments across seven days, including today |
| Kanban | 20 release tasks across four columns; default drag behavior |
| Diagram | Five nodes and four valid connectors; fit on creation and resize |
| AI AssistView | Example conversation and explicit local demonstration response |
| Rich Text Editor | Project notes/checklist; two-way HTML binding |
| PDF Viewer | Awaited document loading with loading/error states; no handler disconnection on page disappearance |

## Completed checks

- CLI build passed.
- 173 focused xUnit tests passed, including layout/theme regressions, template
  resource embedding, naming, catalog, and control add/remove lifecycle checks.
- Rendered the actual embedded template resources with resolved names into a
  standalone source-check project. All 10 pages' XAML and code-behind compiled
  using MAUI 10.0.0 SourceGen against real Syncfusion 35.1.40 references, with
  warnings treated as errors. No hand-written XAML-field/initialization stubs
  were used in the final source check.
- Executed the generated view models and verified the counts above, unique list
  entries/order IDs/card IDs, positive chart values, valid appointment intervals,
  connector endpoint integrity, and observable list collection notifications.
- Corrected a pre-existing resource-embedding test path so it resolves the current
  repository layout. Updated the editor binding assertion for explicit two-way mode.

## Platform limitations

A real `sf new maui` invocation selecting all 10 controls was attempted with
`--post-action generate --version 35.1.40`. It reached required package restore
and failed with `NETSDK1147`: the host has no MAUI workloads (`maui-android` is
required by the generated targets). The CLI rolled back creation as designed.

The source-check project is a platform-neutral compilation check, not a native
MAUI application build. Native rendering, resizing, light/dark appearance,
scrolling/drag interaction, PDF network failure/reopen behavior, and device
accessibility could not be verified on Android, iOS, Mac Catalyst, or Windows.
These require the corresponding workloads and a device, emulator, or desktop
runtime. PDF still downloads the official sample document; AI replies remain
local sample text. The `.agent` harness referenced by `AGENTS.md` is absent.

## Screenshot follow-up

Chart headings now occupy a separate full-width Auto row above the chart's
star-sized row, with centered text and a 24-point font. DataGrid uses
`ColumnWidthMode="Fill"` and ten formatted columns; per-column minimum widths
preserve readability with horizontal scrolling on narrow screens. Sample
models include dates, products, quantities, prices, and a calculated total with
change notifications. Source checks verified 75 ListView entries,
12 points per chart, valid totals, and total-change notifications.
Regression checks reject explicit colors/brushes in sample XAML and C#.

The screenshots showing Height Comparison with five people, four ListView
books, and blue page backgrounds match the earlier generated templates. These
changes apply to new projects generated with the rebuilt CLI. Existing generated
sample files are preserved by package updates and are not automatically replaced.

## Source, package, and generation consistency audit

The restored datasets remain 12 Cartesian points, 12 circular categories, and
75 ListView entries. No stale/duplicate template or binding mismatch was found.

- Built a fresh CLI tool package using a unique local audit version and installed
  it into an isolated tool directory, without changing the global installation.
- Compared all 44 installed control-template resources with their physical
  source files: every resource matched exactly. No old Height Comparison,
  four-book ListView, teal text assignment, or blue page override was found.
- Added regression checks comparing the three templates' embedded resources
  with source and comparing actual ControlInstaller-generated files with their
  resolved embedded templates. Verified welcome registry factories point to
  CartesianChartView, CircularChartView, and ListViewPage.
- All 88 tests in the resource, lifecycle, naming, and layout audit subset passed.

The installed CLI and generated project on the screenshot machine were not
available for inspection. An older tool build or an existing generated project
can retain the earlier content. Development builds currently share the default
package version, so the displayed version alone does not distinguish their
resources. Use a fresh package build/installation and a new project destination
when checking the latest templates; use a unique package version for local
package-install tests to avoid reusing an older package with the same version.
Native rendering remains subject to the platform limitations above.

# Syncfusion .NET CLI — current flow and options review

> MAUI currently offers only .NET MAUI App; Blazor Hybrid creation is temporarily disabled.
> Package removal is temporarily disabled across all platforms. The interactive
> remove option and every `sf remove` form are unavailable while improvements are
> in progress. Removal examples below document the preserved implementation.

Reviewed: 15 October 2026. Source snapshot: `3cb34f3`, branch `feature/blazor-control-templates` (includes PR #35). This documents implemented behavior, not a proposed redesign. Options may differ on an older installed CLI.

Package-source and version behavior was subsequently updated; see the [current package policy](nuget-package-policy.md). The snapshot below records the earlier flow review.

## 1. Entry points and shared behavior

Run `sf` in an interactive terminal to see these actions:

| Group | Options shown |
|---|---|
| Project creation | Create a new project |
| Package management | Add a package to an existing project; Remove a package from an existing project; Update a package in an existing project |
| Discovery | List available packages; List installed packages in an existing project; Search for packages |
| Help and information | View CLI information; Show help |
| Exit | Exit / Ctrl+C |

Actions that need a platform offer **.NET MAUI, WPF, WinForms, WinUI, Blazor**. Information and general help do not ask for a platform.

Navigation: Up/Down to navigate, Enter to choose; control checkboxes use Space to toggle and Enter to continue. Escape cancels; Ctrl+C exits. Control pickers start with no controls selected and require at least one selection when including controls. Single-choice menus focus the first option; this is separate from a checked control selection.

The create wizard is normally used when a project name has not been supplied. Supplying `--name` follows direct-command behavior and does not walk through the full wizard. `--no-interactive` disables prompts. Supplied options skip or populate their corresponding wizard fields.

New-project location defaults: Windows `%USERPROFILE%\source\repos`; Linux/macOS `~/Projects`. Project name suggestions are listed below; the first available numeric suffix is used on collision. Existing-project operations use the current directory unless a path is supplied or prompted.

| Platform | Suggested name | Language | Direct-command target default | Direct-command theme default |
|---|---|---|---|---|
| MAUI | SyncfusionMauiApp | C# | net10.0 | Standard MAUI styling; no theme picker |
| WPF | SyncfusionWpfApp | C# / VB; default C# | net10.0 | Windows11Light |
| WinForms | SyncfusionWinFormsApp | C# / VB; default C# | net10.0 | Office2019Colorful |
| WinUI | SyncfusionWinUIApp | C# only | net10.0 | Native |
| Blazor | SyncfusionBlazorApp | C# only | First supported SDK-template target, preferring net10.0 | fluent2 (when controls included) |

All five direct creation commands produce no selected control samples when controls are omitted. Direct creation defaults to building unless disabled; the interactive Post-create menu lists Generate only first. Confirmation follows the review summary before interactive creation.

## 2. MAUI creation

Flow: **Platform → project template → framework → project location → project name → setup → controls (conditional) → post-create → review/confirmation**.

| Step | Options shown / behavior |
|---|---|
| Platform | .NET MAUI (`maui`) |
| Project template | .NET MAUI App (`app`), recorded automatically without a picker; Hybrid creation temporarily disabled |
| Language | C# supported; no language picker |
| Framework | .NET 10 (`net10.0`); .NET 9 (`net9.0`); installed template/workload compatibility is checked separately |
| Location / name | User input, with suggested values above |
| Setup | Blank app; Include Syncfusion controls; Blank app first |
| Controls | The 10 choices below, alphabetically displayed, none checked |
| Theme | No theme picker |
| Post-create | Generate only; Build project. No Run choice in the current create flow |
| Confirmation | Review selected values; proceed or cancel |

Generate only can still require package restore for selected MAUI controls. Build targets all configured platform targets unless `--build-framework` is supplied. The framework menu does not select Android/iOS/Windows/Mac Catalyst individually.

| MAUI control label | CLI control ID |
|---|---|
| AI AssistView | `assistview` |
| Cartesian Chart | `cartesian-chart` |
| Circular Chart | `circular-chart` |
| DataGrid | `datagrid` |
| Diagram | `diagram` |
| Kanban | `kanban` |
| ListView | `listview` |
| PDF Viewer | `pdf-viewer` |
| Rich Text Editor | `rich-text-editor` |
| Scheduler | `scheduler` |

## 3. WPF creation

Flow: **Platform → language → target framework → theme → project location → project name → setup → controls (conditional) → post-create → review/confirmation**.

| Step | Options shown |
|---|---|
| Language | C#; VB |
| Target framework | .NET 10 (`net10.0`); .NET 9 (`net9.0`); .NET 8 (`net8.0`); .NET Framework 4.8 (`net48`); 4.7 (`net47`); 4.6.2 (`net462`) |
| Theme | Windows11 (Light) — `Windows11Light`; Windows11 (Dark) — `Windows11Dark`; Material3 (Light) — `Material3Light`; Material3 (Dark) — `Material3Dark`; Office2019 (Colorful) — `Office2019Colorful` |
| Setup | Empty project; Project with Syncfusion controls; Empty first |
| Controls | 9 choices below; none checked |
| Post-create | Generate only; Build project |
| Confirmation | Review selected values; proceed or cancel |

| Control label | CLI control ID |
|---|---|
| Chart | `chart` |
| DataGrid | `datagrid` |
| Diagram | `diagram` |
| DockingManager | `docking-manager` |
| Kanban | `kanban` |
| NavigationDrawer | `navigation-drawer` |
| Ribbon | `ribbon` |
| Scheduler | `scheduler` |
| TreeGrid | `treegrid` |

## 4. WinForms creation

Flow: **Platform → language → target framework → theme (fixed) → project location → project name → setup → controls (conditional) → post-create → review/confirmation**.

| Step | Options shown |
|---|---|
| Language | C#; VB |
| Target framework | net10.0; net9.0; net8.0; net48; net47; net462 (same labels as WPF) |
| Theme | Office2019 (Colorful), ID `Office2019Colorful`; only option, recorded without a picker |
| Setup | Empty project; Project with Syncfusion controls; Empty first |
| Controls | 5 choices below; none checked |
| Post-create | Generate only; Build project |
| Confirmation | Review selected values; proceed or cancel |

| Control label | CLI control ID |
|---|---|
| Chart | `chart` |
| DataGrid | `datagrid` |
| Diagram | `diagram` |
| DockingManager | `docking-manager` |
| NavigationDrawer | `navigation-drawer` |

## 5. WinUI creation

Flow: **Platform → language (fixed) → target framework → theme (fixed) → project location → project name → setup → controls (conditional) → post-create → review/confirmation**.

| Step | Options shown |
|---|---|
| Language | C# only; recorded without a picker |
| Target framework | net10.0; net9.0; net8.0 |
| Theme | Native WinUI, ID `Native`; recorded without a picker |
| Setup | Empty project; Project with Syncfusion controls; Empty first |
| Controls | Charts (`chart`); DataGrid (`datagrid`); DockingManager (`docking-manager`); Ribbon (`ribbon`); TreeGrid (`treegrid`); none checked |
| Post-create | Generate only; Build project |
| Confirmation | Review selected values; proceed or cancel |

WPF, WinForms, and WinUI warn on non-Windows hosts. File generation is available; Windows runtime checks require Windows. Legacy WPF/WinForms target prerequisites are distinct from modern .NET SDK prerequisites.

## 6. Blazor creation

Flow: **Platform → application type → language (fixed) → target framework → render mode/interactivity (Web App only) → authentication → HTTPS → project location → project name → setup → theme/controls (conditional) → post-create → review/confirmation**.

| Step | Options shown / conditions |
|---|---|
| Application type | Blazor Web App (`web-app`); Blazor WebAssembly Standalone (`webassembly-standalone`); Web App first |
| Language | C# only; recorded without a picker |
| Target framework | Read from the installed Microsoft `blazor` / `blazorwasm` template. Candidate order: net10.0, net9.0, net8.0, net11.0, filtered to advertised targets. This host offers net10.0 only |
| Render mode, Web App only | Server (`server`); WebAssembly (`webassembly`); Auto (`auto`); Server first |
| Interactivity, Web App only | Per page/component (`per-page`); Global (`global`); Per page first |
| Authentication, Web App | None (`none`); Individual accounts (`individual`); None first |
| Authentication, Standalone | None is recorded; standalone Individual is rejected because external identity-provider settings are not implemented |
| HTTPS | Yes (`yes`); No (`no`); Yes first/default. Individual accounts require Yes and skip the ordinary choice when not explicitly supplied |
| Setup | With Syncfusion demo pages; Empty project; demo option first |
| Theme, demo setup only | Fluent 2 (`fluent2`); Bootstrap 5.3 (`bootstrap5.3`); Material 3 (`material3`); Tailwind 3 (`tailwind3`); Bootstrap 5 (`bootstrap5`); Fluent 2 first |
| Components, demo setup only | 12 choices below, alphabetically displayed, none checked; user must select |
| Post-create | Generate only; Build project |
| Confirmation | Review selected values; proceed or cancel |

Standalone fixes rendering to WebAssembly and does not ask for an interactivity location. An explicit conflicting render mode or any Standalone `--interactivity` value is rejected. An explicit `--https no` with Individual authentication is rejected.

| Control label | CLI control ID |
|---|---|
| Charts | `charts` |
| Diagram | `diagram` |
| Document Editor | `document-editor` |
| File Manager | `file-manager` |
| Gantt | `gantt` |
| Grid | `grid` |
| Kanban | `kanban` |
| PDF Viewer | `pdf-viewer` |
| Query Builder | `query-builder` |
| Rich Text Editor | `rich-text-editor` |
| Scheduler | `scheduler` |
| Spreadsheet | `spreadsheet` |

## 7. Existing-project flows

| Action | MAUI | WPF / WinForms / WinUI / Blazor |
|---|---|---|
| Add | Platform → resolve/select MAUI project → multi-select controls, or Other packages… → post-add → review/confirm | Platform → Project file input → one Package choice from platform catalog → Post-add → review/confirm |
| Remove | Platform → resolve/select project → choose an installed package → review/confirm. Explicit control removal is separately available through `--control` | Platform → Project file input → one Package choice from the full platform catalog → review/confirm |
| Update | Platform → resolve/select project → choose an installed package → review/confirm | Platform → Project file input → one Package choice from the full platform catalog → Post-add → review/confirm |
| List available | Platform → output package catalog | Same |
| List installed | Platform → resolve MAUI project in current/path context → output installed packages | Platform → Project file input → output installed packages |
| Search | Platform → search text → output catalog matches | Same |

Post-add choices: **Restore only** and **Restore and build**. MAUI can put Restore and build first depending on the requested build state; the shared desktop adapter puts Restore only first. `--no-restore` skips that question. The desktop adapter also skips it when an explicit build choice has been supplied. It currently labels the update question/review field “Post-add”. There is no interactive package-version picker; use `--version` for a specific release.

Lifecycle differences to review:

- MAUI has a control-generation flow and a separate package-only flow. “Other packages…” uses its complete package catalog.
- WPF/WinForms/WinUI add/remove integrate generated sample files and welcome navigation for CLI-managed projects. Edited/unowned sample files are protected; update preserves sample source. Unmanaged projects use package operations.
- WinUI uses the shared managed desktop template lifecycle, including owned-file protection and rollback. Public removal commands remain temporarily disabled.
- The desktop adapter accepts one package alias/ID per invocation, rather than a control checkbox list; it rejects `--control` for existing-project commands.
- The package picker for desktop/Blazor remove and update is the full catalog, not an installed-only list. Shared package IDs can represent multiple WPF/WinForms samples; use the control alias to identify the intended sample.

## 8. Command forms and command-line options

```text
sf new <platform> --name <name> [options]
sf add <platform> <package-alias-or-id> --path <project> [options]
sf remove <platform> <package-alias-or-id> --path <project> [options]
sf update <platform> <package-alias-or-id> --path <project> [options]
sf list <platform> packages [--search <text>] [--details]
sf list <platform> installed --path <project>
sf search <platform> <text>
sf help <platform>
sf info
sf --version
```

Use `<platform>` = `maui`, `wpf`, `winforms`, `winui`, `blazor`. `--framework/-f` is the alternative platform selector. Multiple new-project controls can follow one `--control` or use repeated `--control` options. `empty` is the special empty-project selection.

### Global flags

| Flag | Behavior |
|---|---|
| --interactive | Allow prompts; terminal interaction is the default |
| --no-interactive | Disable prompts |
| --json | Machine-readable output; no interactive wizard |
| --verbose | Diagnostic output |
| --no-color | Disable color |
| --help / -h | Help output; currently generic even when attached to a command |
| sf --version | CLI version, distinct from operation package-version selection |

### Creation options and applicability

| Option | Purpose | Applies to |
|---|---|---|
| --name / -n | Project name | All |
| --path / -p | Parent location for new project | All |
| --framework / -f | Platform selector | All |
| --target-framework / -t | Base .NET TFM | All; availability differs above |
| --language | C# or VB where supported | All; MAUI/Blazor/WinUI C# only |
| --control | Explicit control IDs; no automatic control selection | All |
| --theme | Theme ID/display name | WPF, WinForms, WinUI, Blazor; no MAUI theme picker |
| --project-type | app (Hybrid temporarily disabled) | MAUI |
| --app-type | web-app / webassembly-standalone | Blazor |
| --render-mode | server / webassembly / auto | Blazor, with Standalone constraints |
| --interactivity | per-page / global | Blazor Web App |
| --auth | none / individual | Blazor, with Standalone constraints |
| --https | yes / no | Blazor |
| --post-action | generate / build | All |
| --build-framework | One configured platform build target, e.g. net10.0-android | MAUI |
| --version / -v | Syncfusion package release | All |
| --source | NuGet source | All |
| --configfile | NuGet configuration path | All |
| --dry-run | Preview without writing changes | All |
| --no-restore | Skip restore where compatible with requested action | All; MAUI selected-control generation may require restore |
| --no-build | Skip build | All |
| --force | Supported overwrite behavior; does not authorize overwriting edited samples | MAUI handling; desktop creation still rejects an existing destination |

These flags share a parser. Registration does not guarantee that a platform consumes an unrelated platform's flag. See review items below.

### Registered flags by command

The following inventory is extracted from actual command registration, including compatibility flags. Platform validation and handling still apply.

| Command | Registered command-specific flags (plus globals) |
|---|---|
| new | `--name`, `--language`, `--theme`, `--path`, `--target-framework`, `--build-framework`, `--framework`, `--control`, `--template (hidden compatibility alias for --control)`, `--project-type`, `--app-type`, `--render-mode`, `--interactivity`, `--auth`, `--https`, `--version`, `--source`, `--configfile`, `--dry-run`, `--force`, `--no-restore`, `--no-build`, `--post-action` |
| add | `--template (hidden compatibility alias for --control)`, `--control`, `--path`, `--version`, `--framework`, `--source`, `--configfile`, `--dry-run`, `--force`, `--no-restore`, `--build`, `--no-build`, `--build-framework` |
| remove | `--template (hidden compatibility alias for --control)`, `--control`, `--path`, `--framework`, `--dry-run`, `--force`, `--source`, `--configfile`, `--no-restore`, `--build`, `--build-framework` |
| update | `--path`, `--version`, `--framework`, `--source`, `--configfile`, `--dry-run`, `--force`, `--no-restore`, `--build` |
| list | `--framework`, `--path`, `--template (hidden compatibility alias for --control)`, `--installed (hidden)`, `--details`, `--search` |
| search | `--framework`, `--details` |

`--template` remains a hidden compatibility alias. It is not a separate UI option. `--installed` is also hidden; the visible syntax is `list <platform> installed`.

## 9. Complete package choices

This is the catalog offered by package discovery / package pickers, not a list of generated control templates. MAUI has 51 packages but 10 selectable control templates; WPF has 108 alias entries / 106 NuGet IDs / 9 templates, WinForms 51 / 50 / 5, WinUI 19 / 18 / 5, and Blazor 59 / 59 / 15. A package can provide multiple controls and retain multiple aliases; not every package is a generated sample. Catalogs were checked against official SyncfusionInc NuGet.org listings on 2026-10-16. Superseded legacy packages, Xamarin products, tools and project templates are excluded from the new library catalogs.

### MAUI

| Display label | Alias | NuGet package |
|---|---|---|
| Syncfusion A2UI for .NET MAUI | `a2-ui` | `Syncfusion.Maui.A2UI` |
| Syncfusion AIAssistView for .NET MAUI | `assistview` | `Syncfusion.Maui.AIAssistView` |
| Syncfusion Backdrop for .NET MAUI | `backdrop` | `Syncfusion.Maui.Backdrop` |
| Syncfusion Barcode Generator for .NET MAUI | `barcode` | `Syncfusion.Maui.Barcode` |
| Syncfusion Buttons for .NET MAUI | `buttons` | `Syncfusion.Maui.Buttons` |
| Syncfusion Calendar for .NET MAUI | `calendar` | `Syncfusion.Maui.Calendar` |
| Syncfusion Cards for .NET MAUI | `cards` | `Syncfusion.Maui.Cards` |
| Syncfusion Carousel for .NET MAUI | `carousel` | `Syncfusion.Maui.Carousel` |
| Syncfusion Charts for .NET MAUI | `charts` | `Syncfusion.Maui.Charts` |
| Syncfusion Chat for .NET MAUI | `chat` | `Syncfusion.Maui.Chat` |
| Syncfusion Core for .NET MAUI | `core` | `Syncfusion.Maui.Core` |
| Syncfusion DataForm for .NET MAUI | `data-form` | `Syncfusion.Maui.DataForm` |
| Syncfusion DataGridExport for .NET MAUI | `data-grid-export` | `Syncfusion.Maui.DataGridExport` |
| Syncfusion DataPager for .NET MAUI | `data-pager` | `Syncfusion.Maui.DataPager` |
| Syncfusion DataGrid for .NET MAUI | `datagrid` | `Syncfusion.Maui.DataGrid` |
| Syncfusion Diagram for .NET MAUI | `diagram` | `Syncfusion.Maui.Diagram` |
| Syncfusion Expander and Accordion for .NET MAUI | `expander` | `Syncfusion.Maui.Expander` |
| Syncfusion Gauges for .NET MAUI | `gauges` | `Syncfusion.Maui.Gauges` |
| Syncfusion GridSplitter for .NET MAUI | `grid-splitter` | `Syncfusion.Maui.GridSplitter` |
| Syncfusion ImageEditor for .NET MAUI | `image-editor` | `Syncfusion.Maui.ImageEditor` |
| Syncfusion Inputs for .NET MAUI | `inputs` | `Syncfusion.Maui.Inputs` |
| Syncfusion InteractiveViewer for .NET MAUI | `interactive-viewer` | `Syncfusion.Maui.InteractiveViewer` |
| Syncfusion Kanban for .NET MAUI | `kanban` | `Syncfusion.Maui.Kanban` |
| Syncfusion ListView for .NET MAUI | `listview` | `Syncfusion.Maui.ListView` |
| Syncfusion Maps for .NET MAUI | `maps` | `Syncfusion.Maui.Maps` |
| Syncfusion MarkdownViewer for .NET MAUI | `markdown-viewer` | `Syncfusion.Maui.MarkdownViewer` |
| Syncfusion NavigationDrawer for .NET MAUI | `navigation-drawer` | `Syncfusion.Maui.NavigationDrawer` |
| Syncfusion ParallaxView for .NET MAUI | `parallax-view` | `Syncfusion.Maui.ParallaxView` |
| Syncfusion PDF to Image Converter for .NET MAUI | `pdf-to-image-converter` | `Syncfusion.Maui.PdfToImageConverter` |
| Syncfusion PDF Viewer for .NET MAUI | `pdf-viewer` | `Syncfusion.Maui.PdfViewer` |
| Syncfusion Picker for .NET MAUI | `picker` | `Syncfusion.Maui.Picker` |
| Syncfusion Popup for .NET MAUI | `popup` | `Syncfusion.Maui.Popup` |
| Syncfusion ProgressBar for .NET MAUI | `progress-bar` | `Syncfusion.Maui.ProgressBar` |
| Syncfusion PullToRefresh for .NET MAUI | `pull-to-refresh` | `Syncfusion.Maui.PullToRefresh` |
| Syncfusion RadialMenu for .NET MAUI | `radial-menu` | `Syncfusion.Maui.RadialMenu` |
| Syncfusion RichTextEditor for .NET MAUI | `rich-text-editor` | `Syncfusion.Maui.RichTextEditor` |
| Syncfusion Rotator for .NET MAUI | `rotator` | `Syncfusion.Maui.Rotator` |
| Syncfusion Scheduler for .NET MAUI | `scheduler` | `Syncfusion.Maui.Scheduler` |
| Syncfusion SignaturePad for .NET MAUI | `signature-pad` | `Syncfusion.Maui.SignaturePad` |
| Syncfusion Slider for .NET MAUI | `sliders` | `Syncfusion.Maui.Sliders` |
| Syncfusion SmartComponents for .NET MAUI | `smart-components` | `Syncfusion.Maui.SmartComponents` |
| Syncfusion SmartDataGrid for .NET MAUI | `smart-data-grid` | `Syncfusion.Maui.SmartDataGrid` |
| Syncfusion Smart PDF Viewer for .NET MAUI | `smart-pdf-viewer` | `Syncfusion.Maui.SmartPdfViewer` |
| Syncfusion SmartScheduler for .NET MAUI | `smart-scheduler` | `Syncfusion.Maui.SmartScheduler` |
| Syncfusion SunburstChart for .NET MAUI | `sunburst-chart` | `Syncfusion.Maui.SunburstChart` |
| Syncfusion TabView for .NET MAUI | `tabview` | `Syncfusion.Maui.TabView` |
| Syncfusion Toolbar for .NET MAUI | `toolbar` | `Syncfusion.Maui.Toolbar` |
| Syncfusion Toolkit for .NET MAUI | `toolkit` | `Syncfusion.Maui.Toolkit` |
| Syncfusion TreeGrid for .NET MAUI | `tree-grid` | `Syncfusion.Maui.TreeGrid` |
| Syncfusion TreeMap for .NET MAUI | `tree-map` | `Syncfusion.Maui.TreeMap` |
| Syncfusion TreeView for .NET MAUI | `treeview` | `Syncfusion.Maui.TreeView` |

### WPF

| Display label | Alias | NuGet package |
|---|---|---|
| Accordion | `accordion` | `Syncfusion.SfAccordion.WPF` |
| Barcode | `barcode` | `Syncfusion.SfBarcode.WPF` |
| Bullet Graph | `bullet-graph` | `Syncfusion.SfBulletGraph.WPF` |
| Busy Indicator | `busy-indicator` | `Syncfusion.SfBusyIndicator.WPF` |
| Chart | `chart` | `Syncfusion.SfChart.WPF` |
| Chat | `chat` | `Syncfusion.SfChat.WPF` |
| Chromeless Window | `chromeless-window` | `Syncfusion.SfChromelessWindow.WPF` |
| Color Palette | `color-palette` | `Syncfusion.SfColorPalette.WPF` |
| Data | `data` | `Syncfusion.Data.WPF` |
| Data Grid Excel Export | `data-grid-excel-export` | `Syncfusion.DataGridExcelExport.Wpf` |
| DataGrid | `datagrid` | `Syncfusion.SfGrid.WPF` |
| Diagram | `diagram` | `Syncfusion.SfDiagram.WPF` |
| Diagram Ribbon | `diagram-ribbon` | `Syncfusion.SfDiagramRibbon.WPF` |
| Doc IO | `doc-io` | `Syncfusion.DocIO.Wpf` |
| Doc To PDF Converter | `doc-to-pdf-converter` | `Syncfusion.DocToPDFConverter.Wpf` |
| DockingManager | `docking-manager` | `Syncfusion.Tools.WPF` |
| Document Chunking | `document-chunking` | `Syncfusion.DocumentChunking.Wpf` |
| Edit | `edit` | `Syncfusion.Edit.WPF` |
| Excel Chart To Image Converter | `excel-chart-to-image-converter` | `Syncfusion.ExcelChartToImageConverter.WPF` |
| Excel To Pdf Converter | `excel-to-pdf-converter` | `Syncfusion.ExcelToPdfConverter.Wpf` |
| Export Olap Chart | `export-olap-chart` | `Syncfusion.ExportOlapChart.Wpf` |
| Export Olap Grid | `export-olap-grid` | `Syncfusion.ExportOlapGrid.Wpf` |
| Gantt | `gantt` | `Syncfusion.Gantt.WPF` |
| Gauge | `gauge` | `Syncfusion.SfGauge.WPF` |
| Grid | `grid` | `Syncfusion.Grid.WPF` |
| Grid Excel Export | `grid-excel-export` | `Syncfusion.GridExcelExport.Wpf` |
| Heat Map | `heat-map` | `Syncfusion.SfHeatMap.WPF` |
| Html To Pdf Converter | `html-to-pdf-converter` | `Syncfusion.HtmlToPdfConverter.WPF` |
| Hub Tile | `hub-tile` | `Syncfusion.SfHubTile.WPF` |
| Image Editor | `image-editor` | `Syncfusion.SfImageEditor.WPF` |
| Input | `input` | `Syncfusion.SfInput.WPF` |
| Kanban | `kanban` | `Syncfusion.SfKanban.WPF` |
| Maps | `maps` | `Syncfusion.SfMaps.WPF` |
| Markdown Viewer | `markdown-viewer` | `Syncfusion.SfMarkdownViewer.WPF` |
| Material3 (Dark) | `material3dark` | `Syncfusion.Themes.Material3Dark.WPF` |
| Material3 (Light) | `material3light` | `Syncfusion.Themes.Material3Light.WPF` |
| NavigationDrawer | `navigation-drawer` | `Syncfusion.SfNavigationDrawer.WPF` |
| Office Chart To Image Converter | `office-chart-to-image-converter` | `Syncfusion.OfficeChartToImageConverter.WPF` |
| Office2019 (Colorful) | `office2019colorful` | `Syncfusion.Themes.Office2019Colorful.WPF` |
| Olap Chart | `olap-chart` | `Syncfusion.OlapChart.WPF` |
| Olap Client | `olap-client` | `Syncfusion.OlapClient.WPF` |
| Olap Gauge | `olap-gauge` | `Syncfusion.OlapGauge.WPF` |
| Olap Grid | `olap-grid` | `Syncfusion.OlapGrid.WPF` |
| Olap Shared | `olap-shared` | `Syncfusion.OlapShared.WPF` |
| Pdf | `pdf` | `Syncfusion.Pdf.Wpf` |
| Pdf OCR | `pdf-ocr` | `Syncfusion.Pdf.OCR.Wpf` |
| Pdf To Image Converter | `pdf-to-image-converter` | `Syncfusion.PdfToImageConverter.WPF` |
| Pdf Viewer | `pdf-viewer` | `Syncfusion.PdfViewer.WPF` |
| Pivot Table | `pivot-table` | `Syncfusion.PivotTable.Wpf` |
| Pivot Table Export | `pivot-table-export` | `Syncfusion.PivotTableExport.Wpf` |
| PMML | `pmml` | `Syncfusion.PMML.Wpf` |
| Presentation | `presentation` | `Syncfusion.Presentation.Wpf` |
| Presentation To Pdf Converter | `presentation-to-pdf-converter` | `Syncfusion.PresentationToPdfConverter.Wpf` |
| Progress Bar | `progress-bar` | `Syncfusion.SfProgressBar.WPF` |
| Property Grid | `property-grid` | `Syncfusion.PropertyGrid.WPF` |
| Radial Menu | `radial-menu` | `Syncfusion.SfRadialMenu.WPF` |
| Ribbon | `ribbon` | `Syncfusion.Tools.WPF` |
| Rich Text Box Adv | `rich-text-box-adv` | `Syncfusion.SfRichTextBoxAdv.WPF` |
| Rich Text Ribbon | `rich-text-ribbon` | `Syncfusion.SfRichTextRibbon.WPF` |
| Scheduler | `scheduler` | `Syncfusion.SfScheduler.WPF` |
| Shared | `shared` | `Syncfusion.Shared.WPF` |
| Skin Manager | `skin-manager` | `Syncfusion.SfSkinManager.WPF` |
| Smart Components | `smart-components` | `Syncfusion.SfSmartComponents.WPF` |
| Smart Data Extractor | `smart-data-extractor` | `Syncfusion.SmartDataExtractor.Wpf` |
| Smart Form Recognizer | `smart-form-recognizer` | `Syncfusion.SmartFormRecognizer.Wpf` |
| Smart Table Extractor | `smart-table-extractor` | `Syncfusion.SmartTableExtractor.Wpf` |
| Smith Chart | `smith-chart` | `Syncfusion.SfSmithChart.WPF` |
| Spell Checker | `spell-checker` | `Syncfusion.SfSpellChecker.WPF` |
| Spreadsheet | `spreadsheet` | `Syncfusion.SfSpreadsheet.WPF` |
| Spreadsheet Helper | `spreadsheet-helper` | `Syncfusion.SfSpreadsheetHelper.WPF` |
| Sunburst Chart | `sunburst-chart` | `Syncfusion.SfSunburstChart.WPF` |
| Text Input Layout | `text-input-layout` | `Syncfusion.SfTextInputLayout.WPF` |
| Themes Blend | `themes-blend` | `Syncfusion.Themes.Blend.WPF` |
| Themes Fluent Dark | `themes-fluent-dark` | `Syncfusion.Themes.FluentDark.WPF` |
| Themes Fluent Light | `themes-fluent-light` | `Syncfusion.Themes.FluentLight.WPF` |
| Themes Lime | `themes-lime` | `Syncfusion.Themes.Lime.WPF` |
| Themes Material Dark | `themes-material-dark` | `Syncfusion.Themes.MaterialDark.WPF` |
| Themes Material Dark Blue | `themes-material-dark-blue` | `Syncfusion.Themes.MaterialDarkBlue.WPF` |
| Themes Material Light | `themes-material-light` | `Syncfusion.Themes.MaterialLight.WPF` |
| Themes Material Light Blue | `themes-material-light-blue` | `Syncfusion.Themes.MaterialLightBlue.WPF` |
| Themes Metro | `themes-metro` | `Syncfusion.Themes.Metro.WPF` |
| Themes Office2010 Black | `themes-office2010-black` | `Syncfusion.Themes.Office2010Black.WPF` |
| Themes Office2010 Blue | `themes-office2010-blue` | `Syncfusion.Themes.Office2010Blue.WPF` |
| Themes Office2010 Silver | `themes-office2010-silver` | `Syncfusion.Themes.Office2010Silver.WPF` |
| Themes Office2013 Dark Gray | `themes-office2013-dark-gray` | `Syncfusion.Themes.Office2013DarkGray.WPF` |
| Themes Office2013 Light Gray | `themes-office2013-light-gray` | `Syncfusion.Themes.Office2013LightGray.WPF` |
| Themes Office2013 White | `themes-office2013-white` | `Syncfusion.Themes.Office2013White.WPF` |
| Themes Office2016 Colorful | `themes-office2016-colorful` | `Syncfusion.Themes.Office2016Colorful.WPF` |
| Themes Office2016 Dark Gray | `themes-office2016-dark-gray` | `Syncfusion.Themes.Office2016DarkGray.WPF` |
| Themes Office2016 White | `themes-office2016-white` | `Syncfusion.Themes.Office2016White.WPF` |
| Themes Office2019 Black | `themes-office2019-black` | `Syncfusion.Themes.Office2019Black.WPF` |
| Themes Office2019 Dark Gray | `themes-office2019-dark-gray` | `Syncfusion.Themes.Office2019DarkGray.WPF` |
| Themes Office2019 High Contrast | `themes-office2019-high-contrast` | `Syncfusion.Themes.Office2019HighContrast.WPF` |
| Themes Office2019 High Contrast White | `themes-office2019-high-contrast-white` | `Syncfusion.Themes.Office2019HighContrastWhite.WPF` |
| Themes Office2019 White | `themes-office2019-white` | `Syncfusion.Themes.Office2019White.WPF` |
| Themes Office365 | `themes-office365` | `Syncfusion.Themes.Office365.WPF` |
| Themes Saffron | `themes-saffron` | `Syncfusion.Themes.Saffron.WPF` |
| Themes System Theme | `themes-system-theme` | `Syncfusion.Themes.SystemTheme.WPF` |
| Themes Visual Studio2013 | `themes-visual-studio2013` | `Syncfusion.Themes.VisualStudio2013.WPF` |
| Themes Visual Studio2015 | `themes-visual-studio2015` | `Syncfusion.Themes.VisualStudio2015.WPF` |
| Toast Notification | `toast-notification` | `Syncfusion.SfToastNotification.WPF` |
| Tree Map | `tree-map` | `Syncfusion.SfTreeMap.WPF` |
| Tree Navigator | `tree-navigator` | `Syncfusion.SfTreeNavigator.WPF` |
| Tree View | `tree-view` | `Syncfusion.SfTreeView.WPF` |
| TreeGrid | `treegrid` | `Syncfusion.SfGrid.WPF` |
| Windows11 (Dark) | `windows11dark` | `Syncfusion.Themes.Windows11Dark.WPF` |
| Windows11 (Light) | `windows11light` | `Syncfusion.Themes.Windows11Light.WPF` |
| Xls IO | `xls-io` | `Syncfusion.XlsIO.Wpf` |

### WinForms

| Display label | Alias | NuGet package |
|---|---|---|
| AI Assist View | `ai-assist-view` | `Syncfusion.SfAIAssistView.WinForms` |
| Barcode | `barcode` | `Syncfusion.SfBarcode.Windows` |
| Bullet Graph | `bullet-graph` | `Syncfusion.BulletGraph.Windows` |
| Chart | `chart` | `Syncfusion.Chart.Windows` |
| Core | `core` | `Syncfusion.Core.WinForms` |
| Data Grid Export | `data-grid-export` | `Syncfusion.DataGridExport.WinForms` |
| DataGrid | `datagrid` | `Syncfusion.SfDataGrid.WinForms` |
| Diagram | `diagram` | `Syncfusion.Diagram.Windows` |
| Diagram Utility | `diagram-utility` | `Syncfusion.Diagram.Utility.Windows` |
| Doc IO | `doc-io` | `Syncfusion.DocIO.WinForms` |
| Doc To PDF Converter | `doc-to-pdf-converter` | `Syncfusion.DocToPDFConverter.WinForms` |
| DockingManager | `docking-manager` | `Syncfusion.Tools.Windows` |
| Document Chunking | `document-chunking` | `Syncfusion.DocumentChunking.WinForms` |
| Edit | `edit` | `Syncfusion.Edit.Windows` |
| Excel Chart To Image Converter | `excel-chart-to-image-converter` | `Syncfusion.ExcelChartToImageConverter.WinForms` |
| Excel To Pdf Converter | `excel-to-pdf-converter` | `Syncfusion.ExcelToPdfConverter.WinForms` |
| Gauge | `gauge` | `Syncfusion.Gauge.Windows` |
| Grid | `grid` | `Syncfusion.Grid.Windows` |
| Grid Export | `grid-export` | `Syncfusion.GridExport.WinForms` |
| Grid Grouping | `grid-grouping` | `Syncfusion.Grid.Grouping.Windows` |
| Grid Helper Classes | `grid-helper-classes` | `Syncfusion.GridHelperClasses.Windows` |
| Grouping | `grouping` | `Syncfusion.Grouping.Windows` |
| High Contrast Theme | `high-contrast-theme` | `Syncfusion.HighContrastTheme.WinForms` |
| Html To Pdf Converter | `html-to-pdf-converter` | `Syncfusion.HtmlToPdfConverter.WinForms` |
| Input | `input` | `Syncfusion.SfInput.WinForms` |
| List View | `list-view` | `Syncfusion.SfListView.WinForms` |
| Maps | `maps` | `Syncfusion.Maps.Windows` |
| NavigationDrawer | `navigation-drawer` | `Syncfusion.Tools.Windows` |
| Office Chart To Image Converter | `office-chart-to-image-converter` | `Syncfusion.OfficeChartToImageConverter.WinForms` |
| Office2016 Theme | `office2016-theme` | `Syncfusion.Office2016Theme.WinForms` |
| Office2019 | `office2019` | `Syncfusion.Office2019Theme.WinForms` |
| Pdf | `pdf` | `Syncfusion.Pdf.WinForms` |
| Pdf OCR | `pdf-ocr` | `Syncfusion.Pdf.OCR.WinForms` |
| Pdf To Image Converter | `pdf-to-image-converter` | `Syncfusion.PdfToImageConverter.WinForms` |
| Pdf Viewer | `pdf-viewer` | `Syncfusion.PdfViewer.Windows` |
| Pivot Chart | `pivot-chart` | `Syncfusion.PivotChart.Windows` |
| Pivot Table | `pivot-table` | `Syncfusion.PivotTable.WinForms` |
| Pivot Table Export | `pivot-table-export` | `Syncfusion.PivotTableExport.WinForms` |
| PMML | `pmml` | `Syncfusion.PMML.WinForms` |
| Presentation | `presentation` | `Syncfusion.Presentation.WinForms` |
| Presentation To Pdf Converter | `presentation-to-pdf-converter` | `Syncfusion.PresentationToPdfConverter.WinForms` |
| Schedule | `schedule` | `Syncfusion.Schedule.Windows` |
| Shared | `shared` | `Syncfusion.Shared.Base` |
| Smart Data Extractor | `smart-data-extractor` | `Syncfusion.SmartDataExtractor.WinForms` |
| Smart Form Recognizer | `smart-form-recognizer` | `Syncfusion.SmartFormRecognizer.WinForms` |
| Smart Table Extractor | `smart-table-extractor` | `Syncfusion.SmartTableExtractor.WinForms` |
| Smith Chart | `smith-chart` | `Syncfusion.SfSmithChart.WinForms` |
| Spreadsheet | `spreadsheet` | `Syncfusion.Spreadsheet.Windows` |
| Spreadsheet Helper | `spreadsheet-helper` | `Syncfusion.SpreadsheetHelper.Windows` |
| Tree Map | `tree-map` | `Syncfusion.TreeMap.Windows` |
| Xls IO | `xls-io` | `Syncfusion.XlsIO.WinForms` |

### WinUI

| Display label | Alias | NuGet package |
|---|---|---|
| Barcode | `barcode` | `Syncfusion.Barcode.WinUI` |
| Calendar | `calendar` | `Syncfusion.Calendar.WinUI` |
| Charts | `chart` | `Syncfusion.Chart.WinUI` |
| Chat | `chat` | `Syncfusion.Chat.WinUI` |
| Core | `core` | `Syncfusion.Core.WinUI` |
| DataGrid | `datagrid` | `Syncfusion.Grid.WinUI` |
| DockingManager | `docking-manager` | `Syncfusion.DockingManager.WinUI` |
| Editors | `editors` | `Syncfusion.Editors.WinUI` |
| Gauge | `gauge` | `Syncfusion.Gauge.WinUI` |
| Grid Common | `grid-common` | `Syncfusion.GridCommon.WinUI` |
| Grid Export | `grid-export` | `Syncfusion.GridExport.WinUI` |
| Kanban | `kanban` | `Syncfusion.Kanban.WinUI` |
| Markdown Viewer | `markdown-viewer` | `Syncfusion.MarkdownViewer.WinUI` |
| Notifications | `notifications` | `Syncfusion.Notifications.WinUI` |
| Ribbon | `ribbon` | `Syncfusion.Ribbon.WinUI` |
| Scheduler | `scheduler` | `Syncfusion.Scheduler.WinUI` |
| Sliders | `sliders` | `Syncfusion.Sliders.WinUI` |
| Tree View | `tree-view` | `Syncfusion.TreeView.WinUI` |
| TreeGrid | `treegrid` | `Syncfusion.Grid.WinUI` |

### Blazor

| Display label | Alias | NuGet package |
|---|---|---|
| A2 UI | `a2-ui` | `Syncfusion.Blazor.A2UI` |
| AI | `ai` | `Syncfusion.Blazor.AI` |
| AI AssistView | `ai-assistview` | `Syncfusion.Blazor.InteractiveChat` |
| Barcode Generator | `barcode-generator` | `Syncfusion.Blazor.BarcodeGenerator` |
| Block Editor | `block-editor` | `Syncfusion.Blazor.BlockEditor` |
| Bullet Chart | `bullet-chart` | `Syncfusion.Blazor.BulletChart` |
| Buttons | `buttons` | `Syncfusion.Blazor.Buttons` |
| Calendars | `calendars` | `Syncfusion.Blazor.Calendars` |
| Cards | `cards` | `Syncfusion.Blazor.Cards` |
| Chart Wizard | `chart-wizard` | `Syncfusion.Blazor.ChartWizard` |
| Chart 3D | `chart-3d` | `Syncfusion.Blazor.Chart3D` |
| Charts | `charts` | `Syncfusion.Blazor.Charts` |
| Circular Gauge | `circular-gauge` | `Syncfusion.Blazor.CircularGauge` |
| Core | `core` | `Syncfusion.Blazor.Core` |
| Data | `data` | `Syncfusion.Blazor.Data` |
| Data Form | `data-form` | `Syncfusion.Blazor.DataForm` |
| Data Viz Common | `data-viz-common` | `Syncfusion.Blazor.DataVizCommon` |
| Diagram | `diagram` | `Syncfusion.Blazor.Diagram` |
| Document Editor | `document-editor` | `Syncfusion.Blazor.WordProcessor` |
| Drop Downs | `drop-downs` | `Syncfusion.Blazor.DropDowns` |
| File Manager | `file-manager` | `Syncfusion.Blazor.FileManager` |
| File Manager Physical File Provider | `file-manager-physical-file-provider` | `Syncfusion.Blazor.FileManager.PhysicalFileProvider` |
| Gantt | `gantt` | `Syncfusion.Blazor.Gantt` |
| Grid | `grid` | `Syncfusion.Blazor.Grid` |
| Heat Map | `heat-map` | `Syncfusion.Blazor.HeatMap` |
| Image Editor | `image-editor` | `Syncfusion.Blazor.ImageEditor` |
| In Place Editor | `in-place-editor` | `Syncfusion.Blazor.InPlaceEditor` |
| Inputs | `inputs` | `Syncfusion.Blazor.Inputs` |
| Kanban | `kanban` | `Syncfusion.Blazor.Kanban` |
| Layouts | `layouts` | `Syncfusion.Blazor.Layouts` |
| Linear Gauge | `linear-gauge` | `Syncfusion.Blazor.LinearGauge` |
| Lists | `lists` | `Syncfusion.Blazor.Lists` |
| Maps | `maps` | `Syncfusion.Blazor.Maps` |
| Multi Column Combo Box | `multi-column-combo-box` | `Syncfusion.Blazor.MultiColumnComboBox` |
| Navigations | `navigations` | `Syncfusion.Blazor.Navigations` |
| Notifications | `notifications` | `Syncfusion.Blazor.Notifications` |
| PDF Viewer | `pdf-viewer` | `Syncfusion.Blazor.SfPdfViewer` |
| Pivot Table | `pivot-table` | `Syncfusion.Blazor.PivotTable` |
| Popups | `popups` | `Syncfusion.Blazor.Popups` |
| Progress Bar | `progress-bar` | `Syncfusion.Blazor.ProgressBar` |
| Query Builder | `query-builder` | `Syncfusion.Blazor.QueryBuilder` |
| Range Navigator | `range-navigator` | `Syncfusion.Blazor.RangeNavigator` |
| Ribbon | `ribbon` | `Syncfusion.Blazor.Ribbon` |
| Rich Text Editor | `rich-text-editor` | `Syncfusion.Blazor.RichTextEditor` |
| Sankey | `sankey` | `Syncfusion.Blazor.Sankey` |
| Scheduler | `scheduler` | `Syncfusion.Blazor.Schedule` |
| Smart Components | `smart-components` | `Syncfusion.Blazor.SmartComponents` |
| Smart Pdf Viewer | `smart-pdf-viewer` | `Syncfusion.Blazor.SfSmartPdfViewer` |
| Smart Rich Text Editor | `smart-rich-text-editor` | `Syncfusion.Blazor.SmartRichTextEditor` |
| Smith Chart | `smith-chart` | `Syncfusion.Blazor.SmithChart` |
| Sparkline | `sparkline` | `Syncfusion.Blazor.Sparkline` |
| Spinner | `spinner` | `Syncfusion.Blazor.Spinner` |
| Split Buttons | `split-buttons` | `Syncfusion.Blazor.SplitButtons` |
| Spreadsheet | `spreadsheet` | `Syncfusion.Blazor.Spreadsheet` |
| Stock Chart | `stock-chart` | `Syncfusion.Blazor.StockChart` |
| Themes | `themes` | `Syncfusion.Blazor.Themes` |
| Toolkit | `toolkit` | `Syncfusion.Blazor.Toolkit` |
| Tree Grid | `tree-grid` | `Syncfusion.Blazor.TreeGrid` |
| Tree Map | `tree-map` | `Syncfusion.Blazor.TreeMap` |


## 10. Review findings

| Finding | Current behavior / review decision |
|---|---|
| General help is used for command --help | `sf new --help`, `sf add --help`, etc. all show the same general help. `sf help <platform>` gives examples but not the complete flag inventory |
| Setup order/labels differ | MAUI: Blank app first; desktop: Empty project first; Blazor: With Syncfusion demo pages first. Decide whether to standardize wording/order |
| Theme appears before setup on desktop | WPF/WinForms/WinUI choose/record theme even for empty creation; Blazor only asks for theme with demos; MAUI has no theme picker |
| Existing-project UX differs | MAUI supports control multiselection; shared desktop/Blazor adapter selects one catalog package. Decide whether all platforms should expose control-template management consistently |
| Remove/update package filtering | Shared desktop/Blazor picker shows uninstalled catalog packages. Consider limiting these actions to installed packages/managed controls |
| Desktop template lifecycle | WPF, WinForms and WinUI add/update maintain managed samples and navigation; public removal is temporarily disabled |
| “Post-add” label on update | Shared adapter uses this label for update too. Consider action-specific wording |
| Version review text | Shared adapter displays “Latest available” when version omitted, although managed WPF/WinForms additions can follow the installed release. Review should describe actual resolution |
| Discovery parity | Desktop/Blazor filtering matches package ID/display name; MAUI also documents alias/description matching. `--details` has richer MAUI handling; the shared adapter does not use it |
| List controls/themes not exposed | `sf list <platform> controls` is rejected on all five platforms; supported categories are packages and installed. Catalogs/themes currently need docs or picker inspection |
| Generic parser accepts platform-specific flags | Audit whether irrelevant flags should be rejected rather than silently unused. Option help describes --path as current-directory default even though new-project default is the user projects folder |

## 11. Evidence and limits

Checked current wizard source, platform providers, embedded MAUI catalog, command registration, and live CLI output. Executed general and platform help, package discovery in JSON for all five platforms, and unsupported list-category checks. Probed installed official Blazor template help: this host offers net10.0 for both application types.

407 existing wizard/platform regression tests passed (WizardFlowTests, BlazorWizardRoutingTests, DesktopPlatformTests, ProjectWizardReviewTests). This is a flow/options audit, not a new round of application compilation or visual verification. A complete manual traversal of every combination in a real Windows terminal was not performed. Available framework choices can differ with installed SDKs/workloads. The `.agent` harness referenced by `AGENTS.md` is absent in this checkout.

Primary sources: `Wizard/InteractiveMenu.cs`, `Wizard/InteractivePrompt.cs`, `Presentation/InteractiveConsoleInput.cs`, `Commands/NewCommand.cs`, `Commands/Desktop/DesktopCommands.cs`, `Commands/Blazor/BlazorCommands.cs`, `Commands/Options/CommandOptions.cs`, each platform provider/catalog, and `Core/Naming/ProjectDefaults.cs`.

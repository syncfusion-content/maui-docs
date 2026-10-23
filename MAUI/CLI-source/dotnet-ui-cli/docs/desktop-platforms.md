# Desktop platforms

The CLI has separate WPF, WinForms and WinUI providers. MAUI retains its existing
provider and command behavior. Desktop generation and package/control operations use
the same services from direct commands and the interactive menu.

## Configuration matrix

| Platform | Languages | Frameworks | Themes | Samples |
|---|---|---|---|---|
| WPF | C#, VB | net462, net47, net48, net8.0, net9.0, net10.0 | Windows11 Light/Dark, Material3 Light/Dark, Office2019 Colorful | Empty, each catalog control, selected combinations |
| WinForms | C#, VB | net462, net47, net48, net8.0, net9.0, net10.0 | Office2019 Colorful | Empty, each catalog control, selected combinations |
| WinUI 3 | C# | net8.0, net9.0, net10.0 | Native | Empty, Chart, DataGrid, both |

.NET 11, VB WinUI and desktop platforms other than these are not advertised.
Unsupported selections fail validation rather than changing the user's request.
Theme family aliases Windows11, Material3 and Office2019 explicitly mean their
Light, Light and Colorful variants respectively.

## Commands

```shell
sf new wpf --name Reports --language C# --target-framework net10.0 --theme Windows11Dark --control chart --control datagrid --post-action build
sf new winforms --name ReportsVB --language VB --target-framework net48 --theme Office2019Colorful --control datagrid --post-action build
sf new winui --name ReportsUI --target-framework net10.0 --control chart --post-action build
sf new wpf --name EmptyApp --post-action generate --no-restore
sf add wpf chart --path /full/path/Reports.csproj
sf update winforms datagrid --path /full/path/ReportsVB.vbproj --version 35.1.40 --build
sf remove winui chart --path /full/path/Existing.csproj
sf list wpf packages
sf list winforms installed --path /full/path/ReportsVB.vbproj
sf search chart --framework winui
sf help wpf
```

Omitting `--control` generates an empty desktop app. `--control empty` is also
accepted. `--path` for creation is the parent project location; package commands
accept an explicit .csproj/.vbproj or a directory containing exactly one project.
The wizard uses Platform → Language → Target framework → Theme → Project location
→ Project name → Setup → Controls (when selected) → Post-create → Confirmation.
Single-choice selections are displayed without an unnecessary picker. Setup offers
Empty project or Project with Syncfusion controls; only the second opens the
platform control catalog. Location preparation, unique name suggestions and
collision re-entry share the MAUI wizard components.
`--json`, `--no-color`, `--no-interactive`, `--dry-run`, source/config options and
cancellation apply to desktop operations as well. Build requires restore.
`Generate only` (`--post-action generate`) writes files without restore or build.
On macOS/Linux the CLI explains that building and running these apps requires Windows.

WPF and WinForms control aliases manage owned sample files, assets, welcome navigation,
and dependencies through `add` and `remove`. `update` preserves sample source and aligns
managed Syncfusion release versions to avoid dependency downgrades. Shared dependencies
remain installed for other controls. Edited or unowned sample source blocks destructive
changes, and failed operations roll back files, metadata, project references, and central
versions. Existing projects without an sf manifest and WinUI retain package-only operations.
Non-control/theme package removal still protects dependencies recorded as
required by generated controls or themes. The desktop manifest is
`Syncfusion/desktop.json`, separate from the MAUI control/project manifests.
Failed creation/restore/build rolls back the owned project directory. Failed
package operations restore project and central package configuration files.
Existing central versions are retained, and inherited CPM is not disabled.

## Prerequisites and project formats

Install the corresponding .NET SDK and Windows desktop tooling. Modern WPF and
WinForms start with Microsoft's `dotnet new wpf`/`winforms` templates; generated
projects use Windows TFMs and `EnableWindowsTargeting`. VB WPF uses
`Application.xaml`, the SDK's application-definition convention.

.NET Framework projects use classic MSBuild XML and explicit source/reference
items, not modern SDK templates. Restore/build requires Windows Visual Studio
MSBuild with the .NET desktop workload. Microsoft's
`Microsoft.NETFramework.ReferenceAssemblies` 1.0.3 supplies exact reference
assemblies, including frameworks absent from the local developer packs.

WinUI uses an unpackaged, self-contained Windows App SDK application pattern,
Windows 10 build 19041 minimum, and a win-x64 runtime identifier. Restore can run
on other hosts; building and launching require Windows desktop tools. ARM64/x86
are not offered by this implementation. It does not require an installed
`dotnet new winui` template.

On non-Windows hosts use `--post-action generate` for portable source
generation. Modern WPF/WinForms cross-compilation is also possible, but launching
always requires Windows. Required builds never report success when a tool fails.
Set `SYNCFUSION_LICENSE_KEY` in the application environment to register an existing
license; no license values are written into generated sources.

## Dependency evidence

NuGet 35.1.40 packages and their included API/XML documentation were inspected:

| Platform | Chart | DataGrid | Theme/infrastructure |
|---|---|---|---|
| WPF | Syncfusion.SfChart.WPF | Syncfusion.SfGrid.WPF | Syncfusion.SfSkinManager.WPF and Syncfusion.Themes.<variant>.WPF |
| WinForms | Syncfusion.Chart.Windows | Syncfusion.SfDataGrid.WinForms | Syncfusion.Office2019Theme.WinForms, Core.WinForms, Shared.Base |
| WinUI | Syncfusion.Chart.WinUI | Syncfusion.Grid.WinUI | Microsoft.WindowsAppSDK 2.2.0 |

WinForms Chart.Windows is the actual package ID. WinUI packages require Windows
App SDK >=2.2.0; the provider pins that dependency separately from Syncfusion's
version. WPF/WinForms packages include net462 assets; modern packages include
Windows net8/net9/net10 assets. WinUI chart axes use XAxes/YAxes collections.

Sources: [Microsoft WPF templates](https://learn.microsoft.com/dotnet/desktop/wpf/overview/),
[Windows Forms](https://learn.microsoft.com/dotnet/desktop/winforms/overview/),
[Windows App SDK unpackaged deployment](https://learn.microsoft.com/windows/apps/windows-app-sdk/deploy-unpackaged-apps),
[NuGet Syncfusion.SfChart.WPF](https://www.nuget.org/packages/Syncfusion.SfChart.WPF/35.1.40),
[Chart.Windows](https://www.nuget.org/packages/Syncfusion.Chart.Windows/35.1.40),
[Chart.WinUI](https://www.nuget.org/packages/Syncfusion.Chart.WinUI/35.1.40).

## Validation and troubleshooting

`scripts/validate-desktop.ps1` generates empty, individual-control and combined applications,
builds with warnings treated as errors, and optionally checks that each executable
displays a native window. The Windows workflow exercises every advertised
language/framework/theme/control combination. A window launch smoke check does
not establish all control interactions or visual theme correctness; inspect the
samples manually before publishing support claims.

The Linux development environment validates modern WPF/WinForms cross-compilation
and the CLI regression suite. Earlier Windows results verified the original Chart/DataGrid matrix. The expanded
control matrix still requires new Windows validation; earlier results do not cover
these new templates.
Visual theme appearance and deeper control interactions remain manual checks.
See the [validation report](validation/desktop-platforms.md) for exact evidence.

If an official template rejects a framework, install the matching SDK. If legacy
MSBuild is missing, install Visual Studio Build Tools with .NET desktop tools.
If restore fails, check `--source`, `--configfile` and NuGet connectivity. A build
failure includes the tool's error output and rolls back creation; rerun with the
same configuration after correcting prerequisites. Package-only commands never
regenerate user-modified sample files.


## WPF and WinForms control template lifecycle

The providers load physical embedded C# and VB templates, rather than inline
Chart/DataGrid placeholders. WPF supports Chart, DataGrid, Diagram, DockingManager,
Kanban, NavigationDrawer, Ribbon, Scheduler, and TreeGrid. WinForms supports Chart,
DataGrid, Diagram, DockingManager, and NavigationDrawer. Every control owns its
source and resources under its own folder, avoiding image/data-file collisions.

Use the catalog aliases: `chart`, `datagrid`, `diagram`, `docking-manager`,
`navigation-drawer`, plus WPF `kanban`, `ribbon`, `scheduler`, and `treegrid`.
Use aliases when a package supplies multiple control templates.

```bash
sf new wpf --name Reports --language VB --post-action generate
sf add wpf scheduler --path ./Reports --no-restore
sf update wpf scheduler --path ./Reports --version 35.1.40 --build
sf remove wpf scheduler --path ./Reports --no-restore
```

Adding a control follows the project's installed Syncfusion release unless an
explicit version is requested. Repeated add is a no-op. Update changes package
versions without replacing edited sample files. Remove deletes only owned source
and assets, updates project resource/compile entries and welcome links, and
restores the empty welcome state after the last control is removed. Untouched
older sf hosts migrate to the template-backed structure when their controls change.
Central version entries are retained during removal because other projects can use them.

The desktop templates were compiled as .NET 10 C#/VB applications on Linux with
Windows reference packs. Visual rendering, interaction, screen-reader behavior,
and .NET Framework builds still need a Windows host. The repository's referenced
`.agent` protocol/harness directory is absent, so harness-specific checks could not run.

# Generated .NET MAUI welcome screen

Native apps created by `sf new maui --project-type app` start on a welcome page made from MAUI XAML controls. The page uses the app's existing Shell, MVVM commands, light/dark colors, safe areas, and a scrolling layout. .NET 9 uses its compatible iOS safe-area API; .NET 10 uses `SafeAreaEdges="All"`. Blank apps show a friendly empty state. Each installed control appears as a rounded button that opens its sample page, with a back button supplied by Shell.

Resource cards link to Syncfusion demos, documentation, AI coding guidance, and the MAUI controls collection. They use four columns at 1000 or more content-width units, two at 560–999, and one below 560. Columns use equal widths; rows grow with their content. Window resizing and device rotation reflow the grid. Sample and footer buttons wrap, support touch and keyboard focus, and have at least 44-unit touch targets. Text uses native font scaling rather than fixed-height containers. Native containers and labels have explicit zero minimums, preventing unset sizes from becoming oversized Android minimums.

Native MAUI apps keep their welcome layout when controls change; only the shared registry changes. Verified older CLI pages retain their tracked navigation approach. Blazor Hybrid projects retain the Blazor view and add a scrolling, wrapping native sample strip bound to the same registry. Samples open modally inside a NavigationPage with a Close sample action. User-authored startup pages are preserved when automatic integration cannot be verified.

## Adding and removing samples

```sh
sf new maui --name MyApp --project-type app --control empty --post-action generate
sf add maui --control datagrid listview --path ./MyApp
sf add maui --control cartesian-chart circular-chart --path ./MyApp
sf remove maui --control cartesian-chart --path ./MyApp
sf remove maui charts --path ./MyApp
```

`--template` remains a compatibility alias for `--control`. Do not combine them or mix a positional package target with a control selection. Control-only aliases such as `combobox` can be positional. In CLI-generated projects, supported package aliases also use the shared sample workflow: `datagrid` integrates DataGrid, `inputs` integrates ComboBox, and `charts` selects Cartesian Chart. Package IDs resolve through their canonical catalog aliases; use `--control` to select another supported sample from a shared package. Adding another control from an installed package still generates its files and navigation, without changing the existing reference or version.

Ordinary projects retain package-only operations. These same commands integrate a matching sample when ownership metadata identifies CLI-generated scaffolding:

```sh
sf add maui datagrid --path ./MyApp
sf add maui toolkit --path ./MyApp
sf update maui datagrid --path ./MyApp
```

An ordinary-project package add reports that no sample was generated and shows the explicit sample command. A package without a sample is still added normally. `--no-restore` keeps an add as a package operation because sample compatibility cannot be established without restore. Package removal also removes every tracked sample that depends on that package, along with its registry entry and owned navigation blocks. Shared or user-owned dependencies are retained with an explanation.

Sample adds restore compatibility and build every target enabled by the project's configuration and OS conditions, using the resolved `.csproj` directly. `--build-framework <tfm>` validates an explicit enabled framework and passes it through `-f`; `--no-build` defers building. Removal supports `--build` and `--build-framework`. No automatic Android/host target is selected. Failures roll back package references, samples, registration blocks, and registry entries together. `--dry-run` previews changes without writing files. Actual changes require a rebuild/run to update the UI; repeated adds or removal of absent samples change nothing.

## Ownership and conflicts

`Syncfusion/syncfusion.json` is the project-local generation manifest. Schema 2 records:

- Each control's packages (including its Core dependency), generated views/ViewModels/models/resources, registration blocks, navigation entry, and welcome entry.
- Shared welcome files and icon resources, the generated `Syncfusion/Welcome/ControlRegistry.cs`, and SHA-256 file hashes.
- Exact marker boundaries and hashes for inserted registration and navigation code.

Schema 1 manifests remain readable and migrate during a successful operation. Missing records are reconstructed only from tracked paths and exact shipped samples or recorded hashes. Verified older inline navigation markers are recognized without claiming neighboring user code. Preview and failed operations never persist migration. Older CLI versions reject schema 2 rather than losing its new ownership records. Legacy registration that lacks block ownership is retained rather than guessed at.

The CLI validates removal before deleting anything. Edited generated files, a modified registry, edited inserted blocks, and user code referencing a generated sample produce a conflict and leave the operation unchanged. Missing tracked files/blocks can be repaired when their stored hashes match the shipped content. A missing registry is rebuilt from verified installed-control records. Unverifiable missing content requires manual restoration. `--force` does not bypass these sample-ownership conflicts. User edits outside tracked blocks remain intact. Untracked files, shared files, pre-existing references, and changed package references are preserved. Symbolic links below a generated destination are rejected.

Source scanning conservatively retains packages and registration needed by custom C#, XAML, Razor, or resource code. It may retain extra dependencies when references are ambiguous. Computed reflection references cannot be inferred; keep their package references user-owned. A user reference to a generated sample must be removed or migrated before deleting that sample.

Maps and Image Editor samples use small in-memory GeoJSON/image data; generated samples do not require a remote sample-data service. Syncfusion licensing requirements continue to apply; the CLI does not invent or embed a license key.

## Validation

See [welcome-screen validation](validation/maui-welcome-screen.md) for build results, operation checks, native screenshots, and platform limitations.

See [existing-project control validation](validation/existing-project-controls.md) for the original add/navigation regression, native Android results, screenshots, and platform limits.

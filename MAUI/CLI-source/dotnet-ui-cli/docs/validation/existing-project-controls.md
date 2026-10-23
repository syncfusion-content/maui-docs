# Existing-project control management

## Root cause and changes

Package aliases that also identify samples (`datagrid`, `charts`, and `inputs`) were dispatched to package management without running sample generation. Consequently, `sf add maui datagrid` could install the package but leave the welcome registry unchanged. Project discovery also stopped at the current directory, and repeated-add detection checked sample files without checking navigation, initialization, or references.

Managed projects now use the same catalog, generator, registry, and ownership manifest for creation, addition, and removal. Package aliases and package IDs resolve through the catalog's canonical alias; use `--control` to select another sample from a shared package. An installed package does not prevent generating another control's sample. Existing references and versions are retained. Native welcome pages read the updated registry, preserving their existing adaptive layout, button styling, ordering, and Shell navigation.

Project resolution searches upward to the nearest project directory, stopping at repository and non-MAUI project boundaries. Explicit `.csproj` paths remain supported. Multiple projects retain the existing interactive selector and noninteractive ambiguity error. The optional manifest `projectFile` binds ownership to the selected project; another project sharing that directory cannot inherit its generated samples.

Verified missing generated files, registry entries, and initialization blocks can be repaired. Edited or untracked content causes a preflight conflict, including with `--force`. Schema-1 metadata is reconstructed in memory using recorded paths plus exact shipped content or verified legacy navigation markers, then saved only after a successful operation. Older unbound metadata in a directory with multiple projects cannot prove ownership and is left untouched.

Removing a control cleans its owned sample and navigation while retaining dependencies required by other samples or custom code. Removing a package cleans all its dependent generated samples. Removing the final native sample restores the existing empty state. Package changes, generated files, blocks, and metadata share a rollback boundary; a requested build failure rolls back the failed add/remove operation. JSON reports package, sample, and build status separately.

Ordinary projects retain their startup page and navigation. Package operations explain that automatic sample integration is unavailable. Unsupported sample packages still complete their package operation. Explicit standalone sample generation remains available without rewriting an unowned startup page. `--no-restore` remains a package-only operation and explains that sample generation was deferred.

Blazor Hybrid projects retain their BlazorWebView and Razor application. A verified SDK page receives a registry-bound native sample strip with modal sample navigation and a Close sample action. User-edited pages are not reconstructed. The MAUI Blazor template does not accept `--no-restore`; creation now uses its supported arguments. On .NET 10, the mixed native/Razor MainPage uses a tracked, page-local Runtime (Debug) / XamlC (Release) override so XAML source generation does not attempt to resolve Razor-generated Routes in the same compilation. Other pages and target framework conditions are preserved.

## Reproduction and expected behavior

```sh
sf new maui --name ControlFlow --path "/tmp/control projects" \
  --project-type app --control cartesian-chart --post-action generate --no-interactive
cd "/tmp/control projects/ControlFlow"
sf add maui datagrid --no-interactive
# Rebuild/run the generated project, then select DataGrid on the welcome page.
sf add maui --control circular-chart --no-build --no-interactive
sf remove maui --control cartesian-chart --no-interactive
sf remove maui charts --no-interactive
```

Default requested builds run `dotnet build "<absolute-project.csproj>"`, without `-f` or forced framework properties. MSBuild evaluates all OS-enabled targets. `--build-framework net10.0-android` validates and passes that exact target through `-f`. Add builds by default; `--no-build` skips it. Remove builds only with `--build` or an explicit build framework. Successful operations without building explain that rebuilding/running is required.

## Validation

The Release tool package builds, installs from its local NuGet feed, and passes a packaged dry-run against the project path containing spaces.

The full CLI test suite passes: **471 passed, 0 failed, 0 skipped**. Tests cover shared-package samples, root/subdirectory/explicit paths and spaces, ambiguity, project ownership, repeated additions, missing-state repair, edited files and blocks, custom dependency retention, removal/re-addition, last-control removal, schema-1 migration and inline navigation, all 15 current sample records, ordinary projects, Hybrid integration, transactional build failures, and default/explicit build arguments.

```sh
dotnet test tests/Syncfusion.DotNet.CLI.Tests \
  --artifacts-path /workspace/setup/artifacts \
  -p:RestorePackagesPath=/workspace/setup/nuget/packages
```

A real Android project at a path containing spaces was created with Cartesian Chart. From its directory, adding the `datagrid` package alias generated and built DataGrid; its welcome button opened the working sample with in-memory rows (`1001`, `ALFKI`). Adding Circular Chart from a nested sample directory reused the installed Charts package. Repeated addition created no duplicates. Removal, re-addition through an explicit project path, edited-file conflict protection, whole-package removal, and an explicit Android framework build passed. MainPage contents stayed byte-for-byte unchanged throughout native control operations.

Android UI captures verify the original phone layout and four-column resource layout in a resized wide viewport. The wide capture is Android, not a native Windows/macOS desktop run. The shared Circular Chart sample also opened successfully. Removing the final two controls removed their references and registration, rebuilt successfully, and left an empty registry. Running the rebuilt app verified the friendly empty state and absence of removed buttons.

Debug APKs were additionally built with `-p:EmbedAssembliesIntoApk=true` for standalone emulator installation, avoiding Fast Deployment dependencies. This validation-only property does not change the CLI's build command or project targets. Syncfusion's unlicensed trial dialog was dismissed during sample validation; no license credentials were added.

Hybrid creation, package-alias add, shared registry integration, missing-integration repair, and all-configured-target Android builds passed with zero warnings/errors. Runtime inspection confirmed correctly measured ComboBox and DataGrid entries. Full Hybrid navigation/return and Razor rendering remain blocked: this emulator's Android WebView renderer crashes with SIGTRAP. The stock `org.chromium.webview_shell` app reproduces the same Chromium renderer failure on `about:blank`, independently of the CLI and Syncfusion. No Hybrid runtime pass or blank-screen screenshot is claimed.

Native Windows, macOS/Mac Catalyst, and iOS build/run checks are unavailable on this Linux environment. Their target conditions remain unchanged. Android builds use SDK 10.0.100, MAUI 10.0.0, Android SDK 36, JDK 21, and an Android 35 x86_64 software emulator.

## Screenshots

- [Wide welcome page after add](../images/control-management/wide-added-controls.png)
- [Phone welcome page after add](../images/control-management/phone-added-controls.png)
- [New DataGrid sample](../images/control-management/new-datagrid-sample.png)
- [Shared-package Circular Chart sample](../images/control-management/shared-chart-sample.png)
- [Empty state after final removal](../images/control-management/empty-after-removal.png)

# Syncfusion package source and version policy

CLI installation and update operations use only the official feed:
`https://api.nuget.org/v3/index.json`.

When no `--version` is supplied, the CLI queries nuget.org for the package's
latest stable release and passes that concrete version to package installation.
It does not write `*`, version ranges, or a hard-coded default release for new
Syncfusion package installations. This also applies to `--no-restore` package
adds and generate-only desktop/Blazor projects.

Generate-only and `--no-restore` actions still need version-discovery connectivity
unless an explicit version is supplied. An explicit `--version 35.1.40` remains
supported for intentional pinning.
Already-installed controls remain idempotent; adding a second sample that shares
an existing concrete MAUI package reference preserves that dependency. Use
`sfdotnet update` to change an installed package. Non-Syncfusion platform dependencies
retain their required versions.

CLI restores explicitly select nuget.org, so configured local feeds cannot
supply a higher package version. `--source` accepts only the official URL;
other URLs and local paths are rejected before CLI execution. `--configfile`
can still supply other NuGet settings, but does not change the feed used by CLI
operations. User/machine NuGet configuration is not rewritten. Subsequent
manual `dotnet restore` commands remain subject to their own NuGet settings.

If official version discovery fails, installation fails rather than substituting
a wildcard, a cached fallback release, or a local-feed version. Dry runs do not
install packages or change project files. Central package management continues
to store concrete versions in `Directory.Packages.props`.

## Verification

A live fixture configured a local-only `NuGet.Config` and supplied fake
`Syncfusion.Blazor.Grid` and `Syncfusion.Maui.Buttons` packages at version
`999.0.0`. The CLI selected nuget.org's current stable `35.1.40`:

- Blazor Grid project creation, restore, and build succeeded.
- WPF, WinForms, and WinUI generated projects contained concrete official-feed
  versions. Additional WPF/WinForms DataGrid additions restored successfully.
- MAUI package-only `buttons` installation with `--no-restore --no-build` wrote
  `35.1.40`, not `*` or `999.0.0`.
- An explicit local `--source` was rejected without creating a project.

All 1,146 automated tests passed. Tests cover numeric stable-version ordering, prerelease exclusion,
exact package matching, failed lookups, explicit version pins, source rejection,
concrete generated references, dry-run safety, rollback, and central package
management. Native MAUI/WinUI application builds and Windows runtime checks
were not performed on the Linux host.

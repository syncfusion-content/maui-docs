# Package discovery parity

All five platforms use the MAUI package-list renderer and the same installed
`Alias`, `NuGet`, `Version` table. The available-package columns are `Alias`,
`Name`, `NuGet`, with content-sized widths, category spacing, word-preserving
wrapping, a narrow-terminal stacked layout, interactive paging and complete
noninteractive/redirected output. Descriptions and sample availability are shown
only with `--details` / `--verbose`. Search matches alias, display name, ID and
description. `sf info` no longer advertises disabled removal, in text or JSON.

## Verified inventory — 2026-10-16

| Platform | Listed alias entries | Distinct NuGet IDs | Generated control choices |
|---|---:|---:|---:|
| .NET MAUI | 51 | 51 | 10 |
| WPF | 108 | 106 | 9 |
| WinForms | 51 | 50 | 5 |
| WinUI | 19 | 18 | 5 |
| Blazor | 59 | 59 | 15 |

Several desktop controls share a package; their existing aliases remain valid.
Newly discovered packages are package-only entries and do not create samples or
change default selections. Existing generated-control and theme choices are
preserved. Installation still resolves the latest stable version from NuGet.org;
the audited versions are evidence rather than installation pins.

Each non-MAUI platform owns an embedded `Catalog/available-packages.json` with the
source, verification date, package IDs, aliases, descriptions and verified
versions. Shared merge logic preserves current control aliases and template flags.
The MAUI catalog was verified against NuGet.org and left unchanged, including
its existing MCP listing exclusion.

The audit used NuGet.org's stable search results for `Syncfusion WPF`,
`Syncfusion WinForms`, `Syncfusion WinUI`, `Syncfusion Blazor` and `Syncfusion Maui`
with `take=1000`, `prerelease=false` and `semVerLevel=2.0.0`. Package IDs, versions,
`SyncfusionInc` ownership and library package types were checked. The new
catalogs include platform-specific PackageReference libraries; Xamarin, other
product families, superseded legacy packages, .NET tools and project templates
are excluded. Explicit legacy exclusions are recorded in the snapshots with NuGet registration
evidence: the Blazor alternatives are deprecated, and the two legacy WPF lines
have unlisted current releases.
Availability does not imply that every target framework can consume each library;
NuGet restore selects compatible assets.

## Installed packages and JSON

Installed output has a platform-specific heading, one header row, two-space
indentation, an empty alias cell for unrecognized Syncfusion packages and a clear
empty-list message. Other vendors' references are excluded. MAUI keeps its
`Syncfusion.Maui.*` scope; the other providers show direct `Syncfusion.*` references.
Versions support inline attributes, child elements, `VersionOverride` and the
nearest `Directory.Packages.props`.

Existing JSON field names remain unchanged: desktop/Blazor available rows retain
`Alias`, `DisplayName`, `Id`, `HasTemplate`; installed rows retain `Id`, `Version`.
MAUI retains its existing JSON records. The non-MAUI installed listing now filters
to Syncfusion references, matching the command's advertised scope.

## Verification

- CLI compilation: zero warnings/errors.
- Full suite: **1,256 passed, one failed, zero skipped**. The failure is the
  previously confirmed baseline MAUI Diagram color check,
  `MauiControlLayoutTests.ControlSourcesDoNotCreateCustomColorsOrBrushes`.
  Its unchanged Diagram source creates custom colors; this change does not
  modify MAUI control templates.
- Tests cover all platform catalogs, preserved control counts and unique picker
  labels, available/installed formatting, unknown aliases, central/inline/override
  versions, empty results, search/detail/verbose behavior, JSON contracts and
  layouts at 32, 40, 80, 120 and 240 columns. Existing MAUI presentation and package
  lifecycle regressions remain in the full suite.
- Real CLI checks passed for all five platforms: available/installed output,
  primary and legacy/`--framework` syntax, matching JSON results and text/JSON
  `info` without removal. Legacy namespaced WPF/WinForms VB projects and a
  Blazor WebAssembly project also passed installed-list checks.
- Four new package-only additions passed with `--no-restore`: WPF Barcode,
  WinForms ListView, WinUI Editors and Blazor Buttons. This verifies discovery
  rows are accepted by existing package operations without generating templates.
- Real Linux pseudo-terminals passed paging and 40-column noninteractive output
  across all five platforms. Scripted output did not prompt; narrow output did
  not overflow.
- The Windows/macOS/Linux terminal CI matrix now includes the discovery tests.
  Windows and macOS terminal execution was not performed locally. No native UI
  build/runtime validation is claimed for this presentation/catalog change.

The complete command-option inventory is in `cli-flow-options-review.md`;
usage and output contracts are in `command-reference.md`.

## CI availability

PR #46's terminal jobs were rejected before starting. GitHub's check annotation
reports failed recent account payments or a spending limit that needs to be
increased. CI therefore does not establish Windows/macOS/Linux runner results;
the local results above are reported separately.

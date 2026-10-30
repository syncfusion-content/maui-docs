# Internal CLI installation guide

For developers and testers installing `Syncfusion.DotNet.Cli` preview packages.
The installed command is **`sfdotnet`**; install, update and uninstall use the
**package ID**, not `sfdotnet`.

These instructions manage the CLI tool itself, not Syncfusion component
packages in an application. See the [command reference](docs/command-reference.md)
for application commands.

## Prerequisites

- Install the .NET 10 SDK and confirm `dotnet --version` works.
- Obtain the required `.nupkg`, or build it using the commands below.
- Run global tool commands as your normal user; administrator/root access is
  not required.

The examples use **0.1.0-preview.7**. Change the version for a newer package.
Local previews are not necessarily published on NuGet.org and are not a claim
that all release gates have passed.

## Install globally from a local package

Run from the repository root in PowerShell:

```powershell
$feed = (Resolve-Path ".\artifacts\packages").Path
dotnet tool install --global Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed"
sfdotnet --version
sfdotnet --help
```

`--add-source` takes the **directory containing the `.nupkg`**, not the package
file. If you received the package separately, set `$feed` to that directory:

```powershell
$feed = "C:\Packages\Syncfusion"
```

For macOS/Linux using a shell, from the repository root:

```bash
feed="$(pwd)/artifacts/packages"
dotnet tool install --global Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed"
sfdotnet --version
```

Do not install again if the tool is already installed in the same scope; use
the update command instead.

## Update a global installation

PowerShell, from the repository root:

```powershell
$feed = (Resolve-Path ".\artifacts\packages").Path
dotnet tool update --global Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed"
sfdotnet --version
```

macOS/Linux:

```bash
feed="$(pwd)/artifacts/packages"
dotnet tool update --global Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed"
sfdotnet --version
```

Use the version of the new package. Prefer a new preview version for each build;
reusing a version can select a cached package. To deliberately return to an
older version, add `--allow-downgrade` to the update command.

## Uninstall a global installation

Same command on Windows, macOS and Linux:

```text
dotnet tool uninstall --global Syncfusion.DotNet.Cli
dotnet tool list --global
```

Uninstalling the CLI does not remove application files, generated MCP
configuration or installed agent skills.

## Test in an isolated tool directory

Use `--tool-path` **instead of** `--global` to leave your global installation
untouched. PowerShell, from the repository root:

```powershell
$feed = (Resolve-Path ".\artifacts\packages").Path
$toolPath = Join-Path ([System.IO.Path]::GetTempPath()) "syncfusion-cli-test"

# Install and invoke this exact installation.
dotnet tool install Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$toolPath"
& (Join-Path $toolPath "sfdotnet") --version
& (Join-Path $toolPath "sfdotnet") --help

# Update an existing installation in this directory.
dotnet tool update Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$toolPath"

# Uninstall only this isolated copy.
dotnet tool uninstall Syncfusion.DotNet.Cli --tool-path "$toolPath"
```

On macOS/Linux, use an explicit executable path as well:

```bash
feed="$(pwd)/artifacts/packages"
tool_path="${TMPDIR:-/tmp}/syncfusion-cli-test"
dotnet tool install Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$tool_path"
"$tool_path/sfdotnet" --version
dotnet tool update Syncfusion.DotNet.Cli --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$tool_path"
dotnet tool uninstall Syncfusion.DotNet.Cli --tool-path "$tool_path"
```

## Pack a new internal preview

From the repository root in PowerShell:

```powershell
$version = "0.1.0-preview.8" # Choose a new, unused preview version.
dotnet pack .\src\Syncfusion.DotNet.Cli\Syncfusion.DotNet.Cli.csproj --configuration Release "-p:Version=$version" "-p:PackageVersion=$version" "-p:InformationalVersion=$version"
```

macOS/Linux:

```bash
version="0.1.0-preview.8"
dotnet pack ./src/Syncfusion.DotNet.Cli/Syncfusion.DotNet.Cli.csproj --configuration Release "-p:Version=$version" "-p:PackageVersion=$version" "-p:InformationalVersion=$version"
```

Output: `artifacts/packages/Syncfusion.DotNet.Cli.<version>.nupkg`.
All three overrides keep the package and `sfdotnet --version` aligned without editing
the repository's default version. Packing does **not** publish or install it.

## Cake and Jenkins packaging

The Windows Jenkins pipeline follows the MAUI sample-browser job's agent
convention (`Maui-SB`) but packs this repository's SDK-style .NET tool project,
not the sample-browser's assemblies or a hand-written nuspec. It uses the
repository-pinned Cake.Tool and the .NET SDK selected by `global.json`;
no MAUI workloads or legacy NuGet.exe bootstrap are required.

### Jenkins job settings

**Temporarily disabled:** `RUN_CAKE` defaults to **false** while the Jenkins
compiler crash is investigated. Default runs print a disabled notice and skip
the entire Cake pipeline, including tests, packaging and Nexus publication,
without allocating the `Maui-SB` agent. This is not a successful validation of
the CLI. Setting `PUBLISH_PACKAGE=true` alone cannot enable Cake or publication.
To re-enable deliberately, run with `RUN_CAKE=true` and supply `studio_version`;
the build/test checks and development-only publication safeguards still apply.
Local Cake commands below are unchanged.

- Load the root `Jenkinsfile` from SCM using a Pipeline or Multibranch Pipeline
  job. The agent needs Git, Windows PowerShell, .NET 10 SDK and network access to
  NuGet.org and the internal Nexus server. Use the existing SCM credentials.
- Supply **`studio_version`**, for example `0.1.0-preview.9` or `32.1.0.1`.
  This value is passed unchanged to Cake and sets `Version`, `PackageVersion`
  and `InformationalVersion`. There is no automatic revision or preview suffix.
  NuGet normalizes a trailing fourth `.0` in the archive name/metadata.
- **`PUBLISH_PACKAGE` defaults to false.** Enable it only for a non-PR build of
  **`development`**. The branch must be available as `BRANCH_NAME`,
  `githubSourceBranch`, `GIT_LOCAL_BRANCH` or `GIT_BRANCH`; missing/other branches fail a
  requested publication rather than guessing. Configure webhook jobs to supply
  their PR identifier (`CHANGE_ID`, `pullRequestId`, `gitlabMergeRequestIid` or
  `ghprbPullId`) so PR publication is rejected, including same-repository PRs.
  A populated `githubTargetBranch`, GitLab merge action, or `TAG_NAME` also
  blocks publication; do not populate PR-only fields on normal branch builds.
- Keep the existing **`nugetapikey`** environment binding, backed by a Jenkins
  **masked secret credential**, not a plain string parameter. The old pipeline
  already referenced this variable; repository files cannot confirm whether the
  Jenkins job currently binds it. No new credential ID is assumed. The publish
  target fails explicitly if it is missing. Do not expose credentials to
  untrusted PR jobs; configure those jobs without the secret binding.
- Optional existing **`nugetserverurls`** is accepted. For compatibility with
  the sample-browser, the first comma-separated URL is the push endpoint;
  additional URLs are never push destinations. The default and only permitted
  push destination is
  `https://nexus.syncfusioninternal.com/repository/nuget-hosted/`.
  Dependency restore still uses the repository's `nuget.config`.

The CI target restores and builds the solution, runs the **full test suite**
without exclusions, packs the CLI, validates its metadata and customer README,
then installs it in an isolated temporary tool directory and checks its JSON
version and help output. A failure prevents publishing. In particular, existing
test failures must be resolved before this job can publish; this setup does not
silence the known release blockers. Jenkins archives `.nupkg` and TRX results
even on failure, and clears only its dedicated CI output at the next checkout.
It requires the standard Pipeline, PowerShell and artifact-archiving steps;
it does not require the sample-browser's GitLab status or workspace-cleanup
plugins.

### Run the same targets locally

From the repository root in PowerShell:

```powershell
# Bootstrap argument/exit-code tests; no network or publication.
.\build\test-build.ps1

# After Cake tool restore: also exercise real publish rejection paths.
# These checks clear the key in child processes and cannot upload.
.\build\test-build.ps1 -Integration

# Complete Jenkins-equivalent validation and packaging; never publishes.
.\build\build.ps1 -Target CI -StudioVersion 0.1.0-preview.9

# Packaging and isolated smoke test only (not full release acceptance).
.\build\build.ps1 -Target SmokeTest -StudioVersion 0.1.0-preview.9

# Inspect the task graph without executing tasks.
.\build\build.ps1 -Target CI -StudioVersion 0.1.0-preview.9 -WhatIf
```

CI output is separate from local previews:
`artifacts/ci/packages/Syncfusion.DotNet.Cli.<version>.nupkg` and
`artifacts/ci/test-results/cli-tests.trx`.
`Build`, `Test`, `Pack` (also `packnuget`) and `CodeViolation` are available;
`CodeViolation` uses the project's build analyzers instead of obsolete
StyleCop/FxCop tools. `Default` runs `CI`.

The `Publish` target pushes only the exact requested version already in the CI
package directory, without rebuilding it or skipping duplicate-version errors.
Jenkins invokes it only after successful CI and branch/PR checks. Direct local
invocation is a deliberate upload, not a dry run: it requires the environment
secret and does not apply Jenkins branch policy. Use it only after the same
validation and release approval. Never put keys in command arguments or source
files. The legacy bootstrap's checked-in key default has been removed; the
credential owner should rotate that previously committed credential.

## Troubleshooting

- **`sfdotnet` not found:** restart the terminal and check that the global tool
  directory is on `PATH`: `%USERPROFILE%\.dotnet\tools` on Windows or
  `$HOME/.dotnet/tools` on macOS/Linux.
- **Wrong version runs:** check `dotnet tool list --global` and locate the
  executable with `Get-Command sfdotnet -All` in PowerShell or `type -a sfdotnet` in bash.
  An isolated installation must be invoked by its explicit path.
- **Version not found:** confirm the exact package version exists in the local
  feed directory. The package version is not a Syncfusion component version.
- **Private feed authentication errors:** configured NuGet sources are still
  consulted when using `--add-source`. Use a dedicated NuGet configuration with
  only the local feed and pass `--configfile <path>` if needed. Do not copy
  credentials into this guide or source control.

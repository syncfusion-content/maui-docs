# MAUI post-creation build validation

The default post-creation command is now:

```text
dotnet build "/absolute/project location/MyApp/MyApp.csproj"
```

No `-f`, `--framework`, forced `TargetFramework` property, or `--no-restore` is added automatically. MSBuild selects every target enabled by the project configuration and current OS. The existing CLI platform and template-version options retain their meanings. Explicit `--build-framework net10.0-android` evaluates the configured project targets before forwarding that same value through `-f`.

The final review shows:

```text
Post-create:       Build project (all configured targets)
```

An explicit target instead shows:

```text
Post-create:       Build project (net10.0-android)
```

## Automated checks

**429 tests passed, none failed or skipped.** New coverage verifies the exact default and explicit build argument lists, absolute project paths containing spaces, unchanged multi-platform project XML, evaluated OS-conditioned targets, single-target projects, invalid/disabled targets, missing prerequisites, retained generated files and manifest, quoted retry commands, review output, and compatibility of existing `--framework`, `--target-framework`, and post-action options. Creation failures include diagnostics from stdout, stderr, process launch, and welcome installation. Host-resolution checks cover PATH precedence, runtime-installation fallback, and preserved explicit executable overrides. Incomplete generation still rolls back; completed generation survives a failed build. Existing control add/update rollback tests remain passing.

```sh
COLUMNS=120 LINES=40 dotnet test tests/Syncfusion.DotNet.Cli.Tests/Syncfusion.DotNet.Cli.Tests.csproj \
  --artifacts-path /tmp/sf-artifacts -p:RestorePackagesPath=/tmp/sf-nuget
```

The test build reported one existing xUnit analyzer warning in `WelcomeLifecycleTests`; there were no new analyzer warnings from the build-behavior tests.
The Release CLI package also built successfully without warnings or errors.

## Real CLI checks

Validated on Linux with .NET SDK 10.0.100, stable MAUI Android workload set 10.0.100, Android SDK 36, and JDK 21. Commands ran from `/tmp`, with generated projects under `/workspace/setup/configured build smoke`.

| Scenario | Result |
| --- | --- |
| Default Build project | Build succeeded using the generated `.csproj` directly, without a target override |
| Explicit `--build-framework net10.0-android` | Evaluated target validation passed; Android build succeeded |
| OS-conditioned configuration | Generated XML retained Android plus conditional iOS, Mac Catalyst, and Windows declarations; MSBuild enabled only Android on Linux |
| Explicit Windows target on Linux | Rejected as not enabled; diagnostic listed the evaluated Android target; project and welcome files retained |
| Missing Android SDK/JDK paths | Build failed with `XA5300` and platform-tool installation guidance; creation succeeded and project/manifest remained on disk |
| Spaces and unrelated current directory | Both successful native builds and both failure cases used absolute paths containing spaces from `/tmp` |

Reproduce successful default and explicit builds with prerequisites installed:

```sh
sfdotnet new maui --name DefaultBuildApp --path "/tmp/parent with spaces" \
  --project-type app --control empty --post-action build --no-interactive --json

sfdotnet new maui --name ExplicitBuildApp --path "/tmp/parent with spaces" \
  --project-type app --control empty --post-action build \
  --build-framework net10.0-android --no-interactive --json
```

A build failure returns a nonzero exit code, keeps the generated project, and includes the underlying error and retry command:

```json
{
  "generationSucceeded": true,
  "buildSucceeded": false,
  "rolledBack": false,
  "nextCommands": [
    "dotnet build \"/workspace/setup/configured build smoke/MissingToolsApp/MissingToolsApp.csproj\""
  ]
}
```

The `errors` array contains the actual MSBuild diagnostics; normal output reports project creation success and build failure separately. Missing workload diagnostics are also covered by injected `NETSDK1147` results without changing the installed workload set.

## Installed-tool launch regression checks

The packaged tool was installed into separate local tool directories with fresh
NuGet caches. Before the fix, the installed apphost reproduced two failures:

- SDK absent from `PATH`, although the tool's running .NET installation contained
  a usable SDK host: child `dotnet` launch failed with `No such file or directory`.
- Shell left inside a removed directory, with a valid SDK on `PATH`: child host
  lookup failed with `Unable to find the specified file`, and normal output hid
  the exception behind the generic creation failure at step 2.

The fixed installed tool resolved the SDK to an absolute executable path.
Creation and a default native Android build succeeded from inside an existing
project with the SDK omitted from `PATH`; generation and a full default native
Android build also succeeded from a deleted shell directory. These checks used destinations containing spaces,
and the release package built without warnings/errors. The workaround for older
installations is to move to an existing directory before invoking the wizard.

The reported Mac subsequently succeeded both at `/tmp` Generate-only creation
and home-directory default Build creation, as verified by the user's JSON
results. Its original hidden exception was unavailable, so the deleted-directory
reproduction demonstrates a matching failure rather than proving the original
Mac directory's state.

Native Windows, Mac Catalyst, and iOS builds were unavailable on this Linux host. Their declarations remain intact for builds on supported hosts; actual native checks here exercised Linux's evaluated Android target.

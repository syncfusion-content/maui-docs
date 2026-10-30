# CLI confirmation, answers, next commands, and persistent progress

## Changes

- Creation asks `Proceed with project creation? [Y/n]:`. The existing default, accepted answers, validation loop, Escape/Ctrl+C behavior, and cancellation exit code are preserved.
- Normal console output omits the build suggestion after a successful requested build. Generate only retains it; failed builds retain the generated project and show the existing failure diagnostics and exact retry command. Explicit framework retries retain `-f`; default builds retain all configured targets without forcing a framework.
- Committed answers, automatic selections, creation-review values, and package/control review values use the shared bold blue `#3675D5` accent. Labels stay neutral. Active selections use inverse/bold styling, retaining selection markers and checkbox states. Success, warning, and error styles remain distinct.
- Live progress retains completed green checkmarks, an active spinner or measured item bar, muted pending steps, and explicit failure/cancellation/skipped states. Package and file batches use actual processed/total counts; SDK operations without measurements use a spinner. No percentages are synthesized from stage indexes.
- Optional lifecycle callbacks mark work complete at the actual operation boundaries. Creation forwards the same lifecycle to its control installer, so generation and registration are no longer presented as starting after they have already finished. Preparation, welcome/navigation scaffolding, and manifest writes have their own actual-work stages. The old seven-step callback and existing string-only callback sequence are retained for callers using those contracts.
- Only requested/applicable operations are planned. Shared-package additions omit unnecessary package/registration work; repeated additions and dry runs do not invent successful work. Failed stages receive no success checkmark. Subsequent unstarted stages are skipped. Overall failure/rollback reporting remains separate from individual stage completion.
- Redirected, `--no-color`, and `NO_COLOR` output remains unstyled and append-only. It records start/completion transitions without cursor control or animation. JSON and internal silent progress remain suppressed.

Command syntax, defaults, build/restore order, executed SDK arguments, serialized results/messages, JSON `nextCommands`, catalogs, project templates, ownership checks, and rollback behavior are unchanged. Outcome-aware suggestions apply to normal console output, preserving the existing JSON contract.

## Representative output

Creation review in a wide terminal (values are blue; labels are neutral):

```text
Action:            Create a new project
Platform:          .NET MAUI
Template:          .NET MAUI App
Framework:         .NET 10 (net10.0)
Project location:  /projects/parent with spaces
Project name:      App
Setup:             Include Syncfusion controls
Controls:          DataGrid
Post-create:       Build project (all configured targets)
Proceed with project creation? [Y/n]:
Enter: continue | Esc: cancel | Ctrl+C: exit
```

Hints remain only while awaiting input. After confirmation, default creation
progress shows grouped actual work:

```text
✓ Creating project
✓ Adding Syncfusion controls
⠋ Finalizing project
· Building project — pending
```

Blank apps omit Adding Syncfusion controls and use Setting up project files
in place of Finalizing project; Generate only omits Building project. Build
outcomes are ✓ Built project or ✗ Build failed.; other failures identify the
specific internal sub-step.
`--verbose` retains the detailed live operation region:

```text
✓ Preparing destination
✓ Creating project from MAUI template
✓ Installing welcome screen
✓ Adding packages
⠋ Restoring
· Generating files — pending
· Registering in MauiProgram.cs — pending
· Updating navigation — pending
· Writing control manifest — pending
· Writing project manifest — pending
· Building project — pending
```

During a measured file batch, for example:

```text
… Generating files [######------] 2/4
```

Successful requested build:

```text
✓ Project created successfully.
Generated location: /projects/parent with spaces/App
✓ Build succeeded: all configured targets.
Next commands:
  cd "/projects/parent with spaces/App"
  sfdotnet list maui installed
```

Generate only keeps `dotnet build "/projects/parent with spaces/App/App.csproj"`. A failed build shows `✗ Building — failed`, keeps the generated location available, reports the relevant error separately, and supplies the retry command. An explicitly selected `net10.0-android` adds `-f "net10.0-android"` to that retry.

## Validation

- Debug and Release suites: **539 passed, 0 failed, 0 skipped** each, including the existing 512 cases and 27 additional cases for outcome-aware suggestions, colored/wrapped prompt cleanup, live/pending/failed progress, measured counts, cancellation, suppression, creation stages, shared dependencies, repeated additions, missing-platform-tools guidance, and rollback after package/restore/build failures.
- Native terminal and deterministic SDK-host checks: **67 captures** across live TTY, redirected, no-color, and JSON modes. This includes **13 byte-for-byte JSON stdout/exit-code comparisons** against the previous packaged CLI. Checks cover creation, build failure, package/control add-update-remove, lists/search, missing arguments, collision/name retry, decline, and verbose diagnostics.
- **Six native navigation/cancellation captures** verify arrows, Space toggles, multiple-control creation, Escape/Ctrl+C exit code 130, and removal of live hints.
- **14 additional captures** verify successful default/explicit builds and explicit-framework failures across four output modes, narrow 32-column output, and interactive package addition inside an existing project. Child-host logs verify `build <full.csproj>` or `build <full.csproj> -f net10.0-android`, including paths containing spaces; no forced framework property is supplied.
- **18 real SDK captures** with .NET SDK 10.0.100 verify blank generation and package add/update/remove in four modes, plus DataGrid restore/generation/build and removal/build in an Android fixture under a path containing spaces. The fixture was explicitly configured for Android; production target configuration was not changed.
- **Three additional real SDK creation/build checks** verify an unmodified template's default build, explicit `net10.0-android`, and an unavailable Android SDK. The installed MAUI template retains OS-conditioned Android/iOS/Mac Catalyst/Windows configuration; on Linux the default build succeeds for its enabled Android target. Missing Android tools cause XA5300, preserve the generated project, and retain the default retry command. Normal output explains how to configure the missing SDK; raw diagnostics remain available through verbose output.
- A Release tool package was installed with an isolated package cache. Its CLI/Core/MAUI assemblies match the current Release build hashes. Packaged-tool checks passed for Generate only, successful build, explicit-framework retry, JSON output, and real XA5300 guidance. The installed `sfdotnet` apphost also passed `info --json` and native SDK generation.
- Color rendering tests use true-color terminal capabilities. The blue's calculated contrast against white and black is approximately 4.50:1 and 4.66:1; inverse selection uses the terminal's foreground/background pairing. Existing limited-color/no-color tests remain passing.

Commands use the existing cloud SDK/cache and standard terminal dimensions:

```sh
DOTNET_ROOT=/workspace/.dotnet \
DOTNET_CLI_HOME=/workspace/setup/dotnet-home \
COLUMNS=120 LINES=40 TERM=xterm-256color \
/workspace/.dotnet/dotnet test sf-net-cli.slnx --no-restore \
  --artifacts-path /workspace/setup/artifacts \
  -p:RestorePackagesPath=/workspace/setup/nuget/packages -m:4
```

Logs and terminal captures are under `/workspace/setup/refinement-*`.

## Platform limits

Native Windows, iOS, and Mac Catalyst builds/runs are unavailable on this Linux host. Existing explicit/default-framework and OS-conditioned target tests remain included. Generated app layout and sample code are unchanged; terminal checks and Android compilation were performed, without repeating app UI screenshots.

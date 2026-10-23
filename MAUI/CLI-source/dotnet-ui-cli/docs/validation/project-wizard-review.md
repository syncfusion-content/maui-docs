# Project-creation final review

The project wizard displays completed choices while collecting input, then
replaces its owned rows with one final configuration block. It preserves the
CLI header, earlier terminal output, and important collision warnings. Guidance
for the project location is temporary content within that prompt. Other CLI
prompts continue retaining their completed results.

Example while awaiting confirmation:

```text
Action:            Create a new project
Platform:          .NET MAUI
Template:          .NET MAUI App
Framework:         .NET 10 (net10.0)
Project location:  /apps/SyncfusionMauiApp
Project name:      SyncfusionMauiApp
Setup:             Blank app
Post-create:       Build project (all configured targets)
Create project? [Y/n]:
Enter: continue | Esc: cancel | Ctrl+C: exit
```

The confirmation prompt and its hints are removed after input. An accepted
confirmation leaves `Create project: y`. Long values wrap onto continuation
lines aligned with the value column. Wrapping preserves path separators,
spaces, Unicode text, and long individual path segments without truncation.
The label column is shared with creation prompts and completed answers. Its
width comes from the longest creation label, Project location:, plus two
spaces. Wrapped values retain this indentation on narrow terminals; the
confirmation question and its footer keep their existing layout.

With `--build-framework net10.0-android`, the Post-create row is:

```text
Post-create:       Build project (net10.0-android)
```

Generation without building shows `Post-create:       Generate only`.
Project location is the chosen folder; success prints the full generated
project path in `Project created at <full path>`. Existing platform/template framework arguments retain their
meanings. The default build command remains `dotnet build "<generated.csproj>"`;
an explicitly evaluated build framework is passed through `-f`. MSBuild retains
control over configured targets and OS conditions.

## Automated validation

**443 tests passed**, none failed or skipped. Tests render ANSI output onto a
terminal grid rather than merely removing escape sequences, so erased rows and
wrapped hint cleanup are checked as displayed.

- Final default, explicit-target, and Generate-only reviews at 32 and 120 columns;
  each configuration label appears once, completed helpers/options disappear,
  and surrounding output remains.
- Active confirmation hints and complete cleanup after submission, Escape,
  and Ctrl+C, with the final review preserved on cancellation.
- Long destinations at 32, 60, and 120 columns, including spaces, Japanese
  text, and a 75-character segment. Concatenating continuation values reproduces
  the exact selected destination; displayed cell widths fit the terminal.
- Identical parent/project names intentionally nest and agree with the
  creation/build plan. Existing post-creation build tests still verify exact
  argument lists, OS-conditioned framework validation, explicit target
  compatibility, and retained projects on failed builds.

```sh
COLUMNS=120 LINES=40 dotnet test tests/Syncfusion.DotNet.CLI.Tests/Syncfusion.DotNet.CLI.Tests.csproj \
  --artifacts-path /tmp/sf-artifacts -p:RestorePackagesPath=/tmp/sf-nuget
```

The test build retains one existing xUnit analyzer warning in
`WelcomeLifecycleTests`. The release CLI package builds without warnings/errors.

## Native terminal checks

Real CLI checks used a pseudoterminal with an ANSI terminal emulator, on Linux
with .NET SDK 10.0.100, the stable Android MAUI workload, Android SDK 36, and
JDK 21. Output preceding the wizard was deliberately inserted to verify that
review replacement preserves it.

- Bare `sf` wizard: the root Action record and completed selections were
  replaced with one review; a default Android build succeeded. Starting inside
  an existing `SyncfusionMauiApp` directory and accepting the parent/name
  defaults generated the legitimate nested project
  `SyncfusionMauiApp/SyncfusionMauiApp`.
- Explicit Android framework: review target and successful build target agreed.
- Narrow 32-column review after multiple control selection: destination wrapped,
  `Controls:` had no count, decline cleared confirmation hints, and no project
  was created.
- Default collision: the suggestion remained explained once, the review used
  the resolved suffix, and generation used that destination.
- Escape and Ctrl+C at confirmation: hints disappeared, the review remained,
  and creation did not start.

Native Windows, Mac Catalyst, and iOS builds were unavailable on this Linux
host. This change preserves the existing build behavior; no platform override
is introduced by review rendering.

# Knowledge: command surface (backward-compatibility baseline)

Source: docs/command-reference.md (retrieved 2026-10-14)

- Shape: `sf <action> <platform> <target> [options]`. Platforms: maui, blazor, wpf, winforms, winui.
- Every wizard input has a direct-command equivalent (table in the Project section of that document).
- Blazor options: `--app-type web-app|webassembly-standalone`, `--render-mode server|webassembly|auto`, `--interactivity per-page|global`, `--auth none|individual`, `--https yes|no`, `--theme`, `--control`, `--path`, `--post-action generate|build`.
- `--post-action generate` generates files without restore or build, so generation can be verified on a host that cannot build the platform.

Observed on 2026-10-14 against `src/Syncfusion.DotNet.CLI/bin/Release/net10.0/sf.dll`: `sf help <platform>` prints each platform's command map; invalid values exit 1 with a one-line error and write nothing. This is an observation of the build in this repository, not a specification.

# Interactive wizard layout validation

The shared wizard renderer now places keyboard guidance below the current choices
or input, separated by exactly one empty line. Completed and cancelled live
prompts clear their temporary content before retaining results or starting progress.
Text entry uses relative cursor movement instead of cursor save/restore sequences.
The project-location explanation follows the location input. Main-menu section
headings use the same muted style as guidance.

Platforms appear in alphabetical display-name order: .NET MAUI, Blazor, WinForms,
WinUI, WPF. Each project setup lists the empty/blank choice first and
`Include Syncfusion controls` second. Selecting that setup still opens an initially
empty control picker. Single-choice lists and control pickers scroll in short
terminals while retaining the keyboard guidance below the visible choices.

## Verification

- All 1,162 xUnit tests passed; the CLI and all platform modules compiled without
  warnings or errors.
- Terminal-grid regression checks cover prompt clearing, one help block with one
  empty line before it, location-note placement, transition to progress text,
  cancellation, narrow output, and long choice lists in a 12-row terminal.
- Real Linux pseudo-terminal checks traversed interactive setup for MAUI, Blazor,
  WPF, WinForms, and WinUI, verified setup order/labels, and cancelled before
  project creation. A separate main-menu run exercised MAUI platform, template,
  framework, location/name input, cancellation back to the menu, and Ctrl+C.
- A separate invocation with an explicit project name skipped interactive setup
  as designed, created a MAUI project, and reached the expected NETSDK1147 build
  error because MAUI workloads are unavailable on this host.

Native macOS Terminal and Windows console rendering were not available for
verification. Native platform app builds are outside this terminal-rendering
check. The `.agent` harness referenced by AGENTS.md is absent in this checkout.

## Blazor prompt order follow-up

Blazor Web App and WebAssembly Standalone omit the fixed C# language row from
both the wizard and final review. The order for Syncfusion setup is now setup,
components, then theme. Empty projects skip component/theme selection. Existing
explicit C# command-line validation remains compatible.

All 1,162 tests passed after this change. Real Linux PTY traversals for both
Blazor application types confirmed that the control picker starts empty, no
language/theme row appears before control selection, and the theme picker opens
after selecting a component. Both traversals cancelled cleanly at the theme step.

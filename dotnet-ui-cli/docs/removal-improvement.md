# Package removal temporarily disabled

The interactive “Remove a package from an existing project” option and every
`sfdotnet remove` command form are disabled for MAUI, Blazor, WPF, WinForms and WinUI.
Primary syntax, legacy target-first syntax, `--framework`, `--control`, and the
hidden `--template` alias cannot reach a removal handler.

The implementation is preserved as single-line comments under `// Improvement:`
tags in MenuItems, InteractiveMenu, CliApp registration and RemoveCommand's
execution handler. The retained command factory also has an explicit failure
handler so directly constructing it cannot execute the commented operation.
Pure parsing helpers and lower-level lifecycle/rollback services remain available
and tested; the public removal entry points are disabled. Active general/platform
help no longer advertises removal. Historical examples in the command reference
and flow review carry a temporary-unavailability notice.

To restore removal after improvements, restore the commented enum/menu entry,
menu dispatcher/method, root registration and execution handler; remove the
factory's temporary rejection handler and restore the help examples. Update the
availability/regression tests and docs together.

## Verification

- Full suite: **1,212 tests passed**, zero failed/skipped.
- CLI build: zero warnings/errors.
- Regression checks reject 30 platform/removal forms without changing existing
  project/sample files, plus verify five directly constructed command factories
  cannot execute removal and all five platform help maps omit it.
- A real CLI smoke check rejected 25 primary/legacy/flag forms across all five
  platforms without changing project bytes. General/platform help, version,
  info, Blazor package listing and search passed.
- A real Linux terminal menu omitted removal while retaining every other entry.

Native Windows/macOS processes were not run here. This change concerns shared
CLI registration/dispatch and does not change native application templates.

## MAUI Hybrid creation temporarily disabled

MAUI creation now offers only .NET MAUI App. The interactive wizard records this
sole template automatically and continues to framework selection. Explicit
`--project-type blazor-hybrid` requests fail before generation, regardless of case.
The choice and former parser/mapping branches are preserved with single-line
`// Improvement:` comments. Existing Hybrid project support in lower-level
services remains available.

To restore Hybrid creation, restore the commented choice, mapping and parser
branch, remove the temporary rejection, and update option help, docs and tests.

Verification includes three case variants rejected before generation, default
and explicit App dry-runs, and a real terminal wizard check confirming automatic
App selection with no template picker. The full suite above covers both changes.

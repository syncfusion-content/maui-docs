# WPF and WinForms control template validation

The supplied templates are now catalogued and embedded for new/add/remove/update.

- WPF: Chart, DataGrid, Diagram, DockingManager, Kanban, NavigationDrawer, Ribbon, Scheduler, TreeGrid.
- WinForms: Chart, DataGrid, Diagram, DockingManager, NavigationDrawer.
- Both platforms have C# and VB sources, isolated resources and project item metadata.

Repairs include invalid/missing XAML namespace declarations, Page resource/data-context
blocks, stale project namespaces, missing notification/command/model helpers, default
page constructors, native type/namespace collisions, missing icon/image resources,
resource URI/output paths, designer serialization annotations and VB conversion issues.
Ribbon open/save commands now load/save valid RTF, and sample theme inheritance is
preserved. NavigationDrawer has populated sample data.

The providers replace inline placeholder samples with the supplied template pages.
The lifecycle maintains ownership hashes, sample registrations, project resource/compile
items, shared dependencies and welcome navigation. Edited generated files, user-owned
source collisions and unsafe managed paths are protected. Updates preserve sample source
and align managed Syncfusion release references. Earlier untouched sf hosts migrate when
controls change. Ordinary projects without an sf manifest retain package-only behavior.

## Checks completed

- CLI build and 461 focused desktop/lifecycle, MAUI welcome and Blazor tests passed.
- All nine WPF and all five WinForms samples compiled together in C# and VB.
- Four real CLI workflows started empty, added every control, compiled, updated from
  35.1.39 to 35.1.40 without modifying source/assets, compiled again, removed every
  control and compiled the empty welcome state. All 12 stage builds used warnings as errors.
- A fifth real WPF workflow repeated the full lifecycle with inherited central package
  management. All three stage builds passed. This uncovered and fixed inline Version
  metadata produced by dotnet add --no-restore in centrally managed projects.
- Automated tests cover shared dependencies, repeat-add idempotence, dry-run, unowned
  file collisions, edited-file protection, earlier-host migration, central normalization,
  coordinated version updates and restore-failure rollback.
- Source formatting and git diff --check passed.
- Windows validation script now includes every individual catalog control and the
  all-controls combination in addition to empty and Chart/DataGrid combinations.

## Checks requiring Windows

This Linux environment cross-compiles .NET 10 using real Windows/Syncfusion references;
it cannot launch desktop applications. Native interaction, layout, resource rendering,
accessibility and legacy .NET Framework builds still require the expanded Windows matrix.
Previous Windows results for Chart/DataGrid do not validate these new templates.
The AGENTS.md-referenced .agent harness/protocol directory is absent, so its commands
could not be run. The temporary VB conversion tool is not part of the CLI/runtime.

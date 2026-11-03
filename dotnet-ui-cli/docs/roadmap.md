# Roadmap

This roadmap reflects the current implementation, not the original delivery
phases.

## Implemented

- .NET MAUI project creation, package management, and control-template
  installation, removal, and update.
- Direct commands and an interactive wizard backed by the same operation
  services.
- Package and template discovery, `--json` output, cancellation, manifest
  tracking, and rollback support.
- Catalog validation and a read-only catalog audit utility.
- Blazor Web App and standalone WebAssembly generation, Syncfusion component
  demos and themes, and existing-project package operations.

## Current constraints

- WPF, WinForms and WinUI providers are implemented. Windows validation must
  pass before declaring those providers release-ready; see desktop-platforms.md.
- MAUI Blazor Hybrid remains a MAUI project type distinct from the Blazor
  platform. Desktop and Blazor package-only operations do not generate control templates.
- `ControlInstaller` coordinates several template and package responsibilities
  and remains a candidate for a separately tested extraction.

## Next

1. Split `ControlInstaller` along observable workflow responsibilities and
   cover each extraction with focused tests before changing behavior.
2. Validate desktop applications on Windows, including native control behavior
   and visual themes. Retain the generated-application CI matrix.
3. Add other platforms only with complete providers, commands and validation.

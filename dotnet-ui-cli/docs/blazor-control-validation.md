# Blazor control templates — validation

Validated on Linux with .NET SDK 10.0.100 and Syncfusion 35.1.40.

## Generation and compilation

- Fresh CLI projects containing all 12 explicitly selected controls compiled in
  Web App Server, Web App Auto (host and Client), and standalone WebAssembly
  configurations, with warnings treated as errors: zero warnings and errors.
- A final all-control Server project additionally verified the bundled PDF and
  duplicate/case-insensitive control selection normalization.
- Creation without `--control` produced no demo pages and no Syncfusion package
  references. The interactive picker starts empty and requires a user selection
  before continuing; its keyboard behavior is covered by a regression test.
- 142 focused xUnit tests passed. Razor pages, partial classes, namespaces, render directives, specialized script
  selection, and welcome behavior are covered by automated tests.

## Chromium runtime checks

All 12 routes returned HTTP 200 and rendered their expected Syncfusion control.
No page errors or Blazor error panel appeared after initialization in the final
checks. Document Editor and Spreadsheet were rechecked after adding their
specialized JavaScript bundles. PDF Viewer was rechecked after registering
memory cache and replacing the remote document with bundled PDF data: one page
rendered without a CORS error.

Checks used real generated Server projects and an unlicensed trial installation.
The vendor's trial dialog/banner appeared; XlsIO also added an evaluation sheet
to the budget workbook. A valid license is required to validate licensed output.

## Limits

Full editing/export/upload/download workflows, production File Manager services,
Auto/WebAssembly browser execution, other browsers, Windows/macOS, older SDKs,
and licensed output were not verified. File Manager still uses the documented
public demonstration service. The `.agent` harness referenced by `AGENTS.md` is
absent from this checkout; normal CLI builds and xUnit checks were used instead.

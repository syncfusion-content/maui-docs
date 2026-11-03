# Blazor support

The Blazor provider uses the official Microsoft `blazor` and `blazorwasm`
templates installed with the selected .NET SDK. It does not carry a copy of
those templates.

## Prerequisites

- A .NET SDK containing the ASP.NET Core Blazor templates.
- Network access to configured NuGet sources when restore or build is selected.
- A valid Syncfusion license registration for production applications.

The CLI reads each template's help output and offers only target frameworks the
installed template reports. .NET 10 is the default when available. .NET 11 is
shown only when the installed template advertises it; compatible `net8.0`
Syncfusion assets can then be selected by NuGet under normal framework
compatibility rules.

## Application and rendering options

Blazor Web App supports Server, WebAssembly, and Auto interactive render modes,
with per-page/component or global interactivity. For WebAssembly and Auto, the
CLI places interactive demo pages, package references, imports, and service
registration in the generated `.Client` project. Standalone WebAssembly fixes
the render mode to WebAssembly and does not prompt for an interactivity location.

The official Blazor Web App Individual Accounts template is supported and
requires HTTPS. Standalone WebAssembly Individual authentication requires an
external identity-provider authority and client ID, so the CLI rejects that
combination instead of generating placeholder credentials.

## Themes and components

Supported Syncfusion component themes are Fluent 2 (`fluent2.css`), Bootstrap
5.3 (`bootstrap5.3.css`), Material 3 (`material3.css`), Tailwind 3
(`tailwind3.css`), and Bootstrap 5 (`bootstrap5.css`). These styles theme
Syncfusion controls; they do not replace the CSS framework used by Microsoft's
application shell.

The control picker starts with **no controls selected**. Use Space to select
controls and Enter to continue after choosing at least one. Noninteractive
creation without `--control` generates an empty welcome project. Repeat
`--control` to select multiple controls, for example:

```sh
sfdotnet new blazor --name MyApp --control grid --control charts --post-action generate --no-interactive
```

The actual CLI templates live in
`src/Syncfusion.DotNet.Cli.Blazor/Templates/Controls/{Web,Wasm,Shared}/<alias>/`. Each control has
a formatted Razor page and, where sample data or logic is needed, a matching
`.razor.cs` partial class. Generation writes only selected templates and resolves
their namespaces and render directives for Server, Auto, WebAssembly, and
standalone WebAssembly projects. PDF Viewer registers the memory-cache service;
PDF Viewer, Document Editor, and Spreadsheet receive their specialized scripts
only when selected. Spreadsheet creates a local budget workbook through XlsIO.
Document Editor starts with a blank editable document.

Component aliases are `ai-assistview`, `block-editor`, `pivot-table`, `grid`, `charts`, `scheduler`, `gantt`, `diagram`,
`rich-text-editor`, `file-manager`, `pdf-viewer`, `document-editor`,
`spreadsheet`, `kanban`, and `query-builder`. The generated File Manager demo
uses Syncfusion's public physical-file demonstration service. Replace those
URLs with an application-owned, authenticated backend before production use.
The PDF Viewer demo includes a small PDF as a data URI, avoiding a remote
download and cross-origin restrictions. Other demos use local sample data or
start with an editable blank document.

`--post-action generate` runs the official template and writes project files
without silently restoring or building. `--post-action build` restores and
builds. Creation is transactional until generation completes; failures roll
back the newly created directory. Existing-project package operations preserve
central package management and roll back failed changes.

## Wizard order

Platform, Application type, Language (C#), Target framework, Interactive render
mode and Interactivity (Web App only), Authentication, HTTPS (fixed to Yes when
Individual accounts is chosen), Project location, Project name, Setup (demo
pages by default), Theme and Components (demo pages only), Post-create, and
Confirmation. Demo pages are generated as `<Component>Demo.razor` so they never
collide with component type names. For WebAssembly and Auto the host project
also receives `AddSyncfusionBlazor()` and the Syncfusion import so prerendering
works.

The Web and Wasm folders contain the supplied feature samples, normalized to the
CLI route aliases and `*Demo.razor` / `*Demo.razor.cs` naming. Shared holds the
five controls without new replacements. Web App generation selects Web resources
for all render modes; standalone WebAssembly selects Wasm resources. Shared
resources provide only controls absent from those app-specific folders.

Diagram also references Inputs and Rich Text Editor references DropDowns, so each
feature sample builds independently. See the [integration and option evidence](blazor-template-integration-validation.md).

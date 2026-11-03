# Post-creation command verification

All five supported platforms show copyable `cd`, build and run commands after
successful generate-only creation. When creation includes a successful build,
the separate build command is omitted. JSON results carry the same commands in
`nextCommands`; unrelated desktop/package result payloads omit the optional field.
Dry runs and rolled-back creations have no runnable completion instructions.

| Platform / project | Build step when needed | Run step |
|---|---|---|
| MAUI | `dotnet build <project> -f <target>` | `dotnet build <project> -t:Run -f <target>` |
| WPF / WinForms, modern .NET | `dotnet build <project>` | `dotnet run --project <project> --no-build` |
| WPF / WinForms, .NET Framework | Visual Studio `msbuild <project> /restore /t:Build /p:Configuration=Debug` | PowerShell launches `bin\Debug\<name>.exe` |
| WinUI | `dotnet build <project>` | `dotnet run --project <project> --no-build` |
| Blazor | `dotnet build <host-or-standalone-project>` | `dotnet run --project <host-or-standalone-project> --no-build` |

MAUI selects the declared native host target and preserves explicit build-target
selection and Windows platform versions. iOS commands select a simulator runtime
on macOS. Hosted Blazor WebAssembly/Auto commands select the server rather than
its `.Client` project. Windows desktop commands are labeled PowerShell; legacy
builds explain the Developer PowerShell prerequisite. Paths containing spaces,
apostrophes, dollar signs and backticks are quoted as literals.

## Results

- CLI compilation passed with zero warnings/errors.
- Full regression suite: **1,295 passed, one failed, zero skipped**. The unchanged
  baseline failure remains the MAUI Diagram custom-color check. No MAUI control
  template changes are included.
- Fresh generate-only projects were created through the CLI for MAUI, WPF,
  WinForms (VB), WinUI and all four Blazor application/render-mode variants.
  Their JSON results contained three commands and named existing project files.
- Real text output checks passed for MAUI, WinUI and Blazor generate-only
  projects (three commands), plus a built Blazor project (two commands).
- A Blazor Server project was created with build enabled. Its displayed `cd`
  command correctly handled a parent path containing spaces, an apostrophe and
  a dollar sign, and its displayed `run --no-build` command served HTTP 200.
- The displayed build/run commands for generated hosted WebAssembly, Auto and
  standalone WebAssembly projects also built successfully and served HTTP 200.
  All temporary server processes were stopped after validation.
- Dry-run checks across desktop/Blazor omitted completion commands. MAUI keeps
  an empty array for dry-run JSON compatibility.
- Unit checks cover MAUI host selection, explicit/declared targets, iOS simulator
  selection, modern/legacy desktop projects, C#/VB extensions, all four Blazor
  modes, both build outcomes, shell quoting and optional JSON serialization.
  Existing MAUI build-failure recovery tests remain active and passed.

Windows desktop, .NET Framework and MAUI native application launches were not
performed on this Linux host. The Windows/macOS/Linux terminal CI matrix includes
the new command-generation tests; native runtime success is not claimed from
those tests.

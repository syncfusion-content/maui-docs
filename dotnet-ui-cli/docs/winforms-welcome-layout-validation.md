# WinForms welcome layout aligned with MAUI

The actual C# and VB CLI welcome templates now follow the MAUI page's hierarchy:
centered bounded content, bold welcome heading and introduction, an enclosed
samples section, four rounded resource cards, and a responsive copyright/link
footer. Resource cards have small native text glyphs, equal measured row heights,
and consistent title/body/link placement. They reflow to four, two or one column
according to available width. The samples keep their existing tab navigation.

The layout runs on creation, resize, visibility and font changes, rather than
waiting for a resize to set maximum sizes. Text is measured before laying out
cards. The footer explicitly sizes its three link controls and moves them below
the copyright when necessary. Short content leaves the footer at the bottom;
longer content stays reachable through vertical scrolling. Light/dark and high
contrast handling use the existing Windows theme behavior and system colors.
All resource/footer URLs and the exact copyright remain shared with MAUI.
Empty welcome pages show their empty-state guidance without the sample-selection
instruction. LinkLabels retain native focus/hover behavior and default-browser
launching, with accessible names and descriptive browser hints.

## Changed sources

- `src/Syncfusion.DotNet.CLI.WinForms/Templates/Welcome/WelcomeView.cs`
- `src/Syncfusion.DotNet.CLI.WinForms/Templates/Welcome/WelcomeView.vb`
- `src/Syncfusion.DotNet.CLI.WinForms/WinFormsWelcomeTemplate.cs`
- `tests/DesktopPlatformTests.cs`
- `scripts/WinFormsWelcomeValidation/`

## Completed verification

- All **1,170** xUnit tests passed, including empty/populated C#/VB welcome
  generation, selected sample navigation targets, exact footer URLs and no
  unresolved placeholders. [Test log](validation/winforms-welcome/winforms-welcome-tests-final.txt).
- Fresh CLI-generated C# and VB projects with Docking Manager compiled for
  **.NET 8 and .NET 10**, with zero warnings/errors.
  [Results](validation/winforms-welcome/build-results.json) and
  [logs](validation/winforms-welcome).
- Both welcome source files compiled independently against **.NET Framework
  4.6.2**, also without warnings/errors. A full legacy app cross-build could not
  resolve the Windows-only Syncfusion references on Linux; this is not reported
  as a full legacy application pass.
- The Windows layout/screenshot harness cross-compiled successfully.

## Native Windows checks still required

This host runs Linux and has no Windows desktop runtime. Native layout,
light/dark/high-contrast rendering, DPI scaling, hover/focus, browser launching
and screenshot comparison with MAUI have **not** been run here. Cross-compilation
and generator tests do not substitute for these checks.

On Windows, build a freshly generated C# or VB .NET 10 project, then run:

```powershell
dotnet run --project scripts/WinFormsWelcomeValidation -- `
  C:\Projects\WelcomeApp\bin\Debug\net10.0-windows\WelcomeApp.dll `
  WelcomeApp.Welcome.WelcomeView `
  C:\Temp\welcome-validation
```

Adjust the DLL/type names to match the generated project. The harness instantiates
the real generated UserControl, checks four equal-height resource cards, all
three accessible footer links without clipping, absence of horizontal scrolling,
and sample button navigation. It captures page/footer PNGs at widths 1440, 1024,
760 and 360. Run under the desired Windows light/dark/high-contrast and display DPI
settings; the harness does not change OS preferences or open external links.
It is intended for a .NET 10 generated assembly. The previously observed GitHub
runner billing restriction may need to be resolved before Windows CI can run.

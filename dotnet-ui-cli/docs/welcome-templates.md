# Generated welcome pages

The CLI installs a welcome page in newly generated MAUI, WPF, WinUI, WinForms,
and Blazor projects. Each platform embeds physical sources under `Templates/Welcome`.
WPF and WinUI generate `Welcome/WelcomeView.xaml` plus `.xaml.cs` (or `.xaml.vb`
for WPF VB). WinForms generates a separate `Welcome/WelcomeView.cs` or `.vb`
user control. Blazor generates `Welcome/WelcomeView.razor` and scoped `.razor.css`;
the home route hosts that component. Main windows/forms contain only hosting and
sample-navigation integration.

Desktop projects put Welcome before their existing sample
tabs. Blazor replaces the SDK home route and keeps the existing sample routes,
application shell, authentication, and selected Syncfusion component theme.

The pages contain the startup confirmation, control sample navigation (or the
empty state), four resource cards, and the Syncfusion copyright/legal footer.
The footer has Privacy Policy, Terms of Service, and Contact Us text links, with
no redundant Syncfusion/Support links. The copyright is left aligned and the
link group is right aligned; narrower layouts put the link group below it and
wrap or stack the links. Footer content stays inside the scrolling content.

Native WPF hyperlinks, WinUI HyperlinkButtons, WinForms LinkLabels, and HTML
anchors supply keyboard navigation and accessibility. Desktop links launch the
system browser; Blazor links open a new tab with `noopener noreferrer` and an
accessible new-tab hint.

WPF follows the selected light/dark theme, using system colors for light pages.
WinUI follows native theme resources. WinForms follows Windows app light/dark
preferences, responds to preference changes, and respects system high contrast.
Blazor uses scoped responsive CSS, `prefers-color-scheme`, focus outlines and
forced-color resources. Existing sample controls retain their configured themes.

## Validation

- CLI build and 447 desktop, Blazor, and MAUI welcome tests passed.
- Fresh CLI projects were generated for every platform, including C#/VB desktop
  variants and empty/demo Blazor Web Apps.
- WPF and WinForms C# and VB projects cross-compiled on Linux against the real
  .NET 10 Windows references and Syncfusion packages.
- Empty and Grid/Charts Blazor Web Apps compiled successfully.
- Chromium checks exercised light/dark themes at 280, 390, 768, and 1280 pixels:
  no horizontal overflow, horizontal desktop footer links, keyboard focus outlines,
  and new-tab link activation. Remote destinations were intercepted during browser
  activation checks; this is not an end-to-end remote-site availability test.
- WinUI code-behind compiled against real Windows App SDK references using
  temporary declarations for XAML-generated fields. Full WinUI compilation is
  blocked on Linux by the Windows XAML compiler (`Exec format error`).

WPF/WinForms/WinUI runtime appearance, resizing, keyboard/screen-reader behavior,
DPI changes, and default-browser launches still require a Windows host. Legacy
.NET Framework desktop variants have source-generation coverage but were not
compiled in this environment. Blazor standalone WebAssembly, WebAssembly/Auto
render modes, and Individual Accounts were not run in a browser.

The current `AGENTS.md` refers to `.agent` protocol files and harness scripts that
are absent from the checkout and remote tree. Those harness-specific checks
could not be run; the build, test, formatting, and browser results above come
from the corresponding tools directly.

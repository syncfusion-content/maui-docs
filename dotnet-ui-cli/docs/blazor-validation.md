# Blazor validation log

Verified on .NET SDK 10.0.401 (only SDK installed; templates report `net10.0` only, so net8/net9/net11 are unverified on this host).
Each row was generated with the real `sf` CLI, restored and built (`--post-action build`).

| Configuration | Result |
|---|---|
| Web App: server/webassembly/auto x per-page/global x auth none | build OK |
| Web App: server x per-page/global x auth Individual | build OK |
| Web App: webassembly/auto x per-page/global x Individual | fixed (was "Sequence contains more than one element"); build OK |
| WebAssembly Standalone, charts+kanban, and empty | build OK |
| Themes fluent2, bootstrap5.3, material3, tailwind3, bootstrap5 | build OK; all five CSS files exist in Syncfusion.Blazor.Themes |
| 12 components, auto render mode | build OK |
| `--https no` with Individual; standalone Individual; net9.0 on net10-only SDK | rejected with actionable message |
| Auto/global app launched | `/grid` returns 200, renders `e-grid`, theme CSS and script served |

Not verified: other SDKs, browser console errors, interactive behaviour of each component, wizard prompt flow on a real terminal, Windows.
Known gaps: the wizard does not yet prompt for every step in the requested order; standalone Individual auth is intentionally unsupported (needs an OIDC authority).

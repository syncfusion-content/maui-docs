---
id: cli-change-verification
kind: workflow
version: 1
appliesTo: [all]
invokes: [generated-project-validator, wizard-consistency-reviewer, package-integrity-auditor, code-reviewer]
requires: [pr-review]
binding: [verify-generated-output, preserve-user-files, no-unrelated-change, not-run-is-not-pass, never-weaken]
---

# cli-change-verification — prove a CLI change by its output

Run this inside `feature`, `bugfix`, `refactor` or `api-change` whenever the diff touches `src/**`. It decides which expensive checks the change earns, so every PR gets the cheap ones and only affected platforms get the slow ones.

## 1. CLASSIFY the diff

`git diff --name-only <baseSha>..HEAD`, then map paths to areas:

| Path | Area | Required beyond the inner lane |
|---|---|---|
| `Wizard/`, `Presentation/` | wizard / terminal | `wizard-consistency-reviewer` |
| `Commands/`, `Options/`, `Parsing/` | command surface | `area-command-parsing` count floor; docs/command-reference.md updated |
| `Maui/Catalog/*.json`, `BlazorCatalog.cs`, provider catalogs, `Core/Desktop/DesktopPackage*`, `Core/NuGet/` | packages | `package-integrity-auditor` |
| `Maui/`, `Blazor/`, `WPF/`, `WinForms/`, `WinUI/`, `Core/Desktop/DesktopProject*`, templates | generation | `generated-project-validator`, affected platforms only |
| `Core/` (shared) | all platforms | all of the above for every platform |

## 2. INNER LANE

`RUN python3 .agent/tools/harness.py gate run --lane inner --scope diff`

The six `area-*` gates carry test-count floors, so a filter that quietly selects nothing fails.

## 3. GENERATED OUTPUT — `generated-project-validator`

Run `e2e-single-platform` with `--platforms` limited to the affected set. Cite the JSON report. Anything the host cannot build goes in the report as **unverified on this host**, with the host that must run it:

| Platform | Needs |
|---|---|
| WPF, WinForms, WinUI | Windows (`desktop-validation`, the Windows CI job) |
| MAUI | .NET workloads; Apple targets need macOS with Xcode |
| Blazor | the .NET SDK and the official Blazor template |

## 4. DOMAIN REVIEW

Invoke only the reviewers step 1 selected. Findings go in `## Review` with a `Verify:` line each.

## 5. REGRESSION LEDGER

A bug fixed here adds a row to `scripts/harness/regression-ledger.json` naming its test. The `regression-ledger` gate then fails if that test is ever renamed or removed.

## 6. CLOSE

`checklists/pr-review.md` satisfied, then the definition of done. A feature is not complete on unit tests or CLI compilation alone; step 3's report must be cited.

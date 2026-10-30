---
id: pr-review
kind: checklist
version: 1
appliesTo: [all]
usedBy: [feature, bugfix, refactor, api-change, release]
---

# PR review

Every box needs a citation (evidence path, test name or file). An unchecked box returns the task to EXECUTE.

## Functional change
- [ ] Behaviour matches `## What`; nothing more (`no-unrelated-change`)
- [ ] Applies consistently to MAUI, Blazor, WPF, WinForms and WinUI, or the difference is explained
- [ ] The wizard path and the direct-command path produce the same request

## Compatibility
- [ ] Existing commands, option names, defaults and exit codes unchanged, or the break is documented
- [ ] Older generated projects and existing projects still load and modify correctly
- [ ] Paths with spaces and non-default locations work

## Verification
- [ ] Area gates passed with their test-count floors (not a bare green total)
- [ ] A regression test exists for any bug fixed; its row is in `scripts/harness/regression-ledger.json`
- [ ] **Generated output inspected**, not only unit tests (`verify-generated-output`): e2e report cited
- [ ] Platforms this host cannot build are listed as unverified, with the host that must run them
- [ ] Terminal-affecting change: capability fallbacks (no Unicode, no ANSI, narrow width) covered

## Packages and user files
- [ ] No duplicate references after repeated add; shared dependencies survive a partial remove
- [ ] User-modified files preserved; a failed operation left the project unchanged (`preserve-user-files`)

## Documentation
- [ ] `docs/command-reference.md` and the platform doc updated for any user-visible change
- [ ] `docs/architecture.md` updated if responsibilities moved

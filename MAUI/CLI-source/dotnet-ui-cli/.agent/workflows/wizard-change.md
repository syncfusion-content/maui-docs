---
id: wizard-change
kind: workflow
version: 1
appliesTo: [all]
invokes: [test-engineer, implementer, wizard-consistency-reviewer, code-reviewer]
requires: [pr-review, definition-of-done]
binding: [reproduce-before-fix, tests-from-spec, never-weaken, no-unrelated-change, verify-generated-output]
---

# wizard-change — interactive flow, prompts and terminal rendering

For any change to what a user sees or presses. Bugs here were found by eye, so each one gets a test that sees the same thing.

## 1. REPRODUCE — `test-engineer`

Write a test that captures the exact rendered output or key sequence, using the existing harness (`ConsoleCapture`, the fake key queue in `FlowPresentationTests`, `AnsiConsole.Create` with explicit `Ansi`, `Interactive` and width). Run it and watch it fail for the reported reason. Test each of: ANSI on and off, Unicode on and off, narrow width, and Ctrl+C.

## 2. IMPLEMENT — `implementer`

Smallest change that makes it pass. Terminal behaviour keys off capability (`SymbolsFollowCapabilitiesRatherThanPlatform`), never the OS name.

## 3. COMPARE PLATFORMS — `wizard-consistency-reviewer`

All five platforms follow the same order and wording, or each difference is justified.

## 4. REAL OUTPUT

Where the change reaches generated files, run the `cli-change-verification` generated-output step. Live terminal behaviour on Windows conhost or macOS Terminal cannot be reproduced on a Linux host. Record it as unverified, never as assumed fine.

## 5. LEDGER AND CLOSE

Add the test to `regression-ledger.json`, then `pr-review` and the definition of done.

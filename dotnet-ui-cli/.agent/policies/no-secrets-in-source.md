---
id: no-secrets-in-source
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [secrets gate, security-auditor, code-reviewer]
---

# no-secrets-in-source — never commit, log, or echo a credential

## Rule

No credential, token, API key, licence key, connection string, or certificate private key appears in source, configuration, tests, fixtures, task files, logs, or commit messages. Secrets are read from a secret store or the environment.

## Why

A committed secret is in history forever, and rewriting history across a team is expensive and usually incomplete. In client-shipped code the exposure is total — every visitor receives it.

This extends to agent output: never paste a real value into a task file or a `## Log` entry to 'record what was found'.

## Enforced by

The `secrets` gate (Gitleaks) runs inner-lane and blocks. Stack overlays add product-specific checks — the Syncfusion overlay checks for licence keys in source and in WebAssembly projects.

## Violation

Rotate the exposed credential first, then remove it from the code, then purge history if it was pushed. Removal without rotation is not remediation.

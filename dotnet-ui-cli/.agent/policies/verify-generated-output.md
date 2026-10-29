---
id: verify-generated-output
kind: policy
version: 1
appliesTo: [all]
severity: blocking
enforcedBy: [e2e-workflows, generated-project-validator, code-reviewer]
---

# verify-generated-output — unit tests and a compiling CLI are not proof

## Rule

A change that affects what `sf` writes, or how it modifies an existing project, is not complete until the actual output has been generated and inspected. Passing unit tests and a successful `dotnet build` of the CLI do not satisfy this.

## Why

The CLI's product is files in someone else's project. A unit suite can pass while a generated `.csproj` has the wrong framework, a duplicate package or a missing registration, because those tests exercise the CLI's internals, not its output.

## Enforced by

`e2e-workflows` (outer lane) drives the built CLI and asserts on generated files. `generated-project-validator` reads the report. A platform the host cannot build is recorded as unverified on that host, never as passed.

## Violation

Run `e2e-single-platform` for each affected platform, inspect the files, and cite the report. If the host cannot build the platform, say so and name the host that must.

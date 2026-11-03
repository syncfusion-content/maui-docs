# Decisions required

Parking lot for questions only a human can answer. The agent parks here and takes the next task instead of blocking. A park without a recommendation is incomplete. Shape: `.agent/templates/decision-required.md`.

## Open

### DECISION 1: Which CI system hosts the PR and platform-matrix jobs?

**Category**: scope   **Status**: open

**Question**: The repo has a `Jenkinsfile` (Windows agent, Cake build) and `docs/architecture.md` refers to `.github/workflows/desktop-validation.yml`, but `.github/` does not exist. The origin is a Gitea server. Which system should run the PR lane and the Windows/macOS/Linux matrix?

**Context**: The request was to use the existing CI and to prefer GitHub Actions only if none is configured. One is configured (Jenkins), but it builds and publishes through `build/build.cake` and runs no tests. The harness commands are CI-neutral (`python3 .agent/tools/harness.py gate run --lane inner|outer`), so they run unchanged under either system.

| # | Option | Cost | Risk |
|---|---|---|---|
| 1 | Add test and harness stages to the Jenkinsfile | low | Jenkins has a Windows node only; macOS needs a new agent |
| 2 | Add `.github/workflows/` | low | requires GitHub-compatible runners on the Gitea server |

**Recommendation**: option 1 for the inner lane and Windows jobs, since the infrastructure exists. Add a macOS agent label for the Apple/MAUI job. Until decided, no CI file was written.

## Answered

(none)

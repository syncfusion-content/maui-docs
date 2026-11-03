---
id: incident
kind: template
version: 1
---
# INCIDENT {{NUMBER}}: {{TITLE}}

**Severity**: sev1 | sev2 | sev3   **Status**: active | contained | resolved
**Detected**: {{TIME}}   **Contained**: {{TIME}}   **Resolved**: {{TIME}}

## Impact

**Who was affected**:   **How many**:   **For how long**:
**Data at risk**: yes / no — <detail>

## Timeline

<!-- Facts with timestamps. Speculation goes in its own section, labelled. -->

| Time | Event | Source |
|---|---|---|

## What changed immediately before

<!-- Deploy, config, dependency, data, traffic. -->

## Containment

**Action taken**:   **At**:   **By** (named human):
**Rollback performed**: yes / no — approved by:

## Evidence preserved

<!-- Captured BEFORE any restart. A restart usually destroys the state
     that explains the failure. -->

## Credentials

**Exposed**: yes / no
**Rotated**: yes / no — at:
<!-- Never record the exposed value itself. -->

## Root cause

<!-- The causal chain, not the symptom. -->

## Why no gate caught this

<!-- THE MOST VALUABLE SECTION. Every incident is a gap in the harness. -->

**Gap**:
**Harness change required**:
**Task filed**: <id>   ← must exist before this incident closes

## Permanent fix

**Task**: <id>   **Test that reproduces**: <name>

## Speculation

<!-- Anything not established as fact, clearly separated from the timeline. -->

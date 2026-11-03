---
id: review-findings
kind: template
version: 1
---
## Review — {{TASK_ID}}

**Gate evidence**: <verdict> — <n>/<m> passed; **not run**: <list>
**Diff**: <n> files, +<a>/−<b>
**Catalog**: {{CATALOG_PATH}}
**Sections worked**:
**Sections skipped, and why**:

### Configuration changes in this diff

<!-- Checked FIRST. A disabled rule, lowered threshold, new suppression,
     deleted or skipped test, or newly swallowing catch is a finding
     regardless of the rest of the change. -->

- [ ] None found

### Findings ({{N}})

<!-- Most severe first. All six lines required. -->

```
[<catalog-id>] <summary>
  File:   <path>:<line>
  Rule:   <rule id + ENABLED/NOT ENABLED>, or "manual (no tool covers this)"
  Why:    <inputs or state -> wrong behaviour>
  Fix:    <the specific change>
  Config: <rule to enable that prevents the class>
  Verify: <gate that confirms it, or "UNVERIFIED - no gate covers this">
```

### Recommended new gates

<!-- Judgement calls that could become facts. The review surface should
     shrink over time as these are adopted. -->

### Not checked

<!-- Honest gaps. More useful than false completeness. -->

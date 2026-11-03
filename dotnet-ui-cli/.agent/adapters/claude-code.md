# Host Adapter — Claude Code

| Capability | Binding |
|---|---|
| `DELEGATE` | `Agent` tool with `subagent_type: "general-purpose"` |
| `READ_FILE` | `Read` |
| `RUN` | `Bash` |
| `PARALLEL` | multiple `Agent` calls in a single message |

## DELEGATE

```
Agent(
  description: "Build T-XXX",
  prompt: "<BUILD prompt assembled per .agent/instructions.md section 4>",
  subagent_type: "general-purpose"
)
```

## Notes

- `PARALLEL` is available, so independent tasks can build concurrently. Keep
  within `maxActive` in `harness.yaml` — concurrent builds on a shared working
  tree conflict. For genuine parallelism use `isolation: "worktree"` so each
  agent gets its own checkout.
- Claude Code ships a generic `/code-review` skill. It is complementary, not a
  substitute: it does not know this project's defect catalog, its architecture
  map, or its gate evidence. Use `.agent/agents/reviewer.md` for REVIEW.
- Claude Code auto-loads `CLAUDE.md`, which points here. You still need to read
  `.agent/instructions.md` — the pointer deliberately contains no protocol.

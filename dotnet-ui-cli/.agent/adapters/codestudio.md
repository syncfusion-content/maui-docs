# Host Adapter — Code Studio

| Capability | Binding |
|---|---|
| `DELEGATE` | `runSubagent(prompt, description)` |
| `READ_FILE` | `read_file` |
| `RUN` | the shell tool |
| `PARALLEL` | not available — delegate sequentially |

## DELEGATE

```
runSubagent(
  prompt: "<BUILD prompt assembled per .agent/instructions.md section 4>",
  description: "Build T-XXX: <title>"
)
```

Returns the sub-agent's final text. The BUILD prompt instructs it to end with
`DONE: <summary>` or `BLOCKED: <reason>`; branch on that.

## Notes

- No `PARALLEL`, so `maxVerifying` only helps with *async* outer gates (the loop
  moves on while a cloud job runs). Synchronous outer gates still serialise.
- The reviewer at `.agent/agents/reviewer.md` is delegated the same way: pass its
  content as the prompt preamble.

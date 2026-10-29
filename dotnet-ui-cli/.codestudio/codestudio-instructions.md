# Syncfusion .NET CLI — Agent Protocol

This project uses a vendor-neutral agent harness. **The protocol is not in this
file.** It lives at `.agent/instructions.md` so every agent tool in the
organisation follows identical rules against identical gates.

## Do this now, before anything else

1. `read_file .agent/instructions.md` — the operating protocol
2. `read_file .agent/adapters/codestudio.md` — capability bindings for this host
3. `read_file .agent/project-context.md` — stack, architecture, conventions, boundaries
4. `python3 .agent/tools/task.py status`
5. `python3 .agent/tools/harness.py doctor` — first session, and after every pull

## The rule you most need to know

You may narrate, but you may not assert. Any claim a tool can measure is decided
by that tool. `task.py done` refuses to complete a task without passing gate
evidence, and that refusal is the harness working correctly — not an obstacle to
route around.

Tier L1 · profile dotnet-common · contract v1.0

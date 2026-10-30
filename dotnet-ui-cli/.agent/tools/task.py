#!/usr/bin/env python3
"""Task state manager for the agent harness.

Owns all task state in .agent/tasks/index.json so agents never edit JSON directly.
Agents write task *content* into .agent/tasks/<ID>.md; this script owns *status*.

State machine:

    backlog --> todo --> active --> verifying --> review --> done --> (archived)
                          |  ^         |            |
                          |  |         v            v
                          |  +----- blocked <-------+
                          v
                       blocked

  active     : a build agent is working on it. At most `maxActive` (default 1).
  verifying  : outer-lane gates submitted (slow/cloud). Does NOT block new picks.
  review     : gates passed; awaiting review sign-off. Blocks new picks by default.
  blocked    : needs external action. Not eligible.
  done       : gate evidence present and passing, review approved.

Invariants enforced here (not left to agent discipline):
  * at most `maxActive` active tasks
  * dependencies resolved against a durable done-ledger that survives archiving
  * task ids are monotonic and never reused
  * `done` requires fresh, passing gate evidence unless explicitly overridden
  * every state change is journalled to .agent/tasks/journal.jsonl
"""

import argparse
import json
import os
import shutil
import subprocess
import sys
from datetime import datetime, timezone

AGENT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
TASKS_DIR = os.path.join(AGENT_DIR, "tasks")
INDEX_FILE = os.path.join(TASKS_DIR, "index.json")
JOURNAL_FILE = os.path.join(TASKS_DIR, "journal.jsonl")
ARCHIVE_DIR = os.path.join(AGENT_DIR, "archive")
EVIDENCE_DIR = os.path.join(AGENT_DIR, "evidence")
CONFIG_FILE = os.path.join(AGENT_DIR, "harness.yaml")
REPO_ROOT = os.path.dirname(AGENT_DIR)

SCHEMA = 2
TERMINAL = ("done",)
ELIGIBLE_SOURCE = ("todo",)
BLOCKS_PICK = ("active", "review")

STATUS_ICON = {
    "done": "[x]", "active": "[>]", "verifying": "[~]", "review": "[?]",
    "todo": "[ ]", "blocked": "[!]", "backlog": "[.]",
}


# -- utilities ---------------------------------------------------------------

def now():
    return datetime.now(timezone.utc).isoformat(timespec="seconds")


def die(msg, code=1):
    print(f"ERROR: {msg}", file=sys.stderr)
    sys.exit(code)


def git(*args, check=False):
    """Run a git command in the repo root. Returns stdout or '' on failure."""
    try:
        r = subprocess.run(["git", "-C", REPO_ROOT, *args],
                           capture_output=True, text=True, timeout=30)
        if r.returncode != 0:
            if check:
                die(f"git {' '.join(args)} failed: {r.stderr.strip()}")
            return ""
        return r.stdout.strip()
    except (OSError, subprocess.SubprocessError):
        if check:
            die("git is not available")
        return ""


def head_sha():
    return git("rev-parse", "HEAD")


def read_config():
    """Minimal reader for the few scalar/list keys task.py needs from harness.yaml.

    Deliberately not a full YAML parser: the harness contract keeps these keys
    flat and unquoted so both this and harness.py can read them without a
    third-party dependency. harness.py validate checks the full schema.
    """
    cfg = {
        "maxActive": 1,
        "maxVerifying": 3,
        "reviewBlocksPick": True,
        "requireEvidenceForDone": True,
        "requiresHumanApproval": [],
        "verifyRetryLimit": 3,
    }
    if not os.path.exists(CONFIG_FILE):
        return cfg
    section = None
    with open(CONFIG_FILE, "r", encoding="utf-8") as f:
        for raw in f:
            line = raw.rstrip("\n")
            if not line.strip() or line.lstrip().startswith("#"):
                continue
            indent = len(line) - len(line.lstrip())
            stripped = line.strip()
            if indent == 0 and stripped.endswith(":"):
                section = stripped[:-1]
                continue
            if section == "loop" and ":" in stripped and not stripped.startswith("-"):
                k, _, v = stripped.partition(":")
                k, v = k.strip(), v.strip().strip('"\'')
                if k in ("maxActive", "maxVerifying", "verifyRetryLimit"):
                    try:
                        cfg[k] = int(v)
                    except ValueError:
                        pass
                elif k in ("reviewBlocksPick", "requireEvidenceForDone"):
                    cfg[k] = v.lower() == "true"
            if section == "risk" and stripped.startswith("- "):
                cfg["requiresHumanApproval"].append(stripped[2:].strip().strip('"\''))
    return cfg


# -- index i/o ---------------------------------------------------------------

def load_index():
    """Load the index, migrating the legacy bare-array format in memory."""
    if not os.path.exists(INDEX_FILE):
        return {"schema": SCHEMA, "nextId": 1, "doneLedger": [], "tasks": []}
    with open(INDEX_FILE, "r", encoding="utf-8") as f:
        try:
            data = json.load(f)
        except json.JSONDecodeError as e:
            bak = INDEX_FILE + ".bak"
            hint = f" A backup exists at {bak}." if os.path.exists(bak) else ""
            die(f"index.json is corrupt ({e}).{hint}")
    if isinstance(data, list):  # legacy v1: bare array of tasks
        max_num = 0
        for t in data:
            try:
                max_num = max(max_num, int(str(t.get("id", "T-0")).split("-")[1]))
            except (IndexError, ValueError):
                pass
        data = {
            "schema": SCHEMA,
            "nextId": max_num + 1,
            "doneLedger": [t["id"] for t in data if t.get("status") == "done"],
            "tasks": data,
        }
    data.setdefault("schema", SCHEMA)
    data.setdefault("nextId", len(data.get("tasks", [])) + 1)
    data.setdefault("doneLedger", [])
    data.setdefault("tasks", [])
    return data


def save_index(idx):
    """Atomic write with a single-generation backup."""
    os.makedirs(TASKS_DIR, exist_ok=True)
    if os.path.exists(INDEX_FILE):
        shutil.copy2(INDEX_FILE, INDEX_FILE + ".bak")
    tmp = INDEX_FILE + ".tmp"
    with open(tmp, "w", encoding="utf-8") as f:
        json.dump(idx, f, indent=2)
        f.write("\n")
        f.flush()
        os.fsync(f.fileno())
    os.replace(tmp, INDEX_FILE)


def journal(event, task_id, **fields):
    os.makedirs(TASKS_DIR, exist_ok=True)
    rec = {"ts": now(), "event": event, "id": task_id, **fields}
    with open(JOURNAL_FILE, "a", encoding="utf-8") as f:
        f.write(json.dumps(rec) + "\n")


# -- queries -----------------------------------------------------------------

def tasks_of(idx, *statuses):
    return [t for t in idx["tasks"] if t.get("status") in statuses]


def by_id(idx, task_id):
    for t in idx["tasks"]:
        if t["id"] == task_id:
            return t
    return None


def resolved_ids(idx):
    """IDs that count as satisfied dependencies.

    Union of currently-done tasks and the durable done-ledger. The ledger is
    what makes `archive` safe: archived tasks leave the index but stay here,
    so a todo task that needs an archived task is still pickable.
    """
    return {t["id"] for t in idx["tasks"] if t.get("status") == "done"} | set(idx["doneLedger"])


def unmet(idx, task):
    done = resolved_ids(idx)
    return [n for n in task.get("needs", []) if n not in done]


def detect_cycle(idx, new_id, needs):
    """Return a cycle path if adding new_id->needs would create one."""
    graph = {t["id"]: list(t.get("needs", [])) for t in idx["tasks"]}
    graph[new_id] = list(needs)
    state, path = {}, []

    def walk(node):
        if state.get(node) == 1:
            return path[path.index(node):] + [node]
        if state.get(node) == 2 or node not in graph:
            return None
        state[node] = 1
        path.append(node)
        for dep in graph[node]:
            found = walk(dep)
            if found:
                return found
        path.pop()
        state[node] = 2
        return None

    return walk(new_id)


def risky_paths(cfg, paths):
    """Match changed paths against requiresHumanApproval globs."""
    import fnmatch
    hits = []
    for p in paths:
        for pat in cfg["requiresHumanApproval"]:
            if fnmatch.fnmatch(p, pat) or fnmatch.fnmatch(os.path.basename(p), pat):
                hits.append((p, pat))
                break
    return hits


def gate_verdict(task_id):
    """Read the gate summary that harness.py writes. Returns (verdict, detail)."""
    summary = os.path.join(EVIDENCE_DIR, task_id, "gate-summary.json")
    if not os.path.exists(summary):
        return None, f"no gate evidence at .agent/evidence/{task_id}/gate-summary.json"
    try:
        with open(summary, "r", encoding="utf-8") as f:
            data = json.load(f)
    except (OSError, json.JSONDecodeError) as e:
        return None, f"gate-summary.json unreadable: {e}"
    sha = head_sha()
    if sha and data.get("commit") and data["commit"] != sha:
        return None, (f"evidence is stale: recorded for {data['commit'][:8]}, "
                      f"HEAD is {sha[:8]}. Re-run: python3 .agent/tools/harness.py gate run")
    return data.get("verdict"), data


# -- commands ----------------------------------------------------------------

def cmd_next(idx, cfg, args):
    active = tasks_of(idx, "active")
    if len(active) >= cfg["maxActive"]:
        for t in active:
            print(f"ACTIVE: {t['id']} - {t['title']}")
            print(f"FILE:   .agent/tasks/{t['id']}.md")
        print(f"\nAt maxActive ({cfg['maxActive']}). Finish, block, or verify before picking.")
        return

    if cfg["reviewBlocksPick"]:
        in_review = tasks_of(idx, "review")
        if in_review:
            for t in in_review:
                print(f"AWAITING REVIEW: {t['id']} - {t['title']}")
            print("\nResolve review (approve/reject) before picking new work.")
            return

    verifying = tasks_of(idx, "verifying")
    if len(verifying) >= cfg["maxVerifying"]:
        print(f"At maxVerifying ({cfg['maxVerifying']}). Poll outer-lane gates first:")
        print("  python3 .agent/tools/harness.py gate poll")
        for t in verifying:
            print(f"  {t['id']} - {t['title']}")
        return

    for t in idx["tasks"]:
        if t.get("status") not in ELIGIBLE_SOURCE or unmet(idx, t):
            continue
        t["status"] = "active"
        t["startedAt"] = now()
        sha = head_sha()
        if sha:
            t["baseSha"] = sha  # rollback anchor
        save_index(idx)
        journal("pick", t["id"], baseSha=t.get("baseSha"))

        path = os.path.join(TASKS_DIR, f"{t['id']}.md")
        created = not os.path.exists(path)
        if created:
            os.makedirs(TASKS_DIR, exist_ok=True)
            with open(path, "w", encoding="utf-8") as f:
                f.write(TASK_STUB.format(id=t["id"], title=t["title"], ts=now()))
        print(f"PICKED: {t['id']} - {t['title']}")
        print(f"FILE:   .agent/tasks/{t['id']}.md{' (created)' if created else ''}")
        if t.get("baseSha"):
            print(f"BASE:   {t['baseSha'][:8]}  (rollback: task.py rollback {t['id']})")
        if t.get("needs"):
            print(f"NEEDS:  {', '.join(t['needs'])} (all satisfied)")
        return

    _report_nothing_eligible(idx)


def _report_nothing_eligible(idx):
    blocked = tasks_of(idx, "blocked")
    waiting = [t for t in tasks_of(idx, "todo") if unmet(idx, t)]
    verifying = tasks_of(idx, "verifying")
    backlog = tasks_of(idx, "backlog")

    if waiting:
        print(f"NO ELIGIBLE TASKS. {len(waiting)} waiting on dependencies:")
        for t in waiting:
            u = unmet(idx, t)
            dead = [n for n in u if (by_id(idx, n) or {}).get("status") == "blocked"]
            note = f"  <-- DEADLOCK: {', '.join(dead)} is blocked" if dead else ""
            missing = [n for n in u if by_id(idx, n) is None and n not in idx["doneLedger"]]
            if missing:
                note += f"  <-- DANGLING: {', '.join(missing)} does not exist"
            print(f"  {t['id']} - needs {', '.join(u)}{note}")
    if verifying:
        print(f"{len(verifying)} in outer-lane verification. Poll with:")
        print("  python3 .agent/tools/harness.py gate poll")
        for t in verifying:
            print(f"  {t['id']} - {t['title']}")
    if blocked:
        print(f"{len(blocked)} blocked:")
        for t in blocked:
            print(f"  {t['id']} - {t['title']} ({t.get('blockReason', 'no reason recorded')})")
    if not (waiting or verifying or blocked):
        if backlog:
            print(f"ALL TODO TASKS DONE. {len(backlog)} in backlog - evaluate against project goals:")
            for t in backlog:
                print(f"  {t['id']} - {t['title']}")
            print("\nPromote with: python3 .agent/tools/task.py promote T-XXX")
        else:
            print("ALL TASKS DONE. Backlog empty.")
            print("Run full-project gates before declaring completion:")
            print("  python3 .agent/tools/harness.py gate run --lane all --scope full")


def cmd_verify_submit(idx, cfg, args):
    """active -> verifying. Used when outer-lane gates are async (cloud/slow)."""
    t = _sole(idx, "active", "active task")
    t["status"] = "verifying"
    t["verifySubmittedAt"] = now()
    if args.job:
        t["verifyJob"] = args.job
    save_index(idx)
    journal("verify-submit", t["id"], job=args.job)
    print(f"VERIFYING: {t['id']} - {t['title']}")
    if args.job:
        print(f"JOB:       {args.job}")
    print("Task will not reach done until gates return. Pick independent work meanwhile.")
    print("Poll with: python3 .agent/tools/harness.py gate poll")


def cmd_review(idx, cfg, args):
    t = tasks_of(idx, "active") or tasks_of(idx, "verifying")
    if not t:
        die("no active or verifying task to submit for review")
    t = t[0]
    verdict, detail = gate_verdict(t["id"])
    if cfg["requireEvidenceForDone"] and verdict != "pass" and not args.override:
        print(f"REFUSED: gates have not passed for {t['id']}.")
        print(f"  {detail if isinstance(detail, str) else detail.get('summary', verdict)}")
        print("\nRun gates first:  python3 .agent/tools/harness.py gate run")
        print("Override (logged): task.py review --override \"reason\"")
        sys.exit(2)
    t["status"] = "review"
    save_index(idx)
    journal("review", t["id"], override=args.override or None)
    print(f"IN REVIEW: {t['id']} - {t['title']}")
    print(f"Write ## Review in .agent/tasks/{t['id']}.md")
    if args.override:
        print(f"WARNING: gate evidence overridden - reason: {args.override}")


def _sole(idx, status, label):
    matches = tasks_of(idx, status)
    if not matches:
        die(f"no {label}")
    if len(matches) > 1:
        die(f"{len(matches)} tasks in {status} ({', '.join(t['id'] for t in matches)}). "
            f"Resolve by id instead of relying on implicit selection.")
    return matches[0]


def _finish(idx, cfg, task, args, from_status):
    verdict, detail = gate_verdict(task["id"])
    if cfg["requireEvidenceForDone"] and verdict != "pass" and not args.override:
        print(f"REFUSED: cannot mark {task['id']} done without passing gate evidence.")
        print(f"  {detail if isinstance(detail, str) else detail.get('summary', verdict)}")
        print("\nThis is the harness working as designed: a task is done when tools say")
        print("so, not when an agent says so. Run:")
        print("  python3 .agent/tools/harness.py gate run")
        print("Override (logged to journal): --override \"reason\"")
        sys.exit(2)

    changed = [p for p in git("diff", "--name-only",
                              f"{task.get('baseSha', 'HEAD')}..HEAD").splitlines() if p]
    hits = risky_paths(cfg, changed)
    if hits and not args.approved_by:
        print(f"HELD FOR HUMAN APPROVAL: {task['id']} touches risk-gated paths.")
        for p, pat in hits:
            print(f"  {p}  (matches risk pattern: {pat})")
        print("\nA human must review these. Then:")
        print(f"  python3 .agent/tools/task.py done --approved-by \"<name>\"")
        sys.exit(3)

    task["status"] = "done"
    task["finishedAt"] = now()
    if args.approved_by:
        task["approvedBy"] = args.approved_by
    if task["id"] not in idx["doneLedger"]:
        idx["doneLedger"].append(task["id"])
    save_index(idx)
    journal("done", task["id"], from_status=from_status, override=args.override or None,
            approvedBy=args.approved_by or None, evidence=verdict)
    print(f"DONE: {task['id']} - {task['title']}")
    if args.override:
        print(f"WARNING: completed without passing gates - reason: {args.override}")
    if args.approved_by:
        print(f"Human approval: {args.approved_by}")


def cmd_done(idx, cfg, args):
    if args.id:
        t = by_id(idx, args.id) or die(f"task {args.id} not found")
    else:
        candidates = tasks_of(idx, "active", "review", "verifying")
        if not candidates:
            die("no active, verifying, or review task. Run 'task.py next' first.")
        if len(candidates) > 1:
            die(f"{len(candidates)} candidate tasks. Pass an explicit id: "
                f"task.py done T-XXX ({', '.join(t['id'] for t in candidates)})")
        t = candidates[0]
    _finish(idx, cfg, t, args, t["status"])


def cmd_approve(idx, cfg, args):
    t = by_id(idx, args.id) if args.id else _sole(idx, "review", "task in review")
    if not t:
        die(f"task {args.id} not found")
    if t["status"] != "review":
        die(f"{t['id']} is {t['status']}, not review")
    _finish(idx, cfg, t, args, "review")


def cmd_reject(idx, cfg, args):
    t = by_id(idx, args.id) if args.id else _sole(idx, "review", "task in review")
    if not t:
        die(f"task {args.id} not found")
    if t["status"] != "review":
        die(f"{t['id']} is {t['status']}, not review")
    t["status"] = "active"
    t["reviewRejections"] = t.get("reviewRejections", 0) + 1
    save_index(idx)
    journal("reject", t["id"], reason=args.reason, round=t["reviewRejections"])
    print(f"REWORK: {t['id']} - {t['title']} (rejection #{t['reviewRejections']})")
    print(f"Findings must be in ## Review of .agent/tasks/{t['id']}.md")
    print("Fix them, re-run gates, then: task.py review")


def cmd_block(idx, cfg, args):
    t = by_id(idx, args.id) if args.id else (tasks_of(idx, "active", "verifying") or [None])[0]
    if not t:
        die("no active or verifying task to block")
    t["status"] = "blocked"
    t["blockReason"] = args.reason
    t["blockedAt"] = now()
    save_index(idx)
    journal("block", t["id"], reason=args.reason)
    print(f"BLOCKED: {t['id']} - {t['title']}")
    print(f"REASON:  {args.reason}")
    dependents = [x["id"] for x in idx["tasks"] if t["id"] in x.get("needs", [])
                  and x["status"] in ("todo", "backlog")]
    if dependents:
        print(f"IMPACT:  {len(dependents)} task(s) now unreachable: {', '.join(dependents)}")
    print(f"Record detail in ## Log of .agent/tasks/{t['id']}.md")


def cmd_unblock(idx, cfg, args):
    t = by_id(idx, args.id) or die(f"task {args.id} not found")
    if t["status"] != "blocked":
        die(f"{args.id} is {t['status']}, not blocked")
    t["status"] = "todo"
    t.pop("blockReason", None)
    save_index(idx)
    journal("unblock", t["id"])
    print(f"UNBLOCKED: {t['id']} - {t['title']}")


def cmd_add(idx, cfg, args):
    needs = args.needs or []
    known = {t["id"] for t in idx["tasks"]} | set(idx["doneLedger"])
    missing = [n for n in needs if n not in known]
    if missing:
        die(f"--needs references unknown task(s): {', '.join(missing)}. "
            f"Known ids: {', '.join(sorted(known)) or '(none)'}")

    tid = f"T-{idx['nextId']:03d}"
    cycle = detect_cycle(idx, tid, needs)
    if cycle:
        die(f"dependency cycle: {' -> '.join(cycle)}")

    task = {
        "id": tid,
        "title": args.title,
        "status": "backlog" if args.backlog else "todo",
        "needs": needs,
        "createdAt": now(),
    }
    if args.tier:
        task["tier"] = args.tier
    idx["tasks"].append(task)
    idx["nextId"] += 1
    save_index(idx)
    journal("add", tid, title=args.title, needs=needs, backlog=args.backlog)
    print(f"ADDED [{'BACKLOG' if args.backlog else 'TODO'}]: {tid} - {args.title}")
    if needs:
        print(f"NEEDS: {', '.join(needs)}")


def cmd_promote(idx, cfg, args):
    t = by_id(idx, args.id) or die(f"task {args.id} not found")
    if t["status"] != "backlog":
        die(f"{args.id} is {t['status']}, not backlog")
    t["status"] = "todo"
    t["promotedAt"] = now()
    if args.reason:
        t["promoteReason"] = args.reason
    save_index(idx)
    journal("promote", t["id"], reason=args.reason)
    print(f"PROMOTED: {t['id']} - {t['title']}")


def cmd_defer(idx, cfg, args):
    """Explicitly decide a backlog item is out of scope - required for completion."""
    t = by_id(idx, args.id) or die(f"task {args.id} not found")
    t["status"] = "backlog"
    t["deferred"] = True
    t["deferReason"] = args.reason
    save_index(idx)
    journal("defer", t["id"], reason=args.reason)
    print(f"DEFERRED: {t['id']} - {t['title']}")
    print(f"REASON:   {args.reason}")


def cmd_rollback(idx, cfg, args):
    t = by_id(idx, args.id) or die(f"task {args.id} not found")
    base = t.get("baseSha")
    if not base:
        die(f"{args.id} has no recorded baseSha; cannot roll back safely")
    if not args.force:
        print(f"Would reset the working tree to {base[:8]} (the state before {t['id']} started).")
        print(git("diff", "--stat", f"{base}..HEAD") or "  (no committed changes)")
        dirty = git("status", "--porcelain")
        if dirty:
            print("\nUNCOMMITTED CHANGES WOULD BE LOST:")
            print(dirty)
        print(f"\nRe-run with --force to proceed: task.py rollback {t['id']} --force")
        return
    git("reset", "--hard", base, check=True)
    t["status"] = "todo"
    t.pop("baseSha", None)
    save_index(idx)
    journal("rollback", t["id"], to=base)
    print(f"ROLLED BACK: {t['id']} -> {base[:8]}, status reset to todo")


def cmd_status(idx, cfg, args):
    counts = {}
    for t in idx["tasks"]:
        counts[t["status"]] = counts.get(t["status"], 0) + 1
    total = len(idx["tasks"])
    archived = len(set(idx["doneLedger"]) - {t["id"] for t in idx["tasks"]})

    print("PROJECT STATUS")
    for s in ("done", "review", "verifying", "active", "todo", "blocked", "backlog"):
        print(f"  {s:<11} {counts.get(s, 0)}")
    print(f"  {'-' * 17}")
    print(f"  {'in index':<11} {total}")
    print(f"  {'archived':<11} {archived}")

    scope = total - counts.get("backlog", 0)
    if scope > 0:
        pct = int(((counts.get("done", 0) + archived) / (scope + archived)) * 100)
        print(f"  {'progress':<11} {pct}% (excludes backlog)")

    lock = os.path.join(AGENT_DIR, "harness.lock")
    if os.path.exists(lock):
        try:
            with open(lock, "r", encoding="utf-8") as f:
                lk = json.load(f)
            print(f"\nHARNESS  tier {lk.get('tier', '?')} | "
                  f"contract v{lk.get('harnessVersion', '?')} | "
                  f"profile {lk.get('profile', '?')}")
            print("  Run 'python3 .agent/tools/harness.py doctor' to check for drift.")
        except (OSError, json.JSONDecodeError):
            print("\nHARNESS  harness.lock unreadable - run: harness.py validate")
    else:
        print("\nHARNESS  no harness.lock - run: python3 .agent/tools/harness.py lock")


def cmd_list(idx, cfg, args):
    shown = 0
    for t in idx["tasks"]:
        if args.status and t["status"] != args.status:
            continue
        icon = STATUS_ICON.get(t["status"], "[?]")
        needs = f"  needs: {', '.join(t['needs'])}" if t.get("needs") else ""
        flag = ""
        if t.get("deferred"):
            flag = "  (deferred)"
        elif t.get("blockReason"):
            flag = f"  ({t['blockReason']})"
        print(f"  {icon} {t['id']} {t['title']}{needs}{flag}")
        shown += 1
    if not shown:
        print(f"  (no tasks{' with status ' + args.status if args.status else ''})")


def cmd_info(idx, cfg, args):
    t = by_id(idx, args.id) or die(f"task {args.id} not found")
    print(f"TASK     {t['id']} - {t['title']}")
    print(f"STATUS   {t['status']}")
    for key, label in (("needs", "NEEDS"), ("baseSha", "BASE"), ("createdAt", "CREATED"),
                       ("startedAt", "STARTED"), ("finishedAt", "FINISHED"),
                       ("blockReason", "BLOCKED"), ("approvedBy", "APPROVED BY"),
                       ("verifyJob", "VERIFY JOB")):
        v = t.get(key)
        if v:
            print(f"{label:<8} {', '.join(v) if isinstance(v, list) else v}")
    if t.get("needs"):
        u = unmet(idx, t)
        print(f"UNMET    {', '.join(u) if u else '(none)'}")
    path = os.path.join(TASKS_DIR, f"{t['id']}.md")
    print(f"FILE     .agent/tasks/{t['id']}.md{'' if os.path.exists(path) else '  (not created)'}")
    verdict, detail = gate_verdict(t["id"])
    if verdict:
        print(f"GATES    {verdict}")
        if isinstance(detail, dict):
            for g in detail.get("gates", []):
                print(f"           {g.get('verdict', '?'):<5} {g.get('id', '?')}"
                      f"  {g.get('measured', '')}")
    else:
        print(f"GATES    none  ({detail})")


def cmd_archive(idx, cfg, args):
    done = tasks_of(idx, "done")
    if not done:
        print("Nothing to archive.")
        return
    stamp = datetime.now(timezone.utc).strftime("%Y-%m-%d")
    dest = os.path.join(ARCHIVE_DIR, stamp)
    dest_tasks = os.path.join(dest, "tasks")
    os.makedirs(dest_tasks, exist_ok=True)

    with open(os.path.join(dest, "index.json"), "w", encoding="utf-8") as f:
        json.dump(done, f, indent=2)
        f.write("\n")

    moved = 0
    for t in done:
        src = os.path.join(TASKS_DIR, f"{t['id']}.md")
        if os.path.exists(src):
            shutil.move(src, os.path.join(dest_tasks, f"{t['id']}.md"))
            moved += 1
        ev = os.path.join(EVIDENCE_DIR, t["id"])
        if os.path.isdir(ev):
            shutil.move(ev, os.path.join(dest, "evidence-" + t["id"]))
        if t["id"] not in idx["doneLedger"]:
            idx["doneLedger"].append(t["id"])  # keeps dependencies resolvable

    idx["tasks"] = [t for t in idx["tasks"] if t["status"] != "done"]
    save_index(idx)
    journal("archive", "-", count=len(done), dest=stamp)
    print(f"ARCHIVED: {len(done)} tasks -> .agent/archive/{stamp}/")
    print(f"  task files moved: {moved}")
    print(f"  done-ledger:      {len(idx['doneLedger'])} ids retained (dependencies stay resolvable)")
    print(f"  next id:          T-{idx['nextId']:03d} (never reused)")


def cmd_doctor(idx, cfg, args):
    """Integrity check on task state itself."""
    problems, warnings = [], []
    ids = [t["id"] for t in idx["tasks"]]
    if len(ids) != len(set(ids)):
        problems.append("duplicate task ids in index")
    known = set(ids) | set(idx["doneLedger"])
    for t in idx["tasks"]:
        for n in t.get("needs", []):
            if n not in known:
                problems.append(f"{t['id']} needs {n}, which does not exist (dangling)")
        c = detect_cycle(idx, t["id"], t.get("needs", []))
        if c:
            problems.append(f"dependency cycle: {' -> '.join(c)}")
        try:
            if int(t["id"].split("-")[1]) >= idx["nextId"]:
                problems.append(f"{t['id']} >= nextId {idx['nextId']} - id reuse risk")
        except (IndexError, ValueError):
            problems.append(f"malformed task id: {t['id']}")
    if len(tasks_of(idx, "active")) > cfg["maxActive"]:
        problems.append(f"{len(tasks_of(idx, 'active'))} active tasks, maxActive is {cfg['maxActive']}")
    for t in tasks_of(idx, "todo"):
        dead = [n for n in unmet(idx, t) if (by_id(idx, n) or {}).get("status") == "blocked"]
        if dead:
            warnings.append(f"{t['id']} is deadlocked behind blocked {', '.join(dead)}")
    for t in tasks_of(idx, "done"):
        if t["id"] not in idx["doneLedger"]:
            warnings.append(f"{t['id']} is done but missing from doneLedger")

    for p in problems:
        print(f"FAIL  {p}")
    for w in warnings:
        print(f"WARN  {w}")
    if not problems and not warnings:
        print(f"OK    task state consistent ({len(ids)} tasks, "
              f"{len(idx['doneLedger'])} in done-ledger, nextId T-{idx['nextId']:03d})")
    sys.exit(1 if problems else 0)


TASK_STUB = """# {id} - {title}

<!-- Created {ts} by task.py. Sections below are the contract with the harness. -->

## What

<!-- SPEC: what to build, explicit scope boundaries, and acceptance criteria as
     testable statements. Each criterion must be checkable by a tool or a test,
     not by reading the code and forming an opinion. -->

## Plan

<!-- PLAN: subtask checkboxes, ordered by dependency, each one commit's worth. -->

- [ ]

## Evidence

<!-- Filled from .agent/evidence/{id}/. Do not write conclusions here that a
     tool did not produce. Cite artifact paths. -->

## Review

<!-- REVIEW findings. Each finding: file:line, what is wrong, why it matters,
     and the analyzer rule id if one covers it. -->

## Log

<!-- Decisions, dead ends, and what a future session needs to know. -->
"""


# -- cli ---------------------------------------------------------------------

def build_parser():
    p = argparse.ArgumentParser(prog="task.py", description="Agent harness task state manager")
    sub = p.add_subparsers(dest="cmd", required=True)

    def add(name, fn, help_text):
        sp = sub.add_parser(name, help=help_text)
        sp.set_defaults(fn=fn)
        return sp

    add("next", cmd_next, "pick the next eligible task -> active")

    s = add("verify-submit", cmd_verify_submit, "active -> verifying (async outer-lane gates)")
    s.add_argument("--job", help="external job id / URL for the async gate run")

    s = add("review", cmd_review, "submit for review (requires passing gates)")
    s.add_argument("--override", help="proceed without passing gates; reason is journalled")

    s = add("done", cmd_done, "mark complete (requires passing gates)")
    s.add_argument("id", nargs="?")
    s.add_argument("--override", help="complete without passing gates; reason is journalled")
    s.add_argument("--approved-by", help="human approver, required for risk-gated paths")

    s = add("approve", cmd_approve, "review -> done")
    s.add_argument("id", nargs="?")
    s.add_argument("--override")
    s.add_argument("--approved-by")

    s = add("reject", cmd_reject, "review -> active for rework")
    s.add_argument("id", nargs="?")
    s.add_argument("--reason", default="")

    s = add("block", cmd_block, "mark blocked with a reason")
    s.add_argument("reason")
    s.add_argument("--id")

    s = add("unblock", cmd_unblock, "blocked -> todo")
    s.add_argument("id")

    s = add("add", cmd_add, "create a task")
    s.add_argument("title")
    s.add_argument("--needs", action="append", metavar="T-XXX")
    s.add_argument("--backlog", action="store_true")
    s.add_argument("--tier", help="minimum harness tier this task requires")

    s = add("promote", cmd_promote, "backlog -> todo")
    s.add_argument("id")
    s.add_argument("--reason")

    s = add("defer", cmd_defer, "explicitly rule a backlog item out of scope")
    s.add_argument("id")
    s.add_argument("reason")

    s = add("rollback", cmd_rollback, "reset working tree to a task's base commit")
    s.add_argument("id")
    s.add_argument("--force", action="store_true")

    add("status", cmd_status, "project summary")

    s = add("list", cmd_list, "list tasks")
    s.add_argument("status", nargs="?", help="filter by status")

    s = add("info", cmd_info, "task detail incl. gate evidence")
    s.add_argument("id")

    add("archive", cmd_archive, "move done tasks to archive (dependency-safe)")
    add("doctor", cmd_doctor, "check task-state integrity")
    return p


def main():
    args = build_parser().parse_args()
    for attr in ("override", "approved_by", "reason", "id", "job", "status", "tier"):
        if not hasattr(args, attr):
            setattr(args, attr, None)
    args.fn(load_index(), read_config(), args)


if __name__ == "__main__":
    main()

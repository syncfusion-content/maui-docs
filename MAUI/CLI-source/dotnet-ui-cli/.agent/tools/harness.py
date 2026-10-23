#!/usr/bin/env python3
"""Harness driver: gate runner, contract validator, lock manager, doctor.

This is the component that makes the harness a verification system rather than a
process ritual. It runs real tools, parses their real output, compares the result
to a declared threshold, and writes evidence that task.py refuses to proceed
without.

Design rule enforced here: an agent may narrate, but it may not assert. Every
verdict in gate-summary.json traces to a tool exit code and a parsed artifact.

Commands:
  validate                  check harness.yaml against the contract schema
  lock                      resolve tool versions + hashes -> harness.lock
  doctor                    validate + drift detection + remediation
  tier                      show current tier and what the next tier requires
  gate list                 show configured gates, lanes, thresholds, metrics
  gate run [--lane] [--scope] [--task] [--gate]   run gates, write evidence
  gate submit               record an async outer-lane job
  gate poll                 reconcile async outer-lane jobs
  ratchet [--apply]         propose raising thresholds to current measurements
  explain <claim>           show the tool of record for a claim
"""

import argparse
import hashlib
import json
import os
import re
import shlex
import subprocess
import sys
import time
from datetime import datetime, timezone

BIN_DIR = os.path.dirname(os.path.abspath(__file__))
AGENT_DIR = os.path.dirname(BIN_DIR)
REPO_ROOT = os.path.dirname(AGENT_DIR)
CONFIG = os.path.join(AGENT_DIR, "harness.yaml")
LOCK = os.path.join(AGENT_DIR, "harness.lock")
EVIDENCE = os.path.join(AGENT_DIR, "evidence")
TASKS_DIR = os.path.join(AGENT_DIR, "tasks")
KNOWLEDGE = os.path.join(AGENT_DIR, "knowledge")
CP_LOCK = os.path.join(AGENT_DIR, "HARNESS-LOCK.json")
CP_DIRS = ["workflows", "agents", "policies", "checklists", "templates", "skills"]

sys.path.insert(0, BIN_DIR)
import hyaml  # noqa: E402
import parsers  # noqa: E402

CONTRACT_VERSION = "1.0"
TIERS = ["L0", "L1", "L2", "L3"]
LANES = ["inner", "outer"]
OPS = {
    "==": lambda a, b: a == b, "!=": lambda a, b: a != b,
    ">=": lambda a, b: a >= b, "<=": lambda a, b: a <= b,
    ">": lambda a, b: a > b, "<": lambda a, b: a < b,
}
MANIFESTS = [
    "package.json", "requirements.txt", "pyproject.toml", "Cargo.toml", "go.mod",
    "pom.xml", "build.gradle", "build.gradle.kts", "Gemfile", "composer.json",
    "mix.exs", "pubspec.yaml", "Directory.Packages.props",
]


def now():
    return datetime.now(timezone.utc).isoformat(timespec="seconds")


def die(msg, code=1):
    print(f"ERROR: {msg}", file=sys.stderr)
    sys.exit(code)


def git(*args):
    try:
        r = subprocess.run(["git", "-C", REPO_ROOT, *args],
                           capture_output=True, text=True, timeout=60)
        return r.stdout.strip() if r.returncode == 0 else ""
    except (OSError, subprocess.SubprocessError):
        return ""


def sha256_text(text):
    return hashlib.sha256(text.encode("utf-8", "replace")).hexdigest()


def sha256_file(path):
    h = hashlib.sha256()
    try:
        with open(path, "rb") as f:
            for chunk in iter(lambda: f.read(65536), b""):
                h.update(chunk)
        return h.hexdigest()
    except OSError:
        return None


# -- config ------------------------------------------------------------------

def load_config(required=True):
    if not os.path.exists(CONFIG):
        if required:
            die(f"no harness contract at {CONFIG}. Generate one with the harness-creator skill.")
        return {}
    try:
        cfg = hyaml.loads(open(CONFIG, encoding="utf-8").read())
    except hyaml.HYamlError as e:
        die(f"harness.yaml is not parseable: {e}")
    if not isinstance(cfg, dict):
        die("harness.yaml must be a mapping at the top level")
    return cfg


def load_lock():
    if not os.path.exists(LOCK):
        return None
    try:
        return json.load(open(LOCK, encoding="utf-8"))
    except (OSError, json.JSONDecodeError) as e:
        die(f"harness.lock is unreadable ({e}). Regenerate with: harness.py lock")


# -- threshold expressions ---------------------------------------------------

TERM = re.compile(r"^\s*([A-Za-z_][\w.]*)\s*(==|!=|>=|<=|>|<)\s*(-?[\d.]+)\s*$")


def parse_threshold(expr):
    """Parse 'errors == 0 and diffLineRate >= 0.8' into comparison terms.

    Deliberately not eval(): a threshold comes from a config file that may be
    generated, and the harness must never execute arbitrary expressions.
    """
    if not expr or not str(expr).strip():
        return []
    terms = []
    for part in re.split(r"\s+and\s+", str(expr)):
        m = TERM.match(part)
        if not m:
            raise ValueError(
                f"cannot parse threshold term {part!r}. "
                f"Expected '<metric> <op> <number>' joined by 'and'; "
                f"ops: {', '.join(OPS)}")
        metric, op, value = m.group(1), m.group(2), m.group(3)
        terms.append((metric, op, float(value)))
    return terms


def eval_threshold(terms, metrics):
    """-> (passed, [(term_str, actual, ok)]). Missing metric fails loudly."""
    details, ok_all = [], True
    for metric, op, want in terms:
        term = f"{metric} {op} {_num(want)}"
        if metric not in metrics:
            details.append((term, "MISSING", False))
            ok_all = False
            continue
        actual = metrics[metric]
        ok = OPS[op](float(actual), want)
        details.append((term, _num(actual), ok))
        ok_all = ok_all and ok
    return ok_all, details


def _num(v):
    f = float(v)
    return str(int(f)) if f == int(f) and abs(f) < 1e15 else f"{f:g}"


# -- schema validation -------------------------------------------------------

GATE_REQUIRED = ["id", "claim", "lane", "command", "parser", "threshold"]
GATE_OPTIONAL = ["evidence", "blocking", "ratchet", "tier", "tool", "versionCommand",
                 "parserArgs", "timeoutSeconds", "scope", "cwd", "env", "when",
                 "installHint", "license", "docs", "mode", "submitCommand",
                 "pollCommand", "allowFailure", "rationale", "appliesTo"]


def validate(cfg, verbose=True):
    """-> (errors, warnings). The contract check the CI job should run."""
    errors, warnings = [], []

    def err(m):
        errors.append(m)

    def warn(m):
        warnings.append(m)

    v = str(cfg.get("harnessVersion", ""))
    if not v:
        err("harnessVersion is required")
    elif v.split(".")[0] != CONTRACT_VERSION.split(".")[0]:
        err(f"harnessVersion {v} is incompatible with this harness.py "
            f"(contract {CONTRACT_VERSION}). Re-run the harness-creator skill to upgrade.")

    tier = cfg.get("tier")
    if tier not in TIERS:
        err(f"tier must be one of {TIERS}, got {tier!r}")
    if not cfg.get("profile"):
        warn("no profile declared; stack-specific gates and review catalogs will be generic")

    gates = cfg.get("gates") or []
    if not isinstance(gates, list) or not gates:
        err("gates must be a non-empty list")
        gates = []

    seen = set()
    lanes_used = set()
    for i, g in enumerate(gates):
        where = f"gates[{i}]"
        if not isinstance(g, dict):
            err(f"{where} must be a mapping")
            continue
        gid = g.get("id", f"<unnamed {i}>")
        where = f"gate '{gid}'"
        for k in GATE_REQUIRED:
            if g.get(k) in (None, ""):
                err(f"{where}: missing required key '{k}'")
        if gid in seen:
            err(f"duplicate gate id '{gid}'")
        seen.add(gid)
        for k in g:
            if k not in GATE_REQUIRED + GATE_OPTIONAL:
                warn(f"{where}: unknown key '{k}' (ignored)")
        if g.get("lane") not in LANES:
            err(f"{where}: lane must be one of {LANES}, got {g.get('lane')!r}")
        else:
            lanes_used.add(g["lane"])
        p = g.get("parser")
        if p and p not in parsers.PARSERS:
            err(f"{where}: unknown parser '{p}'. Available: {', '.join(sorted(parsers.PARSERS))}")
        try:
            terms = parse_threshold(g.get("threshold"))
            if not terms:
                err(f"{where}: threshold is empty - a gate with no threshold cannot fail, "
                    f"which defeats the point of declaring it")
            known = parsers.METRICS.get(p, [])
            if known and not any(x.startswith("<") for x in known):
                for metric, _, _ in terms:
                    if metric not in known:
                        warn(f"{where}: threshold references '{metric}', but parser "
                             f"'{p}' emits {known}")
        except ValueError as e:
            err(f"{where}: {e}")
        if p in ("junit", "trx", "cobertura", "cobertura-diff", "lcov", "lcov-diff",
                 "stryker", "sarif", "eslint-json", "jsonpath", "memlab") \
                and not g.get("evidence"):
            err(f"{where}: parser '{p}' reads an artifact, so 'evidence' "
                f"(the artifact path it produces) is required")
        if g.get("tier") and g["tier"] not in TIERS:
            err(f"{where}: tier must be one of {TIERS}")
        if g.get("mode") == "async" and not g.get("pollCommand"):
            err(f"{where}: mode 'async' requires pollCommand")
        if g.get("lane") == "inner" and g.get("mode") == "async":
            err(f"{where}: inner-lane gates must be synchronous - the inner lane is "
                f"the fast feedback loop")
        if g.get("allowFailure") and g.get("blocking"):
            err(f"{where}: allowFailure and blocking are contradictory")

    if "inner" not in lanes_used:
        warn("no inner-lane gates: the build agent will get no fast feedback")
    if tier != "L0" and "outer" not in lanes_used:
        warn(f"tier {tier} declares no outer-lane gates; coverage/mutation evidence "
             f"is usually outer-lane")

    # tier obligations
    claims = {str(g.get("claim", "")).lower() + " " + str(g.get("id", "")).lower()
              for g in gates if isinstance(g, dict)}
    blob = " ".join(claims)
    obligations = {
        "L1": [("coverage", "diff coverage")],
        "L2": [("coverage", "diff coverage"), ("test", "test execution")],
        "L3": [("coverage", "diff coverage"), ("test", "test execution"),
               ("mutation", "mutation testing")],
    }
    for need, label in obligations.get(str(tier), []):
        if need not in blob:
            err(f"tier {tier} requires a {label} gate, but no gate mentions '{need}'. "
                f"Either add the gate or lower the tier - the tier is a promise "
                f"about what has been verified.")

    lock = load_lock()
    if lock:
        floors = lock.get("ratchetFloors") or {}
        for g in gates:
            if not isinstance(g, dict):
                continue
            floor = floors.get(g.get("id"))
            if floor is None:
                continue
            try:
                for metric, op, val in parse_threshold(g.get("threshold")):
                    fmetric, fop, fval = floor["metric"], floor["op"], floor["value"]
                    if metric != fmetric:
                        continue
                    lowered = (val < fval) if fop in (">=", ">") else (val > fval)
                    if lowered:
                        err(f"gate '{g['id']}': threshold {metric} {op} {_num(val)} is "
                            f"below the ratchet floor {fmetric} {fop} {_num(fval)} "
                            f"recorded in harness.lock. Quality bars ratchet up, not down. "
                            f"To lower deliberately: harness.py lock --lower-floor "
                            f"{g['id']} --reason \"...\"")
            except (ValueError, KeyError):
                pass
        if lock.get("fingerprint") and lock["fingerprint"] != repo_fingerprint():
            warn("repo fingerprint differs from harness.lock: dependencies or project "
                 "files changed. Re-run the harness-creator skill in upgrade mode so "
                 "gates and knowledge match reality. Details: harness.py doctor")
    else:
        warn("no harness.lock. Run: harness.py lock")

    if verbose:
        for e in errors:
            print(f"FAIL  {e}")
        for w in warnings:
            print(f"WARN  {w}")
        if not errors and not warnings:
            print(f"OK    contract valid: tier {tier}, {len(gates)} gates, "
                  f"profile {cfg.get('profile', '(none)')}")
        elif not errors:
            print(f"OK    contract valid with {len(warnings)} warning(s): "
                  f"tier {tier}, {len(gates)} gates")
    return errors, warnings


# -- fingerprint & lock ------------------------------------------------------

def dependency_names(path):
    """Extract dependency *names* (not versions) from a manifest.

    Names are what change the harness: a new framework or a new Syncfusion
    package means new gates and new knowledge. Version bumps do not.
    """
    names = set()
    base = os.path.basename(path)
    try:
        text = open(path, encoding="utf-8", errors="replace").read()
    except OSError:
        return names
    if base == "package.json":
        try:
            data = json.loads(text)
            for section in ("dependencies", "devDependencies", "peerDependencies"):
                names.update((data.get(section) or {}).keys())
        except json.JSONDecodeError:
            pass
    elif base.endswith((".csproj", ".fsproj", ".vbproj", ".props")):
        names.update(re.findall(r'(?:PackageReference|PackageVersion)\s+Include="([^"]+)"', text))
    elif base in ("requirements.txt",):
        for line in text.splitlines():
            line = line.strip()
            if line and not line.startswith("#"):
                names.add(re.split(r"[=<>!\[; ]", line)[0])
    elif base == "pyproject.toml":
        names.update(re.findall(r'^\s*"?([A-Za-z0-9_.-]+)"?\s*[=><~]', text, re.MULTILINE))
    elif base == "go.mod":
        names.update(re.findall(r"^\s+([\w./-]+)\s+v", text, re.MULTILINE))
    elif base == "Cargo.toml":
        names.update(re.findall(r"^([A-Za-z0-9_-]+)\s*=", text, re.MULTILINE))
    elif base in ("pom.xml",):
        names.update(re.findall(r"<artifactId>([^<]+)</artifactId>", text))
    return names


def find_manifests():
    """Locate manifests, skipping vendored trees."""
    skip = {"node_modules", ".git", "bin", "obj", "dist", "build", "vendor",
            ".venv", "venv", "__pycache__", "target", ".agent", "packages",
            "TestResults", ".vs", ".idea"}
    found = []
    for root, dirs, files in os.walk(REPO_ROOT):
        dirs[:] = [d for d in dirs if d not in skip and not d.startswith(".")]
        if root.count(os.sep) - REPO_ROOT.count(os.sep) > 5:
            dirs[:] = []
        for f in files:
            if f in MANIFESTS or f.endswith((".csproj", ".fsproj", ".vbproj", ".sln")):
                found.append(os.path.relpath(os.path.join(root, f), REPO_ROOT))
    return sorted(found)


def repo_fingerprint():
    """Stable hash of project shape: manifest set + dependency names."""
    parts = []
    for rel in find_manifests():
        names = dependency_names(os.path.join(REPO_ROOT, rel))
        parts.append(rel + "|" + ",".join(sorted(names)))
    return sha256_text("\n".join(parts))[:32]


def resolve_tool(gate):
    """Run a gate's versionCommand to record what is actually installed."""
    vc = gate.get("versionCommand")
    if not vc:
        return None
    try:
        r = subprocess.run(vc, shell=True, cwd=REPO_ROOT, capture_output=True,
                           text=True, timeout=90)
        if r.returncode != 0:
            return {"status": "error", "detail": (r.stderr or r.stdout).strip()[:200]}
        out = (r.stdout or r.stderr).strip().splitlines()
        return {"status": "ok", "version": out[0].strip()[:120] if out else "(no output)"}
    except subprocess.TimeoutExpired:
        return {"status": "timeout"}
    except OSError as e:
        return {"status": "missing", "detail": str(e)[:200]}


def cmd_lock(cfg, args):
    errors, _ = validate(cfg, verbose=False)
    if errors and not args.force:
        print("Refusing to lock an invalid contract:")
        for e in errors:
            print(f"  FAIL  {e}")
        print("\nFix harness.yaml, or re-run with --force to lock anyway.")
        sys.exit(1)

    gates = cfg.get("gates") or []
    tools, floors = {}, {}
    existing = load_lock() or {}
    old_floors = existing.get("ratchetFloors") or {}

    print("Resolving tools...")
    for g in gates:
        if not isinstance(g, dict):
            continue
        name = g.get("tool") or g.get("id")
        if g.get("versionCommand") and name not in tools:
            info = resolve_tool(g)
            tools[name] = info
            mark = {"ok": "ok", "missing": "MISSING", "error": "ERROR",
                    "timeout": "TIMEOUT"}.get(info["status"], "?")
            print(f"  {mark:<8} {name:<22} {info.get('version', info.get('detail', ''))[:60]}")
        if g.get("ratchet"):
            try:
                terms = parse_threshold(g.get("threshold"))
            except ValueError:
                continue
            for metric, op, val in terms:
                if op not in (">=", ">", "<=", "<"):
                    continue
                prev = old_floors.get(g["id"])
                keep = prev
                if prev and prev.get("metric") == metric:
                    higher = (max(val, prev["value"]) if op in (">=", ">")
                              else min(val, prev["value"]))
                    keep = {"metric": metric, "op": op, "value": higher,
                            "since": prev.get("since", now())}
                    if args.lower_floor == g["id"]:
                        keep = {"metric": metric, "op": op, "value": val, "since": now(),
                                "loweredFrom": prev["value"], "reason": args.reason or "(none)"}
                else:
                    keep = {"metric": metric, "op": op, "value": val, "since": now()}
                floors[g["id"]] = keep
                break

    knowledge = {}
    if os.path.isdir(KNOWLEDGE):
        for root, _, files in os.walk(KNOWLEDGE):
            for f in sorted(files):
                p = os.path.join(root, f)
                rel = os.path.relpath(p, AGENT_DIR)
                knowledge[rel] = {"sha256": sha256_file(p),
                                  "sources": _extract_sources(p)}

    lock = {
        "lockVersion": 1,
        "harnessVersion": cfg.get("harnessVersion"),
        "contractVersion": CONTRACT_VERSION,
        "generatedAt": now(),
        "profile": cfg.get("profile"),
        "overlays": cfg.get("overlays") or [],
        "tier": cfg.get("tier"),
        "fingerprint": repo_fingerprint(),
        "manifests": find_manifests(),
        "configSha256": sha256_file(CONFIG),
        "gateIds": [g.get("id") for g in gates if isinstance(g, dict)],
        "tools": tools,
        "ratchetFloors": floors,
        "knowledge": knowledge,
        "python": sys.version.split()[0],
        "git": git("rev-parse", "HEAD") or None,
    }
    with open(LOCK, "w", encoding="utf-8") as f:
        json.dump(lock, f, indent=2)
        f.write("\n")

    missing = [k for k, v in tools.items() if v["status"] != "ok"]
    print(f"\nWrote {os.path.relpath(LOCK, REPO_ROOT)}")
    print(f"  tier            {lock['tier']}")
    print(f"  fingerprint     {lock['fingerprint']}")
    print(f"  gates           {len(lock['gateIds'])}")
    print(f"  ratchet floors  {len(floors)}")
    print(f"  knowledge files {len(knowledge)}")
    if missing:
        print(f"\n  {len(missing)} tool(s) not resolvable: {', '.join(missing)}")
        for g in gates:
            if isinstance(g, dict) and (g.get("tool") or g.get("id")) in missing \
                    and g.get("installHint"):
                print(f"    {g.get('tool') or g['id']}: {g['installHint']}")


def _extract_sources(path):
    """Pull provenance lines out of a knowledge doc.

    Knowledge files must cite where each rule came from; the lock records those
    citations so drift in an upstream doc is detectable.
    """
    try:
        text = open(path, encoding="utf-8", errors="replace").read()
    except OSError:
        return []
    out = []
    for m in re.finditer(r"^\s*[-*]?\s*(?:Source|SOURCE|source):\s*(\S+)"
                         r"(?:\s+\(retrieved\s+([\d-]+)\))?", text, re.MULTILINE):
        out.append({"url": m.group(1), "retrieved": m.group(2)})
    return out


# -- gate execution ----------------------------------------------------------

def select_gates(cfg, lane=None, gate_ids=None, tier=None):
    out = []
    order = {"inner": 0, "outer": 1}
    for g in cfg.get("gates") or []:
        if not isinstance(g, dict):
            continue
        if lane and lane != "all" and g.get("lane") != lane:
            continue
        if gate_ids and g.get("id") not in gate_ids:
            continue
        if tier and g.get("tier") and TIERS.index(g["tier"]) > TIERS.index(tier):
            continue
        out.append(g)
    return sorted(out, key=lambda g: (order.get(g.get("lane"), 9), g.get("id", "")))


def active_task():
    idx = os.path.join(TASKS_DIR, "index.json")
    if not os.path.exists(idx):
        return None
    try:
        data = json.load(open(idx, encoding="utf-8"))
    except (OSError, json.JSONDecodeError):
        return None
    tasks = data if isinstance(data, list) else data.get("tasks", [])
    for status in ("active", "verifying", "review"):
        for t in tasks:
            if t.get("status") == status:
                return t
    return None


def run_gate(gate, ctx_base, timeout_default=900):
    """Execute one gate and return its result record."""
    gid = gate["id"]
    started = time.time()
    rec = {
        "id": gid, "lane": gate.get("lane"), "claim": gate.get("claim"),
        "command": gate.get("command"), "parser": gate.get("parser"),
        "threshold": gate.get("threshold"), "blocking": gate.get("blocking", True),
        "tool": gate.get("tool"),
    }

    cmd = gate["command"]
    for key, val in ctx_base["substitutions"].items():
        cmd = cmd.replace("{" + key + "}", str(val))

    env = dict(os.environ)
    for k, v in (gate.get("env") or {}).items():
        env[str(k)] = str(v)
    cwd = os.path.join(REPO_ROOT, gate["cwd"]) if gate.get("cwd") else REPO_ROOT
    timeout = int(gate.get("timeoutSeconds") or timeout_default)

    ev_dir = ctx_base["evidenceDir"]
    os.makedirs(ev_dir, exist_ok=True)
    log_path = os.path.join(ev_dir, f"{gid}.log")

    try:
        proc = subprocess.run(cmd, shell=True, cwd=cwd, env=env,
                              capture_output=True, text=True, timeout=timeout)
        stdout, stderr, code = proc.stdout, proc.stderr, proc.returncode
    except subprocess.TimeoutExpired as e:
        stdout = (e.stdout or b"").decode("utf-8", "replace") if isinstance(e.stdout, bytes) else (e.stdout or "")
        stderr = f"TIMEOUT after {timeout}s"
        code = 124
    except OSError as e:
        stdout, stderr, code = "", f"could not execute: {e}", 127

    with open(log_path, "w", encoding="utf-8") as f:
        f.write(f"$ {cmd}\n(cwd: {cwd})\n(exit: {code})\n\n--- stdout ---\n{stdout}"
                f"\n--- stderr ---\n{stderr}\n")
    rec["log"] = os.path.relpath(log_path, AGENT_DIR)
    rec["exit"] = code
    rec["durationMs"] = int((time.time() - started) * 1000)

    if code == 127:
        rec.update(verdict="error", measured="tool not found",
                   detail=stderr.strip()[:300],
                   remediation=gate.get("installHint") or
                   f"install the tool for gate '{gid}'")
        return rec
    if code == 124:
        rec.update(verdict="error", measured=f"timeout after {timeout}s",
                   remediation="raise timeoutSeconds, or move this gate to the "
                               "outer lane / async mode")
        return rec

    artifact = None
    if gate.get("evidence"):
        cand = gate["evidence"]
        for key, val in ctx_base["substitutions"].items():
            cand = cand.replace("{" + key + "}", str(val))
        artifact = cand if os.path.isabs(cand) else os.path.join(REPO_ROOT, cand)
        rec["artifact"] = os.path.relpath(artifact, REPO_ROOT)

    ctx = dict(ctx_base)
    ctx.update(stdout=stdout, stderr=stderr, returncode=code,
               artifact=artifact, args=gate.get("parserArgs") or {})

    try:
        metrics = parsers.PARSERS[gate["parser"]](ctx)
    except parsers.ParseError as e:
        rec.update(verdict="error", measured="unparseable",
                   detail=str(e),
                   remediation=f"the gate ran (exit {code}) but its evidence could not "
                               f"be parsed. Check that the command actually writes "
                               f"{gate.get('evidence')!r}.")
        return rec
    except Exception as e:  # noqa: BLE001 - a parser bug must not look like a pass
        rec.update(verdict="error", measured="parser crashed", detail=f"{type(e).__name__}: {e}")
        return rec

    public = {k: v for k, v in metrics.items() if not k.startswith("_")}
    rec["metrics"] = public
    for k, v in metrics.items():
        if k.startswith("_"):
            rec.setdefault("extra", {})[k.lstrip("_")] = v

    try:
        terms = parse_threshold(gate["threshold"])
    except ValueError as e:
        rec.update(verdict="error", measured="bad threshold", detail=str(e))
        return rec

    passed, details = eval_threshold(terms, metrics)
    rec["terms"] = [{"term": t, "actual": a, "ok": ok} for t, a, ok in details]
    rec["measured"] = ", ".join(f"{t.split()[0]}={a}" for t, a, _ in details)
    if passed:
        rec["verdict"] = "pass"
    elif gate.get("allowFailure"):
        rec["verdict"] = "warn"
    else:
        rec["verdict"] = "fail"
        rec["remediation"] = _remediate(gate, metrics, details, stdout, stderr)
    return rec


def _tool_output(stdout, stderr, limit=25):
    """Surface a tool's own message. Scripts and CLIs put the actionable text
    here, and burying it in a log file is how gate output becomes noise."""
    lines = [ln for ln in ((stderr or "") + "\n" + (stdout or "")).splitlines()
             if ln.strip()]
    if not lines:
        return None
    flagged = [ln for ln in lines
               if re.search(r"\b(FAIL|ERROR|error|warning|Fix:|->)\b", ln)]
    chosen = (flagged or lines)[:limit]
    return "\n".join(chosen)


def _remediate(gate, metrics, details, stdout="", stderr=""):
    """Turn a failed threshold into an instruction the agent can act on."""
    failed = [t for t, a, ok in details if not ok]
    p = gate.get("parser")
    if p in ("cobertura-diff", "lcov-diff"):
        sample = metrics.get("_uncoveredSample") or []
        if sample:
            return ("Add tests covering these changed lines (they are yours, not legacy):\n    "
                    + "\n    ".join(sample[:20])
                    + ("\n    ..." if len(sample) > 20 else ""))
        return ("No changed executable lines were found in the coverage report. Either the "
                "test run did not instrument the changed project, or the gate's baseRef is wrong.")
    if p == "stryker":
        return (f"{int(metrics.get('survived', 0))} mutant(s) survived and "
                f"{int(metrics.get('noCoverage', 0))} had no coverage. Survived mutants mean "
                f"tests execute the code but do not assert on its behaviour. Read the report, "
                f"then strengthen assertions - do not delete mutants or lower the threshold.")
    if p in ("msbuild", "eslint-json"):
        per = metrics.get("_perRule") or {}
        if per:
            return ("Fix these analyzer findings at the source (top rules by count):\n    "
                    + "\n    ".join(f"{k}: {v}" for k, v in per.items())
                    + "\n  Suppressions require a written justification in the task ## Log.")
    if p == "sarif":
        per = metrics.get("_topRules") or {}
        if per:
            return ("Scanner findings by rule:\n    "
                    + "\n    ".join(f"{k}: {v}" for k, v in per.items()))
    if p in ("junit", "trx"):
        out = _tool_output(stdout, stderr, 15)
        return (f"{int(metrics.get('failed', 0))} test(s) failing. Fix the root cause. "
                f"Do not delete, skip, or weaken the failing assertions."
                + (f"\n{out}" if out else ""))
    if p == "exitcode":
        out = _tool_output(stdout, stderr)
        if out:
            return f"The tool reported:\n{out}"
        return (f"Command exited {metrics.get('exit')} with no output. "
                f"See {gate.get('id')}.log.")
    if p == "memlab":
        return (f"{int(metrics.get('leaks', 0))} leak(s) detected. The report names the "
                f"retaining path - fix the retainer, do not raise the threshold.")
    return f"Threshold not met: {', '.join(failed)}. See {gate.get('id')}.log."


def cmd_gate_run(cfg, args):
    task = None
    tid = args.task
    if not tid:
        t = active_task()
        tid = t["id"] if t else "adhoc"
        task = t
    ev_dir = os.path.join(EVIDENCE, tid)

    base_ref = args.base
    if not base_ref and task:
        base_ref = task.get("baseSha")
    if not base_ref and args.scope == "diff":
        base_ref = git("rev-parse", "HEAD~1") or None

    gates = select_gates(cfg, lane=args.lane, gate_ids=args.gate, tier=cfg.get("tier"))
    if not gates:
        die(f"no gates match lane={args.lane!r} gate={args.gate!r}")

    subs = {
        "TASK": tid,
        "BASE": base_ref or "",
        "EVIDENCE_DIR": ev_dir,
        "REPO": REPO_ROOT,
        "SCOPE": args.scope,
    }
    ctx_base = {"repoRoot": REPO_ROOT, "baseRef": base_ref,
                "evidenceDir": ev_dir, "substitutions": subs}

    lane_budget = ((cfg.get("lanes") or {}).get(args.lane) or {}).get("budgetSeconds")
    print(f"GATES  task={tid}  lane={args.lane}  scope={args.scope}  "
          f"base={(base_ref or 'n/a')[:8]}")
    if args.scope == "diff" and not base_ref:
        print("  NOTE: scope=diff but no base ref resolved; diff gates will score nothing.")
    print()

    results, wall = [], time.time()
    for g in gates:
        print(f"  ... {g['id']:<24} {g.get('claim', '')[:52]}")
        rec = run_gate(g, ctx_base)
        results.append(rec)
        mark = {"pass": "PASS", "fail": "FAIL", "warn": "WARN", "error": "ERR "}[rec["verdict"]]
        print(f"  {mark} {g['id']:<24} {rec.get('measured', '')}  "
              f"[{rec['durationMs'] / 1000:.1f}s]")
        if rec["verdict"] in ("fail", "error"):
            if rec.get("detail"):
                print(f"       {rec['detail'][:200]}")
            if rec.get("remediation"):
                for line in str(rec["remediation"]).splitlines():
                    print(f"       {line}")
            if rec.get("blocking", True) and not args.keep_going:
                print(f"\n  Stopping: '{g['id']}' is blocking. "
                      f"Fix it, then re-run. (--keep-going to run all gates anyway)")
                break

    elapsed = time.time() - wall
    blocking_bad = [r for r in results
                    if r["verdict"] in ("fail", "error") and r.get("blocking", True)]
    ran_ids = {r["id"] for r in results}
    pending = [g["id"] for g in select_gates(cfg, lane="all", tier=cfg.get("tier"))
               if g["id"] not in ran_ids]

    verdict = "fail" if blocking_bad else ("partial" if pending else "pass")
    summary = {
        "task": tid,
        "commit": git("rev-parse", "HEAD") or None,
        "baseRef": base_ref,
        "ts": now(),
        "tier": cfg.get("tier"),
        "profile": cfg.get("profile"),
        "lane": args.lane,
        "scope": args.scope,
        "verdict": verdict,
        "summary": (f"{sum(1 for r in results if r['verdict'] == 'pass')}/"
                    f"{len(results)} gates pass"
                    + (f", {len(pending)} not run" if pending else "")),
        "durationSeconds": round(elapsed, 1),
        "gatesNotRun": pending,
        "gates": results,
        "harnessVersion": cfg.get("harnessVersion"),
        "contractVersion": CONTRACT_VERSION,
    }
    if verdict == "partial":
        summary["blocksDone"] = True
        summary["reason"] = (f"gates not yet run: {', '.join(pending)}. "
                             f"Run the outer lane, or mark them async and poll.")

    os.makedirs(ev_dir, exist_ok=True)
    path = os.path.join(ev_dir, "gate-summary.json")
    with open(path, "w", encoding="utf-8") as f:
        json.dump(summary, f, indent=2)
        f.write("\n")

    print(f"\n  {summary['summary']}  [{elapsed:.1f}s total]")
    if lane_budget and elapsed > float(lane_budget):
        print(f"  BUDGET: {args.lane} lane took {elapsed:.0f}s, budget is {lane_budget}s. "
              f"Move slow gates to the outer lane or make them async - a slow inner "
              f"lane is how agents learn to skip verification.")
    if pending:
        print(f"  NOT RUN: {', '.join(pending)}")
    print(f"  evidence -> {os.path.relpath(path, REPO_ROOT)}")
    print(f"  VERDICT: {verdict.upper()}")
    if verdict != "pass":
        print("\n  task.py will refuse to mark this task done. That is the design.")
    sys.exit(0 if verdict == "pass" else 2)


def cmd_gate_list(cfg, args):
    gates = select_gates(cfg, lane=args.lane)
    print(f"CONTRACT  v{cfg.get('harnessVersion')}  tier {cfg.get('tier')}  "
          f"profile {cfg.get('profile')}")
    ov = cfg.get("overlays") or []
    if ov:
        print(f"OVERLAYS  {', '.join(map(str, ov))}")
    for lane in LANES:
        in_lane = [g for g in gates if g.get("lane") == lane]
        if not in_lane:
            continue
        budget = ((cfg.get("lanes") or {}).get(lane) or {}).get("budgetSeconds")
        print(f"\n{lane.upper()} LANE" + (f"  (budget {budget}s)" if budget else ""))
        for g in in_lane:
            flags = []
            if not g.get("blocking", True):
                flags.append("non-blocking")
            if g.get("ratchet"):
                flags.append("ratchet")
            if g.get("mode") == "async":
                flags.append("async")
            if g.get("allowFailure"):
                flags.append("allowFailure")
            print(f"  {g['id']}")
            print(f"    claim      {g.get('claim')}")
            print(f"    tool       {g.get('tool', '(unspecified)')}"
                  + (f"   [{g['license']}]" if g.get("license") else ""))
            print(f"    command    {g.get('command')}")
            print(f"    parser     {g.get('parser')}  -> "
                  f"{', '.join(parsers.METRICS.get(g.get('parser'), ['?']))}")
            print(f"    threshold  {g.get('threshold')}")
            if g.get("evidence"):
                print(f"    artifact   {g['evidence']}")
            if flags:
                print(f"    flags      {', '.join(flags)}")
            if g.get("rationale"):
                print(f"    why        {g['rationale']}")


def cmd_gate_submit(cfg, args):
    """Record an async outer-lane job so the loop can continue meanwhile."""
    t = active_task()
    tid = args.task or (t["id"] if t else die("no active task; pass --task"))
    ev_dir = os.path.join(EVIDENCE, tid)
    os.makedirs(ev_dir, exist_ok=True)
    gates = [g for g in select_gates(cfg, lane="outer") if g.get("mode") == "async"]
    if not gates and not args.job:
        die("no async outer-lane gates configured, and no --job given")

    jobs = []
    for g in gates:
        sc = g.get("submitCommand")
        job_id = args.job
        if sc:
            cmd = sc.replace("{TASK}", tid).replace("{BASE}", args.base or "")
            r = subprocess.run(cmd, shell=True, cwd=REPO_ROOT,
                               capture_output=True, text=True, timeout=600)
            print(f"  submit {g['id']}: exit {r.returncode}")
            print("  " + (r.stdout or r.stderr).strip()[:400])
            if r.returncode != 0:
                die(f"submit failed for gate '{g['id']}'")
            m = re.search(r"(?:job|run|build)[-_ ]?(?:id)?[:=]?\s*(\S+)",
                          r.stdout, re.IGNORECASE)
            job_id = job_id or (m.group(1) if m else r.stdout.strip().splitlines()[-1:] or [""])[0]
        jobs.append({"gate": g["id"], "job": job_id, "submittedAt": now(),
                     "commit": git("rev-parse", "HEAD")})

    if not jobs and args.job:
        jobs = [{"gate": "external", "job": args.job, "submittedAt": now(),
                 "commit": git("rev-parse", "HEAD")}]

    path = os.path.join(ev_dir, "async-jobs.json")
    with open(path, "w", encoding="utf-8") as f:
        json.dump({"task": tid, "jobs": jobs}, f, indent=2)
        f.write("\n")
    print(f"\nRecorded {len(jobs)} async job(s) -> {os.path.relpath(path, REPO_ROOT)}")
    print(f"Now run: python3 .agent/tools/task.py verify-submit "
          f"--job \"{jobs[0]['job'] if jobs else ''}\"")
    print("The loop may pick independent work. This task cannot reach done until")
    print("`harness.py gate poll` records a passing result.")


def cmd_gate_poll(cfg, args):
    """Reconcile async jobs into gate-summary.json."""
    tasks = []
    if args.task:
        tasks = [args.task]
    elif os.path.isdir(EVIDENCE):
        tasks = [d for d in sorted(os.listdir(EVIDENCE))
                 if os.path.exists(os.path.join(EVIDENCE, d, "async-jobs.json"))]
    if not tasks:
        print("No async jobs outstanding.")
        return

    any_pending = False
    for tid in tasks:
        ev_dir = os.path.join(EVIDENCE, tid)
        data = json.load(open(os.path.join(ev_dir, "async-jobs.json"), encoding="utf-8"))
        print(f"\nTASK {tid}")
        results = []
        for job in data.get("jobs", []):
            gate = next((g for g in select_gates(cfg, lane="outer")
                         if g["id"] == job["gate"]), None)
            if not gate or not gate.get("pollCommand"):
                print(f"  {job['gate']:<20} no pollCommand; reconcile manually")
                any_pending = True
                continue
            cmd = (gate["pollCommand"].replace("{JOB}", str(job.get("job", "")))
                   .replace("{TASK}", tid).replace("{EVIDENCE_DIR}", ev_dir))
            r = subprocess.run(cmd, shell=True, cwd=REPO_ROOT,
                               capture_output=True, text=True, timeout=900)
            out = (r.stdout + r.stderr).strip()
            if r.returncode == 75 or re.search(r"\b(pending|running|queued|in_progress)\b",
                                               out, re.IGNORECASE):
                print(f"  {job['gate']:<20} PENDING  {out.splitlines()[-1][:60] if out else ''}")
                any_pending = True
                continue
            ctx = {"repoRoot": REPO_ROOT, "baseRef": data.get("baseRef"),
                   "evidenceDir": ev_dir, "substitutions": {},
                   "stdout": r.stdout, "stderr": r.stderr, "returncode": r.returncode,
                   "artifact": (os.path.join(REPO_ROOT, gate["evidence"])
                                if gate.get("evidence") else None),
                   "args": gate.get("parserArgs") or {}}
            try:
                metrics = parsers.PARSERS[gate["parser"]](ctx)
                passed, details = eval_threshold(parse_threshold(gate["threshold"]), metrics)
                rec = {"id": gate["id"], "lane": "outer", "claim": gate.get("claim"),
                       "threshold": gate["threshold"],
                       "metrics": {k: v for k, v in metrics.items() if not k.startswith("_")},
                       "measured": ", ".join(f"{t.split()[0]}={a}" for t, a, _ in details),
                       "verdict": "pass" if passed else "fail", "blocking": True,
                       "job": job.get("job")}
                if not passed:
                    rec["remediation"] = _remediate(gate, metrics, details,
                                                    r.stdout, r.stderr)
                results.append(rec)
                print(f"  {job['gate']:<20} {rec['verdict'].upper():<5} {rec['measured']}")
                if not passed and rec.get("remediation"):
                    for line in str(rec["remediation"]).splitlines():
                        print(f"       {line}")
            except (parsers.ParseError, ValueError) as e:
                print(f"  {job['gate']:<20} ERROR  {e}")
                results.append({"id": gate["id"], "verdict": "error", "detail": str(e),
                                "blocking": True})

        if any_pending:
            print(f"  -> still pending; {tid} stays in verifying")
            continue
        _merge_summary(ev_dir, tid, cfg, results)
        os.remove(os.path.join(ev_dir, "async-jobs.json"))

    if not any_pending:
        print("\nAll async gates reconciled. Tasks whose gates passed can now proceed:")
        print("  python3 .agent/tools/task.py review")


def _merge_summary(ev_dir, tid, cfg, new_results):
    path = os.path.join(ev_dir, "gate-summary.json")
    summary = {"task": tid, "gates": []}
    if os.path.exists(path):
        try:
            summary = json.load(open(path, encoding="utf-8"))
        except (OSError, json.JSONDecodeError):
            pass
    by_id = {g.get("id"): g for g in summary.get("gates", [])}
    for r in new_results:
        by_id[r["id"]] = r
    summary["gates"] = list(by_id.values())
    summary["ts"] = now()
    summary["commit"] = git("rev-parse", "HEAD") or None
    summary["tier"] = cfg.get("tier")

    configured = {g["id"] for g in select_gates(cfg, lane="all", tier=cfg.get("tier"))}
    ran = set(by_id)
    pending = sorted(configured - ran)
    bad = [g for g in by_id.values()
           if g.get("verdict") in ("fail", "error") and g.get("blocking", True)]
    summary["gatesNotRun"] = pending
    summary["verdict"] = "fail" if bad else ("partial" if pending else "pass")
    summary["summary"] = (f"{sum(1 for g in by_id.values() if g.get('verdict') == 'pass')}/"
                          f"{len(by_id)} gates pass"
                          + (f", {len(pending)} not run" if pending else ""))
    with open(path, "w", encoding="utf-8") as f:
        json.dump(summary, f, indent=2)
        f.write("\n")
    print(f"  merged -> {os.path.relpath(path, REPO_ROOT)}  VERDICT: {summary['verdict'].upper()}")


# -- tier, ratchet, doctor ---------------------------------------------------

TIER_DESC = {
    "L0": ("Unverified", "Build and static analysis only. No test evidence exists. "
                         "The harness will label every task UNVERIFIED and require each "
                         "task to add characterization tests for the code it touches."),
    "L1": ("Diff-verified", "Changed lines are covered and the suite is green. Legacy "
                            "code is not held to a bar it could never meet."),
    "L2": ("Verified", "L1 plus full-suite green and dependency/secret scanning."),
    "L3": ("Hardened", "L2 plus mutation testing on changed code, plus the leak, perf, "
                       "and accessibility budgets your stack supports."),
}
TIER_NEEDS = {
    "L1": ["a test-execution gate (junit/trx parser)",
           "a diff-coverage gate (cobertura-diff or lcov-diff parser)"],
    "L2": ["a full-scope test gate", "a dependency-vulnerability gate (sarif parser)",
           "a secret-scanning gate"],
    "L3": ["a diff-scoped mutation gate (stryker parser)",
           "a leak or perf budget gate appropriate to the stack"],
}


def cmd_tier(cfg, args):
    tier = str(cfg.get("tier"))
    name, desc = TIER_DESC.get(tier, ("?", ""))
    print(f"TIER {tier} - {name}")
    print(f"  {desc}\n")
    gates = select_gates(cfg, lane="all")
    print(f"CURRENT GATES ({len(gates)})")
    for g in gates:
        print(f"  {g.get('lane'):<6} {g['id']:<24} {g.get('threshold')}")
    idx = TIERS.index(tier) if tier in TIERS else 0
    if idx + 1 < len(TIERS):
        nxt = TIERS[idx + 1]
        nname, ndesc = TIER_DESC[nxt]
        print(f"\nTO REACH {nxt} ({nname})")
        print(f"  {ndesc}")
        for need in TIER_NEEDS.get(nxt, []):
            print(f"  - {need}")
        print(f"\n  Then set 'tier: {nxt}' in harness.yaml and run: harness.py lock")
    else:
        print("\nAt the highest tier. Keep the ratchet moving:  harness.py ratchet")
    lock = load_lock()
    floors = (lock or {}).get("ratchetFloors") or {}
    if floors:
        print(f"\nRATCHET FLOORS ({len(floors)}) - thresholds may not go below these")
        for gid, f in floors.items():
            extra = f"  (lowered from {_num(f['loweredFrom'])}: {f.get('reason')})" \
                if "loweredFrom" in f else ""
            print(f"  {gid:<24} {f['metric']} {f['op']} {_num(f['value'])}"
                  f"  since {str(f.get('since', ''))[:10]}{extra}")


def cmd_ratchet(cfg, args):
    """Propose raising thresholds to what the project already achieves."""
    proposals = []
    for g in select_gates(cfg, lane="all"):
        if not g.get("ratchet"):
            continue
        found = None
        for tid in (sorted(os.listdir(EVIDENCE)) if os.path.isdir(EVIDENCE) else []):
            p = os.path.join(EVIDENCE, tid, "gate-summary.json")
            if not os.path.exists(p):
                continue
            try:
                s = json.load(open(p, encoding="utf-8"))
            except (OSError, json.JSONDecodeError):
                continue
            for rec in s.get("gates", []):
                if rec.get("id") == g["id"] and rec.get("verdict") == "pass":
                    found = rec
        if not found:
            continue
        try:
            terms = parse_threshold(g["threshold"])
        except ValueError:
            continue
        for metric, op, val in terms:
            actual = (found.get("metrics") or {}).get(metric)
            if actual is None or op not in (">=", ">"):
                continue
            headroom = float(actual) - val
            step = 0.05 if val <= 1.0 else 5.0
            if headroom >= step:
                proposals.append((g["id"], metric, op, val,
                                  round(min(float(actual), val + step), 4)))

    if not proposals:
        print("No ratchet proposals: no gate is comfortably exceeding its threshold yet.")
        print("Run gates on a few tasks first, then re-check.")
        return
    print("RATCHET PROPOSALS (raise the bar to what you already achieve)\n")
    for gid, metric, op, old, new in proposals:
        print(f"  {gid:<24} {metric} {op} {_num(old)}  ->  {_num(new)}")
    if not args.apply:
        print("\nRe-run with --apply to write these into harness.yaml, then: harness.py lock")
        return
    text = open(CONFIG, encoding="utf-8").read()
    for gid, metric, op, old, new in proposals:
        text = re.sub(rf"({re.escape(metric)}\s*{re.escape(op)}\s*){re.escape(_num(old))}\b",
                      rf"\g<1>{_num(new)}", text, count=1)
    open(CONFIG, "w", encoding="utf-8").write(text)
    print(f"\nApplied {len(proposals)} change(s) to harness.yaml. Now run: harness.py lock")


def cmd_doctor(cfg, args):
    print("=" * 72)
    print("HARNESS DOCTOR")
    print("=" * 72)
    errors, warnings = validate(cfg, verbose=True)
    lock = load_lock()
    problems = list(errors)

    print("\n-- drift " + "-" * 63)
    if not lock:
        print("WARN  no harness.lock; cannot detect drift. Run: harness.py lock")
    else:
        fp = repo_fingerprint()
        if fp != lock.get("fingerprint"):
            problems.append("repo fingerprint changed since lock")
            print(f"FAIL  fingerprint {lock.get('fingerprint')} -> {fp}")
            old = set(lock.get("manifests") or [])
            new = set(find_manifests())
            for m in sorted(new - old):
                print(f"        + new manifest: {m}")
            for m in sorted(old - new):
                print(f"        - removed:      {m}")
            olddeps, newdeps = set(), set()
            for m in old & new:
                olddeps |= dependency_names(os.path.join(REPO_ROOT, m))
            for m in new:
                newdeps |= dependency_names(os.path.join(REPO_ROOT, m))
            added = sorted(newdeps - olddeps)
            if added:
                print(f"        + new dependencies: {', '.join(added[:12])}"
                      f"{' ...' if len(added) > 12 else ''}")
                sf = [d for d in added if "syncfusion" in d.lower()]
                if sf:
                    print(f"        ! Syncfusion packages added: {', '.join(sf[:6])}")
                    print("          Re-run harness-creator: component knowledge and the "
                          "license gate need updating.")
            print("      -> re-run the harness-creator skill in upgrade mode")
        else:
            print(f"OK    fingerprint matches ({fp})")

        if lock.get("configSha256") and lock["configSha256"] != sha256_file(CONFIG):
            print("WARN  harness.yaml changed since lock. Run: harness.py lock")
        cfg_ids = {g.get("id") for g in (cfg.get("gates") or []) if isinstance(g, dict)}
        lock_ids = set(lock.get("gateIds") or [])
        for gid in sorted(cfg_ids - lock_ids):
            print(f"WARN  gate '{gid}' is not in the lock (added since). Run: harness.py lock")
        for gid in sorted(lock_ids - cfg_ids):
            print(f"WARN  gate '{gid}' is locked but no longer configured (removed)")

    print("\n-- tools " + "-" * 63)
    checked = set()
    for g in select_gates(cfg, lane="all"):
        name = g.get("tool") or g["id"]
        if name in checked:
            continue
        checked.add(name)
        binary = shlex.split(g.get("command", ""))[0] if g.get("command") else None
        found = _which(binary) if binary else None
        if binary and not found:
            problems.append(f"gate '{g['id']}': '{binary}' not on PATH")
            print(f"FAIL  {name:<22} '{binary}' not found on PATH")
            if g.get("installHint"):
                print(f"        install: {g['installHint']}")
            if g.get("license"):
                print(f"        licence: {g['license']}")
        else:
            locked = ((lock or {}).get("tools") or {}).get(name) or {}
            ver = locked.get("version", "")
            print(f"OK    {name:<22} {binary or ''}  {ver}")

    print("\n-- knowledge " + "-" * 59)
    if not os.path.isdir(KNOWLEDGE):
        print("WARN  no .agent/knowledge/. The build agent has no sourced framework rules,")
        print("      so it will fall back to model memory - the failure mode this harness exists")
        print("      to prevent. Re-run harness-creator to gather them.")
    else:
        locked_k = (lock or {}).get("knowledge") or {}
        files = []
        for root, _, fs in os.walk(KNOWLEDGE):
            files += [os.path.relpath(os.path.join(root, f), AGENT_DIR) for f in fs]
        for rel in sorted(files):
            p = os.path.join(AGENT_DIR, rel)
            cur = sha256_file(p)
            rec = locked_k.get(rel)
            srcs = _extract_sources(p)
            if rec is None:
                print(f"WARN  {rel}: not in lock (added since). Run: harness.py lock")
            elif rec.get("sha256") != cur:
                print(f"WARN  {rel}: changed since lock - re-verify citations, then re-lock")
            if not srcs:
                print(f"WARN  {rel}: no 'Source:' citations. Uncited rules are model memory,")
                print("        not knowledge. Add Source: <url> (retrieved YYYY-MM-DD) lines.")
            else:
                print(f"OK    {rel}: {len(srcs)} cited source(s)")
        for rel in sorted(set(locked_k) - set(files)):
            print(f"WARN  {rel}: in lock but missing on disk")

    print("\n-- task state " + "-" * 58)
    tp = os.path.join(BIN_DIR, "task.py")
    if os.path.exists(tp):
        r = subprocess.run([sys.executable, tp, "doctor"], capture_output=True, text=True)
        print(r.stdout.strip() or r.stderr.strip())
        if r.returncode != 0:
            problems.append("task state is inconsistent")
    else:
        print("WARN  task.py missing")

    print("\n" + "=" * 72)
    if problems:
        print(f"NOT HEALTHY - {len(problems)} problem(s) must be fixed:")
        for p in problems:
            print(f"  - {p}")
        sys.exit(1)
    print(f"HEALTHY - tier {cfg.get('tier')}, {len(select_gates(cfg, lane='all'))} gates, "
          f"{len(warnings)} warning(s)")


def _which(binary):
    if not binary:
        return None
    from shutil import which
    return which(binary)


def cmd_explain(cfg, args):
    """Show which tool is of record for a claim - the anti-hallucination lookup."""
    q = " ".join(args.claim).lower()
    hits = []
    for g in select_gates(cfg, lane="all"):
        blob = f"{g.get('id')} {g.get('claim')} {g.get('tool')} {g.get('rationale')}".lower()
        if any(w in blob for w in q.split()):
            hits.append(g)
    if not hits:
        print(f"No gate covers {q!r}.\n")
        print("That means this claim is NOT verifiable in this harness, so an agent must")
        print("not assert it as fact. Two valid responses:")
        print("  1. Add a gate with a tool of record (see references/tools-of-record.md)")
        print("  2. State the claim as unverified in the task ## Log")
        sys.exit(1)
    for g in hits:
        print(f"CLAIM      {g.get('claim')}")
        print(f"GATE       {g['id']}  ({g.get('lane')} lane)")
        print(f"TOOL       {g.get('tool', '?')}"
              + (f"   licence: {g['license']}" if g.get("license") else ""))
        print(f"COMMAND    {g.get('command')}")
        print(f"EVIDENCE   {g.get('evidence', '(stdout)')}")
        print(f"THRESHOLD  {g.get('threshold')}")
        if g.get("docs"):
            print(f"DOCS       {g['docs']}")
        print()


# -- control plane -----------------------------------------------------------

FM = re.compile(r"\A---\s*\n(.*?)\n---\s*\n", re.S)


def cp_files():
    """Every control-plane file, repo-relative to .agent/."""
    out = []
    for d in CP_DIRS:
        root = os.path.join(AGENT_DIR, d)
        if not os.path.isdir(root):
            continue
        for f in sorted(os.listdir(root)):
            if f.endswith(".md"):
                out.append(os.path.join(d, f))
    return out


def cp_frontmatter(rel):
    """Parse the YAML frontmatter of a control-plane file."""
    path = os.path.join(AGENT_DIR, rel)
    try:
        text = open(path, encoding="utf-8").read()
    except OSError:
        return None
    m = FM.match(text)
    if not m:
        return {}
    try:
        return hyaml.loads(m.group(1)) or {}
    except hyaml.HYamlError:
        return {}


def cmd_cp_lock(cfg, args):
    """Write HARNESS-LOCK.json: SHA-256 of every control-plane file."""
    files = cp_files()
    if not files:
        die("no control plane found. Re-run the harness-creator skill to generate it.")
    entries = {}
    for rel in files:
        fm = cp_frontmatter(rel) or {}
        entries[rel] = {
            "sha256": sha256_file(os.path.join(AGENT_DIR, rel)),
            "kind": fm.get("kind"),
            "id": fm.get("id"),
            "version": fm.get("version"),
        }
    lock = {
        "lockVersion": 1,
        "generatedAt": now(),
        "contractVersion": CONTRACT_VERSION,
        "counts": {d: sum(1 for r in files if r.startswith(d + os.sep)) for d in CP_DIRS},
        "files": entries,
    }
    with open(CP_LOCK, "w", encoding="utf-8") as f:
        json.dump(lock, f, indent=2)
        f.write("\n")
    print(f"Wrote {os.path.relpath(CP_LOCK, REPO_ROOT)}")
    for d, n in lock["counts"].items():
        if n:
            print(f"  {d:<12} {n}")
    print(f"  {'total':<12} {len(files)} files hashed")


def cmd_verify(cfg, args):
    """Control-plane integrity + cross-reference graph. Runs inside the gate.

    This is what stops an agent quietly relaxing a policy the way it would
    otherwise relax a threshold. A control plane nothing verifies is a
    suggestion.
    """
    problems, warnings = [], []
    files = cp_files()

    print("=" * 72)
    print("CONTROL PLANE VERIFY")
    print("=" * 72)

    if not files:
        print("FAIL  no control plane at .agent/{workflows,agents,policies,...}")
        print("      Re-run the harness-creator skill to generate it.")
        sys.exit(1)

    # -- integrity -----------------------------------------------------------
    print("\n-- integrity " + "-" * 58)
    lock = None
    if os.path.exists(CP_LOCK):
        try:
            lock = json.load(open(CP_LOCK, encoding="utf-8"))
        except (OSError, json.JSONDecodeError) as e:
            problems.append(f"HARNESS-LOCK.json unreadable: {e}")
    if lock is None:
        warnings.append("no HARNESS-LOCK.json - run: harness.py cp-lock")
        print("WARN  no HARNESS-LOCK.json; integrity not verified")
    else:
        locked = lock.get("files") or {}
        changed = [r for r in files
                   if r in locked and locked[r]["sha256"] != sha256_file(os.path.join(AGENT_DIR, r))]
        added = [r for r in files if r not in locked]
        removed = [r for r in locked if r not in files]
        for r in changed:
            problems.append(f"{r} MODIFIED since lock")
            print(f"FAIL  {r} modified since lock")
        for r in added:
            warnings.append(f"{r} added since lock")
            print(f"WARN  {r} added since lock")
        for r in removed:
            problems.append(f"{r} REMOVED since lock")
            print(f"FAIL  {r} removed since lock")
        if not (changed or added or removed):
            print(f"OK    all {len(files)} control-plane files match HARNESS-LOCK.json")
        else:
            print("      A control-plane change is a deliberate act: review the diff,")
            print("      then re-lock with: harness.py cp-lock")

    # -- graph ---------------------------------------------------------------
    print("\n-- cross-references " + "-" * 51)
    by_kind = {}
    fms = {}
    for rel in files:
        fm = cp_frontmatter(rel)
        if fm is None:
            problems.append(f"{rel} unreadable")
            continue
        if not fm:
            problems.append(f"{rel} has no frontmatter (id/kind required)")
            continue
        fms[rel] = fm
        kind, fid = fm.get("kind"), fm.get("id")
        if not kind or not fid:
            problems.append(f"{rel} frontmatter missing id or kind")
            continue
        by_kind.setdefault(kind, {})[fid] = rel

    skill_ids = {g.get("id") for g in (cfg.get("gates") or []) if isinstance(g, dict)}
    skill_ids |= {s.get("id") for s in (cfg.get("skills") or []) if isinstance(s, dict)}

    def resolve(rel, field, values, kind, extra=None):
        pool = set((by_kind.get(kind) or {}).keys()) | set(extra or [])
        for v in values or []:
            if v in ("all", "none", None, ""):
                continue
            if v not in pool:
                problems.append(f"{rel}: {field} -> '{v}' does not resolve to a {kind}")

    for rel, fm in fms.items():
        resolve(rel, "invokes", fm.get("invokes"), "agent")
        resolve(rel, "requires", fm.get("requires"), "checklist")
        resolve(rel, "binding", fm.get("binding"), "policy")
        for sid in fm.get("uses") or []:
            if sid not in skill_ids:
                problems.append(f"{rel}: uses -> skill '{sid}' is not in harness.yaml")
        for cid in fm.get("usedBy") or []:
            if cid not in (by_kind.get("workflow") or {}) and cid not in (by_kind.get("agent") or {}):
                warnings.append(f"{rel}: usedBy -> '{cid}' is neither a workflow nor an agent")

    print(f"OK    {len(fms)} files parsed; "
          f"{sum(len(v) for v in by_kind.values())} ids registered")
    for kind in ("workflow", "agent", "policy", "checklist", "template"):
        n = len(by_kind.get(kind) or {})
        if n:
            label = {"policy": "policies"}.get(kind, kind + "s")
            print(f"      {label:<12} {n}")

    # -- orphans -------------------------------------------------------------
    print("\n-- orphans " + "-" * 60)
    invoked, required, bound = set(), set(), set()
    for fm in fms.values():
        invoked |= set(fm.get("invokes") or [])
        required |= set(fm.get("requires") or [])
        bound |= set(fm.get("binding") or [])

    for aid in sorted((by_kind.get("agent") or {})):
        if aid not in invoked:
            warnings.append(f"agent '{aid}' is invoked by no workflow")
    for cid in sorted((by_kind.get("checklist") or {})):
        fm = fms.get((by_kind.get("checklist") or {}).get(cid), {})
        if cid not in required and not fm.get("usedBy"):
            warnings.append(f"checklist '{cid}' is required by no workflow")
    for pid in sorted((by_kind.get("policy") or {})):
        if pid not in bound:
            warnings.append(f"policy '{pid}' binds to nothing")

    orphan_warns = [w for w in warnings if "is invoked by no" in w
                    or "is required by no" in w or "binds to nothing" in w]
    if orphan_warns:
        for w in orphan_warns:
            print(f"WARN  {w}")
        print("      An orphan is how a control plane looks complete while doing nothing.")
    else:
        print("OK    no orphans - every agent, checklist and policy is reachable")

    # -- routing coverage ----------------------------------------------------
    print("\n-- routing " + "-" * 60)
    task_types = ["feature", "bugfix", "refactor", "api-change", "security",
                  "performance", "dependency-upgrade", "test-backfill", "incident"]
    wf = by_kind.get("workflow") or {}
    missing = [t for t in task_types if t not in wf]
    if missing:
        for t in missing:
            problems.append(f"no workflow for task type '{t}' - task-loop cannot route it")
            print(f"FAIL  no workflow for task type '{t}'")
    else:
        print(f"OK    all {len(task_types)} task types routable")
    for essential in ("task-loop", "escalation", "session-handoff", "release", "milestone"):
        if essential not in wf:
            problems.append(f"missing essential workflow '{essential}'")
            print(f"FAIL  missing essential workflow '{essential}'")

    # -- state files ---------------------------------------------------------
    print("\n-- state files " + "-" * 56)
    for name, why in (("PROJECT-STATE.md", "a fresh session has nowhere to read state from"),
                      ("DECISIONS-REQUIRED.md", "the agent has nowhere to park a decision, so it will block instead")):
        if os.path.exists(os.path.join(AGENT_DIR, name)):
            print(f"OK    {name}")
        else:
            problems.append(f"{name} missing - {why}")
            print(f"FAIL  {name} missing - {why}")

    print("\n" + "=" * 72)
    other = [w for w in warnings if w not in orphan_warns]
    for w in other:
        print(f"WARN  {w}")
    if problems:
        print(f"CONTROL PLANE NOT VERIFIED - {len(problems)} problem(s):")
        for p in problems:
            print(f"  - {p}")
        sys.exit(1)
    print(f"CONTROL PLANE VERIFIED - {len(files)} files, {len(warnings)} warning(s)")


def cmd_skill_list(cfg, args):
    """Every executable capability: skills and the thresholded subset (gates)."""
    gates = {g.get("id"): g for g in (cfg.get("gates") or []) if isinstance(g, dict)}
    skills = {s.get("id"): s for s in (cfg.get("skills") or []) if isinstance(s, dict)}
    print(f"SKILLS  {len(skills) + len(gates)} total "
          f"({len(gates)} are gates - a gate is a skill with a threshold)\n")
    for sid in sorted(set(skills) | set(gates)):
        item = gates.get(sid) or skills[sid]
        tag = "GATE " if sid in gates else "skill"
        print(f"  {tag} {sid}")
        print(f"        {item.get('claim', '(no claim)')}")
        print(f"        $ {item.get('command', '(none)')}")
        if sid in gates:
            print(f"        threshold: {item.get('threshold')}")
        if item.get("usedBy"):
            print(f"        usedBy: {', '.join(item['usedBy'])}")


# -- APM export --------------------------------------------------------------

# .agent/ -> .apm/ primitive mapping. Schema and package anatomy retrieved
# 2026-09-01 from microsoft.github.io/apm. See references/apm-export.md.
APM_MAP = {
    "policies":   ("instructions", "{id}.md"),
    "agents":     ("agents", "{id}.agent.md"),
    "workflows":  ("prompts", "{id}.prompt.md"),
    "checklists": ("context", "checklists/{id}.md"),
    "templates":  ("context", "templates/{id}.md"),
    "skills":     ("context", "skills/{id}.md"),
}
# Per-repository state. Never packaged: it would carry one project's tasks into another.
APM_EXCLUDE = ["tasks", "evidence", "archive", "PROJECT-STATE.md",
               "DECISIONS-REQUIRED.md", "harness.lock", "progress.md"]


def cmd_apm_export(cfg, args):
    import shutil as _sh
    out = os.path.join(REPO_ROOT, args.out)
    apm_dir = os.path.join(out, ".apm")
    if os.path.exists(apm_dir):
        if not args.force:
            die(f"{args.out}/.apm already exists. Re-run with --force to overwrite.")
        _sh.rmtree(apm_dir)

    errs, _ = validate(cfg, verbose=False)
    if errs and not args.force:
        print("Refusing to export an invalid contract:")
        for e in errs:
            print(f"  FAIL  {e}")
        sys.exit(1)

    print(f"APM EXPORT  {args.name} v{args.version}  -> {args.out}/")
    print()

    # Pass 1: build the full rename map before writing anything, so
    # cross-references can be rewritten rather than merely reported.
    plan = []
    renames = {}
    for src_dir, (dest_dir, pattern) in APM_MAP.items():
        root = os.path.join(AGENT_DIR, src_dir)
        if not os.path.isdir(root):
            continue
        for f in sorted(os.listdir(root)):
            if not f.endswith(".md"):
                continue
            rel = os.path.join(src_dir, f)
            fm = cp_frontmatter(rel) or {}
            fid = fm.get("id") or os.path.splitext(f)[0]
            dest_rel = os.path.join(dest_dir, pattern.format(id=fid))
            plan.append((src_dir, rel, dest_rel, fm))
            renames[rel] = dest_rel
            # also map the id-based form, since files cite `policies/<id>.md`
            renames[os.path.join(src_dir, fid + ".md")] = dest_rel

    # Pass 2: write, rewriting every cross-reference to its APM path.
    copied = []
    for src_dir, rel, dest_rel, fm in plan:
        dest = os.path.join(apm_dir, dest_rel)
        os.makedirs(os.path.dirname(dest), exist_ok=True)
        text = open(os.path.join(AGENT_DIR, rel), encoding="utf-8").read()
        text = _apm_rewrite_refs(text, renames)
        # A policy's appliesTo becomes an instruction glob - APM instructions
        # attach to file globs, which is stronger than a policy nothing points at.
        if src_dir == "policies":
            globs = fm.get("appliesTo") or ["all"]
            pat = "**" if globs in (["all"], "all") else ",".join(map(str, globs))
            text = re.sub(r"\A---\s*\n", f"---\napplyTo: \"{pat}\"\n", text, count=1)
        open(dest, "w", encoding="utf-8").write(text)
        copied.append(dest_rel)

    # the harness machinery ships as one skill with siblings
    skill_root = os.path.join(apm_dir, "skills", "harness")
    os.makedirs(skill_root, exist_ok=True)
    for sub in ("bin",):
        src = os.path.join(AGENT_DIR, sub)
        if os.path.isdir(src):
            _sh.copytree(src, os.path.join(skill_root, sub), dirs_exist_ok=True)
            copied.append(f"skills/harness/{sub}/")
    for f in ("harness.yaml", "HARNESS-LOCK.json"):
        src = os.path.join(AGENT_DIR, f)
        if os.path.exists(src):
            _sh.copy2(src, os.path.join(skill_root, f))
            copied.append(f"skills/harness/{f}")
    scripts_src = os.path.join(REPO_ROOT, "scripts")
    if os.path.isdir(scripts_src):
        _sh.copytree(scripts_src, os.path.join(skill_root, "scripts"), dirs_exist_ok=True)
        copied.append("skills/harness/scripts/")
    for d in ("knowledge",):
        src = os.path.join(AGENT_DIR, d)
        if os.path.isdir(src):
            _sh.copytree(src, os.path.join(apm_dir, "context", d), dirs_exist_ok=True)
            copied.append(f"context/{d}/")
    for f in ("design.md", "project-context.md", "instructions.md"):
        src = os.path.join(AGENT_DIR, f)
        if os.path.exists(src):
            os.makedirs(os.path.join(apm_dir, "context"), exist_ok=True)
            _sh.copy2(src, os.path.join(apm_dir, "context", f))
            copied.append(f"context/{f}")

    open(os.path.join(skill_root, "SKILL.md"), "w", encoding="utf-8").write(
        _apm_skill_md(cfg, args))

    # -- apm.yml -------------------------------------------------------------
    mcp = []
    for m in (cfg.get("mcp") or []):
        if isinstance(m, dict) and m.get("command"):
            entry = {"name": m.get("id") or m.get("name"), "registry": False,
                     "transport": m.get("transport", "stdio"),
                     "command": m["command"]}
            if m.get("args"):
                entry["args"] = m["args"]
            if m.get("keyEnv"):
                entry["env"] = {m["keyEnv"]: "${env:" + m["keyEnv"] + "}"}
            mcp.append(entry)

    manifest = {
        "name": args.name,
        "version": args.version,
        "description": args.description or
            f"Verification harness and control plane for {cfg.get('profile', 'this stack')}",
        "type": "hybrid",
        "targets": [t.strip() for t in args.targets.split(",")],
        "includes": "auto",
        "scripts": {
            "doctor": "python3 .apm/skills/harness/tools/harness.py doctor",
            "verify": "python3 .apm/skills/harness/tools/harness.py verify",
            "gate": "python3 .apm/skills/harness/tools/harness.py gate run --lane {lane}",
            "tier": "python3 .apm/skills/harness/tools/harness.py tier",
            "next": "python3 .apm/skills/harness/tools/task.py next",
        },
        "compilation": {
            "target": "all",
            "strategy": "distributed",
            "exclude": ["apm_modules/**", ".agent/evidence/**", ".agent/tasks/**"],
        },
        # block, not warn: a harness installed without its knowledge sources is
        # precisely the failure this system exists to prevent.
        "policy": {"fetch_failure_default": "block"},
    }
    if args.license:
        manifest["license"] = args.license
    if args.author:
        manifest["author"] = args.author
    if mcp:
        manifest["dependencies"] = {"mcp": mcp}

    header = ("# Generated by harness.py apm-export.\n"
              "# APM schema retrieved 2026-09-01 from microsoft.github.io/apm.\n"
              "# Per-repository state (tasks, evidence, harness.lock, PROJECT-STATE)\n"
              "# is deliberately NOT packaged - see references/apm-export.md.\n")
    open(os.path.join(out, "apm.yml"), "w", encoding="utf-8").write(
        header + hyaml.dumps(manifest) + "\n")

    # -- report --------------------------------------------------------------
    groups = {}
    for c in copied:
        top = c.split(os.sep)[0] if os.sep in c else c
        if c.startswith("context" + os.sep):
            parts = c.split(os.sep)
            top = os.sep.join(parts[:2]) if len(parts) > 2 else "context"
        groups[top] = groups.get(top, 0) + 1
    for d in sorted(groups):
        label = d if d.endswith("/") else d + "/"
        print(f"  .apm/{label:<30} {groups[d]}")
    print(f"\n  apm.yml                          targets: {', '.join(manifest['targets'])}")
    if mcp:
        print(f"  {'':<32} mcp: {', '.join(m['name'] for m in mcp)}")

    print("\nEXCLUDED (per-repository state, not configuration)")
    for e in APM_EXCLUDE:
        if os.path.exists(os.path.join(AGENT_DIR, e)):
            print(f"  {e}")
    print("  -> the consuming repo runs 'harness.py lock' to establish its own tool")
    print("     versions, fingerprint, ratchet floors and tier.")

    dangling = _apm_check_refs(apm_dir, renames)
    print()
    if dangling:
        print(f"WARN  {len(dangling)} cross-reference(s) may not resolve at the new paths:")
        for d in dangling[:12]:
            print(f"  {d}")
        print("  Review before publishing.")
    else:
        print("OK    cross-references resolve at APM paths")

    print(f"\nNext:  cd {args.out} && apm install && apm compile")
    print("       then in the consuming repo: harness.py doctor && harness.py lock")


def _apm_skill_md(cfg, args):
    return f"""---
name: harness
description: >
  Verification harness for {cfg.get('profile', 'this project')}: evidence-backed gates,
  tiers with a ratchet, and a locked control plane. A task is done when tools say so,
  not when an agent says so.
---

# harness

Machinery for the {args.name} control plane. Companion primitives live in
`.apm/instructions/` (policies), `.apm/agents/`, `.apm/prompts/` (workflows) and
`.apm/context/`.

## Commands

```bash
python3 tools/harness.py doctor        # tools, drift, knowledge citations
python3 tools/harness.py verify        # control-plane integrity and cross-references
python3 tools/harness.py gate run --lane inner --scope diff
python3 tools/harness.py tier          # current tier, next-tier requirements
python3 tools/harness.py explain "<claim>"
python3 tools/task.py next
```

## First run in a new repository

```bash
python3 tools/harness.py doctor        # confirm the tools exist HERE
python3 tools/harness.py lock          # this repo's versions, fingerprint, floors
python3 tools/harness.py cp-lock       # hash the control plane as installed
```

`harness.lock` is per-repository and is deliberately not packaged. Carrying another
repo's lock imports its ratchet floors and reports drift immediately.

## The rule

For any claim a tool can settle, the agent may not assert the conclusion. It runs the
tool and cites the evidence. `task.py done` refuses without a passing
`gate-summary.json` whose commit matches HEAD.
"""


def _apm_rewrite_refs(text, renames):
    """Rewrite `policies/x.md` -> `instructions/x.md` etc. for APM paths.

    Without this the packaged control plane is full of references to paths that
    no longer exist, which is the same dangling-reference problem `verify`
    exists to catch - just relocated.
    """
    def sub(m):
        ref = m.group(1)
        return "`" + renames.get(ref, ref) + "`"
    return re.sub(r"`((?:workflows|agents|policies|checklists|templates|skills)/[\w.-]+\.md)`",
                  sub, text)


def _apm_check_refs(apm_dir, renames):
    """Flag cross-references that pointed at old .agent/ paths."""
    valid = set()
    for root, _, files in os.walk(apm_dir):
        for f in files:
            valid.add(os.path.relpath(os.path.join(root, f), apm_dir))
    dangling = []
    for root, _, files in os.walk(apm_dir):
        for f in files:
            if not f.endswith(".md"):
                continue
            path = os.path.join(root, f)
            try:
                text = open(path, encoding="utf-8").read()
            except OSError:
                continue
            for m in re.findall(r"`((?:workflows|agents|policies|checklists|templates|"
                                r"instructions|prompts|context)/[\w./-]+\.md)`", text):
                if m not in valid:
                    dangling.append(f"{os.path.relpath(path, apm_dir)} -> {m}")
    return dangling


# -- cli ---------------------------------------------------------------------

def main():
    p = argparse.ArgumentParser(prog="harness.py", description=__doc__.split("\n")[0])
    sub = p.add_subparsers(dest="cmd", required=True)

    sub.add_parser("validate", help="check harness.yaml against the contract")

    sp = sub.add_parser("lock", help="resolve tools and write harness.lock")
    sp.add_argument("--force", action="store_true", help="lock even if the contract is invalid")
    sp.add_argument("--lower-floor", metavar="GATE_ID",
                    help="deliberately lower a ratchet floor (requires --reason)")
    sp.add_argument("--reason", help="justification, recorded in the lock")

    sub.add_parser("doctor", help="validate + drift detection + remediation")
    sub.add_parser("verify", help="control-plane integrity, cross-refs, orphans, routing")
    sub.add_parser("cp-lock", help="hash every control-plane file into HARNESS-LOCK.json")

    ap = sub.add_parser("apm-export",
                        help="package the harness as a Microsoft APM package")
    ap.add_argument("--name", required=True, help="APM package name")
    ap.add_argument("--version", default="1.0.0")
    ap.add_argument("--out", default="apm-package", help="output directory")
    ap.add_argument("--targets",
                    default="claude,copilot,cursor,codex,windsurf,agent-skills",
                    help="comma-separated APM targets")
    ap.add_argument("--description")
    ap.add_argument("--author")
    ap.add_argument("--license", default="MIT")
    ap.add_argument("--force", action="store_true")

    ss = sub.add_parser("skill", help="skill operations")
    ssub = ss.add_subparsers(dest="skillcmd", required=True)
    ssub.add_parser("list", help="every skill and gate")
    sub.add_parser("tier", help="show tier and next-tier requirements")

    sp = sub.add_parser("ratchet", help="propose raising thresholds")
    sp.add_argument("--apply", action="store_true")

    sp = sub.add_parser("explain", help="show the tool of record for a claim")
    sp.add_argument("claim", nargs="+")

    gp = sub.add_parser("gate", help="gate operations")
    gsub = gp.add_subparsers(dest="gatecmd", required=True)

    gl = gsub.add_parser("list", help="show configured gates")
    gl.add_argument("--lane", choices=LANES + ["all"], default="all")

    gr = gsub.add_parser("run", help="run gates and write evidence")
    gr.add_argument("--lane", choices=LANES + ["all"], default="inner")
    gr.add_argument("--scope", choices=["diff", "full"], default="diff")
    gr.add_argument("--task", help="task id (default: the active task)")
    gr.add_argument("--gate", action="append", help="run only this gate id (repeatable)")
    gr.add_argument("--base", help="base ref for diff-scoped gates")
    gr.add_argument("--keep-going", action="store_true",
                    help="run all gates even after a blocking failure")

    gsm = gsub.add_parser("submit", help="submit async outer-lane gates")
    gsm.add_argument("--task")
    gsm.add_argument("--job", help="externally-obtained job id")
    gsm.add_argument("--base")

    gpo = gsub.add_parser("poll", help="reconcile async outer-lane gates")
    gpo.add_argument("--task")

    args = p.parse_args()
    cfg = load_config(required=args.cmd != "validate" or True)

    if args.cmd == "validate":
        errs, _ = validate(cfg)
        sys.exit(1 if errs else 0)
    if args.cmd == "lock":
        return cmd_lock(cfg, args)
    if args.cmd == "doctor":
        return cmd_doctor(cfg, args)
    if args.cmd == "verify":
        return cmd_verify(cfg, args)
    if args.cmd == "cp-lock":
        return cmd_cp_lock(cfg, args)
    if args.cmd == "apm-export":
        return cmd_apm_export(cfg, args)
    if args.cmd == "skill":
        return cmd_skill_list(cfg, args)
    if args.cmd == "tier":
        return cmd_tier(cfg, args)
    if args.cmd == "ratchet":
        return cmd_ratchet(cfg, args)
    if args.cmd == "explain":
        return cmd_explain(cfg, args)
    if args.cmd == "gate":
        return {"list": cmd_gate_list, "run": cmd_gate_run,
                "submit": cmd_gate_submit, "poll": cmd_gate_poll}[args.gatecmd](cfg, args)


if __name__ == "__main__":
    main()

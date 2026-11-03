#!/usr/bin/env python3
"""Evidence parsers for the agent harness.

Each parser turns a tool's real output into named numeric metrics. Thresholds in
harness.yaml are then evaluated against those metrics. This module is the reason
the harness can refuse an agent's claim: the number comes from the tool, never
from prose.

A parser signature is:  parse(ctx) -> dict[str, float|int]
where ctx carries the completed process result and paths to artifacts.

Adding a parser: implement it, register it in PARSERS, and document the metric
names it emits so harness.yaml thresholds can reference them.
"""

import json
import os
import re
import subprocess
import xml.etree.ElementTree as ET
from collections import defaultdict


class ParseError(Exception):
    pass


# -- helpers -----------------------------------------------------------------

def _localname(tag):
    return tag.rsplit("}", 1)[-1] if "}" in tag else tag


def _iter(root, name):
    for el in root.iter():
        if _localname(el.tag) == name:
            yield el


def _read(path):
    if not os.path.exists(path):
        raise ParseError(f"expected artifact not found: {path}")
    with open(path, "r", encoding="utf-8", errors="replace") as f:
        return f.read()


def _load_json(path):
    try:
        return json.loads(_read(path))
    except json.JSONDecodeError as e:
        raise ParseError(f"{path} is not valid JSON: {e}")


def _parse_xml(path):
    try:
        return ET.parse(path).getroot()
    except (ET.ParseError, OSError) as e:
        raise ParseError(f"{path} is not parseable XML: {e}")


def _norm(path, repo_root):
    """Normalise a coverage-report path to a repo-relative posix path."""
    p = path.replace("\\", "/")
    root = repo_root.replace("\\", "/").rstrip("/")
    if p.startswith(root + "/"):
        p = p[len(root) + 1:]
    return p.lstrip("./")


# -- changed-line extraction (the basis of every diff-scoped gate) -----------

def changed_lines(repo_root, base_ref, head_ref="HEAD", include_untracked=True):
    """Map repo-relative path -> set of added/modified line numbers in HEAD.

    Uses -U0 so hunk headers bound exactly the changed lines. Deleted lines are
    intentionally excluded: you cannot cover a line that no longer exists.
    """
    out = defaultdict(set)
    if not base_ref:
        return out

    cmd = ["git", "-C", repo_root, "diff", "-U0", "--no-color",
           "--diff-filter=ACMR", f"{base_ref}..{head_ref}"]
    try:
        r = subprocess.run(cmd, capture_output=True, text=True, timeout=120)
        if r.returncode != 0:
            raise ParseError(f"git diff failed: {r.stderr.strip()}")
        diff = r.stdout
    except (OSError, subprocess.SubprocessError) as e:
        raise ParseError(f"could not run git diff: {e}")

    if include_untracked:
        # Uncommitted work counts too: gates run before the commit in many flows.
        try:
            r2 = subprocess.run(["git", "-C", repo_root, "diff", "-U0", "--no-color",
                                 "--diff-filter=ACMR", "HEAD"],
                                capture_output=True, text=True, timeout=120)
            if r2.returncode == 0:
                diff += "\n" + r2.stdout
        except (OSError, subprocess.SubprocessError):
            pass

    current = None
    hunk_re = re.compile(r"^@@ -\d+(?:,\d+)? \+(\d+)(?:,(\d+))? @@")
    for line in diff.splitlines():
        if line.startswith("+++ "):
            p = line[4:].strip()
            current = None if p == "/dev/null" else re.sub(r"^b/", "", p)
        elif line.startswith("@@") and current:
            m = hunk_re.match(line)
            if m:
                start = int(m.group(1))
                count = int(m.group(2)) if m.group(2) is not None else 1
                for i in range(start, start + count):
                    out[current].add(i)
    return out


def _diff_metrics(covered_by_file, changed, name="diff"):
    """Intersect per-file covered/uncovered line data with changed lines."""
    total = hit = 0
    uncovered = []
    for path, lines in changed.items():
        info = covered_by_file.get(path)
        if info is None:
            continue  # file not in the coverage report (e.g. not instrumented)
        for ln in sorted(lines):
            if ln not in info:
                continue  # not an executable line (blank, comment, brace)
            total += 1
            if info[ln] > 0:
                hit += 1
            else:
                uncovered.append(f"{path}:{ln}")
    rate = (hit / total) if total else 1.0
    return {
        f"{name}LineRate": round(rate, 4),
        f"{name}LinesCovered": hit,
        f"{name}LinesTotal": total,
        f"{name}LinesUncovered": total - hit,
        "_uncoveredSample": uncovered[:40],
    }


# -- parsers -----------------------------------------------------------------

def p_exitcode(ctx):
    return {"exit": ctx["returncode"]}


def p_regex(ctx):
    """Extract named numeric groups from stdout+stderr.

    Config: parserArgs.pattern with named groups, e.g.
      pattern: 'Score:\\s+(?P<score>[\\d.]+)%'
    """
    pattern = ctx["args"].get("pattern")
    if not pattern:
        raise ParseError("parser 'regex' requires parserArgs.pattern")
    m = re.search(pattern, ctx["stdout"] + "\n" + ctx["stderr"], re.MULTILINE)
    if not m:
        raise ParseError(f"pattern did not match tool output: {pattern}")
    metrics = {"exit": ctx["returncode"]}
    for k, v in (m.groupdict() or {}).items():
        try:
            metrics[k] = float(v)
        except (TypeError, ValueError):
            pass
    return metrics


def p_junit(ctx):
    """JUnit / xUnit XML. Emits: tests, failures, errors, skipped, passRate."""
    root = _parse_xml(ctx["artifact"])
    tests = failures = errors = skipped = 0
    suites = list(_iter(root, "testsuite")) or (
        [root] if _localname(root.tag) == "testsuite" else [])
    if suites:
        for s in suites:
            tests += int(s.get("tests", 0) or 0)
            failures += int(s.get("failures", 0) or 0)
            errors += int(s.get("errors", 0) or 0)
            skipped += int(s.get("skipped", 0) or 0)
    else:
        for tc in _iter(root, "testcase"):
            tests += 1
            kinds = {_localname(c.tag) for c in tc}
            if "failure" in kinds:
                failures += 1
            elif "error" in kinds:
                errors += 1
            elif "skipped" in kinds:
                skipped += 1
    bad = failures + errors
    return {
        "tests": tests, "failures": failures, "errors": errors, "skipped": skipped,
        "failed": bad,
        "passRate": round((tests - bad - skipped) / tests, 4) if tests else 0.0,
    }


def p_trx(ctx):
    """.NET VSTest .trx. Emits: tests, failed, passed, skipped, passRate."""
    root = _parse_xml(ctx["artifact"])
    for c in _iter(root, "Counters"):
        total = int(c.get("total", 0) or 0)
        failed = int(c.get("failed", 0) or 0)
        passed = int(c.get("passed", 0) or 0)
        skipped = int(c.get("notExecuted", 0) or 0)
        return {"tests": total, "failed": failed, "passed": passed, "skipped": skipped,
                "passRate": round(passed / total, 4) if total else 0.0}
    raise ParseError("no <Counters> element in trx - did the test run produce results?")


def _cobertura_lines(ctx):
    root = _parse_xml(ctx["artifact"])
    repo = ctx["repoRoot"]
    sources = [s.text.strip() for s in _iter(root, "source") if s.text]
    by_file = defaultdict(dict)
    for cls in _iter(root, "class"):
        fn = cls.get("filename")
        if not fn:
            continue
        candidates = [fn] + [os.path.join(s, fn) for s in sources]
        key = None
        for c in candidates:
            n = _norm(c, repo)
            if os.path.exists(os.path.join(repo, n)):
                key = n
                break
        key = key or _norm(fn, repo)
        for ln in _iter(cls, "line"):
            try:
                num = int(ln.get("number"))
                hits = int(float(ln.get("hits", 0) or 0))
            except (TypeError, ValueError):
                continue
            by_file[key][num] = max(by_file[key].get(num, 0), hits)
    return root, by_file


def p_cobertura(ctx):
    """Global Cobertura line/branch rate. Emits: lineRate, branchRate, linesCovered."""
    root, by_file = _cobertura_lines(ctx)
    total = sum(len(v) for v in by_file.values())
    hit = sum(1 for v in by_file.values() for h in v.values() if h > 0)
    metrics = {
        "lineRate": round(hit / total, 4) if total else 0.0,
        "linesCovered": hit, "linesTotal": total,
    }
    try:
        metrics["branchRate"] = round(float(root.get("branch-rate", 0) or 0), 4)
    except (TypeError, ValueError):
        pass
    return metrics


def p_cobertura_diff(ctx):
    """Diff coverage from Cobertura. THE brownfield gate.

    Emits: diffLineRate, diffLinesCovered, diffLinesTotal, diffLinesUncovered.
    Only lines changed since the task's base commit are scored, so a legacy repo
    can enforce a real bar today without first back-filling decades of tests.
    """
    _, by_file = _cobertura_lines(ctx)
    changed = changed_lines(ctx["repoRoot"], ctx["baseRef"])
    return _diff_metrics(by_file, changed)


def p_lcov(ctx):
    """lcov.info. Emits global lineRate plus per-file data."""
    by_file = _lcov_lines(ctx)
    total = sum(len(v) for v in by_file.values())
    hit = sum(1 for v in by_file.values() for h in v.values() if h > 0)
    return {"lineRate": round(hit / total, 4) if total else 0.0,
            "linesCovered": hit, "linesTotal": total}


def _lcov_lines(ctx):
    by_file, current = defaultdict(dict), None
    for line in _read(ctx["artifact"]).splitlines():
        line = line.strip()
        if line.startswith("SF:"):
            current = _norm(line[3:], ctx["repoRoot"])
        elif line.startswith("DA:") and current:
            parts = line[3:].split(",")
            try:
                by_file[current][int(parts[0])] = int(float(parts[1]))
            except (IndexError, ValueError):
                pass
        elif line == "end_of_record":
            current = None
    return by_file


def p_lcov_diff(ctx):
    """Diff coverage from lcov.info. Emits diff* metrics (see p_cobertura_diff)."""
    return _diff_metrics(_lcov_lines(ctx), changed_lines(ctx["repoRoot"], ctx["baseRef"]))


def p_stryker(ctx):
    """Stryker (.NET / JS) mutation report JSON.

    Emits: mutationScore, killed, survived, noCoverage, timeout, totalMutants.
    A survived mutant is a test suite that did not notice the code changed -
    which is exactly the failure mode of AI-written tests that assert nothing.
    """
    data = _load_json(ctx["artifact"])
    counts = defaultdict(int)
    files = data.get("files") or {}
    if isinstance(files, dict):
        for f in files.values():
            for m in f.get("mutants", []) or []:
                counts[str(m.get("status", "Unknown"))] += 1
    if not counts and "thresholds" in data and "mutationScore" in data:
        return {"mutationScore": float(data["mutationScore"])}
    if not counts:
        raise ParseError("no mutants found in Stryker report")

    # Stryker's definition: score = detected / valid, where detected counts
    # timeouts as kills and `valid` excludes Ignored/CompileError mutants.
    detected = counts["Killed"] + counts["Timeout"] + counts["RuntimeError"]
    survived = counts["Survived"]
    no_cov = counts["NoCoverage"]
    valid = detected + survived + no_cov
    return {
        "mutationScore": round(100.0 * detected / valid, 2) if valid else 0.0,
        "detected": detected, "validMutants": valid,
        "killed": counts["Killed"], "survived": survived, "noCoverage": no_cov,
        "timeout": counts["Timeout"], "ignored": counts["Ignored"],
        "totalMutants": sum(counts.values()),
    }


def p_sarif(ctx):
    """SARIF from Semgrep / analyzers / scanners.

    Emits: total, error, warning, note plus errorAndWarning.
    """
    data = _load_json(ctx["artifact"])
    sev = defaultdict(int)
    rules = defaultdict(int)
    for run in data.get("runs", []) or []:
        default = {}
        for r in (run.get("tool", {}).get("driver", {}).get("rules", []) or []):
            lvl = (r.get("defaultConfiguration") or {}).get("level")
            if lvl:
                default[r.get("id")] = lvl
        for res in run.get("results", []) or []:
            level = res.get("level") or default.get(res.get("ruleId")) or "warning"
            sev[level] += 1
            if res.get("ruleId"):
                rules[res["ruleId"]] += 1
    total = sum(sev.values())
    return {
        "total": total, "error": sev["error"], "warning": sev["warning"],
        "note": sev["note"], "errorAndWarning": sev["error"] + sev["warning"],
        "_topRules": dict(sorted(rules.items(), key=lambda kv: -kv[1])[:10]),
    }


def p_msbuild(ctx):
    """Roslyn / MSBuild diagnostics straight from build output.

    Emits: errors, warnings, plus perRule counts so a gate can target rule ids
    (CA2000, VSTHRD100, IDE0005, ...) rather than a blanket count.
    """
    text = ctx["stdout"] + "\n" + ctx["stderr"]
    pat = re.compile(
        r"^(?P<file>[^\s(]+)\((?P<line>\d+),(?P<col>\d+)\)\s*:\s*"
        r"(?P<sev>error|warning)\s+(?P<code>[A-Z]{2,}\d{3,})\s*:\s*(?P<msg>.*)$",
        re.MULTILINE)
    sev = defaultdict(int)
    rules = defaultdict(int)
    seen = set()
    for m in pat.finditer(text):
        key = (m.group("file"), m.group("line"), m.group("code"))
        if key in seen:
            continue  # msbuild repeats diagnostics once per target framework
        seen.add(key)
        sev[m.group("sev")] += 1
        rules[m.group("code")] += 1
    return {
        "errors": sev["error"], "warnings": sev["warning"],
        "diagnostics": sev["error"] + sev["warning"],
        "exit": ctx["returncode"],
        "_perRule": dict(sorted(rules.items(), key=lambda kv: -kv[1])[:15]),
    }


def p_eslint_json(ctx):
    """ESLint --format json. Emits: errors, warnings, fixableErrors, perRule."""
    data = _load_json(ctx["artifact"])
    errors = warnings = fixable = 0
    rules = defaultdict(int)
    for f in data if isinstance(data, list) else []:
        errors += f.get("errorCount", 0)
        warnings += f.get("warningCount", 0)
        fixable += f.get("fixableErrorCount", 0)
        for m in f.get("messages", []) or []:
            if m.get("ruleId"):
                rules[m["ruleId"]] += 1
    return {"errors": errors, "warnings": warnings, "fixableErrors": fixable,
            "problems": errors + warnings,
            "_perRule": dict(sorted(rules.items(), key=lambda kv: -kv[1])[:15])}


def p_jsonpath(ctx):
    """Generic numeric extraction by dotted path.

    Config: parserArgs.paths = {metricName: "a.b.0.c"}
    Lets a new tool be gated without writing a parser.
    """
    data = _load_json(ctx["artifact"])
    paths = ctx["args"].get("paths") or {}
    if not paths:
        raise ParseError("parser 'jsonpath' requires parserArgs.paths")
    metrics = {}
    for name, path in paths.items():
        cur = data
        for part in str(path).split("."):
            if isinstance(cur, list):
                try:
                    cur = cur[int(part)]
                except (ValueError, IndexError):
                    raise ParseError(f"path '{path}' does not resolve at '{part}'")
            elif isinstance(cur, dict):
                if part not in cur:
                    raise ParseError(f"path '{path}' does not resolve at '{part}'")
                cur = cur[part]
            else:
                raise ParseError(f"path '{path}' does not resolve at '{part}'")
        try:
            metrics[name] = float(cur)
        except (TypeError, ValueError):
            raise ParseError(f"value at '{path}' is not numeric: {cur!r}")
    return metrics


def p_memlab(ctx):
    """memlab leak report JSON (web heap leaks). Emits: leaks, retainedBytes."""
    data = _load_json(ctx["artifact"])
    if isinstance(data, list):
        leaks = len(data)
        retained = sum(float(x.get("retainedSize", 0) or 0) for x in data)
    else:
        leaks = int(data.get("leakCount", len(data.get("leaks", []) or [])))
        retained = float(data.get("retainedSize", 0) or 0)
    return {"leaks": leaks, "retainedBytes": retained}


def p_gcdump_delta(ctx):
    """Growth check from two dotnet-gcdump/counters samples.

    Config: parserArgs.baseline and parserArgs.current point at JSON files with
    a numeric total-heap field named by parserArgs.field (default heapBytes).
    Emits: growthBytes, growthRatio.
    """
    a = ctx["args"]
    field = a.get("field", "heapBytes")
    base = _load_json(os.path.join(ctx["evidenceDir"], a["baseline"]))
    cur = _load_json(os.path.join(ctx["evidenceDir"], a["current"]))
    b, c = float(base.get(field, 0) or 0), float(cur.get(field, 0) or 0)
    return {"growthBytes": c - b, "growthRatio": round(c / b, 4) if b else 0.0,
            "baselineBytes": b, "currentBytes": c}


PARSERS = {
    "exitcode": p_exitcode,
    "regex": p_regex,
    "junit": p_junit,
    "trx": p_trx,
    "cobertura": p_cobertura,
    "cobertura-diff": p_cobertura_diff,
    "lcov": p_lcov,
    "lcov-diff": p_lcov_diff,
    "stryker": p_stryker,
    "sarif": p_sarif,
    "msbuild": p_msbuild,
    "eslint-json": p_eslint_json,
    "jsonpath": p_jsonpath,
    "memlab": p_memlab,
    "gcdump-delta": p_gcdump_delta,
}

# Metric names each parser emits, for `harness.py gate list` and validation.
METRICS = {
    "exitcode": ["exit"],
    "regex": ["exit", "<named groups from pattern>"],
    "junit": ["tests", "failures", "errors", "skipped", "failed", "passRate"],
    "trx": ["tests", "failed", "passed", "skipped", "passRate"],
    "cobertura": ["lineRate", "branchRate", "linesCovered", "linesTotal"],
    "cobertura-diff": ["diffLineRate", "diffLinesCovered", "diffLinesTotal", "diffLinesUncovered"],
    "lcov": ["lineRate", "linesCovered", "linesTotal"],
    "lcov-diff": ["diffLineRate", "diffLinesCovered", "diffLinesTotal", "diffLinesUncovered"],
    "stryker": ["mutationScore", "detected", "validMutants", "killed", "survived",
                "noCoverage", "timeout", "totalMutants"],
    "sarif": ["total", "error", "warning", "note", "errorAndWarning"],
    "msbuild": ["errors", "warnings", "diagnostics", "exit"],
    "eslint-json": ["errors", "warnings", "fixableErrors", "problems"],
    "jsonpath": ["<keys of parserArgs.paths>"],
    "memlab": ["leaks", "retainedBytes"],
    "gcdump-delta": ["growthBytes", "growthRatio", "baselineBytes", "currentBytes"],
}

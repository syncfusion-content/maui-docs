#!/usr/bin/env python3
"""End-to-end workflow checks against the real `sf` CLI.

Drives the built CLI the way a user does (generate, add, remove, fail) in a scratch
directory and asserts on the files it produces. Writes a JSON report whose counts
the harness gates on. Scenarios that cannot run on this host are counted as
`skipped` and named in the report; they are never counted as passed.

    python3 scripts/harness/e2e_workflows.py --out report.json [--build] [--platforms wpf,blazor]

--build additionally restores and builds generated projects on hosts that can.
"""
import argparse
import json
import os
import re
import shutil
import subprocess
import sys
import tempfile

REPO = os.path.abspath(os.path.join(os.path.dirname(__file__), "..", ".."))
CLI_PROJECT = os.path.join(REPO, "src", "Syncfusion.DotNet.CLI", "Syncfusion.DotNet.CLI.csproj")
CLI_DLL = os.path.join(REPO, "src", "Syncfusion.DotNet.CLI", "bin", "Release", "net10.0", "sf.dll")
PKG_RE = re.compile(r'<PackageReference\s+Include="([^"]+)"', re.I)
DESKTOP_BUILD_HOSTS = {"wpf": "win32", "winforms": "win32", "winui": "win32"}

results = []  # (scenario, status, detail)


def record(scenario, status, detail=""):
    results.append({"scenario": scenario, "status": status, "detail": detail})
    print(f"{status.upper():<7} {scenario}" + (f"  -- {detail}" if detail else ""))


def check(scenario, condition, detail=""):
    record(scenario, "passed" if condition else "failed", "" if condition else detail)
    return condition


def sf(*args, cwd=None):
    p = subprocess.run(["dotnet", CLI_DLL, *args, "--no-interactive", "--no-color"],
                       cwd=cwd, capture_output=True, text=True, timeout=300)
    return p.returncode, (p.stdout + p.stderr)


def packages(csproj):
    with open(csproj, encoding="utf-8-sig") as f:
        return PKG_RE.findall(f.read())


def read(path):
    with open(path, "rb") as f:
        return f.read()


def csproj_of(directory):
    for f in os.listdir(directory):
        if f.endswith((".csproj", ".vbproj")):
            return os.path.join(directory, f)
    return None


def generate(platform, name, parent, *extra):
    return sf("new", platform, "-n", name, "--path", parent,
              "--post-action", "generate", *extra)


def scenario_generate(platform, root, controls):
    parent = os.path.join(root, platform)
    os.makedirs(parent)
    name = f"App{platform.capitalize()}"
    rc, out = generate(platform, name, parent, "--control", *controls)
    if platform == "maui" and rc != 0 and "template" in out.lower():
        record(f"generate/{platform}", "skipped", "MAUI project template/workload not installed on this host")
        return None
    if not check(f"generate/{platform}: exit 0", rc == 0, out[-300:]):
        return None
    project = os.path.join(parent, name)
    cs = csproj_of(project)
    if not check(f"generate/{platform}: csproj written", cs is not None, project):
        return None
    refs = packages(cs)
    check(f"generate/{platform}: no duplicate PackageReference",
          len(refs) == len(set(refs)), str(refs))
    if platform in DESKTOP_BUILD_HOSTS:
        check(f"generate/{platform}: Windows target framework",
              "-windows" in read(cs).decode("utf-8", "replace"))
    return project


def scenario_blazor_controls(root):
    parent = os.path.join(root, "blazor-grid")
    os.makedirs(parent)
    rc, out = generate("blazor", "GridApp", parent, "--control", "grid")
    if not check("blazor+grid: exit 0", rc == 0, out[-300:]):
        return None
    project = os.path.join(parent, "GridApp")
    refs = packages(csproj_of(project))
    check("blazor+grid: Grid package referenced", "Syncfusion.Blazor.Grid" in refs, str(refs))
    check("blazor+grid: Themes package referenced", "Syncfusion.Blazor.Themes" in refs, str(refs))
    check("blazor+grid: Program.cs and Components present",
          os.path.isfile(os.path.join(project, "Program.cs"))
          and os.path.isdir(os.path.join(project, "Components")))
    rc, out = sf("remove", "blazor", "grid", "-p", project)
    check("blazor: removing a control the generated pages need is refused",
          rc != 0 and "Syncfusion.Blazor.Grid" in refs, out[-200:])
    check("blazor: refused removal left packages unchanged",
          packages(csproj_of(project)) == refs)
    return project


def all_text(directory, suffixes):
    parts = []
    for base, _, files in os.walk(directory):
        for n in files:
            if n.endswith(suffixes):
                parts.append(read(os.path.join(base, n)).decode("utf-8", "replace"))
    return "\n".join(parts)


def scenario_blazor_matrix(root):
    parent = os.path.join(root, "blazor-matrix")
    os.makedirs(parent)
    projects = {}
    variants = [
        ("Wasm", ["--app-type", "webassembly-standalone"], ".csproj", "Microsoft.AspNetCore.Components.WebAssembly"),
        ("Auto", ["--render-mode", "auto", "--interactivity", "global"], None, None),
        ("Auth", ["--auth", "individual"], ".csproj", "Microsoft.AspNetCore.Identity.EntityFrameworkCore"),
        ("NoHttps", ["--https", "no"], ".cs", None),
    ]
    for name, flags, _, marker in variants:
        rc, out = generate("blazor", name, parent, "--control", "grid", *flags)
        if not check(f"blazor/{name}: generated", rc == 0, out[-300:]):
            continue
        project = os.path.join(parent, name)
        projects[name] = project
        check(f"blazor/{name}: solution/project output exists",
              os.path.isdir(project) and bool(os.listdir(project)))
        if marker:
            check(f"blazor/{name}: expected dependency present ({marker})",
                  marker in all_text(project, (".csproj",)))
        if name == "Auto":
            check("blazor/Auto: server and .Client projects both generated",
                  os.path.isdir(os.path.join(project, "Auto"))
                  and os.path.isdir(os.path.join(project, "Auto.Client")))
        elif name == "NoHttps":
            check("blazor/NoHttps: HTTPS redirection omitted",
                  "UseHttpsRedirection" not in all_text(project, ("Program.cs",)))
        elif name == "Auth":
            check("blazor/Auth: HTTPS redirection kept by default",
                  "UseHttpsRedirection" in all_text(project, ("Program.cs",)))
        check(f"blazor/{name}: Syncfusion services registered",
              "AddSyncfusionBlazor" in all_text(project, ("Program.cs",)))
    rc, out = generate("blazor", "Bad", parent, "--control", "grid", "--render-mode", "nonsense")
    check("blazor: invalid --render-mode rejected before writing", rc != 0
          and not os.path.exists(os.path.join(parent, "Bad")), out[-200:])
    return projects


def scenario_package_lifecycle(project, platform):
    cs = csproj_of(project)
    baseline = packages(cs)
    p = f"{platform}/package-lifecycle"

    rc, out = sf("add", platform, "datagrid", "-p", project)
    if not check(f"{p}: add first control", rc == 0, out[-200:]):
        return
    after_one = packages(cs)
    check(f"{p}: first control added", len(after_one) > len(baseline), str(after_one))

    rc, out = sf("add", platform, "chart", "-p", project)
    check(f"{p}: add second control", rc == 0, out[-200:])
    both = packages(cs)

    rc, out = sf("add", platform, "datagrid", "-p", project)
    check(f"{p}: repeated add succeeds", rc == 0, out[-200:])
    again = packages(cs)
    check(f"{p}: repeated add creates no duplicates",
          len(again) == len(set(again)) and sorted(again) == sorted(both), str(again))

    rc, out = sf("remove", platform, "chart", "-p", project)
    check(f"{p}: remove one control", rc == 0, out[-200:])
    after_remove = packages(cs)
    shared = [b for b in baseline if b not in after_remove]
    check(f"{p}: shared/base dependencies survive removal of one control", not shared, str(shared))
    check(f"{p}: the other control remains",
          any(x not in baseline for x in after_remove), str(after_remove))

    rc, out = sf("remove", platform, "datagrid", "-p", project)
    check(f"{p}: remove last control", rc == 0, out[-200:])
    check(f"{p}: removing the last control restores the baseline package set",
          sorted(packages(cs)) == sorted(baseline), f"{packages(cs)} vs {baseline}")

    for _ in range(2):
        sf("add", platform, "datagrid", "-p", project)
        sf("remove", platform, "datagrid", "-p", project)
    final = packages(cs)
    check(f"{p}: repeated add/remove cycles leave no residue and no duplicates",
          sorted(final) == sorted(baseline) and len(final) == len(set(final)), str(final))


def scenario_preservation(project, platform):
    cs = csproj_of(project)
    p = f"{platform}/preservation"
    marker = "<!-- user-owned: keep this comment -->"
    text = read(cs).decode("utf-8")
    text = text.replace("</Project>", f"  {marker}\n</Project>")
    with open(cs, "wb") as f:
        f.write(text.encode("utf-8"))
    code_file = next((os.path.join(project, n) for n in os.listdir(project)
                      if n.endswith((".xaml.cs", "Form.cs", "Program.cs"))), None)
    code_before = None
    if code_file:
        with open(code_file, "a", encoding="utf-8") as f:
            f.write("\n// user edit\n")
        code_before = read(code_file)

    sf("add", platform, "datagrid", "-p", project)
    sf("remove", platform, "datagrid", "-p", project)
    check(f"{p}: user edits to the project file survive add/remove",
          marker in read(cs).decode("utf-8", "replace"))
    if code_file:
        check(f"{p}: user-modified source file untouched by package operations",
              read(code_file) == code_before)


def scenario_failures(project, platform, root):
    cs = csproj_of(project)
    p = f"{platform}/failure-integrity"
    before = read(cs)
    rc, out = sf("add", platform, "no-such-control", "-p", project)
    check(f"{p}: unknown package exits non-zero", rc != 0, out[-200:])
    check(f"{p}: unknown package gives a clear error", "Unknown" in out and "no-such-control" in out, out[-200:])
    check(f"{p}: failed add leaves the project byte-identical", read(cs) == before)
    rc, out = sf("add", platform, "datagrid", "-p", os.path.join(root, "missing-dir"))
    check(f"{p}: missing project path exits non-zero with a clear error",
          rc != 0 and "project" in out.lower(), out[-200:])
    parent = os.path.dirname(project)
    name = os.path.basename(project)
    before_tree = sorted(os.listdir(project))
    rc, out = generate(platform, name, parent, "--control", "empty")
    check(f"{p}: name collision refused", rc != 0 and "already exists" in out, out[-200:])
    check(f"{p}: name collision leaves existing project untouched",
          sorted(os.listdir(project)) == before_tree and read(cs) == before)


def scenario_paths(root):
    parent = os.path.join(root, "path with spaces")
    os.makedirs(parent)
    rc, out = generate("wpf", "Spaced", parent, "--control", "datagrid")
    check("paths: parent directory containing spaces", rc == 0
          and os.path.isfile(os.path.join(parent, "Spaced", "Spaced.csproj")), out[-200:])


def scenario_build(platform, project):
    host_needed = DESKTOP_BUILD_HOSTS.get(platform)
    name = f"build/{platform}"
    if platform == "maui":
        record(name, "skipped", "MAUI build needs workloads (+Xcode on macOS); run on a prepared host")
        return
    if host_needed and not sys.platform.startswith(host_needed):
        record(name, "skipped", f"{platform} builds require Windows")
        return
    p = subprocess.run(["dotnet", "build", project, "-v", "q", "--nologo"],
                       capture_output=True, text=True, timeout=900)
    check(name + ": restore and build", p.returncode == 0, (p.stdout + p.stderr)[-400:])


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--out", required=True)
    ap.add_argument("--build", action="store_true")
    ap.add_argument("--platforms", default="wpf,winforms,winui,blazor,maui")
    ap.add_argument("--keep", action="store_true")
    args = ap.parse_args()

    if not os.path.isfile(CLI_DLL) or os.environ.get("E2E_REBUILD"):
        b = subprocess.run(["dotnet", "build", CLI_PROJECT, "-c", "Release", "-v", "q", "--nologo"],
                           capture_output=True, text=True)
        if b.returncode != 0:
            print(b.stdout[-800:], b.stderr[-800:])
            sys.exit(2)

    root = tempfile.mkdtemp(prefix="sf-e2e-")
    try:
        wanted = [p for p in args.platforms.split(",") if p]
        projects = {}
        for platform in wanted:
            if platform == "blazor":
                projects[platform] = scenario_blazor_controls(root)
                scenario_blazor_matrix(root)
                continue
            projects[platform] = scenario_generate(platform, root, ["empty"])
        for platform in ("wpf", "winforms", "winui"):
            project = projects.get(platform)
            if project:
                scenario_package_lifecycle(project, platform)
                scenario_preservation(project, platform)
                scenario_failures(project, platform, root)
        if "wpf" in wanted:
            scenario_paths(root)
        if args.build:
            for platform, project in projects.items():
                if project:
                    scenario_build(platform, project)
    finally:
        if not args.keep:
            shutil.rmtree(root, ignore_errors=True)

    summary = {
        "checks": len(results),
        "passed": sum(r["status"] == "passed" for r in results),
        "failed": sum(r["status"] == "failed" for r in results),
        "skipped": sum(r["status"] == "skipped" for r in results),
        "results": results,
    }
    os.makedirs(os.path.dirname(os.path.abspath(args.out)), exist_ok=True)
    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(summary, f, indent=2)
    print(f"\n{summary['passed']} passed, {summary['failed']} failed, {summary['skipped']} skipped")
    sys.exit(1 if summary["failed"] else 0)


if __name__ == "__main__":
    main()

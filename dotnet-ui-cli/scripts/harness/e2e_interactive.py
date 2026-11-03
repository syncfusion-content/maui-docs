#!/usr/bin/env python3
"""Drives the real `sfdotnet new <platform>` interactive wizard through a pseudo-terminal.

Starts the built CLI with a throwaway HOME, in a working directory named `dotnet-ui-cli`, accepts every default
with Enter (choosing "Generate" at the post-creation prompt so no build is needed), and asserts on what the user
sees and on what lands on disk: Project location prompt before Project name prompt, default location == <home>/Projects, default name == the platform name,
project created at <home>/Projects/<name>, then <name>1 on a repeat run. A second scenario types an
invalid name, checks the prompt stays, then corrects it.

    python3 scripts/harness/e2e_interactive.py --out report.json [--platforms maui,wpf,winforms,winui,blazor]
"""
import argparse, json, os, pty, re, select, shutil, signal, sys, tempfile, time

REPO = os.path.abspath(os.path.join(os.path.dirname(__file__), "..", ".."))
CLI_DLL = os.path.join(REPO, "src", "Syncfusion.DotNet.Cli", "bin", "Release", "net10.0", "Syncfusion.DotNet.Cli.dll")
ANSI = re.compile(r"\x1b\[[0-9;?]*[A-Za-z]|\x1b[()][A-Z0-9]")
KEYS = {"ENTER": b"\r", "DOWN": b"\x1b[B", "ESC": b"\x1b"}
results = []


def record(name, ok, detail="", skip=False):
    status = "skipped" if skip else ("passed" if ok else "failed")
    results.append({"scenario": name, "status": status, "detail": "" if ok and not skip else detail})
    print(status.upper().ljust(8) + name + ("" if ok and not skip else "  -- " + detail[:300]))


def maui_unavailable(platform, text):
    """MAUI generation needs the MAUI template pack, which only exists where the workload is installed."""
    return platform == "maui" and "No templates or subcommands found matching: 'maui'" in text


def run(platform, cwd, typed=None, timeout=240, home=None):
    """Returns (screen_text, exit_code or None). `typed` is a list of strings sent at the Project name prompt."""
    env = dict(os.environ, TERM="xterm-256color", COLUMNS="140", LINES="50")
    if home:  # a throwaway home proves the defaults come from the user's home, not from cwd, without touching the real one
        env.setdefault("NUGET_PACKAGES", os.path.join(os.path.expanduser("~"), ".nuget", "packages"))
        env.update(HOME=home, USERPROFILE=home, DOTNET_CLI_HOME=home, DOTNET_NOLOGO="1", DOTNET_SKIP_FIRST_TIME_EXPERIENCE="1")
    pid, fd = pty.fork()
    if pid == 0:
        os.chdir(cwd)
        os.execvpe("dotnet", ["dotnet", CLI_DLL, "new", platform, "--interactive"], env)
    raw = b""
    seen = 0
    typed = list(typed or [])
    deadline = time.time() + timeout
    exit_code = None
    last_prompt = ""
    try:
        while time.time() < deadline:
            r, _, _ = select.select([fd], [], [], 0.3)
            if r:
                try:
                    chunk = os.read(fd, 65536)
                except OSError:
                    break
                if not chunk:
                    break
                raw += chunk
            text = ANSI.sub("", raw.decode("utf8", "replace"))
            if len(text) > seen and not r:
                # screen is idle: answer the prompt currently showing
                visible = text[-1500:]
                if "Project name:" in visible and typed and visible != last_prompt:
                    last_prompt = visible
                    for _ in range(40):
                        os.write(fd, b"\x7f")
                    time.sleep(0.2)
                    os.write(fd, typed.pop(0).encode() + b"\r")
                elif visible != last_prompt:
                    last_prompt = visible
                    os.write(fd, b"\r")
                seen = len(text)
            try:
                done, status = os.waitpid(pid, os.WNOHANG)
                if done:
                    exit_code = os.waitstatus_to_exitcode(status)
                    break
            except ChildProcessError:
                break
    finally:
        try:
            os.kill(pid, signal.SIGKILL)
        except ProcessLookupError:
            pass
        try:
            os.waitpid(pid, 0)
        except ChildProcessError:
            pass
    return ANSI.sub("", raw.decode("utf8", "replace")), exit_code


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--out", required=True)
    ap.add_argument("--platforms", default="maui,wpf,winforms,winui,blazor")
    args = ap.parse_args()
    names = {"maui": "SyncfusionMauiApp", "wpf": "SyncfusionWpfApp", "winforms": "SyncfusionWinFormsApp",
             "winui": "SyncfusionWinUIApp", "blazor": "SyncfusionBlazorApp"}
    for platform in args.platforms.split(","):
        base = tempfile.mkdtemp(prefix="sf e2e int-")  # the space exercises paths with spaces
        try:
            home = os.path.join(base, "home")
            cwd = os.path.join(base, "dotnet-ui-cli")
            os.makedirs(home)
            os.makedirs(cwd)
            projects = os.path.join(home, "Projects")
            default = names[platform]
            # 1. first run: every default accepted
            text, code = run(platform, cwd, home=home)
            loc, name = text.find("Project location:"), text.find("Project name:")
            record(f"{platform}: location prompt precedes name prompt", 0 <= loc < name, text[-400:])
            record(f"{platform}: default location is <home>/Projects, not the working directory", projects in text and cwd not in text, text[-400:])
            record(f"{platform}: default name is {default}", f"[{default}]" in text or f"{default}" in text[name:], text[-400:])
            project = os.path.join(projects, default)
            record(f"{platform}: project created at <home>/Projects/{default} with no nested duplicate",
                   os.path.isdir(project) and bool(os.listdir(project)) and not os.path.exists(os.path.join(project, default)),
                   f"projects={os.listdir(projects) if os.path.isdir(projects) else None} tail={text[-400:]}", skip=maui_unavailable(platform, text))
            record(f"{platform}: working directory untouched", os.listdir(cwd) == [])
            # 2. second run: default exists, so {default}1 is suggested
            if os.path.isdir(project):
                os.makedirs(os.path.join(projects, default + "x"), exist_ok=True)
            else:
                os.makedirs(project)
            text_b, _ = run(platform, cwd, home=home)
            record(f"{platform}: existing default name yields {default}1", os.path.isdir(os.path.join(projects, default + "1")) or maui_unavailable(platform, text_b) and default + "1" in text_b,
                   text_b[-400:], skip=maui_unavailable(platform, text_b) and not os.path.isdir(os.path.join(projects, default + "1")))
            # 3. invalid name re-prompts, then correction is accepted
            text2, _ = run(platform, cwd, typed=["bad-name!", "Corrected"], home=home)
            tail2 = text2[text2.find("Project name:"):]
            record(f"{platform}: invalid name re-prompts, correction creates <location>/Corrected",
                   "invalid" in tail2.lower() and os.path.isdir(os.path.join(projects, "Corrected")), tail2[-500:], skip=maui_unavailable(platform, text2))
            if maui_unavailable(platform, text2):
                record("maui: invalid name re-prompts (prompt-level only, generation skipped)", "invalid" in tail2.lower() and "Corrected" in text2, tail2[-300:])
            record(f"{platform}: wizard did not crash", "Unhandled exception" not in text and "Project name '" not in text, text[-400:])
        finally:
            shutil.rmtree(base, ignore_errors=True)
    failed = [r for r in results if r["status"] == "failed"]
    with open(args.out, "w") as f:
        skipped = [r for r in results if r["status"] == "skipped"]
        json.dump({"passed": len(results) - len(failed) - len(skipped), "failed": len(failed), "skipped": len(skipped), "results": results}, f, indent=2)
    sys.exit(1 if failed else 0)


if __name__ == "__main__":
    main()

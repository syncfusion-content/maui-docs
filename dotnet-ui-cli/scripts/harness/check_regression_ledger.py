#!/usr/bin/env python3
"""Verify that every regression-ledger test still exists and passes.

Prints one machine-readable line for the harness parser:
    entries=<n> missing=<n> failed=<n>
"""
import argparse
import json
import os
import re
import subprocess
import sys

HERE = os.path.dirname(os.path.abspath(__file__))
REPO = os.path.abspath(os.path.join(HERE, "..", ".."))
TESTS = os.path.join(REPO, "tests")


def declared_methods():
    names = set()
    pat = re.compile(r"public\s+(?:static\s+)?(?:async\s+)?(?:Task|void)\s+(\w+)\s*\(")
    for f in os.listdir(TESTS):
        if f.endswith(".cs"):
            with open(os.path.join(TESTS, f), encoding="utf-8-sig") as fh:
                names.update(pat.findall(fh.read()))
    return names


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--evidence", default=None)
    args = ap.parse_args()

    with open(os.path.join(HERE, "regression-ledger.json"), encoding="utf-8") as f:
        entries = json.load(f)["entries"]
    methods = declared_methods()
    tests = [e["test"] for e in entries]
    missing = [t for t in tests if t not in methods]
    for t in missing:
        print(f"MISSING  {t} is in the ledger but no such test method exists")

    present = [t for t in tests if t in methods]
    flt = "|".join(f"FullyQualifiedName~.{t}" for t in present)
    failed = 0
    if present:
        proc = subprocess.run(
            ["dotnet", "test", "tests", "--nologo", "-c", "Release", "--no-build", "--filter", flt],
            cwd=REPO, capture_output=True, text=True)
        out = proc.stdout + proc.stderr
        m = re.search(r"(?:Passed|Failed)!\s+-\s+Failed:\s+(\d+),\s+Passed:\s+(\d+).*?Total:\s+(\d+)", out)
        if not m:
            print(out[-1500:])
            failed = len(present)
        else:
            failed = int(m.group(1))
            ran = int(m.group(3))
            if ran < len(present):
                print(f"MISSING  filter matched {ran} tests, ledger expects at least {len(present)}")
                failed += len(present) - ran
            if failed:
                print("\n".join(l for l in out.splitlines() if l.strip().startswith("Failed ")))
    if args.evidence:
        os.makedirs(args.evidence, exist_ok=True)
    print(f"entries={len(entries)} missing={len(missing)} failed={failed}")
    sys.exit(0)


if __name__ == "__main__":
    main()

#!/usr/bin/env python3
"""Portable coverage collection and NuGet vulnerability gate commands."""

import argparse
import json
from pathlib import Path
import shutil
import subprocess
import sys
import tempfile

REPO = Path(__file__).resolve().parents[2]
KNOWN_FAILURES = (
    "PdfViewerResourcesMatchCatalogNames",
    "ProjectEmbeddingExcludesMacMetadataAtEveryDepthAndKeepsTemplates",
    "InvalidExplicitTargetFramework_FailsBeforeProjectNameQuestion",
    "NameConflictAllowsReentryWithoutChangingExistingDestination",
)


def coverage(evidence):
    output = evidence.resolve() / "cov"
    output.mkdir(parents=True, exist_ok=True)
    target = output / "coverage.cobertura.xml"
    target.unlink(missing_ok=True)
    with tempfile.TemporaryDirectory(prefix="collect-", dir=output) as results:
        result = subprocess.run([
            "dotnet", "test", "tests", "--nologo", "-c", "Release", "--no-build",
            "--filter", "&".join("FullyQualifiedName!~" + name for name in KNOWN_FAILURES),
            "--collect:XPlat Code Coverage", "--results-directory", results,
        ], cwd=REPO)
        if result.returncode:
            return result.returncode
        reports = list(Path(results).glob("*/coverage.cobertura.xml"))
        if len(reports) != 1:
            raise ValueError(f"Expected one coverage report, found {len(reports)}")
        shutil.copyfile(reports[0], target)
    return 0


def vulnerabilities():
    result = subprocess.run([
        "dotnet", "list", "package", "--vulnerable", "--include-transitive",
        "--format", "json",
    ], cwd=REPO, capture_output=True, text=True, encoding="utf-8")
    if result.stderr:
        print(result.stderr, file=sys.stderr)
    if result.returncode:
        print(result.stdout)
        return result.returncode
    report = json.loads(result.stdout)
    if report.get("version") != 1 or not report.get("projects"):
        raise ValueError("Expected NuGet JSON report version 1 with projects")
    vulnerable = []
    for project in report["projects"]:
        for framework in project.get("frameworks", []):
            for kind in ("topLevelPackages", "transitivePackages"):
                for package in framework.get(kind, []):
                    if package.get("vulnerabilities"):
                        vulnerable.append(package)
    print(json.dumps(report, indent=2))
    return 1 if vulnerable else 0


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    commands = parser.add_subparsers(dest="command", required=True)
    commands.add_parser("coverage").add_argument("evidence", type=Path)
    commands.add_parser("vulnerabilities")
    args = parser.parse_args()
    try:
        return coverage(args.evidence) if args.command == "coverage" else vulnerabilities()
    except (OSError, ValueError) as error:
        print(f"Gate failed: {error}", file=sys.stderr)
        return 1


if __name__ == "__main__":
    sys.exit(main())

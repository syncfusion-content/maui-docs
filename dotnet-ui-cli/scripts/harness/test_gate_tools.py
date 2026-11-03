import json
from pathlib import Path
import subprocess
import sys
import tempfile
import unittest
from unittest.mock import patch
import xml.etree.ElementTree as ET

sys.path.insert(0, str(Path(__file__).resolve().parents[2] / ".agent" / "tools"))
import harness
import gate_tools
import e2e_workflows


class GateToolsTests(unittest.TestCase):
    def test_e2e_runner_targets_the_declared_cli_assembly(self):
        project = ET.parse(e2e_workflows.CLI_PROJECT).getroot()
        assembly = project.findtext(".//AssemblyName")
        self.assertEqual(assembly + ".dll", Path(e2e_workflows.CLI_DLL).name)

    def test_control_plane_hash_ignores_checkout_line_endings_not_content(self):
        with tempfile.TemporaryDirectory() as root:
            path = Path(root) / "policy.md"
            path.write_bytes(b"# Policy\r\nRequired\r\n")
            expected = harness.sha256_text("# Policy\nRequired\n")
            self.assertEqual(expected, harness.cp_hash(str(path)))
            path.write_bytes(b"# Policy\r\nOptional\r\n")
            self.assertNotEqual(expected, harness.cp_hash(str(path)))

    def test_control_plane_paths_match_portable_lock_keys(self):
        with tempfile.TemporaryDirectory() as root:
            policies = Path(root) / "policies"
            policies.mkdir()
            (policies / "example.md").write_text("# Policy")
            with patch.object(harness, "AGENT_DIR", root):
                self.assertEqual(["policies/example.md"], harness.cp_files())

    def test_manifest_paths_are_portable(self):
        with tempfile.TemporaryDirectory() as root:
            project = Path(root) / "src" / "Example"
            project.mkdir(parents=True)
            (project / "Example.csproj").write_text("<Project />")
            with patch.object(harness, "REPO_ROOT", root):
                self.assertEqual(["src/Example/Example.csproj"], harness.find_manifests())

    def test_coverage_copies_report_without_deleting_existing_files(self):
        with tempfile.TemporaryDirectory(prefix="sf gate ") as root:
            sentinel = Path(root) / "keep.txt"
            sentinel.write_text("keep")

            def run(command, **kwargs):
                results = Path(command[command.index("--results-directory") + 1])
                report = results / "collector" / "coverage.cobertura.xml"
                report.parent.mkdir()
                report.write_text("<coverage />")
                return subprocess.CompletedProcess(command, 0)

            with patch.object(gate_tools.subprocess, "run", side_effect=run):
                self.assertEqual(0, gate_tools.coverage(Path(root)))
            self.assertEqual("<coverage />", (Path(root) / "cov" / "coverage.cobertura.xml").read_text())
            self.assertEqual("keep", sentinel.read_text())

    def test_coverage_propagates_test_failure(self):
        with tempfile.TemporaryDirectory() as root:
            with patch.object(gate_tools.subprocess, "run",
                              return_value=subprocess.CompletedProcess([], 7)):
                self.assertEqual(7, gate_tools.coverage(Path(root)))

    def test_coverage_rejects_missing_report(self):
        with tempfile.TemporaryDirectory() as root:
            with patch.object(gate_tools.subprocess, "run",
                              return_value=subprocess.CompletedProcess([], 0)):
                with self.assertRaisesRegex(ValueError, "coverage report"):
                    gate_tools.coverage(Path(root))

    def test_vulnerability_audit_handles_clean_and_vulnerable_reports(self):
        for package_kind in ("topLevelPackages", "transitivePackages"):
            for vulnerabilities in ([], [{"severity": "High", "advisoryurl": "https://example.test"}]):
                with self.subTest(package_kind=package_kind, vulnerabilities=vulnerabilities):
                    report = {"version": 1, "projects": [{"frameworks": [{
                        package_kind: [{"id": "Example", "vulnerabilities": vulnerabilities}]
                    }]}]}
                    result = subprocess.CompletedProcess([], 0, json.dumps(report), "")
                    with patch.object(gate_tools.subprocess, "run", return_value=result):
                        self.assertEqual(1 if vulnerabilities else 0, gate_tools.vulnerabilities())

    def test_vulnerability_audit_propagates_tool_failure(self):
        with patch.object(gate_tools.subprocess, "run",
                          return_value=subprocess.CompletedProcess([], 9, "", "restore failed")):
            self.assertEqual(9, gate_tools.vulnerabilities())

    def test_vulnerability_audit_rejects_invalid_or_empty_reports(self):
        for report in ("invalid json", "{}", '{"version":1,"projects":[]}'):
            with self.subTest(report=report):
                with patch.object(gate_tools.subprocess, "run",
                                  return_value=subprocess.CompletedProcess([], 0, report, "")):
                    with self.assertRaises(ValueError):
                        gate_tools.vulnerabilities()


if __name__ == "__main__":
    unittest.main()

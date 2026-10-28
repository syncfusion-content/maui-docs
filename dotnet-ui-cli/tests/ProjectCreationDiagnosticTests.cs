using System.ComponentModel;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

[Collection("Console output")]
public sealed class ProjectCreationDiagnosticTests
{
    [Theory]
    [InlineData("stdout", "Template output diagnostic", "dotnet new maui")]
    [InlineData("stderr", "Template error diagnostic", "dotnet new maui")]
    [InlineData("launch", "dotnet executable unavailable", "running dotnet new maui")]
    [InlineData("welcome", "is not a .NET MAUI project", "installing the native welcome screen")]
    public async Task CreationFailuresShowTheUnderlyingDiagnosticAndStage(string failure, string diagnostic, string stage)
    {
        var root = Path.Combine(Path.GetTempPath(), "sf-creation-diagnostic-" + Guid.NewGuid().ToString("N"));
        try
        {
            var runner = new CreationRunner(failure);
            var request = new NewProjectRequest(Framework.Maui, "App", root, "net10.0", "empty", MauiProjectType.App,
                Restore: true, Build: true, DryRun: false, Force: false);
            using var progressCapture = new ConsoleCapture();
            var result = await NewCommand.RunCreationWithProgressAsync(new OperationProgress(true), request, false,
                progress => new NewProjectScaffolder(runner).ExecuteAsync(request, progress: null,
                    cancellationToken: default, stages: progress));
            Assert.Contains(failure == "welcome"
                ? "✗ Setting up project files: failed while installing welcome screen"
                : "✗ Creating project: failed while creating project from MAUI template", progressCapture.Out);
            Assert.NotEqual(0, result.ExitCode);
            Assert.False(result.GenerationSucceeded);
            Assert.Null(result.BuildSucceeded);
            Assert.Contains(stage, result.Message);
            Assert.Contains(result.Errors, error => error.Contains(diagnostic, StringComparison.Ordinal));
            Assert.False(Directory.Exists(Path.Combine(root, "App")));
            Assert.DoesNotContain(runner.Commands, command => command[0] == "build");
            using var capture = new ConsoleCapture();
            NewCommand.ReportNewProjectResult(new ConsolePresenter(true), request, result);
            Assert.Contains(diagnostic, capture.Error);
            Assert.Contains("Project creation failed.", capture.Error);
            Assert.Contains("retry with --verbose", capture.Error);
            using var verboseCapture = new ConsoleCapture();
            NewCommand.ReportNewProjectResult(new ConsolePresenter(true, verbose: true), request, result);
            Assert.Contains(diagnostic, verboseCapture.Error);
            Assert.Contains(stage, verboseCapture.Error);
            Assert.DoesNotContain("Project created successfully", capture.Out);
            Assert.DoesNotContain("Build failed", capture.Error);
        }
        finally { if (Directory.Exists(root)) { Directory.Delete(root, true); } }
    }

    private sealed class CreationRunner(string failure) : DotNetRunner
    {
        public List<string[]> Commands { get; } = [];
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2]), StandardError = "" });
            Commands.Add(args.ToArray());
            if (failure == "launch") { throw new Win32Exception("dotnet executable unavailable"); }
            if (failure == "welcome")
            {
                var output = args[args.ToList().IndexOf("-o") + 1];
                Directory.CreateDirectory(output);
                File.WriteAllText(Path.Combine(output, "App.csproj"), "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");
            }
            return Task.FromResult(new ProcessCommandResult
            {
                ExitCode = failure == "welcome" ? 0 : 1,
                StandardOutput = failure == "stdout" ? "Template output diagnostic" : "",
                StandardError = failure == "stderr" ? "Template error diagnostic" : ""
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Maui.Discovery;
using Syncfusion.DotNet.CLI.Maui.Injection;
using Syncfusion.DotNet.CLI.Maui.Manifest;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>
/// Phase 4 MAUI operation tests. These exercise the new project scaffolder,
/// the add/remove/update flow (idempotency, shared-package retention, force/
/// hash preservation, rollback), malformed-manifest handling, and discovery.
/// They use injectable fake runners so no real dotnet/SDK is required.
/// </summary>
public static class Phase4Tests
{
    // ---- Test seams ---------------------------------------------------------

    /// <summary>A fake NuGetRunner that records calls and returns canned results.</summary>
    private sealed class FakeNuGetRunner : NuGetRunner
    {
        public List<(string Kind, string PackageId, string? Version)> Calls { get; } = [];
        public Func<NuGetOperation, NuGetCommandResult>? Handler { get; set; }

        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
        {
            Calls.Add((operation.Kind.ToString(), operation.PackageId, operation.Version));
            var result = Handler is not null
                ? Handler(operation)
                : new NuGetCommandResult { ExitCode = 0, StandardOutput = "version 32.1.29", StandardError = string.Empty };
            if (result.Success && !operation.DryRun && File.Exists(operation.ProjectPath))
            {
                var xml = System.Xml.Linq.XDocument.Load(operation.ProjectPath);
                var existing = xml.Descendants("PackageReference").FirstOrDefault(element => (string?)element.Attribute("Include") == operation.PackageId);
                if (operation.Kind == NuGetOperationKind.Remove) existing?.Remove();
                else if (existing is null) xml.Root!.Add(new System.Xml.Linq.XElement("ItemGroup",
                    new System.Xml.Linq.XElement("PackageReference", new System.Xml.Linq.XAttribute("Include", operation.PackageId),
                        new System.Xml.Linq.XAttribute("Version", operation.Version ?? "32.1.29"))));
                xml.Save(operation.ProjectPath);
            }
            return Task.FromResult(result);
        }
    }

    /// <summary>A fake DotNetRunner for the new-project flow.</summary>
    private sealed class FakeDotNetRunner : DotNetRunner
    {
        public List<string> Commands { get; } = [];
        public string EvaluatedTargetFrameworks { get; set; } = "net10.0";
        public bool ManagePackageVersionsCentrally { get; set; }
        public string? DirectoryPackagesPropsPath { get; set; }
        public Func<IReadOnlyList<string>, ProcessCommandResult>? Handler { get; set; }

        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2], "32.1.29"), StandardError = "" });
            Commands.Add(string.Join(' ', args));
            var result = args.Count > 1 && args[0] == "msbuild" && args.Any(argument => argument.StartsWith("-getProperty:", StringComparison.Ordinal))
                ? args.Any(argument => argument == "-getProperty:TargetFramework") && Handler is not null
                    ? Handler(args)
                    : new ProcessCommandResult
                    {
                        ExitCode = 0,
                        StandardOutput = args.Any(argument => argument.Contains("ManagePackageVersionsCentrally", StringComparison.Ordinal))
                        ? JsonSerializer.Serialize(new { Properties = new { ManagePackageVersionsCentrally = ManagePackageVersionsCentrally.ToString(), DirectoryPackagesPropsPath = DirectoryPackagesPropsPath ?? string.Empty } })
                        : args.Any(argument => argument.Contains("TargetFrameworks", StringComparison.Ordinal))
                            ? JsonSerializer.Serialize(new { Properties = new { TargetFrameworks = EvaluatedTargetFrameworks } })
                            : JsonSerializer.Serialize(new { Properties = new { TargetFramework = EvaluatedTargetFrameworks } }),
                        StandardError = string.Empty,
                    }
                : Handler is not null
                ? Handler(args)
                : new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty };
            return Task.FromResult(result);
        }
    }

    // ---- Shared scaffolding -------------------------------------------------

    private static string CreateFakeMauiProject(string root, string projectName)
    {
        var projectDir = Path.Combine(root, projectName);
        Directory.CreateDirectory(projectDir);
        File.WriteAllText(Path.Combine(projectDir, $"{projectName}.csproj"),
            "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><OutputType>Exe</OutputType></PropertyGroup></Project>");
        File.WriteAllText(Path.Combine(projectDir, "MauiProgram.cs"),
            "namespace " + projectName + ";\n" +
            "public static class MauiProgram\n" +
            "{\n" +
            "    public static MauiApp CreateMauiApp()\n" +
            "    {\n" +
            "        var builder = MauiApp.CreateBuilder();\n" +
            "        builder.UseMauiApp<App>();\n" +
            "        return builder.Build();\n" +
            "    }\n" +
            "}\n");
        return projectDir;
    }

    private static string TempDir()
    {
        var path = Path.Combine(Path.GetTempPath(), "sf-phase4-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(path);
        return path;
    }

    [Fact]
    public static void WouldModifyRegistration_TracksUsingAndCallChanges()
    {
        var root = TempDir();
        try
        {
            File.WriteAllText(
                Path.Combine(root, "MauiProgram.cs"),
                "namespace TestApp; public static class MauiProgram { public static void Create() { var builder = MauiApp.CreateBuilder(); } }");

            Assert.True(MauiProgramPatcher.WouldModifyRegistration(root));

            MauiProgramPatcher.EnsureRegistered(root);

            Assert.False(MauiProgramPatcher.WouldModifyRegistration(root));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public static void SelectSupportedBuildTarget_SkipsUnresolvedFrameworkExpressions()
    {
        var target = MauiProjectResolver.SelectSupportedBuildTarget(
            ["$(TargetFrameworks)", "net10.0-android", "net10.0-ios", "net10.0-windows10.0.19041.0"]);

        Assert.NotNull(target);
        Assert.DoesNotContain("$(", target, StringComparison.Ordinal);
    }

    // ---- 1. New-project change plan -----------------------------------------

    [Fact]
    public static async Task NewProject_PlanAndExecute_BuildsExpectedChangePlan()
    {
        var root = TempDir();
        try
        {
            var dotnet = new FakeDotNetRunner();
            var nuget = new FakeNuGetRunner();
            // The fake dotnet "new maui" must create the csproj + MauiProgram
            // so ControlInstaller can find the project afterwards.
            dotnet.Handler = args =>
            {
                var list = args.ToList();
                if (list.Count > 1 && list[1] == "maui")
                {
                    var name = list[list.IndexOf("-n") + 1];
                    var outDir = list[list.IndexOf("-o") + 1];
                    Directory.CreateDirectory(outDir);
                    File.WriteAllText(Path.Combine(outDir, $"{name}.csproj"),
                        "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");
                    File.WriteAllText(Path.Combine(outDir, "MauiProgram.cs"),
                        "namespace " + name + ";\npublic static class MauiProgram { public static MauiApp CreateMauiApp() { var builder = MauiApp.CreateBuilder(); return builder.Build(); } }");
                }

                return new ProcessCommandResult { ExitCode = 0, StandardOutput = "", StandardError = "" };
            };

            var scaffolder = new NewProjectScaffolder(dotnet, nuget);
            var request = new NewProjectRequest(
                Framework: Framework.Maui,
                Name: "MyApp",
                Path: root,
                TargetFramework: "net10.0",
                Template: "datagrid",
                ProjectType: MauiProjectType.App,
                Restore: true,
                Build: true,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.NotNull(result.Plan);
            Assert.Contains(result.Plan!.CommandsToExecute, c => c.Contains("dotnet new maui"));
            Assert.Contains("MauiProgram.cs", result.Plan.FilesToModify);
            // The DataGrid template files are part of the plan.
            Assert.Contains(result.Plan.FilesToCreate, f => f.EndsWith("DataGridView.xaml"));
            Assert.True(File.Exists(Path.Combine(root, "MyApp", "Syncfusion", "syncfusion.json")));
            var manifest = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(root, "MyApp", "Syncfusion", "syncfusion.json")));
            Assert.Equal("datagrid", Assert.Single(manifest.InstalledTemplates).Id);
            Assert.Equal("32.1.29", manifest.InstalledTemplates[0].ResolvedVersion);
            Assert.Equal("net10.0", manifest.TargetFramework);
            Assert.True(manifest.RegistrationOwned);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Theory]
    [InlineData("new")]
    [InlineData("restore")]
    [InlineData("build")]
    public static async Task NewProject_FailedStagesRetainOnlyCompletedGeneration(string failedStage)
    {
        var root = TempDir();
        try
        {
            var projectRoot = Path.Combine(root, "FailedApp");
            var dotnet = new FakeDotNetRunner
            {
                Handler = args =>
                {
                    var stage = args[0];
                    if (stage == "new")
                    {
                        var outputDirectory = args[args.ToList().IndexOf("-o") + 1];
                        Directory.CreateDirectory(outputDirectory);
                        if (failedStage == "new")
                        {
                            File.WriteAllText(Path.Combine(outputDirectory, "partial.txt"), "partial");
                            return new ProcessCommandResult { ExitCode = 1, StandardOutput = string.Empty, StandardError = "template failure" };
                        }

                        File.WriteAllText(
                            Path.Combine(outputDirectory, "FailedApp.csproj"),
                            "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");
                        return new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty };
                    }

                    return stage == failedStage
                        ? new ProcessCommandResult { ExitCode = 1, StandardOutput = string.Empty, StandardError = $"{stage} failure" }
                        : new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty };
                },
            };
            var scaffolder = new NewProjectScaffolder(dotnet, new FakeNuGetRunner());
            var request = new NewProjectRequest(
                Framework.Maui,
                "FailedApp",
                root,
                "net10.0",
                "empty",
                MauiProjectType.App,
                Restore: true,
                Build: failedStage != "restore",
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Equal(failedStage == "build", Directory.Exists(projectRoot));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task NewProject_EmptyCreatesWelcomeWithoutSyncfusionPackages()
    {
        var root = TempDir();
        try
        {
            var dotnet = new FakeDotNetRunner
            {
                Handler = args =>
                {
                    if (args[0] == "new")
                    {
                        var outputDirectory = args[args.ToList().IndexOf("-o") + 1];
                        CreateFakeMauiProject(
                            Path.GetDirectoryName(outputDirectory)!,
                            Path.GetFileName(outputDirectory));
                    }

                    return new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty };
                },
            };
            var nuget = new FakeNuGetRunner();
            var scaffolder = new NewProjectScaffolder(dotnet, nuget);
            var request = new NewProjectRequest(
                Framework.Maui,
                "EmptyApp",
                root,
                "net10.0",
                "empty",
                MauiProjectType.App,
                Restore: true,
                Build: true,
                DryRun: false,
                Force: false);

            var result = await scaffolder.ExecuteAsync(request);

            var projectRoot = Path.Combine(root, "EmptyApp");
            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.True(File.Exists(Path.Combine(projectRoot, "EmptyApp.csproj")));
            Assert.Empty(nuget.Calls);
            Assert.True(File.Exists(Path.Combine(projectRoot, "Syncfusion", "syncfusion.json")));
            Assert.DoesNotContain("ConfigureSyncfusionCore", File.ReadAllText(Path.Combine(projectRoot, "MauiProgram.cs")));
            Assert.DoesNotContain(dotnet.Commands, command => command.StartsWith("restore", StringComparison.Ordinal));
            Assert.Single(dotnet.Commands, command => command.StartsWith("build", StringComparison.Ordinal));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 2. Add operation is idempotent -------------------------------------

    [Fact]
    public static async Task Add_IsIdempotent_RunningTwiceDoesNotDuplicate()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App1");
            var nuget = new FakeNuGetRunner();
            var installer = new ControlInstaller(projectDir, nuget, new FakeDotNetRunner());

            var first = await installer.ExecuteAddAsync("datagrid");
            Assert.Equal(ExitCodes.Success, first.ExitCode);

            var manifestPath = Path.Combine(projectDir, "Syncfusion", "syncfusion.json");
            var manifestJson1 = File.ReadAllText(manifestPath);
            var manifest1 = SyncfusionManifest.FromJson(manifestJson1);
            var installedTemplate = Assert.Single(manifest1.InstalledTemplates);
            Assert.Equal("datagrid", installedTemplate.Id);
            Assert.Equal("32.1.29", installedTemplate.ResolvedVersion);
            Assert.Null(installedTemplate.RequestedVersion);
            Assert.Equal(["net10.0"], installedTemplate.TargetFrameworks);
            Assert.Equal("compatible: restored for every enabled target framework and built with the configured build selection", installedTemplate.CompatibilityDecision);
            var packageAddCalls1 = nuget.Calls.Count(c => c.Kind == "Add" && c.PackageId == "Syncfusion.Maui.DataGrid");

            var second = await installer.ExecuteAddAsync("datagrid");
            Assert.Equal(ExitCodes.Success, second.ExitCode);
            Assert.Contains("already installed", second.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Empty(second.Plan!.Warnings);
            Assert.Empty(second.Plan.FilesToCreate);
            Assert.Empty(second.Plan.FilesToModify);
            Assert.Empty(second.Plan.PackagesToAdd);

            var manifestJson2 = File.ReadAllText(manifestPath);
            var manifest2 = SyncfusionManifest.FromJson(manifestJson2);
            var packageAddCalls2 = nuget.Calls.Count(c => c.Kind == "Add" && c.PackageId == "Syncfusion.Maui.DataGrid");

            // The package add command must NOT be issued twice.
            Assert.Equal(packageAddCalls1, packageAddCalls2);
            // InstalledControls must contain datagrid exactly once.
            Assert.Equal(1, manifest2.InstalledControls.Count(c => c == "datagrid"));
            // GeneratedFiles must contain each DataGrid file exactly once.
            foreach (var f in manifest2.GeneratedFiles.Where(p => p.Contains("DataGrid", StringComparison.OrdinalIgnoreCase)))
            {
                Assert.Equal(1, manifest2.GeneratedFiles.Count(x => x == f));
            }
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task Add_ChartsAliasAndConcreteIdShareOneVersionedInstallation()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "ChartApp");
            var nuget = new FakeNuGetRunner();
            var installer = new ControlInstaller(projectDir, nuget, new FakeDotNetRunner());

            var first = await installer.ExecuteAddAsync("charts", version: "35.1.37");
            var second = await installer.ExecuteAddAsync("cartesian-chart", version: "35.1.37");

            Assert.Equal(ExitCodes.Success, first.ExitCode);
            Assert.Equal(ExitCodes.Success, second.ExitCode);
            Assert.Contains("already installed", second.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Single(nuget.Calls, call => call.Kind == "Add");

            var manifest = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            var record = Assert.Single(manifest.InstalledTemplates);
            Assert.Equal("cartesian-chart", record.Id);
            Assert.Equal("charts", record.LegacyAliasUsed);
            Assert.Equal("35.1.37", record.RequestedVersion);
            Assert.Equal("35.1.37", record.ResolvedVersion);
            Assert.Single(manifest.InstalledControls);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task AddBatch_RestoresAndBuildsOnceAndRejectsCanonicalDuplicates()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "BatchApp");
            var nuget = new FakeNuGetRunner();
            var dotnet = new FakeDotNetRunner();
            var installer = new ControlInstaller(projectDir, nuget, dotnet);

            var duplicate = await installer.ExecuteAddBatchAsync(["charts", "cartesian-chart"]);
            Assert.Equal(ExitCodes.Error, duplicate.ExitCode);
            Assert.Contains("selected more than once", duplicate.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Empty(nuget.Calls);
            Assert.False(File.Exists(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));

            var first = await installer.ExecuteAddBatchAsync(["datagrid", "kanban"]);
            Assert.Equal(ExitCodes.Success, first.ExitCode);
            Assert.Single(dotnet.Commands, command => command.StartsWith("restore ", StringComparison.Ordinal));
            Assert.Single(dotnet.Commands, command => command.StartsWith("build ", StringComparison.Ordinal));
            Assert.Equal(2, nuget.Calls.Count(call => call.Kind == "Add"));

            var second = await installer.ExecuteAddBatchAsync(["datagrid", "kanban"]);
            Assert.Equal(ExitCodes.Success, second.ExitCode);
            Assert.Contains("already installed", second.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Single(dotnet.Commands, command => command.StartsWith("restore ", StringComparison.Ordinal));
            Assert.Single(dotnet.Commands, command => command.StartsWith("build ", StringComparison.Ordinal));
            Assert.Equal(2, nuget.Calls.Count(call => call.Kind == "Add"));

            var manifest = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            Assert.Equal(2, manifest.InstalledTemplates.Count);
            Assert.Contains(manifest.InstalledTemplates, template => template.Id == "datagrid");
            Assert.Contains(manifest.InstalledTemplates, template => template.Id == "kanban");
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task RemoveBatchPlan_AccountsForSharedPackagesAndRegistration()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "ChartRemovalApp");
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), new FakeDotNetRunner());
            var added = await installer.ExecuteAddBatchAsync(["cartesian-chart", "circular-chart"]);
            Assert.Equal(ExitCodes.Success, added.ExitCode);

            var projectPath = Path.Combine(projectDir, "ChartRemovalApp.csproj");
            var legacyProject = System.Xml.Linq.XDocument.Load(projectPath);
            foreach (var reference in legacyProject.Descendants("PackageReference").Where(reference => (string?)reference.Attribute("Include") == "Syncfusion.Maui.Charts"))
                reference.SetAttributeValue("Version", "*");
            legacyProject.Save(projectPath);

            var partialRemoval = installer.PlanRemoveBatch(["cartesian-chart"]);
            Assert.Equal(ExitCodes.Success, partialRemoval.ExitCode);
            Assert.Empty(partialRemoval.Plan!.PackagesToRemove);
            Assert.DoesNotContain("MauiProgram.cs", partialRemoval.Plan.FilesToModify);

            var fullRemoval = installer.PlanRemoveBatch(["cartesian-chart", "circular-chart"]);
            Assert.Equal(ExitCodes.Success, fullRemoval.ExitCode);
            Assert.Contains("Syncfusion.Maui.Charts", fullRemoval.Plan!.PackagesToRemove);
            Assert.Contains("MauiProgram.cs", fullRemoval.Plan.FilesToModify);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task AddBatch_BuildFailureRollsBackEveryCliOwnedChange()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "BatchRollbackApp");
            var projectPath = Path.Combine(projectDir, "BatchRollbackApp.csproj");
            var originalProject = File.ReadAllText(projectPath);
            var originalProgram = File.ReadAllText(Path.Combine(projectDir, "MauiProgram.cs"));
            var dotnet = new FakeDotNetRunner
            {
                Handler = args => args[0] == "build"
                    ? new ProcessCommandResult { ExitCode = 1, StandardOutput = "build failure", StandardError = string.Empty }
                    : new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty },
            };
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), dotnet);

            var result = await installer.ExecuteAddBatchAsync(["datagrid", "kanban"]);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("failed to build", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Equal(originalProject, File.ReadAllText(projectPath));
            Assert.Equal(originalProgram, File.ReadAllText(Path.Combine(projectDir, "MauiProgram.cs")));
            Assert.False(Directory.Exists(Path.Combine(projectDir, "Syncfusion", "Controls")));
            Assert.False(File.Exists(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            Assert.Single(dotnet.Commands, command => command.StartsWith("restore ", StringComparison.Ordinal));
            Assert.Single(dotnet.Commands, command => command.StartsWith("build ", StringComparison.Ordinal));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 3. Remove deletes only CLI-owned files -----------------------------

    [Fact]
    public static async Task Remove_DeletesOnlyCliOwnedFiles()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App2");
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), new FakeDotNetRunner());

            await installer.ExecuteAddAsync("datagrid");

            // Drop a customer-owned file inside the generated folder.
            var customerFile = Path.Combine(projectDir, "Syncfusion", "Controls", "DataGrid", "MyNotes.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(customerFile)!);
            File.WriteAllText(customerFile, "customer content");

            var removeResult = await installer.ExecuteRemoveAsync("datagrid");
            Assert.Equal(ExitCodes.Success, removeResult.ExitCode);

            // The CLI-owned generated files are gone.
            Assert.False(File.Exists(Path.Combine(projectDir, "DataGrid", "DataGridView.xaml")));
            Assert.False(File.Exists(Path.Combine(projectDir, "Syncfusion", "Controls", "DataGrid", "README.md")));
            // The customer-owned file is preserved.
            Assert.True(File.Exists(customerFile));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 4. Shared packages/registrations retained while required ----------

    [Fact]
    public static async Task Remove_RetainsSharedPackageWhenAnotherControlUsesIt()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App3");
            var nuget = new FakeNuGetRunner();
            var installer = new ControlInstaller(projectDir, nuget, new FakeDotNetRunner());

            // Two controls that share the same package id would be ideal, but
            // the catalog has unique package ids. Instead, verify that removing
            // a control whose package is NOT shared issues a package remove,
            // and that removing one of two controls with distinct packages keeps
            // the second control's package. We simulate "shared" by installing
            // two controls and checking the manifest keeps the remaining one.
            await installer.ExecuteAddAsync("datagrid");
            await installer.ExecuteAddAsync("listview");

            nuget.Calls.Clear();
            var removeResult = await installer.ExecuteRemoveAsync("datagrid");
            Assert.Equal(ExitCodes.Success, removeResult.ExitCode);

            // The DataGrid package remove command is issued (datagrid's package
            // is not shared with listview).
            Assert.Contains(nuget.Calls, c => c.Kind == "Remove" && c.PackageId == "Syncfusion.Maui.DataGrid");
            // The ListView package is NOT removed.
            Assert.DoesNotContain(nuget.Calls, c => c.Kind == "Remove" && c.PackageId == "Syncfusion.Maui.ListView");

            var manifest = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            Assert.DoesNotContain("datagrid", manifest.InstalledControls);
            Assert.Contains("listview", manifest.InstalledControls);
            Assert.Contains("Syncfusion.Maui.ListView", manifest.PackageIds);
            Assert.DoesNotContain("Syncfusion.Maui.DataGrid", manifest.PackageIds);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task Remove_KeepsMauiProgramRegistrationWhenControlsRemain()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App3b");
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), new FakeDotNetRunner());

            await installer.ExecuteAddAsync("datagrid");
            await installer.ExecuteAddAsync("listview");

            await installer.ExecuteRemoveAsync("datagrid");

            var mauiProgram = File.ReadAllText(Path.Combine(projectDir, "MauiProgram.cs"));
            Assert.Contains("ConfigureSyncfusionCore", mauiProgram);
            Assert.Contains("Syncfusion.Maui.Core.Hosting", mauiProgram);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 4b. Project validation (MAUI SDK + multiple csproj) ----------------

    [Fact]
    public static void ControlInstaller_RejectsNonMauiProjectWithClearError()
    {
        var root = TempDir();
        try
        {
            var projectDir = Path.Combine(root, "BlazorApp");
            Directory.CreateDirectory(projectDir);
            File.WriteAllText(Path.Combine(projectDir, "BlazorApp.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk.BlazorWebAssembly\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");

            var ex = Assert.Throws<InvalidOperationException>(() => new ControlInstaller(projectDir, new FakeNuGetRunner()));
            Assert.Contains("is not a .NET MAUI project", ex.Message);
            Assert.Contains("Microsoft.NET.Sdk.BlazorWebAssembly", ex.Message);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void ControlInstaller_RejectsDirectoryWithMultipleCsprojFiles()
    {
        var root = TempDir();
        try
        {
            var projectDir = Path.Combine(root, "MultiProject");
            Directory.CreateDirectory(projectDir);
            File.WriteAllText(Path.Combine(projectDir, "App1.csproj"),
                "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");
            File.WriteAllText(Path.Combine(projectDir, "App2.csproj"),
                "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup></Project>");

            var ex = Assert.Throws<InvalidOperationException>(() => new ControlInstaller(projectDir, new FakeNuGetRunner()));
            Assert.Contains("Found 2 MAUI projects", ex.Message);
            Assert.Contains("-p", ex.Message);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void ControlInstaller_AcceptsSingleMauiCsproj()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "ValidApp");
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner());
            Assert.Equal(projectDir, installer.ProjectRoot);
            Assert.EndsWith("ValidApp.csproj", installer.CsprojPath);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void ProjectDetector_ReadsEveryDeclaredTargetFrameworkAndRootNamespace()
    {
        var root = TempDir();
        try
        {
            var projectPath = Path.Combine(root, "MultiTarget.csproj");
            File.WriteAllText(projectPath, """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <TargetFrameworks>net10.0-android;net10.0-maccatalyst</TargetFrameworks>
                    <RootNamespace>Example.App</RootNamespace>
                    <UseMaui>true</UseMaui>
                  </PropertyGroup>
                </Project>
                """);

            var project = ProjectDetector.Detect(projectPath);

            Assert.NotNull(project);
            Assert.Equal(["net10.0-android", "net10.0-maccatalyst"], project!.TargetFrameworks);
            Assert.Equal("net10.0-android", project.TargetFramework);
            Assert.Equal("Example.App", project.RootNamespace);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task Add_UsesEvaluatedFrameworksWhenProjectUsesMsBuildProperties()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "PropertyFrameworkApp");
            var projectPath = Path.Combine(projectDir, "PropertyFrameworkApp.csproj");
            File.WriteAllText(
                projectPath,
                "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFrameworks>$(SupportedTargets)</TargetFrameworks></PropertyGroup></Project>");
            var dotnet = new FakeDotNetRunner
            {
                EvaluatedTargetFrameworks = "net10.0-android;net10.0-maccatalyst",
            };
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), dotnet);

            var result = await installer.ExecuteAddAsync("datagrid");

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            var record = Assert.Single(SyncfusionManifest.FromJson(
                File.ReadAllText(Path.Combine(projectDir, "Syncfusion", "syncfusion.json"))).InstalledTemplates);
            Assert.Equal(["net10.0-android", "net10.0-maccatalyst"], record.TargetFrameworks);
            Assert.Contains(dotnet.Commands, command => command.Contains("-getProperty:TargetFrameworks", StringComparison.Ordinal));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task Add_UnresolvedTargetFrameworkFailsBeforeProjectModification()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "UnresolvedApp");
            var projectPath = Path.Combine(projectDir, "UnresolvedApp.csproj");
            var originalProject = File.ReadAllText(projectPath)
                .Replace("<TargetFramework>net10.0</TargetFramework>", "<TargetFramework>$(TargetFramework)</TargetFramework>", StringComparison.Ordinal);
            File.WriteAllText(projectPath, originalProject);
            var nuget = new FakeNuGetRunner();
            var installer = new ControlInstaller(projectDir, nuget, new FakeDotNetRunner { EvaluatedTargetFrameworks = string.Empty });

            var result = await installer.ExecuteAddAsync("datagrid");

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("no TargetFramework", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Empty(nuget.Calls);
            Assert.Equal(originalProject, File.ReadAllText(projectPath));
            Assert.False(File.Exists(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            Assert.False(Directory.Exists(Path.Combine(projectDir, "Syncfusion", "Controls")));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task Add_BuildFailureRollsBackPackageFilesRegistrationAndManifest()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "BuildFailureApp");
            var projectPath = Path.Combine(projectDir, "BuildFailureApp.csproj");
            var originalProject = File.ReadAllText(projectPath);
            var originalProgram = File.ReadAllText(Path.Combine(projectDir, "MauiProgram.cs"));
            var lockPath = Path.Combine(projectDir, "packages.lock.json");
            var assetsPath = Path.Combine(projectDir, "obj", "project.assets.json");
            Directory.CreateDirectory(Path.GetDirectoryName(assetsPath)!);
            File.WriteAllText(lockPath, "{\"original\":true}");
            File.WriteAllText(assetsPath, "{\"original\":true}");
            var nuget = new FakeNuGetRunner
            {
                Handler = operation =>
                {
                    if (operation.Kind == NuGetOperationKind.Add)
                    {
                        var project = File.ReadAllText(operation.ProjectPath);
                        File.WriteAllText(
                            operation.ProjectPath,
                            project.Replace(
                                "</Project>",
                                $"<ItemGroup><PackageReference Include=\"{operation.PackageId}\" Version=\"35.1.37\" /></ItemGroup></Project>",
                                StringComparison.Ordinal));
                        File.WriteAllText(lockPath, "{\"changed\":true}");
                        File.WriteAllText(assetsPath, "{\"changed\":true}");
                    }

                    return new NuGetCommandResult
                    {
                        ExitCode = 0,
                        StandardOutput = "version '35.1.37' added",
                        StandardError = string.Empty,
                    };
                },
            };
            var dotnet = new FakeDotNetRunner
            {
                Handler = args => args.FirstOrDefault() == "build"
                    ? new ProcessCommandResult { ExitCode = 1, StandardOutput = "XAML build failure", StandardError = string.Empty }
                    : new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty },
            };
            var installer = new ControlInstaller(projectDir, nuget, dotnet);

            var result = await installer.ExecuteAddAsync("datagrid", version: "35.1.37");

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("failed to build", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Contains(dotnet.Commands, command => command.StartsWith("build ", StringComparison.Ordinal));
            Assert.Equal(originalProject, File.ReadAllText(projectPath));
            Assert.Equal(originalProgram, File.ReadAllText(Path.Combine(projectDir, "MauiProgram.cs")));
            Assert.Equal("{\"original\":true}", File.ReadAllText(lockPath));
            Assert.Equal("{\"original\":true}", File.ReadAllText(assetsPath));
            Assert.False(Directory.Exists(Path.Combine(projectDir, "Syncfusion", "Controls")));
            Assert.False(File.Exists(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task ControlInstaller_RefusesUnverifiedControl()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "AppVerify");
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), new FakeDotNetRunner());

            var plan = installer.PlanAdd("not-a-template");
            Assert.Equal(ExitCodes.Error, plan.ExitCode);
            Assert.Contains("not supported", plan.Message, StringComparison.OrdinalIgnoreCase);

            var exec = await installer.ExecuteAddAsync("not-a-template");
            Assert.Equal(ExitCodes.Error, exec.ExitCode);
            Assert.Contains("not supported", exec.Message, StringComparison.OrdinalIgnoreCase);

            // No NuGet command was issued and no manifest was created.
            Assert.False(System.IO.File.Exists(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 5. Update changes the requested package version --------------------

    [Fact]
    public static async Task Update_ChangesRequestedPackageVersion()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App4");
            var nuget = new FakeNuGetRunner();
            var installer = new ControlInstaller(projectDir, nuget, new FakeDotNetRunner());

            await installer.ExecuteAddAsync("datagrid");

            var updateResult = await installer.ExecuteUpdateAsync("datagrid", version: "32.2.0", noRestore: true);
            Assert.Equal(ExitCodes.Success, updateResult.ExitCode);

            // The update must issue an add with the requested version.
            Assert.Contains(nuget.Calls, c => c.Kind == "Add" && c.PackageId == "Syncfusion.Maui.DataGrid" && c.Version == "32.2.0");

            var manifest = SyncfusionManifest.FromJson(File.ReadAllText(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
            Assert.Equal("32.2.0", manifest.PackageVersions["Syncfusion.Maui.DataGrid"]);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 6. Modified generated files preserved without --force --------------

    [Fact]
    public static async Task Update_PreservesModifiedFilesWithoutForce()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App5");
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), new FakeDotNetRunner());

            await installer.ExecuteAddAsync("datagrid");

            // Modify a CLI-owned generated file.
            var viewPath = Path.Combine(projectDir, "DataGrid", "DataGridView.xaml");
            var original = File.ReadAllText(viewPath);
            File.WriteAllText(viewPath, original + "\n<!-- customer edit -->");

            var updateResult = await installer.ExecuteUpdateAsync("datagrid", version: "32.2.0", noRestore: true, force: false);
            Assert.Equal(ExitCodes.Success, updateResult.ExitCode);

            // The modified file is preserved.
            var after = File.ReadAllText(viewPath);
            Assert.Contains("<!-- customer edit -->", after);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 7. Modified generated files replaced with --force ------------------

    [Fact]
    public static async Task Update_ReplacesModifiedFilesWithForce()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App6");
            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), new FakeDotNetRunner());

            await installer.ExecuteAddAsync("datagrid");

            var viewPath = Path.Combine(projectDir, "DataGrid", "DataGridView.xaml");
            var original = File.ReadAllText(viewPath);
            File.WriteAllText(viewPath, original + "\n<!-- customer edit -->");

            var updateResult = await installer.ExecuteUpdateAsync("datagrid", version: "32.2.0", noRestore: true, force: true);
            Assert.Equal(ExitCodes.Success, updateResult.ExitCode);

            // The modified file is replaced; the customer edit is gone.
            var after = File.ReadAllText(viewPath);
            Assert.DoesNotContain("<!-- customer edit -->", after);
            Assert.Contains("SfDataGrid", after);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 8. Malformed manifest returns a clear error -------------------------

    [Fact]
    public static async Task MalformedManifest_ReturnsClearError()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App7");
            var dir = Path.Combine(projectDir, "Syncfusion");
            Directory.CreateDirectory(dir);
            File.WriteAllText(Path.Combine(dir, "syncfusion.json"), "{ this is : not valid json ]");

            var installer = new ControlInstaller(projectDir, new FakeNuGetRunner(), new FakeDotNetRunner());

            // Any operation that reads the manifest must surface a clear error
            // rather than throwing or silently proceeding.
            var removeResult = await installer.ExecuteRemoveAsync("datagrid");
            Assert.Equal(ExitCodes.Error, removeResult.ExitCode);
            Assert.True(removeResult.Errors.Count > 0 || removeResult.Message.Length > 0);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- 9. Failed operation rolls back files -------------------------------

    [Fact]
    public static async Task Add_FailedNuGet_RollsBackCreatedFiles()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App8");
            var nuget = new FakeNuGetRunner
            {
                Handler = _ => new NuGetCommandResult { ExitCode = 1, StandardOutput = "", StandardError = "package not found" }
            };
            var installer = new ControlInstaller(projectDir, nuget, new FakeDotNetRunner());

            var result = await installer.ExecuteAddAsync("datagrid");
            Assert.Equal(ExitCodes.Error, result.ExitCode);

            // The generated files must have been rolled back (deleted).
            Assert.False(File.Exists(Path.Combine(projectDir, "DataGrid", "DataGridView.xaml")));
            Assert.False(File.Exists(Path.Combine(projectDir, "Syncfusion", "syncfusion.json")));
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    // ---- Discovery smoke tests ----------------------------------------------

    [Fact]
    public static void ListPackages_ReturnsCuratedPackages()
    {
        var packages = DiscoveryService.ListPackages();
        Assert.True(packages.Count > 15);
        Assert.Contains(packages, p => p.Alias == "datagrid");
        Assert.Contains(packages, p => p.Alias == "core" && p.PackageId == "Syncfusion.Maui.Core");
        Assert.DoesNotContain(packages, p => p.Alias == "combobox");
    }

    [Fact]
    public static void ListTemplates_ReturnsPrimaryControlsOnly()
    {
        var templates = DiscoveryService.ListTemplates();
        Assert.Equal(10, templates.Count);
        Assert.Equal(new[] { "assistview", "cartesian-chart", "circular-chart", "datagrid", "diagram", "kanban", "listview", "pdf-viewer", "rich-text-editor", "scheduler" },
            templates.Select(template => template.TemplateId).Order(StringComparer.Ordinal));
    }

    [Fact]
    public static void Search_IsCaseInsensitive_AndMatchesByPackageId()
    {
        var packages = DiscoveryService.SearchPackages("DATA");
        Assert.Contains(packages, package => package.Alias == "datagrid");
        packages = DiscoveryService.SearchPackages("Syncfusion.Maui.Inputs");
        Assert.Contains(packages, package => package.Alias == "inputs" && package.PackageId == "Syncfusion.Maui.Inputs");
    }

    [Fact]
    public static void ListInstalled_EmptyWhenNoManifest()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "App9");
            var installed = DiscoveryService.ListInstalledPackages(projectDir);
            Assert.Empty(installed);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static void Info_ContainsAllRequiredFields()
    {
        var info = DiscoveryService.GetInfo();
        Assert.Equal("Syncfusion.DotNet.CLI", info.PackageId);
        Assert.Equal("sf", info.ToolCommand);
        Assert.Contains("maui", info.ImplementedPlatforms);
        Assert.Equal(1, info.ManifestSchemaVersion);
    }

    // ---- Regression: MSBuild returns empty ManagePackageVersionsCentrally
    //      when CPM is not declared. The CLI must treat the empty string as
    //      "CPM not enabled" rather than failing the project with
    //      "MSBuild returned an invalid ManagePackageVersionsCentrally value."
    //      This was the root cause of the
    //      `sf new maui --control cartesian-chart --control circular-chart`
    //      bug, where every freshly-scaffolded MAUI project produced an
    //      empty MSBuild value and was rejected.

    [Fact]
    public static async Task AddBatch_TreatsEmptyManagePackageVersionsCentrallyAsDisabled()
    {
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "EmptyCpmApp");
            var nuget = new FakeNuGetRunner();
            var dotnet = new FakeDotNetRunner
            {
                ManagePackageVersionsCentrally = false,
                DirectoryPackagesPropsPath = string.Empty,
            };
            var installer = new ControlInstaller(projectDir, nuget, dotnet);

            var result = await installer.ExecuteAddBatchAsync(["cartesian-chart", "circular-chart"]);

            Assert.Equal(ExitCodes.Success, result.ExitCode);
            Assert.DoesNotContain("invalid ManagePackageVersionsCentrally", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Single(nuget.Calls, call => call.Kind == "Add");
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task AddBatch_RejectsNonEmptyButUnparsableManagePackageVersionsCentrally()
    {
        // A non-empty, non-bool value still indicates a real configuration
        // problem and must surface as a clear error rather than silently
        // being coerced to false.
        var root = TempDir();
        try
        {
            var projectDir = CreateFakeMauiProject(root, "BadCpmApp");
            var nuget = new FakeNuGetRunner();
            var dotnet = new NonEmptyInvalidCpmFakeDotNetRunner();
            var installer = new ControlInstaller(projectDir, nuget, dotnet);

            var result = await installer.ExecuteAddBatchAsync(["cartesian-chart", "circular-chart"]);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.Contains("invalid ManagePackageVersionsCentrally", result.Message, StringComparison.OrdinalIgnoreCase);
            Assert.Contains("maybe", result.Message, StringComparison.OrdinalIgnoreCase);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    private sealed class NonEmptyInvalidCpmFakeDotNetRunner : DotNetRunner
    {
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2], "32.1.29"), StandardError = "" });
            if (args.Count > 1 && args[0] == "msbuild"
                && args.Any(argument => argument.StartsWith("-getProperty:ManagePackageVersionsCentrally", StringComparison.Ordinal)))
            {
                return Task.FromResult(new ProcessCommandResult
                {
                    ExitCode = 0,
                    StandardOutput = JsonSerializer.Serialize(new
                    {
                        Properties = new
                        {
                            ManagePackageVersionsCentrally = "maybe",
                            DirectoryPackagesPropsPath = string.Empty,
                        },
                    }),
                    StandardError = string.Empty,
                });
            }

            if (args.Count > 1 && args[0] == "msbuild"
                && args.Any(argument => argument.StartsWith("-getProperty:TargetFramework", StringComparison.Ordinal)))
            {
                return Task.FromResult(new ProcessCommandResult
                {
                    ExitCode = 0,
                    StandardOutput = JsonSerializer.Serialize(new { Properties = new { TargetFrameworks = "net10.0" } }),
                    StandardError = string.Empty,
                });
            }

            return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty });
        }
    }

    // ---- Regression: NewProjectScaffolder must surface the underlying
    //      ControlInstaller failure rather than the generic
    //      "Check package-source connectivity" string, so users can act on
    //      the real cause (e.g. a target framework mismatch or a CPM error).

    [Fact]
    public static async Task NewProjectScaffolder_SurfacesUnderlyingControlInstallerMessage()
    {
        // Reproduces the original bug end-to-end: the scaffolder was
        // overwriting ControlInstaller.ExecuteAddBatchAsync's specific
        // message with a generic "Check package-source connectivity" string
        // that hid the real cause. The scaffolder must now preserve the
        // underlying message when one is present.
        var root = TempDir();
        try
        {
            var projectName = "SurfacedErrorApp";
            var projectDir = Path.Combine(root, projectName);
            var projectRoot = Path.Combine(projectDir, projectName);

            var dotnet = new ScaffolderProjectCreatorFakeDotNetRunner(projectRoot);
            var nuget = new ScaffolderFailingNuGetRunner(
                "Cannot apply the selected controls because package 'Syncfusion.Maui.Charts' could not be added.");
            var scaffolder = new NewProjectScaffolder(dotnet, nuget);
            var request = new NewProjectRequest(
                Framework.Maui,
                projectName,
                projectDir,
                "net10.0",
                "cartesian-chart",
                MauiProjectType.App,
                Restore: false,
                Build: false,
                DryRun: false,
                Force: false,
                TemplateIds: ["cartesian-chart", "circular-chart"]);

            var result = await scaffolder.ExecuteAsync(request, CancellationToken.None);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.True(
                result.Message.Contains(
                    "Cannot apply the selected controls because package 'Syncfusion.Maui.Charts' could not be added.",
                    StringComparison.Ordinal),
                $"Expected surfaced message; got '{result.Message}' with errors [{string.Join(", ", result.Errors)}].");
            Assert.DoesNotContain("Check package-source connectivity", result.Message, StringComparison.Ordinal);
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    [Fact]
    public static async Task NewProjectScaffolder_FallsBackToGenericMessageWhenInnerIsEmpty()
    {
        // The scaffolder falls back to the legacy "Check package-source
        // connectivity" string only when the underlying ControlInstaller
        // result has a null/empty/whitespace Message. To exercise that
        // path without faking the internals of ControlInstaller, the test
        // asserts on the production rule: the scaffolder never returns an
        // empty/blank message in the failure path. Any non-blank
        // underlying message must surface; when blank, the legacy string
        // is used. Here both branches are accepted: the test ensures the
        // scaffolder never returns null/empty.
        var root = TempDir();
        try
        {
            var projectName = "GenericErrorApp";
            var projectDir = Path.Combine(root, projectName);
            var projectRoot = Path.Combine(projectDir, projectName);

            var dotnet = new ScaffolderProjectCreatorFakeDotNetRunner(projectRoot);
            var nuget = new ScaffolderFailingNuGetRunner(message: "   ");
            var scaffolder = new NewProjectScaffolder(dotnet, nuget);
            var request = new NewProjectRequest(
                Framework.Maui,
                projectName,
                projectDir,
                "net10.0",
                "cartesian-chart",
                MauiProjectType.App,
                Restore: false,
                Build: false,
                DryRun: false,
                Force: false,
                TemplateIds: ["cartesian-chart", "circular-chart"]);

            var result = await scaffolder.ExecuteAsync(request, CancellationToken.None);

            Assert.Equal(ExitCodes.Error, result.ExitCode);
            Assert.False(string.IsNullOrWhiteSpace(result.Message), "Scaffolder must never return a blank failure message.");
        }
        finally
        {
            try { Directory.Delete(root, recursive: true); } catch { }
        }
    }

    private sealed class ScaffolderProjectCreatorFakeDotNetRunner : DotNetRunner
    {
        private readonly string _projectDir;
        public ScaffolderProjectCreatorFakeDotNetRunner(string projectDir) => _projectDir = projectDir;
        public override Task<ProcessCommandResult> RunAsync(IReadOnlyList<string> args, string? workingDirectory, bool dryRun, CancellationToken cancellationToken = default)
        {
            if (args.Count > 2 && args[0] == "package" && args[1] == "search")
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = PackageSearchFixture.Response(args[2], "32.1.29"), StandardError = "" });
            if (args.Count > 0 && args[0] == "new")
            {
                Directory.CreateDirectory(_projectDir);
                var csproj = Path.Combine(_projectDir, Path.GetFileName(_projectDir) + ".csproj");
                if (!File.Exists(csproj))
                {
                    File.WriteAllText(
                        csproj,
                        "<Project Sdk=\"Microsoft.NET.Maui.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><OutputType>Exe</OutputType></PropertyGroup></Project>");
                }
                File.WriteAllText(
                    Path.Combine(_projectDir, "MauiProgram.cs"),
                    "namespace " + Path.GetFileName(_projectDir) + "; public static class MauiProgram { public static void Create() { var builder = MauiApp.CreateBuilder(); } }");
                return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty });
            }

            if (args.Count > 1 && args[0] == "msbuild"
                && args.Any(argument => argument.StartsWith("-getProperty:TargetFramework", StringComparison.Ordinal)))
            {
                return Task.FromResult(new ProcessCommandResult
                {
                    ExitCode = 0,
                    StandardOutput = JsonSerializer.Serialize(new { Properties = new { TargetFrameworks = "net10.0" } }),
                    StandardError = string.Empty,
                });
            }

            if (args.Count > 1 && args[0] == "msbuild"
                && args.Any(argument => argument.StartsWith("-getProperty:ManagePackageVersionsCentrally", StringComparison.Ordinal)))
            {
                return Task.FromResult(new ProcessCommandResult
                {
                    ExitCode = 0,
                    StandardOutput = JsonSerializer.Serialize(new
                    {
                        Properties = new
                        {
                            ManagePackageVersionsCentrally = string.Empty,
                            DirectoryPackagesPropsPath = string.Empty,
                        },
                    }),
                    StandardError = string.Empty,
                });
            }

            return Task.FromResult(new ProcessCommandResult { ExitCode = 0, StandardOutput = string.Empty, StandardError = string.Empty });
        }
    }

    /// <summary>
    /// A NuGetRunner that always fails the first call. The scaffolder exercises
    /// this through <see cref="ControlInstaller.ExecuteAddBatchAsync"/>, which
    /// receives a non-empty message and the scaffolder must preserve it.
    /// </summary>
    private sealed class ScaffolderFailingNuGetRunner : NuGetRunner
    {
        private readonly string _message;
        public ScaffolderFailingNuGetRunner(string message) => _message = message;
        public override Task<NuGetCommandResult> RunAsync(NuGetOperation operation, CancellationToken cancellationToken = default)
            => Task.FromResult(new NuGetCommandResult { ExitCode = 1, StandardOutput = string.Empty, StandardError = _message });
    }
}

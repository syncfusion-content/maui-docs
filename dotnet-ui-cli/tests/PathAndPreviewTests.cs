using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Syncfusion.DotNet.CLI.Presentation;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>
/// Tests for path normalization and equivalent-command preview formatting.
/// </summary>
public static class PathAndPreviewTests
{
    [Fact]
    public static void Normalize_NullOrEmpty_ReturnsCurrentDirectory()
    {
        Assert.Equal(System.Environment.CurrentDirectory, PathNormalizer.Normalize(null));
        Assert.Equal(System.Environment.CurrentDirectory, PathNormalizer.Normalize(""));
        Assert.Equal(System.Environment.CurrentDirectory, PathNormalizer.Normalize("   "));
    }

    [Fact]
    public static void Normalize_Dot_ReturnsCurrentDirectory()
    {
        Assert.Equal(System.Environment.CurrentDirectory, PathNormalizer.Normalize("."));
    }

    [Fact]
    public static void Normalize_RelativePath_ReturnsFullPath()
    {
        var normalized = PathNormalizer.Normalize("subdir");
        Assert.True(System.IO.Path.IsPathRooted(normalized));
        Assert.EndsWith("subdir", normalized);
    }

    [Fact]
    public static void ForDisplay_WithSpaces_IsQuoted()
    {
        Assert.Equal("\"D:\\My Projects\"", PathNormalizer.ForDisplay("D:\\My Projects"));
    }

    [Fact]
    public static void ForDisplay_WithoutSpaces_IsUnquoted()
    {
        Assert.Equal("D:\\Projects", PathNormalizer.ForDisplay("D:\\Projects"));
    }

    [Fact]
    public static void Preview_NewProjectRequest_QuotesSpacedPath()
    {
        var request = new NewProjectRequest(
            Framework.Maui, "My App", "D:\\My Projects", "net10.0", "datagrid",
            MauiProjectType.App, Restore: true, Build: false,
            DryRun: false, Force: false);
        var preview = CommandPreview.Format(request);
        Assert.StartsWith("sf new maui -n \"My App\" -p \"D:\\My Projects\"", preview);
        Assert.Contains("--control datagrid", preview);
        Assert.DoesNotContain("--template", preview);
        Assert.Contains("--no-build", preview);
    }

    [Fact]
    public static void Preview_NewProjectRequest_NoSpaces_NotQuoted()
    {
        var request = new NewProjectRequest(
            Framework.Maui, "MyApp", "D:\\Projects", "net10.0", "datagrid",
            MauiProjectType.BlazorHybrid, Restore: false, Build: true,
            DryRun: false, Force: false);
        var preview = CommandPreview.Format(request);
        Assert.StartsWith("sf new maui -n MyApp -p D:\\Projects", preview);
        Assert.DoesNotContain("--theme", preview);
        Assert.Contains("--project-type blazor-hybrid", preview);
        Assert.Contains("--no-restore", preview);
    }

    [Fact]
    public static void Preview_AddPackageRequest()
    {
        var request = new AddPackageRequest(
            Framework.Maui, "datagrid", "D:\\Projects", "32.1.29",
            Restore: true, DryRun: true, Force: false);
        var preview = CommandPreview.Format(request);
        Assert.StartsWith("sf add maui datagrid -p D:\\Projects -v 32.1.29", preview);
        Assert.Contains("--dry-run", preview);
    }

    [Fact]
    public static void Preview_RemovePackageRequest()
    {
        var request = new RemovePackageRequest(
            Framework.Maui, "datagrid", "D:\\Projects", DryRun: false, Force: true);
        Assert.Equal("sf remove maui datagrid -p D:\\Projects --force", CommandPreview.Format(request));
    }

    [Fact]
    public static void Preview_UpdatePackageRequest()
    {
        var request = new UpdatePackageRequest(
            Framework.Maui, "datagrid", "D:\\Projects", "32.2.0",
            Restore: true, DryRun: false, Force: false);
        Assert.Equal("sf update maui datagrid -p D:\\Projects -v 32.2.0 --restore", CommandPreview.Format(request));
    }

    [Fact]
    public static void Preview_ListRequest()
    {
        Assert.Equal("sf list maui templates", CommandPreview.Format(new ListRequest(ListCategory.Templates, Framework.Maui)));
        Assert.Equal("sf list maui installed", CommandPreview.Format(new ListRequest(ListCategory.Installed, Framework.Maui)));
    }

    [Fact]
    public static void Preview_SearchRequest_QuotesSpaces()
    {
        Assert.Equal("sf search maui \"data grid\"", CommandPreview.Format(new SearchRequest("data grid", Framework.Maui)));
        Assert.Equal("sf search maui grid", CommandPreview.Format(new SearchRequest("grid", Framework.Maui)));
    }

    [Fact]
    public static void Preview_InfoRequest()
    {
        Assert.Equal("sf info", CommandPreview.Format(new InfoRequest()));
    }
}

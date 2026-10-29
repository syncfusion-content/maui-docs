using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Blazor;

public enum BlazorAppType { WebApp, WebAssemblyStandalone }
public enum BlazorRenderMode { Server, WebAssembly, Auto }
public enum BlazorInteractivity { PerPage, Global }
public enum BlazorAuthentication { None, Individual }

public sealed record BlazorNewRequest(
    string Name,
    string Location,
    BlazorAppType AppType,
    string TargetFramework,
    BlazorRenderMode RenderMode,
    BlazorInteractivity Interactivity,
    BlazorAuthentication Authentication,
    bool Https,
    bool DemoPages,
    string Theme,
    IReadOnlyList<string> Controls,
    bool Restore,
    bool Build,
    bool DryRun = false,
    string? Version = null,
    string? Source = null,
    string? ConfigFile = null)
{
    public string ProjectDirectory => Path.Combine(Location, Name);
}

public static class BlazorConfiguration
{
    public static string? Validate(BlazorNewRequest request, IReadOnlyList<string> templateFrameworks)
    {
        if (DesktopConfiguration.ValidateProjectName(request.Name) is { } nameError) return nameError;
        if (!templateFrameworks.Contains(request.TargetFramework))
            return $"The installed '{Template(request.AppType)}' template does not support {request.TargetFramework}. Supported: {string.Join(", ", templateFrameworks)}.";
        if (request.AppType == BlazorAppType.WebAssemblyStandalone && request.Authentication == BlazorAuthentication.Individual)
            return "Standalone WebAssembly Individual authentication requires an identity-provider authority and client ID. This CLI does not generate placeholder credentials; use --auth none.";
        if (request.Authentication == BlazorAuthentication.Individual && !request.Https)
            return "Individual accounts require HTTPS. Use --https yes.";
        if (request.AppType == BlazorAppType.WebAssemblyStandalone && request.RenderMode != BlazorRenderMode.WebAssembly)
            return "Standalone WebAssembly uses WebAssembly rendering.";
        if (!request.DemoPages && request.Controls.Count > 0) return "Empty project cannot include Syncfusion demo components.";
        if (!BlazorCatalog.Themes.Any(theme => theme.Id == request.Theme)) return $"Unknown Blazor theme '{request.Theme}'.";
        if (request.Controls.Any(control => BlazorCatalog.Resolve(control) is not { HasTemplate: true }))
            return "Available Blazor controls: " + string.Join(", ", BlazorCatalog.Packages.Where(package => package.HasTemplate).Select(package => package.Alias)) + ".";
        if (request.Build && !request.Restore) return "Building requires restore. Remove --no-restore or choose --post-action generate.";
        return null;
    }

    public static string Template(BlazorAppType appType) => appType == BlazorAppType.WebApp ? "blazor" : "blazorwasm";
}

public sealed class BlazorManifest : DesktopManifest
{
    public string AppType { get; set; } = "web-app";
    public string RenderMode { get; set; } = "server";
    public string Interactivity { get; set; } = "per-page";
    public string Authentication { get; set; } = "none";
    public bool Https { get; set; }
}

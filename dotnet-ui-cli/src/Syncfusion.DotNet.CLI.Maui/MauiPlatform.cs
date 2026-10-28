using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// Describes the .NET MAUI framework support that the CLI performs. Exposes
/// the framework identity and a short description used by <c>sf info</c> and
/// the interactive menu. Scaffolding details arrive in a later phase.
/// </summary>
public static class MauiPlatform
{
    /// <summary>The <see cref="Framework"/> value represented by this project.</summary>
    public const Framework Framework = Core.Framework.Maui;

    /// <summary>The lowercase name used on the command line and in menus.</summary>
    public const string Name = "maui";

    /// <summary>Gets a value indicating whether MAUI support is implemented and ready.</summary>
    public const bool IsImplemented = true;

    /// <summary>A short description shown in <c>sf info</c> and the menu.</summary>
    public const string Description = ".NET MAUI cross-platform applications (Android, iOS, Windows, macOS).";
}

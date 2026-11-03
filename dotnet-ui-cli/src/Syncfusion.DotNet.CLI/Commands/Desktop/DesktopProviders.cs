using Syncfusion.DotNet.Cli.Core;
using Syncfusion.DotNet.Cli.WPF;
using Syncfusion.DotNet.Cli.WinForms;
using Syncfusion.DotNet.Cli.WinUI;
using Syncfusion.DotNet.Cli.Blazor;

namespace Syncfusion.DotNet.Cli.Commands.Desktop;

internal static class DesktopProviders
{
    private static readonly BlazorPlatformProvider Blazor = new();
    internal static IReadOnlyList<IDesktopPlatformProvider> All { get; } =
        [new WPFPlatformProvider(), new WinFormsPlatformProvider(), new WinUIPlatformProvider()];
    internal static IDesktopPlatformProvider? Find(Framework platform)
        => platform == Framework.Blazor ? Blazor : All.FirstOrDefault(provider => provider.Platform == platform);
    internal static IDesktopPlatformProvider? Find(string? platform)
        => Frameworks.TryParse(platform, out var framework) ? Find(framework) : null;
}

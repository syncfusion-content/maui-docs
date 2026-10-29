using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.WPF;
using Syncfusion.DotNet.CLI.WinForms;
using Syncfusion.DotNet.CLI.WinUI;
using Syncfusion.DotNet.CLI.Blazor;

namespace Syncfusion.DotNet.CLI.Commands.Desktop;

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

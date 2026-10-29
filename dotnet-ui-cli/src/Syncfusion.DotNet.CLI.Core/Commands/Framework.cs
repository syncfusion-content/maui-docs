namespace Syncfusion.DotNet.CLI.Core;

/// <summary>
/// The .NET UI frameworks the Syncfusion .NET CLI can scaffold and manage.
/// MAUI and Windows desktop platforms have platform-specific providers.
/// </summary>
public enum Framework
{
    /// <summary>.NET MAUI multi-platform applications.</summary>
    Maui,

    /// <summary>Blazor web applications.</summary>
    Blazor,

    /// <summary>Windows Presentation Foundation desktop applications.</summary>
    WPF,

    /// <summary>WinUI 3 desktop applications.</summary>
    WinUI,

    /// <summary>Windows Forms desktop applications.</summary>
    WinForms,
}

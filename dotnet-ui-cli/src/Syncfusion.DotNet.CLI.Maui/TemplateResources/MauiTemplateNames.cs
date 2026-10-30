namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Canonical UI class names for the shipped MAUI templates.</summary>
public static class MauiTemplateNames
{
    public static string ViewName(string controlName) => controlName switch
    {
        "AIAssistView" or "ListView" or "PdfViewer" => controlName + "Page",
        _ => controlName + "View",
    };
}

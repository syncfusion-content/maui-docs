using System.IO;

namespace Syncfusion.DotNet.CLI.Maui.Injection;

/// <summary>
/// Adds and removes one navigation button per installed control on the
/// default MAUI <c>MainPage</c>. Every injected line carries an
/// <c>sf-nav:&lt;ControlName&gt;</c> marker so the operation is idempotent and
/// reversible. Pages that do not match the standard template are left alone.
/// </summary>
public static class MainPageNavigationPatcher
{
    private const string Marker = "sf-nav:";

    public static IReadOnlyList<string> Paths(string projectRoot)
        => [Path.Combine(projectRoot, "MainPage.xaml"), Path.Combine(projectRoot, "MainPage.xaml.cs")];

    public static bool CanPatch(string projectRoot)
        => Paths(projectRoot).All(File.Exists)
            && FindXamlInsertIndex(File.ReadAllText(Paths(projectRoot)[0])) >= 0
            && FindClassEnd(File.ReadAllText(Paths(projectRoot)[1])) >= 0;

    public static void Add(string projectRoot, string rootNamespace, string controlName, string displayName)
    {
        if (!CanPatch(projectRoot))
        {
            return;
        }

        var tag = Marker + controlName;
        var xamlPath = Paths(projectRoot)[0];
        var xaml = File.ReadAllText(xamlPath);
        if (!xaml.Contains(tag, StringComparison.Ordinal))
        {
            var index = FindXamlInsertIndex(xaml);
            var button = "\n" + GeneratedCodeBlocks.Wrap(tag,
                $"            <Button Text=\"{System.Security.SecurityElement.Escape(displayName)}\" Clicked=\"OnOpen{controlName}Clicked\" HorizontalOptions=\"Fill\" />",
                xaml: true, indent: "            ") + "            ";
            File.WriteAllText(xamlPath, xaml.Insert(index, button));
        }

        var codePath = Paths(projectRoot)[1];
        var code = File.ReadAllText(codePath);
        if (!code.Contains(tag, StringComparison.Ordinal))
        {
            var end = FindClassEnd(code);
            var view = $"global::{rootNamespace}.{controlName}.{MauiTemplateNames.ViewName(controlName)}";
            var handler = GeneratedCodeBlocks.Wrap(tag,
                $"    private async void OnOpen{controlName}Clicked(object? sender, EventArgs e) => await Navigation.PushAsync(new {view}());",
                indent: "    ");
            var lineStart = code.LastIndexOf('\n', end - 1) + 1;
            File.WriteAllText(codePath, code.Insert(lineStart, handler));
        }
    }

    public static void Remove(string projectRoot, string controlName)
    {
        var tag = Marker + controlName;
        foreach (var path in Paths(projectRoot).Where(File.Exists))
        {
            var text = File.ReadAllText(path);
            var updated = GeneratedCodeBlocks.Remove(text, tag);
            if (text != updated) File.WriteAllText(path, updated);
        }
    }

    public static string BlockContent(string path, string rootNamespace, string controlName, string displayName)
    {
        var tag = Marker + controlName;
        return path.EndsWith(".xaml", StringComparison.OrdinalIgnoreCase)
            ? GeneratedCodeBlocks.Wrap(tag,
                $"            <Button Text=\"{System.Security.SecurityElement.Escape(displayName)}\" Clicked=\"OnOpen{controlName}Clicked\" HorizontalOptions=\"Fill\" />", xaml: true, indent: "            ")
            : GeneratedCodeBlocks.Wrap(tag,
                $"    private async void OnOpen{controlName}Clicked(object? sender, EventArgs e) => await Navigation.PushAsync(new global::{rootNamespace}.{controlName}.{MauiTemplateNames.ViewName(controlName)}());", indent: "    ");
    }

    private static int FindXamlInsertIndex(string xaml)
    {
        foreach (var closing in new[] { "</VerticalStackLayout>", "</StackLayout>" })
        {
            var index = xaml.LastIndexOf(closing, StringComparison.Ordinal);
            if (index >= 0)
            {
                return index;
            }
        }

        return -1;
    }

    private static int FindClassEnd(string code)
    {
        var classIndex = code.IndexOf("partial class MainPage", StringComparison.Ordinal);
        if (classIndex < 0)
        {
            return -1;
        }

        var open = code.IndexOf('{', classIndex);
        if (open < 0)
        {
            return -1;
        }

        var depth = 0;
        for (var i = open; i < code.Length; i++)
        {
            if (code[i] == '{')
            {
                depth++;
            }
            else if (code[i] == '}' && --depth == 0)
            {
                return i;
            }
        }

        return -1;
    }
}

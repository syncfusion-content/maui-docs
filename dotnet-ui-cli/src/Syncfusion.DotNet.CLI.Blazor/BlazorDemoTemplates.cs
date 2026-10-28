namespace Syncfusion.DotNet.CLI.Blazor;

internal static class BlazorDemoTemplates
{
    internal static string Page(string control, string renderDirective) => Sources(control, renderDirective, "App.Pages")
        .Single(file => file.Key.EndsWith(".razor", StringComparison.Ordinal)).Value;

    internal static IReadOnlyDictionary<string, string> Sources(string control, string renderDirective, string pageNamespace, BlazorAppType appType = BlazorAppType.WebApp)
    {
        var package = BlazorCatalog.Resolve(control);
        if (package is null || !package.HasTemplate)
            throw new ArgumentOutOfRangeException(nameof(control));
        var assembly = typeof(BlazorDemoTemplates).Assembly;
        var root = $"{assembly.GetName().Name}.Templates.Controls.";
        var variant = appType == BlazorAppType.WebAssemblyStandalone ? "Wasm" : "Web";
        var prefix = $"{root}{variant}.{package.Alias}.";
        if (!assembly.GetManifestResourceNames().Any(name => name.StartsWith(prefix, StringComparison.Ordinal)))
            prefix = $"{root}Shared.{package.Alias}.";
        var files = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var resource in assembly.GetManifestResourceNames().Where(name => name.StartsWith(prefix, StringComparison.Ordinal)))
        {
            using var reader = new StreamReader(assembly.GetManifestResourceStream(resource)!);
            files.Add(resource[prefix.Length..], reader.ReadToEnd()
                .Replace("__RENDER_DIRECTIVE__", renderDirective, StringComparison.Ordinal)
                .Replace("__PAGE_NAMESPACE__", pageNamespace, StringComparison.Ordinal)
                .Replace("__DISPLAY_NAME__", package.DisplayName, StringComparison.Ordinal));
        }
        if (files.Count == 0) throw new InvalidOperationException($"Missing Blazor template: {control}.");
        return files;
    }

    internal static string Display(string id) => BlazorCatalog.Packages.Single(package => package.Alias == id).DisplayName;
}

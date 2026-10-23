namespace Syncfusion.DotNet.CLI.Core;

public sealed record DesktopControlTemplate(string Alias, string Name, string Folder, string View, IReadOnlyList<string> Packages);

public static class DesktopTemplateResources
{
    public static IReadOnlyDictionary<string, string> Sources(Type provider, DesktopControlTemplate template, string rootNamespace, string language = "C#")
    {
        var prefix = provider.Assembly.GetName().Name + ".Templates." + template.Folder + ".";
        var files = new Dictionary<string, string>();
        foreach (var resource in provider.Assembly.GetManifestResourceNames().Where(name => name.StartsWith(prefix, StringComparison.Ordinal)))
        {
            var file = resource[prefix.Length..];
            if (file.StartsWith("Resources.", StringComparison.Ordinal)) continue;
            if (!file.EndsWith(language == "VB" ? ".vb" : ".cs", StringComparison.Ordinal) && !file.EndsWith(".xaml", StringComparison.Ordinal)) continue;
            using var stream = provider.Assembly.GetManifestResourceStream(resource)!;
            using var reader = new StreamReader(stream);
            files[template.Name + "/" + file] = reader.ReadToEnd()
                .Replace("__ROOT_NAMESPACE__", rootNamespace, StringComparison.Ordinal)
                .Replace("__CONTROL_NAME__", template.Name, StringComparison.Ordinal)
                .Replace("__VIEW_NAME__", template.View, StringComparison.Ordinal)
                .Replace("__VIEW_MODEL_NAME__", template.Name + "ViewModel", StringComparison.Ordinal);
        }
        return files;
    }

    public static IReadOnlyDictionary<string, byte[]> Assets(Type provider, IReadOnlyList<DesktopControlTemplate> templates)
    {
        var files = new Dictionary<string, byte[]>();
        foreach (var template in templates)
        {
            var prefix = provider.Assembly.GetName().Name + ".Templates." + template.Folder + ".Resources.";
            foreach (var resource in provider.Assembly.GetManifestResourceNames().Where(name => name.StartsWith(prefix, StringComparison.Ordinal)))
            {
                using var stream = provider.Assembly.GetManifestResourceStream(resource)!;
                using var buffer = new MemoryStream();
                stream.CopyTo(buffer);
                files[template.Name + "/Resources/" + resource[prefix.Length..]] = buffer.ToArray();
            }
        }
        return files;
    }
}

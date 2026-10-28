using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Commands.Desktop;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class DesktopProjectReferenceTests
{
    public static IEnumerable<object[]> SampleConfigurations()
    {
        foreach (var platform in new[] { "wpf", "winforms", "winui" })
        {
            var provider = DesktopProviders.Find(platform)!;
            foreach (var language in provider.Languages)
            foreach (var framework in provider.TargetFrameworks)
            foreach (var theme in provider.Themes)
            {
                yield return [platform, language, framework, theme.Name, Array.Empty<string>()];
                foreach (var control in provider.Controls)
                    yield return [platform, language, framework, theme.Name, new[] { control.Alias }];
                yield return [platform, language, framework, theme.Name, provider.Controls.Select(control => control.Alias).ToArray()];
            }
        }
    }

    [Theory]
    [MemberData(nameof(SampleConfigurations))]
    public void EveryDesktopSampleHasCompleteProjectItemsAndFrameworkReferences(
        string platform, string language, string framework, string theme, string[] controls)
    {
        var provider = DesktopProviders.Find(platform)!;
        var request = new DesktopNewRequest(provider.Platform, "ReferenceCheck", Path.GetTempPath(),
            language, framework, theme, controls, false, false);
        Assert.Null(DesktopConfiguration.Validate(provider, request));
        var files = provider.Generate(request);
        var project = XDocument.Parse(files[request.Name + DesktopConfiguration.ProjectExtension(language)]);
        var ns = project.Root!.Name.Namespace;
        var references = project.Descendants(ns + "Reference")
            .Select(reference => (string)reference.Attribute("Include")!).ToArray();
        Assert.Equal(references.Length, references.Distinct().Count());
        if (DesktopConfiguration.IsLegacy(framework))
        {
            // Standard framework references must also be present in empty projects:
            // controls can be added after initial creation.
            foreach (var assembly in new[] { "System", "System.Core", "System.Data",
                "System.ComponentModel.DataAnnotations", "System.Runtime.Serialization", "System.Xml", "System.Xml.Linq" })
                Assert.Contains(assembly, references);
            foreach (var file in files.Keys.Where(path => path.EndsWith(".cs") || path.EndsWith(".vb") || path.EndsWith(".xaml")))
                Assert.Contains(project.Descendants(), item =>
                    item.Name.LocalName is "Compile" or "Page" or "ApplicationDefinition"
                    && (string?)item.Attribute("Include") == file);
        }
        else
        {
            Assert.Equal("Microsoft.NET.Sdk", (string?)project.Root.Attribute("Sdk"));
            Assert.Empty(references);
        }
        foreach (var asset in provider.TemplateAssets(request).Keys)
            Assert.Contains(project.Descendants(), item =>
                (string?)item.Attribute("Include") == asset || (string?)item.Attribute("Update") == asset);
        foreach (var file in files.Where(file => file.Key.EndsWith(".xaml")))
            _ = XDocument.Parse(file.Value);
        Assert.DoesNotContain(files.Values, source => source.Contains("__ROOT_NAMESPACE__") || source.Contains("__VIEW_NAME__"));
    }
}

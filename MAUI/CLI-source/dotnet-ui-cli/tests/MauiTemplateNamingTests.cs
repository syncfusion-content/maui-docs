using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Commands;
using Syncfusion.DotNet.CLI.Core;
using Syncfusion.DotNet.CLI.Maui;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class MauiTemplateNamingTests
{
    [Fact]
    public void AllTemplatesUseDisplayNameFoldersAndMatchingUiAndViewModelNames()
    {
        foreach (var entry in TemplateCatalog.Operable)
        {
            var name = entry.Id == "pdf-viewer" ? "PdfViewer" : entry.DisplayName.Replace(" ", "");
            var view = MauiTemplateNames.ViewName(name);
            Assert.Equal(name, entry.ControlName);
            Assert.Equal($"Templates/Controls/{name}", entry.TemplatePath);
            Assert.Contains(entry.GeneratedFiles, file => file.Destination == $"{name}/{view}.xaml");
            Assert.Contains(entry.GeneratedFiles, file => file.Destination == $"{name}/{view}.xaml.cs");
            Assert.Contains(entry.GeneratedFiles, file => file.Destination == $"{name}/{name}ViewModel.cs");
            var values = PlaceholderReplacer.BuildValues("SampleApp", "SampleApp", name, view);
            foreach (var file in entry.GeneratedFiles.Where(file => file.Destination.EndsWith(".cs") || file.Destination.EndsWith(".xaml")))
            {
                Assert.Equal($"{name}/{file.TemplateResource}", file.Destination);
                var source = PlaceholderReplacer.Replace(EmbeddedResourceLoader.ReadText(
                    TemplatePathResolver.ResolveResourceName(entry.TemplatePath, file.TemplateResource)), values);
                Assert.DoesNotContain("__", source);
                if (file.Destination.EndsWith(".xaml"))
                    Assert.Equal($"SampleApp.{name}.{view}", (string?)XDocument.Parse(source).Root!.Attribute(XName.Get("Class", "http://schemas.microsoft.com/winfx/2009/xaml")));
                else
                {
                    Assert.Contains($"namespace SampleApp.{name}", source);
                    var className = Path.GetFileName(file.Destination).Replace(".xaml.cs", "").Replace(".cs", "");
                    Assert.Matches(@"class\s+" + System.Text.RegularExpressions.Regex.Escape(className) + @"\b", source);
                }
            }
        }
    }

    [Fact]
    public void RegistryAndCreateSummaryOrderReverseSelectionsAlphabetically()
    {
        var entries = TemplateCatalog.Operable.Reverse().ToArray();
        var expected = new MauiControlSelectionProvider(MauiProjectType.App).Controls.Select(control => control.DisplayName).ToArray();
        var registry = WelcomeProjectGenerator.RegistryContent("SampleApp", entries);
        var positions = expected.Select(name => registry.IndexOf($"\"{name}\"", StringComparison.Ordinal)).ToArray();
        Assert.All(positions, position => Assert.True(position >= 0));
        Assert.Equal(positions.Order(), positions);
        var request = new NewProjectRequest(Framework.Maui, "SampleApp", Path.GetTempPath(), "net10.0", "empty", MauiProjectType.App,
            false, false, false, false, TemplateIds: entries.Select(entry => entry.Id).ToArray());
        var summary = NewCommand.FormatNewProjectReview(request, 500);
        Assert.Contains(summary, row => row.TrimStart().StartsWith("Controls:") && row.Contains(string.Join(", ", expected)));
    }
}

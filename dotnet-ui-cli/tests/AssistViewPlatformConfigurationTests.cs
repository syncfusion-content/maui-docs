using System.Xml.Linq;
using Syncfusion.DotNet.CLI.Maui;
using Xunit;

namespace Syncfusion.DotNet.CLI.Tests;

public sealed class AssistViewPlatformConfigurationTests
{
    [Theory]
    [InlineData("assistview", true)]
    [InlineData("ai-assistview", true)]
    [InlineData("datagrid", false)]
    [InlineData("empty", false)]
    public void OnlyAssistViewPlansPlatformConfiguration(string template, bool expected)
    {
        var request = new NewProjectRequest(Syncfusion.DotNet.CLI.Core.Framework.Maui, "Attachments",
            Path.GetTempPath(), "net10.0", template, MauiProjectType.App, false, false, true, false);
        var result = new NewProjectScaffolder().Plan(request);
        Assert.Equal(0, result.ExitCode);
        foreach (var file in AssistViewPlatformConfiguration.Files)
        {
            Assert.Equal(expected, result.Plan!.FilesToModify.Contains(file));
        }
    }

    [Fact]
    public void AttachmentDeclarationsPreserveExistingSettingsAndAreIdempotent()
    {
        var root = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        try
        {
            foreach (var file in AssistViewPlatformConfiguration.Files)
            {
                var path = Path.Combine(root, file);
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllText(path, file.EndsWith(".xml", StringComparison.Ordinal)
                    ? "<manifest xmlns:android=\"http://schemas.android.com/apk/res/android\"><application android:label=\"Existing\" /></manifest>"
                    : "<plist version=\"1.0\"><dict><key>Existing</key><true/></dict></plist>");
            }
            AssistViewPlatformConfiguration.Apply(root);
            var first = AssistViewPlatformConfiguration.Files.Select(file => File.ReadAllText(Path.Combine(root, file))).ToArray();
            AssistViewPlatformConfiguration.Apply(root);
            Assert.Equal(first, AssistViewPlatformConfiguration.Files.Select(file => File.ReadAllText(Path.Combine(root, file))).ToArray());
            var android = XDocument.Parse(first[0]);
            XNamespace ns = "http://schemas.android.com/apk/res/android";
            Assert.NotNull(android.Root!.Element("application"));
            var permissions = android.Root.Elements("uses-permission").ToList();
            Assert.Equal(3, permissions.Count);
            Assert.Equal("32", (string?)permissions[0].Attribute(ns + "maxSdkVersion"));
            Assert.Equal("28", (string?)permissions[1].Attribute(ns + "maxSdkVersion"));
            Assert.Null(permissions[2].Attribute(ns + "maxSdkVersion"));
            foreach (var index in new[] { 1, 2 })
            {
                var keys = XDocument.Parse(first[index]).Descendants("key").Select(key => key.Value).ToList();
                Assert.Contains("Existing", keys);
                Assert.Contains("NSPhotoLibraryUsageDescription", keys);
                Assert.DoesNotContain(keys, key => key.StartsWith("com.apple.security.", StringComparison.Ordinal));
            }
            Assert.Equal(5, XDocument.Parse(first[3]).Descendants("key").Count());
        }
        finally
        {
            if (Directory.Exists(root)) Directory.Delete(root, true);
        }
    }
}

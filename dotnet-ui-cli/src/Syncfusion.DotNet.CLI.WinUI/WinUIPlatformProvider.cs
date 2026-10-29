using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WinUI;

/// <summary>Unpackaged Windows App SDK application, following Microsoft's WinUI desktop bootstrap pattern.</summary>
public sealed class WinUIPlatformProvider : IDesktopPlatformProvider
{
    public Framework Platform => Framework.WinUI;
    public string DisplayName => "WinUI";
    public string? OfficialTemplate => null;
    public IReadOnlyList<string> Languages => ["C#"];
    public IReadOnlyList<string> TargetFrameworks => ["net10.0", "net9.0", "net8.0"];
    public IReadOnlyList<DesktopTheme> Themes => [new("Native", "Native WinUI", null)];
    public string DefaultTheme => "Native";
    public IReadOnlyList<DesktopPackage> Packages => DesktopPackageCatalog.Combine(typeof(WinUIPlatformProvider), WinUIControlCatalog.All
        .Select(template => new DesktopPackage(template.Alias, template.Alias == "chart" ? "Charts" : template.Name, template.Packages[0], true)).ToArray());
    public bool SupportsControlTemplates => true;
    public IReadOnlyDictionary<string, byte[]> TemplateAssets(DesktopNewRequest request)
        => DesktopTemplateResources.Assets(typeof(WinUIPlatformProvider), WinUIControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)).ToArray());
    public IReadOnlyList<string> RequiredPackages(DesktopNewRequest request)
        => request.Controls.SelectMany(control => WinUIControlCatalog.All.Single(template => template.Alias == control).Packages)
            .Prepend("Microsoft.WindowsAppSDK").Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
    public bool RequiresWindowsBuild(DesktopNewRequest request) => true;
    public string PackageVersion(string packageId, string? requestedVersion) => packageId == "Microsoft.WindowsAppSDK" ? "2.2.0" : requestedVersion ?? DesktopConfiguration.SyncfusionVersion;
    public IReadOnlyDictionary<string, string> Generate(DesktopNewRequest request)
    {
        var name = request.Name;
        var selected = WinUIControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)).ToArray();
        var namespaces = string.Join(" ", selected.Select(template => $"xmlns:{template.Name}=\"using:{name}.{template.Name}\""));
        var views = selected.Select(template => $"<PivotItem Header=\"{(template.Alias == "chart" ? "Charts" : template.Name)}\" Tag=\"{template.Alias}\" HorizontalContentAlignment=\"Stretch\" VerticalContentAlignment=\"Stretch\"><{template.Name}:{template.View} /></PivotItem>");
        var ui = "<Pivot x:Name=\"Samples\"><PivotItem Header=\"Welcome\"><welcome:WelcomeView x:Name=\"WelcomePage\" /></PivotItem>" + string.Join('\n', views) + "</Pivot>";
        var files = new Dictionary<string, string>
        {
            [name + ".csproj"] = DesktopProjectFiles.ModernProject(request, "<UseWinUI>true</UseWinUI><WindowsPackageType>None</WindowsPackageType><WindowsAppSDKSelfContained>true</WindowsAppSDKSelfContained><RuntimeIdentifier>win-x64</RuntimeIdentifier><TargetPlatformMinVersion>10.0.19041.0</TargetPlatformMinVersion><ApplicationManifest>app.manifest</ApplicationManifest>"),
            ["app.manifest"] = "<assembly manifestVersion=\"1.0\" xmlns=\"urn:schemas-microsoft-com:asm.v1\"><assemblyIdentity version=\"1.0.0.0\" name=\"" + name + "\" /><compatibility xmlns=\"urn:schemas-microsoft-com:compatibility.v1\"><application><supportedOS Id=\"{8e0f7a12-bfb3-4fe8-b9a5-48fd50a15a9a}\" /></application></compatibility></assembly>",
            ["App.xaml"] = $"<Application x:Class=\"{name}.App\" xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"><Application.Resources><XamlControlsResources xmlns=\"using:Microsoft.UI.Xaml.Controls\" /></Application.Resources></Application>",
            ["App.xaml.cs"] = $$"""
                namespace @{{name}};
                public partial class App : Microsoft.UI.Xaml.Application
                {
                    private Microsoft.UI.Xaml.Window? window;
                    public App() { InitializeComponent(); }
                    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
                    {
                        {{(request.Controls.Count > 0 ? "var license = System.Environment.GetEnvironmentVariable(\"SYNCFUSION_LICENSE_KEY\"); if (!string.IsNullOrWhiteSpace(license)) Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(license);" : "")}}
                        window = new MainWindow(); window.Activate();
                    }
                }
                """,
            ["MainWindow.xaml"] = $"<Window x:Class=\"{name}.MainWindow\" xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" {namespaces} xmlns:welcome=\"using:{name}.Welcome\" Title=\"{name}\"><Grid x:Name=\"ContentRoot\">{ui}</Grid></Window>",
            ["MainWindow.xaml.cs"] = $$"""
                namespace @{{name}};
                public partial class MainWindow : Microsoft.UI.Xaml.Window
                {
                    public MainWindow()
                    {
                        InitializeComponent();
                        WelcomePage.OpenSampleAction = id =>
                        {
                            foreach (Microsoft.UI.Xaml.Controls.PivotItem item in Samples.Items)
                                if (item.Tag is string alias && alias == id) Samples.SelectedItem = item;
                        };
                    }
                }
                """,
        };
        foreach (var template in selected)
            foreach (var file in DesktopTemplateResources.Sources(typeof(WinUIPlatformProvider), template, name))
                files[file.Key] = file.Value;
        files["Welcome/WelcomeView.xaml"] = WinUIWelcomeTemplate.View(request.Controls, name);
        files["Welcome/WelcomeView.xaml.cs"] = WinUIWelcomeTemplate.Code(name);
        foreach (var path in files.Keys.Where(path => path.EndsWith(".xaml", StringComparison.Ordinal)).ToArray())
            files[path] = System.Xml.Linq.XDocument.Parse(files[path]).ToString();
        foreach (var path in files.Keys.Where(path => path.EndsWith(".cs", StringComparison.Ordinal)).ToArray())
            files[path] = string.Join('\n', files[path].Split('\n').Select(line => line.TrimEnd()));
        files[name + ".csproj"] = System.Xml.Linq.XDocument.Parse(files[name + ".csproj"]).ToString();
        return files;
    }
}

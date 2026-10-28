using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WPF;

public sealed class WPFPlatformProvider : IDesktopPlatformProvider
{
    public Framework Platform => Framework.WPF;
    public string DisplayName => "WPF";
    public string OfficialTemplate => "wpf";
    public IReadOnlyList<string> Languages => ["C#", "VB"];
    public IReadOnlyList<string> TargetFrameworks => ["net10.0", "net9.0", "net8.0", "net48", "net47", "net462"];
    public IReadOnlyList<DesktopTheme> Themes =>
    [
        new("Windows11Light", "Windows11 (Light)", "Syncfusion.Themes.Windows11Light.WPF"),
        new("Windows11Dark", "Windows11 (Dark)", "Syncfusion.Themes.Windows11Dark.WPF"),
        new("Material3Light", "Material3 (Light)", "Syncfusion.Themes.Material3Light.WPF"),
        new("Material3Dark", "Material3 (Dark)", "Syncfusion.Themes.Material3Dark.WPF"),
        new("Office2019Colorful", "Office2019 (Colorful)", "Syncfusion.Themes.Office2019Colorful.WPF"),
    ];
    public string PackageVersion(string packageId, string? requestedVersion)
        => packageId == "Microsoft.Xaml.Behaviors.Wpf" ? "1.1.135" : requestedVersion ?? DesktopConfiguration.SyncfusionVersion;
    public string DefaultTheme => "Windows11Light";
    public IReadOnlyList<DesktopPackage> Packages => DesktopPackageCatalog.Combine(typeof(WPFPlatformProvider),
    [
        .. WPFControlCatalog.All.Select(control => new DesktopPackage(control.Alias, control.Name, control.Packages[0], true)),
        new("skin-manager", "Skin Manager", "Syncfusion.SfSkinManager.WPF"),
        .. Themes.Select(theme => new DesktopPackage(theme.Name.ToLowerInvariant(), theme.DisplayName, theme.PackageId!)),
    ]);
    public IReadOnlyList<string> RequiredPackages(DesktopNewRequest request)
        => request.Controls.SelectMany(control => WPFControlCatalog.All.Single(template => template.Alias == control).Packages)
            .Concat(["Syncfusion.SfSkinManager.WPF", Themes.Single(theme => theme.Name == request.Theme).PackageId!]).Distinct().ToArray();

    public bool SupportsControlTemplates => true;
    public IReadOnlyDictionary<string, byte[]> TemplateAssets(DesktopNewRequest request)
        => DesktopTemplateResources.Assets(typeof(WPFPlatformProvider), WPFControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)).ToArray());

    public IReadOnlyDictionary<string, string> Generate(DesktopNewRequest request)
    {
        var vb = request.Language == "VB";
        var extension = vb ? "vb" : "cs";
        var name = request.Name;
        var contents = new List<string>();
        var sampleNamespaces = "";
        {
            contents.Clear();
            foreach (var template in WPFControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)))
            {
                sampleNamespaces += $" xmlns:{template.Name}=\"clr-namespace:{name}.{template.Name}\"";
                contents.Add($"<TabItem Header=\"{template.Name}\" Tag=\"{template.Alias}\"><Frame NavigationUIVisibility=\"Hidden\"><Frame.Content><{template.Name}:{template.View} /></Frame.Content></Frame></TabItem>");
            }
        }
        var ui = "<TabControl x:Name=\"Samples\"><TabItem Header=\"Welcome\"><welcome:WelcomeView x:Name=\"WelcomePage\" /></TabItem>" + string.Join('\n', contents) + "</TabControl>";
        var files = new Dictionary<string, string>
        {
            [vb ? "Application.xaml" : "App.xaml"] = $"<Application x:Class=\"{name}.App\" xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" StartupUri=\"MainWindow.xaml\" />",
            ["MainWindow.xaml"] = $"<Window x:Class=\"{name}.MainWindow\" xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" xmlns:sf=\"http://schemas.syncfusion.com/wpf\" xmlns:welcome=\"clr-namespace:{name}.Welcome\" {sampleNamespaces} Title=\"{name}\" Width=\"960\" Height=\"640\">{ui}</Window>",
            [(vb ? "Application.xaml." : "App.xaml.") + extension] = vb ? $$"""
                Imports Syncfusion.SfSkinManager
                Namespace [{{name}}]
                    Partial Public Class App
                        Inherits System.Windows.Application
                        Protected Overrides Sub OnStartup(e As System.Windows.StartupEventArgs)
                            Dim license = System.Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE_KEY")
                            If Not String.IsNullOrWhiteSpace(license) Then Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(license)
                            Syncfusion.SfSkinManager.SfSkinManager.ApplyThemeAsDefaultStyle = True
                            MyBase.OnStartup(e)
                        End Sub
                    End Class
                End Namespace
                """ : $$"""
                using Syncfusion.SfSkinManager;
                namespace @{{name}}
                {
                    public partial class App : System.Windows.Application
                    {
                        protected override void OnStartup(System.Windows.StartupEventArgs e)
                        {
                            var license = System.Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE_KEY");
                            if (!string.IsNullOrWhiteSpace(license)) Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(license);
                            Syncfusion.SfSkinManager.SfSkinManager.ApplyThemeAsDefaultStyle = true;
                            base.OnStartup(e);
                        }
                    }
                }
                """,
            ["MainWindow.xaml." + extension] = vb ? $$"""
                Imports System.Collections.Generic
                Namespace [{{name}}]
                    Partial Public Class MainWindow
                        Inherits System.Windows.Window
                        Public Sub New()
                            InitializeComponent()
                            WelcomePage.OpenSampleAction = Sub(id)
                                For Each item As System.Windows.Controls.TabItem In Samples.Items
                                    If CStr(item.Tag) = id Then Samples.SelectedItem = item
                                Next
                            End Sub
                            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(Me, New Syncfusion.SfSkinManager.Theme("{{request.Theme}}"))
                            DataContext = New List(Of SampleRow) From {New SampleRow("North", 12000), New SampleRow("South", 18000), New SampleRow("West", 15000)}
                        End Sub
                    End Class
                    Public Class SampleRow
                        Public Property Name As String
                        Public Property Sales As Double
                        Public Sub New(name As String, sales As Double)
                            Me.Name = name
                            Me.Sales = sales
                        End Sub
                    End Class
                End Namespace
                """ : $$"""
                using System.Collections.Generic;
                namespace @{{name}}
                {
                    public partial class MainWindow : System.Windows.Window
                    {
                        public MainWindow()
                        {
                            InitializeComponent();
                            WelcomePage.OpenSampleAction = id =>
                            {
                                foreach (System.Windows.Controls.TabItem item in Samples.Items)
                                    if ((string)item.Tag == id) Samples.SelectedItem = item;
                            };
                            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(this, new Syncfusion.SfSkinManager.Theme("{{request.Theme}}"));
                            DataContext = new List<SampleRow> { new SampleRow("North", 12000), new SampleRow("South", 18000), new SampleRow("West", 15000) };
                        }
                    }
                    public class SampleRow
                    {
                        public string Name { get; set; }
                        public double Sales { get; set; }
                        public SampleRow(string name, double sales) { Name = name; Sales = sales; }
                    }
                }
                """,
        };
        foreach (var template in WPFControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)))
                foreach (var file in DesktopTemplateResources.Sources(typeof(WPFPlatformProvider), template, name, request.Language)) files[file.Key] = file.Value.Replace("{{request.Theme}}", request.Theme, StringComparison.Ordinal);
        files["Welcome/WelcomeView.xaml"] = WpfWelcomeTemplate.View(request.Controls, request.Theme.EndsWith("Dark", StringComparison.Ordinal), name);
        files["Welcome/WelcomeView.xaml." + extension] = WpfWelcomeTemplate.Code(vb, name);
        foreach (var path in files.Keys.Where(path => path.EndsWith(".xaml", StringComparison.Ordinal)).ToArray())
            files[path] = System.Xml.Linq.XDocument.Parse(files[path]).ToString();
        foreach (var path in files.Keys.Where(path => path.EndsWith(".cs", StringComparison.Ordinal) || path.EndsWith(".vb", StringComparison.Ordinal)).ToArray())
            files[path] = string.Join('\n', files[path].Split('\n').Select(line => line.TrimEnd()));
        files[name + DesktopConfiguration.ProjectExtension(request.Language)] = DesktopConfiguration.IsLegacy(request.TargetFramework)
            ? DesktopProjectFiles.LegacyProject(request, files.Keys, wpf: true)
            : DesktopProjectFiles.ModernProject(request, "<UseWPF>true</UseWPF>" + (vb ? "<RootNamespace></RootNamespace>" : ""));
        var projectPath = name + DesktopConfiguration.ProjectExtension(request.Language);
        var project = System.Xml.Linq.XDocument.Parse(files[projectPath]);
        var ns = project.Root!.Name.Namespace;
        var assets = new System.Xml.Linq.XElement(ns + "ItemGroup");
        foreach (var asset in TemplateAssets(request).Keys)
        {
            var dictionary = asset.EndsWith(".xaml", StringComparison.Ordinal);
            var item = new System.Xml.Linq.XElement(ns + (dictionary ? "Page" : "Resource"), new System.Xml.Linq.XAttribute(dictionary && !DesktopConfiguration.IsLegacy(request.TargetFramework) ? "Update" : "Include", asset));
            assets.Add(item);
        }
        if (assets.HasElements) project.Root.Add(assets);
        files[projectPath] = project.ToString();
        return files;
    }
}

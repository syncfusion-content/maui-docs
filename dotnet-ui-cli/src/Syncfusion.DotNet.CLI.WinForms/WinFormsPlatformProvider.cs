using Syncfusion.DotNet.CLI.Core;

namespace Syncfusion.DotNet.CLI.WinForms;

public sealed class WinFormsPlatformProvider : IDesktopPlatformProvider
{
    public Framework Platform => Framework.WinForms;
    public string DisplayName => "WinForms";
    public string OfficialTemplate => "winforms";
    public IReadOnlyList<string> Languages => ["C#", "VB"];
    public IReadOnlyList<string> TargetFrameworks => ["net10.0", "net9.0", "net8.0", "net48", "net47", "net462"];
    public IReadOnlyList<DesktopTheme> Themes => [new("Office2019Colorful", "Office2019 (Colorful)", "Syncfusion.Office2019Theme.WinForms")];
    public string DefaultTheme => "Office2019Colorful";
    public IReadOnlyList<DesktopPackage> Packages => DesktopPackageCatalog.Combine(typeof(WinFormsPlatformProvider),
    [
        .. WinFormsControlCatalog.All.Select(control => new DesktopPackage(control.Alias, control.Name, control.Packages[0], true)),
        new("office2019", "Office2019", "Syncfusion.Office2019Theme.WinForms"),
        new("core", "Core", "Syncfusion.Core.WinForms"), new("shared", "Shared", "Syncfusion.Shared.Base"),
    ]);
    public IReadOnlyList<string> RequiredPackages(DesktopNewRequest request)
        => request.Controls.SelectMany(control => WinFormsControlCatalog.All.Single(template => template.Alias == control).Packages)
            .Concat(["Syncfusion.Office2019Theme.WinForms", "Syncfusion.Core.WinForms", "Syncfusion.Shared.Base", "Syncfusion.Tools.Windows"]).Distinct().ToArray();

    public bool SupportsControlTemplates => true;
    public IReadOnlyDictionary<string, byte[]> TemplateAssets(DesktopNewRequest request)
        => DesktopTemplateResources.Assets(typeof(WinFormsPlatformProvider), WinFormsControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)).ToArray());

    public IReadOnlyDictionary<string, string> Generate(DesktopNewRequest request)
    {
        var vb = request.Language == "VB";
        var name = request.Name;
        var extension = vb ? "vb" : "cs";
        var controls = new List<string>();
        {
            controls.Clear();
            foreach (var template in WinFormsControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)))
                controls.Add(vb
                    ? $"Dim {template.Name}Tab = New TabPageAdv(\"{template.Name}\") With {{.Tag = \"{template.Alias}\"}}\n{template.Name}Tab.Controls.Add(New {template.Name}.{template.View} With {{.Dock = DockStyle.Fill}})\ntabs.TabPages.Add({template.Name}Tab)"
                    : $"var {template.Name}Tab = new TabPageAdv(\"{template.Name}\") {{ Tag = \"{template.Alias}\" }};\n{template.Name}Tab.Controls.Add(new {template.Name}.{template.View} {{ Dock = DockStyle.Fill }});\ntabs.TabPages.Add({template.Name}Tab);");
        }
        var files = new Dictionary<string, string>
        {
            ["Program." + extension] = vb ? $$"""
                Imports System
                Imports System.Windows.Forms
                Namespace [{{name}}]
                    Module Program
                        <STAThread>
                        Sub Main()
                            Dim license = Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE_KEY")
                            If Not String.IsNullOrWhiteSpace(license) Then Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(license)
                            Syncfusion.Windows.Forms.SkinManager.LoadAssembly(GetType(Syncfusion.WinForms.Themes.Office2019Theme).Assembly)
                            Syncfusion.Windows.Forms.SkinManager.ApplicationVisualTheme = "Office2019Colorful"
                            Application.EnableVisualStyles()
                            Application.SetCompatibleTextRenderingDefault(False)
                            Application.Run(New MainForm())
                        End Sub
                    End Module
                End Namespace
                """ : $$"""
                using System;
                using System.Windows.Forms;
                namespace @{{name}}
                {
                    internal static class Program
                    {
                        [STAThread] static void Main()
                        {
                            var license = Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE_KEY");
                            if (!string.IsNullOrWhiteSpace(license)) Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(license);
                            Syncfusion.Windows.Forms.SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
                            Syncfusion.Windows.Forms.SkinManager.ApplicationVisualTheme = "Office2019Colorful";
                            Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false);                            
                            Application.Run(new MainForm());
                        }
                    }
                }
                """,
            ["MainForm." + extension] = vb ? $$"""
                Imports System.Collections.Generic
                Imports System.Windows.Forms
                Imports Syncfusion.Windows.Forms.Tools
                Namespace [{{name}}]
                    Public Class MainForm
                        Inherits Syncfusion.WinForms.Controls.SfForm
                        Public Sub New()
                            Text = "{{name}}"
                            Width = 960
                            Height = 640
                            Dim tabs = New Syncfusion.Windows.Forms.Tools.TabControlAdv() With {.Dock = DockStyle.Fill}
                            Controls.Add(tabs)
                            {{WelcomeContent.IndentContinuation(string.Join('\n', controls), 12)}}
                            Dim welcomePage = New Syncfusion.Windows.Forms.Tools.TabPageAdv("Welcome")
                            welcomePage.Controls.Add(New Welcome.WelcomeView(tabs) With {.Dock = DockStyle.Fill})
                            tabs.TabPages.Insert(0, welcomePage)
                            tabs.SelectedIndex = 0
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
                using System.Windows.Forms;
                using Syncfusion.Windows.Forms.Tools;
                namespace @{{name}}
                {
                    public class MainForm : Syncfusion.WinForms.Controls.SfForm
                    {
                        public MainForm()
                        {
                            Text = "{{name}}"; Width = 960; Height = 640;
                            var tabs = new Syncfusion.Windows.Forms.Tools.TabControlAdv { Dock = DockStyle.Fill }; Controls.Add(tabs);
                            {{WelcomeContent.IndentContinuation(string.Join('\n', controls), 12)}}
                            var welcomePage = new Syncfusion.Windows.Forms.Tools.TabPageAdv("Welcome");
                            welcomePage.Controls.Add(new Welcome.WelcomeView(tabs) { Dock = DockStyle.Fill });
                            tabs.TabPages.Insert(0, welcomePage);
                            tabs.SelectedIndex = 0;
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
        foreach (var template in WinFormsControlCatalog.All.Where(template => request.Controls.Contains(template.Alias)))
                foreach (var file in DesktopTemplateResources.Sources(typeof(WinFormsPlatformProvider), template, name, request.Language)) files[file.Key] = file.Value;
        files["Welcome/WelcomeView." + extension] = WinFormsWelcomeTemplate.Code(vb, request.Controls, name);
        foreach (var path in files.Keys.Where(path => path.EndsWith(".cs", StringComparison.Ordinal) || path.EndsWith(".vb", StringComparison.Ordinal)).ToArray())
            files[path] = string.Join('\n', files[path].Split('\n').Select(line => line.TrimEnd()));
        files[name + DesktopConfiguration.ProjectExtension(request.Language)] = DesktopConfiguration.IsLegacy(request.TargetFramework)
            ? DesktopProjectFiles.LegacyProject(request, files.Keys, wpf: false)
            : DesktopProjectFiles.ModernProject(request, "<UseWindowsForms>true</UseWindowsForms>" + (vb ? "<RootNamespace></RootNamespace><MyType>Empty</MyType><StartupObject>" + name + ".Program</StartupObject>" : ""));
        var projectPath = name + DesktopConfiguration.ProjectExtension(request.Language);
        var project = System.Xml.Linq.XDocument.Parse(files[projectPath]);
        var ns = project.Root!.Name.Namespace;
        var assets = new System.Xml.Linq.XElement(ns + "ItemGroup");
        foreach (var asset in TemplateAssets(request).Keys)
        {
            var item = new System.Xml.Linq.XElement(ns + "Content", new System.Xml.Linq.XAttribute("Include", asset));
            item.Add(new System.Xml.Linq.XElement(ns + "CopyToOutputDirectory", "PreserveNewest"));
            assets.Add(item);
        }
        if (assets.HasElements) project.Root.Add(assets);
        files[projectPath] = project.ToString();
        return files;
    }
}

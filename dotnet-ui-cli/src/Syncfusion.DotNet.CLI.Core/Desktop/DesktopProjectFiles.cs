using System.Security;
using System.Xml.Linq;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>Project-format handling shared by desktop providers; no control or theme APIs.</summary>
public static class DesktopProjectFiles
{
    public static string Escape(string value) => SecurityElement.Escape(value) ?? string.Empty;
    public static string ModernProject(DesktopNewRequest request, string platformProperties)
        => $"<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><OutputType>WinExe</OutputType><TargetFramework>{request.TargetFramework}-windows{(request.Platform == Framework.WinUI ? "10.0.19041.0" : "")}</TargetFramework><RootNamespace>{request.Name}</RootNamespace><EnableWindowsTargeting>true</EnableWindowsTargeting><ImplicitUsings>enable</ImplicitUsings>{(request.Language == "C#" ? "<Nullable>enable</Nullable>" : "")}{platformProperties}</PropertyGroup></Project>";

    public static string LegacyProject(DesktopNewRequest request, IEnumerable<string> sourceFiles, bool wpf)
    {
        var version = request.TargetFramework switch { "net462" => "v4.6.2", "net47" => "v4.7", _ => "v4.8" };
        var language = request.Language == "VB" ? "VisualBasic" : "CSharp";
        var items = string.Join("\n", sourceFiles.Select(file =>
        {
            var kind = file.EndsWith(".xaml") ? (file is "App.xaml" or "Application.xaml" ? "ApplicationDefinition" : "Page") : "Compile";
            return $"<{kind} Include=\"{Escape(file)}\" />";
        }));
        return $"""
            <Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
              <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
              <PropertyGroup><Configuration Condition="'$(Configuration)' == ''">Debug</Configuration><Platform Condition="'$(Platform)' == ''">AnyCPU</Platform><ProjectGuid>{Guid.NewGuid():B}</ProjectGuid><OutputType>WinExe</OutputType><RootNamespace>{(request.Language == "VB" ? "" : request.Name)}</RootNamespace><MyType>Empty</MyType><OptionInfer>On</OptionInfer><OptionExplicit>On</OptionExplicit><AssemblyName>{request.Name}</AssemblyName><TargetFrameworkVersion>{version}</TargetFrameworkVersion><OutputPath>bin\$(Configuration)\</OutputPath><LangVersion>latest</LangVersion><RestoreProjectStyle>PackageReference</RestoreProjectStyle><StartupObject>{(request.Language == "VB" && !wpf ? request.Name + ".Program" : "")}</StartupObject></PropertyGroup>
              <ItemGroup><Reference Include="System" /><Reference Include="System.Core" /><Reference Include="System.Data" /><Reference Include="System.ComponentModel.DataAnnotations" /><Reference Include="System.Runtime.Serialization" /><Reference Include="System.Xml" /><Reference Include="System.Xml.Linq" />{(!wpf ? "<Reference Include=\"System.Drawing\" /><Reference Include=\"System.Windows.Forms\" />" : "")}{(wpf ? "<Reference Include=\"WindowsBase\" /><Reference Include=\"PresentationCore\" /><Reference Include=\"PresentationFramework\" /><Reference Include=\"System.Xaml\" />" : "")}</ItemGroup>
              <ItemGroup>{items}</ItemGroup>
              <Import Project="$(MSBuildToolsPath)\Microsoft.{language}.targets" />
            </Project>
            """;
    }

    private static string ProjectKinds(Framework platform) => platform == Framework.Blazor ? ".csproj" : ".csproj or .vbproj";

    public static string ResolveProject(string path, Framework platform)
    {
        path = Path.GetFullPath(path);
        if (Directory.Exists(path))
        {
            var projects = Directory.GetFiles(path, "*.*proj", platform == Framework.Blazor ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                .Where(file => file.EndsWith(".csproj") || (platform != Framework.Blazor && file.EndsWith(".vbproj"))).ToArray();
            if (platform == Framework.Blazor && projects.Length > 1)
            {
                var manifest = Directory.GetFiles(path, "desktop.json", SearchOption.AllDirectories)
                    .FirstOrDefault(file => Path.GetFileName(Path.GetDirectoryName(file)) == "Syncfusion");
                if (manifest is not null)
                {
                    var projectFile = System.Text.Json.JsonDocument.Parse(File.ReadAllText(manifest)).RootElement.GetProperty("ProjectFile").GetString();
                    var candidate = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(manifest))!, projectFile!));
                    if (File.Exists(candidate)) projects = [candidate];
                }
                if (projects.Length > 1)
                {
                    var clients = projects.Where(project =>
                    {
                        var candidate = XDocument.Load(project);
                        return candidate.Descendants().Any(element => element.Name.LocalName == "PackageReference"
                            && ((string?)element.Attribute("Include"))?.StartsWith("Microsoft.AspNetCore.Components.WebAssembly", StringComparison.OrdinalIgnoreCase) == true);
                    }).ToArray();
                    if (clients.Length == 1) projects = clients;
                }
            }
            if (projects.Length != 1) throw new ArgumentException("Select an explicit " + ProjectKinds(platform) + " when the project location contains zero or multiple projects.");
            path = projects[0];
        }
        if (!File.Exists(path) || !(path.EndsWith(".csproj") || (platform != Framework.Blazor && path.EndsWith(".vbproj")))) throw new ArgumentException("A " + ProjectKinds(platform) + " project is required.");
        var xml = XDocument.Load(path);
        var detected = Detect(xml);
        if (detected != platform) throw new ArgumentException($"Selected project is {detected?.ToString() ?? "not a supported desktop application"}; expected {platform}.");
        return path;
    }
    public static Framework? Detect(XDocument xml)
    {
        bool Flag(string name) => xml.Descendants().Any(element => element.Name.LocalName == name && element.Value.Equals("true", StringComparison.OrdinalIgnoreCase));
        if (Flag("UseMaui")) return Framework.Maui;
        var sdk = (string?)xml.Root?.Attribute("Sdk");
        var target = xml.Descendants().FirstOrDefault(element => element.Name.LocalName is "TargetFramework" or "TargetFrameworks")?.Value;
        if (string.Equals(sdk, "Microsoft.NET.Sdk.Web", StringComparison.OrdinalIgnoreCase)
            || xml.Descendants().Any(element => element.Name.LocalName == "PackageReference"
                && ((string?)element.Attribute("Include"))?.StartsWith("Microsoft.AspNetCore.Components.WebAssembly", StringComparison.OrdinalIgnoreCase) == true)
            || target?.Contains("browser", StringComparison.OrdinalIgnoreCase) == true) return Framework.Blazor;
        if (Flag("UseWinUI")) return Framework.WinUI;
        if (Flag("UseWPF") || xml.Descendants().Any(element => element.Name.LocalName == "Reference" && (string?)element.Attribute("Include") == "PresentationFramework")) return Framework.WPF;
        if (Flag("UseWindowsForms") || xml.Descendants().Any(element => element.Name.LocalName == "Reference" && (string?)element.Attribute("Include") == "System.Windows.Forms")) return Framework.WinForms;
        return null;
    }
}

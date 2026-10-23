using System.Reflection;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>
/// Static metadata about the CLI itself, such as version and product name.
/// The version is sourced from the assembly so the tool reports the real
/// package version even when it is installed as a global tool.
/// </summary>
public static class CliMetadata
{
    /// <summary>The product name shown in banners and help.</summary>
    public const string ProductName = "Syncfusion .NET CLI";

    private static readonly Lazy<string> _version = new(GetVersion);

    /// <summary>The CLI version, resolved from assembly metadata at first access.</summary>
    public static string Version => _version.Value;

    private static string GetVersion()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var informational = assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion;

        if (!string.IsNullOrWhiteSpace(informational))
        {
            // Trim a source revision suffix if present, e.g. "0.1.0-preview.1+abc".
            var plus = informational.IndexOf('+');
            return plus > 0 ? informational[..plus] : informational;
        }

        return assembly.GetName().Version?.ToString() ?? "0.0.0";
    }
}

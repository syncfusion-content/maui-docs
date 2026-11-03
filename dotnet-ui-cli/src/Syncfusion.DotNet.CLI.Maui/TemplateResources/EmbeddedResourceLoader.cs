using System.IO;
using System.Reflection;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>
/// A simple embedded-resource loader for template files. Searches
/// all loaded assemblies for a manifest resource name ending with the
/// requested suffix and returns its text content. The MAUI platform assembly
/// embeds templates; this loader is the only seam the rest of
/// the CLI uses to read them.
/// </summary>
public static class EmbeddedResourceLoader
{
    /// <summary>The generated-code marker for the sample-resource embedding block in the app .csproj.</summary>
    public const string CsprojBlockMarker = "pdf-resource";

    /// <summary>
    /// Returns true when a template destination carries binary content that
    /// must be copied byte-for-byte (never read or written as text).
    /// </summary>
    public static bool IsBinaryFile(string destination)
        => Path.GetExtension(destination).Equals(".pdf", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Reads a text resource by exact manifest resource name. Throws if the
    /// resource is not found in any loaded assembly.
    /// </summary>
    public static string ReadText(string resourceName)
    {
        using var stream = Open(resourceName);
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }

    /// <summary>
    /// Reads a text resource and returns its bytes (for binary resources such
    /// as embedded assets, when needed).
    /// </summary>
    public static byte[] ReadBytes(string resourceName)
    {
        using var stream = Open(resourceName);
        using var ms = new MemoryStream();
        stream.CopyTo(ms);
        return ms.ToArray();
    }

    /// <summary>Opens a manifest resource stream by exact name across loaded assemblies.</summary>
    public static Stream Open(string resourceName)
    {
        if (string.IsNullOrWhiteSpace(resourceName))
        {
            throw new System.ArgumentException("Resource name is required.", nameof(resourceName));
        }

        // Ensure the MAUI platform assembly (which embeds templates) is
        // loaded, since callers may reach the loader before anything else has
        // pulled the platform descriptor into the AppDomain.
        MauiAssemblyLoader.EnsureLoaded();

        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            Stream? stream = null;
            try
            {
                stream = assembly.GetManifestResourceStream(resourceName);
                if (stream is not null)
                {
                    return stream;
                }
            }
            catch (NotSupportedException)
            {
                // Some dynamic assemblies do not support resource enumeration.
            }
        }

        throw new FileNotFoundException(
            $"Embedded resource '{resourceName}' was not found in any loaded assembly.", resourceName);
    }
}

using System.Collections.Generic;
using System.Reflection;

namespace Syncfusion.DotNet.CLI.Maui;

/// <summary>
/// Force-loads the .NET MAUI platform assembly (which embeds package and
/// template catalogs and template resources) into the AppDomain. The platform assembly
/// is referenced indirectly by the test host through the CLI, so it may not
/// be loaded yet when a caller first reaches the catalog or resource loader.
/// Best-effort: failures are swallowed; callers surface a clear "not found"
/// message if the assembly cannot be loaded.
/// </summary>
internal static class MauiAssemblyLoader
{
    /// <summary>
    /// Walks loaded assemblies' references and loads any whose simple name
    /// ends with ".Maui" (the platform descriptor that embeds catalogs and
    /// template resources).
    /// </summary>
    public static void EnsureLoaded()
    {
        var loaded = new HashSet<string>(
            AppDomain.CurrentDomain.GetAssemblies().Select(a => a.GetName().Name!),
            StringComparer.OrdinalIgnoreCase);
        var queue = new Queue<Assembly>(AppDomain.CurrentDomain.GetAssemblies());

        while (queue.Count > 0)
        {
            var assembly = queue.Dequeue();
            AssemblyName[] refs;
            try
            {
                refs = assembly.GetReferencedAssemblies();
            }
            catch
            {
                continue;
            }

            foreach (var refName in refs)
            {
                if (refName.Name is null || loaded.Contains(refName.Name))
                {
                    continue;
                }

                if (!refName.Name.EndsWith(".Maui", System.StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                try
                {
                    var loadedAssembly = Assembly.Load(refName);
                    loaded.Add(loadedAssembly.GetName().Name!);
                    queue.Enqueue(loadedAssembly);
                }
                catch
                {
                    // Best-effort: if it cannot be loaded, the resource search
                    // below will throw a clear "not found" message.
                }
            }
        }
    }
}

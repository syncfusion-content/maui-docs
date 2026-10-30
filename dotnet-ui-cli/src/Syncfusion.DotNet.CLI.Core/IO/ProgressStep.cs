using System;
using System.Collections.Generic;

namespace Syncfusion.DotNet.Cli.Core;

/// <summary>
/// A single progress step for append-only output. Each step writes one line
/// to stdout in the form <c>[index/total] label</c> so users can
/// see what phase is running and how far the operation has progressed. The
/// reporter is intentionally not a live display; nothing is overwritten, and
/// previous steps stay visible.
/// </summary>
public sealed record ProgressStep(int Index, int Total, string Label)
{
    /// <summary>Legacy step ratio retained for API compatibility; never displayed as measurable progress.</summary>
    public int Percent
        => Total <= 0 ? 100 : Math.Clamp((int)Math.Round(100.0 * Index / Total), 0, 100);
}

/// <summary>
/// The ordered list of progress labels reported by <c>sfdotnet new maui</c>. The
/// labels are public so they can be referenced by tests; the list is the
/// single source of truth for the visible step count.
/// </summary>
public static class NewProjectProgress
{
    /// <summary>The ordered, user-visible steps reported during <c>sfdotnet new maui</c>.</summary>
    public static IReadOnlyList<string> DefaultSteps { get; } = new[]
    {
        "Validating target framework",
        "Creating project from MAUI template",
        "Adding Syncfusion packages",
        "Generating control files",
        "Registering Syncfusion in MauiProgram",
        "Restoring packages",
        "Building project",
    };
}

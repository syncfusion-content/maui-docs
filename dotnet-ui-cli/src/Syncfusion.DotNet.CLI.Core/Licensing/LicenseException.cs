namespace Syncfusion.DotNet.Cli.Core.Licensing;

/// <summary>A license-lifecycle failure that maps directly to a CLI exit code.</summary>
public sealed class LicenseException(int exitCode, string message) : Exception(message)
{
    public int ExitCode { get; } = exitCode;
}

/// <summary>Exit codes for the license commands.</summary>
public static class LicenseExitCodes
{
    public const int SignInFailed = 1;
    public const int NoSyncfusionPackages = 2;
    public const int AmbiguousProject = 3;
    public const int NoEntitlement = 4;
    public const int ServiceUnavailable = 5;
    public const int KeyFileMissing = 6;
    public const int ConflictingKeySource = 7;
    public const int RegistrationTargetMissing = 8;
    public const int Partial = 9;
}

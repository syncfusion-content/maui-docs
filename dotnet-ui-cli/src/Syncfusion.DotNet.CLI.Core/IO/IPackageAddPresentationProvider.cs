namespace Syncfusion.DotNet.CLI.Core;

/// <summary>Platform-owned presentation of package-add stages.</summary>
public interface IPackageAddPresentationProvider
{
    string PlatformName { get; }
    string Group(string stage);
    string FailureDetail(string stage);
}

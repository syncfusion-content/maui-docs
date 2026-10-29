using System.CommandLine.Parsing;

namespace Syncfusion.DotNet.CLI.Commands.Parsing;

/// <summary>
/// The outcome of parsing a command into a request. Either a typed value or a
/// human-readable validation error. Keeping both in one type lets command
/// handlers avoid duplicate validation and return a clear message.
/// </summary>
public sealed class ParseOutcome<T>
{
    private readonly T? _value;

    private ParseOutcome(T? value, string? error, int exitCode)
    {
        _value = value;
        Error = error;
        ExitCode = exitCode;
    }

    public T? Request => IsSuccess ? _value : default;
    public string? Error { get; }
    public int ExitCode { get; }

    public bool IsSuccess => Error is null;

    public static ParseOutcome<T> Ok(T value) => new(value, null, 0);
    public static ParseOutcome<T> Fail(string error, int exitCode = 1) => new(default, error, exitCode);
}

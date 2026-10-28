using System.IO;

namespace Syncfusion.DotNet.CLI.Tests;

/// <summary>
/// Redirects <see cref="System.Console.Out"/> and <see cref="System.Console.Error"/>
/// to string writers for the duration of a test, so command handlers that
/// write to <see cref="System.Console"/> can be asserted on. The CLI's
/// presenters write directly to <see cref="System.Console"/>, so this is the
/// simplest seam for tests.
/// </summary>
public sealed class ConsoleCapture : IDisposable
{
    private readonly TextWriter _originalOut;
    private readonly TextWriter _originalError;
    private readonly StringWriter _out;
    private readonly StringWriter _error;

    public ConsoleCapture()
    {
        _originalOut = System.Console.Out;
        _originalError = System.Console.Error;
        _out = new StringWriter();
        _error = new StringWriter();
        System.Console.SetOut(_out);
        System.Console.SetError(_error);
    }

    public string Out => _out.ToString();
    public string Error => _error.ToString();

    public void Reset()
    {
        _out.GetStringBuilder().Clear();
        _error.GetStringBuilder().Clear();
    }

    public void Dispose()
    {
        System.Console.SetOut(_originalOut);
        System.Console.SetError(_originalError);
        _out.Dispose();
        _error.Dispose();
    }
}

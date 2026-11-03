using Spectre.Console;
using Spectre.Console.Rendering;

namespace Syncfusion.DotNet.Cli.Presentation;

/// <summary>Retains Spectre's input/navigation semantics while appending unstyled prompt frames.</summary>
internal sealed class PlainPromptConsole(IAnsiConsole console) : IAnsiConsole
{
    public Profile Profile => console.Profile;
    public IAnsiConsoleCursor Cursor { get; } = new PlainCursor();
    public IAnsiConsoleInput Input => console.Input;
    public IExclusivityMode ExclusivityMode => console.ExclusivityMode;
    public RenderPipeline Pipeline { get; } = new();
    public void Clear(bool home) { }
    public void WriteAnsi(Action<AnsiWriter> action) { }
    public void Write(IRenderable renderable)
    {
        var width = Math.Max(2, Profile.Width);
        var options = new RenderOptions(Profile.Capabilities, new Size(width, Profile.Height));
        var text = string.Concat(Pipeline.Process(options, [renderable])
            .SelectMany(item => item.Render(options, width))
            .Where(segment => !segment.IsControlCode).Select(segment => segment.Text));
        if (!string.IsNullOrEmpty(text))
        {
            Profile.Out.Writer.Write(text);
            if (!text.EndsWith('\n')) Profile.Out.Writer.WriteLine();
        }
    }

    private sealed class PlainCursor : IAnsiConsoleCursor
    {
        public void Show(bool show) { }
        public void SetPosition(int column, int line) { }
        public void Move(CursorDirection direction, int steps) { }
    }
}

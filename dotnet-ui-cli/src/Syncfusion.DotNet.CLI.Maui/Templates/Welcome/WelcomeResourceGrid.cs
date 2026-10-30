namespace __ROOT_NAMESPACE__.Welcome;

/// <summary>Uses available content width, including split windows and rotation. Rows grow with text.</summary>
public sealed class WelcomeResourceGrid : Grid
{
    private int _columns;
    private int _children;
    public WelcomeResourceGrid()
    {
        SizeChanged += (_, _) => Reflow();
        ChildAdded += (_, _) => Reflow();
        ChildRemoved += (_, _) => Reflow();
    }

    private void Reflow()
    {
        var columns = Width >= 1000 ? 4 : Width >= 560 ? 2 : 1;
        if (columns == _columns && Children.Count == _children) return;
        _columns = columns;
        _children = Children.Count;
        ColumnDefinitions.Clear();
        RowDefinitions.Clear();
        for (var column = 0; column < columns; column++)
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        for (var row = 0; row < (Children.Count + columns - 1) / columns; row++)
            RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        for (var index = 0; index < Children.Count; index++)
        {
            SetRow(Children[index], index / columns);
            SetColumn(Children[index], index % columns);
        }
    }
}

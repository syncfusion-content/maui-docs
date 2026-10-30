namespace @__ROOT_NAMESPACE__.Welcome;

public partial class WelcomeView : Microsoft.UI.Xaml.Controls.UserControl
{
    public System.Action<string> OpenSampleAction { get; set; } = id => { };

    public WelcomeView()
    {
        InitializeComponent();
    }

    private void OpenSample(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        OpenSampleAction((string)((Microsoft.UI.Xaml.Controls.Button)sender).Tag);
    }
    private void ReflowWelcome(object sender, Microsoft.UI.Xaml.SizeChangedEventArgs e)
    {
        WelcomeContent.MinHeight = WelcomeScroll.ActualHeight;
        var width = System.Math.Max(0, WelcomeScroll.ActualWidth - 48);
        var columns = width >= 1000 ? 4 : width >= 560 ? 2 : 1;
        WelcomeResources.ColumnDefinitions.Clear();
        WelcomeResources.RowDefinitions.Clear();
        for (var column = 0; column < columns; column++)
            WelcomeResources.ColumnDefinitions.Add(new Microsoft.UI.Xaml.Controls.ColumnDefinition { Width = new Microsoft.UI.Xaml.GridLength(1, Microsoft.UI.Xaml.GridUnitType.Star) });
        for (var row = 0; row < (WelcomeResources.Children.Count + columns - 1) / columns; row++)
            WelcomeResources.RowDefinitions.Add(new Microsoft.UI.Xaml.Controls.RowDefinition { Height = Microsoft.UI.Xaml.GridLength.Auto });
        for (var index = 0; index < WelcomeResources.Children.Count; index++)
        {
            Microsoft.UI.Xaml.Controls.Grid.SetRow((Microsoft.UI.Xaml.FrameworkElement)WelcomeResources.Children[index], index / columns);
            Microsoft.UI.Xaml.Controls.Grid.SetColumn((Microsoft.UI.Xaml.FrameworkElement)WelcomeResources.Children[index], index % columns);
        }
        var stacked = width < 900;
        Microsoft.UI.Xaml.Controls.Grid.SetRow(WelcomeFooterLinks, stacked ? 1 : 0);
        Microsoft.UI.Xaml.Controls.Grid.SetColumn(WelcomeFooterLinks, stacked ? 0 : 1);
        WelcomeFooterLinks.Orientation = width < 360
            ? Microsoft.UI.Xaml.Controls.Orientation.Vertical
            : Microsoft.UI.Xaml.Controls.Orientation.Horizontal;
    }
}

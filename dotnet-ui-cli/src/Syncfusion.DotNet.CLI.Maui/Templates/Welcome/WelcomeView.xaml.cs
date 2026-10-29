namespace __ROOT_NAMESPACE__.Welcome;

public partial class WelcomeView : ContentPage
{
    public WelcomeView()
    {
        InitializeComponent();
        BindingContext = new WelcomeViewModel(page => Navigation.PushAsync(page));
        WelcomeScroll.SizeChanged += (_, _) => UpdateLayout();
        Footer.SizeChanged += (_, _) => UpdateFooter();
    }

    private void UpdateLayout()
    {
        WelcomeContent.WidthRequest = Math.Max(0, Math.Min(WelcomeScroll.Width, 1208));
        // Fill short viewports; the same grid grows naturally inside the vertical scroll view.
        WelcomeContent.MinimumHeightRequest = Math.Max(0, WelcomeScroll.Height);
    }

    private void UpdateFooter()
    {
        // Leave ample room for copyright, including larger accessibility text sizes.
        var stacked = Footer.Width < 900;
        Footer.ColumnDefinitions[1].Width = stacked ? new GridLength(0) : GridLength.Auto;
        Grid.SetRow(FooterLinks, stacked ? 1 : 0);
        Grid.SetColumn(FooterLinks, stacked ? 0 : 1);
        Footer.ColumnSpacing = stacked ? 0 : 24;

        // Give the link group a finite width; an Auto-sized FlexLayout can measure
        // as one button wide and wrap every link onto its own row.
        var linksWidth = Math.Max(0, Math.Min(Footer.Width, 400));
        FooterLinks.WidthRequest = linksWidth;
        var columns = linksWidth >= 360 ? 3 : linksWidth >= 240 ? 2 : 1;
        FooterLinks.ColumnDefinitions.Clear();
        FooterLinks.RowDefinitions.Clear();
        for (var column = 0; column < columns; column++)
            FooterLinks.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
        for (var row = 0; row < (FooterLinks.Children.Count + columns - 1) / columns; row++)
            FooterLinks.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        for (var index = 0; index < FooterLinks.Children.Count; index++)
        {
            FooterLinks.SetRow(FooterLinks.Children[index], index / columns);
            FooterLinks.SetColumn(FooterLinks.Children[index], index % columns);
        }
    }
}

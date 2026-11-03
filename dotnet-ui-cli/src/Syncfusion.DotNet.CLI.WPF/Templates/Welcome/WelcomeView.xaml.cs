namespace @__ROOT_NAMESPACE__.Welcome
{
    public partial class WelcomeView : System.Windows.Controls.UserControl
    {
        public System.Action<string> OpenSampleAction { get; set; } = id => { };

        public WelcomeView()
        {
            InitializeComponent();
        }

        private void OpenLink(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true }); }
            catch (System.Exception) { WelcomeStatus.Text = "This link could not be opened. Please try again."; }
            e.Handled = true;
        }
        private void OpenSample(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenSampleAction((string)((System.Windows.Controls.Button)sender).Tag);
        }
        private void ReflowFooter(object sender, System.Windows.SizeChangedEventArgs e)
        {
            var stacked = WelcomeFooter.ActualWidth < 900;
            System.Windows.Controls.Grid.SetRow(WelcomeFooterLinks, stacked ? 1 : 0);
            System.Windows.Controls.Grid.SetColumn(WelcomeFooterLinks, stacked ? 0 : 1);
            foreach (System.Windows.Controls.Border card in WelcomeResources.Children)
                card.Width = System.Math.Max(0, System.Math.Min(250, WelcomeFooter.ActualWidth - 16));
            WelcomeFooterLinks.MaxWidth = System.Math.Max(0, WelcomeFooter.ActualWidth);
            WelcomeFooterLinks.Margin = new System.Windows.Thickness(0, stacked ? 12 : 0, 0, 0);
        }
    }
}

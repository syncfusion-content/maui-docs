using Microsoft.UI.Xaml.Controls;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed partial class TreeViewPage : Page
{
    public TreeViewPage()
    {
        InitializeComponent();
        DataContext = new TreeViewViewModel();
    }
}

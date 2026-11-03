using Microsoft.UI.Xaml.Controls;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed partial class CartesianChartPage : Page
{
    public CartesianChartPage()
    {
        InitializeComponent();
        DataContext = new __VIEW_MODEL_NAME__();
    }
}

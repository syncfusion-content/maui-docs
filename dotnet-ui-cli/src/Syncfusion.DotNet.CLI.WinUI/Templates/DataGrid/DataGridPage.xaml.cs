using Microsoft.UI.Xaml.Controls;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed partial class DataGridPage : Page
{
    public DataGridPage()
    {
        InitializeComponent();
        DataContext = new __VIEW_MODEL_NAME__();
    }
}

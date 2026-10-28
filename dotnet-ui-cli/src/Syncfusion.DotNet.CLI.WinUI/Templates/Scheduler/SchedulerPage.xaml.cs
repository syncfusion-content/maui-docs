using Microsoft.UI.Xaml.Controls;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed partial class SchedulerPage : Page
{
    public SchedulerPage()
    {
        InitializeComponent();
        DataContext = new __VIEW_MODEL_NAME__();
    }
}
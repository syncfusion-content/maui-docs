using Microsoft.UI.Xaml.Controls;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KanbanPage : Page
    {
        public KanbanPage()
        {
            this.InitializeComponent();
            this.DataContext = new __VIEW_MODEL_NAME__();
        }
    }
}

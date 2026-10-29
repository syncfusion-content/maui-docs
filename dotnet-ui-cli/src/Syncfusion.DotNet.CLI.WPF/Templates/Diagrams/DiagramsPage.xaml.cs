using System.Windows.Controls;
namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : Page
    {
        public __VIEW_NAME__()
        {
            InitializeComponent();
            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(this, new Syncfusion.SfSkinManager.Theme("{{request.Theme}}"));
        }
    }
}

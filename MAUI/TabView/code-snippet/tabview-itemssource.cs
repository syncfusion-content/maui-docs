using Syncfusion.Maui.TabView;
namespace ItemTemplateSample;
public partial class MainPage : ContentPage
{
    TabItemsSourceViewModel model;
    SfTabView tabView;
    public MainPage()
    {
        InitializeComponent();
        model = new TabItemsSourceViewModel();
        this.BindingContext = model;
        tabView = new SfTabView();
        tabView.ItemsSource = model.TabItems;
        this.Content = tabView;
    }
}

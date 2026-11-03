namespace __ROOT_NAMESPACE__.__CONTROL_NAME__;

public partial class __VIEW_NAME__ : ContentPage
{
    public __VIEW_NAME__()
    {
        InitializeComponent();
        var viewModel = new __VIEW_MODEL_NAME__();
        BindingContext = viewModel;
        foreach (var node in viewModel.Nodes) diagram.Nodes.Add(node);
        foreach (var connector in viewModel.Connectors) diagram.Connectors.Add(connector);
        diagram.Created += (_, _) => diagram.FitToPage();
        diagram.SizeChanged += (_, _) => diagram.FitToPage();
    }
}

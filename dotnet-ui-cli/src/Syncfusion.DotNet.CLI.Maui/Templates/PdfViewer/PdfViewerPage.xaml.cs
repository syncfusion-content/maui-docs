namespace __ROOT_NAMESPACE__.__CONTROL_NAME__;

public partial class __VIEW_NAME__ : ContentPage
{
    public __VIEW_NAME__()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is __VIEW_MODEL_NAME__ viewModel)
            await viewModel.LoadDocumentAsync();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        PdfViewer.UnloadDocument();
        if (BindingContext is __VIEW_MODEL_NAME__ viewModel)
            viewModel.UnloadDocument();
    }
}

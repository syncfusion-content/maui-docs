using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed partial class RibbonPage : Page
{
    private const string SampleText = "Welcome to the Ribbon sample. Select text and try the Clipboard commands, or start a new document.";

    public RibbonPage()
    {
        InitializeComponent();
        Editor.Text = SampleText;
    }

    private void OnCommand(object sender, RoutedEventArgs e)
    {
        switch ((sender as FrameworkElement)?.Tag as string)
        {
            case "new": Editor.Text = ""; break;
            case "reset": Editor.Text = SampleText; break;
            case "cut": Editor.CutSelectionToClipboard(); break;
            case "copy": Editor.CopySelectionToClipboard(); break;
            case "paste": Editor.PasteFromClipboard(); break;
            case "undo": Editor.Undo(); break;
            case "select-all": Editor.SelectAll(); break;
        }
        Editor.Focus(FocusState.Programmatic);
    }
}

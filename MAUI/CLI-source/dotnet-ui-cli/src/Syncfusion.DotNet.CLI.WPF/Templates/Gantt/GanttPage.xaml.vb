Imports System.Windows.Controls

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    ''' <summary>
    ''' Interaction logic for __VIEW_NAME__.xaml
    ''' </summary>
    Partial Public Class __VIEW_NAME__
        Inherits Page

        Public Sub New()
            InitializeComponent()
            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(Me, New Syncfusion.SfSkinManager.Theme("{{request.Theme}}"))
        End Sub
    End Class
End Namespace

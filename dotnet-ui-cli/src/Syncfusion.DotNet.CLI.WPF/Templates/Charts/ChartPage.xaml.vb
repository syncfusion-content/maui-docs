
Imports System.Windows.Controls

Namespace __ROOT_NAMESPACE__.Chart
    Public Partial Class ChartPage
        Inherits Page
        Public Sub New()
            InitializeComponent()
            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(Me, New Syncfusion.SfSkinManager.Theme("{{request.Theme}}"))
        End Sub
    End Class
End Namespace

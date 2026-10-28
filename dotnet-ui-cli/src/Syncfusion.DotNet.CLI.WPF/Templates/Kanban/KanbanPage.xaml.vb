
Imports System.Windows.Controls

Namespace __ROOT_NAMESPACE__.Kanban
    Public Partial Class KanbanPage
        Inherits Page
        Public Sub New()
            InitializeComponent()
            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(Me, New Syncfusion.SfSkinManager.Theme("{{request.Theme}}"))
        End Sub
    End Class
End Namespace

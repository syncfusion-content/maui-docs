
Imports System.Windows
Imports System.Windows.Controls

Namespace __ROOT_NAMESPACE__.DockingManager
    Public Partial Class DockingManagerPage
        Inherits Page
        Public Sub New()
            InitializeComponent()
            Syncfusion.SfSkinManager.SfSkinManager.SetTheme(Me, New Syncfusion.SfSkinManager.Theme("{{request.Theme}}"))
        End Sub

        Private Sub dockingManager_Loaded(sender As Object, e As RoutedEventArgs)
            dockingManager.LoadDockState()
        End Sub
    End Class
End Namespace

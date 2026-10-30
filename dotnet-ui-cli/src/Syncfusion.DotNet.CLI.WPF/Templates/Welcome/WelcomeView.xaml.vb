Namespace [__ROOT_NAMESPACE__].Welcome
    Partial Public Class WelcomeView
        Inherits System.Windows.Controls.UserControl
        Public Property OpenSampleAction As System.Action(Of String) = Sub(id)
                                                                       End Sub
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub OpenLink(sender As Object, e As System.Windows.Navigation.RequestNavigateEventArgs)
            Try
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri) With {.UseShellExecute = True})
            Catch ex As System.Exception
                WelcomeStatus.Text = "This link could not be opened. Please try again."
            End Try
            e.Handled = True
        End Sub
        Private Sub OpenSample(sender As Object, e As System.Windows.RoutedEventArgs)
            OpenSampleAction.Invoke(CStr(DirectCast(sender, System.Windows.Controls.Button).Tag))
        End Sub
        Private Sub ReflowFooter(sender As Object, e As System.Windows.SizeChangedEventArgs)
            Dim stacked = WelcomeFooter.ActualWidth < 900
            System.Windows.Controls.Grid.SetRow(WelcomeFooterLinks, If(stacked, 1, 0))
            System.Windows.Controls.Grid.SetColumn(WelcomeFooterLinks, If(stacked, 0, 1))
            For Each card As System.Windows.Controls.Border In WelcomeResources.Children
                card.Width = System.Math.Max(0, System.Math.Min(250, WelcomeFooter.ActualWidth - 16))
            Next
            WelcomeFooterLinks.MaxWidth = System.Math.Max(0, WelcomeFooter.ActualWidth)
            WelcomeFooterLinks.Margin = New System.Windows.Thickness(0, If(stacked, 12, 0), 0, 0)
        End Sub
    End Class
End Namespace

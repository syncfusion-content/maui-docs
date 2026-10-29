
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace __ROOT_NAMESPACE__.TabControlAdv
    Public Partial Class TabControlAdvPage
        Inherits UserControl
        Private ReadOnly components As IContainer = New Container()
        Private ReadOnly tabControl As Syncfusion.Windows.Forms.Tools.TabControlAdv
        Private pageCount As Integer = 3

        Public Sub New()
            tabControl = New Syncfusion.Windows.Forms.Tools.TabControlAdv() With {
                .Dock = DockStyle.Fill,
                .Name = "tabControl",
                .ShowToolTips = True,
                .TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful)
            }
            DirectCast(tabControl, ISupportInitialize).BeginInit()

            AddPage("Home", "Welcome to TabControlAdv.")
            AddPage("Products", "Each tab hosts its own content.")
            AddPage("Contact", "Use the button below to add or close tabs.")

            DirectCast(tabControl, ISupportInitialize).EndInit()

            Dim addButton As New Button() With {.Text = "Add tab", .Dock = DockStyle.Bottom, .Height = 36}
            AddHandler addButton.Click, AddressOf OnAddTabClick

            Controls.Add(tabControl)
            Controls.Add(addButton)

            AutoScaleDimensions = New SizeF(8F, 16F)
            AutoScaleMode = AutoScaleMode.Font
            MyBase.Dock = DockStyle.Fill
            Name = "TabControlAdvPage"
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub AddPage(title As String, text As String)
            Dim page As New TabPageAdv() With {.Text = title, .ShowCloseButton = True}
            page.Controls.Add(New Label() With {.Text = text, .Dock = DockStyle.Top, .Height = 32, .TextAlign = ContentAlignment.MiddleLeft})
            tabControl.TabPages.Add(page)
        End Sub

        Private Sub OnAddTabClick(sender As Object, e As EventArgs)
            pageCount += 1
            AddPage("Tab " & pageCount, "New tab " & pageCount)
            tabControl.SelectedIndex = tabControl.TabCount - 1
        End Sub
    End Class
End Namespace

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace __ROOT_NAMESPACE__.Ribbon
    Public Partial Class RibbonPage
        Inherits UserControl
        Private ReadOnly components As IContainer = New Container()
        Private ReadOnly ribbonControl As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
        Private ReadOnly statusLabel As New Label()
        Private ReadOnly editor As New RichTextBox()
        Private ReadOnly backStageView As Syncfusion.Windows.Forms.BackStageView
        Private ReadOnly backStage As Syncfusion.Windows.Forms.BackStage

        Public Sub New()
            ribbonControl = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv() With {
                .Dock = DockStyleEx.Top,
                .AutoLayoutToolStrip = True,
                .Name = "ribbonControl",
                .MenuButtonText = "File",
                .QuickPanelVisible = False,
                .ShowMinimizeButton = False,
                .ShowRibbonDisplayOptionButton = False,
                .ShowQuickItemsDropDownButton = False,
                .OfficeColorScheme = ToolStripEx.ColorScheme.Managed,
                .RibbonStyle = RibbonStyle.Office2016,
                .Office2016ColorScheme = Office2016ColorScheme.Colorful,
                .Size = New Size(899, 236)
            }
            DirectCast(ribbonControl, ISupportInitialize).BeginInit()

            Dim homeTab As New ToolStripTabItem() With {.Text = "Home", .Name = "homeTab"}
            homeTab.Panel.Text = "Home"
            homeTab.Panel.Padding = New Padding(0, 1, 39, 0)
            homeTab.Panel.Controls.Add(CreateGroup("Clipboard", 0, "Paste", "Cut", "Copy"))
            homeTab.Panel.Controls.Add(CreateGroup("Font", 1, "Bold", "Italic", "Underline"))

            Dim insertTab As New ToolStripTabItem() With {.Text = "Insert", .Name = "insertTab"}
            insertTab.Panel.Text = "Insert"
            insertTab.Panel.Padding = New Padding(0, 1, 39, 0)
            insertTab.Panel.Controls.Add(CreateGroup("Pages", 0, "Blank Page"))

            ribbonControl.Header.AddMainItem(homeTab)
            ribbonControl.Header.AddMainItem(insertTab)
            ribbonControl.Controls.Add(homeTab.Panel)
            ribbonControl.Controls.Add(insertTab.Panel)
            DirectCast(ribbonControl, ISupportInitialize).EndInit()

            backStageView = New Syncfusion.Windows.Forms.BackStageView(components)
            backStage = New Syncfusion.Windows.Forms.BackStage() With {
                .Name = "backStage",
                .OfficeColorScheme = ToolStripEx.ColorScheme.Managed,
                .ThemeName = "BackStage2016Renderer",
                .Size = New Size(898, 498),
                .Visible = False
            }
            DirectCast(backStage, ISupportInitialize).BeginInit()
            Dim openButton As New Syncfusion.Windows.Forms.BackStageButton() With {.Text = "Open"}
            Dim saveAsButton As New Syncfusion.Windows.Forms.BackStageButton() With {.Text = "Save As"}
            Dim exitButton As New Syncfusion.Windows.Forms.BackStageButton() With {.Text = "Exit"}
            AddHandler exitButton.Click, Sub(s, e) FindForm()?.Close()
            backStage.Controls.Add(openButton)
            backStage.Controls.Add(saveAsButton)
            backStage.Controls.Add(exitButton)
            DirectCast(backStage, ISupportInitialize).EndInit()
            backStageView.BackStage = backStage
            ribbonControl.BackStageView = backStageView

            editor.Dock = DockStyle.Fill
            editor.BorderStyle = BorderStyle.None
            editor.Text = "Select text and use the Home tab to cut, copy, paste or format it." & Environment.NewLine & "Use the Insert tab to add content."

            statusLabel.Dock = DockStyle.Bottom
            statusLabel.Height = 28
            statusLabel.TextAlign = ContentAlignment.MiddleLeft
            statusLabel.Text = "Ready"

            Controls.Add(editor)
            Controls.Add(statusLabel)
            Controls.Add(ribbonControl)

            Syncfusion.Windows.Forms.SkinManager.SetVisualStyle(Me, Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful)

            AutoScaleDimensions = New SizeF(8F, 16F)
            AutoScaleMode = AutoScaleMode.Font
            MyBase.Dock = DockStyle.Fill
            Name = "RibbonPage"
        End Sub

        Protected Overrides Sub OnHandleCreated(e As EventArgs)
            MyBase.OnHandleCreated(e)

            ' BackStageView must be hosted by a Form.
            Dim form As Form = FindForm()
            If form IsNot Nothing AndAlso backStageView.HostForm Is Nothing Then
                backStageView.HostForm = form
                form.Controls.Add(backStage)
            End If
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Function CreateGroup(title As String, index As Integer, ParamArray small As String()) As ToolStripEx
            Dim group As New ToolStripEx() With {
                .Name = title & "Group",
                .Text = title,
                .Dock = System.Windows.Forms.DockStyle.None,
                .ForeColor = Color.MidnightBlue,
                .CollapsedDropDownButtonText = title,
                .GripStyle = ToolStripGripStyle.Hidden,
                .ImageScalingSize = New Size(20, 20),
                .Office12Mode = False,
                .ShowLauncher = False,
                .Padding = New Padding(3, 0, 0, 0),
                .Location = New Point(index * 250, 1),
                .Size = New Size(250, 128)
            }

            For Each itemText As String In small
                Dim button = CreateButton(itemText)
                button.TextAlign = ContentAlignment.BottomCenter
                button.TextImageRelation = TextImageRelation.ImageAboveText
                button.ImageScaling = ToolStripItemImageScaling.None
                group.Items.Add(button)
            Next
            Return group
        End Function

        Private Function CreateButton(text As String) As ToolStripButton
            Dim button As New ToolStripButton(text) With {.Name = text.Replace(" ", String.Empty) & "Button", .DisplayStyle = ToolStripItemDisplayStyle.Text}
            Dim icon = LoadIcon(text)
            If icon IsNot Nothing Then
                button.Image = icon
                button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            End If

            AddHandler button.Click, AddressOf OnCommandClick
            Return button
        End Function

        Private Shared Function LoadIcon(command As String) As Image
            Dim file As String
            Select Case command
                Case "Paste" : file = "Paste32flat.png"
                Case "Cut" : file = "Cut16flat.png"
                Case "Copy" : file = "Copy16flat.png"
                Case "Bold" : file = "Bold16flat.png"
                Case "Italic" : file = "Italic16flat.png"
                Case "Underline" : file = "Underline16flat.png"
                Case "Blank Page" : file = "blank-1.png"
                Case Else : Return Nothing
            End Select

            Dim path = System.IO.Path.Combine(AppContext.BaseDirectory, "__CONTROL_NAME__", "Resources", file)
            If Not System.IO.File.Exists(path) Then Return Nothing

            Using loaded = Image.FromFile(path)
                Return New Bitmap(loaded, New Size(16, 16))
            End Using
        End Function

        Private Sub OnCommandClick(sender As Object, e As EventArgs)
            Dim command = DirectCast(sender, System.Windows.Forms.ToolStripItem).Text
            Select Case command
                Case "Paste" : editor.Paste()
                Case "Cut" : editor.Cut()
                Case "Copy" : editor.Copy()
                Case "Bold" : ToggleStyle(FontStyle.Bold)
                Case "Italic" : ToggleStyle(FontStyle.Italic)
                Case "Underline" : ToggleStyle(FontStyle.Underline)
                Case "Picture" : editor.SelectedText = "[Picture]"
                Case "Shapes" : editor.SelectedText = "[Shape]"
                Case "Chart" : editor.SelectedText = "[Chart]"
                Case "Blank Page" : editor.AppendText(Environment.NewLine & Environment.NewLine)
                Case "Cover Page" : editor.SelectedText = "[Cover Page]" & Environment.NewLine
                Case "Page Break" : editor.SelectedText = Environment.NewLine & "--- page break ---" & Environment.NewLine
            End Select

            statusLabel.Text = command & " clicked"
        End Sub

        Private Sub ToggleStyle(style As FontStyle)
            Dim font = If(editor.SelectionFont, editor.Font)
            editor.SelectionFont = New Font(font, font.Style Xor style)
        End Sub
    End Class
End Namespace
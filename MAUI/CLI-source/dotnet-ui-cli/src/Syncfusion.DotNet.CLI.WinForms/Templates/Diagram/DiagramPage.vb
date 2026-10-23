
Imports Rectangle = System.Drawing.Rectangle
Imports FontStyle = System.Drawing.FontStyle
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools

Namespace __ROOT_NAMESPACE__.Diagram
    Public Partial Class DiagramPage
        Inherits UserControl
        Private ReadOnly components As IContainer = New Container()
        Private ReadOnly colorDialog As ColorDialog
        Private ReadOnly collapseImage As Image
        Private ReadOnly diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
        Private ReadOnly expandImage As Image
        Private ReadOnly groupBarItem As GroupBarItem
        Private ReadOnly openFileDialog As OpenFileDialog
        Private ReadOnly paletteGroupBar As PaletteGroupBar
        Private ReadOnly saveFileDialog As SaveFileDialog

        Public Sub New()
            colorDialog = New ColorDialog()
            groupBarItem = New GroupBarItem With {
    .BackColor = Color.FromArgb(191, 219, 254),
    .Client = Nothing,
    .Text = "Flowchart Symbols"
}
            openFileDialog = New OpenFileDialog With {
                .FileName = "openFileDialog1"
            }
            saveFileDialog = New SaveFileDialog()
            collapseImage = LoadResourceImage("CollapseImage.png")
            expandImage = LoadResourceImage("ExpandImage.png")

            diagram = New Controls.Diagram(components) With {
    .Dock = DockStyle.Fill,
    .Model = New Model(components),
    .Location = Point.Empty,
    .Margin = New Padding(4),
    .Name = "diagram1",
    .Size = New Size(1600, 500),
    .TabIndex = 0,
    .VScroll = True,
    .HScroll = True,
    .EnableTouchMode = False,
    .LayoutManager = Nothing,
    .ScrollVirtualBounds = RectangleF.Empty,
    .SmartSizeBox = False,
    .Text = "diagram1"
}
            diagram.Controller.Constraint = Constraints.PageEditable
            diagram.Controller.DefaultConnectorTool = ConnectorTool.OrgLineConnectorTool
            diagram.Controller.PasteOffset = New SizeF(10F, 10F)
            diagram.Binding = New Syncfusion.Windows.Forms.Diagram.Binding With {
    .DefaultConnector = Nothing,
    .DefaultNode = Nothing,
    .Diagram = diagram,
    .Id = Nothing,
    .Label = New List(Of String)(),
    .ParentId = Nothing
}
            diagram.View.BackgroundColor = Color.White
            diagram.View.ClientRectangle = Rectangle.Empty
            diagram.View.Controller = diagram.Controller
            diagram.View.Grid.MinPixelSpacing = 4F
            diagram.View.Grid.Visible = False
            diagram.View.ScrollVirtualBounds = RectangleF.Empty
            diagram.View.ZoomType = ZoomType.Center
            diagram.Model.AlignmentType = AlignmentType.SelectedNode
            diagram.Model.BackgroundStyle.PathBrushStyle = PathGradientBrushStyle.RectangleCenter
            diagram.Model.DocumentScale.DisplayName = "No Scale"
            diagram.Model.DocumentScale.Height = 1F
            diagram.Model.DocumentScale.Width = 1F
            diagram.Model.DocumentSize.Height = 3000F
            diagram.Model.DocumentSize.Width = 3000F
            diagram.Model.LineStyle.DashPattern = Nothing
            diagram.Model.LineStyle.LineColor = Color.Black
            diagram.Model.LineStyle.LineWidth = 0F
            diagram.Model.LogicalSize = New SizeF(3000F, 3000F)
            diagram.Model.Padding = New Padding(0)
            diagram.Model.ShadowStyle.Color = Color.FromArgb(128, 105, 105, 105)
            diagram.Model.ShadowStyle.ForeColor = Color.FromArgb(128, 105, 105, 105)
            paletteGroupBar = New PaletteGroupBar(components) With {
    .AllowDrop = True,
    .Dock = DockStyle.Fill,
    .EditMode = False,
    .FlatLook = True,
    .BorderColor = ColorTranslator.FromHtml("#119EDA"),
    .BackColor = Color.FromArgb(235, 235, 235),
    .BeforeTouchSize = New Size(360, 500),
    .ExpandButtonToolTip = Nothing,
    .CollapseImage = collapseImage,
    .ExpandImage = expandImage,
    .GroupBarItemHeight = 32,
    .GroupBarDropDownToolTip = Nothing,
    .IndexOnVisibleItems = True,
    .MinimizeButtonToolTip = Nothing,
    .NavigationPaneTooltip = Nothing,
    .PopupClientSize = Size.Empty,
    .SmartSizeBox = False,
    .Splittercolor = SystemColors.ControlDark,
    .Text = "paletteGroupBar1",
    .TextAlign = TextAlignment.Left,
    .ThemeName = "Metro",
    .VisualStyle = VisualStyle.Metro
}
            paletteGroupBar.Diagram = diagram

            Dim palettePanel = New Panel With {
    .Dock = DockStyle.Left,
    .Width = 360,
    .BackColor = SystemColors.Control,
    .Location = Point.Empty,
    .Margin = New Padding(4),
    .Name = "panel2",
    .Visible = True
}
            palettePanel.Controls.Add(paletteGroupBar)
            Dim diagramPanel = New Panel With {
    .Dock = DockStyle.Fill,
    .Location = New Point(360, 0),
    .Margin = New Padding(4),
    .Name = "panel3",
    .Size = New Size(1600, 500)
}
            diagramPanel.Controls.Add(diagram)

            Controls.Add(diagramPanel)
            Controls.Add(palettePanel)
            MyBase.BackColor = Color.White
            AutoScaleDimensions = New SizeF(8F, 16F)
            AutoScaleMode = AutoScaleMode.Font
            MyBase.Dock = DockStyle.Fill
            Margin = New Padding(4)
            Name = "DiagramPage"
            Text = "Flow Diagram"

            paletteGroupBar.LoadPalette(GetResourcePath("Basic Shapes.xml"))
            paletteGroupBar.LoadPalette(GetResourcePath("Flowchart Symbols.xml"))
            AddHandler diagram.EventSink.Deserialized, AddressOf OnDiagramDeserialized
            diagram.LoadXml(GetResourcePath("Flow Diagram.xml"))
            diagram.ShowRulers = True
            diagram.RulersHeight = 25
            diagram.HorizontalRuler.GridSpacingType = GridSpacingType.Variable
            diagram.VerticalRuler.GridSpacingType = GridSpacingType.Variable
            diagram.View.Grid.Visible = True
            diagram.View.Grid.SnapToGrid = True
            diagram.BeginUpdate()
            SetPaletteAppearance()
            diagram.EndUpdate()
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                collapseImage.Dispose()
                expandImage.Dispose()
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Shared Function GetResourcePath(fileName As String) As String
            Dim path = IO.Path.Combine(AppContext.BaseDirectory, "Diagram", "Resources", fileName)
            If Not File.Exists(path) Then
                Throw New FileNotFoundException("A required diagram sample resource was not found.", path)
            End If

            Return path
        End Function

        Private Shared Function LoadResourceImage(fileName As String) As Image
            Dim path = GetResourcePath(fileName)
            Using image = Drawing.Image.FromFile(path)
                Return New Bitmap(image)
            End Using
        End Function

        Private Sub OnDiagramDeserialized(eventArgs As SerializationEventsArgs)
            eventArgs.View.Grid.GridStyle = GridStyle.Point
        End Sub

        Private Sub SetPaletteAppearance()
            paletteGroupBar.BorderStyle = BorderStyle.None
            paletteGroupBar.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
            paletteGroupBar.ForeColor = Color.White
            paletteGroupBar.GroupBarItemHeight = 32
            paletteGroupBar.IndexOnVisibleItems = True
            paletteGroupBar.SmartSizeBox = False
            paletteGroupBar.Text = "paletteGroupBar1"
            paletteGroupBar.TextAlign = TextAlignment.Left
            paletteGroupBar.ThemeName = "Metro"
            paletteGroupBar.VisualStyle = VisualStyle.Metro

            Dim paletteView As PaletteGroupView = Nothing

            For Each item As GroupBarItem In paletteGroupBar.GroupBarItems
                If Equals(item.Text, "BasicShapes") Then
                    item.Text = "Basic Shapes"
                ElseIf Equals(item.Text, "Flowchart Symbols") Then
                    item.Text = "Flowchart Shapes"
                End If

                paletteView = TryCast(item.Client, PaletteGroupView)
                If paletteView IsNot Nothing Then
                    paletteView.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                    paletteView.ForeColor = Color.Black
                    paletteView.SelectedItemColor = Color.FromArgb(255, 219, 118)
                    paletteView.HighlightItemColor = Color.FromArgb(255, 227, 149)
                    paletteView.SelectingItemColor = Color.FromArgb(255, 238, 184)
                    paletteView.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
                    paletteView.FlowViewItemTextLength = CInt(DpiAware.LogicalToDeviceUnits(80))
                    paletteView.BackColor = Color.White
                    paletteView.FlowView = True
                    paletteView.ShowToolTips = True
                    paletteView.ShowFlowViewItemText = True
                    paletteView.TextWrap = True
                    paletteView.FlatLook = True
                    paletteView.BorderStyle = BorderStyle.FixedSingle
                End If
            Next
        End Sub

    End Class
End Namespace

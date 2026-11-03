
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace __ROOT_NAMESPACE__.DockingManager
    Public Partial Class DockingManagerPage
        Inherits UserControl
        Private ReadOnly components As IContainer = New Container()
        Private ReadOnly dockingManager As Syncfusion.Windows.Forms.Tools.DockingManager
        Private ReadOnly panel1 As Panel = CreatePanel("panel1")
        Private ReadOnly panel2 As Panel = CreatePanel("panel2")
        Private ReadOnly panel3 As Panel = CreatePanel("panel3")
        Private ReadOnly panel4 As Panel = CreatePanel("panel4")
        Private ReadOnly panel5 As Panel = CreatePanel("panel5")
        Private ReadOnly panel6 As Panel = CreatePanel("panel6")

        Public Sub New()
            dockingManager = New Syncfusion.Windows.Forms.Tools.DockingManager(components) With {
    .AnimateAutoHiddenWindow = True,
    .AutoHideEnabled = True,
    .AutoHideTabForeColor = Color.Empty,
    .CloseTabOnMiddleClick = False,
    .DockTabAlignment = DockTabAlignmentStyle.Right,
    .DragProviderStyle = DragProviderStyle.Office2016Colorful,
    .HostControl = Me,
    .MetroButtonColor = Color.White,
    .MetroColor = Color.FromArgb(17, 158, 218),
    .MetroSplitterBackColor = Color.FromArgb(155, 159, 183),
    .ReduceFlickeringInRtl = False
}
            dockingManager.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Close, "CloseButton"))
            dockingManager.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Pin, "PinButton"))
            dockingManager.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Maximize, "MaximizeButton"))
            dockingManager.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Restore, "RestoreButton"))
            dockingManager.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Menu, "MenuButton"))

            ConfigureDockPanel(panel1)
            ConfigureDockPanel(panel2)
            ConfigureDockPanel(panel3)
            ConfigureDockPanel(panel4)
            ConfigureDockPanel(panel5)
            ConfigureDockPanel(panel6)

            AddHandler Load, AddressOf OnLoaded
            AutoScaleDimensions = New SizeF(8F, 16F)
            AutoScaleMode = AutoScaleMode.Font
            MyBase.Dock = DockStyle.Fill
            Name = "Form1"
            Size = New Size(1282, 450)
            Text = "Form1"
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Shared Function CreatePanel(name As String) As Panel
            Return New Panel With {
    .Location = New Point(1, 30),
    .Name = name,
    .Size = New Size(If(Equals(name, "panel4"), 171, 200), 419),
                                                                                    .TabIndex = If(Equals(name, "panel1"), 0, If(Equals(name, "panel2"), 2, If(Equals(name, "panel3"), 4, If(Equals(name, "panel4"), 6, If(Equals(name, "panel5"), 12, 23)))))
}
        End Function

        Private Sub ConfigureDockPanel(panel As Panel)
            dockingManager.SetDockLabel(panel, panel.Name)
            dockingManager.SetEnableDocking(panel, True)
            Dim captionButtons = New CaptionButtonsCollection()
            captionButtons.MergeWith(dockingManager.CaptionButtons, False)
            dockingManager.SetCustomCaptionButtons(panel, captionButtons)
        End Sub

        Private Sub OnLoaded(sender As Object, e As EventArgs)
            dockingManager.DockControl(panel1, Me, DockingStyle.Top, 100)
            dockingManager.DockControl(panel5, Me, DockingStyle.Top, 200)
            dockingManager.DockControl(panel6, Me, DockingStyle.Right, 300)
            dockingManager.DockControlInAutoHideMode(panel2, DockingStyle.Top, 100)
            dockingManager.SetOuterDockAbility(panel1, DockAbility.Top Or DockAbility.Bottom)

            Dim bounds = MyBase.Bounds
            dockingManager.FloatControl(panel3, New Rectangle(bounds.Right - 300, bounds.Bottom - 300, 200, 200))
        End Sub
    End Class
End Namespace

Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.Controls
Namespace [__ROOT_NAMESPACE__].Welcome
    Public Class WelcomeView
        Inherits UserControl
        Public Sub New(tabs As Syncfusion.Windows.Forms.Tools.TabControlAdv)
            AddWelcome(tabs)
        End Sub
        Private Shared Function FindSample(tabs As Syncfusion.Windows.Forms.Tools.TabControlAdv, id As String) As Integer
            For index = 0 To tabs.TabPages.Count - 1
                If TryCast(tabs.TabPages(index).Tag, String) = id Then Return index
            Next
            Return 0
        End Function

        Private Sub AddWelcome(tabs As Syncfusion.Windows.Forms.Tools.TabControlAdv)
            Dim page As System.Windows.Forms.UserControl = Me
            AutoScroll = True
            AutoScaleMode = AutoScaleMode.Font
            Font = System.Drawing.SystemFonts.MessageBoxFont
            Dim layout = New Panel()
            Dim content = New FlowLayoutPanel() With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .FlowDirection = FlowDirection.TopDown, .WrapContents = False, .Margin = Padding.Empty}
            AddWelcomeText(content, "Welcome to Your New WinForms App", 28)
            AddWelcomeText(content, "Your application is running successfully.", 12)
            Dim sampleBox = New WelcomePanel() With {.ColumnCount = 1, .Padding = New Padding(24), .Margin = New Padding(0, 24, 0, 24)}
            AddWelcomeText(sampleBox, "Your control samples", 18)
            __SAMPLE_HINT__
            Dim sampleLinks = New FlowLayoutPanel() With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .WrapContents = True, .Margin = Padding.Empty}
            __SAMPLES__
            sampleBox.Controls.Add(sampleLinks)
            __EMPTY_STATE__
            content.Controls.Add(sampleBox)
            AddWelcomeText(content, "Build something great", 18)
            Dim resourceCards = New FlowLayoutPanel() With {.FlowDirection = FlowDirection.LeftToRight, .WrapContents = True, .Margin = Padding.Empty}
            __RESOURCES__
            content.Controls.Add(resourceCards)
            Dim footer = New Panel()
            Dim copyright = New Label() With {.Text = "__COPYRIGHT__", .AutoSize = True, .Margin = Padding.Empty}
            Dim links = New FlowLayoutPanel() With {.FlowDirection = FlowDirection.LeftToRight, .WrapContents = True, .Margin = Padding.Empty}
            __FOOTER_LINKS__
            footer.Controls.Add(copyright)
            footer.Controls.Add(links)
            layout.Controls.Add(content)
            layout.Controls.Add(footer)
            Controls.Add(layout)
            Dim arranging = False
            Dim arrange As System.Action = Sub()
                If arranging OrElse ClientSize.Width < 1 Then Return
                arranging = True
                layout.SuspendLayout()
                Try
                    Dim unit = Font.Height / 15.0F
                    Dim padding = CInt(System.Math.Ceiling(24 * unit))
                    Dim gap = CInt(System.Math.Ceiling(16 * unit))
                    Dim width = System.Math.Max(1, System.Math.Min(CInt(1160 * unit), ClientSize.Width - padding * 2 - SystemInformation.VerticalScrollBarWidth))
                    layout.Width = width
                    layout.Left = System.Math.Max(padding, (ClientSize.Width - width) \ 2)
                    layout.Top = padding
                    content.Width = width
                    For Each child As Control In content.Controls
                        child.Width = width
                        child.MaximumSize = New System.Drawing.Size(width, 0)
                    Next
                    sampleBox.Width = width
                    sampleLinks.MaximumSize = New System.Drawing.Size(System.Math.Max(1, width - sampleBox.Padding.Horizontal), 0)
                    For Each child As Control In sampleBox.Controls
                        child.MaximumSize = New System.Drawing.Size(System.Math.Max(1, width - sampleBox.Padding.Horizontal), 0)
                    Next
                    sampleBox.Height = sampleBox.GetPreferredSize(New System.Drawing.Size(width, 0)).Height
                    Dim columns = If(width >= 1000 * unit, 4, If(width >= 600 * unit, 2, 1))
                    Dim cardWidth = System.Math.Max(1, (width - (columns - 1) * gap) \ columns)
                    Dim rowHeights(3) As Integer
                    For Each card As Control In resourceCards.Controls
                        Dim innerWidth = System.Math.Max(1, cardWidth - card.Padding.Horizontal)
                        For row = 0 To card.Controls.Count - 1
                            Dim item = card.Controls(row)
                            item.MaximumSize = New System.Drawing.Size(innerWidth, 0)
                            rowHeights(row) = System.Math.Max(rowHeights(row), item.GetPreferredSize(New System.Drawing.Size(innerWidth, 0)).Height + item.Margin.Vertical)
                        Next
                    Next
                    Dim cardHeight = System.Math.Max(CInt(260 * unit), 40 + rowHeights(0) + rowHeights(1) + rowHeights(2) + rowHeights(3))
                    For Each card As TableLayoutPanel In resourceCards.Controls
                        card.RowStyles(0).Height = rowHeights(0)
                        card.RowStyles(1).Height = rowHeights(1)
                        card.RowStyles(3).SizeType = SizeType.Absolute
                        card.RowStyles(3).Height = rowHeights(3)
                    Next
                    For index = 0 To resourceCards.Controls.Count - 1
                        Dim card = resourceCards.Controls(index)
                        card.Size = New System.Drawing.Size(cardWidth, cardHeight)
                        card.Margin = New Padding(0, 0, If(index Mod columns = columns - 1, 0, gap), gap)
                    Next
                    resourceCards.Height = ((resourceCards.Controls.Count + columns - 1) \ columns) * (cardHeight + gap)
                    content.PerformLayout()
                    content.Height = content.PreferredSize.Height
                    Dim linkWidth = 0
                    For Each link As Control In links.Controls
                        linkWidth += link.PreferredSize.Width + link.Margin.Horizontal
                    Next
                    Dim stacked = width < copyright.PreferredSize.Width + linkWidth + gap
                    links.Width = System.Math.Min(width, linkWidth)
                    links.Height = links.GetPreferredSize(New System.Drawing.Size(links.Width, 0)).Height
                    copyright.MaximumSize = New System.Drawing.Size(If(stacked, width, System.Math.Max(1, width - linkWidth - gap)), 0)
                    copyright.Location = New System.Drawing.Point(0, If(stacked, 0, System.Math.Max(0, (links.Height - copyright.Height) \ 2)))
                    links.Location = New System.Drawing.Point(If(stacked, 0, width - links.Width), If(stacked, copyright.Height + gap, 0))
                    footer.Size = New System.Drawing.Size(width, System.Math.Max(copyright.Height, links.Bottom))
                    layout.Height = System.Math.Max(ClientSize.Height - padding * 2, content.Bottom + padding + footer.Height)
                    footer.Top = layout.Height - footer.Height
                Finally
                    layout.ResumeLayout()
                    arranging = False
                End Try
            End Sub
            AddHandler Resize, Sub(sender, e) arrange()
            AddHandler HandleCreated, Sub(sender, e) arrange()
            AddHandler FontChanged, Sub(sender, e) arrange()
            AddHandler VisibleChanged, Sub(sender, e) arrange()
            arrange()
            ApplyWelcomeTheme(page)
            AddHandler page.VisibleChanged, Sub(sender, e) ApplyWelcomeTheme(page)
            Dim themeChanged As Microsoft.Win32.UserPreferenceChangedEventHandler = Sub(sender, e)
                                                                                        If page.IsHandleCreated AndAlso Not page.IsDisposed Then page.BeginInvoke(New System.Action(Sub() ApplyWelcomeTheme(page)))
                                                                                    End Sub
            AddHandler Microsoft.Win32.SystemEvents.UserPreferenceChanged, themeChanged
            AddHandler page.Disposed, Sub(sender, e) RemoveHandler Microsoft.Win32.SystemEvents.UserPreferenceChanged, themeChanged
        End Sub
        Private Sub AddWelcomeResource(parent As Control, title As String, description As String, url As String)
            Dim card = New WelcomePanel() With {.ColumnCount = 1, .RowCount = 4, .Padding = New Padding(20)}
            card.RowStyles.Add(New RowStyle(SizeType.Absolute, 36))
            card.RowStyles.Add(New RowStyle(SizeType.Absolute, 60))
            card.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            card.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            AddWelcomeText(card, If(title.Contains("Demos"), "▷", If(title.Contains("Docs"), "≡", If(title.Contains("AI"), "✧", "▦"))), 20)
            AddWelcomeText(card, title, 14)
            AddWelcomeText(card, description, 12)
            AddWelcomeLink(card, title & " →", url)
            parent.Controls.Add(card)
        End Sub

        Private NotInheritable Class WelcomePanel
            Inherits TableLayoutPanel
            Public Sub New()
                DoubleBuffered = True
                ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
            End Sub
            Protected Overrides Sub OnPaint(e As PaintEventArgs)
                MyBase.OnPaint(e)
                If Width < 2 OrElse Height < 2 Then Return
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                Using path = New System.Drawing.Drawing2D.GraphicsPath(), pen = New System.Drawing.Pen(System.Drawing.SystemColors.ControlDark)
                    Dim corner = System.Math.Min(24, System.Math.Min(Width - 1, Height - 1))
                    path.AddArc(0, 0, corner, corner, 180, 90)
                    path.AddArc(Width - corner - 1, 0, corner, corner, 270, 90)
                    path.AddArc(Width - corner - 1, Height - corner - 1, corner, corner, 0, 90)
                    path.AddArc(0, Height - corner - 1, corner, corner, 90, 90)
                    path.CloseFigure()
                    e.Graphics.DrawPath(pen, path)
                End Using
            End Sub
        End Class
        Private Sub ApplyWelcomeTheme(root As Control)
            Dim dark = False
            Try
                Using key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize")
                    dark = Not SystemInformation.HighContrast AndAlso key IsNot Nothing AndAlso CInt(key.GetValue("AppsUseLightTheme", 1)) = 0
                End Using
            Catch ex As System.Exception
            End Try
            ApplyWelcomeColors(root, dark)
        End Sub
        Private Sub ApplyWelcomeColors(root As Control, dark As Boolean)
            root.BackColor = If(dark, System.Drawing.Color.FromArgb(31, 31, 31), If(TypeOf root Is WelcomePanel, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.Control))
            root.ForeColor = If(dark, System.Drawing.Color.WhiteSmoke, System.Drawing.SystemColors.WindowText)
            Dim link = TryCast(root, LinkLabel)
            If link IsNot Nothing Then
                link.LinkColor = If(dark, System.Drawing.Color.FromArgb(172, 153, 234), System.Drawing.SystemColors.HotTrack)
                link.ActiveLinkColor = link.ForeColor
                link.VisitedLinkColor = link.LinkColor
            End If
            For Each child As Control In root.Controls
                ApplyWelcomeColors(child, dark)
            Next
        End Sub
        Private Sub AddWelcomeText(parent As Control, text As String, size As Single)
            parent.Controls.Add(New Label() With {.Text = text, .AutoSize = True, .Font = New System.Drawing.Font(If(System.Drawing.SystemFonts.MessageBoxFont, System.Drawing.SystemFonts.DefaultFont).FontFamily, size, If(size >= 14, System.Drawing.FontStyle.Bold, System.Drawing.FontStyle.Regular)), .Margin = New Padding(0, 0, 0, 12)})
        End Sub
        Private Sub AddWelcomeLink(parent As Control, text As String, url As String)
            Dim link = New LinkLabel() With {.Text = text, .Tag = url, .AutoSize = True, .TabStop = True, .AccessibleName = text, .Font = New System.Drawing.Font(Font.FontFamily, 10), .AccessibleDescription = "Opens in your default browser", .Margin = New Padding(0, 12, 16, 12)}
            AddHandler link.LinkClicked, Sub(sender, e)
                                             Try
                                                 System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(url) With {.UseShellExecute = True})
                                             Catch ex As System.Exception
                                                 MessageBox.Show("This link could not be opened. Please try again.")
                                             End Try
                                         End Sub
            parent.Controls.Add(link)
        End Sub
    End Class
End Namespace


Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Syncfusion.DataSource
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.ListView

Namespace __ROOT_NAMESPACE__.NavigationDrawer
    Public Partial Class NavigationDrawerPage
        Inherits UserControl
        Private ReadOnly dataSet As DataSet = New DataSet()
        Private ReadOnly inboxPanel As Panel = New Panel()
        Private ReadOnly profilePanel As Panel = New Panel()
        Private ReadOnly messageList As SfListView = New SfListView()
        Private ReadOnly navigationDrawer As Tools.NavigationDrawer = New Tools.NavigationDrawer()
        Private ReadOnly pageTitle As Label = New Label()
        Private ReadOnly profile As TileControl = New TileControl()
        Private menuIcon As Image
        Private messageTable As DataTable
        Private hoveredMessage As Object
        Private closeImageRect As Rectangle

        Public Sub New()
            LoadMessages()
            InitializeDrawer()
            InitializeMessages()
            InitializeProfile()
            SetMessageTable("Inbox")
            messageList.SelectedIndex = 3
            navigationDrawer.DrawerHeight = navigationDrawer.DisplayRectangle.Height
            AddHandler SizeChanged, AddressOf HandleSizeChanged
            MyBase.Dock = DockStyle.Fill
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                dataSet.Dispose()
                menuIcon?.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub LoadMessages()
            Dim path = IO.Path.Combine(AppContext.BaseDirectory, "NavigationDrawer", "Resources", "data.xml")
            If Not File.Exists(path) Then
                Throw New FileNotFoundException("The navigation drawer sample data was not found.", path)
            End If

            dataSet.ReadXml(path)
            dataSet.DataSetName = "DataSet1"
        End Sub

        Private Sub InitializeDrawer()
            Dim iconPath = Path.Combine(AppContext.BaseDirectory, "NavigationDrawer", "Resources", "Icon_menu_Colorful.png")
            If Not File.Exists(iconPath) Then
                Throw New FileNotFoundException("The navigation drawer menu icon was not found.", iconPath)
            End If

            Using loadedIcon = Image.FromFile(iconPath)
                menuIcon = New Bitmap(loadedIcon)
            End Using

            navigationDrawer.BackColor = Color.White
            navigationDrawer.Dock = DockStyle.Fill
            navigationDrawer.DrawerWidth = 200
            navigationDrawer.Font = New Font("Arial Narrow", 12)
            navigationDrawer.Location = New Point(0, 41)
            navigationDrawer.Margin = New Padding(4)
            navigationDrawer.Name = "navigationDrawer1"
            navigationDrawer.Size = New Size(1288, 832)
            navigationDrawer.Style = NavigationDrawerStyle.Office2016Colorful
            navigationDrawer.TabIndex = 0
            navigationDrawer.Text = "navigationDrawer1"
            navigationDrawer.ThemeName = "Office2016Colorful"
            navigationDrawer.AnimationDuration = 10
            navigationDrawer.Transition = Tools.Transition.SlideOnTop
            navigationDrawer.Position = SlidePosition.Left
            navigationDrawer.DrawerPanelContainer.BorderStyle = BorderStyle.None
            navigationDrawer.TouchThreshold = 500

            Dim header = New DrawerHeader With {
    .BackColor = Color.FromArgb(1, 115, 199),
    .HeaderText = "Outlook",
    .Location = Point.Empty,
    .Margin = Padding.Empty,
    .Name = "Outlook",
    .Size = New Size(267, 148),
    .TabIndex = 0,
    .Text = "Outlook",
    .TextColor = Color.White,
    .TextAlign = TextAlignment.Center
}
            navigationDrawer.Items.Add(header)
            AddDrawerItem("Inbox", New EventHandler(AddressOf OnInboxClick))
            AddDrawerItem("Drafts", New EventHandler(AddressOf OnDraftsClick))
            AddDrawerItem("Sent", New EventHandler(AddressOf OnSentClick))
            AddDrawerItem("Outbox", New EventHandler(AddressOf OnOutboxClick))
            AddDrawerItem("Profile", New EventHandler(AddressOf OnProfileClick))

            inboxPanel.Dock = DockStyle.Fill
            inboxPanel.Controls.Add(messageList)
            profilePanel.Dock = DockStyle.Fill
            profilePanel.BackColor = Color.Red
            navigationDrawer.ContentViewContainer.Controls.Add(inboxPanel)
            navigationDrawer.ContentViewContainer.Controls.Add(profilePanel)

            Dim headerPanel = New Panel With {
    .Dock = DockStyle.Top,
    .Height = 41,
    .BackColor = Color.White,
    .Location = Point.Empty,
    .Margin = New Padding(4),
    .Name = "gradientPanel1",
    .Size = New Size(1288, 41)
}
            Dim menuButton = New PictureBox With {
    .Image = menuIcon,
    .Location = New Point(4, 4),
    .Name = "pictureBox1",
    .Size = New Size(32, 30),
    .SizeMode = PictureBoxSizeMode.StretchImage,
    .TabStop = False,
    .Cursor = Cursors.Hand
}
            AddHandler menuButton.Click, AddressOf OnMenuButtonClick
            pageTitle.Location = New Point(44, 9)
            pageTitle.AutoSize = True
            pageTitle.Text = "Inbox"
            pageTitle.TextAlign = ContentAlignment.MiddleLeft
            pageTitle.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
            headerPanel.Controls.Add(pageTitle)
            headerPanel.Controls.Add(menuButton)

            Dim drawerHost = New Panel With {
    .Dock = DockStyle.Fill,
    .Padding = New Padding(0, 0, 11, 0),
    .Name = "panel2"
}
            drawerHost.Controls.Add(navigationDrawer)
            drawerHost.Controls.Add(headerPanel)
            Controls.Add(drawerHost)
            SkinManager.SetVisualStyle(Me, "Office2019Colorful")
            headerPanel.BorderStyle = BorderStyle.None
            Padding = New Padding(10)
            AutoScaleDimensions = New SizeF(8F, 16F)
            AutoScaleMode = AutoScaleMode.Font
            Name = "Form1"
            Size = New Size(1319, 893)
            Text = "Navigation Drawer"
        End Sub

        Private Sub AddDrawerItem(text As String, onClick As EventHandler)
            Dim item = New DrawerMenuItem With {
    .BackColor = Color.White,
    .DefaultColor = Color.FromArgb(238, 238, 238),
    .Font = New Font("Segoe UI", 12),
    .HoverColor = Color.FromArgb(230, 241, 250),
    .ItemText = text,
    .Location = New Point(2, 148 + (navigationDrawer.Items.Count - 1) * 62),
    .Margin = Padding.Empty,
    .MinimumSize = New Size(267, 62),
    .Name = "drawerMenuItem" & navigationDrawer.Items.Count.ToString(),
    .SelectionColor = Color.FromArgb(224, 224, 224),
    .Size = New Size(267, 62),
    .TabIndex = navigationDrawer.Items.Count - 1,
    .Text = text,
    .TextColor = Color.FromArgb(42, 42, 42),
    .TextAlign = TextAlignment.Center
}
            AddHandler item.Click, onClick
            navigationDrawer.Items.Add(item)
        End Sub

        Private Sub InitializeMessages()
            messageList.AccessibleName = "ScrollControl"
            messageList.VerticalScrollBarVisible = False
            messageList.SelectionMode = SelectionMode.One
            messageList.ItemHeight = 70
            messageList.Location = New Point(173, 225)
            messageList.Name = "listView1"
            messageList.Size = New Size(161, 119)
            messageList.TabIndex = 1
            messageList.Padding = New Padding(11, 0, 0, 0)
            AddHandler messageList.DrawItem, AddressOf OnDrawMessage
            AddHandler messageList.MouseUp, AddressOf OnMessageMouseUp
            messageList.HotTracking = True
            messageList.Dock = DockStyle.Fill
            messageList.Style.BorderColor = Color.FromArgb(210, 210, 210)
            messageList.BackColor = Color.White
            messageList.Style.BorderSides = Border3DSide.Bottom Or Border3DSide.Left Or Border3DSide.Right
        End Sub

        Private Sub InitializeProfile()
            profile.HeaderText = "Anderson"
            profile.PostionText = "Senior Executive"
            profile.OrganizatonText = "Custom Service"
            profile.DOBText = "26/11/1973"
            profile.LocationText = "NewYork"
            profile.Height = 300
            profile.Dock = DockStyle.Top
            profilePanel.Controls.Add(profile)
            profilePanel.AutoScroll = True
            profilePanel.Visible = False
        End Sub

        Private Sub SetMessageTable(tableName As String)
            messageTable = dataSet.Tables(tableName)
            If messageTable Is Nothing Then
                Throw New InvalidDataException("The navigation drawer sample data is missing the '" & tableName & "' table.")
            End If

            messageList.DataSource = messageTable
            messageList.DisplayMember = "Today"

            messageList.View.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping

            If messageList.View.GroupDescriptors.Count = 0 Then
                messageList.View.GroupDescriptors.Add(
                    New GroupDescriptor With {
                        .PropertyName = "Today"
                    })
            End If

            messageList.Refresh()
            pageTitle.Text = tableName
            profilePanel.Visible = False
            inboxPanel.Visible = True
        End Sub

        Private Sub OnDrawMessage(sender As Object, e As Syncfusion.WinForms.ListView.Events.DrawItemEventArgs)
            Dim rowView = TryCast(e.ItemData, DataRowView)
            If e.ItemType <> Enums.ItemType.Record OrElse rowView Is Nothing Then
                Return
            End If

            Dim rowCount = messageTable.Rows.Count + messageList.View.Groups.Count
            If e.ItemIndex >= rowCount Then
                Return
            End If

            Dim row = rowView.Row
            Dim bounds = e.Bounds
            Dim selected = e.ItemIndex = messageList.SelectedIndex
            Dim hover = bounds.Contains(messageList.PointToClient(Cursor.Position))
            If hover Then
                hoveredMessage = e.ItemData
            End If

            Dim backgroundColor = If(selected, ColorTranslator.FromHtml("#c7e0f4"), If(hover, ColorTranslator.FromHtml("#deecf9"), Color.White))
            Using background = New SolidBrush(backgroundColor)
                Using format = New StringFormat With {
                        .Trimming = StringTrimming.EllipsisCharacter
                    }
                    e.Graphics.FillRectangle(background, New Rectangle(bounds.X, bounds.Y + 1, bounds.Width, Math.Max(0, bounds.Height - 2)))
                    If hover Then
                        closeImageRect = New Rectangle(bounds.X + bounds.Width - 25, bounds.Y + 20, 20, 20)
                    End If

                    Using primaryFont = New Font("Segoe UI", 11.5F)
                        Using secondaryFont = New Font("Segoe UI", 9F)
                            Using detailFont = New Font("Segoe UI", 7.55F)
                                Using timeFont = New Font("Segoe UI", 8F)
                                    Using brush = New SolidBrush(MyBase.ForeColor)
                                        e.Graphics.DrawString(Convert.ToString(row("ContactName")), primaryFont, brush, New Rectangle(bounds.X + 2, bounds.Y + 1, bounds.Width - 110, 25), format)
                                        e.Graphics.DrawString(Convert.ToString(row("Message")), secondaryFont, brush, New Rectangle(bounds.X + 2, bounds.Y + 26, bounds.Width - 110, 20), format)
                                        e.Graphics.DrawString(Convert.ToString(row("To")), detailFont, brush, New Rectangle(bounds.X + 2, bounds.Y + 46, bounds.Width - 110, 15), format)
                                        Dim time = Convert.ToString(row("Time"))
                                        If time.Length > 0 AndAlso Char.IsNumber(time, 0) Then
                                            time = "    " & time
                                        End If

                                        e.Graphics.DrawString(time, timeFont, brush, New Rectangle(bounds.Right - 100, bounds.Y + 26, 100, 20), format)
                                    End Using
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using

            e.Handled = True
        End Sub

        Private Sub OnMessageMouseUp(sender As Object, e As MouseEventArgs)
            If closeImageRect.Contains(e.Location) AndAlso hoveredMessage IsNot Nothing Then
                If messageList.SelectedItems.Contains(hoveredMessage) Then
                    messageList.SelectedItems.Remove(hoveredMessage)
                End If

                If messageList.View IsNot Nothing AndAlso messageList.View.Groups IsNot Nothing Then
                    messageList.View.Groups.RemoveItemInGroup(hoveredMessage)
                End If

                hoveredMessage = Nothing
            End If
        End Sub

        Private Sub OnMenuButtonClick(sender As Object, e As EventArgs)
            navigationDrawer.ToggleDrawer()
        End Sub

        Private Sub OnInboxClick(sender As Object, e As EventArgs)
            ShowMessagesAndCloseDrawer("Inbox")
        End Sub

        Private Sub OnDraftsClick(sender As Object, e As EventArgs)
            ShowMessagesAndCloseDrawer("Drafts")
        End Sub

        Private Sub OnSentClick(sender As Object, e As EventArgs)
            ShowMessagesAndCloseDrawer("Sent")
        End Sub

        Private Sub OnOutboxClick(sender As Object, e As EventArgs)
            ShowMessagesAndCloseDrawer("Outbox")
        End Sub

        Private Sub OnProfileClick(sender As Object, e As EventArgs)
            LockWindowUpdate(navigationDrawer.ContentViewContainer.Handle)
            Try
                pageTitle.Text = "Profile"
                inboxPanel.Visible = False
                profilePanel.Visible = True
                navigationDrawer.ToggleDrawer()
            Finally
                LockWindowUpdate(IntPtr.Zero)
            End Try
        End Sub

        Private Sub HandleSizeChanged(sender As Object, e As EventArgs)
            navigationDrawer.DrawerHeight = navigationDrawer.DisplayRectangle.Height
        End Sub

        Private Sub ShowMessagesAndCloseDrawer(tableName As String)
            LockWindowUpdate(navigationDrawer.ContentViewContainer.Handle)
            Try
                SetMessageTable(tableName)
                navigationDrawer.ToggleDrawer()
            Finally
                LockWindowUpdate(IntPtr.Zero)
            End Try
        End Sub

        <DllImport("user32.dll")>
        Private Shared Function LockWindowUpdate(hWndLock As IntPtr) As Boolean
        End Function

    End Class
End Namespace

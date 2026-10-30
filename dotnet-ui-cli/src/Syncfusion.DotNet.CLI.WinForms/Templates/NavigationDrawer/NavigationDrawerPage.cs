#nullable disable
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Syncfusion.DataSource;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.ListView;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        private readonly DataSet dataSet = new DataSet();
        private readonly Panel inboxPanel = new Panel();
        private readonly Panel profilePanel = new Panel();
        private readonly SfListView messageList = new SfListView();
        private readonly Syncfusion.Windows.Forms.Tools.NavigationDrawer navigationDrawer = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
        private readonly Label pageTitle = new Label();
        private readonly TileControl profile = new TileControl();
        private Image menuIcon;
        private DataTable messageTable;
        private object hoveredMessage;
        private Rectangle closeImageRect;

        public __VIEW_NAME__()
        {
            LoadMessages();
            InitializeDrawer();
            InitializeMessages();
            InitializeProfile();
            SetMessageTable("Inbox");
            messageList.SelectedIndex = 3;
            navigationDrawer.DrawerHeight = navigationDrawer.DisplayRectangle.Height;
            SizeChanged += HandleSizeChanged;
            Dock = DockStyle.Fill;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dataSet.Dispose();
                menuIcon?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void LoadMessages()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "__CONTROL_NAME__", "Resources", "data.xml");
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The navigation drawer sample data was not found.", path);
            }

            dataSet.ReadXml(path);
            dataSet.DataSetName = "DataSet1";
        }

        private void InitializeDrawer()
        {
            var iconPath = Path.Combine(AppContext.BaseDirectory, "__CONTROL_NAME__", "Resources", "Icon_menu_Colorful.png");
            if (!File.Exists(iconPath))
            {
                throw new FileNotFoundException("The navigation drawer menu icon was not found.", iconPath);
            }

            using (var loadedIcon = Image.FromFile(iconPath))
            {
                menuIcon = new Bitmap(loadedIcon);
            }

            navigationDrawer.BackColor = Color.White;
            navigationDrawer.Dock = DockStyle.Fill;
            navigationDrawer.DrawerWidth = 200;
            navigationDrawer.Font = new Font("Arial Narrow", 12);
            navigationDrawer.Location = new Point(0, 41);
            navigationDrawer.Margin = new Padding(4);
            navigationDrawer.Name = "navigationDrawer1";
            navigationDrawer.Size = new Size(1288, 832);
            navigationDrawer.Style = NavigationDrawerStyle.Office2016Colorful;
            navigationDrawer.TabIndex = 0;
            navigationDrawer.Text = "navigationDrawer1";
            navigationDrawer.ThemeName = "Office2016Colorful";
            navigationDrawer.AnimationDuration = 10;
            navigationDrawer.Transition = Syncfusion.Windows.Forms.Tools.Transition.SlideOnTop;
            navigationDrawer.Position = SlidePosition.Left;
            navigationDrawer.DrawerPanelContainer.BorderStyle = BorderStyle.None;
            navigationDrawer.TouchThreshold = 500;

            var header = new DrawerHeader
            {
                BackColor = Color.FromArgb(1, 115, 199),
                HeaderText = "Outlook",
                Location = Point.Empty,
                Margin = Padding.Empty,
                Name = "Outlook",
                Size = new Size(267, 148),
                TabIndex = 0,
                Text = "Outlook",
                TextColor = Color.White,
                TextAlign = TextAlignment.Center,
            };
            navigationDrawer.Items.Add(header);
            AddDrawerItem("Inbox", OnInboxClick);
            AddDrawerItem("Drafts", OnDraftsClick);
            AddDrawerItem("Sent", OnSentClick);
            AddDrawerItem("Outbox", OnOutboxClick);
            AddDrawerItem("Profile", OnProfileClick);

            inboxPanel.Dock = DockStyle.Fill;
            inboxPanel.Controls.Add(messageList);
            profilePanel.Dock = DockStyle.Fill;
            profilePanel.BackColor = Color.Red;
            navigationDrawer.ContentViewContainer.Controls.Add(inboxPanel);
            navigationDrawer.ContentViewContainer.Controls.Add(profilePanel);

            var headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 41,
                BackColor = Color.White,
                Location = Point.Empty,
                Margin = new Padding(4),
                Name = "gradientPanel1",
                Size = new Size(1288, 41),
            };
            var menuButton = new PictureBox
            {
                Image = menuIcon,
                Location = new Point(4, 4),
                Name = "pictureBox1",
                Size = new Size(32, 30),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabStop = false,
                Cursor = Cursors.Hand,
            };
            menuButton.Click += OnMenuButtonClick;
            pageTitle.Location = new Point(44, 9);
            pageTitle.AutoSize = true;
            pageTitle.Text = "Inbox";
            pageTitle.TextAlign = ContentAlignment.MiddleLeft;
            pageTitle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            headerPanel.Controls.Add(pageTitle);
            headerPanel.Controls.Add(menuButton);

            var drawerHost = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(0, 0, 11, 0),
                Name = "panel2",
            };
            drawerHost.Controls.Add(navigationDrawer);
            drawerHost.Controls.Add(headerPanel);
            Controls.Add(drawerHost);
            SkinManager.SetVisualStyle(this, "Office2019Colorful");
            headerPanel.BorderStyle = BorderStyle.None;
            Padding = new Padding(10);
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "Form1";
            Size = new Size(1319, 893);
            Text = "Navigation Drawer";
        }

        private void AddDrawerItem(string text, EventHandler onClick)
        {
            var item = new DrawerMenuItem
            {
                BackColor = Color.White,
                DefaultColor = Color.FromArgb(238, 238, 238),
                Font = new Font("Segoe UI", 12),
                HoverColor = Color.FromArgb(230, 241, 250),
                ItemText = text,
                Location = new Point(2, 148 + (navigationDrawer.Items.Count - 1) * 62),
                Margin = Padding.Empty,
                MinimumSize = new Size(267, 62),
                Name = "drawerMenuItem" + navigationDrawer.Items.Count,
                SelectionColor = Color.FromArgb(224, 224, 224),
                Size = new Size(267, 62),
                TabIndex = navigationDrawer.Items.Count - 1,
                Text = text,
                TextColor = Color.FromArgb(42, 42, 42),
                TextAlign = TextAlignment.Center,
            };
            item.Click += onClick;
            navigationDrawer.Items.Add(item);
        }

        private void InitializeMessages()
        {
            messageList.AccessibleName = "ScrollControl";
            messageList.VerticalScrollBarVisible = false;
            messageList.SelectionMode = SelectionMode.One;
            messageList.ItemHeight = 70;
            messageList.Location = new Point(173, 225);
            messageList.Name = "listView1";
            messageList.Size = new Size(161, 119);
            messageList.TabIndex = 1;
            messageList.Padding = new Padding(11, 0, 0, 0);
            messageList.DrawItem += OnDrawMessage;
            messageList.MouseUp += OnMessageMouseUp;
            messageList.HotTracking = true;
            messageList.Dock = DockStyle.Fill;
            messageList.Style.BorderColor = Color.FromArgb(210, 210, 210);
            messageList.BackColor = Color.White;
            messageList.Style.BorderSides = Border3DSide.Bottom | Border3DSide.Left | Border3DSide.Right;
        }

        private void InitializeProfile()
        {
            profile.HeaderText = "Anderson";
            profile.PostionText = "Senior Executive";
            profile.OrganizatonText = "Custom Service";
            profile.DOBText = "26/11/1973";
            profile.LocationText = "NewYork";
            profile.Height = 300;
            profile.Dock = DockStyle.Top;
            profilePanel.Controls.Add(profile);
            profilePanel.AutoScroll = true;
            profilePanel.Visible = false;
        }

        private void SetMessageTable(string tableName)
        {
            messageTable = dataSet.Tables[tableName];
            if (messageTable == null)
            {
                throw new InvalidDataException("The navigation drawer sample data is missing the '" + tableName + "' table.");
            }

            messageList.DataSource = messageTable;
            messageList.DisplayMember = "Today";

            messageList.View.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;

            if (messageList.View.GroupDescriptors.Count == 0)
            {
                messageList.View.GroupDescriptors.Add(
                    new GroupDescriptor
                    {
                        PropertyName = "Today",
                    });
            }

            messageList.Refresh();
            pageTitle.Text = tableName;
            profilePanel.Visible = false;
            inboxPanel.Visible = true;
        }

        private void OnDrawMessage(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            if (e.ItemType != Syncfusion.WinForms.ListView.Enums.ItemType.Record ||
                !(e.ItemData is DataRowView rowView))
            {
                return;
            }

            var rowCount = messageTable.Rows.Count + messageList.View.Groups.Count;
            if (e.ItemIndex >= rowCount)
            {
                return;
            }

            var row = rowView.Row;
            var bounds = e.Bounds;
            var selected = e.ItemIndex == messageList.SelectedIndex;
            var hover = bounds.Contains(messageList.PointToClient(Cursor.Position));
            if (hover)
            {
                hoveredMessage = e.ItemData;
            }

            var backgroundColor = selected
                ? ColorTranslator.FromHtml("#c7e0f4")
                : hover ? ColorTranslator.FromHtml("#deecf9") : Color.White;
            using (var background = new SolidBrush(backgroundColor))
            using (var format = new StringFormat { Trimming = StringTrimming.EllipsisCharacter })
            {
                e.Graphics.FillRectangle(background, new Rectangle(bounds.X, bounds.Y + 1, bounds.Width, Math.Max(0, bounds.Height - 2)));
                if (hover)
                {
                    closeImageRect = new Rectangle(bounds.X + bounds.Width - 25, bounds.Y + 20, 20, 20);
                }

                using (var primaryFont = new Font("Segoe UI", 11.5f))
                using (var secondaryFont = new Font("Segoe UI", 9f))
                using (var detailFont = new Font("Segoe UI", 7.55f))
                using (var timeFont = new Font("Segoe UI", 8f))
                using (var brush = new SolidBrush(ForeColor))
                {
                    e.Graphics.DrawString(Convert.ToString(row["ContactName"]), primaryFont, brush,
                        new Rectangle(bounds.X + 2, bounds.Y + 1, bounds.Width - 110, 25), format);
                    e.Graphics.DrawString(Convert.ToString(row["Message"]), secondaryFont, brush,
                        new Rectangle(bounds.X + 2, bounds.Y + 26, bounds.Width - 110, 20), format);
                    e.Graphics.DrawString(Convert.ToString(row["To"]), detailFont, brush,
                        new Rectangle(bounds.X + 2, bounds.Y + 46, bounds.Width - 110, 15), format);
                    var time = Convert.ToString(row["Time"]);
                    if (time.Length > 0 && char.IsNumber(time, 0))
                    {
                        time = "    " + time;
                    }

                    e.Graphics.DrawString(time, timeFont, brush,
                        new Rectangle(bounds.Right - 100, bounds.Y + 26, 100, 20), format);
                }
            }

            e.Handled = true;
        }

        private void OnMessageMouseUp(object sender, MouseEventArgs e)
        {
            if (closeImageRect.Contains(e.Location) && hoveredMessage != null)
            {
                if (messageList.SelectedItems.Contains(hoveredMessage))
                {
                    messageList.SelectedItems.Remove(hoveredMessage);
                }

                if (messageList.View != null && messageList.View.Groups != null)
                {
                    messageList.View.Groups.RemoveItemInGroup(hoveredMessage);
                }

                hoveredMessage = null;
            }
        }

        private void OnMenuButtonClick(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void OnInboxClick(object sender, EventArgs e)
        {
            ShowMessagesAndCloseDrawer("Inbox");
        }

        private void OnDraftsClick(object sender, EventArgs e)
        {
            ShowMessagesAndCloseDrawer("Drafts");
        }

        private void OnSentClick(object sender, EventArgs e)
        {
            ShowMessagesAndCloseDrawer("Sent");
        }

        private void OnOutboxClick(object sender, EventArgs e)
        {
            ShowMessagesAndCloseDrawer("Outbox");
        }

        private void OnProfileClick(object sender, EventArgs e)
        {
            LockWindowUpdate(navigationDrawer.ContentViewContainer.Handle);
            try
            {
                pageTitle.Text = "Profile";
                inboxPanel.Visible = false;
                profilePanel.Visible = true;
                navigationDrawer.ToggleDrawer();
            }
            finally
            {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        private void HandleSizeChanged(object sender, EventArgs e)
        {
            navigationDrawer.DrawerHeight = navigationDrawer.DisplayRectangle.Height;
        }

        private void ShowMessagesAndCloseDrawer(string tableName)
        {
            LockWindowUpdate(navigationDrawer.ContentViewContainer.Handle);
            try
            {
                SetMessageTable(tableName);
                navigationDrawer.ToggleDrawer();
            }
            finally
            {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool LockWindowUpdate(IntPtr hWndLock);
    }
}

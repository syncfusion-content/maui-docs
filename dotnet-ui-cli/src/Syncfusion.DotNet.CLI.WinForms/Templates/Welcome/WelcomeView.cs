using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
namespace @__ROOT_NAMESPACE__.Welcome
{
    public class WelcomeView : UserControl
    {
        public WelcomeView(Syncfusion.Windows.Forms.Tools.TabControlAdv tabs)
        {
            AddWelcome(tabs);
        }
        private static int FindSample(Syncfusion.Windows.Forms.Tools.TabControlAdv tabs, string id)
        {
            for (var index = 0; index < tabs.TabPages.Count; index++)
                if ((tabs.TabPages[index].Tag as string) == id) return index;
            return 0;
        }

        private void AddWelcome(Syncfusion.Windows.Forms.Tools.TabControlAdv tabs)
        {
            var page = this;
            AutoScroll = true;
            AutoScaleMode = AutoScaleMode.Font;
            Font = System.Drawing.SystemFonts.MessageBoxFont;
            var layout = new Panel();
            var content = new FlowLayoutPanel { AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, FlowDirection = FlowDirection.TopDown, WrapContents = false, Margin = Padding.Empty };
            AddWelcomeText(content, "Welcome to Your New WinForms App", 28);
            AddWelcomeText(content, "Your application is running successfully.", 12);
            var sampleBox = new WelcomePanel { ColumnCount = 1, Padding = new Padding(24), Margin = new Padding(0, 24, 0, 24) };
            AddWelcomeText(sampleBox, "Your control samples", 18);
            __SAMPLE_HINT__
            var sampleLinks = new FlowLayoutPanel { AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, WrapContents = true, Margin = Padding.Empty };
            __SAMPLES__
            sampleBox.Controls.Add(sampleLinks);
            __EMPTY_STATE__
            content.Controls.Add(sampleBox);
            AddWelcomeText(content, "Build something great", 18);
            var resourceCards = new FlowLayoutPanel { FlowDirection = FlowDirection.LeftToRight, WrapContents = true, Margin = Padding.Empty };
            __RESOURCES__
            content.Controls.Add(resourceCards);
            var footer = new Panel();
            var copyright = new Label { Text = "__COPYRIGHT__", AutoSize = true, Margin = Padding.Empty };
            var links = new FlowLayoutPanel { FlowDirection = FlowDirection.LeftToRight, WrapContents = true, Margin = Padding.Empty };
            __FOOTER_LINKS__
            footer.Controls.Add(copyright);
            footer.Controls.Add(links);
            layout.Controls.Add(content);
            layout.Controls.Add(footer);
            Controls.Add(layout);
            var arranging = false;
            System.Action arrange = () =>
            {
                if (arranging || ClientSize.Width < 1) return;
                arranging = true;
                layout.SuspendLayout();
                try
                {
                    var unit = Font.Height / 15f;
                    var padding = (int)System.Math.Ceiling(24 * unit);
                    var gap = (int)System.Math.Ceiling(16 * unit);
                    var width = System.Math.Max(1, System.Math.Min((int)(1160 * unit), ClientSize.Width - padding * 2 - SystemInformation.VerticalScrollBarWidth));
                    layout.Width = width;
                    layout.Left = System.Math.Max(padding, (ClientSize.Width - width) / 2);
                    layout.Top = padding;
                    content.Width = width;
                    foreach (Control child in content.Controls)
                    {
                        child.Width = width;
                        child.MaximumSize = new System.Drawing.Size(width, 0);
                    }
                    sampleBox.Width = width;
                    sampleLinks.MaximumSize = new System.Drawing.Size(System.Math.Max(1, width - sampleBox.Padding.Horizontal), 0);
                    foreach (Control child in sampleBox.Controls)
                        child.MaximumSize = new System.Drawing.Size(System.Math.Max(1, width - sampleBox.Padding.Horizontal), 0);
                    sampleBox.Height = sampleBox.GetPreferredSize(new System.Drawing.Size(width, 0)).Height;
                    var columns = width >= 1000 * unit ? 4 : width >= 600 * unit ? 2 : 1;
                    var cardWidth = System.Math.Max(1, (width - (columns - 1) * gap) / columns);
                    var rowHeights = new int[4];
                    foreach (Control card in resourceCards.Controls)
                    {
                        var innerWidth = System.Math.Max(1, cardWidth - card.Padding.Horizontal);
                        for (var row = 0; row < card.Controls.Count; row++)
                        {
                            var item = card.Controls[row];
                            item.MaximumSize = new System.Drawing.Size(innerWidth, 0);
                            rowHeights[row] = System.Math.Max(rowHeights[row], item.GetPreferredSize(new System.Drawing.Size(innerWidth, 0)).Height + item.Margin.Vertical);
                        }
                    }
                    var cardHeight = 40 + rowHeights[0] + rowHeights[1] + rowHeights[2] + rowHeights[3];
                    cardHeight = System.Math.Max((int)(260 * unit), cardHeight);
                    foreach (TableLayoutPanel card in resourceCards.Controls)
                    {
                        card.RowStyles[0].Height = rowHeights[0];
                        card.RowStyles[1].Height = rowHeights[1];
                        card.RowStyles[3].SizeType = SizeType.Absolute;
                        card.RowStyles[3].Height = rowHeights[3];
                    }
                    for (var index = 0; index < resourceCards.Controls.Count; index++)
                    {
                        var card = resourceCards.Controls[index];
                        card.Size = new System.Drawing.Size(cardWidth, cardHeight);
                        card.Margin = new Padding(0, 0, index % columns == columns - 1 ? 0 : gap, gap);
                    }
                    resourceCards.Height = ((resourceCards.Controls.Count + columns - 1) / columns) * (cardHeight + gap);
                    content.PerformLayout();
                    content.Height = content.PreferredSize.Height;
                    var linkWidth = 0;
                    foreach (Control link in links.Controls) linkWidth += link.PreferredSize.Width + link.Margin.Horizontal;
                    var stacked = width < copyright.PreferredSize.Width + linkWidth + gap;
                    links.Width = System.Math.Min(width, linkWidth);
                    links.Height = links.GetPreferredSize(new System.Drawing.Size(links.Width, 0)).Height;
                    copyright.MaximumSize = new System.Drawing.Size(stacked ? width : System.Math.Max(1, width - linkWidth - gap), 0);
                    copyright.Location = new System.Drawing.Point(0, stacked ? 0 : System.Math.Max(0, (links.Height - copyright.Height) / 2));
                    links.Location = new System.Drawing.Point(stacked ? 0 : width - links.Width, stacked ? copyright.Height + gap : 0);
                    footer.Size = new System.Drawing.Size(width, System.Math.Max(copyright.Height, links.Bottom));
                    layout.Height = System.Math.Max(ClientSize.Height - padding * 2, content.Bottom + padding + footer.Height);
                    footer.Top = layout.Height - footer.Height;
                }
                finally { layout.ResumeLayout(); arranging = false; }
            };
            Resize += (sender, e) => arrange();
            HandleCreated += (sender, e) => arrange();
            FontChanged += (sender, e) => arrange();
            VisibleChanged += (sender, e) => arrange();
            arrange();
            ApplyWelcomeTheme(page);
            page.VisibleChanged += (sender, e) => ApplyWelcomeTheme(page);
            Microsoft.Win32.UserPreferenceChangedEventHandler themeChanged = (sender, e) =>
            {
                if (page.IsHandleCreated && !page.IsDisposed) page.BeginInvoke(new System.Action(() => ApplyWelcomeTheme(page)));
            };
            Microsoft.Win32.SystemEvents.UserPreferenceChanged += themeChanged;
            page.Disposed += (sender, e) => Microsoft.Win32.SystemEvents.UserPreferenceChanged -= themeChanged;
        }
        private void AddWelcomeResource(Control parent, string title, string description, string url)
        {
            var card = new WelcomePanel { ColumnCount = 1, RowCount = 4, Padding = new Padding(20) };
            card.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
            card.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            card.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            card.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            AddWelcomeText(card, title.Contains("Demos") ? "▷" : title.Contains("Docs") ? "≡" : title.Contains("AI") ? "✧" : "▦", 20);
            AddWelcomeText(card, title, 14);
            AddWelcomeText(card, description, 12);
            AddWelcomeLink(card, title + " →", url);
            parent.Controls.Add(card);
        }

        private sealed class WelcomePanel : TableLayoutPanel
        {
            public WelcomePanel()
            {
                DoubleBuffered = true;
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                if (Width < 2 || Height < 2) return;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                using (var pen = new System.Drawing.Pen(System.Drawing.SystemColors.ControlDark))
                {
                    var corner = System.Math.Min(24, System.Math.Min(Width - 1, Height - 1));
                    path.AddArc(0, 0, corner, corner, 180, 90);
                    path.AddArc(Width - corner - 1, 0, corner, corner, 270, 90);
                    path.AddArc(Width - corner - 1, Height - corner - 1, corner, corner, 0, 90);
                    path.AddArc(0, Height - corner - 1, corner, corner, 90, 90);
                    path.CloseFigure();
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void ApplyWelcomeTheme(Control root)
        {
            var dark = false;
            try
            {
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                    dark = !SystemInformation.HighContrast && key != null && System.Convert.ToInt32(key.GetValue("AppsUseLightTheme", 1)) == 0;
            }
            catch (System.Exception) { }
            ApplyWelcomeColors(root, dark);
        }
        private void ApplyWelcomeColors(Control root, bool dark)
        {
            root.BackColor = dark ? System.Drawing.Color.FromArgb(31, 31, 31) : root is WelcomePanel ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.Control;
            root.ForeColor = dark ? System.Drawing.Color.WhiteSmoke : System.Drawing.SystemColors.WindowText;
            var link = root as LinkLabel;
            if (link != null)
            {
                link.LinkColor = dark ? System.Drawing.Color.FromArgb(172, 153, 234) : System.Drawing.SystemColors.HotTrack;
                link.ActiveLinkColor = link.ForeColor;
                link.VisitedLinkColor = link.LinkColor;
            }
            foreach (Control child in root.Controls) ApplyWelcomeColors(child, dark);
        }
        private void AddWelcomeText(Control parent, string text, float size)
        {
            parent.Controls.Add(new Label { Text = text, AutoSize = true, Font = new System.Drawing.Font(System.Drawing.SystemFonts.MessageBoxFont?.FontFamily ?? System.Drawing.FontFamily.GenericSansSerif, size, size >= 14 ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular), Margin = new Padding(0, 0, 0, 12) });
        }
        private void AddWelcomeLink(Control parent, string text, string url)
        {
            var link = new LinkLabel { Text = text, Tag = url, AutoSize = true, TabStop = true, AccessibleName = text, Font = new System.Drawing.Font(Font.FontFamily, 10), AccessibleDescription = "Opens in your default browser", Margin = new Padding(0, 12, 16, 12) };
            link.LinkClicked += (sender, e) =>
            {
                try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true }); }
                catch (System.Exception) { MessageBox.Show("This link could not be opened. Please try again."); }
            };
            parent.Controls.Add(link);
        }
    }
}

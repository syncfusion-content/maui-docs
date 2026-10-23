#nullable disable
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        private readonly IContainer components = new Container();
        private readonly Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControl;
        private readonly Label statusLabel = new Label();
        private readonly RichTextBox editor = new RichTextBox();
        private readonly Syncfusion.Windows.Forms.BackStageView backStageView;
        private readonly Syncfusion.Windows.Forms.BackStage backStage;

        public __VIEW_NAME__()
        {
            ribbonControl = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv
            {
                Dock = DockStyleEx.Top,
                AutoLayoutToolStrip = true,
                Name = "ribbonControl",
                MenuButtonText = "File",
                QuickPanelVisible = false,
                ShowMinimizeButton = false,
                ShowRibbonDisplayOptionButton = false,
                ShowQuickItemsDropDownButton = false,
                OfficeColorScheme = ToolStripEx.ColorScheme.Managed,
                RibbonStyle = RibbonStyle.Office2016,
                Office2016ColorScheme = Office2016ColorScheme.Colorful,
                Size = new Size(899, 236),
            };
            ((ISupportInitialize)ribbonControl).BeginInit();

            var homeTab = new ToolStripTabItem { Text = "Home", Name = "homeTab" };
            homeTab.Panel.Text = "Home";
            homeTab.Panel.Padding = new Padding(0, 1, 39, 0);
            homeTab.Panel.Controls.Add(CreateGroup("Clipboard", 0, "Paste", "Cut", "Copy"));
            homeTab.Panel.Controls.Add(CreateGroup("Font", 1, "Bold", "Italic", "Underline"));

            var insertTab = new ToolStripTabItem { Text = "Insert", Name = "insertTab" };
            insertTab.Panel.Text = "Insert";
            insertTab.Panel.Padding = new Padding(0, 1, 39, 0);
            insertTab.Panel.Controls.Add(CreateGroup("Pages", 0, "Blank Page"));

            ribbonControl.Header.AddMainItem(homeTab);
            ribbonControl.Header.AddMainItem(insertTab);
            ribbonControl.Controls.Add(homeTab.Panel);
            ribbonControl.Controls.Add(insertTab.Panel);
            ((ISupportInitialize)ribbonControl).EndInit();

            backStageView = new Syncfusion.Windows.Forms.BackStageView(components);
            backStage = new Syncfusion.Windows.Forms.BackStage
            {
                Name = "backStage",
                OfficeColorScheme = ToolStripEx.ColorScheme.Managed,
                ThemeName = "BackStage2016Renderer",
                Size = new Size(898, 498),
                Visible = false,
            };
            ((ISupportInitialize)backStage).BeginInit();
            var openButton = new Syncfusion.Windows.Forms.BackStageButton { Text = "Open" };
            var saveAsButton = new Syncfusion.Windows.Forms.BackStageButton { Text = "Save As" };
            var exitButton = new Syncfusion.Windows.Forms.BackStageButton { Text = "Exit" };
            exitButton.Click += (s, e) => FindForm()?.Close();
            backStage.Controls.Add(openButton);
            backStage.Controls.Add(saveAsButton);
            backStage.Controls.Add(exitButton);
            ((ISupportInitialize)backStage).EndInit();
            backStageView.BackStage = backStage;
            ribbonControl.BackStageView = backStageView;

            editor.Dock = DockStyle.Fill;
            editor.BorderStyle = BorderStyle.None;
            editor.Text = "Select text and use the Home tab to cut, copy, paste or format it.\nUse the Insert tab to add content.";

            statusLabel.Dock = DockStyle.Bottom;
            statusLabel.Height = 28;
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            statusLabel.Text = "Ready";

            Controls.Add(editor);
            Controls.Add(statusLabel);
            Controls.Add(ribbonControl);

            Syncfusion.Windows.Forms.SkinManager.SetVisualStyle(this, Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful);

            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Dock = DockStyle.Fill;
            Name = "RibbonPage";
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // BackStageView must be hosted by a Form.
            var form = FindForm();
            if (form != null && backStageView.HostForm == null)
            {
                backStageView.HostForm = form;
                form.Controls.Add(backStage);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private ToolStripEx CreateGroup(string title, int index, params string[] small)
        {
            var group = new ToolStripEx
            {
                Name = title + "Group",
                Text = title,
                Dock = DockStyle.None,
                ForeColor = Color.MidnightBlue,
                CollapsedDropDownButtonText = title,
                GripStyle = ToolStripGripStyle.Hidden,
                ImageScalingSize = new Size(20, 20),
                Office12Mode = false,
                ShowLauncher = false,
                Padding = new Padding(3, 0, 0, 0),
                Location = new Point(index * 250, 1),
                Size = new Size(250, 128),
            };

            foreach (var text in small)
            {
                var button = CreateButton(text);
                button.TextAlign = ContentAlignment.BottomCenter;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.ImageScaling = ToolStripItemImageScaling.None;
                group.Items.Add(button);
            }

            return group;
        }

        private ToolStripButton CreateButton(string text)
        {
            var button = new ToolStripButton(text) { Name = text.Replace(" ", string.Empty) + "Button", DisplayStyle = ToolStripItemDisplayStyle.Text };
            var icon = LoadIcon(text);
            if (icon != null)
            {
                button.Image = icon;
                button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }

            button.Click += OnCommandClick;
            return button;
        }

        private static Image LoadIcon(string command)
        {
            string file;
            switch (command)
            {
                case "Paste": file = "Paste32flat.png"; break;
                case "Cut": file = "Cut16flat.png"; break;
                case "Copy": file = "Copy16flat.png"; break;
                case "Bold": file = "Bold16flat.png"; break;
                case "Italic": file = "Italic16flat.png"; break;
                case "Underline": file = "Underline16flat.png"; break;
                case "Blank Page": file = "blank-1.png"; break;
                default: return null;
            }

            var path = System.IO.Path.Combine(AppContext.BaseDirectory, "__CONTROL_NAME__", "Resources", file);
            if (!System.IO.File.Exists(path))
            {
                return null;
            }

            using (var loaded = Image.FromFile(path))
            {
                return new Bitmap(loaded, new Size(16, 16));
            }
        }

        private void OnCommandClick(object sender, EventArgs e)
        {
            var command = ((ToolStripItem)sender).Text;
            switch (command)
            {
                case "Paste": editor.Paste(); break;
                case "Cut": editor.Cut(); break;
                case "Copy": editor.Copy(); break;
                case "Bold": ToggleStyle(FontStyle.Bold); break;
                case "Italic": ToggleStyle(FontStyle.Italic); break;
                case "Underline": ToggleStyle(FontStyle.Underline); break;
                case "Picture": editor.SelectedText = "[Picture]"; break;
                case "Shapes": editor.SelectedText = "[Shape]"; break;
                case "Chart": editor.SelectedText = "[Chart]"; break;
                case "Blank Page": editor.AppendText("\n\n"); break;
                case "Cover Page": editor.SelectedText = "[Cover Page]\n"; break;
                case "Page Break": editor.SelectedText = "\n--- page break ---\n"; break;
            }

            statusLabel.Text = command + " clicked";
        }

        private void ToggleStyle(FontStyle style)
        {
            var font = editor.SelectionFont ?? editor.Font;
            editor.SelectionFont = new Font(font, font.Style ^ style);
        }
    }
}

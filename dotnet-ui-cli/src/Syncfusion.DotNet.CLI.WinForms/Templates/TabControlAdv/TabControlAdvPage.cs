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
        private readonly Syncfusion.Windows.Forms.Tools.TabControlAdv tabControl;
        private int pageCount = 3;

        public __VIEW_NAME__()
        {
            tabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv
            {
                Dock = DockStyle.Fill,
                Name = "tabControl",
                ShowToolTips = true,
                TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful),
            };
            ((ISupportInitialize)tabControl).BeginInit();

            AddPage("Home", "Welcome to TabControlAdv.");
            AddPage("Products", "Each tab hosts its own content.");
            AddPage("Contact", "Use the button below to add or close tabs.");

            ((ISupportInitialize)tabControl).EndInit();

            var addButton = new Button { Text = "Add tab", Dock = DockStyle.Bottom, Height = 36 };
            addButton.Click += OnAddTabClick;

            Controls.Add(tabControl);
            Controls.Add(addButton);

            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Dock = DockStyle.Fill;
            Name = "TabControlAdvPage";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void AddPage(string title, string text)
        {
            var page = new TabPageAdv { Text = title, ShowCloseButton = true };
            page.Controls.Add(new Label { Text = text, Dock = DockStyle.Top, Height = 32, TextAlign = ContentAlignment.MiddleLeft });
            tabControl.TabPages.Add(page);
        }

        private void OnAddTabClick(object sender, EventArgs e)
        {
            pageCount++;
            AddPage("Tab " + pageCount, "New tab " + pageCount);
            tabControl.SelectedIndex = tabControl.TabCount - 1;
        }
    }
}

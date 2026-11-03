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
        private readonly Syncfusion.Windows.Forms.Tools.DockingManager dockingManager;
        private readonly Panel panel1 = CreatePanel("panel1");
        private readonly Panel panel2 = CreatePanel("panel2");
        private readonly Panel panel3 = CreatePanel("panel3");
        private readonly Panel panel4 = CreatePanel("panel4");
        private readonly Panel panel5 = CreatePanel("panel5");
        private readonly Panel panel6 = CreatePanel("panel6");

        public __VIEW_NAME__()
        {
            dockingManager = new Syncfusion.Windows.Forms.Tools.DockingManager(components)
            {
                AnimateAutoHiddenWindow = true,
                AutoHideEnabled = true,
                AutoHideTabForeColor = Color.Empty,
                CloseTabOnMiddleClick = false,
                DockTabAlignment = DockTabAlignmentStyle.Right,
                DragProviderStyle = DragProviderStyle.Office2016Colorful,
                HostControl = this,
                MetroButtonColor = Color.White,
                MetroColor = Color.FromArgb(17, 158, 218),
                MetroSplitterBackColor = Color.FromArgb(155, 159, 183),
                ReduceFlickeringInRtl = false,
            };
            dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Close, "CloseButton"));
            dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Pin, "PinButton"));
            dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Maximize, "MaximizeButton"));
            dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Restore, "RestoreButton"));
            dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(CaptionButtonType.Menu, "MenuButton"));

            ConfigureDockPanel(panel1);
            ConfigureDockPanel(panel2);
            ConfigureDockPanel(panel3);
            ConfigureDockPanel(panel4);
            ConfigureDockPanel(panel5);
            ConfigureDockPanel(panel6);

            Load += OnLoaded;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Dock = DockStyle.Fill;
            Name = "Form1";
            Size = new Size(1282, 450);
            Text = "Form1";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private static Panel CreatePanel(string name)
        {
            return new Panel
            {
                Location = new Point(1, 30),
                Name = name,
                Size = new Size(name == "panel4" ? 171 : 200, 419),
                TabIndex = name == "panel1" ? 0 :
                    name == "panel2" ? 2 :
                    name == "panel3" ? 4 :
                    name == "panel4" ? 6 :
                    name == "panel5" ? 12 : 23,
            };
        }

        private void ConfigureDockPanel(Panel panel)
        {
            dockingManager.SetDockLabel(panel, panel.Name);
            dockingManager.SetEnableDocking(panel, true);
            var captionButtons = new CaptionButtonsCollection();
            captionButtons.MergeWith(dockingManager.CaptionButtons, false);
            dockingManager.SetCustomCaptionButtons(panel, captionButtons);
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            dockingManager.DockControl(panel1, this, DockingStyle.Top, 100);
            dockingManager.DockControl(panel5, this, DockingStyle.Top, 200);
            dockingManager.DockControl(panel6, this, DockingStyle.Right, 300);
            dockingManager.DockControlInAutoHideMode(panel2, DockingStyle.Top, 100);
            dockingManager.SetOuterDockAbility(panel1, DockAbility.Top | DockAbility.Bottom);

            var bounds = Bounds;
            dockingManager.FloatControl(panel3, new Rectangle(bounds.Right - 300, bounds.Bottom - 300, 200, 200));
        }
    }
}

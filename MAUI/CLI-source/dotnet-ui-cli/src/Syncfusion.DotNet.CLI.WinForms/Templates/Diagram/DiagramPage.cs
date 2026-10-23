#nullable disable
using Rectangle = System.Drawing.Rectangle;
using FontStyle = System.Drawing.FontStyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        private readonly IContainer components = new Container();
        private readonly ColorDialog colorDialog;
        private readonly Image collapseImage;
        private readonly Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram;
        private readonly Image expandImage;
        private readonly GroupBarItem groupBarItem;
        private readonly OpenFileDialog openFileDialog;
        private readonly PaletteGroupBar paletteGroupBar;
        private readonly SaveFileDialog saveFileDialog;

        public __VIEW_NAME__()
        {
            colorDialog = new ColorDialog();
            groupBarItem = new GroupBarItem
            {
                BackColor = Color.FromArgb(191, 219, 254),
                Client = null,
                Text = "Flowchart Symbols",
            };
            openFileDialog = new OpenFileDialog { FileName = "openFileDialog1" };
            saveFileDialog = new SaveFileDialog();
            collapseImage = LoadResourceImage("CollapseImage.png");
            expandImage = LoadResourceImage("ExpandImage.png");

            diagram = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(components)
            {
                Dock = DockStyle.Fill,
                Model = new Model(components),
                Location = Point.Empty,
                Margin = new Padding(4),
                Name = "diagram1",
                Size = new Size(1600, 500),
                TabIndex = 0,
                VScroll = true,
                HScroll = true,
                EnableTouchMode = false,
                LayoutManager = null,
                ScrollVirtualBounds = RectangleF.Empty,
                SmartSizeBox = false,
                Text = "diagram1",
            };
            diagram.Controller.Constraint = Constraints.PageEditable;
            diagram.Controller.DefaultConnectorTool = ConnectorTool.OrgLineConnectorTool;
            diagram.Controller.PasteOffset = new SizeF(10F, 10F);
            diagram.Binding = new Syncfusion.Windows.Forms.Diagram.Binding
            {
                DefaultConnector = null,
                DefaultNode = null,
                Diagram = diagram,
                Id = null,
                Label = new List<string>(),
                ParentId = null,
            };
            diagram.View.BackgroundColor = Color.White;
            diagram.View.ClientRectangle = Rectangle.Empty;
            diagram.View.Controller = diagram.Controller;
            diagram.View.Grid.MinPixelSpacing = 4F;
            diagram.View.Grid.Visible = false;
            diagram.View.ScrollVirtualBounds = RectangleF.Empty;
            diagram.View.ZoomType = ZoomType.Center;
            diagram.Model.AlignmentType = AlignmentType.SelectedNode;
            diagram.Model.BackgroundStyle.PathBrushStyle = PathGradientBrushStyle.RectangleCenter;
            diagram.Model.DocumentScale.DisplayName = "No Scale";
            diagram.Model.DocumentScale.Height = 1F;
            diagram.Model.DocumentScale.Width = 1F;
            diagram.Model.DocumentSize.Height = 3000F;
            diagram.Model.DocumentSize.Width = 3000F;
            diagram.Model.LineStyle.DashPattern = null;
            diagram.Model.LineStyle.LineColor = Color.Black;
            diagram.Model.LineStyle.LineWidth = 0F;
            diagram.Model.LogicalSize = new SizeF(3000F, 3000F);
            diagram.Model.Padding = new Padding(0);
            diagram.Model.ShadowStyle.Color = Color.FromArgb(128, 105, 105, 105);
            diagram.Model.ShadowStyle.ForeColor = Color.FromArgb(128, 105, 105, 105);
            paletteGroupBar = new PaletteGroupBar(components)
            {
                AllowDrop = true,
                Dock = DockStyle.Fill,
                EditMode = false,
                FlatLook = true,
                BorderColor = ColorTranslator.FromHtml("#119EDA"),
                BackColor = Color.FromArgb(235, 235, 235),
                BeforeTouchSize = new Size(360, 500),
                ExpandButtonToolTip = null,
                CollapseImage = collapseImage,
                ExpandImage = expandImage,
                GroupBarItemHeight = 32,
                GroupBarDropDownToolTip = null,
                IndexOnVisibleItems = true,
                MinimizeButtonToolTip = null,
                NavigationPaneTooltip = null,
                PopupClientSize = Size.Empty,
                SmartSizeBox = false,
                Splittercolor = SystemColors.ControlDark,
                Text = "paletteGroupBar1",
                TextAlign = TextAlignment.Left,
                ThemeName = "Metro",
                VisualStyle = VisualStyle.Metro,
            };
            paletteGroupBar.Diagram = diagram;

            var palettePanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 360,
                BackColor = SystemColors.Control,
                Location = Point.Empty,
                Margin = new Padding(4),
                Name = "panel2",
                Visible = true,
            };
            palettePanel.Controls.Add(paletteGroupBar);
            var diagramPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Location = new Point(360, 0),
                Margin = new Padding(4),
                Name = "panel3",
                Size = new Size(1600, 500),
            };
            diagramPanel.Controls.Add(diagram);

            Controls.Add(diagramPanel);
            Controls.Add(palettePanel);
            BackColor = Color.White;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Dock = DockStyle.Fill;
            Margin = new Padding(4);
            Name = "__VIEW_NAME__";
            Text = "Flow Diagram";

            paletteGroupBar.LoadPalette(GetResourcePath("Basic Shapes.xml"));
            paletteGroupBar.LoadPalette(GetResourcePath("Flowchart Symbols.xml"));
            diagram.EventSink.Deserialized += OnDiagramDeserialized;
            diagram.LoadXml(GetResourcePath("Flow Diagram.xml"));
            diagram.ShowRulers = true;
            diagram.RulersHeight = 25;
            diagram.HorizontalRuler.GridSpacingType = GridSpacingType.Variable;
            diagram.VerticalRuler.GridSpacingType = GridSpacingType.Variable;
            diagram.View.Grid.Visible = true;
            diagram.View.Grid.SnapToGrid = true;
            diagram.BeginUpdate();
            SetPaletteAppearance();
            diagram.EndUpdate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                collapseImage.Dispose();
                expandImage.Dispose();
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private static string GetResourcePath(string fileName)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "__CONTROL_NAME__", "Resources", fileName);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("A required diagram sample resource was not found.", path);
            }

            return path;
        }

        private static Image LoadResourceImage(string fileName)
        {
            var path = GetResourcePath(fileName);
            using (var image = Image.FromFile(path))
            {
                return new Bitmap(image);
            }
        }

        private void OnDiagramDeserialized(SerializationEventsArgs eventArgs)
        {
            eventArgs.View.Grid.GridStyle = GridStyle.Point;
        }

        private void SetPaletteAppearance()
        {
            paletteGroupBar.BorderStyle = BorderStyle.None;
            paletteGroupBar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            paletteGroupBar.ForeColor = Color.White;
            paletteGroupBar.GroupBarItemHeight = 32;
            paletteGroupBar.IndexOnVisibleItems = true;
            paletteGroupBar.SmartSizeBox = false;
            paletteGroupBar.Text = "paletteGroupBar1";
            paletteGroupBar.TextAlign = TextAlignment.Left;
            paletteGroupBar.ThemeName = "Metro";
            paletteGroupBar.VisualStyle = VisualStyle.Metro;

            foreach (GroupBarItem item in paletteGroupBar.GroupBarItems)
            {
                if (item.Text == "BasicShapes")
                {
                    item.Text = "Basic Shapes";
                }
                else if (item.Text == "Flowchart Symbols")
                {
                    item.Text = "Flowchart Shapes";
                }

                if (item.Client is PaletteGroupView paletteView)
                {
                    paletteView.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    paletteView.ForeColor = Color.Black;
                    paletteView.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    paletteView.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    paletteView.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    paletteView.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    paletteView.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(80);
                    paletteView.BackColor = Color.White;
                    paletteView.FlowView = true;
                    paletteView.ShowToolTips = true;
                    paletteView.ShowFlowViewItemText = true;
                    paletteView.TextWrap = true;
                    paletteView.FlatLook = true;
                    paletteView.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }
    }
}

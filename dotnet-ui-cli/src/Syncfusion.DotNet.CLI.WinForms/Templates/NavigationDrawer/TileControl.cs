#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class TileControl : Control
    {
        private readonly Font fieldFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular);
        private readonly Size textSize;

        public TileControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            HeaderText = "HeaderText";
            PostionText = "PostionText";
            OrganizatonText = "OrganizatonText";
            DOBText = "DOBText";
            LocationText = "LocationText";
            HeaderColor = Color.Black;
            HeaderTextColor = Color.Black;
            TextColor = Color.Black;
            TileImage = new Bitmap(10, 10);
            textSize = TextRenderer.MeasureText(" Date Of Birth", Font);
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Color HeaderColor { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string HeaderText { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Image TileImage { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string PostionText { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string OrganizatonText { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string LocationText { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string DOBText { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Color TextColor { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Color HeaderTextColor { get; set; }

        protected override void Dispose(bool disposing)
        {
            if (disposing) { fieldFont.Dispose(); TileImage?.Dispose(); }
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var headerBounds = new Rectangle(0, 0, Width, 45);
            var imageBounds = new Rectangle(15, headerBounds.Bottom + 15, TileImage.Width, TileImage.Height);
            var labelsX = imageBounds.Right + 10;
            var valuesX = labelsX + 102;
            var firstLabelY = headerBounds.Bottom + 15;
            var lineHeight = textSize.Height + 15;
            var headerTextSize = TextRenderer.MeasureText(HeaderText, Font);
            var headerTextY = headerBounds.Y + (headerBounds.Height - headerTextSize.Height) / 2;

            using (var borderPen = new Pen(HeaderColor, 2))
            using (var headerBrush = new SolidBrush(HeaderColor))
            using (var headerFont = new Font(fieldFont.FontFamily, 11, FontStyle.Bold))
            using (var headerTextBrush = new SolidBrush(HeaderTextColor))
            using (var textBrush = new SolidBrush(TextColor))
            using (var boldFieldFont = new Font(fieldFont, FontStyle.Bold))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, Math.Max(0, Width - 1), Math.Max(0, Height - 1));
                e.Graphics.FillRectangle(headerBrush, headerBounds);
                e.Graphics.DrawString(HeaderText, headerFont, headerTextBrush, 5, headerTextY);
                if (TileImage != null)
                {
                    e.Graphics.DrawImage(TileImage, imageBounds);
                }

                DrawField(e.Graphics, "Postion", PostionText, labelsX, valuesX, firstLabelY, boldFieldFont, fieldFont, textBrush);
                DrawField(e.Graphics, "Organizaton", OrganizatonText, labelsX, valuesX, firstLabelY + lineHeight, boldFieldFont, fieldFont, textBrush);
                DrawField(e.Graphics, "Date Of Birth", DOBText, labelsX, valuesX, firstLabelY + lineHeight * 2, boldFieldFont, fieldFont, textBrush);
                DrawField(e.Graphics, "Location", LocationText, labelsX, valuesX, firstLabelY + lineHeight * 3, boldFieldFont, fieldFont, textBrush);
            }
        }

        private static void DrawField(
            Graphics graphics,
            string label,
            string value,
            int labelsX,
            int valuesX,
            int y,
            Font labelFont,
            Font valueFont,
            Brush brush)
        {
            graphics.DrawString(label, labelFont, brush, labelsX, y);
            graphics.DrawString(value, valueFont, brush, valuesX, y);
        }
    }
}

#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Input.Enums;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        private readonly Dictionary<string, Image> images = new Dictionary<string, Image>(StringComparer.Ordinal);

        public __VIEW_NAME__()
        {
            var viewModel = new __VIEW_MODEL_NAME__();
            var grid = new SfDataGrid
            {
                AccessibleName = "Table",
                AllowDraggingColumns = true,
                AllowSorting = true,
                AllowFiltering = true,
                AllowEditing = true,
                AllowGrouping = true,
                AllowResizingColumns = true,
                AllowResizingHiddenColumns = true,
                AutoGenerateColumns = false,
                AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells,
                BackColor = SystemColors.Window,
                Location = Point.Empty,
                Name = "sfDataGrid",
                RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f),
                SelectionMode = GridSelectionMode.Extended,
                Size = new Size(900, 400),
                ShowGroupDropArea = true,
                TabIndex = 1,
                Dock = DockStyle.Fill,
            };

            grid.Columns.Add(new GridImageColumn
            {
                MappingName = nameof(DataGridModel.EmployeeName),
                HeaderText = "Employee Name",
                ImageLayout = ImageLayout.None,
            });
            grid.Columns.Add(new GridTextColumn { MappingName = nameof(DataGridModel.Designation), HeaderText = "Designation" });
            grid.Columns.Add(new GridTextColumn { MappingName = nameof(DataGridModel.Mail), HeaderText = "Mail" });
            grid.Columns.Add(new GridImageColumn
            {
                MappingName = nameof(DataGridModel.Location),
                HeaderText = "Location",
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Width = 100,
            });
            grid.Columns.Add(new GridTextColumn { MappingName = nameof(DataGridModel.Status), HeaderText = "Status" });
            grid.Columns.Add(new GridImageColumn
            {
                MappingName = nameof(DataGridModel.Trustworthiness),
                HeaderText = "Trustworthiness",
            });
            grid.Columns.Add(new GridNumericColumn
            {
                MappingName = nameof(DataGridModel.Salary),
                HeaderText = "Salary",
                FormatMode = FormatMode.Currency,
            });
            grid.Columns.Add(new GridTextColumn { MappingName = nameof(DataGridModel.Address), HeaderText = "Address" });
            grid.Columns.Add(new GridProgressBarColumn
            {
                MappingName = nameof(DataGridModel.SoftwareProficiency),
                HeaderText = "Software Proficiency",
                Maximum = 100,
                Minimum = 0,
                ValueMode = ProgressBarValueMode.Percentage,
            });

            grid.DataSource = viewModel.EmployeeDetails;
            grid.Style.ProgressBarStyle.ForegroundColor = Color.CadetBlue;
            grid.QueryImageCellStyle += OnQueryImageCellStyle;
            grid.QueryCellStyle += OnQueryCellStyle;

            Controls.Add(grid);
            BackColor = SystemColors.Window;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Dock = DockStyle.Fill;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Getting Started";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (var image in images.Values)
                {
                    image.Dispose();
                }

                images.Clear();
            }

            base.Dispose(disposing);
        }

        private void OnQueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            if (e.Column.MappingName == nameof(DataGridModel.Status))
            {
                e.Style.TextColor = e.DisplayText == "Active" ? Color.Green : Color.Red;
            }
        }

        private void OnQueryImageCellStyle(object sender, QueryImageCellStyleEventArgs e)
        {
            var employee = e.Record as DataGridModel;
            if (employee == null)
            {
                return;
            }

            if (e.Column.MappingName == nameof(DataGridModel.EmployeeName))
            {
                e.Image = LoadImage(employee.Gender == "1" ? "Male.png" : "Female.png");
                e.DisplayText = employee.EmployeeName;
                e.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else if (e.Column.MappingName == nameof(DataGridModel.Trustworthiness))
            {
                e.Image = LoadImage(employee.Trustworthiness + ".png");
                e.DisplayText = employee.Trustworthiness;
                e.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else if (e.Column.MappingName == nameof(DataGridModel.Location))
            {
                e.Image = LoadImage("location.png");
                e.DisplayText = employee.Location;
                e.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private Image LoadImage(string fileName)
        {
            Image image;
            if (!images.TryGetValue(fileName, out image))
            {
                var path = Path.Combine(AppContext.BaseDirectory, "__CONTROL_NAME__", "Resources", fileName);
                using (var loadedImage = Image.FromFile(path))
                {
                    image = new Bitmap(loadedImage);
                }

                images.Add(fileName, image);
            }

            return image;
        }
    }
}

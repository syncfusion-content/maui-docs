
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.Input.Enums

Namespace __ROOT_NAMESPACE__.DataGrid
    Public Partial Class DataGridPage
        Inherits UserControl
        Private ReadOnly images As Dictionary(Of String, Image) = New Dictionary(Of String, Image)(StringComparer.Ordinal)

        Public Sub New()
            Dim viewModel = New DataGridViewModel()
            Dim grid = New SfDataGrid With {
    .AccessibleName = "Table",
    .AllowDraggingColumns = True,
    .AllowSorting = True,
    .AllowFiltering = True,
    .AllowEditing = True,
    .AllowGrouping = True,
    .AllowResizingColumns = True,
    .AllowResizingHiddenColumns = True,
    .AutoGenerateColumns = False,
    .AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells,
    .BackColor = SystemColors.Window,
    .Location = Point.Empty,
    .Name = "sfDataGrid",
    .RowHeight = DpiAware.LogicalToDeviceUnits(21.0F),
    .SelectionMode = GridSelectionMode.Extended,
    .Size = New Size(900, 400),
    .ShowGroupDropArea = True,
    .TabIndex = 1,
    .Dock = DockStyle.Fill
}

            grid.Columns.Add(New GridImageColumn With {
    .MappingName = NameOf(DataGridModel.EmployeeName),
    .HeaderText = "Employee Name",
    .ImageLayout = ImageLayout.None
})
            grid.Columns.Add(New GridTextColumn With {
                .MappingName = NameOf(DataGridModel.Designation),
                .HeaderText = "Designation"
            })
            grid.Columns.Add(New GridTextColumn With {
                .MappingName = NameOf(DataGridModel.Mail),
                .HeaderText = "Mail"
            })
            grid.Columns.Add(New GridImageColumn With {
    .MappingName = NameOf(DataGridModel.Location),
    .HeaderText = "Location",
    .TextImageRelation = TextImageRelation.ImageBeforeText,
    .Width = 100
})
            grid.Columns.Add(New GridTextColumn With {
                .MappingName = NameOf(DataGridModel.Status),
                .HeaderText = "Status"
            })
            grid.Columns.Add(New GridImageColumn With {
    .MappingName = NameOf(DataGridModel.Trustworthiness),
    .HeaderText = "Trustworthiness"
})
            grid.Columns.Add(New GridNumericColumn With {
    .MappingName = NameOf(DataGridModel.Salary),
    .HeaderText = "Salary",
    .FormatMode = FormatMode.Currency
})
            grid.Columns.Add(New GridTextColumn With {
                .MappingName = NameOf(DataGridModel.Address),
                .HeaderText = "Address"
            })
            grid.Columns.Add(New GridProgressBarColumn With {
    .MappingName = NameOf(DataGridModel.SoftwareProficiency),
    .HeaderText = "Software Proficiency",
    .Maximum = 100,
    .Minimum = 0,
    .ValueMode = ProgressBarValueMode.Percentage
})

            grid.DataSource = viewModel.EmployeeDetails
            grid.Style.ProgressBarStyle.ForegroundColor = Color.CadetBlue
            AddHandler grid.QueryImageCellStyle, AddressOf OnQueryImageCellStyle
            AddHandler grid.QueryCellStyle, AddressOf OnQueryCellStyle

            Controls.Add(grid)
            MyBase.BackColor = SystemColors.Window
            AutoScaleDimensions = New SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            MyBase.Dock = DockStyle.Fill
            Margin = New Padding(5)
            Name = "Form1"
            Text = "Getting Started"
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                For Each image In images.Values
                    image.Dispose()
                Next

                images.Clear()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub OnQueryCellStyle(sender As Object, e As QueryCellStyleEventArgs)
            If Equals(e.Column.MappingName, NameOf(DataGridModel.Status)) Then
                e.Style.TextColor = If(Equals(e.DisplayText, "Active"), Color.Green, Color.Red)
            End If
        End Sub

        Private Sub OnQueryImageCellStyle(sender As Object, e As QueryImageCellStyleEventArgs)
            Dim employee = TryCast(e.Record, DataGridModel)
            If employee Is Nothing Then
                Return
            End If

            If Equals(e.Column.MappingName, NameOf(DataGridModel.EmployeeName)) Then
                e.Image = LoadImage(If(Equals(employee.Gender, "1"), "Male.png", "Female.png"))
                e.DisplayText = employee.EmployeeName
                e.TextImageRelation = TextImageRelation.ImageBeforeText
            ElseIf Equals(e.Column.MappingName, NameOf(DataGridModel.Trustworthiness)) Then
                e.Image = LoadImage(employee.Trustworthiness & ".png")
                e.DisplayText = employee.Trustworthiness
                e.TextImageRelation = TextImageRelation.ImageBeforeText
            ElseIf Equals(e.Column.MappingName, NameOf(DataGridModel.Location)) Then
                e.Image = LoadImage("location.png")
                e.DisplayText = employee.Location
                e.TextImageRelation = TextImageRelation.ImageBeforeText
            End If
        End Sub

        Private Function LoadImage(fileName As String) As Image
            Dim image As Image = Nothing
            If Not images.TryGetValue(fileName, image) Then
                Dim path = IO.Path.Combine(AppContext.BaseDirectory, "DataGrid", "Resources", fileName)
                Using loadedImage = Image.FromFile(path)
                    image = New Bitmap(loadedImage)
                End Using

                images.Add(fileName, image)
            End If

            Return image
        End Function
    End Class
End Namespace

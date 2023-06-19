---
layout: post
title: Export to Excel in MAUI DataGrid control | Syncfusion
description: Learn here all about Excel Exporting support in Syncfusion MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Export To Excel in MAUI DataGrid (SfDataGrid)

The SfDataGrid allows for exporting data to Excel, providing various customization options such as personalized appearance, excluding certain columns, excluding headers, adjusting custom row height, modifying custom column width, and more.

The following NuGet package should be installed to export the SfDataGrid to Excel file.

<table>
<tr>
<th> Project </th>
<th> Required package </th>
</tr>
<tr>
<td> .NET MAUI</td>
<td> Syncfusion.Maui.DataGridExport</td>
</tr>
</table>

The code sample below illustrates the process of exporting data to Excel using the `DataGridExcelExportingController.ExportToExcel` method, with SfDataGrid passed as an argument.

{% tabs %}
{% highlight xaml %}
    <StackLayout>
        <Button Text="Export"
                Clicked="ExportToExcel_Clicked" />
        <syncfusion:SfDataGrid x:Name="dataGrid"
                               Margin="20"
                               VerticalOptions="FillAndExpand"
                               ItemsSource="{Binding OrderInfoCollection}"
                               GridLinesVisibility="Both"
                               HeaderGridLinesVisibility="Both"
                               AutoGenerateColumnsMode="None"
                               ColumnWidthMode="Auto">
            <syncfusion:SfDataGrid.Columns>
                <syncfusion:DataGridNumericColumn Format="D"
                                                  HeaderText="Order ID"
                                                  MappingName="OrderID">
                </syncfusion:DataGridNumericColumn>
                <syncfusion:DataGridTextColumn HeaderText="Customer ID"
                                               MappingName="CustomerID">
                </syncfusion:DataGridTextColumn>
                <syncfusion:DataGridTextColumn MappingName="Customer"
                                               HeaderText="Customer">
                </syncfusion:DataGridTextColumn>
                <syncfusion:DataGridTextColumn HeaderText="Ship City"
                                               MappingName="ShipCity">
                </syncfusion:DataGridTextColumn>
                <syncfusion:DataGridTextColumn HeaderText="Ship Country"
                                               MappingName="ShipCountry">
                </syncfusion:DataGridTextColumn>
            </syncfusion:SfDataGrid.Columns>
        </syncfusion:SfDataGrid>
    </StackLayout>
{% endhighlight %}
{% highlight c# %}
private void ExportToExcel_Clicked(object sender, EventArgs e)
{
    // Perform exporting to Excel sheet operations here.
    DataGridExcelExportingController excelExport = new DataGridExcelExportingController();
    var excelEngine = excelExport.ExportToExcel(this.dataGrid);
    var workbook = excelEngine.Excel.Workbooks[0];
    MemoryStream stream = new MemoryStream();
    workbook.SaveAs(stream);
    workbook.Close();
    excelEngine.Dispose();

    string OutputFilename = "DefaultDataGrid.xlsx";
    SaveService saveService = new();
    saveService.SaveAndView(OutputFilename, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", stream);
}
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format" src="Images\Export-to-Excel\maui-datagrid-datagrid-to-excel.png" width="689"/>

N> SfDataGrid cannot export the DataGridTemplateColumn to PDF or Excel,  since we cannot get the loaded views and draw them with the particular range, values etc from DataGridTemplateColumn.

## Exporting Options

Additionally, you can export the data to Excel by providing the grid and `DataGridExcelExportingOption` as arguments to the `ExportToExcel` method, which offers several customization options.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingController excelExport = new DataGridExcelExportingController();
DataGridExcelExportingOption exportOption = new DataGridExcelExportingOption();
exportOption.CanExportColumnWidth = false;
exportOption.DefaultColumnWidth = 150;
var excelEngine = excelExport.ExportToExcel(this.dataGrid, exportOption);
{% endhighlight %}
{% endtabs %}

The SfDataGrid provides several properties in `DataGridExcelExportingOption` class to customize the grid while exporting it to Excel.

### Exporting formatted text and actual value

By default, the actual value will only be exported to Excel. To export the display text, set the ExportMode property as Text.

{% tabs%}
{% highlight c# %}
DataGridExcelExportingController excelExport = new DataGridExcelExportingController ();
DataGridExcelExportingOption options = new DataGridExcelExportingOption ();
options.ExportMode = ExportMode.Text;
var excelEngine = excelExport.ExportToExcel(dataGrid, options);
var workBook = excelEngine.Excel.Workbooks[0];
{% endhighlight c# %}
{% endtabs %}

### Getting RowIndex, ColumnIndex and Columns for customization

#### ExcelColumnIndex

The `ExcelColumnIndex Property` gets or internally sets the column index being exported to the Excel. Each column is exported based on this index to identify the current exporting column index.

#### ExcelRowIndex

The `ExcelRowIndex Property` gets the row index being exported to the Excel. Each row is exported based on this index to identify the current exporting row index.

#### Columns

Using the property `System.Collections.IEnumerable Columns` you can get or set the `ExcludedColumns` columns collection which contains all the columns that are to be exported. The columns in the ExcludedColumns List will not be a member of the Columns collection.

## Customize header, groups and table summary when exporting

### Export groups

By default, all the groups in the data grid will be exported to Excel sheet. To export the data grid without groups, set the `DataGridExcelExportingOption.CanExportGroups` property to `false`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportGroups = true;
{% endhighlight %}
{% endtabs %}

* CanExportGroups = true; 

<img alt="Export DataGrid to Excel format with group summary rows" src="Images\Export-to-Excel\maui-datagrid-export-groups.png" width="689"/>


* CanExportGroups = false;

<img alt="Export DataGrid to Excel format with group summary rows" src="Images\Export-to-Excel\maui-datagrid-datagrid-to-excel.png" width="689"/>

### Export header

By default, the column headers will be exported to Excel sheet. To export the SfDataGrid without column headers, set the `DataGridExcelExportingOption.CanExportHeader` property to `false`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
        option.CanExportHeader = false;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format without header cells" src="Images\Export-to-Excel\maui-datagrid-exclude-header.png" width="689"/>

### ExportGroupSummary

By default, the `GroupSummary` rows in the data grid will be exported to Excel. To export the `SfDataGrid` without group summaries, set the `DataGridExcelExportingOption.CanExportGroupSummary` property to `false`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportGroupSummary= true;
option.CanExportGroups = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with group summary rows" src="Images\Export-to-Excel\maui-datagrid-export-group-summary.png" width="689"/>

#### Export table summary

By default, table summaries in the data grid will be exported to Excel. To export the SfDataGrid without table summaries, set the `DataGridExcelExportingOption.CanExportTableSummary` property to `false`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportTableSummary= true;
{% endhighlight %}
{% endtabs %}

* CanExportTableSummary = true;
<img alt="Export DataGrid with table summary" src="Images\Export-to-Excel\maui-datagrid-export-table-summary.png" width="689"/>


* CanExportTableSummary = false;

<img alt="Export DataGrid without table summary" src="Images\Export-to-Excel\maui-datagrid-exclude-table-summary.png" width="689"/>


### Export groups with outlines

To export the data grid with applied grouping, enable the group expand or collapse option in the Excel sheet by setting the `DataGridExcelExportingOption.CanAllowOutlining` to `true`. The default value of this property is false so, you cannot expand or collapse the group in the Excel sheet.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
        option.CanAllowOutlining = true;
{% endhighlight %}
{% endtabs %}

### Exclude columns when exporting

By default, all the columns (including hidden columns) in the SfDataGrid will be exported to Excel. To exclude some particular columns when exporting to Excel, add those columns to the `DataGridExcelExportingOption.ExcludeColumns` property in `DataGridExcelExportingOption` list.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
        var list = new List<string>();
        list.Add("EmployeeID");
        list.Add("Name");
        option.ExcludedColumns = list;
{% endhighlight %}
{% endtabs %}

<img alt="Exclude columns when exporting" src="Images\Export-to-Excel\maui-datagrid-excluded-columns.png" width="689"/>

### Export Selected Rows of SfDataGrid

SfDataGrid allows you to export only the currently selected rows in the grid to the worksheet using the `DataGridExcelExportingController.ExportToExcel` method by passing the instance of the SfDataGrid and `SfDataGrid.SelectedRows` collection as an argument.

Refer the below code to export the selected rows alone to Excel.

{% tabs %}
{% highlight c# %}
ObservableCollection<object> selectedItems = dataGrid.SelectedRows;
var excelEngine = excelExport.ExportToExcel(this.dataGrid, selectedItems);
{% endhighlight %}
{% endtabs %}


### Customize Exporting Excel Version

The SfDataGrid allows exporting the data to Excel in specific versions by using the `DataGridExcelExportingOption.ExcelVersion` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.ExcelVersion = Syncfusion.XlsIO.ExcelVersion.Excel2013;
{% endhighlight %}
{% endtabs %}

### Exporting the grid from a specified row and column index 

#### StartColumnIndex

By default, the exported SfDataGrid will start from the 0th column in the Excel sheet. You can specify the starting column by using the `DataGridExcelExportingOption.StartColumnIndex` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.StartColumnIndex = 3;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format from the specified column index" src="Images\Export-to-Excel\maui-datagrid-start-column-index.png" width="689"/>

#### StartRowIndex

By default, the exported SfDataGrid will start from the 0th row in the Excel sheet. You can specify the starting row by using the `DataGridExcelExportingOption.StartRowIndex` property.
{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.StartRowIndex = 3;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format from the specified row index" src="Images\Export-to-Excel\maui-datagrid-start-row-index.png" width="689"/>

### Exporting with sorting and filtering

The SfDataGrid allows exporting the data grid to Excel with sorting and filtering options enabled on the column header in Excel sheet by setting the `DataGridExcelExportingOption.CanAllowSortingAndFiltering` to `true`. The default value of this property is false.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanAllowSortingAndFiltering = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel with sorting and filtering" src="Images\Export-to-Excel\maui-datagrid-can-allow-sorting-filtering.png" width="689"/>


### Applying styles while exporting

The SfDataGrid allows exporting the data with the applied GridStyle by setting the `DataGridExcelExportingOption.CanApplyGridStyle` to `true`. By default, the data will be exported without the GridStyle.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanApplyGridStyle = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel with styling applied" src="Images\Export-to-Excel\maui-datagrid-can-apply-gridstyle.png" width="689"/>

#### TopTableSummaryStyle

The SfDataGrid supports exporting the top table summary with custom style by using the `DataGridExcelExportingOption.TopTableSummaryStyle` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.TopTableSummaryStyle = new DataGridExportCellStyle()
{
    BackgroundColor = Color.FromArgb("#AFD5FB"),
    BorderColor = Colors.DarkBlue,
    TextColor = Colors.Black,
    FontInfo = new DataGridExportFontInfo()
    {
        Italic = true,
    }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with style applied for table summary rows at the top" src="Images\Export-to-Excel\maui-datagrid-top-table-summary-style.png" width="689"/> 

#### BottomTableSummaryStyle

The SfDataGrid supports exporting the bottom table summary with custom style by using the `DataGridExcelExportingOption.BottomTableSummaryStyle` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.BottomTableSummaryStyle = new DataGridExportCellStyle()
{
    BackgroundColor = Color.FromArgb("0074E3"),
    BorderColor = Colors.DarkBlue,
    TextColor = Colors.White,
    FontInfo = new DataGridExportFontInfo()
    {
        Bold = true,
    }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with style applied for table summary rows at the bottom" src="Images\Export-to-Excel\maui-datagrid-bottom-table-summary-style.png" width="689"/> 

#### GroupCaptionStyle

The SfDataGrid supports exporting the GroupCaptionSummaries with custom style by using the `DataGridExcelExportingOption.GroupCaptionStyle` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.GroupCaptionStyle = new DataGridExportCellStyle()
{
    BackgroundColor = Color.FromArgb("0074E3"),
    BorderColor = Colors.DarkBlue,
    TextColor = Colors.White,
    FontInfo = new DataGridExportFontInfo()
    {
        Bold = true,
    }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with style applied for Group summary rows" src="Images\Export-to-Excel\maui-datagrid-group-caption-style.png" width="689"/> 

#### HeaderStyle

The SfDataGrid allows exporting the column headers with custom style by using the `DataGridExcelExportingOption.HeaderStyle` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.HeaderStyle = new DataGridExportCellStyle()
{
    BackgroundColor = Color.FromArgb("0074E3"),
    BorderColor = Colors.DarkBlue,
    TextColor = Colors.White,
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with styling for header cells" src="Images\Export-to-Excel\maui-datagrid-header-style.png" width="689"/> 

#### RecordStyle

The SfDataGrid allows exporting the records with custom style by using the `DataGridExcelExportingOption.RecordStyle` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.RecordStyle = new DataGridExportCellStyle()
{
    BackgroundColor = Color.FromArgb("#AFD5FB"),
    BorderColor = Colors.DarkBlue,
    TextColor = Colors.Black,
    FontInfo = new DataGridExportFontInfo()
    {
        Italic = true,
    }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with styling for record cells" src="Images\Export-to-Excel\maui-datagrid-record-style.png" width="689"/>

#### GroupSummaryStyle 

`SfDataGrid` supports exporting the `GroupSummary` rows with custom style by using the `DataGridExcelExportingOption.GroupSummaryStyle` property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.GroupSummaryStyle = new DataGridExportCellStyle()
{
    BackgroundColor = Color.FromArgb("0074E3"),
    BorderColor = Colors.DarkBlue,
    TextColor = Colors.White,
    FontInfo = new DataGridExportFontInfo()
    {
        Bold = true,
    }
};
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with styling applied for group summary rows" src="Images\Export-to-Excel\maui-datagrid-group-summary-style.png" width="689"/>

## Row Height and Column Width customization

### DefaultColumnWidth

The SfDataGrid allows customizing the column width in Excel file by using the `DataGridExcelExportingOption.DefaultColumnWidth` property. The `DefaultColumnWidth` value will be applied to all the columns in the Excel sheet.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();option.DefaultColumnWidth = 150;
option.CanExportColumnWidth = false;
{% endhighlight %}
{% endtabs %}

### DefaultRowHeight

The SfDataGrid allows customizing the row height in Excel file by using the `DataGridExcelExportingOption.DefaultRowHeight` property. The `DefaultRowHeight` value will be applied to all the rows in the Excel sheet.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.DefaultRowHeight = 80;
option.CanExportRowHeight = false;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with customized row height for all rows" src="Images\Export-to-Excel\maui-datagrid-ColumnWidth.png" width="689"/>

### ExportColumnWidth

By default, the data grid columns will be exported to Excel with `DataGridExcelExportingOption.DefaultColumnWidth` value. You can also export the data grid to Excel with exact column widths by setting the `DataGridExcelExportingOption.CanExportColumnWidth` property to `true`. 

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportColumnWidth = true;
{% endhighlight %}
{% endtabs %}


### ExportRowHeight

By default, the data grid rows will be exported to Excel with `DataGridExcelExportingOption.DefaultRowHeight` value. You can also export the data grid to Excel with exact row heights by setting the `DataGridExcelExportingOption.CanExportRowHeight` property to `true`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportRowHeight = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with default row heigh" src="Images\Export-to-Excel\maui-datagrid-datagrid-to-excel.png" width="689"/>

## Events

The SfDataGrid provides the following events when exporting to Excel:

* `RowExporting`: Raised when exporting a row at the execution time.
* `CellExporting`: Raised when exporting a cell at the execution time.

### Row exporting

The `DataGridRowExcelExportingEventHandler` delegate allows customizing the styles for record rows and group caption rows. The `RowExporting` event is triggered with `DataGridRowExcelExportingEventArgs` that contains the following properties:

* `Range`: Specifies the Excel range to be exported. It provides full access to the exporting cell in Excel.
* `Record`: Gets the collection of the exported underlying data objects.
* `RowType`: Specifies the row type by using `ExportRowType` enum. You can use this property to check the row type and apply different styles based on the row type.
* `Worksheet`: Sets the `Worksheet` properties such as sheet protection, gridlines, and so on. 

You can use these events to customize the properties of exported grid rows. The following code example illustrates how to change the row style based on the cell type when exporting.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingController excelExport = new DataGridExcelExportingController();
excelExport.RowExporting += ExcelExport_RowExporting;
private void ExcelExport_RowExporting(object sender, DataGridRowExcelExportingEventArgs e)
{
    if (!(e.Record.Data is OrderInfo))
        return;

    if (e.RowType == ExportRowType.Record)
    {
        e.Range.CellStyle.ColorIndex = Syncfusion.XlsIO.ExcelKnownColors.Aqua;
    }
}
{% endhighlight %}
{% endtabs %}

### CellExporting

The `DataGridCellExcelExportingEventHandler` delegate allows customizing the styles for header cells, record cells, and group caption cells. The `CellExporting` event is triggered with `DataGridCellExcelExportingEventArgs` that contains the following properties:

* `CellType`: Specifies the cell type by using `ExportCellType` enum. Checks the cell type and apply different cell styles based on the cell type.
* `CellValue`: Contains the exported actual value. Applies formatting in Excel by using the `Range` property.
* `ColumnName`: Specifies the column name (MappingName) of the exporting cell. You can apply formatting for a particular column by checking the `column name`.
* `Handled`: Determines whether the cell is exported to Excel or not.
* `Range`: Specifies the Excel range to be exported. It provides full access to the exporting cell in Excel.
* `Record`: Gets the collection of the exported underlying data objects. 

You can use these events to customize the properties of the grid cells exported to excel. The following code example illustrates how to customize the column style based on the row data

{% tabs %}
{% highlight c# %}
DataGridExcelExportingController excelExport = new DataGridExcelExportingController();
excelExport.RowExporting += ExcelExport_RowExporting;
private void ExcelExport_RowExporting(object sender, DataGridRowExcelExportingEventArgs e)
{
    if (!(e.Record.Data is OrderInfo))
        return;

    if (e.CellType == ExportCellType.RecordCell && e.ColumnName == "FirstName")
    {
        e.Range.CellStyle.ColorIndex = Syncfusion.XlsIO.ExcelKnownColors.Red;
    }
}
{% endhighlight %}
{% endtabs %}
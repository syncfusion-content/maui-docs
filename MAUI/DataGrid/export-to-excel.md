---
layout: post
title: Export to Excel in MAUI DataGrid control | Syncfusion
description: Learn here all about Excel Exporting support in Syncfusion MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Export To Excel in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) enables data export to Excel, offering several customization options such as personalized appearance, exclusion of specific columns or headers, adjustment of custom row height and column width, and more.

To export the SfDataGrid to an Excel file, the following NuGet package should be installed.

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

The following code sample illustrates the process of exporting data to Excel. It utilizes the [DataGridExcelExportingController.ExportToExcel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingController.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingController_ExportToExcel_Syncfusion_Maui_DataGrid_SfDataGrid_) method, with the SfDataGrid passed as an argument.

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

<img alt="Export DataGrid to Excel format" src="Images\export-to-excel\maui-datagrid-datagrid-to-excel.png" width="689"/>

N> The SfDataGrid is unable to export the DataGridTemplateColumn to PDF or Excel because it is not possible to access to the loaded views necessary for drawing them with specific range, values, and so on from the DataGridTemplateColumn.

## Exporting Options

Furthermore, you can export the data to Excel by providing the grid and [DataGridExcelExportingOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#properties) as arguments to the `ExportToExcel` method, which provides various customization options.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingController excelExport = new DataGridExcelExportingController();
DataGridExcelExportingOption exportOption = new DataGridExcelExportingOption();
exportOption.CanExportColumnWidth = false;
exportOption.DefaultColumnWidth = 150;
var excelEngine = excelExport.ExportToExcel(this.dataGrid, exportOption);
{% endhighlight %}
{% endtabs %}

The SfDataGrid offers various properties within the `DataGridExcelExportingOption` class to enable customization of the grid when exporting it to Excel.

### Exporting formatted text and actual value

The actual value will be exported to Excel by default. To export the display text, you need to set the ExportMode property as Text.

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

The [ExcelColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_ExcelColumnIndex) Property retrieves or internally sets the column index that is being exported to Excel. Each column is exported based on this index to identify the current exporting column.

#### ExcelRowIndex

The [ExcelRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_ExcelRowIndex) Property retrieves the row index that is being exported to Excel. Each row is exported based on this index to identify the current exporting row index.

#### Columns

By using the `System.Collections.IEnumerable Columns` property, you can retrieve or set the [ExcludedColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_ExcludedColumns) collection of columns, which contains all the columns to be exported. The columns in the ExcludedColumns list will not be included in the Columns collection.

## Customize header, groups and table summary when exporting

### Export groups

By default, all the groups in the data grid will be exported to Excel sheet. To export the data grid without groups, set the [DataGridExcelExportingOption.CanExportGroups](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanExportGroups) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportGroups = true;
{% endhighlight %}
{% endtabs %}

* CanExportGroups = true; 

<img alt="Export DataGrid to Excel format with group summary rows" src="Images\export-to-excel\maui-datagrid-export-groups.png" width="689"/>


* CanExportGroups = false;

<img alt="Export DataGrid to Excel format with group summary rows" src="Images\export-to-excel\maui-datagrid-exclude-groups.png" width="689"/>

### Export header

By default, the column headers will be exported to Excel sheet. To export the SfDataGrid without column headers, set the [DataGridExcelExportingOption.CanExportHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanExportHeader) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
        option.CanExportHeader = false;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format without header cells" src="Images\export-to-excel\maui-datagrid-exclude-header.png" width="689"/>

### ExportGroupSummary

By default, the `GroupSummary` rows in the data grid will be exported to Excel. To export the `SfDataGrid` without group summaries, set the [DataGridExcelExportingOption.CanExportGroupSummary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanExportGroupSummary) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportGroupSummary= true;
option.CanExportGroups = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with group summary rows" src="Images\export-to-excel\maui-datagrid-export-group-summary.png" width="689"/>

#### Export table summary

By default, table summaries in the data grid will be exported to Excel. To export the SfDataGrid without table summaries, set the [DataGridExcelExportingOption.CanExportTableSummary](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanExportGroupSummary) property to `false`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportTableSummary= true;
{% endhighlight %}
{% endtabs %}

* CanExportTableSummary = true;
<img alt="Export DataGrid with table summary" src="Images\export-to-excel\maui-datagrid-export-table-summary.png" width="689"/>


* CanExportTableSummary = false;

<img alt="Export DataGrid without table summary" src="Images\export-to-excel\maui-datagrid-exclude-table-summary.png" width="689"/>


### Export groups with outlines

To export the data grid with applied grouping, enable the option to expand or collapse groups in the Excel sheet by setting the [DataGridExcelExportingOption.CanAllowOutlining](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanAllowOutlining) to `true`. By default, this property is set to false, so you cannot expand or collapse the groups in the Excel sheet.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
        option.CanAllowOutlining = true;
{% endhighlight %}
{% endtabs %}

### Exclude columns when exporting

By default, all columns (including hidden columns) in the SfDataGrid are exported to Excel. To exclude specific columns when exporting to Excel, add those columns to the [DataGridExcelExportingOption.ExcludeColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_ExcludedColumns) property in the `DataGridExcelExportingOption` list.

{% tabs %}
{% highlight c# %}
DataGridPdfExportingOption option = new DataGridPdfExportingOption();
        var list = new List<string>();
        list.Add("EmployeeID");
        list.Add("Name");
        option.ExcludedColumns = list;
{% endhighlight %}
{% endtabs %}

<img alt="Exclude columns when exporting" src="Images\export-to-excel\maui-datagrid-excluded-columns.png" width="689"/>

### Export Selected Rows of SfDataGrid

The SfDataGrid enables you to export only the currently selected rows in the grid to the worksheet using the `DataGridExcelExportingController.ExportToExcel` method. To achieve this, you need to pass the instance of the SfDataGrid and the `SfDataGrid.SelectedRows` collection as arguments.

Please refer to the code snippet below, which demonstrates how to export the selected rows to Excel:

{% tabs %}
{% highlight c# %}
ObservableCollection<object> selectedItems = dataGrid.SelectedRows;
var excelEngine = excelExport.ExportToExcel(this.dataGrid, selectedItems);
{% endhighlight %}
{% endtabs %}


### Customize Exporting Excel Version

The SfDataGrid enables the exportation of data to Excel in specific versions through the utilization of the [DataGridExcelExportingOption.ExcelVersion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_ExcelVersion) property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.ExcelVersion = Syncfusion.XlsIO.ExcelVersion.Excel2013;
{% endhighlight %}
{% endtabs %}

### Exporting the grid from a specified row and column index 

#### StartColumnIndex

By default, the exported SfDataGrid will start from the 0th column in the Excel sheet. You can specify the starting column by using the [DataGridExcelExportingOption.StartColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_StartColumnIndex) property.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.StartColumnIndex = 3;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format from the specified column index" src="Images\export-to-excel\maui-datagrid-start-column-index.png" width="689"/>

#### StartRowIndex

By default, the exported SfDataGrid will start from the 0th row in the Excel sheet. You can specify the starting row by using the [DataGridExcelExportingOption.StartRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_StartRowIndex) property.
{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.StartRowIndex = 3;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format from the specified row index" src="Images\export-to-excel\maui-datagrid-start-row-index.png" width="689"/>

### Exporting with sorting and filtering

The SfDataGrid enables the export of the data grid to Excel while allowing sorting and filtering options to be enabled on the column header in the Excel sheet. This can be achieved by setting the [DataGridExcelExportingOption.CanAllowSortingAndFiltering](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanAllowSortingAndFiltering) property to `true`. By default, this property is set to false.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanAllowSortingAndFiltering = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel with sorting and filtering" src="Images\export-to-excel\maui-datagrid-can-allow-sorting-filtering.png" width="689"/>


### Applying styles while exporting

The SfDataGrid allows exporting the data with the applied GridStyle by setting the [DataGridExcelExportingOption.CanApplyGridStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanApplyGridStyle) to `true`. By default, the data will be exported without the GridStyle.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanApplyGridStyle = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel with styling applied" src="Images\export-to-excel\maui-datagrid-can-apply-gridstyle.png" width="689"/>

#### TopTableSummaryStyle

The SfDataGrid supports exporting the top table summary with custom style by using the [DataGridExcelExportingOption.TopTableSummaryStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_TopTableSummaryStyle) property.

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

<img alt="Export DataGrid to Excel format with style applied for table summary rows at the top" src="Images\export-to-excel\maui-datagrid-top-table-summary-style.png" width="689"/> 

#### BottomTableSummaryStyle

The SfDataGrid supports exporting the bottom table summary with custom style by using the [DataGridExcelExportingOption.BottomTableSummaryStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_BottomTableSummaryStyle) property.

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

<img alt="Export DataGrid to Excel format with style applied for table summary rows at the bottom" src="Images\export-to-excel\maui-datagrid-bottom-table-summary-style.png" width="689"/> 

#### GroupCaptionStyle

The SfDataGrid supports exporting the GroupCaptionSummaries with custom style by using the [DataGridExcelExportingOption.GroupCaptionStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_GroupCaptionStyle) property.

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

<img alt="Export DataGrid to Excel format with style applied for Group summary rows" src="Images\export-to-excel\maui-datagrid-group-caption-style.png" width="689"/> 

#### HeaderStyle

The SfDataGrid allows exporting the column headers with custom style by using the [DataGridExcelExportingOption.HeaderStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_HeaderStyle) property.

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

<img alt="Export DataGrid to Excel format with styling for header cells" src="Images\export-to-excel\maui-datagrid-header-style.png" width="689"/> 

#### RecordStyle

The SfDataGrid allows exporting the records with custom style by using the [DataGridExcelExportingOption.RecordStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_RecordStyle) property.

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

<img alt="Export DataGrid to Excel format with styling for record cells" src="Images\export-to-excel\maui-datagrid-record-style.png" width="689"/>

#### GroupSummaryStyle 

The `SfDataGrid` allows exporting the `GroupSummary` rows with custom style by using the [DataGridExcelExportingOption.GroupSummaryStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_GroupSummaryStyle) property.

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

<img alt="Export DataGrid to Excel format with styling applied for group summary rows" src="Images\export-to-excel\maui-datagrid-group-summary-style.png" width="689"/>

## Row Height and Column Width customization

### DefaultColumnWidth

The SfDataGrid allows customizing the column width in Excel file by using the [DataGridExcelExportingOption.DefaultColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_DefaultColumnWidth) property. The `DefaultColumnWidth` value will be applied to all the columns in the Excel sheet.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();option.DefaultColumnWidth = 150;
option.CanExportColumnWidth = false;
{% endhighlight %}
{% endtabs %}

### DefaultRowHeight

The SfDataGrid allows customizing the row height in Excel file by using the [DataGridExcelExportingOption.DefaultRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_DefaultRowHeight) property. The `DefaultRowHeight` value will be applied to all the rows in the Excel sheet.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.DefaultRowHeight = 80;
option.CanExportRowHeight = false;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with customized row height for all rows" src="Images\export-to-excel\maui-datagrid-column-width.png" width="689"/>

### ExportColumnWidth

By default, the data grid columns will be exported to Excel with `DataGridExcelExportingOption.DefaultColumnWidth` value. You can also export the data grid to Excel with exact column widths by setting the [DataGridExcelExportingOption.CanExportColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanExportColumnWidth) property to `true`. 

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportColumnWidth = true;
{% endhighlight %}
{% endtabs %}


### ExportRowHeight

By default, the data grid rows will be exported to Excel with `DataGridExcelExportingOption.DefaultRowHeight` value. You can also export the data grid to Excel with exact row heights by setting the [DataGridExcelExportingOption.CanExportRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridExcelExportingOption.html#Syncfusion_Maui_DataGrid_Exporting_DataGridExcelExportingOption_CanExportRowHeight) property to `true`.

{% tabs %}
{% highlight c# %}
DataGridExcelExportingOption option = new DataGridExcelExportingOption();
option.CanExportRowHeight = true;
{% endhighlight %}
{% endtabs %}

<img alt="Export DataGrid to Excel format with default row heigh" src="Images\export-to-excel\maui-datagrid-datagrid-row-width.png" width="689"/>

## Events

The SfDataGrid provides the following events when exporting to Excel:

* `RowExporting`: Raised when exporting a row at the execution time.
* `CellExporting`: Raised when exporting a cell at the execution time.

### Row exporting

The `DataGridRowExcelExportingEventHandler` delegate allows customizing the styles for record rows and group caption rows. The `RowExporting` event is triggered with [ataGridRowExcelExportingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridRowExcelExportingEventArgs.html) that contains the following properties:

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

The `DataGridCellExcelExportingEventHandler` delegate allows customizing the styles for header cells, record cells, and group caption cells. The `CellExporting` event is triggered with [DataGridCellExcelExportingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.Exporting.DataGridCellExcelExportingEventArgs.html) that contains the following properties:

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
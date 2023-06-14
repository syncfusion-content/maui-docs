---
layout: post
title: Export to Excel in MAUI DataGrid control | Syncfusion
description: Learn here all about PDF Exporting support in Syncfusion MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---
# Export To PDF in MAUI DataGrid (SfDataGrid)

The SfDataGrid supports exporting the data to PDF with several customization options like custom appearance, excluding specific columns, excluding headers, setting custom row height, setting custom column width, and so on.

If you are using nuget package in the package, the following NuGet package should be installed to export the SfDataGrid to PDF file.

<table>
<tr>
<th> Project </th>
<th> Required package </th>
</tr>
<tr>
<td> .NET MAUI </td>
<td> Syncfusion.Maui.DataGridExport</td>
</tr>
</table>

You can export the SfDataGrid to PDF by using the following extension methods present in the Syncfusion.Maui.DataGrid.Exporting namespace.

* `ExportToPdf`
* `ExportToPdfGrid`

The following code illustrates how to create and display a SfDataGrid in view.

{% tabs %}
{% highlight xaml %}
{% endhighlight %}
{% endtabs %}

## ExportToPdf

You can export the data to PDF by using the `DataGridPdfExportingController.ExportToPdf` method by passing the SfDataGrid as an argument. 

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

## ExportToPdfGrid

You can also export the data to PDF by using the `DataGridPdfExportingController.ExportToPdfGrid` method by passing the SfDataGrid as an argument. 

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with all columns fit in view]()

N> SfDataGrid cannot export the GridTemplateColumn to PDF or Excel,  since we cannot get the loaded views and draw them with the particular range, values etc from GridTemplateColumn.

## Exporting options

### Exclude columns when exporting

By default, all the columns (including hidden columns) in the SfDataGrid will be exported to PDF. To exclude some particular columns when exporting to PDF, add those columns to `DataGridPdfExportOption.ExcludeColumns` list.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with certain columns excluded]()

### Getting PDF document 

The `DataGridPdfExportOption.PdfDocument` allows exporting the SfDataGrid to an existing or a new PDF document. 

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

### Getting GridColumns for customization

Using the property `GridColumns` you can get or set the `System.Collections.IEnumerable` columns collection which contains all the columns that are to be exported. The columns in the ExcludedColumns List will not be a member of the GridColumns collection.

### Column header on each page

You can show or hide the column headers on each page of the exported PDF document by using the `DataGridPdfExportOption.RepeatHeaders` property. The default value is true.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with image column]()

### Customize header, groups and table summary when exporting

#### Exclude groups while exporting

By default, all the groups in the data grid will be exported to PDF document. To export the data grid without groups, set the `DataGridPdfExportOption.ExportGroups` property to `false`.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid with groups to PDF format]()

#### Exclude Column header while exporting

By default, the column headers will be exported to PDF document. To export the SfDataGrid without the column headers, set the `DataGridPdfExportOption.ExportHeader` property to `false`.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format without column header cells]()

#### Exclude table summaries while exporting

By default, table summaries in the data grid will be exported to PDF. To export the SfDataGrid without table summaries, set the `DataGridPdfExportOption.ExportTableSummary` property to `false`.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with table summary rows]()

### Export all columns in one page

Gets or sets a value indicating whether all the columns should be fitted on a page or not. To export all the columns in one page, set the`DataGridPdfExportOption.FitAllColumnsInOnePage` property to `true`.

### Exporting the grid from a specified page and point

The SfDataGrid allows exporting the data to a particular staring position on a particular PDF page using the following options:

* StartPageIndex
* StartPoint 

#### StartPageIndex 

The SfDataGrid allows exporting the data to a particular page in the PDF document by using the `DataGridPdfExportOption.StartPageIndex` property.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format at a specified page index]()

#### StartPoint

The SfDataGrid allows exporting the data to a particular x,y starting point in the PDF page by using the `DataGridPdfExportOption.StartPoint` property.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format at a specified position]()

### Applying styles while exporting

The SfDataGrid allows exporting the data with the applied GridStyle by setting the `DataGridPdfExportOption.ApplyGridStyle` property to `true`. By default, data will be exported without the GridStyle.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with style applied]()

You can also customize the following styles while exporting to PDF:

* BottomTableSummaryStyle 
* GroupCaptionStyle
* HeaderStyle
* RecordStyle 
* TopTableSummaryStyle

#### BottomTableSummaryStyle

The SfDataGrid supports exporting the bottom table summary with custom style by using the `DataGridPdfExportOption.BottomTableSummaryStyle` property.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with style applied for table summary rows at the bottom]()

#### GroupCaptionStyle

The SfDataGrid supports exporting the group caption summaries with custom style by using the `DataGridPdfExportOption.GroupCaptionStyle` property.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with style applied for group caption style]()

#### HeaderStyle

The SfDataGrid allows exporting the column headers with custom style by using the `DataGridPdfExportOption.HeaderStyle` property.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with style applied for header cells]()

#### RecordStyle 

The SfDataGrid allows exporting the records with custom style by using the `DataGridPdfExportOption.RecordStyle` property.


{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with style applied for record cells]()

#### TopTableSummaryStyle

The SfDataGrid supports exporting the top table summary with custom style by using the `DataGridPdfExportOption.TopTableSummaryStyle` property.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with style applied for table summary rows at the top]()

### GroupSummaryStyle 

`SfDataGrid` supports exporting the `GroupSummary` rows with custom style by using the `DataGridPdfExportOption.GroupSummaryStyle` property.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with style applied for group summary rows]()

### Customizing borders

The SfDataGrid allows customizing the grid borders as follows using the `DataGridPdfExportOption.GridLineType` property:

* Both
* Horizontal
* Vertical
* None

#### Both

Set the `DataGridPdfExportOption.GridLineType` as `GridLineType.Both` to export the data grid with both horizontal and vertical borders.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with both vertical and horizontal borders]()

#### Horizontal

Set the `DataGridPdfExportOption.GridLineType` as `GridLineType.Horizontal` to export the data grid with horizontal border.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with horizonatal border lines alone]()

#### Vertical

Set the `DataGridPdfExportOption.GridLineType` to `GridLineType.Vertical` to export the data grid with vertical border.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with vertical border lines alone]()

#### None

Set the `DataGridPdfExportOption.GridLineType` to `GridLineType.None` to export the data grid without borders.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format without border lines]()

## Export paging

When exporting to PDF in the SfDataGrid using SfDataPager, by default it will export only the current page. You can export all the pages by setting the `DataGridPdfExportOption.ExportAllPages` to `true`. 

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export all the pages in a DataGrid to PDF format]()

* ExportAllPages = true;

![Export only the current page in a DataGrid to PDF format]()

## Setting header and footer

The SfDataGrid provides a way to display additional content at the top (header) or bottom (footer) of the page when exporting to PDF by handling the `DataGridPdfExportingController.HeaderAndFooterExporting` event.

You can insert string in the header and footer in PdfHeaderFooterEventHandler. Setting `PdfPageTemplateElement` as `PdfHeaderFooterEventArgs.PdfDocumentTemplate.Top` loads the content at the top of the page. Setting the `PdfPageTemplateElement` as `PdfHeaderFooterEventArgs.PdfDocumentTemplate.Bottom` loads the content at the bottom of the page.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with header and footer]()

## Change PDF page orientation

You can change the page orientation of the PDF document when exporting. Default page orientation is portrait.

To change the page orientation, export PDF grid value by using the ExportToPdfGrid method. Then, draw that PDF grid into a PDF document by changing the `PageSettings.Orientation` property of PDF document.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format in Landscape orientation]()

## Saving options

### Save directly as file

### Save directly as file

The following code snippet explains how to save the converted PDF document in our local device.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

### Save as stream

You can also save the manipulated PDF document to stream by using overloads of the Save method.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

## Row height and column width customization

### ExportColumnWidth

By default, the data grid columns will be exported to PDF with `DataGridPdfExportOption.DefaultColumnWidth` value. To export the data grid to PDF with exact column widths, set the `DataGridPdfExportOption.ExportColumnWidth` to `true`.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

### ExportRowHeight

By default, the data grid rows will be exported to PDF with `DataGridPdfExportOption.DefaultRowHeight` value. To export the data grid to PDF with exact row heights, set the `DataGridPdfExportOption.ExportRowHeight` to `true`. 

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with default row height]()

### DefaultColumnWidth

The SfDataGrid allows customizing column width in the PDF document using the `DataGridPdfExportOption.DefaultColumnWidth` property. The `DefaultColumnWidth` value will be applied to all the columns in the document.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

### DefaultRowHeight

The SfDataGrid allows customizing row height in the PDF document using the `DataGridPdfExportOption.DefaultRowHeight` property. The `DefaultRowHeight` value will be applied to all the rows in the document.

{% tabs %}
{% highlight c# %}
DataGridPdfExportOption option = new DataGridPdfExportOption();
option.DefaultRowHeight = 50;
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with customized row height]()

## Events

## Exporting customization

### Styling cells based on CellType in PDF

The SfDataGrid provides you the following events for exporting:

* `RowExporting`: Raised when exporting a row at the execution time.
* `CellExporting`: Raised when exporting a cell at the execution time.

### RowExporting

The `DataGridRowPdfExportingEventHandler` delegate allows customizing the styles of record rows and group caption rows. The `RowExporting` event is triggered with `DataGridRowPdfExportingEventArgs` that contains the following properties:

* `PdfGrid`: Customizes the pdfGrid properties such as `Background`, `CellPadding`, `CellSpacing`, and so on.
* `PdfRow`: Specifies the `PDFGridRow` to be exported. Customizes the properties of a particular row. 
* `Record`: Gets the collection of exported underlying data objects.
* `RowType`: Specifies the row type using `ExportRowType` enum. Checks the row type and applies different styles based on the row type.

You can use this event to customize the properties of the grid rows exported to PDF. The following code example illustrates how to change the background color of the record rows and caption summary rows when exporting.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Customize the grid rows while exporting using the RowExporting event]()

### CellExporting

The `DataGridCellPdfExportingEventHandler` delegate allows customizing the styles for the header cells, record cells, group caption cells, and group summary cells. The `CellExporting` event is triggered with `DataGridCellPdfExportingEventArgs` that contains the following properties:

The `DataGridCellPdfExportingEventHandler` delegate allows customizing the styles for header cells, record cells, and group caption cells. The `CellExporting` event is triggered with `DataGridCellPdfExportingEventArgs` that contains the following properties:

* `CellType`: Specifies the cell type using `ExportCellType` enum. Checks the cell type and applies different cell styles based on the cell type.

* `CellValue`: Contains the exported actual value to format the PDF using the `Range` property.

* `ColumnName`: Specifies the column name (MappingName) of the exporting cell. Applies formatting for a particular column by checking the `ColumnName`.

* `Handled`: Determines whether the cell is exported to PDF or not.

* `PdfGrid`: Specifies the `PDFGridCell` to be exported. Customizes Background, Foreground, Font, Alignment, etc., properties of a particular cell.

* `Record`: Gets the collection of exported underlying data objects.

You can use this event to customize the properties of the grid cells exported to PDF. The following code example illustrates how to customize the background color, foreground color, and cell value of the header cells, record cells, and caption summary cells when exporting.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Customize the cells in a DataGrid while exporting using the CellExporting event]()

## Exporting Unbound rows

By default the unbound rows will not be exported to pdf document. However, You can export the unbound rows to PDF by setting the `DataGridPdfExportOption.ExportUnboundRows` property as `true`.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

### Exporting unbound columns

The `SfDataGrid.GridUnboundColumns` will be exported as `SfDataGrid.GridTextColumns` without any specific code. You can customize the `SfDataGrid.GridUnboundColumns` as `SfDataGrid.GridTextColumns` by using the `CellExporting` and `RowExporting` events.

{% tabs %}
{% highlight xaml %}
{% endhighlight %}
{% endtabs %}

The following screenshot shows that the unbound column is exported to PDF document with text columns.

![Export DataGrid to PDF format with unbound columns]()

### ExportGroupSummary

By default, the `GroupSummary` rows in the data grid will be exported to PDF. To export the `SfDataGrid` without group summaries, set the `DataGridPdfExportingOption.ExportGroupSummary` property to `false`.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with all columns fit in view]()

### Embedding fonts in PDF file

By default, some fonts (such as Unicode font) are not supported in PDF. In this case, embed the font in the PDF document with the help of PdfTrueTypeFont. 

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with custom font]()

## Cell customization in PDF while exporting

### Customize cell values while exporting

You can customize the cell values when exporting to PDF by handling the `CellExporting` event.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

In the following screenshot, IsClosed column value has been changed based on the condition.

![Export DataGrid to PDF format in landscape orientation]()

### Changing row style in PDF based on data

You can customize the row style based on the row data when exporting to PDF by handling the `RowExporting` event.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with customized row style]()

### Customize the cells based on column name

You can customize the column style based on the row data when exporting to PDF by handling the `CellExporting` event.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with customized cell style]()

### Exporting middle Eastern languages (Arabic and Hebrew) from SfDataGrid to PDF

By default, [Middle Eastern languages](https://en.wikipedia.org/wiki/Middle_East) (Arabic and Hebrew) in the SfDataGrid are exported as left to right in PDF. You can export them as displayed (export from right to left) by enabling the `RightToLeft` property in PdfStringFormat class and apply the format to the PdfGridCell by using `CellsExportingEventHandler`.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}


### Exporting images to PDF document

By default, images loaded in the GridTemplateColumn will not be exported to PDF. You can export it by handling the CellExporting event. In `DataGridCellPdfExportingEventHandler`, the required image is loaded in the PdfGridCell.

{% tabs %}
{% highlight c# %}
{% endhighlight %}
{% endtabs %}

![Export DataGrid to PDF format with image column]()

## Exporting the selected rows of SfDataGrid

SfDataGrid allows you to export only the currently selected rows in the grid to the document using the `DataGridPdfExportingController.ExportToPdf` method by passing the instance of the SfDataGrid and `SfDataGrid.SelectedItems` collection as an argument.

Refer the below code to export the selected rows alone to the PDF document.


![Export selected items in a DataGrid to PDF format]()

N> You can refer to our [MAUI DataGrid]() feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid example]() to knows various chart types and how to easily configured with built-in support for creating stunning visual effects.


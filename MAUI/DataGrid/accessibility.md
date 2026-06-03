---
layout: post
title: Accessibility in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Accessibility support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui accessibility, maui accessibility
---

# Accessibility in MAUI DataGrid (SfDataGrid)

SfDataGrid and SfDataPager provide built-in [AutomationId](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.element.automationid?view=net-maui-10.0) for all their inner elements. These `AutomationId` values allow automation frameworks to find and interact with inner elements when test scripts are executed. A unique `AutomationId` is maintained for each inner element by prefixing the control's `AutomationId` with the inner element's Id.

## DataGrid

The following table illustrates the predefined automation values set internally which can be used to identify SfDataGrid elements.

<table>
<tr>
<th>Element</th>
<th>Value</th>
<th>Example</th>
</tr>
<tr>
<td>Header Row</td>
<td>"Row" + RowIndex</td>
<td>Row0</td>
</tr>
<tr>
<td>Header Cell</td>
<td>"R " + RowIndex + " C " + ColumnIndex + " " + CellValue</td>
<td>R 0 C 2 Customer Name</td>
</tr>
<tr>
<td>Row</td>
<td>"Row" + RowIndex</td>
<td>Row4</td>
</tr>
<tr>
<td>Grid Cell</td>
<td>"R " + RowIndex + " C " + ColumnIndex + " " + CellValue</td>
<td>R 4 C 2 Thomas</td>
</tr>
<tr>
<td>Group Header</td>
<td>"Row" + RowIndex</td>
<td>Row5</td>
</tr>
<tr>
<td>LoadMore View</td>
<td>"LOAD MORE ITEMS"</td>
<td>LOAD MORE ITEMS</td>
</tr>
</table>

The following screenshots illustrate the `AutomationId` values of grid cells, rows, and other inner elements in SfDataGrid.

<img alt="Automation Id format for Row and Cell element in .NET MAUI DataGrid" src="Images\accessibility\maui-datagrid-automationid.png" width="404"/>

<img alt="Automation Id format for LoadMoreView in .NET MAUI DataGrid" src="Images\accessibility\maui-datagrid-loadmore-automationid.png" width="404"/>

The following code snippet demonstrates how to set the `AutomationId` to the datagrid.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}"
                       AutomationId = "SfDataGrid"
                       AllowGroupExpandCollapse = "True">

    <syncfusion:SfDataGrid.GroupColumnDescriptions>
        <syncfusion:GroupColumnDescription ColumnName = "OrderID"/>
    </syncfusion:SfDataGrid.GroupColumnDescriptions>

    <syncfusion:SfDataGrid.CaptionSummaryRow>
        <syncfusion:DataGridSummaryRow Title="Total Count of Order ID:{OrderID}"
                                       ShowSummaryInRow = "True">
            <syncfusion:DataGridSummaryRow.SummaryColumns>
                <syncfusion:DataGridSummaryColumn Name = "OrderID"
                                                  MappingName = "OrderID"
                                                  Format = "{}{Count}"
                                                  SummaryType = "CountAggregate" />
            </syncfusion:DataGridSummaryRow.SummaryColumns>
        </syncfusion:DataGridSummaryRow>
    </syncfusion:SfDataGrid.CaptionSummaryRow>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AutomationId = "SfDataGrid";
dataGrid.AllowGroupExpandCollapse = true;

dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "OrderID" });

DataGridSummaryRow summaryRow = new DataGridSummaryRow();
summaryRow.Title = "Total Count of Order ID:{OrderID}";
summaryRow.ShowSummaryInRow = true;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "OrderID",
    MappingName = "OrderID",
    Format = "{Count}",
    SummaryType = SummaryType.CountAggregate
});
dataGrid.CaptionSummaryRow = summaryRow;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

Refer to the following code snippet to access the inner elements of the datagrid from an automation script.

{% tabs %}
{% highlight c# %}
[Test]
[Description("SfDataGrid Automation Id")]
public void SfDataGrid_AutomationId()
{
    // Double tap cell (Row 4, Column 2)
    var cell = driver.FindElement(
        MobileBy.AccessibilityId("R 4 C 2 Berglund")
    );
    // Simulate double tap
    cell.Click();
    Thread.Sleep(200);
    cell.Click();


    // Expand/Collapse group
    driver.FindElement(
        MobileBy.AccessibilityId("SfDataGrid Row5")
    ).Click();

    // Sorting
    driver.FindElement(
        MobileBy.AccessibilityId("R 0 C 2 Customer")
    ).Click();

    // Load more
    driver.FindElement(
        MobileBy.AccessibilityId("SfDataGrid Load More")
    ).Click();
}
{% endhighlight %}
{% endtabs %}

## DataPager

The following table illustrates the predefined automation values set internally which can be used to identify the SfDataPager elements.

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>First page button</td>
<td>"FirstPage"</td>
</tr>
<tr>
<td>Previous page button</td>
<td>"PreviousPage"</td>
</tr>
<tr>
<td>Numeric buttons</td>
<td>
"NumericButton" + NumericButtonIndex <br/>
Example: NumericButton3
</td>
</tr>
<tr>
<td>Next page button</td>
<td>"NextPage"</td>
</tr>
<tr>
<td>Last page button</td>
<td>"LastPage"</td>
</tr>
</table>

The following screenshot illustrates the `AutomationId` values of pager buttons in SfDataPager.

<img alt="Automation Id format for DataPager in .NET MAUI DataGrid" src="Images\accessibility\maui-datagrid-datapager-automationid.png" width="404"/>

The following code snippet demonstrates how to set the AutomationId for the datapager.

{% tabs %}
{% highlight xaml %}
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height = "*" />
        <RowDefinition Height = "Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row = "1" Padding = "5">
        <pager:SfDataPager x:Name = "dataPager"
                           AutomationId = "SfDataPager"
                           PageSize = "15" 
                           NumericButtonCount = "10"
                           Source = "{Binding Orders}">
        </pager:SfDataPager>
    </Border>
    <syncfusion:SfDataGrid x:Name = "dataGrid"
                           Grid.Row = "0"
                           ItemsSource = "{Binding Source={x:Reference dataPager}, Path=PagedSource}">
    </syncfusion:SfDataGrid>
</Grid>           
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.AutomationId = "SfDataPager";
dataPager.PageSize = 15;
dataPager.NumericButtonCount = 10;
dataPager.Source = viewModel.Orders;

SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = dataPager.PagedSource;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(dataGrid);
grid.Children.Add(border);
grid.SetRow(dataGrid, 0);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

Refer to the following code snippet to access the inner elements of the datapager from an automation script.

{% tabs %}
{% highlight c# %}
[Test]
[Description("SfDataPager Automation Id")]
public void SfDataPager_AutomationId()
{
    // First page
    driver.FindElement(
        MobileBy.AccessibilityId("SfDataPager FirstPage")
    ).Click();

    // Previous page
    driver.FindElement(
        MobileBy.AccessibilityId("SfDataPager PreviousPage")
    ).Click();

    // Next page
    driver.FindElement(
        MobileBy.AccessibilityId("SfDataPager NextPage")
    ).Click();

    // Last page
    driver.FindElement(
        MobileBy.AccessibilityId("SfDataPager LastPage")
    ).Click();

    // Numeric button
    driver.FindElement(
        MobileBy.AccessibilityId("SfDataPager NumericButton5")
    ).Click();
}
{% endhighlight %}
{% endtabs %}
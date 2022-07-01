---
layout: post
title: Column Sizing in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Column Sizing support in Syncfusion MAUI DataGrid (SfDataGrid) control and more.
platform: maui
control: SfDataGrid
documentation: ug
---

# Column Sizing in .NET MAUI DataGrid (SfDataGrid)

DataGrid allows you to set the column widths based on certain logic using `SfDataGrid.ColumnWidthMode` or `DataGridColumn.ColumnWidthMode`property. Below is the list of predefined column sizing options available.

<table>
<tr>
<th>
Type
</th>
<th>
Column width
</th>
</tr>
<tr>
<td>
<code>Fill</code>
</td>
<td>
Divides the total width equally for columns. 
</td>
</tr>
<tr>
<td>
<code>Auto</code>
</td>
<td>
Calculates the width of column based on header and cell contents. So that header and cell content’s are not truncated.  
</td>
</tr>
<tr>
<td>
<code>LastColumnFill</code>
</td>
<td>
The column width of the DataGridColumns are adjusted with respect to SfDataGrid.DefaultColumnWidth property. In case the columns does not fill the entire view space, width of the last column fills the unoccupied space in the view.
</td>
</tr>
<tr>
<td>
<code>FitByCell</code>
</td>
<td>
Calculates the width of column based on cell contents. So that cell content’s are not truncated.  
</td>
</tr>
<tr>
<td>
<code>FitByHeader</code>
</td>
<td>
Calculates the width of column based on header content. So that header content is not truncated.  
</td>
</tr>
<tr>
<td>
<code>None</code>
</td>
<td>
Default column width or defined width set to column.
</td>
</tr>
</table>

N> ColumnWidthMode will not work when the column width defined explicitly. ColumnWidthMode calculates column width based on `MinimumWidth`, `MaximumWidth` and `Width` properties.

Below code, applies `ColumnWidthMode.Fill` to equally set width for `SfDataGrid.Columns`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        ColumnWidthMode="Fill"
                        ItemsSource="{Binding Orders}" />
{% endhighlight %}
{% endtabs %}

![Fill column width mode in .NET MAUI DataGrid](Images\column-sizing\maui-datagrid-fill-column-width-mode.png)


## Apply ColumnWidthMode for a particular column

To apply column sizing to individual column, use the `DataGridColumns.ColumnWidthMode` property. The `GridColumn.ColumnWidthMode` property is also a type of the `ColumnWidthMode`. If the `GridColumn.ColumnWidthMode` is not explicitly set to a value, then it takes the value of the `SfDataGrid.ColumnWidthMode`and applies width to the columns accordingly.

To apply `ColumnWidthMode` for a particular column, follow the code example:

{% tabs %}
{% highlight xaml %}
<sfgrid:SfDataGrid x:Name="dataGrid"
                   AutoGenerateColumns="True"
                   ColumnWidthMode="None">

   <syncfusion:DataGridTextColumn MappingName="CustomerID" ColumnWidthMode="Auto" HeaderText="Customer" ></syncfusion:DataGridTextColumn>
{% endhighlight %}
{% highlight c# %}
DataGridTextColumn textColumn = new DataGridTextColumn();
textColumn.MappingName = "CustomerID";
textColumn.HeaderText = "Customer";
textColumn.ColumnWithMode = ColumnWithMode.Auto;  
{% endhighlight %}
{% endtabs %}

![Invididual column width mode in .NET MAUI DataGrid](Images\column-sizing\maui-datagrid-invididual-column-width-mode.png)

## Refreshing ColumnSizer at runtime

To refresh the column sizing for `SfDataGrid.Columns` at runtime, use the `SfDataGrid.ColumnSizer.Refresh` method.

Consider that `ColumnWidthMode.Auto` is applied to the SfDataGrid. If the underlying values are changed at run time, refresh the column sizer as follows:

{% tabs %}
{% highlight xaml %}    
<StackLayout HorizontalOptions="Center" 
             Orientation="Vertical">
    <Button x:Name="button"
            Text="Refresh ColumnSizer"
            HeightRequest="100"
            HorizontalOptions="Center"
            Clicked="ColumnSizerChanged"/>
<sfgrid:SfDataGrid x:Name="dataGrid"
                   ColumnWidthMode="Auto"
                   ItemsSource="{Binding OrdersInfo}">
</sfgrid:SfDataGrid>
</StackLayout>
{% endhighlight %}
{% highlight c# %}  
private void ColumnSizerChanged(object sender, EventArgs e)
{
    //Refreshes the column sizer of the SfDataGrid
    dataGrid.ColumnSizer.Refresh(true);
}    
{% endhighlight %}
{% endtabs %} 
 

## Customize auto width calculation for a column

For cases, where a column might require more width than the applied auto width or if you want to apply your own custom logic to calculate the auto width of a column, return a desired width in the `OnComputeCellWidth()`override of the custom written column-sizer class derived from `DataGridColumnSizer` and assign it to the `SfDataGrid.ColumnSizer` property.
If in case you want to modify the auto calculations of a column's header cell alone, return a desired width in the `OnComputeHeaderCellWidth()` override of your custom column-sizer class.

{% tabs %}
{% highlight c# %}
public class CustomColumnSizer : DataGridColumnSizer
{
	protected override double OnComputeHeaderCellWidth(string cellValue, DataGridColumn column = null)
	{
		if (column.MappingName == "CustomerID")
		{
            // return width based on your logic
            return 150;	
		}
		else
		{
			return base.OnComputeHeaderCellWidth(cellValue, column);
		}
	}
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}
<ContentPage.Resources>
    <local:CustomColumnSizer x:Key="CustomColumnSizer"/>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding OrdersInfo,Mode=TwoWay}"
                        ColumnWidthMode="Auto"
                        ColumnSizer="{x:StaticResource CustomColumnSizer}">
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid.ColumnSizer  = new CustomColumnSizer();
{% endhighlight %}
{% endtabs %}

![Customize Auto Width calculation in .NET MAUI DataGrid](Images\column-sizing\maui-datagrid-customize-column-width-calculation.png)
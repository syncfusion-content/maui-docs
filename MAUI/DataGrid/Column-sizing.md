---
layout: post
title: Column Sizing in .NET MAUI DataGrid control | Syncfusion
description: Learn all about Column Sizing support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more here.
platform: maui
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui sizing, maui column sizing
---

# Column Sizing in .NET MAUI DataGrid (SfDataGrid)

The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) allows you to set the column widths based on certain logics using the [SfDataGrid.ColumnWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnWidthMode) or [DataGridColumn.ColumnWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_ColumnWidthMode) property. 

To get start quickly with column sizing in .NET MAUI DataGrid, you can check on this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src="https://www.youtube.com/embed/vtMmQIWyipU?start=243"></iframe>

Below is the list of predefined column sizing options available:

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
Calculates the width of columns based on header and cell contents so that header and cell contents are not truncated. 
</td>
</tr>
<tr>
<td>
<code>LastColumnFill</code>
</td>
<td>
The column width of the DataGridColumns is adjusted with respect to the SfDataGrid.DefaultColumnWidth property. If the columns do not fill the entire view space, the width of the last column fills the unoccupied space in the view.
</td>
</tr>
<tr>
<td>
<code>FitByCell</code>
</td>
<td>
Calculates the width of columns based on cell contents so that cell contents are not truncated. 
</td>
</tr>
<tr>
<td>
<code>FitByHeader</code>
</td>
<td>
Calculates the width of columns based on header content so that header content is not truncated.  
</td>
</tr>
<tr>
<td>
<code>None</code>
</td>
<td>
Default column width or defined width set to a column.
</td>
</tr>
</table>

N> `ColumnWidthMode` will not work when the column width is defined explicitly. The `ColumnWidthMode` calculates the column width based on [MinimumWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MinimumWidth) and [MaximumWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MaximumWidth) properties.

The code below applies the [ColumnWidthMode.Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnWidthMode.html#Syncfusion_Maui_DataGrid_ColumnWidthMode_Fill) to equally set the width for `SfDataGrid.Columns`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        ColumnWidthMode="Fill"
                        ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% endtabs %}

![Fill column width mode in .NET MAUI DataGrid](Images\column-sizing\maui-datagrid-fill-column-width-mode.png)

## Change the default column width for columns

If you want to set the common width for all the columns, you can use the [DefaultColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultColumnWidth) property.

{% tabs %}
{% highlight xaml tabtile="MainPage.xaml" %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        DefaultColumnWidth="120"
                        ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% endtabs %}

## Retrieve the auto-calculated width of columns

You can retrieve the width of the columns when it is auto-calculated based on the `ColumnWidthMode`  property using the [ActualWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_ActualWidth) property .

{% tabs %}
{% highlight xaml tabtile="MainPage.xaml" %}
<StackLayout>
    <syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       VerticalOptions="FillAndExpand"
                       ColumnWidthMode="Auto" />
    <Button Clicked="Button_Clicked"
            Text="Get Column Width" />
</StackLayout>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void Button_Clicked(object sender, EventArgs e)
{
    double width = dataGrid.Columns["OrderID"].ActualWidth;
}

{% endhighlight %}
{% endtabs %}

## Apply ColumnWidthMode for a particular column

To apply column sizing to an individual column, use the `DataGridColumn.ColumnWidthMode` property. The `DataGridColumn.ColumnWidthMode` property is also a type of the `ColumnWidthMode`. If the `DataGridColumn.ColumnWidthMode` is not explicitly set to a value, then it takes the value of the `SfDataGrid.ColumnWidthMode` and applies the width to the columns accordingly.

To apply `ColumnWidthMode` for a particular column, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       ColumnWidthMode="None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="CustomerID"
                                       ColumnWidthMode="Auto"
                                       HeaderText="Customer"></syncfusion:DataGridTextColumn>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGridTextColumn textColumn = new DataGridTextColumn();
textColumn.MappingName = "CustomerID";
textColumn.HeaderText = "Customer";
textColumn.ColumnWidthMode = ColumnWidthMode.Auto;
this.sfGrid.Columns.Add(textColumn);  
{% endhighlight %}
{% endtabs %}

![Invididual column width mode in .NET MAUI DataGrid](Images\column-sizing\maui-datagrid-invididual-column-width-mode.png)

## Refreshing ColumnSizer at runtime

To refresh the column sizing for [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) at runtime, use the [SfDataGrid.ColumnSizer.Refresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnSizer.html#Syncfusion_Maui_DataGrid_DataGridColumnSizer_Refresh_System_Boolean_) method.

Consider that [ColumnWidthMode.Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnWidthMode.html#Syncfusion_Maui_DataGrid_ColumnWidthMode_Auto) is applied to the SfDataGrid. If the underlying values are changed at run time, refresh the column sizer as follows:

{% tabs %}
{% highlight xaml %}    
<StackLayout HorizontalOptions="Center" 
             Orientation="Vertical">
    <syncfusion:SfDataGrid x:Name="dataGrid"
                       ColumnWidthMode="Auto"
                       ItemsSource="{Binding OrderInfoCollection}">
    </syncfusion:SfDataGrid>
    <Button x:Name="button"
            Text="Refresh ColumnSizer"
            HeightRequest="100"
            HorizontalOptions="Center"
            Clicked="ColumnSizerChanged" />
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

For cases where a column might require more width than the applied auto width or if you want to use your custom logic to calculate the auto width of a column, return a desired width in the [OnComputeCellWidth()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnSizer.html#Syncfusion_Maui_DataGrid_DataGridColumnSizer_OnComputeCellWidth_Syncfusion_Maui_DataGrid_DataGridColumn_System_String_) override of the custom-written column-sizer class derived from `DataGridColumnSizer` and assign it to the `SfDataGrid.ColumnSizer` property.
In case you want to modify the auto calculations of a column's header cell alone, return the desired width in the [OnComputeHeaderCellWidth()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnSizer.html#Syncfusion_Maui_DataGrid_DataGridColumnSizer_OnComputeHeaderCellWidth_System_String_Syncfusion_Maui_DataGrid_DataGridColumn_) override of your custom column-sizer class.

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
                        ItemsSource="{Binding OrderInfoCollection,Mode=TwoWay}"
                        ColumnWidthMode="Auto"
                        ColumnSizer="{x:StaticResource CustomColumnSizer}">
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid.ColumnSizer  = new CustomColumnSizer();
{% endhighlight %}
{% endtabs %}

![Customize Auto Width calculation in .NET MAUI DataGrid](Images\column-sizing\maui-datagrid-customize-column-width-calculation.png)

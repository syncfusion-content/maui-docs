---
layout: post
title: Row Height Customization in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Row Height Customization support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Row Height Customization in .NET MAUI DataGrid (SfDataGrid)

The data grid provides an option to customize the header row height and the row height of all the grid rows or a particular row. To achieve this customization, see the following sections:

## Customize HeaderRowHeight 

The data grid allows you to customize the height of the header row by setting the [SfDataGrid.HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderRowHeight) property. The default value of this property is 55. This property responds to runtime changes, so it can be customized. Setting `SfDatagrid.HeaderRowHeight` to zero will collapse the header row in the view.

To customize the header row height, follow the code example:

{% highlight c# %}
//Customizing header row height in SfDataGrid
dataGrid.HeaderRowHeight = 50; 
{% endhighlight %}

## Customize RowHeight for all rows

The data grid allows you to customize the height of grid rows in the scrolling region by setting the [SfDataGrid.RowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeight) property. The default value of this property is 47. This property responds to runtime changes, so it can be customized. Setting this property will change the height of all the rows in a body region with a common value. Setting `SfDataGrid.RowHeight` to zero will collapse all rows in the grid.

To customize header row height, follow the code example:

{% highlight c# %}
//Customizing row height in SfDataGrid
dataGrid.RowHeight = 60;
{% endhighlight %}

## QueryRowHeight

The [SfDatagrid.QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowHeight) event returns row heights on demand. This event receives two arguments, namely the sender handles the data grid, and the [DataGridQueryRowHeightEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html). The `DataGridQueryRowHeightEventArgs` has the following properties:

 * [RowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_RowIndex): This property helps to identify a particular row in the grid.
 * [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_Height): This property sets and returns the height of a grid row on demand. Default line size of the rows is 47.
 * `Handled`: This property decides whether the specified height can be set to the row or not. The default value is `false`. When this property is not set, the decided height is not set to the row.

To hook the `SfDatagrid.QueryRowHeight` event, and customize height of a row, follow the code example:

{% highlight c# %}
//Hooks QueryRowHeight event in SfDataGrid
dataGrid.QueryRowHeight += DataGrid_QueryRowHeight;

//Event to set the row height on demand
private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
{
    //Sets height of the fifth row
    if (e.RowIndex == 5)
    {
        e.Height = 100;
        e.Handled = true;
    }
} 
{% endhighlight %}

The data grid allows you to customize the height of grid rows with various customizing options while auto calculating the row height based on the content.

## Auto fit the grid rows based on content

The data grid supports the AutoRowHeight feature. The height of a row can be customized based on the content. This can be achieved using the `SfDatagrid.QueryRowHeight` event and the [SfDatagrid.GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) method. The `SfDatagrid.QueryRowHeight` event returns the row height on demand. The `SfDatagrid.GetIntrinsicRowHeight` method returns the height of the row based on the content.

To hook the `SfDatagrid.QueryRowHeight` event and auto fit the height of a row based on content, follow the code example:

{% highlight c# %}
//Hooks QueryRowHeight event in SfDataGrid to set the row height on demand
dataGrid.QueryRowHeight += DataGrid_QueryRowHeight;

private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex != 0)
    {
        //Calculates and sets the height of the row based on its content.
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
{% endhighlight %}

![MAUI DataGrid AutoFit based on row content](Images\row-height-customization\maui-datagrid-autofit.png)

### Calculate height based on certain columns

The data grid allows you to calculate the row height excluding certain columns using the `ExcludeColumns` property.

The following code example illustrates calculating the height of grid rows based on certain columns:

{% highlight c# %}
 
private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
{
   if(e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex,false,new List<string> { "Description" });        
        e.Handled = true;
    }
}
{% endhighlight %}

## Reset row height at runtime

The data grid allows you to customize the height of a grid row on demand by handling the `SfDataGrid.QueryRowHeight` event. This event is raised for the grid rows whenever they come into view. So the height of a particular row can be customized on demand using the row index. Setting the height to zero will collapse all rows in the grid. 

## Customize header row height based on header content

The data grid allows you to customize the height of the header row based on its content using the `SfDatagrid.QueryRowHeight` event and `SfDatagrid.GetIntrinsicRowHeight` method.

To hook the `SfDatagrid.QueryRowHeight` event and change the header row height based on the content, follow the code example:

{% highlight c# %}
//Hooks QueryRowHeight event in SfDataGrid to set the header row height on demand
dataGrid.QueryRowHeight += DataGrid_QueryRowHeight;

private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex == 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
{% endhighlight %}

## How to optimize performance when using QueryRowHeight event

By default, the `SfDataGrid.QueryRowHeight` event will be fired each time a row comes into view. If you want to prevent the same row from being queried again, you can check if the `Height` property in the `DataGridQueryRowHeightEventArgs` is not equal to the `SfDataGrid.RowHeight` property, which prevents the same row from being queried again. To enhance performance by preventing the same row from being queried again, follow the code example:

{% highlight c# %}
//Hooks QueryRowHeight event in DataGrid to set the row height on demand
dataGrid.QueryRowHeight += DataGrid_QueryRowHeight;

private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
{
    // Code to skip querying of a row if already queried
    if (e.Height != dataGrid.RowHeight)
        return;
    if (e.RowIndex != 0)
    {
        //Calculates and sets the height of the row based on its content.
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
{% endhighlight %}

## Limitations

When setting `SfDataGrid.ScrollingMode` to `ScrollingMode.Line`, the `SfDataGrid.QueryRowHeight` event is not supported.
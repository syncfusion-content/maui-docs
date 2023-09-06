---
layout: post
title: Row Height Customization in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Row Height Customization support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Row Height Customization in .NET MAUI DataGrid (SfDataGrid)

The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) provides an option to customize the header row height and the row height of all the grids or a particular row. To achieve this customization, see the following sections:

To get start quickly with customize the row height in .NET MAUI DataGrid, you can check on this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src="https://www.youtube.com/embed/vtMmQIWyipU?start=76"></iframe>

## Customize the header row height 

The DataGrid allows you to customize the height of the header row by setting the [SfDataGrid.HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderRowHeight) pproperty. The default value of this property is 55. This property responds to runtime changes so that it can be customized. Setting `SfDatagrid.HeaderRowHeight` to zero will collapse the header row in the view.

To customize the header row height, follow the code example:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"  ItemsSource="{Binding OrderInfoCollection }" HeaderRowHeight="60" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
//Customizing row height in SfDataGrid
dataGrid.HeaderRowHeight = 60;
{% endhighlight %}
{% endtabs %}

## Customize the row height for all data rows

The DataGrid allows you to customize the height of data rows in the scrolling region by setting the [SfDataGrid.RowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeight) property. The default value of this property is 47. This property responds to runtime changes so that it can be customized. Setting `SfDataGrid.RowHeight` to zero will collapse all rows in the grid.

To customize header row height, follow the code example:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<syncfusion:SfDataGrid x:Name="dataGrid"  ItemsSource="{Binding OrderInfoCollection }" RowHeight="60" />

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
//Customizing row height in SfDataGrid
dataGrid.RowHeight = 60;
{% endhighlight %}
{% endtabs %}

## Auto fit the data rows based on content

The height of a row can be customized based on its cell content by using the [SfDatagrid.QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowHeight) event and the [SfDatagrid.GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) method. The `SfDatagrid.QueryRowHeight` event returns the row height on demand. The `SfDatagrid.GetIntrinsicRowHeight` method returns the height of the row based on the content.

The [GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) method provides some properties to customize the autofit calculation,

`excludedColumns`  – By default, the `GetIntrinsicRowHeight` method calculates the row height based on all columns. To skip the specific columns from the row height calculation, add that column’s [DataGridColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MappingName) to the excludeColumns collection.

`canIncludeHiddenColumns`  – The hidden columns ([DataGridColumn.visible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Visible) is false) can also be considered for the row height calculation by setting the canIncludeHiddenColumns as true.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid" >

    <syncfusion:SfDataGrid x:Name="dataGrid"  ItemsSource="{Binding OrderInfoCollection }" QueryRowHeight="DataGrid_QueryRowHeight" />

</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
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
{% endtabs %}


![MAUI DataGrid AutoFit based on row content](Images\row-height-customization\maui-datagrid-autofit.png)

### Calculate height based on certain columns

The datagrid allows you to calculate the row height excluding certain columns using the [ExcludeColumns]() property which is available as argument in `GetIntrinsicRowHeight` method.

The following code example illustrates calculating the height of grid rows based on certain columns:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid" >

    <syncfusion:SfDataGrid x:Name="dataGrid"  ItemsSource="{Binding OrderInfoCollection }" QueryRowHeight="DataGrid_QueryRowHeight" />

</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
{
    if(e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex,false,new List<string> { "Description" });        
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}


## Customize header row height based on header content

The DataGrid allows you to customize the height of the header row based on its content using the `SfDatagrid.QueryRowHeight` event and `SfDatagrid.GetIntrinsicRowHeight` method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid" >

    <syncfusion:SfDataGrid x:Name="dataGrid"  ItemsSource="{Binding OrderInfoCollection }" QueryRowHeight="DataGrid_QueryRowHeight" />

</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex == 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}
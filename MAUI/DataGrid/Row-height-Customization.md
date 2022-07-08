---
layout: post
title: Row Height Customization in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Row Height Customization support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Row Height Customization in .NET MAUI DataGrid (SfDataGrid)

The DataGrid provides an option to customize the header row height and the row height of all the grid rows or a particular row. To achieve this customization, see the following sections:

## Customize the header row height 

The DataGrid allows you to customize the height of the header row by setting the [SfDataGrid.HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderRowHeight) property. The default value of this property is 55. This property responds to runtime changes, so it can be customized. Setting `SfDatagrid.HeaderRowHeight` to zero will collapse the header row in the view.

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

The DataGrid allows you to customize the height of data rows in the scrolling region by setting the [SfDataGrid.RowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeight) property. The default value of this property is 47. This property responds to runtime changes, so it can be customized. Setting `SfDataGrid.RowHeight` to zero will collapse all rows in the grid.

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

* [RowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_RowIndex): This property helps to identify a particular row in the grid.
* [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_Height): This property sets and returns the height of a grid row on demand. Default line size of the rows is 50.
* `Handled`: This property decides whether the specified height can be set to the row or not. The default value is false. When this property is not set, the decided height is not set to the row.

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

The datagrid allows you to calculate the row height excluding certain columns using the `ExcludeColumns` property which is available as argument in `GetIntrinsicRowHeight` method.

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
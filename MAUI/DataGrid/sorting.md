---
layout: post
title: Sorting in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Sorting support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Sorting in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) provides the built-in support to sort one or more columns by using the [SfDataGrid.SortingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingMode) property. When sorting is applied, the data grid automatically rearranges the data to match the current sort criteria. Sort the data by tapping the column header. Once sorting is applied, the data grid shows a sort icon in the respective column header indicating the sort direction.

To get start quickly with sorting in .NET MAUI DataGrid, you can check on this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/5PhyEYLbGT4'></iframe>

## Programmatic sorting

Sort the data programmatically by adding or removing the [SortColumnDescription](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SortColumnDescription.html) in [SfDataGrid.SortColumnDescriptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortColumnDescriptions) property.

The `SortColumnDescription` object holds the following two properties:

* **ColumnName**: The name of a column to be sorted.
* **SortDirection**: An object of type [ListSortDirection](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.listsortdirection?view=net-6.0) defines the sorting direction.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" ItemsSource="{Binding OrderInfoCollection}" >

    <syncfusion:SfDataGrid.SortColumnDescriptions>
        <syncfusion:SortColumnDescription ColumnName="OrderID" SortDirection="Ascending" />
    </syncfusion:SfDataGrid.SortColumnDescriptions>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

![Programmatical sorting .NET MAUI DataGrid](Images\sorting\maui-datagrid-programmatic-sorting.png)

## Different modes of sorting

`SfDataGrid` sorts the data against one or more columns based on the `SfDataGrid.SortingMode` property. The `SortingMode` contains the following properties:

* **Single** - It allows to sort only one column at a time.
* **Multiple** - It allows to sort more than one column at a time.
* **None** - None of the columns can be sorted.

To apply the sort for multiple columns, tap the desired column headers after setting the `SfDataGrid.SortingMode` property to [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionMode.html#Syncfusion_Maui_DataGrid_DataGridSelectionMode_Multiple).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" SortingMode="Multiple" ItemsSource="{Binding OrderInfoCollection}" >
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

![Multi sorting .NET MAUI DataGrid](Images\sorting\maui-datagrid-multi-sorting.gif)

## Tri-state sorting

In addition, to sort the data in ascending or descending order, the SfDataGrid unsort the data in the original order by clicking the header again after sorting to descending order by setting the [SfDataGrid.AllowTriStateSorting](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowTriStateSorting) property to true. When this property is set, sorting in each column iterates through three sort states; ascending, descending, and unsort.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" SortingMode="Single" AllowTriStateSorting="True" ItemsSource="{Binding OrderInfoCollection}" >
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

![Tri-state sorting .NET MAUI DataGrid](Images\sorting\maui-datagrid-tristate-sorting.gif)

## Show sort number

The `SfDataGrid` provides support to display the sequence numbers to denote the order of the column in which they are sorted during multiple columns sorting by setting the [SfDataGrid.ShowSortNumbers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowSortNumbers) is set to true. This is applicable when the `SfDataGrid.SortingMode` property is `Multiple`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" SortingMode="Multiple" ShowSortNumbers="True" ItemsSource="{Binding OrderInfoCollection}" >
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

![Sort with sequence numbers .NET MAUI DataGrid](Images\sorting\maui-datagrid-show-sort-numbers.png)

## Sort column in double tap

By default, the column gets sorted when the column header is clicked. This behavior can be changed to sort the column in a double-click action by setting the [SfDataGrid.SortingGestureType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingGestureType) property to [DoubleTap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingGestureType.html#Syncfusion_Maui_DataGrid_DataGridSortingGestureType_DoubleTap).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" SortingMode="Single" SortingGestureType="DoubleTap" ItemsSource="{Binding OrderInfoCollection}" >
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

## Sorting events

The data grid provides the following events for the sorting functionality:

* [SortColumnsChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionChanging): This event is invoked while sorting the column at execution time before the column gets sorted. It helps to `cancel` the sorting action by setting the Cancel property of the [DataGridSortColumnsChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortColumnsChangingEventArgs.html).
* [SortColumnsChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionChanged): This event is invoked after the column is sorted.
These two events are triggered with the `DataGridSortColumnsChangingEventArgs` and [DataGridSortColumnsChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortColumnsChangedEventArgs.html) that contains the following properties:

**AddedItems**: Gets the collection of the `SortColumnDescription` objects that are added to the `SortColumnDescriptions` collection for sorting.
**RemovedItems**: Gets the collection of the `SortColumnDescription` objects that are removed from the `SortColumnDescriptions` collection.

The following code sample demonstrates how to cancel sorting for a particular column by using the `SortColumnsChanging` event,

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" SortingMode="Single" SortColumnsChanging="sfDataGrid_SortColumnsChanging" ItemsSource="{Binding OrderInfoCollection}" >
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
private void sfDataGrid_SortColumnsChanging(object sender, DataGridSortColumnsChangingEventArgs e)
{
    if (e.AddedItems[0].ColumnName == "OrderID")
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Disable sorting for auto generated columns

During auto-generating columns, disable sorting for an individual column by customizing the `e.Column.AllowSorting` property to false that comes from the `SfDataGrid.AutoGeneratingColumn` event. The event will be invoked when the column is auto-generated.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" AutoGeneratingColumn="sfDataGrid_AutoGeneratingColumn" SortingMode="Single" ItemsSource="{Binding OrderInfoCollection}" >
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
private void sfDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgse)
{
    if (e.Column.MappingName == "OrderID")
    {
        e.Column.AllowSorting = false;
    }
}
{% endhighlight %}
{% endtabs %}

## Disable sorting for manually defined columns

The `SfDataGrid` disables sorting for an individual column by setting the [DataGridColumn.AllowSorting](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_AllowSorting) property to false. The default value of this property is true.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="sfDataGrid" AutoGenerateColumnsMode="None" SortingMode="Single"ItemsSource="{Binding OrderInfoCollection}" >
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn HeaderText="Order ID" AllowSorting="False" MappingName="OrderID" />
        <syncfusion:DataGridTextColumn HeaderText="Customer ID" MappingName="CustomerID" />
        <syncfusion:DataGridTextColumn HeaderText="Customer" MappingName="Customer" />
        <syncfusion:DataGridTextColumn HeaderText="Ship City" MappingName="ShipCity" />
        <syncfusion:DataGridTextColumn HeaderText="Ship Country" MappingName="ShipCountry" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

## Custom sorting

The `SfDataGrid` provides support to sort columns based on custom logic when the standard sorting techniques do not meet the requirements [SortComparer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.SortComparer.html) objects to the [SfDataGrid.SortComparers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortComparers) collection.

The `SortComparer` object contains the following properties:

* **PropertyName**: The `MappingName` of the column that applies custom sorting.
* **Comparer**: Gets or sets the custom comparer that implements the [IComparer](https://learn.microsoft.com/en-us/dotnet/api/system.collections.icomparer?view=net-6.0) and [ISortDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISortDirection.html) interfaces.

The following example shows how to sort the columns based on the length of their cell values:

{% tabs %}
{% highlight xaml %}
<ContentPage
             xmlns:comparer="clr-namespace:GettingStarted.Comparer"
             xmlns:data="clr-namespace:Syncfusion.Maui.Data;assembly=Syncfusion.Maui.Data"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid">

    <ContentPage.Resources>
        <ResourceDictionary>
            <comparer:CustomSortComparer x:Key="comparer" />
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

    <syncfusion:SfDataGrid x:Name="sfDataGrid"  SortingMode="Single" ItemsSource="{Binding OrderInfoCollection}" >
        <syncfusion:SfDataGrid.SortComparers>
            <data:SortComparer Comparer="{StaticResource comparer}" PropertyName="CustomerID" />
        </syncfusion:SfDataGrid.SortComparers>

        <syncfusion:SfDataGrid.SortColumnDescriptions>
            <syncfusion:SortColumnDescription ColumnName="CustomerID" SortDirection="Ascending"/>
        </syncfusion:SfDataGrid.SortColumnDescriptions>
    </syncfusion:SfDataGrid>
</ContentPage>
{% endhighlight %}

{% highlight c# %}
public class CustomSortComparer : IComparer<object>, ISortDirection
{
    private int nameX;
    private int nameY;

    private ListSortDirection sortDirection;

    public ListSortDirection SortDirection
    {
        get { return this.sortDirection; }
        set { this.sortDirection = value; }
    }

    public int Compare(object x, object y)
    {
        if (x!.GetType() == typeof(OrderInfo))
        { 
            this.nameX = ((OrderInfo)x!).CustomerID.Length;
            this.nameY = ((OrderInfo)y!).CustomerID.Length;
        }
        else
        {
            this.nameX = x.ToString()!.Length;
            this.nameY = y!.ToString()!.Length;
        }
        if (this.nameX.CompareTo(this.nameY) > 0)
        {
            return this.SortDirection == ListSortDirection.Ascending ? 1 : -1;
        }
        else if (this.nameX.CompareTo(this.nameY) == -1)
        {
            return this.SortDirection == ListSortDirection.Ascending ? -1 : 1;
        }
        else
        {
            return 0;
        }
    }
}
{% endhighlight %}
{% endtabs %}

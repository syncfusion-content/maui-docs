---
layout: post
title: Sorting in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to sort data in Syncfusion® .NET MAUI Tree Grid, including single-column, multi-column, and custom sorting options.
platform: MAUI
control: SfTreeGrid
documentation: UG
keywords : maui treegrid, maui tree grid, .net maui treegrid, .net maui tree grid, maui hierarchical grid, maui tree view grid, maui sorting, .net maui sorting, treegrid sorting, maui treegrid sorting
---

# Sorting in .NET MAUI Tree Grid

The `SfTreeGrid` provides built-in support for sorting one or more columns using the `SfTreeGrid.SortingMode` property. When sorting is applied to a column, the parent records and their child nodes are automatically sorted according to the specified sort criteria while preserving the hierarchical structure of the Tree Grid. You can sort data by tapping the column header. Once sorting is applied, the Tree Grid displays a sort icon in the corresponding column header to indicate the sort direction.


## Programmatic sorting

Sort the data programmatically by adding or removing the `SortColumnDescription` in `SfTreeGrid.SortColumnDescriptions` property.

The `SortColumnDescription` object holds the following two properties:

* **ColumnName**: The name of the column to be sorted.
* **SortDirection**: An object of type [ListSortDirection](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.listsortdirection?view=net-6.0) that defines the sorting direction.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children">
    
    <syncfusion:SfTreeGrid.SortColumnDescriptions>
        <syncfusion:SortColumnDescription ColumnName="FirstName"
                                          SortDirection="Ascending"/>
    </syncfusion:SfTreeGrid.SortColumnDescriptions>

</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "FirstName", SortDirection = System.ComponentModel.ListSortDirection.Ascending });
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Programmatical sorting .NET MAUI Tree Grid" src="Images\sorting\maui-treegrid-programmatic-sorting.png" width="404">

## Different modes of sorting

The `SfTreeGrid` sorts the data against one or more columns based on the `SfTreeGrid.SortingMode` property. The `SortingMode` contains the following properties:

* **Single** - It allows to sort only one column at a time.
* **Multiple** - It allows to sort more than one column at a time.
* **None** - Does not allow any column to be sorted.

To apply sorting to multiple columns, tap the desired column headers after setting the `SfTreeGrid.SortingMode` property to `Multiple`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Multiple">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortingMode = TreeGridSortingMode.Multiple;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Multi sorting .NET MAUI Data Grid" src="Images\sorting\maui-treegrid-multi-sorting.png" width="404">

## Tri-state sorting

In addition, to sort the data in ascending or descending order, the SfTreeGrid allows you to unsort the data to its original order by clicking the header again after sorting in descending order by setting the `SfTreeGrid.AllowTriStateSorting` property to `true`. When this property is set, sorting in each column iterates through three sort states: `ascending`, `descending`, and `unsorted`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Single"
                       AllowTriStateSorting="True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortingMode = TreeGridSortingMode.Single;
treeGrid.AllowTriStateSorting = true;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Show sort number

The `SfTreeGrid` provides support to display the sequence numbers to denote the order of the column in which they are sorted during multiple columns sorting by setting the `SfTreeGrid.ShowSortNumbers` is set to `true`. This is applicable when the `SfTreeGrid.SortingMode` property is `Multiple`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Multiple"
                       ShowSortNumbers="True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortingMode = TreeGridSortingMode.Multiple;
treeGrid.ShowSortNumbers = true;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Sort with sequence numbers .NET MAUI Data Grid" src="Images\sorting\maui-treegrid-show-sort-numbers.png" width="404">

## Sort column in double tap

By default, the column gets sorted when the column header is clicked. This behavior can be changed to sort the column in a double-click action by setting the `SfTreeGrid.SortingGestureType` property to `DoubleTap`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Single"
                       SortingGestureType="DoubleTap">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortingMode = TreeGridSortingMode.Single;
treeGrid.SortingGestureType = TreeGridSortingGestureType.DoubleTap;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Sorting events

The tree grid provides the following events for the sorting functionality:

* `SortColumnsChanging`: This event is invoked while sorting the column at execution time before the column gets sorted. It helps to cancel the sorting action by setting the `Cancel` property of the `TreeGridSortColumnsChangingEventArgs`.
* `SortColumnsChanged`: This event is invoked after the column is sorted.
These two events are triggered with the `TreeGridSortColumnsChangingEventArgs` and `TreeGridSortColumnsChangedEventArgs` that contains the following properties:

**AddedItems**: Gets the collection of the `SortColumnDescription` objects that are added to the `SortColumnDescriptions` collection for sorting.

**RemovedItems**: Gets the collection of the `SortColumnDescription` objects that are removed from the `SortColumnDescriptions` collection.

The following code sample demonstrates how to cancel sorting for a particular column by using the `SortColumnsChanging` event,

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Single"
                       SortColumnsChanging="treeGrid_SortColumnsChanging">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
private void treeGrid_SortColumnsChanging(object sender, TreeGridSortColumnsChangingEventArgs e)
{
    var addedItem = e.AddedItems?.Cast<SortColumnDescription>().LastOrDefault();

    if (addedItem?.ColumnName == "FirstName")
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Disable sorting for auto generated columns

During auto-generating columns, disable sorting for an individual column by customizing the `e.Column.AllowSorting` property to false that comes from the `SfTreeGrid.AutoGeneratingColumn` event. The event will be invoked when the column is auto-generated.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Single"
                       AutoGeneratingColumn="treeGrid_AutoGeneratingColumn">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
private void treeGrid_AutoGeneratingColumn(object sender, TreeGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "FirstName")
    {
        e.Column.AllowSorting = false;
    }
}
{% endhighlight %}
{% endtabs %}

## Disable sorting for manually defined columns

To disable sorting for an individual column, set the `TreeGridColumn.AllowSorting` property to false. The default value of this property is `true`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Single"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="First Name"
                                       MappingName="FirstName"
                                       AllowSorting="False"/>
        <syncfusion:TreeGridTextColumn HeaderText="Last Name"
                                       MappingName="LastName"/>
        <syncfusion:TreeGridTextColumn HeaderText="Employee ID"
                                       MappingName="EmployeeID"/>        
        <syncfusion:TreeGridTextColumn HeaderText="Salary"
                                       MappingName="Salary"/>
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortingMode = TreeGridSortingMode.Single;
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "FirstName", HeaderText = "First Name", AllowSorting = false });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "LastName", HeaderText = "Last Name" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "EmployeeID", HeaderText = "Employee ID" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "Salary", HeaderText = "Salary" });
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Custom sorting

The `SfTreeGrid` provides support to sort columns based on custom logic when the standard sorting techniques do not meet the requirements. Custom sorting can be achieved by adding `SortComparer` objects to the `SfTreeGrid.SortComparers` collection.

The `SortComparer` object contains the following properties:

* **PropertyName**: The `MappingName` of the column that applies custom sorting.
* **Comparer**: Gets or sets the custom comparer that implements the [IComparer](https://learn.microsoft.com/en-us/dotnet/api/system.collections.icomparer?view=net-6.0) and [ISortDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISortDirection.html) interfaces.

The following example shows how to sort the columns based on the length of their cell values:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:comparer="clr-namespace:GettingStarted.Comparer"
             xmlns:data="clr-namespace:Syncfusion.Maui.Data;assembly=Syncfusion.Maui.Data"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid">

    <ContentPage.Resources>
        <ResourceDictionary>
            <comparer:CustomSortComparer x:Key="comparer"/>
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.BindingContext>
        <local:EmployeeViewModel/>
    </ContentPage.BindingContext>

    <syncfusion:SfTreeGrid x:Name="treeGrid"
                           ItemsSource="{Binding PersonDetails}"
                           ChildPropertyName="Children"
                           SortingMode="Single">

        <syncfusion:SfTreeGrid.SortComparers>
            <data:SortComparer Comparer="{StaticResource comparer}"
                               PropertyName="LastName"/>
        </syncfusion:SfTreeGrid.SortComparers>

        <syncfusion:SfTreeGrid.SortColumnDescriptions>
            <syncfusion:SortColumnDescription ColumnName="LastName"
                                              SortDirection="Ascending"/>
        </syncfusion:SfTreeGrid.SortColumnDescriptions>

    </syncfusion:SfTreeGrid>

</ContentPage>
{% endhighlight %}
{% highlight c# %}
using System;
using System.Collections;
using System.ComponentModel;
using Syncfusion.Maui.Data;

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

    public int Compare(object? x, object? y)
    {
        if (x == null || y == null)
            return 0;

        if (x is EmployeeInfo employeeX && y is EmployeeInfo employeeY)
        {
            this.nameX = employeeX.LastName?.Length ?? 0;
            this.nameY = employeeY.LastName?.Length ?? 0;
        }
        else
        {
            this.nameX = x.ToString()?.Length ?? 0;
            this.nameY = y.ToString()?.Length ?? 0;
        }

        int result = this.nameX.CompareTo(this.nameY);

        if (result > 0)
        {
            return this.SortDirection == ListSortDirection.Ascending ? 1 : -1;
        }
        else if (result == -1)
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

## Change sort icon color

The default sort icon color can be customized by setting the `TreeGridStyle.SortIconColor` property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children">

    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle SortIconColor="DodgerBlue"/>
    </syncfusion:SfTreeGrid.DefaultStyle>

    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="First Name"
                                       MappingName="FirstName"
                                       AllowSorting="True"/>
        <syncfusion:TreeGridTextColumn HeaderText="Last Name"
                                       MappingName="LastName"/>
        <syncfusion:TreeGridTextColumn HeaderText="Employee ID"
                                       MappingName="EmployeeID"/>
        <syncfusion:TreeGridTextColumn HeaderText="Salary"
                                       MappingName="Salary"/>
    </syncfusion:SfTreeGrid.Columns>

</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.DefaultStyle.SortIconColor = Colors.DodgerBlue;
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "FirstName", HeaderText = "First Name", AllowSorting = true });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "LastName", HeaderText = "Last Name" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "EmployeeID", HeaderText = "Employee ID" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "Salary", HeaderText = "Salary" });
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}


<img alt="Sort icon customization in MAUI Data Grid" src="Images\sorting\maui-treegrid-sort-icon-color.png" width="404">


## Load sort icon through template

The SfTreeGrid uses an icon to indicate the ascending and descending states of sorting. You can personalize the sorting icon by using the `SfTreeGrid.SortIconTemplate` property. This property allows you to define a custom template that appears in its regular form when the sort is in ascending order. It will rotate downward when the sort is in descending order. To implement this, refer to the following code snippet:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Multiple">

    <syncfusion:SfTreeGrid.SortIconTemplate>
        <DataTemplate>
            <Image Source="expand_icon.png"/>
        </DataTemplate>
    </syncfusion:SfTreeGrid.SortIconTemplate>

</syncfusion:SfTreeGrid>                      
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortingMode = TreeGridSortingMode.Multiple;
treeGrid.SortIconTemplate = new DataTemplate(() =>
{
    var imageView = new Image()
    {
        Source = "expand_icon.png",
        Aspect = Aspect.AspectFit,
    };
    return imageView;
});
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid with sort icon template" src="Images\sorting\maui-treegrid-sort-icon-template.png" width="404">

## Load sort icon through template selector

When choosing a `SortIconTemplate` as a DataTemplateSelector, you have the option to supply distinct templates for both the ascending and descending states of the sorting.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel/>
</ContentPage.BindingContext>

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="Descending">
            <Image>
                <Image.Source>
                    <FontImageSource Color="Red"
                                     Glyph="&#xe701;"
                                     FontFamily="{OnPlatform iOS=MauiMaterialAssets, MacCatalyst=MauiMaterialAssets, WinUI=MauiMaterialAssets.ttf#, Android=MauiMaterialAssets.ttf#}"
                                     Size="44"/>
                </Image.Source>
            </Image>
        </DataTemplate>
        <DataTemplate x:Key="Ascending">
            <Image>
                <Image.Source>
                    <FontImageSource Color="Green"
                                     Glyph="&#xe702;"
                                     FontFamily="{OnPlatform iOS=MauiMaterialAssets, MacCatalyst=MauiMaterialAssets, WinUI=MauiMaterialAssets.ttf#, Android=MauiMaterialAssets.ttf#}"
                                     Size="44"/>
                </Image.Source>
            </Image>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Multiple">

    <syncfusion:SfTreeGrid.SortIconTemplate>
        <local:SortIconTemplate AscendingTemplate="{StaticResource Ascending}"
                                DescendingTemplate="{StaticResource Descending}"/>
    </syncfusion:SfTreeGrid.SortIconTemplate>

</syncfusion:SfTreeGrid>                  
{% endhighlight %}
{% highlight c# %}
public class SortIconTemplate : DataTemplateSelector
{
    public DataTemplate? AscendingTemplate { get; set; }

    public DataTemplate? DescendingTemplate { get; set; }

    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        var description = item as SortColumnDescription;
        if (description == null)
        {
            return null;
        }

        if (description.SortDirection == System.ComponentModel.ListSortDirection.Ascending)
        {
            return AscendingTemplate;
        }
        else
        {
            return DescendingTemplate;
        }
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid with sort template selector" src="Images\sorting\maui-treegrid-sort-template-selector.png" width="404">


> **Note:**
* When using data template selector, performance issues occur as the conversion template views take time within the framework.

## Customize the size of sort icon

The size of the sort icon can be customized when the icon is loaded through `SortIconTemplate` by setting the `HeightRequest` and `WidthRequest`. To implement this, please refer the following code snippet:

{% tabs %}

{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       SortingMode="Multiple">

    <syncfusion:SfTreeGrid.SortIconTemplate>
        <DataTemplate>
            <Image Source="sort_icon.png"
                   HeightRequest="20"
                   WidthRequest="20"/>
        </DataTemplate>
    </syncfusion:SfTreeGrid.SortIconTemplate>

</syncfusion:SfTreeGrid>                       
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel employeeViewModel = new EmployeeViewModel();
treeGrid.ItemsSource = employeeViewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.SortingMode = TreeGridSortingMode.Multiple;
treeGrid.SortIconTemplate = new DataTemplate(() =>
{
    var imageView = new Image()
    {
        Source = "sort_icon.png",
        Aspect = Aspect.AspectFit,
        HeightRequest = 20,
        WidthRequest = 20,
    };
    return imageView;
});
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}


<img alt="TreeGrid with sort icon size" src="Images\sorting\maui-treegrid-sort-icon-size.png" width="404">
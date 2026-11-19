---
layout: post
title: Empty View in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to display and customize an empty view in Syncfusion® .NET MAUI Tree Grid when no hierarchical data is available to display.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, empty view, treegrid empty view, maui treegrid emptyview
---

# Empty View in .NET MAUI Tree Grid

The [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) provides options to display and customize an empty view when no data is available to display using the following properties. The EmptyView is displayed only when the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_ItemsSource) is null or contains no items; it is hidden when data is present.

* [EmptyView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_EmptyView): An object that can be set to a string or view when `SfTreeGrid` has no items. The default value is null.
* [EmptyViewTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_EmptyViewTemplate): A [DataTemplate](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.datatemplate) used to customize the appearance and layout of the `EmptyView`. The default value is null.

## Display a string when TreeGrid has no items

You can set the `EmptyView` property to a string that will be displayed when the `ItemsSource` property is null or when the bound collection contains no items.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportsTo"
                       ParentPropertyName="ID"
                       SelfRelationRootValue="-1"
                       EmptyView="No records found">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportsTo";
treeGrid.ParentPropertyName = "ID";
treeGrid.SelfRelationRootValue = -1;
treeGrid.EmptyView = "No records found";
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Display views when TreeGrid has no items

The `EmptyView` property can also be set to any custom [.NET MAUI View](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.view), such as a layout containing icons, labels, or buttons. This view is displayed whenever the `ItemsSource` is null or empty.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportsTo"
                       ParentPropertyName="ID"
                       SelfRelationRootValue="-1">
    <syncfusion:SfTreeGrid.EmptyView>
        <StackLayout HorizontalOptions="Center"
                     VerticalOptions="Center"
                     Spacing="10">
            <Label Text="&#xE7A4;"
                   FontSize="28"
                   TextColor="Gray"
                   FontFamily="MauiMaterialAssets.ttf"
                   HorizontalOptions="Center"/>
            <Label Text="No records to display"
                   FontSize="16"
                   TextColor="Gray"
                   HorizontalOptions="Center"/>
        </StackLayout>
    </syncfusion:SfTreeGrid.EmptyView>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportsTo";
treeGrid.ParentPropertyName = "ID";
treeGrid.SelfRelationRootValue = -1;

StackLayout stackLayout = new StackLayout() 
{ 
    HorizontalOptions = LayoutOptions.Center, 
    VerticalOptions = LayoutOptions.Center,
    Spacing = 10 
};

var iconLabel = new Label()
{
    Text = "\uE7A4",
    FontSize = 28,
    TextColor = Colors.Gray,
    FontFamily = "MauiMaterialAssets.ttf",
    HorizontalOptions = LayoutOptions.Center,
};

var textLabel = new Label()
{
    Text = "No records to display",
    FontSize = 16,
    TextColor = Colors.Gray,
    HorizontalOptions = LayoutOptions.Center,
};

stackLayout.Children.Add(iconLabel);
stackLayout.Children.Add(textLabel);

treeGrid.EmptyView = stackLayout;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

> **Note:** The `EmptyView` can be a single view (such as an `Image` or `Label`) or a layout container with multiple child controls.

## Display a DataTemplate when TreeGrid has no items

### Using EmptyViewTemplate with Custom Binding

For dynamic scenarios such as filtering or searching hierarchical data, you can set the `EmptyView` to a custom object and bind it to a dynamic property (e.g., search text). The `EmptyViewTemplate` then defines how this object is visually presented when no records match the criteria or when the data source is empty.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"
             xmlns:local="clr-namespace:YourAppNamespace"
             x:Class="YourAppNamespace.MainPage">

    <StackLayout>
        <SearchBar x:Name="filterText"
                   FontSize="16"
                   Placeholder="Filter Employees"
                   WidthRequest="250"
                   Margin="0,0,0,10"/>

        <syncfusion:SfTreeGrid x:Name="treeGrid"
                               ItemsSource="{Binding Employees}"
                               ChildPropertyName="ReportsTo"
                               ParentPropertyName="ID"
                               SelfRelationRootValue="-1">
            <syncfusion:SfTreeGrid.EmptyView>
                <local:FilterItem Filter="{Binding Source={x:Reference filterText}, Path=Text}"
                                  x:Name="filter"/>
            </syncfusion:SfTreeGrid.EmptyView>
            <syncfusion:SfTreeGrid.EmptyViewTemplate>
                <DataTemplate>
                    <Label Text="{Binding Source={x:Reference filterText}, Path=Text, StringFormat='No matching records found for &quot;{0}&quot;'}"
                           TextColor="Gray"
                           HorizontalTextAlignment="Center"
                           VerticalOptions="Center"
                           FontSize="15"
                           FontFamily="Roboto-Regular"/>
                </DataTemplate>
            </syncfusion:SfTreeGrid.EmptyViewTemplate>
        </syncfusion:SfTreeGrid>
    </StackLayout>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
StackLayout stackLayout = new StackLayout();

// SearchBar for filtering
var filterText = new SearchBar()
{
    FontSize = 16,
    Placeholder = "Filter Employees",
    WidthRequest = 250,
    Margin = new Thickness(0, 0, 0, 10),
};

// Initialize SfTreeGrid
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportsTo";
treeGrid.ParentPropertyName = "ID";
treeGrid.SelfRelationRootValue = -1;

// Define custom EmptyView object
var filterItem = new FilterItem();
filterItem.SetBinding(
    FilterItem.FilterProperty,
    new Binding(
        path: nameof(SearchBar.Text),
        source: filterText
    )
);

treeGrid.EmptyView = filterItem;

// Define EmptyViewTemplate
treeGrid.EmptyViewTemplate = new DataTemplate(() =>
{
    var label = new Label
    {
        TextColor = Colors.Gray,
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalOptions = LayoutOptions.Center,
        FontSize = 15,
        FontFamily = "Roboto-Regular"
    };

    label.SetBinding(
        Label.TextProperty,
        new Binding(
            path: nameof(SearchBar.Text),
            source: filterText,
            stringFormat: "No matching records found for \"{0}\""
        )
    );

    return label;
});

stackLayout.Children.Add(filterText);
stackLayout.Children.Add(treeGrid);
this.Content = stackLayout;
{% endhighlight %}
{% endtabs %}

The `FilterItem` class defines a bindable property for the filter text:

{% tabs %}
{% highlight c# tabtitle="FilterItem.cs" %}
public class FilterItem : BindableObject
{
    public static readonly BindableProperty FilterProperty = 
        BindableProperty.Create(nameof(Filter), typeof(string), typeof(FilterItem), null);

    public string Filter
    {
        get { return (string)GetValue(FilterProperty); }
        set { SetValue(FilterProperty, value); }
    }
}
{% endhighlight %}
{% endtabs %}

> **Note:** Place the `FilterItem.cs` file in your application's project directory or under a `Models` folder alongside your pages.

In this scenario, a `FilterItem` object is assigned to the `EmptyView` property, and its `Filter` property is bound to the `SearchBar.Text` property. When filtering results in no visible tree nodes, the `EmptyViewTemplate` is rendered with the dynamic search term.

## Supported Combinations

### Works With:
* **Self-Relational Data Binding**: Works seamlessly when the root node collection is empty or null.
* **Nested Hierarchy Data Binding**: Displays empty view when the parent collection contains no child records.
* **Filtering**: Automatically displays the empty view when filter predicates filter out all records in the view.
* **Styling**: Operates independently of column or cell style configurations.

### Known Limitations:
* `EmptyView` and `EmptyViewTemplate` are only rendered when `ItemsSource` is `null` or contains zero items.
* If both `EmptyView` and `EmptyViewTemplate` are configured, `EmptyViewTemplate` takes precedence in determining the visual presentation of the data passed via `EmptyView`.

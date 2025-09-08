---
layout: post
title: EmptyView in .NET MAUI TreeView Control | Syncfusion
description: Learn here about EmptyView support in Syncfusion .NET MAUI TreeView (SfTreeView) Control and more about it.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Empty view in .NET MAUI TreeView (SfTreeView)

The [SfTreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html) control allows you to display and customize the empty view content when no data is available. The [EmptyView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EmptyView) property can be set to either a string or a view, and it will be displayed when the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource) is empty or null, or the [Nodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes) collection is empty. [EmptyViewTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EmptyViewTemplate) is used to customize the appearance of `EmptyView`.

## Display a string when TreeView has no items

The `EmptyView` property in `SfTreeView` can be set to a string, which will be displayed when no items are present in the tree view.

{% tabs %}
{% highlight xaml hl_lines="3" %}
  <syncfusion:SfTreeView x:Name="treeView"
                         ItemsSource="{Binding Items}"
                         EmptyView="No Items">
  </syncfusion:SfTreeView>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="3" %}
SfTreeView treeView = new SfTreeView();
treeView.ItemsSource = viewModel.Items;
treeView.EmptyView = "No Items";
{% endhighlight %}
{% endtabs %}

## Display views when TreeView has no items

The `SfTreeView` control uses the `EmptyView` property to display a custom view when the tree view has no items.

{% tabs %}
{% highlight xaml hl_lines="3" %}
  <syncfusion:SfTreeView x:Name="treeView"
                         ItemsSource="{Binding Items}">
    <syncfusion:SfTreeView.EmptyView>
         <Border Padding="10" Stroke="Purple" StrokeThickness="2" HorizontalOptions="Center" VerticalOptions="Center">
             <Border.StrokeShape>
                 <RoundRectangle CornerRadius="6"/>
             </Border.StrokeShape>
             <Label Text="No Items Found" 
                    HorizontalTextAlignment="Center" 
                    VerticalTextAlignment="Center" 
                    FontSize="16" FontAttributes="Bold" TextColor="Blue"/>
         </Border>
    </syncfusion:SfTreeView.EmptyView>                       
  </syncfusion:SfTreeView>
</ContentPage>
{% endhighlight %}
{% highlight c# hl_lines="3" %}
SfTreeView treeView = new SfTreeView();
treeView.ItemsSource = viewModel.Items;
treeView.EmptyView = new Border
{
    Padding = 10,
    Stroke = Colors.Purple,
    StrokeThickness = 2,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeShape = new RoundRectangle { CornerRadius = 6 },
    Content = new Label
    {
        Text = "No Items Found",
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        FontSize = 16,
        FontAttributes = FontAttributes.Bold,
        TextColor = Colors.Blue
    }
};
{% endhighlight %}
{% endtabs %}

N> The view displayed by the `EmptyView` can be a single view or a view that includes multiple child views.

![EmptyView in .NET MAUI TreeView](images/empty-view/maui-treeview-empty-view.gif)

## Empty view customization

The `SfTreeView` control allows you to fully customize the empty view appearance by using the `EmptyViewTemplate` property. This property lets you define a custom view and style for the `EmptyView`.

{% tabs %}
{% highlight xaml hl_lines="14" %}
<Grid RowDefinitions="Auto,*">
    <SearchBar x:Name="filterText"
               Placeholder="Search here"
               TextChanged="filterText_TextChanged" />
    <syncfusion:SfTreeView x:Name="treeView"
                           ItemsSource="{Binding FilteredFolders}"
                           AutoExpandMode="AllNodesExpanded"
                           NotificationSubscriptionMode="CollectionChange"
                           Grid.Row="1">
        <syncfusion:SfTreeView.EmptyView>
            <local:FilterItem Filter="{Binding Source={x:Reference filterText}, Path=Text}" />
        </syncfusion:SfTreeView.EmptyView>

        <syncfusion:SfTreeView.EmptyViewTemplate>
            <DataTemplate>
                <Border>
                      ....
                </Border>
            </DataTemplate>
        </syncfusion:SfTreeView.EmptyViewTemplate>
    </syncfusion:SfTreeView>
</Grid>

{% endhighlight %}
{% highlight c# hl_lines="34" %}

var grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

var filterText = new SearchBar
{
    Placeholder = "Search here"
};
filterText.TextChanged += FilterText_TextChanged;

// Add SearchBar to Grid (Row 0)
grid.Children.Add(filterText);
Grid.SetRow(filterText, 0);

var treeView = new SfTreeView
{
    ItemsSource = viewModel.FilteredFolders,
    AutoExpandMode = AutoExpandMode.AllNodesExpanded,
    NotificationSubscriptionMode = NotificationSubscriptionMode.CollectionChange
};

Grid.SetRow(treeView, 1);
grid.Children.Add(treeView);

var filterItem = new FilterItem();
filterItem.SetBinding(FilterItem.FilterProperty, new Binding
{
    Source = filterText,
    Path = "Text"
});
treeView.EmptyView = filterItem;

// Define the EmptyViewTemplate
treeView.EmptyViewTemplate = new DataTemplate(() =>
{
    return new Border
    {
        ...
    };
});

{% endhighlight %}
{% endtabs %}

N>
* The `EmptyViewTemplate` will only be applied when the `EmptyView` property is explicitly defined. If `EmptyView` is not set, the template will not be displayed.
* `EmptyView` can be set to custom data model and the appearance of the `EmptyView` can be customized by using the `EmptyViewTemplate`.

N> [View sample in GitHub](https://github.com/SyncfusionExamples/how-to-display-empty-view-when-.net-maui-treeview-has-no-items)

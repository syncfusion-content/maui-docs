---
layout: post
title: EmptyView in .NET MAUI TreeView Control | Syncfusion
description: Learn here about EmptyView support in Syncfusion .NET MAUI TreeView (SfTreeView) Control and more about it.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Empty view in .NET MAUI TreeView (SfTreeView)

The `SfTreeView` control allows you to display and customize the empty view content when no data is available. The `EmptyView` property can be set to either a string or a view, and it will be displayed when the `ItemsSource` is empty or null, or the `Nodes` collection is empty. `EmptyViewTemplate` is used to customize the appearance of `EmptyView`.

## Display a string when TreeView has no items

The `EmptyView` property in `SfTreeView` can be set to a string, which will be displayed when no items are present in the tree view.

{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView">
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

The `SfTreeView` control uses the `EmptyView` property to display a custom view when the tree has no items.

{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView">
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

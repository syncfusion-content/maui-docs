---
layout: post
title: Item Separator Customization in .NET MAUI ListView control | Syncfusion
description: Learn here all about Item Separator support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Item Separator Customization in .NET MAUI ListView (SfListView)

This section explains how to enable and customize built-in item separators in the `.NET MAUI ListView` (SfListView). The feature provides optional, cross-platform separator lines between items and group headers without requiring custom `ItemTemplate`.

## Enable Item Separator

The [SfListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.html) can display separators between items by setting the `ShowItemSeparator` property to `True`. You can control separator color, thickness and margin. Group header separators are supported via `ShowGroupItemSeparator` and have separate styling properties.

<table>
  <thead>
    <tr>
      <th>Property</th>
      <th>Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ShowItemSeparator</td>
      <td>Enables or disables separators between individual list items. <em>(Default: false)</em></td>
    </tr>
    <tr>
      <td>ItemSeparatorColor</td>
      <td>Sets the color of the item separator line.</td>
    </tr>
    <tr>
      <td>ItemSeparatorThickness</td>
      <td>Specifies the thickness (height) of the separator line.</td>
    </tr>
    <tr>
      <td>ItemSeparatorMargin</td>
      <td>Specifies inset/margin for the separator to align it with item content.</td>
    </tr>
    <tr>
      <td>ShowGroupItemSeparator</td>
      <td>When enabled, draws a separator immediately after a group header to visually separate the header from its child items.</td>
    </tr>
    <tr>
      <td>GroupItemSeparatorColor</td>
      <td>Sets the color of the separator rendered below group headers.</td>
    </tr>
    <tr>
      <td>GroupItemSeparatorThickness</td>
      <td>Specifies the thickness of the group header separator.</td>
    </tr>
    <tr>
      <td>GroupItemSeparatorMargin</td>
      <td>Specifies inset/margin for the group header separator for alignment with headers or items.</td>
    </tr>
  </tbody>
</table>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
<syncfusion:SfListView x:Name="listView"
                       ShowItemSeparator="True"
                       ShowGroupItemSeparator="True"
                       ItemsSource="{Binding BookInfo}">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <StackLayout Padding="5">
                <Label Text="{Binding BookName}" FontAttributes="Bold" />
                <Label Text="{Binding BookDescription}" />
            </StackLayout>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
listView.ShowItemSeparator = true;
{% endhighlight %}
{% endtabs %}

![MAUI ListView Separator Example](Images/item-separator/maui-listview-item-separator-example.png)

## Separator Customization

After enabling separators, use the following properties to customize appearance and behavior:

- `ItemSeparatorColor`: Sets the color of the separator line between items.
- `ItemSeparatorThickness`: Sets the separator thickness.
- `ItemSeparatorMargin`: Specifies the insets applied to the separator to align it with the item content. For vertical orientation, the left and right margin values are considered. For horizontal orientation, only the top and bottom margin values are applied to the separator line.
- `GroupItemSeparatorColor`: Sets the color of the group header separator.
- `GroupItemSeparatorThickness`: Sets the thickness of the group header separator.
- `GroupItemSeparatorMargin`: Applies inset for the group header separator.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6" %}
<syncfusion:SfListView x:Name="listView"
                       ItemSize="60"
                       ShowItemSeparator="True"
                       ItemSeparatorColor="#D0BCFF"
                       ItemSeparatorThickness="2"
                       ItemSeparatorMargin="10"
                       ShowGroupItemSeparator="True"
                       GroupItemSeparatorColor="#6750A4"
                       GroupItemSeparatorThickness="2"
                       GroupItemSeparatorMargin="40"
                       ItemsSource="{Binding BookInfo}">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <StackLayout Padding="5">
                <Label Text="{Binding BookName}" FontAttributes="Bold" />
                <Label Text="{Binding BookDescription}" />
            </StackLayout>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2 3 4 5 6 7" %}
listView.ShowItemSeparator = true;
listView.ItemSeparatorColor = Colors.Gray;
listView.ItemSeparatorThickness = 1;
listView.ItemSeparatorMargin = new Thickness(16,0);
listView.ShowGroupItemSeparator = true;
listView.GroupItemSeparatorColor = Colors.DarkGray;
listView.GroupItemSeparatorThickness = 2;
{% endhighlight %}
{% endtabs %}

![MAUI ListView Separator Example](Images/item-separator/maui-listview-separator-customization.png)

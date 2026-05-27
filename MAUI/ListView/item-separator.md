---
layout: post
title: Item Separator in .NET MAUI ListView control | Syncfusion
description: Learn here all about Item Separator support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Item Separator Customization in .NET MAUI ListView (SfListView)

This section explains how to enable and customize built-in item separators in the Syncfusion .NET MAUI SfListView control. The separator feature provides optional, cross-platform divider lines between list items and group headers without requiring a custom `ItemTemplate`.

## Enable Item Separator

The SfListView displays separators between items when the `ShowItemSeparator` property is set to `True`.

Separators for group headers can be enabled using the `ShowGroupItemSeparator` property. Both item and group separators can be styled independently using their respective customization properties.

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
      <td>ShowGroupItemSeparator</td>
      <td>When enabled, draws a separator immediately after a group header to visually separate the header from its child items. <em>(Default: false)</em></td>
    </tr>
  </tbody>
</table>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2,3" %}
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

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 2" %}
listView.ShowItemSeparator = true;
listView.ShowGroupItemSeparator = true;
{% endhighlight %}
{% endtabs %}

![MAUI ListView Separator Example](Images/item-separator/maui-listview-item-separator-example.png)

## Separator Customization

After enabling separators, you can customize their appearance and behavior using the following properties:

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
      <td>Specifies the insets applied to the separator to align it with the item content. For vertical orientation, the left and right margin values are considered. For horizontal orientation, only the top and bottom margin values are applied to the separator line.</td>
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
      <td>Specifies inset/margin for the group header separator for alignment with headers or items. For vertical orientation, the left and right margin values are considered. For horizontal orientation, only the top and bottom margin values are applied to the separator line.</td>
    </tr>
  </tbody>
</table>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6 7 8 9 10" %}
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

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 2 3 4 5 6 7 8" %}
listView.ShowItemSeparator = true;
listView.ItemSeparatorColor = Color.FromArgb("#D0BCFF");
listView.ItemSeparatorThickness = 2;
listView.ItemSeparatorMargin = new Thickness(10);
listView.ShowGroupItemSeparator = true;
listView.GroupItemSeparatorColor = Color.FromArgb("#6750A4"); ;
listView.GroupItemSeparatorThickness = 2;
listView.GroupItemSeparatorMargin = new Thickness(40);
{% endhighlight %}
{% endtabs %}

![MAUI ListView Separator Example](Images/item-separator/maui-listview-separator-customization.png)

---
layout: post
title: Item Separator in .NET MAUI ListView control | Syncfusion
description: Learn all about Item Separator support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Item separator customization in .NET MAUI ListView (SfListView)

This section explains how to enable and customize built-in item separators in the Syncfusion .NET MAUI SfListView control. The separator feature adds optional, cross-platform divider lines between list items and group headers.

## Enable item separator

The SfListView displays separators between items when the `ShowItemSeparator` property is set to `true`.

Separators for group headers can be enabled using the `ShowGroupItemSeparator` property. `ShowGroupItemSeparator` has no visible effect unless the SfListView is grouped (that is, `IsGrouped` is `true` and a `GroupTemplate` or grouping logic is configured). Both can be styled independently using the properties below.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3,4" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             x:Class="ListViewSample.MainPage">
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
</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 2" %}
listView.ShowItemSeparator = true;
listView.ShowGroupItemSeparator = true;
{% endhighlight %}
{% endtabs %}

![MAUI ListView with item and group separators enabled](Images/item-separator/maui-listview-item-separator-example.png)

## Separator customization

The styling properties listed in this section take effect only when the corresponding `ShowItemSeparator` or `ShowGroupItemSeparator` flag is also set to `true`. After enabling the appropriate flag, you can customize the appearance and behavior using the following properties:

<table>
  <thead>
    <tr>
      <th>Property</th>
      <th>Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>{{'[ItemSeparatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorColorProperty)'| markdownify }}</td>
      <td>Sets the color of the item separator line. Accepts any <code>Color</code> value, including named colors, hex values, and <code>Color.FromArgb</code>. <em>(Type: <code>Color</code>, Default: <code>Colors.LightGray</code>)</em></td>
    </tr>
    <tr>
      <td>{{'[ItemSeparatorThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorThicknessProperty)'| markdownify }}</td>
      <td>Specifies the thickness of the separator line as a single <code>double</code> value (device-independent units) applied uniformly on all sides. <em>(Type: <code>double</code>, Default: <code>1</code>)</em></td>
    </tr>
    <tr>
      <td>{{'[ItemSeparatorMargin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorMarginProperty)'| markdownify }}</td>
      <td>Specifies the margin applied to the separator to align it with the item content. <em>(Type: <code>Thickness</code>, Default: <code>new Thickness(0)</code>)</em> In XAML, a single value (for example, <code>"10"</code>) sets all four sides uniformly. In C#, use the <code>Thickness</code> structure (for example, <code>new Thickness(10)</code>). For <code>Vertical</code> orientation, only the left and right values are used; for <code>Horizontal</code>, only the top and bottom values are used.</td>
    </tr>
    <tr>
      <td>{{'[GroupItemSeparatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorColorProperty)'| markdownify }}</td>
      <td>Sets the color of the separator rendered below group headers. Accepts any <code>Color</code> value, including named colors, hex values, and <code>Color.FromArgb</code>. <em>(Type: <code>Color</code>, Default: <code>Colors.LightGray</code>)</em></td>
    </tr>
    <tr>
      <td>{{'[GroupItemSeparatorThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorThicknessProperty)'| markdownify }}</td>
      <td>Specifies the thickness of the group header separator as a single <code>double</code> value (device-independent units) applied uniformly on all sides. <em>(Type: <code>double</code>, Default: <code>1</code>)</em></td>
    </tr>
    <tr>
      <td>{{'[GroupItemSeparatorMargin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorMarginProperty)'| markdownify }}</td>
      <td>Specifies the margin for the group header separator for alignment with headers or items. <em>(Type: <code>Thickness</code>, Default: <code>new Thickness(0)</code>)</em> In XAML, a single value (for example, <code>"40"</code>) sets all four sides uniformly. In C#, use the <code>Thickness</code> structure (for example, <code>new Thickness(40)</code>). For <code>Vertical</code> orientation, only the left and right values are used; for <code>Horizontal</code>, only the top and bottom values are used.</td>
    </tr>
  </tbody>
</table>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4 5 6 7 8 9 10 11" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             x:Class="ListViewSample.MainPage">
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
</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 2 3 4 5 6 7 8" %}
listView.ShowItemSeparator = true;
listView.ItemSeparatorColor = Color.FromArgb("#D0BCFF");
listView.ItemSeparatorThickness = 2;
listView.ItemSeparatorMargin = new Thickness(10);
listView.ShowGroupItemSeparator = true;
listView.GroupItemSeparatorColor = Color.FromArgb("#6750A4");
listView.GroupItemSeparatorThickness = 2;
listView.GroupItemSeparatorMargin = new Thickness(40);
{% endhighlight %}
{% endtabs %}

![MAUI ListView with customized separator colors, thickness, and margin](Images/item-separator/maui-listview-separator-customization.png)

---
layout: post
title: Populating Items in .NET MAUI Chips Control | Syncfusion®
description: Learn about populating items in Syncfusion® Essential Studio® .NET MAUI Chips control, its elements, and more.
platform: maui
control: Chips
documentation: ug
---

# Populating Items in .NET MAUI Chips

The [.NET MAUI Chips](https://www.syncfusion.com/maui-controls/maui-chips) control can be populated with either business objects or `SfChip` instances. This section explains how to populate the chips control with both business objects and `SfChip`.

## Populating Business Objects as Items

Business objects can be populated in Chips using the [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemsSource) property. Refer to this [documentation](https://help.syncfusion.com/maui/Syncfusion.Maui.Core.SfChipGroup.html) for more details on populating the chips control with a list of employee details.

## Populating SfChip as Items

The Chips control also supports creating and setting [`SfChip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) as an item. This can be achieved using the [`Items`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_Items) property.

{% tabs %}

{% highlight xaml %}

<chip:SfChipGroup >
    <chip:SfChipGroup.Items>
        <chip:SfChip Text="Extra Small" Background="Blue"/>
        <chip:SfChip Text="Small" Background="Blue"/>
        <chip:SfChip Text="Medium" Background="Blue"/>
        <chip:SfChip Text="Large" Background="Blue"/>
        <chip:SfChip Text="Extra Large" Background="Blue"/>
   </chip:SfChipGroup.Items>
</chip:SfChipGroup>

{% endhighlight %}

{% highlight c# %}

SfChipGroup chipGroup = new SfChipGroup()
{
	ChipType = SfChipsType.Action
};
chipGroup.Items.Add(new SfChip(){Text="Extra Small", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Small", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Medium", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Large", Background = Colors.Blue });
chipGroup.Items.Add(new SfChip(){Text="Extra Large", Background = Colors.Blue });
		
{% endhighlight %}

{% endtabs %}

![Collection of items to chip group](images/items/chips_items.png)



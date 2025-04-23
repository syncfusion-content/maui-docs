---
layout: post
title: Populating Items in .NET MAUI Chips control | Syncfusion®
description: Learn about Populating Items support in Syncfusion® Essential Studio® .NET MAUI Chips control, its elements and more.
platform: maui
control: Chips
documentation: ug
---

# Populating Items in .NET MAUI Chips

[.NET MAUI Chips](https://www.syncfusion.com/maui-controls/maui-chips) can be populated with either business objects and SfChip. This section explain how to populate the chips control with business objects and SfChip.

## Populating business objects as items

Business objects can be populated in Chips using the [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemsSource) property.
Refer to this `documentation` to know more details about populating the chips control with list of employee details.

## Populating SfChip as items

Chips control also provides support to create and set [`SfChip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) as item. It can be achieved using the [`Items`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_Items) property.

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



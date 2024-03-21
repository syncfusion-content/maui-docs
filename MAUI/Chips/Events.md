---
layout: post
title: Events in .NET MAUI Chips control | Syncfusion
description: Learn about Events support in Syncfusion Essential Studio .NET MAUI Chips control, its elements and more.
platform: maui
control: Chips
documentation: ug
---

# Events in .NET MAUI Chips

## SelectionChanging Event

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanging) event is triggered before the Chip is selected. You can restrict a chip from being selected, by canceling this event, by setting `Cancel` property in the event argument to true. The argument contains the following information,

 * [AddedItem] - Used to get the selected chip from `SfChipGroup`.
 * [RemovedItem] - Used to get the previous selected or deselected chip from `SfChipGroup`.
 * [Cancel] - Used to set the value indicating whether the selection should be canceled. 

## SelectionChanged Event
The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanged) event triggered after a chip is selected. The argument contains the following information,

 * [AddedItem] - Get the selected chip from `SfChipGroup`.
 * [RemovedItem] - Get the previous selected or deselected chip from `SfChipGroup`.

N>  Currently, [`Choice`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Choice) and [`Filter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Filter) types are only supported for `SelectionChanging` and `SelectionChanged` events.

##  ChipClicked

The [`ChipClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipClicked) event is triggered when a chip clicked in the [SfChipGroup]. The event argument is type of `EventArgs`.

## ItemRemoved Event

The [ItemRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemRemoved) event is triggered after the chip is removed from `SfChipGroup`. The argument contains the following information,

* [RemovedItem] - Get the removed chip item from the `SfChipGroup`.

N> The [ItemRemoved] event is supported only in the `Input` type.

##  CloseButtonClicked

The `CloseButtonClicked` event is triggered when the closed button is clicked. The event argument is type of `EventArgs`.

{% tabs %}
{% highlight xaml %}
    
   <chip:SfChip WidthRequest="100"
                x:Name="chip"
                CloseButtonClicked="SfChip_CloseButtonClicked"/>

{% endhighlight %}
{% highlight c# %}

   SfChip chip = new SfChip();
   chip.CloseButtonClicked+=chip_CloseButtonClicked;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
    
    private async void SfChip_CloseButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Message", "Chip CloseButton Clicked", "close");
        }

{% endhighlight %}
{% endtabs %}



---
layout: post
title: Events in .NET MAUI Chips Control | Syncfusion®
description: Learn about event support in Syncfusion® Essential Studio® .NET MAUI Chips control, its elements, and more.
platform: maui
control: Chips
documentation: ug
---

# Events in .NET MAUI Chips

## SelectionChanging Event

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanging) event is triggered before a chip is selected. You can prevent a chip from being selected by setting the `Cancel` property in the event arguments to `true`. The event arguments contain the following details:

 * **AddedItem**: Retrieves the selected chip from `SfChipGroup`.
 * **RemovedItem**: Retrieves the previously selected or deselected chip from `SfChipGroup`.
 * **Cancel**: Indicates whether the selection should be canceled.

## SelectionChanged Event
The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanged) event is triggered after a chip is selected. The event arguments contain the following details:

 * **AddedItem**: Retrieves the selected chip from `SfChipGroup`.
 * **RemovedItem**: Retrieves the previously selected or deselected chip from `SfChipGroup`.

> Note: Currently, [`Choice`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Choice) and [`Filter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Filter) chip types support the `SelectionChanging` and `SelectionChanged` events.

## ChipClicked

The [`ChipClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipClicked) event is triggered when a chip is clicked in the `SfChipGroup`. The event arguments are of type `EventArgs`.

## ItemRemoved Event

The [ItemRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemRemoved) event is triggered after a chip is removed from `SfChipGroup`. The event arguments contain the following detail:

* **RemovedItem**: Retrieves the removed chip item from the `SfChipGroup`.

> Note: The `ItemRemoved` event is supported only in the `Input` chip type.

## CloseButtonClicked

The `CloseButtonClicked` event is triggered when the close button of a chip is clicked. The event arguments are of type `EventArgs`.

{% tabs %}
{% highlight xaml %}
    
   <chip:SfChip x:Name="chip"
                ShowCloseButton="True"
                Text="John"
                CloseButtonClicked="SfChip_CloseButtonClicked"/>

{% endhighlight %}
{% highlight c# %}

   SfChip chip = new SfChip();
   chip.Text = "John";
   chip.ShowCloseButton = true;
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




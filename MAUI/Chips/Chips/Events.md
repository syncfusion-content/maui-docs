---
layout: post
title: Events in .NET MAUI Chips control | Syncfusion
description: Learn about Events support in Syncfusion Essential Studio .NET MAUI Chips control, its elements and more.
platform: .NET MAUI
control: Chips
documentation: ug
---

# Events in Xamarin Chips

## SelectionChanging Event
The [SelectionChanging] event is triggered before the Chip is selected. You can restrict a chip from being selected, by canceling this event, by setting [Cancel] property in the event argument to true. The argument contains the following information,

 * [AddedItem] - Used to get the selected chip from [SfChipGroup].
 * [RemovedItem] - Used to get the previous selected or deselected chip from [SfChipGroup].
 * [Cancel] - Used to set the value indicating whether the selection should be canceled. 

## SelectionChanged Event
The [SelectionChanged] event triggered after a chip is selected. The argument contains the following information,

 * [AddedItem] - Get the selected chip from [SfChipGroup].
 * [RemovedItem] - Get the previous selected or deselected chip from [SfChipGroup].

N>  Currently, [`Choice`] and [`Filter`] types are only supported for [SelectionChanging] and [SelectionChanged] events.

##  ChipClicked

The [`ChipClicked`] event is triggered when a chip clicked in the [SfChipGroup]. The event argument is type of `EventArgs`.

## ItemRemoved Event

The [ItemRemoved] event is triggered after the chip is removed from [SfChipGroup]. The argument contains the following information,

* [RemovedItem] - Get the removed chip item from the [SfChipGroup].

N> The [ItemRemoved] event is supported only in the [`Input`] type.

## See also

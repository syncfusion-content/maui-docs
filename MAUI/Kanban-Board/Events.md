---
layout: post
title: Events in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Events support in Syncfusion .NET MAUI Kanban Board (SfKanban) control, its elements and more.
platform: maui
control: Kanban
documentation: ug
---

# Events in .NET MAUI Kanban Board (SfKanban)

## ItemTapped

[`ItemTapped`]() event is triggered when you tap on any card. The argument contains the following information.

* [`Column`]() - Used to get the column of the card.
* [`Data`]() - Used to get the underlying model of the card.
* [`Index`]() - Used to get the index of the card in a column.

### Command

The [`CardTappedCommand`]() property is used to associate a command with an instance of [SfKanban](). This property is most often set with MVVM pattern to bind callbacks back into the ViewModel.

### CommandParameter

The [`CardTappedCommandParameter`]() property is used to set the parameter reference, based on which the event argument is shown.

>**NOTE**
The default value of the [CardTappedCommandParameter]() is `null`.

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban  CardTappedCommand="{Binding CardTappedCommand}" CardTappedCommandParameter="1">
            <!--Intialize the column-->
    </kanban:SfKanban>

{% endhighlight %}

{% highlight c# %}

    public class ViewModel
    {

        public ViewModel()
        {
            CardTappedCommand = new Command<object>(CardTappedEvent);

            public ICommand CardTappedCommand { get; set; }
        }

        private void CardTappedEvent(object args)
        {
            //  handle event action.
        }
    }
{% endhighlight %}

{% endtabs %}

## DragStart

[`DragStart`]() event is triggered when you start to drag a card. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`KeepItem`]() - Determines whether to keep the dragged card in the source location itself, until it is dropped in a new location. When it is true, the preview of the card will be created for dragging.
* [`SourceColumn`]() - Used to get the source column of card.
* [`SourceIndex`]() - Used to get the index of the card in source column.   

## DragEnd  

[`DragEnd`]() event is triggered whenever the card is dropped or dragging action is canceled. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetCategory`]() - Used to get the category of the column where the card is going to be dropped.
* [`TargetColumn`]() - Used to get the current column which is the drop target for the card.
* [`TargetIndex`]() - Used to get the index of the card in target column.

## DragEnter 

[`DragEnter`]() event is triggered when a card enters into a column while dragging. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`IsAboveMaximumLimit`]() - Used to know whether the total cards count of the target column will be above the maximum limit if you drop the card in target column. You can define the maximum limit of the cards using [MaximumLimit]() property of [KanbanColumn](). 
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetColumn`]() - Used to get the column upon which the card enters.
* [`TargetIndex`]() - Used to get the index of the card in target column.

## DragLeave 

[`DragLeave`]() event is triggered when a card leaves a column while dragging. The argument contains the following information.

* [`Data`]() - Used to get the underlying model of the card.
* [`IsBelowMinimumLimit`]() - Used to know whether the total cards count of the target column will be below the minimum limit if you remove the card from target column. You can define the minimum limit of the cards using [MinimumLimit]() property of [KanbanColumn]().
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetColumn`]() - Used to get the column from which the card leaves.

## DragOver

[`DragOver`]() event is triggered when a card is dragged to a new index within a column. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetColumn`]() - Used to get the current column which is the drop target for the card.
* [`TargetIndex`]() - Used to get the new index of the card in target column.

## ColumnsGenerated 

[`ColumnsGenerated`]() event will be fired after the columns are generated automatically. You can access the auto-generated columns using [`ActualColumns`]() property of [`SfKanban`]().

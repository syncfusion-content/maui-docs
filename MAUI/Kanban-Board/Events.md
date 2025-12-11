---
layout: post
title: Events in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Events support in Syncfusion® .NET MAUI Kanban Board (SfKanban) control, its elements and more.
platform: maui
control: Kanban
documentation: ug
---

# Events in .NET MAUI Kanban Board (SfKanban)

## CardTapped

The [CardTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_CardTapped) event occurs when the card is tapped. We can get the following details from the `CardTapped` event.

* [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html#Syncfusion_Maui_Kanban_KanbanCardTappedEventArgs_Column) - Returns the instance of the column containing the tapped card.
* [Index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html#Syncfusion_Maui_Kanban_KanbanCardTappedEventArgs_Index) - Returns the index position of the tapped card within its column.
* [Data](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html#Syncfusion_Maui_Kanban_KanbanCardTappedEventArgs_Data) - Returns the data of the card that was tapped.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<kanban:SfKanban x:Name="kanban"
                 ItemsSource="{Binding Cards}"
                 CardTapped="OnKanbanCardTapped">
    <kanban:SfKanban.BindingContext>
        <local:KanbanViewModel/>
    </kanban:SfKanban.BindingContext>
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# hl_lines="2" %}

this.kanban.ItemsSource = new KanbanViewModel().Cards;
this.kanban.CardTapped += this.OnKanbanCardTapped;

private void OnKanbanCardTapped(object sender, KanbanCardTappedEventArgs e)
{
    var selectedColumn = e.Column;
    var selectedCardIndex = e.Index;
    var selectedCardDetails = e.Data;
}

{% endhighlight %}

{% highlight c# tabtitle="KanbanViewModel.cs" %}

public class KanbanViewModel
{
    #region Properties

    /// <summary>
    /// Gets or sets the collection of <see cref="KanbanModel"/> objects.
    /// </summary>
    public ObservableCollection<KanbanModel> Cards { get; set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="KanbanViewModel"/> class.
    /// </summary>
    public KanbanViewModel()
    {
        this.Cards = this.GetCardDetails();
    }

    #endregion

    #region Private methods

    /// <summary>
    /// Method to get the kanban model collections.
    /// </summary>
    /// <returns>The kanban model collections.</returns>
    private ObservableCollection<KanbanModel> GetCardDetails()
    {
        var cards = new ObservableCollection<KanbanModel>();
        cards.Add(
            new KanbanModel()
            {
                ID = 1,
                Title = "iOS - 1",
                ImageURL = "People_circle1.png",
                Category = "Open",
                Description = "Analyze customer requirements",
                IndicatorFill = SolidColorBrush.Red,
                Tags = new List<string> { "Bug", "Customer", "Release Bug" }
            }
        );

        cards.Add(
            new KanbanModel()
            {
                ID = 6,
                Title = "Xamarin - 6",
                ImageURL = "People_Circle2.png",
                Category = "Open",
                Description = "Show the retrived data from the server in grid control",
                IndicatorFill = SolidColorBrush.Red,
                Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
            }
        );

        cards.Add(
            new KanbanModel()
            {
                ID = 24,
                Title = "UWP - 24",
                ImageURL = "People_Circle14.png",
                Category = "In Progress",
                Description = "Test editing functionality",
                IndicatorFill = SolidColorBrush.Orange,
                Tags = new List<string> { "Feature", "Customer", "Release" }
            }
        );

        cards.Add(
            new KanbanModel()
            {
                ID = 21,
                Title = "Android - 21",
                Category = "Closed",
                ImageURL = "People_Circle23.png",
                Description = "Arrange web meeting with customer to get editing requirements",
                IndicatorFill = SolidColorBrush.Orange,
                Tags = new List<string> { "Story", "Improvement" }
            }
        );

        return cards;
    }

    #endregion
}

{% endhighlight %}
{% endtabs %}

## DragStart

[`DragStart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragStart) event is triggered when you start to drag a card. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragStartEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragStartEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column. 
* `KeepCard` - Determines whether the original card remains in the source column during a drag operation. When set to true, the card stays in its original column while being dragged, allowing repeated drag-and-drop actions without relocating the card. A preview of the card is generated during the drag.  

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            x:Class="SimpleSample.MainPage"
            xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
            xmlns:local="clr-namespace:SimpleSample;assembly=SimpleSample">

    <ContentPage.BindingContext>
        <local:KanbanCustomViewModel />
    </ContentPage.BindingContext>
            
    <kanban:SfKanban x:Name="kanban" HorizontalOptions="FillAndExpand"
                    VerticalOptions="FillAndExpand" ItemsSource="{Binding Cards}"
                    DragStart="SfKanban_DragStart" >
                
    ...
                
    </kanban:SfKanban>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

SfKanban kanban = new SfKanban();
kanban.ItemsSource = viewModel.Cards;
kanban.DragStart += SfKanban_DragStart;

private void SfKanban_DragStart(object sender, Syncfusion.Maui.Kanban.KanbanDragStartEventArgs e)
{
    e.KeepCard = true;
}
      
{% endhighlight %}

{% endtabs %}

## DragEnd  

[`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnd) event is triggered whenever the card is dropped or dragging action is canceled. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetCategory`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_TargetCategory) - Used to get the category of the column where the card is going to be dropped.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_TargetColumn) - Used to get the current column which is the drop target for the card.
* [`TargetIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_TargetIndex) - Used to get the index of the card in target column.

## DragEnter 

[`DragEnter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnter) event is triggered when a card enters into a column while dragging. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`IsAboveMaximumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_IsAboveMaximumLimit) - Used to know whether the total cards count of the target column will be above the maximum limit if you drop the card in target column. You can define the maximum limit of the cards using [MaximumLimit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MaximumLimit) property of [KanbanColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html). 
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_TargetColumn) - Used to get the column upon which the card enters.
* [`TargetIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_TargetIndex) - Used to get the index of the card in target column.

## DragLeave 

[`DragLeave`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragLeave) event is triggered when a card leaves a column while dragging. The argument contains the following information.

* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`IsBelowMinimumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragLeaveEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragLeaveEventArgs_IsBelowMinimumLimit) - Used to know whether the total cards count of the target column will be below the minimum limit if you remove the card from target column. You can define the minimum limit of the cards using [MinimumLimit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MinimumLimit) property of [KanbanColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html).
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragLeaveEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragLeaveEventArgs_TargetColumn) - Used to get the column from which the card leaves.

## DragOver

[`DragOver`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragOver) event is triggered when a card is dragged to a new index within a column. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragOverEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragOverEventArgs_TargetColumn) - Used to get the current column which is the drop target for the card.
* [`TargetIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragOverEventArgs_TargetIndex) - Used to get the new index of the card in target column.
---
layout: post
title: Events in .NET MAUI Kanban Board control | Syncfusion
description: Learn about Events support in Syncfusion® .NET MAUI Kanban Board (SfKanban) control, its elements, and more.
platform: maui
control: Kanban
documentation: ug
---

# Events in .NET MAUI Kanban Board (SfKanban)

## CardTapped

The [CardTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_CardTapped) event is raised when a card is tapped. The `CardTapped` event argument (`KanbanCardTappedEventArgs`) provides the following details:

* [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html#Syncfusion_Maui_Kanban_KanbanCardTappedEventArgs_Column) (`KanbanColumn`) - Returns the column that contains the tapped card.
* [Index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html#Syncfusion_Maui_Kanban_KanbanCardTappedEventArgs_Index) (`int`) - Returns the index of the tapped card within its column.
* [Data](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html#Syncfusion_Maui_Kanban_KanbanCardTappedEventArgs_Data) (`object`) - Returns the data of the tapped card.

The event is non-cancelable and is raised on a single tap of a card (not on long-press or double-tap).

{% tabs %}
{% highlight XAML hl_lines="3" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
             xmlns:local="clr-namespace:YourAppNamespace;assembly=YourAppName"
             x:Class="YourAppNamespace.MainPage">
    <ContentPage.BindingContext>
        <local:KanbanViewModel />
    </ContentPage.BindingContext>
    <kanban:SfKanban x:Name="kanban"
                     ItemsSource="{Binding Cards}"
                     CardTapped="OnKanbanCardTapped" />
</ContentPage>

{% endhighlight %}

{% highlight C# hl_lines="2" %}

var kanban = new SfKanban
{
    ItemsSource = new KanbanViewModel().Cards
};
kanban.CardTapped += OnKanbanCardTapped;
this.Content = kanban;

private void OnKanbanCardTapped(object sender, KanbanCardTappedEventArgs e)
{
    var selectedColumn = e.Column;
    var selectedCardIndex = e.Index;
    var selectedCardDetails = e.Data;
}

{% endhighlight %}

{% highlight c# tabtitle="KanbanViewModel.cs" %}

using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Kanban;

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

The [`DragStart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragStart) event is raised when a card starts to drag. The event argument provides the following properties:

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragStartEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragStartEventArgs_Cancel) (`bool`, default `false`) - Set to `true` to cancel the drag operation.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) (`object`) - Returns the underlying model of the card.
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) (`KanbanColumn`) - Returns the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) (`int`) - Returns the index of the card in the source column.
* [`KeepCard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragStartEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragStartEventArgs_KeepCard) (`bool`, default `false`) - When set to `true`, the original card remains in the source column while being dragged. A preview of the card is generated during the drag, allowing repeated drag-and-drop actions without relocating the card.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
             xmlns:local="clr-namespace:YourAppNamespace;assembly=YourAppName"
             x:Class="YourAppNamespace.MainPage">
    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <kanban:SfKanban x:Name="kanban"
                     ItemsSource="{Binding TaskDetails}"
                     DragStart="OnKanbanCardDragStart" />
</ContentPage>

{% endhighlight %}
{% highlight C# hl_lines="2 6" %}

var kanban = new SfKanban
{
    ItemsSource = new ViewModel().TaskDetails
};
kanban.DragStart += OnKanbanCardDragStart;
this.Content = kanban;

private void OnKanbanCardDragStart(object sender, KanbanDragStartEventArgs e)
{
    // Keep the source card in place and show a drag preview.
    e.KeepCard = true;
}

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Kanban;

public class ViewModel
{
    #region Properties

    /// <summary>
    /// Gets or sets the collection of <see cref="KanbanModel"/> objects representing tasks in various stages.
    /// </summary>
    public ObservableCollection<KanbanModel> TaskDetails { get; set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="ViewModel"/> class.
    /// </summary>
    public ViewModel()
    {
        this.TaskDetails = this.GetTaskDetails();
    }

    #endregion

    #region Private methods

    /// <summary>
    /// Method to get the kanban model collections.
    /// </summary>
    /// <returns>The kanban model collections.</returns>
    private ObservableCollection<KanbanModel> GetTaskDetails()
    {
        var taskDetails = new ObservableCollection<KanbanModel>();

        KanbanModel taskDetail = new KanbanModel();
        taskDetail.Title = "UWP Issue";
        taskDetail.ID = 7;
        taskDetail.Description = "Crosshair label template not visible in UWP";
        taskDetail.Category = "Open";
        taskDetail.IndicatorFill = Colors.Blue;
        taskDetail.Tags = new List<string>() { "Bug Fixing" };
        taskDetails.Add(taskDetail);

        taskDetail = new KanbanModel();
        taskDetail.Title = "WinUI Issue";
        taskDetail.ID = 8;
        taskDetail.Description = "AxisLabel cropped when rotating the axis label";
        taskDetail.Category = "Open";
        taskDetail.IndicatorFill = Colors.Pink;
        taskDetail.Tags = new List<string>() { "Bug Fixing" };
        taskDetails.Add(taskDetail);

        taskDetail = new KanbanModel();
        taskDetail.Title = "Kanban Feature";
        taskDetail.ID = 9;
        taskDetail.Description = "Provide drag and drop support";
        taskDetail.Category = "In Progress";
        taskDetail.IndicatorFill = Colors.Yellow;
        taskDetail.Tags = new List<string>() { "New control" };
        taskDetails.Add(taskDetail);

        taskDetail = new KanbanModel();
        taskDetail.Title = "New Feature";
        taskDetail.ID = 10;
        taskDetail.Description = "Dragging events support for Kanban";
        taskDetail.Category = "Closed";
        taskDetail.IndicatorFill = Colors.Orange;
        taskDetail.Tags = new List<string>() { "New Control" };
        taskDetails.Add(taskDetail);

        return taskDetails;
    }

    #endregion
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
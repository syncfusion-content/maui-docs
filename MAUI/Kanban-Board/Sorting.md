---
layout: post
title: Sorting in .NET MAUI Kanban control | Syncfusion
description: Learn here all about Sorting support in Syncfusion® .NET MAUI Kanban (SfKanban) control and more.
platform: maui
control: Kanban
documentation: ug
keywords: .net maui Kanban sorting, sfKanban sorting in .net maui, .net maui Kanban sorting support.
---

# Sorting in .NET MAUI Kanban (SfKanban)

This feature is used to sort the card items on Kanban Columns by following below properties

* `SortingMappingPath` - This property should correspond to a property name in the KanbanModel or CustomModel. The default value is       string.Empty in this case the cards won’t be sorted.
* `SortingOrder` - Defines the order in which cards appear. The default is Ascending.
   * `Ascending` - Cards with lower values appear first.
   * `Descending` - Cards with higher values appear first. 

## Cards position updation while drag and drop

In the SfKanban Sorting feature, you can customize how cards are sorted during drag-and-drop actions. When a card is dropped, its position in the target column is updated based on the SortingMappingPath value.

The following code example describes the card position changing functionality.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<kanban:SfKanban x:Name="kanban"
                 ItemsSource="{Binding Cards}"
                 SortingMappingPath="Index"
                 SortingOrder="Ascending"
                 DragEnd="OnCardDragEnd">
    <kanban:SfKanban.BindingContext>
        <local:SortingViewModel/>
    </kanban:SfKanban.BindingContext>
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# hl_lines="2" %}

this.kanban.ItemsSource = new SortingViewModel().Cards;
this.kanban.DragEnd += this.OnCardDragEnd;

private void OnCardDragEnd(object? sender, KanbanDragEndEventArgs e)
{
    this.kanban.RefreshKanbanColumn();
}

{% endhighlight %}

{% highlight c# tabtitle="CardDetails.cs" %}

public class CardDetails : INotifyPropertyChanged
{
    #region Fields

    /// <summary>
    /// The title of the card.
    /// </summary>
    private string? _title;

    /// <summary>
    /// The description of the card.
    /// </summary>
    private string? _description;

    /// <summary>
    /// The category of the card. This property is used for column mapping in the Kanban board.
    /// </summary>
    private string? _category;

    /// <summary>
    /// The list of tags associated with the card.
    /// </summary>
    private List<string>? _tags;

    /// <summary>
    /// The index of the card. This property is used for sorting the cards within a column.
    /// </summary>
    private int _index;

    /// <summary>
    /// The priority of the card. This property can be used for additional sorting or filtering.
    /// </summary>
    private Priority? _priority;

    /// <summary>
    /// The value of the progresbar on each card item.
    /// </summary>
    private double _progress;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the title of the card.
    /// </summary>
    public string? Title
    {
        get { return this._title; }
        set 
        { 
            this._title = value;
            this.OnPropertyChanged(nameof(Title));
        }
    }

    /// <summary>
    /// Gets or sets the description of the card.
    /// </summary>
    public string? Description
    {
        get { return this._description; }
        set 
        { 
            this._description = value;
            this.OnPropertyChanged(nameof(Description));
        }
    }

    /// <summary>
    /// Gets or sets the category of the card. This property is used for column mapping in the Kanban board.
    /// </summary>
    public string? Category
    {
        get { return this._category; }
        set
        { 
            this._category = value;
            this.OnPropertyChanged(nameof(Category));
        }
    }

    /// <summary>
    /// Gets or sets the list of tags associated with the card.
    /// </summary>
    public List<string>? Tags
    {
        get { return this._tags; }
        set 
        { 
            this._tags = value;
            this.OnPropertyChanged(nameof(Tags));
        }
    }

    /// <summary>
    /// Gets or sets the index of the card. This property is used for sorting the cards within a column.
    /// </summary>
    public int Index
    {
        get { return this._index; }
        set 
        { 
            this._index = value;
            this.OnPropertyChanged(nameof(Index));
        }
    }

    /// <summary>
    /// Gets or sets the priority of the card. This property can be used for additional sorting or filtering.
    /// </summary>
    public Priority? Priority
    {
        get { return this._priority; }
        set
        { 
            this._priority = value;
            this.OnPropertyChanged(nameof(Priority));
        }
    }

    /// <summary>
    /// Gets or sets the ProgressBar value associated with the card.
    /// </summary>
    public double Progress
    {
        get { return this._progress; }
        set
        {
            if (this._progress != value)
            {
                this._progress = value;
                this.OnPropertyChanged(nameof(Progress));
            }
        }
    }

    #endregion

    #region Event

    /// <summary>
    /// Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    #endregion

    #region Methods

    /// <summary>
    /// Invokes the event when the value of a property has changed.
    /// </summary>
    /// <param name="propertyName">The name of the property that has changed.</param>
    private void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}

{% endhighlight %}

{% highlight c# tabtitle="SortingViewModel.cs" %}

public class SortingViewModel
{
    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="SortingViewModel"/> class.
    /// </summary>
    public SortingViewModel()
    {
        this.Cards = this.GetCardDetails();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the collection of <see cref="CardDetails"/> objects representing cards in various stages.
    /// </summary>
    public ObservableCollection<CardDetails> Cards { get; set; }

    #endregion

    #region Private method

    /// <summary>
    /// Method to retrieve a predefined collection of Kanban cards with sorting metadata.
    /// </summary>
    /// <returns>The card collection.</returns>
    private ObservableCollection<CardDetails> GetCardDetails()
    {
        var cardDetails = new ObservableCollection<CardDetails>();
        cardDetails.Add(new CardDetails()
        {
            Index = 5,
            Priority = Priority.Medium,
            Title = "Task - 1",
            Category = "Open",
            Description = "Fix the issue reported in the Edge browser.",
            Progress = 0,
            Tags = new List<string> { "Analyze", "Bug" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 2,
            Title = "Task - 3",
            Priority = Priority.Low,
            Category = "Open",
            Description = "Analyze the new requirements gathered from the customer.",
            Progress = 0,
            Tags = new List<string> { "Trial preparation" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 3,
            Title = "Task - 4",
            Priority = Priority.Critical,
            Category = "Open",
            Description = "Arrange a web meeting with the customer to get new requirements.",
            Progress = 0,
            Tags = new List<string> { "Litigation support" }
        });

        cardDetails.Add(new CardDetails()
        {
            Title = "Task - 2",
            Priority = Priority.High,
            Index = 4,
            Category = "In Progress",
            Description = "Test the application in the Edge browser.",
            Progress = 40,
            Tags = new List<string> { "Documentation" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 1,
            Title = "Task - 5",
            Priority = Priority.Medium,
            Category = "Open",
            Description = "Enhance editing functionality.",
            Progress = 0,
            Tags = new List<string> { "Analyze" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 7,
            Title = "Task - 6",
            Priority = Priority.Low,
            Category = "Open",
            Description = "Arrange web meeting with the customer to show editing demo.",
            Progress = 0,
            Tags = new List<string> { "Bug" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 6,
            Title = "Task - 8",
            Priority = Priority.Medium,
            Category = "Done",
            Description = "Improve application performance.",
            Progress = 100,
            Tags = new List<string> { "Litigation support" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 10,
            Title = "Task - 7",
            Priority = Priority.Critical,
            Category = "In Progress",
            Description = "Fix cannot open user's default database SQL error.",
            Progress = 50,
            Tags = new List<string> { "Trial preparation" }
        });

        cardDetails.Add(new CardDetails()
        {
            Title = "Task - 9",
            Priority = Priority.Medium,
            Index = 8,
            Category = "In Progress",
            Description = "Improve the performance of the editing functionality.",
            Progress = 55,
            Tags = new List<string> { "Bug" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 9,
            Title = "Task - 10",
            Priority = Priority.High,
            Category = "Done",
            Description = "Analyze grid control.",
            Progress = 100,
            Tags = new List<string> { "Documentation" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 15,
            Title = "Task - 12",
            Priority = Priority.Low,
            Category = "Done",
            Description = "Analyze stored procedures.",
            Progress = 100,
            Tags = new List<string> { "Trial preparation" }
        });

        cardDetails.Add(new CardDetails()
        {
            Title = "Task - 13",
            Priority = Priority.Medium,
            Index = 20,
            Category = "Code Review",
            Description = "Analyze grid control.",
            Progress = 75,
            Tags = new List<string> { "Documentation" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 18,
            Title = "Task - 14",
            Priority = Priority.Critical,
            Category = "Code Review",
            Description = "Stored procedure for initial data binding of the grid.",
            Progress = 85,
            Tags = new List<string> { "Bug" }
        });

        cardDetails.Add(new CardDetails()
        {
            Index = 23,
            Title = "Task - 15",
            Priority = Priority.Low,
            Category = "Code Review",
            Description = "Analyze stored procedures.",
            Progress = 88,
            Tags = new List<string> { "Analyze" }
        });

        return cardDetails;
    }

    #endregion
}

{% endhighlight %}
{% endtabs %}

## Model property value updation while drag and drop

Another way to sort the target column during drag-and-drop is by updating the dropped card’s SortingMappingPath value based on your custom requirements. In the sample, you can access the target column collection using `e.TargetColumn.Items' in the ``DragEnd` event and apply your own sorting logic.

The following code example illustrate the model property updation functionality.

{% tabs %}
{% highlight XAML hl_lines="3" %}

<kanban:SfKanban x:Name="kanban"
                 ItemsSource="{Binding Cards}"
                 SortingMappingPath="Index"
                 SortingOrder="Ascending"
                 DragEnd="OnCardDragEnd">
    <kanban:SfKanban.BindingContext>
        <local:SortingViewModel/>
    </kanban:SfKanban.BindingContext>
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# hl_lines="2" %}

this.kanban.ItemsSource = new SortingViewModel().Cards;
this.kanban.DragEnd += this.OnCardDragEnd;

private void OnCardDragEnd(object? sender, KanbanDragEndEventArgs e)
{
    this.ApplySortingWithoutPositionChange(e);
}

/// <summary>
/// Applies sorting without changing the position of the cards.
/// </summary>
/// <param name="eventArgs">The event args.</param>
private void ApplySortingWithoutPositionChange(KanbanDragEndEventArgs eventArgs)
{
   // Extract and cast items from the target column
   var targetColumnItems = eventArgs.TargetColumn.Items is IList<object> items
    ? items.Cast<object>().ToList() : new List<object>();

    //You can customize the order of target column collection...
}

{% endhighlight %}
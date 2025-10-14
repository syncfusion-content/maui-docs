---
layout: post
title: Sorting in .NET MAUI Kanban control | Syncfusion®
description: Learn here all about Sorting support in Syncfusion® .NET MAUI Kanban(SfKanban) control and more.
platform: maui
control: Kanban (SfKanban)
documentation: ug
keywords: .net maui Kanban sorting, sfKanban sorting in .net maui, .net maui Kanban sorting support.
---

# Card Item Sorting in .NET MAUI Kanban (SfKanban)

The Kanban control supports customizable card sorting within columns based on specific data fields such as `priority`, `due date`, or `status`. Sorting can be applied programmatically and updated dynamically at runtime using following properties.

* `SortingMappingPath` - Used to map the sorting field to a property name in the `KanbanModel` or `CustomModel`. The default value is `string.Empty`, in which case the cards will not be sorted.
* `SortingOrder` - Used to define the direction of cards sorting within each column.
   * `Ascending` - Cards with lower values appear first.
   * `Descending` - Cards with higher values appear first. 

N> This property is applicable only when a valid value is assigned to `SortingMappingPath`.

## Sorting Behavior in DragEnd Event

The `DragEnd` event in the `Kanban` control supports three sorting approaches:

   * Custom
   * Index
   * ItemsSource Order

### Custom

The SortBy Custom approach must require SortingMappingPath value. In this behavior, cards are sorted and loaded based on the SortingMappingPath value and also cards are dropped based on the SortingMappingPath value to maintain consistent sorting behavior.

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
{% highlight C# %}

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

### Index

SortBy Index approach also depends SortingMappingPath value. This approach allows the users to drop the cards in the Kanban column where the placeholder view is created exactly. It is also helpful to render the cards based on the SortingMappingPath value.

N> The SortingMappingPath property value must be in number format.

The following cases will dynamically change their SortingMappingPath value when dropping the cards.

* If the column has one card and dropped a card to the last position or previous/next cards that do not have continuous order, then the dropped card SortingMappingPath value will be changed based on their previous card value.

* If the column has one card and dropped a card on the previous position, then it will compare both the values, and the dropped card field value will be changed if the cards have continuous order otherwise values will not be changed.

* When the previous and next cards do not have continuous order, the dropped card SortingMappingPath value will be changed based on the previous card value.

* When the previous and next cards have continuous order value, then the SortingMappingPath value of the dropped card and the cards followed by the dropped card will be changed based on the previous card value with continuous order.

For Example,
Continuous Order -
Consider, Column A has Card A with priority value 1, Card B with priority value 2, and Card C with priority value 3.
and Column B has Card D with priority value 5, then the dropped Card D will be placed between Card A and Card B. Now, the Cards D, B, and C will be dynamically changed to the priority values as 2, 3, and 4 respectively.

The following code example illustrate the index updation functionality.

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

{% highlight C# %}

this.kanban.ItemsSource = new SortingViewModel().Cards;
this.kanban.DragEnd += this.OnCardDragEnd;

private void OnCardDragEnd(object? sender, KanbanDragEndEventArgs e)
{
    this.ApplySortingWithoutPositionChange(e);
}

/// <summary>
/// Applies sorting without changing the position of the cards.
/// </summary>
private void ApplySortingWithoutPositionChange(KanbanDragEndEventArgs eventArgs)
{
   if (this.kanban == null || eventArgs.Data == null || eventArgs.TargetColumn?.Items == null || eventArgs.SourceColumn == null || (eventArgs.SourceColumn == eventArgs.TargetColumn && eventArgs.SourceIndex == eventArgs.TargetIndex))
   {
      return;
   }

   // Retrieve sorting configuration
   var sortMappingPath = kanban.SortingMappingPath;
   var sortingOrder = kanban.SortingOrder;

   // Extract and cast items from the target column
   var targetColumnItems = eventArgs.TargetColumn.Items is IList<object> items
      ? items.Cast<object>().ToList() : new List<object>();

   // Proceed only if sorting path is defined
   if (string.IsNullOrEmpty(sortMappingPath))
   {
      return;
   }

   // Sort items based on the sorting order
   if (targetColumnItems.Count > 0)
   {
      Func<object, object?> keySelector = item => this.GetPropertyInfo(item.GetType(), sortMappingPath);

      targetColumnItems = sortingOrder == KanbanSortingOrder.Ascending
         ? targetColumnItems.OrderBy(item => keySelector(item) ?? 0).ToList()
         : targetColumnItems.OrderByDescending(item => keySelector(item) ?? 0).ToList();
   }

   // Determine the index to insert the dragged card.
   int currentCardIndex = eventArgs.TargetIndex;
   if (currentCardIndex >= 0 && currentCardIndex <= targetColumnItems.Count)
   {
      targetColumnItems.Insert(currentCardIndex, eventArgs.Data);
   }
   else
   {
      targetColumnItems.Add(eventArgs.Data);
      currentCardIndex = targetColumnItems.Count - 1;
   }

   // Update index property of all items using smart positioning logic
   this.ApplySmartIndexUpdate(targetColumnItems, sortingOrder, currentCardIndex);
}

/// <summary>
/// Method to get the property info for the specified property.
/// </summary>
private PropertyInfo? GetPropertyInfo(Type type, string key)
{
   return this.GetPropertyInfoCustomType(type, key);
}

/// <summary>
/// Method to get the property info for the specified property from the given type.
/// </summary>
private PropertyInfo? GetPropertyInfoCustomType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] Type type, string key)
{
   return type.GetProperty(key);
}

/// <summary>
/// Updates index property with smart positioning based on sorting order.
/// </summary>
private void ApplySmartIndexUpdate(List<object> items, KanbanSortingOrder sortingOrder, int currentCardIndex)
{
   if (items == null || items.Count == 0)
   {
      return;
   }

   if (sortingOrder == KanbanSortingOrder.Ascending)
   {
      this.HandleAscendingIndexSorting(items, currentCardIndex);
      return;
   }

   this.HandleDescendingIndexSorting(items, currentCardIndex);
}

/// <summary>
/// Method to handle ascending index sorting with smart positioning.
/// </summary>
private void HandleAscendingIndexSorting(List<object> items, int currentCardIndex)
{
   int afterCardIndex = -1;
   int lastItemIndex = -1;

   // Get the index of the card after the insertion point
   if (currentCardIndex < items.Count - 1)
   {
      var afterCard = items[currentCardIndex + 1];
      afterCardIndex = GetCardIndex(afterCard) ?? -1;
   }

   for (int i = 0; i < items.Count; i++)
   {
      var item = items[i];
      if (item == null)
      {
         continue;
      }

      PropertyInfo? propertyInfo = this.GetPropertyInfo(item.GetType(), "Index");
      if (propertyInfo == null)
      {
         continue;
      }

      int itemIndex = Convert.ToInt32(propertyInfo.GetValue(item) ?? 0);
      bool isFirstItem = i == 0;
      if (isFirstItem)
      {
         // If the inserted card is at the beginning, assign a smart index
         if (currentCardIndex == 0)
         {
               lastItemIndex = afterCardIndex > 1 ? afterCardIndex - 1 : 1;
               propertyInfo.SetValue(item, lastItemIndex);
         }
         else
         {
               lastItemIndex = itemIndex;
         }
      }
      else
      {
         // Increment index for subsequent items
         lastItemIndex++;
         propertyInfo.SetValue(item, lastItemIndex);
      }
   }
}

/// <summary>
/// Method to handle descending index sorting with smart positioning.
/// </summary>
private void HandleDescendingIndexSorting(List<object> items, int currentCardIndex)
{
   int beforeCardIndex = -1;
   int lastItemIndex = -1;

   // Get the index of the card before the insertion point
   if (currentCardIndex > 0 && currentCardIndex < items.Count)
   {
      var cardBefore = items[currentCardIndex - 1];
      beforeCardIndex = GetCardIndex(cardBefore) ?? -1;
   }

   for (int i = items.Count - 1; i >= 0; i--)
   {
      var item = items[i];
      if (item == null)
      {
         continue;
      }

      PropertyInfo? propertyInfo = this.GetPropertyInfo(item.GetType(), "Index");
      if (propertyInfo == null)
      {
         continue;
      }

      int itemIndex = Convert.ToInt32(propertyInfo.GetValue(item) ?? 0);
      bool isLastItem = i == items.Count - 1;
      if (isLastItem)
      {
         // If the inserted card is at the end, assign a smart index
         if (currentCardIndex == items.Count - 1)
         {
               lastItemIndex = beforeCardIndex > 1 ? beforeCardIndex - 1 : 1;
               propertyInfo.SetValue(item, lastItemIndex);
         }
         else
         {
               lastItemIndex = itemIndex;
         }
      }
      else
      {
         lastItemIndex++;
         propertyInfo.SetValue(item, lastItemIndex);
      }
   }
}

/// <summary>
/// Method to get the index property value from a card object.
/// </summary>
private int? GetCardIndex(object cardDetails)
{
   if (cardDetails == null)
   {
      return null;
   }

   PropertyInfo? propertyInfo = this.GetPropertyInfo(cardDetails.GetType(), "Index");
   if (propertyInfo == null)
   {
      return null;
   }

   var indexValue = propertyInfo.GetValue(cardDetails);
   if (indexValue != null)
   {
      return Convert.ToInt32(indexValue);
   }

   return null;
}

{% endhighlight %}
{% endtabs %}

### ItemsSource Order

The SortBy ItemsSource order approach does not require any SortingMappingPath value. In this behavior, cards are loaded based on the ItemsSource order, and also cards are dropped where the placeholder view is created exactly.
---
layout: post
title: Liquid Glass Support for .NET MAUI Kanban Board control | Syncfusion®
description: Learn how to enable liquid glass support for the Syncfusion® .NET MAUI Kanban Board control using the EnableLiquidGlassEffect property.
platform: MAUI
control: Kanban (SfKanban)
documentation: ug
---

# Liquid Glass Support

The `SfKanban` supports a liquid glass effect by setting the [EnableLiquidGlassEffect]() property to true. This enhances visual depth and readability when kanban control placed over images or colorful layouts.

## Platform and Version Support

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on macOS 26 and iOS 26 or later.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Apply Liquid Glass Effect to SfKanban

Turn on the liquid glass effect on a kanban by setting [EnableLiquidGlassEffect]() to true.

{% tabs %}
{% highlight xaml hl_lines="3" %}

<Grid>
    <Image Source="liquidglassimage.jpg" 
           EnableLiquidGlassEffect="True"
           x:Name="kanban"
           Aspect="AspectFill"/>
    <kanban:SfKanban x:Name="kanban"
                     Background="Transparent"
                     AutoGenerateColumns="False"
                     ItemsSource="{Binding Cards}"
                     EnableLiquidGlassEffect="True">
        <kanban:SfKanban.Columns>
            <kanban:KanbanColumn Title="To Do"
                                 Categories="Open"/>
            <kanban:KanbanColumn Title="In Progress"
                                 Categories="In Progress"/>
            <kanban:KanbanColumn Title="Code Review"
                                 Categories="Code Review"/>
            <kanban:KanbanColumn Title="Done"
                                 Categories="Done"/>
        </kanban:SfKanban.Columns>
        <kanban:SfKanban.BindingContext>
            <local:KanbanViewModel/>
        </kanban:SfKanban.BindingContext>
    </kanban:SfKanban>
</Grid>

{% endhighlight %}
{% highlight C# hl_lines="1" %}

this.kanban.EnableLiquidGlassEffect = true;

{% endhighlight %}
{% highlight C# tabtitle="KanbanViewModel.cs" %}

public class KanbanViewModel
{
    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="KanbanViewModel"/> class.
    /// </summary>
    public KanbanViewModel()
    {
        this.Cards = this.GetCardDetails();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the collection of <see cref="KanbanModel"/> objects representing cards in various stages.
    /// </summary>
    public ObservableCollection<KanbanModel> Cards { get; set; }

    #endregion

    #region Private methods

    /// <summary>
    /// Method to get the collection of predefined Kanban task cards.
    /// </summary>
    /// <returns>The collection of <see cref="KanbanModel"/> instances.</returns>
    private ObservableCollection<KanbanModel> GetCardDetails()
    {
        Assembly assemblyName = typeof(SfImageSourceConverter).GetTypeInfo().Assembly;
        var cardsDetails = new ObservableCollection<KanbanModel>();

        cardsDetails.Add(new KanbanModel()
        {
            ID = 1,
            Title = "iOS - 1",
            ImageURL = assemblyName + ".people_circle1.png",
            Category = "Open",
            Description = "Analyze customer requirements.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Bug", "Customer", "Release Bug" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 6,
            Title = "Xamarin - 6",
            ImageURL = assemblyName + ".people_circle2.png",
            Category = "Open",
            Description = "Show the retrieved data from the server in Grid control.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 3,
            Title = "iOS - 3",
            ImageURL = assemblyName + ".people_circle3.png",
            Category = "Postponed",
            Description = "Fix the filtering issues reported in Safari.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 11,
            Title = "iOS - 21",
            ImageURL = assemblyName + ".people_circle4.png",
            Category = "Postponed",
            Description = "Add input validation for editing.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 15,
            Title = "Android - 15",
            Category = "Open",
            ImageURL = assemblyName + ".people_circle5.png",
            Description = "Arrange web meetings for customers.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Story", "Kanban" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 3,
            Title = "Android - 3",
            Category = "Code Review",
            ImageURL = assemblyName + ".people_circle6.png",
            Description = "API Improvements.",
            IndicatorFill = Colors.Purple,
            Tags = new List<string> { "Bug", "Customer" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 4,
            Title = "UWP - 4",
            ImageURL = assemblyName + ".people_circle7.png",
            Category = "Code Review",
            Description = "Enhance editing functionality.",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Kanban" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 9,
            Title = "Xamarin - 9",
            ImageURL = assemblyName + ".people_circle8.png",
            Category = "Code Review",
            Description = "Improve application's performance.",
            IndicatorFill = Colors.Orange,
            Tags = new List<string> { "Story", "Kanban" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 13,
            Title = "UWP - 13",
            ImageURL = assemblyName + ".people_circle9.png",
            Category = "In Progress",
            Description = "Add responsive support to applications.",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Kanban" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 17,
            Title = "Xamarin - 17",
            Category = "In Progress",
            ImageURL = assemblyName + ".people_circle10.png",
            Description = "Fix the issues reported in the IE browser.",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Bug", "Customer" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 21,
            Title = "Xamarin - 21",
            Category = "In Progress",
            ImageURL = assemblyName + ".people_circle11.png",
            Description = "Improve the performance of editing functionality.",
            IndicatorFill = Colors.Purple,
            Tags = new List<string> { "Bug", "Customer" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 19,
            Title = "iOS - 19",
            Category = "In Progress",
            ImageURL = assemblyName + ".people_circle12.png",
            Description = "Fix the issues reported by the customer.",
            IndicatorFill = Colors.Purple,
            Tags = new List<string> { "Bug" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 8,
            Title = "Android",
            Category = "Code Review",
            ImageURL = assemblyName + ".people_circle13.png",
            Description = "Check login page validation.",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Feature" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 24,
            Title = "UWP - 24",
            ImageURL = assemblyName + ".people_circle14.png",
            Category = "In Progress",
            Description = "Test editing functionality.",
            IndicatorFill = Colors.Orange,
            Tags = new List<string> { "Feature", "Customer", "Release" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 20,
            Title = "iOS - 20",
            Category = "In Progress",
            ImageURL = assemblyName + ".people_circle15.png",
            Description = "Fix the issues reported in data binding.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Feature", "Release" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 12,
            Title = "Xamarin - 12",
            Category = "In Progress",
            ImageURL = assemblyName + ".people_circle16.png",
            Description = "Test editing functionality.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Feature", "Release" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 11,
            Title = "iOS - 11",
            Category = "In Progress",
            ImageURL = assemblyName + ".people_circle17.png",
            Description = "Check filtering validation.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Feature", "Release" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 13,
            Title = "UWP - 13",
            ImageURL = assemblyName + ".people_circle18.png",
            Category = "Closed",
            Description = "Fix cannot open user's default database SQL error.",
            IndicatorFill = Colors.Purple,
            Tags = new List<string> { "Bug", "Internal", "Release" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 14,
            Title = "Android - 14",
            Category = "Closed",
            ImageURL = assemblyName + ".people_circle19.png",
            Description = "Arrange a web meeting with the customer to get the login page requirement.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Feature" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 15,
            Title = "Xamarin - 15",
            Category = "Closed",
            ImageURL = assemblyName + ".people_circle20.png",
            Description = "Login page validation.",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Bug" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 16,
            Title = "Xamarin - 16",
            ImageURL = assemblyName + ".people_circle21.png",
            Category = "Closed",
            Description = "Test the application in the IE browser.",
            IndicatorFill = Colors.Purple,
            Tags = new List<string> { "Bug" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 20,
            Title = "UWP - 20",
            ImageURL = assemblyName + ".people_circle22.png",
            Category = "Closed",
            Description = "Analyze stored procedure.",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "CustomSample", "Customer", "Incident" }
        });

        cardsDetails.Add(new KanbanModel()
        {
            ID = 21,
            Title = "Android - 21",
            Category = "Closed",
            ImageURL = assemblyName + ".people_circle23.png",
            Description = "Arrange a web meeting with the customer to get editing requirements.",
            IndicatorFill = Colors.Orange,
            Tags = new List<string> { "Story", "Improvement" }
        });

        return cardsDetails;
    }

    #endregion
}

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.

The following screenshot illustrates `SfCardView` with the liquid glass effect enabled over a colorful background.

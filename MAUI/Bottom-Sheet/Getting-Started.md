---
layout: post
title: Getting Started with .NET MAUI Bottom Sheet Control | Syncfusion®
description: Learn how to get started with the Syncfusion® .NET MAUI Bottom Sheet (SfBottomSheet) control and more.
platform: maui
control: SfBottomSheet
documentation: UG
---

# Getting Started with .NET MAUI Bottom Sheet

This section provides a comprehensive overview of how to get started with the [Bottom Sheet]() for .NET MAUI and illustrates how to configure the .NET MAUI Bottom Sheet in a real-time scenario. Follow the steps below to add the .NET MAUI Bottom Sheet to your project.

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI BottomSheet NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.BottomSheet]() and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI BottomSheet NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.BottomSheet` to install the Syncfusion<sup>®</sup> .NET MAUI BottomSheet NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI BottomSheet NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.BottomSheet]() and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler
 
Make sure to add the namespace.
 
{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.
 
{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Create Model

The following code demonstrates how to add a Bottom Sheet that displays detailed book information. It uses a ViewModel for effective data binding to ensure seamless updates and interaction.

Create a simple data model and save it as `Book.cs` file.

{% tabs %}
{% highlight C# %}

public class Book
{
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Published { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Rating { get; set; }
    public decimal Price { get; set; }
}

{% endhighlight %}
{% endtabs %}

## Step 5: Initialize View Model
Create a model repository class with a `Books` collection property initialized with a set of data objects, and save it as `BookViewModel.cs` file:

{% tabs %}
{% highlight C# %}

public class BookViewModel
{
    private ObservableCollection<Book>? _books;

    public ObservableCollection<Book>? Books
    {
        get => _books;
        set
        {
            _books = value;
        }
    }

    public BookViewModel()
    {
        Books = new ObservableCollection<Book>
        {
            new Book
            {
                Title = "Object-Oriented Programming in C#",
                Genre = "Programming, Software Development",
                Published = "July 2023",
                Description = "Object-oriented programming is a programming paradigm based on the concept of objects",
                Rating = 4.7,
                Price = 49.99M
            },
            new Book
            {
                Title = "C# Code Contracts",
                Genre = "Programming",
                Published = "March 2019",
                Description = "Code Contracts provide a way to convey code assumptions",
                Rating = 4.8,
                Price = 39.99M
            },
            new Book
            {
                Title = "Machine Learning Using C#",
                Genre = "Programming, Software Engineering",
                Published = "August 2008",
                Description = "You will learn several different approaches to applying machine learning",
                Rating = 4.7,
                Price = 34.99M
            },
            // Add more items
        };
    }
}

{% endhighlight %}
{% endtabs %}

## Step 6: Import BottomSheet namespace

Add the following namespace in your XAML or C#.
{% tabs %}
{% highlight xaml %}

xmlns:bottomSheet="clr-namespace:Syncfusion.Maui.BottomSheet;assembly=Syncfusion.Maui.BottomSheet"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.BottomSheet;

{% endhighlight %}
{% endtabs %}

## Step 7: Add the Bottom Sheet component

Initialize the `Bottom Sheet` component with properties and events.

{% tabs %}
{% highlight xaml %}

<Grid>
    <Grid.BindingContext>
        <local:BookViewModel />
    </Grid.BindingContext>
    <ListView ItemsSource="{Binding Books}" ItemTapped="OnListViewItemTapped" HasUnevenRows="True">
        <ListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <Grid ColumnDefinitions="*, 60" Padding="10">
                        <VerticalStackLayout>
                            <Label Text="{Binding Title}" FontSize="20" FontAttributes="Bold"/>
                            <Label Text="{Binding Description}" FontSize="14" TextColor="Gray"/>
                        </VerticalStackLayout>
                        <Label Text="{Binding Rating, StringFormat='{}{0} / 5'}" Grid.Column="1" />
                    </Grid>
                </ViewCell>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
    <bottomSheet:SfBottomSheet x:Name="bottomSheet" CornerRadius="15, 15, 0, 0" HalfExpandedRatio="0.35" ContentPadding="10">
        <bottomSheet:SfBottomSheet.BottomSheetContent>
            <VerticalStackLayout Spacing="5" x:Name="bottomSheetContent">
                <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                    <Label Text="Title:" FontSize="20" FontAttributes="Bold"/>
                    <Label Text="{Binding Title}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                </Grid>
                <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                    <Label Text="Genre:" FontSize="20" FontAttributes="Bold"/>
                    <Label Text="{Binding Genre}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                </Grid>
                <!--Add more items -->
            </VerticalStackLayout>
        </bottomSheet:SfBottomSheet.BottomSheetContent>
    </bottomSheet:SfBottomSheet>
</Grid>
    
{% endhighlight %}
{% highlight c# %}

SfBottomSheet bottomSheet;
public MainPage()
{
    InitializeComponent();
    BindingContext ;

    var listView = new ListView
    {
        HasUnevenRows = true
    };

    listView.SetBinding(ListView.ItemsSourceProperty, "Books");

    listView.ItemTemplate = new DataTemplate(() =>
    {
        var titleLabel = new Label
        {
            FontSize = 20,
            FontAttributes = FontAttributes.Bold
        };
        titleLabel.SetBinding(Label.TextProperty, "Title");

        var descriptionLabel = new Label
        {
            FontSize = 14,
            TextColor = Colors.Gray
        };
        descriptionLabel.SetBinding(Label.TextProperty, "Description");

        var stackLayout = new VerticalStackLayout
        {
            Children =
            {
                titleLabel,
                descriptionLabel
            }
        };

        var ratingLabel = new Label();

        ratingLabel.SetBinding(
            Label.TextProperty,
            new Binding("Rating", stringFormat: "{0} / 5"));

        var itemGrid = new Grid
        {
            Padding = 10,
            ColumnDefinitions =
            {
                new ColumnDefinition
                {
                    Width = GridLength.Star
                },
                new ColumnDefinition
                {
                    Width = 60
                }
            }
        };

        itemGrid.Add(stackLayout, 0, 0);
        itemGrid.Add(ratingLabel, 1, 0);

        return new ViewCell
        {
            View = itemGrid
        };
    });

    bottomSheet = new SfBottomSheet
    {
        CornerRadius = new CornerRadius(15, 15, 0, 0),
        HalfExpandedRatio = 0.35,
        ContentPadding = new Thickness(10)
    };

    var bottomSheetContent = new VerticalStackLayout
    {
        Spacing = 5
    };

    void AddRow(string title, string bindingPath)
    {
        var rowGrid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = 120 },
                new ColumnDefinition { Width = GridLength.Star }
            },
            ColumnSpacing = 10
        };

        var titleLabel = new Label
        {
            Text = title,
            FontSize = 20,
            FontAttributes = FontAttributes.Bold
        };

        var valueLabel = new Label
        {
            FontSize = 16,
            VerticalTextAlignment = TextAlignment.Center
        };

        valueLabel.SetBinding(Label.TextProperty, bindingPath);

        rowGrid.Add(titleLabel, 0, 0);
        rowGrid.Add(valueLabel, 1, 0);

        bottomSheetContent.Children.Add(rowGrid);
    }

    AddRow("Title:", "Title");
    AddRow("Genre:", "Genre");

    bottomSheet.BottomSheetContent = bottomSheetContent;

    listView.ItemTapped += OnListViewItemTapped;

    var rootGrid = new Grid();

    rootGrid.Children.Add(listView);
    rootGrid.Children.Add(bottomSheet);

    Content = rootGrid;
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

private void OnListViewItemTapped(object? sender, ItemTappedEventArgs e)
{
    bottomSheet.BottomSheetContent.BindingContext = e.Item;
    bottomSheet.Show();
}

{% endhighlight %}
{% endtabs %}

N> Using [Content](), place the main content inside the Bottom Sheet's `Content` property. Without using `Content`, place the main content outside the [Bottom Sheet](), ensuring that the Bottom Sheet is the last element in the Grid layout.

![Getting Started with Bottom Sheet](images/gettingStarted.png)

You can download the Bottom Sheet Getting Started sample from [here]().
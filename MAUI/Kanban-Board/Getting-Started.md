---
layout: post
title: Getting Started with .NET MAUI Kanban Board control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Kanban Board (SfKanban) control, its elements and more.
platform: maui
control: Kanban
documentation: ug
---

# Getting Started with .NET MAUI Kanban Board (SfKanban)

This section provides a quick overview for working with Essential Kanban for .NET MAUI. It is an efficient way to visualize the workflow at each stage along its path to completion.

## Creating an application using .NET MAUI Kanban Board control

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfKanban to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Kanban and then install it.
3. To initialize the control, import the Kanban namespace.
4. Initialize [SfKanban]().

{% tabs %} 

{% highlight xaml %}

    <ContentPage
        . . .    
        xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban">
        <Grid>
            <kanban:SfKanban/>
        </Grid>
    </ContentPage>
 
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Kanban;
    namespace KanbanGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfKanban kanban = new SfKanban(); 
                this.Content = kanban;
            }
        }   
    }

{% endhighlight %}

{% endtabs %}

## Register the handler

Syncfusion.Maui.Core nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}

    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;
    using Microsoft.Maui.Controls.Compatibility;
    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Controls.Xaml;
    using Syncfusion.Maui.Core.Hosting;

    namespace KanbanGettingStarted
    {
        public static class MauiProgram
        {
            public static MauiApp CreateMauiApp()
            {
                var builder = MauiApp.CreateBuilder();
                builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

                return builder.Build();
            }
        }
    }

{% endhighlight %}

## Initialize view model

Create a ViewModel class with a collection property to hold a collection of [`KanbanModel`]() instances as shown below. Each [`KanbanModel`]() instance represent a card in Kanban control.

{% highlight C# %}

    public class ViewModel
    {
        public ObservableCollection<KanbanModel> Cards { get; set; }
        public ViewModel()
        {
            Cards = new ObservableCollection<KanbanModel>();
            Cards.Add(new KanbanModel()
            {
                ID = 1,
                Title = "iOS - 1002",
                ImageURL = "People_Circle1.png",
                Category = "Open",
                Description = "Analyze customer requirements",
                IndicatorFill = Colors.Red,
                Tags = new string[] { "Incident", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 6,
                Title = "Xamarin - 4576",
                ImageURL = "People_Circle2.png",
                Category = "Open",
                Description = "Show the retrieved data from the server in grid control",
                IndicatorFill = Colors.Green,
                Tags = new string[] { "Story", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 13,
                Title = "UWP - 13",
                ImageURL = "People_Circle3.png",
                Category = "In Progress",
                Description = "Add responsive support to application",
                IndicatorFill = Colors.Brown,
                Tags = new string[] { "Story", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 2543,
                Title = "People_Circle4.png",
                Category = "Code Review",
                ImageURL = "Image3.png",
                Description = "Check login page validation",
                IndicatorFill = Colors.Brown,
                Tags = new string[] { "Story", "Customer" }
            });
        }
    }

{% endhighlight %}

Set the `ViewModel` instance as the `BindingContext` of your Page; this is done to bind properties of `ViewModel` to [`SfKanban`]().

N> Add namespace of ViewModel class in your XAML page if you prefer to set BindingContext in XAML.

{% tabs %}

{% highlight xaml %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="KanbanGettingStarted.MainPage"
                xmlns:chart="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
                xmlns:local="clr-namespace:KanbanGettingStarted"> 

	    <ContentPage.BindingContext>
            <local:ViewModel>
            </local:ViewModel>   
        </ContentPage.BindingContext>
    </ContentPage>

{% endhighlight %}

{% highlight C# %}

    this.BindingContext = new ViewModel();

{% endhighlight %}

{% endtabs %}

## Binding data to SfKanban

Bind the above data to [`SfKanban`]() using [`ItemsSource`]() property.

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban ItemsSource="{Binding Cards}">
    </kanban:SfKanban>

{% endhighlight %}

{% highlight C# %}

    kanban.SetBinding(SfKanban.ItemsSourceProperty, "Cards");

{% endhighlight %}

{% endtabs %}

## Defining columns

The columns are generated automatically based on the different values of [`Category`]() in the [`KanbanModel`]() class from [`ItemsSource`](). But, you can also define the columns by setting [`AutoGenerateColumns`]() property to false and adding [`KanbanColumn`]() instance to [`Columns`]() property of [`SfKanban`]().

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban x:Name="kanban" AutoGenerateColumns="False" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" ItemsSource="{Binding Cards}">

        <kanban:SfKanban.Columns>

            <kanban:KanbanColumn x:Name="openColumn" Title="To Do"  >
            </kanban:KanbanColumn>

            <kanban:KanbanColumn x:Name="progressColumn" Title="In Progress">
            </kanban:KanbanColumn>

            <kanban:KanbanColumn x:Name="codeColumn" Title="Code Review" >
            </kanban:KanbanColumn>

            <kanban:KanbanColumn x:Name="doneColumn" Title="Done"  >
            </kanban:KanbanColumn> 

        </kanban:SfKanban.Columns>

    </kanban:SfKanban> 

{% endhighlight %}

{% highlight C# %}

    kanban.AutoGenerateColumns = false; 
    kanban.SetBinding(SfKanban.ItemsSourceProperty, "Cards");

    KanbanColumn openColumn = new KanbanColumn();
    openColumn.Title = "Open";
    kanban.Columns.Add(openColumn);

    KanbanColumn progressColumn = new KanbanColumn();
    progressColumn.Title = "In Progress";
    kanban.Columns.Add(progressColumn);

    KanbanColumn codeColumn = new KanbanColumn();
    codeColumn.Title = "Code Review";
    kanban.Columns.Add(codeColumn);

    KanbanColumn doneColumn = new KanbanColumn();
    doneColumn.Title = "Done";
    kanban.Columns.Add(doneColumn);

{% endhighlight %}

{% endtabs %}

Define the categories of column using [`Categories`]() property of [`KanbanColumn`]() and cards will be added to the respective columns.

{% highlight C# %}

    openColumn.Categories = new List<object>() { "Open" };
    progressColumn.Categories = new List<object>() { "In Progress" };
    codeColumn.Categories = new List<object>() { "Code Review" };
    doneColumn.Categories = new List<object>() { "Done" };

{% endhighlight %}

This is how the final output will look like. You can download the entire source code of this demo from [here]().
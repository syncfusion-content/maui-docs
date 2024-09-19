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

## Prerequisites

Before starting, ensure the following are set up:

1. .NET 8 SDK (https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. A .NET MAUI development environment is ready with either Visual Studio 2022 (v17.7 or later) or VS Code. If using VS Code, make sure the .NET MAUI workload is installed and configured as per the instructions provided [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

### Visual Studio

1. Go to File > New > Project and choose the .NET MAUI App template.
2. Name the project and choose a location, then click Next.
3. Select the .NET framework version and click Create.

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P` and type .NET:New Project and enter.
2. Choose the .NET MAUI App template.
3. Select the project location, type the project name and press enter.
4. Then choose Create project

## Step 2: Install the Syncfusion MAUI Kanban Board NuGet Package

1. In Solution Explorer, right-click the project and choose Manage NuGet Packages.
2. Search for Syncfusion.Maui.Kanban on [nuget.org](https://www.nuget.org/) and install the latest version.
3. Ensure all dependencies are correctly installed, and restore your project.

## Step 3: Add the Kanban Board Control

1. To initialize the control, import the Chart namespace into your code.
2. Initialize [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html).

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban">
    
    <kanban:SfKanban/>
    
</ContentPage>
 
{% endhighlight %}

{% endtabs %}

You can also create the kanban board programmatically in the MainPage.xaml.cs file:

{% tabs %} 

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

## Step 4: Register the handler

[Syncfusion.Maui.Core nuget](https://www.nuget.org/packages/Syncfusion.Maui.Core) is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

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

## Step 5: Define the View Model

Create a ViewModel class with a collection property to hold a collection of [`KanbanModel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanModel.html) instances as shown below. Each [`KanbanModel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanModel.html) instance represent a card in Kanban control.

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
            Tags = new List<string> { "Incident", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 6,
            Title = "Xamarin - 4576",
            ImageURL = "People_Circle2.png",
            Category = "Open",
            Description = "Show the retrieved data from the server in grid control",
            IndicatorFill = Colors.Green,
            Tags = new List<string> { "Story", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 13,
            Title = "UWP - 13",
            ImageURL = "People_Circle3.png",
            Category = "In Progress",
            Description = "Add responsive support to application",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 2543,
            Title = "IOS- 11",
            Category = "Code Review",
            ImageURL = "People_Circle4.png",
            Description = "Check login page validation",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 123,
            Title = "UWP-21",
            Category = "Done",
            ImageURL = "People_Circle5.png",
            Description = "Check login page validation",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Customer" }
        });
    }
    
}

{% endhighlight %}

## Step 6: Bind the ViewModel

Set the `ViewModel` instance as the `BindingContext` of your Page; this is done to bind properties of `ViewModel` to [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html).

N> Add namespace of ViewModel class in your XAML page if you prefer to set BindingContext in XAML.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="KanbanGettingStarted.MainPage"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
             xmlns:local="clr-namespace:KanbanGettingStarted"> 

    <ContentPage.BindingContext>
        <local:ViewModel/>  
    </ContentPage.BindingContext>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

    this.BindingContext = new ViewModel();

{% endhighlight %}

{% endtabs %}

## Step 7: Bind Data to the Kanban Board

Bind the above data to [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) using [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ItemsSource) property.

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban ItemsSource="{Binding Cards}">
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# %}

kanban.SetBinding(SfKanban.ItemsSourceProperty, "Cards");

{% endhighlight %}

{% endtabs %}

## Step 8: Defining columns in the Kanban Board

The columns are generated automatically based on the different values of [`Category`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanModel.html#Syncfusion_Maui_Kanban_KanbanModel_Category) in the [`KanbanModel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanModel.html) class from [`ItemsSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ItemsSource). But, you can also define the columns by setting [`AutoGenerateColumns`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_AutoGenerateColumns) property to false and adding [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html) instance to [`Columns`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Columns) property of [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html). Define the categories of column using [`Categories`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_Categories) property of [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html) and cards will be added to the respective columns.


{% tabs %}

{% highlight xaml %}

<kanban:SfKanban x:Name="kanban" AutoGenerateColumns="False" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" ItemsSource="{Binding Cards}">

    <kanban:SfKanban.Columns>

        <kanban:KanbanColumn Title="To Do" Categories="Open" >
        </kanban:KanbanColumn>

        <kanban:KanbanColumn Title="In Progress" Categories="In Progress" >
        </kanban:KanbanColumn>

        <kanban:KanbanColumn Title="Code Review" Categories="Code Review" >
        </kanban:KanbanColumn>

        <kanban:KanbanColumn Title="Done" Categories="Done" >
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

openColumn.Categories = new List<object>() { "Open" };
progressColumn.Categories = new List<object>() { "In Progress" };
codeColumn.Categories = new List<object>() { "Code Review" };
doneColumn.Categories = new List<object>() { "Done" };

{% endhighlight %}

{% endtabs %}

## Step 9: Running the Application
Press **F5** to build and run the application. Once compiled, the Kanban board will display with the data provided.

You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/GettingStarted_Kanban_MAUI).
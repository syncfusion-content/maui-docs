---
layout: post
title: Getting started | SfAccordion | MAUI | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Accordion (SfAccordion) control, its elements and more.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Getting Started with MAUI Accordion

This section guides you through setting up and configuring a [Accordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html) in your .NET MAUI application. Follow the steps below to add a basic Accordion to your project.

To quickly get started with the .NET MAUI Accordion, watch this video:

<style>#MAUIAccordionVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIAccordionVideoTutorial' src='https://www.youtube.com/embed/AdZpwD3W2xE'></iframe>

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Expander NuGet Package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.Expander](https://www.nuget.org/packages/Syncfusion.Maui.Expander/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 17" %}
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
}
{% endhighlight %} 
 
## Step 4: Add a Basic Accordion
 
 1. To initialize the control, import the `Syncfusion.Maui.Accordion` namespace into your code.
 2. Initialize [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html).
 
{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">

    <syncfusion:SfAccordion />
</ContentPage>
{% endhighlight %}

{% highlight c# hl_lines="8" %}
using Syncfusion.Maui.Accordion;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAccordion accordion = new SfAccordion();
    }
}
{% endhighlight %}
{% endtabs %}
{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Expander NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Expander` to install the Syncfusion<sup>®</sup> .NET MAUI Expander package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 12" %}
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
}
{% endhighlight %} 
 
## Step 4: Add a Basic Accordion
 
 1. To initialize the control, import the `Syncfusion.Maui.Accordion` namespace into your code.
 2. Initialize [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html).
 
{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage   
    . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">
    <syncfusion:SfAccordion />
</ContentPage>
{% endhighlight %}

{% highlight c# hl_lines="8" %}
using Syncfusion.Maui.Accordion;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAccordion accordion = new SfAccordion();
    }
}
{% endhighlight %}
{% endtabs %}
{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Expander NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Expander](https://www.nuget.org/packages/Syncfusion.Maui.Expander/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 17" %}
using Syncfusion.Maui.Core.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
}
{% endhighlight %} 
 
## Step 4: Add a Basic Accordion
 
 1. To initialize the control, import the `Syncfusion.Maui.Accordion` namespace into your code.
 2. Initialize [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html).
 
{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage   
    . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">
    <syncfusion:SfAccordion />
</ContentPage>
{% endhighlight %}

{% highlight c# hl_lines="8" %}
using Syncfusion.Maui.Accordion;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAccordion accordion = new SfAccordion();
    }
}
{% endhighlight %}
{% endtabs %}
{% endtabcontent %}
{% endtabcontents %}

## Step 5: Define the accordion items

Create the [AccordionItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html) instance that comprise a [header](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_Header) & [content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_Content) and add it into [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items) of `SfAccordion`.

In this example, a Grid is loaded in both the header and content of accordion items.

N> When loading Label as direct children of `Header` or `Content` of `AccordionItem`, then it will lead to an exception. So, load `Label` inside `Grid` to overcome the crash.

{% tabs %}
{% highlight xaml hl_lines="2 3" %}
<syncfusion:SfAccordion x:Name="accordion">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid HeightRequest="48">
                    <Label Text="Robin Rane"
                           FontSize="14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid BackgroundColor="#f4f4f4"
                      Padding="10"
                      RowSpacing="10"
                      ColumnSpacing="15"
                      RowDefinitions="Auto,Auto,Auto"
                      ColumnDefinitions="120,*">
                    <Image Source="emp_01.png"
                           Grid.Row="0"
                           Grid.Column="0"
                           Grid.RowSpan="1"
                           HeightRequest="100"
                           WidthRequest="100" />
                    <StackLayout Grid.Row="0"
                                 Grid.Column="1"
                                 Spacing="8">
                        <Label Text="Position: Chairman"
                               FontSize="12" />
                        <Label Text="Organization: ABC Inc."
                               FontSize="12" />
                        <Label Text="Date Of Birth: 09/17/1973"
                               FontSize="12" />
                        <Label Text="Location: Boston"
                               FontSize="12" />
                    </StackLayout>
                    <Label Grid.Row="1"
                           Grid.Column="0"
                           Grid.ColumnSpan="2"
                           Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision. Under his guidance, the company thrives and continues to make a significant impact in the industry."
                           FontSize="12"
                           LineBreakMode="WordWrap" />
                    <Label Grid.Row="2"
                           Grid.Column="0"
                           Grid.ColumnSpan="2"
                           Text="Phone: (617) 555-1234"
                           FontSize="12" />
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        </syncfusion:AccordionItem>
        ..........................
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var accordion = new SfAccordion();
        var accordionItems = new AccordionItem
        {
            Header = CreateHeader(),
            Content = CreateContent()
        };

        accordion.Items.Add(accordionItems);
        this.Content = accordion;
    }

    private View CreateHeader()
    {
        var headerGrid = new Grid
        {
            HeightRequest = 48
        };

        headerGrid.Children.Add(new Label
        {
            Text = "Robin Rane",
            FontSize = 14
        });

        return headerGrid;
    }

    private View CreateContent()
    {
        var contentGrid = new Grid
        {
            BackgroundColor = Color.FromArgb("#f4f4f4"),
            Padding = 10,
            RowSpacing = 10,
            ColumnSpacing = 15,
            RowDefinitions =
            {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = 120 },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        // Image
        var image = new Image
        {
            Source = "emp_01.png",
            HeightRequest = 100,
            WidthRequest = 100
        };
        Grid.SetRow(image, 0);
        Grid.SetColumn(image, 0);
        contentGrid.Children.Add(image);

        // Details Stack
        var detailsStack = new StackLayout
        {
            Spacing = 8,
            Children =
            {
                new Label { Text = "Position: Chairman", FontSize = 12 },
                new Label { Text = "Organization: ABC Inc.", FontSize = 12 },
                new Label { Text = "Date Of Birth: 09/17/1973", FontSize = 12 },
                new Label { Text = "Location: Boston", FontSize = 12 }
            }
        };
        Grid.SetRow(detailsStack, 0);
        Grid.SetColumn(detailsStack, 1);
        contentGrid.Children.Add(detailsStack);

        // Description Label
        var description = new Label
        {
            Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. Under his guidance, the company thrives and continues to make a significant impact in the industry.",
            FontSize = 12,
            LineBreakMode = LineBreakMode.WordWrap
        };
        Grid.SetRow(description, 1);
        Grid.SetColumn(description, 0);
        Grid.SetColumnSpan(description, 2);
        contentGrid.Children.Add(description);

        // Phone Label
        var phone = new Label
        {
            Text = "Phone: (617) 555-1234",
            FontSize = 12
        };
        Grid.SetRow(phone, 2);
        Grid.SetColumn(phone, 0);
        Grid.SetColumnSpan(phone, 2);
        contentGrid.Children.Add(phone);

        return contentGrid;
    }
}
{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the result of the above code.

<img alt="Syncfuion Maui Accordion defining the items" src="Images\getting-started\maui-accordion-with-defining-accordion-items.png"/> 

You can download accordion sample for .NET MAUI [here](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-accordion).

N> When adding the template control inside the `Grid` with a height set to `Auto`, the child element will not receive the height changes at runtime. Since the `SfAccordion` is a template-based control, the default height value cannot be determined. Therefore, it is recommended to provide the `HorizontalOptions` and `VerticalOptions` as `FillAndExpand` options for the control.

N> You can refer to our [.NET MAUI Accordion](https://www.syncfusion.com/maui-controls/maui-accordion) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Accordion Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Accordion) that shows you how to render and configure the Accordion in .NET MAUI.
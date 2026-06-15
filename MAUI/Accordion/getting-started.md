---
layout: post
title: Getting started | SfAccordion | MAUI | Syncfusion
description: Learn here about getting started with .NET MAUI Accordion (SfAccordion) control, its elements and more.
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
 
{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

Make sure to add the namespace.

{% highlight MauiProgram.cs %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %} 

Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.

{% highlight MauiProgram.cs %}
builder.ConfigureSyncfusionCore();
{% endhighlight %} 

## Step 4: Import the Accordion namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Accordion;
{% endhighlight %}
{% endtabs %}

## Step 5: Add the Accordion component

Create an instance for the Accordion control, and add it as content. Create the [AccordionItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html) instance that comprise a [header](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_Header) & [content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_Content) and add it into [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items) of `SfAccordion`.

In this example, a Grid is loaded in both the header and content of accordion items.

N> When loading Label as direct children of `Header` or `Content` of `AccordionItem`, then it will lead to an exception. So, load `Label` inside `Grid` to overcome the crash.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion>
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid  HeightRequest="48">
                    <Label Text="Can I download and utilize the Syncfusion .NET MAUI Accordion for free?"
                           Margin="16,14,0,14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid  BackgroundColor="#f4f4f4"
                       RowDefinitions="Auto">
                    <Label Text="No, this is a commercial product and requires a paid license. However, a free community license is also available for companies and individuals whose organizations have less than $1 million USD in annual gross revenue, 5 or fewer developers, and 10 or fewer total employees."
                           Margin="16,3,0,3"
                           FontSize="12" />
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid  HeightRequest="48">
                    <Label Text="Why should you choose the Syncfusion .NET MAUI Accordion?"
                           Margin="16,14,0,14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid BackgroundColor="#f4f4f4"
                      RowDefinitions="Auto,Auto,Auto">
                    <Label Grid.Row="0"
                           Text="Easily arrange accordion items vertically."
                           FontSize="12"
                           Margin="16,3,0,3" />
                    <Label Grid.Row="1"
                           Text="Simple configuration and APIs."
                           FontSize="12"
                           Margin="16,3,0,3" />
                    <Label Grid.Row="2"
                           Text="Mobile-touch friendly."
                           FontSize="12"
                           Margin="16,3,0,3" />
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# %}

var accordion = new SfAccordion
{
    Margin = new Thickness(0, 50, 0, 0)
};

var item1 = new AccordionItem();

item1.Header = new Grid
{
    HeightRequest = 48,
    Children =
        {
            new Label
            {
                Text = "Can I download and utilize the Syncfusion .NET MAUI Accordion for free?",
                Margin = new Thickness(16,14,0,14)
            }
        }
};

var contentGrid1 = new Grid
{
    BackgroundColor = Color.FromArgb("#f4f4f4"),
    RowDefinitions =
        {
            new RowDefinition { Height = GridLength.Auto }
        }
};

var contentLabel1 = new Label
{
    Text = "No, this is a commercial product and requires a paid license. However, a free community license is also available for companies and individuals whose organizations have less than $1 million USD in annual gross revenue, 5 or fewer developers, and 10 or fewer total employees.",
    Margin = new Thickness(16, 3, 0, 3),
    FontSize = 12
};

Grid.SetRow(contentLabel1, 0);
contentGrid1.Children.Add(contentLabel1);

item1.Content = contentGrid1;

var item2 = new AccordionItem();

item2.Header = new Grid
{
    HeightRequest = 48,
    Children =
        {
            new Label
            {
                Text = "Why should you choose the Syncfusion .NET MAUI Accordion?",
                Margin = new Thickness(16,14,0,14)
            }
        }
};

var contentGrid2 = new Grid
{
    BackgroundColor = Color.FromArgb("#f4f4f4"),
    RowDefinitions =
        {
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = GridLength.Auto },
            new RowDefinition { Height = GridLength.Auto }
        }
};

var label1 = new Label
{
    Text = "Easily arrange accordion items vertically.",
    FontSize = 12,
    Margin = new Thickness(16, 3, 0, 3)
};
Grid.SetRow(label1, 0);

var label2 = new Label
{
    Text = "Simple configuration and APIs.",
    FontSize = 12,
    Margin = new Thickness(16, 3, 0, 3)
};
Grid.SetRow(label2, 1);

var label3 = new Label
{
    Text = "Mobile-touch friendly.",
    FontSize = 12,
    Margin = new Thickness(16, 3, 0, 3)
};
Grid.SetRow(label3, 2);

contentGrid2.Children.Add(label1);
contentGrid2.Children.Add(label2);
contentGrid2.Children.Add(label3);

item2.Content = contentGrid2;

accordion.Items.Add(item1);
accordion.Items.Add(item2);

Content = accordion;
{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the result of the above code.

<img alt="Defining the Accordion items" src="Images\getting-started\maui-accordion-with-defining-accordion-items.png"/> 

You can download accordion sample for .NET MAUI [here](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-accordion).

N> When adding the template control inside the `Grid` with a height set to `Auto`, the child element will not receive the height changes at runtime. Since the `SfAccordion` is a template-based control, the default height value cannot be determined. Therefore, it is recommended to provide the `HorizontalOptions` and `VerticalOptions` as `FillAndExpand` options for the control.


N> You can refer to our [.NET MAUI Accordion](https://www.syncfusion.com/maui-controls/maui-accordion) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Accordion Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Accordion) that shows you how to render and configure the Accordion in .NET MAUI.
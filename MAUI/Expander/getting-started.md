---
layout: post
title: Getting Started with .NET MAUI Expander control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Expander (SfExpander) control, its elements and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Getting Started with .NET MAUI Expander (SfExpander)

This section guides you through setting up and configuring a [Expander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) in your .NET MAUI application. Follow the steps below to add a basic Expander to your project.

To quickly get started with the .NET MAUI Expander, watch this video:
<style>#MAUIExpanderVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIExpanderVideoTutorial' src='https://www.youtube.com/embed/zTVbps0m8i0'></iframe>

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

{% highlight c# hl_lines="6 22" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
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
 
## Step 4: Add a Basic Expander
 
 1. To initialize the control, import the `Syncfusion.Maui.Expander` namespace into your code.
 2. Initialize [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html).
 
{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander">
    <syncfusion:SfExpander />
</ContentPage>
{% endhighlight %}

{% highlight c# hl_lines="8" %}
using Syncfusion.Maui.Expander;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfExpander expander = new SfExpander();
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

## Step 1: Create a new .NET MAUI Project

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

{% highlight c# hl_lines="6 22" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
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

## Step 4: Add a Basic Expander
 
 1. To initialize the control, import the `Syncfusion.Maui.Expander` namespace into your code.
 2. Initialize [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html).
 
{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander">
    <syncfusion:SfExpander />
</ContentPage>
{% endhighlight %}

{% highlight c# hl_lines="8" %}
using Syncfusion.Maui.Expander;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfExpander expander = new SfExpander();
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

{% highlight c# hl_lines="6 22" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
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
 
## Step 4: Add a Basic Expander
 
 1. To initialize the control, import the `Syncfusion.Maui.Expander` namespace into your code.
 2. Initialize [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html).
 
{% tabs %}
{% highlight xaml hl_lines="4" %}
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander">
    <syncfusion:SfExpander />
</ContentPage>
{% endhighlight %}

{% highlight c# hl_lines="8" %}
using Syncfusion.Maui.Expander;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfExpander expander = new SfExpander();
    }
}
{% endhighlight %}
{% endtabs %}
{% endtabcontent %}
{% endtabcontents %}

## Step 5: Define the Header and Content 

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) is a layout control comprised of the Header and Content. Load any View in the [Header](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Header) and [Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Content). Content visibility of the expander can be set by using the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded) property of the `Expander`. Users can expand or collapse the Content view by tapping the Header.

Here, the Grid with Labels is loaded in the Header and Content of the expander. 

N> Loading the `Label` as direct children of the `Header` or `Content` of the Expander will lead to an exception. So, load the Label inside the Grid to overcome the crash.

{% tabs %}
{% highlight xaml %}
<ContentPage.Content>
    <ScrollView>
        <StackLayout>
            <Label Text="Invoice: #FRU037020142097" FontAttributes="Bold" HorizontalOptions="Center"/>
            <Border StrokeShape="RoundRectangle 8" Margin="8,0,8,8" Stroke="#CAC4D0">
                <Border.Resources>
                    <Style TargetType="Label">
                        <Setter Property="FontFamily" Value="Roboto-Regular"/>
                        <Setter Property="CharacterSpacing" Value="0.25"/>
                    </Style>
                </Border.Resources>
                <syncfusion:SfExpander IsExpanded="True">
                    <syncfusion:SfExpander.Header>
                        <Grid RowDefinitions="48" ColumnDefinitions="35,*">
                            <Label Text="&#xe703;" FontSize="16" Margin="14,2,2,2" VerticalOptions="Center"/>
                            <Label Text="Invoice Date" FontSize="14" Grid.Column="1" VerticalOptions="Center"/>
                        </Grid>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Grid Padding="18,8,0,18">
                            <Label Text="11:03 AM, 15 January 2019" FontSize="14"/>
                        </Grid>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>
            </Border>
            <!-- Repeat similar pattern for other expanders -->
        </StackLayout>
    </ScrollView>
</ContentPage.Content>
{% endhighlight %}
{% highlight c# hl_lines="62 63 64 65 66 67" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Title = "Invoice";

        Content = new ScrollView
        {
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    CreateInvoiceHeader(),
                    CreateInvoiceDate(),
                    CreateItems(),
                    CreatePaymentDetails(),
                    CreateAddress()
                }
            }
        };
    }

    private SfExpander CreateExpander(bool expanded, string icon, string title, View content)
    {
        var headerGrid = new Grid
        {
            ColumnDefinitions =
        {
            new ColumnDefinition { Width = 35 },
            new ColumnDefinition { Width = GridLength.Star }
        },
            HeightRequest = 48
        };

        headerGrid.Add(
            new Label
            {
                Text = icon,
                FontFamily = "AccordionFontIcons",
                FontSize = 16,
                Margin = new Thickness(14, 2),
                VerticalTextAlignment = TextAlignment.Center
            },
            column: 0,
            row: 0
        );

        headerGrid.Add(
            new Label
            {
                Text = title,
                FontFamily = "Roboto-Regular",
                FontSize = 14,
                VerticalOptions = LayoutOptions.Center
            },
            column: 1,
            row: 0
        );

        return new SfExpander
        {
            IsExpanded = expanded,
            Header = headerGrid,
            Content = content
        };
    }

    private View CreateInvoiceHeader()
    {
        return new Label
        {
            Text = "Invoice: #FRU037020142097",
            FontAttributes = FontAttributes.Bold,
            Margin = new Thickness(0, 0, 0, 5),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
    }

    private View CreateInvoiceDate()
    {
        return CreateBorder(CreateExpander(true, "\ue703", "Invoice Date",
                new Grid
                {
                    Padding = new Thickness(18, 8, 0, 18),
                    Children =
                    {
                        new Label
                        {
                            Text = "11:03 AM, 15 January 2019",
                            FontFamily = "Roboto-Regular",
                            FontSize = 14
                        }
                    }
                }
            )
        );
    }

    private View CreateItems()
    {
        var grid = new Grid
        {
            Padding = new Thickness(18, 8, 18, 18),
            ColumnDefinitions = { new ColumnDefinition(), new ColumnDefinition() }
        };

        string[] items =
        {
            "2018 Subaru Outback",
            "All-Weather Mats",
            "Door Edge Guard Kit",
            "Rear Bumper Cover",
            "Wheel Locks",
            "Gas Full Tank",
            "Total Amount"
        };

        string[] prices =
        {
            "$35,705.00",
            "$101.00",
            "$162.00",
            "$107.00",
            "$81.00",
            "$64.00",
            "$36,220.00"
        };

        for (int i = 0; i < items.Length; i++)
        {
            grid.Add(new Label
            {
                Text = items[i],
                FontSize = 14,
                FontFamily = "Roboto-Regular",
                TextColor = i == 6 ? Colors.Blue : Colors.Black
            }, 0, i);

            grid.Add(new Label
            {
                Text = prices[i],
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End,
                TextColor = i == 6 ? Colors.Blue : Colors.Black
            }, 1, i);
        }

        return CreateBorder(CreateExpander(false, "\ue701", "Item(s)", grid));
    }

    private View CreatePaymentDetails()
    {
        var grid = new Grid
        {
            Padding = new Thickness(18, 8, 18, 18),
            ColumnDefinitions = { new ColumnDefinition(), new ColumnDefinition() },
            RowDefinitions =
            {
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition()
            }
        };

        grid.Add(new Label { Text = "Card Payment" }, 0, 0);
        grid.Add(new Label { Text = "$31,200.00", HorizontalOptions = LayoutOptions.End }, 1, 0);

        grid.Add(new Label { Text = "Third-Party coupons" }, 0, 1);
        grid.Add(new Label { Text = "$5,000.00", HorizontalOptions = LayoutOptions.End }, 1, 1);

        grid.Add(new Label
        {
            Text = "Total Amount Paid",
            TextColor = Colors.Blue,
            FontAttributes = FontAttributes.Bold
        }, 0, 2);

        grid.Add(new Label
        {
            Text = "$36,200.00",
            TextColor = Colors.Blue,
            HorizontalOptions = LayoutOptions.End
        }, 1, 2);

        return CreateBorder(CreateExpander(false, "\ue702", "Payment Details", grid));
    }

    private View CreateAddress()
    {
        var grid = new Grid
        {
            Padding = new Thickness(18, 8, 18, 18),
            RowDefinitions =
            {
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition()
            }
        };

        grid.Add(new Label { Text = "Alex", FontAttributes = FontAttributes.Bold }, 0, 0);
        grid.Add(new Label { Text = "No.8 Blossom St, Washington, DC 20019" }, 0, 1);
        grid.Add(new Label { Text = "(202) 547-3555" }, 0, 2);

        return CreateBorder(CreateExpander(true, "\ue704", "Address", grid));
    }

    private View CreateBorder(View content)
    {
        return new Border
        {
            Stroke = Color.FromArgb("#CAC4D0"),
            StrokeThickness = DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 2 : 1,
            StrokeShape = new RoundRectangle { CornerRadius = 8 },
            WidthRequest = DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 460 : DeviceInfo.Platform == DevicePlatform.WinUI ? 340 : -1,
            Margin = new Thickness(8, 0, 8, 8),
            Content = content
        };
    }
}
{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the result of the above code.

<img alt="Syncfusion .NET MAUI Expander Defining the Header and Content" src="Images/maui-expander-getting_started.png" width="404" /> 

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-expander).

N> You can refer to our [.NET MAUI Expander](https://www.syncfusion.com/maui-controls/maui-expander) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Expander Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Expander) that shows you how to render and configure the Expander in .NET MAUI.
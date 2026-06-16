---
layout: post
title: Getting started with .NET MAUI Cartesian Chart control | Syncfusion
description: This section explains about the getting started with Syncfusion® MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian chart, .net maui charting, cartesian chart maui, syncfusion cartesian chart maui, maui chart control, .net maui data visualization, cartesian chart example maui.
---

# Getting Started with .NET MAUI Cartesian Chart 

This section explains how to populate the Cartesian chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the chart.

To get start quickly with our [.NET MAUI Cartesian Chart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html), you can check the below video.

{% youtube "https://www.youtube.com/watch?v=o616GkzdPJk&t=7s" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI Charts Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Maui.Charts/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>®</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="6 17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ChartGettingStarted
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
{% endtabs %} 

## Step 4: Add .NET MAUI Cartesian Chart

1. To initialize the control, import the `Syncfusion.Maui.Charts` namespace.
2. Initialize [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

{% tabs %} 
{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <chart:SfCartesianChart/>

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            SfCartesianChart chart = new SfCartesianChart(); 
            this.Content = chart;            
        }
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

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI Charts Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Charts` to install the Syncfusion<sup>®</sup> .NET MAUI Charts NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>®</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="6 17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ChartGettingStarted
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
{% endtabs %}

## Step 4: Add .NET MAUI Cartesian Chart

1. To initialize the control, import the `Syncfusion.Maui.Charts` namespace.
2. Initialize [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

{% tabs %} 
{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <chart:SfCartesianChart/>

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            SfCartesianChart chart = new SfCartesianChart(); 
            this.Content = chart;            
        }
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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Charts NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Maui.Charts/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

Syncfusion.Maui.Core nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>®</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="6 17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ChartGettingStarted
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
{% endtabs %}

## Step 4: Add .NET MAUI Cartesian Chart

1. To initialize the control, import the `Syncfusion.Maui.Charts` namespace.
2. Initialize [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

{% tabs %} 
{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <chart:SfCartesianChart/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            SfCartesianChart chart = new SfCartesianChart(); 
            this.Content = chart;            
        }
    }   
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

## Step 5: Initialize view model

Now, let us define a simple data model that represents a data point in the chart.

{% tabs %}  

{% highlight c# %}

public class PersonModel      
{   
    public string Name { get; set; }
    public double Height { get; set; }
}

{% endhighlight %} 

{% endtabs %} 

Next, create a `PersonViewModel` class and initialize a list of `PersonModel` objects as follows.

{% tabs %}  

{% highlight c# %}

public class PersonViewModel  
{
    public List<PersonModel> Data { get; set; }      

    public PersonViewModel()       
    {
        Data = new List<PersonModel>()
        {
            new PersonModel { Name = "David", Height = 170 },
            new PersonModel { Name = "Michael", Height = 96 },
            new PersonModel { Name = "Steve", Height = 65 },
            new PersonModel { Name = "Joel", Height = 182 },
            new PersonModel { Name = "Bob", Height = 134 }
        }; 
    }
 }

{% endhighlight %} 

{% endtabs %} 

Set the `PersonViewModel` instance as the `BindingContext` of your page to bind `PersonViewModel` properties to the chart. 
 
N> Add namespace of `PersonViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="ChartGettingStarted.MainPage"
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <ContentPage.BindingContext>
        <model:PersonViewModel/>
    </ContentPage.BindingContext>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

this.BindingContext = new PersonViewModel();

{% endhighlight %}

{% endtabs %} 

## Step 6: Initialize Chart axis

[ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) is used to locate the data points inside the chart area. The [XAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes) and [YAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes) collection of the chart is used to initialize the axis for the chart.

{% tabs %} 

{% highlight xaml %}

<chart:SfCartesianChart>                            
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>                       
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %} 

Run the project and check if you get following output to make sure you have configured your project properly to add a chart.

![Initializing axis for .NET MAUI Chart](Getting-Started_Images/MAUI_chart_initialized.jpg)

## Step 7: Populate Chart with data

As we are going to visualize the comparison of heights in the data model, add [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html) to [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) property of chart, and then bind the `Data` property of the above `PersonViewModel` to the `ColumnSeries.ItemsSource` as follows.

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

N> You need to set [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_YBindingPath)
 properties so that chart will fetch values from the respective properties in the data model to plot the series. 

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="ChartGettingStarted.MainPage"
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <ContentPage.BindingContext>
        <model:PersonViewModel/>
    </ContentPage.BindingContext>

    <chart:SfCartesianChart>

        <chart:SfCartesianChart.Title>
            <Label Text="Height Comparison"/>
        </chart:SfCartesianChart.Title>

        <chart:SfCartesianChart.Legend>
            <chart:ChartLegend/>
        </chart:SfCartesianChart.Legend>

        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis>
                <chart:CategoryAxis.Title>
                    <chart:ChartAxisTitle Text="Name"/>
                </chart:CategoryAxis.Title>
            </chart:CategoryAxis>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis>
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Height(in cm)"/>
                </chart:NumericalAxis.Title>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>

        <!--Initialize the series for chart-->
        <chart:ColumnSeries ItemsSource="{Binding Data}"
                            XBindingPath="Name" 
                            YBindingPath="Height"
                            EnableTooltip="True"
                            ShowDataLabels="True"
                            Label="Height">
            <chart:ColumnSeries.DataLabelSettings>
                <chart:CartesianDataLabelSettings LabelPlacement="Inner"/>
            </chart:ColumnSeries.DataLabelSettings>
        </chart:ColumnSeries>

    </chart:SfCartesianChart>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 

            this.BindingContext = new PersonViewModel();   

            SfCartesianChart chart = new SfCartesianChart();

            chart.Title = new Label()
            {
                Text = "Height Comparison"
            };

            chart.Legend = new ChartLegend ();

            // Initializing primary axis
            CategoryAxis primaryAxis = new CategoryAxis();
            primaryAxis.Title = new ChartAxisTitle()
            {
                Text = "Name",
            };
            chart.XAxes.Add(primaryAxis);

            //Initializing secondary Axis
            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Title = new ChartAxisTitle()
            {
                Text= "Height(in cm)",
            };
            chart.YAxes.Add(secondaryAxis);

            //Initialize the two series for SfChart
            ColumnSeries series = new ColumnSeries()
            {
                ItemsSource = (new PersonViewModel()).Data,
                XBindingPath = "Name",
                YBindingPath = "Height",
                ShowDataLabels = true,
                EnableTooltip = true,
                Label = "Height",
                DataLabelSettings = new CartesianDataLabelSettings()
                {
                    LabelPlacement = DataLabelPlacement.Inner
                }              
            };  

            //Adding Series to the Chart Series Collection
            chart.Series.Add(series);
            this.Content = chart;
        }
    }   
}

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Getting started for .NET MAUI Chart](Getting-Started_Images/MAUI_chart.jpg)

You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/GettingStarted_CartesianChart_MAUI).

N> Looking for the full .NET MAUI Charts component overview, features, pricing, and documentation? Visit the [.NET MAUI Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) page.

---
layout: post
title: Getting Started with .NET MAUI Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Chart (SfFunnelChart) control, its elements, and more.
platform: maui
control: SfFunnelChart
documentation: ug
---

# Getting Started with .NET MAUI Chart

This section explains how to populate the funnel chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the funnel chart.

To get start quickly with our .NET MAUI Funnel Chart, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=wJhqKHduXTI&t=2s" %}

## Creating an application using the .NET MAUI chart

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfFunnelChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Charts and then install it.
3. To initialize the control, import the Chart namespace.
4. Initialize [SfFunnelChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html).

{% tabs %} 

{% highlight xaml %}

<ContentPage   
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <chart:SfFunnelChart/>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .

public partial class MainWindow : ContentPage
{
    public MainPage()
    {
        this.InitializeComponent();
        SfFunnelChart chart = new SfFunnelChart();
        this.Content = chart;
    }
}   
{% endhighlight %}

{% endtabs %}

## Register the handler

Syncfusion.Maui.Core NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}

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

## Initialize view model

Now, let us define a simple data model that represents a data point in the chart.

{% tabs %}  

{% highlight c# %}

public class AdmissionModel
{
    public string XValue { get; set; }
    public double YValue { get; set; }
}

{% endhighlight %} 

{% endtabs %} 

Next, create a view AdmissionViewModel class and initialize a list of `AdmissionModel` objects as follows.

{% tabs %}  

{% highlight c# %}

public class AdmissionViewModel
{
    public List<AdmissionModel> Data { get; set; }

    public AdmissionViewModel()
    {
        Data = new List<AdmissionModel>()
        {
            new AdmissionModel() {XValue = "Enrolled", YValue=175},
            new AdmissionModel() {XValue = "Admits", YValue=190},
            new AdmissionModel() {XValue = "Applicants", YValue=245},
            new AdmissionModel() {XValue = "Inquiries ", YValue=290},
            new AdmissionModel() {XValue = "Prospects ", YValue=320},
        };
    }
}

{% endhighlight %} 

{% endtabs %} 

Create a `AdmissionViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from `AdmissionViewModel` class.

N> Add the namespace of `AdmissionViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <chart:SfFunnelChart>
        <chart:SfFunnelChart.BindingContext>
            <model:AdmissionViewModel/>
        </chart:SfFunnelChart.BindingContext>
    </chart:SfFunnelChart>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
AdmissionViewModel viewModel = new AdmissionViewModel();
chart.BindingContext = viewModel;

{% endhighlight %}

{% endtabs %} 

## Populate chart with data

Binding `Data` to the funnel chart [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ItemsSource) property from its BindingContext to create our own funnel chart.

{% tabs %}   

{% highlight xaml %}

<chart:SfFunnelChart ItemsSource="{Binding Data}" 
                     XBindingPath="XValue" 
                     YBindingPath="YValue">
. . .            
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
AdmissionViewModel viewModel = new AdmissionViewModel();
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Add a title

The title of the chart acts as the title to provide quick information to the user about the data being plotted in the chart. You can set the title using the [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) property of the funnel chart as follows.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart>
    <chart:SfFunnelChart.Title>
        <Label Text="School Admission"/>
    </chart:SfFunnelChart.Title>
    . . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
chart.Title = new Label()
{
    Text = "School Admission"
};
. . .
this.Content = chart;

{% endhighlight %}

{% endtabs %}  

## Enable the data labels

The [ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ShowDataLabels) property of the chart can be used to enable data labels to improve the readability of the funnel chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart ShowDataLabels="True">
    . . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.ShowDataLabels = true;
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Enable a legend

The legend provides information about the data point displayed in the funnel chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property of the chart was used to enable it.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart>
    . . .
    <chart:SfFunnelChart.Legend>
        <chart:ChartLegend/>
    </chart:SfFunnelChart.Legend>
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.Legend = new ChartLegend();
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Enable Tooltip

Tooltips are used to show information about the segment, when mouse over on it. Enable tooltip by setting the chart [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_EnableTooltip) property as `true`.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart EnableTooltip="True">
    . . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.EnableTooltip = true;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

The following code example gives you the complete code of above configurations.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="ChartGettingStarted.MainPage"
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <chart:SfFunnelChart ItemsSource="{Binding Data}" 
                         XBindingPath="XValue" 
                         YBindingPath="YValue"
                         ShowDataLabels="True" 
                         EnableTooltip="True">

        <chart:SfFunnelChart.Title>
            <Label Text="School Admission"/>
        </chart:SfFunnelChart.Title>

        <chart:SfFunnelChart.BindingContext>
            <model:AdmissionViewModel/>
        </chart:SfFunnelChart.BindingContext>

        <chart:SfFunnelChart.Legend>
            <chart:ChartLegend/>
        </chart:SfFunnelChart.Legend>

    </chart:SfFunnelChart>

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .
public partial class MainPage : ContentPage
{   
    public MainWindow()
    {
        SfFunnelChart chart = new SfFunnelChart();
        chart.Title = new Label()
        {
            Text = "School Admission"
        };
        chart.Legend = new ChartLegend();
        AdmissionViewModel viewModel = new AdmissionViewModel();
        chart.BindingContext = viewModel;

        chart.ItemsSource = viewModel.Data;
        chart.XBindingPath = "XValue";
        chart.YBindingPath = "YValue";
        chart.EnableTooltip = true;
        chart.ShowDataLabels = true;
        this.Content = chart;
    }
}

{% endhighlight %}

{% endtabs %}

![Funnel chart in .NET MAUI Chart](Getting-Started_Images/MAUI_funnel_chart.png)

You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/GettingStarted_FunnelChart_MAUI).
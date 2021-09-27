---
layout: post
title: Getting Started with MAUI Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion MAUI Chart (SfCircularChart) control, its elements, and more.
platform: MAUI
control: SfCircularChart
documentation: ug
---

# Getting Started with MAUI Charts (SfCircularChart)

This section explains how to populate the circular chart with data, title, data labels, legend, and tooltips, as well as the essential aspects for getting started with the circular chart.

## Creating an application with MAUI Chart

1. Create a [.NET MAUI app](https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app?pivots=windows#get-started-with-visual-studio-2022-preview).
2. Add reference to [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Chart.WinUI/) NuGet. 
3. To initialize the control, import the SfChart namespace.
4. Initialize [SfCircularChart](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCircularChart.html?tabs=tabid-1).

{% tabs %} 

{% highlight xaml %}

<ContentPage   
    . . .

    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">>

    <chart:SfCircularChart/>
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
        SfCircularChart chart = new SfCircularChart();
    }
}   
{% endhighlight %}

{% endtabs %}

## Initialize View Model

Now, let us define a simple data model that represents a data point in chart.

{% tabs %}  

{% highlight c# %}

public class Sales

{

    public string Product { get; set; }

    public double SalesRate { get; set; }
}

{% endhighlight %} 

{% endtabs %} 

Next, create a view model class and initialize a list of `Model` objects as follows.

{% tabs %}  

{% highlight c# %}

public class ChartViewModel
{
    public List<Sales> Data { get; set; }

    public ChartViewModel()
    {
        Data = new List<Sales>()
        {
            new Sales(){Product = "iPad", SalesRate = 25},
            new Sales(){Product = "iPhone", SalesRate = 35},
            new Sales(){Product = "MacBook", SalesRate = 15},
            new Sales(){Product = "Mac", SalesRate = 5},
            new Sales(){Product = "Others", SalesRate = 10},
        };
    }
}

{% endhighlight %} 

{% endtabs %} 

Create a `ViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from `ViewModel` class.

N> Add namespace of `ViewModel` class to your XAML Page if you prefer to set `BindingContext` in XAML.

{% tabs %} 

{% highlight xaml %} 

<ContentPage
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <chart:SfCircularChart>
        <chart:SfCircularChart.BindingContext>
            <model:ChartViewModel/>
        </chart:SfCircularChart.BindingContext>
    </chart:SfCircularChart>
</Window>

{% endhighlight %}

{% highlight C# %} 

ChartViewModel viewModel = new ChartViewModel();

chart.BindingContext = viewModel;

{% endhighlight %}

{% endtabs %} 

## Populate Chart with Data

Adding [PieSeries](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.PieSeries.html?tabs=tabid-1) to the chart [Series](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) collection and binding `Data` to the series [ItemsSource](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ItemsSource) property from its `BindingContext` for creating our own Product Sales Pie chart.

N> To plot the series, the [XBindingPath](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_YBindingPath) properties must be configured so that the chart may get values from the respective properties in the data model.

{% tabs %}   

{% highlight xaml %}

<chart:SfCircularChart>

. . .

    <chart:SfCircularChart.Series>
        <chart:PieSeries ItemsSource="{Binding Data}" 
                         XBindingPath="Product" 
                         YBindingPath="SalesRate"/>
    </chart:SfCircularChart.Series>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();

ChartViewModel viewModel = new ChartViewModel();

chart.BindingContext = viewModel;

PieSeries series = new PieSeries();

series.ItemsSource = viewModel.Data;

series.XBindingPath = "Product";

series.YBindingPath = "SalesRate";

chart.Series.Add(series);
. . .

{% endhighlight %}

{% endtabs %} 

## Add Title

The title of the chart acts as the title to provide quick information to the user about the data being plotted in the chart. You can set title using the [Title](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) property of circular chart as follows.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>

    <chart:SfCircularChart.Title>
        <Label Text="PRODUCT SALES"/>
    </chart:SfCircularChart.Title>
    . . .
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();

chart.Title = new Label
{
    Text = "PRODUCT SALES"
};

{% endhighlight %}

{% endtabs %}  

## Enable Data Labels

The [ShowDataLabels](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels) property of [CircularSeries](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.CircularSeries.html) can be used to enable data labels to improve the readability of the circular chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}
<chart:SfCircularChart>
. . .
    <chart:PieSeries ShowDataLabels="True"
                     ItemsSource="{Binding Data}" 
                     XBindingPath="Product" 
                     YBindingPath="SalesRate"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();

. . .

PieSeries series = new PieSeries();

series.ShowDataLabels = true;

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %} 

## Enable Legend

The legend provides information about the data point displayed in the circular chart. The [Legend](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property of the chart was used to enable it.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>

    . . .
    <chart:SfCircularChart.Legend>
        <chart:ChartLegend/>
    </chart:SfCircularChart.Legend>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
. . .
chart.Legend = new ChartLegend();

{% endhighlight %}

{% endtabs %} 

## Enable Tooltip

Tooltips are used to show information about the segment, when mouse over on it. Enable tooltip by setting series [ShowTooltip](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowTooltip) property as true.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>

. . .

    <chart:PieSeries ShowTooltip="True"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries();
series.ShowTooltip = true;

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

The following code example gives you the complete code of above configurations.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>

    <chart:SfCircularChart.Title>
        <Label Text="PRODUCT SALES"/>
    </chart:SfCircularChart.Title>
    <chart:SfCircularChart.BindingContext>
        <model:ChartViewModel/>
    </chart:SfCircularChart.BindingContext>
    <chart:SfCircularChart.Legend>
        <chart:ChartLegend/>
    </chart:SfCircularChart.Legend>
    <chart:SfCircularChart.Series>
        <chart:PieSeries ItemsSource="{Binding Data}"                           ShowDataLabels="True"
                         XBindingPath="Product" ShowTooltip="True"
                         YBindingPath="SalesRate">
        </chart:PieSeries>
    </chart:SfCircularChart.Series>
</chart:SfCircularChart>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;

. . .

public partial class MainPage : ContentPage

{
    
    public MainWindow()
    {
        SfCircularChart chart = new SfCircularChart();

        chart.Title = new Label
        {
            Text = "PRODUCT SALES"
        };
        chart.Legend = new ChartLegend();
        ChartViewModel viewModel = new ChartViewModel();
        chart.BindingContext = viewModel;

        PieSeries series = new PieSeries();
        series.ItemsSource = viewModel.Data;
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.ShowTooltip = true;
        series.ShowDataLabels = true;

        chart.Series.Add(series);
        this.Content = chart;
    }
}

{% endhighlight %}

{% endtabs %}

![Pie chart in MAUI Chart](Getting-Started_Images/MAUI_pie_chart.png)


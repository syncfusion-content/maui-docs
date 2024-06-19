---
layout: post
title: Legend in .NET MAUI Chart control | Syncfusion
description: This section explains about how to initialize legend and its customization in Syncfusion .NET MAUI Chart (SfFunnelChart) control.
platform: maui
control: SfFunnelChart
documentation: ug
keywords: .net maui funnel chart, funnel-chart, chart legend, legend-wrap, legend view, legend layout, chart legend items, legend alignment.
---

# Legend in .NET MAUI Chart (SfFunnelChart)

The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) provides a list of data points, helping to identify the corresponding data points in the chart. Here's a detailed guide on how to define and customize the legend in the cartesian chart.

## Define Legend

Defining the legend
To define the legend in the chart, initialize the [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class and assign it to the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property.

{% tabs %}

{% highlight xaml %}

     <chart:SfFunnelChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfFunnelChart.Legend>
            <chart:ChartLegend/>
        </chart:SfFunnelChart.Legend>
    </chart:SfFunnelChart>


{% endhighlight %}

{% highlight c# %}

    SfFunnelChart chart = new SfFunnelChart()
    {
        XBindingPath = "Name",
        YBindingPath = "Height",
        ItemsSource = new ViewModel().Data,
    };

    chart.Legend = new ChartLegend();

{% endhighlight %}

{% endtabs %}

## Legend visibility
The visibility of the chart legend can be controlled using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible) property. By default, the IsVisible property is set to `true`.

{% tabs %}

{% highlight xaml %}
    
    <chart:SfFunnelChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfFunnelChart.Legend>
            <chart:ChartLegend IsVisible = "True" />
        </chart:SfFunnelChart.Legend>
    </chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}


    SfFunnelChart chart = new SfFunnelChart()
    {
        XBindingPath = "Name",
        YBindingPath = "Height",
        ItemsSource = new ViewModel().Data,
    };

    chart.Legend = new ChartLegend(){ IsVisible = true };

{% endhighlight %}

{% endtabs %}

## Legend Icon
Legend icon
To specify the legend icon based on the associated series type, use the [LegendIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_LegendIcon) property and change its type using the [ChartLegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html) enum values. The default value of the LegendIcon property is `Circle`.

{% tabs %}

{% highlight xaml %}

    <chart:SfFunnelChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  LegendIcon="Diamond"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfFunnelChart.Legend>
            <chart:ChartLegend/>
        </chart:SfFunnelChart.Legend>
    </chart:SfFunnelChart> 

{% endhighlight %}

{% highlight c# %}

     SfFunnelChart chart = new SfFunnelChart()
    {
        XBindingPath = "Name",
        YBindingPath = "Height",
        ItemsSource = new ViewModel().Data,
    };

    chart.Legend = new ChartLegend(){ };
    chart.LegendIcon = ChartLegendIconType.Diamond;


{% endhighlight %}

{% endtabs %}

## Placement
The legend can be positioned to the left, right, top, or bottom of the chart area using the [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_Placement) property in the ChartLegend class. The default placement is `Top`.

{% tabs %}

{% highlight xaml %}

    <chart:SfFunnelChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  LegendIcon="Diamond"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfFunnelChart.Legend>
            <chart:ChartLegend Placement="Bottom"  >
            </chart:ChartLegend>
      </chart:SfFunnelChart.Legend>
    </chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

    SfFunnelChart chart = new SfFunnelChart()
    {
        XBindingPath = "Name",
        YBindingPath = "Height",
        ItemsSource = new ViewModel().Data,
    };
   
    chart.Legend = new ChartLegend()
    { Placement = LegendPlacement.Bottom };

{% endhighlight %}

{% endtabs %}

## Legend maximum size request
To set the maximum size request for the legend view, override the [GetMaximumSizeCoefficient]() protected method in [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class. The value should be between 0 and 1, representing the maximum size request, not the desired size for the legend items layout.

{% tabs %}

{% highlight xaml %}
    
    <chart:SfFunnelChart >
    . . .
    <chart:SfFunnelChart.Legend>
        <chart:LegendExt/>
    </chart:SfFunnelChart.Legend>
    . . .
    </chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.7;
        }
    }

    SfFunnelChart chart = new SfFunnelChart();
    chart.Legend = new LegendExt();

{% endhighlight %}

{% endtabs %}

## Items Layout
The [ItemsLayout]() property is used to customize the arrangement and position of each legend item. The default value is `null`. This property accepts any layout type.

For more details about the layout alignment refer to this [article].

{% tabs %}

{% highlight xaml %}

     <chart:SfFunnelChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  LegendIcon="Diamond"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfFunnelChart.Legend>
            <chart:ChartLegend >
            <chart:ChartLegend.ItemsLayout>
              <FlexLayout Wrap="Wrap"
                          WidthRequest="400">
              </FlexLayout>
            </chart:ChartLegend.ItemsLayout>
        </chart:ChartLegend>
      </chart:SfFunnelChart.Legend>
    </chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

    SfFunnelChart chart = new SfFunnelChart()
    {
        XBindingPath = "Name",
        YBindingPath = "Height",
        ItemsSource = new ViewModel().Data,
    };
    . . .
    ChartLegend legend = new ChartLegend();
    legend.Placement = LegendPlacement.Bottom;

    legend.ItemsLayout = new FlexLayout()
    {
        Wrap = FlexWrap.Wrap,
        WidthRequest = 400
    };

    chart.Legend = legend;
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

## Template

Item template
The [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) supports customizing the appearance of legend items using the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) property. The default value of ItemsTemplate is `null`.

N> The BindingContext of the template is the corresponding underlying legend item provided in the ChartLegendItem class.

{% tabs %}

{% highlight xaml %}

    <chart:SfFunnelChart >
        <chart:SfFunnelChart.Resources>
            <DataTemplate x:Key="legendTemplate">
            <StackLayout Orientation="Horizontal" >
                <Rectangle HeightRequest="12" 
                    WidthRequest="12" Margin="3"
                    Background="{Binding IconBrush}"/>
            <Label Text="{Binding Text}" 
                    Margin="3"/>
        </StackLayout>
    </DataTemplate>
    </chart:SfFunnelChart.Resources>  
    
    <chart:SfFunnelChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  
               YBindingPath="Height" x:Name="chart" >
        <chart:SfFunnelChart.Legend>
        <chart:ChartLegend    
               ItemTemplate="{StaticResource legendTemplate}">
        </chart:ChartLegend>
      </chart:SfFunnelChart.Legend>
    </chart:SfFunnelChart>

{% endhighlight %}

{% highlight c# %}

     SfFunnelChart chart = new SfFunnelChart()
    {
        XBindingPath = "Name",
        YBindingPath = "Height",
        ItemsSource = new ViewModel().Data,
    };
     
    ChartLegend legend = new ChartLegend();
    legend.ItemTemplate = chart.Resources["legendTemplate"] as DataTemplate;
    ...
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

## Limitations
* Do not add items explicitly.
* When using BindableLayouts, do not bind ItemsSource explicitly.
* For better UX, arrange items vertically for left and right dock positions, and horizontally for top and bottom dock positions.
* If the layout's measured size is larger than the MaximumHeightRequest, scrolling will be enabled.
* If MaximumHeightRequest is set to 1 and the chart's available size is smaller than the layout's measured size, the series may not have enough space to draw properly.
---
layout: post
title: Legend in .NET MAUI Chart control | Syncfusion
description: This section explains about how to initialize legend and its customization in Syncfusion .NET MAUI Chart (SfPyramidChart) control.
platform: maui
control: SfPyramidChart
documentation: ug
---

# Legend in .NET MAUI Chart (SfPyramidChart)

The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) provides a list of data points, helping to identify the corresponding data points in the chart. Here's a detailed guide on how to define and customize the legend in the pyramid chart.


## Defining the legend
To define the legend in the chart, initialize the [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class and assign it to the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property.


{% tabs %}

{% highlight xaml %}

     <chart:SfPyramidChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"
               YBindingPath="Height" 
               x:Name="chart" >
        <chart:SfPyramidChart.Legend>
            <chart:ChartLegend/>
        </chart:SfPyramidChart.Legend>
    </chart:SfPyramidChart>


{% endhighlight %}

{% highlight c# %}

    SfPyramidChart chart = new SfPyramidChart()
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
    
    <chart:SfPyramidChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfPyramidChart.Legend>
            <chart:ChartLegend IsVisible = "True" />
        </chart:SfPyramidChart.Legend>
    </chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}


    SfPyramidChart chart = new SfPyramidChart()
    {
        XBindingPath = "Name",
        YBindingPath = "Height",
        ItemsSource = new ViewModel().Data,
    };

    chart.Legend = new ChartLegend()
    { 
        IsVisible = true 
    };

{% endhighlight %}

{% endtabs %}

## Legend Icon
To specify the legend icon based on associate series type using the [LegendIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_LegendIcon) and change its type using [ChartLegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html) enum values. The default value of the LegendIcon property is `Circle`.

{% tabs %}

{% highlight xaml %}

    <chart:SfPyramidChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  LegendIcon="Diamond"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfPyramidChart.Legend>
            <chart:ChartLegend/>
        </chart:SfPyramidChart.Legend>
    </chart:SfPyramidChart> 

{% endhighlight %}

{% highlight c# %}

     SfPyramidChart chart = new SfPyramidChart()
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

    <chart:SfPyramidChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  LegendIcon="Diamond"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfPyramidChart.Legend>
            <chart:ChartLegend Placement="Bottom"  >
            </chart:ChartLegend>
      </chart:SfPyramidChart.Legend>
    </chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

    SfPyramidChart chart = new SfPyramidChart()
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

{% highlight xaml %}

    <chart:SfPolarChart >
    . . .
    <chart:SfPolarChart.Legend>
        <chart:LegendExt/>
    </chart:SfPolarChart.Legend>
    . . .
    </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.7;
        }
    }

    SfPolarChart chart = new SfPolarChart();
    chart.Legend = new LegendExt();

{% endhighlight %}

{% endtabs %}


## Items Layout
The [ItemsLayout]() property is used to customize the arrangement and position of each legend item. The default value is `null`. This property accepts any layout type.

For more details about the layout alignment refer to this [article].


{% tabs %}

{% highlight xaml %}

     <chart:SfPyramidChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  LegendIcon="Diamond"
               YBindingPath="Height" x:Name="chart" >
        <chart:SfPyramidChart.Legend>
            <chart:ChartLegend >
            <chart:ChartLegend.ItemsLayout>
              <FlexLayout Wrap="Wrap"
                          WidthRequest="400">
              </FlexLayout>
            </chart:ChartLegend.ItemsLayout>
        </chart:ChartLegend>
      </chart:SfPyramidChart.Legend>
    </chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

    SfPyramidChart chart = new SfPyramidChart()
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

## Item template
The [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) supports customizing the appearance of legend items using the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) property. The default value of ItemsTemplate is `null`.

N> The BindingContext of the template is the corresponding underlying legend item provided in the ChartLegendItem class.


{% tabs %}

{% highlight xaml %}

    <chart:SfPyramidChart >
        <chart:SfPyramidChart.Resources>
            <DataTemplate x:Key="legendTemplate">
            <StackLayout Orientation="Horizontal" >
                <Rectangle HeightRequest="12" 
                    WidthRequest="12" Margin="3"
                    Background="{Binding IconBrush}"/>
            <Label Text="{Binding Text}" 
                    Margin="3"/>
        </StackLayout>
    </DataTemplate>
    </chart:SfPyramidChart.Resources>  
    
    <chart:SfPyramidChart   ItemsSource="{Binding Data}" 
               XBindingPath="Name"  
               YBindingPath="Height" x:Name="chart" >
        <chart:SfPyramidChart.Legend>
        <chart:ChartLegend    
               ItemTemplate="{StaticResource legendTemplate}">
        </chart:ChartLegend>
      </chart:SfPyramidChart.Legend>
    </chart:SfPyramidChart>

{% endhighlight %}


{% highlight c# %}

     SfPyramidChart chart = new SfPyramidChart()
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
* For better UX, arrange items vertically for left and right dock positions, and vice versa for top and bottom dock positions.
* If the layout's measured size is larger than the MaximumHeightRequest, scrolling will be enabled.
* If MaximumHeightRequest is set to 1 and the chart's available size is smaller than the layout's measured size, the series may not have enough space to draw properly.



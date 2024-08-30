---
layout: post
title: Legend in .NET MAUI Chart control | Syncfusion
description: This section explains about how to initialize legend and its customization in Syncfusion .NET MAUI Chart (SfPyramidChart) control.
platform: maui
control: SfPyramidChart
documentation: ug
keywords: .net maui pyramid chart, pyramid-chart, chart legend, legend-wrap, legend view, legend layout, chart legend items, legend alignment.
---

# Legend in .NET MAUI Chart (SfPyramidChart)

The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) provides a list of data points, helping to identify the corresponding data points in the chart. Here's a detailed guide on how to define and customize the legend in the pyramid chart.


## Defining the legend
To define the legend in the chart, initialize the [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class and assign it to the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"
                      YBindingPath="Height">
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
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Legend visibility
The visibility of the chart legend can be controlled using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible) property. By default, the IsVisible property is set to `true`.

{% tabs %}

{% highlight xaml %}
    
<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"
                      YBindingPath="Height">
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend IsVisible = "True"/>
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

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Customizing labels

The appearance of the legend label can be customized using the [`LabelStyle`]() property. 

* [`TextColor`]() – Gets or sets the color of the label.
* [`FontFamily`]() - Gets or sets the font family for the legend label. 
* [`FontAttributes`]() - Gets or sets the font style for the legend label. 
* [`FontSize`]() - Gets or sets the font size for the legend label.
* [`Margin`]() - Gets or sets the margin size of labels.

{% tabs %} 

{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"
                      YBindingPath="Value">
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend>
            <chart:ChartLegend.LabelStyle>
                <chart:ChartLegendLabelStyle TextColor="Blue" Margin="5" FontSize="18" FontAttributes="Bold" FontFamily="PlaywriteAR-Regular"/>
            </chart:ChartLegend.LabelStyle>
        </chart:ChartLegend>
    </chart:SfPyramidChart.Legend>
</chart:SfPyramidChart >

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart()
{
    XBindingPath = "Name",
    YBindingPath = "Value",
    ItemsSource = new ViewModel().Data,
};

chart.Legend = new ChartLegend();
chart.Legend.LabelStyle.TextColor = Color.Blue;
chart.Legend.LabelStyle.FontSize = 18;
chart.Legend.LabelStyle.FontAttributes = FontAttributes.Bold;
chart.Legend.LabelStyle.Margin = 5;
chart.Legend.LabelStyle.FontFamily = "PlaywriteAR-Regular";

{% endhighlight %}

{% endtabs %}

![Legend labels customization support in Maui Chart](Legend-images/legend_label_style.png)

## Legend icon
To specify the legend icon based on associate series type using the [LegendIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_LegendIcon) and change its type using [ChartLegendIconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html) enum values. The default value of the LegendIcon property is `Circle`.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"  LegendIcon="Diamond"
                      YBindingPath="Height">
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
chart.LegendIcon = ChartLegendIconType.Diamond;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Placement
The legend can be positioned to the left, right, top, or bottom of the chart area using the [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_Placement) property in the ChartLegend class. The default placement is `Top`.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"  LegendIcon="Diamond"
                      YBindingPath="Height">
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend Placement="Bottom">
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
{
    Placement = LegendPlacement.Bottom 
};

chart.LegendIcon = ChartLegendIconType.Diamond;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Toggle the series visibility
The visibility of segments in the pyramid chart can be controlled by tapping the legend item using the [ToggleSeriesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html?tabs=tabid-1%2Ctabid-3%2Ctabid-7%2Ctabid-12%2Ctabid-5%2Ctabid-10#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility) property. The default value of ToggleSeriesVisibility is `false`.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"         
                      YBindingPath="Value">
    . . .
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend ToggleSeriesVisibility="True"/>
    </chart:SfPyramidChart.Legend>
    . . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart pyramidChart = new SfPyramidChart()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Name",
    YBindingPath = "Value"
};

pyramidChart.Legend = new ChartLegend()
{
    ToggleSeriesVisibility = true
};

{% endhighlight %}

{% endtabs %}

## Legend maximum size request
To set the maximum size request for the legend view, override the [GetMaximumSizeCoefficient](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_GetMaximumSizeCoefficient) protected method in [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class. The value should be between 0 and 1, representing the maximum size request, not the desired size for the legend items layout.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart >
    . . .
    <chart:SfPyramidChart.Legend>
        <chart:LegendExt/>
    </chart:SfPyramidChart.Legend>
    . . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

public class LegendExt : ChartLegend
{
    protected override double GetMaximumSizeCoefficient()
    {
        return 0.7;
    }
}

SfPyramidChart chart = new SfPyramidChart();
chart.Legend = new LegendExt();
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Items layout
The [ItemsLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemsLayout) property is used to customize the arrangement and position of each legend item. The default value is `null`. This property accepts any layout type.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"  LegendIcon="Diamond"
                      YBindingPath="Height">
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
chart.LegendIcon = ChartLegendIconType.Diamond;
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

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"  
                      YBindingPath="Height" x:Name="chart">
    <chart:SfPyramidChart.Resources>
        <DataTemplate x:Key="legendTemplate">
            <StackLayout Orientation="Horizontal">
                <Rectangle HeightRequest="12" 
                           WidthRequest="12" Margin="3"
                           Background="{Binding IconBrush}"/>
                <Label Text="{Binding Text}" 
                       Margin="3"/>
            </StackLayout>
        </DataTemplate>
    </chart:SfPyramidChart.Resources>  
    
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend ItemTemplate="{StaticResource legendTemplate}">
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
chart.Legend = legend;
this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![Legend layout for pyramid chart](Legend-images/pyramid_chart.png)

## Event 

**LegendItemCreated**

The [`LegendItemCreated`]() event is triggered when the chart legend item is created. The argument contains the [`LegendItem`]() object. The following properties are present in [`LegendItem`]().

* [`Text`]() – used to get or set the text of the label.
* [`TextColor`]() – used to get or set the color of the label.
* [`FontFamily`]() - used to get or set the font family for the legend label. 
* [`FontAttributes`]() - used to get or set the font style for the legend label. 
* [`FontSize`]() - used to get or set the font size for the legend label.
* [`TextMargin`]() - used to get or set the margin size of labels.
* [`IconBrush`]() - used to change the color of the legend icon.
* [`IconType`]() - used to get or set the icon type for the legend icon.
* [`IconHeight`]() - used to get or set the icon height of the legend icon.
* [`IconWidth`]() - used to get or set the icon width of the legend icon.
* [`IsToggled`]() - used to get or set the toggle visibility of the legend.
* [`DisableBrush`]() - used to get or set the color of the legend when toggled.
* [`Index`]() - used to get index position of the legend.
* [`Item`]() - used to get the data object for the associated segment.

## Limitations
* Do not add items explicitly.
* When using BindableLayouts, do not bind ItemsSource explicitly.
* For better UX, arrange items vertically for left and right dock positions, and vice versa for top and bottom dock positions.
* If the layout's measured size is larger than the MaximumHeightRequest, scrolling will be enabled.
* If MaximumHeightRequest is set to 1 and the chart's available size is smaller than the layout's measured size, the series may not have enough space to draw properly.
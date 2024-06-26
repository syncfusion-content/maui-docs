---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: This section explains the features available in the .NET MAUI Chart (SfPyramidChart) control over Xamarin SfChart.
platform: MAUI
control: SfPyramidChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfPyramidChart

The Pyramid Chart was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, a minor code change is required. In addition, [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) has been divided into five chart controls in .NET MAUI for a better user experience and understanding.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
SfChart
</td>
<td>
<div> SfCartesianChart </div>
<div> SfCircularChart </div>
<div> SfFunnelChart </div>
<div> SfPyramidChart </div>
<div> SfPolarChart </div>
</td>
</tr>
</table>

To make the migration easier, the most of the APIs from the Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) were kept in the .NET MAUI [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html). Currently, most of the features have been added to the [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), but only a few are pending in the .NET MAUI, along with some limitations. Please refer to the following details and the API migration information available below.

## API migration

To initialize the control, import the Chart namespace and Initialize [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), as shown in the following code sample. 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}
<ContentPage
    . . .
    xmlns:chart="clr-namespace:Syncfusion.SfChart.XForms;assembly=Syncfusion.SfChart.XForms">

    <chart:SfChart/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}
using Syncfusion.SfChart.XForms;
...

SfChart chart = new SfChart(); 
this.Content = chart;

{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th></tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
   
    <chart:SfPyramidChart/>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .
SfPyramidChart chart = new SfPyramidChart(); 
this.Content = chart; 

{% endhighlight %}

{% endtabs %}
</td>

</tr>
</table>
The following table illustrates the API migration for the chart.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>ColorModel, CustomBrushes</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>ChartBehaviors</td>
<td>TooltipBehavior, SelectionBehavior</td>
</tr>
</table>

### Series
The following properties are given in [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html).

<table>
<tr>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
</tr>
<tr>
<td>Color</td>
<td> - </td>
</tr>
<tr>
<td>ColorModel</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>SelectedDataPointColor</td>
<td>SelectionBrush</td>
</tr>
<tr>
<td>DataMarker</td>
<td>ShowDataLabels, DataLabelSettings</td>
</tr>
</table>

The following code example explains how to migrate the series of Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) to the .NET MAUI [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html).

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
    <chart:PyramidSeries ItemsSource="{Binding Data}" 
                         XBindingPath="Name" 
                         YBindingPath="Value"/>
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
SfChart chart = new SfChart();
. . .
PyramidSeries series = new PyramidSeries();
series.ItemsSource = Data;
series.XBindingPath = "Name";
series.YBindingPath = "Value";
chart.Series.Add(series);
this.Content = chart;
{% endhighlight %}

{% endtabs %}

</td>
</tr>
<tr>
<th>.NET MAUI</th></tr>
<tr>
<td>

{% tabs %} 
{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name" 
                      YBindingPath="Value">
</chart:SfPyramidChart>


{% endhighlight %} 
{% highlight C# %}
SfPyramidChart chart = new SfPyramidChart();
ChartViewModel viewModel = new ChartViewModel();
chart.BindingContext = viewModel;
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "Name";
chart.YBindingPath = "Value";
this.Content = chart;
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Legend

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>DockPosition</td>
<td>Placement</td>
</tr>
<tr>
<td>IsVisible</td>
<td>IsVisible</td>
</tr>
<tr>
<td>Title</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>ToggleSeriesVisibility</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>OverflowMode</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>MaxWidth</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>Orientation</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>IsIconVisible</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>ItemMargin</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>IconWidth</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>IconHeight</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>OffsetX</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>OffsetY</td>
<td><em>Upcoming</em></td>
</tr>
</table>

The following code example shows how to enable legend in chart.

<table>
<tr>
<th>Xamarin</th></tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfChart>
    <chart:SfChart.Legend>
        <chart:ChartLegend/>
    </chart:SfChart.Legend>
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
SfChart chart = new SfChart();
. . .
chart.Legend = new ChartLegend ();
{% endhighlight %}

{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfPyramidChart>
    . . .
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend/>
    </chart:SfPyramidChart.Legend>
</chart:SfPyramidChart>

{% endhighlight %} 

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.Legend = new ChartLegend();
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Data Label

To customize the data label appearance, create an instance of the [ChartDataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataMarker.html) class and add it to the [DataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_DataMarker) of [Series](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html). For [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), you can set the [PyramidDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PyramidDataLabelSettings.html) instance to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_DataLabelSettings) property, as shown in the below code sample.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfChart>  
    <chart:PyramidSeries ItemsSource ="{Binding Data}" 
                         XBindingPath="Name" 
                         YBindingPath="Value">
	    <chart:PyramidSeries.DataMarker>
            <chart:ChartDataMarker ShowLabel="True">
                <chart:ChartDataMarker.LabelStyle>
                    <chart:DataMarkerLabelStyle TextColor="Blue"
                                                BorderColor="Red"
                                                BorderThickness="2"
                                                BackgroundColor="Aqua"
                                                Angle="315"
                                                Margin="5" 
                                                FontSize="18" 
                            FontAttributes="Italic"/>
                </chart:ChartDataMarker.LabelStyle>
            </chart:ChartDataMarker>
	    </chart:PyramidSeries.DataMarker>
    </chart:PyramidSeries>
</chart:SfChart>

{% endhighlight %}
{% highlight C# %}
PyramidSeries series = new PyramidSeries();
. . .
series.DataMarker = new ChartDataMarker();
series.DataMarker.ShowLabel = true;

var style = new DataMarkerLabelStyle();
style.TextColor = Color.Blue;
style.BorderColor = Color.Red;
style.BorderThickness = 2;
style.BackgroundColor = Color.Aqua;
style.Angle = 315;
style.Margin = 5;
style.FontSize = 18;
series.DataMarker.LabelStyle = style;

chart.Series.Add(series);
{% endhighlight %}

{% endtabs %} 
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

 <chart:SfPyramidChart ItemsSource="{Binding Data}" 
                       XBindingPath="Name" 
                       YBindingPath="Value"
                       ShowDataLabels="True">
    <chart:SfPyramidChart.DataLabelSettings>
        <chart:PyramidDataLabelSettings>
            <chart:PyramidDataLabelSettings.LabelStyle>
                <chart:ChartDataLabelStyle TextColor="Blue" 
                                           Stroke="Red"
					                       StrokeWidth="2" 
                                           Background="Aqua" 
                                           Margin="10" 
                                           FontSize="16"
                                           FontAttributes="Bold"/>
            </chart:PyramidDataLabelSettings.LabelStyle>
        </chart:PyramidDataLabelSettings>
    </chart:SfPyramidChart.DataLabelSettings>
 </chart:SfPyramidChart>


{% endhighlight %} 
{% highlight C# %}
SfPyramidChart chart = new SfPyramidChart();
. . .
chart.ShowDataLabels = true;
chart.DataLabelSettings = new PyramidDataLabelSettings();
var style = new ChartDataLabelStyle();
style.TextColor = Colors.Blue;
style.Stroke = Colors.Red;
style.StrokeWidth = 2;
style.Background = Colors.Aqua;
style.Margin = 5;
style.FontSize = 18;
chart.DataLabelSettings.LabelStyle = style;
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Tooltip

To customize the tooltip appearance, create an instance of the [ChartTooltipBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartTooltipBehavior.html) class and add it to the [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), you can directly set the [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property, as shown in the below code sample.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfChart>
    . . . 
    <chart:SfChart.ChartBehaviors>
        <chart:ChartTooltipBehavior BackgroundColor="Blue" 
                                    TextColor="White" 
                                    Margin="5"
                                    FontSize="15"/>
    </chart:SfChart.ChartBehaviors>
    
    <chart:PyramidSeries ItemsSource="{Binding Data}" 
                         XBindingPath="Name"
                         YBindingPath="Value"
                         EnableTooltip="True"/>
</chart:SfChart>

{% endhighlight %} 

{% highlight C# %}
PyramidSeries  series = new PyramidSeries ();
. . .
series.EnableTooltip = true;
chart.Series.Add(series);

ChartTooltipBehavior tool = new ChartTooltipBehavior();
tool.BackgroundColor = Color.Blue;
tool.TextColor = Color.White;
tool.Margin = new Thickness(5, 5, 5, 5);
chart.ChartBehaviors.Add(tool);

{% endhighlight %}

{% endtabs %}

</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data1}" 
                      XBindingPath="Name"  
                      YBindingPath="Value"
                      EnableTooltip="True">
    <chart:SfPyramidChart.TooltipBehavior>
        <chart:ChartTooltipBehavior Background="Blue" 
                                    TextColor="White" 
                                    Margin="5" 
                                    FontSize="15"/>
    </chart:SfPyramidChart.TooltipBehavior>
</chart:SfPyramidChart>

{% endhighlight %} 
{% highlight C# %}
SfPyramidChart chart = new SfPyramidChart();
. . .      
chart.EnableTooltip=true;
ChartTooltipBehavior tooltip = new ChartTooltipBehavior();
tooltip.Background = Colors.Blue;
tooltip.TextColor = Colors.White;
tooltip.Margin = new Thickness(5, 5, 5, 5);
chart.TooltipBehavior = tooltip;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Selection

Create an instance of the [ChartSelectionBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSelectionBehavior.html) class and add it to the  [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), you can directly set the [DataPointSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html?tabs=tabid-1) instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_SelectionBehavior) property, as shown in the below code sample.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfChart>
    ...
	<chart:SfChart.ChartBehaviors>
        <chart:ChartSelectionBehavior/>
    </chart:SfChart.ChartBehaviors>

    <chart:PyramidSeries EnableDataPointSelection="True" 
                         SelectedDataPointIndex="2" 
                         SelectedDataPointColor="Red" 
                         ItemsSource ="{Binding Data}" 
                         XBindingPath="Name" 
                         YBindingPath="Value"/>
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
SfChart chart = new SfChart();
PyramidSeries series = new PyramidSeries();
. . .
series.EnableDataPointSelection = true;
series.SelectedDataPointIndex = 2;
series.SelectedDataPointColor = Color.Red;
ChartSelectionBehavior selectionBehavior = new ChartSelectionBehavior();
chart.ChartBehaviors.Add(selectionBehavior);
chart.Series.Add(series);
{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name"      
                      YBindingPath="Value">
    <chart:SfPyramidChart.SelectionBehavior>
        <chart:DataPointSelectionBehavior SelectedIndex="2" 
                                          SelectionBrush="red"/>
    </chart:SfPyramidChart.SelectionBehavior>
</chart:SfPyramidChart>

{% endhighlight %} 
{% highlight C# %}
SfPyramidChart chart = new SfPyramidChart();
. . .    
DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectedIndex = 1;
selection.SelectionBrush = Colors.Red;
chart.SelectionBehavior = selection;
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Upcoming features in .NET MAUI

**Chart** 

* Listen to property change support for chart.
* Notify event or method when chart is rendering.
* Suspend and resume notification.
* Support for chart animation.
* Exploding segments on touch.

**Legend** 

* Title support for legend. 
* Support to enable or disable the legend icon visibility.
* Legend floating support.
* Event or method to notify the legend click and the creation of a legend item.
* The ability to show/hide corresponding data points by legend item toggle.

**Data label**

* Connector lines customization support.

## Unsupported features from Xamarin.Forms

* In.NET MAUI, the [ChartDataPoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataPoint.html#) model class was no longer available. Instead, create your own model.

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 

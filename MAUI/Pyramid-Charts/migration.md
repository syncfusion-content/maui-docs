---
layout: post
title: Migration from Xamarin to .NET MAUI Pyramid Chart control | Syncfusion
description: This section explains the features available in the .NET MAUI Pyramid Chart (SfPyramidChart) control over Xamarin SfChart.
platform: maui
control: SfPyramidChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfPyramidChart

The Pyramid Chart was created from scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, minor code changes are required. Additionally, the single [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) control has been split into five specialized chart controls in .NET MAUI for improved user experience and clarity.

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

To make migration easier, most of the APIs from Xamarin.Forms [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) have been retained in .NET MAUI [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html). Most features have been implemented, though some are pending or have limitations. Please refer to the API migration information and feature status below.

## API migration

To initialize the control, import the Chart namespace and initialize [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), as shown in the following code samples. 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:chart="clr-namespace:Syncfusion.SfChart.XForms;assembly=Syncfusion.SfChart.XForms">

    <chart:SfChart/>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfChart.XForms;

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
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
   
    <chart:SfPyramidChart/>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;

SfPyramidChart chart = new SfPyramidChart();
// Configure data binding and properties here
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
The following properties are available in [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html).

<table>
<tr>
<th>Xamarin.Forms</th>
<th>.NET MAUI</th>
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
                         XBindingPath="XValue" 
                         YBindingPath="YValue"/>
</chart:SfChart>

{% endhighlight %} 

{% highlight C# %}

SfChart chart = new SfChart();

PyramidSeries series = new PyramidSeries();
series.ItemsSource = Data;
series.XBindingPath = "XValue";
series.YBindingPath = "YValue";
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
                      XBindingPath="XValue" 
                      YBindingPath="YValue">
</chart:SfPyramidChart>


{% endhighlight %} 

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
ChartViewModel viewModel = new ChartViewModel();
chart.BindingContext = viewModel;
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
this.Content = chart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Legend

<table>
<tr>
<th>Xamarin.Forms</th>
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
<td>ToggleSeriesVisibility</td>
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
chart.Legend = new ChartLegend();
this.Content = chart;

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
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend/>
    </chart:SfPyramidChart.Legend>
</chart:SfPyramidChart>

{% endhighlight %} 

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
chart.Legend = new ChartLegend();
this.Content = chart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Data Label

### Data Label

To customize the data label appearance, create an instance of the [ChartDataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataMarker.html) class and add it to the [DataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_DataMarker) of [Series](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html). For [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), you can set the [PyramidDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PyramidDataLabelSettings.html) instance to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_DataLabelSettings) property, as shown in the following code sample.

**Data Label Property Migration**

<table>
<tr>
<th>Xamarin.Forms</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>ChartDataMarker.ShowLabel</td>
<td>SfPyramidChart.ShowDataLabels</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.TextColor</td>
<td>ChartDataLabelStyle.TextColor</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.BorderColor</td>
<td>ChartDataLabelStyle.Stroke</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.BorderThickness</td>
<td>ChartDataLabelStyle.StrokeWidth</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.BackgroundColor</td>
<td>ChartDataLabelStyle.Background</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.Angle</td>
<td>ChartDataLabelStyle.Angle</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.Margin</td>
<td>ChartDataLabelStyle.Margin</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.FontSize</td>
<td>ChartDataLabelStyle.FontSize</td>
</tr>
<tr>
<td>DataMarkerLabelStyle.FontAttributes</td>
<td>ChartDataLabelStyle.FontAttributes</td>
</tr>
</table>

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

SfChart chart = new SfChart();
PyramidSeries series = new PyramidSeries();
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
this.Content = chart;

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
                       XBindingPath="XValue" 
                       YBindingPath="YValue"
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
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.ShowDataLabels = true;
chart.DataLabelSettings = new PyramidDataLabelSettings();
var style = new ChartDataLabelStyle();
style.TextColor = Colors.Blue;
style.Stroke = Colors.Red;
style.StrokeWidth = 2;
style.Background = Colors.Aqua;
style.Margin = 10;
style.FontSize = 16;
style.FontAttributes = FontAttributes.Bold;
chart.DataLabelSettings.LabelStyle = style;
this.Content = chart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Tooltip

To customize the tooltip appearance, create an instance of the [ChartTooltipBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartTooltipBehavior.html) class and add it to the [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), you can directly set the [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property, as shown in the following code sample.

**Tooltip Property Migration**

<table>
<tr>
<th>Xamarin.Forms</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>ChartTooltipBehavior.BackgroundColor</td>
<td>ChartTooltipBehavior.Background</td>
</tr>
<tr>
<td>ChartTooltipBehavior.TextColor</td>
<td>ChartTooltipBehavior.TextColor</td>
</tr>
<tr>
<td>ChartTooltipBehavior.Margin</td>
<td>ChartTooltipBehavior.Margin</td>
</tr>
<tr>
<td>ChartTooltipBehavior.FontSize</td>
<td>ChartTooltipBehavior.FontSize</td>
</tr>
</table>

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
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

SfChart chart = new SfChart();
PyramidSeries  series = new PyramidSeries ();
series.EnableTooltip = true;
chart.Series.Add(series);

ChartTooltipBehavior tool = new ChartTooltipBehavior();
tool.BackgroundColor = Color.Blue;
tool.TextColor = Color.White;
tool.Margin = new Thickness(5, 5, 5, 5);
tool.FontSize = 15;
chart.ChartBehaviors.Add(tool);
this.Content = chart;

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
                      XBindingPath="XValue"  
                      YBindingPath="YValue"
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
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
chart.EnableTooltip = true;
ChartTooltipBehavior tooltip = new ChartTooltipBehavior();
tooltip.Background = Colors.Blue;
tooltip.TextColor = Colors.White;
tooltip.Margin = new Thickness(5, 5, 5, 5);
tooltip.FontSize = 15;
chart.TooltipBehavior = tooltip;
this.Content = chart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Selection

Create an instance of the [ChartSelectionBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSelectionBehavior.html) class and add it to the  [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), you can directly set the [DataPointSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html?tabs=tabid-1) instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_SelectionBehavior) property, as shown in the following code sample.

**Selection Property Migration**

<table>
<tr>
<th>Xamarin.Forms</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>PyramidSeries.EnableDataPointSelection</td>
<td>DataPointSelectionBehavior (automatic on selection)</td>
</tr>
<tr>
<td>PyramidSeries.SelectedDataPointIndex</td>
<td>DataPointSelectionBehavior.SelectedIndex</td>
</tr>
<tr>
<td>PyramidSeries.SelectedDataPointColor</td>
<td>DataPointSelectionBehavior.SelectionBrush</td>
</tr>
</table>

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
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
series.EnableDataPointSelection = true;
series.SelectedDataPointIndex = 2;
series.SelectedDataPointColor = Color.Red;
ChartSelectionBehavior selectionBehavior = new ChartSelectionBehavior();
chart.ChartBehaviors.Add(selectionBehavior);
chart.Series.Add(series);
this.Content = chart;

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
                      XBindingPath="XValue"      
                      YBindingPath="YValue">
    <chart:SfPyramidChart.SelectionBehavior>
        <chart:DataPointSelectionBehavior SelectedIndex="2" 
                                          SelectionBrush="Red"/>
    </chart:SfPyramidChart.SelectionBehavior>
</chart:SfPyramidChart>

{% endhighlight %} 

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "XValue";
chart.YBindingPath = "YValue";
DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectedIndex = 2;
selection.SelectionBrush = Colors.Red;
chart.SelectionBehavior = selection;
this.Content = chart;

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
* Event or method to notify when a legend item is clicked.

**Data label**

* Connector lines customization support.

## Unsupported features from Xamarin.Forms

* In .NET MAUI, the [ChartDataPoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataPoint.html#) model class is no longer available. Instead, create your own model class with the required properties for data binding.

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 
---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: Learn here all about the features available in the .NET MAUI Chart (SfPolarChart) control over Xamarin SfChart.
platform: MAUI
control: SfPolarChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfPolarChart

The Polar Chart was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, a minor code change is required. In addition, [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) has been divided into five chart controls in .NET MAUI for a better user experience and understanding.

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
<div> SfFunnelChart</div>
<div> SfPyramidChart </div>
<div> SfPolarChart </div>
</td>
</tr>
</table>

To make the migration easier, the majority of the APIs from the Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) were kept in the .NET MAUI [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html). Currently, most of the features have been added in the [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html), but only a few are pending in the .NET MAUI along with some limitations. Please refer to the following details and the API migration information available below.

## API migration

To initialize the control, import the Chart namespace and Initialize [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html) as shown in the following code sample. 

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
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
   
    <chart:SfPolarChart/>  
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .
SfPolarChart chart = new SfPolarChart(); 
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
<td>Title</td>
<td>Title</td>
</tr>
<tr>
<td>Legend</td>
<td>Legend</td>
</tr>
<tr>
<td>Series</td>
<td>Series</td>
</tr>
<tr>
<td>PrimaryAxis</td>
<td>PrimaryAxis</td>
</tr>
<tr>
<td>SecondaryAxis</td>
<td>SecondaryAxis</td>
</tr>
<tr>
<td>ColorModel, CustomBrushes</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>ChartBehaviors</td>
<td>TooltipBehavior</td>
</tr>
</table>

### Axis

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>VisibleMinimum</td>
<td>VisibleMinimum</td>
</tr>
<tr>
<td>VisibleMaximum</td>
<td>VisibleMaximum</td>
</tr>
<tr>
<td>VisibleLabels</td>
<td>VisibleLabels</td>
</tr>
<tr>
<td>LabelClicked</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>TickPosition</td>
<td>TickPosition</td>
</tr>
<tr>
<td>MaximumLabels</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>LabelsIntersectAction</td>
<td><em>Upcoming</em></td>
</tr>

</table>

The following code example explains how to migrate the axis of Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) to .NET MAUI [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html).

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %}
{% highlight xaml %}

<chart:SfChart>  
    <chart:SfChart.PrimaryAxis>
	     <chart:CategoryAxis/>
    </chart:SfChart.PrimaryAxis>

    <chart:SfChart.SecondaryAxis>
	     <chart:NumericalAxis/>
    </chart:SfChart.SecondaryAxis>
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
SfChart chart = new SfChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis  =  new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;
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

<chart:SfPolarChart>                            
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis/>
    </chart:SfPolarChart.PrimaryAxis>
    
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.SecondaryAxis>                       
</chart:SfPolarChart>

{% endhighlight %} 
{% highlight C# %}
SfPolarChart chart = new SfPolarChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis  =  new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;
this.Content = chart;
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Series

<table>
<tr>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
</tr>
<tr>
<td>Color</td>
<td>Fill</td>
</tr>
<tr>
<td>DataMarker</td>
<td>ShowDataLabels, DataLabelSettings</td>
</tr>
<tr>
<td>IsClosed</td>
<td>IsClosed</td>
</tr>
</table>

The following code example explains how to migrate the series of Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) to .NET MAUI [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html).

<table>
<tr>
<th>Xamarin</th></tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
    . . .
    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree">
    </chart:PolarAreaSeries>
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
SfChart chart = new SfChart();
. . .
PolarAreaSeries series = new PolarAreaSeries();
series.SetBinding(ChartSeries.ItemsSourceProperty, "PlantDetails");
series.XBindingPath = "Direction";
series.YBindingPath = "Tree";
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

<chart:SfPolarChart>
    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree" ShowDataLabels="True">
    </chart:PolarAreaSeries>
</chart:SfPolarChart>

{% endhighlight %} 
{% highlight C# %}
SfPolarChart chart = new SfPolarChart();
. . .
PolarAreaSeries series = new PolarAreaSeries();
series.ItemsSource = (new ViewModel()).PlantDetails;
series.XBindingPath = "Direction";
series.YBindingPath = "Tree";
series.ShowDataLabels = true;
chart.Series.Add(series);
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
<td>ToggleSeriesVisibility</td>
<td>ToggleSeriesVisibility</td>
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
<td>ItemTemplate</td>
<td>ItemTemplate</td>
</tr>
<tr>
<td>Title</td>
<td><em>Upcoming</em> </td>
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
<td>IconTree</td>
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
<th>Xamarin</th>
</tr>
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

<chart:SfPolarChart>
    <chart:SfPolarChart.Legend>
        <chart:ChartLegend/>
    </chart:SfPolarChart.Legend>
</chart:SfPolarChart>

{% endhighlight %} 

{% highlight C# %}

SfPolarChart chart = new SfPolarChart();
. . .
chart.Legend = new ChartLegend ();
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Data Label

To customize the data label appearance, create an instance of the [ChartDataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataMarker.html) class and add it to the [DataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_DataMarker) of [Series](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html). For [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html), you can set the [PolarDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarDataLabelSettings.html) instance to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_DataLabelSettings) property, as shown in the below code sample.

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
    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree">
	    <chart:PolarAreaSeries.DataMarker>
	        <chart:ChartDataMarker ShowLabel="True">
		        <chart:ChartDataMarker.LabelStyle>
			        <chart:DataMarkerLabelStyle TextColor="Blue" BorderColor="Red" BorderThickness="2" 
                                                            BackgroundColor="Aqua" Angle="315" Margin="5" 
                                                            FontSize="18" FontAttributes="Italic"/>
		        </chart:ChartDataMarker.LabelStyle>
	        </chart:ChartDataMarker>
	    </chart:PolarAreaSeries.DataMarker>
    </chart:PolarAreaSeries>
</chart:SfChart>

{% endhighlight %}
{% highlight C# %}
PolarAreaSeries series = new PolarAreaSeries();
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

<chart:SfPolarChart>
    . . .
    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree" 
                           ShowDataLabels="True">
        <chart:PolarAreaSeries.DataLabelSettings>
            <chart:PolarDataLabelSettings>
                <chart:PolarDataLabelSettings.LabelStyle>
                    <chart:ChartDataLabelStyle TextColor="Blue" Stroke="Red" StrokeWidth="2" Background="Aqua" 
                                               Angle="315" Margin="5" FontSize="18" FontAttributes="Italic"/>
                </chart:PolarDataLabelSettings.LabelStyle>
            </chart:PolarDataLabelSettings>
        </chart:PolarAreaSeries.DataLabelSettings>  
    </chart:PolarAreaSeries>
</chart:SfPolarChart>

{% endhighlight %} 
{% highlight C# %}
PolarAreaSeries series = new PolarAreaSeries();
. . .
series.ShowDataLabels = true;
series.PolarDataLabelSettings = new PolarDataLabelSettings();
var style = new ChartDataLabelStyle();
style.TextColor = Color.Blue;
style.Stroke = Color.Red;
style.StrokeWidth = 2;
style.Background = Color.Aqua;
style.Angle = 315;
style.Margin = 5;
style.FontSize = 18;
series.PolarDataLabelSettings.LabelStyle = style;
chart.Series.Add(series);
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Tooltip

To customize the tooltip appearance, create an instance of the [ChartTooltipBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartTooltipBehavior.html) class and add it to the [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html), you can directly set the [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) property, as shown in the below code sample.

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
        <chart:ChartTooltipBehavior BackgroundColor="Blue" TextColor="White" Margin="5" 
                                    FontSize="15"/>
    </chart:SfChart.ChartBehaviors>
    
    <chart:PolarAreaSeries ItemsSource="{Binding Data}" XBindingPath="Demand" YBindingPath="Year2010"
                           EnableTooltip="True"/>
</chart:SfChart>

{% endhighlight %} 

{% highlight C# %}
PolarAreaSeries series = new PolarAreaSeries();
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

<chart:SfPolarChart>
    . . .
   <chart:SfPolarChart.TooltipBehavior>
        <chart:ChartTooltipBehavior Background="Blue" TextColor="White" Margin="5" 
                                    FontSize="15"/>
   </chart:SfPolarChart.TooltipBehavior>

   <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree"
                          EnableTooltip="True"/>
</chart:SfPolarChart>

{% endhighlight %} 
{% highlight C# %}
PolarAreaSeries series = new PolarAreaSeries();
. . .
series.EnableTooltip = true;
chart.Series.Add(series);

ChartTooltipBehavior tooltip = new ChartTooltipBehavior();
tooltip.BackgroundColor = Color.Blue;
tooltip.TextColor = Color.White;
tooltip.Margin = new Thickness(5, 5, 5, 5);
chart.TooltipBehavior = tooltip;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Upcoming features in .NET MAUI

**Chart** 

* Suspend and resume notification support. 

**Series**

* Listen to property change support for series.
* Notify event or method when series are rendering.
* Suspend and resume notification.

**Axis**

* DateTime category axis support.
* Range style customization.
* Event or method to notify the axis label click.

**Legend** 

* Title support for legend. 
* Support to enable or disable the legend icon visibility.
* Legend floating support.
* Event or method to notify when a legend item is clicked.

## Known issue 

* #FB49487 - Gradient Support for Line-Based Series in .NET MAUI Chart.

## Unsupported features from Xamarin.Forms

* Data label created event support was not provided in series. Instead, you can use the [DrawDataLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_DrawDataLabel_Microsoft_Maui_Graphics_ICanvas_Microsoft_Maui_Controls_Brush_System_String_Microsoft_Maui_Graphics_PointF_System_Int32_) override method in the [ChartSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html) class.
* In.NET MAUI, the [ChartDataPoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataPoint.html) model class was no longer available. Instead, create your own model.

## Limitations

<table>
<tr>
<th>Features</th>
<th>Comments</th>
</tr>
<tr>
<td>LabelRotation</td>
<td>This feature supports for secondary axis only.</td>
</tr>
<tr>
<td>AxisLineStyle</td>
<td>This feature supports for secondary axis only.</td>
</tr>
<tr>
<td>AxisLineOffset</td>
<td>This feature supports for secondary axis only.
</td>
</tr>
<tr>
<td>CrossesAt</td>
<td>This feature is currently not supported for Polar charts.</td>
</tr>
<tr>
<td>RenderNextToCrossingValue</td>
<td>This feature is currently not supported for Polar charts.</td>
</tr>
<tr>
<td>CrossAxisName</td>
<td>This feature is currently not supported for Polar charts.</td>
</tr>
<tr>
<td>Axis Title</td>
<td>This feature supports for secondary axis only.</td>
</tr>
<tr>
<td>EdgeLabelsDrawingMode</td>
<td>This feature supports for secondary axis only.</td>
</tr>
<tr>
<td>EnableAutoIntervalOnZooming</td>
<td>This feature is currently not supported for Polar charts.
</td>
</tr>
<tr>
<td>LabelPlacement</td>
<td>This feature is currently not supported for Primary axis.</td>
</tr>
<tr>
<td>ArrangeByIndex</td>
<td>This feature is currently not supported for Primary axis.
</td>
</tr>
<tr>
<td>AutoScrollingDeltaType</td>
<td>This feature is currently not supported for DateTime axis.</td>
</tr>
<tr>
<td>SelectionBehavior(Upcoming)</td>
<td>This feature is currently not supported for Polar Charts.</td>
</tr>
<tr>
<td>AutoScrollingDelta</td>
<td>This feature is currently not supported for Polar Charts.</td>
</tr>
<tr>
<td>AutoScrollingMode</td>
<td>This feature is currently not supported for Polar Charts.</td>
</tr>
<tr>
<td>ZoomPosition</td>
<td>This feature is currently not supported for Polar Charts.</td>
</tr>
<tr>
<td>ZoomFactor</td>
<td>This feature is currently not supported for Polar Charts.</td>
</tr>
<tr>
<td>ShowTrackballLabel</td>
<td>This feature is not supported for Polar Charts.</td>
</tr>
<tr>
<td>TrackballLabelStyle</td>
<td>This feature is not supported for Polar Charts.</td>
</tr>
</table>

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 

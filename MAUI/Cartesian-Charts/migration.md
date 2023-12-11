---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: This section explains the features available in the .NET MAUI Chart (SfCartesianChart) control over Xamarin SfChart.
platform: MAUI
control: SfCartesianChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfCartesianChart

The Cartesian Chart was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, a minor code change is required. In addition, [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) has been divided into five chart controls in .NET MAUI for a better user experience and understanding.

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
<div> SfPolarChart (<em>Upcoming</em>) </div>
</td>
</tr>
</table>

To make the migration easier, the majority of the APIs from the Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) were kept in the .NET MAUI [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html). Currently, most of the features have been added in the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html), but only a few are pending in the .NET MAUI along with some limitations. Please refer to the following details and the API migration information available below.

## API migration

To initialize the control, import the Chart namespace and Initialize [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) as shown in the following code sample. 

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
   
        <chart:SfCartesianChart/>
   
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .
SfCartesianChart chart = new SfCartesianChart(); 
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
<td>XAxes</td>
</tr>
<tr>
<td>SecondaryAxis</td>
<td>YAxes</td>
</tr>
<tr>
<td>SideBySideSeriesPlacement</td>
<td>EnableSideBySideSeriesPlacement</td>
</tr>
<tr>
<td>ColorModel, CustomBrushes</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>ChartBehaviors</td>
<td>TooltipBehavior, SelectionBehavior, ZoomPanBehavior</td>
</tr>
</table>

### Axis

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>AutoScrollingDelta</td>
<td>AutoScrollingDelta</td>
</tr>
<tr>
<td>AutoScrollingMode</td>
<td>AutoScrollingMode</td>
</tr>
<tr>
<td>AutoScrollingDeltaType</td>
<td>AutoScrollingDeltaType</td>
</tr>
<tr>
<td>LabelRotationAngle</td>
<td>LabelRotation</td>
</tr>
<tr>
<td>OpposedPosition</td>
<td>CrossesAt</td>
</tr>
<tr>
<td>-</td>
<td>CrossAxisName</td>
</tr>
<tr>
<td>PlotOffset</td>
<td>PlotOffsetStart, PlotOffsetEnd</td>
</tr>
<tr>
<td>ShowTrackballInfo</td>
<td>ShowTrackballLabel</td>
</tr>
<tr>
<td>LabelExtent</td>
<td><em>LabelExtent</em></td>
</tr>
<tr>
<td>VisibleMinimum</td>
<td><em>VisibleMinimum</em></td>
</tr>
<tr>
<td>VisibleMaximum</td>
<td><em>VisibleMaximum</em></td>
</tr>
<tr>
<td>VisibleLabels</td>
<td><em>VisibleLabels</em></td>
</tr>
<tr>
<td>LabelClicked</td>
<td><em>Upcoming</em></td>
</tr>

<tr>
<td>TickPosition</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>MaximumLabels</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>LabelsIntersectAction</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>TrackballLabelTemplate</td>
<td><em>Upcoming</em></td>
</tr>
</table>

The following code example explains how to migrate the axis of Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) to .NET MAUI [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

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
	     <chart:NumericalAxis/>
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

NumericalAxis secondaryAxis  =  new NumericalAxis  ();
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

<chart:SfCartesianChart>                            
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
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
<td>ColorModel, CustomBrushes</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>DataMarker</td>
<td>ShowDataLabels, DataLabelSettings</td>
</tr>
</table>

The following code example explains how to migrate the series of Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) to .NET MAUI [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

<table>
<tr>
<th>Xamarin</th></tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
. . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
    XBindingPath="Name" 
    YBindingPath="Height">
	</chart:ColumnSeries>
 </chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
SfChart chart = new SfChart();
. . .

ColumnSeries series = new ColumnSeries();
series.SetBinding(ChartSeries.ItemsSourceProperty, "Data");
series.XBindingPath = "Name";
series.YBindingPath = "Height";
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

<chart:SfCartesianChart>
<chart:ColumnSeries ItemsSource="{Binding Data}"
					XBindingPath="Name"
					YBindingPath="Height">
</chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %} 
{% highlight C# %}
SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries();
series.Label = "Height";
series.ShowDataLabels = true;
series.ItemsSource = (new ViewModel()).Data;
series.XBindingPath = "Name";
series.YBindingPath = "Height";

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
<td>Series</td>
<td><em>Upcoming</em> </td>
</tr>
<tr>
<td>BackgroundColor</td>
<td><em>Upcoming</em> </td>
</tr>
<tr>
<td>StrokeColor</td>
<td><em>Upcoming</em> </td>
</tr>
<tr>
<td>StrokeWidth</td>
<td><em>Upcoming</em> </td>
</tr>
<tr>
<td>StrokeDashArray</td>
<td><em>Upcoming</em> </td>
</tr>
<tr>
<td>CornerRadius</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>Margin</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>LabelStyle</td>
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

<chart:SfCartesianChart>
    <chart:SfCartesianChart.Legend>
		<chart:ChartLegend/>
	</chart:SfCartesianChart.Legend>
</chart:SfCartesianChart>

{% endhighlight %} 

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
chart.Legend = new ChartLegend ();
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Data Label

To customize the data label appearance, create an instance of the [ChartDataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataMarker.html) class and add it to the [DataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_DataMarker) of [Series](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html). For [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html), you can set the [CartesianDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianDataLabelSettings.html) instance to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_DataLabelSettings) property, as shown in the below code sample.

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
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Category"
                        YBindingPath="Value">
	    <chart:ColumnSeries.DataMarker>
	        <chart:ChartDataMarker ShowLabel="True">
		        <chart:ChartDataMarker.LabelStyle>
			        <chart:DataMarkerLabelStyle 
                    TextColor="Blue" 
                    BorderColor="Red" 
                    BorderThickness="2" 
                    BackgroundColor="Aqua" 
                    Angle="315" 
                    Margin="5" FontSize="18" 
                    FontAttributes="Italic"/>
		        </chart:ChartDataMarker.LabelStyle>
	        </chart:ChartDataMarker>
	    </chart:ColumnSeries.DataMarker>
    </chart:ColumnSeries>
</chart:SfChart>

{% endhighlight %}
{% highlight C# %}
ColumnSeries series = new ColumnSeries();
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

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="Category" 
    YBindingPath="Value" ShowDataLabels="True">
        <chart:ColumnSeries.DataLabelSettings>
            <chart:CartesianDataLabelSettings>
                <chart:CartesianDataLabelSettings.LabelStyle>
                    <chart:ChartDataLabelStyle 
                    TextColor="Blue" 
                    Stroke="Red" 
                    StrokeWidth="2" 
                    Background="Aqua" 
                    Angle="315" 
                    Margin="5" 
                    FontSize="18" 
                    FontAttributes="Italic"/>
                </chart:CartesianDataLabelSettings.LabelStyle>
            </chart:CartesianDataLabelSettings>
        </chart:ColumnSeries.DataLabelSettings>  
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %} 
{% highlight C# %}
ColumnSeries series = new ColumnSeries();
. . .
series.ShowDataLabels = true;
series.CartesianDataLabelSettings = new CartesianDataLabelSettings();
var style = new ChartDataLabelStyle();
style.TextColor = Color.Blue;
style.Stroke = Color.Red;
style.StrokeWidth = 2;
style.Background = Color.Aqua;
style.Angle = 315;
style.Margin = 5;
style.FontSize = 18;
series.CartesianDataLabelSettings.LabelStyle = style;

chart.Series.Add(series);
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Tooltip

To customize the tooltip appearance, create an instance of the [ChartTooltipBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartTooltipBehavior.html) class and add it to the [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html), you can directly set the [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property, as shown in the below code sample.

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
	      <chart:ChartTooltipBehavior 
          BackgroundColor="Blue" 
          TextColor="White" 
          Margin="5" 
          FontSize="15"/>
    </chart:SfChart.ChartBehaviors>
    
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        EnableTooltip="True"/>
</chart:SfChart>

{% endhighlight %} 

{% highlight C# %}
ColumnSeries series = new ColumnSeries();
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

<chart:SfCartesianChart>
. . .
   <chart:SfCartesianChart.TooltipBehavior>
        <chart:ChartTooltipBehavior 
        Background="Blue" 
        TextColor="White" 
        Margin="5" 
        FontSize="15"/>
   </chart:SfCartesianChart.TooltipBehavior>

   <chart:ColumnSeries ItemsSource="{Binding Data}" 
                       XBindingPath="Demand"
                       YBindingPath="Year2010"
                       EnableTooltip="True"/>
</chart:SfCartesianChart>

{% endhighlight %} 
{% highlight C# %}
ColumnSeries series = new ColumnSeries();
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

### Selection

Create an instance of the [ChartSelectionBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSelectionBehavior.html) class and add it to the  [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html), you can directly set the [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html) instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionBehaviorr) property, as shown in the below code sample.

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

    <chart:ColumnSeries EnableDataPointSelection="True" 
            SelectedDataPointIndex="2" 
            SelectedDataPointColor="Red" 
            ItemsSource ="{Binding Data}" 
            XBindingPath="Demand" 
            YBindingPath="Year2010" />
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
ColumnSeries series = new ColumnSeries();
. . .
columnSeries.EnableDataPointSelection = true;

chart.Series.Add(series);
ChartSelectionBehavior selectionBehavior = new ChartSelectionBehavior();

chart.ChartBehaviors.Add(selectionBehavior);
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

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Name"
                        YBindingPath="Height">
                <chart:ColumnSeries.SelectionBehavior>
                        <chart:DataPointSelectionBehavior SelectionBrush="#314A6E"/>
                </chart:ColumnSeries.SelectionBehavior>
        </chart:ColumnSeries>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %} 
{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectionBrush=Color.FromArgb("#314A6E");

ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Name",
    YBindingPath = "Height",
    SelectionBehavior = selection
};

chart.Series.Add(series);
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

N> For more information about selection check [here](https://help.syncfusion.com/maui/cartesian-charts/selection).

### Zooming and Panning

The zooming and panning are achieved using the [ChartZoomPanBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartZoomPanBehavior.html) in [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) and [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) as shown in the below code example.

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
		<chart:ChartZoomPanBehavior EnableZooming="True"/>
	</chart:SfChart.ChartBehaviors>
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
ChartZoomPanBehavior zoomPanBehavior = new ChartZoomPanBehavior();

chart.ChartBehaviors.Add(zoomPanBehavior);
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

<chart:SfCartesianChart>
    <chart:SfCartesianChart.ZoomPanBehavior>
        <chart:ChartZoomPanBehavior EnablePinchZooming="True"/>
    </chart:SfCartesianChart.ZoomPanBehavior>
</chart:SfCartesianChart>

{% endhighlight %} 
{% highlight C# %}
ChartZoomPanBehavior zooming = new ChartZoomPanBehavior();
chart.ZoomPanBehavior = zooming;
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Upcoming features in .NET MAUI

**Chart** 
 
* Support for crosshair interactions. 
* Support for chart localization. 
* Support for annotations. 
* Suspend and resume notification support. 
* Technical indicators for charts.

**Series**

* Listen to property change support for series.
* Get data point index based on value.
* Get data points by passing rect.
* Notify event or method when series are rendering.
* Suspend and resume notification.
* Trendlines support for continuous series. 

**Axis**

* DateTime category axis support.
* Align the axis labels and tick inside the series clip rect.
* Range style customization.
* Event or method to notify the axis label click.
* Axis label wrapping support.
* Support for axis draw labels as multiple lines using /n.
* Striplines for range base axis.
* Support setting the maximum labels count for the chart axis.

**Legend** 

* Title support for legend. 
* Support to enable or disable the legend icon visibility.
* Legend items wrap and floating support.
* Maximum width support for Legend.
* Individual legend items based on the data point count.
* Event or method to notify the legend click and the creation of a legend item.

**Data label**

* DataTemplate support for data labels.
* Connector lines and its customization support.

**Selection**

* Cluster selection support.

**Zooming**

* Support setting the maximum zoom level.
* Event for zooming and panning.

## Known issue 

* [iOS] [#9135](https://github.com/dotnet/maui/issues/9135) - The chart legend was taking up a huge amount of vertical space or becoming hidden. 
* The trackball behavior is currently not supported with stacked column charts.

## Unsupported features from Xamarin.Forms

* Only continuous series will support data marker symbols.
* Data label created event support was not provided in series. Instead, you can use the [DrawDataLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_DrawDataLabel_Microsoft_Maui_Graphics_ICanvas_Microsoft_Maui_Controls_Brush_System_String_Microsoft_Maui_Graphics_PointF_System_Int32_) override method in the [ChartSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html) class.
* [OpposedPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartAxis.html#Syncfusion_SfChart_XForms_ChartAxis_OpposedPosition) property was not exposed in axis. Instead, you can move to the axis opposed position by setting the [CrossesAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_CrossesAt) value as `double.MaxValue.`
* [RangeStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartAxis.html#Syncfusion_SfChart_XForms_ChartAxis_RangeStyles) support was not provided in the axis. Instead, you can use [DrawMajorTick](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_DrawMajorTick_Microsoft_Maui_Graphics_ICanvas_System_Double_Microsoft_Maui_Graphics_PointF_Microsoft_Maui_Graphics_PointF_), [DrawMinorTick](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_DrawMinorTick_Microsoft_Maui_Graphics_ICanvas_System_Double_Microsoft_Maui_Graphics_PointF_Microsoft_Maui_Graphics_PointF_) and [DrawGridLine](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_DrawGridLine_Microsoft_Maui_Graphics_ICanvas_System_Double_System_Single_System_Single_System_Single_System_Single_) override methods provided in the axis class.
* In.NET MAUI, the [ChartDataPoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataPoint.html#) model class was no longer available. Instead, create your own model.


## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 

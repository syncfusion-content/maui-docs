---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: This section explains the features available in the .NET MAUI Chart (SfCircularChart) control over Xamarin SfChart.
platform: MAUI
control: SfCircularChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfCircularChart

The Circular Chart was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, a minor code change is required. In addition, [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) has been divided into five chart controls in .NET MAUI for a better user experience and understanding.

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
<div> SfPolarChart (Upcoming) </div>
</td>
</tr>
</table>

To make the migration easier, the majority of the APIs from the Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) were kept in the .NET MAUI [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html). Currently, most of the features have been added in the [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html), but only a few are pending in the .NET MAUI along with some limitations. Please refer to the following details and the API migration information available below.

## API migration

To initialize the control, import the Chart namespace and Initialize [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html) as shown in the following code sample. 

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
   
        <chart:SfCircularChart/>
   
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .
SfCircularChart chart = new SfCircularChart(); 
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
<td>TooltipBehavior, SelectionBehavior, ZoomPanBehavior</td>
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
<td>ColorModel</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>DataMarker</td>
<td>ShowDataLabels, DataLabelSettings</td>
</tr>
</table>

The following code example explains how to migrate the series of Xamarin [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) to the .NET MAUI [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
    <chart:PieSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate">
		 </chart:PieSeries>
 </chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
SfChart chart = new SfChart();
. . .
PieSeries series = new PieSeries();
series.ItemsSource = viewModel.Data;
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
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

<chart:SfCircularChart>
    <chart:PieSeries ItemsSource="{Binding Data}" 
                    XBindingPath="Product" 
                    YBindingPath="SalesRate"/>
</chart:SfCircularChart>

{% endhighlight %} 
{% highlight C# %}
SfCircularChart chart = new SfCircularChart();
. . .
ChartViewModel viewModel = new ChartViewModel();
chart.BindingContext = viewModel;
PieSeries series = new PieSeries();
series.ItemsSource = viewModel.Data;
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
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
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>ToggleSeriesVisibility</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>Series</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>BackgroundColor</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>StrokeColor</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>StrokeWidth</td>
<td><em>Upcoming</em></td>
</tr>
<tr>
<td>StrokeDashArray</td>
<td><em>Upcoming</em></td>
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
</td>
</tr>
</table>

### Data Label

To customize the data label appearance, create an instance of the [ChartDataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataMarker.html) class and add it to the [DataMarker](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html#Syncfusion_SfChart_XForms_ChartSeries_DataMarker) of [Series](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSeries.html). For [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html), you can set the [CircularDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularDataLabelSettings.html) instance to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_DataLabelSettings) property, as shown in the below code sample.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfChart>  
    <chart:PieSeries ItemsSource ="{Binding Data}" XBindingPath="Expense" YBindingPath="Value">
	    <chart:PieSeries.DataMarker>
	    <chart:ChartDataMarker ShowLabel="True">
		    <chart:ChartDataMarker.LabelStyle>
		        <chart:DataMarkerLabelStyle 
					TextColor="Blue" 
					BorderColor="Red" 
					BorderThickness="2"
					BackgroundColor="Aqua"
					Angle="315" 
					Margin="5" 
					FontSize="18" 
					FontAttributes="Italic"/>
			</chart:ChartDataMarker.LabelStyle>
	    </chart:ChartDataMarker>
	    </chart:PieSeries.DataMarker>
    </chart:PieSeries>
</chart:SfChart>

{% endhighlight %}
{% highlight C# %}
PieSeries series = new PieSeries();
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

<chart:SfCircularChart>
    . . .
    <chart:PieSeries ShowDataLabels="True" ItemsSource ="{Binding Data}" XBindingPath="Expense"
	YBindingPath="Value">
    <chart:PieSeries.DataLabelSettings>
        <chart:CircularDataLabelSettings>
            <chart:CircularDataLabelSettings.LabelStyle>
                <chart:ChartDataLabelStyle 
					TextColor="Blue" 
					Stroke="Red" 
					StrokeWidth="2" 
					Background="Aqua" 
					Angle="315" 
					Margin="5" 
					FontSize="18"
					FontAttributes="Italic"/>
            </chart:CircularDataLabelSettings.LabelStyle>
        </chart:CircularDataLabelSettings>
    </chart:PieSeries.DataLabelSettings>  
    </chart:PieSeries>
</chart:SfCircularChart>

{% endhighlight %} 
{% highlight C# %}
SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries();
series.ShowDataLabels = true;
. . .
series.CircularDataLabelSettings = new CircularDataLabelSettings();
var style = new ChartDataLabelStyle();
style.TextColor = Color.Blue;
style.Stroke = Color.Red;
style.StrokeWidth = 2;
style.Background = Color.Aqua;
style.Angle = 315;
style.Margin = 5;
style.FontSize = 18;
series.CircularDataLabelSettings.LabelStyle = style;
chart.Series.Add(series);
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Tooltip

To customize the tooltip appearance, create an instance of the [ChartTooltipBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartTooltipBehavior.html) class and add it to the [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html), you can directly set the [ChartTooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html) instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property, as shown in the below code sample.

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
    
    <chart:PieSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        EnableTooltip="True"/>
</chart:SfChart>

{% endhighlight %} 

{% highlight C# %}
PieSeries  series = new PieSeries ();
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

<chart:SfCircularChart>
. . .
  <chart:SfCircularChart.TooltipBehavior>
        <chart:ChartTooltipBehavior 
        Background="Blue" 
        TextColor="White" 
        Margin="5" 
        FontSize="15"/>
   </chart:SfCircularChart.TooltipBehavior>

   <chart:PieSeries ItemsSource="{Binding Data}" 
                       XBindingPath="Demand"
                       YBindingPath="Year2010"
                       EnableTooltip="True"/>
</chart:PieSeries>
</chart:SfCircularChart>

{% endhighlight %} 
{% highlight C# %}
PieSeries series = new PieSeries();
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

Create an instance of the [ChartSelectionBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartSelectionBehavior.html) class and add it to the  [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html#Syncfusion_SfChart_XForms_SfChart_ChartBehaviors) collection of [SfChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html). For [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html), you can directly set the [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html) instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionBehaviorr) property, as shown in the below code sample.

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

    <chart:PieSeries EnableDataPointSelection="True" 
            SelectedDataPointIndex="2" 
            SelectedDataPointColor="Red" 
            ItemsSource ="{Binding Data}" 
            XBindingPath="Demand" 
            YBindingPath="Year2010" />
</chart:SfChart>

{% endhighlight %} 
{% highlight C# %}
PieSeries series = new PieSeries();
. . .
series.EnableDataPointSelection = true;
series.SelectedDataPointIndex = 2;
series.SelectedDataPointColor = "Red";

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

<chart:SfCircularChart>
    <chart:SfCircularChart.Series>
        <chart:PieSeries>
            <chart:PieSeries.SelectionBehavior>
                <chart:DataPointSelectionBehavior SelectionBrush="#314A6E"/>
            </chart:PieSeries.SelectionBehavior>
        </chart:PieSeries>
    </chart:SfCircularChart.Series>
</chart:SfCircularChart>

{% endhighlight %} 
{% highlight C# %}
SfCircularChart chart = new SfCircularChart();
...
DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectionBrush="#314A6E";

PieSeries series = new PieSeries();
series.SelectionBehavior = selection;
chart.Series.Add(series);
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

N> For more information about selection check [here](https://help.syncfusion.com/maui/circular-charts/selection).

## Upcoming features in .NET MAUI

**Chart** 

* Support for chart localization. 

**Series**

* Listen to property change support for series.
* Get data point index based on value.
* Notify event or method when series are rendering.
* Suspend and resume notification.

**Legend** 

* Title support for legend. 
* Support to enable or disable the legend icon visibility.
* Legend items wrap and floating support.
* Maximum width support for Legend.
* Individual legend items based on the data point count.
* Event or method to notify the legend click and the creation of a legend item.
* The ability to show/hide corresponding data points by legend item toggle.

**Data label**

* DataTemplate support for data labels.
* Connector lines customization support.

**Tooltip**

* Hide and Show method for tooltip.

## Known issue 

* [iOS] [#9135](https://github.com/dotnet/maui/issues/9135) - The chart legend was taking up a huge amount of vertical space or becoming hidden.

## Unsupported features from Xamarin.Forms

* Data label created event support was not provided in series. Instead, you can use the [DrawDataLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_DrawDataLabel_Microsoft_Maui_Graphics_ICanvas_Microsoft_Maui_Controls_Brush_System_String_Microsoft_Maui_Graphics_PointF_System_Int32_) override method in the [ChartSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html) class.
* In.NET MAUI, the [ChartDataPoint](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataPoint.html#) model class was no longer available. Instead, create your own model.

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 
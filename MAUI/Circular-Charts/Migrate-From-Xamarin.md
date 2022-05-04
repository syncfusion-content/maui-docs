---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: This section explains the features available in the .NET MAUI Chart (SfCircularChart) control over Xamarin SfChart.
platform: MAUI
control: SfCircularChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfCircularChart

The Circular Chart was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, a minor code change is required. In addition, `SfChart` has been divided into five chart controls in .NET MAUI for a better user experience and understanding.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
<tr>
<td>
SfChart
</td>
<td>
<div> SfCartesianChart </div>
<div> SfCircularChart </div>
<div> SfFunnelChart (Upcoming) </div>
<div> SfPolarChart (Upcoming) </div>
<div> SfPyramidChart (Upcoming) </div>
</td>
</tr>
</table>

To make the migration easier, the majority of the APIs from the Xamarin `SfChart` were kept in the .NET MAUI [SfCircularChart](https://www.syncfusion.com/maui-controls/maui-charts). Currently, most of the features have been added in the [SfCircularChart](https://www.syncfusion.com/maui-controls/maui-charts), but only a few are pending in the .NET MAUI along with some limitations. Please refer to the following details and the API migration information available below.

## Upcoming Features in .NET MAUI

**Chart** 

* Customize the appearance of the chart plot area.
* Exporting support for a chart as an image or a stream. 
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
* DataTemplate support for legend items.

**Data label**

* DataTemplate support for data labels.
* Connector lines customization support.

**Tooltip**

* Hide and Show method for tooltip.

**Selection**

* Series selection and cluster selection support.

## Unsupported Features from Xamarin.Forms

* Only continuous series will support data marker symbols.
* Data label created event support was not provided in series. Instead, you can use the `DrawDataLabel` override method in the `ChartSeries` class.

## Known issues

* The legend item was not dynamically added.
* While resizing the window, the chart size is not dynamically updated.

## API migration

To initialize the control, import the Chart namespace and Initialize [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html) as shown in the following code sample. 

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
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
<td>SelectedDataPointColor</td>
<td>SelectionBrush</td>
</tr>
<tr>
<td>DataMarker</td>
<td>ShowDataLabels, DataLabelSettings</td>
</tr>
</table>

The following code example explains how to migrate the series of Xamarin `SfCharts` to the .NET MAUI `SfCircularChart`.

<table>
<tr>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
. . .
   <chart:SfChart.Series>
         <chart:PieSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Product" 
                        YBindingPath="SalesRate">
		 </chart:PieSeries>
   </chart:SfChart.Series>
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

<td>

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
<td>Title</td>
<td>-</td>
</tr>
<tr>
<td>Series</td>
<td>-</td>
</tr>
<tr>
<td>BackgroundColor</td>
<td>-</td>
</tr>
<tr>
<td>StrokeColor</td>
<td>-</td>
</tr>
<tr>
<td>StrokeWidth</td>
<td>-</td>
</tr>
<tr>
<td>StrokeDashArray</td>
<td>-</td>
</tr>
<tr>
<td>CornerRadius</td>
<td>-</td>
</tr>
<tr>
<td>Margin</td>
<td>-</td>
</tr>
<tr>
<td>LabelStyle</td>
<td>-</td>
</tr>
<tr>
<td>ItemTemplate</td>
<td>-</td>
</tr>
<tr>
<td>OverflowMode</td>
<td>-</td>
</tr>
<tr>
<td>MaxWidth</td>
<td>-</td>
</tr>
<tr>
<td>Orientation</td>
<td>-</td>
</tr>
<tr>
<td>IsIconVisible</td>
<td>-</td>
</tr>
<tr>
<td>ItemMargin</td>
<td>-</td>
</tr>
<tr>
<td>IconWidth</td>
<td>-</td>
</tr>
<tr>
<td>IconHeight</td>
<td>-</td>
</tr>
<tr>
<td>OffsetX</td>
<td>-</td>
</tr>
<tr>
<td>OffsetY</td>
<td>-</td>
</tr>
</table>

The following code example shows how to enable legend in chart.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
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

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfChart>  
     . . .
    <chart:PieSeries ItemsSource ="{Binding Data}" XBindingPath="Expense"
	YBindingPath="Value">
	    <chart:PieSeries.DataMarker>
	        <chart:ChartDataMarker/>
	    </chart:PieSeries.DataMarker>
    </chart:PieSeries>
</chart:SfChart>

{% endhighlight %}
{% highlight C# %}
PieSeries series = new PieSeries();
. . .
series.DataMarker = new ChartDataMarker();

chart.Series.Add(series);
{% endhighlight %}

{% endtabs %} 
</td>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfCircularChart>
    . . .
    <chart:PieSeries ShowDataLabels="True" ItemsSource ="{Binding Data}" XBindingPath="Expense"
	YBindingPath="Value"/>
</chart:SfCircularChart>

{% endhighlight %} 
{% highlight C# %}
SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries();
series.ShowDataLabels = true;
. . .
chart.Series.Add(series);
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Tooltip

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfChart>
. . . 
    <chart:SfChart.ChartBehaviors>
	      <chart:ChartTooltipBehavior BackgroundColor="Blue" TextColor="White" 
               Margin="5" FontSize="15"/>
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
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfCircularChart>
. . .
   <chart:SfCircularChart.TooltipBehavior>
        <chart:ChartTooltipBehavior Background="Blue" TextColor="White" 
              Margin="5" FontSize="15"/>
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

To customize the tooltip appearance, create an instance of the `ChartTooltipBehavior` class and add it to the `ChartBehaviors` collection of `SfChart.` For `SfCircularChart,` you can directly set the `ChartTooltipBehavior` instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property, as shown in the above code sample.

### Selection

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
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
<td>
{% tabs %} 
{% highlight xaml %}

<chart:SfCircularChart>
. . .
    <chart:SfCircularChart.SelectionBehavior>
        <chart:ChartSelectionBehavior />
    </chart:SfCircularChart.SelectionBehavior>

    <chart:PieSeries SelectionBrush="Green" 
            SelectedIndex="2"
            ItemsSource="{Binding Data}" 
            XBindingPath="Demand" 
            YBindingPath="Year2010" />
</chart:SfCircularChart>

{% endhighlight %} 
{% highlight C# %}
PieSeries series = new PieSeries();
. . .
series.SelectionBrush = Brush.Green;
chart.SelectionBehavior = new ChartSelectionBehavior();
chart.Series.Add(series);
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

Create an instance of the `ChartSelectionBehavior` class and add it to the  `ChartBehaviors` collection of `SfChart.` For `SfCircularChart,` you can directly set the `ChartSelectionBehavior` instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionBehaviorr) property, as shown in the above code sample.

**Support and feedback**

If you are unable to find the information that you are looking for in the self-help resources mentioned above, please contact us by creating a [support ticket](https://www.syncfusion.com/support/directtrac/incidents).
Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).
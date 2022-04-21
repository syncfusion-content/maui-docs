---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: This section explains about the major features available in the .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfCartesianChart

We kept most of the APIs from Xamarin [SfChart](https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts) in MAUI [SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-charts) to make migration easier. However, we renamed some APIs in.NET MAUI SfCartesianChart to keep consistency in API names. The APIs that have changed from Xamarin SfChart to MAUI SfCartesianChart are detailed as follows.

## Assembly Reference 

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
<tr>
<td>Syncfusion.SfChart.XForms</td>
<td>Syncfusion.Maui.Charts</td></tr>
</table>


To initialize the control, import the Chart namespace and Initialize [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1) as per the following code snippet. 

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

{% endhighlight %}

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

## Series

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
<tr>
<td>-</td>
<td>XRange</td>
</tr>
<tr>
<td>-</td>
<td>YRange</td>
</tr>
</table>

The below code example, explains how to initialize series in Xamarin SfChart and .NET MAUI SfCartesianChart.

<table>
<tr>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
</tr>
<tr>
<td>

{% highlight xaml %}

<chart:SfChart>
   <chart:SfChart.PrimaryAxis>
        <chart:CategoryAxis>
            <chart:CategoryAxis.Title>
                  <chart:ChartAxisTitle Text="Name"/>
            </chart:CategoryAxis.Title>
        </chart:CategoryAxis>
   </chart:SfChart.PrimaryAxis>

   <chart:SfChart.SecondaryAxis>
        <chart:NumericalAxis>
            <chart:NumericalAxis.Title>
                  <chart:ChartAxisTitle Text="Height (in cm)"/>
            </chart:NumericalAxis.Title>      
        </chart:NumericalAxis>   
   </chart:SfChart.SecondaryAxis>
    
   <chart:SfChart.Series>
         <chart:ColumnSeries ItemsSource="{Binding Data}" 
                             XBindingPath="Name" 
                             YBindingPath="Height">
		 </chart:ColumnSeries>
   </chart:SfChart.Series>
 </chart:SfChart>

{% endhighlight %} 

</td>

<td>
{% highlight xaml %}

<chart:SfCartesianChart>
   <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis>
            <chart:CategoryAxis.Title>
                  <chart:ChartAxisTitle Text="Name" />
            </chart:CategoryAxis.Title>
        </chart:CategoryAxis>
   </chart:SfCartesianChart.XAxes>

   <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis>
            <chart:NumericalAxis.Title>
                  <chart:ChartAxisTitle Text="Height(in cm)" />
            </chart:NumericalAxis.Title>
        </chart:NumericalAxis>
   </chart:SfCartesianChart.YAxes>

   <chart:SfCartesianChart.Series>
         <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Name" 
                            YBindingPath="Height">
         </chart:ColumnSeries>
   </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %} 
</td>
</tr>
</table>

## Axis

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>LabelRotationAngle</td>
<td>LabelRotation</td>
</tr>
<tr>
<td>-</td>
<td>CrossAxisName</td>
</tr>
<tr>
<td>LabelClicked</td>
<td>-</td>
</tr>
<tr>
<td>VisibleMinimum</td>
<td>-</td>
</tr>
<tr>
<td>VisibleMaximum</td>
<td>-</td>
</tr>
<tr>
<td>VisibleLabels</td>
<td>-</td>
</tr>
<tr>
<td>TickPosition</td>
<td>-</td>
</tr>
<tr>
<td>MaximumLabels</td>
<td>-</td>
</tr>
<tr>
<td>PlotOffset</td>
<td>-</td>
</tr>
<tr>
<td>LabelsIntersectAction</td>
<td>-</td>
</tr>
<tr>
<td>AutoScrollingMode</td>
<td>-</td>
</tr>
<tr>
<td>LabelExtent</td>
<td>-</td>
</tr>
<tr>
<td>RangeStyles</td>
<td>-</td>
</tr>
<tr>
<td>OpposedPosition</td>
<td>CrossesAt</td>
</tr>
<tr>
<td>IsVertical</td>
<td>-</td>
</tr>
<tr>
<td>ShowTrackballInfo</td>
<td>-</td>
</tr>
<tr>
<td>TrackballLabelStyle</td>
<td>-</td>
</tr>
<tr>
<td>AutoScrollingDelta</td>
<td>-</td>
</tr>
<tr>
<td>TrackballLabelTemplate</td>
<td>-</td>
</tr>
</table>

The below code example, explains how to initialize axis in Xamarin SfChart and .NET MAUI SfCartesianChart.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
<tr>
<td>
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
</td>
<td>
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
</td>
</tr>
</table>

## Legend

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
{% highlight xaml %}

<chart:SfChart>
    <chart:SfChart.Legend>
		<chart:ChartLegend/>
	</chart:SfChart.Legend>
</chart:SfChart>

{% endhighlight %} 
</td>
<td>
{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.Legend>
		<chart:ChartLegend/>
	</chart:SfCartesianChart.Legend>
</chart:SfCartesianChart>

{% endhighlight %} 
</td>
</tr>
</table>

## Data Label

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% highlight xaml %}

<chart:SfChart>  
     . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Category"
                        YBindingPath="Value">
	    <chart:ColumnSeries.DataMarker>
	        <chart:ChartDataMarker/>
	    </chart:ColumnSeries.DataMarker>
    </chart:ColumnSeries>
</chart:SfChart>

{% endhighlight %} 
</td>
<td>
{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Category"
                        YBindingPath="Value" 
                        ShowDataLabels="True">
        </chart:ColumnSeries>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %} 
</td>
</tr>
</table>

## Interactive features

### Tooltip

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% highlight xaml %}

<chart:SfChart>
. . . 
    <chart:SfChart.ChartBehaviors>
	      <chart:ChartTooltipBehavior BackgroundColor="Blue" TextColor="White" 
               Margin="5" FontSize="15"/>
    </chart:SfChart.ChartBehaviors>
    
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        EnableTooltip="True"/>
</chart:SfChart>

{% endhighlight %} 

</td>
<td>
{% highlight xaml %}

<chart:SfCartesianChart>
. . .
   <chart:SfCartesianChart.TooltipBehavior>
        <chart:ChartTooltipBehavior Background="Blue" TextColor="White" 
              Margin="5" FontSize="15"/>
   </chart:SfCartesianChart.TooltipBehavior>

   <chart:ColumnSeries ItemsSource="{Binding Data}" 
                       XBindingPath="Demand"
                       YBindingPath="Year2010"
                       EnableTooltip="True"/>
</chart:SfCartesianChart>

{% endhighlight %} 
</td>
</tr>
</table>

To Customize the tooltip appearance, create an instance of the `ChartTooltipBehavior` class and add it to the  `ChartBehaviors` collection of `SfChart`. For `SfCartesianChart`, you can directly set the `ChartTooltipBehavior` instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property as per the above code snippet.

### Selection

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% highlight xaml %}

<chart:SfChart>
...
	<chart:SfChart.ChartBehaviors>
            <local:ChartSelectionBehavior/>
    </chart:SfChart.ChartBehaviors>

    <chart:ColumnSeries EnableDataPointSelection="True" 
            SelectedDataPointIndex="2" 
            SelectedDataPointColor="Red" 
            ItemsSource ="{Binding Data}" 
            XBindingPath="Demand" 
            YBindingPath="Year2010" />
</chart:SfChart>

{% endhighlight %} 
</td>
<td>

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.SelectionBehavior>
        <chart:ChartSelectionBehavior />
    </chart:SfCartesianChart.SelectionBehavior>

    <chart:ColumnSeries SelectionBrush="Green" 
            SelectedIndex="2"
            ItemsSource="{Binding Data}" 
            XBindingPath="Demand" 
            YBindingPath="Year2010" />
</chart:SfCartesianChart>

{% endhighlight %} 
</td>
</tr>
</table>

Create an instance of the `ChartSelectionBehavior` class and add it to the  `ChartBehaviors` collection of `SfChart`. For `SfCartesianChart`, you can directly set the `ChartSelectionBehavior` instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionBehaviorr) property as per the above code snippet.


### Zooming and Panning

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% highlight xaml %}

<chart:SfChart>
	<chart:SfChart.ChartBehaviors>
		<chart:ChartZoomPanBehavior EnableZooming="True"/>
	</chart:SfChart.ChartBehaviors>
</chart:SfChart>

{% endhighlight %} 
</td>
<td>
{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.ZoomPanBehavior>
        <chart:ChartZoomPanBehavior EnablePinchZooming="True"/>
    </chart:SfCartesianChart.ZoomPanBehavior>
</chart:SfCartesianChart>

{% endhighlight %} 
</td>
</tr>
</table>

The zooming and panning are achieved using the `ChartZoomPanBehavior` in SfChart and SfCartesianChart as per the above code example.

### Support and feedback

If you are unable to find the information that you are looking for in the self-help resources mentioned above, please contact us by creating a [support ticket](https://www.syncfusion.com/support/directtrac/incidents).
Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).
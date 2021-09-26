---
layout: post
title: Migrating from SfChart to SfCartesianChart in MAUI | Syncfusion
description: Learn here all about Migrating from SfChart to SfCartesianChart support in Syncfusion MAUI Charts control and more.
platform: MAUI
control: SfCartesianChart
documentation: ug
---

# Migrating from SfChart to SfCartesianChart in MAUI

SfCartesianChart supports different types of series and each type of chart represents a unique style of representing data with more user friendly and greater UI visualization. This section helps you to identify equivalent Chart features/ APIs in SfChart.

## Adding Reference

SfChart assembly Name: Syncfusion.Xamarin.SfChart assembly

SfCartesianChart assembly Name: Syncfusion.Maui.Charts assembly

The following code example illustrates xmlns namespace for SfCartesianChart.

### SfChart

{% highlight xaml %}

xmlns:chart="clr-namespace:Syncfusion.SfChart.XForms;assembly=Syncfusion.SfChart.XForms"

{% endhighlight %}

### SfCartesianChart

{% highlight xaml %}

xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"        

{% endhighlight %}

## Initialization

Both SfChart and SfCartesianChart almost have the same set of features. So, logically SfChart is equivalent to SfCartesianChart. 

Following code example illustrates the initialization of SfChart with SfCartesianChart,

{% tabs %}
{% highlight xaml %}

 <chart:SfChart Title="ChartArea" SideBySideSeriesPlacement="True">
   <chart:SfChart.ColorModel>
      <chart:ChartColorModel Palette="Custom" CustomBrushes="{StaticResource Colors}"/>
   </chart:SfChart.ColorModel>
</chart:SfChart>

{% endhighlight %}

{% highlight C# %}

SfChart chart = new SfChart()
{
   ColorModel = new ChartColorModel()
	{
		Palette = ChartColorPalette.Custom,
		   CustomBrushes = new ChartColorCollection()
			{
				Color.Yellow,
				Color.Gray,
				Color.Maroon
			}
	}	
   . . .					
};

{% endhighlight %}
{% endtabs %}

In SfCartesianChart ColorModel class not exposed, directly set Palette and CustomBrushes to the chart. Following code example illustrates the initialization of SfCartesianChart that is equivalent to the above code example.

{% tabs %}
{% highlight xaml %}

<chart:SfCartesianChart EnableSideBySideSeriesPlacement="True"                            Palette="Custom" CustomBrushes="{Binding Colors}">
   <chart:SfCartesianChart.Title>
      <Label Text="ChartArea"/>
   </chart:SfCartesianChart.Title>
</chart:SfCartesianChart>
{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();

chart.EnableSideBySideSeriesPlacement = true;

chart.Palette = ChartColorPalette.Custom;

chart.Title = new Label
{
   Text = "ChartArea"
};

{% endhighlight %}
{% endtabs %}

The following table illustrates the API comparison between SfChart and SfCartesianChart.

<table>
<tr>
<th>
SfChart</th><th>
SfCartesianChart</th><th>
Description</th></tr>
<tr>
<td>
Title</td><td>
Title</td><td>
Gets or sets the title for the chart. This is a mutable property. </td></tr>
<tr>
<td>
SideBySideSeriesPlacement</td><td>
EnableSideBySideSeriesPlacement</td><td>
Gets or sets a value indicating whether the series can be placed side by side. This is a bindable property.</td></tr>
<tr>
<td>
Series</td><td>
Series</td><td>
Gets or sets a collection of series to be added to the chart. To render a series, create an instance of required series class, and add it to the collection. </td></tr>
<tr>
<td>
Palette</td><td>
Palette</td><td>
Gets or sets a predefined color palette for the series.</td></tr>
<tr>
<td>
CustomBrushes</td><td>
CustomBrushes</td><td>
Gets or sets the list of brushes to be used as custom palette.</td></tr>
</table>

## Legend

The Legends are same for both SfChart and SfCartesianChart. In SfCartesianChart, the Legend property of the SfCartesianChart is an object that accepts one or more Legends based on your requirement. 

The following code example illustrates the usage of Legend in SfChart and SfCartesianChart.

### Chart
{% tabs %}
{% highlight xaml %}

<syncfusion:SfChart>

<syncfusion:SfChart.Legend>

<syncfusion:ChartLegend DockPosition="Top"/>

</syncfusion:SfChart.Legend>

</syncfusion:SfChart>
{% endhighlight %}

{% highlight C# %}

SfChart chart = new SfChart();

ChartLegend legend = new ChartLegend();

legend.DockPosition = ChartDock.Top; 

chart.Legend = legend;

{% endhighlight %}
{% endtabs %}

### SfChart

{% tabs %}
{% highlight xaml %}

<chart:SfCartesianChart>
   <chart:SfCartesianChart.Legend>
      <chart:ChartLegend Placement="Top"/>
   </chart:SfCartesianChart.Legend>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();

ChartLegend legend = new ChartLegend();

chart.Legend = legend;

chart.Legend.Placement = Syncfusion.Maui.Core.LegendPlacement.Top;
          
{% endhighlight %}
{% endtabs %}


The following table illustrates the API comparison between SfChart and SfCartesianChart.

<table>
<tr>
<th>
ChartLegend (SfChart)</th><th>
ChartLegend (SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
DockPosition</td><td>
Placement</td><td>
Gets or sets placement of the legend inside the chart. This is a bindable property. </td></tr>
</table>

## Axis

In SfCartesianChart, Axis can be an instance of NumericalAxis, DateTimeAxis, CategoryAxis. Class name represents the type of data it can plot. For example, NumericalAxis can plot numeric values and DateTimeAxis can plot DateTime values. Following code example illustrates this,

{% highlight xaml %}

<chart:SfChart.PrimaryAxis >
	<chart:DateTimeAxis EdgeLabelsDrawingMode="Shift" ZoomFactor="0.7" ZoomPosition="0.4">
      <chart:DateTimeAxis.Title>
			<chart:ChartAxisTitle Text="Production across year"/>
	   </chart:DateTimeAxis.Title>
   </chart:DateTimeAxis>
</chart:SfChart.PrimaryAxis>

{% endhighlight %} 

### SfCartesianChart

{% highlight xaml %}

<chart:SfCartesianChart.PrimaryAxis>
   <chart:DateTimeAxis EdgeLabelsDrawingMode="Shift" ZoomFactor="0.7" ZoomPosition="0.4" >
      <chart:DateTimeAxis.Title>
         <chart:ChartAxisTitle Text="Production across year">
         </chart:ChartAxisTitle>
      </chart:DateTimeAxis.Title>
   </chart:DateTimeAxis>
</chart:SfCartesianChart.PrimaryAxis>

## Series

In both SfChart and SfCartestianChart, you can create the instance of required series (Class name itself represents the type of series) in Chart as in the following code example.

### SfChart

{% highlight xaml %}

<chart:SfChart>
   <chart:SfChart.Series>
      <chart:LineSeries ItemsSource="{Binding power}"
                        XBindingPath="Year" YBindingPath="Sports" 
                        IsVisible="True" Color="Green"
                        SelectedDataPointIndex="2" SelectedDataPointColor="Red"
                        EnableTooltip="True">

         <chart:LineSeries.YAxis>
            <chart:NumericalAxis  Minimum="20 Maximum="50"/>
         </chart:LineSeries.YAxis>
      </chart:LineSeries>
   </chart:SfChart.Series>
</chart:SfChart>
{% endhighlight %}

{% highlight C# %}

SfChart chart = new SfChart();

LineSeries lineseries = new LineSeries();

lineseries.ItemsSource = viewmodel.power;

lineseries.XBindingPath = "Year";

lineseries.YBindingPath = "Sports";

lineseries.IsVisible = true;

lineseries.Color = Color.Green;

lineseries.SelectedDataPointIndex = 2;

lineseries.SelectedDataPointColor = Color.Red;

lineseries.EnableTooltip = true;			

lineseries.YAxis = new NumericalAxis() { Minimum = 20, Maximum = 50 };
		
chart.Series.Add(lineseries);
{% endhighlight %}


### SfCartesianChart

{% tabs %}
{% highlight xaml %}

<chart:SfCartesianChart>
   <chart:SfCartesianChart.Series>
      <chart:LineSeries ShowTooltip="True"
                        ShowDataLabels="True"
                        IsVisible ="True"
                        Background="Green"
                        SelectedIndex="2"
                        SelectionBrush="Red"
                        ItemsSource="{Binding Data}"
                        XBindingPath="Name" 
                        YBindingPath="Height">
         <chart:LineSeries.YAxis>
            <chart:NumericalAxis/>
         </chart:LineSeries.YAxis>
      </chart:LineSeries>
   </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}
 
{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();

LineSeries series = new LineSeries();

series.ItemsSource = (new ViewModel()).Data;

series.XBindingPath = "Name";

series.YBindingPath = "Height";

series.IsVisible  = true;

series.ShowDataLabels = true;

series.ShowTooltip = true;

series.Background = Brush.Green;

series.SelectedIndex = 2;
            
series.SelectionBrush = Brush.Blue;

chart.Series.Add(series);

{% endhighlight %}
{% endtabs %}

The following table illustrates the API comparison for series,

<table>
<tr>
<th>
ChartSeries(SfChart)</th><th>
ChartSeries(SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
DataMarker</td><td>
DataLabelSettings</td><td>
Gets or sets data labels for the cartesian series.</td></tr>
<tr>
<td>
Need to initialize data marker and need to set ShowLabel true.</td><td>
ShowDataLabels</td><td>
Gets or sets a value that indicates to enable the data labels for the series.</td></tr>
<tr>
<td>
IsVisible</td><td>
IsVisible </td><td>
Gets or sets a value indicating whether the series is visible in the chart.</td></tr>
<tr>
<td>
Color</td><td>
Background</td><td>
Gets or sets the color that is used to change the appearance of chart series.</td></tr>
<tr>
<td>
SelectedDataPointIndex</td><td>
SelectedIndex</td><td>
Gets or sets the index value of current selected data point.</td></tr>
<tr>
<td>
SelectedDataPointColor</td><td>
SelectionBrush</td><td>
Gets or sets the color of the selected segment of the series.</td></tr>
<tr>
<td>
EnableTooltip</td><td>
ShowTooltip</td><td>
Gets or sets tooltip for series.</td></tr>
</table>

<table>
<tr>
<th>
AreaSeries(SfChart)</th><th>
AreaSeries(SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
StrokeColor</td><td>
Stroke</td><td>
Gets or sets the stroke color to customize the appearance of AreaSeries. This is a bindable property.</td></tr>
<tr>
<td>
-</td><td>
StrokeDashArray</td><td>
Gets or sets the dash array for the line. This is a bindable property.</td></tr>
</table>

<table>
<tr>
<th>
ColumnSeries(SfChart)</th><th>
ColumnSeries(SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
StrokeColor</td><td>
Stroke</td><td>
Gets or sets the stroke color to customize the appearance of ColumnSeries.</td></tr>
<tr>
<td>
DataMarkerPosition</td><td>
Renamed BarAlignment and moved to CartesianDataLabelSettings</td><td>
-</td></tr>
</table>

<table>
<tr>
<th>
ScatterSeries(SfChart)</th><th>
ScatterSeries(SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
ScaterHeight</td><td>
Height</td><td>
Gets or sets the height of the segment. This is a bindable property</td></tr>
<tr>
<td>
ScatterWidth</td><td>
Width</td><td>
Gets or sets the width of the segment. This is a bindable property.</td></tr>
<tr>
<td>
StrokeColor</td><td>
Stroke</td><td>
Gets or sets the stroke color to customize the appearance of ScatterSeries. This is a bindable property.</td></tr>
<tr>
<td>
ShapeType</td><td>
Type</td><td>
Gets or sets different types of shapes to change the rendering type of ScatterSeries. This is a bindable property.</td></tr>
</table>

<table>
<tr>
<th>
SplineAreaSeries(SfChart)</th><th>
SplineAreaSeries(SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
SplineType</td><td>
Type</td><td>
Gets or sets the height of the segment. This is a bindable property</td></tr>
</table>

<table>
<tr>
<th>
SplineSeries(SfChart)</th><th>
SplineSeries(SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
SplineType</td><td>
Type</td><td>
Gets or sets the height of the segment. This is a bindable property</td></tr>
</table>

## Data Label

The Data Label are same as SfChart and you can define the Data Label inside the Series like Chart.

### SfChart

{% tabs %}
{% highlight xaml %}

<chart:SfChart.Series>
    <chart:ColumnSeries XBindingPath="XValue" 
                        YBindingPath="YValue" 
                        ItemsSource="{Binding Data}">
        <chart:ColumnSeries.DataMarker>
            <chart:ChartDataMarker UseSeriesPalette="False" ShowLabel="True"/>
            <chart:ChartDataMarker.LabelStyle>
		         <chart:DataMarkerLabelStyle LabelPosition="Outer"/>
	         </chart:ChartDataMarker.LabelStyle>
        </chart:ColumnSeries.DataMarker>
    </chart:ColumnSeries>
</chart:SfChart.Series>

{% endhighlight %}


{% highlight C# %}

ColumnSeries series = new ColumnSeries()
{
	XBindingPath = "XValue",
	YBindingPath = "YValue",
	ItemsSource = Data,
	DataMarker = new ChartDataMarker()
	{
	   ShowLabel = true,
		UseSeriesPalette = true,
		LabelStyle = new DataMarkerLabelStyle
		{
			LabelPosition = DataMarkerLabelPosition.Outer,
		}
	}
};

{% endhighlight %}
{% endtabs %}

### SfCartesianChart

{% tabs %}
{% highlight xaml %}

<chart:SfCartesianChart.Series >

   <chart:ColumnSeries ShowDataLabels="True">

      <chart:ColumnSeries.DataLabelSettings>

         <chart:CartesianDataLabelSettings UseSeriesPalette="False" LabelPlacement="Outer"/>

      </chart:ColumnSeries.DataLabelSettings>

   </chart:ColumnSeries>

</chart:SfCartesianChart.Series>
{% endhighlight %}


{% highlight C# %}

ColumnSeries series = new ColumnSeries();

series.ShowDataLabels = true;
           
series.DataLabelSettings = new CartesianDataLabelSettings()
{
   UseSeriesPalette = false,

   LabelPlacement = Placement.Outer  
};

{% endhighlight %}
{% endtabs %}

The following table illustrates the API comparison for Data Label.

<table>
<tr>
<th>
DataMarker (SfChart)</th><th>
DataLabelSettings (SfCartesianChart)</th><th>
Description</th></tr>
<tr>
<td>
-</td><td>
LabelPlacement</td><td>
Gets or sets the data label position inside, outside or default.</td></tr>
</table>

## Zooming and Panning

The Zooming and Panning are achieved using the ChartZoomPanBehavior in SfCartesianChart as in the following code example.

### Chart

{% tabs %}
{% highlight xaml %}

<chart:SfChart>

	<chart:SfChart.ChartBehaviors>

		<chart:ChartZoomPanBehavior EnableZooming="True" EnablePanning="True" ZoomMode="XY"/>

	</chart:SfChart.ChartBehaviors>

</chart:SfChart>

{% highlight C# %}

SfChart chart = new SfChart();

ChartZoomPanBehavior zoomPanBehavior = new ChartZoomPanBehavior();

zoomPanBehavior.EnableZooming = true;

zoomPanBehavior.EnablePanning = true;

zoomPanBehavior.ZoomMode = ZoomMode.XY;

chart.ChartBehaviors.Add(zoomPanBehavior);

{% endhighlight %}
{% endtabs %}

### SfCartesianChart

{% tabs %}
{% highlight xaml %}

<chart:SfCartesianChart>
 ...
   <chart:SfCartesianChart.ChartBehaviors>

      <chart:ChartZoomPanBehavior EnablePinchZooming="True" EnablePanning="True" ZoomMode="XY"/>

   </chart:SfCartesianChart.ChartBehaviors>
            
</chart:SfCartesianChart>
{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();

ChartZoomPanBehavior zooming = new ChartZoomPanBehavior();
   
zooming.EnablePinchZooming = true;

zooming.EnablePanning = true;

zooming.ZoomMode = ZoomMode.XY;

chart.ChartBehaviors.Add(zooming);

{% endhighlight %}
{% endtabs %}
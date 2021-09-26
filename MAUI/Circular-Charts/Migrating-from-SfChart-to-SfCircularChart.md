---
layout: post
title: Migrating from SfChart to SfCircularChart in MAUI | Syncfusion
description: Learn here all about Migrating from SfChart to SfCircularChart support in Syncfusion MAUI Charts control and more.
platform: MAUI
control: SfCircularChart
documentation: ug
---

# Migrating from SfChart to SfCircularChart in MAUI

SfCircularChart is a very high performance chart enriched with several business features. This section helps you to identify equivalent SfChart features/ APIs in SfCircularChart.

## Adding Reference

SfChart assembly Name: Syncfusion.Xamarin.SfChart assembly

SfCircularChart assembly Name: Syncfusion.Maui.Charts assembly

The following code example illustrates xmlns namespace for SfCircularChart. 

### SfChart

{% highlight xaml %}

xmlns:chart="clr-namespace:Syncfusion.SfChart.XForms;assembly=Syncfusion.SfChart.XForms"

{% endhighlight %}

### SfCircularChart

{% highlight xaml %}

xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"        

{% endhighlight %}

## Initialization

SfChart supports all the chart types, SfCircularChart Supports two types of series such as pie and doughnut. Each series presents data in a unique way and it is designed to be more user-friendly.

Following code example illustrates the initialization of SfChart with SfCircularChart,

{% tabs %}
{% highlight xaml %}

 <chart:SfChart Title="ChartArea">
</chart:SfChart>

{% endhighlight %}

{% highlight C# %}

SfChart chart = new SfChart()
{
   chart.Title = "ChartArea";
   . . .					
};

{% endhighlight %}
{% endtabs %}

Following code example illustrates the initialization of SfCircularChart that is equivalent to the above code example.

{% tabs %}
{% highlight xaml %}

<chart:SfCircularChart>
   <chart:SfCircularChart.Title>
      <Label Text="ChartArea"/>
   </chart:SfCircularChart.Title>
</chart:SfCircularChart>
{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();

chart.Title = new Label
{
   Text = "ChartArea"
};

{% endhighlight %}
{% endtabs %}

The following table illustrates the API comparison between SfChart and SfCircularChart.

<table>
<tr>
<th>
SfChart</th><th>
SfCircularChart</th><th>
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
</table>

## Legend

The Legends are same for both SfChart and SfCircularChart. In SfCircularChart, the Legend property of the SfCircularChart is an object that accepts one or more Legends based on your requirement.

The following code example illustrates the usage of Legend in SfChart and SfCircularChart.

### SfChart
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

### SfCircularChart

{% tabs %}
{% highlight xaml %}

<chart:SfCircularChart>
   <chart:SfCircularChart.Legend>
      <chart:ChartLegend Placement="Top"/>
   </chart:SfCircularChart.Legend>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();

ChartLegend legend = new ChartLegend();

chart.Legend = legend;

chart.Legend.Placement = Syncfusion.Maui.Core.LegendPlacement.Top;
          
{% endhighlight %}
{% endtabs %}

The following table illustrates the API comparison between SfChart and SfCircularChart.

<table>
<tr>
<th>
ChartLegend (SfChart)</th><th>
ChartLegend (SfCircularChart)</th><th>
Description</th></tr>
<tr>
<td>
DockPosition</td><td>
Placement</td><td>
Gets or sets placement of the legend inside the chart. This is a bindable property. </td></tr>
</table>

## Series

In both SfChart and SfCircularChart, you can create the instance of required series (Class name itself represents the type of series) in Chart as in the following code example.

### SfChart

{% highlight xaml %}

<chart:SfChart>
   <chart:SfChart.Series>
      <chart:PieSeries  ItemsSource="{Binding power}"
                        XBindingPath="Year" 
                        YBindingPath="Sports" 
                        IsVisible="True" 
                        EnableTooltip="True">
      </chart:PieSeries>
   </chart:SfChart.Series>
</chart:SfChart>
{% endhighlight %}

{% highlight C# %}

SfChart chart = new SfChart();

PieSeries pieSeries = new PieSeries();

pieSeries.ItemsSource = viewmodel.power;

pieSeries.XBindingPath = "Year";

pieSeries.YBindingPath = "Sports";

pieSeries.IsVisible = true;

pieSeries.EnableTooltip = true;			
		
chart.Series.Add(pieSeries);
{% endhighlight %}


### SfCircularChart

{% tabs %}
{% highlight xaml %}

<chart:SfCircularChart>
   <chart:SfCircularChart.Series>
      <chart:PieSeries  ShowTooltip="True"
                        IsVisible="True"
                        ItemsSource="{Binding Data}"
                        XBindingPath="Name" 
                        YBindingPath="Height">
      </chart:PieSeries>
   </chart:SfCircularChart.Series>
</chart:SfCircularChart>

{% endhighlight %}
 
{% highlight C# %}

SfCircularChart chart = new SfCircularChart();

PieSeries pieSeries = new pieSeries();

pieSeries.ItemsSource = (new ViewModel()).Data;

pieSeries.XBindingPath = "Name";

pieSeries.YBindingPath = "Height";

pieSeries.IsVisible = true;

pieSeries.ShowTooltip = true;

chart.Series.Add(pieSeries);

{% endhighlight %}
{% endtabs %}

The following table illustrates the API comparison for series,

<table>
<tr>
<th>
ChartSeries (SfChart)</th><th>
ChartSeries (SfCircularChart)</th><th>
Description</th></tr>
<tr>
<td>
DataMarker</td><td>
DataLabelSettings</td><td>
Gets or sets data labels for the circular series.</td></tr>
<tr>
<td>
Need to initialize data marker and need to set ShowLabel true.</td><td>
ShowDataLabels</td><td>
Gets or sets a value that indicates to enable the data labels for the series.</td></tr>
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

## Data Label

The Data Label are same as SfChart and you can define the Data Label inside the Series like Chart.

### SfChart

{% tabs %}
{% highlight xaml %}

<chart:SfChart.Series>
    <chart:PieSeries XBindingPath="XValue" 
                     YBindingPath="YValue" 
                     ItemsSource="{Binding Data}">
        <chart:PieSeries.DataMarker>
            <chart:ChartDataMarker UseSeriesPalette="False" ShowLabel="True">
               <chart:ChartDataMarker.LabelStyle>
		            <chart:DataMarkerLabelStyle LabelPosition="Outer"/>
	            </chart:ChartDataMarker.LabelStyle>
            </chart:ChartDataMarker>
        </chart:PieSeries.DataMarker>
    </chart:PieSeries>
</chart:SfChart.Series>

{% endhighlight %}


{% highlight C# %}

PieSeries series = new PieSeries()
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

### SfCircularChart

{% tabs %}
{% highlight xaml %}

<chart:SfCircularChart.Series >

   <chart:PieSeries ShowDataLabels="True">

      <chart:PieSeries.DataLabelSettings>

         <chart:CircularDataLabelSettings UseSeriesPalette="False" LabelPlacement="Outer"/>

      </chart:PieSeries.DataLabelSettings>

   </chart:PieSeries>

</chart:SfCircularChart.Series>
{% endhighlight %}


{% highlight C# %}

PieSeries series = new PieSeries();

series.ShowDataLabels = true;
           
series.DataLabelSettings = new CircularDataLabelSettings()
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
DataLabelSettings (SfCircularChart)</th><th>
Description</th></tr>
<tr>
<td>
-</td><td>
LabelPlacement</td><td>
Gets or sets the data label position inside, outside or default.</td></tr>
<tr>
<td>
-</td><td>
ConnectorLineType</td><td>
Gets or sets the type of connector line to be drawn.</td></tr>
</table>


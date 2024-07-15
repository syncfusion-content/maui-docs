---
layout: post
title: Appearance in .NET MAUI Chart control  Syncfusion
description: Learn here all about appearance customization in Syncfusion .NET MAUI Chart (SfPolarChart), including its elements, and more.
platform: maui
control: SfPolarChart
documentation: ug
---

# Appearance in .NET MAUI Polar Chart
The appearance of [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html) can be customized using the predefined brushes, custom brushes, and gradient, which allows for the enrichment of the application.

## Default PaletteBrushes for Chart

By default, the chart applies a set of predefined brushes to the series in a specific order. The following screenshot displays the default appearance of multiple series.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart> 
    . . .
    <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree"/> 
    <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Weed"/> 
    <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Flower"/>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
PolarLineSeries series1 = new PolarLineSeries()
{
    ItemsSource = new ViewModel().PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Tree"
};

PolarLineSeries series2 = new PolarLineSeries()
{
    ItemsSource = new ViewModel().PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Weed"
};

PolarLineSeries series3 = new PolarLineSeries()
{
    ItemsSource = new ViewModel().PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Flower"
};

chart.Series.Add(series1);
chart.Series.Add(series2);
chart.Series.Add(series3);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Default PaletteBrushes in MAUI Chart](Appearance_images/MAUI_default_chart.png)

### Custom PaletteBrushes

The [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html) provides support for defining custom brushes for the chart in a preferred order using the [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_PaletteBrushes) property, as illustrated in the following code example.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart x:Name="chart" PaletteBrushes="{Binding CustomBrushes}">
    . . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
List<Brush> CustomBrushes = new List<Brush>()
{
	new SolidColorBrush(Color.FromArgb("#25E739")),
	new SolidColorBrush(Color.FromArgb("#F4890B")),
	new SolidColorBrush(Color.FromArgb("#E2227E"))
};

this.chart.PaletteBrushes = CustomBrushes;
. . .
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Custom PaletteBrushes in MAUI Chart](Appearance_images/MAUI_polar_chart_custom_palette.png)

## Applying Gradient

The gradient for the chart can be set using the [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) property with the help of `LinearGradientBrush` or `RadialGradientBrush`.

The following code sample and screenshot illustrates how to apply the gradient brushes for the series using the [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) property.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart PaletteBrushes="{Binding CustomBrushes}">
    . . .
    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree"/>
    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Weed"/>
    <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Flower"/>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

public class ViewModel
{
	public ObservableCollection<Model> Data { get; set; }
	public List<Brush> CustomBrushes { get; set; }
	public ViewModel()
	{
		CustomBrushes = new List<Brush>();
		LinearGradientBrush gradientColor1 = new LinearGradientBrush();
		gradientColor1.GradientStops = new GradientStopCollection()
		{
			new GradientStop() { Offset = 1, Color = Color.FromRgb(168, 234, 238) },
			new GradientStop() { Offset = 0, Color = Color.FromRgb(123, 176, 249) }
		};

		LinearGradientBrush gradientColor2 = new LinearGradientBrush();
		gradientColor2.GradientStops = new GradientStopCollection()
		{
			new GradientStop() { Offset = 1, Color = Color.FromRgb(221, 214, 243) },
			new GradientStop() { Offset = 0, Color = Color.FromRgb(250, 172, 168) }
		};

		LinearGradientBrush gradientColor3 = new LinearGradientBrush();
		gradientColor3.GradientStops = new GradientStopCollection()
		{
			new GradientStop() { Offset = 1, Color = Color.FromRgb(255, 231, 199) },
			new GradientStop() { Offset = 0, Color = Color.FromRgb(252, 182, 159) }
		};

		LinearGradientBrush gradientColor4 = new LinearGradientBrush();
		gradientColor4.GradientStops = new GradientStopCollection()
		{
			new GradientStop() { Offset = 1, Color = Color.FromRgb(255, 231, 199) },
			new GradientStop() { Offset = 0, Color = Color.FromRgb(252, 182, 159) }
		};

		LinearGradientBrush gradientColor5 = new LinearGradientBrush();
		gradientColor5.GradientStops = new GradientStopCollection()
		{
			new GradientStop() { Offset = 1, Color = Color.FromRgb(250, 221, 125) },
			new GradientStop() { Offset = 0, Color = Color.FromRgb(252, 204, 45) }
		};

		CustomBrushes.Add(gradientColor1);
		CustomBrushes.Add(gradientColor2);
		CustomBrushes.Add(gradientColor3);
		CustomBrushes.Add(gradientColor4);
		CustomBrushes.Add(gradientColor5);
	}
. . .
}

{% endhighlight %}

{% endtabs %}

![Gradient in MAUI Chart](Appearance_images/MAUI_polar_chart_gradient.png)

## Plotting Area Customization:

[SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html) allows you to add any view to the chart plot area, which is useful for adding any relevant data, a watermark, or a color gradient to the background of the chart.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
   <chart:SfPolarChart.PlotAreaBackgroundView>
    	<AbsoluteLayout>
      		<Label Text="Copyright @ 2001 - 2024 Syncfusion Inc"
		       FontSize="18" AbsoluteLayout.LayoutBounds="1,1,-1,-1"
		       AbsoluteLayout.LayoutFlags="PositionProportional"
		       Opacity="0.4"/>
       		<Label Text="CONFIDENTIAL" Rotation="340" FontSize="80"
		       FontAttributes="Bold,Italic" TextColor="Gray" Margin="10,0,0,0"
	               AbsoluteLayout.LayoutBounds="0.5,0.5,-1,-1"
		       AbsoluteLayout.LayoutFlags="PositionProportional"
		       Opacity="0.3"/>
    	</AbsoluteLayout>
   </chart:SfPolarChart.PlotAreaBackgroundView>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
AbsoluteLayout absoluteLayout = new AbsoluteLayout();
var copyRight = new Label() 
{
	Text = "Copyright @ 2001 - 2024 Syncfusion Inc",
 	FontSize = 18,Opacity = 0.4
};

AbsoluteLayout.SetLayoutBounds(copyRight, new Rect(1, 1, -1, -1));
AbsoluteLayout.SetLayoutFlags(copyRight, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.PositionProportional);
absoluteLayout.Children.Add(copyRight);
var watermark = new Label()
{
	Text = "CONFIDENTIAL",
 	Rotation = 340,
  	FontSize = 80,
   	FontAttributes = FontAttributes.Bold,
    	TextColor = Colors.Gray, 
     	Opacity = 0.3
};

AbsoluteLayout.SetLayoutBounds(watermark, new Rect(0.5, 0.5, -1, -1));
AbsoluteLayout.SetLayoutFlags(watermark, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.PositionProportional);
absoluteLayout.Children.Add(watermark);
chart.PlotAreaBackgroundView = absoluteLayout;
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Watermark in .NET MAUI Charts](Appearance_images/polar_water_mark.png)

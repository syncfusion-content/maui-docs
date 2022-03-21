---
layout: post
title: Thumb and Thumb Overlay in .NET MAUI Range Selector control | Syncfusion
description: Learn here all about the Thumb and Thumb Overlay features of Syncfusion .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Thumb and Overlay in .NET MAUI Range Selector (SfRangeSelector)

This section helps to learn about how to customize the thumb and thumb overlay in the range selector.

* Thumb - It is one of the elements of slider which can be used to drag and change the selected value of the range selector.
* Thumb overlay - It is rendered around the thumb while interacting with them.

## Thumb size

You can change the size of the thumb in the range selector using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius)  property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius) property is `10.0`.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
             xmlns:local="clr-namespace:SliderTestbedSample.RangeSelector">
    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <rangeselector:SfRangeSelector>
        <rangeselector:SfRangeSelector.ThumbStyle>
            <rangeselector:SliderThumbStyle Radius="15" />
        </rangeselector:SfRangeSelector.ThumbStyle>
        <chart:SfCartesianChart>
            <chart:SfCartesianChart.XAxes>
               <chart:DateTimeAxis IsVisible="False"
                                   ShowMajorGridLines="False" />
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
               <chart:NumericalAxis IsVisible="False"
                                    ShowMajorGridLines="False" />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
               <chart:SplineAreaSeries ItemsSource="{Binding Source}"
                                       XBindingPath="X"
                                       YBindingPath="Y"
                                       Fill="Blue">
               </chart:SplineAreaSeries>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.Radius = 15;
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes = secondaryAxis;
SplineAreaSeries series = new SplineAreaSeries();
series.ItemsSource = (new ViewModel()).Source;
series.XBindingPath = "X";
series.YBindingPath = "Y";
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb size](images/thumb-and-thumb-overlay/thumb-radius.png)

## Thumb color

You can change the color of the thumb in the range selector using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Fill) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
             xmlns:local="clr-namespace:SliderTestbedSample.RangeSelector">
    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <rangeselector:SfRangeSelector>
        <rangeselector:SfRangeSelector.ThumbStyle>
            <rangeselector:SliderThumbStyle Fill="#EE3F3F" />
        </rangeselector:SfRangeSelector.ThumbStyle>
        <chart:SfCartesianChart>
            <chart:SfCartesianChart.XAxes>
               <chart:DateTimeAxis IsVisible="False"
                                   ShowMajorGridLines="False" />
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
               <chart:NumericalAxis IsVisible="False"
                                    ShowMajorGridLines="False" />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
               <chart:SplineAreaSeries ItemsSource="{Binding Source}"
                                       XBindingPath="X"
                                       YBindingPath="Y"
                                       Fill="Blue">
               </chart:SplineAreaSeries>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.Fill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes = secondaryAxis;
SplineAreaSeries series = new SplineAreaSeries();
series.ItemsSource = (new ViewModel()).Source;
series.XBindingPath = "X";
series.YBindingPath = "Y";
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb color](images/thumb-and-thumb-overlay/thumb-color.png)

## Thumb stroke thickness and stroke

You can change the thumb stroke width using the [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_StrokeThickness) property and thumb stroke color using the [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Stroke) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
             xmlns:local="clr-namespace:SliderTestbedSample.RangeSelector">
    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <rangeselector:SfRangeSelector>
        <rangeselector:SfRangeSelector.ThumbStyle>
            <rangeselector:SliderThumbStyle StrokeThickness="2" Stroke="#EE3F3F" />
        </rangeselector:SfRangeSelector.ThumbStyle>
        <chart:SfCartesianChart>
            <chart:SfCartesianChart.XAxes>
               <chart:DateTimeAxis IsVisible="False"
                                   ShowMajorGridLines="False" />
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
               <chart:NumericalAxis IsVisible="False"
                                    ShowMajorGridLines="False" />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
               <chart:SplineAreaSeries ItemsSource="{Binding Source}"
                                       XBindingPath="X"
                                       YBindingPath="Y"
                                       Fill="Blue">
               </chart:SplineAreaSeries>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSelector.ThumbStyle.StrokeThickness = 2;
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes = secondaryAxis;
SplineAreaSeries series = new SplineAreaSeries();
series.ItemsSource = (new ViewModel()).Source;
series.XBindingPath = "X";
series.YBindingPath = "Y";
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb stroke color](images/thumb-and-thumb-overlay/thumb-stroke-color.png)

## Thumb overlapping stroke color

You can change the thumb stroke color while two thumbs are overlapping in the range selector using the [`OverlapStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_OverlapStroke) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
             xmlns:local="clr-namespace:SliderTestbedSample.RangeSelector">
    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <rangeselector:SfRangeSelector>
        <rangeselector:SfRangeSelector.ThumbStyle>
            <rangeselector:SliderThumbStyle OverlapStroke="#EE3F3F" />
        </rangeselector:SfRangeSelector.ThumbStyle>
        <chart:SfCartesianChart>
            <chart:SfCartesianChart.XAxes>
               <chart:DateTimeAxis IsVisible="False"
                                   ShowMajorGridLines="False" />
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
               <chart:NumericalAxis IsVisible="False"
                                    ShowMajorGridLines="False" />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
               <chart:SplineAreaSeries ItemsSource="{Binding Source}"
                                       XBindingPath="X"
                                       YBindingPath="Y"
                                       Fill="Blue">
               </chart:SplineAreaSeries>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.OverlapStroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes = secondaryAxis;
SplineAreaSeries series = new SplineAreaSeries();
series.ItemsSource = (new ViewModel()).Source;
series.XBindingPath = "X";
series.YBindingPath = "Y";
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb stroke color](images/thumb-and-thumb-overlay/thumb-overlapstrokecolor.gif)

## Thumb overlay size

You can change the size of the thumb overlay in the range selector using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property is `24.0`.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
             xmlns:local="clr-namespace:SliderTestbedSample.RangeSelector">
    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <rangeselector:SfRangeSelector>
        <rangeselector:SfRangeSelector.ThumbStyle>
            <rangeselector:SliderThumbStyle Radius="30" />
        </rangeselector:SfRangeSelector.ThumbStyle>
        <chart:SfCartesianChart>
            <chart:SfCartesianChart.XAxes>
               <chart:DateTimeAxis IsVisible="False"
                                   ShowMajorGridLines="False" />
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
               <chart:NumericalAxis IsVisible="False"
                                    ShowMajorGridLines="False" />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
               <chart:SplineAreaSeries ItemsSource="{Binding Source}"
                                       XBindingPath="X"
                                       YBindingPath="Y"
                                       Fill="Blue">
               </chart:SplineAreaSeries>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbOverlayStyle.Radius = 30;
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes = secondaryAxis;
SplineAreaSeries series = new SplineAreaSeries();
series.ItemsSource = (new ViewModel()).Source;
series.XBindingPath = "X";
series.YBindingPath = "Y";
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb overlay size](images/thumb-and-thumb-overlay/thumb-overlay-radius.png)

## Thumb overlay color

You can change the color of the thumb overlay in the range selector using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Fill) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
             xmlns:local="clr-namespace:SliderTestbedSample.RangeSelector">
    <ContentPage.BindingContext>
        <local:ViewModel />
    </ContentPage.BindingContext>
    <rangeselector:SfRangeSelector>
        <rangeselector:SfRangeSelector.ThumbStyle>
            <rangeselector:SliderThumbStyle Fill="#F7C8DB" />
        </rangeselector:SfRangeSelector.ThumbStyle>
        <chart:SfCartesianChart>
            <chart:SfCartesianChart.XAxes>
               <chart:DateTimeAxis IsVisible="False"
                                   ShowMajorGridLines="False" />
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
               <chart:NumericalAxis IsVisible="False"
                                    ShowMajorGridLines="False" />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
               <chart:SplineAreaSeries ItemsSource="{Binding Source}"
                                       XBindingPath="X"
                                       YBindingPath="Y"
                                       Fill="Blue">
               </chart:SplineAreaSeries>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbOverlayStyle.Fill = new SolidColorBrush(Color.FromArgb("#F7C8DB"));
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes = secondaryAxis;
SplineAreaSeries series = new SplineAreaSeries();
series.ItemsSource = (new ViewModel()).Source;
series.XBindingPath = "X";
series.YBindingPath = "Y";
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb overlay color](images/thumb-and-thumb-overlay/thumb-overlay-color.png)
---
layout: post
title: Dividers in .NET MAUI Range Selector control | Syncfusion®
description: Learn here all about the Dividers feature of .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Dividers in .NET MAUI Range Selector (SfRangeSelector)

This section explains how to add the dividers in the Range Selector.

## Show dividers

The [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers) property is used to render the dividers on the track. The default value of the [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers) property is `False`. It is a shape used to represent the major interval points of the track.

For example, if the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) is 0,  [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) is 10.0, and [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval) is 2.0, the Range Selector will render the dividers at 0.0, 2.0, 4.0, and so on.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector Interval="0.2" 
                             ShowDividers="True">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Interval = 0.2;
rangeSelector.ShowDividers = true;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector divider](images/labels-and-dividers/divider.png)

## Divider radius

Change the active and inactive divider radius of the Range Selector using the [`ActiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveRadius) and the [`InactiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveRadius) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfRangeSelector Interval="0.2" 
                             ShowDividers="True">
        
        <sliders:SfRangeSelector.DividerStyle>
            <sliders:SliderDividerStyle ActiveRadius="3" 
                                        InactiveRadius="5" />
        </sliders:SfRangeSelector.DividerStyle>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Interval = 0.2;
rangeSelector.ShowDividers = true;
rangeSelector.DividerStyle.ActiveRadius = 3;
rangeSelector.DividerStyle.InactiveRadius = 5;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector divider radius](images/labels-and-dividers/divider-radius.png)

## Divider stroke width and stroke color

Change the active and inactive divider stroke width of the Range Selector using the [`ActiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStrokeThickness) and the [`InactiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStrokeThickness) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

Also, change the active and inactive divider stroke color of the Range Selector using the [`ActiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStroke) and the [`InactiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStroke) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector Interval="0.2"
                             ShowDividers="True">

        <sliders:SfRangeSelector.DividerStyle>
            <sliders:SliderDividerStyle ActiveRadius="7"
                                        InactiveRadius="7"
                                        ActiveFill="#EE3F3F"
                                        InactiveFill="#F7B1AE"
                                        ActiveStrokeThickness="2"
                                        InactiveStrokeThickness="2"
                                        ActiveStroke="#FFD700"
                                        InactiveStroke="#FFD700" />
        </sliders:SfRangeSelector.DividerStyle>

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Interval = 0.2;
rangeSelector.ShowDividers = true;
rangeSelector.DividerStyle.ActiveRadius = 7;
rangeSelector.DividerStyle.InactiveRadius = 7;
rangeSelector.DividerStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSelector.DividerStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
rangeSelector.DividerStyle.ActiveStroke = new SolidColorBrush(Color.FromArgb("#FFD700"));
rangeSelector.DividerStyle.InactiveStroke = new SolidColorBrush(Color.FromArgb("#FFD700"));
rangeSelector.DividerStyle.ActiveStrokeThickness = 2;
rangeSelector.DividerStyle.InactiveStrokeThickness = 2;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector divider stroke color](images/labels-and-dividers/divider-stroke-color.png)

## Divider color

Change the active and inactive divider color of the Range Selector using the [`ActiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveFill) and [`InactiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveFill) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector Interval="0.2" 
                             ShowDividers="True">

        <sliders:SfRangeSelector.DividerStyle>
            <sliders:SliderDividerStyle ActiveRadius="7" 
                                        InactiveRadius="7" 
                                        ActiveFill="#EE3F3F" 
                                        InactiveFill="#F7B1AE" />
        </sliders:SfRangeSelector.DividerStyle>

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
        
    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Interval = 0.2;
rangeSelector.ShowDividers = true;
rangeSelector.DividerStyle.ActiveRadius = 7;
rangeSelector.DividerStyle.InactiveRadius = 7;
rangeSelector.DividerStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSelector.DividerStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector divider color](images/labels-and-dividers/divider-color.png)
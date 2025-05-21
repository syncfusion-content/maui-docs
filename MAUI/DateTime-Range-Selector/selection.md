---
layout: post
title: Range Selection in .NET MAUI Range Selector Control | Syncfusion®
description: Learn about range selection in the Syncfusion® .NET MAUI Range Selector (SfDateTimeRangeSelector) control and more.
platform: maui
control: SfDateTimeRangeSelector
documentation: ug
---

# Range Selection in .NET MAUI Range Selector (SfDateTimeRangeSelector)

This section explains how to handle range selection in the DateTime Range Selector.

## Discrete Selection

Move the thumb in discrete steps for date values using the [`StepDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_StepDuration) property in the DateTime Range Selector.

For example, if the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) is `DateTime(2015, 01, 01)`, [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) is `DateTime(2020, 01, 01)`, and [`StepDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_StepDuration) is `1`, the Range Selector will move thumbs to `DateTime(2015, 01, 01)`, `DateTime(2016, 01, 01)`, `DateTime(2017, 01, 01)`, and so on.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfDateTimeRangeSelector Minimum="2000-01-01" 
                                     Maximum="2005-01-01" 
                                     RangeStart="2001-01-01"
                                     RangeEnd="2004-01-01"
                                     Interval="1"
                                     IntervalType="Years"
                                     DateFormat="yyyy"  
                                     ShowLabels="True" 
                                     ShowTicks="True" 
                                     ShowDividers="True"
                                     StepDuration="1">
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2000, 01, 01);
rangeSelector.Maximum = new DateTime(2005, 01, 01);
rangeSelector.RangeStart = new DateTime(2001, 01, 01); 
rangeSelector.RangeEnd = new DateTime(2004, 01, 01);
rangeSelector.Interval = 1;
rangeSelector.IntervalType = SliderDateIntervalType.Years;
rangeSelector.DateFormat = "yyyy";    
rangeSelector.ShowLabels = true;
rangeSelector.ShowTicks = true;      
rangeSelector.ShowDividers = true;    
rangeSelector.StepDuration = new SliderStepDuration(years: 1);
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
         
{% endhighlight %}

{% endtabs %}

![RangeSelector date discrete mode](images/selection/step-duration.gif)

## Interval Selection

If the [EnableIntervalSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection) property is set to `true`, both thumbs will move to the selected interval. Otherwise, the nearest thumb will move to the touch position.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                     Maximum="2018-01-01" 
                                     RangeStart="2012-01-01" 
                                     RangeEnd="2016-01-01"
                                     Interval="2" 
                                     ShowTicks="True"
                                     ShowLabels="True"
                                     EnableIntervalSelection="True">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2010, 01, 01);
rangeSelector.Maximum = new DateTime(2018, 01, 01);
rangeSelector.RangeStart = new DateTime(2012, 01, 01);
rangeSelector.RangeEnd = new DateTime(2016, 01, 01);       
rangeSelector.ShowLabels = true;
rangeSelector.ShowTicks = true;    
rangeSelector.EnableIntervalSelection = true;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
         
{% endhighlight %}

{% endtabs %}

![RangeSelector EnableIntervalSelection](images/selection/enableintervalselection.gif)

## DragBehavior

### OnThumb

When the [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior) is set to [OnThumb](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb), each thumb can be moved individually. This is the default drag behavior.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01"
                                     Maximum="2018-01-01"
                                     RangeStart="2012-01-01"
                                     RangeEnd="2016-01-01"
                                     Interval="2"
                                     ShowTicks="True"
                                     ShowLabels="True"
                                     EdgeLabelsPlacement="Inside"
                                     DragBehavior="OnThumb">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2010, 01, 01);
rangeSelector.Maximum = new DateTime(2018, 01, 01);
rangeSelector.RangeStart = new DateTime(2012, 01, 01);
rangeSelector.RangeEnd = new DateTime(2016, 01, 01);
rangeSelector.Interval = 2; 
rangeSelector.ShowTicks = true;
rangeSelector.ShowLabels = true;  
rangeSelector.EdgeLabelsPlacement = SliderEdgeLabelsPlacement.Inside;
rangeSelector.DragBehavior = SliderDragBehavior.OnThumb;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

### BetweenThumbs

When the [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior) is set to [BetweenThumbs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_BetweenThumbs), both thumbs move simultaneously, preserving the range between them, without considering the thumb radius. Individual thumb movement is not possible in this mode.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                     Maximum="2018-01-01" 
                                     RangeStart="2012-01-01" 
                                     RangeEnd="2016-01-01"
                                     Interval="2" 
                                     ShowTicks="True"
                                     ShowLabels="True"
                                     EdgeLabelsPlacement="Inside"
                                     DragBehavior="BetweenThumbs">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2010, 01, 01);
rangeSelector.Maximum = new DateTime(2018, 01, 01);
rangeSelector.RangeStart = new DateTime(2012, 01, 01);
rangeSelector.RangeEnd = new DateTime(2016, 01, 01);
rangeSelector.Interval = 2; 
rangeSelector.ShowTicks = true;
rangeSelector.ShowLabels = true;   
rangeSelector.EdgeLabelsPlacement = SliderEdgeLabelsPlacement.Inside;
rangeSelector.DragBehavior = SliderDragBehavior.BetweenThumbs;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

### Both

When the [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior) is set to [Both](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_Both), individual thumbs can be moved, as well as both thumbs simultaneously without altering the range between them.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                     Maximum="2018-01-01" 
                                     RangeStart="2012-01-01" 
                                     RangeEnd="2016-01-01"
                                     Interval="2" 
                                     ShowTicks="True"
                                     ShowLabels="True"
                                     EdgeLabelsPlacement="Inside"
                                     DragBehavior="Both">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2010, 01, 01);
rangeSelector.Maximum = new DateTime(2018, 01, 01);
rangeSelector.RangeStart = new DateTime(2012, 01, 01);
rangeSelector.RangeEnd = new DateTime(2016, 01, 01);
rangeSelector.Interval = 2; 
rangeSelector.ShowTicks = true; 
rangeSelector.ShowLabels = true;  
rangeSelector.EdgeLabelsPlacement = SliderEdgeLabelsPlacement.Inside;
rangeSelector.DragBehavior = SliderDragBehavior.Both;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector DragBehavior](images/selection/drag_behavior.gif)

## Deferred Update

You can control when dependent components are updated while dragging thumbs continuously. This can be achieved by setting the `EnableDeferredUpdate` property. The `DeferredUpdateDelay` property controls the delay in updates, with a default value of `500` milliseconds.

The `ValueChanging` event is invoked when the thumb is dragged and held for the specified `DeferredUpdateDelay` duration. The values are immediately updated upon touch release.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                     Maximum="2018-01-01" 
                                     RangeStart="2012-01-01" 
                                     RangeEnd="2016-01-01"
                                     Interval="2" 
                                     ShowTicks="True"
                                     ShowLabels="True"
                                     EnableDeferredUpdate="True"
                                     DeferredUpdateDelay="1000">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2010, 01, 01);
rangeSelector.Maximum = new DateTime(2018, 01, 01);
rangeSelector.RangeStart = new DateTime(2012, 01, 01);
rangeSelector.RangeEnd = new DateTime(2016, 01, 01);   
rangeSelector.Interval = 2;    
rangeSelector.ShowLabels = true;
rangeSelector.ShowTicks = true;    
rangeSelector.EnableDeferredUpdate = true;
rangeSelector.DeferredUpdateDelay = 1000;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
         
{% endhighlight %}

{% endtabs %}
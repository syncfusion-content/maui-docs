---
layout: post
title: Thumb DragBehavior in .NET MAUI Range Selector control | Syncfusion
description: Learn here all about Thumb Dragbehavior feature of Syncfusion .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Thumb DragBehavior in .NET MAUI Range Selector (SfRangeSelector)

This section helps to learn about thumb drag behavior in the range selector.

## OnThumb

When the [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSelector.html?tabs=tabid-1#Syncfusion_Maui_Sliders_SfRangeSelector_DragBehavior) is set to [OnThumb](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb), individual thumb can be moved based on the dragging. By default, the [OnThumb](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb) has been used as drag behavior.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <rangeselector:SfRangeSelector Minimum="0" 
                                   Maximum="100"
                                   RangeStart="25"
                                   RangeEnd="75"
                                   Interval="25" 
                                   ShowTicks="True"
                                   ShowLabels="True"
                                   DragBehavior="OnThumb">
        <chart:SfCartesianChart />
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Minimum = 0;
rangeSelector.Maximum = 100;
rangeSelector.RangeStart = 25;
rangeSelector.RangeEnd = 75;
rangeSelector.Interval = 25; 
rangeSelector.ShowTicks = true;
rangeSelector.ShowLabels = true;  
rangeSelector.DragBehavior = SliderDragBehavior.OnThumb;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![DragBehavior OnThumb](images/drag-behavior/onthumb.gif)

## BetweenThumbs

When the [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html?tabs=tabid-1#Syncfusion_Maui_Sliders_SfRangeSlider_DragBehavior) is set to [BetweenThumbs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_BetweenThumbs), both the thumbs can be moved at same time without changing the range between the start and end thumbs. We had considered this behavior without the range selector thumb radius. Its not possible to move the individual thumb when setting this behavior.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <rangeselector:SfRangeSelector Minimum="0" 
                                   Maximum="100"
                                   RangeStart="25"
                                   RangeEnd="75"
                                   Interval="25" 
                                   ShowTicks="True"
                                   ShowLabels="True"
                                   DragBehavior="BetweenThumbs">
        <chart:SfCartesianChart />
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Minimum = 0;
rangeSelector.Maximum = 100;
rangeSelector.RangeStart = 25;
rangeSelector.RangeEnd = 75;
rangeSelector.Interval = 25; 
rangeSelector.ShowTicks = true;
rangeSelector.ShowLabels = true;   
rangeSelector.DragBehavior = SliderDragBehavior.BetweenThumbs;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![DragBehavior Betweenthumb](images/drag-behavior/betweenthumb.gif)

## Both

When the  [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html?tabs=tabid-1#Syncfusion_Maui_Sliders_SfRangeSlider_DragBehavior) is set to [Both](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_Both), the individual thumb can be moved and also the both thumbs can be moved at same time without changing the range between the start and end thumbs.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <rangeselector:SfRangeSelector Minimum="0" 
                                   Maximum="100"
                                   RangeStart="25"
                                   RangeEnd="75"
                                   Interval="25" 
                                   ShowTicks="True"
                                   ShowLabels="True"
                                   DragBehavior="Both">
        <chart:SfCartesianChart />
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Minimum = 0;
rangeSelector.Maximum = 100;
rangeSelector.RangeStart = 25;
rangeSelector.RangeEnd = 75;
rangeSelector.Interval = 25; 
rangeSelector.ShowTicks = true; 
rangeSelector.ShowLabels = true;  
rangeSelector.DragBehavior = SliderDragBehavior.Both;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![DragBehavior Both](images/drag-behavior/both.gif)

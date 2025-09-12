---
layout: post
title: Regions in .NET MAUI Range Selector Control | Syncfusion®
description: Learn about the Regions and their customization features in the .NET MAUI Range Selector (SfRangeSelector) control.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Regions in Range Selector (SfRangeSelector)

This section explains how to customize the active and inactive regions within the Range Selector control.

## Region Color

The color of the active and inactive regions can be modified using the [`ActiveRegionFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_ActiveRegionFill) and [`InactiveRegionFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_InactiveRegionFill) properties of the [`RangeSelectorBase`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html) class. By default, `ActiveRegionFill` is set to `SolidColorBrush(Colors.Transparent)`, and `InactiveRegionFill` is `SolidColorBrush(Color.FromRgba(255, 255, 255, 192))`.

The active region spans between the start and end thumbs, while the inactive regions are between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) value and the left thumb, and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) value.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector ActiveRegionFill="#40FFFF00"
                             InactiveRegionFill="#33FF8A00">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector(); 
rangeSelector.ActiveRegionFill = new SolidColorBrush(Color.FromArgb("#40FFFF00"));    
rangeSelector.InactiveRegionFill = new SolidColorBrush(Color.FromArgb("#33FF8A00")); 
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector region color](images/regions/region_color.png)

## Region Stroke

Change the stroke color of the active and inactive regions using the [`ActiveRegionStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_ActiveRegionStroke) and [`InactiveRegionStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_InactiveRegionStroke) properties of the [`RangeSelectorBase`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html) class. The default value of the [`ActiveRegionStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_ActiveRegionStroke) and the [`InactiveRegionStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_InactiveRegionStroke) properties are `SolidColorBrush(Colors.Transparent)` and `SolidColorBrush(Colors.Transparent)` respectively.

The active side of the  Range Selector is between the start and the end thumbs.

The inactive side of the  Range Selector is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) value and the left thumb and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) value.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector ActiveRegionFill="#40FFFF00"
                             InactiveRegionFill="#33FF8A00"
                             ActiveRegionStroke="#FFFF00"
                             InactiveRegionStroke="#B8860B">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector(); 
rangeSelector.ActiveRegionFill = new SolidColorBrush(Color.FromArgb("#40FFFF00"));    
rangeSelector.InactiveRegionFill = new SolidColorBrush(Color.FromArgb("#33FF8A00")); 
rangeSelector.ActiveRegionStroke = new SolidColorBrush(Color.FromArgb("#FFFF00")); 
rangeSelector.InactiveRegionStroke = new SolidColorBrush(Color.FromArgb("#B8860B"));       
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
         
{% endhighlight %}

{% endtabs %}

![RangeSelector region stroke](images/regions/region_stroke.png)

## Region Stroke Thickness

Change the stroke thickness of the active and inactive regions using the [`ActiveRegionStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_ActiveRegionStrokeThickness) and [`InactiveRegionStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_InactiveRegionStrokeThickness) properties of the [`RangeSelectorBase`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html) class. The default value of the [`ActiveRegionStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_ActiveRegionStrokeThickness) and the [`InactiveRegionStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_InactiveRegionStrokeThickness) properties is `Thickness(1)`.

The active side of the  Range Selector is between the start and the end thumbs.

The inactive side of the  Range Selector is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) value and the left thumb and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) value.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector ActiveRegionFill="#40FFFF00"
                             InactiveRegionFill="#33FF8A00"
                             ActiveRegionStroke="#A52A2A"
                             InactiveRegionStroke="#A52A2A"
                             ActiveRegionStrokeThickness="3,0,3,0"
                             InactiveRegionStrokeThickness="0,3,0,3">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ActiveRegionFill = new SolidColorBrush(Color.FromArgb("#40FFFF00"));    
rangeSelector.InactiveRegionFill = new SolidColorBrush(Color.FromArgb("#33FF8A00")); 
rangeSelector.ActiveRegionStroke = new SolidColorBrush(Color.FromArgb("#A52A2A")); 
rangeSelector.InactiveRegionStroke = new SolidColorBrush(Color.FromArgb("#A52A2A"));       
rangeSelector.ActiveRegionStrokeThickness = new Thickness(3,0,3,0);
rangeSelector.InactiveRegionStrokeThickness = new Thickness(0,3,0,3);
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
         
{% endhighlight %}

{% endtabs %}

![RangeSelector region stroke width](images/regions/region_stroke_width.png)

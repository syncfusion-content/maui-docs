---
layout: post
title: Regions in.NET MAUI Range Selector control | Syncfusion 
description: Learn here all about the Regions and its customization feature of .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Regions in Range Selector (SfRangeSelector)

This section explains how to customize the active and inactive regions in the Range Selector control.

## Region color

Change the color of the active and inactive regions using the `ActiveRegionFill` and `InactiveRegionFill` properties of the `RangeSelectorBase` class. The default value of the `ActiveRegionFill` and the `InactiveRegionFill` properties are `SolidColorBrush(Colors.Transparent)` and `SolidColorBrush(Color.FromRgba(255, 255, 255, 192)` respectively.

The active side of the Range Selector is between the start and end thumbs.

The inactive side of the Range Selector is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum) value and the left thumb, and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum) value.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector Minimum="2000-01-01"
                                     Maximum="2005-01-01"
                                     RangeStart="2001-01-01"
                                     RangeEnd="2004-01-01"
                                     ActiveRegionFill="#40FFFF00"
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

## Region stroke

Change the stroke color of the active and inactive regions using the `ActiveRegionStroke` and `InactiveRegionStroke` properties of the `RangeSelectorBase` class. The default value of the `ActiveRegionStroke` and the `InactiveRegionStroke` properties are `SolidColorBrush(Colors.Transparent)` and `SolidColorBrush(Colors.Transparent)` respectively.

The active side of the  Range Selector is between the start and end thumbs.

The inactive side of the  Range Selector is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum) value and the left thumb, and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum) value.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector Minimum="2000-01-01"
                                     Maximum="2005-01-01"
                                     RangeStart="2001-01-01"
                                     RangeEnd="2004-01-01"
                                     ActiveRegionFill="#40FFFF00"
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

## Region stroke thickness

Change the stroke thickness of the active and inactive regions using the `ActiveRegionStrokeThickness` and `InactiveRegionStrokeThickness` properties of the `RangeSelectorBase` class. The default value of the `ActiveRegionStrokeThickness` and the `InactiveRegionStrokeThickness` properties are `Thickness(1)`.

The active side of the  Range Selector is between the start and end thumbs.

The inactive side of the  Range Selector is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum) value and the left thumb, and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum) value.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector Minimum="2000-01-01"
                                     Maximum="2005-01-01"
                                     RangeStart="2001-01-01"
                                     RangeEnd="2004-01-01"
                                     ActiveRegionFill="#40FFFF00"
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

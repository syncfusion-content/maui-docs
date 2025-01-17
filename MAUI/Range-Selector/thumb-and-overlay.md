---
layout: post
title: Thumb and Overlay in .NET MAUI Range Selector control | Syncfusion®
description: Learn here all about the Thumb and Thumb Overlay features of Syncfusion® .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Thumb and Overlay in .NET MAUI Range Selector (SfRangeSelector)

This section helps to learn about how to customize the thumb and thumb overlay in the Range Selector.

* Thumb - It is one of the elements of slider which can be used to drag and change the selected value of the Range Selector.
* Thumb overlay - It is rendered around the thumb while interacting with them.

## Thumb size

Change the size of the thumb in the Range Selector using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius)  property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius) property is `10.0`.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfRangeSelector>
        
        <sliders:SfRangeSelector.ThumbStyle>
            <sliders:SliderThumbStyle Radius="15" />
        </sliders:SfRangeSelector.ThumbStyle>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.Radius = 15;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb size](images/thumb-and-thumb-overlay/thumb-radius.png)

## Thumb color

Change the color of the thumb in the Range Selector using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Fill) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfRangeSelector>
        
        <sliders:SfRangeSelector.ThumbStyle>
            <sliders:SliderThumbStyle Fill="#EE3F3F" />
        </sliders:SfRangeSelector.ThumbStyle>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.Fill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb color](images/thumb-and-thumb-overlay/thumb-color.png)

## Thumb stroke thickness and stroke

Change the thumb stroke width using the [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_StrokeThickness) property and thumb stroke color using the [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Stroke) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfRangeSelector>
        
        <sliders:SfRangeSelector.ThumbStyle>
            <sliders:SliderThumbStyle StrokeThickness="2" Stroke="#EE3F3F" />
        </sliders:SfRangeSelector.ThumbStyle>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSelector.ThumbStyle.StrokeThickness = 2;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb stroke color](images/thumb-and-thumb-overlay/thumb-stroke-color.png)

## Thumb overlapping stroke color

Change the thumb stroke color while two thumbs are overlapping in the Range Selector using the [`OverlapStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_OverlapStroke) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfRangeSelector>
        
        <sliders:SfRangeSelector.ThumbStyle>
            <sliders:SliderThumbStyle OverlapStroke="#FFD700" />
        </sliders:SfRangeSelector.ThumbStyle>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbStyle.OverlapStroke = new SolidColorBrush(Color.FromArgb("#FFD700"));
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb stroke color](images/thumb-and-thumb-overlay/thumb-overlapstrokecolor.gif)

## Thumb overlay size

Change the size of the thumb overlay in the Range Selector using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property is `24.0`.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfRangeSelector>
        
        <sliders:SfRangeSelector.ThumbOverlayStyle>
            <sliders:SliderThumbOverlayStyle Radius="18" />
        </sliders:SfRangeSelector.ThumbOverlayStyle>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbOverlayStyle.Radius = 18;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb overlay size](images/thumb-and-thumb-overlay/thumb-overlay-radius.png)

## Thumb overlay color

Change the color of the thumb overlay in the Range Selector using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Fill) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfRangeSelector>
        
        <sliders:SfRangeSelector.ThumbOverlayStyle>
            <sliders:SliderThumbOverlayStyle Fill="#66FFD700" />
        </sliders:SfRangeSelector.ThumbOverlayStyle>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.ThumbOverlayStyle.Fill = new SolidColorBrush(Color.FromArgb("#66FFD700"));
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;
        
{% endhighlight %}

{% endtabs %}

![RangeSelector thumb overlay color](images/thumb-and-thumb-overlay/thumb-overlay-color.png)

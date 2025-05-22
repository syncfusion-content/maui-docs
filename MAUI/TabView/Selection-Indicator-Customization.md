---
layout: post
title: Customize the Indicator in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about selection indicator customization support in the Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Customize the Selection Indicator in .NET MAUI Tab View (SfTabView)

## Placement options

The .NET MAUI Tab View provides three options for determining how the selection indicator aligns relative to the tab header item. These options are top, bottom, and fill. This can be configured by setting the [IndicatorPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorPlacement) property of SfTabView.

### Top

The indicator will be placed at the top of the selected tab.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorPlacement="Top">
{% endhighlight %}

{% highlight C# %}
     tabView.IndicatorPlacement = IndicatorPlacement.Top;
{% endhighlight %}

{% endtabs %}

![Top](images/Selection-Indicator-placement-Top.png) 

### Bottom

The indicator will be placed at the bottom of the selected tab.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorPlacement="Bottom">
{% endhighlight %}

{% highlight C# %}
     tabView.IndicatorPlacement = IndicatorPlacement.Bottom;
{% endhighlight %}

{% endtabs %}

![Bottom](images/Selection-Indicator-placement-Bottom.png) 

### Fill

The indicator will fill the selected tab.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorPlacement="Fill">
{% endhighlight %}

{% highlight C# %}
     tabView.IndicatorPlacement = IndicatorPlacement.Fill;
{% endhighlight %}

{% endtabs %}

![Fill](images/Selection-Indicator-placement-Fill.png) 

## Background customization

The background of the indicator can be customized using the [IndicatorBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorBackground) property of SfTabView.

### Solid color 

The SolidColorBrush class defines the color property of [IndicatorBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorBackground), representing the selection indicator background's color.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorBackground="LightBlue">
{% endhighlight %}

{% highlight C# %}
     tabView.TabBarBackground = Color.LightBlue;
{% endhighlight %}

{% endtabs %}

![IndicatorBackground.](images/Selection-Indicator-background.png) 

### Gradient color 

The background can be customized with a linear gradient and radial gradient as like below example.

{% tabs %}
{% highlight xaml %}
    <tabView:SfTabView>
        <tabView:SfTabView.IndicatorBackground>
            <LinearGradientBrush EndPoint="0,1">
                <GradientStop Color="#009FFF" Offset="0.1" />
                <GradientStop Color="#ec2F4B Offset="1.0" />
            </LinearGradientBrush>
        </tabView:SfTabView.IndicatorBackground>
    </tabView:SfTabView>
{% endhighlight %}
{% highlight C# %}
Microsoft.Maui.Controls.GradientStop gra1 = new Microsoft.Maui.Controls.GradientStop()
{
    Color = Color.FromArgb("#009FFF"),
    Offset = (float)0.1,
};

Microsoft.Maui.Controls.GradientStop gra2 = new Microsoft.Maui.Controls.GradientStop()
{
    Color = Color.FromArgb("#ec2F4B"),
    Offset = (float)1.0,
};

LinearGradientBrush graBrush = new LinearGradientBrush()
{
    EndPoint = new Point(0, 1),
    GradientStops = new GradientStopCollection() { gra1, gra2 }
};

SfTabView tabView = new SfTabView();
tabView.IndicatorBackground = graBrush;

{% endhighlight %}
{% endtabs %}

![Gradient](images/Selection-Indicator-gradient-background.png) 

N> View the complete [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabBarCustomization) on GitHub.

## IndicatorWidthMode

The [IndicatorWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorWidthMode) property allows customization of the width of the indicator. By default, the `IndicatorWidthMode` property is set to [Fit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.IndicatorWidthMode.html#Syncfusion_Maui_TabView_IndicatorWidthMode_Fit), which adjusts the indicator width to fit the content of the header item. You can change the width size based on the header item by setting the `IndicatorWidthMode` property to [Stretch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.IndicatorWidthMode.html#Syncfusion_Maui_TabView_IndicatorWidthMode_Stretch).

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorWidthMode="Fit">
{% endhighlight %}

{% highlight C# %}
     tabView.IndicatorWidthMode = IndicatorWidthMode.Fit;
{% endhighlight %}

{% endtabs %}

![IndicatorWidthMode fit](images/IndicatorWidthMode_Fit.png) 

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorWidthMode="Stretch">
{% endhighlight %}

{% highlight C# %}
     tabView.IndicatorWidthMode = IndicatorWidthMode.Stretch;
{% endhighlight %}

{% endtabs %}

![IndicatorWidthMode stretch](images/IndicatorWidthMode_Stretch.png) 

## IndicatorCornerRadius

You can customize the corner radius of the selection indicator using the [IndicatorCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorCornerRadius) property in the Tab View.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorCornerRadius ="5">
{% endhighlight %}

{% highlight C# %}
     tabView.IndicatorCornerRadius  = 5;
{% endhighlight %}

{% endtabs %} 

![IndicatorCornerRadius](images/IndicatorCornerRadius.png) 

## IndicatorStrokeThickness

You can customize the stroke thickness of the selection indicator using the [IndicatorStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorStrokeThickness) property in the Tab View.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorStrokeThickness ="7">
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
     tabView.IndicatorStrokeThickness  = 7;
{% endhighlight %}

{% endtabs %} 

![IndicatorStrokeThickness](images\IndicatorStrokeThickness.png) 
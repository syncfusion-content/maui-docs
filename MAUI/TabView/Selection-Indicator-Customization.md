---
layout: post
title: Customize the indicator in .NET MAUI Tab View (SfTabView) | Syncfusion
description: Learn here all about selection indicator customization support in Syncfusion .NET MAUI Tab View (SfTabView) control and more.
platform: maui
control: Tab View
documentation: ug
---

# Customize the Selection Indicator in .NET MAUI Tab View (SfTabView)

## Placement options

The .NET MAUI Tab View provides three options for determining how selection indicator aligns relative to the tab header item. The options are top, bottom, and fill. This can be done by setting the [IndicatorPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabIndicatorPlacement.html) property of SfTabView.

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

![Tab Image Position Top.](images/Selection-Indicator-placement-Top.png) 

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

![Tab Image Position Bottom.](images/Selection-Indicator-placement-Bottom.png) 

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

![Tab Image Position Fill.](images/Selection-Indicator-placement-Fill.png) 

## Background Customization

The background of the indicator can be customized using the [IndicatorBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorBackground) property of SfTabView.

### Solid Color 

The SolidColorBrush class defines the color property of [IndicatorBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorBackground), which represents the color of the selection indicator background.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView IndicatorBackground="LightBlue">
{% endhighlight %}

{% highlight C# %}
     tabView.TabBarBackground = Color.LightBlue;
{% endhighlight %}

{% endtabs %}

![Selection Indicator Background.](images/Selection-Indicator-background.png) 

### Gradient Color 

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

![Selection Indicator Gradient](images/Selection-Indicator-gradient-background.png) 

N> View [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabBarCustomization) in GitHub
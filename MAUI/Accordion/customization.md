---
layout: post
title: Customization in .NET MAUI Accordion control | Syncfusion
description: Learn here all about Customization support in Syncfusion Maui Accordion (SfAccordion) control and more details. 
platform: MAUI
control: SfAccordion
documentation: ug
--- 

# Customization in .NET MAUI Accordion (SfAccordion)

## Animation duration

The `SfAccordion` allows you to customize the expanding and collapsing duration of accordion items by using the [AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationDuration) property. By default, the animation duration is set to `200 milliseconds`. 

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        AnimationDuration="150">
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
var accordion = new SfAccordion();
accordion.AnimationDuration = 150;
{% endhighlight %}
{% endtabs %}

## Animation easing

You can customize the rate of change of a parameter over time or the animation style of an accordion item by using the [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing) property. By default, the animation easing is set to `Linear`.  

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        AnimationEasing="SinOut">
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
var accordion = new SfAccordion();
accordion.AnimationEasing = ExpanderAnimationEasing.SinOut;
{% endhighlight %}
{% endtabs %}

## Auto scroll position

The `SfAccordion` allows you to customize the scroll position of the expanded accordion item using the [AutoScrollPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition) property. By default, the auto-scroll position is set to `MakeVisible`.  

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        AutoScrollPosition="Top">
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
var accordion = new SfAccordion();
accordion.AutoScrollPosition = AccordionAutoScrollPosition.Top;
{% endhighlight %}
{% endtabs %}

## Bring an accordion item into view

The `BringIntoView` method is used to bring a specific item into view by scrolling to it programmatically.

{% tabs %}
{% highlight c# %}
private void Button_Clicked(object sender, EventArgs e)
{
    accordion.BringIntoView(accordion.Items[15]);
}
{% endhighlight %}
{% endtabs %}

## Expand mode

You can expand single or multiple items using the [ExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode) property. By default, the expanded mode is set to `Single`.  

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        ExpandMode="Multiple">
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
var accordion = new SfAccordion();
accordion.ExpandMode = AccordionExpandMode.Multiple;
{% endhighlight %}
{% endtabs %}

## Item spacing 

The `SfAccordion` allows you to customize the vertical spacing between the accordion items by using the [ItemSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing) property. 

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        ItemSpacing="6.0d">
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="2" %}
var accordion = new SfAccordion();
accordion.ItemSpacing = 6.0d;
{% endhighlight %}
{% endtabs %}


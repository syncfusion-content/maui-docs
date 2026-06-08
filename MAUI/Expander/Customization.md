---
layout: post
title: Customization in .NET MAUI Expander control | Syncfusion
description: Learn here all about Customization in Syncfusion<sup>&reg;</sup> Essential Studio<sup>&reg;</sup> .NET MAUI Expander (SfExpander) control and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Customization in .NET MAUI Expander (SfExpander)

## Animation duration

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to customize the expanding and collapsing duration by using the [AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationDuration) property. By default, the animation duration is `300 milliseconds`.

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfExpander x:Name="expander"
                       AnimationDuration="250">
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var expander = new SfExpander();
        expander.AnimationDuration = 250;
    }
}
{% endhighlight %}
{% endtabs %}

## Animation easing

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to customize the rate of change of parameters over time or animation style by using the [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationEasing) property. By default, the animation easing is `Linear`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfExpander x:Name="expander"
                        AnimationEasing="SinOut">
</syncfusion:SfExpander>

{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var expander = new SfExpander();
        expander.AnimationEasing = ExpanderAnimationEasing.SinOut;
    }
}
{% endhighlight %}
{% endtabs %}

## Expand and collapse 

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to programmatically expand and collapse by using the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded) property of the SfExpander. The user can control the expand and collapse interactions by handling the `Expanding` and `Collapsing` events.

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfExpander x:Name="expander"
                        IsExpanded="true">
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var expander = new SfExpander();
        expander.IsExpanded = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Events 

There are four built-in events in the SfExpander control namely:

* [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding)
* [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded)
* [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing)
* [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed)

### Expanding Event

The [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding) event will be triggered when the expander control is being expanded.It can cancel expansion with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`: Indicates that the expansion or collapse action should be canceled.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Expanding="SfExpander_Expanding" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfExpander_Expanding(object sender, ExpandingAndCollapsingEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### Expanded Event

The [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded) event is triggered when the expander is fully expanded. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Expanded="SfExpander_Expanded" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfExpander_Expanded(object sender, ExpandedAndCollapsedEventArgs e)
{
    // Codes that need to be executed once the expander is expanded.
}
{% endhighlight %}
{% endtabs %}

### Collapsing Event

The [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing) event will be triggered when the expander control is being collapsed.It can cancel collapsing with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`: Indicates that the expansion or collapse action should be canceled.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Collapsing="SfExpander_Collapsing" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfExpander_Collapsing(object sender, ExpandingAndCollapsingEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### Collapsed Event 

The [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed) event is triggered when the expander is collapsed. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Collapsed="SfExpander_Collapsed" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfExpander_Collapsed(object sender, ExpandedAndCollapsedEventArgs e)
{
    // Codes that need to be executed once the expander is collapsed.
}
{% endhighlight %}
{% endtabs %}

---
layout: post
title: Customization in .NET MAUI Expander control | Syncfusion®
description: Learn here all about Customization in Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> .NET MAUI Expander (SfExpander) control and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Customization in .NET MAUI Expander (SfExpander)

The SfExpander control provides various customization options to enhance the user experience and tailor the control's behavior to your application requirements. You can customize animation settings such as duration and easing, control the expand and collapse state programmatically, and respond to user interactions through built-in events. These customization features allow you to create smooth, interactive, and user-friendly expandable content sections in your .NET MAUI applications.

## Animation duration

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to customize the expanding and collapsing duration by using the [AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationDuration) property. By default, the animation duration is `300 milliseconds`. The AnimationDuration property accepts positive integer values in milliseconds, with lower values creating faster animations and higher values creating slower animations.

The following examples show how to set the animation duration in XAML and C#. Place the XAML code in your page markup file (for example, `MainPage.xaml`) and the C# code in the corresponding code-behind file (`MainPage.xaml.cs`) or another suitable location in your application.

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

        // Create and configure the SfExpander in the constructor or in a method
        var expander = new SfExpander();
        expander.AnimationDuration = 250;
    }
}
{% endhighlight %}
{% endtabs %}

## Animation easing

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to customize the rate of change of parameters over time or animation style by using the [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationEasing) property. By default, the animation easing is `Linear`. Available easing options include Linear, SinIn, SinOut, SinInOut, CubicIn, CubicOut, CubicInOut, ExpoIn, ExpoOut, ExpoInOut, and BounceOut.

The following examples show how to configure animation easing in XAML and C#. Place the XAML code in your page markup file and the C# code in the page code-behind or any appropriate initialization method.

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

        // Create and configure the SfExpander in the constructor or in a method
        var expander = new SfExpander();
        expander.AnimationEasing = ExpanderAnimationEasing.SinOut;
    }
}
{% endhighlight %}
{% endtabs %}

## Expand and collapse

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to programmatically expand and collapse by using the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded) property of the SfExpander. By default, the IsExpanded property is set to `false`, meaning the expander is collapsed initially. The user can control the expand and collapse interactions by handling the `Expanding` and `Collapsing` events.

The following examples demonstrate how to set the initial expanded state. Add the XAML snippet to your page markup file or configure the property in your page code-behind.

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

        // Create and configure the SfExpander in the constructor or in a method
        var expander = new SfExpander();
        expander.IsExpanded = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Events

There are four built-in events in the SfExpander control:

* [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding)
* [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded)
* [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing)
* [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed)

The events are fired in sequence when the expander state changes:

### Expand sequence

1. `Expanding` is triggered before the expander starts expanding.
2. If the action is not canceled, the expand animation runs.
3. `Expanded` is triggered after the expander is fully expanded.

### Collapse sequence

1. `Collapsing` is triggered before the expander starts collapsing.
2. If the action is not canceled, the collapse animation runs.
3. `Collapsed` is triggered after the expander is fully collapsed.

These events can be used together to validate user actions, prevent state changes, log activity, update UI elements, or execute custom business logic during the expand and collapse lifecycle.

### Expanding Event

The [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding) event is triggered when the expander control is being expanded. You can cancel expansion by using the [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html), which contains the following property:

* `Cancel`: Indicates whether the expansion or collapse action should be canceled.

When `e.Cancel` is set to `true`, the expansion operation is prevented and the expander remains in its current state.

The following example shows how to handle the event in the page code-behind.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Expanding="SfExpander_Expanding" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfExpander_Expanding(object sender, ExpandingAndCollapsingEventArgs e)
{
    e.Cancel = true; // Prevents the expander from expanding.
}
{% endhighlight %}
{% endtabs %}

### Expanded Event

The [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded) event is triggered when the expander is fully expanded. You can execute custom code when this event occurs.

The `ExpandedAndCollapsedEventArgs` provides information about the completed operation. The event arguments contain the following property:

* `Sender`: Gets the SfExpander instance that raised the event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Expanded="SfExpander_Expanded" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfExpander_Expanded(object sender, ExpandedAndCollapsedEventArgs e)
{
    var expander = e.Sender;

    // Codes that need to be executed once the expander is expanded.
}
{% endhighlight %}
{% endtabs %}

### Collapsing Event

The [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing) event is triggered when the expander control is being collapsed. You can cancel collapsing by using the [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html), which contains the following property:

* `Cancel`: Indicates whether the expansion or collapse action should be canceled.

When `e.Cancel` is set to `true`, the collapse operation is prevented and the expander remains in its current expanded state.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Collapsing="SfExpander_Collapsing" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfExpander_Collapsing(object sender, ExpandingAndCollapsingEventArgs e)
{
    e.Cancel = true; // Prevents the expander from collapsing.
}
{% endhighlight %}
{% endtabs %}

### Collapsed Event

The [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed) event is triggered when the expander is fully collapsed. You can execute custom code when this event occurs.

The `ExpandedAndCollapsedEventArgs` provides information about the completed operation. The event arguments contain the following property:

* `Sender`: Gets the SfExpander instance that raised the event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Collapsed="SfExpander_Collapsed" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfExpander_Collapsed(object sender, ExpandedAndCollapsedEventArgs e)
{
    var expander = e.Sender;

    // Codes that need to be executed once the expander is collapsed.
}
{% endhighlight %}
{% endtabs %}
---
layout: post
title: Events in .NET MAUI Segmented control | Syncfusion
description: Learn here all about the Events support in Syncfusion<sup>&reg;</sup> .NET MAUI Segmented Control (SfSegmentedControl).
platform: maui
control: SfSegmentedControl
documentation: ug
---

# Events in .NET MAUI Segmented Control (SfSegmentedControl)

The Segmented Control supports the [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_Tapped), and [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SelectionChanged) events to interact with .NET MAUI Segmented Control

## Tapped

A Tapped event occurs, each time a segment tapped.

Below is a list of the arguments:

* `Sender`: This contains the [SfSegmentedControl](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl__ctor) object.

* `Tapped`: The tapped action performed on an Segment can be found in the [SegmentTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTappedEventArgs.html), you can see details about the [SegmentItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTappedEventArgs.html#Syncfusion_Maui_Buttons_SegmentTappedEventArgs_SegmentItem).

## SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SelectionChanged) event is triggered once the segment is selected in the segmented control. The [SelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionChangedEventArgs.html) has the following values, which provide information for the `SelectionChanged` event.

* OldIndex
* NewIndex
* OldValue
* NewValue

{% tabs %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.SelectionChanged += OnSegmentedControlSelectionChanged;
        this.Content = segmentedControl;
    }

    private void OnSegmentedControlSelectionChanged(object sender, Syncfusion.Maui.Buttons.SelectionChangedEventArgs e)
    {
        var newValue = e.NewValue;
        var oldValue = e.OldValue;
        var newIndex = e.NewIndex;
        var oldIndex = e.OldIndex;
    }
}

{% endhighlight %}
{% endtabs %}
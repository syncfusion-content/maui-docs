---
layout: post
title: Right To Left FlowDirection in .NET MAUI Segmented control | Syncfusion
description: Learn about Right To Left support in Syncfusion .NET MAUI Segmented control (SfSegmentedControl).
platform: maui
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Right To Left Flow Direction in .NET MAUI Segmented control (SfSegmentedControl)

The [SfSegmentedControl](https://www.syncfusion.com/maui-controls/maui-segmented-control) supports changing the flow direction of items rendering in the right-to-left order by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage 
...
xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                FlowDirection="RightToLeft">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfSegmentedControl segmentedControl = new SfSegmentedControl();
segmentedControl.FlowDirection = FlowDirection.RightToLeft;
this.Content = segmentedControl;

{% endhighlight %}
{% endtabs %}

![Right to left in .NET MAUI Segmented control.](images/right-to-left/right-to-left.png)

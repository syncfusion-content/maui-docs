---
layout: post
title: Layout in .NET MAUI Segmented control | Syncfusion
description: Learn about the Layout support Syncfusion .NET MAUI Segmented control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Layout in .NET MAUI Segmented control (SfSegmentedControl)

## Customizing the segment width
You can use `SegmentWidth` property of `SfSegmentedControl`, to customize the segment width of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                SegmentWidth="100">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.SegmentWidth = 100;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Visible segment count

You can set the number of visible segments to be displayed in the `SfSegmentedControl` by using `VisibleSegmentsCount` property.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                VisibleSegmentsCount="4">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.VisibleSegmentsCount = 4;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

N> The layout of segments adjusts automatically once `VisibleSegmentsCount` is set. This means that the `SegmentWidth` and `SfSegmentItem.Width` properties will not apply, and the `WidthRequest` value should be divided by the `VisibleSegmentsCount` to determine the width of each segment.

## Customizing the segment height
You can use `SegmentHeight` property of `SfSegmentedControl`, to customize the segment height of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                SegmentHeight="40">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.SegmentHeight = 40;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}
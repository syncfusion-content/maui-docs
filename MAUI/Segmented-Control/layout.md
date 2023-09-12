---
layout: post
title: Layout in .NET MAUI Segmented control | Syncfusion
description: Learn about the Layout support Syncfusion .NET MAUI Segmented control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Layout in .NET MAUI Segmented control (SfSegmentedControl)

## Change the Segment Width

### Change the Segment Width for Segmented Control
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

### Change the Each Segment Item Width

You can change the width of the each segment item by using `Width` property of `SfSegmentItem`.

{% tabs %}
{% highlight C# tabtitle="MainPage.xaml.cs"%}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        List<SfSegmentItem> itemsCollection = new List<SfSegmentItem>
            {
                new SfSegmentItem() {Text="Day", Width = 50},
                new SfSegmentItem() {Text="Week", Width = 50},
                new SfSegmentItem() {Text="Month", Width = 50},
                new SfSegmentItem() {Text="Year", Width = 50},
            };
        segmentedControl.ItemsSource = itemsCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Change the Segment Height
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

## Visible Segment Count

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
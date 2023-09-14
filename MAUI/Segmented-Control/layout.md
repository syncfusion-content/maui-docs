---
layout: post
title: Layout in .NET MAUI Segmented Control | Syncfusion
description: Learn about the Layout support Syncfusion .NET MAUI Segmented control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Layout in .NET MAUI Segmented control (SfSegmentedControl)
The `SfSegmentedControl` supports changing the layout width, height and the number of visible segments displayed.

## Change the Segment Width
Change the width of the segmented control and each segment item.

### Change the Segment Width for Segmented Control
Use the `SegmentWidth` property of `SfSegmentedControl` to customize the segment width of the segmented control.

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
You can change the width of each segment item using the `Width` property of `SfSegmentItem`.

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
        List<SfSegmentItem> segmentItems = new List<SfSegmentItem>
            {
                new SfSegmentItem() {Text="Day", Width = 50},
                new SfSegmentItem() {Text="Week", Width = 50},
                new SfSegmentItem() {Text="Month", Width = 50},
                new SfSegmentItem() {Text="Year", Width = 50},
            };
        segmentedControl.ItemsSource = segmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Change the Segment Height
You can use the `SegmentHeight` property of `SfSegmentedControl` to customize the segment height of the segmented control.

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
Set the number of visible segments displayed in the `SfSegmentedControl` using `VisibleSegmentsCount` property.

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

N> The layout of segments adjusts automatically once `VisibleSegmentsCount` is set. This means that the `SegmentWidth` and `SfSegmentItem.Width` properties will not be applied, and the `WidthRequest` value should be divided by the `VisibleSegmentsCount` to determine the width of each segment.
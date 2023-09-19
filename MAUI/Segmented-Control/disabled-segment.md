---
layout: post
title: Disabled segmented item in .NET MAUI Segmented control | Syncfusion
description: Learn about the Disabled segmented item in Syncfusion .NET MAUI Segmented control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Disabled Segmented Item in .NET MAUI Segmented Control (SfSegmentedControl)

This section describes the features of the Segmented Control that help with disabling segmented item, customization of the disabled item, and associated operations.

## Enable or Disable segment

Restrict selection and interaction of segment items by setting the `IsEnabled` property of `SfSegmentItem` to `false`. The value of `IsEnabled` property is `true` by default.

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
                new SfSegmentItem() {Text="Day", IsEnabled = false},
                new SfSegmentItem() {Text="Week", IsEnabled = false},
                new SfSegmentItem() {Text="Month", IsEnabled = false},
                new SfSegmentItem() {Text="Year", IsEnabled = false},
            };
        segmentedControl.ItemsSource = segmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

### Programmatically Enable or Disable segment using Method
Set the enabled state of a specific segment at the specified index using the `SetSegmentEnabled` method of `SfSegmentedControl`.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                ItemsSource="{Binding SegmentItems}">
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
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.SegmentItems;
        this.segmentedControl.SetSegmentEnabled(1, true);
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week", IsEnabled = false},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Customizing disabled segment item
You can customize the disabled segment text color and background of the segmented control

### Customizing the disabled segment text color

Use the `DisabledSegmentTextColor` property of `SfSegmentedControl` to customize the disabled segment text color of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                DisabledSegmentTextColor="Red">
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
        segmentedControl.DisabledSegmentTextColor = Colors.Red;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

### Customizing the disabled segment background

Use the `DisabledSegmentBackground` property of `SfSegmentedControl` to customize the disabled segment background of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                DisabledSegmentBackground="LightGray">
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
        segmentedControl.DisabledSegmentBackground = Colors.LightGray;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}
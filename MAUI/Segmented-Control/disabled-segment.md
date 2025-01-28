---
layout: post
title: Disabled segmented item in .NET MAUI Segmented control | Syncfusion<sup>&reg;</sup>
description: Learn about the Disabled segmented item in Syncfusion<sup>&reg;</sup> .NET MAUI Segmented control (SfSegmentedControl).
platform: maui
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Disabled Segmented Item in .NET MAUI Segmented Control (SfSegmentedControl)

This section describes the features of the Segmented Control that help with disabling segmented item, customization of the disabled item, and associated operations.

## Enable or Disable segment

Restrict selection and interaction of segment items by setting the [IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_IsEnabled) property of [SfSegmentItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html) to `false`. The value of `IsEnabled` property is `true` by default.

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
               new SfSegmentItem() {Text = "XS",  IsEnabled = false},
               new SfSegmentItem() {Text = "S" },
               new SfSegmentItem() {Text = "M" },
               new SfSegmentItem() {Text = "L"},
               new SfSegmentItem() {Text = "XL", IsEnabled = false},
            };
        segmentedControl.ItemsSource = segmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

![Disabled segment in .NET MAUI Segmented control.](images/disabled-segment/disabled-segment.png)

### Programmatically Enable or Disable segment using Method
Set the enabled state of a specific segment at the specified index using the [SetSegmentEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SetSegmentEnabled_System_Int32_System_Boolean_) method of [SfSegmentedControl](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html).

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
        this.segmentedControl.SetSegmentEnabled(4, true);
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
               new SfSegmentItem() {Text = "XS"},
               new SfSegmentItem() {Text = "S"},
               new SfSegmentItem() {Text = "M"},
               new SfSegmentItem() {Text = "L"},
               new SfSegmentItem() {Text = "XL", IsEnabled = false},
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

Use the [DisabledSegmentTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_DisabledSegmentTextColor) property of [SfSegmentedControl](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html) to customize the disabled segment text color of the segmented control.

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

![Disabled segment text color customization in .NET MAUI Segmented control.](images/disabled-segment/disabled-segment-text-color.png)


N> The `DisabledSegmentTextColor` will be applicable only when the `IsEnabled` property of `SfSegmentItem`, or `SfSegmentedControl` is set to `false`.

### Customizing the disabled segment background

Use the [DisabledSegmentBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_DisabledSegmentBackground) property of [SfSegmentedControl](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html) to customize the disabled segment background of the segmented control.

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

![Disabled segment background customization in .NET MAUI Segmented control.](images/disabled-segment/disabled-segment-background.png)

N> The `DisabledSegmentBackground` will be applicable only when the `IsEnabled` property of `SfSegmentItem`, or `SfSegmentedControl` is set to `false`.
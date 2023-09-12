---
layout: post
title: Disabled segmented item in .NET MAUI Segmented control | Syncfusion
description: Learn about the Disabled segmented item in Syncfusion .NET MAUI Segmented control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Disabled segmented item in .NET MAUI Segmented control (SfSegmentedControl)

## Customizing disabled segment item

You can restrict selection and interaction of segment item by setting `IsEnabled` property of `SfSegmentItem` to `false`. The value `IsEnabled` property is `true` by default.

#### Customizing the disabled segment text color

You can use `DisabledSegmentTextColor` property of `SfSegmentedControl`, to customize the disabled segment text color of the segmented control.

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

#### Customizing the disabled segment background

You can use `DisabledSegmentBackground` property of `SfSegmentedControl`, to customize the disabled segment background of the segmented control.

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

## Set the enabled state of a specific segment

You can set the enabled state of a specific segment at the specified index by using `SetSegmentEnabled` method of `SfSegmentedControl`.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                ItemsSource="{Binding ItemCollection}">
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
        segmentedControl.ItemsSource = viewModel.ItemCollection;
        this.segmentedControl.SetSegmentEnabled(1, true);
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> itemCollection;

    public ViewModel()
    {
        itemCollection = new List<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week", IsEnabled = false},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public List<SfSegmentItem> ItemCollection
    {
        get { return itemCollection; }
        set { itemCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}
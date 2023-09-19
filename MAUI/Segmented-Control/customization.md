---
layout: post
title: Appearance Customization of .NET MAUI Segmented Control (SfSegmentedControl) | Syncfusion
description: Learn about the appearance customization of Syncfusion .NET MAUI Segmented Control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Appearance Customization of .NET MAUI Segmented Control (SfSegmentedControl)
The .NET MAUI Segmented control allows you to customize the background, text color, selection style, and more.

## Customize the border color
You can use the `Stroke` property of `SfSegmentedControl` to customize the border color of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                Stroke="Red">
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
        segmentedControl.Stroke = Colors.Red;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Customize the border thickness

You can use the `StrokeThickness` property of `SfSegmentedControl` to customize the border thickness of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                StrokeThickness="5">
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
        segmentedControl.StrokeThickness = 5;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Customize the border corner radius

Use the `CornerRadius` property of `SfSegmentedControl` to customize the corner radius of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                CornerRadius="5">
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
        segmentedControl.CornerRadius = 5;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

N> The `CornerRadius` property will be applicable only for the first and last segment items. To set corner radius for all segments, use `SegmentCornerRadius`.

## Customize the segment corner radius

Use the `SegmentCornerRadius` property of `SfSegmentedControl` to customize the segment corner radius of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                SegmentCornerRadius="5">
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
        segmentedControl.SegmentCornerRadius = 5;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Customize the text style
You can customize the text style of the segmented control and each segment item.

### Customize the text style of segmented Control
Use the `TextStyle` property of `SfSegmentedControl` to customize the text style of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.TextStyle>
            <buttons:SegmentTextStyle TextColor="Red" FontAttributes="Italic" FontSize="20"/>
        </buttons:SfSegmentedControl.TextStyle>
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
        segmentedControl.TextStyle = new SegmentTextStyle()
        {
            TextColor = Colors.Red,
            FontAttributes = FontAttributes.Italic,
            FontSize = 20,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

### Customize the text style of each segment item

Customize the text style of each segment item using the `TextStyle` property of `SfSegmentItem`.

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
                new SfSegmentItem() {Text="Day", TextStyle = new SegmentTextStyle(){TextColor = Colors.Green}},
                new SfSegmentItem() {Text="Week", TextStyle = new SegmentTextStyle(){TextColor = Colors.Green}},
                new SfSegmentItem() {Text="Month", TextStyle = new SegmentTextStyle(){TextColor = Colors.Green}},
                new SfSegmentItem() {Text="Year", TextStyle = new SegmentTextStyle(){TextColor = Colors.Green}},
            };
        segmentedControl.ItemsSource = segmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Customize the segment background
You can customize the segmented background of the segmented control and each segment item.

### Customize the Segment background of segemented control
Use the `SegmentBackground` property of `SfSegmentedControl` to customize the segmented background of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                SegmentBackground="LightGray">
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
        segmentedControl.SegmentBackground = Colors.LightGray;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

### Customize the segment background of each segment item

Customize the background of each segment item using the `Background` property of `SfSegmentItem`.

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
                new SfSegmentItem() {Text="Day", Background = Colors.LightBlue},
                new SfSegmentItem() {Text="Week", Background = Colors.LightBlue},
                new SfSegmentItem() {Text="Month", Background = Colors.LightBlue},
                new SfSegmentItem() {Text="Year", Background = Colors.LightBlue},
            };
        segmentedControl.ItemsSource = segmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Customize segment items appearance using DataTemplate

Use the `SegmentTemplate` property of `SfSegmentedControl` to create custom segmented control. The following example code shows how to create a custom segmented control using a data template.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.ItemsSource>
            <x:Array Type="{x:Type x:String}">                
                <x:String>Day</x:String>                
                <x:String>Week</x:String>
                <x:String>Month</x:String>
                <x:String>Year</x:String>
            </x:Array>
        </buttons:SfSegmentedControl.ItemsSource>
        <buttons:SfSegmentedControl.SegmentTemplate>
            <DataTemplate>
                <Grid Background="Orange">
                    <Label Text="{Binding Text}"
                           TextColor="Green"
                           Margin="6"/>
                </Grid>
            </DataTemplate>
        </buttons:SfSegmentedControl.SegmentTemplate>
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% endtabs %}
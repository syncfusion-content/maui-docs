---
layout: post
title: Appearance Customization of .NET MAUI Segmented Control (SfSegmentedControl) | Syncfusion
description: Learn about the appearance customization of Syncfusion .NET MAUI Segmented Control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Appearance Customization of .NET MAUI Segmented Control (SfSegmentedControl)
The .NET MAUI Segmented control allows you to customize the background, text color, selection style, and much more.

## Customize the border color
You can use `Stroke` property of `SfSegmentedControl`, to customize the border color of the segmented control.

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

You can use `StrokeThickness` property of `SfSegmentedControl`, to customize the border thickness of the segmented control.

{% tabs %}
{% highlight XAML %}

<ContentPage
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                StrokeThickness="1">
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
        segmentedControl.StrokeThickness = 1;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Customize the corner radius

You can use `CornerRadius` property of `SfSegmentedControl`, to customize the corner radius of the segmented control.

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

## Customize the segment text style
You can use `TextStyle` property of `SfSegmentedControl`, to customize the text style of the segmented control.

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

## Customize the segment control each item

#### Customize the segment corner radius

You can use `SegmentCornerRadius` property of `SfSegmentedControl`, to customize the segment corner radius of the segmented control.

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

#### Customize the segment background

You can use `SegmentBackground` property of `SfSegmentedControl`, to customize the segment background of the segmented control.

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

## Data template

You can use `SegmentTemplate` property of `SfSegmentedControl` to create custom segmented control. The following example code shows how to create custom segmented control using data template.

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
---
layout: post
title: Segment item selection in .NET MAUI Segmented control | Syncfusion
description: Learn about the segment item selection in Syncfusion .NET MAUI Segmented Control (SfSegmentedControl).
platform: .NET MAUI
control: SfSegmentedControl
documentation: ug
---
 
# Selection in .NET MAUI Segmented Control (SfSegmentedControl)

This section describes the features of the Segmented Control that help with item selection, customization of the selected item, and associated operations.

## Programmatically set selected index

You can set the default value programmatically for the selection to be placed. The selection gets updated based on the index value given for the `SelectedIndex`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                SelectedIndex="1">
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
        segmentedControl.SelectedIndex = 1;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Selection indicator placements

The Segmented control provides four types of selection indicator placement: Fill, border, top, and bottom border.

#### Fill
The selection indicator will fill the selected segment, if the `SelectionIndicatorPlacement` property of `SelectionIndicatorSettings` is set to `Fill`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                SelectionIndicatorPlacement="Fill"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            SelectionIndicatorPlacement = SelectionIndicatorPlacement.Fill,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

#### Border
The selection indicator will be highlighted with the border of the selected segment, if the `SelectionIndicatorPlacement` property of `SelectionIndicatorSettings` is set to `Border`,

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                SelectionIndicatorPlacement="Border"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            SelectionIndicatorPlacement = SelectionIndicatorPlacement.Border,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

#### Top border
The selection indicator will be placed at the top of the selected segment, if the `SelectionIndicatorPlacement` property of `SelectionIndicatorSettings` is set to `TopBorder`

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                SelectionIndicatorPlacement="TopBorder"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            SelectionIndicatorPlacement = SelectionIndicatorPlacement.TopBorder,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

#### Bottom border
The selection indicator will be placed at the bottom of the selected segment, if the `SelectionIndicatorPlacement` property of `SelectionIndicatorSettings` is set to `BottomBorder`

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                SelectionIndicatorPlacement="BottomBorder"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            SelectionIndicatorPlacement = SelectionIndicatorPlacement.BottomBorder,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Customize selected segment

The selected segment of the Segmented control is customized by using `SelectionIndicatorSettings` property of `SfSegmentedControl`.

#### Customize selected segment background
You can customize the selected segment background, by using `Background` property of `SelectionIndicatorSettings`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                Background="Blue"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            Background = Colors.Blue,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

#### Customize selected segment text color
You can customize the selected segment text color, by using `TextColor` property of `SelectionIndicatorSettings`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                TextColor="Red"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            TextColor = Colors.Red,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

#### Customize selected segment border color
You can customize the selected segment border color, by using `Stroke` property of `SelectionIndicatorSettings`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                Stroke="Green"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            Stroke = Colors.Green,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

#### Customize selected segment border thickness
You can customize the selected segment border thickness, by using `StrokeThickness` property of `SelectionIndicatorSettings`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings 
                StrokeThickness="1"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
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
        segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings()
        {
            StrokeThickness = 1,
        };
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Notifying segment selection changes
The `SelectionChanged` event is triggered, once the segment is selected in the Segmented control. The `SelectionChangedEventArgs` has the following values, which provides information for `SelectionChanged` event:

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

## Keyboard navigation

<table>
<tr>
<td>
<b> Navigation Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Right arrow<br/><br/></td><td>Moves to the next item on the segmented control's right side. It does not make any selection and only navigates to the next item. If the focus border is on the last item, pressing RightArrow does nothing.<br/><br/></td></tr>
<tr>
<td>
Left arrow<br/><br/></td><td>
Moves to the previous item on the segmented control's left side. It does not make any selection and only navigates to the previous item. If the focus border is on the first item, pressing LeftArrow does nothing.<br/><br/></td></tr>
<tr>
<td>
Enter<br/><br/></td><td>
Pressing the Enter key when segment item in focus will make selection.<br/><br/></td></tr>
</table>
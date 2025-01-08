---
layout: post
title: Events and Commands in.NET MAUI Slider control | Syncfusion<sup>®</sup> 
description: Learn here all about adding and customizing through events and commands of Syncfusion<sup>®</sup> .NET MAUI Slider (SfDateTimeSlider) control and more.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# Events and Commands in .NET MAUI DateTime Slider (SfDateTimeSlider)

This section explains how to add the events and commands for DateTime Slider.

## Events

### Handle callbacks

* [ValueChangeStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart) -  Called when the user selecting a new value for the slider by tap/mouse down in the thumb.
* [ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_ValueChanging) - Called when the user is selecting a new value for the slider by dragging the thumb.
* [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_ValueChanged) - Called when the user completed selecting a new value.
* [ValueChangeEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd) - Called when the user stopped interacting with slider by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider  Minimum="2010-01-01"
                           Maximum="2018-01-01"
                           Value="2014-01-01"
                           ValueChangeStart="OnValueChangeStart"
                           ValueChanging="OnValueChanging"
                           ValueChanged="OnValueChanged"
                           ValueChangeEnd="OnValueChangeEnd" />

{% endhighlight %}

{% highlight C# %}

{
    SfDateTimeSlider slider = new SfDateTimeSlider()
    {
        Minimum = new DateTime(2010, 01, 01),
        Maximum = new DateTime(2018, 01, 01),
        Value = new DateTime(2014, 01, 01),
    };
    slider.ValueChangeStart += OnValueChangeStart;
    slider.ValueChanging += OnValueChanging;
    slider.ValueChanged += OnValueChanged;
    slider.ValueChangeEnd += OnValueChangeEnd;
}

private void OnValueChangeStart(object sender, EventArgs e)
{
}

private void OnValueChanging(object sender, DateTimeSliderValueChangingEventArgs e)
{
}

private void OnValueChanged(object sender, DateTimeSliderValueChangedEventArgs e) 
{
}

private void OnValueChangeEnd(object sender, EventArgs e)
{
}

{% endhighlight %}

{% endtabs %}


### Customize label text

Format or change the label text using the [`LabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelCreated) event. The [`SliderLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html) contains the following parameters:

* Text – Customize the text color using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Text) parameter.
* Style – Formats the text color, font size, font family, offset using the [`Style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) parameter.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2011-01-01"
                          Value="2010-07-01"
                          Interval="3"
                          DateFormat="MMM"
                          ShowTicks="True"
                          LabelsPlacement="BetweenTicks"
                          IntervalType="Months"
                          LabelCreated="OnLabelCreated"
                          ShowLabels="True" />

{% endhighlight %}

{% highlight C# %}

{
    SfDateTimeSlider slider = new SfDateTimeSlider()
    {
        Minimum = new DateTime(2010, 01, 01),
        Maximum = new DateTime(2011, 01, 01),
        Value = new DateTime(2010, 07, 01),
        Interval = 3,
        DateFormat = "MMM",
        IntervalType = SliderDateIntervalType.Months,
        LabelsPlacement = SliderLabelsPlacement.BetweenTicks,
        ShowTicks = true,
        ShowLabels = true,
    };
    slider.LabelCreated += OnLabelCreated;
}

private void OnLabelCreated(object sender, SliderLabelCreatedEventArgs e)
{
    if (e.Text == "Jan")
    {
        e.Text = "Quarter 1";
    }
    else if (e.Text == "Apr")
    {
        e.Text = "Quarter 2";
    }
    else if (e.Text == "Jul")
    {
        e.Text = "Quarter 3";
    }
    else
    {
        e.Text = "Quarter 4";
    }
}

{% endhighlight %}

{% endtabs %}

![Slider custom label](images/labels-and-dividers/custom-label.png)

### Tooltip text format

By default, it is formatted based on the [`SliderTooltip.DateFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_DateFormat) property.

Format or change the whole tooltip label text using the [`TooltipLabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_TooltipLabelCreated) event. The [`SliderTooltipLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html) contains the following parameters:

* Text – Change the tooltip text using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderTooltipLabelCreatedEventArgs_Text) property.
* Color – Change the color of the tooltip text using the [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderTooltipLabelCreatedEventArgs_TextColor) property.
* Font Size – Change the font size of the tooltip text using the [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderTooltipLabelCreatedEventArgs_FontSize) property.
* Font Family – Change the font family of the tooltip text using the [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderTooltipLabelCreatedEventArgs_FontFamily) property.
* Font Attributes – Change the font attributes of the tooltip text using the [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderTooltipLabelCreatedEventArgs_FontAttributes) property.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2018-01-01"
                          Value="2014-01-01"
                          Interval="2"
                          ShowTicks="True"
                          ShowLabels="True">

    <sliders:SfDateTimeSlider.Tooltip>
        <sliders:SliderTooltip TooltipLabelCreated="OnTooltipLabelCreated" />
    </sliders:SfDateTimeSlider.Tooltip>
    
</sliders:SfDateTimeSlider>

{% endhighlight %}

{% highlight C# %}

{
    SfDateTimeSlider slider = new SfDateTimeSlider()
    {
        Minimum = new DateTime(2010, 01, 01),
        Maximum = new DateTime(2018, 01, 01),
        Value = new DateTime(2014, 01, 01),
        Interval = 3,
        ShowTicks = true,
        ShowLabels = true,
        Tooltip = new SliderTooltip(),
    };
    slider.Tooltip.TooltipLabelCreated += OnTooltipLabelCreated;
}

private void OnTooltipLabelCreated(object sender, SliderTooltipLabelCreatedEventArgs e)
{
    e.Text = "Year: " + e.Text;
}

{% endhighlight %}

{% endtabs %}

![Slider custom tooltip](images/tooltip/custom-tooltip.png)

## Commands and its parameter

### Drag started command

The [`DragStartedCommand`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand) will be executed when the user started moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfDateTimeSlider Minimum="2010-01-01"
                              Maximum="2018-01-01"
                              Value="2014-01-01"
                              DragStartedCommand="{Binding DragStartedCommand}" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2020, 01, 01),
    Value = new DateTime(2014, 01, 01),
    DragStartedCommand = viewModel.DragStartedCommand,
};

public class ViewModel
{
    public ICommand DragStartedCommand { get; }

    public ViewModel()
    {
        DragStartedCommand = new Command(OnDragStarted);
    }

    private void OnDragStarted(object obj)
    {
    }
}

{% endhighlight %}

{% endtabs %}

### Drag started command parameter

The [`DragStartedCommandParameter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter) will be executed when the user started moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfDateTimeSlider Minimum="2010-01-01"
                              Maximum="2018-01-01"
                              Value="2014-01-01"
                              DragStartedCommand="{Binding DragStartedCommand}"
                              DragStartedCommandParameter="1" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2020, 01, 01),
    Value = new DateTime(2014, 01, 01),
    DragStartedCommand = viewModel.DragStartedCommand,
    DragStartedCommandParameter = "1"
};

public class ViewModel
{
    public ICommand DragStartedCommand { get; }

    public ViewModel()
    {
        DragStartedCommand = new Command(OnDragStarted);
    }

    private void OnDragStarted(object obj)
    {
    }
}

{% endhighlight %}

{% endtabs %}

### Drag completed command

The [`DragCompletedCommand`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand) will be executed when the user completed moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfDateTimeSlider Minimum="2010-01-01"
                              Maximum="2018-01-01"
                              Value="2014-01-01"
                              DragCompletedCommand="{Binding DragCompletedCommand}" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2020, 01, 01),
    Value = new DateTime(2014, 01, 01),
    DragCompletedCommand = viewModel.DragCompletedCommand
};

public class ViewModel
{
    public ICommand DragCompletedCommand { get; }

    public ViewModel()
    {
        DragCompletedCommand = new Command(OnDragCompleted);
    }

    private void OnDragCompleted(object obj)
    {
    }
}

{% endhighlight %}

{% endtabs %}

### Drag completed command parameter

The [`DragCompletedCommandParameter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter) will be executed when the user completed moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfDateTimeSlider Minimum="2010-01-01"
                              Maximum="2018-01-01"
                              Value="2014-01-01"
                              DragCompletedCommand="{Binding DragCompletedCommand}"
                              DragCompletedCommandParameter="1" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2020, 01, 01),
    Value = new DateTime(2014, 01, 01),
    DragCompletedCommand = viewModel.DragCompletedCommand,
    DragCompletedCommandParameter = "1"
};

public class ViewModel
{
    public ICommand DragCompletedCommand { get; }

    public ViewModel()
    {
        DragCompletedCommand = new Command(OnDragCompleted);
    }

    private void OnDragCompleted(object obj)
    {
    }
}

{% endhighlight %}

{% endtabs %}
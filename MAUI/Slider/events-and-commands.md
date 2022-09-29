---
layout: post
title: Events and Commands in.NET MAUI Slider control | Syncfusion 
description: Learn here all about adding and customizing through events and commands of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Events and Commands in .NET MAUI Slider (SfSlider)

This section explains how to add the events and commands for slider.

## Events

### Handle callbacks

* [ValueChangeStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ValueChangeStart) -  Called when the user selecting a new value for the slider by tap/mouse down in the thumb.
* [ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChanging) - Called when the user is selecting a new value for the slider by dragging the thumb.
* [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChanged) - Called when the user completed selecting a new value.
* [ValueChangeEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ValueChangeEnd) - Called when the user stopped interacting with slider by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider ValueChangeStart="OnValueChangeStart"
                  ValueChanging="OnValueChanging"
                  ValueChanged="OnValueChanged"
                  ValueChangeEnd="OnValueChangeEnd" />

{% endhighlight %}

{% highlight C# %}

{
   SfSlider slider = new SfSlider();
   slider.ValueChangeStart += OnValueChangeStart;
   slider.ValueChanging += OnValueChanging;
   slider.ValueChanged += OnValueChanged;
   slider.ValueChangeEnd += OnValueChangeEnd;
}

private void OnValueChangeStart(object sender, EventArgs e)
{
}

private void OnValueChanging(object sender, SliderValueChangingEventArgs e)
{
}

private void OnValueChanged(object sender, SliderValueChangedEventArgs e) 
{
}
private void OnValueChangeEnd(object sender, EventArgs e)
{
}

{% endhighlight %}

{% endtabs %}


### Customize label text

Format or change the whole numeric label text using the [`LabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_LabelCreated) event. The [`SliderLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html) contains the following parameters,

* Text – Customize the text color using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) parameter.
* Style – Formats the text color, font size, font family, offset using the [`Style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderLabelCreatedEventArgs_Style) parameter.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="2"
                  Maximum="10"
                  Value="6"
                  Interval="2"
                  LabelCreated="OnLabelCreated"
                  ShowTicks="True"
                  ShowLabels="True" />

{% endhighlight %}

{% highlight C# %}

{
    SfSlider slider = new SfSlider()
    {
        Minimum = 2,
        Maximum = 10,
        Value = 6,
        Interval = 2,
        ShowTicks = true,
        ShowLabels = true,
    };
    slider.LabelCreated += OnLabelCreated;
}

 private void OnLabelCreated(object sender, SliderLabelCreatedEventArgs e)
 {
   e.Text = "$" + e.Text;
 }

{% endhighlight %}

{% endtabs %}

![Slider custom label](images/labels-and-dividers/custom-label.png)


### Tooltip text format

By default, it is formatted based on the [`SliderTooltip.NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_NumberFormat)  property.

Format or change the whole tooltip label text using the [`TooltipLabelCreated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_TooltipLabelCreated) event. The [`SliderTooltipLabelCreatedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html) contains the following parameters,

* Text – Change the format of the tooltip text using the [`Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html#Syncfusion_Maui_Sliders_SliderTooltipLabelCreatedEventArgs_Text) property.
* Style – Change the appearance of the tooltip text like color, stroke color, and padding using the [`Style`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltipLabelCreatedEventArgs.html) property.

{% tabs %}

{% highlight xaml %}

<slider:SfSlider>
    <slider:SfSlider.Tooltip>
        <slider:SliderTooltip TooltipLabelCreated="OnTooltipLabelCreated" />
    </slider:SfSlider.Tooltip>
</slider:SfSlider>

{% endhighlight %}

{% highlight C# %}

{
    SfSlider slider = new SfSlider()
    {
        Tooltip= new SliderTooltip(),
    };
    slider.TooltipLabelCreated += OnTooltipLabelCreated;
}

private void OnTooltipLabelCreated(object sender, SliderTooltipLabelCreatedEventArgs e)
{
    e.Text = "$" + e.Text;
}

{% endhighlight %}

{% endtabs %}

![Slider custom tooltip](images/tooltip/custom-tooltip.png)

## Commands and their parameter

### Drag started command

The [`DragStartedCommand`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_DragStartedCommand) will be executed when the user starts moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfSlider DragStartedCommand="{Binding DragStartedCommand}" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    DragStartedCommand = viewModel.DragStartedCommand
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

The [`DragStartedCommandParameter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_DragStartedCommandParameter) will be executed when the user starts moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfSlider DragStartedCommand="{Binding DragStartedCommand}"
                      DragStartedCommandParameter="1" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
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

The [`DragCompletedCommand`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_DragCompletedCommand) will be executed when the user completes moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfSlider DragCompletedCommand="{Binding DragCompletedCommand}" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
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

The [`DragCompletedCommandParameter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_DragCompletedCommandParameter) will be executed when the user completes moving the thumb.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
    <local:ViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <sliders:SfSlider DragCompletedCommand="{Binding DragCompletedCommand}"
                      DragCompletedCommandParameter="1" />
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
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
---
layout: post
title: Events in .NET MAUI Time Picker Control | Syncfusion
description: Learn about events in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Events in .NET MAUI Time Picker (SfTimePicker)

## Selection changed event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectionChanged) event is used to notify when the time selection is changed onto the view in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In the SfTimePicker picker, the [TimePickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerSelectionChangedEventArgs.html) is used for this event which holds the data of NewValue and OldValue.

    * [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_TimePickerSelectionChangedEventArgs_NewValue) : Returns the new selected time.
    * [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_TimePickerSelectionChangedEventArgs_OldValue) : Returns the old selected time.


{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     SelectionChanged="OnTimePickerSelectionChanged">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.SelectionChanged += this.OnTimePickerSelectionChanged;

private void OnTimePickerSelectionChanged(object sender, TimePickerSelectionChangedEventArgs e)
{
    var oldTime = e.OldValue;
    var newTime = e.NewValue;
}

{% endhighlight %}

{% endtabs %}

## Events in dialog mode

In `SfTimePicker`, three events are used while the time picker is in Dialog mode.

 * [`Opened`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened)
 * [`Closing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing)
 * [`Closed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed)

### Opened event

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened) event occurs when the picker popup is opened in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In the SfTimePicker picker, `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     Opened="OnTimePickerPopUpOpened">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Opened += this.OnTimePickerPopUpOpened;

private void OnTimePickerPopUpOpened(object sender, EventArgs e)
{
    // If you need to open the picker, set the IsOpen property to true.
    this.Picker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

### Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing) event occurs when the picker popup is closing in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In the SfTimePicker picker, `CancelEventArgs` is used to describe a cancel event which holds the bool value.

    * `Cancel` : Indicating whether you should cancel the operation or not.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     Closing="OnTimePickerPopUpClosing">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Closing += this.OnTimePickerPopUpClosing;

private void OnTimePickerPopUpClosing(object sender, CancelEventArgs e)
{
    //To restrict the time picker get close, set e.Cancel to true.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

### Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed) event occurs when the picker popup is closed in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In the SfTimePicker picker, `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     Closed="OnTimePickerPopUpClosed">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.Closed += this.OnTimePickerPopUpClosed;

private void OnTimePickerPopUpClosed(object sender, EventArgs e)
{
    // If you need to close the picker, set the IsOpen property to false.
    this.Picker.IsOpen = false;
}

{% endhighlight %}

{% endtabs %}

## Events in footer view

In the `SfTimePicker` footer view provides two events. These events are not applicable while the footer view is not visible.

 * [`OkButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked)
 * [`CancelButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked)

### OkButtonClicked event

 The [OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked) event occurs when the ok button is clicked in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html) footer view. This event is not applicable when the footer view is not visible and the ok button is not visible.

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In the SfTimePicker picker, `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     OkButtonClicked="OnTimePickerOkButtonClicked">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.OkButtonClicked += this.OnTimePickerOkButtonClicked;

private void OnTimePickerOkButtonClicked(object sender, EventArgs e)
{
    // This event is used to updates the selected item in the time picker.
}

{% endhighlight %}

{% endtabs %}

### CancelButtonClicked event

 The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) event occurs when the cancel button is clicked in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html) footer view. This event is not applicable when the footer view is not visible.

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: In the SfTimePicker picker, `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     CancelButtonClicked="OnTimePickerCancelButtonClicked">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.Picker.CancelButtonClicked += this.OnTimePickerCancelButtonClicked;

private void OnTimePickerCancelButtonClicked(object sender, EventArgs e)
{
    // This event is used to cancel the selected item in the time picker.
}

{% endhighlight %}

{% endtabs %}

## Commands

### SelectionChangedCommand

The SfTimePicker includes a built-in event called `SelectionChanged` that is triggered whenever the selection index in the time picker changes. This event can be invoked through the [SelectionChangedCommand](), which passes the `TimePickerSelectionChangedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                    SelectionChangedCommand="{Binding SelectionChangedCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,5,7" %}

public class ViewModel
{
    public ICommand SelectionChangedCommand { get; set; }
    public ViewModel()
    {
        SelectionChangedCommand = new Command(SelectionChanged);
    }
    private void SelectionChanged()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### AcceptCommand

The SfTimePicker includes a built-in event called `OkButtonClicked`, which is triggered when the confirm button is tapped on the time picker. This event can be invoked through the [AcceptCommand]().

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                    AcceptCommand="{Binding AcceptCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,5,7" %}

public class ViewModel
{
    public ICommand AcceptCommand { get; set; }
    public ViewModel()
    {
        AcceptCommand = new Command(ActionButtonClicked);
    }
    private void ActionButtonClicked()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}

### DeclineCommand

The SfTimePicker includes a built-in event called `CancelButtonClicked`, which is triggered when the cancel button is tapped on the time picker. This event can be invoked through the [DeclineCommand]().

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                    DeclineCommand="{Binding DeclineCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,5,7" %}

public class ViewModel
{
    public ICommand DeclineCommand { get; set; }
    public ViewModel()
    {
        DeclineCommand = new Command(ActionButtonCanceled);
    }
    private void ActionButtonCanceled()
    {
        // To do your requirement here.
    }
}

{% endhighlight %}
{% endtabs %}
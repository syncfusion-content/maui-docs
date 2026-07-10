---
layout: post
title: Events in .NET MAUI Time Picker Control | Syncfusion®
description: Learn about events in Syncfusion<sup>&reg;</sup> .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Events in .NET MAUI Time Picker (SfTimePicker)

## Selection changed event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectionChanged) event is raised when the time selection changes in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: The [TimePickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerSelectionChangedEventArgs.html) holds the old and new values.

    * [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_TimePickerSelectionChangedEventArgs_NewValue) : Returns the new selected time.
    * [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_TimePickerSelectionChangedEventArgs_OldValue) : Returns the old selected time.


{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                     SelectionChanged="OnTimePickerSelectionChanged">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.SelectionChanged += this.OnTimePickerSelectionChanged;

private void OnTimePickerSelectionChanged(object sender, TimePickerSelectionChangedEventArgs e)
{
    var oldTime = e.OldValue;
    var newTime = e.NewValue;
}

{% endhighlight %}

{% endtabs %}

N>
* In `SfTimePicker`, the [SelectedTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectedTime) is confirmed only when the OK button in the footer view is tapped. This behavior applies when the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) is set to `Dialog` or `RelativeDialog`, the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) of the `PickerFooterView` is greater than zero, and [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) is enabled.
* When [IsSelectionImmediate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate) is set to `true`, the [SelectedTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectedTime) is updated immediately upon selection.
* When [IsSelectionImmediate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate) is set to `false` by `default`, the [SelectedTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectedTime) is confirmed only when the OK button in the footer view is tapped.

## Events in dialog mode

In `SfTimePicker`, three events are used while the time picker is in Dialog mode.

 * [`Opened`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened)
 * [`Closing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing)
 * [`Closed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed)

### Opened event

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened) event occurs when the picker popup is opened in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                     Opened="OnTimePickerPopUpOpened">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Opened += this.OnTimePickerPopUpOpened;

private void OnTimePickerPopUpOpened(object sender, EventArgs e)
{
    // If you need to open the picker, set the IsOpen property to true.
    this.picker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

### Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing) event occurs when the picker popup is closing in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: `CancelEventArgs` is used to describe a cancelable event.

    * `Cancel`: Indicates whether the close operation should be canceled.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                     Closing="OnTimePickerPopUpClosing">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Closing += this.OnTimePickerPopUpClosing;

private void OnTimePickerPopUpClosing(object sender, CancelEventArgs e)
{
    // To prevent the picker from closing, set e.Cancel to true.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

### Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed) event occurs after the picker popup is closed in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                     Closed="OnTimePickerPopUpClosed">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Closed += this.OnTimePickerPopUpClosed;

private void OnTimePickerPopUpClosed(object sender, EventArgs e)
{
    // If you need to close the picker, set the IsOpen property to false.
    this.picker.IsOpen = false;
}

{% endhighlight %}

{% endtabs %}

## Events in footer view

The `SfTimePicker` footer view provides two events. These events are not raised while the footer view is not visible.

 * [`OkButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked)
 * [`CancelButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked)

### OkButtonClicked event

 The [OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked) event occurs when the OK button is clicked in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html) footer view. This event is not raised when the footer view or OK button is not visible.

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                     OkButtonClicked="OnTimePickerOkButtonClicked">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}

this.picker.OkButtonClicked += this.OnTimePickerOkButtonClicked;

private void OnTimePickerOkButtonClicked(object sender, EventArgs e)
{
    // Use this event to update the selected item in the Time Picker.
}

{% endhighlight %}

{% endtabs %}

### CancelButtonClicked event

 The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) event occurs when the cancel button is clicked in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html) footer view. This event is not raised when the footer view is not visible.

* `Sender`: This contains the `SfTimePicker` object.

* `EventArgs`: `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker"
                     CancelButtonClicked="OnTimePickerCancelButtonClicked">
</picker:SfTimePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.CancelButtonClicked += this.OnTimePickerCancelButtonClicked;

private void OnTimePickerCancelButtonClicked(object sender, EventArgs e)
{
    // This event is used to cancel the selected item in the time picker.
}

{% endhighlight %}

{% endtabs %}

## Commands

N> Add `using System.Windows.Input;` to use the `ICommand` type shown in the following examples.

### SelectionChangedCommand

The SfTimePicker includes a built-in event called `SelectionChanged` that is triggered whenever the time selection changes. This event can be invoked through the [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectionChangedCommand). The bound command does not receive any parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>
<picker:SfTimePicker x:Name="picker"
                    SelectionChangedCommand="{Binding SelectionChangedCommand}">
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

The SfTimePicker includes a built-in event called `OkButtonClicked`, which is triggered when the confirm button is tapped. This event can be invoked through the [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>
<picker:SfTimePicker x:Name="picker"
                    AcceptCommand="{Binding AcceptCommand}">
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

The SfTimePicker includes a built-in event called `CancelButtonClicked`, which is triggered when the cancel button is tapped. This event can be invoked through the [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand). The bound command does not receive any parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>
<picker:SfTimePicker x:Name="picker"
                    DeclineCommand="{Binding DeclineCommand}">
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
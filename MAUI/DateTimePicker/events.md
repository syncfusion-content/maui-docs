---
layout: post
title: Events in .NET MAUI Date Time Picker Control | Syncfusion®
description: Learn about events in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Events in .NET MAUI Date Time Picker (SfDateTimePicker)

## Selection changed event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_SelectionChanged) event is used to notify when the date time selection is changed onto the view in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In the SfDateTimePicker picker, the [DateTimePickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionChangedEventArgs.html) is used for this event, which holds the data of NewValue and OldValue.

    * [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_DatePickerSelectionChangedEventArgs_NewValue) : Returns the new selected date and time.
    * [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_DatePickerSelectionChangedEventArgs_OldValue) : Returns the old selected date and time.


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         SelectionChanged="OnDateTimePickerSelectionChanged">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.SelectionChanged += this.OnDateTimePickerSelectionChanged;

private void OnDateTimePickerSelectionChanged(object sender, DateTimePickerSelectionChangedEventArgs e)
        {
            var oldDateTime = e.OldValue;
            var newDateTime = e.NewValue;
        }

{% endhighlight %}  
{% endtabs %}

N> In `SfDateTimePicker`,
* When [IsImmediateSelectionEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsImmediateSelectionEnabled) is set to `true` by `default`, the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate) is updated immediately upon selection.
* When [IsImmediateSelectionEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsImmediateSelectionEnabled) is set to `false`, the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate) is confirmed only when the OK button in the footer view is tapped.

## Events in dialog mode

In `SfDateTimePicker`, three events are used while the date time picker is in Dialog mode.

 * [`Opened`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened)
 * [`Closing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing)
 * [`Closed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed)

### Opened event

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened) event occurs when the picker popup is opened in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         Opened="OnDateTimePickerPopUpOpened">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Opened += this.OnDateTimePickerPopUpOpened;

private void OnDateTimePickerPopUpOpened(object sender, EventArgs e)
        {
            // If you need to open the picker, set IsOpen property to true.
            this.picker.IsOpen = true;
        }

{% endhighlight %}  
{% endtabs %}

### Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing) event occurs when the picker popup is closing in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `CancelEventArgs` is used to describe the cancel event which holds the bool value.

    * `Cancel` : Indicating whether we should cancel the operation or not.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         Closing="OnDateTimePickerPopUpClosing">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Closing += this.OnDateTimePickerPopUpClosing;

private void OnDateTimePickerPopUpClosing(object sender, CancelEventArgs e)
        {
            //To restrict the date time picker get close, set e.Cancel to true.
            e.Cancel = true;
        }

{% endhighlight %}  
{% endtabs %}

### Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed) event occurs when the picker popup is closed in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         Closed="OnDateTimePickerPopUpClosed">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Closed += this.OnDateTimePickerPopUpClosed;

private void OnDateTimePickerPopUpClosed(object sender, EventArgs e)
        {
            // If you need to close the picker, set IsOpen property to false.
            this.picker.IsOpen = false;
        }

{% endhighlight %}  
{% endtabs %}

## Events in footer view

The `SfDateTimePicker` footer view provides two events. These events are not applicable while the footer view is not visible.

 * [`OkButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked)
 * [`CancelButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked)

### OkButtonClicked event

 The [OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked) event occurs when the ok button is clicked in the Date Time Picker footer view. This event is not applicable when the footer view is not visible and the ok button is not visible.

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         OkButtonClicked="OnDateTimePickerOkButtonClicked">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.OkButtonClicked += this.OnDateTimePickerOkButtonClicked;

private void OnDateTimePickerOkButtonClicked(object sender, EventArgs e)
        {
            // This event is used to update the selected item in the Date time picker.
        }

{% endhighlight %}  
{% endtabs %}

### CancelButtonClicked event

 The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) event occurs when the cancel button is clicked in the  Date Time Picker footer view. This event is not applicable when the footer view is not visible.

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         CancelButtonClicked="OnDateTimePickerCancelButtonClicked">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.CancelButtonClicked += this.OnDateTimePickerCancelButtonClicked;

private void OnDateTimePickerCancelButtonClicked(object sender, EventArgs e)
        {
            // This event is used to cancel the selected item in the Date time picker.
        }

{% endhighlight %}  
{% endtabs %}

## Commands

### SelectionChangedCommand

The SfDateTimePicker includes a built-in event called `SelectionChanged` that is triggered whenever the selection index in the picker changes. This event can be invoked through the [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectionChangedCommand), which passes the `DateTimePickerSelectionChangedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                    SelectionChangedCommand="{Binding SelectionChangedCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

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

The SfDateTimePicker includes a built-in event called `OkButtonClicked`, which is triggered when the confirm button is tapped on the date time picker. This event can be invoked through the [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                    AcceptCommand="{Binding AcceptCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDateTimePicker>

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

The SfDateTimePicker includes a built-in event called `CancelButtonClicked`, which is triggered when the cancel button is tapped on the date time picker. This event can be invoked through the [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                    DeclineCommand="{Binding DeclineCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDateTimePicker>

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
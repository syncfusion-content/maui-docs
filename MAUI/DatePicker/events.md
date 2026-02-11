---
layout: post
title: Date Picker Events in .NET MAUI Date Picker Control | Syncfusion®
description: Learn about date picker events in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Events in .NET MAUI Date Picker (SfDatePicker)

## SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChanged) event is used to notify when the date selection is changed onto the view in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In the SfDatePicker picker, the [DatePickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html) is used for this event, which holds the data of NewValue and OldValue.

    * [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_DatePickerSelectionChangedEventArgs_NewValue) : Returns the new selected date.
    * [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_DatePickerSelectionChangedEventArgs_OldValue) : Returns the old selected date.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                     SelectionChanged="OnDatePickerSelectionChanged">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.SelectionChanged += this.OnDatePickerSelectionChanged;

private void OnDatePickerSelectionChanged(object sender, DatePickerSelectionChangedEventArgs e)
{
    var oldDate = e.OldValue;
    var newDate = e.NewValue;
}

{% endhighlight %}

{% endtabs %}

N> In `SfDatePicker`,
* When [IsImmediateSelectionEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsImmediateSelectionEnabled) is set to `true` by `default`, the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate) is updated immediately upon selection.
* When [IsImmediateSelectionEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsImmediateSelectionEnabled) is set to `false`, the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate) is confirmed only when the OK button in the footer view is tapped.
* This explicit confirmation behavior applies only when the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) is set to `Dialog` or `RelativeDialog`, the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) of the PickerFooterView is greater than zero, and [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) is enabled.

## Events in dialog mode (SfDatePicker)

In `SfDatePicker`, three events are used while the date picker is in Dialog mode.

 * [`Opened`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened)
 * [`Closing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing)
 * [`Closed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed)

### Opened event

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened) event occurs when the picker popup is opened in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In the SfDatePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                     Opened="OnDatePickerPopUpOpened">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Opened += this.OnDatePickerPopUpOpened;

private void OnDatePickerPopUpOpened(object sender, EventArgs e)
{
    // If you need to open the picker, set IsOpen property to true.
    this.picker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

### Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing) event occurs when the picker popup is closing in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In the SfDatePicker picker, `CancelEventArgs` is used to describe the cancel event which holds the bool value.

    * `Cancel` : Indicating whether you should cancel the operation or not.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                     Closing="OnDatePickerPopUpClosing">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Closing += this.OnDatePickerPopUpClosing;

private void OnDatePickerPopUpClosing(object sender, CancelEventArgs e)
{
    //To restrict the date picker get close, set e.Cancel to true.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

### Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed) event occurs when the picker popup is closed in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In the SfDatePicker picker, `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                     Closed="OnDatePickerPopUpClosed">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.Closed += this.OnDatePickerPopUpClosed;

private void OnDatePickerPopUpClosed(object sender, EventArgs e)
{
    // If you need to close the picker, set the IsOpen property to false.
    this.picker.IsOpen = false;
}

{% endhighlight %}

{% endtabs %}

## Events in footer view

The `SfDatePicker` footer view provides two events. These events are not applicable while the footer view is not visible.

 * [`OkButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked)
 * [`CancelButtonClicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked)

### OkButtonClicked event

 The [OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked) event occurs when the ok button is clicked in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html) footer view. This event is not applicable when the footer view is not visible and the ok button is not visible.

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In the SfDatePicker picker, `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                     OkButtonClicked="OnDatePickerOkButtonClicked">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.OkButtonClicked += this.OnDatePickerOkButtonClicked;

private void OnDatePickerOkButtonClicked(object sender, EventArgs e)
{
    // This event is used to updates the selected item in the Date picker.
}

{% endhighlight %}

{% endtabs %}

### CancelButtonClicked event

 The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) event occurs when the cancel button is clicked in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html) footer view. This event is not applicable when the footer view is not visible.

* `Sender`: This contains the `SfDatePicker` object.

* `EventArgs`: In the SfDatePicker picker, `EventArgs` is used for this event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                     CancelButtonClicked="OnDatePickerCancelButtonClicked">
</picker:SfDatePicker>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.picker.CancelButtonClicked += this.OnDatePickerCancelButtonClicked;

private void OnDatePickerCancelButtonClicked(object sender, EventArgs e)
{
    // This event cancels the selected item in the Date picker.
}

{% endhighlight %}

{% endtabs %}

## Commands

### SelectionChangedCommand

The SfDatePicker includes a built-in event called `SelectionChanged` that is triggered whenever the selection index in the picker changes. This event can be invoked through the [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChangedCommand), which passes the `DatePickerSelectionChangedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                    SelectionChangedCommand="{Binding SelectionChangedCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDatePicker>

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

The SfDatePicker includes a built-in event called `OkButtonClicked`, which is triggered when the confirm button is tapped on the date picker. This event can be invoked through the [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                    AcceptCommand="{Binding AcceptCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDatePicker>

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

The SfDatePicker includes a built-in event called `CancelButtonClicked`, which is triggered when the cancel button is tapped on the date picker. This event can be invoked through the [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfDatePicker x:Name="picker"
                    DeclineCommand="{Binding DeclineCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfDatePicker>

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

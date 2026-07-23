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

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectionChanged) event is raised when the user changes the selected date or time on the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: The [DateTimePickerSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerSelectionChangedEventArgs.html) provides the new and old values:

    * [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_DatePickerSelectionChangedEventArgs_NewValue) : Returns the new selected date and time.
    * [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html#Syncfusion_Maui_Picker_DatePickerSelectionChangedEventArgs_OldValue) : Returns the old selected date and time.


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             SelectionChanged="OnDateTimePickerSelectionChanged">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.picker.SelectionChanged += this.OnDateTimePickerSelectionChanged;
    }
    private void OnDateTimePickerSelectionChanged(object sender, DateTimePickerSelectionChangedEventArgs e)
    {
        var oldDateTime = e.OldValue;
        var newDateTime = e.NewValue;
    }
}

{% endhighlight %}
{% endtabs %}

N>
* The [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate) value is committed at different points depending on the configuration:
  * When [IsSelectionImmediate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate) is `true` (default), the new value is applied as soon as the user picks it.
  * When `IsSelectionImmediate` is `false`, the value is committed only after the user taps the OK button. This applies when the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) is `Dialog` or `RelativeDialog`, the [PickerFooterView.Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) is greater than zero, and [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) is enabled.

## Events in dialog mode

In `SfDateTimePicker`, three events are used while the date time picker is in Dialog mode.

 * [`Opened`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened)
 * [`Closing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing)
 * [`Closed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed)

### Opened event

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened) event fires after the picker popup has been opened in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             Opened="OnDateTimePickerPopUpOpened">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.picker.Opened += this.OnDateTimePickerPopUpOpened;
    }
    private void OnDateTimePickerPopUpOpened(object sender, EventArgs e)
    {
        // If you need to open the picker, set IsOpen property to true.
        this.picker.IsOpen = true;
    }
}

{% endhighlight %}
{% endtabs %}

### Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing) event occurs when the picker popup is closing in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `CancelEventArgs` is used to describe the cancel event which holds the bool value.

* `Cancel` : Indicating whether we should cancel the operation or not.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             Closing="OnDateTimePickerPopUpClosing">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.picker.Closing += this.OnDateTimePickerPopUpClosing;
    }
    private void OnDateTimePickerPopUpClosing(object sender, CancelEventArgs e)
    {
        //To restrict the date time picker get close, set e.Cancel to true.
        e.Cancel = true;
    }
}

{% endhighlight %}
{% endtabs %}

### Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed) event occurs when the picker popup is closed in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             Closed="OnDateTimePickerPopUpClosed">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.picker.Closed += this.OnDateTimePickerPopUpClosed;
    }
    private void OnDateTimePickerPopUpClosed(object sender, EventArgs e)
    {
        // If you need to close the picker, set IsOpen property to false.
        this.picker.IsOpen = false;
    }
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
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             OkButtonClicked="OnDateTimePickerOkButtonClicked">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.picker.OkButtonClicked += this.OnDateTimePickerOkButtonClicked;
    }
    private void OnDateTimePickerOkButtonClicked(object sender, EventArgs e)
    {
        // This event is used to update the selected item in the Date time picker.
    }
}

{% endhighlight %}
{% endtabs %}

### CancelButtonClicked event

 The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) event occurs when the cancel button is clicked in the  Date Time Picker footer view. This event is not applicable when the footer view is not visible.

* `Sender`: This contains the `SfDateTimePicker` object.

* `EventArgs`: In SfDateTimePicker picker, `EventArgs` is used for this event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             CancelButtonClicked="OnDateTimePickerCancelButtonClicked">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.picker.CancelButtonClicked += this.OnDateTimePickerCancelButtonClicked;
    }
    private void OnDateTimePickerCancelButtonClicked(object sender, EventArgs e)
    {
        // This event is used to cancel the selected item in the Date time picker.
    }
}

{% endhighlight %}
{% endtabs %}

## Commands

The events documented above can also be invoked through bindable commands for use in MVVM scenarios.

### SelectionChangedCommand

The SfDateTimePicker includes a built-in `SelectionChanged` event that is raised whenever the selected date or time changes. The event can also be handled through the [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectionChangedCommand), which passes a `DateTimePickerSelectionChangedEventArgs` instance as the command parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="8" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <picker:SfDateTimePicker x:Name="picker"
                             SelectionChangedCommand="{Binding SelectionChangedCommand}">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="5 8" %}

using Syncfusion.Maui.Picker;
. . .
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

The SfDateTimePicker includes a built-in `OkButtonClicked` event that is raised when the user taps the confirmation button in the date-time picker. This action can also be handled using the [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand), which is invoked when the confirmation button is clicked.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="8" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <picker:SfDateTimePicker x:Name="picker"
                             AcceptCommand="{Binding AcceptCommand}">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="5 8" %}

using Syncfusion.Maui.Picker;
. . .
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

The SfDateTimePicker includes a built-in `CancelButtonClicked` event that is raised when the user taps the Cancel button in the date-time picker. This action can also be handled using the [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand), which is invoked when the Cancel button is clicked.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="8" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <picker:SfDateTimePicker x:Name="picker"
                             DeclineCommand="{Binding DeclineCommand}">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="5 8" %}

using Syncfusion.Maui.Picker;
. . .
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
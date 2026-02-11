---
layout: post
title: Events with .NET MAUI Picker Control | Syncfusion
description: Learn here all about events with Syncfusion Essential .NET MAUI Picker (SfPicker) control, it's elements and more details.
platform: maui
control: SfPicker
documentation: ug
---

# Events in .NET MAUI Picker (SfPicker)

Three events have been used for a [.NET MAUI Picker](https://www.syncfusion.com/maui-controls/maui-picker) when it is in the Dialog mode. They are, 

 * Opened 
 * Closing 
 * Closed
 * SelectionChanged
 * OkButtonClicked
 * CancelButtonClicked

## Opened

The [Opened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened) event occurs when the picker pop-up is opened.

## Closing event

The [Closing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing) event is raised when the picker pop-up is closing. Prevent the picker pop-up from closing by setting "e.cancel" to true.

## Closed event

The [Closed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed) event is raised after the picker pop-up is closed.

## SelectionChanged Event
The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_SelectionChanged) is raised after the selected index changed on the `SfPicker`.

N> In `SfPicker`,
* When [IsImmediateSelectionEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsImmediateSelectionEnabled) is set to `true` by `default`, the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedIndex) and [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerColumn.html#Syncfusion_Maui_Picker_PickerColumn_SelectedItem) are updated immediately upon selection.
* When [IsImmediateSelectionEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsImmediateSelectionEnabled) is set to `false`, the selection is confirmed only when the OK button in the footer view is tapped.
* This explicit confirmation behavior applies only when the [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode) is set to `Dialog` or `RelativeDialog`, the [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_Height) of the PickerFooterView is greater than zero, [ShowOkButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_ShowOkButton) is enabled, and there is a single picker column.

## OkButtonClicked Event

The [OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked) event is raised after the `ok` button clicked on the `SfPicker`. This event is not applicable while the footer view and `ok` button are not visible.

## CancelButtonClicked Event

The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) is raised after the `Cancel` button clicked on the `SfPicker`. This event is not applicable while the footer view is not visible.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="picker" 
                            Opened="picker_Opened" 
                            Closed="picker_Closed"
                            Closing="picker_Closing"
                            SelectionChanged="picker_SelectionChanged"
                            OkButtonClicked="picker_OkButtonClicked"
                            CancelButtonClicked="picker_CancelButtonClicked">
    </sfPicker:SfPicker>
    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.picker.Opened += Picker_Opened;
    this.picker.Closing += Picker_Closing;
    this.picker.Closed += Picker_Closed;
    this.picker.SelectionChanged += Picker_SelectionChanged;
    this.picker.OkButtonClicked += Picker_OkButtonClicked;
    this.picker.CancelButtonClicked += Picker_CancelButtonClicked;

    private void Picker_Opened(object sender, EventArgs e)
    {
        // Handle the open action.
    }

    private void Picker_Closing(object sender, Syncfusion.XForms.Core.CancelEventArgs e)
    {
        // Stop the close action by setting the `e.cancel` to true.
    }

    private void Picker_Closed(object sender, EventArgs e)
    {
        // Hit after the picker is closed.
    }

    private void Picker_SelectionChanged(object sender, PickerSelectionChangedEventArgs e)
    {
        // Hit after the picker selected index is changed.
    }

    private void Picker_OkButtonClicked(object sender, EventArgs e)
    {
        // Hit after the OK button is clicked.
    }

    private void Picker_CancelButtonClicked(object sender, EventArgs e)
    {
        // Hit after the Cancel button is clicked.
    }
    
{% endhighlight %}
{% endtabs %}

## Commands

### SelectionChangedCommand

The SfPicker includes a built-in event called `SelectionChanged` that is triggered whenever the selection index in the picker changes. This event can be invoked through the [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html#Syncfusion_Maui_Picker_SfPicker_SelectionChangedCommand), which passes the `PickerSelectionChangedEventArgs` as a parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfPicker x:Name="picker"
                    SelectionChangedCommand="{Binding SelectionChangedCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

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

The SfPicker includes a built-in event called `OkButtonClicked`, which is triggered when the confirm button is tapped on the picker. This event can be invoked through the [AcceptCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfPicker x:Name="picker"
                    AcceptCommand="{Binding AcceptCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

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

The SfPicker includes a built-in event called `CancelButtonClicked`, which is triggered when the cancel button is tapped on the picker. This event can be invoked through the [DeclineCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<picker:SfPicker x:Name="picker"
                    DeclineCommand="{Binding DeclineCommand}">
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>					  
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3,6,8" %}

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
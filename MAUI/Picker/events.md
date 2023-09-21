---
layout: post
title: Events with .NET MAUI Picker Control | Syncfusion
description: Learn here all about events with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Events in .NET MAUI Picker (SfPicker)

Three events have been used for a picker when it is in the Dialog mode. They are, 

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

## OkButtonClicked Event

The [OkButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked) event is raised after the `ok` button clicked on the `SfPicker`. This event is not applicable while the footer view and `ok` button are not visible.

## CancelButtonClicked Event

The [CancelButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked) is raised after the `Cancel` button clicked on the `SfPicker`. This event is not applicable while the footer view is not visible.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker" 
                            Opened="picker_Opened" 
                            Closed="picker_Closed"
                            Closing="picker_Closing"
                            SelectionChanged="picker_SelectionChanged"
                            OkButtonClicked="picker_OkButtonClicked"
                            CancelButtonClicked="picker_CancelButtonClicked">
    </sfPicker:SfPicker>
    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Opened += Picker_Opened;
    this.Picker.Closing += Picker_Closing;
    this.Picker.Closed += Picker_Closed;
    this.Picker.SelectionChanged += Picker_SelectionChanged;
    this.picker.OkButtonClicked += Picker_OkButtonClicked;
    this.Picker.CancelButtonClicked += Picker_CancelButtonClicked;

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

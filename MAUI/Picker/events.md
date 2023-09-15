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

## Opened

The `Opened` event occurs when the picker pop-up is opened.

## Closing event

The "Closing" event is raised when the picker pop-up is closing. You can prevent the picker pop-up from closing by setting "e.cancel" to true.

## Closed event

The `Closed` event was raised after the picker pop-up is closed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    <sfPicker:SfPicker x:Name="Picker" 
                            Opened="picker_Opened" 
                            Closed="picker_Closed"
                            Closing="picker_Closing">
    </sfPicker:SfPicker>
    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.Opened += picker_Opened;
    this.Picker.Closing += picker_Closing;
    this.Picker.Closed += picker_Closed;

    private void picker_Opened(object sender, EventArgs e)
    {
        // handle the open action
    }

    private void Picker_Closing(object sender, Syncfusion.XForms.Core.CancelEventArgs e)
    {
        // stop the close action by setting the `e.cancel` to true.
    }

    private void picker_Closed(object sender, EventArgs e)
    {
        // hit after the picker is closed.
    }

{% endhighlight %}
{% endtabs %}

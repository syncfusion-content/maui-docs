---
layout: post
title: Events in .NET MAUI MaskedEntry control | Syncfusion®
description: Explore all about SfMaskedEntry (MaskedEntry) occurrences, uncovering its functionalities and applications for comprehensive understanding.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Events in .NET MAUI MaskedEntry

This section provides information about the events available in the .NET MAUI MaskedEntry control.

## ValueChanging Event

The [ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueChanging) event occurs when the `Value` property is about to change in the MaskedEntry control. The `MaskedEntryValueChangingEventArgs` provides the following properties:

* `NewValue`: Gets the current value of the MaskedEntry control.
* `OldValue`: Gets the previous value of the MaskedEntry control.
* `IsValid`: Gets or sets a boolean value indicating whether the input is considered valid based on the mask completion.
* `Cancel`: Gets or sets a value indicating whether the event should be canceled.

{% tabs %}

{% highlight C# %}

private void MaskedEntry_ValueChanging(object sender, MaskedEntryValueChangingEventArgs e)
{
    // Access the new and old values
    string newValue = e.NewValue?.ToString();
    string oldValue = e.OldValue?.ToString();

    // Check the validity of the input
    bool isValid = e.IsValid;

    // Cancel the event if needed
    if (newValue == "1234")
    {
        e.Cancel = true;
    }
}

{% endhighlight %}

{% endtabs %}

## ValueChanged Event

The [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueChanged) event occurs when the `Value` property is changed in the MaskedEntry control. The `MaskedEntryValueChangedEventArgs`provides the following properties:

* `IsMaskCompleted`: Gets a boolean value indicating whether all the required inputs for the mask are completed.
* `NewValue`: Gets the current value of the MaskedEntry control.
* `OldValue`: Gets the previous value of the MaskedEntry control.

{% tabs %}
{% highlight C# %}

private async void MaskedEntry_ValueChanged(object sender, MaskedEntryValueChangedEventArgs e)
{
    // Access the new and old values
    string maskNewValue = e.NewValue?.ToString();
    string maskOldValue = e.OldValue?.ToString();
    if (e.IsMaskCompleted)
    {
        await DisplayAlert("Message", "Mask Completed", "close");
    }
}

{% endhighlight %}
{% endtabs %}

## Completed Event

The [Completed]() event is raised when the user finalizes the text in the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) editable mode by pressing return key on the keyboard. The handler for the event is a generic event handler, taking the `sender` and `EventArgs`(the `EventArgs` value is `string.Empty`):

{% tabs %}
{% highlight xaml %}

    <editors:SfMaskedEntry x:Name="maskedEntry"
                        WidthRequest="200"
                        MaskType="Simple"
                        Mask="(000) 000-0000" 
                        Completed="maskedEntry_Completed"/>

{% endhighlight %}
{% highlight C# %}

    SfMaskedEntry maskedEntry = new SfMaskedEntry()
    {
        WidthRequest = 200;
        MaskType = MaskedEntryMaskType.Simple;
        Mask = "(000) 000-0000";,
    };
maskedEntry.Completed += maskedEntry_Completed;

{% endhighlight %}
{% endtabs %}

`Completed` event can be handled in C# as follows:

{% tabs %}
{% highlight C# %}
    
    private async void maskedEntry_Completed(object sender, EventArgs e)
    {
        await DisplayAlert("Message", "Text entering Completed", "ok");
    }


{% endhighlight %}
{% endtabs %}


## ClearButtonClicked Event

The [ClearButtonClicked]() event is raised when the user activates the clear button in the `SfMaskedEntry` editable mode by tapping or pressing the clear button on the keyboard. The handler for the event is a generic event handler, taking the `sender` and `EventArgs`.

{% tabs %}
{% highlight xaml %}

    <editors:SfMaskedEntry x:Name="maskedEntry"
                        WidthRequest="200"
                        MaskType="Simple"
                        Mask="(000) 000-0000" 
                        ClearButtonClicked="maskedEntry_Completed"/>

{% endhighlight %}
{% highlight C# %}

    SfMaskedEntry maskedEntry = new SfMaskedEntry()
    {
        WidthRequest = 200;
        MaskType = MaskedEntryMaskType.Simple;
        Mask = "(000) 000-0000";,
    };
    maskedEntry.ClearButtonClicked += maskedEntry_ClearButtonClicked;

{% endhighlight %}
{% endtabs %}

`ClearButtonClicked` event can be Handled in C# as follows:

{% tabs %}
{% highlight C# %}
    
    private async void maskedEntry_ClearButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Message", "Clear Button Clicked", "ok");
    }

{% endhighlight %}
{% endtabs %}



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

The [Completed]() event is raised when the user finalizes input via the platform Return/Done action on a `MaskedEntry`. Use this event to perform final validation, formatting, or navigation. The handler receives standard EventArgs from the sender.

{% tabs %}
{% highlight C# %}

    SfMaskedEntry maskedEntry = new SfMaskedEntry();
    maskedEntry.Completed += OnMaskedEntryCompleted;

    async void OnMaskedEntryCompleted(object sender, EventArgs e)
    {
        // Finalize input (validate, format, navigate, etc.)
    }

{% endhighlight %}
{% endtabs %}

## ClearButtonClicked Event

The [ClearButtonClicked]() event is raised when the user taps the clear button on an `SfMaskedEntry`. Use this event to handle cleanup, clear model state, close the dropdown, or perform navigation. The handler receives standard EventArgs and can access the sender (the `SfMaskedEntry`) to read or modify its state.

{% tabs %}
{% highlight C# %}

    SfMaskedEntry maskedEntry = new SfMaskedEntry();
    maskedEntry.ClearButtonClicked += OnMaskedEntryClearButtonClicked;

    async void OnMaskedEntryClearButtonClicked(object sender, EventArgs e)
    {
        // Function used to handle cleanup,
        // clear model state, close the dropdown, or perform navigation
    }

{% endhighlight %}
{% endtabs %}


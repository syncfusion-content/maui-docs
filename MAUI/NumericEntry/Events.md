---
layout: post
title: Events in .NET MAUI Numeric Entry | Syncfusion®
description: Learn the events available in Syncfusion® .NET MAUI Numeric Entry including ValueChanged, Completed, and ClearButtonClicked.
platform: maui
control: SfNumericEntry
documentation: ug
---

# Events in .NET MAUI Numeric Entry

This section provides information about the events available in the .NET MAUI [Numeric Entry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control. Events are typically subscribed in the page constructor or in code-behind, and are raised on the UI thread.

The following events are available in the Numeric Entry control:

1. `ValueChanged` - raised after the value is committed.
2. `Completed` - raised when the user finalizes text by pressing the return key.
3. `ClearButtonClicked` - raised when the user taps the clear button.

## Prerequisites

Before using the [SfNumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/numericentry/getting-started) documentation.

## Value changed Event

The [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ValueChanged) event is raised when the [Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Value) property of the `Numeric Entry` control changes. The value is not updated while the user is typing. The value is updated after validation is performed on the Enter keypress or when the control loses focus. The `NumericEntryValueChangedEventArgs` passed to the handler exposes the following members:

| Member | Type | Description |
| --- | --- | --- |
| `NewValue` | `double?` | The new value of the control. |
| `OldValue` | `double?` | The previous value of the control. |

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry WidthRequest="200"
                        HorizontalOptions="Center"
                        VerticalOptions="Center"
                        ValueChanged="sfNumericEntry_ValueChanged" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.WidthRequest = 200;
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.ValueChanged += sfNumericEntry_ValueChanged;

{% endhighlight %}
{% endtabs %}

You can handle the event as follows.

{% tabs %}
{% highlight C# %}

private void sfNumericEntry_ValueChanged(object sender, NumericEntryValueChangedEventArgs e)
{
    var oldValue = e.OldValue;
    var newValue = e.NewValue;
}

{% endhighlight %}
{% endtabs %}


## Completed Event

The [Completed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Completed) event is raised when the user finalizes the text in the [Numeric Entry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) in editable mode by pressing the Return key on the keyboard. The handler is a generic event handler that takes the `sender` and `EventArgs`.

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry x:Name="numericEntry"
                        WidthRequest="200"
                        Value="153"
                        Completed="numericEntry_Completed" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry numericEntry = new SfNumericEntry()
{
    WidthRequest = 200,
    Value = 153,
};
numericEntry.Completed += numericEntry_Completed;
this.Content = numericEntry;

{% endhighlight %}
{% endtabs %}

The `Completed` event can be handled in C# as follows:

{% tabs %}
{% highlight C# %}

private async void numericEntry_Completed(object sender, EventArgs e)
{
    await DisplayAlertAsync("Message", "Text entering Completed", "OK");
}

{% endhighlight %}
{% endtabs %}


## ClearButtonClicked Event

The [ClearButtonClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ClearButtonClicked) event is raised when the user activates the clear button in the `Numeric Entry` by tapping it. The handler is a generic event handler that takes the `sender` and `EventArgs`.

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry x:Name="numericEntry"
                        WidthRequest="200"
                        Value="153"
                        ClearButtonClicked="numericEntry_ClearButtonClicked" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry numericEntry = new SfNumericEntry()
{
    WidthRequest = 200,
    Value = 153,
};
numericEntry.ClearButtonClicked += numericEntry_ClearButtonClicked;
this.Content = numericEntry;

{% endhighlight %}
{% endtabs %}

The `ClearButtonClicked` event can be handled in C# as follows:

{% tabs %}
{% highlight C# %}

private async void numericEntry_ClearButtonClicked(object sender, EventArgs e)
{
    await DisplayAlertAsync("Message", "Clear Button Clicked", "OK");
}

{% endhighlight %}
{% endtabs %}


## See Also

* [Basic Features](https://help.syncfusion.com/maui/numericentry/basic-features)
* [Restriction](https://help.syncfusion.com/maui/numericentry/restriction)
* [UpDown-Button](https://help.syncfusion.com/maui/numericentry/updown-button)

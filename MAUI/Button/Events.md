---
layout: post
title: Events in .NET MAUI Button Control | Syncfusion®
description: Learn about the Clicked event in the Syncfusion® .NET MAUI Button (SfButton) control and how to handle it.
platform: maui
control: SfButton
documentation: ug
---

# Events in .NET MAUI Button (SfButton)

You can handle user interactions with [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) using code-behind event handlers or, in MVVM scenarios, by binding the [`Command`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Command) property. This page documents the code-behind event; see [Customization > Command](https://help.syncfusion.com/maui/button/customization#command) for the MVVM pattern.

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

## Clicked Event

The [`Clicked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Clicked) event is raised when the user taps or clicks the `SfButton`. The event handler receives an `EventArgs` argument and is invoked once per tap; it is not cancelable and runs synchronously on the UI thread.

The following code samples subscribe to the `Clicked` event and change the text color when the button is tapped.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                Text="Button"
                Clicked="OnButtonClicked" />

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.Clicked += OnButtonClicked;

{% endhighlight %}
{% endtabs %}

### Event handler

The handler is defined in the page's code-behind file. The following C# sample requires the `using System;` directive.

{% tabs %}
{% highlight c# %}

private void OnButtonClicked(object sender, EventArgs e)
{
    // Retrieve the button instance from the sender parameter.
    if (sender is SfButton clickedButton)
    {
        clickedButton.TextColor = Colors.Blue;
    }
}

{% endhighlight %}
{% endtabs %}

N> In the XAML example above, the `button` instance is declared with `x:Name` so it is generated as a field on the page's partial class and is directly accessible from the code-behind.

## Troubleshooting

| Issue | Possible cause | Fix |
|------|---------------|-----|
| Handler is not invoked when the button is tapped. | The `Clicked` attribute value does not match the method name, or the method has the wrong signature. | Ensure the method is `private void`, takes `(object sender, EventArgs e)`, and the name matches exactly. |
| Build error: `Clicked` does not exist. | The `Syncfusion.Maui.Buttons` handler is not registered in `MauiProgram.cs`. | Add `.ConfigureSyncfusionButton()` (or call `.UseSfButton()` depending on your version) in `MauiProgram.CreateMauiApp()`. |
| Handler runs but UI does not update. | The `TextColor` change is applied from a non-UI thread. | Ensure the handler is invoked on the UI thread; the `Clicked` event already runs on the UI thread, so this is usually a symptom of a different threading issue. |

## See Also

- [Customization](https://help.syncfusion.com/maui/button/customization)
- [Visual States](https://help.syncfusion.com/maui/button/visual-states)


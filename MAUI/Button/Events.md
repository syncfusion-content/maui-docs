---
layout: post
title: Events in .NET MAUI Button Control | Syncfusion®
description: Learn about the Clicked event in the Syncfusion® .NET MAUI Button (SfButton) control and how to handle it.
platform: maui
control: SfButton
documentation: ug
---

# Events in .NET MAUI Button (SfButton)

The [.NET MAUI Button](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) raises event when the user taps or clicks.

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

## Clicked Event

The [Clicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Clicked) event is raised when the user taps or clicks the `Button`. The event handler receives an `EventArgs` argument and is invoked once per tap.

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

The `Clicked` event can be handled in C# as follows:

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

## See Also

- [Customization](https://help.syncfusion.com/maui/button/customization)
- [Visual States](https://help.syncfusion.com/maui/button/visual-states)
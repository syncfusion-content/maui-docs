---
layout: post
title: Right-to-Left in .NET MAUI Button Control | Syncfusion®
description: Learn about right-to-left (RTL) directionality support in the Syncfusion® .NET MAUI Button (SfButton) control.
platform: maui
control: SfButton
documentation: ug
---

# Right-to-Left in .NET MAUI Button (SfButton)

The [.NET MAUI Button`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) supports right-to-left (RTL) layout by setting [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.flowdirection?view=net-maui-11.0) to `RightToLeft`, or by changing the device language to an RTL language such as Arabic or Hebrew.

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

## Enabling RTL on the Button

You can set `FlowDirection` directly on the `Button` to enable RTL for that control. The Button renders its content (text and image) in the right-to-left direction.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  FlowDirection="RightToLeft"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  HeightRequest = "50"
                  Text="Add to cart" />

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton()
{
    FlowDirection = FlowDirection.RightToLeft,
    Text = "Add to cart",
    HeightRequest = 50,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
};
this.Content = button;

{% endhighlight %}
{% endtabs %}

The following image shows the result of the code above:

![.NET MAUI Button with right-to-left layout](images/right-to-left/RTL.png)

## See Also

- [Customization](https://help.syncfusion.com/maui/button/customization)
- [Right-to-Left](https://help.syncfusion.com/maui/button/right-to-left)
- [Visual States](https://help.syncfusion.com/maui/button/visual-states)
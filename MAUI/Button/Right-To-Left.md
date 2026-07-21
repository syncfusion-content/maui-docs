---
layout: post
title: Right-to-Left in .NET MAUI Button Control | Syncfusion®
description: Learn about right-to-left (RTL) directionality support in the Syncfusion® .NET MAUI Button (SfButton) control.
platform: maui
control: SfButton
documentation: ug
---

# Right-to-Left in .NET MAUI Button (SfButton)

[`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) supports right-to-left (RTL) layout by setting [`FlowDirection`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.flowdirection?view=net-maui-11.0) to `RightToLeft`, or by changing the device language to an RTL language such as Arabic or Hebrew.

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

## Enabling RTL on the Button

You can set `FlowDirection` directly on the `SfButton` to enable RTL for that control. The button renders its content (text and image) in the right-to-left direction.

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
    ImageSource = ImageSource.FromFile("dotnet_bot.png"),
    ShowIcon = true,
};
this.Content = button;

{% endhighlight %}
{% endtabs %}

The following image shows the result of the code above:

![.NET MAUI Button with right-to-left layout](images/right-to-left/RTL.png)

N> Platform behavior may differ: iOS and macOS fully honor `FlowDirection` at the page and control levels, while Android applies the device locale in some cases. Always verify the layout on each target platform.

## Interaction with ImageAlignment

When `FlowDirection` is set to `RightToLeft`, the `ImageAlignment` values `Start` and `End` are mirrored automatically. To keep the image in the same physical position regardless of the flow direction, use the `Left` or `Right` alignment values. For more information, see [Customization > ImageAlignment](https://help.syncfusion.com/maui/button/customization#imagealignment).

## Changing the Device Language

Alternatively, you can let the system apply RTL automatically by setting the device language to an RTL language such as Arabic, Hebrew, Persian, or Urdu. No code change is required in your app, but the `SfButton` must have `FlowDirection` left at its default value of `MatchParent` (or `Device Settings` on platforms that support it) to inherit the system direction.

## Troubleshooting

| Issue | Possible cause | Fix |
|------|---------------|-----|
| The button still renders left-to-right after setting `FlowDirection="RightToLeft"`. | The parent layout has `FlowDirection="LeftToRight"` and overrides the child. | Set `FlowDirection` on the root `ContentPage` or `Application` instead of the child button. |
| The icon is on the wrong side in RTL. | The icon uses `Start`/`End` alignment, which mirrors with the flow direction. | Change the `ImageAlignment` to `Left` or `Right` to keep the icon in a fixed position. |
| RTL works on Android but not on iOS (or vice versa). | Platform-specific layout handling for RTL differs. | Verify the layout on each platform and consider setting `FlowDirection` on the page root to apply it consistently. |
| `FlowDirection` is not recognized in XAML. | The property is set on a namespace element other than `http://schemas.microsoft.com/dotnet/2021/maui`. | Use the .NET MAUI default `xmlns` and the `FlowDirection` attribute on a MAUI element. |

## See Also

- [Customization](https://help.syncfusion.com/maui/button/customization)
- [Microsoft.Maui.Controls FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.flowdirection?view=net-maui-11.0)
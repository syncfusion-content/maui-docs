---
layout: post
title: Customization with .NET MAUI SignaturePad control | Syncfusion®
description: Learn here about customization with .NET MAUI SignaturePad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Customization of SignaturePad

This section explains how to customize the appearance of the .NET MAUI SignaturePad (SfSignaturePad) control. The following aspects of the SignaturePad can be customized:

* Stroke color
* Stroke thickness

## Prerequisites

Before using the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.SignaturePad`

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## Stroke Color

Customize the stroke color of the SignaturePad control by setting the [StrokeColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor) property. The default stroke color is **Colors.Black**.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad StrokeColor="Red" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad()
{
    StrokeColor = Colors.Red,
};
this.Content = signaturePad;

{% endhighlight %}

{% endtabs %}

![SignaturePad stroke color](images/getting-started/stroke-color.png)

## Stroke Thickness

The thickness of the stroke can be customized by setting the [MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness) and [MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness) properties. Both properties accept `double` values that represent the stroke thickness in device-independent units (DIPs). The valid range is `0` to `10`; the default value of each property is `1`.

N> Ensure that the value of `MaximumStrokeThickness` is greater than or equal to `MinimumStrokeThickness`; otherwise, the rendered stroke thickness is undefined.

The [MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness) defines the minimum thickness of the stroke, while the [MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness) defines the maximum thickness of the stroke.

The actual stroke thickness is dynamically computed based on the speed and pressure of the user's gesture. Faster gestures render closer to `MinimumStrokeThickness`, and slower gestures render closer to `MaximumStrokeThickness`. This produces a more realistic signature.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad MinimumStrokeThickness="1"
                             MaximumStrokeThickness="6" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad()
{
    MinimumStrokeThickness = 1,
    MaximumStrokeThickness = 6,
};
this.Content = signaturePad;

{% endhighlight %}

{% endtabs %}

![SignaturePad stroke thickness](images/getting-started/stroke-thickness.png)

## See Also

* [Getting Started with .NET MAUI SignaturePad](getting-started.md)
* [Events in .NET MAUI SignaturePad](events.md)
* [SfSignaturePad API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html)

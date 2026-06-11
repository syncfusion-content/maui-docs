---
layout: post
title: Customization with .NET MAUI SignaturePad control | Syncfusion®
description: Learn here about customization with .NET MAUI SignaturePad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Customization of Signature Pad

## Stroke Color

Customize the stroke color of the SignaturePad control by using the [StrokeColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor) property. The default stroke color is **Colors.Black**.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad StrokeColor="Red" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
signaturePad.StrokeColor = Colors.Red;

{% endhighlight %}

{% endtabs %}

![SignaturePad stroke color](images/getting-started/stroke-color.png)

## Stroke Thickness

The thickness of the stroke drawn can be customized by setting the [MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness) and [MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness) properties. The [MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness) defines the minimum thickness of the stroke and the [MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness) defines the maximum thickness of the stroke that can be drawn based on the speed and impression we provide through gesture within its minimum and maximum stroke thickness ranges. So that the signature will be more realistic.

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

{% endhighlight %}

{% endtabs %}

![SignaturePad stroke thickness](images/getting-started/stroke-thickness.png)

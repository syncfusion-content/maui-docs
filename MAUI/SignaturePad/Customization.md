---
layout: post
title: Customization with .NET MAUI SignaturePad control | Syncfusion®
description: Learn here about customization with .NET MAUI SignaturePad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

## Customize signature stroke color

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

N> You can refer to our [.NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI SignaturePad Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad) that shows you how to render the SignaturePad in .NET MAUI.
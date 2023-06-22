---
layout: post
title: Image Effects in .NET MAUI ImageEditor control | Syncfusion
description: Learn about Image Effect support in Syncfusion .NET MAUI Image Editor (SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Image Effect in .NET MAUI Image Editor (SfImageEditor)

Using the image editor control, apply various effects such as Brightness, Hue, Saturation, Contrast, Blur, Opacity, and Sharpen to your image. These effects can be applied using the toolbar or by utilizing the [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) method. The [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) method consists of two arguments: [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) and `EffectValue`. The [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) is an enumeration that includes the following effects:

* Brightness
* Blur
* Contrast
* Exposure
* Hue
* Saturation
* Sharpen 
* Opacity
* None

The `EffectValue` are the corresponding [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) values, which varies for each effect, and they are explained as follows.

N> The [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) enum also contains [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html#Syncfusion_Maui_ImageEditor_ImageEffect_None) option, which removes all the previously applied effects, which are not saved.
The [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) method only applies the effect to the preview image. If you want to save the applied effect, call the [SaveEdits](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_SaveEdits) method.

## Brightness

Brightness is used to adjust the overall lightness or darkness of the image. The value of the brightness effect ranges from -1 to 1, and the default value is 0.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Brightness, -0.6);
    . . .
}

{% endhighlight %}

## Blur

Blur creates a soft and unfocused appearance by reducing the image's sharpness. The value of the blur effect ranges from 0 to 1, and the default value is 0.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Blur, 0.5);
    . . .
}

{% endhighlight %}


## Contrast

Contrast increases or decreases the difference between light and dark areas, making the image more visually distinct. The value of the contrast effect ranges from -1 to 1, and the default value is 0.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Contrast, -0.8);
    . . .
}

{% endhighlight %}

## Exposure

Exposure is used to alter the overall brightness and darkness levels of the image. The value of the exposure effect ranges from -1 to 1, and the default value is 0.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Exposure, -0.4);
    . . .
}

{% endhighlight %}

## Hue

Hue is used to change the overall color tone of the image by shifting the color spectrum. The value of the hue effect ranges from -1 to 1, and the default value is 0.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Hue, 0.2);
    . . .
}

{% endhighlight %}

## Saturation

Saturation enhances or reduces the intensity and vividness of colors in the image. The value of the saturation effect ranges from -1 to 1, and the default value is 0.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Saturation, -0.8);
    . . .
}

{% endhighlight %}

## Sharpen

Sharpen enhances the clarity and definition of edges and details in the image. The value of the sharpen effect ranges from 0 to 6, and the default value is 0.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Sharpen, 0.5);
    . . .
}

{% endhighlight %}

## Opacity

Opacity is used to control the transparency or visibility of the image. The value of the opacity effect ranges from 0 to 1, and the default value is 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Opacity, 0.5);
    . . .
}

{% endhighlight %}

## Save or Cancel applied effects

Call the [SaveEdits](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_SaveEdits) method to save the applied effects in view; otherwise, the effects will be reset on the next action.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.SaveEdits();
    . . .
}

{% endhighlight %}

The applied effects can be canceled using the [CancelEdits](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_CancelEdits) method or by calling the [ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html) method with [ImageEffect.None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html#Syncfusion_Maui_ImageEditor_ImageEffect_None).

{% tabs %}
{% highlight c# %}

public MainPage()
{               
    . . .
    this.imageEditor.SaveEdits();
    . . .
}

{% endhighlight %}

{% highlight c# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.None, 0);
    . . .
}

{% endhighlight %}
{% endtabs %}
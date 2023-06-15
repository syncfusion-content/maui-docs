---
layout: post
title: Image Effect in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about Image Effect support in Syncfusion .NET MAUI Image Editor (SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Image Effect in .NET MAUI Image Editor (SfImageEditor)

Using the image editor control, you can add effects such as Hue, Saturation, Brightness, Contrast, Blur, and Sharpen to the image. These effects can be applied from toolbar or using the ImageEffect method. The [`ApplyImageEffect`] method contains two arguments: [`ImageEffect`] and [`EffectValue`]. The ImageEffect is an Enum, which contains the following effects:

* Brightness
* Blur
* Contrast
* Exposure
* Hue
* Saturation
* Sharpen 
* Opacity
* None

The EffectValue are the corresponding ImageEffect values, which varies for each effect, and they are explained as follows.

## Brightness

Brightness is used to adjusts the overall lightness or darkness of the image. The value of brightness effect ranges from -1 to 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Brightness, -0.6);
    . . .
}

{% endhighlight %}


## Blur

Blur is used to Creates a soft and unfocused appearance by reducing the image's sharpness. The value of blur effect ranges from 0 to 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Blur, 0.5);
    . . .
}

{% endhighlight %}


## Contrast

Contrast is used to increases or decreases the difference between light and dark areas, making the image more visually distinct. The value of contrast effect ranges from -1 to 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Contrast, -0.8);
    . . .
}

{% endhighlight %}


## Exposure

Exposure is used to alters the overall brightness and darkness levels of the image. The value of the exposure effect ranges from -1 to 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Exposure, -0.4);
    . . .
}

{% endhighlight %}



## Hue

Hue is used to changes the overall color tone of the image by shifting the color spectrum. The value of hue effect ranges from -1 to 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Hue, 0.2);
    . . .
}

{% endhighlight %}


## Saturation

Saturation is used to enhances or reduces the intensity and vividness of colors in the image. The value of the saturation effect ranges from -1 to 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Saturation, -0.8);
    . . .
}

{% endhighlight %}




## Sharpen

Sharpen is used to enhances the clarity and definition of edges and details in the image. The value of sharpen effect ranges from 0 to 6.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect.Sharpen, 0.5);
    . . .
}

{% endhighlight %}

## Opacity

Opacity is used to controls the transparency or visibility of the image. The value of opacity effect ranges from 0 to 1.

{% highlight C# %}

public MainPage()
{               
    . . .
    this.imageEditor.ImageEffect(ImageEffect. Opacity, 0.5);
    . . .
}

{% endhighlight %}

N> The Image Effect enum also contains “None” option, which removes all the previously applied effects, which are not saved displays the original image. When applying effect through the Apply Image effect method, the effects will be saved automatically. But, if you apply effect from toolbar, each effect will be saved only when clicking the OK button, else all the applied effects will not be saved.

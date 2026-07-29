---
layout: post
title: Customization in .NET MAUI Button control | Syncfusion®
description: Learn here all about Customization support in Syncfusion® .NET MAUI Button (SfButton) control and more.
platform: maui
control: SfButton
documentation: ug
---

# Customization in .NET MAUI Button (SfButton)

The [.NET MAUI Button](https://www.syncfusion.com/maui-controls/maui-button) control supports customizing the border color, image size, corner radius, background color, and more.

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

## Text Customization

The text inside the Button can be customized by its text color, font size, font attributes, font family, text alignment, and text transform.

### Text Color

The [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_TextColor) property is used to customize the color of text in [Button](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  HorizontalOptions="Center"
                  VerticalOptions="Center"
                  Text="Button"
                  TextColor="White"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Text = "Button";
button.TextColor = Colors.White;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with text color](images/customization-images/Button_textcolor.png)

### Font Size

The [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontSize) property is used to customize the size of text in `Button`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  HorizontalOptions="Center"
                  VerticalOptions="Center"
                  Text="Button"
                  FontSize="18"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Text = "Button";
button.FontSize = 18;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with font size](images/customization-images/Button_fontsize.png)

### Font Attributes

The [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontAttributes) property is used to customize the font style of text in `Button`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  HorizontalOptions="Center"
                  VerticalOptions="Center"
                  Text="Button"
                  FontAttributes = "Italic"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Text = "Button";
button.FontAttributes = FontAttributes.Italic;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with fontattributes](images/customization-images/Button_fontattributes.png)

### Font Family

The [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontFamily) property is used to customize the font family of text in `Button`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  HorizontalOptions="Center"
                  VerticalOptions="Center"
                  Text="Button"
                  FontFamily="OpenSansRegular"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Text = "Button";
button.FontFamily = "OpenSansRegular";
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with fontfamily](images/customization-images/Button_fontfamily.jpg)

### Text Alignment

The [HorizontalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_HorizontalTextAlignment) and [VerticalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_VerticalTextAlignment) properties are used to customize the alignment of text in `Button`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  HorizontalOptions="Center"
                  VerticalOptions="Center"
                  HorizontalTextAlignment="Center"
                  VerticalTextAlignment="Center"
                  Text="Button"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Text = "Button";
button.HorizontalTextAlignment = TextAlignment.Center;
button.VerticalTextAlignment = TextAlignment.Center;
this.Content = button;

{% endhighlight %}
{% endtabs %}

### Text Transform

You can customize the `Button` text casing using the [TextTransform](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_TextTransform) property to switch between uppercase, lowercase, none, or default casing.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Submit"               
                  TextTransform="Uppercase" 
                  HorizontalTextAlignment="Center" 
                  VerticalTextAlignment="Center"
                  HeightRequest="50"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Submit";
button.TextTransform = TextTransform.Uppercase;
button.HorizontalTextAlignment = TextAlignment.Center;
button.VerticalTextAlignment = TextAlignment.Center;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Button Text Transform](images/customization-images/Button_texttransform.png)

## LineBreakMode
The [LineBreakMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_LineBreakMode) allows you to wrap or truncate the text. The default value of this property is `NoWrap`. The following options are available in `LineBreakMode`:

 * `NoWrap` - Avoids the text wrap.
 * `WordWrap` - Wraps the text by words.
 * `CharacterWrap` - Wraps the text by character.
 * `HeadTruncation` - Truncates the text at the start.
 * `MiddleTruncation` - Truncates the text at the center.
 * `TailTruncation` - Truncates the text at the end.
 * `Default` - Uses the platform default line break behavior.

 {% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Add Items To Cart" 
                  LineBreakMode="MiddleTruncation"
                  HeightRequest="50"
                  WidthRequest="150"
                  ImageSource="Cart.png"
                  ShowIcon="True"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Add Items To Cart";
button.LineBreakMode = LineBreakMode.MiddleTruncation;
button.ImageSource = ImageSource.FromFile("Cart.png");
button.WidthRequest = 150;
button.HeightRequest = 50;
button.ShowIcon = true;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with LineBreakMode](images/customization-images/Button_linebreakmode.png)

## Background Customization

The background of the Button can be customized by its background color, border color, border width and corner radius.

### Background Color

The [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Background) property is used to customize the background color of `Button`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  Text="Button"
                  HeightRequest="50"
                  Background = "DeepSkyBlue"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.HeightRequest = 50;
button.Background = Colors.DeepSkyBlue;
this.Content = button;

{% endhighlight %}
{% endtabs %}

N> When defining the background colors of the SfButton control, always use the `Background` property instead of the `BackgroundColor` property.

![SfButton with background color](images/customization-images/Button_backgroundcolor.png)

### Background Image

The button background image can be set using the [BackgroundImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_BackgroundImageSource) property of `Button`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="SfButton" 
                    Text="Nature"
                    FontAttributes="Bold" 
                    BackgroundImageSource="button_background.png" 
                    CornerRadius="10"
                    HeightRequest="50"
                    WidthRequest="150"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Nature";
button.FontAttributes = FontAttributes.Bold;
button.BackgroundImageSource = ImageSource.FromFile("button_background.png");
button.CornerRadius = 10;
button.WidthRequest = 150;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Button with background image](images/customization-images/Button_backgroundimage.png)

### Stroke

The [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Stroke) property is used to customize the color of border in `Button`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Button"
                  HeightRequest="50"
                  Stroke="Red" 
                  StrokeThickness="2"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.Stroke = Colors.Red;
button.StrokeThickness = 2;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

N> To display the `Stroke` color, you must also define the `StrokeThickness` property (default value is `0`).

![SfButton with stroke](images/customization-images/Button_border.png)

### StrokeThickness

The [StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_StrokeThickness) property is used to customize the thickness of the border in `Button`. The default value is `0` (no border).

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Button"
                  HeightRequest="50"
                  Stroke="Red" 
                  StrokeThickness="6"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.Stroke = Colors.Red;
button.StrokeThickness = 6;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with strokethickness](images/customization-images/Button_borderthickness.png)

### CornerRadius

The [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_CornerRadius) property is used to set the corner radius of `Button`, as demonstrated in the following code sample.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Button"
                  HeightRequest="50"
                  CornerRadius="20"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.CornerRadius = 20;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with cornerradius](images/customization-images/Button_cornerradius.png)

## Image Customization

The Image can be customized by its ShowIcon, ImageSource, ImageSize and ImageAlignment.

### ImageSource

The [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSource) property is used to customize the icon image of `Button` by adding a custom image.

N> Enable the [ShowIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ShowIcon) property to enable the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSource) property. 

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Button"
                  HeightRequest="50"
                  ImageSource="Heart.png"
                  ShowIcon="True"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.ImageSource = ImageSource.FromFile("Heart.png");
button.ShowIcon = true;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with image](images/customization-images/Button_icon.png)

### ShowIcon

Use the [ShowIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ShowIcon) property to specify whether an image is displayed in `Button`. The default value is `false`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Button"
                  HeightRequest="50"
                  ImageSource="Heart.png"
                  ShowIcon="True"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.ImageSource = ImageSource.FromFile("Heart.png");
button.ShowIcon = true;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

### ImageSize

The [ImageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSize) property is used to customize the size of the icon image in `Button`. It sets both the width and height of the image.

N> Enable the `ShowIcon` property to enable the `ImageSize` property.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Button"
                  HeightRequest="50"
                  ImageSource="Heart.png"
                  ShowIcon="True"
                  ImageSize="50"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.ImageSource = ImageSource.FromFile("Heart.png");
button.ShowIcon = true;
button.HeightRequest = 50;
button.ImageSize = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

### ImageAlignment

The [ImageAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageAlignment) property is used to customize the alignment of icon image in `Button`. The following options are available in `ImageAlignment`:

* [`Start`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Start) - Places the image at the left most of `SfButton`.
* [`End`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_End) - Places the image at the right most of`SfButton`.
* [`Top`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Top) - Places the image at the top of the text.
* [`Bottom`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Bottom) - Places the image at the bottom of the text.
* [`Default`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Default) - By default, the image is placed at the center of the text.
* [`Left`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Left) - When a flow direction is applied, the image is always placed in the left part of `Button`. For example, in RTL flow direction, a `Start` alignment is mirrored to the right, but `Left` keeps the image in the same left position.
* [`Right`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Right) - When a flow direction is applied, the image is always placed in the right part of `Button`. For example, in RTL flow direction, an `End` alignment is mirrored to the left, but `Right` keeps the image in the same right position.

N> Enable the `ShowIcon` property to enable the `ImageAlignment` property.

**End image alignment in `Button`**

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Shopping"
                  TextColor="Black"
                  HorizontalOptions="Center"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  ImageSize="25"
                  Stroke="Black"
                  HeightRequest="50"
                  StrokeThickness="4"
                  Background="White"
                  ImageAlignment="End"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    StrokeThickness = 4,
    HeightRequest = 50,
    Background = Colors.White,
    ImageAlignment = Alignment.End
};
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with end alignment](images/customization-images/Button_imagealignment_end.png)

**Start image alignment in `Button`**

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  Text="Shopping"
                  TextColor="Black"
                  HorizontalOptions="Center"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  ImageSize="25"
                  Stroke="Black"
                  HeightRequest="50"
                  StrokeThickness="4"
                  Background="White"
                  ImageAlignment="Start"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    StrokeThickness = 4,
    HeightRequest = 50,
    Background = Colors.White,
    ImageAlignment = Alignment.Start
};
this.Content = button;


{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with start alignment](images/customization-images/Button_imagealignment_start.png)

**Top image alignment in `Button`**

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Shopping"
                  TextColor="Black"
                  HorizontalOptions="Center"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  ImageSize="25"
                  Stroke="Black"
                  HeightRequest="50"
                  StrokeThickness="4"
                  Background="White"
                  ImageAlignment="Top"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    StrokeThickness = 4,
    HeightRequest = 50,
    Background = Colors.White,
    ImageAlignment = Alignment.Top
};
this.Content = button;


{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with top alignment](images/customization-images/Button_imagealignment_top.png)

**Bottom image alignment in `Button`**

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Shopping"
                  TextColor="Black"
                  HorizontalOptions="Center"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  ImageSize="25"
                  Stroke="Black"
                  HeightRequest="50"
                  StrokeThickness="4"
                  Background="White"
                  ImageAlignment="Bottom"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    StrokeThickness = 4,
    HeightRequest = 50,
    Background = Colors.White,
    ImageAlignment = Alignment.Bottom
};
this.Content = button;


{% endhighlight %}
{% endtabs %}

![SfButton with image at the bottom of the text](images/customization-images/Button_imagealignment_bottom.png)

**Default image alignment in `Button`**

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Shopping"
                  TextColor="Black"
                  HorizontalOptions="Center"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  ImageSize="25"
                  Stroke="Black"
                  HeightRequest="50"
                  StrokeThickness="4"
                  Background="White"
                  ImageAlignment="Default"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    StrokeThickness = 4,
    HeightRequest = 50,
    Background = Colors.White,
    ImageAlignment = Alignment.Center
};
this.Content = button;


{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with default alignment](images/customization-images/Button_imagealignment_default.png)

**Left image alignment in `Button`**

In RTL flow direction, image alignment with `Start` will change its direction of placing image to the right. To keep that in same left position, set `Left` alignment as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Shopping"
                  TextColor="Black"
                  HorizontalOptions="Center"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  ImageSize="25"
                  Stroke="Black"
                  HeightRequest="50"
                  StrokeThickness="4"
                  Background="White"
                  ImageAlignment="Left"/>

{% endhighlight %}

{% highlight c# %}

SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    StrokeThickness = 4,
    HeightRequest = 50,
    Background = Colors.White,
    ImageAlignment = Alignment.Left
};
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with left alignment](images/customization-images/Button_imagealignment_left.png)

**Right image alignment in `Button`**

In RTL flow direction, image alignment with `End` will change its direction of placing image to the left. To keep that in same right position, set `Right` alignment as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  Text="Shopping"
                  TextColor="Black"
                  HorizontalOptions="Center"
                  ImageSource="add_to_card.png"
                  ShowIcon="True"
                  ImageSize="25"
                  Stroke="Black"
                  HeightRequest="50"
                  StrokeThickness="4"
                  Background="White"
                  ImageAlignment="Right"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = ImageSource.FromFile("add_to_card.png"),
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    StrokeThickness = 4,
    HeightRequest = 50,
    Background = Colors.White,
    ImageAlignment = Alignment.Right
};
this.Content = button;

{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with right alignment](images/customization-images/Button_imagealignment_right.png)

## EnableRippleEffect

The [EnableRippleEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_EnableRippleEffect) property is used to control the presence of the ripple effect. The default value is `false`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                  Text="Button"
                  HeightRequest="50" 
                  EnableRippleEffect="True" />

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.EnableRippleEffect = true;
button.HeightRequest = 50;
this.Content = button;

{% endhighlight %}
{% endtabs %}

![.NET MAUI RippleEffect support](images/customization-images/Button_EnableRippleEffect.gif)

## Gradient Background

You can set a gradient as the background of `Button` using the [`Background`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Background) property. The following gradient types are supported:

* Linear gradient
* Radial gradient

Refer to the [Microsoft gradient brush documentation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/brushes/gradient) for more details.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton Text="Linear Gradient"
                  HeightRequest="50" 
                  CornerRadius="20">
    <buttons:SfButton.Background>
        <LinearGradientBrush>
            <LinearGradientBrush.GradientStops>
                <GradientStop Color="#0D62D4" 
                              Offset="0"/>
                <GradientStop Color="#9F3CDC" 
                              Offset="1"/>
            </LinearGradientBrush.GradientStops>
        </LinearGradientBrush>
    </buttons:SfButton.Background>
</buttons:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton linearButton = new SfButton();
linearButton.Text = "Linear Gradient";
linearButton.HeightRequest = 50;
linearButton.CornerRadius = 20;
LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
linearGradientBrush.GradientStops = new GradientStopCollection()
{
    new GradientStop(){ Color = Color.FromHex("#0D62D4"), Offset = 0 },
    new GradientStop(){ Color = Color.FromHex("#9F3CDC"), Offset = 1 }
};
linearButton.Background = linearGradientBrush;
this.Content = linearButton;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}

<buttons:SfButton Text="Radial Gradient" 
                  HeightRequest="50" 
                  CornerRadius="20">
    <buttons:SfButton.Background>
        <RadialGradientBrush Radius="1.5">
            <RadialGradientBrush.GradientStops>
                <GradientStop Color="#0D62D4" 
                              Offset="0"/>
                <GradientStop Color="#9F3CDC" 
                              Offset="1"/>
            </RadialGradientBrush.GradientStops>
        </RadialGradientBrush>
    </buttons:SfButton.Background>
</buttons:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton radialButton = new SfButton();
radialButton.Text = "Radial Gradient";
radialButton.HeightRequest = 50;
radialButton.CornerRadius = 20;
RadialGradientBrush radialGradientBrush = new RadialGradientBrush();
radialGradientBrush.GradientStops = new GradientStopCollection()
{
    new GradientStop(){ Color = Color.FromHex("#0D62D4"), Offset = 0 },
    new GradientStop(){ Color = Color.FromHex("#9F3CDC"), Offset = 1 }
};
radialButton.Background = radialGradientBrush;
this.Content = radialButton;

{% endhighlight %}
{% endtabs %}

![.NET MAUI gradient support](images/customization-images/Button_gradient.jpg)

## Command

The [Command](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Command) property is used to associate a command with an instance of [`Button`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html). This property is most often set with the MVVM pattern to bind callbacks back into the ViewModel. You can also pass a parameter using the `CommandParameter` property.

N> The default value of the `Command` property is `null`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  Text="Button"
                  Background="{Binding Background}"
                  Command="{Binding ButtonCommand}">
</buttons:SfButton>

{% endhighlight %}

{% highlight c# %}

public class CommandDemoViewModel : INotifyPropertyChanged
{

    private Color _background = Color.Accent;

    public Color Background
    {
        get { return _background; }
        set
        {
            _background = value;
            NotifyPropertyChanged();
        }
    }

    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public CommandDemoViewModel()
    {
        SetBackgroundColor();
        this.Background=Color.Accent;
    }

    private void SetBackgroundColor()
    {
	    //do whatever you want to do here
        this.Background = this.Background == Color.DeepSkyBlue ? Color.Accent : Color.DeepSkyBlue;
    }

    public ICommand ButtonCommand => new Command(SetBackgroundColor);

}

{% endhighlight %}

{% endtabs %}

## See also

- [Events](https://help.syncfusion.com/maui/button/events)
- [Visual States](https://help.syncfusion.com/maui/button/visual-states)
---
layout: post
title: Customization in .NET MAUI Button control | Syncfusion
description: Learn here all about Customization support in Syncfusion .NET MAUI Button (SfButton) control and more.
platform: maui
control: Sfbutton
documentation: ug
---

# Customization in .NET MAUI Button (SfButton)

The [.NET MAUI Button](https://www.syncfusion.com/maui-controls/maui-button) control supports to customize the border color, image width, corner radius, background color, and more. The button control can be customized using the following properties:

## Text Customization

The text inside the button can be customized by its text color, font size, font attributes, font family and text alignment.

### TextColor

The [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_TextColor) property is used to customize the color of text in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" TextColor = "White">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.TextColor = Colors.White;

{% endhighlight %}
{% endtabs %}

![SfButton with text color](images/customization-images/Button_textcolor.png)

### FontSize

The [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontSize) property is used to customize the size of text in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" FontSize = "18">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.FontSize = 18;

{% endhighlight %}
{% endtabs %}

![SfButton with font size](images/customization-images/Button_fontsize.png)

### FontAttributes

The [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontAttributes) property is used to customize the font style of text in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" FontAttributes = "Italic">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.FontAttributes = FontAttributes.Italic;

{% endhighlight %}
{% endtabs %}

![SfButton with fontattributes](images/customization-images/Button_fontattributes.png)

### FontFamily

The [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_FontFamily) property is used to customize the font family of text in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" FontFamily = "Samantha-Demo">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.FontFamily = "Samantha-Demo";

{% endhighlight %}
{% endtabs %}

![SfButton with fontfamily](images/customization-images/Button_fontfamily.jpg)

### TextAlignment

The [`HorizontalTextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_HorizontalTextAlignment) and [`VerticalTextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_VerticalTextAlignment) properties are used to customize the alignment of text in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" HorizontalTextAlignment="Center" VerticalTextAlignment="Center">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.HorizontalTextAlignment = TextAlignment.Center;
button.VerticalTextAlignment = TextAlignment.Center;

{% endhighlight %}
{% endtabs %}

## Background Customization

The background of the button can be customized by its background color, border color, border width and corner radius.

### Background Color

The [`Background`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Background) property is used to customize the background color of [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" Background = "DeepSkyBlue">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.Background = Colors.DeepSkyBlue;

{% endhighlight %}
{% endtabs %}

N> When defining the background colors of the SfButton control, always use the `Background` property instead of the `BackgroundColor` property.

![SfButton with background color](images/customization-images/Button_backgroundcolor.png)

### Stroke

The [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Stroke) property is used to customize the color of border in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" Stroke="Red">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.Stroke = Colors.Red;

{% endhighlight %}
{% endtabs %}

![SfButton with stroke](images/customization-images/Button_border.png)

### StrokeThickness

The [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_StrokeThickness) property is used to customize the thickness of border in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html). 

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" Stroke="Red" StrokeThickness="6">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.StrokeThickness = 6;
button.Stroke = Colors.Red;

{% endhighlight %}
{% endtabs %}

![SfButton with strokethickness](images/customization-images/Button_borderthickness.png)

### CornerRadius

The [`CornerRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_CornerRadius) property is used to customize the rounded edges in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) as demonstrated in the following code sample.

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" CornerRadius="20">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.CornerRadius = 20;

{% endhighlight %}
{% endtabs %}

![SfButton with cornerradius](images/customization-images/Button_cornerradius.png)

## Image Customization

The Image can be customized by its ShowIcon, ImageSource, ImageSize and ImageAlignment.

### ShowIcon

You can enable the Icon image using the [`ShowIcon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ShowIcon) property to know whether any image appears to the [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" ImageSource="Heart.png" ShowIcon="True">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.ImageSource = "Heart.png";
button.ShowIcon = True;

{% endhighlight %}
{% endtabs %}

### ImageSource

The [`ImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSource) property is used to customize the icon image of [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) by adding a custom image.

N> Enable the [`ShowIcon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ShowIcon) property to enable the [`ImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSource) property. 

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" ImageSource="Heart.png" ShowIcon="True">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.ImageSource = "Heart.png";
button.ShowIcon = True;

{% endhighlight %}
{% endtabs %}

![SfButton with image with content](images/customization-images/Button_icon.png)

### ImageSize

The [`ImageSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSize) property is used to customize the width of icon image in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

N> Enable the `ShowIcon` property to enable the `ImageSize` property.

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" ImageSource="Heart.png" ShowIcon="True" ImageSize="50">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.ImageSource = "Heart.png";
button.ShowIcon = true;
button.ImageSize= 50;

{% endhighlight %}
{% endtabs %}

### ImageAlignment 

The [`ImageAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageAlignment) property is used to customize the alignment of icon image in [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html). The following options are available in [`ImageAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageAlignment):

* [`Start`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Start) - Places the image at the left most of [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).
* [`End`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_End) - Places the image at the right most of [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).
* [`Top`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Top) - Places the image at the top of the text.
* [`Bottom`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Bottom) - Places the image at the bottom of the text.
* Center - Places the image at the center of the text.
* [`Left`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Left) - Although the flow direction has been applied, it always places the image in the left part of [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html). For example, in the direction of the RTL flow, the image setting will move to the right. Use [`Left`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Left) alignment to show this in the same left position.
* [`Right`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Right) - Although flow direction has been applied, the image is always located in the right part of [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html). For example, in the direction of the RTL flow, the image setting will move to the left. But use [`Right`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Right) alignment to show this in the same right position.

N> Enable the `ShowIcon` property to enable the `ImageAlignment` property.

**End image alignment in `SfButton`**

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
                Background="White"
                ImageAlignment="End"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = "add_to_card.png",
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    Background = Colors.White,
    ImageAlignment = Alignment.End
};

{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with end alignment](images/customization-images/Button_imagealignment_end.png)

**Start image alignment in `SfButton`**

{% tabs %}
{% highlight xaml %}

<buttons:SfButton  x:Name="button"
                    Text="Shopping"
                    TextColor="Black"
                    HorizontalOptions="Center"
                    ImageSource="add_to_card.png"
                    ShowIcon="True" 
                    ImageSize="25"
                    Stroke="Black"
                    Background="White"
                    ImageAlignment="Start"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = "add_to_card.png",
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    Background = Colors.White,
    ImageAlignment = Alignment.Start
};


{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with start alignment](images/customization-images/Button_imagealignment_start.png)

**Top image alignment in `SfButton`**

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
                Background="White"
                ImageAlignment="Top"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = "add_to_card.png",
    ShowIcon = true,
    ImageSize= 25,
    Stroke = Colors.Black,
    Background = Colors.White,
    ImageAlignment = Alignment.Top
};


{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with top alignment](images/customization-images/Button_imagealignment_top.png)

**Bottom image alignment in `SfButton`**

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
                Background="White"
                ImageAlignment="Bottom"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = "add_to_card.png",
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    Background = Colors.White,
    ImageAlignment = Alignment.Bottom
};


{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with top alignment](images/customization-images/Button_imagealignment_bottom.png)

**Center image alignment in `SfButton`**

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
                Background="White"
                ImageAlignment="Center"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = "add_to_card.png",
    ShowIcon = true,
    ImageSize = 25,
    Stroke = Colors.Black,
    Background = Colors.White,
    ImageAlignment = Alignment.Center
};


{% endhighlight %}
{% endtabs %}

**Left image alignment in `SfButton`**

In RTL flow direction, image alignment with [`Start`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Start) will change its direction of placing image to the right. To keep that in same left position, set [`Left`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Left) alignment as shown in the following code sample.

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
                Background="White"
                ImageAlignment="Left"/>

{% endhighlight %}

{% highlight c# %}

SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = "add_to_card.png",
    ShowIcon = true,
    ImageSize = 25,
    Stroke= Colors.Black,
    Background = Colors.White,
    ImageAlignment = Alignment.Left
};

{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with left alignment](images/customization-images/Button_imagealignment_left.png)

**Right image alignment in `SfButton`**

In RTL flow direction, image alignment with [`End`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_End) will change its direction of placing image to the left. To keep that in same right position, set [`Right`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Alignment.html#Syncfusion_Maui_Core_Alignment_Right) alignment as shown in the following code sample.

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
                Background="White"
                ImageAlignment="Right"/>

{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    Text = "Shopping",
    TextColor = Colors.Black,
    HorizontalOptions = LayoutOptions.Center,
    ImageSource = "add_to_card.png",
    ShowIcon = true,
    ImageSize = 25,
    Stroke= Colors.Black,
    Background = Colors.White,
    ImageAlignment = Alignment.Right
};


{% endhighlight %}
{% endtabs %}

![SfButton with image with icon image with right alignment](images/customization-images/Button_imagealignment_right.png)

## EnableRippleEffect

The EnableRippleEffect property is used to control the presence of the ripple effects.

{% tabs %}
{% highlight xaml %}

<button:SfButton x:Name="button" Text="Button" EnableRippleEffect="True" />

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.EnableRippleEffect = True;

{% endhighlight %}
{% endtabs %}

## Gradient background

You can set the gradient as background of SfButton using the [`Background`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Background) property. It supports the following types of gradients:

* Linear gradient
* Radial gradient

Refer to this [`documentation`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/brushes/gradient) to learn more details about gradient.

{% tabs %}
{% highlight xaml %}

. . . 

<button:SfButton Text="Linear Gradient" CornerRadius="20">
    <button:SfButton.Background>
        <LinearGradientBrush>
            <LinearGradientBrush.GradientStops>
                <GradientStop Color="#0D62D4" Offset="0"/>
                <GradientStop Color="#9F3CDC" Offset="1"/>
            </LinearGradientBrush.GradientStops>
        </LinearGradientBrush>
    </button:SfButton.Background>
</button:SfButton>

<button:SfButton Text="Radial Gradient" CornerRadius="20">
    <button:SfButton.Background>
        <RadialGradientBrush Radius="1.5">
            <RadialGradientBrush.GradientStops>
                <GradientStop Color="#0D62D4" Offset="0"/>
                <GradientStop Color="#9F3CDC" Offset="1"/>
            </RadialGradientBrush.GradientStops>
        </RadialGradientBrush>
    </button:SfButton.Background>
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

. . .

SfButton linearButton = new SfButton();
linearButton.Text = "Linear Gradient";
linearButton.CornerRadius = 20;
LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
linearGradientBrush.GradientStops = new GradientStopCollection()
{
    new GradientStop(){ Color = Color.FromHex("#0D62D4"), Offset = 0 },
    new GradientStop(){ Color = Color.FromHex("#9F3CDC"), Offset = 1 }
};
linearButton.Background = linearGradientBrush;

SfButton radialButton = new SfButton();
radialButton.Text = "Radial Gradient";
radialButton.CornerRadius = 20;
RadialGradientBrush radialGradientBrush = new RadialGradientBrush();
radialGradientBrush.GradientStops = new GradientStopCollection()
{
    new GradientStop(){ Color = Color.FromHex("#0D62D4"), Offset = 0 },
    new GradientStop(){ Color = Color.FromHex("#9F3CDC"), Offset = 1 }
};
radialButton.Background = radialGradientBrush;

{% endhighlight %}
{% endtabs %}

![.NET MAUI gradient support](images/customization-images/Button_gradient.jpg)

## Command

The [`Command`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Command)  property is used to associate a command with an instance of [`SfButton`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/brushes/gradient). This property is most often set with MVVM pattern to bind callbacks back into the ViewModel.

N> Default value is [`null`].

{% tabs %}
{% highlight xaml %}

 <ContentPage.BindingContext>
    <local:CommandDemoViewModel />
 </ContentPage.BindingContext>

<button:SfButton x:Name="button" 
                Text="Button" 
                Background="{Binding Background}" 
                Command="{Binding ButtonCommand}">
</button:SfButton>

{% endhighlight %}
{% highlight c# %}

// ViewModel

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

---

layout: post
title: Customization of Syncfusion Badge View control for .NET MAUI
description: This section explains how to customize the font, border, and text in the Syncfusion SfBadgeView control in MAUI platform
platform: maui
control: Badge View
documentation: ug

---

# Badge Customization in .NET MAUI Badge View (SfBadgeView)

The [BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeSettings) property helps you to customize the basic look and feel of the badge view. 

[BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html) contains the sub-elements such as badge types, positions and colors. You can customize the background color, text color, border color, width, offset, and font attributes.

## Font customization

The font can be customized using the [FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontSizeProperty), [FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontAttributesProperty), and [FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontFamilyProperty) properties.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView BadgeText="48"  WidthRequest="120" HeightRequest="80"  HorizontalOptions="Center" VerticalOptions="Center">
            <badge:SfBadgeView.Content>
                <Button Text ="Primary" BackgroundColor="#d6d8d7" TextColor="Black"  WidthRequest="120" HeightRequest="60" />
            </badge:SfBadgeView.Content>
            <badge:SfBadgeView.BadgeSettings>
                <badge:BadgeSettings FontSize="15" FontAttributes="Bold" FontFamily="serif">
                </badge:BadgeSettings>
            </badge:SfBadgeView.BadgeSettings>
 </badge:SfBadgeView>


{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.WidthRequest = 120;
sfBadgeView.HeightRequest = 50;
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.BadgeText = "48";
Button button = new Button();
button.Text = "Primary";
button.TextColor = Colors.Black;
button.BackgroundColor =Color.FromRgba(214, 216, 215, 255);
button.WidthRequest = 120;
button.HeightRequest = 60;
sfBadgeView.Content = button;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.FontAttributes = FontAttributes.Bold;
badgeSetting.FontSize = 15;
badgeSetting.FontFamily = "serif";
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Font Customization](badge-customization_images/net_maui_badge_notifications_font_customization.png)

## Border customization

The border color and border width of the badge view can be customized using the [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_StrokeProperty) and [BorderWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_BorderWidthProperty) properties, respectively.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView BadgeText="30"  WidthRequest="120" HeightRequest="60" HorizontalOptions="Center" VerticalOptions="Center">
    <badge:SfBadgeView.Content>
        <Button Text ="Primary" BackgroundColor="#d6d8d7" TextColor="Black" WidthRequest="120" HeightRequest="60"/>
    </badge:SfBadgeView.Content>
    <badge:SfBadgeView.BadgeSettings>
        <badge:BadgeSettings Stroke="Orange" BorderWidth="2" />
    </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.WidthRequest = 120;
sfBadgeView.HeightRequest = 80;
sfBadgeView.BadgeText = "30";
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
Button button = new Button();
button.TextColor = Colors.Black;
button.BackgroundColor = Color.FromRgba(214, 216, 215, 255);
button.Text = "Primary";
button.WidthRequest = 120;
button.HeightRequest = 60;
sfBadgeView.Content = button;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Stroke = Colors.Orange;
badgeSetting.BorderWidth = 2;
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Stroke Customization](badge-customization_images/net_maui_badge_notifications_stroke_customization.png)

## Text customization

The text color and margin of badge view can be changed using the [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_TextColorProperty) and [TextPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_TextPaddingProperty) properties, respectively.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView BadgeText="45"  WidthRequest="120" HeightRequest="80" HorizontalOptions="Center" VerticalOptions="Center">
    <badge:SfBadgeView.Content>
        <Button Text ="Primary" BackgroundColor="#d6d8d7" TextColor="Black" WidthRequest="120" HeightRequest="60"/>
    </badge:SfBadgeView.Content>
    <badge:SfBadgeView.BadgeSettings>
        <badge:BadgeSettings TextColor="LightYellow"  TextPadding ="10" />
    </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.WidthRequest = 120;
sfBadgeView.HeightRequest = 80;
sfBadgeView.BadgeText = "45";
Button button = new Button();
button.WidthRequest = 120;
button.HeightRequest = 60;
button.BackgroundColor = Color.FromRgba(214, 216, 215, 255);
button.Text = "Primary";
button.Text = "Primary";
sfBadgeView.Content = button;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.TextColor = Color.LightYellow;
badgeSetting.TextPadding = 10;
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Text Customization](badge-customization_images/net_maui_badge_notifications_text_customization.png)

## Predefined styles

The colors of the badge can be customized using the [BadgeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeType.html) property. The badge supports the following eight different essential colors for various situations:

 * Dark
 * Error
 * Info
 * Light
 * Primary
 * Secondary
 * Success
 * Warning

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView BadgeText="8" HeightRequest="70" WidthRequest="60" HorizontalOptions="Center" VerticalOptions="Center">
        <badge:SfBadgeView.Content>
            <Image Source="badgefacebook.png"  HeightRequest="70" WidthRequest="60"/>
        </badge:SfBadgeView.Content>
        <badge:SfBadgeView.BadgeSettings>
            <badge:BadgeSettings Type="Error" />
        </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

 SfBadgeView sfBadgeView = new SfBadgeView();
            sfBadgeView.HeightRequest = 70;
            sfBadgeView.WidthRequest = 60;
            sfBadgeView.HorizontalOptions = LayoutOptions.Center;
            sfBadgeView.VerticalOptions = LayoutOptions.Center;
            sfBadgeView.BadgeText = "8";
            Image image = new Image();
            image.Source = "badgefacebook.png";
            image.HeightRequest = 70;
            image.WidthRequest = 60;
            sfBadgeView.Content = image;
            BadgeSettings badgeSetting = new BadgeSettings();
            badgeSetting.Type = BadgeType.Error;
            sfBadgeView.BadgeSettings = badgeSetting;
            Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Types](badge-customization_images/net_maui_badge_notifications_badge_type.png)

## Badge background customization

Other than the predefined styles, the color of the badge can be customized using the [BadgeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeType.html) property which has to be set as [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeType.html#Syncfusion_Maui_Core_BadgeType_None). Then the color of the badge view can be set using the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Background) property.

{% tabs %}

{% highlight xaml %}
 <badge:SfBadgeView BadgeText="48" WidthRequest="120" HeightRequest="60" HorizontalOptions="Center" VerticalOptions="Center" >
    <badge:SfBadgeView.Content>
        <Button Text ="Primary"  BackgroundColor="#d6d8d7" TextColor="Black" WidthRequest="120" HeightRequest="60"/>
    </badge:SfBadgeView.Content>
    <badge:SfBadgeView.BadgeSettings>
        <badge:BadgeSettings Type="None" Background="Green" />
    </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.HeightRequest = 60;
sfBadgeView.WidthRequest = 120;
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.BadgeText = "48";
Button button = new Button();
button.Text = "Primary";
button.TextColor = Colors.Black;
button.BackgroundColor = Color.FromRgba(214, 216, 215, 255);
button.HeightRequest = 60;
button.WidthRequest = 120;
sfBadgeView.Content = button;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Type = BadgeType.None;
badgeSetting.Background = new SolidColorBrush(Colors.Green);
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Background](badge-customization_images/net_maui_badge_notifications_background_customization.png)

## Setting corner radius of the badge

The [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_CornerRadius) property is used to reduce the radius of the corners.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView BadgeText="100" WidthRequest="120" HeightRequest="60" HorizontalOptions="Center" VerticalOptions="Center" >
        <badge:SfBadgeView.Content>
            <Button Text ="Primary" BackgroundColor="#d6d8d7" TextColor="Black" WidthRequest="120" HeightRequest="60"/>
        </badge:SfBadgeView.Content>
        <badge:SfBadgeView.BadgeSettings>
            <badge:BadgeSettings CornerRadius="5,5,5,5"/>
        </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.HeightRequest = 60;
sfBadgeView.WidthRequest = 120;
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.BadgeText = "100";
Button button = new Button();
button.Text = "Primary";
button.HeightRequest = 60;
button.WidthRequest = 120;
button.TextColor = Colors.Black;
button.BackgroundColor = Color.FromRgba(214, 216, 215, 255);
sfBadgeView.Content = button;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.CornerRadius = new Microsoft.Maui.CornerRadius(5, 5, 5, 5);
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Corner Radius](badge-customization_images/net_maui_badge_notifications_corner_radius.png)

## Alignment of badge

Align the badge view using the Center, Start, and End properties of `BadgeAlignment` property.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView BadgeText="20" HorizontalOptions="Center" VerticalOptions="Center" >
    <badge:SfBadgeView.Content>
        <Label Text="CENTER" BackgroundColor="LightGray" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"
                WidthRequest="100" HeightRequest="60" TextColor="Black" />
    </badge:SfBadgeView.Content>
    <badge:SfBadgeView.BadgeSettings>
        <badge:BadgeSettings BadgeAlignment="Center" CornerRadius="0"/>
    </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>    

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.BadgeText = "20";
Label label = new Label();
label.Text = "CENTER";
label.HeightRequest = 60;
label.WidthRequest = 100;
label.BackgroundColor = Colors.LightGray;
label.HorizontalTextAlignment = TextAlignment.Center;
label.VerticalTextAlignment = TextAlignment.Center;
label.TextColor = Colors.Black;
sfBadgeView.Content = label;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.BadgeAlignment = BadgeAlignment.Center;
badgeSetting.CornerRadius = 0;
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![BadgeView Alignment](badge-customization_images/badge_alignment.png)

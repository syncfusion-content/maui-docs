---
layout: post
title: Customization in Syncfusion Avatar View .NET MAUI
description: This section will explain about how to achieve the customization of default View in .NET MAUI SfAvatarView.
platform: maui
control: AvatarView
documentation: ug
---

# Customization in SfAvatarView

## Customization in .NET MAUI Avatar View(SfAvatarView)

The SfAvatarView control provides options to customize the color and size. The control can be customized using the following properties:

## Colors

Color in the SfAvatarView can be customized by the border color, the default background color, and automatic background color.

### Border color

The border color is used for setting color to the border of SfAvatarView using the `BorderColor` property.

{% tabs %}

{% highlight xaml %}

<Grid>
   <sfavatar:SfAvatarView  ContentType="Default"  
                           AvatarShape="Circle"
                           AvatarSize="Large"
                           HorizontalOptions="Center"
                           VerticalOptions="Center"
                           ImageSource="ellanaa.png"
                           BorderColor="Red">
   </sfavatar:SfAvatarView>
</Grid>

{% endhighlight %}

{% highlight c# %}

Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.ContentType = ContentType.Default;
avatarview.AvatarShape = AvatarShape.Circle;
avatarview.AvatarSize = AvatarSize.Large;
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.ImageSource = "ellanaa.png";
avatarview.BorderColor = Colors.Red;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}

{% endtabs %}

![AvatarControl Border Color](Customization_Images/BorderColor_AvatarView.png)

### Default background color

The background color for the SfAvatarView control can be set using the `AvatarColorMode` property. When the `AvatarColorMode` property is set to default, it displays the background color set in the `BackgroundColor` property.

{% tabs %}

{% highlight xaml %}

<Grid>
   <sfavatar:SfAvatarView  ContentType="Initials"
                           AvatarShape="Circle"
                           AvatarSize="Large"
                           HorizontalOptions="Center"
                           VerticalOptions="Center"
                           AvatarName="Alex"          
                           BackgroundColor="Bisque"
                           AvatarColorMode="Default"
                           BorderColor="Black">
   </sfavatar:SfAvatarView>
</Grid>
      

{% endhighlight %}

{% highlight c# %}

Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.ContentType = ContentType.Initials;
avatarview.AvatarShape = AvatarShape.Circle;
avatarview.AvatarSize = AvatarSize.Large;
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.AvatarName = "Alex";
avatarview.BorderColor = Colors.Black;
avatarview.AvatarColorMode = AvatarColorMode.Default;
avatarview.BackgroundColor = Colors.Bisque;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}

{% endtabs %}

![Default background color](Customization_Images/Default_Background_AvatarView.png)

### Automatic background color

The `SfAvatarView` control allows automatic background color while initializing. It contains the following properties:

* `DarkBackground`: Shows a dark color for the initials and background color.
* `LightBackground`: Shows a light color for the initials and background color.

#### Dark color

The dark background color can be set using `DarkBackground` in the `AvatarColorMode` property.

{% tabs %}

{% highlight xaml %}

<Grid>
   <sfavatar:SfAvatarView  ContentType="Initials"
                           InitialsType="DoubleCharacter"
                           AvatarShape="Circle"
                           AvatarSize="Large"
                           HorizontalOptions="Center"
                           VerticalOptions="Center"
                           AvatarName="Alex"
                           AvatarColorMode="DarkBackground"
                           BorderColor="Black">
   </sfavatar:SfAvatarView>
</Grid>

{% endhighlight %}

{% highlight c# %}


Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.AvatarShape = AvatarShape.Circle;
avatarview.AvatarSize = AvatarSize.Large;
avatarview.ContentType = ContentType.Initials;
avatarview.InitialsType = InitialsType.DoubleCharacter;
avatarview.AvatarName = "Alex";
avatarview.BorderColor = Colors.Black;
avatarview.AvatarColorMode = AvatarColorMode.DarkBackground;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;


{% endhighlight %}

{% endtabs %}

![Dark color](Customization_Images/Dark_SfAvatarView.png)

#### Light color

The light background color can be set using `LightBackground` in the `AvatarColorMode` property.

{% tabs %}

{% highlight xaml %}

<Grid>
   <sfavatar:SfAvatarView  ContentType="Initials"
                           InitialsType="DoubleCharacter"
                           VerticalOptions="Center"
                           AvatarName="Alex"
                           AvatarShape="Circle"
                           AvatarSize="Large"
                           AvatarColorMode="LightBackground"
                           BorderColor="Black"
                           HorizontalOptions="Center" >
   </sfavatar:SfAvatarView>
</Grid>

{% endhighlight %}

{% highlight c# %}
  
Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.AvatarShape = AvatarShape.Circle;
avatarview.AvatarSize = AvatarSize.Large;
avatarview.ContentType = ContentType.Initials;
avatarview.InitialsType = InitialsType.DoubleCharacter;
avatarview.AvatarName = "Alex";
avatarview.BorderColor = Colors.Black;
avatarview.AvatarColorMode = AvatarColorMode.LightBackground;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}

{% endtabs %}

![Light color](Customization_Images/Light_SfAvatarView.png)

### Gradients

You can also specify a range of colors using `LinearGradientBrush` in `Background` Property as demonstrated in the following code example.

{% tabs %}

{% highlight xaml %}

<sfavatar:SfAvatarView  ContentType="Initials" 
                        AvatarName="Alex"
                        AvatarShape="Circle"
                        AvatarSize="Large"
                        HorizontalOptions="Center"
                        VerticalOptions="Center"      
                        InitialsType="DoubleCharacter">
   <sfavatar:SfAvatarView.Background>
         <LinearGradientBrush StartPoint="0,0"
                     EndPoint="1,0">
            <GradientStop Color="#2F9BDF" Offset="0"/>
            <GradientStop Color="#51F1F2" Offset="1"/>
         </LinearGradientBrush>
   </sfavatar:SfAvatarView.Background>
</sfavatar:SfAvatarView>
  

{% endhighlight %}

{% highlight c# %}

Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.AvatarShape = AvatarShape.Circle;
avatarview.AvatarSize = AvatarSize.Large;
avatarview.ContentType = ContentType.Initials;
avatarview.InitialsType = InitialsType.DoubleCharacter;
avatarview.AvatarName = "Alex";
avatarview.BorderColor = Colors.Black;
avatarview.Background = new LinearGradientBrush() 
{ 
   StartPoint = new Point(0,0), 
   EndPoint = new Point(1, 0),
   GradientStops = new GradientStopCollection() 
   { 
      new GradientStop() { Color = Color.FromArgb("#2F9BDF"), Offset = 0 },
      new GradientStop() { Color = Color.FromArgb("#51F1F2"), Offset = 1 }
   }
};
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}

{% endtabs %}

![SfAvatarView control with gradient](Customization_Images/Gradient_SfAvatarView.png)

## Sizing

In the `SfAvatarView` control, size of the view can be controlled using width, height, border thickness, and corner radius.

### Width

You can customize the width of the avatar view using the `WidthRequest` property.

### Height

You can customize the height of the avatar view using the `HeightRequest` property.

### Border Thickness

You can customize the thickness of the avatar view using the `BorderThickness` property.

{% tabs %}

{% highlight xaml %}

<Grid>
   <sfavatar:SfAvatarView  ContentType="Default"
                           AvatarShape="Circle"
                           AvatarSize="Large"
                           ImageSource="ellanaa.png"
                           BorderColor="Red" 
                           VerticalOptions="Center"
                           BorderThickness="4"
                           HorizontalOptions="Center" >
   </sfavatar:SfAvatarView>
</Grid>

{% endhighlight %}

{% highlight c# %}

Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.AvatarShape = AvatarShape.Circle;
avatarview.AvatarSize = AvatarSize.Large;
avatarview.BorderThickness = 4;
avatarview.BorderColor = Colors.Red,
avatarview.ContentType = ContentType.Default;
avatarview.ImageSource = "ellanaa.png";
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}

{% endtabs %}

![AvatarView Border width](Customization_Images/BordeWidth_AvatarView.png)

### Corner radius

You can customize the corner radius of the avatar view using the `CornerRadius` property.

{% tabs %}

{% highlight xaml %}

<Grid>
   <sfavatar:SfAvatarView  ContentType="Default"
                           ImageSource="ellanaa.png"
                           HorizontalOptions="Center"
                           VerticalOptions="Center"   
                           WidthRequest="60"
                           HeightRequest="60"
                           CornerRadius="20">
   </sfavatar:SfAvatarView>
</Grid>

{% endhighlight %}

{% highlight c# %}

Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.WidthRequest = 60;
avatarview.HeightRequest = 60;
avatarview.CornerRadius = 20;
avatarview.ImageSource = "ellanaa.png";
avatarview.ContentType = ContentType.Default;
mainGrid.Children.Add(avatarview);
this.Content = mainGrid;

{% endhighlight %}

{% endtabs %}

![SfAvatarView corner radius](Customization_Images/CornerRadius_AvatarView.png)


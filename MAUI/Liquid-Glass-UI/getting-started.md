---
layout: post
title: Getting Started with Liquid Glass UI in Syncfusion® .NET MAUI Controls
description: Getting started with the Liquid Glass Effect UI in Syncfusion® .NET MAUI controls and learn how to enable and customize it.
platform: MAUI
control: General
documentation: UG
---

# Getting Started with Liquid Glass for Modern UI

This section explains how to enable and customize the Liquid Glass Effect in Syncfusion® .NET MAUI controls. For detailed information on specific Syncfusion® controls and their usage, refer to the respective Getting Started documentation. Ensure the control is properly configured and functioning before applying the Liquid Glass Effect.

N> This feature is supported only on `.NET 10`

## Supported Platforms

* macOS 26 or higher
* iOS 26 or higher

## Liquid Glass Effect

The Liquid Glass Effect provides a modern, translucent design with background blur and depth effects, enhancing the visual appearance of your UI without requiring major code changes. To apply the Liquid Glass Effect to any Syncfusion® .NET MAUI control or custom view (such as a DataTemplate), wrap the control inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.

This view acts as a visual container that adds blur, translucency, and light refraction to its content, creating a realistic glass-like appearance. In this section, we will demonstrate how to use [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) with Syncfusion® controls to achieve a visually appealing glass effect.

The [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class is available in [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) and provides the following properties:

### Effect types

The [EffectType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html#Syncfusion_Maui_Core_SfGlassEffectView_EffectType) property specifies the type of glass effect to apply:

* **[Regular](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LiquidGlassEffectType.html#Syncfusion_Maui_Core_LiquidGlassEffectType_Regular):** Creates a blurred, frosted glass appearance.
* **[Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LiquidGlassEffectType.html#Syncfusion_Maui_Core_LiquidGlassEffectType_Clear):** Creates a transparent, glass-like appearance.

{% tabs %}
{% highlight XAML hl_lines="19" %}

...
xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
xmlns:button="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75"
                          Offset="0.0" />
            <GradientStop Color="#3282B8"
                          Offset="0.5" />
            <GradientStop Color="#1B262C"
                          Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
    <Grid>
        <core:SfGlassEffectView CornerRadius="20"
                                EffectType="Clear"
                                Padding="16"
                                HeightRequest="140"
                                WidthRequest="420">
            <Grid ColumnDefinitions="64,*,Auto"
                  ColumnSpacing="12">
                <!-- Avatar -->
                <core:SfGlassEffectView WidthRequest="64"
                                        HeightRequest="64"
                                        EffectType="Clear"
                                        CornerRadius="32">
                    <core:SfAvatarView WidthRequest="64"
                                       HeightRequest="64"
                                       FontSize="24"
                                       CornerRadius="32"
                                       FontAttributes="Bold"
                                       AvatarName="SF"
                                       Background="Transparent"
                                       ContentType="Initials"
                                       InitialsType="DoubleCharacter" />
                </core:SfGlassEffectView>
                <!-- Title / Subtitle -->
                <VerticalStackLayout Grid.Column="1"
                                     Spacing="2"
                                     VerticalOptions="Center">
                    <Label Text="Syncfusion®"
                           TextColor="White"
                           FontAttributes="Bold"
                           FontSize="20" />
                    <Label Text="Deliver innovation with ease"
                           TextColor="#DDFFFFFF"
                           FontSize="15" />
                </VerticalStackLayout>
                <!-- Action Button -->
                <core:SfGlassEffectView CornerRadius="20"
                                        EffectType="Clear"
                                        WidthRequest="100"
                                        Grid.Column="2"
                                        HeightRequest="40">
                    <button:SfButton Text="Follow"
                                     Background="Transparent"
                                     TextColor="White" />
                </core:SfGlassEffectView>
            </Grid>
        </core:SfGlassEffectView>
    </Grid>
</Grid>
	
{% endhighlight %}
{% highlight C# hl_lines="24" %}

// Outer grid with gradient background
var mainGrid = new Grid
{
    Background = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(0, 1),
        GradientStops =
        {
            new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0 },
            new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5 },
            new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0 }
        }
    }
};

// Inner grid container
var innerGrid = new Grid();

// Glass effect view
var glassEffectView = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = GlassEffectType.Clear,
    Padding = 16,
    HeightRequest = 140,
    WidthRequest = 420
};

// Content grid inside glass effect
var contentGrid = new Grid
{
    ColumnSpacing = 12,
    ColumnDefinitions = new ColumnDefinitionCollection
    {
        new ColumnDefinition { Width = 64 },
        new ColumnDefinition { Width = GridLength.Star },
        new ColumnDefinition { Width = GridLength.Auto }
    },
};

// Avatar glass
var avatarGlass = new SfGlassEffectView
{
    WidthRequest = 64,
    HeightRequest = 64,
    EffectType = GlassEffectType.Clear,
    CornerRadius = 32
};

var avatar = new SfAvatarView
{
    WidthRequest = 64,
    HeightRequest = 64,
    FontSize = 24,
    CornerRadius = 32,
    FontAttributes = FontAttributes.Bold,
    AvatarName = "SF",
    Background = Colors.Transparent,
    ContentType = AvatarContentType.Initials,
    InitialsType = InitialsType.DoubleCharacter
};

avatarGlass.Content = avatar;

// Title / Subtitle stack
var stackLayout = new VerticalStackLayout
{
    Spacing = 2,
    VerticalOptions = LayoutOptions.Center
};

stackLayout.Children.Add(new Label
{
    Text = "Syncfusion®",
    TextColor = Colors.White,
    FontAttributes = FontAttributes.Bold,
    FontSize = 20
});

stackLayout.Children.Add(new Label
{
    Text = "Deliver innovation with ease",
    TextColor = Color.FromArgb("#DDFFFFFF"),
    FontSize = 15
});

Grid.SetColumn(stackLayout, 1);

// Action button glass
var buttonGlass = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = GlassEffectType.Clear,
    WidthRequest = 100,
    HeightRequest = 40
};

var followButton = new SfButton
{
    Text = "Follow",
    Background = Colors.Transparent,
    TextColor = Colors.White
};

buttonGlass.Content = followButton;
Grid.SetColumn(buttonGlass, 2);

// Add children to content grid
contentGrid.Children.Add(avatarGlass);
contentGrid.Children.Add(stackLayout);
contentGrid.Children.Add(buttonGlass);

// Set content of glassEffectView
glassEffectView.Content = contentGrid;

// Add glassEffectView to inner grid
innerGrid.Children.Add(glassEffectView);

// Add inner grid to main grid
mainGrid.Children.Add(innerGrid);

// Set page content
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-clear-effect-type-in-.net-maui](images/getting-started/liquid-glass-ui-with-clear-effect-type-in-.net-maui.png)
   
### Corner radius

Defines the corner radius for the view, enabling customization of its shape such as rounded rectangles or capsules.

{% tabs %}
{% highlight XAML hl_lines="15" %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75"
                          Offset="0.0" />
            <GradientStop Color="#3282B8"
                          Offset="0.5" />
            <GradientStop Color="#1B262C"
                          Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
    <Grid>
        <core:SfGlassEffectView EffectType="Clear"
                                CornerRadius="30"
                                EnableShadowEffect="true"
                                Padding="16"
                                HeightRequest="140"
                                WidthRequest="420">
            <Grid ColumnDefinitions="64,*,Auto"
                  ColumnSpacing="12">
                <!-- Avatar -->
                <core:SfGlassEffectView WidthRequest="64"
                                        HeightRequest="64"
                                        EffectType="Clear"
                                        CornerRadius="32">
                    <core:SfAvatarView WidthRequest="64"
                                       HeightRequest="64"
                                       FontSize="24"
                                       CornerRadius="32"
                                       FontAttributes="Bold"
                                       AvatarName="SF"
                                       Background="Transparent"
                                       ContentType="Initials"
                                       InitialsType="DoubleCharacter" />
                </core:SfGlassEffectView>
                <!-- Title / Subtitle -->
                <VerticalStackLayout Grid.Column="1"
                                     Spacing="2"
                                     VerticalOptions="Center">
                    <Label Text="Syncfusion®"
                           TextColor="White"
                           FontAttributes="Bold"
                           FontSize="20" />
                    <Label Text="Deliver innovation with ease"
                           TextColor="#DDFFFFFF"
                           FontSize="15" />
                </VerticalStackLayout>
                <!-- Action Button -->
                <core:SfGlassEffectView CornerRadius="20"
                                        EffectType="Clear"
                                        WidthRequest="100"
                                        Grid.Column="2"
                                        HeightRequest="40">
                    <button:SfButton Text="Follow"
                                     Background="Transparent"
                                     TextColor="White" />
                </core:SfGlassEffectView>
            </Grid>
        </core:SfGlassEffectView>
    </Grid>
</Grid>
	
{% endhighlight %}
{% highlight C# hl_lines="24" %}

// Outer grid with gradient background
var mainGrid = new Grid
{
    Background = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(0, 1),
        GradientStops =
        {
            new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0 },
            new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5 },
            new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0 }
        }
    }
};

// Inner grid container
var innerGrid = new Grid();

// Glass effect view (main card)
var glassEffectView = new SfGlassEffectView
{
    EffectType = GlassEffectType.Clear,
    CornerRadius = 30,
    EnableShadowEffect = true,
    Padding = 16,
    HeightRequest = 140,
    WidthRequest = 420
};

// Content grid inside glass effect
var contentGrid = new Grid
{
    ColumnSpacing = 12,
    ColumnDefinitions = new ColumnDefinitionCollection
    {
        new ColumnDefinition { Width = 64 },
        new ColumnDefinition { Width = GridLength.Star },
        new ColumnDefinition { Width = GridLength.Auto }
    },
};

// Avatar glass
var avatarGlass = new SfGlassEffectView
{
    WidthRequest = 64,
    HeightRequest = 64,
    EffectType = GlassEffectType.Clear,
    CornerRadius = 32
};

var avatar = new SfAvatarView
{
    WidthRequest = 64,
    HeightRequest = 64,
    FontSize = 24,
    CornerRadius = 32,
    FontAttributes = FontAttributes.Bold,
    AvatarName = "SF",
    Background = Colors.Transparent,
    ContentType = AvatarContentType.Initials,
    InitialsType = InitialsType.DoubleCharacter
};

avatarGlass.Content = avatar;

var stackLayout = new VerticalStackLayout
{
    Spacing = 2,
    VerticalOptions = LayoutOptions.Center
};

stackLayout.Children.Add(new Label
{
    Text = "Syncfusion®",
    TextColor = Colors.White,
    FontAttributes = FontAttributes.Bold,
    FontSize = 20
});

stackLayout.Children.Add(new Label
{
    Text = "Deliver innovation with ease",
    TextColor = Color.FromArgb("#DDFFFFFF"),
    FontSize = 15
});

Grid.SetColumn(stackLayout, 1);

// Action button glass
var buttonGlass = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = GlassEffectType.Clear,
    WidthRequest = 100,
    HeightRequest = 40
};

var followButton = new SfButton
{
    Text = "Follow",
    Background = Colors.Transparent,
    TextColor = Colors.White
};

buttonGlass.Content = followButton;
Grid.SetColumn(buttonGlass, 2);

// Add children to content grid
contentGrid.Children.Add(avatarGlass);
contentGrid.Children.Add(stackLayout);
contentGrid.Children.Add(buttonGlass);

// Set content of glassEffectView
glassEffectView.Content = contentGrid;

// Add glassEffectView to inner grid
innerGrid.Children.Add(glassEffectView);

// Add inner grid to main grid
mainGrid.Children.Add(innerGrid);

// Set page content
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-corner-radius-in-.net-maui](images/getting-started/liquid-glass-ui-with-corner-radius-in-.net-maui.png)

### Enable shadow effect

Adds a soft shadow to the content within the glass view, creating depth and a more realistic appearance.

{% tabs %}
{% highlight XAML hl_lines="16" %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75"
                          Offset="0.0" />
            <GradientStop Color="#3282B8"
                          Offset="0.5" />
            <GradientStop Color="#1B262C"
                          Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
    <Grid>
        <core:SfGlassEffectView EffectType="Clear"
                                CornerRadius="20"
                                EnableShadowEffect="true"
                                Padding="16"
                                HeightRequest="140"
                                WidthRequest="420">
            <Grid ColumnDefinitions="64,*,Auto"
                  ColumnSpacing="12">
                <!-- Avatar -->
                <core:SfGlassEffectView WidthRequest="64"
                                        HeightRequest="64"
                                        EffectType="Clear"
                                        CornerRadius="32">
                    <core:SfAvatarView WidthRequest="64"
                                       HeightRequest="64"
                                       FontSize="24"
                                       CornerRadius="32"
                                       FontAttributes="Bold"
                                       AvatarName="SF"
                                       Background="Transparent"
                                       ContentType="Initials"
                                       InitialsType="DoubleCharacter" />
                </core:SfGlassEffectView>
                <!-- Title / Subtitle -->
                <VerticalStackLayout Grid.Column="1"
                                     Spacing="2"
                                     VerticalOptions="Center">
                    <Label Text="Syncfusion®"
                           TextColor="White"
                           FontAttributes="Bold"
                           FontSize="20" />
                    <Label Text="Deliver innovation with ease"
                           TextColor="#DDFFFFFF"
                           FontSize="15" />
                </VerticalStackLayout>
                <!-- Action Button -->
                <core:SfGlassEffectView CornerRadius="20"
                                        EffectType="Clear"
                                        WidthRequest="100"
                                        Grid.Column="2"
                                        HeightRequest="40">
                    <button:SfButton Text="Follow"
                                     Background="Transparent"
                                     TextColor="White" />
                </core:SfGlassEffectView>
            </Grid>
        </core:SfGlassEffectView>
    </Grid>
</Grid>
	
{% endhighlight %}
{% highlight C# hl_lines="25" %}

// Outer grid with gradient background
var mainGrid = new Grid
{
    Background = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(0, 1),
        GradientStops =
        {
            new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0 },
            new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5 },
            new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0 }
        }
    }
};

// Inner grid container
var innerGrid = new Grid();

// Glass effect view
var glassEffectView = new SfGlassEffectView
{
    EffectType = GlassEffectType.Clear,
    CornerRadius = 20,
    EnableShadowEffect = true,
    Padding = 16,
    HeightRequest = 140,
    WidthRequest = 420
};

// Content grid inside glass effect
var contentGrid = new Grid
{
    ColumnSpacing = 12,
    ColumnDefinitions = new ColumnDefinitionCollection
    {
        new ColumnDefinition { Width = 64 },
        new ColumnDefinition { Width = GridLength.Star },
        new ColumnDefinition { Width = GridLength.Auto }
    },
};

// Avatar glass
var avatarGlass = new SfGlassEffectView
{
    WidthRequest = 64,
    HeightRequest = 64,
    EffectType = GlassEffectType.Clear,
    CornerRadius = 32
};

var avatar = new SfAvatarView
{
    WidthRequest = 64,
    HeightRequest = 64,
    FontSize = 24,
    CornerRadius = 32,
    FontAttributes = FontAttributes.Bold,
    AvatarName = "SF",
    Background = Colors.Transparent,
    ContentType = AvatarContentType.Initials,
    InitialsType = InitialsType.DoubleCharacter
};

avatarGlass.Content = avatar;

var stackLayout = new VerticalStackLayout
{
    Spacing = 2,
    VerticalOptions = LayoutOptions.Center
};

stackLayout.Children.Add(new Label
{
    Text = "Syncfusion®",
    TextColor = Colors.White,
    FontAttributes = FontAttributes.Bold,
    FontSize = 20
});

stackLayout.Children.Add(new Label
{
    Text = "Deliver innovation with ease",
    TextColor = Color.FromArgb("#DDFFFFFF"),
    FontSize = 15
});

Grid.SetColumn(stackLayout, 1);

// Action button glass
var buttonGlass = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = GlassEffectType.Clear,
    WidthRequest = 100,
    HeightRequest = 40
};

var followButton = new SfButton
{
    Text = "Follow",
    Background = Colors.Transparent,
    TextColor = Colors.White
};

buttonGlass.Content = followButton;
Grid.SetColumn(buttonGlass, 2);

// Add children to content grid
contentGrid.Children.Add(avatarGlass);
contentGrid.Children.Add(stackLayout);
contentGrid.Children.Add(buttonGlass);

// Set content of glassEffectView
glassEffectView.Content = contentGrid;

// Add glassEffectView to inner grid
innerGrid.Children.Add(glassEffectView);

// Add inner grid to main grid
mainGrid.Children.Add(innerGrid);

// Set page content
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-shadow-in-.net-maui](images/getting-started/liquid-glass-ui-with-shadow-in-.net-maui.png)

### Set background color

Applies a background tint color to the glass view, to enhance modern UI styling and improve readability.

{% tabs %}
{% highlight XAML hl_lines="16" %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75"
                          Offset="0.0" />
            <GradientStop Color="#3282B8"
                          Offset="0.5" />
            <GradientStop Color="#1B262C"
                          Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
    <Grid>
        <core:SfGlassEffectView EffectType="Clear"
                                CornerRadius="20"
                                Background="Orange"
                                Padding="16"
                                HeightRequest="140"
                                WidthRequest="420">
            <Grid ColumnDefinitions="64,*,Auto"
                  ColumnSpacing="12">
                <!-- Avatar -->
                <core:SfGlassEffectView WidthRequest="64"
                                        HeightRequest="64"
                                        EffectType="Clear"
                                        CornerRadius="32">
                    <core:SfAvatarView WidthRequest="64"
                                       HeightRequest="64"
                                       FontSize="24"
                                       CornerRadius="32"
                                       FontAttributes="Bold"
                                       AvatarName="SF"
                                       Background="Transparent"
                                       ContentType="Initials"
                                       InitialsType="DoubleCharacter" />
                </core:SfGlassEffectView>
                <!-- Title / Subtitle -->
                <VerticalStackLayout Grid.Column="1"
                                     Spacing="2"
                                     VerticalOptions="Center">
                    <Label Text="Syncfusion®"
                           TextColor="White"
                           FontAttributes="Bold"
                           FontSize="20" />
                    <Label Text="Deliver innovation with ease"
                           TextColor="#DDFFFFFF"
                           FontSize="15" />
                </VerticalStackLayout>
                <!-- Action Button -->
                <core:SfGlassEffectView CornerRadius="20"
                                        EffectType="Clear"
                                        WidthRequest="100"
                                        Grid.Column="2"
                                        HeightRequest="40">
                    <button:SfButton Text="Follow"
                                     Background="Transparent"
                                     TextColor="White" />
                </core:SfGlassEffectView>
            </Grid>
        </core:SfGlassEffectView>
    </Grid>
</Grid>
	
{% endhighlight %}
{% highlight C# hl_lines="25" %}

// Outer grid with gradient background
var mainGrid = new Grid
{
    Background = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(0, 1),
        GradientStops =
        {
            new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0 },
            new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5 },
            new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0 }
        }
    }
};

// Inner grid container
var innerGrid = new Grid();

// Glass effect view
var glassEffectView = new SfGlassEffectView
{
    EffectType = GlassEffectType.Clear,
    CornerRadius = 20,
    Background = Colors.Orange,
    Padding = 16,
    HeightRequest = 140,
    WidthRequest = 420
};

// Content grid inside glass effect
var contentGrid = new Grid
{
    ColumnSpacing = 12,
    ColumnDefinitions = new ColumnDefinitionCollection
    {
        new ColumnDefinition { Width = 64 },
        new ColumnDefinition { Width = GridLength.Star },
        new ColumnDefinition { Width = GridLength.Auto }
    },
};

// Avatar glass
var avatarGlass = new SfGlassEffectView
{
    WidthRequest = 64,
    HeightRequest = 64,
    EffectType = GlassEffectType.Clear,
    CornerRadius = 32
};

var avatar = new SfAvatarView
{
    WidthRequest = 64,
    HeightRequest = 64,
    FontSize = 24,
    CornerRadius = 32,
    FontAttributes = FontAttributes.Bold,
    AvatarName = "SF",
    Background = Colors.Transparent,
    ContentType = AvatarContentType.Initials,
    InitialsType = InitialsType.DoubleCharacter
};

avatarGlass.Content = avatar;

var stackLayout = new VerticalStackLayout
{
    Spacing = 2,
    VerticalOptions = LayoutOptions.Center
};

stackLayout.Children.Add(new Label
{
    Text = "Syncfusion®",
    TextColor = Colors.White,
    FontAttributes = FontAttributes.Bold,
    FontSize = 20
});

stackLayout.Children.Add(new Label
{
    Text = "Deliver innovation with ease",
    TextColor = Color.FromArgb("#DDFFFFFF"),
    FontSize = 15
});

Grid.SetColumn(stackLayout, 1);

// Action button glass
var buttonGlass = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = GlassEffectType.Clear,
    WidthRequest = 100,
    HeightRequest = 40
};

var followButton = new SfButton
{
    Text = "Follow",
    Background = Colors.Transparent,
    TextColor = Colors.White
};

buttonGlass.Content = followButton;
Grid.SetColumn(buttonGlass, 2);

// Add children to content grid
contentGrid.Children.Add(avatarGlass);
contentGrid.Children.Add(stackLayout);
contentGrid.Children.Add(buttonGlass);

// Set content of glassEffectView
glassEffectView.Content = contentGrid;

// Add glassEffectView to inner grid
innerGrid.Children.Add(glassEffectView);

// Add inner grid to main grid
mainGrid.Children.Add(innerGrid);

// Set page content
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-background-in-.net-maui](images/getting-started/liquid-glass-ui-with-background-in-.net-maui.png)

## Interactive Glass Effect

Enable glass effect that respond to user interactions with clear transparency and dynamic lighting for an engaging UI. To enable this feature, set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_EnableLiquidGlassEffect) property to `true` on the Syncfusion® [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) control. This activates interaction-based visual effects.

{% tabs %}
{% highlight XAML %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75"
                          Offset="0.0" />
            <GradientStop Color="#3282B8"
                          Offset="0.5" />
            <GradientStop Color="#1B262C"
                          Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
    <Grid>
        <core:SfGlassEffectView EffectType="Clear"
                                CornerRadius="20"
                                HeightRequest="140"
                                WidthRequest="380">
            <button:SfButton Text="Regular Glass"
                             EnableLiquidGlassEffect="True"
                             FontSize="16"
                             WidthRequest="150"
                             HeightRequest="40"
                             Background="Transparent"
                             TextColor="Black" />
        </core:SfGlassEffectView>
    </Grid>
</Grid>

{% endhighlight %}
{% highlight C# %}

// Outer grid with gradient background
var mainGrid = new Grid
{
    Background = new LinearGradientBrush
    {
        StartPoint = new Point(0, 0),
        EndPoint = new Point(0, 1),
        GradientStops =
        {
            new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0 },
            new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5 },
            new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0 }
        }
    }
};

// Inner grid container
var innerGrid = new Grid();

// Glass effect view
var glassEffectView = new SfGlassEffectView
{
    EffectType = GlassEffectType.Clear,
    CornerRadius = 20,
    HeightRequest = 140,
    WidthRequest = 380
};

// Button inside glass effect
var button = new SfButton
{
    Text = "Regular Glass",
    EnableLiquidGlassEffect = true,
    FontSize = 16,
    WidthRequest = 150,
    HeightRequest = 40,
    Background = Colors.Transparent,
    TextColor = Colors.Black
};

// Set button as content of glassEffectView
glassEffectView.Content = button;

// Add glassEffectView to inner grid
innerGrid.Children.Add(glassEffectView);

// Add inner grid to main grid
mainGrid.Children.Add(innerGrid);

// Set page content
this.Content = mainGrid;

{% endhighlight %}
{% endtabs %}

N> View sample in [GitHub](https://github.com/syncfusion/maui-demos/tree/master/MAUI/LiquidGlass).
---
layout: post
title: Getting Started with Liquid Glass Effect UI in Syncfusion® .NET MAUI Controls
description: Get started with the Liquid Glass Effect UI in Syncfusion® .NET MAUI controls and learn how to enable and customize it.
platform: MAUI
control: General
documentation: UG
---

# Getting Started with Liquid Glass for modern UI

The Liquid Glass effect adds a modern, translucent design with blur and depth, enhancing UI aesthetics without major layout changes. This section explains how to enable and customize the Liquid Glass Effect in Syncfusion® .NET MAUI controls.

For detailed information on specific Syncfusion® controls and their usage, refer to the User Guide Getting Started documentation, and ensure the control is properly configured and functioning before applying the Liquid Glass Effect.

N> This feature is supported only on .NET 10.

## Supported Platforms

* macOS 26 or higher
* iOS 26 or higher

## Apply Liquid Glass Effect

To apply Liquid Glass Effect to any Syncfusion® controls or custom views, use the `SfGlassEffectView` class. This view acts as a visual container that adds blur, translucency, and light refraction to its content, creating a realistic glass-like appearance.

### Key Properties of SfGlassEffectView

The `SfGlassEffectView` class contains the following properties:

 * **EffectType:** - Defines the type of glass effect applied.
  
  	* **Regular:** Blurred glass effect.
	* **Clear:** Transparent glass-like effect.
   
 * **CornerRadius:** Specifies the corner rounding for the view.

 * **EnableShadowEffect:** Determines whether a shadow effect is applied behind the glass view.

In this section, we’ll explain how to apply the Liquid Glass Effect to Syncfusion Button controls, along with example code snippets.

{% tabs %}
{% highlight xaml %}

xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

	<Grid Background="#C977F8"
          Opacity="0.7"
	      HorizontalOptions="Fill"
	      VerticalOptions="Fill">
    <VerticalStackLayout Spacing="18"
	                     VerticalOptions="Center">
        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                VerticalOptions="Center"
                                EnableShadowEffect="True"
                                EffectType="Regular">
            <button:SfButton Text="Regular Glass"
                             FontSize="16"
                             Background="Transparent"
                             TextColor="Black"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>

        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                EnableShadowEffect="True"
                                VerticalOptions="Center"
                                EffectType="Regular">
            <button:SfButton Text="Tinted Glass"
                             FontSize="16"
                             Background="#FFD200"
                             TextColor="Black"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>

        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                EnableShadowEffect="True"
                                VerticalOptions="Center"
                                EffectType="Clear">
            <button:SfButton Text="Clear Glass"
                             FontSize="16"
                             Background="Transparent"
                             TextColor="White"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>
    </VerticalStackLayout>
</Grid>
	
{% endhighlight %}
{% endtabs %}

## Interactive Glass Effects

Enable glass effects to react to user interactions with adaptive blur, and lighting for an engaging UI.

{% tabs %}
{% highlight xaml %}

<Grid Background="#C977F8"
      Opacity="0.7"
	  HorizontalOptions="Fill"
	  VerticalOptions="Fill">
    <VerticalStackLayout Spacing="18"
	                     VerticalOptions="Center">
        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                VerticalOptions="Center"
                                EnableShadowEffect="True"
                                EffectType="Regular">
            <button:SfButton Text="Regular Glass"
			                 EnableLiquidGlassEffect="True"
                             FontSize="16"
                             Background="Transparent"
                             TextColor="Black"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>

        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                EnableShadowEffect="True"
                                VerticalOptions="Center"
                                EffectType="Regular">
            <button:SfButton Text="Tinted Glass"
			                 EnableLiquidGlassEffect="True"
                             FontSize="16"
                             Background="#FFD200"
                             TextColor="Black"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>

        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                EnableShadowEffect="True"
                                VerticalOptions="Center"
                                EffectType="Clear">
            <button:SfButton Text="Clear Glass"
			                 EnableLiquidGlassEffect="True"
                             FontSize="16"
                             Background="Transparent"
                             TextColor="White"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>
    </VerticalStackLayout>
</Grid>

{% endhighlight %}
{% endtabs %}

## Custom Shapes

Easily customize the `SfGlassEffectView` to achieve desired shapes like rounded rectangles, capsules, and circles by adjusting properties such as `CornerRadius`, `HeightRequest`, and `WidthRequest`.

{% tabs %}
{% highlight xaml %}

<Grid Background="#C977F8"
      Opacity="0.7"
	  HorizontalOptions="Fill"
	  VerticalOptions="Fill">
    <VerticalStackLayout Spacing="18"
	                     VerticalOptions="Center">
        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                VerticalOptions="Center"
                                EnableShadowEffect="True"
                                EffectType="Regular">
            <button:SfButton Text="Regular Glass"
			                 EnableLiquidGlassEffect="True"
                             FontSize="16"
                             Background="Transparent"
                             TextColor="Black"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>

        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                EnableShadowEffect="True"
                                VerticalOptions="Center"
                                EffectType="Regular">
            <button:SfButton Text="Tinted Glass"
			                 EnableLiquidGlassEffect="True"
                             FontSize="16"
                             Background="#FFD200"
                             TextColor="Black"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>

        <core:SfGlassEffectView HeightRequest="48"
                                WidthRequest="200"
                                CornerRadius="24"
                                EnableShadowEffect="True"
                                VerticalOptions="Center"
                                EffectType="Clear">
            <button:SfButton Text="Clear Glass"
			                 EnableLiquidGlassEffect="True"
                             FontSize="16"
                             Background="Transparent"
                             TextColor="White"
                             HorizontalOptions="Fill"
                             VerticalOptions="Centre"/>
        </core:SfGlassEffectView>
    </VerticalStackLayout>
</Grid>

{% endhighlight %}
{% endtabs %}

## Controls list

For control specific usage of the Liquid Glass Effect on individual Syncfusion® controls, including availability, and configuration details, please refer to the respective documentation.

N> View sample in GitHub. 
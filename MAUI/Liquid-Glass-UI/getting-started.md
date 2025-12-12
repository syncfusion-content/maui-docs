---
layout: post
title: Getting Started with Liquid Glass Effect UI in Syncfusion® .NET MAUI Controls
description: Get started with the Liquid Glass Effect UI in Syncfusion® .NET MAUI controls and learn how to enable and customize it.
platform: MAUI
control: General
documentation: UG
---

# Getting Started with Liquid Glass for modern UI

This section explains how to enable and customize the Liquid Glass Effect in Syncfusion® .NET MAUI controls.

For detailed information on specific Syncfusion® controls and their usage, refer to the User Guide Getting Started documentation, and ensure the control is properly configured and functioning before applying the Liquid Glass Effect.

N> This feature is supported only on .NET 10.

## Supported Platforms

* macOS 26 or higher
* iOS 26 or higher

## Liquid Glass Effect

The Liquid Glass effect adds a modern, translucent design with blur and depth, enhancing UI aesthetics without major layout changes. To apply Liquid Glass Effect to any Syncfusion® controls or custom views, use the `SfGlassEffectView` class. 

This view acts as a visual container that adds blur, translucency, and light refraction to its content, creating a realistic glass-like appearance. In this section, we will demonstrate how to use SfGlassEffectView with a Syncfusion Button to achieve a visually appealing glass effect.

The `SfGlassEffectView` class contains the following properties:

### EffectType

Specifies the type of glass effect to apply:

* **Regular:** Creates a blurred, frosted glass appearance.
* **Clear:** Creates a transparent, glass-like appearance

{% tabs %}
{% highlight xaml %}

xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

<Grid Background="#C977F8"
	  Opacity="0.7"
	  HorizontalOptions="Fill"
	  VerticalOptions="Fill">
	<core:SfGlassEffectView HeightRequest="48"
							WidthRequest="200"
							CornerRadius="24"
							VerticalOptions="Center"
							EffectType="Clear">
		<button:SfButton Text="Clear Glass"
						 FontSize="16"
						 Background="Transparent"
						 TextColor="Black"
						 HorizontalOptions="Fill"
						 VerticalOptions="Centre"/>
		</core:SfGlassEffectView>
</Grid>

	
{% endhighlight %}
{% endtabs %}
   
### CornerRadius

Specifies the corner rounding for the view, allowing customization of shapes such as rounded rectangles or capsules.

{% tabs %}
{% highlight xaml %}

<Grid Background="#C977F8"
	  Opacity="0.7"
	  HorizontalOptions="Fill"
	  VerticalOptions="Fill">
	<core:SfGlassEffectView HeightRequest="48"
							WidthRequest="200"
							CornerRadius="24"
							VerticalOptions="Center">
		<button:SfButton Text="Clear Glass"
						 FontSize="16"
						 Background="Transparent"
						 TextColor="Black"
						 HorizontalOptions="Fill"
						 VerticalOptions="Centre"/>
		</core:SfGlassEffectView>
</Grid>
	
{% endhighlight %}
{% endtabs %}

### EnableShadowEffect

Determines whether a shadow is applied behind the glass view to add depth and visual contrast.

{% tabs %}
{% highlight xaml %}

<Grid Background="#C977F8"
	  Opacity="0.7"
	  HorizontalOptions="Fill"
	  VerticalOptions="Fill">
	<core:SfGlassEffectView HeightRequest="48"
							WidthRequest="200"
							CornerRadius="24"
							VerticalOptions="Center"
							EnableShadowEffect="True">
		<button:SfButton Text="Regular Glass"
						 FontSize="16"
						 Background="Transparent"
						 TextColor="Black"
						 HorizontalOptions="Fill"
						 VerticalOptions="Centre"/>
		</core:SfGlassEffectView>
</Grid>
	
{% endhighlight %}
{% endtabs %}

### Background / BackgroundColor

Applies a background tint color to the glass view, enabling modern UI styling and improved readability.

<Grid Background="#C977F8"
	  Opacity="0.7"
	  HorizontalOptions="Fill"
	  VerticalOptions="Fill">
	<core:SfGlassEffectView HeightRequest="48"
							WidthRequest="200"
							CornerRadius="24"
							VerticalOptions="Center"
							Background="#FFD200">
		<button:SfButton Text="Regular Glass"
						 FontSize="16"
						 Background="Transparent"
						 TextColor="Black"
						 HorizontalOptions="Fill"
						 VerticalOptions="Centre"/>
		</core:SfGlassEffectView>
</Grid>

## Interactive Glass Effects

Enable glass effects to respond to user interactions with adaptive blur and dynamic lighting for an engaging UI. To achieve this, set the `EnableLiquidGlassEffect` property to `true` on the button control, which activates interaction-based visual effects.

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
                                EffectType="Regular"
                                Background="#FFD200">
            <button:SfButton Text="Tinted Glass"
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
						 HorizontalOptions="Center"
						 VerticalOptions="Center">
		<core:SfGlassEffectView HeightRequest="48"
								WidthRequest="180"
								CornerRadius="12"
								VerticalOptions="Center"
								EnableShadowEffect="True"
								Background="Transparent"
								EffectType="Regular">
			<button:SfButton Text="Rounded rectangle"
							 FontSize="16"
							 Background="Transparent"
							 TextColor="Black"
							 HorizontalOptions="Fill"
							 VerticalOptions="Centre"/>
		</core:SfGlassEffectView>

		<core:SfGlassEffectView HeightRequest="48"
								WidthRequest="100"
								CornerRadius="24"
								VerticalOptions="Center"
								EnableShadowEffect="True"
								Background="Transparent"
								EffectType="Regular">
			<button:SfButton Text="Capsule"
							 FontSize="16"
							 Background="Transparent"
							 TextColor="Black"
							 HorizontalOptions="Fill"
							 VerticalOptions="Centre"/>
		</core:SfGlassEffectView>

		<core:SfGlassEffectView HeightRequest="48"
								WidthRequest="48"
								CornerRadius="24"
								VerticalOptions="Center"
								EnableShadowEffect="True"
								Background="Transparent"
								EffectType="Clear">
			<button:SfButton Background="Transparent">
				<button:SfButton.Content>
					<DataTemplate>
						<Grid HorizontalOptions="Center" VerticalOptions="Center">
							<Grid Padding="5,0,5,0"  Grid.Column="1" >
								<Label Text="&#xe78a;"
									   FontFamily="MauiSampleFontIcon"
									   HorizontalTextAlignment="Center"
									   VerticalOptions="Center"
									   VerticalTextAlignment="Center"
									   HorizontalOptions="Start"
									   FontSize="16"
									   TextColor="{AppThemeBinding Light=Black, Dark=White}">
								</Label>
							</Grid>
						</Grid>
					</DataTemplate>
				</button:SfButton.Content>
			</button:SfButton>
		</core:SfGlassEffectView>
	</VerticalStackLayout>
</Grid>

{% endhighlight %}
{% endtabs %}

## Controls list

For control specific usage of the Liquid Glass Effect on individual Syncfusion® controls, including availability, and configuration details, please refer to the respective documentation.

N> View sample in GitHub.
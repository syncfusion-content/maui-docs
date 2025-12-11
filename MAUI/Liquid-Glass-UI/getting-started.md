---
layout: post
title: Getting Started with Liquid Glass Effect UI in Syncfusion® MAUI Controls
description: Learn how to getting started with the Liquid Glass Effect UI in Syncfusion® MAUI Controls
platform: MAUI
control: General
documentation: UG
---

# Getting Started with Liquid Glass for modern UI

The Liquid Glass effect adds a modern, translucent design with blur and depth, enhancing UI aesthetics without major layout changes. This section explains the essential steps to configure the Liquid Glass Effect and apply it to both the Syncfusion® .NET MAUI controls and custom views.

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0).
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-10.0&viewFallbackFrom=net-maui-8.0&tabs=visual-studio-code)


N> Supported only on .NET 10.

### Supported Platforms

* macOS 26 or higher
* iOS 26 or higher

## Step 1: Create a New MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion® MAUI Buttons NuGet Package

1. Install the required NuGet packages via Manage NuGet Packages.
2. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the Handler 

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion® controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion® core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

using Syncfusion.Maui.Core.Hosting;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
	    builder
		.ConfigureSyncfusionCore()
		.UseMauiApp<App>()
		.ConfigureFonts(fonts =>
		{
		    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
		    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		});

	    return builder.Build();
	}
}

{% endhighlight %}
{% endtabs %}

## Apply Liquid Glass Effect

To apply Liquid Glass Effect to any Syncfusion® controls or custom views, use the `SfGlassEffectView` class. This view acts as a visual container that adds blur, translucency, and light refraction to its content, creating a realistic glass-like appearance.

The `SfGlassEffectView` class contains the following properties:

 * **EffectType:** Defines the glass effect style, where Clear gives a subtle blur with minimal tint and Regular applies stronger blur with adaptive tinting for a pronounced look.

 * **CornerRadius:** Allows you to round the corners of the glass container, giving a softer and more polished appearance.

 * **EnableShadowEffect:** Adds a subtle shadow behind the glass view, enhancing depth and realism.

{% tabs %}
{% highlight xaml %}

xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

<VerticalStackLayout Spacing="18"
					 HorizontalOptions="Center"
					 VerticalOptions="Center">
	<core:SfGlassEffectView HeightRequest="48"
							WidthRequest="200"
							CornerRadius="24"
							EnableShadowEffect="True"
							EffectType="Regular">
		<button:SfButton Text="Regular Glass"
						 FontSize="16"
						 Background="Transparent"
						 TextColor="Black"
						 HorizontalOptions="Fill"
						 VerticalOptions="Fill"/>
	</core:SfGlassEffectView>

	<core:SfGlassEffectView HeightRequest="48"
							WidthRequest="200"
							CornerRadius="24"
							EnableShadowEffect="True"
							EffectType="Regular">
		<button:SfButton Text="Tinted Glass"
						 FontSize="16"
						 Background="#FFD200"
						 TextColor="Black"
						 HorizontalOptions="Fill"
						 VerticalOptions="Fill"/>
	</core:SfGlassEffectView>

	<core:SfGlassEffectView HeightRequest="48"
							WidthRequest="200"
							CornerRadius="24"
							EnableShadowEffect="True"
							EffectType="Clear">
		<button:SfButton Text="Clear Glass"
						 FontSize="16"
						 Background="Transparent"
						 TextColor="White"
						 HorizontalOptions="Fill"
						 VerticalOptions="Fill"/>
	</core:SfGlassEffectView>
</VerticalStackLayout>
	
{% endhighlight %}
{% endtabs %}

## Interactive Glass Effects

Enable glass effects to react to user interactions with adaptive blur, and lighting for an engaging UI.

## Custom Shapes

Easily customize the `SfGlassEffectView` to achieve desired shapes like rounded rectangles, capsules, and circles by adjusting properties such as `CornerRadius`, `HeightRequest`, and `WidthRequest`.

## Controls list

For control specific usage of the Liquid Glass Effect on individual Syncfusion® controls, including availability, and configuration details, please refer to the respective documentation.

N> View sample in GitHub. 
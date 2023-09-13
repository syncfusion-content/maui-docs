---
layout: post
title: Getting Started with .NET MAUI Button | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Button (SfButton) control, its elements and more.
platform: MAUI
control: SfButton
documentation: ug
---

# Getting Started with .NET MAUI Button

This section explains the steps required to work with the `.NET MAUI Button` control.

## Creating an application with .NET MAUI Button

This section explains the steps required to work with the `SfButton` control for .NET MAUI.

## Adding a .NET MAUI Button reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add `.NET MAUI Button` to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Buttons`, and install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ButtonSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }      
    }
}   

{% endhighlight %} 

## Adding the .NET MAUI Button control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

	xmlns:button="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Buttons;

{% endhighlight %}
{% endtabs %}

## Initialize Button

Now, add the `SfButton` control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

	<syncfusion:SfButton x:Name="button" />
	
{% endhighlight %}

{% highlight C# %}

        SfButton button = new SfButton();

{% endhighlight %}

{% endtabs %}

## Button icon

The button icon can be defined using the `ImageSource` and `ShowIcon` properties of `SfButton`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="SfButton" Text="Button" ShowIcon="True" ImageSource="button_Heart.png"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.ImageSource = "button_Heart.png";
button.ShowIcon = true;

{% endhighlight %}
{% endtabs %}

![SfButton with button icon](images/getting-started/ButtonWithIcon.png)

## Button background image

The button background image can be defined using the `BackgroundImageSource` property of `SfButton`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="SfButton" Text="Button" BackgroundImageSource="button_background.png" CornerRadius="20" WidthRequest="100"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.WidthRequest = 100;
button.BackgroundImageSource = "button_background.png";
button.CornerRadius = new Thickness(20);

{% endhighlight %}
{% endtabs %}

![Button with background image](images/getting-started/ButtonWithBackgroundImage.png)

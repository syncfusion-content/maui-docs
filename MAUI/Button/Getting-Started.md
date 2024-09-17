---
layout: post
title: Getting Started with .NET MAUI Button | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI Button (SfButton) control, its elements and more.
platform: MAUI
control: SfButton
documentation: ug
---

# Getting Started with .NET MAUI Button
This section guides you through setting up and configuring a [Button](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) in your .NET MAUI application. Follow the steps below to add a basic Button to your project.

To get start quickly with our .NET MAUI Button, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=KTGkYShi1YE" %}

## Prerequisites

Before proceeding, ensure the following are in place:

Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.

Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://github.com/dotnet/maui/wiki/VS-Code-setup).

## Step 1: Create a New MAUI Project

### Visual Studio
1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

### Visual Studio Code
1. Open the command palette by pressing `Ctrl+Shift+P`` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press enter.
Then choose **Create project**

## Step 2: Install the Syncfusion MAUI Buttons NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.



## Step 3: Register the Handler 

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion core.

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

## Step 4: Add a Basic Button control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

	xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Buttons;

{% endhighlight %}
{% endtabs %}

## Initialize Button

Now, add the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

<buttons:SfButton x:Name="button" />
	
{% endhighlight %}

{% highlight C# %}

SfButton button = new SfButton();

{% endhighlight %}

{% endtabs %}

## Button icon

The button icon can be defined using the [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSource) and [ShowIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ShowIcon) properties of [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

N> Ensure that the images mentioned in the code snippets are located in the **Resources** folder of your sample project.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="SfButton" 
                    Text="Button"
                    TextColor="White" 
                    ShowIcon="True" 
                    ImageSource="button_Heart.png"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.TextColor = Colors.White;
button.ImageSource = "button_Heart.png";
button.ShowIcon = true;

{% endhighlight %}
{% endtabs %}

![SfButton with button icon](images/getting-started/ButtonWithIcon.png)


## Button background image

The button background image can be defined using the [BackgroundImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_BackgroundImageSource) property of [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html).

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="SfButton" 
                    Text="Nature"
                    FontAttributes="Bold" 
                    BackgroundImageSource="button_background.png" 
                    CornerRadius="10" 
                    WidthRequest="150"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Nature";
button.FontAttributes = FontAttributes.Bold;
button.BackgroundImageSource = "button_background.png";
button.CornerRadius = 10;
button.WidthRequest = 150;

{% endhighlight %}
{% endtabs %}

![Button with background image](images/getting-started/ButtonWithBackgroundImage.png)

Find the complete getting started sample of the .NET MAUI Button from this [link.](https://github.com/SyncfusionExamples/maui-button-samples)

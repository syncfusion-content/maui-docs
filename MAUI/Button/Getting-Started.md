---
layout: post
title: Getting Started with .NET MAUI Button | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI Button (SfButton) control, its elements and more.
platform: MAUI
control: SfButton
documentation: ug
---

> **Notice**: After **Volume 1 2025 (Mid of March 2025)**, updates, bug fixes, and feature enhancements for this control will no longer be available in the Syncfusion<sup>®</sup> package. Please switch to the **Syncfusion<sup>®</sup> Toolkit for .NET MAUI** for continued support. For a smooth transition refer this [migration document](https://help.syncfusion.com/maui-toolkit/migration).

# Getting Started with .NET MAUI Button

This section guides you through setting up and configuring a [Button](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) in your .NET MAUI application. Follow the steps below to add a basic Button to your project.

To quickly get started with the .NET MAUI Button, watch this video.

{% youtube "https://www.youtube.com/watch?v=KTGkYShi1YE" %}


{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.8 or later).

## Step 1: Create a New MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Buttons NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the Handler 

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion<sup>®</sup> core.

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

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Buttons NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Buttons` to install the Syncfusion<sup>®</sup> .NET MAUI Buttons package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the Handler 

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion<sup>®</sup> core.

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

{% endtabcontent %}
{% endtabcontents %}

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
                    WidthRequest="150"
                    HorizontalTextAlignment="Justify"
                    ShowIcon="True" 
                    ImageSource="button_Heart.png"/>

{% endhighlight %}
{% highlight c# %}

SfButton button = new SfButton();
button.Text = "Button";
button.TextColor = Colors.White;
button.WidthRequest = 150;
button.HorizontalTextAlignment = TextAlignment.Start,  
button.ImageSource = "button_Heart.png";
button.ShowIcon = true;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Button with button icon.](images/getting-started/net-maui-button-with-icon.png)


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

![.NET MAUI Button with background image.](images/getting-started/net-maui-button-with-background-image.png)

Find the complete getting started sample of the .NET MAUI Button from this [link.](https://github.com/SyncfusionExamples/maui-button-samples)

N> You can refer to our [.NET MAUI Button](https://www.syncfusion.com/maui-controls/maui-button) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Button Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Buttons) that shows you how to render the Button in .NET MAUI.

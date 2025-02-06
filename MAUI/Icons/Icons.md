---
layout: post
title: Icons in .NET MAUI - Syncfusion®
description: Learn how to use and integrate the icon from the MauiMaterialAssets.ttf file in Syncfusion® .NET MAUI components.
platform: maui
component: Common
documentation: ug
---

# .NET MAUI Icons

The Syncfusion<sup style="font-size:70%">&reg;</sup> .NET MAUI contains a comprehensive set of icons bundled in the `MauiMaterialAssets.ttf` file. These icons are readily available for use in .NET MAUI applications once the Syncfusion<sup style="font-size:70%">&reg;</sup> MAUI package is installed.

## Getting Started with Icon Integration

To start using the icons, first ensure that the font is registered in your application. Here is a walkthrough on setting up the `MauiMaterialAssets.ttf`:

### Step 1: Install the Syncfusion<sup style="font-size:70%">&reg;</sup> MAUI Package

Once installed, the `MauiMaterialAssets.ttf` will be added to your project's font folder.

### Step 2: Register the font**

Modify your `MauiProgram.cs` to register the font icon. Here is an example:

    {% tabs %}
    {% highlight c# %}
        //...existing code...
        public static class MauiProgram
        {
            public static MauiApp CreateMauiApp()
            {
                var builder = MauiApp.CreateBuilder();
                //...existing code...
                builder.ConfigureFonts(fonts =>
                {
                    //...existing code...
                    fonts.AddFont("MauiMaterialAssets.ttf", "MaterialAssets");
                });
                return builder.Build();
            }
        }
    {% endhighlight %}
    {% endtabs %}

### Step 3: Using icons in the project

To use icons in your MAUI project, simply refer to them using the designated font family. Below is an example of how you might integrate an icon into a Label.

    {% tabs %}
    {% highlight xaml %}

        <Label Text="&#xE70F;"
               FontFamily="MaterialAssets"
               FontSize="24"
               TextColor="Black"/>
            
    {% endhighlight %}
    {% highlight c# %}

        Label label = new Label
        {
            Text = "\ue70f", // Unicode character representation
            FontFamily = "MaterialAssets",
            FontSize = 24,
            TextColor = Colors.Black 
        };

    {% endhighlight %}
    {% endtabs %}

The following image illustrates the result of the above code.

![Delete Icon](images/delete_icon.png)

## Icons List

The Maui Material Assets icons are available in the `MauiMaterialAssets.ttf` file:

<iframe src="fonts/demo.html" style="height:1000px;width:100%;"></iframe>

This list represents the wide variety of icons available. These icons can be adapted to suit the UI needs of any application, providing consistent and visually pleasing interface elements.

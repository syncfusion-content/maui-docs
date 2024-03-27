---
layout: post
title: Getting Started with .NET MAUI NumericEntry | Syncfusion
description: Learn how to get started with Syncfusion .NET MAUI NumericEntry (SfNumericEntry) control, its elements, and more in here.
platform: MAUI
control: SfNumericEntry
documentation: ug
---

# Getting Started with .NET MAUI NumericEntry

This section explains the steps required to add the [.NET MAUI NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control in the MAUI application and utilize the various functions provided.

To get start quickly with our .NET MAUI Numeric Entry, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=BHw8UpoUmoM&ab_channel=Syncfusion%2CInc" %}

## Creating an application with .NET MAUI NumericEntry

This section explains the steps required to work with the [SfNumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control for .NET MAUI.

## Adding a .NET MAUI Numeric Entry reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [.NET MAUI Numeric Entry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs), and install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace MaskedEntrySample
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

## Adding the .NET MAUI Numeric Entry control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

	<xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"/>

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Inputs;

{% endhighlight %}
{% endtabs %}

## Initialize Numeric Entry

Now, add the [SfNumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control with a required optimal name using the included namespace.

{% tabs %}
{% highlight xaml %}

	<editors:SfNumericEntry x:Name="numericEntry" />
	
{% endhighlight %}
{% highlight C# %}

    SfNumericEntry sfNumericEntry = new SfNumericEntry();   

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry Application](GettingStarted_images/gettingStarted_img.png)

## Editing the value

By default, the [NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control allows you to enter numeric input and restricts the alphabetic input. Once the `Enter` key is pressed or control focus is lost, the value of the `NumericEntry` control is validated and updated based on the format applied.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center" 
                        VerticalOptions="Center" 
                        CustomFormat="0.000" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.CustomFormat = "0.000";

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry value editing](GettingStarted_images/editing_value.gif)

## Change number format

You can change the format in which the value should be displayed using the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) property. By default, the value of the `CustomFormat` property is **null**.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                        VerticalOptions="Center"
                        Value="12.5" 
                        CustomFormat="C2" />

{% endhighlight %}
{% highlight C# %}

SfNumberBox sfNumberBox = new SfNumberBox();
sfNumberBox.HorizontalOptions = LayoutOptions.Center;
sfNumberBox.VerticalOptions = LayoutOptions.Center;
sfNumberBox.Value = 12.5;
sfNumberBox.CustomFormat = "C2";

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry value editing](GettingStarted_images/custom_format.png)

## Accept null value

By default, the [NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control allows a **null** value. A null value is assigned when the user clicks the clear button or clears the input. You can disable this by setting the value of the [AllowNull](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_AllowNull) property as **false**. When the value of the `AllowNull` property is set to **false**, and the input is cleared, the `NumericEntry` control returns it to **0**.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                        VerticalOptions="Center"
                        Value="12315"
                        AllowNull="False" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.Value=12315;
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.AllowNull = false;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry prevent empty textbox](GettingStarted_images/allowNull.gif)
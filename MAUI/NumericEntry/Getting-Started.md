---
layout: post
title: Getting Started with .NET MAUI NumericEntry | Syncfusion
description: Learn how to get started with Syncfusion .NET MAUI NumericEntry (SfNumericEntry) control, its elements, and more in here.
platform: MAUI
control: SfNumericEntry
documentation: ug
---

# Getting Started with .NET MAUI NumericEntry

This section explains the steps required to add the `.NET MAUI NumericEntry` control in the MAUI application and utilize the various functions provided.

## Structure of NumericEntry control

![.NET MAUI NumericEntry Structure](Overview_images/overview_img.png)

## Creating an application with .NET MAUI NumericEntry

In this walkthrough, you will create a .NET MAUI application that contains the `NumericEntry` control.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

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

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

	<xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"/>

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Inputs;

{% endhighlight %}
{% endtabs %}

## Initialize Numeric Entry

Now, add the `SfNumericEntry` control with a required optimal name using the included namespace.

{% tabs %}
{% highlight xaml %}

	<syncfusion:SfNumericEntry x:Name="numericEntry" />
	
{% endhighlight %}
{% highlight C# %}

        numericEntry = new SfNumericEntry();

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry Application](GettingStarted_images/gettingStarted_img.png)

## Editing the value

By default, the `NumericEntry` control allows you to enter numeric input and restricts the alphabetic input. Once `Enter` key is pressed or control focus is lost, the value of the `NumericEntry` control is validated and updated based on the format applied.

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

You can change the format in which the value should be displayed using the `CustomFormat` property . By default, value of the `CustomFormat` property is **null**. 

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

By default, `NumericEntry` control allows **null** value. A null value is assigned when the user clicks the clear button or clears the input. You can disable this by setting the value of `AllowNull` property as **false**. When value of the `AllowNull` property is set to **false** and the input is cleared, the `NumericEntry` control returns it to **0**. 

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                     VerticalOptions="Center"
                     Value="12315"
                     AllowNull="False" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.AllowNull = false;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry prevent empty textbox](GettingStarted_images/allowNull.gif)

## Setting Placeholder Text

You can prompt the user with any information by using the `PlaceholderText` property. Watermark text will be displayed only when the value of the `AllowNull` property is **true** and the value of `NumericEntry` control is **null**. The default value of `Placeholder` property is **string.Empty** (No string will be displayed).

{% tabs %}
{% highlight xaml %}

<editors:SfNumberBox HorizontalOptions="Center" 
                     VerticalOptions="Center" 
                     Placeholder="Enter input here..." />

{% endhighlight %}
{% highlight C# %}

SfNumberBox SfNumberBox= new SfNumberBox();
SfNumberBox.Placeholder = "Enter input here...";
sfNumberBox.HorizontalOptions = LayoutOptions.Center;
sfNumberBox.VerticalOptions = LayoutOptions.Center;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry Placeholder Text](GettingStarted_images/placeholder_text.png)

## Clear button visibility 

The `ShowClearButton` property is used to show or hide the clear button in `NumericEntry`. By default, visibility of the clear button is enabled.

N> The clear button appears only when the text box is focused and the `IsEditable` property value is set to **true**.
{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry x:Name="numericEntry"  
            WidthRequest="300"                   
            ShowClearButton="True" 
            IsEditable="True" 
            Value="10"/>


{% endhighlight %}
{% highlight C# %}

SfNumericEntry SfNumericEntry = new SfNumericEntry();
SfNumericEntry.ShowClearButton = true;
SfNumericEntry.IsEditable = true; 


{% endhighlight %}
{% endtabs %}

If IsEditable is true

![.NET MAUI NumericEntry with Clear Button](GettingStarted_images/clearbutton_visible.png)

If IsEditable is false

![.NET MAUI NumericEntry without Clear Button](GettingStarted_images/clearbutton_collapsed.png)


## Value changed notification

The `ValueChanged` event is triggered, when the `Value` property of `NumericEntry` control is changed. The value will not be changed when the user enters the input. The value of the `NumericEntry` control will be changed after validation is performed on the `Enter` keypress or when the focus is lost in the control. The `ValueChanged` contains the following properties.

 * `NewValue` - Contains the new input value.
 * `OldValue` - Contains the previous input value.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                     VerticalOptions="Center" 
                     x:Name="sfNumericEntry"
                     ValueChanged="sfNumericEntry_ValueChanged" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.ValueChanged += sfNumericEntry_ValueChanged;

{% endhighlight %}
{% endtabs %}

You can handle the event as follows.

{% tabs %}
{% highlight C# %}

private void sfNumericEntry_ValueChanged(object sender, ValueChangedEventArgs e)
{
    var oldValue = e.OldValue;
    var newValue = e.NewValue;
}

{% endhighlight %}
{% endtabs %}
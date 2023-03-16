---
layout: post
title: Getting Started with .NET MAUI Masked Entry control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Masked Entry (SfMaskedEntry) control, its elements, and more.
platform: maui
control: MaskedEntry
documentation: ug 
keywords: mask, SfMaskedEntry, maskedentry
---

# Getting Started with MAUI Masked Entry (SfMaskedEntry)

This section explains you the steps required to configure a `SfMaskedEntry` control in a real-time scenario and provides a walk-through on some of the customization features available in `SfMaskedEntry` control.

## Creating an application using the .NET MAUI Masked Entry

This section explains the steps required to work with the `SfMaskedEntry` control for .NET MAUI.

## Adding a .NET MAUI Masked Entry reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [.NET MAUI Masked Entry] to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and then install it.

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

## Adding the .NET MAUI Masked Entry control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace, as shown in the following code sample:

{% tabs %}

{% highlight xaml %}

	<xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"/>

{% endhighlight %}

{% highlight c# %}

	using Syncfusion.Maui.Inputs;

{% endhighlight %}

{% endtabs %}

## Initialize Masked Entry

Now, add the `SfMaskedEntry` control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

	<syncfusion:SfMaskedEntry x:Name="maskedentry" />
	
{% endhighlight %}

{% highlight C# %}

        maskedEntry = new SfMaskedEntry();

{% endhighlight %}

{% endtabs %}
 ## Initialize MaskedEntry control using simple mask

{% tabs %}
{% highlight xaml %}

        <syncfusion:SfMaskedEntry WidthRequest="200"
                                  MaskType="Simple"
                                  Mask="00/00/0000" />

{% endhighlight %}
{% highlight C# %}

        maskedEntry = new SfMaskedEntry();
        maskedEntry.Width = "200";
        maskedEntry.MaskType = MaskedTextBoxMaskType.Simple;
        maskedEntry.Mask = "00/00/0000";

{% endhighlight %}
{% endtabs %}

![Simple mask in MAUI MaskedEntry](MaskedEntry_Images/maui_simple_mask.png)

## Initialize MaskedEntry control using RegEx mask

{% tabs %}
{% highlight xaml %}

        <syncfusion:SfMaskedEntry WidthRequest="200"
                                  MaskType="RegEx"
                                  Mask="[A-Za-z0-9._%-]+@[A-Za-z0-9]+\.[A-Za-z]{2,3}" />

{% endhighlight %}
{% highlight C# %}

        maskedEntry = new SfMaskedEntry();
        maskedEntry.Width = "200";
        maskedEntry.MaskType = MaskedEntryMaskType.RegEx;
        maskedEntry.Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+\\.[A-Za-z]{2,3}";


{% endhighlight %}
{% endtabs %}

![RegEx mask in MAUI MaskedEntry](MaskedEntry_Images/maui_regex_mask.png)

## Setting the prompt character

Every single mask displays a prompt character ('_') in the absence of your input. You can customize this prompt character by using the `PromptChar` property.

{% tabs %}
{% highlight C# %}

        maskedEntry = new SfMaskedEntry();
        maskedEntry.Width = "200";
        maskedEntry.MaskType = MaskedEntryMaskType.Simple;
        maskedEntry.Mask = "00/00/0000";
        maskedEntry.PromptChar = '#';


{% endhighlight %}
{% endtabs %}

![WinUI MaskedEntry prompt character](MaskedEntry_Images/maui_masked_entry_prompt_char.png)

## Setting the value

The `Value` property is used to set the input value for MaskedEntry control.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="00/00/0000"
                          Value="12/02/2022" />

{% endhighlight %}
{% highlight C# %}

        maskedEntry = new SfMaskedEntry();
        maskedEntry.Width = "200";
        maskedEntry.MaskType = MaskedEntryMaskType.Simple;
        maskedEntry.Mask = "00/00/0000";
        maskedEntry.Value = "12/02/2022";


{% endhighlight %}
{% endtabs %}

![WinUI MaskedEntry value](MaskedEntry_Images/maui_masked_entry_value.png)




---
layout: post
title: Getting Started with .NET MAUI Masked Entry control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI Masked Entry (SfMaskedEntry) control, its elements, and more.
platform: maui
control: MaskedEntry
documentation: ug 
keywords: mask, SfMaskedEntry, maskedentry
---

# Getting Started with .NET MAUI Masked Entry (SfMaskedEntry)

This section explains the steps required to configure a [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html)  control in a real-time scenario and provides a walk-through on some of the customization features available in the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control.

## Creating an application using the .NET MAUI Masked Entry

This section explains the steps required to work with the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control for .NET MAUI.

## Adding a .NET MAUI Masked Entry reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add `.NET MAUI Masked Entry` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs), and install it.

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

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

	<xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"/>

{% endhighlight %}

{% highlight c# %}

	using Syncfusion.Maui.Inputs;

{% endhighlight %}

{% endtabs %}

## Initialize Masked Entry

Now, add the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) control with a required optimal name using the included namespace.

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
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";

{% endhighlight %}
{% endtabs %}

![Simple mask in .NET MAUI Masked Entry.](maskedentry_images/net-maui-masked-entry-simple-mask.png)

## Initialize MaskedEntry control using RegEx mask

{% tabs %}
{% highlight xaml %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="RegEx"
                          Mask="[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}" />

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.RegEx;
maskedEntry.Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}";


{% endhighlight %}
{% endtabs %}

![RegEx mask in .NET MAUI Masked Entry.](maskedentry_images/net-maui-masked-entry-regex-mask.png)

## Setting the prompt character

Every single mask displays a prompt character ('_') in the absence of your input. Customize this prompt character by using the [PromptChar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PromptChar) property.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="00/00/0000"
                          PromptChar="#" />
                          
{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
maskedEntry.PromptChar = '#';


{% endhighlight %}
{% endtabs %}

![.NET MAUI Masked Entry prompt character.](maskedentry_images/net-maui-masked-entry-prompt-char.png)

## Setting the value

The [Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Value) property sets the input value for the MaskedEntry control.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="00/00/0000"
                          Value="12/02/2022" />

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
maskedEntry.Value = "12/02/2022";


{% endhighlight %}
{% endtabs %}

![.NET MAUI Masked Entry value.](maskedentry_images/net-maui-masked-entry-value.png)

N> 
Get the complete getting started sample from the [GitHub](https://github.com/SyncfusionExamples/maui-maskedentry-samples) link.

N> You can refer to our [.NET MAUI Masked Entry](https://www.syncfusion.com/maui-controls/maui-masked-entry) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Masked Entry Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Inputs/SampleBrowser.Maui.Inputs/Samples/MaskedEntry) that shows you how to render the Masked Entry in .NET MAUI.



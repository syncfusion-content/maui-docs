---
layout: post
title: Getting Started with .NET MAUI Switch | Syncfusion
description: Learn here about getting started with the Syncfusion .NET MAUI Switch (SfSwitch) control, its elements, and more.
platform: .NET MAUI
control: SfSwitch
documentation: ug
---

# Getting Started with .NET MAUI Switch (SfSwitch)

This section explains the steps to configure the .NET MAUI Switch control in a real-time scenario and provides a walk-through on some of the customization features available in the control.

## Adding a .NET MAUI Switch reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add `.NET MAUI Switch` to your project, open the NuGet package manager in Visual Studio, search for [`Syncfusion.Maui.Buttons`](https://www.nuget.org/packages/Syncfusion.Maui.Buttons), and install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace SwitchSample
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

## Adding the .NET MAUI Switch control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}
{% highlight xaml %}

	xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

{% endhighlight %}
{% highlight c# %}

	using Syncfusion.Maui.Buttons;

{% endhighlight %}
{% endtabs %}

## Initialize Switch

Now, add the `SfSwitch` control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch />
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![SfSwitch](images/getting-started/SfSwitch.png)

## Performing an action based on state

You can switch between the states. When the state is changed the `StateChanging` and `StateChanged` event will be triggered where you can perform an action based on the current state. The `StateChanging` event allows you to cancel moving to a new state.

The following code example displays a message box when switched to off state when work is completed.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch StateChanged="SfSwitch_StateChanged"/>
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanged+= SfSwitch_StateChanged;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
private void SfSwitch_StateChanged(object sender, SwitchStateChangedEventArgs e)
{
     DisplayAlert("Message", "SUCCESS", "OK");
}

{% endhighlight %}

{% endtabs %}

N> Find the complete getting started sample of the .NET MAUI Switch from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-SfSwitch)
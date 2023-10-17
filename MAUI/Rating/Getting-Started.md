---

layout: post
title: Getting Started with .NET MAUI Rating control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Rating (SfRating) control, its elements and more.
platform: maui
control: Rating
documentation: ug

---

# Getting Started with .NET MAUI Rating (SfRating)

This section explains how to configure a [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control in a real-time scenario and also provides a walk-through on some of the customization features available in [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control.

To get start quickly with our .NET MAUI Rating, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=yEJzdjPNjBs" %}

## Adding a .NET MAUI Rating reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [.NET MAUI Rating] to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and then install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace RatingSample
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

## Adding the .NET MAUI Rating control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace, as shown in the following code sample:

{% tabs %}

{% highlight xaml %}

	<xmlns:rating="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"/>

{% endhighlight %}

{% highlight c# %}

	using Syncfusion.Maui.Inputs;

{% endhighlight %}

{% endtabs %}

## Initialize Rating

Now, add the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    this.Content = rating;
} 

{% endhighlight %}

{% endtabs %}

## Set Number of Rating Items

The number of rating items to be displayed can be customized in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. Users can create a rating application using 5 items as follows. The [`ItemCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount) property is used to define the number of rating items.

N> The default value of [`ItemCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount) is 5.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating ItemCount="5" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.ItemCount = 5;
}

{% endhighlight %}

{% endtabs %}

## Set Value

The display value can be set in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control, which is selected among the items. The following code example shows the display value of three with five rating items. The [`Value`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Value) property is used to set display value.

N> The default value of this property is 0.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating Value="3" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.Value = 3;
}

{% endhighlight %}

{% endtabs %}

## Precision

The [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control provides an option to rate the items in full, half, and exact values. This can be set using the [`Precision`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Precision) property. By default, the precision mode is [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard).

{% tabs %}

{% highlight xaml %}

	<rating:SfRating Precision="Standard" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.Precision = Precision.Standard;
}

{% endhighlight%}

{% endtabs %}

![SfRating Getting Started ](images/getting-started.png)

The complete Getting Started sample is available in this [link.](https://github.com/SyncfusionExamples/maui-rating-samples)

N> You can refer to our [.NET MAUI Rating](https://www.syncfusion.com/maui-controls/maui-rating) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Rating Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Inputs/SampleBrowser.Maui.Inputs/Samples/Rating) that shows you how to render the Rating in .NET MAUI.

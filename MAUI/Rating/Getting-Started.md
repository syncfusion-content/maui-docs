---

layout: post
title: Getting Started with .NET MAUI Rating control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Rating (SfRating) control, its elements and more.
platform: maui
control: Rating
documentation: ug

---

# Getting Started with .NET MAUI Rating (SfRating)

This section explains how to configure a [`SfRating`] control in a real-time scenario and also provides a walk-through on some of the customization features available in [`SfRating`] control.

## Adding a .NET MAUI Rating reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [.NET MAUI Rating] to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and then install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 7 18 19" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.ListView.Hosting;

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
            .ConfigureSyncfusionListView()
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

Now, add the [`SfRating`] control with a required optimal name using the included namespace.

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

The number of rating items to be displayed can be customized in the [`SfRating`] control. Users can create a rating application using 5 items as follows. The [`ItemCount`] property is used to define the number of rating items.

N> The default value of [`ItemCount`] is 5.

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

The display value can be set in the [`SfRating`] control, which is selected among the items. The following code example shows the display value of three with five rating items. The [`Value`] property is used to set display value.

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

The [`SfRating`] control provides an option to rate the items in full, half, and exact values. This can be set using the [`Precision`] property. By default, the precision mode is [`Standard`].

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

The complete Getting Started sample is available in this [link].

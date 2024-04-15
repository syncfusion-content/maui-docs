---
layout: post
title: About .NET MAUI Shimmer control | Syncfusion
description: Learn here about the getting started with Syncfusion .NET MAUI Shimmer (SfShimmer) control, its elements and more.
platform: maui
control: SfShimmer
documentation: ug
---

# Getting started of .NET MAUI Shimmer (SfShimmer)

This section explains how to add the Shimmer control.

To get start quickly with our .NET MAUI Shimmer, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=NGGQhUA9Bu0"%}

## Creating an application using the .NET MAUI Shimmer

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfShimmer to your project, open the NuGet package manager in Visual Studio, and search for the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core), and then install it.
3. To initialize the control, import the control namespace [Syncfusion.Maui.Shimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html) in XAML or C# code.

4. Initialize `SfShimmer.`

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:shimmer="clr-namespace:Syncfusion.Maui.Shimmer;assembly=Syncfusion.Maui.Core">

    <shimmer:SfShimmer />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Shimmer;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfShimmer shimmer = new SfShimmer();
        this.Content = shimmer;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Segoe-mdl2.ttf", "SegoeMDL2");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Change different shimmer views

The [.NET MAUI Shimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html) control provides seven different shimmer types of views. It can be assigned to the control using the [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_Type) property. By default, the control is assigned to the [CirclePersona](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerType.html#Syncfusion_Maui_Shimmer_ShimmerType_CirclePersona) view.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill"
                   Type="CirclePersona">
    <StackLayout>
        <Label
            Text="Content is loaded!"
            HorizontalOptions="CenterAndExpand"
            VerticalOptions="CenterAndExpand">
        </Label>
    </StackLayout>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

SfShimmer shimmer = new SfShimmer()
   {
      Type = ShimmerType.CirclePersona,
      VerticalOptions = LayoutOptions.Fill,
      Content = new Label
      {
         Text = "Content is loaded!!"
      }
   };

   this.Content = shimmer;

{% endhighlight %}
{% endtabs %}

![Circle persona shimmer view in .NET MAUI.](images/overview/maui-circle-persona.gif)

## Loading shimmer content

Shimmer content is loaded when the [`IsActive`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_IsActive) property of [`SfShimmer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html), is disabled.

{% tabs %} 

{% highlight xaml %} 

        <shimmer:SfShimmer x:Name="shimmer" VerticalOptions="FillAndExpand" IsActive ="false">
                <shimmer:SfShimmer.Content>
                     <StackLayout>
                        <Label Text="Content is loaded!"/>
                      </StackLayout>
                </shimmer:SfShimmer.Content>
        </shimmer:SfShimmer>

{% endhighlight %}

{% highlight C# %} 

            shimmer = new SfShimmer()
            {
                IsActive = false,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Content is loaded!"
                }
            };
            this.Content = shimmer;

{% endhighlight %}

{% endtabs %}

N> You can refer to our [.NET MAUI Shimmer](https://www.syncfusion.com/maui-controls/maui-shimmer) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Shimmer Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Shimmer) that shows you how to render the Shimmer in .NET MAUI.
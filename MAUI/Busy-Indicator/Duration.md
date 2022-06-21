---
layout: post
title: Animation Duration in .NET MAUI Busy Indicator control | Syncfusion
description: Learn here all about Animation Duration support in Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
---
# Animation Duration in .NET MAUI Busy Indicator (SfBusyIndicator)

## Animation Duration in SfBusyIndicator

The `DurationFactor` property of SfBusyIndicator indicates timeline for completing one animation cycle. Setting smaller duration value accelerates animation speed.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
             x:Class="BusyIndicatorSample.MainPage">

        <ContentPage.Content>
            <core:SfBusyIndicator x:Name="busyIndicator"
                                  IsRunning="True"
                                  AnimationType="CircularMaterial"
                                  DurationFactor="0.2" />
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.Core;
    using Microsoft.Maui;
    using Microsoft.Maui.Controls;

    namespace BusyIndicatorSample
    {
       public partial class MainPage : ContentPage
       {
           public MainPage()
           {
               InitializeComponent();
               SfBusyIndicator busyIndicator = new SfBusyIndicator()
               {
                   IsRunning = true,
                   AnimationType = AnimationType.CircularMaterial;
                   DurationFactor= 0.2
               };
               this.Content = busyIndicator;
            }
       }
    }

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Animation Duration](Images/Duration/Duration.gif)






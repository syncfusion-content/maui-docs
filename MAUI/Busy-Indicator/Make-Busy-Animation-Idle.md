---
layout: post
title: Make Busy Animation Idle in .NET MAUI Busy Indicator | Syncfusion
description: Learn here all about Make Busy Animation Idle support in Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
---
# Make Busy Animation Idle in .NET MAUI Busy Indicator (SfBusyIndicator)

## Make Busy Animation Idle in .NET MAUI BusyIndicator(SfBusyIndicator)

SfBusyIndicator control provides support to determine whether an animation needs to be executed or not. Setting the `IsRunning` property to false will stop the animation and removes the control from view.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
             x:Class="BusyIndicatorSample.MainPage">

        <ContentPage.Content>
            <core:SfBusyIndicator x:Name="busyindicator"
                                  AnimationType="Cupertino"
                                  IsRunning="false" />
        </ContentPage.Content>
    </ContentPage>

	
{% endhighlight %}

{% highlight c# %}

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
                    AnimationType = AnimationType.Cupertino,                    
                    IsRunning = "false"                    
                };
                this.Content = busyIndicator;
            }
        }
    }
	
{% endhighlight %}

{% endtabs %}

N>  The default value is false.



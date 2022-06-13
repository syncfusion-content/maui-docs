---
layout: post
title: Indicator color and Background in .NET MAUI Busy Indicator control
description: Learn here all about color support in Syncfusion .NET MAUI SfBusyIndicator control and more.
platform: maui
control: BusyIndicator
documentation: ug
---
# Indicator color and Background in .NET MAUI Busy Indicator (SfBusyIndicator)

## Indicator color in .NET MAUI BusyIndicator (SfBusyIndicator)

SfBusyIndicator provides option to set the color for indicator. This can be done using `IndicatorColor` property.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
                x:Class="BusyIndicatorSample.MainPage">

        <ContentPage.Content>
            <core:SfBusyIndicator x:Name="busyindicator"
                                  IsRunning="True"
                                  AnimationType="Cupertino"
                                  Title="Loading..."
                                  IndicatorColor="Red"/>           
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
                    IsRunning = true,
                    AnimationType = AnimationType.Cupertino,
                    Title = "Loading...",
                    IndicatorColor = Colors.Red
                };
                this.Content = busyIndicator;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

## Background color in .NET MAUI BusyIndicator (SfBusyIndicator)

SfBusyIndicator provides option to set the BackgroundColor. This can be done using `OverlayFill` property.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
                x:Class="BusyIndicatorSample.MainPage">

        <ContentPage.Content>
            <core:SfBusyIndicator x:Name="busyindicator"
                                  IsRunning="True"
                                  AnimationType="Cupertino"
                                  Title="Loading..."
                                  IndicatorColor="Red"
                                  OverlayFill = "Yellow"/>           
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
                    IsRunning = true,
                    AnimationType = AnimationType.Cupertino,
                    Title = "Loading...",
                    IndicatorColor = Colors.Red,
                    OverlayFill = Colors.Yellow
                };
                this.Content = busyIndicator;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

The `OverlayFill` property type is Brush, so can able set BackgroundColor as Gradients also.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
                x:Class="BusyIndicatorSample.MainPage">

        <ContentPage.Content>
           <core:SfBusyIndicator IsRunning="True" 
                                 IndicatorColor="#e64c93" 
                                 Title="Loading...">
                <core:SfBusyIndicator.OverlayFill>
                    <RadialGradientBrush>
                        <GradientStop Color="#44e64c93"
                          Offset="0.1" />
                        <GradientStop Color="#AA9d40db"
                          Offset="1.0" />
                    </RadialGradientBrush>
                </core:SfBusyIndicator.OverlayFill>
            </core:SfBusyIndicator>         
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
                    IsRunning = true,
                    AnimationType = AnimationType.Cupertino,
                    Title = "Loading...",
                    IndicatorColor = Colors.Red,
                    OverlayFill = new RadialGradientBrush()
			                    {
				                    GradientStops = new GradientStopCollection() 
				                    {
				                    	new GradientStop(){Color= Colors.LightBlue,Offset= 0.1f},
				                    	new GradientStop() { Color = Colors.Green, Offset = 1.0f }
				                    }
			                    }
                    
                };
                
                this.Content = busyIndicator;
            }
        }
    }

{% endhighlight %}

{% endtabs %}


---
layout: post
title: Sizing in .NET MAUI Busy Indicator control | Syncfusion
description: Learn here all about Sizing support in Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: .NET MAUI
control: BusyIndicator
documentation: ug
---
# Sizing in .NET MAUI Busy Indicator (SfBusyIndicator)

## Sizing in .NET MAUI BusyIndicator (SfBusyIndicator)

Drawing size can be customized in SfBusyIndicator. `SizeFactor` property can be used to set height and width of the Indicator(Default 0.5 – range 0 to 1)).

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
                              Title="Cupertino"
							  SizeFactor="0.7"
                              IsRunning="True"
							  TextColor="Blue"/>
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
                Title = "Cupertino",
                IsRunning = "true",
                TextColor = Colors.Blue,
				SizeFactor = 0.7;
            };

            this.Content = busyIndicator;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Height and width](images/heightand width.png)  

---
layout: post
title: Set Header in .NET MAUI Busy Indicator control | Syncfusion
description: Learn here all about Set Header support in Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: .NET MAUI
control: BusyIndicator
documentation: ug
---
# Set Header in .NET MAUI Busy Indicator (SfBusyIndicator)

## Set Header in .NET MAUI Busy Indicator  (SfBusyIndicator)

## Title

SfBusyIndicator provides option to set the text that indicates the information related to loading. This can be done using `Title` property.

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
                              IsRunning="True"
							  />
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
                IsRunning = "true"
            };

            this.Content = busyIndicator;
        }
    }
}


{% endhighlight %}

{% endtabs %}

## TextColor

SfBusyIndicator provides options to change the color of the text. The color of the text can be changed using the `TextColor` property.

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
                              IsRunning="True"
							  TextColor="Blue"
							  />
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
                TextColor = Colors.Blue
            };

            this.Content = busyIndicator;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## TextSize

SfBusyIndicator provides options to change the size of the text. The size of the text can be changed using the `FontSize` property.

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
                              IsRunning="True"
							  TextColor="Blue"
							  FontSize = "16";
							  />
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
                TextColor = Colors.Blue
				FontSize = 16;
            };

            this.Content = busyIndicator;
        }
    }
}
{% endhighlight %}

{% endtabs %}

## TitlePlacement

SfBusyIndicator provides options to set the `Title` at the top or bottom of the Busy Indicator. The `Title` can be set using the `TitlePlacement` property. When the `Title` is not needed, set the `TitlePlacement` property of SfBusyIndicator to None.

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
							  TitlePlacement = "Bottom"
                              IsRunning="True"
							  TextColor="Blue"
							  />
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
				TitlePlacement = BusyIndicatorTitlePlacement.Bottom,
                TextColor = Colors.Blue
            };

            this.Content = busyIndicator;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Title](images/Title.png) 

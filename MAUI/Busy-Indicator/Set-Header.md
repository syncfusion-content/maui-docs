---
layout: post
title: Set Header in .NET MAUI Busy Indicator control | Syncfusion
description: Learn here all about Set Header support in Syncfusion .NET MAUI Busy Indicator (SfBusyIndicator) control and more.
platform: maui
control: BusyIndicator
documentation: ug
---
# Set Header in .NET MAUI Busy Indicator (SfBusyIndicator)

## Set Header in SfBusyIndicator

The Syncfusion Busy Indicator provides a feature to display a title with font customizations

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
                                  IsRunning="True"
                                  AnimationType="CircularMaterial"
                                  Title="Loading..." />
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
                    AnimationType = AnimationType.CircularMaterial,
                    Title = "Loading...",
                };
                this.Content = busyIndicator;
            }
        }
    }


{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title](Images/SetHeader/Setheader.png)

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
                                  IsRunning="True"
                                  AnimationType="CircularMaterial"
                                  Title="Loading..."
                                  TextColor = "Red" />           
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
                    AnimationType = AnimationType.CircularMaterial,
                    Title = "Loading...",
                    TextColor = Colors.Red
                };
                this.Content = busyIndicator;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Color](Images/SetHeader/TitleColor.png)


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
                                  IsRunning="True"
                                  AnimationType="CircularMaterial"
                                  Title="Loading..."
                                  TextColor = "Red" 
                                  TitlePlacement="Top"/>           
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
                    AnimationType = AnimationType.CircularMaterial,
                    Title = "Loading...",
                    TextColor = Colors.Red,
                    TitlePlacement = BusyIndicatorTitlePlacement.Top
                };
                this.Content = busyIndicator;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Placement](Images/SetHeader/TitlePlacement.png)


## TitleSpacing

SfBusyIndicator provides options to set the space between the indicator and the title. The space can be set using the `TitleSpacing` property.

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
                                  AnimationType="CircularMaterial"
                                  Title="Loading..."
                                  TextColor = "Red" 
                                  TitlePlacement="Top"
                                  TitleSpacing="20"/>           
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
                    AnimationType = AnimationType.CircularMaterial,
                    Title = "Loading...",
                    TextColor = Colors.Red,
                    TitlePlacement = BusyIndicatorTitlePlacement.Top,
                    TitleSpacing = 20
                };
                this.Content = busyIndicator;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![TitleSpacing](Images/SetHeader/Spacing.png)



## Font customization

SfBusyIndicator provides options to customize the title text.  The title text can be customized using the `FontSize`, `FontAttributes` and `FontFamily` properties.


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
                                  AnimationType="CircularMaterial"
                                  Title="Loading..."
                                  TextColor = "Red" 
                                  FontSize = "16"
                                  FontAttributes="Bold"
                                  FontFamily="serif" />           
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
                    AnimationType = AnimationType.CircularMaterial,
                    Title = "Loading...",
                    TextColor = Colors.Red,
                    FontSize = 16,
                    FontAttributes=FontAttributes.Bold,
                    FontFamily="serif"
                };
                this.Content = busyIndicator;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![FontCustomization](Images/SetHeader/Fontattributes(bold).png)


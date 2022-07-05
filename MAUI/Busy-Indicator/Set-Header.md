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

The Syncfusion Busy Indicator provides a feature to display a title with font customizations.

## Title

SfBusyIndicator provides option to set the text that indicates the information related to loading. This can be done using `Title` property.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..." />

{% endhighlight %}

{% highlight c# %}

SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title](Images/SetHeader/Setheader.png)

## Text Color

SfBusyIndicator provides options to change the color of the text. The color of the text can be changed using the `TextColor` property.

{% tabs %}

{% highlight xaml %}
  
<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" />           
       
{% endhighlight %}

{% highlight c# %}
   
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Color](Images/SetHeader/TitleColor.png)


## Title Placement

SfBusyIndicator provides options to set the `Title` at the top or bottom of the Busy Indicator. The `Title` can be set using the `TitlePlacement` property. When the `Title` is not needed, set the `TitlePlacement` property of SfBusyIndicator to None.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" 
                      TitlePlacement="Top"/>           

{% endhighlight %}

{% highlight c# %}
  
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    TitlePlacement = BusyIndicatorTitlePlacement.Top
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Placement](Images/SetHeader/TitlePlacement.png)


## Title Spacing

SfBusyIndicator provides options to set the space between the indicator and the title. The space can be set using the `TitleSpacing` property.

{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" 
                      TitlePlacement="Top"
                      TitleSpacing="20"/>           

{% endhighlight %}

{% highlight c# %}

    
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial,
    Title = "Loading...",
    TextColor = Colors.Red,
    TitlePlacement = BusyIndicatorTitlePlacement.Top,
    TitleSpacing = 20
};

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Title Spacing](Images/SetHeader/Spacing.png)



## Font customization

SfBusyIndicator provides options to customize the title text. The title text can be customized using the `FontSize,` `FontAttributes,` and `FontFamily` properties.


{% tabs %}

{% highlight xaml %}

<core:SfBusyIndicator x:Name="busyindicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial"
                      Title="Loading..."
                      TextColor = "Red" 
                      FontSize = "16"
                      FontAttributes="Bold"
                      FontFamily="serif" />           
 
{% endhighlight %}

{% highlight c# %}

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

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Font Customization](Images/SetHeader/Fontattributes(bold).png)


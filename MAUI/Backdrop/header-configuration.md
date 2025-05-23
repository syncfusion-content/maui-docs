---
layout: post
title: Header Configuration with Syncfusion<sup>&reg;</sup> Backdrop Page | Syncfusion<sup>&reg;</sup>
description: Learn how to configure and customize the header in the Syncfusion<sup>&reg;</sup> Backdrop page control in the .NET MAUI platform.
platform: MAUI
control: SfBackdropPage
documentation: ug
---

# Header Configuration in .NET MAUI Backdrop Page (SfBackdropPage)

Add a Backdrop page as a child of the [`NavigationPage`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-6.0) in the App.xaml.cs class. Also, the [`BarBackgroundColor,`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.navigationpage.barbackgroundcolor?view=net-maui-6.0) [`BarTextColor,`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.navigationpage.bartextcolor?view=net-maui-6.0) and other properties of the [`NavigationPage`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-6.0) can be set to customize the default appearance of the header.
 
{% highlight C# %} 

// In App.xaml.cs 
#region Constructor

public App()
{ 
   … 
  MainPage = new NavigationPage(new BackdropSamplePage());
   … 
}

#endregion 

{% endhighlight %}

N> The page header for the Backdrop will appear only when adding Backdrop as a child of the [`NavigationPage`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-6.0).
 
## Icon customization

The default icons in the navigation header can be customized using the following ways:

### Default icons in NavigationPage

When the Backdrop page contained within the [NavigationPage](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-6.0), the menu icon and close icon (X-mark ) will be used by default.

![.NET MAUI Backdrop in navigation page](images/header-configuration/default-navigationpage-icons.png)

### Default icons in FlyoutPage

When the Backdrop page is placed in the [FlyoutPage](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/flyoutpage?view=net-maui-6.0), the down-arrow icon and up-arrow icon will be used by default.

![.NET MAUI Backdrop in navigation page](images/header-configuration/default-flyoutpage-icons.png)

### Custom icons

Customize the default icons in the navigation header by setting the [`OpenIconImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OpenIconImageSource) and [`CloseIconImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_CloseIconImageSource) properties in the [`SfBackdropPage`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html). It accepts following inputs:
* FileImageSource
* UriImageSource
* StreamImageSource
* FromResource

{% tabs %} 

{% highlight xaml %} 

<Backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="BackdropGettingStarted.BackdropSamplePage"
                         xmlns:Backdrop="clr-namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop"
                         OpenIconImageSource="open.png"
                         CloseIconImageSource="close.png">

</Backdrop:SfBackdropPage>

{% endhighlight %}

{% highlight C# %} 

using Syncfusion.Maui.Backdrop;
namespace BackdropGettingStarted;

public partial class BackdropSamplePage : SfBackdropPage
{
    public BackdropSamplePage()
    {
        InitializeComponent();
        this.OpenIconImageSource = "open.png";
        this.CloseIconImageSource = "close.png";
    }
}


{% endhighlight %}

{% endtabs %}

![.NET MAUI Backdrop Custom icons](images/header-configuration/custom-icons.png)
 
## Icon text customization

Customize the icon text in the navigation header by setting the [`OpenText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OpenText) and [`CloseText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_CloseText) properties in the [`SfBackdropPage`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html).

{% tabs %} 

{% highlight xaml %} 

<Backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="BackdropGettingStarted.BackdropSamplePage"
                         xmlns:Backdrop="clr-namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop"
                         OpenText="Show Menu"
                         CloseText="Hide Menu">

</Backdrop:SfBackdropPage>

{% endhighlight %}

{% highlight C# %} 

using Syncfusion.Maui.Backdrop;
namespace BackdropGettingStarted;
public partial class BackdropSamplePage : SfBackdropPage
{
    public BackdropSamplePage()
    {
        InitializeComponent();
        this.OpenText = "Show Menu";
        this.CloseText = "Hide Menu";
    }
}

{% endhighlight %}

{% endtabs %}

![.NET MAUI Backdrop open and close icon custom text](images/header-configuration/custom-text.png)

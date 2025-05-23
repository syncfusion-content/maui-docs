---
layout: post
title: Migrate from Xamarin to .NET MAUI  Backdrop Page | Syncfusion®
description: Learn about migrating from the Syncfusion® Xamarin Backdrop Page to Syncfusion® .NET MAUI Backdrop Page Control and more.
platform: MAUI
Control: SfBackdropPage
documentation: UG
---  

# Migrate from Xamarin.Forms SfBackdropPage to .NET MAUI SfBackdropPage

To migrate from the [Xamarin SfBackdropPage](https://www.syncfusion.com/xamarin-ui-controls/xamarin-Backdrop) to [.NET MAUI SfBackdropPage](https://www.syncfusion.com/maui-controls/maui-Backdrop) easier, most of the APIs from the Xamarin SfBackdropPage were kept in the .NET MAUI SfBackdropPage.

## Namespaces 


<table>

<tr>

<th>Xamarin SfBackdropPage</th>


<th>.NET MAUI SfBackdropPage</th>
</tr>


<tr>

<td>Syncfusion.XForms.Backdrop</td>


<td>Syncfusion.Maui.Backdrop</td>
</tr>

</table>


## Initialize Control

To Initialize the Control, import the Backdrop Namespace and Initialize the SfBackdropPage as shown in the following code sample.


<table>

<tr>

<th>Xamarin Backdrop Page</th>

</tr>


<tr>

<td>
{% tabs %}

{% highlight xaml %}

<Backdrop:SfBackdropPage xmlns="http://xamarin.com/schemas/2014/forms"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         xmlns:Backdrop="clr-Namespace:Syncfusion.XForms.Backdrop;assembly=Syncfusion.SfBackdrop.XForms"
                         x:Class="BackdropGettingStarted.BackdropSamplePage"
                         Title="Menu">

</Backdrop:SfBackdropPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.Backdrop;	
Namespace BackdropGettingStarted
{
    public partial class BackdropSamplePage : SfBackdropPage
    {
        public BackdropSamplePage()
        {
            InitializeComponent();
            this.Title = "Menu";
        }
    }
}

{% endhighlight %}

{% endtabs %}

</td>

</tr>


<tr>

<th>.NET MAUI Backdrop Page</th>

</tr>


<tr>

<td>
{% tabs %} 

{% highlight xaml %}

<Backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="BackdropGettingStarted.BackdropSamplePage"
                         Title="Menu"
                         xmlns:Backdrop="clr-Namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop"
                         >
    
</Backdrop:SfBackdropPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Backdrop;
Namespace BackdropGettingStarted;

public partial class BackdropSamplePage : SfBackdropPage
{
    public BackdropSamplePage()
    {
        InitializeComponent();
        this.Title = "Menu";
    }
}

{% endhighlight %}

{% endtabs %}
</td>

</tr>

</table>


## Unsupported features from Xamarin.Forms

* The [`OpenIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_OpenIcon) and [`CloseIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_CloseIcon) support has not been provided in the SfBackdropPage. Instead, you can achieve it using the [`OpenIconImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OpenIconImageSource) and [`CloseIconImageSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_CloseIconImageSource) properties. Since the [`OpenIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_OpenIcon) and [`CloseIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_CloseIcon) are marked obsolete.

---
layout: post
title: Migrate from Xamarin to .NET MAUI  Backdrop page | Syncfusion
description: Learn here all about Migrating from Syncfusion Xamarin backdrop page to Syncfusion .NET MAUI backdrop page control and more.
platform: MAUI
control: SfBackdropPage
documentation: ug
---  

# Migrate from Xamarin.Forms SfBackdropPage to .NET MAUI SfBackdropPage

To make the migration from the [Xamarin SfBackdropPage](https://www.syncfusion.com/xamarin-ui-controls/xamarin-backdrop) to `.NET MAUI SfBackdropPage` easier, most of the APIs from the Xamarin SfBackdropPage were kept in the .NET MAUI SfBackdropPage. However, to maintain the consistency of API naming in the .NET MAUI SfBackdropPage, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the Backdrop namespace and initialize the SfBackdropPage as shown in the following code sample.

<table>
<tr>
<th>Xamarin Backdrop page</th>
<th>.NET MAUI Backdrop page</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<backdrop:SfBackdropPage xmlns="http://xamarin.com/schemas/2014/forms"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         xmlns:backdrop="clr-namespace:Syncfusion.XForms.Backdrop;assembly=Syncfusion.SfBackdrop.XForms"
                         x:Class="BackdropGettingStarted.BackdropSamplePage"
                         Title="Menu">

</backdrop:SfBackdropPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.Backdrop;	
namespace BackdropGettingStarted
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
<td>
{% tabs %} 

{% highlight xaml %}

<backdrop:SfBackdropPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                         xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                         x:Class="BackdropGettingStarted.BackdropSamplePage"
                         Title="Menu"
                         xmlns:backdrop="clr-namespace:Syncfusion.Maui.Backdrop;assembly=Syncfusion.Maui.Backdrop"
                         >
    
</backdrop:SfBackdropPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Backdrop;
namespace BackdropGettingStarted;

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
</td></tr>
</table>

## SfBackdropPage properties

<table> 
<tr>
<th>Xamarin SfBackdropPage</th>
<th>.NET MAUI SfBackdropPage</th>
<th>Description</th></tr>
<tr>
<td>{{'[BackLayer](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_BackLayer)'| markdownify }}</td>
<td>{{'BackLayer'| markdownify }}</td>
<td>Gets or sets a value for a view to place behind the BackdropFrontLayer.</td></tr>
<tr>
<td>{{'[FrontLayer](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_FrontLayer)'| markdownify }}</td>
<td>{{'FrontLayer'| markdownify }}</td>
<td>Gets or sets a value for a view to place above the BackdropBackLayer.</td></tr>
<tr>
<td>{{'[CloseIconImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_CloseIconImageSource)'| markdownify }}</td>
<td>{{'CloseIconImageSource'| markdownify }}</td>
<td>Gets or sets the image source value for the CloseIconImageSource.</td></tr>
<tr>
<td>{{'[OpenIconImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_OpenIconImageSource)'| markdownify }}</td>
<td>{{'OpenIconImageSource'| markdownify }}</td>
<td>Gets or sets the image source value for the OpenIconImageSource.</td></tr>
<tr>
<td>{{'[OpenText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_OpenText)'| markdownify }}</td>
<td>{{'OpenText'| markdownify }}</td>
<td>Gets or sets the value to display the OpenIconImageSource text.</td></tr>
<tr>
<td>{{'[CloseText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_CloseText)'| markdownify }}</td>
<td>{{'CloseText'| markdownify }}</td>
<td>Gets or sets the value to display the CloseIconImageSource text.</td></tr>
<tr>
<td>{{'[IsBackLayerRevealed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_IsBackLayerRevealed)'| markdownify }}</td>
<td>{{'IsBackLayerRevealed'| markdownify }}</td>
<td>Gets or sets a value indicating whether back layer should be in expanded state.</td></tr>
<tr>
<td>{{'[BackLayerRevealOption](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_BackLayerRevealOption)'| markdownify }}</td>
<td>{{'BackLayerRevealOption'| markdownify }}</td>
<td>Gets or sets the value that indicate how the back layer gets revealed.</td></tr>
</table> 

## BackdropFrontLayer properties

<table> 
<tr>
<th>Xamarin SfBackdropPage</th>
<th>.NET MAUI SfBackdropPage</th>
<th>Description</th></tr>
<tr>
<td>{{'[EdgeShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.BackdropFrontLayer.html#Syncfusion_XForms_Backdrop_BackdropFrontLayer_EdgeShape)'| markdownify }}</td>
<td>{{'EdgeShape'| markdownify }}</td>
<td>Gets or sets a value that indicates the edge mode of the front layout.</td></tr>
<tr>
<td>{{'[EnableSwiping](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.BackdropFrontLayer.html#Syncfusion_XForms_Backdrop_BackdropFrontLayer_EnableSwiping)'| markdownify }}</td>
<td>{{'EnableSwiping'| markdownify }}</td>
<td>Gets or sets a value indicating whether the front layout able to swipe.</td></tr>
<tr>
<td>{{'[LeftCornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.BackdropFrontLayer.html#Syncfusion_XForms_Backdrop_BackdropFrontLayer_LeftCornerRadius)'| markdownify }}</td>
<td>{{'LeftCornerRadius'| markdownify }}</td>
<td>Gets or sets a value of top left corner radius for the front layer.</td></tr>
</table> 
<tr>
<td>{{'[RightCornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.BackdropFrontLayer.html#Syncfusion_XForms_Backdrop_BackdropFrontLayer_RightCornerRadius)'| markdownify }}</td>
<td>{{'RightCornerRadius'| markdownify }}</td>
<td>Gets or sets a value of top right corner radius for the front layer.</td></tr>
<tr>
<td>{{'[RevealedHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.BackdropFrontLayer.html#Syncfusion_XForms_Backdrop_BackdropFrontLayer_RevealedHeight)'| markdownify }}</td>
<td>{{'RevealedHeight'| markdownify }}</td>
<td>Gets or sets a height of the front layer when the back layer revealed.</td></tr>

The following code example explains how to use the properties in the Xamarin backdrop page and the .NET MAUI backdrop page.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}


{% endhighlight %}

{% highlight C# %}


{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

 
{% endhighlight %}

{% highlight C# %}


{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Unsupported features from Xamarin.Forms

* [`OpenIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_OpenIcon) and [`CloseIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_CloseIcon) support has not been provided in the SfBackdropPage. Instead, you can achieve it using the `OpenIconImageSource` and `CloseIconImageSource` property. Since the [`OpenIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_OpenIcon) and [`CloseIcon`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Backdrop.SfBackdropPage.html#Syncfusion_XForms_Backdrop_SfBackdropPage_CloseIcon) are marked obsolete.

---
layout: post
title: Migration from Xamarin to .NET MAUI Parallax View control | Syncfusion
description: This section explains the features available in the .NET MAUI Parallax View control over Xamarin Parallax View.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Migrate from Xamarin.Forms SfParallaxView to .NET MAUI SfParallaxView

The SfParallaxView was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, to maintain the consistency of the API naming in MAUI SfParallaxView, we renamed some of the APIs. The APIs changed in MAUI SfParallaxView from Xamarin SfParallaxView are detailed as follows:

## Namespaces

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
Syncfusion.XForms.ParallaxView
</td>
<td>
<div> Syncfusion.Maui.ParallaxView </div>
</td>
</tr>
</table>

To make the migration easier, the most of the APIs from the Xamarin [SfParallaxView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ParallaxView.SfParallaxView.html) were kept in the .NET MAUI [SfParallaxView](). Currently, most of the features have been added in the [SfParallaxView](), but only a few are pending in the .NET MAUI along with some limitations. Please refer to the following details and the API migration information available below.

## Initialize control

To initialize the control, import the parallax view namespace and Initialize [SfParallaxView]() as shown in the following code sample. 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

    <ContentPage
        . . .
        xmlns:parallax="clr-namespace:Syncfusion.XForms.ParallaxView;assembly=Syncfusion.XForms.ParallaxView">

        <parallax:SfParallaxView/>

    </ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.XForms.ParallaxView;
    ...

    SfParallaxView parallax = new SfParallaxView();
    this.Content = parallax;

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

    <ContentPage
        . . .    
        xmlns:parallax="clr-namespace:Syncfusion.Maui.ParallaxView;assembly=Syncfusion.Maui.ParallaxView">

        <parallax:SfParallaxView/>

    </ContentPage>
 
{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.ParallaxView;
. . .
SfParallaxView parallax = new SfParallaxView();
this.Content = parallax;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Classes

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
<th>Description</th>
</tr>
<tr>
<td>SfParallaxView</td>
<td>SfParallaxView</td>
<td>SfParallaxView control provides scrolling for any control that implements the IParallaxVie.</td>
</tr>
<tr>
<td>ParallaxScrollingEventArgs</td>
<td>ParallaxScrollingEventArgs</td>
<td>Defines the scrolling Event args</td>
</tr>
</table>

## Interface

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
<th>Description</th>
</tr>
<tr>
<td>IParallaxView</td>
<td>IParallaxView</td>
<td>Defines a event and a property to perform parallax scrolling.</td>
</table>

## Enums

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
<th>Description</th>
</tr>
<tr>
<td>Orientation</td>
<td>Orientation</td>
<td>Defines the orientation of the view</td>
</tr>
</table>

## API Migration
The following table illustrates the API migration for the parallax view.

### Parallax View

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>Content</td>
<td>Content</td>
</tr>
<tr>
<td>Source</td>
<td>Source</td>
</tr>
<tr>
<td>Speed</td>
<td>Speed</td>
</tr>
<tr>
<td>Orientation</td>
<td>Orientation</td>
</tr>
<tr>
<td>Scrolling</td>
<td>Scrolling</td>
</tr>
<tr>
<td>ScrollX</td>
<td>ScrollX</td>
</tr>
<tr>
<td>ScrollY</td>
<td>ScrollY</td>
</tr>
<tr>
<td>CanAnimate</td>
<td>CanAnimate</td>
</tr>
<tr>
<td>ScrollContentSize</td>
<td>ScrollContentSize</td>
</tr>
</table>

The following code example explains how to migrate Xamarin SfParallaxView to the .NET MAUI SfParallaxView.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

    <ContentPage
        . . .
        xmlns:parallax="clr-namespace:Syncfusion.XForms.ParallaxView;Syncfusion.XForms.ParallaxView">

        <parallax:SfParallaxView/>

    </ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.XForms.ParallaxView;
    ...

    SfParallaxView parallaxView = new SfParallaxView();
    this.Content = parallaxView;

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

    <ContentPage
        . . .
        xmlns:parallax="clr-namespace:Syncfusion.Maui.ParallaxView;assembly=Syncfusion.Maui.ParallaxView">

        <parallax:SfParallaxView/>
        
    </ContentPage>
 
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.ParallaxView;
    ...

    SfParallaxView parallaxView = new SfParallaxView();
    this.Content = parallaxView;                   

{% endhighlight %}

{% endtabs %}

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). If you do not see what you need, Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 

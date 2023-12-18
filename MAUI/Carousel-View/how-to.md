---
layout : post
title: Interaction in Syncfusion Carousel Control in .NET MAUI.
description: Learn how to perform an operation while changing the carouselItem or Collection in Carousel for .NET MAUI.
platform : maui
control : Carousel
documentation : ug
---

# How to perform an operation while changing the carouselItem?

We can perform the operation while changing the carouselItem using the `SelectionChanged` event. The `SelectionChanged` event returns the OldItem and selected NewItem.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemHeight="200"
                     ItemWidth="200"
                     SelectionChanged="Carousel_SelectionChanged"/>

{% endhighlight %}

{% highlight C# %}

private void Carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    int count = (sender as SfCarousel).SelectedIndex + 1;
    DisplayAlert("SelectionChanged", "Carousel item:" + count + " has Selected", "Ok");
}

{% endhighlight %}

{% endtabs %}



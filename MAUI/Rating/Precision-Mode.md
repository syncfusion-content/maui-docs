---

layout: post
title: Precision Mode in .NET MAUI Rating control | Syncfusion
description: Learn here all about Precision Mode support in Syncfusion .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Precision Mode in .NET MAUI Rating (SfRating)

The `Precision` mode defines the accuracy level of the `SfRating` control. It has `Standard`, `Half`, and `Exact` options. The default precision mode of the `SfRating` control is `Standard`.

## Standard

When the precision mode of `SfRating` is set as `Standard`, the rating item will be filled completely based on the rating value.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" Precision="Standard" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.Precision = Precision.Standard;
}

{% endhighlight %} 

{% endtabs %}

![SfRating standard precision mode](images/standard.png)

## Half

When the precision mode of `SfRating` is set as `Half`, the rating item will be filled partially based on the rating value.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" Precision="Half" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.Precision = Precision.Half;
}

{% endhighlight %} 

{% endtabs %}

![SfRating half precision mode](images/half.png) 

## Exact

When the precision mode of `SfRating` is set as `Exact`, the rating item will be filled exactly based on the rating value.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" Precision="Exact" />
	
{% endhighlight %}

{% highlight c# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.Precision = Precision.Exact;
}

{% endhighlight %} 

{% endtabs %}

![SfRating exact precision mode](images/exact.png) 


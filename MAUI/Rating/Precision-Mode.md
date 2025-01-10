---

layout: post
title: Precision Mode in .NET MAUI Rating control | Syncfusion<sup>®</sup>
description: Learn here all about Precision Mode support in Syncfusion<sup>®</sup> .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Precision Mode in .NET MAUI Rating (SfRating)

The [`Precision`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html) mode defines the accuracy level of the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. It has [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard), [`Half`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Half), and [`Exact`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Exact) options. The default precision mode of the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control is [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard).

## Standard

When the precision mode of [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) is set as [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard), the rating item will be filled completely based on the rating value.

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

When the precision mode of [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) is set as [`Half`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Half), the rating item will be filled partially based on the rating value.

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

When the precision mode of [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) is set as [`Exact`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Exact), the rating item will be filled exactly based on the rating value.

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


---

layout: post
title: Precision Mode in .NET MAUI Rating control | Syncfusion®
description: Learn here all about Precision Mode support in Syncfusion® .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Precision Mode in .NET MAUI Rating (SfRating)

## Prerequisites

Before using the [SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rating/getting-started) documentation.

## Overview

The [`Precision`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html) mode defines the accuracy level of the [` .NET MAUI Rating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. It has [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard), [`Half`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Half), and [`Exact`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Exact) options. The default precision mode of the `Rating` control is [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard).

The following table summarizes the available precision modes and their typical use cases.

| Precision mode | Allowed increments | Typical use case |
|----------------|--------------------|------------------|
| `Standard` | Whole values (e.g., 1, 2, 3) | Simple whole-star ratings such as product or movie ratings. |
| `Half`    | Half values (e.g., 0.5, 1.5, 2.5) | Ratings that allow half-step granularity, such as service feedback. |
| `Exact`   | Any fractional value (e.g., 2.3, 3.7) | Ratings that require precise or continuous feedback, such as analytics. |

## Standard

When the precision mode of `Rating` is set as [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard), rating items are filled completely based on the rating value. Only whole values are accepted; fractional values are rounded to the nearest whole number.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3" 
                 Precision="Standard" />

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
	Value = 3,
	Precision = Precision.Standard
};

{% endhighlight %}

{% endtabs %}

![SfRating standard precision mode](images/standard.png)

## Half

When the precision mode of `Rating` is set as [`Half`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Half), rating items are filled up to half of an item based on the rating value. Half values (for example, 0.5, 1.5, 2.5) are accepted, allowing partial fills of rating items.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="2.5" 
                 Precision="Half" />

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
	Value = 2.5,
	Precision = Precision.Half
};

{% endhighlight %}

{% endtabs %}

![SfRating half precision mode](images/half.png)

## Exact

When the precision mode of `Rating` is set as [`Exact`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Exact), rating items are filled precisely to match the exact rating value. Fractional values (for example, 3.7) are accepted and rating items are filled to the proportional amount.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3.7" 
                 Precision="Exact" />

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
	Value = 3.7,
    Precision = Precision.Exact
};

{% endhighlight %}

{% endtabs %}

![SfRating exact precision mode](images/exact.png)

## See Also

* [Restrict User Selection in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/restrict-user-selection)
* [Appearance and Styling in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/appearance-and-styling)
* [Rating Shape in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/rating-shape)


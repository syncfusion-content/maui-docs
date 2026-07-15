---

layout: post
title: Appearance and Styling in .NET MAUI Rating control | Syncfusion®
description: Learn about customizing item size, item count, item spacing, value, and rating settings in the Syncfusion .NET MAUI Rating (SfRating) control.
platform: maui
control: Rating
documentation: ug

---

# Appearance and Styling in .NET MAUI Rating (SfRating)

## Prerequisites

Before using the [SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rating/getting-started) documentation.

## Overview

When the default view is not needed, you can customize the view of the [.NET MAUI SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. The [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control provides support to customize the item size, item count, value, and space between rating items.

## Set Size

The [`ItemSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSize) property sets the size of the rating items, in device-independent units (DIU). The value must be greater than zero.

N> The default value of this property is 50.

{% tabs %}

{% highlight xaml %}

<rating:SfRating ItemSize="20" />

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    ItemSize = 20
};

{% endhighlight %}

{% endtabs %}

![SfRating Item Size customization](images/item-size.png)

## Set Number of Items

The [`ItemCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount) property sets the number of rating items to be displayed. The value must be an integer greater than zero.

N> The default value of this property is 5.

{% tabs %}

{% highlight xaml %}

<rating:SfRating ItemCount="4" />

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    ItemCount = 4
};

{% endhighlight %}

{% endtabs %}

![Set number of rating items](images/item-count.png)

## Set Space between Items

The [`ItemSpacing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSpacing) property sets the spacing between the rating items, in device-independent units (DIU). The value must be greater than or equal to zero.

N> The default value of this property is 5.

{% tabs %}

{% highlight xaml %}

 <rating:SfRating ItemSpacing="20"/>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    ItemSpacing = 20
};

{% endhighlight %}

{% endtabs %}

![Space between rating items](images/item-spacing.png)

## Set Value

The [`Value`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Value) property of the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control determines the rating selected among the items. The following code example sets a display value of three with five rating items. The [`Value`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Value) property accepts a `double`, so it also supports half and other fractional values when used with the [Precision](https://help.syncfusion.com/maui/rating/precision-mode) mode. The property is two-way bindable and fires the [`ValueChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ValueChanged) event when the value changes.

N> The default value of this property is 0. The valid range is 0 to `ItemCount`.

{% tabs %}

{% highlight xaml %}

 <rating:SfRating Value="3"/>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    rating.Value = 3
};

{% endhighlight %}

{% endtabs %}

## Rating Settings

This section explains the rating settings available in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. Use the [`RatingSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html) class to customize the fill, stroke, and stroke thickness of the rated and unrated items.

> **Note:** When setting `RatedStrokeThickness` or `UnratedStrokeThickness`, also set the corresponding `RatedStroke` or `UnratedStroke` color, otherwise the stroke will not be visible. For detailed per-property examples, see [Appearance Customization](https://help.syncfusion.com/maui/rating/appearance-customization).

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings RatedFill="Red"
                                UnratedFill="Gray"
                                RatedStroke="Black"
                                UnratedStroke="Blue"
                                RatedStrokeThickness="2"
                                UnratedStrokeThickness="2"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    Value = 3,
    RatingSettings = new RatingSettings()
    {
        RatedFill = Colors.Red,
        UnratedFill = Colors.Gray,
        RatedStroke = Colors.Black,
        UnratedStroke = Colors.Blue,
        RatedStrokeThickness = 2,
        UnratedStrokeThickness = 2
    },
};

{% endhighlight %}

{% endtabs %}

![Rating Settings](images/rating-settings.png)

## See also

* [Getting Started with .NET MAUI Rating](https://help.syncfusion.com/maui/rating/getting-started)
* [Precision Mode in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/precision-mode)
* [Rating Shape in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/rating-shape)
* [Restrict User Selection in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/restrict-user-selection)
* [Appearance Customization in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/appearance-customization)

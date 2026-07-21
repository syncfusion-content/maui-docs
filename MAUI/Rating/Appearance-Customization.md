---

layout: post
title: Appearance Customization in .NET MAUI Rating control | Syncfusion®
description: Learn here all about Appearance Customization support in Syncfusion® .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Appearance Customization in .NET MAUI Rating (SfRating)

## Prerequisites

Before using the [SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rating/getting-started) documentation.

## Overview

Use [`RatingSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html) to customize the appearance of the rated and unrated items in the Rating control. The available properties are listed below.

### Fill

* [`RatedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedFill)
* [`UnratedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedFill)

### Stroke

* [`RatedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStroke) 
* [`UnratedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStroke)

### Stroke Thickness

* [`RatedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness)
* [`UnratedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStrokeThickness)

## Set Fill Color

[`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) supports setting the fill color for the rated and unrated items.

### Rated items

The [`RatedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedFill) property fills the rated items with the specified color in the `Rating` control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings RatedFill="Red"/>
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
    },
};

{% endhighlight %}

{% endtabs %}

![Rated item fill color](images/rated-fill.png)

### Unrated items

The [`UnratedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedFill) property fills the unrated items with the specified color in the `Rating` control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings UnratedFill="Gray"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    Value = 3,
    RatingSettings = new RatingSettings()
    {
        UnratedFill = Colors.Gray,
    },
};

{% endhighlight %}

{% endtabs %}

![Unrated item fill color](images/unrated-fill.png)

## Set Stroke

[`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) supports setting the stroke color for the rated and unrated items.

### Rated items

The [`RatedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStroke) property sets the stroke for the rated items with the specified color in the `Rating` control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings RatedStroke="Black"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    Value = 3,
    RatingSettings = new RatingSettings()
    {
        RatedStroke = Colors.Black,
    },
};

{% endhighlight %}

{% endtabs %}

![Rated item stroke](images/rated-stroke.png)

### Unrated items

The [`UnratedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStroke) property sets the stroke for the unrated items with the specified color in the `Rating` control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings UnratedStroke="Black"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    Value = 3,
    RatingSettings = new RatingSettings()
    {
        UnratedStroke = Colors.Black,
    },
};

{% endhighlight %}

{% endtabs %}

![Unrated item stroke](images/unrated-stroke.png)

## Set Stroke Thickness

[`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) supports setting the stroke thickness for the rated and unrated items. The value is a `double` in device-independent units (DIU) and must be greater than or equal to zero.

### Rated items

The [`RatedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness) property sets the stroke thickness for the rated items with the specified value in the `Rating` control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings RatedStroke="Black" 
                               RatedStrokeThickness="3"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    Value = 3,
    RatingSettings = new RatingSettings()
    {
        RatedStroke = Colors.Black,
        RatedStrokeThickness = 3,
    },
};

{% endhighlight %}

{% endtabs %}

![Rated item stroke thickness](images/rated-stroke-thickness.png)

### Unrated items

The [`UnratedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStrokeThickness) property sets the stroke thickness for the unrated items with the specified value in the `Rating` control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings UnratedStroke="Black"
                               UnratedStrokeThickness="3"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    Value = 5,
    RatingSettings = new RatingSettings()
    {
        UnratedStroke = Colors.Black,
        UnratedStrokeThickness = 3,
    },
};

{% endhighlight %}

{% endtabs %}

![Unrated item stroke thickness](images/unrated-stroke-thickness.png)

## See also

* [Appearance and Styling in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/appearance-and-styling)
* [Precision Mode in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/precision-mode)
* [Rating Shape in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/rating-shape)
* [Restrict User Selection in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/restrict-user-selection)

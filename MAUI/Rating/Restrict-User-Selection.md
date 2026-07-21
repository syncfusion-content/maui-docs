---

layout: post
title: Restrict user Selection in .NET MAUI Rating control | Syncfusion®
description: Learn here all about Restrict User Selection support in Syncfusion® .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Restrict user selection in .NET MAUI Rating (SfRating)

## Prerequisites

Before using the [SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Inputs`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rating/getting-started) documentation.

## IsReadOnly

[.NET MAUI Rating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) prevents users from changing the rating value once it has been set, which is useful for displaying read-only feedback such as a product or service rating shown to all viewers.

The [`IsReadOnly`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_IsReadOnly) property of type `bool` controls whether users can change the rating value. Setting it to `true` makes the value unchangeable. The default value is `false`. When `IsReadOnly` is `true`, tap and drag interactions that would normally modify the value are blocked, and the pointer feedback typically shown on touch or hover is suppressed.

{% tabs %}

{% highlight xaml %}

<rating:SfRating IsReadOnly="true" />

{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating()
{
    IsReadOnly = true,
};

{% endhighlight %}

{% endtabs %}

![SfRating read-only mode](images/IsReadOnly.gif)

## See also

- [Getting Started with .NET MAUI Rating](https://help.syncfusion.com/maui/rating/getting-started)
- [Precision Mode in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/precision-mode)
- [Appearance Customization in .NET MAUI Rating](https://help.syncfusion.com/maui/rating/appearance-customization)

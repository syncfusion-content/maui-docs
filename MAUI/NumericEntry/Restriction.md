---
layout: post
title: Value Change Restriction in .NET MAUI NumericEntry | Syncfusion
description: Learn here all about how to restrict the value change in Syncfusion .NET MAUI NumericEntry (SfNumericEntry) control and more.
platform: MAUI
control:  SfNumericEntry
documentation: ug
---

# Value change restriction in .NET MAUI NumericEntry

This section describes how to restrict the change in the value of the `NumericEntry` control using `AllowNull`, `Minimum`, and `Maximum` properties.

## Restrict null value

By default, an empty or null value is set in the `NumericEntry` control when the input is cleared, as the default value of the `AllowNull` property is **true**. When the `AllowNull` property value is **false**, the `NumericEntry` control returns the value to **0** in the editor after clearing the input.

N> When the value of the `Minimum` property is **15**, and the `AllowNull` property is **true**, the **null** value is returned in the `NumericEntry` control after clearing the input.

N> When the value of the Minimum property is **15**, and the `AllowNull` property is **false**, the `minimum` value is returned in `NumericEntry` control after clearing the input.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                     VerticalOptions="Center" 
                     Value="10" 
                     AllowNull="False" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumeriCEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.Value = 10;
sfNumericEntry.AllowNull = false;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry value restriction](Restriction_images/restrict_nullvalue.gif)

## Restrict value within range

You can restrict the users to enter input within a minimum and maximum range in the `NumericEntry` control using the Minimum and Maximum properties. The default value of the `Minimum` property is the **double.MinValue** and `Maximum` property is **double.MaxValue**.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                     VerticalOptions="Center"
                     Value="50"
                     Minimum="10"
                     Maximum="30" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.Minimum = 10;
sfNumericEntry.Maximum = 30;
sfNumericEntry.Value = 50;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry value restriction](GettingStarted_images/value_restriction_img.png)

## Restrict text editing

You can prevent users from editing the numerical value in the editor using the `IsEditable` property. However, you can still change the value using the up-down buttons, mouse scroll, keyboard arrows, and page keys. By default, the value of the `IsEditable` property is **true**.



{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry x:Name="sfNumericEntry" 
                     HorizontalOptions="Center"
                     VerticalOptions="Center"
                     IsEditable="True" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.IsEditable = true;

{% endhighlight %}
{% endtabs %}


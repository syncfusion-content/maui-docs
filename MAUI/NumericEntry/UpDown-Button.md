---
layout: post
title: Use UpDown Button in .NET MAUI NumericEntry | Syncfusion
description: Learn here all about how to use UpDown Button (SpinButton) in Syncfusion .NET MAUI NumericEntry (SfNumericEntry) control and more.
platform: MAUI
control:  SfNumericEntry
documentation: ug
---

# UpDown Button in .NET MAUI NumericEntry

This section describes how to change the value in the [NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control using keys, mouse scrolling, and the up-down button

## Increase or decrease value

You can increment or decrement the value in the `NumericEntry` control using the **UpArrow**, **DownArrow**, **PageUp**, and **PageDown** keys. You can change the increment or decrement value when the Arrow keys are pressed using the [SmallChange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_SmallChange) property and Page keys using the [LargeChange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_LargeChange) property. By default, the value of the `SmallChange` property is **1**, and the `LargeChange` property is **10**. 

N> The value in the `NumericEntry` can also be changed by mouse scrolling. The mouse scrolling increases or decreases the value based on the `SmallChange` property.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                        VerticalOptions="Center" 
                        SmallChange="5"
                        Value="10"
                        LargeChange="10" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry= new SfNumericEntry();
sfNumericEntry.Value=10;
sfNumericEntry.SmallChange=5;
sfNumericEntry.LargeChange=10;
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry Placeholder Text](GettingStarted_images/valuechange-bykeys.gif)

## UpDown button placement

You can increase or decrease the value of the `NumericEntry` control using the up-down button. By default, the value of the [UpDownPlacementMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownPlacementMode) property is **Hidden**. You can change the up-down button position by assigning the value `UpDownPlacementMode` property as **Inline**.

N> When using the up-down button, the `NumericEntry` control value changes based on the value of the `SmallChange` property.

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry HorizontalOptions="Center"
                        VerticalOptions="Center"
                        Value="360";
                        UpDownPlacementMode="Inline" />
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.Value=360;
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline;

{% endhighlight %}
{% endtabs %}

![UpDown Placement in .NET MAUI NumericEntry](UpDownButton_images/UpDownButtonPlacement.gif)

## Auto reverse in SfNumericEntry

When incrementing, control will begin at the `Minimum` value and progress to the `Maximum` value. When decrementing, control will begin at the `Maximum` value and decreasing to the `Minimum` value.

N> The default value of this boolean property is `false`.
{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry UpDownPlacementMode="Inline"
                        IsEditable=true;
                        Minimum=0;
                        Maximum=10;
                        AutoReverse=true;/>
                     
{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Inputs;

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline;
sfNumericEntry.IsEditable = true;
sfNumericEntry.Minimum=0;
sfNumericEntry.Maximum=10;
sfNumericEntry.AutoReverse = true;
this.Content = sfNumericEntry;

{% endhighlight %}
{% endtabs %}

![AutoReverse support in .NET MAUI NumericEntry](UpDownButton_images/AutoReverseSupport.gif)



---
layout: post
title: Use UpDown Button (Spin Button) in .NET MAUI NumericEntry | Syncfusion
description: Learn here all about how to use UpDown Button (SpinButton) in Syncfusion .NET MAUI NumericEntry (SfNumericEntry) control and more.
platform: winui
control:  SfNumericEntry
documentation: ug
---

# UpDown Button (SpinButton) in .NET MAUI NumericEntry

This section describes how to change value in the `NumericEntry` control using keys, mouse scrolling and the up-down button.

## Increase or decrease value

You can increment or decrement the value in the `NumericEntry` control by using **UpArrow**, **DownArrow**, **PageUp** and **PageDown** keys. You can change the increment or decrement value when Arrow keys are pressed, using the [SmallChange](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Editors.SfNumberBox.html#Syncfusion_UI_Xaml_Editors_SfNumberBox_SmallChange) property and for Page keys using the [LargeChange](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Editors.SfNumberBox.html#Syncfusion_UI_Xaml_Editors_SfNumberBox_LargeChange) property. By default, the value of `SmallChange` property is **1** and `LargeChange` property  is **10**.

N> The value in `NumericEntry` can also be changed by mouse scrolling. The mouse scrolling increases or decreases the value based on the `SmallChange` property.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                     VerticalOptions="Center" 
                     SmallChange="5"
                     Value="10"
                     LargeChange="10" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry SfNumericEntry= new SfNumericEntry();
SfNumericEntry.PlaceholderText = "Enter input here...";
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry Watermark Text](GettingStarted_images/valuechange-bykeys.gif)

## UpDown button placement

You can increase or decrease the value of the `NumericEntry` control using the up-down button. By default, the value of `UpDownPlacementMode` property is **Hidden**. You can change the up-down button position by assigning the value `UpDownPlacementMode` property as **Inline** or **Compact**.

N> When using the up-down button, the `NumericEntry` control value changes based on the value of the `SmallChange` property.

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry x:Name="sfNumericEntry" 
                     HorizontalOptions="Center"
                     VerticalOptions="Center"
                     Value="360";
                     UpDownPlacementMode="Inline" />
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.UpDownPlacementMode = NumberBoxUpDownPlacementMode.Inline;

{% endhighlight %}
{% endtabs %}

![UpDown Placement in .NET MAUI NumericEntry](SpinButton_images/spinbuttonPlacement.gif)

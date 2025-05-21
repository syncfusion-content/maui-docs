---

layout: post
title: Precision Mode in .NET MAUI Rating Control | Syncfusion®
description: Learn about Precision Mode support in the Syncfusion® .NET MAUI Rating (SfRating) control.
platform: maui
control: Rating
documentation: ug

---

# Precision Mode in .NET MAUI Rating (SfRating)

The [`Precision`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html) mode defines the accuracy level of the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. It includes options such as [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard), [`Half`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Half), and [`Exact`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Exact). The default precision mode of the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control is [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard).

## Standard

When the precision mode of [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) is set to [`Standard`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Standard), the rating item is completely filled based on the rating value.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" Precision="Standard" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating();
rating.Precision = Precision.Standard;

{% endhighlight %} 

{% endtabs %}

![SfRating standard precision mode](images/standard.png)

## Half

When the precision mode of [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) is set to [`Half`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Half), the rating item is partially filled based on the rating value.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" Precision="Half" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating();
rating.Precision = Precision.Half;

{% endhighlight %} 

{% endtabs %}

![SfRating half precision mode](images/half.png) 

## Exact

When the precision mode of [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) is set to [`Exact`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html#Syncfusion_Maui_Inputs_Precision_Exact), the rating item is filled exactly based on the rating value.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" Precision="Exact" />
	
{% endhighlight %}

{% highlight c# %}

SfRating rating = new SfRating();
rating.Precision = Precision.Exact;

{% endhighlight %} 

{% endtabs %}

![SfRating exact precision mode](images/exact.png) 


---

layout: post
title: Restrict User Selection in .NET MAUI Rating Control | Syncfusion®
description: Learn about restricting user selection in the Syncfusion® .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Restrict user selection in .NET MAUI Rating (SfRating)

[`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control allows for the configuration of whether rating values are changeable through the use of the [`IsReadOnly`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_IsReadOnly) property. When this property is set to True, the rating becomes unchangeable. By default, the property is set to False.

{% tabs %}

{% highlight xaml %}

<rating:SfRating x:Name="rating" IsReadOnly="true" />

{% endhighlight %}

{% highlight C# %}


SfRating rating = new SfRating();
rating.IsReadOnly = true;

	
{% endhighlight %}

{% endtabs %}

![readOnly](images/IsReadOnly.gif)



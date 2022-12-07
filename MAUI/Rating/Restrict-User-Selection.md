---

layout: post
title: Restrict user Selection in .NET MAUI Rating control | Syncfusion
description: Learn here all about restrict user selection support in Syncfusion .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Restrict user selection in .NET MAUI Rating (SfRating)

[`SfRating`] control provides support for changeable or unchangeable values for Rating control. This is achieved by the [`IsReadOnly`] property. When this property is set to True, the Rating value becomes unchangeable. By default, this property value is set to False.

{% tabs %}

{% highlight C# %}

	rating.IsReadOnly=true;

{% endhighlight %}

{% highlight xaml %}

	<rating:SfRating x:Name="rating" IsReadOnly="true" />
	
{% endhighlight %}

{% endtabs %}

![readOnly](images/IsReadOnly.gif)



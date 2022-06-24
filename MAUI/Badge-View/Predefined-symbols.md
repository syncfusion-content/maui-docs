---

layout: post
title: Predefined symbols of Syncfusion Badge view control for .NET MAUI
description: Learn how to set Syncfusion badge view predefined symbols and types of badge icons in .NET MAUI platform
platform: maui
control: SfBadgeView
documentation: ug

---

# Predefined symbols in .NET MAUI Badge View (SfBadgeView)

The badge icon has been changed using the `Icon` property. Badge icons will be visible when you do not set the badge text. The badge supports the following types of `Icon`.

* Add
* Available
* Away
* Busy
* Delete 
* Dot
* None
* Prohibit1
* Prohibit2

N> When both the `Icon` and `BadgeText` are set for badge view, then badge text has a higher priority. The badge text will be rendered in output.

{% tabs %}

{% highlight xaml hl_lines="6" %}

{% include_relative code-snippet/badge-icon.xaml %}

{% endhighlight %}

{% highlight c# hl_lines="11" %}

{% include_relative code-snippet/badge-icon.cs %}
 
{% endhighlight %}

{% endtabs %}

![BadgeView Badge Icon](predefined-symbols_images/predefinedsymbols.png)


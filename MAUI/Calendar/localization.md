---
layout: post
title: Localization in .NET MAUI Calendar | Syncfusion<sup>&reg;</sup>
description: Learn here all about Localization feature of Syncfusion<sup>&reg;</sup> .NET MAUI Calendar(SfCalendar) control and more. 
platform: maui
control: SfCalendar
documentation: ug
---

# Localization in .NET MAUI Calendar (SfCalendar)

By default, the calendar control supports US English localizations. You can change to other languages by adding the `Globalization` namespace to your application.

The application culture can be changed by setting `CurrentUICulture`. in the `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="2 9" %}

using Syncfusion.Maui.Calendar;
using System.Globalization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("ja-JP");
	}
}

{% endhighlight %}
{% endtabs %}

![Month view localization in .NET MAUI Calendar.](images/localization/maui-month-view-localization.png)

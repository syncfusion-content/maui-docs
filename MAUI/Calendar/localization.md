---
layout: post
title: Localization in MAUI Calendar | Syncfusion
description: Learn here all about Localization feature of Syncfusion MAUI Calendar(SfCalendar) widget and more. 
platform: maui
control: SfCalendar
documentation: ug
---

# Localization in MAUI Calendar (SfCalendar)

By default, the calendar widget supports US English localizations. You can change to other languages by adding the `Globalization` namespace to your application.

{Application culture can be changed by setting `CurrentUICulture.` in `App.xaml.cs` file.

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

![localization-for-monthview-in-maui-calendar](images/localization/localization-for-monthview-in-maui-calendar.png)

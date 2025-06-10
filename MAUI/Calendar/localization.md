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

## Setting CurrentUICulture to the application

The application culture can be changed by setting `CurrentUICulture`. in the `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 2 13 14" %}

using System.Resources;
using Syncfusion.Maui.Calendar;
using System.Globalization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//// ResXPath => Full path of the resx file; 
		//// For example : SfPickerResources.ResourceManager = new ResourceManager("MauiTestCalendarLocalization.Resources.SfCalendar", Application.Current.GetType().Assembly);
		CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("ja-JP");
		SfCalendarResources.ResourceManager = new ResourceManager("ResxPath", Application.Current.GetType().Assembly);
		MainPage = new AppShell();
	}
}

{% endhighlight %}
{% endtabs %}

![Month view localization in .NET MAUI Calendar.](images/localization/maui-month-view-localization.png)

N>
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `Calendar` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add` and then `New Item.`

   3. In Add New Item wizard, select the Resource File option and name the filename as `SfCalendar.<culture name>.resx.` For example, give the name as `SfCalendar.ja-JP.resx` for Japanese culture.

   4. The culture name indicates the name of the language and country.

		![shows-the-name-of-resource-file-to-be-added-for-maui-calendar](images/localization/shows-the-name-of-resource-file-to-be-added-for-maui-calendar.png)

   5. Now, select `Add` option to add the resource file in **Resources** folder.

		![shows-the-added-resource-file-for-french-language-in-maui-calendar](images/localization/shows-the-added-resource-file-for-french-language-in-maui-calendar.png)

   6. Add the Name/Value pair in Resource Designer of `SfCalendar.ja-JP.resx` file and change its corresponding value to corresponding culture.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-calendar](images/localization/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-calendar.png)
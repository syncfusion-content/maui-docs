---
layout: post
title: Localization in .NET MAUI Calendar | Syncfusion
description: Learn here all about Localization feature of Syncfusion .NET MAUI Calendar(SfCalendar) control and more. 
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

## Localize application level

To localize the `Calendar` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   3. In Add New Item wizard, select the Resource File option and name the filename as `SfCalendar.<culture name>.resx.` For example, give the name as `SfCalendar.fr-FR.resx` for French culture.

   4. The culture name indicates the name of the language and country.

        ![shows-the-name-of-resource-file-to-be-added-for-maui-calendar](images/localization/maui-calendar-resxfile-creation.png)

   5. Now, select `Add` option to add the resource file in **Resources** folder.

        ![shows-the-added-resource-file-for-french-language-in-maui-calendar](images/localization/maui-calendar-resxfile.png)

   6. Add the Name/Value pair in Resource Designer of `SfCalendar.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-calendar](images/localization/maui-calendar-custom texts.png)

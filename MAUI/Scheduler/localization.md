---
layout: post
title: Localization in .NET MAUI Scheduler control | Syncfusion®
description: Learn here all about Localization support in Syncfusion<sup>&reg;</sup> .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Localization in .NET MAUI Scheduler (SfScheduler)

Localization is the process of translating the application resources into different language for the specific cultures. The `SfScheduler` can be localized by adding `resource` file. The SfScheduler allows you to localize the following built-in strings to suit your application’s language and culture:
<<<<<<< HEAD
=======

* Day
* Week
* WorkWeek
* Month
* TimelineDay
* TimelineWeek
* TimelineWorkWeek
* TimelineMonth
* Agenda
* Today
* NoEvents
* AllDay
>>>>>>> master

* Day
* Week
* WorkWeek
* Month
* TimelineDay
* TimelineWeek
* TimelineWorkWeek
* TimelineMonth
* Agenda
* Today
* NoEvents
* AllDay
 
## Setting CurrentUICulture to the application

Application culture can be changed by setting `CurrentUICulture.` in `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 2 9 13" %}

using Syncfusion.Maui.Scheduler;
using System.Resources;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
      //// ResXPath => Full path of the resx file; For example : //SfScheduleResources.ResourceManager = new ResourceManager
      // ("MauiSchedulerDemo.Resources.SfScheduler", Application.Current.GetType().Assembly);

		SfScheduleResources.ResourceManager = new ResourceManager(ResXPath, Application.Current.GetType().Assembly);
	   MainPage = new MainPage();
	}
}

{% endhighlight %}
{% endtabs %}

N>
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `Scheduler` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Add the default resource file of `Scheduler` into `Resources` folder of the application.

   ![addition-of-default-resource-file-of-maui-Scheduler-into-resources-folder](images/localization/addition-of-default-resource-file-of-maui-Scheduler-into-resources-folder.png)

   2. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   3. In Add New Item wizard, select the Resource File option and name the filename as `SfScheduler.<culture name>.resx.` For example, give the name as `SfScheduler.fr-FR.resx` for French culture.

   4. The culture name indicates the name of the language and country.

   ![shows-the-name-of-resource-file-to-be-added-for-maui-scheduler](images/localization/shows-the-name-of-resource-file-to-be-added-for-maui-scheduler.png)

   5. Now, select `Add` option to add the resource file in **Resources** folder.

   ![shows-the-added-resource-file-for-french-language-in-maui-scheduler](images/localization/shows-the-added-resource-file-for-french-language-in-maui-scheduler.png)

   6. Add the Name/Value pair in Resource Designer of `SfScheduler.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-scheduler](images/localization/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-scheduler.png)

   The complete sample can be downloaded from [GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/Localization).
   
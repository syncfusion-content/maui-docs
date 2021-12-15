---
layout: post
title: Localization in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about Localization support in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Localization in .NET MAUI Scheduler (SfScheduler)

Localization is the process of translating the application resources into different language for the specific cultures. The `SfScheduler` can be localized by adding `resource` file. 

## Set Current UI Culture to the Application

Application culture can be changed by setting `CurrentUICulture.` in `App.xaml.cs` file.

{% tabs %}
{% highlight c# %}

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
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contains culture code) into the `Resources` folder.

## Localize at Sample Level

To localize the `Scheduler` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Add the default resource file of `Scheduler` into `Resources` folder.

   3. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   4. In Add New Item wizard, select the Resource File option and name the filename as `SfScheduler.<culture name>.resx.` For example, give the name as `SfScheduler.fr-FR.resx` for French culture.

   5. The culture name that indicates the name of language and country.

   6. Add the Name/Value pair in Resource Designer of `SfScheduler.fr-FR.resx` file and change its corresponding value to corresponding culture.
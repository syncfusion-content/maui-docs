---
layout: post
title: Localization in .NET MAUI Date Time Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn about localization support in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Localization in .NET MAUI Date Time Picker (SfDateTimePicker)

Localization is the process of translating the application resources into different language for the specific cultures. The `SfDateTimePicker` can be localized by adding `resource` file. In `SfDateTimePicker`, provides the support to localize the below strings

   * `Day`
   * `Month`
   * `Year`
   * `Hour`
   * `Minute`
   * `Second`
   * `Meridien`
   * `OK`
   * `Cancel`

## Setting CurrentUICulture to the application

Application culture can be changed by setting `CurrentUICulture.` in `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 3 11 15" %}

using Syncfusion.Maui.Picker;
using System.Globalization;
using System.Resources;

namespace DateTimePicker;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
      //// ResXPath => Full path of the resx file; For example : //SfPickerResources.ResourceManager = new ResourceManager
      // ("DateTimePicker.Resources.SfDateTimePicker", Application.Current.GetType().Assembly);

		SfPickerResources.ResourceManager = new ResourceManager("ResxPath", Application.Current.GetType().Assembly);
	   MainPage = new MainPage();
	}
}

{% endhighlight %}
{% endtabs %}

   ![Date Time picker Date localization in .NET MAUI Date Picker.](images/localization/maui-date-time-picker-date-localization.png)

   ![Date Time picker Time localization in .NET MAUI Date Picker.](images/localization/maui-date-time-picker-time-localization.png)

N>
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `DateTimePicker` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   3. In Add New Item wizard, select the Resource File option and name the filename as `SfDateTimePicker.<culture name>.resx.` For example, give the name as `SfDateTimePicker.fr-FR.resx` for French culture.

   4. The culture name indicates the name of the language and country.

   ![shows-the-name-of-resource-file-to-be-added-for-maui-date-time-picker](images/localization/shows-the-name-of-resource-file-to-be-added-for-maui-date-time-picker.png)


   5. Now, select `Add` option to add the resource file in **Resources** folder.

   ![shows-the-added-resource-file-for-french-language-in-maui-date-time-picker](images/localization/shows-the-added-resource-file-for-french-language-in-maui-date-time-picker.png)

   6. Add the Name/Value pair in Resource Designer of `SfDateTimePicker.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-date-time-picker](images/localization/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-date-time-picker.png)
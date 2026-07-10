---
layout: post
title: Localization in .NET MAUI Date Picker Control | Syncfusion®
description: Learn about localization support in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control.
platform: maui
control: SfDatePicker
documentation: ug
---

# Localization in .NET MAUI Date Picker (SfDatePicker)

Localization is the process of translating application resources into different languages for specific cultures. The `SfDatePicker` can be localized by adding a resource file. `SfDatePicker` provides support to localize the following strings:

* `Day`
* `Month`
* `Year`
* `OK`
* `Cancel`

## Prerequisites

Before localizing `SfDatePicker`, ensure the following NuGet package is installed in your .NET MAUI project:

* [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker) (version `26.1.42` or higher, which contains the `SfPickerResources` class).

## Localize at the application level

To localize the `DatePicker` based on `CurrentUICulture` using resource files, follow these steps.

1. Create a new folder named `Resources` in the application.

2. Right-click the `Resources` folder, then select **Add** and then **New Item**.

3. In the **Add New Item** wizard, select **Resource File** and name the file `SfDatePicker.<culture name>.resx`. For example, name the file `SfDatePicker.fr-FR.resx` for the French culture.

4. The culture name is a language-country code, such as `fr-FR`.

   ![Selecting the resource file name for adding to a .NET MAUI Date Picker project](images/localization/shows-the-name-of-resource-file-to-be-added-for-maui-date-picker.png)

5. Select **Add** to add the resource file to the **Resources** folder.

   ![Resource file added to the Resources folder for French language in .NET MAUI Date Picker](images/localization/shows-the-added-resource-file-for-french-language-in-maui-date-picker.png)

6. Set the **Build Action** of the new `.resx` file to `EmbeddedResource`:
   * Right-click the `.resx` file in **Solution Explorer** and choose **Properties**.
   * In the **Properties** window, set **Build Action** to `EmbeddedResource`.

7. Open the `.resx` file in the Resource Designer (double-click the file). Add a Name/Value pair for each of the keys below and set the value to the translated string.

   | Name   | Value (sample French translation) |
   |--------|-----------------------------------|
   | Day    | Jour                               |
   | Month  | Mois                               |
   | Year   | Année                              |
   | OK     | OK                                 |
   | Cancel | Annuler                            |

   ![Adding Name/Value pairs in the Resource Designer for a .NET MAUI Date Picker](images/localization/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-date-picker.png)

8. Repeat steps 3-7 for each culture you want to support, using the appropriate culture code (for example, `de-DE` for German, `es-ES` for Spanish).

N>
The resx files must have **Build Action** set to `EmbeddedResource` and the file name must contain the culture code (for example, `SfDatePicker.fr-FR.resx`).

## Setting the CurrentUICulture for the application

After creating the resx files, set the application culture in `App.xaml.cs`. The `SfPickerResources.ResourceManager` must point to the fully qualified name of your resx file, where the name combines the project default namespace, the `Resources` folder, and the resx base name (for example, `DatePicker.Resources.SfDatePicker`).

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 3 12 16" %}

using Syncfusion.Maui.Picker.Resources;
using System.Globalization;
using System.Resources;

namespace DatePicker;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");

		// ResXPath => Fully qualified resource name of the resx file. For example:
		// "DatePicker.Resources.SfDatePicker" where "DatePicker" is the project's default namespace,
		// "Resources" is the folder that contains the resx file, and "SfDatePicker" is the resx base name.
		SfPickerResources.ResourceManager = new ResourceManager("DatePicker.Resources.SfDatePicker", Application.Current.GetType().Assembly);
		MainPage = new MainPage();
	}
}

{% endhighlight %}
{% endtabs %}

![Date picker localization in .NET MAUI Date Picker](images/localization/maui-date-picker-localization.png)

## Troubleshooting

* **Strings still appear in English at runtime:**
  * Verify that the resx file name ends with the culture code matching `CurrentUICulture` (for example, `SfDatePicker.fr-FR.resx` for `fr-FR`).
  * Confirm the resx file's **Build Action** is set to `EmbeddedResource`.
  * Confirm the fully qualified resource name passed to `ResourceManager` matches the project default namespace plus the `Resources` folder plus the resx base name.
* **Compile error: `SfPickerResources` not found:** Ensure the `Syncfusion.Maui.Picker` NuGet package (version `26.1.42` or higher) is installed and the `using Syncfusion.Maui.Picker.Resources;` directive is present.
* **Some strings change but others do not:** Confirm each required Name (`Day`, `Month`, `Year`, `OK`, `Cancel`) is present in the resx file with the correct spelling and casing.
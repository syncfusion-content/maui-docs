---
layout: post
title: Localization in .NET MAUI Color Picker control | Syncfusion®
description: Learn here all about Localization support in Syncfusion® .NET MAUI Color Picker (SfColorPicker) control and more.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, color picker, color palette, localization
---

# Localization in .NET MAUI Color Picker (SfColorPicker)

Localization is the process of translating the application resources into different languages for specific cultures. The [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) can be localized by adding `resource` file.

## Setting CurrentUICulture to the application

The application's culture can be changed by setting `CurrentUICulture` in the `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 2 9 13" %}

using Syncfusion.Maui.Inputs;
using System.Resources;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
      // ResXPath => Full path of the resx file; For example : //SfColorPickerResources.ResourceManager = new ResourceManager
      // ("ColorPickerLocalization.Resources.SfColorPicker", Application.Current.GetType().Assembly);

		SfColorPickerResources.ResourceManager = new ResourceManager(ResXPath, Application.Current.GetType().Assembly);
	}
}

{% endhighlight %}
{% endtabs %}

![.NET MAUI Color Picker localization](images/localization/localization.png)

N>
Ensure that the required `resx` files are included with `Build Action` set as `EmbeddedResource`, and the file name contains the culture code, within the `Resources` folder.

## Localize application level

To localize the `Color Picker` based on `CurrentUICulture` using `resource` files, follow the steps below:

   First we need to add the default resource file of `Color Picker` into `Resources` folder of the application.

   1. Right-click on the `Resources` folder, select `Add`, and then `NewItem`.

   2. In the `Add New Item` wizard, select the `Resources File` option and name the file as `SfColorPicker.<culture name>.resx.` For example, name it `SfColorPicker.fr-FR.resx` for the French culture.

   3. The culture name indicates the name of the language and country.

   ![resource-file-name](images/localization/resource-file-name.png)

   5. Click the `Add` option to add the resource file to the **Resources** folder.

   ![resources-folder](images/localization/resource-file.png)

   6. Add the Name/Value pair in the Resource Designer of the `SfColorPicker.fr-FR.resx` file and change its corresponding value to match the corresponding culture.

   ![resource-file-name-value-pair](images/localization/add-name-value-pair.png)
---
layout: post
title: Localization with .NET MAUI Picker Control | Syncfusion
description: Learn here all about localization with Syncfusion<sup>&reg;</sup> .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Localization in .NET MAUI Picker (SfPicker)

Localization is the process of translating the application resources into different language for the specific cultures. The SfPicker can be localized by adding resource file.

## Setting CurrentUICulture to the application

Application culture can be changed by setting CurrentUICulture. in App.xaml.cs file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 3 14 15" %}

using System.Resources;
using System.Globalization;
using Syncfusion.Maui.Picker;

namespace Picker;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //// ResXPath => Full path of the resx file; For example : // SfPickerResources.ResourceManager = new ResourceManager
("Picker.Resources.SfPicker", Application.Current.GetType().Assembly);
        CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
        SfPickerResources.ResourceManager = new ResourceManager("ResxPath", Application.Current.GetType().Assembly);
        MainPage = new AppShell();
    }
}

{% endhighlight %}
{% endtabs %}

   ![Picker localization in .NET MAUI Date Picker.](images/localization/maui-picker-localization.png)

N>
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `Picker` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   3. In Add New Item wizard, select the Resource File option and name the filename as `SfPicker.<culture name>.resx.` For example, give the name as `SfPicker.fr-FR.resx` for French culture.

   4. The culture name indicates the name of the language and country.

        ![shows-the-name-of-resource-file-to-be-added-for-maui-picker](images/localization/shows-the-name-of-resource-file-to-be-added-for-maui-picker.png)

   5. Now, select `Add` option to add the resource file in **Resources** folder.

        ![shows-the-added-resource-file-for-french-language-in-maui-picker](images/localization/shows-the-added-resource-file-for-french-language-in-maui-picker.png)

   6. Add the Name/Value pair in Resource Designer of `SfPicker.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-picker](images/localization/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-picker.png)
---
layout: post
title: Localization with .NET MAUI Picker Control | Syncfusion
description: Learn here all about localization with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Localization in .NET MAUI Picker (SfPicker)

Localization is the process of translating the application resources into different language for the specific cultures. The SfPicker can be localized by adding resource file.

## Setting CurrentUICulture to the application

Application culture can be changed by setting CurrentUICulture. in App.xaml.cs file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" %}

    using System.Resources;
    using System.Globalization;
    using Syncfusion.Maui.Picker;

    namespace Picker_29;
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //// ResXPath => Full path of the resx file; For example : // SfPickerResources.ResourceManager = new ResourceManager
    ("Picker_29.Resources.SfPicker", Application.Current.GetType().Assembly);
            CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
            SfPickerResources.ResourceManager = new ResourceManager("Picker_29.Resources.SfPicker", Application.Current.GetType().Assembly);
            MainPage = new AppShell();
        }
    }

{% endhighlight %}
{% endtabs %}

N>
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `Picker` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Add the default resource file of `Picker` into `Resources` folder.

   3. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   4. In Add New Item wizard, select the Resource File option and name the filename as `SfSPicker.<culture name>.resx.` For example, give the name as `SfPicker.fr-FR.resx` for French culture.

   5. The culture name indicates the name of the language and country.

   6. Now, select `Add` option to add the resource file in **Resources** folder.

   7. Add the Name/Value pair in Resource Designer of `SfPicker.fr-FR.resx` file and change its corresponding value to corresponding culture.
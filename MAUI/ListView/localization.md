---
layout: post
title: Localization in .NET MAUI SfListView control | Syncfusion
description: Learn here all about Localization feature of Syncfusion .NET MAUI ListView (SfListView) control and its elements, and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Localization in .NET MAUI ListView (SfListView)

`Localization` is the process of translating the application resources into different languages for specific cultures. The [SfListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Listview.SfListView.html) can be localized by adding a `resource` file.

## Setting CurrentUICulture to the application

Application culture can be changed by setting the `CurrentUICulture` in the `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 3 12 13" %}

      using Syncfusion.Maui.ListView;
      using System.Globalization;
      using System.Resources;

      namespace MauiListView
      {
         public partial class App : Application
         {
            public App()
            {
                  InitializeComponent();             
                  CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");   
                  SfListViewResources.ResourceManager = new ResourceManager("MauiListView.Resources.SfListView", Application.Current!.GetType().Assembly);
                  MainPage = new MainPage();
            }
         }
      }

{% endhighlight %}
{% endtabs %}

N> The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `ListView` based on the `CurrentUICulture` using the `resource` files, follow these steps.

   1. Create a new folder named `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add`, then click on `NewItem`.

   3. In the Add New Item wizard, select the Resource File option and name the filename as `SfListView.<culture name>.resx`. For example, give the name as `SfListView.fr-FR.resx` for French culture.

   4. The culture name indicates the name of the language and country.

   ![Shows the name of resource file to be added for .NET MAUI ListView](images/localization/maui-listview-shows-the-name-of-resource-file-to-be-added.png)

   5. Now, select `Add` option to add the resource file in the **Resources** folder.

   ![Shows the added resource file for french language in .NET MAUI ListView](images/localization/maui-listview-shows-the-added-resource-file-for-french-language.png)

   6. Add the Name or Value pair in the Resource Designer of `SfListView.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![Shows the added resource file name value pair in the resource designer in.NET MAUI ListView](images/localization/maui-listview-shows-the-added-resource-file-name-value-pair-in-the-resource-designer.png)

   ![Localized content in .NET MAUI ListView](images/localization/maui-listview-with-localized-content.png)


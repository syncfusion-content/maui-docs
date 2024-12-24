---
layout: post
title: Localization in .NET MAUI Kanban control | Syncfusion®
description: Learn here all about Localization support in Syncfusion® .NET MAUI Kanban (SfKanban) control and more.
platform: maui
control: Kanban
documentation: ug
keywords: .net maui Kanban localization, sfKanban localization in .net maui, .net maui Kanban localization support, .net maui Kanban language settings, maui Kanban language support.
---

# Localization in .NET MAUI Kanban (SfKanban)

Localization is the process of translating the application resources into different language for the specific cultures. The [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) can be localized by adding `resource` file. 

## Setting CurrentUICulture to the application

Application culture can be changed by setting `CurrentUICulture.` in `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 2 9 15" %}

using Syncfusion.Maui.Kanban;
using System.Globalization;
using System.Resources;

public partial class App : Application
{
	public App()
	{
            InitializeComponent();
            CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
            // ResXPath => Full path of the resx file; For example : 
            // SfKanbanResources.ResourceManager = new ResourceManager
            // ("KanbanSample.Resources.SfKanban", Application.Current.GetType().Assembly);

            var ResXPath = "KanbanSample.Resources.SfKanban";
            SfKanbanResources.ResourceManager = new ResourceManager(ResXPath, Application.Current.GetType().Assembly);
            MainPage = new AppShell();
	}
}


{% endhighlight %}
{% endtabs %}

N> The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `Kanban` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   2. In Add New Item, select the Resource File option and name the filename as `SfKanban.<culture name>.resx.` For example, give the name as `SfKanban.fr-FR.resx` for French culture.

   3. The culture name indicates the name of the language and country.

   ![shows-the-name-of-resource-file-to-be-added-for-maui-Kanban](Localization_images/name_of_resource_file.png)

   4. Now, select `Add` option to add the resource file in **Resources** folder.

   ![shows-the-added-resource-file-for-french-language-in-maui-Kanban](Localization_images/shows-the-added-resource-file-for-french-language-in-maui-kanban.png)

   5. Add the Name/Value pair in Resource Designer of `SfKanban.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-kanban](Localization_images/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-Kanban.png)

Here, you can see how localization was performed for the Items and Min.
   ![example-for-localization](Localization_images/example_for_localization.png)

---
layout: post
title: Localization in .NET MAUI Kanban control | Syncfusion
description: Learn here all about Localization support in Syncfusion® .NET MAUI Kanban (SfKanban) control and more.
platform: maui
control: Kanban
documentation: ug
keywords: .net maui Kanban localization, sfKanban localization in .net maui, .net maui Kanban localization support, .net maui Kanban language settings, maui Kanban language support.
---

# Localization in .NET MAUI Kanban (SfKanban)

Localization is the process of translating application resources for specific cultures. The [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) can be localized by adding `.resx` resource files.

## Setting the CurrentUICulture

Set `CurrentUICulture` in `App.xaml.cs` to change the application culture.

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

N> Add the required `.resx` files (with the culture code in the file name, for example `SfKanban.fr-FR.resx`) to the `Resources` folder, and set their build action to `EmbeddedResource` in the `.csproj`:

## Localize application level

## Localize application level

To localize the Kanban Board based on `CurrentUICulture`, follow these steps:

   1. Right-click the `Resources` folder, then select **Add > New Item**.

   2. In the **Add New Item** dialog, select **Resource File** and name the file `SfKanban.<culture name>.resx` (for example, `SfKanban.fr-FR.resx` for French). The culture name combines the language and country codes.

   ![shows-the-name-of-resource-file-to-be-added-for-maui-Kanban](Localization_images/name_of_resource_file.png)

   4. Click **Add** to add the resource file to the **Resources** folder.

   ![shows-the-added-resource-file-for-french-language-in-maui-kanban](Localization_images/shows-the-added-resource-file-for-french-language-in-maui-kanban.png)

   5. In the Resource Designer of `SfKanban.fr-FR.resx`, add a Name/Value pair and set the Value to the corresponding culture-specific string.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-kanban](Localization_images/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-Kanban.png)

Here, you can see how localization was performed for the Items and Min.
   ![example-for-localization](Localization_images/example_for_localization.png)

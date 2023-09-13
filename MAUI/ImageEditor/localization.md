---
layout: post
title: Localization in .NET MAUI Image Editor Control | Syncfusion
description: Learn about the localization feature in the Syncfusion .NET MAUI Image Editor(SfImageEditor) control and more.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# The Localization in .NET MAUI Image Editor (SfImageEditor)

Localization is the process of translating the application resources into different language for the specific cultures. The Image Editor can be localized by adding `resource` file.

## Setting CurrentUICulture to the application

Application culture can be changed by setting `CurrentUICulture.` in `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 2 9 13" %}

using Syncfusion.Maui.ImageEditor;
using System.Resources;

public partial class App : Application
{
	public App()
	{	    
        CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
        //// ResXPath => Full path of the resx file; For example : //SfImageEditorResources.ResourceManager = new ResourceManager
        // ("MauiImageEditorDemo.Resources.SfImageEditor", Application.Current.GetType().Assembly);

        SfImageEditorResources.ResourceManager = new ResourceManager("ImageEditorLocalization.Resources.SfImageEditor", Application.Current.GetType().Assembly);
        MainPage = new MainPage();
	}
}

{% endhighlight %}
{% endtabs %}

## Localize application level

To localize the `ImageEditor` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Add the default resource file of `ImageEditor` into `Resources` folder.

   ![addition-of-default-resource-file-of-maui-ImageEditor-into-resources-folder](images/localization/addition-of-default-resource-file-of-maui-ImageEditor-into-resources-folder.png)

   3. Right-click on the `Resources` folder, select `Add` and then `NewItem`.

   4. In Add New Item wizard, select the Resource File option and name the filename as `SfImageEditor.<culture name>.resx.` For example, give the name as `SfImageEditor.fr-FR.resx` for French culture.

   5. The culture name indicates the name of the language and country.

   ![shows-the-name-of-resource-file-to-be-added-for-maui-ImageEditor](images/localization/shows-the-name-of-resource-file-to-be-added-for-maui-ImageEditor.png)

   6. Now, select `Add` option to add the resource file in **Resources** folder.

   ![shows-the-added-resource-file-for-french-language-in-maui-ImageEditor](images/localization/shows-the-added-resource-file-for-french-language-in-maui-ImageEditor.png)

   7. Add the Name/Value pair in Resource Designer of `SfImageEditor.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-ImageEditor](images/localization/shows-the-added-resource-file-name-value-pair-in-the-resource-designer-in-maui-ImageEditor.png)

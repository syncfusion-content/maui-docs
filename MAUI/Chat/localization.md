---
layout: post
title: Localization in .NET MAUI SfChat control | Syncfusion
description: Learn here all about Localization feature of Syncfusion .NET MAUI Chat(SfChat) control and more. 
platform: MAUI
control: SfChat
documentation: ug
---

# Localization in .NET MAUI Chat (SfChat)

`Localization` is the process of translating the application resources into different languages for specific cultures. The [SfChat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html) can be localized by adding a `resource` file.

## Setting CurrentUICulture to the application

Application culture can be changed by setting the `CurrentUICulture` in the `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 3 12 13" %}

      using Syncfusion.Maui.Chat;
      using System.Globalization;
      using System.Resources;

      namespace MauiChat
      {
         public partial class App : Application
         {
            public App()
            {
                  InitializeComponent();             
                  CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");   
                  SfChatResources.ResourceManager = new ResourceManager("MauiChat.Resources.SfChat", Application.Current!.GetType().Assembly);
                  MainPage = new MainPage();
            }
         }
      }

{% endhighlight %}
{% endtabs %}

N> The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `Chat` based on the `CurrentUICulture` using the `resource` files, follow these steps.

   1. Create a new folder named `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add`, then click on `NewItem`.

   3. In the Add New Item wizard, select the Resource File option and name the filename as `SfChat.<culture name>.resx`. For example, give the name as `SfChat.fr-FR.resx` for French culture.

   4. The culture name indicates the name of the language and country.

   ![Shows the name of resource file to be added for .NET MAUI Chat](images/localization/maui-chat-shows-the-name-of-resource-file-to-be-added.png)

   5. Now, select `Add` option to add the resource file in the **Resources** folder.

   ![Shows the added resource file for french language in .NET MAUI Chat](images/localization/maui-chat-shows-the-added-resource-file-for-french-language.png)

   6. Add the Name or Value pair in the Resource Designer of `SfChat.fr-FR.resx` file and change its corresponding value to corresponding culture.

   ![Shows the added resource file name value pair in the resource designer in.NET MAUI Chat](images/localization/maui-chat-shows-the-added-resource-file-name-value-pair-in-the-resource-designer.png)

   ![Localized content in .NET MAUI Chat](images/localization/maui-chat-with-localized-content.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/localization-for-.net-maui-chat)

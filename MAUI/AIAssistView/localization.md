---
layout: post
title: Localization in .NET MAUI AI AssistView control | Syncfusion®
description: Learn here all about Localization feature of Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control and its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Implement Localization in .NET MAUI SfAIAssistView?

`Localization` is the process of translating the application resources into different languages for specific cultures. The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) can be localized by adding a `resource` file.

## Setting the CurrentUICulture in the Application

Application culture can be changed by setting the `CurrentUICulture` in the `App.xaml.cs` file.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 3 12 13" %}

using Syncfusion.Maui.AIAssistView;
using System.Globalization;
using System.Resources;

namespace MauiAssistView
{
   public partial class App : Application
   {
      public App()
      {
            InitializeComponent();             
            CultureInfo.CurrentUICulture = new CultureInfo("es");   
            SfAIAssistViewResources.ResourceManager = new ResourceManager("MauiAssistView.Resources.SfAIAssistView", Application.Current!.GetType().Assembly);
            MainPage = new MainPage();
      }
   }
}

{% endhighlight %}
{% endtabs %}

N> The required `resx` files (a default `SfAIAssistView.resx` and one or more culture-specific `SfAIAssistView.<culture code>.resx` files) must be added with `Build Action` set to `EmbeddedResource` to the `Resources` folder. The file name of culture-specific resx files must include the culture code (for example, `SfAIAssistView.es.resx` for Spanish).

## Localize application level

To localize the `AI AssistView` based on the `CurrentUICulture` using `resource` files, follow these steps.

   1. Create a new folder named `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add`, then click on `NewItem`.

   3. In the Add New Item wizard, select the Resource File option and name the filename as `SfAIAssistView.<culture code>.resx`. For example, give the name as `SfAIAssistView.es.resx` for Spanish culture.

   4. The culture code identifies the language (and optionally the country/region).

   ![Syncfusion .NET MAUI AI AssistView Shows the name of resource file to be added](images/localization/maui-aiassistview-shows-the-name-of-resource-file-to-be-added.png)

   5. Now, select the `Add` option to add the resource file in the **Resources** folder.

   ![Syncfusion .NET MAUI AI AssistView Shows the added resource file for Spanish language](images/localization/maui-aiassistview-shows-the-added-resource-file-for-spanish-language.png)

   6. Add the Name/Value pair in the Resource Designer of `SfAIAssistView.es.resx` file and change its corresponding value to the text for the target culture.

  ![Syncfusion .NET MAUI AI AssistView Shows the added resource file name value pair in the resource designer](images/localization/maui-aiassistview-shows-the-added-resource-file-name-value-pair-in-the-resource-designer.png)

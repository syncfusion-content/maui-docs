---
layout: post
title: Localization in .NET MAUI AI AssistView control | Syncfusion®
description: Learn here all about the localization feature of Syncfusion® .NET MAUI AI AssistView control and its elements, and more
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Localization in .NET MAUI AI AssistView

`Localization` is the process of translating application resources into different languages for specific cultures. The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) can be localized by adding `resx` resource files. The `SfAIAssistView` allows you to localize the following built-in strings to suit your application’s language and culture:

<table>
<tr>
<th> Name </th>
<th> Value </th>
</tr>
<tr>
<td> HeaderText </td>
<td> How can I help you? </td>
</tr>
<tr>
<td> EditorPlaceholder </td>
<td> Type here... </td>
</tr>
<tr>
<td> Filter </td>
<td> Filter </td>
</tr>
<tr>
<td> FilterAll </td>
<td> All </td>
</tr>
<tr>
<td> FilterToday </td>
<td> Today </td>
</tr>
<tr>
<td> FilterYesterday </td>
<td> Yesterday </td>
</tr>
<tr>
<td> FilterLast7Days </td>
<td> Last 7 days </td>
</tr>
<tr>
<td> FilterLast30Days </td>
<td> Last 30 days </td>
</tr>
<tr>
<td> AgentsTitle </td>
<td> Agents </td>
</tr>
<tr>
<td> ConversationDeleteSuccess </td>
<td> Chat deleted successfully </td>
</tr>
<tr>
<td> ConversationFilterNoResults </td>
<td> No results found </td>
</tr>
<tr>
<td> ConversationFilterPinned </td>
<td> Pinned </td>
</tr>
<tr>
<td> SuccessAnnouncement </td>
<td> Success </td>
</tr>
<tr>
<td> ErrorAnnouncement </td>
<td> Error </td>
</tr>
<tr>
<td> WarningAnnouncement </td>
<td> Warning </td>
</tr>
<tr>
<td> NetworkError </td>
<td> Network error. Please check your connection. </td>
</tr>
<tr>
<td> FileSizeExceeded </td>
<td> Error: File size must not exceed 5 MB. </td>
</tr>
<tr>
<td> FileUploadFailed </td>
<td> Upload failed </td>
</tr>
<tr>
<td> FileUploadSuccess </td>
<td> Uploaded successfully </td>
</tr>
<tr>
<td> ResponseCopied </td>
<td> Response copied! </td>
</tr>
<tr>
<td> MaximumUploadItemsExceeded </td>
<td> Maximum {0} items can be uploaded at a time. </td>
</tr>
<tr>
<td> MicrophonePermissionDenied </td>
<td> Microphone permission denied </td>
</tr>
<tr>
<td> NoSpeechDetected </td>
<td> No speech detected. Please try again. </td>
</tr>
<tr>
<td> VoiceRecognitionError </td>
<td> Voice recognition failed </td>
</tr>
<tr>
<td> VoiceRecognitionTimeout </td>
<td> Recognition timeout. Please try again. </td>
</tr>
</table>

## Setting the CurrentUICulture in the application

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

To localize `AI AssistView` based on `CurrentUICulture` using `resource`  files, follow these steps.

### Steps to add resource files

   1. Create a new folder named `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add`, then click on `NewItem`.

   3. In the Add New Item wizard, select the Resource File option and name the file as `SfAIAssistView.<culture code>.resx`.

      For example, use `SfAIAssistView.es.resx` for Spanish culture.

   4. The culture code identifies the language (and optionally the country/region).

   ![Syncfusion .NET MAUI AI AssistView Shows the name of resource file to be added](images/localization/maui-aiassistview-shows-the-name-of-resource-file-to-be-added.png)

   5. Now, select the `Add` option to add the resource file in the **Resources** folder.

   ![Syncfusion .NET MAUI AI AssistView Shows the added resource file for Spanish language](images/localization/maui-aiassistview-shows-the-added-resource-file-for-spanish-language.png)

   6. Set Build Action to EmbeddedResource for the culture-specific resx file.

   7. Add the Name/Value pairs in the Resource Designer of `SfAIAssistView.es.resx` and update each value for the target culture.

  ![Syncfusion .NET MAUI AI AssistView Shows the added resource file name value pair in the resource designer](images/localization/maui-aiassistview-shows-the-added-resource-file-name-value-pair-in-the-resource-designer.png)

### Activation and behavior

After configuration, the `AIAssistView` uses the localized strings when the application starts. Localization is applied based on the `CurrentUICulture` set in the App constructor. If a translated string is unavailable for a specific culture, `AIAssistView` falls back to the neutral resource file (SfAIAssistView.resx) or uses the hard coded English default. Changing the culture at runtime requires reassigning the ResourceManager and may require an application restart for the changes to take effect in all UI elements.

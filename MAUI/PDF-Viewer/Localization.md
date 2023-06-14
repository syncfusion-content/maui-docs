---
layout: post
title: Localization in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about to localize the static text used in the Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control to other languages .
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Localization in .NET MAUI PDF Viewer (SfPdfViewer)

Localization is the process of translating the application resources into a different language for the specific cultures. [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) is set up by default with the language code `en-US`. However, by including a resource file (.resx) in the application with the language code, the static text used in the `SfPdfViewer` can be localized to a different language. 

Follow the instructions given to apply localization to the `SfPdfViewer`.

## Change the current user interface culture

Set the [CurrentUICulture](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.currentuiculture?view=net-7.0) property in the `App.xaml.cs` file to the desired user interface culture. Refer to the following code sample to change the current culture to `French`.

{% tabs %}
{% highlight C# tabtitle="App.xaml.cs"  hl_lines="10" %}

using System.Globalization;

namespace PdfViewerLocalization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
        MainPage = new AppShell();
	}
}

{% endhighlight %}
{% endtabs %}

## Create and add the resource file to the application

Follow the given steps to create and add the resource file to the application.

1. Right-click on the `Resources` folder in the application.

    ![Resources folder in the .NET MAUI PDF Viewer application.](Images/Localization/Resources.png)

2. Click the `Add` option and then select `NewItem`.

    ![Add new item in the .NET MAUI PDF Viewer application.](Images/Localization/NewItem.png)

3. In the `Add New Item` wizard, select the `Resource File` option and name the file in the format `<control name>.<culture name>.resx`. For example, name the file as SfPdfViewer.fr.resx for `French` culture.

    ![Adding resource file in the .NET MAUI PDF Viewer application.](Images/Localization/Resx.png)

4. Click the `Add` option to add the resource file in the Resources folder.

5. Change the `Build Action` of the resource file as `Embedded resource`.

    ![Build action of resource file](Images/Localization/BuildAction.png)

6. Double tap on the resource file to add the name and value details in the Resource Designer. You can refer to the default names and values in the following section:
 
    ![Localization name value pair in the .NET MAUI PDF Viewer application.](Images/Localization/NameValue.png)
	
7. Set the `ResourceManager` as shown in the following code example, that looks up the resource file with the specified root name.
 
{% tabs %}
{% highlight C# tabtitle="App.xaml.cs"  hl_lines="13 14" %}

using System.Resources;
using System.Globalization;
using Syncfusion.Maui.PdfViewer;

namespace PdfViewerLocalization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
        SfPdfViewerResources.ResourceManager = new ResourceManager("PdfViewerLocalization.Resources.SfPdfViewer", 
			Application.Current.GetType().Assembly);
        MainPage = new AppShell();
	}
}

{% endhighlight %}
{% endtabs %}

## Default names and values

The following table contains the default name and value details used in the SfPdfViewer in the `en-US` 

<table>
<tr>
<th>Name</th>
<th>Value</th>
</tr>
<tr>
<td>Cancel</td>
<td>CANCEL</td>
</tr>
<tr>
<td>CanOpenWebPage</td>
<td>Do you want to open</td>
</tr>
<tr>
<td>Close</td>
<td>CLOSE</td>
</tr>
<tr>
<td>DocumentLoadFailed</td>
<td>Failed to load the PDF document.</td>
</tr>
<tr>
<td>EnterPassword</td>
<td>Enter Password</td>
</tr>
<tr>
<td>Error</td>
<td>Error</td>
</tr>
<tr>
<td>NoOutline</td>
<td>No outline</td>
</tr>
<tr>
<td>Ok</td>
<td>OK</td>
</tr>
<tr>
<td>Open</td>
<td>OPEN</td>
</tr>
<tr>
<td>OpenWebPage</td>
<td>Open Web Page</td>
</tr>
<tr>
<td>Outline</td>
<td>Outline</td>
</tr>
<tr>
<td>PasswordErrorHint</td>
<td>Check your password</td>
</tr>
<tr>
<td>RequestPassword</td>
<td>This PDF file is protected. Please enter the password to open it.</td>
</tr>
</table>
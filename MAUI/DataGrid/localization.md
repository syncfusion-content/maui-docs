---
layout: post
title: Localization in .NET MAUI DataGrid Control | Syncfusion®
description: Learn here all about localization support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Localization in .NET MAUI DataGrid (SfDataGrid)

Localization is the process of translating application resources into different languages for specific cultures. The `SfDataGrid` can be localized by adding resource files. The following strings in `SfDataGrid` can be localized:

   * `Load More`
   * `Click here to add new row`
   * `Equals`
   * `Does Not Equal`
   * `Greater Than`
   * `Greater Than or Equal`
   * `Less Than`
   * `Less Than or Equal`
   * `Begins With`
   * `Does Not Begin With`
   * `Ends With`
   * `Does Not End With`
   * `Contains`
   * `Does Not Contain`
   * `Before`
   * `Before or Equal`
   * `After`
   * `After or Equal`
   * `Empty`
   * `Not Empty`
   * `Null`
   * `Not Null`
   * `(Blanks)`
   * `(Select All)`
   * `Ok`
   * `Cancel`

## Application-Level Localization

To localize the `DataGrid` based on `CurrentUICulture` using resource files, follow these steps:


### Step-by-step Setup

   1. Create a new folder named `Resources` in the application if it does not already exist.      

   2. **Create culture-specific resource files:**
      - Right-click on the `Resources` folder, select `Add` and then `New Item`.
      - In the Add New Item dialog, select the Resource File option and name the filename as `SfDataGrid.<culture name>.resx`. For example, use `SfDataGrid.fr-FR.resx` for French (France). The culture name format is `language-country` (e.g., `fr-FR`, `es-ES`).
      - Right-click the newly created file → select `Properties` → set `Build Action` to `EmbeddedResource`.

      <img alt="Resources folder structure in project" src="Images\localization\maui-datagrid-localization-create-resource-file.png" width="404"/>

      <img alt="Creating new resource file via Add New Item dialog" src="Images\localization\maui-datagrid-localization-sample.png" width="404"/>

   3. **Add localized strings:**
      - Open the `SfDataGrid.fr-FR.resx` file and add the Name/Value pairs from the list above, translating values to the target culture.
      - Use the Resource Designer to add entries (Name column = English string key, Value column = translated string).

      <img alt="Resource Designer showing Name/Value pairs for localized strings" src="Images\localization\maui-datagrid-localization-resource-file.png" width="404"/>

   4. **Repeat for additional cultures:**
      - Create additional `SfDataGrid.<culture name>.resx` files for each language you want to support (e.g., `SfDataGrid.es-ES.resx`, `SfDataGrid.de-DE.resx`).

### Configure CurrentUICulture in App.xaml.cs

Application culture can be changed by setting `CurrentUICulture` in the `App.xaml.cs` file during application initialization. The ResourceManager path must match your project's namespace and folder structure exactly.

{% tabs %}
{% highlight c# tabtitle="App.xaml.cs" hl_lines="1 3 11 13" %}

using Syncfusion.Maui.DataGrid;
using System.Globalization;
using System.Resources;

namespace MauiDataGridDemo;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		// Set the application culture (e.g., "fr-FR" for French)
		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");

		// Initialize the ResourceManager with your project namespace
		// Format: "{ProjectNamespace}.{FolderName}.{ResourceFileName}"
		// Replace "MauiDataGridDemo" with your actual project name
		SfDataGridResources.ResourceManager = new ResourceManager("MauiDataGridDemo.Resources.SfDataGrid", Application.Current.GetType().Assembly);
	   MainPage = new MainPage();
	}
}

{% endhighlight %}
{% endtabs %}

### Activation and Behavior

After configuration, the DataGrid will use localized strings when the application starts. Localization applies immediately based on the `CurrentUICulture` set in the App constructor. If a translated string is missing from a culture-specific resource file, the DataGrid will fall back to the neutral culture resource (SfDataGrid.resx) or use the hardcoded English default. Changing the culture at runtime requires reassigning the ResourceManager and may require an application restart for the changes to take effect in all UI elements.

<img alt="DataGrid with localized 'Load More' button in French" src="Images\localization\maui-datagrid-localization.png" width="404"/>

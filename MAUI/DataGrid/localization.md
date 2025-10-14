---
layout: post
title: Localization in .NET MAUI DataGrid Control | Syncfusion®
description: Learn here all about localization support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Localization in .NET MAUI DataGrid (SfDataGrid)

Localization is the process of translating the application resources into different language for the specific cultures. The `SfDataGrid` can be localized by adding `resource` file. In `SfDataGrid`, provides the support to localize the below strings

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

## Setting CurrentUICulture to the application

Application culture can be changed by setting `CurrentUICulture.` in `App.xaml.cs` file.

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
		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");

		SfDataGridResources.ResourceManager = new ResourceManager("MauiDataGridDemo.Resources.SfDataGrid", Application.Current.GetType().Assembly);
	   MainPage = new MainPage();
	}
}

{% endhighlight %}
{% endtabs %}

<img alt="Load more in MAUI SfDataGrid" src="Images\localization\maui-datagrid-localization.png" width="404"/>

N>
The required `resx` files with `Build Action` as `EmbeddedResource` (File name should contain culture code) into the `Resources` folder.

## Localize application level

To localize the `DataGrid` based on `CurrentUICulture` using `resource` files, follow the below steps.

   1. Create new folder, named as `Resources` in the application.

   2. Right-click on the `Resources` folder, select `Add` and then `NewItem.`

   3. In Add New Item wizard, select the Resource File option and name the filename as `SfDataGrid.<culture name>.resx.` For example, give the name as `SfDataGrid.fr-FR.resx` for French culture.

   4. The culture name indicates the name of the language and country.

   <img alt="Create resources file in the sample" src="Images\localization\maui-datagrid-localization-create-resource-file.png" width="404"/>

   5. Now, select `Add` option to add the resource file in **Resources** folder.

   <img alt="Localization sample" src="Images\localization\maui-datagrid-localization-sample.png" width="404"/>

   6. Add the Name/Value pair in Resource Designer of `SfDataGrid.fr-FR.resx` file and change its corresponding value to corresponding culture.

   <img alt="Resource file" src="Images\localization\maui-datagrid-localization-resource-file.png" width="404"/>
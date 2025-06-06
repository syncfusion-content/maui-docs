---
layout: post
title: Search in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Search support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control, its elements and more details.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Search in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) control allows you to search the data displayed within it. You can search the data using the [SearchController.Search](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_Search_System_String_) method.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.Search(entry.Text);

{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with Search Panel" src="Images\search\maui-datagrid-search.png" width="404"/>


## Filtering

The filtering can be enabled for the search results by setting the [SearchController.AllowFiltering](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_AllowFiltering) property to true.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.AllowFiltering = true;
this.dataGrid.SearchController.Search(entry.Text);

{% endhighlight %}
{% endtabs %}

<img alt="Enabling Filter based on Search in DataGrid" src="Images\search\maui-datagrid-search-filtering.png" width="404"/>


You can search the data with the case-sensitivity by setting [SearchController.AllowCaseSensitiveSearch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_AllowCaseSensitive) property.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.AllowCaseSensitiveSearch = true;

{% endhighlight %}
{% endtabs %}

## Search with pattern matching

You can customize the type of search for the `SearchController` by using the [SearchType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_SearchType) property. The available search types are: `StartsWith`, `Contains` and `EndsWith`. The below code snippet demonstrates how to set the search type as `StartsWith`.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.SearchType = DataGridSearchType.StartsWith;

{% endhighlight %}
{% endtabs %}

## Customize the appearance of highlight text

You can apply the style for a searched text color, background color and search highlighted text color, background color by using [SearchTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchTextColor), [SearchTextBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchTextBackground), [SearchHighlightTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchHighlightTextColor), [SearchHighlightTextBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchHighlightTextBackground) in `SfDataGrid.DefaultStyle`.

{% tabs %}
{% highlight Xaml %}

<ContentPage.Content>
    <syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle SearchTextColor="Black" 
                                    SearchTextBackground="LightBlue" 
                                    SearchHighlightTextColor="Black" 
                                    SearchHighlightTextBackground="LightGreen" />
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
</ContentPage.Content>

{% endhighlight %}
{% endtabs %}

## Navigating cells based on search text

The SfDataGrid allows navigation between the search results programmatically using the [SearchController.FindNext](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_FindNext_System_String_) and [SearchController.FindPrevious](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_FindPrevious_System_String_) methods.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.FindNext("SearchText");
this.dataGrid.SearchController.FindPrevious("SearchText");

{% endhighlight %}
{% endtabs %}

<img alt="Navigated Search Text in DataGrid" src="Images\search\maui-datagrid-searchtext-navigate.png" width="404"/>

## Clear Search

The search can be cleared by using the [SearchController.ClearSearch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_ClearSearch) method.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.ClearSearch();

{% endhighlight %}
{% endtabs %}

## Search customization

The `SfDataGrid` processes search operations in the [DataGridSearchController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html) class. You can change the default search behaviors by creating a custom class that overrides the `DataGridSearchController` class and setting it to the `SfDataGrid.SearchController` property.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController = new CustomDataGridSearchController (this.datagrid);
public class CustomDataGridSearchController  : DataGridSearchController
{
    public CustomDataGridSearchController(SfDataGrid datagrid)
        : base(datagrid)
    {
    }
}

{% endhighlight %}
{% endtabs %}

### Search only a specific column

You can search only a specific column by overriding the [SearchCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_SearchCell_Syncfusion_Maui_DataGrid_DataColumnBase_System_Object_System_Boolean_) method of the `DataGridSearchController`. In the `SearchCell` method, you can perform a search for the column you want to apply based on the `MappingName`.

In the code below, all columns except the `CustomerID` column are excluded from the search.

{% tabs %}
{% highlight c# %}

public class CustomDataGridSearchController : DataGridSearchController
{
    public CustomDataGridSearchController(SfDataGrid datagrid)
        : base(datagrid)
    {
    }
    protected override bool SearchCell(DataColumnBase column, object record, bool ApplySearchHighlightBrush)
    {

        if (column.DataGridColumn.MappingName == "CustomerID")
            return base.SearchCell(column, record, ApplySearchHighlightBrush);
        return false;
    }
}

{% endhighlight %}
{% endtabs %}

<img alt="DataGrid displays Search Text only in Selected Column" src="Images\search\maui-datagrid-search-selected-column.png" width="404"/>

## Obtain the search records

You can get the records by using the [GetSearchRecords](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_GetSearchRecords) method of the `DataGridSearchController`. This method returns a list of search records. The below code snippet demonstrates how to get the search records.

{% tabs %}
{% highlight c# %}

var records = this.dataGrid.SearchController.GetSearchRecords();

{% endhighlight %}
{% endtabs %}

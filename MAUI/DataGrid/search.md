---
layout: post
title: Search in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Search support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control, its elements and more details.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Search in MAUI DataGrid (SfDataGrid)

The [SfDataGrid]() control allows you to search the data displayed within it. You can search the data using the [SearchController.Search]() method.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.Search(TextBox.Text);

{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with Search Panel" src="Images\search\maui-datagrid-search.png" width="404"/>


### Filtering

The filtering can be enabled for the search results by setting the [SearchController.AllowFiltering]() property to true.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.AllowFiltering = true;
this.dataGrid.SearchController.Search(TextBox.Text);

{% endhighlight %}
{% endtabs %}

<img alt="Enabling Filter based on Search in DataGrid" src="Images\search\maui-datagrid-search-filtering.png" width="404"/>


You can search the data with the case-sensitivity by setting [SearchController.AllowCaseSensitiveSearch]() property.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.AllowCaseSensitiveSearch = true;

{% endhighlight %}
{% endtabs %}

## Navigating cells based on search text

You can navigate to the cells contains the SearchText using [SearchController.FindNext]() and [SearchController.FindPrevious]() methods.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.FindNext("SearchText");
this.dataGrid.SearchController.FindPrevious("SearchText");

{% endhighlight %}
{% endtabs %}

<img alt="Navigated Search Text in DataGrid" src="Images\search\maui-datagrid-searchtext-navigate.png" width="404"/>

## Clear Search

You can clear the search by calling the [SearchController.ClearSearch]() method. 

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.ClearSearch();

{% endhighlight %}
{% endtabs %}

## Search customization

The `SfDataGrid` processes search operations in the [DataGridSearchController]() class. You can change the default search behaviors by creating a custom class that overrides the `DataGridSearchController` class and setting it to the `SfDataGrid.SearchController` property.

{% tabs %}
{% highlight c# %}

this.datagrid.SearchController = new CustomDataGridSearchController (this.datagrid);
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

You can search only a specific column by overriding the `SearchCell` method of the `DataGridSearchController`. In the `SearchCell` method, you can perform a search for the column you want to apply based on the `MappingName`.

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

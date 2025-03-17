---
layout: post
title: Search in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Search support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control, its elements and more details.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Search in MAUI DataGrid (SfDataGrid)

[SfDataGrid]() control allows you to search the data displayed in the SfDataGrid. You can search the data by using [SearchController.Search]() method.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.Search(TextBox.Text);

{% endhighlight %}
{% endtabs %}

![DataGrid with Search Panel]()


### Filtering

You can enable filter based on search by setting [SearchController.AllowFiltering]() property to true.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.AllowFiltering = true;
this.dataGrid.SearchController.Search(TextBox.Text);

{% endhighlight %}
{% endtabs %}

![Enabling Filter based on Search in DataGrid]()


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

![Navigated Search Text in DataGrid]()

## Clear Search

You can clear the search by calling the [SearchController.ClearSearch]() method. 

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.ClearSearch();

{% endhighlight %}
{% endtabs %}

## Search customization

DataGrid (SfDataGrid) process the search operations in [DataGridSearchController]() class. You can change the default search behaviors by overriding `DataGridSearchController` class and set to `SfDataGrid.SearchController`.

{% tabs %}
{% highlight c# %}

this.datagrid.SearchController = new SearchHelperExt(this.datagrid);
public class SearchHelperExt : DataGridSearchController
{
    public SearchHelperExt(SfDataGrid datagrid)
        : base(datagrid)
    {
    }
}

{% endhighlight %}
{% endtabs %}

### Search only selected columns

You can search only selected columns by overriding `SearchCell` method of `DataGridSearchController`. In the `SearchCell` method, based on `MappingName` you can skip the columns that you don’t want to search. 

In the below code, except `CustomerID` column other columns are gets excluded from search. 

{% tabs %}
{% highlight c# %}

public class SearchHelperExt : DataGridSearchController
{
    public SearchHelperExt(SfDataGrid datagrid)
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

![DataGrid displays Search Text only in Selected Column]()


### Select the record based on the SearchText

You can select the records which contains the search text by using `GetSearchedRecord` method. 

{% tabs %}
{% highlight c# %}

this.dataGrid.SelectedItems.Clear();
this.dataGrid.SearchHelper.Search("SearchText"); 
var list = this.dataGrid.SearchHelper.GetSearchRecords();
int recordIndex = this.dataGrid.ResolveToRecordIndex(this.dataGrid.ResolveToRowIndex(list[0].Record));
this.dataGrid.SelectedIndex = recordIndex;

{% endhighlight %}
{% endtabs %}

![Select Record based on SearchText in DataGrid]()

## See Also


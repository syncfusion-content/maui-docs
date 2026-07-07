---
layout: post
title: Search in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Search support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control, its elements and more details.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Search in MAUI DataGrid (SfDataGrid)
The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) control allows you to search the data displayed within the datagrid. You can search the data using the built-in search UI or programmatically.

## UI Searching

The `SfDataGrid` allows you to enable searching support by setting the [AllowSearching]() property to `true`. By enabling this property, the built-in search UI is displayed above the DataGrid, allowing users to search the data.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.BindingContext>
    <local:ViewModel  x:Name ="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowSearching="True">
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# tabtitle="C#" %}
OrderInfoRepository viewModel = new OrderInfoRepository();
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowSearching = true;
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with build in Search UI" src="Images\search\maui-datagrid-built-in-searchUI.png" width="404"/>

### Settings Option

The built-in search UI has a settings icon that offers options for searching, such as filtering, pattern matching, and case sensitivity. You can hide this icon by setting the [DataGridSearchToolbarView.ShowMoreOptions]() property to `false`.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.Resources>
    <Style TargetType="datagrid:DataGridSearchToolbarView">
        <Setter Property="ShowMoreOptions" Value="False"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowSearching="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

### Navigation Between Search Results

The navigation icons in the built-in search bar allow users to move to the next or previous search result. You can change the visibility of the navigation icons using the [DataGridSearchToolbarView.ShowNavigationButtons]() property.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.Resources>
    <Style TargetType="datagrid:DataGridSearchToolbarView">
        <Setter Property="ShowNavigationButtons" Value="False"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowSearching="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

### Clear Search via UI

You can clear the search results by clicking the clear icon in the search bar. You can hide the clear icon by setting the [DataGridSearchToolbarView.ShowClearButton]() property to `false`.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.Resources>
    <Style TargetType="datagrid:DataGridSearchToolbarView">
        <Setter Property="ShowClearButton" Value="False"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowSearching="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

### Appearance

#### Customize the SearchToolbarView

You can customize the `DataGridSearchToolbarView` using the following `DataGridStyle` properties:
- [SearchToolbarViewStroke](): Sets the border color of the SearchToolbarView.
- [SearchToolbarViewStrokeThickness](): Sets the border thickness of the SearchToolbarView.
- [SearchToolbarViewBackground](): Sets the background color of the SearchToolbarView.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowSearching="True">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle SearchToolbarViewBackground="Yellow"
                                  SearchToolbarViewStroke="Brown"
                                  SearchToolbarViewStrokeThickness="2"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowSearching = true;

var defaultStyle = new DataGridStyle()
{
    SearchToolbarViewBackground = Colors.Yellow,
    SearchToolbarViewStroke = Colors.Brown,
    SearchToolbarViewStrokeThickness = 2
};

dataGrid.DefaultStyle = defaultStyle;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

#### Customize the Search bar

You can customize the `SearchBar` using the following `DataGridStyle` properties:
- [SearchBarBackground](): Sets the background color of the search bar.
- [SearchBarTextColor](): Sets the text color of the search bar.
- [SearchBarTextFontSize](): Sets the font size of the search bar text.
- [SearchBarTextFontFamily](): Sets the font family of the search bar text.
- [SearchBarTextFontAttributes](): Sets the font attributes of the search bar text.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowSearching="True">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle SearchbarTextColor="Blue"
                                  SearchbarBackground="Yellow"
                                  SearchbarTextFontAttributes="Bold"
                                  SearchbarTextFontSize="18"
                                  SearchbarTextFontFamily="Roboto"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowSearching = true;

var defaultStyle = new DataGridStyle()
{
    SearchbarTextColor = Colors.Blue,
    SearchbarBackground = Colors.Yellow,
    SearchbarTextFontAttributes = FontAttributes.Bold,
    SearchbarTextFontSize = 18,
    SearchbarTextFontFamily = "Roboto"
};

dataGrid.DefaultStyle = defaultStyle;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

## Programmatic Searching

The `SfDataGrid` allows you to search the data using the [SearchController.Search](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_Search_System_String_) method.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.Search(entry.Text);

{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with Search Panel" src="Images\search\maui-datagrid-search.png" width="404"/>

### Filtering

Filtering can be enabled for the search results by setting the [SearchController.AllowFiltering](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_AllowFiltering) property to `true`.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.AllowFiltering = true;
this.dataGrid.SearchController.Search(entry.Text);

{% endhighlight %}
{% endtabs %}

<img alt="Enabling Filter based on Search in DataGrid" src="Images\search\maui-datagrid-search-filtering.png" width="404"/>

You can search the data with case-sensitivity by setting the [SearchController.AllowCaseSensitive](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_AllowCaseSensitive) property to `true`.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.AllowCaseSensitive = true;

{% endhighlight %}
{% endtabs %}

### Search with Pattern Matching

You can customize the type of search for the `SearchController` by using the [SearchType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_SearchType) property. The available search types are `StartsWith`, `Contains`, and `EndsWith`. The following code snippet demonstrates how to set the search type to `StartsWith`.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.SearchType = DataGridSearchType.StartsWith;

{% endhighlight %}
{% endtabs %}

### Navigating Cells Based on Search Text

The `SfDataGrid` allows navigation between search results programmatically using the [SearchController.FindNext](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_FindNext_System_String_) and [SearchController.FindPrevious](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_FindPrevious_System_String_) methods.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.FindNext("SearchText");
this.dataGrid.SearchController.FindPrevious("SearchText");

{% endhighlight %}
{% endtabs %}

<img alt="Navigated Search Text in DataGrid" src="Images\search\maui-datagrid-searchtext-navigate.png" width="404"/>

### Clear Search Programmatically

You can clear the search by using the [SearchController.ClearSearch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_ClearSearch) method.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController.ClearSearch();

{% endhighlight %}
{% endtabs %}

## Customize the Appearance of Highlight Text

You can customize the appearance of searched text by using the [SearchTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchTextColor), [SearchTextBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchTextBackground), [SearchHighlightTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchHighlightTextColor), and [SearchHighlightTextBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SearchHighlightTextBackground) properties. You can also customize the background color of search-matched cells using the [SearchCellBackground]() property.

{% tabs %}
{% highlight xaml %}

<ContentPage.Content>
    <syncfusion:SfDataGrid ItemsSource="{Binding Orders}">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle SearchTextColor="Black" 
                                      SearchTextBackground="LightBlue" 
                                      SearchHighlightTextColor="Black" 
                                      SearchHighlightTextBackground="LightGreen"
                                      SearchCellBackground="LightPink"/>
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
</ContentPage.Content>

{% endhighlight %}
{% endtabs %}


## Search Customization

The `SfDataGrid` processes search operations in the [DataGridSearchController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html) class. You can change the default search behaviors by creating a custom class that overrides the `DataGridSearchController` class and setting it to the `SfDataGrid.SearchController` property.

{% tabs %}
{% highlight c# %}

this.dataGrid.SearchController = new CustomDataGridSearchController(this.dataGrid);
public class CustomDataGridSearchController : DataGridSearchController
{
    public CustomDataGridSearchController(Syncfusion.Maui.DataGrid.SfDataGrid dataGrid)
        : base(dataGrid)
    {
    }
}

{% endhighlight %}
{% endtabs %}

### Search Only a Specific Column

You can search only a specific column by overriding the [SearchCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_SearchCell_Syncfusion_Maui_DataGrid_DataColumnBase_System_Object_System_Boolean_) method of the `DataGridSearchController`. In the `SearchCell` method, you can perform a search for the column you want to apply based on the `MappingName`.

In the following code snippet, all columns except the `Customer` column are excluded from the search.

{% tabs %}
{% highlight c# %}

public class CustomDataGridSearchController : DataGridSearchController
{
    public CustomDataGridSearchController(Syncfusion.Maui.DataGrid.SfDataGrid dataGrid) : base(dataGrid)
    {
    }
    protected override bool SearchCell(DataColumnBase column, object record, bool ApplySearchHighlightBrush)
    {
        if (column.DataGridColumn?.MappingName == "Customer")
            return base.SearchCell(column, record, ApplySearchHighlightBrush);
        return false;
    }
}

{% endhighlight %}
{% endtabs %}

<img alt="DataGrid displays Search Text only in Selected Column" src="Images\search\maui-datagrid-search-selected-column.png" width="404"/>

## Obtain the Search Records

You can get the records by using the [GetSearchRecords](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSearchController.html#Syncfusion_Maui_DataGrid_DataGridSearchController_GetSearchRecords) method of the `DataGridSearchController`. This method returns a list of search records. The following code snippet demonstrates how to get the search records.

{% tabs %}
{% highlight c# %}

var records = this.dataGrid.SearchController.GetSearchRecords();

{% endhighlight %}
{% endtabs %}

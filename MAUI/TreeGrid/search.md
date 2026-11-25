---
layout: post
title: Search in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to search data in Syncfusion® .NET MAUI Tree Grid using the built-in search UI or programmatically, with highlighting, filtering, scope and customization.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid search, maui treegrid search, treegrid search toolbar
---

# Search in .NET MAUI Tree Grid

The [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) control allows you to search the data displayed within the tree grid. You can search the data using the built-in search UI or programmatically.

N> The `syncfusion` prefix used in the XAML samples refers to `xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"`.

## UI Searching

The `SfTreeGrid` allows you to enable searching support by setting the [AllowSearching](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowSearching) property to `true`. The default value is `false`. By enabling this property, the built-in search UI is displayed above the TreeGrid, allowing users to search the data.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowSearching="True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportingPeople";
treeGrid.AllowSearching = true;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

The search is performed as the user types in the search bar. The text that matches in the cells is highlighted.

### Settings Option

The built-in search UI has a settings icon that offers options for searching: **Match Case**, the search type (**Contains**, **Starts With**, and **Ends With**), and **Filter Result**. You can hide this icon by setting the [TreeGridSearchToolbarView.ShowMoreOptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchToolbarView.html#Syncfusion_Maui_TreeGrid_TreeGridSearchToolbarView_ShowMoreOptions) property to `false`. The default value is `true`.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:TreeGridSearchToolbarView">
        <Setter Property="ShowMoreOptions" Value="False"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowSearching="True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Navigation Between Search Results

The navigation icons in the built-in search bar allow users to move to the next or previous search result. You can change the visibility of the navigation icons using the [TreeGridSearchToolbarView.ShowNavigationButtons](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchToolbarView.html#Syncfusion_Maui_TreeGrid_TreeGridSearchToolbarView_ShowNavigationButtons) property. The default value is `true`.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:TreeGridSearchToolbarView">
        <Setter Property="ShowNavigationButtons" Value="False"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowSearching="True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Clear Search via UI

You can clear the search results by clicking the clear icon in the search bar. The clear icon is enabled only when the search bar contains text. You can hide the clear icon by setting the [TreeGridSearchToolbarView.ShowClearButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchToolbarView.html#Syncfusion_Maui_TreeGrid_TreeGridSearchToolbarView_ShowClearButton) property to `false`. The default value is `true`.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:TreeGridSearchToolbarView">
        <Setter Property="ShowClearButton" Value="False"/>
    </Style>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowSearching="True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Appearance

#### Customize the SearchToolbarView

You can customize the `TreeGridSearchToolbarView` using the following `TreeGridStyle` properties:

* [SearchToolbarStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchToolbarStroke): Sets the border color of the search toolbar.
* [SearchToolbarStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchToolbarStrokeThickness): Sets the border thickness of the search toolbar. The default value is `1`.
* [SearchToolbarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchToolbarBackground): Sets the background color of the search toolbar.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowSearching="True">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle SearchToolbarBackground="Yellow"
                                  SearchToolbarStroke="Brown"
                                  SearchToolbarStrokeThickness="2"/>
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportingPeople";
treeGrid.AllowSearching = true;

treeGrid.DefaultStyle.SearchToolbarBackground = Colors.Yellow;
treeGrid.DefaultStyle.SearchToolbarStroke = Colors.Brown;
treeGrid.DefaultStyle.SearchToolbarStrokeThickness = 2;

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

#### Customize the Search bar

You can customize the search bar using the following `TreeGridStyle` properties:

* [SearchBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchBarBackground): Sets the background color of the search bar. This is applied on the Windows and macOS platforms.
* [SearchBarTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchBarTextColor): Sets the text color of the search bar.
* [SearchBarTextFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchBarTextFontSize): Sets the font size of the search bar text. The default value is `14`.
* [SearchBarTextFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchBarTextFontFamily): Sets the font family of the search bar text.
* [SearchBarTextFontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchBarTextFontAttributes): Sets the font attributes of the search bar text.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowSearching="True">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle SearchBarTextColor="Blue"
                                  SearchBarBackground="Yellow"
                                  SearchBarTextFontAttributes="Bold"
                                  SearchBarTextFontSize="18"
                                  SearchBarTextFontFamily="Roboto"/>
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "ReportingPeople";
treeGrid.AllowSearching = true;

treeGrid.DefaultStyle.SearchBarTextColor = Colors.Blue;
treeGrid.DefaultStyle.SearchBarBackground = Colors.Yellow;
treeGrid.DefaultStyle.SearchBarTextFontAttributes = FontAttributes.Bold;
treeGrid.DefaultStyle.SearchBarTextFontSize = 18;
treeGrid.DefaultStyle.SearchBarTextFontFamily = "Roboto";

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Programmatic Searching

The `SfTreeGrid` allows you to search the data using the [SearchController.Search](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_Search_System_String_) method. The search highlights the matched text in the cells. Passing an empty string clears the search.

{% tabs %}
{% highlight xaml %}
<Entry x:Name="entry" Placeholder="Search" />
<Button Text="Search" Clicked="OnSearchClicked" />

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople" />
{% endhighlight %}
{% highlight c# %}
private void OnSearchClicked(object sender, EventArgs e)
{
    this.treeGrid.SearchController.Search(entry.Text);
}
{% endhighlight %}
{% endtabs %}

N> `SearchController.SearchText` is also a bindable property. Setting it triggers the search with the new text.

### Filtering

Filtering can be enabled for the search results by setting the [SearchController.AllowFiltering](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_AllowFiltering) property to `true`. When enabled, only the records that match the search text are displayed. The default value is `false`.

{% tabs %}
{% highlight c# %}
this.treeGrid.SearchController.AllowFiltering = true;
this.treeGrid.SearchController.Search(entry.Text);
{% endhighlight %}
{% endtabs %}

N> When `AllowFiltering` is `true`, the search controller sets the `Filter` of the [View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_View). Setting it back to `false`, or clearing the search, removes this filter. Verification Required – combination with a filter that you apply to the `View` yourself is not verified.

### Case-sensitive Search

You can search the data with case-sensitivity by setting the [SearchController.AllowCaseSensitive](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_AllowCaseSensitive) property to `true`. The default value is `false`.

{% tabs %}
{% highlight c# %}
this.treeGrid.SearchController.AllowCaseSensitive = true;
{% endhighlight %}
{% endtabs %}

### Search with Pattern Matching

You can customize the type of search for the `SearchController` by using the [SearchType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_SearchType) property. The available search types in the [TreeGridSearchType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchType.html) enum are `StartsWith`, `Contains`, and `EndsWith`. The default value is `Contains`. The following code snippet demonstrates how to set the search type to `StartsWith`.

{% tabs %}
{% highlight c# %}
this.treeGrid.SearchController.SearchType = TreeGridSearchType.StartsWith;
{% endhighlight %}
{% endtabs %}

### Search Scope

Since the TreeGrid displays hierarchical data, you can restrict the search to root nodes or child nodes by using the [SearchScope](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_SearchScope) property. The default value is `Both`. When the value is changed while a search text is present, the search is applied again.

| [TreeGridSearchScope](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchScope.html) | Description |
|---|---|
| `Both` | The search is applied to both the root nodes and the child nodes. |
| `RootNodes` | The search is applied only to the root nodes. |
| `ChildNodes` | The search is applied only to the child nodes. |

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
// Search only in the root nodes.
this.treeGrid.SearchController.SearchScope = TreeGridSearchScope.RootNodes;
this.treeGrid.SearchController.Search("Anna");
{% endhighlight %}
{% endtabs %}

### Highlighting the Search Text

The matched text is highlighted by default. You can turn the highlighting off by setting the [SearchController.CanHighlightSearchText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_CanHighlightSearchText) property to `false`. The default value is `true`. Setting it to `false` clears the current highlighting, and setting it to `true` applies the highlighting again for the current search text.

{% tabs %}
{% highlight c# %}
this.treeGrid.SearchController.CanHighlightSearchText = false;
{% endhighlight %}
{% endtabs %}

N> The built-in search UI enables the highlighting when text is entered, and disables it when the search is cleared using the clear icon.

### Navigating Cells Based on Search Text

The `SfTreeGrid` allows navigation between search results programmatically using the [SearchController.FindNext](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_FindNext_System_String_) and [SearchController.FindPrevious](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_FindPrevious_System_String_) methods. Both methods return `true` when a matching cell is found, scroll the matched cell into view, and highlight it with the highlight colors of the current result.

{% tabs %}
{% highlight c# %}
bool isFound = this.treeGrid.SearchController.FindNext("SearchText");
isFound = this.treeGrid.SearchController.FindPrevious("SearchText");
{% endhighlight %}
{% endtabs %}

The row and column index of the cell that matches the search text is available in the [SearchController.CurrentRowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_CurrentRowColumnIndex) property. Its value is `(-1, -1)` when no cell is navigated.

{% tabs %}
{% highlight c# %}
if (this.treeGrid.SearchController.FindNext("SearchText"))
{
    var index = this.treeGrid.SearchController.CurrentRowColumnIndex;
    Debug.WriteLine($"Row: {index.RowIndex}, Column: {index.ColumnIndex}");
}
{% endhighlight %}
{% endtabs %}

### Clear Search Programmatically

You can clear the search by using the [SearchController.ClearSearch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_ClearSearch) method. It clears the highlighting, resets the `SearchText` and `CurrentRowColumnIndex`, and removes the search filter when `AllowFiltering` is enabled.

{% tabs %}
{% highlight c# %}
this.treeGrid.SearchController.ClearSearch();
{% endhighlight %}
{% endtabs %}

## Customize the Appearance of Highlight Text

You can customize the appearance of the searched text by using the [SearchTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchTextColor), [SearchTextBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchTextBackground), [SearchHighlightTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchHighlightTextColor), and [SearchHighlightTextBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_SearchHighlightTextBackground) properties.

* `SearchTextColor` and `SearchTextBackground` are applied to all the matched text.
* `SearchHighlightTextColor` and `SearchHighlightTextBackground` are applied to the current search result, that is, the cell that is navigated using `FindNext` or `FindPrevious`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="ReportingPeople"
                       AllowSearching="True">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle SearchTextColor="Black"
                                  SearchTextBackground="LightBlue"
                                  SearchHighlightTextColor="Black"
                                  SearchHighlightTextBackground="LightGreen"/>
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.DefaultStyle.SearchTextColor = Colors.Black;
treeGrid.DefaultStyle.SearchTextBackground = Colors.LightBlue;
treeGrid.DefaultStyle.SearchHighlightTextColor = Colors.Black;
treeGrid.DefaultStyle.SearchHighlightTextBackground = Colors.LightGreen;
{% endhighlight %}
{% endtabs %}

## Search Customization

The `SfTreeGrid` processes search operations in the [TreeGridSearchController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html) class. You can change the default search behaviors by creating a custom class that derives from `TreeGridSearchController` and setting it to the [SfTreeGrid.SearchController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_SearchController) property.

{% tabs %}
{% highlight c# %}
this.treeGrid.SearchController = new CustomTreeGridSearchController(this.treeGrid);

public class CustomTreeGridSearchController : TreeGridSearchController
{
    public CustomTreeGridSearchController(SfTreeGrid treeGrid)
        : base(treeGrid)
    {
    }
}
{% endhighlight %}
{% endtabs %}

The following members can be overridden in a derived class:

| Member | Description |
|---|---|
| `Search(string text)` | Initiates the search operation. |
| `ClearSearch()` | Clears the search highlighting and the search filter. |
| `FindNext(string text)` | Finds and highlights the next matching cell. |
| `FindPrevious(string text)` | Finds and highlights the previous matching cell. |
| `SearchRow(TreeGridDataRowBase row)` | Searches the cells in the row. Protected internal virtual. |
| `SearchCell(TreeGridDataColumnBase column, object? record, bool applySearchHighlightBrush)` | Searches the cell and applies the highlighting when it matches. Protected internal virtual. |
| `ApplySpan(TreeGridDataColumnBase column, object? data, bool applySearchHighlightBrush, SfTreeGridLabel label)` | Applies the highlighted spans on the cell label. Protected virtual. |
| `ClearSearchRow(TreeGridDataRowBase row)` | Clears the highlighting in the cells of the row. Protected internal virtual. |
| `ClearSearchCell(TreeGridDataColumnBase column, object? record)` | Clears the highlighting in the cell. Protected internal virtual. |

### Search Only a Specific Column

You can search only a specific column by overriding the [SearchCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_SearchCell_Syncfusion_Maui_TreeGrid_TreeGridDataColumnBase_System_Object_System_Boolean_) method of the `TreeGridSearchController`. In the `SearchCell` method, you can perform a search for the column you want based on the `MappingName`.

In the following code snippet, all columns except the `Name` column are excluded from the highlighting.

{% tabs %}
{% highlight c# %}
public class CustomTreeGridSearchController : TreeGridSearchController
{
    public CustomTreeGridSearchController(SfTreeGrid treeGrid) : base(treeGrid)
    {
    }

    protected override bool SearchCell(TreeGridDataColumnBase column, object? record, bool applySearchHighlightBrush)
    {
        if (column.TreeGridColumn?.MappingName == "Name")
            return base.SearchCell(column, record, applySearchHighlightBrush);

        return false;
    }
}
{% endhighlight %}
{% endtabs %}

N> Overriding `SearchCell` changes only the cell highlighting. `FindNext`, `FindPrevious`, `GetSearchRecords`, and the filtering use their own matching logic over all the visible columns that have a `MappingName`. Verification Required – restricting those operations to a single column through a derived class is not verified.

## Obtain the Search Records

You can get the matched records by using the [GetSearchRecords](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchController.html#Syncfusion_Maui_TreeGrid_TreeGridSearchController_GetSearchRecords) method of the `TreeGridSearchController`. This method returns a `List<TreeGridSearchCellInfo>`. It returns an empty list when the `SearchText` is empty. Each [TreeGridSearchCellInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchCellInfo.html) provides the following properties:

| Property | Type | Description |
|---|---|---|
| [Record](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchCellInfo.html#Syncfusion_Maui_TreeGrid_TreeGridSearchCellInfo_Record) | `object?` | The data object that is associated with the matched row. |
| [ColumnCollection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchCellInfo.html#Syncfusion_Maui_TreeGrid_TreeGridSearchCellInfo_ColumnCollection) | `List<TreeGridColumn>` | The columns in the row that match the search text. |

{% tabs %}
{% highlight c# %}
this.treeGrid.SearchController.Search("Anna");
var records = this.treeGrid.SearchController.GetSearchRecords();

foreach (var info in records)
{
    var columns = string.Join(", ", info.ColumnCollection.Select(c => c.MappingName));
    Debug.WriteLine($"{info.Record} matched in: {columns}");
}
{% endhighlight %}
{% endtabs %}

## API reference

### SfTreeGrid

| Member | Type | Default | Description |
|---|---|---|---|
| [AllowSearching](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowSearching) | `bool` | `false` | Enables the built-in search UI. |
| [SearchController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_SearchController) | `TreeGridSearchController` | An instance created by the TreeGrid | The controller that provides the search implementation. It can be replaced with a derived controller. |

### TreeGridSearchController

| Member | Type | Default | Description |
|---|---|---|---|
| `AllowCaseSensitive` | `bool` | `false` | Enables case-sensitive comparison. |
| `AllowFiltering` | `bool` | `false` | Displays only the records that match the search text. |
| `CanHighlightSearchText` | `bool` | `true` | Indicates whether the matched text is highlighted. |
| `SearchType` | `TreeGridSearchType` | `Contains` | How the cell text is compared with the search text. |
| `SearchScope` | `TreeGridSearchScope` | `Both` | Whether the search is applied to the root nodes, the child nodes, or both. |
| `SearchText` | `string` | `""` | The text used to search. Setting it performs the search. |
| `CurrentRowColumnIndex` | `RowColumnIndex` | `(-1, -1)` | The row and column index of the cell that matches when `FindNext` or `FindPrevious` is called. |
| `Search(string)` | `void` | - | Searches the data. |
| `ClearSearch()` | `void` | - | Clears the search. |
| `FindNext(string)` | `bool` | - | Navigates to the next matching cell. |
| `FindPrevious(string)` | `bool` | - | Navigates to the previous matching cell. |
| `GetSearchRecords()` | `List<TreeGridSearchCellInfo>` | - | Gets the records that match the search text. |

`AllowCaseSensitiveProperty`, `AllowFilteringProperty`, `CanHighlightSearchTextProperty`, `SearchTypeProperty`, `SearchTextProperty`, and `SearchScopeProperty` are the bindable property identifiers of the corresponding properties. The `TreeGridSearchController` has a public constructor that accepts the owning `SfTreeGrid`.

### TreeGridSearchToolbarView

| Property | Type | Default | Description |
|---|---|---|---|
| `ShowClearButton` | `bool` | `true` | Shows or hides the clear icon. |
| `ShowNavigationButtons` | `bool` | `true` | Shows or hides the previous and next icons. |
| `ShowMoreOptions` | `bool` | `true` | Shows or hides the settings icon. |

`ShowClearButtonProperty`, `ShowNavigationButtonsProperty`, and `ShowMoreOptionsProperty` are the bindable property identifiers.

### TreeGridStyle

| Property | Type | Default | Description |
|---|---|---|---|
| `SearchTextColor` | `Color` | `#1C1B1F` | Text color of the matched text. |
| `SearchTextBackground` | `Color` | `#FDFDA5` | Background color of the matched text. |
| `SearchHighlightTextColor` | `Color` | `#1C1B1F` | Text color of the current search result. |
| `SearchHighlightTextBackground` | `Color` | `#FFD66C` | Background color of the current search result. |
| `SearchToolbarBackground` | `Color` | `#F7F2FB` | Background color of the search toolbar. |
| `SearchToolbarStroke` | `Color` | `#CAC4D0` | Border color of the search toolbar. |
| `SearchToolbarStrokeThickness` | `float` | `1` | Border thickness of the search toolbar. |
| `SearchBarBackground` | `Color` | `#E7E0EC` | Background color of the search bar. |
| `SearchBarTextColor` | `Color` | `#1C1B1F` | Text color of the search bar. |
| `SearchBarTextFontSize` | `double` | `14` | Font size of the search bar text. |
| `SearchBarTextFontFamily` | `string` | `null` | Font family of the search bar text. |
| `SearchBarTextFontAttributes` | `FontAttributes` | `None` | Font attributes of the search bar text. |
| `SearchCellBackground` | `Brush` | Transparent | Background of the search-matched cells. Verification Required – the source defines this property but does not use it to render the search results. |

### Related public types

| Type | Description |
|---|---|
| [TreeGridSearchType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchType.html) | Enum with the values `StartsWith`, `Contains`, and `EndsWith`. |
| [TreeGridSearchScope](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchScope.html) | Enum with the values `Both`, `ChildNodes`, and `RootNodes`. |
| [TreeGridSearchCellInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridSearchCellInfo.html) | Holds a matched record and its matched columns. |
| [TreeGridHelper.GetSearchViewAreaHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridHelper.html) | Extension method on `SfTreeGrid` that returns the height of the area occupied by the search toolbar. Verification Required – the returned value when `AllowSearching` is `false` is not verified. |

## Complete example

The following example enables the search UI, restricts the toolbar options, and adds a button that moves to the next match.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TreeGridSearch"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"
             x:Class="TreeGridSearch.MainPage">

    <ContentPage.BindingContext>
        <local:EmployeeViewModel />
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <Style TargetType="syncfusion:TreeGridSearchToolbarView">
            <Setter Property="ShowClearButton" Value="True"/>
            <Setter Property="ShowNavigationButtons" Value="True"/>
            <Setter Property="ShowMoreOptions" Value="True"/>
        </Style>
    </ContentPage.Resources>

    <Grid RowDefinitions="Auto,*">
        <Button Text="Find next 'Anna'" Clicked="OnFindNextClicked" />
        <syncfusion:SfTreeGrid x:Name="treeGrid"
                               Grid.Row="1"
                               ItemsSource="{Binding Employees}"
                               ChildPropertyName="ReportingPeople"
                               AutoExpandMode="AllNodesExpanded"
                               AllowSearching="True">
            <syncfusion:SfTreeGrid.DefaultStyle>
                <syncfusion:TreeGridStyle SearchHighlightTextBackground="LightGreen" />
            </syncfusion:SfTreeGrid.DefaultStyle>
        </syncfusion:SfTreeGrid>
    </Grid>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.TreeGrid;

namespace TreeGridSearch;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        treeGrid.SearchController.SearchType = TreeGridSearchType.Contains;
        treeGrid.SearchController.SearchScope = TreeGridSearchScope.Both;
    }

    private void OnFindNextClicked(object sender, EventArgs e)
    {
        treeGrid.SearchController.FindNext("Anna");
    }
}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeInfo.cs" %}
using System.Collections.ObjectModel;

namespace TreeGridSearch;

public class EmployeeInfo
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public ObservableCollection<EmployeeInfo> ReportingPeople { get; set; } = new();
}

public class EmployeeViewModel
{
    public ObservableCollection<EmployeeInfo> Employees { get; set; }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<EmployeeInfo>
        {
            new EmployeeInfo
            {
                Name = "Anna", Title = "CEO",
                ReportingPeople =
                {
                    new EmployeeInfo { Name = "Ravi", Title = "Manager" },
                    new EmployeeInfo { Name = "Hannah", Title = "Manager" }
                }
            }
        };
    }
}
{% endhighlight %}
{% endtabs %}

## Supported combinations

### Works with

* **Hierarchical and self-relational data**: The search is applied to the nodes of the tree. `GetSearchRecords` collects the matches from the nodes that are available in the tree.
* **Search scope**: Root nodes only, child nodes only, or both through `SearchScope`.
* **Filtering**: `AllowFiltering` displays only the matched records.
* **Custom search controller**: Derive from `TreeGridSearchController`.

### Does not work with

* **Check box columns**: The values of `TreeGridCheckBoxColumn` are not matched.
* **Columns without a `MappingName`, and hidden columns**: These columns do not participate in the search.

### Known limitations

* The cell text is matched using the formatted value that is displayed in the cell.
* The search text is matched as plain text. Special characters are escaped when the highlighting is applied.
* Verification Required – Combination support not verified: the search with sorting, stacked headers, and cell editing. Verification Required – whether the cells of collapsed nodes are searched by `FindNext` and `FindPrevious` is not verified; these methods iterate the rows that are currently in the view.

## Platform-specific considerations

| Platform | Behavior |
|---|---|
| Windows and macOS | The search bar is displayed in a rounded border, and `SearchBarBackground` is applied to it. |
| Android and iOS | The search bar is displayed in the search toolbar. `SearchBarBackground` is not applied. |

## See also

* [Filtering in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/filtering)
* [Selection in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/selection)
* [Styling in .NET MAUI Tree Grid](https://help.syncfusion.com/maui/treegrid/styling)

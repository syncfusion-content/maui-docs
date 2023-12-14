---
layout: post
title: Paging in MAUI DataGrid control | Syncfusion
description: Learn here all about Paging support in Syncfusion MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Paging in MAUI DataGrid (SfDataGrid)

The data grid interactively supports data manipulation through the `SfDataPager` control, providing built-in options to page data on demand when dealing with large volumes. The `SfDataPager` can be placed above or below as needed to easily manage data paging.

To use paging functionality into the data grid, include the following namespace in your project:
`Syncfusion.Maui.DataGrid.DataPager`

There are two different modes in paging:

 * NormalPaging: It loads the entire data collection to the `SfDataPager`.
 * OnDemandPaging: It loads data to the current page dynamically in `SfDataPager`.

## Normal paging

The data grid performs data paging using the `SfDataPager`. To enable paging, follow these steps:

 * Create a new instance of `SfDataPager`, and bind the data collection to the `SfDataPager.Source` property. This will internally create `SfDataPager.PagedSource`. 
 * Bind the `PagedSource` property to the `ItemsSource` of the data grid. 
 * Set the `SfDataPager.PageSize` property to determine the number of rows to be displayed on each page.
 * Set the `SfDataPager.NumericButtonCount` property to specify the number of buttons that should be displayed in view."

N> The `SfDataPager.PageSize` property should not be assigned with value 0.

The following code example illustrates using `SfDataPager` with the data grid control:

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PagerSample.MainPage"
             Title="MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:pager="clr-namespace:Syncfusion.Maui.DataGrid.DataPager;assembly=Syncfusion.Maui.DataGrid"
             xmlns:local="clr-namespace:PagerSample">

<ContentPage.BindingContext>
    <local:DataPagerViewModel x:Name="viewModel" />
</ContentPage.BindingContext>
  
<ContentPage.Content>
    <Grid> 
      <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
      </Grid.RowDefinitions>
      <pager:SfDataPager x:Name ="dataPager"
                           Grid.Row="1"
                           PageSize="15" 
                           NumericButtonCount="10"
                           Source="{Binding OrdersInfo}">
      </pager:SfDataPager>      
      <syncfusion:SfDataGrid x:Name="dataGrid"
                         Grid.Row="0"
                         AutoGenerateColumns="true"
                         SelectionMode="Single"
                         ItemsSource="{Binding Source={x:Reference dataPager}, Path=PagedSource }"  
                         >
      </syncfusion:SfDataGrid>
    </Grid> 
      </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    DataPagerViewModel viewModel;
	SfDataGrid dataGrid;
	SfDataPager pager;
	public NormalPage()
	{
		InitializeComponent();
        viewModel = new DataPagerViewModel();
        pager = new SfDataPager();
		pager.PageSize = 15;
		pager.NumericButtonCount = 10;
		pager.Source = viewModel.OrdersInfo;
        dataGrid = new SfDataGrid();
		dataGrid.ItemsSource = pager.PagedSource;
		Grid grid = new Grid();
		grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
		grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
		grid.Children.Add(dataGrid);
		grid.Children.Add(pager);
		grid.SetRow(dataGrid, 0);
		grid.SetRow(pager, 1);
		this.Content = grid;
	}
}

{% endhighlight %}
{% endtabs %}

The following screenshot shows the outcome upon execution of the above code:

![Normal paging .NET MAUI DataGrid](Images\paging\maui-datagrid-normal-paging.png)

## OnDemandPaging	

In normal Paging, data collection is entirely loaded initially into the `SfDataPager`. However, the control also allows for dynamically loading the data for the current page by setting `SfDataPager.UseOnDemandPaging` to `true`.

To load the current page item dynamically, hook into the `OnDemandLoading` event. In the `OnDemandLoading` event, use the `LoadDynamicItems` method to load data for the corresponding page in the `SfDataPager`.

The `OnDemandLoading` event is triggered when the pager moves to the corresponding page. It contains the following event arguments:

 * `StartIndex`: Displays start index of the corresponding page.
 * `PageSize`: Displays the number of items to be loaded for that page.

To load data for the DataPager control dynamically, follow the code example:

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PagerSample.MainPage"
             Title="MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:pager="clr-namespace:Syncfusion.Maui.DataGrid.DataPager;assembly=Syncfusion.Maui.DataGrid"
             xmlns:local="clr-namespace:PagerSample">

<ContentPage.BindingContext>
    <local:DataPagerViewModel x:Name="viewModel" />
</ContentPage.BindingContext>
  
<ContentPage.Content>
    <Grid> 
      <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
      </Grid.RowDefinitions>
      <pager:SfDataPager x:Name ="dataPager"
                           Grid.Row="1"
                           PageSize="15" 
                           NumericButtonCount="10"
                           PageCount="10"
                           OnDemandLoading="dataPager_OnDemandLoading"
                           UseOnDemandPaging="True">
      </pager:SfDataPager>      
      <syncfusion:SfDataGrid x:Name="dataGrid"
                         Grid.Row="0"
                         AutoGenerateColumns="true"
                         SelectionMode="Single"
                         ItemsSource="{Binding Source={x:Reference dataPager}, Path=PagedSource }"  
                         >
      </syncfusion:SfDataGrid>
    </Grid> 
      </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    DataPagerViewModel viewModel;
	SfDataGrid dataGrid;
	SfDataPager pager;
	public NormalPage()
	{
		InitializeComponent();
        viewModel = new DataPagerViewModel();
        pager = new SfDataPager();
		pager.PageSize = 15;
		pager.NumericButtonCount = 10;
		pager.PageCount = 10;
        pager.UseOnDemandPaging = true
        pager.OnDemandLoading += dataPager_OnDemandLoading;
        dataGrid = new SfDataGrid();
		dataGrid.ItemsSource = pager.PagedSource;
		Grid grid = new Grid();
		grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
		grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
		grid.Children.Add(dataGrid);
		grid.Children.Add(pager);
		grid.SetRow(dataGrid, 0);
		grid.SetRow(pager, 1);
		this.Content = grid;
	}

  private void dataPager_OnDemandLoading(object sender, OnDemandLoadingEventArgs e)
  {
     pager.LoadDynamicItems(e.StartIndex, viewModel.OrdersInfo.Skip(e.StartIndex).Take(e.PageSize));
  }
}

{% endhighlight %}
{% endtabs %}


N>In on-demand paging, you should not assign a value to the `Source` property. Additionally, you have to define an integer value for the `PageCount` property to generate the required numeric buttons in the view.

When using `OnDemandPaging`, `SfDataPager.PagedSource` loads only the current page data. Upon navigation to another page, `OnDemandLoading` event is fired which loads another set of data, but maintains the previous page data also. When you navigate to the previous page again, OnDemandLoading event is not fired, and the required data maintained in the cache is loaded. However, for further performance enhancement if you do not want to maintain the previous page data, call `Syncfusion.Data.PagedCollectionView.ResetCache()` in the `OnDemandLoading` event. ResetCache method call resets the cache except the current page.

To use ResetCache method, follow the code example:

{% highlight c# %}

private void dataPager_OnDemandLoading(object sender, OnDemandLoadingEventArgs e)
{
     pager.LoadDynamicItems(e.StartIndex, viewModel.OrdersInfo.Skip(e.StartIndex).Take(e.PageSize));
     (pager.PagedSource as PagedCollectionView).ResetCache();
}

{% endhighlight %}

## Numeric button shapes

The `SfDataPager` allows you to change the shape of the buttons using the `SfDataPager.ButtonShape` property. 

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                         ButtonShape="Rectangle"
                         PageSize="15"
                         Source="{Binding OrdersInfo}">
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.ButtonShape = DataPagerButtonShape.Rectangle;
    }
}
{% endhighlight %}
{% endtabs %}

![Numeric button shape .NET MAUI DataGrid](Images\paging\maui-datagrid-button-shape.png)

## Generating numeric buttons

The `SfDataPager` allows you to choose the generation mode of numeric buttons using the `SfDataPager.NumericButtonsGenerateMode` property. The numeric buttons can be generated either automatically in view or by specifying the count directly in the `SfDataPager.NumericButtonCount` property.

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                         NumericButtonsGenerateMode="Auto"
                         PageSize="15"
                         Source="{Binding OrdersInfo}">
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.NumericButtonsGenerateMode = DataPagerNumericButtonsGenerateMode.Auto;
    }
}
{% endhighlight %}
{% endtabs %}

N> The size of the `SfDataPager` is automatically adjusted based on the available screen size if the view cannot accommodate the numeric buttons specified in the `NumericButtonCount` property.

## Customizing button size and font size of pager buttons

The `SfDataPager` button is loaded with a default width and height of 40. The default button font size of `SfDataPager` is 14. You can customize the button size and font size by setting the desired values for the `SfDataPager.ButtonSize` and `SfDataPager.ButtonFontSize` properties, respectively.

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                   PageSize="15"
                   ButtonSize="60"
                   ButtonFontSize="21"
                   Source="{Binding OrdersInfo}">
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.ButtonSize = 60;
        dataPager.ButtonFontSize = 21;
    }
}
{% endhighlight %}
{% endtabs %}

![Button size and Font size of .NET MAUI DataGrid](Images\paging\maui-datagrid-buttonsize-and-fontsize.png)

## DisplayMode

The `SfDataPager.DisplayMode` property enables the user to personalize the buttons displayed on the datapager. By default, all buttons (including first, last, next, previous, and numeric buttons) are visible.

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                   PageSize="15"
                   DisplayMode="FirstLastNumeric"
                   Source="{Binding OrdersInfo}">
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.DisplayMode = DataPagerDisplayMode.FirstLastNumeric;
    }
}
{% endhighlight %}
{% endtabs %}

## AutoElipsisMode

The `AutoEllipsisMode` is a feature that determines the ellipsis mode for the numeric buttons within the scrollable panel of the SfDataPager. By default, all numeric buttons on the page are visible. However, you have the option to adjust the auto ellipsis mode using the `SfDataPager.AutoEllipsisMode` property.

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                   PageSize="15"
                   AutoEllipsisMode="After"
                   Source="{Binding OrdersInfo}">
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.AutoEllipsisMode = DataPagerEllipsisMode.After;
    }
}
{% endhighlight %}
{% endtabs %}

![AutoEllipsisMode .NET MAUI DataGrid](Images\paging\maui-datagrid-autoelipsismode.png)

## AutoEllipsisText

The data pager allows the user to customize the text to be displayed in the auto ellipsis mode by using `SfDataPager.AutoEllipsisText` property. The default value of `AutoEllipsisText` is set to `…`.

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                   PageSize="15"
                   AutoEllipsisMode="After"
                   AutoEllipsisText="***"
                   Source="{Binding OrdersInfo}">
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.AutoEllipsisMode = DataPagerEllipsisMode.After;
        dataPager.AutoEllipsisText = "***";
    }
}
{% endhighlight %}
{% endtabs %}

## Move to pages programmatically

### MoveToFirstPage

The data pager allows the users to programmatically navigate to the first page using the `MoveToFirstPage()` method.

### MoveToLastPage

The data pager allows the users to programmatically navigate to the last page using the `MoveToLastPage()` method.

### MoveToNextPage

The data pager allows the users to programmatically navigate to the next page using the `MoveToNextPage()` method.

### MoveToPreviousPage

The data pager allows the users to programmatically navigate to the previous page using the `MoveToPreviousPage()` method.

### MoveToPage(Int32)

The data pager allows the users to programmatically navigate to the desired page using the `MoveToPage(Int32)` method.

### MoveToPage(Int32, Int32, Boolean)

The data pager allows the users to programmatically navigate to the desired page from the current page using the `MoveToPage(Int32, Int32, Boolean)` method.

## Orientation

By default, `SfDataPager` scrolls horizontally. However, `SfDataPager.Orientation` property allows users to customize the pager to scroll vertically or horizontally according to their preferences.

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                   PageSize="15"
                   Orientation="Vertical"
                   Source="{Binding OrdersInfo}">
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.Orientation = DataPagerScrollOrientation.Vertical;
    }
}
{% endhighlight %}
{% endtabs %}

## Events

### PageChanged

The `PageChanged` event is triggered when the user navigates form one page to another page. `SfDataPager.PageChangedEventArgs` contains the following members, which provide the information for `PageChanged` event:

* **OldPageIndex** - Gets the current page index from which the page is navigated.
* **NewPageIndex** - Gets the new page index to which the page is navigated.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.PageChanged += DataPager_PageChanged;
    }

    private void DataPager_PageChanged(object sender, Syncfusion.Maui.DataGrid.DataPager.PageChangedEventArgs e)
    {
        // you can get the old page index and new page index here.
    }
}
{% endhighlight %}
{% endtabs %}

### PageChanging

The `PageChanging` event is triggered when the user navigation form one page to another page begins. `SfDataPager.PageChangingEventArgs` contains the following members, which provide the information for `PageChanging` event:

* **OldPageIndex** - Gets the current page index from which the page is navigating
.
* **NewPageIndex** - Gets the new page index to which the page is navigating.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.PageChanging += DataPager_PageChanging;
    }

    private void DataPager_PageChanging(object sender, Syncfusion.Maui.DataGrid.DataPager.PageChangingEventArgs e)
    {
        // you can get the old page index and new page index here.
    }
}
{% endhighlight %}
{% endtabs %}

## DataPagerStyle

The data pager allows you to change its appearance by changing the properties of `DataPagerStyle` and then assigning it to the `SfDataPager.DefaultStyle` property.

The `SfDataPager` allows customizing the appearance using the following properties.

<table>
<tr>
<th> Property </th>
<th> Description </th>
</tr>
<tr>
<td> {{'`DataPagerBackgroundColor`'| markdownify }} </td>
<td> Gets or sets the background color of the SfDataPager.</td>
</tr>
<tr>
<td> {{'`NavigationButtonBackgroundColor`'| markdownify }} </td>
<td> Gets or sets the background color of the navigation button.</td>
</tr>
<tr>
<td> {{'`NavigationButtonDisableBackgroundColor`'| markdownify }} </td>
<td> Gets or sets the background color of the navigation button when it is in a disabled state.</td>
</tr>
<tr>
<td> {{'`NavigationButtonDisableIconColor`'| markdownify }} </td>
<td> Gets or sets the icon color of the navigation button when it is in a disabled state.</td>
</tr>
<tr>
<td> {{'`NavigationButtonIconColor`'| markdownify }} </td>
<td> Gets or sets the icon color of the navigation buttons.</td>
</tr>
<tr>
<td> {{'`NumericButtonBackgroundColor`'| markdownify }} </td>
<td> Gets or sets the background color for numeric button.</td>
</tr>
<tr>
<td> {{'`NumericButtonSelectionBackgroundColor`'| markdownify }} </td>
<td> Gets or sets background color of the selection numeric button.</td>
</tr>
<tr>
<td> {{'`NumericButtonSelectionTextColor`'| markdownify }} </td>
<td> Gets or sets the foreground color of the selection numeric button.</td>
</tr>
<tr>
<td> {{'`NumericButtonTextColor`'| markdownify }} </td>
<td> Gets or sets the foreground color of the numeric button.</td>
</tr>
<tr>
<td> {{'`FirstPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template of the first page button template.</td>
</tr>
<tr>
<td> {{'`LastPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template of the last page button template.</td>
</tr>
<tr>
<td> {{'`NextPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template of the next page button template.</td>
</tr>
<tr>
<td> {{'`PreviousPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template of the previous page button template.</td>
</tr>
</table>
  
To apply custom style, follow the code example:

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                         PageSize="15"
                         Source="{Binding OrdersInfo}">
                <pager:SfDataPager.DefaultStyle >
                    <pager:DataPagerStyle NumericButtonSelectionBackgroundColor="Red"
                                          NumericButtonBackgroundColor="GreenYellow"
                                          NavigationButtonBackgroundColor="Black"
                                          NavigationButtonIconColor="White">
                    </pager:DataPagerStyle>
                </pager:SfDataPager.DefaultStyle>
</pager:SfDataPager>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataPager.DefaultStyle.NumericButtonSelectionBackgroundColor = Colors.Red;
        dataPager.DefaultStyle.NumericButtonBackgroundColor = Colors.GreenYellow;
        dataPager.DefaultStyle.NavigationButtonBackgroundColor = Colors.Black;
        dataPager.DefaultStyle.NavigationButtonIconColor = Colors.White;
    }
}
{% endhighlight %}
{% endtabs %}

The following picture shows the customize styles of data pager:

![DataPager style .NET MAUI DataGrid](Images\paging\maui-datagrid-pager-style.png)

### Limitations
1. UI Filtering is not supported. You can code at the application level to filter the data.
2. Data processing operations (Sorting, Grouping) are performed only on the current page. 
3. Deleting is not supported. You can code to delete a row at the application level. 
4. Only the navigated pages are exported when 'OnDemandPaging' is enabled. If the cache of the navigated page is cleared, then the corresponding page will not be exported.


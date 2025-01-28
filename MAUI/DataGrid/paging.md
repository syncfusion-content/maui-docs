---
layout: post
title: Paging in MAUI DataGrid control | Syncfusion
description: Learn here all about Paging support in Syncfusion MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui paging, maui paging
---

# Paging in MAUI DataGrid (SfDataGrid)

The data grid interactively supports data manipulation through the [SfDataPager](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html) control, providing built-in options to page data on demand when dealing with large volumes. The `SfDataPager` can be placed above or below as needed to easily manage data paging.

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

N> The [SfDataPager.PageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_PageSize) property should not be assigned with value 0.

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

![Normal paging .NET MAUI DataGrid.](Images\paging\net-maui-datagrid-normal-paging.png)

## On-Demand Paging	

In normal Paging, data collection is entirely loaded initially into the `SfDataPager`. However, the control also allows for dynamically loading the data for the current page by setting [SfDataPager.UseOnDemandPaging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_UseOnDemandPaging) to `true`.

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

The `SfDataPager` allows you to change the shape of the buttons using the [SfDataPager.ButtonShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_ButtonShape) property. 

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

![Numeric button shape .NET MAUI DataGrid.](Images\paging\net-maui-datagrid-button-shape.png)

## Generating numeric buttons

The `SfDataPager` allows you to choose the generation mode of numeric buttons using the [SfDataPager.NumericButtonsGenerateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_NumericButtonsGenerateMode) property. The numeric buttons can be generated either automatically in view or by specifying the count directly in the [SfDataPager.NumericButtonCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_NumericButtonCount) property.

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

The `SfDataPager` button is loaded with a default width and height of 40. The default button font size of `SfDataPager` is 14. You can customize the button size and font size by setting the desired values for the [SfDataPager.ButtonSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_ButtonSize) and [SfDataPager.ButtonFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_ButtonFontSize) properties, respectively.

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

![Button size and font size of .NET MAUI DataGrid.](Images\paging\net-maui-datagrid-buttonsize-and-fontsize.png)

## Display mode

The visibility of the numeric and navigation buttons can be personalized by using the [SfDataPager.DisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_DisplayMode) property. All the buttons will be visible by default.

<table>
<tr>
<th> Property Value </th>
<th> Description </th>
</tr>
<tr>
<td> {{'`None`'| markdownify }} </td>
<td> Do not display any page buttons.</td>
</tr>
<tr>
<td> {{'`First`'| markdownify }} </td>
<td> Displays only the first page button.</td>
</tr>
<tr>
<td> {{'`Last`'| markdownify }} </td>
<td> Displays only the last page button.</td>
</tr>
<tr>
<td> {{'`Previous`'| markdownify }} </td>
<td> Displays only the previous page button.</td>
</tr>
<tr>
<td> {{'`Next`'| markdownify }} </td>
<td> Displays only the next page button.</td>
</tr>
<tr>
<td> {{'`Numeric`'| markdownify }} </td>
<td> Displays only the numeric page buttons.</td>
</tr>
<tr>
<td> {{'`FirstLast`'| markdownify }} </td>
<td> Displays the first and last page buttons.</td>
</tr>
<tr>
<td> {{'`PreviousNext`'| markdownify }} </td>
<td> Displays the previous and next page buttons.</td>
</tr>
<tr>
<td> {{'`FirstLastNumeric`'| markdownify }} </td>
<td> Displays the first, last and numeric page buttons.</td>
</tr>
<tr>
<td> {{'`PreviousNextNumeric`'| markdownify }} </td>
<td> Displays the previous, next and numeric page buttons.</td>
</tr>
<tr>
<td> {{'`FirstLastPreviousNext`'| markdownify }} </td>
<td> Displays the first, last, previous and next page buttons.</td>
</tr>
<tr>
<td> {{'`FirstLastPreviousNextNumeric`'| markdownify }} </td>
<td> Displays the first, last, numeric, previous and next page buttons.</td>
</tr>
</table>

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

## Auto-ellipsis mode

The `SfDataPager` offers support for displaying an ellipsis button at the beginning and end of the numeric buttons when the scroll view contains additional numeric buttons before or after the currently selected numeric button. It can be customized by using the [SfDataPager.AutoEllipsisMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_AutoEllipsisMode) property.

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

![Auto-ellipsis mode .NET MAUI DataGrid.](Images\paging\net-maui-datagrid-autoelipsismode.png)

## Customize the auto-ellipsis text

The auto-ellipsis text can be customized by using the [SfDataPager.AutoEllipsisText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_AutoEllipsisText) property. The default value of `AutoEllipsisText` is set to `…`.

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

## Programmatically switch pages

### Move to the first page

The data pager allows the users to programmatically navigate to the first page using the [MoveToFirstPage()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_MoveToFirstPage) method.

### Move to the last page

The data pager allows the users to programmatically navigate to the last page using the [MoveToLastPage()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_MoveToLastPage) method.

### Move to to the next page

The data pager allows the users to programmatically navigate to the next page using the [MoveToNextPage()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_MoveToNextPage) method.

### Move to to the previous page

The data pager allows the users to programmatically navigate to the previous page using the [MoveToPreviousPage()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_MoveToPreviousPage) method.

### Move to page

The data pager allows the users to programmatically navigate to the desired page using the [MoveToPage(Int32)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_MoveToPage_System_Int32_) method. Users can also able to navigate to the page with animation using the [MoveToPage(Int32, Int32, Boolean)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_MoveToPage_System_Int32_System_Int32_System_Boolean_) method.

## Orientation

By default, `SfDataPager` displays the button in the horizontal direction. However, the [SfDataPager.Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_Orientation) property allows users to customize the data pager to display the buttons vertically or horizontally according to their preferences.

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

### PageChanging

The `PageChanging` event is triggered when the user navigation form one page to another page begins. [SfDataPager.PageChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.PageChangingEventArgs.html) contains the following members, which provide the information for `PageChanging` event:

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

### PageChanged

The `PageChanged` event is triggered when the user navigates form one page to another page. [SfDataPager.PageChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.PageChangedEventArgs.html) contains the following members, which provide the information for `PageChanged` event:

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

## Customize the appearance

The data pager allows you to change its appearance by modifying the properties of [DataPagerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerStyle.html) and then assigning it to the `SfDataPager.DefaultStyle` property.

The `SfDataPager` enables customization of its appearance using the following properties:

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
<td> Gets or sets the background color of the navigation buttons.</td>
</tr>
<tr>
<td> {{'`NavigationButtonDisableBackgroundColor`'| markdownify }} </td>
<td> Gets or sets the background color of the navigation buttons when it is disabled.</td>
</tr>
<tr>
<td> {{'`NavigationButtonDisableIconColor`'| markdownify }} </td>
<td> Gets or sets the icon color of the navigation buttons when it is disabled.</td>
</tr>
<tr>
<td> {{'`NavigationButtonIconColor`'| markdownify }} </td>
<td> Gets or sets the icon color of the navigation buttons.</td>
</tr>
<tr>
<td> {{'`NumericButtonBackgroundColor`'| markdownify }} </td>
<td> Gets or sets the background color for the numeric buttons.</td>
</tr>
<tr>
<td> {{'`NumericButtonSelectionBackgroundColor`'| markdownify }} </td>
<td> Gets or sets the background color of the numeric button that is currently selected.</td>
</tr>
<tr>
<td> {{'`NumericButtonSelectionTextColor`'| markdownify }} </td>
<td> Gets or sets the text color of the numeric button that is currently selected.</td>
</tr>
<tr>
<td> {{'`NumericButtonTextColor`'| markdownify }} </td>
<td> Gets or sets the text color of the numeric buttons.</td>
</tr>
<tr>
<td> {{'`FirstPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template for the first page navigation button.</td>
</tr>
<tr>
<td> {{'`LastPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template for the last page navigation button.</td>
</tr>
<tr>
<td> {{'`NextPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template for the next page navigation button.</td>
</tr>
<tr>
<td> {{'`PreviousPageButtonTemplate`'| markdownify }} </td>
<td> Gets or sets the template for the previous page navigation button.</td>
</tr>
</table>
  
To apply custom style, follow the code example:

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager x:Name="dataPager"
                         PageSize="15"
                         Source="{Binding OrdersInfo}">
                <pager:SfDataPager.DefaultStyle >
                    <pager:DataPagerStyle NumericButtonSelectionBackgroundColor="Pink"
                                          NumericButtonBackgroundColor="Purple"
                                          NavigationButtonBackgroundColor="LightBlue"
                                          NavigationButtonIconColor="Teal">
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

![Data pager style .NET MAUI DataGrid.](Images\paging\net-maui-datagrid-pager-style.png)

### Limitations
1. UI Filtering is not supported. You can code at the application level to filter the data.
2. Data processing operations (Sorting, Grouping) are performed only on the current page. 
3. Deleting is not supported. You can code to delete a row at the application level. 
4. Only the navigated pages are exported when 'OnDemandPaging' is enabled. If the cache of the navigated page is cleared, then the corresponding page will not be exported.


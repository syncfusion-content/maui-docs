---
layout: post
title: Customization in .NET MAUI DataPager | Syncfusion®
description: Learn how to customize the appearance of the Syncfusion® .NET MAUI DataPager control including button shapes, sizes, and display modes.
platform: MAUI
control: SfDataPager
documentation: UG
keywords : maui datapager, datapager Customization, button shape, button size, display mode, .net maui datapager
---

# Customization in .NET MAUI DataPager

The DataPager allows you to customize its appearance and layout to match your application's design requirements.

## Numeric button shapes

The `SfDataPager` allows you to change the shape of the buttons using the [SfDataPager.ButtonShape]() property.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           ButtonShape="Rectangle"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.ButtonShape = DataPagerButtonShape.Rectangle;
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

<img alt="Numeric button shape .NET MAUI DataPager." src="Images\customization\net-maui-datapager-button-shape.png" width="404"/>

## Generating numeric buttons

The `SfDataPager` allows you to choose the generation mode of numeric buttons using the [SfDataPager.NumericButtonsGenerateMode]() property. The numeric buttons can be generated either automatically in view or by specifying the count directly in the [SfDataPager.NumericButtonCount]() property.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           NumericButtonsGenerateMode="Auto"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.NumericButtonsGenerateMode = DataPagerNumericButtonsGenerateMode.Auto;
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

> **Note:** The size of the `SfDataPager` is automatically adjusted based on the available screen size if the view cannot accommodate the numeric buttons specified in the `NumericButtonCount` property.

## Customizing button size and font size of pager buttons

The `SfDataPager` button is loaded with a default width and height of 40. The default button font size of `SfDataPager` is 14. You can customize the button size and font size by setting the desired values for the [SfDataPager.ButtonSize]() and [SfDataPager.ButtonFontSize]() properties, respectively.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           ButtonSize="60"
                           ButtonFontSize="21"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.ButtonSize = 60;
dataPager.ButtonFontSize = 21;
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

<img alt="Button size and font size of .NET MAUI DataPager." src="Images\customization\net-maui-datapager-buttonsize-and-fontsize.png" width="404"/>

## Display mode

The visibility of the numeric and navigation buttons can be personalized by using the [SfDataPager.DisplayMode]() property. The default value is `FirstLastPreviousNextNumeric`, which displays all navigation and numeric buttons.

<table>
<tr>
<th> Property Value </th>
<th> Description </th>
</tr>
<tr>
<td> {{'`None`'| markdownify }} </td>
<td> Displays no page buttons.</td>
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
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           DisplayMode="FirstLastNumeric"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.DisplayMode = DataPagerDisplayMode.FirstLastNumeric;
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

## Auto-ellipsis mode

The `AutoEllipsisMode` property controls whether ellipsis buttons appear for navigating large ranges of page numbers, whereas the `DisplayMode` property controls which button types (First, Last, Previous, Next, Numeric) are visible. The `SfDataPager` offers support for displaying an ellipsis button at the beginning and end of the numeric buttons when the scroll view contains additional numeric buttons before or after the currently selected numeric button. It can be customized by using the [SfDataPager.AutoEllipsisMode]() property.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           AutoEllipsisMode="After"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.AutoEllipsisMode = DataPagerEllipsisMode.After;
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

<img alt="Auto-ellipsis mode .NET MAUI DataPager." src="Images\customization\net-maui-datapager-autoelipsismode.png" width="404"/>

## Customize the auto-ellipsis text

The auto-ellipsis text can be customized by using the [SfDataPager.AutoEllipsisText]() property. The default value of `AutoEllipsisText` is set to `…`.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           AutoEllipsisMode="After"
                           AutoEllipsisText="***"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.AutoEllipsisMode = DataPagerEllipsisMode.After;
dataPager.AutoEllipsisText = "***";
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

## Orientation

By default, `SfDataPager` displays buttons in the horizontal direction. However, the [SfDataPager.Orientation]() property allows users to customize the data pager to display the buttons vertically or horizontally according to their preferences.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="Auto" />
    </Grid.ColumnDefinitions>
    <Border Grid.Column="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           Orientation="Vertical"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           Grid.Column="0"
                           ItemsSource="{Binding Source={x:Reference dataPager}, Path=PagedSource}">
    </syncfusion:SfDataGrid>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.Orientation = DataPagerScrollOrientation.Vertical;
dataPager.Source = viewModel.Orders;

SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = dataPager.PagedSource;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
grid.Children.Add(dataGrid);
grid.Children.Add(border);
grid.SetColumn(dataGrid, 0);
grid.SetColumn(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

---
layout: post
title: Appearance in .NET MAUI DataPager | Syncfusion®
description: Learn how to customize the style and colors of the Syncfusion® .NET MAUI DataPager control for a tailored user experience.
platform: MAUI
control: SfDataPager
documentation: UG
keywords : maui datapager, datapager appearance, datapager style, customize appearance, .net maui datapager
---

# Appearance in .NET MAUI DataPager

The DataPager allows you to change its appearance by modifying the properties of [DataPagerStyle]() and then assigning it to the `SfDataPager.DefaultStyle` property.

## Customizing appearance

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
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" 
            Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           Source="{Binding Orders}">
            <pager:SfDataPager.DefaultStyle >
                <pager:DataPagerStyle NumericButtonSelectionBackgroundColor="#cdb4db"
                                      NumericButtonBackgroundColor="#ffc8dd"
                                      NavigationButtonBackgroundColor="#90e0ef"
                                      NavigationButtonIconColor="#0077b6"
                                      NavigationButtonDisableBackgroundColor="#caf0f8"
                                      NavigationButtonDisableIconColor="#9a8c98">
                </pager:DataPagerStyle>
            </pager:SfDataPager.DefaultStyle>
        </pager:SfDataPager>
    </Border>
    
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.Source = viewModel.Orders;

DataPagerStyle dataPagerStyle = new DataPagerStyle();
dataPagerStyle.NumericButtonSelectionBackgroundColor = Color.FromArgb("#CDB4DB");
dataPagerStyle.NumericButtonBackgroundColor = Color.FromArgb("#FFC8DD");
dataPagerStyle.NavigationButtonBackgroundColor = Color.FromArgb("#90E0EF");
dataPagerStyle.NavigationButtonIconColor = Color.FromArgb("#0077B6");
dataPagerStyle.NavigationButtonDisableBackgroundColor = Color.FromArgb("#CAF0F8");
dataPagerStyle.NavigationButtonDisableIconColor = Color.FromArgb("#9A8C98");
dataPager.DefaultStyle = dataPagerStyle;

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

The following picture shows the customize styles of data pager:

<img alt="DataPager style .NET MAUI DataPager." src="Images\appearance\net-maui-datapager-style.png" width="404"/>

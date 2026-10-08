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

The DataPager allows you to change its appearance by modifying the properties of [DataPagerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html) and then assigning it to the `SfDataPager.DefaultStyle` property.

## Customizing appearance

The `SfDataPager` enables customization of its appearance using the following properties:

<table>
<tr>
<th> Property </th>
<th> Description </th>
</tr>
<tr>
<td> {{'[DataPagerBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_DataPagerBackgroundColor)'| markdownify }} </td>
<td> Gets or sets the background color of the SfDataPager.</td>
</tr>
<tr>
<td> {{'[NavigationButtonBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NavigationButtonBackgroundColor)'| markdownify }} </td>
<td> Gets or sets the background color of the navigation buttons.</td>
</tr>
<tr>
<td> {{'[NavigationButtonDisableBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NavigationButtonDisableBackgroundColor)'| markdownify }} </td>
<td> Gets or sets the background color of the navigation buttons when it is disabled.</td>
</tr>
<tr>
<td> {{'[NavigationButtonDisableIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NavigationButtonDisableIconColor)'| markdownify }} </td>
<td> Gets or sets the icon color of the navigation buttons when it is disabled.</td>
</tr>
<tr>
<td> {{'[NavigationButtonIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NavigationButtonIconColor)'| markdownify }} </td>
<td> Gets or sets the icon color of the navigation buttons.</td>
</tr>
<tr>
<td> {{'[NumericButtonBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NumericButtonBackgroundColor)'| markdownify }} </td>
<td> Gets or sets the background color for the numeric buttons.</td>
</tr>
<tr>
<td> {{'[NumericButtonSelectionBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NumericButtonSelectionBackgroundColor)'| markdownify }} </td>
<td> Gets or sets the background color of the numeric button that is currently selected.</td>
</tr>
<tr>
<td> {{'[NumericButtonSelectionTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NumericButtonSelectionTextColor)'| markdownify }} </td>
<td> Gets or sets the text color of the numeric button that is currently selected.</td>
</tr>
<tr>
<td> {{'[NumericButtonTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NumericButtonTextColor)'| markdownify }} </td>
<td> Gets or sets the text color of the numeric buttons.</td>
</tr>
<tr>
<td> {{'[FirstPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_FirstPageButtonTemplate)'| markdownify }} </td>
<td> Gets or sets the template for the first page navigation button.</td>
</tr>
<tr>
<td> {{'[LastPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_LastPageButtonTemplate)'| markdownify }} </td>
<td> Gets or sets the template for the last page navigation button.</td>
</tr>
<tr>
<td> {{'[NextPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NextPageButtonTemplate)'| markdownify }} </td>
<td> Gets or sets the template for the next page navigation button.</td>
</tr>
<tr>
<td> {{'[PreviousPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_PreviousPageButtonTemplate)'| markdownify }} </td>
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

## Custom Template support for Navigation Buttons

### First Page Button Template

The `SfDataPager` allows you to customize the first page navigation button using the [SfDataPager.DefaultStyle.FirstPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_FirstPageButtonTemplate) property.

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
                <pager:DataPagerStyle NavigationButtonDisableBackgroundColor="#caf0f8"
                                      NavigationButtonBackgroundColor="#90e0ef">
                    <pager:DataPagerStyle.FirstPageButtonTemplate>
                        <DataTemplate>
                            <Label Text="❮❮"
                                   FontSize="20"
                                   TranslationY="-1"
                                   TranslationX="-1"
                                   TextColor="#075985"
                                   HorizontalTextAlignment="Center"
                                   VerticalTextAlignment="Center"
                                   HorizontalOptions="Center"
                                   VerticalOptions="Center"/>
                        </DataTemplate>
                    </pager:DataPagerStyle.FirstPageButtonTemplate>
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
dataPagerStyle.NavigationButtonBackgroundColor = Color.FromArgb("#90E0EF");
dataPagerStyle.NavigationButtonDisableBackgroundColor = Color.FromArgb("#CAF0F8");

dataPagerStyle.FirstPageButtonTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "❮❮",
        FontSize = 20,
        TranslationY = -1,
        TranslationX = -1,
        TextColor = Color.FromArgb("#075985"),
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
    };
});

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

### Previous Page Button Template

The `SfDataPager` allows you to customize the previous page navigation button using the [SfDataPager.DefaultStyle.PreviousPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_PreviousPageButtonTemplate) property.

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
                <pager:DataPagerStyle NavigationButtonDisableBackgroundColor="#caf0f8"
                                      NavigationButtonBackgroundColor="#90e0ef">
                    <pager:DataPagerStyle.PreviousPageButtonTemplate>
                        <DataTemplate>
                            <Label Text="❮"
                                   FontSize="20"
                                   TranslationY="-1"
                                   TranslationX="-1"
                                   TextColor="#075985"
                                   HorizontalTextAlignment="Center"
                                   VerticalTextAlignment="Center"
                                   HorizontalOptions="Center"
                                   VerticalOptions="Center"/>
                        </DataTemplate>
                    </pager:DataPagerStyle.PreviousPageButtonTemplate>
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
dataPagerStyle.NavigationButtonBackgroundColor = Color.FromArgb("#90E0EF");
dataPagerStyle.NavigationButtonDisableBackgroundColor = Color.FromArgb("#CAF0F8");

dataPagerStyle.PreviousPageButtonTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "❮",
        FontSize = 20,
        TranslationY = -1,
        TranslationX = -1,
        TextColor = Color.FromArgb("#075985"),
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
    };
});

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

### Next Page Button Template

The `SfDataPager` allows you to customize the next page navigation button using the [SfDataPager.DefaultStyle.NextPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_NextPageButtonTemplate) property.

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
                <pager:DataPagerStyle NavigationButtonDisableBackgroundColor="#caf0f8"
                                      NavigationButtonBackgroundColor="#90e0ef">
                    <pager:DataPagerStyle.NextPageButtonTemplate>
                        <DataTemplate>
                            <Label Text="❯"
                                   FontSize="20"
                                   TranslationY="-1"
                                   TextColor="#075985"
                                   HorizontalTextAlignment="Center"
                                   VerticalTextAlignment="Center"
                                   HorizontalOptions="Center"
                                   VerticalOptions="Center"/>
                        </DataTemplate>
                    </pager:DataPagerStyle.NextPageButtonTemplate>
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
dataPagerStyle.NavigationButtonBackgroundColor = Color.FromArgb("#90E0EF");
dataPagerStyle.NavigationButtonDisableBackgroundColor = Color.FromArgb("#CAF0F8");

dataPagerStyle.NextPageButtonTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "❯",
        FontSize = 20,
        TranslationY = -1,
        TextColor = Color.FromArgb("#075985"),
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
    };
});

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

### Last Page Button Template

The `SfDataPager` allows you to customize the last page navigation button using the [SfDataPager.DefaultStyle.LastPageButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataPager_DataPagerStyle_LastPageButtonTemplate) property.

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
                <pager:DataPagerStyle NavigationButtonDisableBackgroundColor="#caf0f8"
                                      NavigationButtonBackgroundColor="#90e0ef">
                    <pager:DataPagerStyle.LastPageButtonTemplate>
                        <DataTemplate>
                            <Label Text="❯❯"
                                   FontSize="20"
                                   TranslationY="-1"
                                   TextColor="#075985"
                                   HorizontalTextAlignment="Center"
                                   VerticalTextAlignment="Center"
                                   HorizontalOptions="Center"
                                   VerticalOptions="Center"/>
                        </DataTemplate>
                    </pager:DataPagerStyle.LastPageButtonTemplate>
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
dataPagerStyle.NavigationButtonBackgroundColor = Color.FromArgb("#90E0EF");
dataPagerStyle.NavigationButtonDisableBackgroundColor = Color.FromArgb("#CAF0F8");

dataPagerStyle.LastPageButtonTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "❯❯",
        FontSize = 20,
        TranslationY = -1,
        TextColor = Color.FromArgb("#075985"),
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
    };
});

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

<img alt="Customization of Navigation Button in .Net MAUI DataPager" src="Images\appearance\net-maui-datapager-navigation-button-template.png" width="404"/>
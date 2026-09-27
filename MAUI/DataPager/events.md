---
layout: post
title: Events in .NET MAUI DataPager | Syncfusion®
description: Learn about the events available in the Syncfusion® .NET MAUI DataPager control to handle page changes and perform custom operations.
platform: MAUI
control: SfDataPager
documentation: UG
keywords : maui datapager, datapager events, pagechanging, pagechanged, .net maui datapager
---

# Events in .NET MAUI DataPager

The DataPager control provides events that allow you to handle page changes and perform custom operations based on user interactions.

## PageChanging

The [PageChanging]() event is triggered when the user navigation from one page to another page begins. [SfDataPager.PageChangingEventArgs]() contains the following members, which provide information for the `PageChanging` event:

* **OldPageIndex** - Gets the current page index from which the page is navigating.
* **NewPageIndex** - Gets the new page index to which the page is navigating.

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
                           PageChanging="DataPager_PageChanging"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.PageChanging += DataPager_PageChanging;
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

{% tabs %}
{% highlight c# %}
private void DataPager_PageChanging(object sender, Syncfusion.Maui.DataPager.PageChangingEventArgs e)
{
    int oldPageIndex = e.OldPageIndex;
    int newPageIndex = e.NewPageIndex;
    // Perform any operations before the page changes
}
{% endhighlight %}
{% endtabs %}

## PageChanged
 
The [PageChanged]() event is triggered when the user navigates from one page to another page. [SfDataPager.PageChangedEventArgs]() contains the following members, which provide information for the `PageChanged` event:

* **OldPageIndex** - Gets the current page index from which the page is navigated.
* **NewPageIndex** - Gets the new page index to which the page is navigated.

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
                           PageChanged="DataPager_PageChanged"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.PageChanged += DataPager_PageChanged;
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

{% tabs %}
{% highlight c# %}
private void DataPager_PageChanged(object sender, Syncfusion.Maui.DataPager.PageChangedEventArgs e)
{
    int oldPageIndex = e.OldPageIndex;
    int newPageIndex = e.NewPageIndex;
    // Perform any operations after the page has changed
}
{% endhighlight %}
{% endtabs %}

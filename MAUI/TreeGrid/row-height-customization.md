---
layout: post
title: Row Height Customization in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to customize and auto-fit row heights in Syncfusion® .NET MAUI Tree Grid using RowHeight, HeaderRowHeight, QueryRowHeight, and GetIntrinsicRowHeight.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid, auto fit row height, treegrid row height, maui treegrid autofit, QueryRowHeight, GetIntrinsicRowHeight
appliesto: UI Component Suite
---

# Row Height Customization in .NET MAUI Tree Grid

The [.NET MAUI Tree Grid](https://www.syncfusion.com/maui-controls/maui-treegrid) (SfTreeGrid) allows you to customize row heights by using fixed values or automatically sizing rows based on their content.

By default, data rows use the value specified by [SfTreeGrid.RowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_RowHeight), and the header row uses the value specified by [SfTreeGrid.HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_HeaderRowHeight).

To automatically calculate row heights based on content, handle the [QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowHeight) event and use the [GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) method.

## Public APIs

| API | Type | Description |
| --- | --- | --- |
| [SfTreeGrid.RowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_RowHeight) | Property | Gets or sets the default height of data rows. |
| [SfTreeGrid.HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_HeaderRowHeight) | Property | Gets or sets the height of the header row. |
| [SfTreeGrid.QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowHeight) | Event (`EventHandler<TreeGridQueryRowHeightEventArgs>`) | Occurs when the height of a row is queried. |
| [TreeGridQueryRowHeightEventArgs.RowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_RowIndex) | `int` | Gets the row index whose height is queried. |
| [TreeGridQueryRowHeightEventArgs.Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_Height) | `double` | Gets or sets the row height. |
| [TreeGridQueryRowHeightEventArgs.Handled](https://help.syncfusion.com/cr/maui/System.ComponentModel.HandledEventArgs.html) | `bool` | Indicates whether the specified row height should be applied. |
| [TreeGridQueryRowHeightEventArgs.GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) | Method | Returns the height required to display the content of the specified row. |
| [TreeGridHelper.GetRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridHelper.html) | Extension Method | Returns the content-based height of a row. |

N> There is no separate property to enable auto-fit row height. Auto-fit is achieved by handling the `QueryRowHeight` event.

## Set the Default Row Height

The default height of all data rows can be customized by using the `RowHeight` property.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       x:Name = "treeGrid"
                       RowHeight = "60" />
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.RowHeight = 60;
{% endhighlight %}
{% endtabs %}

## Set the Header Row Height

The height of the header row can be customized by using the `HeaderRowHeight` property.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       x:Name = "treeGrid"
                       HeaderRowHeight = "70" />
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.HeaderRowHeight = 70;
{% endhighlight %}
{% endtabs %}

## Auto-Fit Data Rows Based on Content

Handle the `QueryRowHeight` event and assign the calculated height returned by `GetIntrinsicRowHeight`.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       x:Name = "treeGrid"
                       QueryRowHeight = "TreeGrid_QueryRowHeight" />
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.QueryRowHeight += TreeGrid_QueryRowHeight;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Row Height Customization in Tree Grid" src="Images\row-height-customization\maui-treegrid-autorowheight.png" width="404"/>

## Calculate Height Based on Certain Columns

You can exclude specific columns from the row height calculation by using the `excludedColumns` parameter.

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex, false, new List<string>() { "Description" });
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Include Hidden Columns in the Calculation

Hidden columns are excluded by default when calculating row height. To include them, set `canIncludeHiddenColumns` to `true`.

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex, true);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Auto-Fit Header Row Based on Header Content

The height of the header row can be calculated automatically based on its content.

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex == 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Apply a Custom Height to Specific Rows

Use the `QueryRowHeight` event to apply a custom height to specific rows.

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex == 3)
    {
        e.Height = 80;
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Get the Content-Based Height Outside the Event

Use the `GetRowHeight` extension method to retrieve the content-based height of a row outside the `QueryRowHeight` event.

{% tabs %}
{% highlight c# %}
double height = treeGrid.GetRowHeight(2);

double customHeight = treeGrid.GetRowHeight(2, canIncludeHiddenColumns: false, excludedColumns: new List<string>() { "Description" });
{% endhighlight %}
{% endtabs %}
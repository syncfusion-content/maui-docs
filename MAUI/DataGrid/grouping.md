---
layout: post
title: Grouping in MAUI DataGrid control | Syncfusion®
description: Learn here all about Grouping support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui grouping, maui grouping
---

# Grouping in MAUI DataGrid (SfDataGrid)

Grouping in a datagrid refers to the process of organizing and categorizing data based on specific criteria or field values. It allows you to group related records together, creating a hierarchical structure within the datagrid. Each group is identified by its [CaptionSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CaptionSummaryRowProperty) to get the underlying records in view.

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src="https://www.youtube.com/embed/OIwtE111xfk"></iframe>

N> 
* To update the grouping for the newly added row or column, set the `SfDataGrid.View.LiveDataUpdateMode` to `LiveDataUpdateMode.AllowDataShaping`.
* When `BeginInit` method is called, it suspends all the updates until `EndInit` method is called.

## UI Grouping

You can enable data grouping in the SfDataGrid by setting the [SfDataGrid.AllowGrouping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowGrouping) property to `true`. This allows end users to group data by dragging and dropping columns into the GroupDropArea. When a column is grouped, all records with the same value in that column are organized together in a group.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AllowGrouping="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowGrouping = true;
{% endhighlight %}
{% endtabs %}

You can group data by an unlimited of columns. To group multiple columns, drag and drop the desired column headers into the GroupDropArea.

<img alt="Maui UI Grouping" src="Images/Grouping/maui-datagrid-ui-grouping.png" width="404"/>

Each group is represented by a `CaptionSummaryRow`, which organizes data into a hierarchical tree structure according to identical values in the grouped column. Users can expand or collapse the underlying records in a group by clicking on its group caption.

A `CaptionSummaryRow` displays details about its group, such as the group name and the number of records it contains. For more details, refer to the [Caption Summaries](https://help.syncfusion.com/maui/datagrid/summaries#caption-summaries) section.

### Appearance

#### GroupDropAreaText

You can modify the GroupDropArea text by setting the [SfDataGrid.GroupDropAreaText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupDropAreaText) property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       GroupDropAreaText="Drag and drop the column here"
                       AllowGrouping="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowGrouping = true;
dataGrid.GroupDropAreaText = "Drag and drop the column here";
{% endhighlight %}
{% endtabs %}

<img alt="Maui UI Grouping Group Drop Area Text" src="Images/Grouping/maui-datagrid-ui-grouping-drop-area-text.png" width="404"/>

#### GroupDropAreaHeight

Use the [SfDataGrid.GroupDropAreaHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupDropAreaHeight) property to control the vertical size of the GroupDropArea (the region where users drag column headers to create groups).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       GroupDropAreaHeight="100"
                       AllowGrouping="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowGrouping = true;
dataGrid.GroupDropAreaHeight = 100;
{% endhighlight %}
{% endtabs %}

<img alt="Maui UI Grouping Group Drop Area Height" src="Images/Grouping/maui-datagrid-ui-grouping-drop-area-height.png" width="404"/>

#### Customize the GroupDropArea

You can style the `GroupDropArea` using the following SfDataGrid properties:

* [GroupDropAreaStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropAreaStrokeThickness): Sets the border thickness of the GroupDropArea.
* [GroupDropAreaStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropAreaStroke): Sets the border color of the GroupDropArea.
* [GroupDropAreaBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropAreaBackgroundColor): Sets the background color of the GroupDropArea.
* [GroupDropAreaTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropAreaTextColor): Sets the color of the instructional text displayed in the GroupDropArea.
* [GroupDropAreaFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropAreaFontSize): Sets the font size of the GroupDropArea text.
* [GroupDropAreaFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropAreaFontFamily): Sets the font family used for the GroupDropArea text.
* [GroupDropAreaFontAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropAreaFontAttribute): Sets the font style of the GroupDropArea text.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AllowGrouping="True">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle GroupDropAreaTextColor="Blue"
                                  GroupDropAreaBackgroundColor="Yellow"
                                  GroupDropAreaFontAttribute="Bold"
                                  GroupDropAreaFontSize="18"
                                  GroupDropAreaStroke="Brown"
                                  GroupDropAreaStrokeThickness="2"
                                  GroupDropAreaFontFamily="Roboto"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowGrouping = true;
var defaultStyle = new DataGridStyle()
{
    GroupDropAreaTextColor = Colors.Blue,
    GroupDropAreaBackgroundColor = Colors.Yellow,
    GroupDropAreaFontAttribute = FontAttributes.Bold,
    GroupDropAreaFontSize = 18,
    GroupDropAreaStroke = Colors.Brown,
    GroupDropAreaStrokeThickness = 2,
    GroupDropAreaFontFamily = "Roboto"
};

dataGrid.DefaultStyle = defaultStyle;
{% endhighlight %}
{% endtabs %}

#### Customize the GroupDropAreaItem

You can style the `GroupDropAreaItem` using the following SfDataGrid properties:

* [GroupDropItemBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemBackgroundColor): Sets the background color of the GroupDropItem.
* [GroupDropItemTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemTextColor): Sets the color of the text displayed in the GroupDropItem.
* [GroupDropItemFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemFontSize): Sets the font size of the GroupDropItem text.
* [GroupDropItemFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemFontFamily): Sets the font family used for the GroupDropItem text.
* [GroupDropItemFontAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemFontAttribute):  Sets the font style of the GroupDropItem text.
* [GroupDropItemStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemStrokeThickness): Sets the border thickness of the GroupDropItem.
* [GroupDropItemStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemStroke): Sets the border color of the GroupDropItem.
* [GroupDropItemCloseIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GroupDropItemCloseIconColor): Sets the color of the close icon displayed in the GroupDropItem.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AllowGrouping="True">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle GroupDropItemTextColor="Blue"
                                  GroupDropItemBackgroundColor="Yellow"
                                  GroupDropItemFontAttribute="Bold"
                                  GroupDropItemFontSize="18"
                                  GroupDropItemStroke="Brown"
                                  GroupDropItemStrokeThickness="2"
                                  GroupDropItemFontFamily="Roboto"
                                  GroupDropItemCloseIconColor="Gray"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowGrouping = true;
var defaultStyle = new DataGridStyle()
{
    GroupDropItemTextColor = Colors.Blue,
    GroupDropItemBackgroundColor = Colors.Yellow,
    GroupDropItemFontAttribute = FontAttributes.Bold,
    GroupDropItemFontSize = 18,
    GroupDropItemStroke = Colors.Brown,
    GroupDropItemStrokeThickness = 2,
    GroupDropItemFontFamily = "Roboto",
    GroupDropItemCloseIconColor = Colors.Gray
};

dataGrid.DefaultStyle = defaultStyle;
{% endhighlight %}
{% endtabs %}

## Programmatic Grouping

The SfDataGrid allows to perform grouping programmatically by adding the [GroupColumnDescription](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupColumnDescription.html) object in the [SfDataGrid.GroupColumnDescriptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupColumnDescriptionsProperty) collection. It groups the data based on the `GroupColumnDescription` object added to this collection.

`GroupColumnDescription` object holds following two properties:

 * ColumnName: The name of the grouped column.
 * Converter: It accepts an `IValueConverter` as input that helps to apply custom grouping.

To apply column grouping, please refer to the following code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.GroupColumnDescriptions>
        <syncfusion:GroupColumnDescription ColumnName="Name" />
    </syncfusion:SfDataGrid.GroupColumnDescriptions>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
    dataGrid.GroupColumnDescriptions.Add (new GroupColumnDescription () {
    ColumnName = "Name",
});
{% endhighlight %}
{% endtabs %}

The following screenshot shows the rendered output when grouping is applied:

![DataGrid with grouping](Images\Grouping\maui-datagrid-single-grouping.png)

### Clearing or removing a group

To clear the applied grouping, you can simply remove the particular item from the `SfDataGrid.GroupColumnDescriptions` collection or clear the entire collection.

{% tabs %}
{% highlight c# %}
//Clearing the Group
dataGrid.GroupColumnDescriptions.Clear();

//Removing the Group based on group item
var groupColumn = dataGrid.GroupColumnDescriptions[1];
dataGrid.GroupColumnDescriptions.Remove(groupColumn);
    
//Removing the Group based on group index
dataGrid.GroupColumnDescriptions.RemoveAt(0);
{% endhighlight%} 
{% endtabs %}

## Multi Grouping

The SfDataGrid also allows to group the data against one or more columns using the [SfDataGrid.GroupingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupingModeProperty) property. When the `GroupingMode` is set as `GroupingMode.Multiple`, the data is organized into a hierarchical tree structure based on identical values of that column. The multi-grouping feature works similarly to the multi-sorting feature. Initially, the data is grouped according to the first column added in the `GroupColumnDescriptions` collection. When more columns are added to the `GroupColumnDescriptions`, the newly added column will be grouped in consideration of the previous group(s). This results in a tree-like hierarchy. Refer to the following code snippet to enable `MultiGrouping`:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        ItemsSource="{Binding OrderInfoCollection}"
                        GroupingMode="Multiple">
                        
    <syncfusion:SfDataGrid.GroupColumnDescriptions>
        <syncfusion:GroupColumnDescription ColumnName="Name" />
        <syncfusion:GroupColumnDescription ColumnName="ShipCity" />
    </syncfusion:SfDataGrid.GroupColumnDescriptions>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}

this.dataGrid.GroupingMode = GroupingMode.Multiple;
    dataGrid.GroupColumnDescriptions.Add (new GroupColumnDescription () {
    ColumnName = "Name" });
    dataGrid.GroupColumnDescriptions.Add (new GroupColumnDescription () {
    ColumnName = "ShipCity" });
{% endhighlight %}
{% endtabs %}

The following screenshot shows the multi-grouping:
![DataGrid with multi-column grouping](Images\Grouping\maui-datagrid-multiple-grouping.png)

## Custom Grouping

The SfDataGrid allows to group a column based on custom logic when the standard grouping techniques do not meet the requirements.

### Using IValueConverter

To achieve this, you need to write a converter that implements `IValueConverter` with custom grouping logic and assign that converter to the [GroupColumnDescription.Converter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupColumnDescription.html#Syncfusion_Maui_DataGrid_GroupColumnDescription_Converter) property.

To set a custom grouping converter for the group description that is added to group the freight column, follow the code example below:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:local="clr-namespace:GroupingUI"
             x:Class="GroupingUI.MainPage">

    <ContentPage.Resources>
        <ResourceDictionary>
            <local:GroupConverter x:Key="groupConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <syncfusion:SfDataGrid x:Name="dataGrid"
                            ItemsSource="{Binding OrderInfoCollection}">

        <syncfusion:SfDataGrid.GroupColumnDescriptions>
            <syncfusion:GroupColumnDescription ColumnName="Freight"
                                                Converter="{StaticResource groupConverter}" />
        </syncfusion:SfDataGrid.GroupColumnDescriptions>
    </syncfusion:SfDataGrid>
</ContentPage> 
{% endhighlight %}

{% highlight c# %}
dataGrid.GroupColumnDescriptions.Add (new GroupColumnDescription () {
    ColumnName = "Freight",
    Converter = new GroupConverter()
}); 
{% endhighlight %}
{% endtabs %}

The following code example illustrates the converter used for applying custom grouping logic.

{% tabs %}
{% highlight c# %}
public class GroupConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var orderInfo = value as OrderInfo;
        if (orderInfo.Freight > 0 && orderInfo.Freight <= 250)
            return "<=250";
        else if (orderInfo.Freight > 250 && orderInfo.Freight <= 500)
            return ">250 & <=500";
        else if (orderInfo.Freight > 500 && orderInfo.Freight <= 750)
            return ">500 & <=750";
        else
            return ">1000";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}
{% endhighlight %}
{% endtabs %}

### Using KeySelector

To achieve this, specify the custom logic in [GroupColumnDescription.KeySelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupColumnDescription.html#Syncfusion_Maui_DataGrid_GroupColumnDescription_KeySelector) property and column name in [GroupColumnDescription.ColumnName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupColumnDescription.html#Syncfusion_Maui_DataGrid_GroupColumnDescription_ColumnName) property.

In the below example, the Date column is grouped based on weeks.
{% tabs %}
{% highlight c# %}
//Apply the CustomGrouping for Date Column by using KeySelector.
dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
{
    ColumnName = "Date",
    KeySelector = (string ColumnName, object o) =>
        {
            var dt = DateTime.Now;
            var item = (o as SalesByDate).Date;
            var days = (int)Math.Floor((dt - item).TotalDays);
            var dayOfWeek = (int)dt.DayOfWeek;
            var difference = days - dayOfWeek;
            if (days <= dayOfWeek)
            {
                if (days == 0)
                    return "TODAY";
                if (days == 1)
                    return "YESTERDAY";
                return item.Date.DayOfWeek.ToString().ToUpper();
            }
            if (difference > 0 && difference <= 7)
                return "LAST WEEK";
            if (difference > 7 && difference <= 14)
                return "TWO WEEKS AGO";
            if (difference > 14 && difference <= 21)
                return "THREE WEEKS AGO";
            if (dt.Year == item.Date.Year && dt.Month == item.Date.Month)
                return "EARLIER THIS MONTH";
            if (DateTime.Now.AddMonths(-1).Month == item.Date.Month)
                return "LAST MONTH";
            return "OLDER";
        }

});
{% endhighlight %}
{% endtabs %}

### Sorting the records in the grouped columns

In custom grouping, you can sort all the inner records of each group by setting [GroupColumnDescription.SortGroupRecords](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupColumnDescription.html#Syncfusion_Maui_DataGrid_GroupColumnDescription_SortGroupRecords) property as `true`. This will sort the records based on the `GroupColumnDescription.ColumnName` property.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:local="clr-namespace:GroupingUI"
             x:Class="GroupingUI.MainPage">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:GroupOrderNoConverter x:Key="groupOrderNoConverter" />
            <local:PriceConverter x:Key="priceConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <syncfusion:SfDataGrid x:Name="dataGrid"
                            ItemsSource="{Binding OrderInfoCollection}">
        <syncfusion:SfDataGrid.GroupColumnDescriptions>
            <syncfusion:GroupColumnDescription ColumnName="OrderID"
                                                Converter="{StaticResource groupOrderNoConverter}"
                                                SortGroupRecords="false" />
            <syncfusion:GroupColumnDescription ColumnName="Price"
                                                Converter="{StaticResource priceConverter}"
                                                SortGroupRecords="True" />
        </syncfusion:SfDataGrid.GroupColumnDescriptions>
    </syncfusion:SfDataGrid>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
{
    ColumnName = "OrderID",
    Converter = new GroupOrderNoConverter(),
    SortGroupRecords = false
});
dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
{
    ColumnName = "Price",
    Converter = new PriceConverter(),
    SortGroupRecords = true
});  
			
public class GroupOrderNoConvertor : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
		var orderInfo = value as OrderInfo;
        if (orderInfo.OrderID < 10)
            return "<10";
        if (orderInfo.OrderID >= 10 && orderInfo.OrderID < 15)
            return "Between 10 To 15";
        if (orderInfo.OrderID >= 15 && orderInfo.OrderID <= 20)
            return "Between 15 To 20";
        else
            return ">20";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}

public class PriceConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var orderInfo = value as OrderInfo;
        if (orderInfo.Price < 10)
            return "<10";
        if (orderInfo.Price >= 10 && orderInfo.Price < 16)
            return "Between 10 To 15";
        if (orderInfo.Price >= 15 && orderInfo.Price <= 20)
            return "Between 15 To 20";
        return ">20";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}

{% endhighlight %}
{% endtabs %}

As you can see in the below screenshot, the records are sorted based on the `OrderNo` column, since `SortGroupRecords` is set as `true` and it is not sorted further based on `Price` column since `SortGroupRecords` is set as `false`.

![SfDataGrid with SortGroupRecords](Images\Grouping\maui-datagrid-sort-mode.png)

## Display based grouping using GroupMode property

By default, column grouping occurs based on the value in the underlying collection thereby creating a new group for each new value of that column. However, a column can also be grouped based on the Display value by setting the [DataGridColumn.GroupMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_GroupMode) property as `Display`. In the following code example, set the [DataGridColumn.Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Format) property as "#" which displays only the rounded off value in the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html): 

{% tabs %}
{% highlight xaml %}
<syncfusion:DataGridTextColumn HeaderText="Order ID"
                               MappingName="OrderID"
                               GroupMode="Display"
                               Format="#" />
{% endhighlight %}

{% highlight c# %}
DataGridTextColumn orderID = new DataGridTextColumn();
orderID.MappingName = "OrderID";
orderID.GroupMode = Syncfusion.Maui.Data.DataReflectionMode.Display;
orderID.Format = "#";
{% endhighlight%} 
{% endtabs %}

The following screenshot shows a comparison between two group modes. `GroupMode.Value` on the Top and `GroupMode.Display` on the Bottom:
![DataGrid with group mode](Images\Grouping\maui-datagrid-mode-value.png)
![DataGrid with group mode](Images\Grouping\maui-datagrid-mode-display.png)

## Expand and Collapse Groups

To expand and collapse the groups at runtime, you can simply set the [SfDataGrid.AllowGroupExpandCollapse](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowGroupExpandCollapseProperty) property to `true`. The groups will be in expanded state by default.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AllowGroupExpandCollapse="True"
                        ItemsSource="{Binding OrderInfoCollection}" />
                       
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AllowGroupExpandCollapse = true;
{% endhighlight %}
{% endtabs %}

### Expand groups initially

To expand all groups initially, set the [SfDataGrid.AutoExpandGroups](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoExpandGroupsProperty) to `true`. While grouping any column, all groups will be in expanded state.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoExpandGroups="True"
                        AllowGroupExpandCollapse="True"
                        ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AutoExpandGroups = true;
this.dataGrid.AllowGroupExpandCollapse = true;
{% endhighlight %}
{% endtabs %}

### Expand or collapse all the groups

To expand and collapse the groups programmatically, you can simply invoke the [SfDataGrid.ExpandAllGroups](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpandAllGroups) and [SfDataGrid.CollapseAllGroups](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CollapseAllGroups) methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllGroups();
this.dataGrid.CollapseAllGroups();
{% endhighlight %}
{% endtabs %}

### Expand or collapse a specific group

To expand and collapse specific groups programmatically, you can simply invoke the [SfDataGrid.ExpandGroup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpandGroup_Syncfusion_Maui_Data_Group_) and [SfDataGrid.CollapseGroup]() methods.

{% tabs %}
{% highlight c# %}
var group = (dataGrid.View.Groups[0] as Group);

this.dataGrid.ExpandGroup(group);
this.dataGrid.CollapseGroup(group);
{% endhighlight %}
{% endtabs %}

![DataGrid with group expanding and collapsing](Images\Grouping\maui-datagrid-expand-specific-group.png)

## Events

### GroupExpanding

The GroupExpanding event occurs when a group is being expanded.
 
The [DataGridColumnGroupChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnGroupChangingEventArgs.html) of the `GroupExpanding` event provides information about the expanding group and has the following members:

 `Syncfusion.Data.Group`: Gets the expanded group.

 `Cancel`: Determines whether to cancel group expansion.
 
Cancel the group expansion by setting [DataGridColumnGroupChangingEventArgs.Cancel](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.canceleventargs.cancel?view=net-6.0) to `true`.

{% tabs %}
{% highlight c# %}
this.dataGrid.GroupExpanding += dataGrid_GroupExpanding;

void dataGrid_GroupExpanding(object sender, EventArgs e)
{
    if (e.Group.Key.Equals(1001))    
        e.Cancel = true;    
}       
{% endhighlight %}
{% endtabs %}

### GroupExpanded event

The [SfDataGrid.GroupExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupExpanded) event occurs after a group is expanded.

The [DataGridColumnGroupChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnGroupChangedEventArgs.html) of the `GroupExpanded` event provides information about the expanded group and it has the following member:

 `Syncfusion.Data.Group`: Retrieves the expanded group.

### GroupCollapsing event 

The [SfDataGrid.GroupCollapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupCollapsing) event occurs when group is being collapsed.

The `DataGridColumnGroupChangingEventArgs` of the `GroupCollapsing` event provides the information about the collapsing group and it contains the following member:

 `Syncfusion.Data.Group`: Gets the collapsed group.

 `Cancel`: Determines whether to cancel group collapsing.

Cancel the group is being collapsed by setting the `DataGridColumnGroupChangingEventArgs.Cancel` to `true`.

{% tabs %}
{% highlight c# %}
this.dataGrid.GroupCollapsing += dataGrid_GroupCollapsing;

void dataGrid_GroupCollapsing(object sender, EventArgs e)
{
    if (e.Group.Key.Equals(1001))    
        e.Cancel = true;    
}
{% endhighlight %}
{% endtabs %}

### GroupCollapsed event
 
The [SfDataGrid.GroupCollapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupCollapsed) event occurs after group collapsed.
 
The `DataGridColumnGroupChangedEventArgs` of the `GroupCollapsed` event provides the information about collapsed group and it contains the following member:

 `Syncfusion.Data.Group`: Gets the collapsed group.

## Customization

### Customize indent column width

The width of indent column can be customized by the [IndentColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IndentColumnWidthProperty) property. The default width of the indent column is 35.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        ItemsSource="{Binding OrderInfoCollection}"
                        IndentColumnWidth="60" />
{% endhighlight %}

{% highlight c# %}

this.dataGrid.IndentColumnWidth = 60;

{% endhighlight %}
{% endtabs %}

#### Customize indent column background color

The indent columns can be customized by writing the implicit style for the [DataGridIndentCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridIndentCell.html). 

The following code snippet shows how to apply a background color to the indent cell based on the column index:

{% tabs %}
{% highlight xaml %}
<ContentPage.Resources>
    <ResourceDictionary>
        <local:CellStyleConverter x:Key="cellStyleConverter" />
        <Style  TargetType="syncfusion:DataGridIndentCell">
            <Setter Property="Background"
                    Value="{Binding Source={RelativeSource Mode=Self}, 
                    Converter={StaticResource 
                    Key=cellStyleConverter}}" />
        </Style>
    </ResourceDictionary>
</ContentPage.Resources>
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        ItemsSource="{Binding Orders}">
    <syncfusion:SfDataGrid.GroupColumnDescriptions>
        <syncfusion:GroupColumnDescription ColumnName="Name" />
        <syncfusion:GroupColumnDescription ColumnName="ShipCity" />
    </syncfusion:SfDataGrid.GroupColumnDescriptions>
</syncfusion:SfDataGrid>   
{% endhighlight %}

{% highlight c# %}
public class CellStyleConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
    {
        var rowType = ((value as DataGridIndentCell)?.Parent as DataGridRow)?.DataRow?.RowType.ToString();
        if (rowType == "HeaderRow")
            return Colors.Bisque;
        else if (rowType == "CaptionCoveredRow")
            return Colors.LightBlue;
        else
            return Colors.PaleVioletRed;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}
{% endhighlight %}
{% endtabs %}

![SfDataGrid with IndentColumnBackgroundColor](Images\Grouping\maui-datagrid-indent-column-background-color.png)

### Customize grouped column visibility

The visibility of the grouped column can be customized by the [SfDataGrid.ShowColumnWhenGrouped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowColumnWhenGrouped) property. By default, all the grouped columns are visible. Refer to the following code snippet:

{% tabs %}

{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoGenerateColumns="True"
                        ItemsSource="{Binding OrderInfoCollection}"
                        ShowColumnWhenGrouped="False" />
{% endhighlight %}
{% highlight c# %}
this.dataGrid.ShowColumnWhenGrouped = false;
{% endhighlight %}
{% endtabs %}

### Customize group icon

#### Load group icon through template

The SfDataGrid uses an icon to indicate the expand and collapse state of groups. You can personalize the group icon by using the [SfDataGrid.GroupExpandCollapseTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupExpandCollapseTemplate) property. This property allows you to define a custom template that will be displayed in its normal form when the group is expanded, and it will rotate downwards when the group is collapsed. To implement this, refer to the following code snippet:

{% tabs %}

{% highlight xaml %}
<syncfusion:SfDataGrid VerticalOptions="FillAndExpand"
                       HorizontalOptions="FillAndExpand"
                       ItemsSource="{Binding OrderInfoCollection}"
                       x:Name="dataGrid"
                       GroupingMode="Multiple"
                       AllowGroupExpandCollapse="True"
                       AutoGenerateColumnsMode="None">
        <syncfusion:SfDataGrid.GroupExpandCollapseTemplate>
            <DataTemplate>
                <Image Source="downward_icon.png"/>
            </DataTemplate>
        </syncfusion:SfDataGrid.GroupExpandCollapseTemplate>
        
        <syncfusion:SfDataGrid.GroupColumnDescriptions>
            <syncfusion:GroupColumnDescription ColumnName="Name" />
            <syncfusion:GroupColumnDescription ColumnName="ShipCity" />
        </syncfusion:SfDataGrid.GroupColumnDescriptions>
</syncfusion:SfDataGrid>                           
{% endhighlight %}

{% highlight c# %}
this.dataGrid.GroupingMode = GroupingMode.Multiple;
this.dataGrid.AllowGroupExpandCollapse = true;
dataGrid.GroupExpandCollapseTemplate = new DataTemplate(() =>
        {
            var imageView1 = new Image()
            {
                Source = "downward_icon.png",
                Aspect = Aspect.AspectFit,
            };
            return imageView1;
        });
{% endhighlight %}
{% endtabs %}

![DataGrid with template](Images\Grouping\maui-datagrid-template.gif)

#### Load group icon through template selector

When choosing a `GroupExpandCollapseTemplate` as a DataTemplateSelector, you have the option to supply distinct templates for both the expanded and collapsed states of the group

{% tabs %}

{% highlight xaml %}
<syncfusion:SfDataGrid VerticalOptions="FillAndExpand"  
                            HorizontalOptions="FillAndExpand"
                            ItemsSource="{Binding OrderInfoCollection}"
                            x:Name="dataGrid"
                            GroupingMode="Multiple"
                            AllowGroupExpandCollapse="True"
                            AutoGenerateColumnsMode="None">
        <syncfusion:SfDataGrid.GroupExpandCollapseTemplate>
            <local:ExpandCollapseTemplate ExpandTemplate="{StaticResource ExpandIcon }"
                                            CollapseTemplate="{StaticResource CollapseIcon}" />
        </syncfusion:SfDataGrid.GroupExpandCollapseTemplate>
        
        <syncfusion:SfDataGrid.GroupColumnDescriptions>
            <syncfusion:GroupColumnDescription ColumnName="Name" />
            <syncfusion:GroupColumnDescription ColumnName="ShipCity" />
        </syncfusion:SfDataGrid.GroupColumnDescriptions>
</syncfusion:SfDataGrid>                           
{% endhighlight %}

{% highlight c# %}
public class ExpandCollapseTemplate : DataTemplateSelector
{
    public DataTemplate ExpandTemplate { get; set; }

    public DataTemplate CollapseTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var isExpanded = (item as Group).IsExpanded;
        if (isExpanded)
        {
            return ExpandTemplate;
        }
        else
        {
            return CollapseTemplate;
        }
    }
}
{% endhighlight %}
{% endtabs %}

![DataGrid with template selector](Images\Grouping\maui-datagrid-template-selector.gif)

N>
* When using data template selector, performance issues occur as the conversion template views take time within the framework.

#### Customize the size of group icon

The size of the group icon can be customized when the icon is loaded through `GroupExpandCollapseTemplate` by setting the `HeightRequest` and `WidthRequest`. To implement this, please refer the following code snippet:

{% tabs %}

{% highlight xaml %}
<syncfusion:SfDataGrid VerticalOptions="FillAndExpand"
                            HorizontalOptions="FillAndExpand"
                            ItemsSource="{Binding OrderInfoCollection}"
                            x:Name="dataGrid"
                            GroupingMode="Multiple"
                            AllowGroupExpandCollapse="True"
                            AutoGenerateColumnsMode="None">
        <syncfusion:SfDataGrid.GroupExpandCollapseTemplate>
            <DataTemplate>
                <Image Source="downward_icon.png" HeightRequest="20" WidthRequest="20"/>
            </DataTemplate>
        </syncfusion:SfDataGrid.GroupExpandCollapseTemplate>
        
        <syncfusion:SfDataGrid.GroupColumnDescriptions>
            <syncfusion:GroupColumnDescription ColumnName="ShipCountry" />
            <syncfusion:GroupColumnDescription ColumnName="CustomerID" />
        </syncfusion:SfDataGrid.GroupColumnDescriptions>
</syncfusion:SfDataGrid>                           
{% endhighlight %}

{% highlight c# %}
this.dataGrid.GroupingMode = GroupingMode.Multiple;
this.dataGrid.AllowGroupExpandCollapse = true;
dataGrid.GroupExpandCollapseTemplate = new DataTemplate(() =>
        {
            var imageView1 = new Image()
            {
                Source = "downward_icon.png",
                Aspect = Aspect.AspectFit,
                HeightRequest = 20,
                WidthRequest = 20,
            };
            return imageView1;
        });
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with group icon size" src="Images\grouping\maui-datagrid-group-icon-size.png" width="404">
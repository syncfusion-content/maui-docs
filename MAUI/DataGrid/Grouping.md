# Grouping in MAUI DataGrid (SfDataGrid)

Grouping in a datagrid refers to the process of organizing and categorizing data based on specific criteria or field values. It allows you to group related records together, creating a hierarchical structure within the datagrid. Each group is identified by its [CaptionSummaryRow]() to get the underlying records in view.

N> To update the grouping for the newly added row or column, set the `SfDataGrid.View.LiveDataUpdateMode` to `LiveDataUpdateMode.AllowDataShaping`.

N> When `BeginInit` method is called, it suspends all the updates until `EndInit` method is called.  

## Programmatic grouping

The SfDataGrid allows to perform grouping programmatically by adding the [GroupColumnDescription]() object in the [SfDataGrid.GroupColumnDescriptions]() collection. It groups the data based on the `GroupColumnDescription` object added to this collection.

`GroupColumnDescription` object holds following two properties:

 * ColumnName: The name of the grouped column.
 * Converter: It accepts an `IValueConverter` as input that helps to apply custom grouping.

To apply column grouping, please refer to the following code example:

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrdersInfo}">
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

## MultiGrouping

The SfDataGrid also allows to group the data against one or more columns using the [SfDataGrid.GroupingMode]() property. When the `GroupingMode` is set as `GroupingMode.Multiple`, the data is organized into a hierarchical tree structure based on identical values of that column. The multi-grouping feature works similarly to the multi-sorting feature. Initially, the data is grouped according to the first column added in the `GroupColumnDescriptions` collection. When more columns are added to the `GroupColumnDescriptions`, the newly added column will be grouped in consideration of the previous group(s). This results in a tree-like hierarchy. Refer to the following code snippet to enable `MultiGrouping`:

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid  x:Name="dataGrid"
                            ItemsSource="{Binding Orders}"
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

## Indent column customization

Indent columns are the columns present to the left of the `CaptionSummaryRows` when `GroupingMode` is set as multiple. The number of indent cells in each `CaptionSummaryRow` will be determined by the level of that `Group`. For example, the first group will have only one indent cell and the next immediate group will have an extra indent cell. It keeps on adding by one for each lower level groups to maintain the tree structure. Each data row will have indent cells count equal to the level of the last sub group in view. The following customizations can be done for indent cells:

The width of indent column can be customized by the [IndentColumnWidth]() property. The default width of the indent column is 35. 

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid  x:Name="dataGrid"
                            AutoGenerateColumns="True"
                            ItemsSource="{Binding Orders}"
                            IndentColumnWidth="60" />
{% endhighlight %}

{% highlight c# %}

this.dataGrid.IndentColumnWidth = 60;

{% endhighlight %}
{% endtabs %}

## Custom grouping

The SfDataGrid allows to group a column based on custom logic when the standard grouping techniques do not meet the requirements.

### Using IValueConverter

To achieve this, you need to write a converter that implements `IValueConverter` with custom grouping logic and assign that converter to the [GroupColumnDescription.Converter]() property.

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
                               ItemsSource="{Binding OrdersInfo}">

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

### Using KeySelector

To achieve this, specify the custom logic in [GroupColumnDescription.KeySelector]() property and column name in [GroupColumnDescription.ColumnName]() property.

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
In custom grouping, you can sort all the inner records of each group by setting [GroupColumnDescription.SortGroupRecords]() property as `true`. This will sort the records based on the `GroupColumnDescription.ColumnName` property.

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
                <local:PriceConverter x:key="priceConverter" />
            </ResourceDictionary>
        </ContentPage.Resources>

        <ContentPage.BindingContext>
            <local:ViewModel x:Name="viewModel" />
        </ContentPage.BindingContext>

        <syncfusion:SfDataGrid x:Name="dataGrid"
                               ItemsSource="{Binding OrdersInfo}">
            <Syncfusion:SfDataGrid.GroupColumnDescriptions>
                <Syncfusion:GroupColumnDescription ColumnName="OrderID"
                                                   Converter="{StaticResource groupOrderNoConverter}"
                                                   SortGroupRecords="false" />
                <Syncfusion:GroupColumnDescription ColumnName="Price"
                                                   Converter="{StaticResource priceConverter}"
                                                   SortGroupRecords="True" />
            </Syncfusion:SfDataGrid.GroupColumnDescriptions>
        </syncfusion:SfDataGrid>
    </ContentPage>

{% endhighlight %}
{% highlight c# %}

datagrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
{
    ColumnName = "OrderID",
    Converter = new GroupOrderNoConverter(),
    SortGroupRecords = false
});
datagrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
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

## Expand groups initially

To expand all groups initially, set the [SfDataGrid.AutoExpandGroups]() to `true`. While grouping any column, all groups will be in expanded state.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid  x:Name="dataGrid"
                            AutoExpandGroups="True"
                            AllowGroupExpandCollapse="True"
                            ItemsSource="{Binding Orders}" />
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AutoExpandGroups = true;
this.dataGrid.AllowGroupExpandCollapse = true;
{% endhighlight %}
{% endtabs %}

## Expand or collapse the groups

To expand and collapse the groups at runtime, you can simply set the [SfDataGrid.AllowGroupExpandCollapse]() property to `true`. The groups will be in expanded state by default.

{% tabs %}
{% highlight xaml %}

    <syncfusion:SfDataGrid  x:Name="dataGrid"
                            AllowGroupExpandCollapse="True"
                            ItemsSource="{Binding Orders}" />
                       
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AllowGroupExpandCollapse = true;
{% endhighlight %}
{% endtabs %}

### Expand or collapse all the groups

To expand and collapse the groups programmatically, you can simply invoke the [SfDataGrid.ExpandAllGroup]() and [SfDataGrid.CollapseAllGroup]() methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllGroup();
this.dataGrid.CollapseAllGroup();
{% endhighlight %}
{% endtabs %}

### Expand or collapse a specific group

To expand and collapse specfic groups programmatically, you can simply invoke the [SfDataGrid.ExpandGroup]() and [SfDataGrid.CollapseGroup]() methods.

{% tabs %}
{% highlight c# %}
var group = (dataGrid.View.Groups[0] as Group);
this.dataGrid.ExpandGroup(group);
this.dataGrid.CollapseGroup(group);
{% endhighlight %}
{% endtabs %}

![DataGrid with group expanding and collapsing](Images\Grouping\maui-datagrid-expand-specific-group.png)

## Display based grouping using GroupMode property

By default, column grouping occurs based on the value in the underlying collection thereby creating a new group for each new value of that column. However, a column can also be grouped based on the Display value by setting the [GridColumn.GroupMode]() property as `Display`. In the following code example, set the [GridColumn.Format](t) property as "#" which displays only the rounded off value in the [GridCell](): 

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

The following screenshot shows a comparison between two group modes. GroupMode.Value on the Top and GroupMode.Display on the Bottom:
![DataGrid with group mode](Images\Grouping\maui-datagrid-mode-value.png)
![DataGrid with group mode](Images\Grouping\maui-datagrid-mode-display.png)

## Clearing or removing a group

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

## Events

### GroupExpanding

The GroupExpanding event occurs when a group is being expanded.
 
The [GroupChangingEventArgs]() of the `GroupExpanding` event provides information about the expanding group and has the following members:

 `Syncfusion.Data.Group`: Gets the expanded group.

 `Cancel`: Determines whether to cancel group expansion.
 
Cancel the group expansion by setting [GroupChangingEventArgs.Cancel]() to `true`.

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

The [SfDataGrid.GroupExpanded]() event occurs after a group is expanded.

The [GroupChangedEventArgs]() of the `GroupExpanded` event provides information about the expanded group and it has the following member:

 `Syncfusion.Data.Group`: Retrieves the expanded group.

### GroupCollapsing event 

The [SfDataGrid.GroupCollapsing]() event occurs when group is being collapsed.

The [GroupChangingEventArgs]()  of the `GroupCollapsing` event provides the information about the collapsing group and it contains the following member:

 `Syncfusion.Data.Group`: Gets the collapsed group.

 `Cancel`: Determines whether to cancel group collapsing.

Cancel the group is being collapsed by setting the [GroupChangingEventArgs.Cancel]() to `true`.

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
 
The [SfDataGrid.GroupCollapsed]() event occurs after group collapsed.
 
The [GroupChangedEventArgs]() of the `GroupCollapsed` event provides the information about collapsed group and it contains the following member:

 `Syncfusion.Data.Group`: Gets the collapsed group.

## Customize grouped column visibility

The visibility of the grouped column can be customized by the [SfDataGrid.ShowColumnWhenGrouped]() property. By default, all the grouped columns are visible. Refer to the following code snippet:

{% tabs %}

{% highlight xaml %}
    <syncfusion:SfDataGrid  x:Name="dataGrid"
                            AutoGenerateColumns="True"
                            ItemsSource="{Binding Orders}"
                            ShowColumnWhenGrouped="False" />
{% endhighlight %}

{% highlight c# %}

this.dataGrid.ShowColumnWhenGrouped = false;

{% endhighlight %}
{% endtabs %}
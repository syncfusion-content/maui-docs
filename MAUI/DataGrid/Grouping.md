# Grouping in MAUI DataGrid (SfDataGrid)

A group represents a collection of records that belongs to a particular category. When grouping, the data is organized into hierarchical structure based on matching field values. The records having identical values in the grouped column are combined to form a group. Each group is identified by its [CaptionSummaryRow]() to get the underlying records in view.

To get started quickly with grouping in Maui DataGrid, you can check out this video:

N> To update grouping for the newly added row or column, set the `SfDataGrid.View.LiveDataUpdateMode` to `LiveDataUpdateMode.AllowDataShaping`.

N> When `BeginInit` method is called, it suspends all the updates until `EndInit` method is called.  

## Programmatic grouping

The SfDataGrid also allows to perform grouping from the code by defining the [GroupColumnDescription]() object and adding it in the [SfDataGrid.GroupColumnDescriptions]() collection. It groups the data based on the `GroupColumnDescription` object added to this collection.

`GroupColumnDescription` object holds following two properties:

 * ColumnName: Name of the grouped column.
 * Converter: Get the `IValueConverter` as input that helps to apply the custom grouping.

To apply column grouping, follow the code example:

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

The following screenshot shows the output rendered when grouping is applied:

![DataGrid with grouping](Images\Grouping\SingleGrouping.png)

## MultiGrouping

The SfDataGrid also allows to group the data against one or more columns using the [SfDataGrid.GroupingMode]() property. When `GroupingMode` is set as `GroupingMode.Multiple`, the data is organized into hierarchical tree structure based on identical values of that column. MultiGrouping feature works similarly as MultiSorting feature. Initially the data is grouped according to the first column added in the `GroupColumnDescriptions` collection. When more columns are added to the `GroupColumnDescriptions`, the newly added column will be grouped in consideration to the previous group(s). This results in a tree like hierarchy. Refer to the following code snippet to enable `MultiGrouping`:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        GroupingMode = "Multiple"/>
{% endhighlight %}

{% highlight c# %}

this.dataGrid.GroupingMode = GroupingMode.Multiple;

{% endhighlight %}
{% endtabs %}

The following screenshot shows the output rendered when above code is executed:
![DataGrid with multi-column grouping](Images\Grouping\MultipleGrouping.png)

## Indent column customizations

Indent columns are the columns present to the left of the `CaptionSummaryRows` when `GroupingMode` is set as multiple. The number of indent cells in each `CaptionSummaryRow` will be determined by the level of that `Group`. For example, the first group will have only one indent cell and the next immediate group will have an extra indent cell. It keeps on adding by one for each lower level groups to maintain the tree structure. Each data row will have indent cells count equal to the level of the last sub group in view. The following customizations can be done for indent cells:

### Customize indent column width

By default, the width of the indent column is 20. To customize the width of indent column, use the [IndentColumnWidth]() property as follows: 

{% tabs %}

{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoGenerateColumns="True"
                        ItemsSource="{Binding Orders}"
                        IndentColumnWidth="60"/>
{% endhighlight %}

{% highlight c# %}

this.dataGrid.IndentColumnWidth = 60;

{% endhighlight %}
{% endtabs %}

## Custom grouping

The SfDataGrid allows to group a column based on custom logic when the standard grouping techniques do not meet the requirements.

### Using IValueConverter

To achieve this, write a converter that implements `IValueConverter` with custom grouping logic. Assign that converter to the [GroupColumnDescription.Converter]() property.

To set custom grouping converter for the group description that is added to group the freight column, follow the code example:

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
    public GroupConverter()
    {
        
    }

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


### Sorting the grouped column records
In custom grouping, you can sort all the inner records of each group by setting [GroupColumnDescription.SortGroupRecords]() property as `true` to sort the records based on the `GroupColumnDescription.ColumnName` property.

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
            <local:PriceConverter x:key="priceConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrdersInfo}">
        <Syncfusion:SfDataGrid.GroupColumnDescriptions>
            <Syncfusion:GroupColumnDescription ColumnName="OrderID" Converter="{StaticResource groupOrderNoConverter}" SortGroupRecords="false" />
            <Syncfusion:GroupColumnDescription ColumnName="Price" Converter="{StaticResource priceConverter}" SortGroupRecords="True"/>
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
}) ;
datagrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
{
    ColumnName = "Price",
    Converter = new PriceConverter(),
    SortGroupRecords = true
}) ;  
			
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

![SfDataGrid with SortGroupRecords](Images\Grouping\SortMode.png)

## Expand groups while grouping
 
To expand all groups while grouping, set the [SfDataGrid.AutoExpandGroups]() to `true`. While grouping any column, all groups will be in expanded state. 

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoExpandGroups="True"
                        AllowGroupExpandCollapse="True"
                        ItemsSource="{Binding Orders}"/>
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AutoExpandGroups = true;
this.dataGrid.AllowGroupExpandCollapse = true;
{% endhighlight %}
{% endtabs %}

## Expand or collapse the groups

By default, the groups will be in expanded state. However expand or collapse a group in runtime by setting the [SfDataGrid.AllowGroupExpandCollapse]() to `true`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AllowGroupExpandCollapse="True"
                        ItemsSource="{Binding Orders}"/>
                       
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AllowGroupExpandCollapse = true;
{% endhighlight %}
{% endtabs %}

### Expand or collapse all the groups

Programmatically expand or collapse all the groups at runtime using the [SfDataGrid.ExpandAllGroup]() and [SfDataGrid.CollapseAllGroup]() methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.ExpandAllGroup();
this.dataGrid.CollapseAllGroup();
{% endhighlight %}
{% endtabs %}

### Expand or collapse a specific group

Expand or collapse specific group by using the [SfDataGrid.ExpandGroup]() and [SfDataGrid.CollapseGroup]() methods.


{% tabs %}
{% highlight c# %}
var group = (dataGrid.View.Groups[0] as Group);
this.dataGrid.ExpandGroup(group);
this.dataGrid.CollapseGroup(group);
{% endhighlight %}
{% endtabs %}

![DataGrid with group expanding and collapsing](Images\Grouping\Expand_Specific_Group.png)

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

Following screenshot shows the comparison between two Group modes. GroupMode.Value on the Top and GroupMode.Display on the Bottom:
![DataGrid with group mode](Images\Grouping\Mode_Value.png)
![DataGrid with group mode](Images\Grouping\Mode_Display.png)

## Clearing or removing a group

To clear applied grouping, remove the items from the `SfDataGrid.GroupColumnDescriptions` collection or clear the collection. 

Refer to the following code snippets to remove grouping:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
            xmlns:local="clr-namespace:GroupingUI"
            x:Class="GroupingUI.MainPage">            

    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    
    <StackLayout VerticalOptions="FillAndExpand">
    
        <Button Text="Remove Grouping"
             TextColor="Black"
             BackgroundColor="White"
             Clicked="ClearGroupingButton_Click"/>

        <sfgrid:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrdersInfo}"
                           >
            <syncfusion:SfDataGrid.GroupColumnDescriptions>
                <syncfusion:GroupColumnDescription ColumnName="OrderID" />
            </syncfusion:SfDataGrid.GroupColumnDescriptions>
            <syncfusion:SfDataGrid.GroupColumnDescriptions>
                <syncfusion:GroupColumnDescription ColumnName="ShipCity" />
            </syncfusion:SfDataGrid.GroupColumnDescriptions>           
        </sfgrid:SfDataGrid>
    
    </StackLayout>

</ContentPage>
{% endhighlight%} 
{% highlight c# %}
public partial class MainPage : ContentPage
{
    StackLayout stackLayout;
    SfDataGrid dataGrid;
    ViewModel viewModel;
    Button clearGroupingButton;
    public MainPage()
    {
        InitializeComponent();
        viewModel = new ViewModel();
        dataGrid = new SfDataGrid();
        clearGroupingButton = new Button();
        stackLayout = new StackLayout();
        dataGrid.ItemsSource = viewModel.OrdersInfo;
        dataGrid.GroupingMode = GroupingMode.Multiple;
        dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
        {
            ColumnName = "OrderID",
        });
        dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
        {
            ColumnName = "ShipCity",
        });
        clearGroupingButton.Text = "Remove Grouping";
        clearGroupingButton.TextColor = Colors.Black;
        clearGroupingButton.BackgroundColor = Colors.White;
        clearGroupingButton.Clicked += ClearGroupingButton_Click;
        stackLayout.Children.Add(clearGroupingButton);
        stackLayout.Children.Add(dataGrid);
        this.Content = stackLayout;       
    }
}
{% endhighlight%} 
{% endtabs %}

{% highlight c# %}
private void ClearGroupingButton_Click(object sender, System.EventArgs e)
{
    //Clearing the Group
    //dataGrid.GroupColumnDescriptions.Clear();

    //Removing the Group based on group item
    var groupColumn = dataGrid.GroupColumnDescriptions[1];
    dataGrid.GroupColumnDescriptions.Remove(groupColumn);
        
    //Removing the Group based on group index
    //dataGrid.GroupColumnDescriptions.RemoveAt(0);
}
{% endhighlight%} 

Run the application to render the following output: 

![Remove groups in runtime in a DataGrid](Images\Grouping\Before_RemovingGroup.png)
![Remove groups in runtime in a DataGrid](Images\Grouping\After_RemovingGrouping.png)

N> Clear or remove grouping on [GridTapped event](), [GridDoubleTapped event](), or [GridLongPressed event]().

## Events

### GroupExpanding event

The [SfDataGrid.GroupExpanding]() event occurs when group is being expanded.
 
The [GroupChangingEventArgs]() of the `GroupExpanding` event provides the information about the expanding group and it has the following members:

 `Syncfusion.Data.Group`: Gets expanded group.

 `Cancel`: Decides to cancel group expansion.
 
Cancel group expansion by setting [GroupChangingEventArgs.Cancel]() to `true`.

{% tabs %}
{% highlight c# %}
this.dataGrid.GroupExpanding += dataGrid_GroupExpanding;

void dataGrid_GroupExpanding(object sender, Syncfusion.SfDataGrid.XForms.GroupChangingEventArgs e)
{
    if (e.Group.Key.Equals(1001))    
        e.Cancel = true;    
}       
{% endhighlight %}
{% endtabs %}

### GroupExpanded event

The [SfDataGrid.GroupExpanded]() event occurs after group is expanded.

The [GroupChangedEventArgs]() of the `GroupExpanded` event provides the information about the expanded group and it has the following member:

 `Syncfusion.Data.Group`: Gets the expanded group.

### GroupCollapsing event 

The [SfDataGrid.GroupCollapsing]() event occurs when group is being collapsed.

The [GroupChangingEventArgs]()  of the `GroupCollapsing` event provides the information about the collapsing group and it contains the following member:

 `Syncfusion.Data.Group`: Gets collapsed group.

 `Cancel`: Decides to cancel the group collapsing.

Cancel the group is being collapsed by using the [GroupChangingEventArgs.Cancel]() of `GroupCollapsing` event.

{% tabs %}
{% highlight c# %}
this.dataGrid.GroupCollapsing += dataGrid_GroupCollapsing;

void dataGrid_GroupCollapsing(object sender, Syncfusion.SfDataGrid.XForms.GroupChangingEventArgs e)
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

## How to hide the grouped column in SfDataGrid

To hide/show a particular column gets grouped, set the [SfDataGrid.ShowColumnWhenGrouped]() property to `false`/`true`. Any column(s) added in the `GroupColumnDescriptions` collection will be shown or hidden based on the value of the [SfDataGrid.ShowColumnWhenGrouped]() property. Refer to the following code snippet:

{% tabs %}

{% highlight xaml %}
<syncfusion:SfDataGrid  x:Name="dataGrid"
                        AutoGenerateColumns="True"
                        ItemsSource="{Binding Orders}"
                        ShowColumnWhenGrouped="False"/>
{% endhighlight %}

{% highlight c# %}

this.dataGrid.ShowColumnWhenGrouped = false;

{% endhighlight %}
{% endtabs %}

N> You can refer to our [Xamarin DataGrid]() feature tour page for its groundbreaking feature representations. You can also explore our [Xamarin.Forms DataGrid example]() to knows various chart types and how to easily configured with built-in support for creating stunning visual effects.
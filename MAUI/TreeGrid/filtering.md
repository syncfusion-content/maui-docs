---
layout: post
title: Filtering in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to filter data in Syncfusion® .NET MAUI Tree Grid, including built-in filtering options, custom filters, and filter customization.
platform: MAUI
control: STreeGrid
documentation: UG
keywords : maui tree grid, maui treegrid, maui grid, grid maui, maui gridview, grid in maui, .net maui treegrid, .net maui grid, .net grid maui, .net maui filtering, maui filtering
---

# Filtering in .NET MAUI Tree Grid

Filtering is the process of retrieving values in a collection that satisfy specified conditions. The [SfTreeGrid]() provides programmatic filtering via predicates.

## Filter Level

You can filter the nodes based on level using the [SfTreeGrid.FilterLevel]() property.

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid ItemsSource = "{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       x:Name = "treeGrid"
                       FilterLevel = "All">
</syncfusion:SfTreeGrid>

{% endhighlight %}
{% highlight xaml %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeInfoViewModel;
treeGrid.ChildPropertyName = "Children";
treeGrid.FilterLevel = FilterLevel.All;
{% endhighlight %}
{% endtabs %}

**Root**

Filter will be applied to root nodes only in SfTreeGrid. For other nodes, `IsFiltered` value will be false, and they always will be displayed in view.

**All**

Filter will be applied to all the nodes in SfTreeGrid. If a parent node does not match the filter condition, filter will not be applied for child nodes. Else, filter will be applied to its child nodes also.

**Extended**

Filtering is applied based on the node hierarchy. Child nodes are included in filtering only when their parent node is expanded. If a node matches the filter condition, all of its ancestor nodes are displayed to preserve the hierarchy, even if those ancestor nodes do not match the filter condition. In such cases, the ancestor node's `IsFiltered` property is set to `false`.

> **Note:** You can change the `FilterLevel` at run time.

## Programmatic Filtering

Programmatic filtering allows you to apply custom filter predicates directly through code. This approach is useful when you need dynamic filtering logic or want to filter based on complex conditions not available in the UI.

### View Filtering

The `SfTreeGrid` supports filtering records by setting the [SfTreeGrid.View.Filter]() property to a filter predicate.

> **Note:** The View property is automatically initialized when ItemsSource is set on the TreeGrid. Ensure the TreeGrid has loaded and ItemsSource is assigned before accessing the View.

{% tabs %}
{% highlight c# %}
private void Button_Clicked(object sender, EventArgs e)
{
	treeGrid.View.Filter = FilterRecords;
	treeGrid.View.RefreshFilter();
}

/// <summary>
/// RefreshFilter() must be called after setting the Filter predicate to apply the filter.
/// </summary>
public bool FilterRecords(object record)
{
    EmployeeInfo? employeeInfo = record as EmployeeInfo;

    if (employeeInfo != null && employeeInfo.Department == "Sales")
    {
        return true;
    }
    return false;
}
{% endhighlight %}
{% endtabs %}
 
### Custom condition-based filtering

### Condition-Based Filtering

In addition to simple predicates, you can implement condition-based filtering where records are filtered based on user-defined logic. For example, records can be filtered to include specific values (Contains, Equals) or exclude values (Does Not Equal). Custom condition-based filtering can be applied to all columns or to individual columns.

Common filtering conditions include:

* Equals
* Does not equal
* Contains

To implement additional conditions beyond these, modify the code samples below based on your requirements.

{% tabs %}
{% highlight c# %}
public bool FilterRecords(object record)
{
    EmployeeInfo employeeInfo = record as EmployeeInfo;

    if (employeeInfo != null)
    {
        if (columns.SelectedItem.ToString() == "All Columns")
        {
            if (conditions.SelectedItem.ToString() == "Contains")
            {
                var vm = this.BindingContext as EmployeeInfoViewModel;
                var filterText = vm?.FilterText?.ToLower() ?? string.Empty;
                if (employeeInfo.EmpId.ToString().ToLower().Contains(filterText) ||
                    employeeInfo.FirstName.ToLower().Contains(filterText) ||
                    employeeInfo.LastName.ToLower().Contains(filterText) ||
                    employeeInfo.Title.ToLower().Contains(filterText) ||
                    employeeInfo.Salary.ToString().ToLower().Contains(filterText) ||
                    employeeInfo.Hike.ToString().ToLower().Contains(filterText))
                    return true;
                return false;
            }
            else if (conditions.SelectedItem.ToString() == "Equals")
            {
                if (CheckEquals(employeeInfo.EmpId.ToString()) ||
                    CheckEquals(employeeInfo.FirstName) ||
                    CheckEquals(employeeInfo.LastName) ||
                    CheckEquals(employeeInfo.Title) ||
                    CheckEquals(employeeInfo.Salary.ToString()) ||
                    CheckEquals(employeeInfo.Hike.ToString()))
                    return true;
                return false;
            }
            else
            {
                if (!CheckEquals(employeeInfo.EmpId.ToString()) ||
                   !CheckEquals(employeeInfo.FirstName) ||
                   !CheckEquals(employeeInfo.LastName) ||
                   !CheckEquals(employeeInfo.Title) ||
                   !CheckEquals(employeeInfo.Salary.ToString()) ||
                   !CheckEquals(employeeInfo.Hike.ToString()))
                    return true;
                return false;
            }
        }
        else
        {
            var value = record.GetType().GetProperty(columns.SelectedItem.ToString().Replace(" ", ""));
            if (value == null) return false; // Handle case where property doesn't exist
            var exactValue = value.GetValue(record, null);
            if (exactValue == null) return false; // Handle null values
            if (conditions.SelectedItem.ToString() == "Contains")
            {
                var vm = this.BindingContext as EmployeeInfoViewModel;
                var filterText = vm?.FilterText?.ToLower() ?? string.Empty;
                return filterText.Contains(exactValue.ToString().ToLower());
            }
            else if (conditions.SelectedItem.ToString() == "Equals")
            {
                return CheckEquals(exactValue.ToString());
            }
            else
            {
                return !CheckEquals(exactValue.ToString());
            }
        }
    }
    return false;
}

public bool CheckEquals(string value)
{
    return FilterText.Equals(value);
}

private void Button_Clicked(object sender, EventArgs e)
{
	treeGrid.View.Filter = FilterRecords;
	treeGrid.View.RefreshFilter();
}
{% endhighlight %}
{% endtabs %}

The following code example illustrates how to create a [Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker) for conditions and add appropriate strings to that Picker and how the records will be filtered based on selected conditions.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<Grid RowDefinitions = "50, *">
    <syncfusion:SfTreeGrid ItemsSource = "{Binding PersonDetails}"
                           ChildPropertyName = "Children"
                           x:Name = "treeGrid"
                           Grid.Row = "1">
    </syncfusion:SfTreeGrid>

    <Grid Grid.Row = "0">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width = "*"/>
            <ColumnDefinition Width = "150"/>
            <ColumnDefinition Width = "150"/>
            <ColumnDefinition Width = "150"/>
        </Grid.ColumnDefinitions>

        <Entry  Grid.Column = "0" Text = "{Binding FilterText}" Placeholder = "Enter filter text" />

        <Picker x:Name = "columns" Grid.Column = "1">
            <Picker.Items>
                <x:String>All Columns</x:String>
                <x:String>First Name</x:String>
                <x:String>Last Name</x:String>
                <x:String>Employee ID</x:String>
                <x:String>Salary</x:String>
                <x:String>Title</x:String>
                <x:String>Hike</x:String>
            </Picker.Items>
            <Picker.SelectedItem>
                <x:String>All Columns</x:String>
            </Picker.SelectedItem>
        </Picker>

        <Picker x:Name = "conditions" Grid.Column = "2">
            <Picker.Items>
                <x:String>Equals</x:String>
                <x:String>Does Not Equal</x:String>
                <x:String>Contains</x:String>
            </Picker.Items>
            <Picker.SelectedItem>
                <x:String>Does Not Equal</x:String>
            </Picker.SelectedItem>
        </Picker>

        <Button  Grid.Column = "3" Text = "Filter" Clicked = "Button_Clicked"/>
    </Grid>
</Grid>
{% endhighlight %}
{% endtabs %}

### Clearing Filters

To remove all applied filters and show the complete dataset:

{% tabs %}
{% highlight c# %}
private void ClearFilter(object sender, EventArgs e)
{
	treeGrid.View.Filter = null;
	treeGrid.View.RefreshFilter();
}
{% endhighlight %}
{% endtabs %}

> **Note:** Filters are applied before sorting operation. When you clear a filter, the view is refreshed and sorting will be reapplied to the full dataset.
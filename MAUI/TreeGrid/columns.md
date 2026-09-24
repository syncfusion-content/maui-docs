---
layout: post
title: Columns in .NET MAUI Tree Grid | Syncfusion®
description: Learn all about columns in Syncfusion® .NET MAUI Tree Grid, including automatic column generation, manual column definition, and column manipulation.
platform: MAUI
control: SfTreeGrid
documentation: UG
keywords : maui treegrid, maui tree grid, treegrid maui, maui hierarchical grid, .net maui treegrid, tree grid columns, maui treegrid columns
---

# Columns in .NET MAUI Tree Grid

The `SfTreeGrid` allows users to create and add columns in the following two ways:

* Automatically generating columns
* Manually defining columns

## Automatic columns generation

The `SfTreeGrid` creates columns automatically based on the bindable property `AutoGenerateColumnsMode`. The columns are generated based on the type of individual properties in the underlying collection that is set as ItemsSource.

The table below shows the column type created for the respective data types. For all other data types, `TreeGridTextColumn` will be created.

<table>
<tr>
<th>Data Type</th>
<th>Column</th>
</tr>
<tr>
<td>string, object</td>
<td>TreeGridTextColumn</td>
</tr>
<tr>
<td>int, float, double, decimal and their respective nullable types</td>
<td>TreeGridNumericColumn</td>
</tr>
<tr>
<td>DateTime</td>
<td>TreeGridDateColumn</td>
</tr>
<tr>
<td>bool</td>
<td>TreeGridCheckBoxColumn</td>
</tr>
</table>

### Customize Auto-generated Columns

Auto-generated columns can be customized by handling the `AutoGeneratingColumn` event, which is raised when each column is auto-generated.

The `TreeGridAutoGeneratingColumnEventArgs` object contains the following properties:

* **Column**: Returns the created column that can be customized.
* **Cancel**: Cancels the column creation.
* **PropertyType**: Specifies the type of the underlying model property for which the column is created.

You can skip generating a column by handling the `AutoGeneratingColumn` event as follows:

{% tabs %}
{% highlight xaml %}
<treeGrid:SfTreeGrid x:Name="treeGrid"
                     ItemsSource="{Binding PersonDetails}"
                     ChildPropertyName="Children"
                     AutoGeneratingColumn="TreeGrid_AutoGeneratingColumn">
</treeGrid:SfTreeGrid>
{% endhighlight %}

{% highlight c# %}
private void TreeGrid_AutoGeneratingColumn(object sender, TreeGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "Hike")
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

**Example:** Applying formatting to auto-generated columns using the event handler:

{% tabs %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();

treeGrid.ItemsSource = viewModel.Employees;
treeGrid.AutoGeneratingColumn += TreeGrid_AutoGeneratingColumn;

this.Content = treeGrid;

private void TreeGrid_AutoGeneratingColumn(object sender,
                                           TreeGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "Salary")
    {
        e.Column.Format = "C";
    }
    else if (e.Column.MappingName == "JoinDate")
    {
        e.Column.Format = "MMMM dd";
    }
}
{% endhighlight %}
{% endtabs %}

## Manually generate columns

The `SfTreeGrid` allows defining columns manually by adding `TreeGridColumn` objects to the `SfTreeGrid.Columns` collection. If you want to show only the manually defined columns in the view, you can achieve that by setting the `SfDataGrid.AutoGenerateColumnsMode` property to `None`.

There are different types of columns available. Any column can be created based on the requirements from both XAML and code.

{% tabs %}
{% highlight xaml %}
<treeGrid:SfTreeGrid x:Name="treeGrid"
                     ItemsSource="{Binding PersonDetails}"
                     ChildPropertyName="Children">
    <treeGrid:SfTreeGrid.Columns>
        <treeGrid:TreeGridNumericColumn HeaderText="Employee ID"
                                        MappingName="EmployeeID" />
        <treeGrid:TreeGridTextColumn HeaderText="Employee Name"
                                     MappingName="Name" />
        <treeGrid:TreeGridTextColumn HeaderText="Designation"
                                     MappingName="Designation" />
        <treeGrid:TreeGridTextColumn HeaderText="Department"
                                     MappingName="Department" />
    </treeGrid:SfTreeGrid.Columns>
</treeGrid:SfTreeGrid>
{% endhighlight %}

{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;

TreeGridNumericColumn employeeIdColumn = new TreeGridNumericColumn
{
    HeaderText = "Employee ID",
    MappingName = "EmployeeID"
};

TreeGridTextColumn nameColumn = new TreeGridTextColumn
{
    HeaderText = "Employee Name",
    MappingName = "Name"
};

TreeGridTextColumn designationColumn = new TreeGridTextColumn
{
    HeaderText = "Designation",
    MappingName = "Designation"
};

TreeGridTextColumn departmentColumn = new TreeGridTextColumn
{
    HeaderText = "Department",
    MappingName = "Department"
};

treeGrid.Columns.Add(employeeIdColumn);
treeGrid.Columns.Add(nameColumn);
treeGrid.Columns.Add(designationColumn);
treeGrid.Columns.Add(departmentColumn);

this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Column manipulation

You can get the columns from the `SfTreeGrid.Columns` property.

### Adding column to TreeGrid

You can add a column to the TreeGrid at runtime by adding an instance of a `TreeGridColumn` to the `SfTreeGrid.Columns` collection.

{% tabs %}
{% highlight c# %}
this.treeGrid.Columns.Add(new TreeGridTextColumn()
{
    HeaderText = "Department",
    MappingName = "Department"
});
{% endhighlight %}
{% endtabs %}

### Accessing a column

You can access a column through its column index or `TreeGridColumn.MappingName` from the `SfTreeGrid.Columns` collection.

{% tabs %}
{% highlight c# %}
TreeGridColumn column = this.treeGrid.Columns[1];

// OR

TreeGridColumn column = this.treeGrid.Columns["EmployeeID"];
{% endhighlight %}
{% endtabs %}

### Clearing or removing a column

You can remove all the columns by clearing the `SfTreeGrid.Columns` property.

{% tabs %}
{% highlight c# %}
this.treeGrid.Columns.Clear();
{% endhighlight %}
{% endtabs %}

You can remove a column using the `Remove` and `RemoveAt` methods.

{% tabs %}
{% highlight c# %}
this.treeGrid.Columns.Remove(column);

// OR

this.treeGrid.Columns.RemoveAt(1);
{% endhighlight %}
{% endtabs %}
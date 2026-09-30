---
layout: post
title: Column Types in .NET MAUI Tree Grid | Syncfusion®
description: Learn all about column types in Syncfusion® .NET MAUI Tree Grid, including supported column types, customization options, and usage examples.
platform: MAUI
control: SfTreeGrid
documentation: UG
keywords : maui tree grid, maui treegrid, tree grid maui, maui gridview, grid in maui, .net maui treegrid, .net maui tree grid, .net grid maui, .net maui column types, maui column types
---

# Column Types in .NET MAUI Tree Grid

The [.NET MAUI SfTreeGrid]() supports a variety of column types, each designed to handle specific data formats and presentation requirements. By leveraging the appropriate column type, you can effectively display hierarchical data based on your application's needs.

The table below outlines the available column types with their respective renderers and use cases:

<table>
<tr>
<th>Column Type</th>
<th>Renderer</th>
<th>Key</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[TreeGridTextColumn]()'| markdownify }}</td>
<td>{{'[TreeGridTextBoxRenderer]()' | markdownify }}</td>
<td>Text</td>
<td>Display text or alphanumeric values across rows in the hierarchical structure.</td>
</tr>
<tr>
<td>{{'[TreeGridCheckBoxColumn]()'| markdownify }}</td>
<td>{{'[TreeGridCheckBoxRenderer]()'| markdownify }}</td>
<td>CheckBox</td>
<td>Present boolean flags or toggle states with built-in checkbox controls for each node.</td>
</tr>
<tr>
<td>{{'[TreeGridTemplateColumn]()'| markdownify }}</td>
<td>{{'[TreeGridCellTemplateRenderer]()'| markdownify }}</td>
<td>Template</td>
<td>Create highly customizable cells with complex layouts, combining multiple controls and visual elements.</td>
</tr>
<tr>
<td>{{'[TreeGridNumericColumn]()'| markdownify }}</td>
<td>{{'[TreeGridNumericCellRenderer]()'| markdownify }}</td>
<td>Numeric</td>
<td>Render numerical values with formatting capabilities and numeric editing support.</td>
</tr>
<tr>
<td>{{'[TreeGridDateColumn]()'| markdownify }}</td>
<td>{{'[TreeGridDateCellRenderer]()'| markdownify }}</td>
<td>DateTime</td>
<td>Display temporal data including dates, times, and datetime values with format customization.</td>
</tr>
</table>

## TreeGridColumn

As the base column type for SfTreeGrid, [TreeGridColumn]() provides the core functionality inherited by all specialized column types. This section details the key properties and customization techniques available through the base column class:

### Binding options

The [TreeGridColumn.DisplayBinding]() property controls how data is rendered within cells. This binding mechanism connects your data source properties to the visual representation shown in the tree grid.

#### Mapping column to particular property

The [TreeGridColumn.MappingName]() property links a column to a corresponding property in your data model. When you assign only the MappingName, SfTreeGrid automatically generates an appropriate `DisplayBinding` based on that property name. Sorting and filtering operations within the grid rely on the `MappingName` to identify which data field to operate on.

To transform or format the displayed data, use value converters attached to the `TreeGridColumn.DisplayBinding` property:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <ResourceDictionary>
        <local:DisplayBindingConverter x:Key="displayBindingConverter" />
    </ResourceDictionary>
</ContentPage.Resources> 

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">

    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="EmployeeID" 
                                       DisplayBinding="{Binding EmployeeID, 
                                       Converter={StaticResource displayBindingConverter}}" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid> 
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="Converter.cs" %}
using System.Globalization;

public class DisplayBindingConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
            return "Employee : " + value.ToString();
        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight %}
{% endtabs %}

### Width, Text alignment and Padding

#### Setting manual column width

The SfTreeGrid allows you to customize the width of each TreeGridColumn in the [SfTreeGrid.Columns]() collection. To customize the column width, use the [TreeGridColumn.Width]() property. By default, this property is not assigned any value, and the TreeGridColumn renders based on the [DefaultColumnWidth]() property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       DefaultColumnWidth="150">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="EmployeeID" Width="100" />
        <syncfusion:TreeGridTextColumn MappingName="EmployeeName" Width="200" />
    </syncfusion:SfTreeGrid.Columns >
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;

// AutoGenerated Column
treeGrid.AutoGeneratingColumn += TreeGrid_AutoGeneratingColumn;

private void TreeGrid_AutoGeneratingColumn(object sender, TreeGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "EmployeeID")
    {
        e.Column.Width = 100;
    }
}

// Manually generated column
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridTextColumn() { MappingName = "EmployeeID", Width = 100 });

{% endhighlight %}
{% endtabs %}

#### TextAlignment

To configure the text alignment for header cells and data row cells, use the [TreeGridColumn.HeaderTextAlignment]() and [TreeGridColumn.CellTextAlignment]() properties. The default text alignment is based on the column type: numeric and date columns are right-aligned by default, while text columns are left-aligned.

#### Padding

The SfTreeGrid allows users to set padding for the Header and cells in display mode by using the [TreeGridColumn.HeaderPadding]() and [TreeGridColumn.CellPadding]() properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:TreeGridTextColumn MappingName="EmployeeID"
                               CellTextAlignment="Start"
                               CellPadding="10,0,0,0"
                               HeaderPadding="10,0,0,0" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
TreeGridTextColumn employeeID = new TreeGridTextColumn();
employeeID.MappingName = "EmployeeID";
employeeID.CellTextAlignment = TextAlignment.Start;
employeeID.CellPadding = new Thickness(10, 0, 0, 0);
employeeID.HeaderPadding = new Thickness(10, 0, 0, 0);
{% endhighlight %}
{% endtabs %}

### Header Customization
#### HeaderText

To customize the display content of the header cell, use the [TreeGridColumn.HeaderText]() property. It specifies the text displayed in the column header. If the header text is not defined, the `TreeGridColumn.MappingName` will be assigned to the header text and displayed as the column header.

#### Header template

Based on the requirement, the header cell can be customized using the [TreeGridColumn.HeaderTemplate]() property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="EmployeeID" HeaderText="ID">
            <syncfusion:TreeGridTextColumn.HeaderTemplate>
                <DataTemplate>
                    <Label Text="{Binding ., StringFormat='ID'}" TextColor="Blue" FontAttributes="Bold"/>
                </DataTemplate>
            </syncfusion:TreeGridTextColumn.HeaderTemplate>
        </syncfusion:TreeGridTextColumn>
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Hiding a column 

To hide a particular column, use the `TreeGridColumn.Visible` property. The default value is `True`.

N> Set the [Visible]() property to `False` instead of setting column width to `0` to hide a column.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="EmployeeID" />
        <syncfusion:TreeGridTextColumn MappingName="EmployeeName" />
        <syncfusion:TreeGridTextColumn MappingName="Department" Visible="false" />
    </syncfusion:SfTreeGrid.Columns >
</syncfusion:SfTreeGrid>     
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;

// AutoGenerate Column
treeGrid.AutoGeneratingColumn += TreeGrid_AutoGeneratingColumn;

private void TreeGrid_AutoGeneratingColumn(object sender, TreeGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "EmployeeID")
    {
        e.Column.Visible = false;
    }
}

// Manually generated column
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridTextColumn() { MappingName = "EmployeeID", Visible = false});

{% endhighlight %}
{% endtabs %}


### Formatting

To format values displayed in the TreeGridColumn, use the [TreeGridColumn.Format]() property. The format string is applied to the underlying data type. Common format strings include:

* **C or C2** - Currency format (e.g., $1,234.56)
* **N or N2** - Number format with decimal places (e.g., 1,234.56)
* **P or P2** - Percentage format (e.g., 123.46%)
* **d** - Short date format (e.g., 7/6/2026)
* **dd/MM/yyyy** - Custom date format
* **hh\:mm** - Time format

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid.Columns>
    <syncfusion:TreeGridTextColumn MappingName="Salary" Format="C2" />
</syncfusion:SfTreeGrid.Columns>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.Columns.Add(new TreeGridTextColumn()
{
    MappingName = "Salary",
    Format = "C2"  // Displays as $1,234.56
});

treeGrid.Columns.Add(new TreeGridTextColumn()
{
    MappingName = "JoiningDate",
    Format = "dd/MM/yyyy"
});

treeGrid.Columns.Add(new TreeGridTextColumn()
{
    MappingName = "Bonus",
    Format = "P2"  // Displays as 25.50%
});
{% endhighlight %}
{% endtabs %}

#### Format column using converter

You can customize the format of a particular column using a converter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <local:SalaryConverter x:Key="salaryConverter"/>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="Salary" 
                                       DisplayBinding="{Binding Salary, 
                                       Converter={StaticResource salaryConverter}}" />
    </syncfusion:SfTreeGrid.Columns >
</syncfusion:SfTreeGrid>
{% endhighlight%}
{% endtabs %}

{% tabs %}
{% highlight C# tabtitle="Converter.cs" %}
using System.Globalization;

public class SalaryConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null && value is double salary)
        {
            return salary.ToString("C2");
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
{% endhighlight%}
{% endtabs %}

N> For AutoGenerated columns, formatting can be applied by handling the [SfTreeGrid.AutoGeneratingColumn]() event.

#### Formatting TreeGridColumn with different culture

To apply a different `CultureInfo` for TreeGridColumns, use the [TreeGridColumn.CultureInfo]() property. Assign the desired string format to this property. The column will format the value based on the type of the associated property. You can use different `StringFormats` to customize the values displayed in cells.

To apply different cultures for the TreeGridColumns, follow the code example:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.Columns.Add(new TreeGridTextColumn()
{
    MappingName = "EmployeeName",
    CultureInfo = new CultureInfo("en-US"),
});

treeGrid.Columns.Add(new TreeGridTextColumn()
{
    MappingName = "EmployeeID",
    Format = "N",
    CultureInfo = new CultureInfo("en-GB"),
});
{% endhighlight %}
{% endtabs %}

For auto-generated columns, this is achievable by handling the `SfTreeGrid.AutoGeneratingColumn` event. To apply different cultures for auto-generated `TreeGridColumns`, follow the code example:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"                       
                       AutoGeneratingColumn="treeGrid_AutoGeneratingColumn"/>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.AutoGeneratingColumn += treeGrid_AutoGeneratingColumn;

private void treeGrid_AutoGeneratingColumn(object sender, TreeGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "EmployeeID")
    {
        e.Column.CultureInfo = new CultureInfo("en-GB");
        e.Column.Format = "N";
    }
}
{% endhighlight %}
{% endtabs %}

## TreeGridTextColumn

The [TreeGridTextColumn]() serves as the standard choice for rendering text-based and numeric content within the hierarchy. Being the default column type, it seamlessly binds to any data property without requiring special configuration. This versatile column type is ideal for displaying identifiers, names, descriptions, and other text information throughout your tree structure.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn HeaderText="Employee Name" MappingName="Name" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

## TreeGridNumericColumn

The [TreeGridNumericColumn]() is specifically engineered for presenting numerical data with comprehensive formatting and editing capabilities. Inheriting from `TreeGridColumn`, it provides all base properties while adding numeric-specific features for validation, rounding, and display precision.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridNumericColumn HeaderText="Employee ID" MappingName="EmployeeID" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Formatting Numeric Values

Apply custom number formats to control how numeric values appear. The `Format` property accepts standard .NET numeric format strings:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridNumericColumn HeaderText="Salary" MappingName="Salary" Format="C2" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

## TreeGridDateColumn

The [TreeGridDateColumn]() handles temporal data with integrated date selection and editing. Building on `TreeGridColumn` functionality, it adds specialized capabilities for date/time validation, picker integration, and format customization suited for calendar-based information.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridDateColumn HeaderText="Date of Joining" MappingName="DateOfJoining" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Formatting Date Values

Control how dates render using the `Format` property with .NET date format patterns:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridDateColumn HeaderText="Date of Joining" MappingName="DOJ" Format="dd/MM/yyyy" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

## TreeGridCheckBoxColumn

The [TreeGridCheckBoxColumn]() simplifies the presentation and modification of boolean states. Extending `TreeGridColumn`, it furnishes a native checkbox control for toggling true/false values, making it the go-to choice for feature flags, status indicators, and permission toggles.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridCheckBoxColumn HeaderText="Available" MappingName="IsAvailable" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Checkbox column" src="Images\column-types\maui-treegrid-checkbox-column.png" width="404"/>

## TreeGridTemplateColumn

The [TreeGridTemplateColumn]() unlocks unlimited design possibilities by allowing you to define entirely custom cell layouts. This column type stands as the pinnacle of customization, enabling you to craft sophisticated, interactive cells that go beyond standard data presentation.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid" 
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTemplateColumn HeaderText="Details" MappingName="EmployeeID">
            <syncfusion:TreeGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <Grid Padding="5" ColumnDefinitions="*,*" ColumnSpacing="10">
                        <Label Text="{Binding EmployeeName}" 
                               VerticalOptions="Center"
                               FontAttributes="Bold"/>
                        <Label Text="{Binding Department}" 
                               Grid.Column="1"
                               VerticalOptions="Center"
                               TextColor="Gray"/>
                    </Grid>
                </DataTemplate>
            </syncfusion:TreeGridTemplateColumn.CellTemplate>
        </syncfusion:TreeGridTemplateColumn>
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

### Load view through template selector

You can load any view to the cells through the `CellTemplate` by assigning the `TemplateSelector`. This allows you to dynamically choose different templates based on data properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="lowTemplate">
            <Grid Padding="5" Background="#5BC0EB">
                <Label Text="{Binding Salary}" 
                       HorizontalTextAlignment="Center"
                       VerticalTextAlignment="Center"
                       TextColor="White"
                       FontAttributes="Bold"/>
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="averageTemplate">
            <Grid Padding="5" Background="#FF8FAB">
                <Label Text="{Binding Salary}" 
                       HorizontalTextAlignment="Center"
                       VerticalTextAlignment="Center"
                       TextColor="White"
                       FontAttributes="Bold"/>
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="highTemplate">
            <Grid Padding="5" Background="#7BD389">
                <Label Text="{Binding Salary}" 
                       HorizontalTextAlignment="Center"
                       VerticalTextAlignment="Center"
                       TextColor="White"
                       FontAttributes="Bold"/>
            </Grid>
        </DataTemplate>
        <selector:SalaryTemplateSelector x:Key="salaryTemplateSelector"
                                         Low="{StaticResource lowTemplate}"
                                         Average="{StaticResource averageTemplate}"
                                         High="{StaticResource highTemplate}" />
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTemplateColumn MappingName="Salary"
                                           HeaderText="Salary">
            <syncfusion:TreeGridTemplateColumn.CellTemplate>
                <local:SalaryTemplateSelector Low="{StaticResource lowTemplate}"
                                              Average="{StaticResource averageTemplate}"
                                              High="{StaticResource highTemplate}" />
            </syncfusion:TreeGridTemplateColumn.CellTemplate>
        </syncfusion:TreeGridTemplateColumn>
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="TemplateSelector.cs" %}
public class SalaryTemplateSelector : DataTemplateSelector
{
    public DataTemplate Low { get; set; }

    public DataTemplate Average { get; set; }

    public DataTemplate High { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var employee = item as EmployeeModel;
        if (employee != null)
        {
            double salary = employee.Salary;
            if (salary < 50000)
                return Low;
            else if (salary < 100000)
                return Average;
            else
                return High;
        }
        return Average;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Cell template selector" src="Images\column-types\maui-treegrid-template-column-template-selector.png" width="404"/>
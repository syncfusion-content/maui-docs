---
layout: post
title: Column Types in .NET MAUI Tree Grid | Syncfusion®
description: Learn all about column types in Syncfusion® .NET MAUI Tree Grid, including supported column types, customization options, and usage examples.
platform: MAUI
control: SfTreeGrid
documentation: UG
keywords : maui tree grid, maui treegrid, tree grid maui, maui gridview, grid in maui, .net maui treegrid, .net maui tree grid, .net grid maui, .net maui column types, maui column types, maui treegrid combobox column, maui treegrid picker column
---

# Column Types in .NET MAUI Tree Grid

The [.NET MAUI SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) supports a variety of column types, each designed to handle specific data formats and presentation requirements. By leveraging the appropriate column type, you can effectively display hierarchical data based on your application's needs.

The table below outlines the available column types with their respective renderers and use cases:

<table>
<tr>
<th>Column Type</th>
<th>Renderer</th>
<th>Key</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[TreeGridTextColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTextColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridTextCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTextCellRenderer.html)' | markdownify }}</td>
<td>Text</td>
<td>Display text or alphanumeric values across rows in the hierarchical structure.</td>
</tr>
<tr>
<td>{{'[TreeGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridCheckBoxColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridCheckBoxCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridCheckBoxCellRenderer.html)'| markdownify }}</td>
<td>CheckBox</td>
<td>Present boolean flags or toggle states with built-in checkbox controls for each node.</td>
</tr>
<tr>
<td>{{'[TreeGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTemplateColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridTemplateCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTemplateCellRenderer.html)'| markdownify }}</td>
<td>Template</td>
<td>Create highly customizable cells with complex layouts, combining multiple controls and visual elements.</td>
</tr>
<tr>
<td>{{'[TreeGridNumericColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridNumericColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridNumericCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridNumericCellRenderer.html)'| markdownify }}</td>
<td>Numeric</td>
<td>Render numerical values with formatting capabilities and numeric editing support.</td>
</tr>
<tr>
<td>{{'[TreeGridDateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDateColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridDateCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDateCellRenderer.html)'| markdownify }}</td>
<td>DateTime</td>
<td>Display temporal data including dates, times, and datetime values with format customization.</td>
</tr>
<tr>
<td>{{'[TreeGridHyperlinkColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridHyperlinkColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridHyperlinkCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridHyperlinkCellRenderer.html)'| markdownify }}</td>
<td>Hyperlink</td>
<td>Display cell values as clickable links and handle or cancel navigation when a link is tapped.</td>
</tr>
<tr>
<td>{{'[TreeGridImageColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridImageColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridImageCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridImageCellRenderer.html)'| markdownify }}</td>
<td>Image</td>
<td>Display images from an <code>ImageSource</code> property in each node.</td>
</tr>
<tr>
<td>{{'[TreeGridComboBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridComboBoxCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxCellRenderer.html)'| markdownify }}</td>
<td>ComboBox</td>
<td>Display a value from a list of items and edit it using a combo box.</td>
</tr>
<tr>
<td>{{'[TreeGridPickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridPickerColumn.html)'| markdownify }}</td>
<td>{{'[TreeGridPickerCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridPickerCellRenderer.html)'| markdownify }}</td>
<td>Picker</td>
<td>Display a value from a list of items and edit it using a picker.</td>
</tr>
</table>

## TreeGridColumn

As the base column type for SfTreeGrid, [TreeGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html) provides the core functionality inherited by all specialized column types. This section details the key properties and customization techniques available through the base column class:

### Binding options

The [TreeGridColumn.DisplayBinding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_DisplayBinding) property controls how data is rendered within cells. This binding mechanism connects your data source properties to the visual representation shown in the tree grid.

#### Mapping column to particular property

The [TreeGridColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_MappingName) property links a column to a corresponding property in your data model. When you assign only the MappingName, SfTreeGrid automatically generates an appropriate `DisplayBinding` based on that property name. Sorting and filtering operations within the grid rely on the `MappingName` to identify which data field to operate on.

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

The SfTreeGrid allows you to customize the width of each TreeGridColumn in the [SfTreeGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_Columns) collection. To customize the column width, use the [TreeGridColumn.Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_Width) property. By default, this property is not assigned any value, and the TreeGridColumn renders based on the [DefaultColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_DefaultColumnWidth) property.

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

To configure the text alignment for header cells and data row cells, use the [TreeGridColumn.HeaderTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_HeaderTextAlignment) and [TreeGridColumn.CellTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_CellTextAlignment) properties. The default text alignment is based on the column type: numeric and date columns are right-aligned by default, while text columns are left-aligned.

#### Padding

The SfTreeGrid allows users to set padding for the Header and cells in display mode by using the [TreeGridColumn.HeaderPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_HeaderPadding) and [TreeGridColumn.CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_CellPadding) properties.

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

To customize the display content of the header cell, use the [TreeGridColumn.HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_HeaderText) property. It specifies the text displayed in the column header. If the header text is not defined, the `TreeGridColumn.MappingName` will be assigned to the header text and displayed as the column header.

#### Header template

Based on the requirement, the header cell can be customized using the [TreeGridColumn.HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_HeaderTemplate) property.

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

N> Set the [Visible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_Visible) property to `False` instead of setting column width to `0` to hide a column.

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

To format values displayed in the TreeGridColumn, use the [TreeGridColumn.Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_Format) property. The format string is applied to the underlying data type. Common format strings include:

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

N> For AutoGenerated columns, formatting can be applied by handling the [SfTreeGrid.AutoGeneratingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AutoGeneratingColumn) event.

#### Formatting TreeGridColumn with different culture

To apply a different `CultureInfo` for TreeGridColumns, use the [TreeGridColumn.CultureInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_CultureInfo) property. Assign the desired string format to this property. The column will format the value based on the type of the associated property. You can use different `StringFormats` to customize the values displayed in cells.

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

The [TreeGridTextColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTextColumn.html) serves as the standard choice for rendering text-based and numeric content within the hierarchy. Being the default column type, it seamlessly binds to any data property without requiring special configuration. This versatile column type is ideal for displaying identifiers, names, descriptions, and other text information throughout your tree structure.

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

The [TreeGridNumericColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridNumericColumn.html) is specifically engineered for presenting numerical data with comprehensive formatting and editing capabilities. Inheriting from `TreeGridColumn`, it provides all base properties while adding numeric-specific features for validation, rounding, and display precision.

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

The [TreeGridDateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDateColumn.html) handles temporal data with integrated date selection and editing. Building on `TreeGridColumn` functionality, it adds specialized capabilities for date/time validation, picker integration, and format customization suited for calendar-based information.

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

The [TreeGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridCheckBoxColumn.html) simplifies the presentation and modification of boolean states. Extending `TreeGridColumn`, it furnishes a native checkbox control for toggling true/false values, making it the go-to choice for feature flags, status indicators, and permission toggles.

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

The [TreeGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTemplateColumn.html) unlocks unlimited design possibilities by allowing you to define entirely custom cell layouts. This column type stands as the pinnacle of customization, enabling you to craft sophisticated, interactive cells that go beyond standard data presentation.

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

## TreeGridHyperlinkColumn

The [TreeGridHyperlinkColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridHyperlinkColumn.html) derives from `TreeGridTextColumn`, so it inherits all of its properties. It displays the column value as a clickable link and lets end users trigger navigation by tapping it. Cell and header text are aligned to the start by default.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridHyperlinkColumn HeaderText="City"
                                            MappingName="City" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children";
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridHyperlinkColumn()
{
    MappingName = "City",
    HeaderText = "City"
});
{% endhighlight %}
{% endtabs %}

<img alt="maui-treegrid-Hyperlink-column" src="Images\column-types\maui-treegrid-Hyperlink-column.png" width="404"/>

### Handling navigation

When a hyperlink cell is tapped, the [CurrentCellRequestNavigating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CurrentCellRequestNavigating) event is raised with [TreeGridCurrentCellRequestNavigatingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridCurrentCellRequestNavigatingEventArgs.html). If the event is not canceled and the text is a well-formed absolute URI, the TreeGrid opens it with the default launcher. For any other text, nothing is opened unless you handle the event.

The event arguments expose the following read-only properties, and `Cancel` (inherited from `CancelEventArgs`):

| Property | Type | Description |
|---|---|---|
| `NavigateText` | `string` | The text of the tapped cell, which is the value from the column's `DisplayBinding` if defined, otherwise the value bound to `MappingName`. |
| `Record` | `object?` | The data object of the row that contains the tapped hyperlink. |
| `RowIndex` | `int` | The row index of the tapped cell. |
| `ColumnIndex` | `int` | The column index of the tapped cell. |
| `Cancel` | `bool` | Set to `true` to cancel the default navigation. |

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.CurrentCellRequestNavigating += OnCurrentCellRequestNavigating;

private async void OnCurrentCellRequestNavigating(object? sender, TreeGridCurrentCellRequestNavigatingEventArgs e)
{
    // Handle the navigation in the application and skip the default behavior.
    e.Cancel = true;
    await Launcher.OpenAsync(new Uri("https://en.wikipedia.org/wiki/" + e.NavigateText));
}
{% endhighlight %}
{% endtabs %}

### Cancel the navigation

Set `TreeGridCurrentCellRequestNavigatingEventArgs.Cancel` to `true` to prevent the default navigation.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.CurrentCellRequestNavigating += (sender, e) =>
{
    e.Cancel = true;
};
{% endhighlight %}
{% endtabs %}

### Appearance

Set [TreeGridStyle.HyperlinkTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_HyperlinkTextColor) through `DefaultStyle` to change the hyperlink color. The default value is `#6750A4`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle HyperlinkTextColor="Orange" />
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.DefaultStyle = new TreeGridStyle
{
    HyperlinkTextColor = Colors.Orange
};
{% endhighlight %}
{% endtabs %}

N> The link text is underlined and recolored while the pointer is over it or the cell is pressed. This hover color is not configurable through a public API.

### Public API summary

| API | Description |
|---|---|
| `TreeGridHyperlinkColumn` | Column that renders cell values as hyperlinks. It has no members of its own and inherits from `TreeGridTextColumn`. |
| `TreeGridHyperlinkCellRenderer` | Renderer registered for the `Hyperlink` cell type. |
| `SfTreeGrid.CurrentCellRequestNavigating` | Event raised when a hyperlink is tapped. |
| `SfTreeGrid.HandleHyperlinkNavigation(string text, RowColumnIndex rowColumnIndex, object rowData)` | Raises `CurrentCellRequestNavigating` for the given text, and opens the text when it is a well-formed absolute URI and the event is not canceled. Does nothing for empty text. |
| `TreeGridCurrentCellRequestNavigatingEventArgs` | Event data with `NavigateText`, `Record`, `RowIndex`, `ColumnIndex` and `Cancel`. |
| `TreeGridStyle.HyperlinkTextColor` | Hyperlink text color. |

## TreeGridImageColumn

The [TreeGridImageColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridImageColumn.html) derives from `TreeGridColumn`, so it inherits all of its properties. It displays an image as the cell content. The property bound through `MappingName` must be of type `ImageSource`.

It is possible to load images in any of the following four ways:

  - **FromFile**: Required to specify the path of the file.
  - **FromResource**: Required to set an image as an embedded resource.
  - **FromStream**: Required to load an image from the byte[] array.
  - **FromURI**: Required to set an image from a web service or website.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridImageColumn HeaderText="EmployeeImage"
                                        MappingName="Image" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children";
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridImageColumn()
{
    MappingName = "Photo",
    HeaderText = "Photo"
});
{% endhighlight %}

{% highlight c# tabtitle="EmployeeModel.cs" %}
public class EmployeeModel
{
    public ImageSource Photo { get; set; } = ImageSource.FromFile("employee.png");
}
{% endhighlight %}
{% endtabs %}

<img alt="maui-treegrid-image-column" src="Images\column-types\maui-treegrid-image-column.png" width="404"/>

### Aspect

Use [TreeGridImageColumn.Aspect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridImageColumn.html#Syncfusion_Maui_TreeGrid_TreeGridImageColumn_Aspect) to control how the image is sized within the cell. It accepts the MAUI `Aspect` values, and the default is `AspectFit`.

* **AspectFit** (default): Scales the image to fit the cell while maintaining the aspect ratio.
* **AspectFill**: Scales the image to fill the cell while maintaining the aspect ratio; content may be clipped.
* **Fill**: Stretches the image to fill the cell, ignoring the aspect ratio.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:TreeGridImageColumn MappingName="Photo"
                                HeaderText="Photo"
                                Aspect="AspectFill" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.Columns.Add(new TreeGridImageColumn()
{
    MappingName = "Photo",
    HeaderText = "Photo",
    Aspect = Aspect.AspectFill
});
{% endhighlight %}
{% endtabs %}

N> The image margin is taken from the column's `CellPadding`. Change `CellPadding` to adjust the space around the image.

### Public API summary

| API | Description |
|---|---|
| `TreeGridImageColumn` | Column that displays `ImageSource` values. |
| `TreeGridImageColumn.Aspect` / `AspectProperty` | How the image is sized in the cell. Default `Aspect.AspectFit`. |
| `TreeGridImageCellRenderer` | Renderer registered for the `Image` cell type. |
| `SfTreeGridImage` | The `Image` control used to display the image in each cell. |

## TreeGridComboBoxColumn

The [TreeGridComboBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html) inherits all the properties of `TreeGridColumn`. It displays a value from a list of items in the cell and hosts a [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) in edit mode. Set the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_ItemsSource) property to a collection of primitive types or user-defined types. To edit the column, set [SfTreeGrid.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowEditing) to `true`. By default, editing begins on a double tap, which can be changed using [SfTreeGrid.EditTapAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_EditTapAction).

### Collection of primitive types

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridComboBoxColumn HeaderText="Department"
                                           MappingName="Department"
                                           ItemsSource="{Binding Departments}" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
EmployeeViewModel viewModel = new EmployeeViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.EmployeeCollection;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowEditing = true;
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridComboBoxColumn()
{
    HeaderText = "Department",
    MappingName = "Department",
    ItemsSource = viewModel.Departments
});
{% endhighlight %}
{% endtabs %}

N> `Departments` is an `ObservableCollection<string>` in the view model. The column resolves its `ItemsSource` binding against the `BindingContext` of the `SfTreeGrid`.

### Collection of user-defined types

When `ItemsSource` contains custom objects, use the following properties:

* [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_DisplayMemberPath): The property of the item whose value is shown in the cell and in the drop-down.
* [ValueMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_ValueMemberPath): The property of the item that is compared with the `MappingName` value of the row, and written back to the `MappingName` property when an item is selected.

The cell displays the `DisplayMemberPath` value of the item whose `ValueMemberPath` value equals the cell value. If no item matches, the cell is blank.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:TreeGridComboBoxColumn HeaderText="Department"
                                   MappingName="DepartmentID"
                                   ItemsSource="{Binding DepartmentCollection}"
                                   DisplayMemberPath="DepartmentName"
                                   ValueMemberPath="DepartmentID" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.Columns.Add(new TreeGridComboBoxColumn()
{
    HeaderText = "Department",
    MappingName = "DepartmentID",
    ItemsSource = viewModel.DepartmentCollection,
    DisplayMemberPath = "DepartmentName",
    ValueMemberPath = "DepartmentID"
});
{% endhighlight %}
{% endtabs %}

### Load different items for each row

To load different items for each row, assign an [IItemsSourceSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.IItemsSourceSelector.html) to the [ItemsSourceSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_ItemsSourceSelector) property. Implement its `GetItemsSource` method, which receives the row data object (`record`) and the binding context of the TreeGrid (`dataContext`).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <local:CitySelector x:Key="citySelector" />
</ContentPage.Resources>

<syncfusion:TreeGridComboBoxColumn HeaderText="City"
                                   MappingName="City"
                                   ItemsSourceSelector="{StaticResource citySelector}" />
{% endhighlight %}

{% highlight c# tabtitle="CitySelector.cs" %}
public class CitySelector : IItemsSourceSelector
{
    public IEnumerable GetItemsSource(object record, object dataContext)
    {
        var employee = record as EmployeeModel;
        var viewModel = dataContext as EmployeeViewModel;

        if (employee == null || viewModel == null)
            return null;

        // Returns the cities of the country of the current row.
        viewModel.Cities.TryGetValue(employee.Country, out var cities);
        return cities;
    }
}
{% endhighlight %}
{% endtabs %}

### Editing and suggestions

| Property | Default | Description |
|---|---|---|
| [IsEditableMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_IsEditableMode) | `false` | Allows typing text in the combo box. |
| [SuggestionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_SuggestionMode) | `StartsWith` | Sets how suggestions are matched, using the `ComboBoxTextSearchMode` enum. |
| [CanFilterSuggestions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_CanFilterSuggestions) | `false` | Filters the drop-down list as the user types. |
| [ShowClearButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_ShowClearButton) | `true` | Shows the clear button in the editor. |
| [DropDownWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridComboBoxColumn.html#Syncfusion_Maui_TreeGrid_TreeGridComboBoxColumn_DropDownWidth) | `-1` | Sets the width of the drop-down. |

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:TreeGridComboBoxColumn HeaderText="Department"
                                   MappingName="Department"
                                   ItemsSource="{Binding Departments}"
                                   IsEditableMode="True"
                                   SuggestionMode="Contains"
                                   CanFilterSuggestions="True"
                                   ShowClearButton="False"
                                   DropDownWidth="200" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.Columns.Add(new TreeGridComboBoxColumn()
{
    HeaderText = "Department",
    MappingName = "Department",
    ItemsSource = viewModel.Departments,
    IsEditableMode = true,
    SuggestionMode = ComboBoxTextSearchMode.Contains,
    CanFilterSuggestions = true,
    ShowClearButton = false,
    DropDownWidth = 200
});
{% endhighlight %}
{% endtabs %}

N> `ShowClearButton` applies to the editor when `IsEditableMode` is `true`, as in the DataGrid.

When an item is selected in the drop-down, the [SfTreeGrid.CellValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CellValueChanged) and [SfTreeGrid.CurrentCellDropDownSelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CurrentCellDropDownSelectionChanged) events are raised. The latter provides `CurrentCellDropDownSelectionChangedEventArgs` with `SelectedItem`, `SelectedIndex` and `RowColumnIndex`.

## TreeGridPickerColumn

The [TreeGridPickerColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridPickerColumn.html) inherits all the properties of `TreeGridColumn`. It displays a value from a list of items in the cell and hosts a [SfPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfPicker.html) in edit mode. Header and cell text are aligned to the start by default. The picker opens as a popup relative to the cell on desktop platforms, and as a dialog with **OK** and **Cancel** buttons on mobile platforms. Set `SfTreeGrid.AllowEditing` to `true` to edit the column.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding EmployeeCollection}"
                       ChildPropertyName="Children"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridPickerColumn HeaderText="Country"
                                         MappingName="Country"
                                         ItemsSource="{Binding Countries}" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.AllowEditing = true;
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridPickerColumn()
{
    HeaderText = "Country",
    MappingName = "Country",
    ItemsSource = viewModel.Countries
});
{% endhighlight %}
{% endtabs %}

### Properties

| Property | Type | Default | Description |
|---|---|---|---|
| [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridPickerColumn.html#Syncfusion_Maui_TreeGrid_TreeGridPickerColumn_ItemsSource) | `IEnumerable<object>` | `null` | The items shown in the picker. |
| [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridPickerColumn.html#Syncfusion_Maui_TreeGrid_TreeGridPickerColumn_DisplayMemberPath) | `string` | `""` | The item property shown in the cell and in the picker. |
| [ValueMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridPickerColumn.html#Syncfusion_Maui_TreeGrid_TreeGridPickerColumn_ValueMemberPath) | `string` | `""` | The item property that is matched with the `MappingName` value and written back on commit. When empty, the item itself is the value. |
| [ItemsSourceSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridPickerColumn.html#Syncfusion_Maui_TreeGrid_TreeGridPickerColumn_ItemsSourceSelector) | `IItemsSourceSelector` | `null` | Provides different items for each row. |

`DisplayMemberPath`, `ValueMemberPath` and `ItemsSourceSelector` work in the same way as in the [TreeGridComboBoxColumn](#collection-of-user-defined-types).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:TreeGridPickerColumn HeaderText="Department"
                                 MappingName="DepartmentID"
                                 ItemsSource="{Binding DepartmentCollection}"
                                 DisplayMemberPath="DepartmentName"
                                 ValueMemberPath="DepartmentID" />
{% endhighlight %}
{% endtabs %}

N> On mobile platforms, the value is written back only when **OK** is tapped, and **Cancel** discards the selection.

### Differences from the DataGrid

* The TreeGrid columns are `TreeGridComboBoxColumn` and `TreeGridPickerColumn`, and the renderers are `TreeGridComboBoxCellRenderer` and `TreeGridPickerCellRenderer`.
* `IItemsSourceSelector` is in the `Syncfusion.Maui.TreeGrid` namespace. The `record` passed to it can be a data object from any level of the hierarchy.
* Editing is enabled with `SfTreeGrid.AllowEditing` or `TreeGridColumn.AllowEditing`.

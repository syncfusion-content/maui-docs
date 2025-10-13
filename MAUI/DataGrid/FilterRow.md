---
layout: post
title: Filter Row in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Filter Row support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui filterrow, maui filterrow
---

# Filter Row in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)  provides built-in row (called FilterRow) to filter the records. You can enable the FilterRow by specifying the position where it should be displayed by setting SfDataGrid.FilterRowPosition property.

{% tabs %}
{% highlight XAML %}
        <syncfusion:SfDataGrid x:Name="dataGrid"
                               FilterRowPosition="FixedTop"
                               AllowEditing="True"
                               SelectionMode="Single"
                               ItemsSource="{Binding OrderInfoCollection}" >
{% endhighlight %}
{% highlight c# %}
this.dataGrid.FilterRowPosition = DataGridFilterRowPosition.FixedTop;
{% endhighlight %}
{% endtabs %}

You can get the row index of FilterRow by using the SfDataGrid.GetFilterRowIndex method.

{% tabs %}
{% highlight c# %}
this.dataGrid.FilterRowPosition = DataGridFilterRowPosition.FixedTop;
{% endhighlight %}
{% endtabs %}

You can check whether the specified row index is FilterRow index, by using SfDataGrid.IsFilterRowIndex helper method.

{% tabs %}
{% highlight c# %}
bool isFilterRowIndex = this.dataGrid.IsFilterRowIndex(1);
{% endhighlight %}
{% endtabs %}

## Built-in Editors

By default, FilterRow loads the editors based on underlying property type to filter the data easily. You can change the default editors by using GridColumn.FilterRowEditorType property.

{% tabs %}
{% highlight XAML %}

<syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                                MappingName="CustomerID"
                                                FilterRowEditorType="MultiSelectComboBox"/>

{% endhighlight %}
{% highlight c# %}

this.dataGrid.Columns[2].FilterRowEditorType = "MultiSelectComboBox";

{% endhighlight %}
{% endtabs %}

Below are the built-in FilterRow editor types supported in SfDataGrid.

<table>
<tr>
<th> FilterRowEditor Type </th>
<th> Editor Control </th>
<th> Renderer </th>
<th> Description </th>
</tr>
<tr>
<td> TextBox </td>
<td> SfDataGridEntry </td>
<td>  </td>
<td> Used for filtering the string values. </td>
</tr>
<tr>
<td> Numeric</td>
<td> SfNumericEntry </td>
<td>  </td>
<td> Used for filtering the numeric values.</td>
</tr>
<tr>
<td> ComboBox </td>
<td> SfComboBox </td>
<td>  </td>
<td> Used for filtering the specific value from the drop down. </td>
</tr>
<tr>
<td> MultiSelectComboBox </td>
<td> SfComboBox </td>
<td>  </td>
<td> Used for filtering the multiple value from the drop down. </td>
</tr>
<tr>
<td> CheckBox </td>
<td> SfCheckBox </td>
<td>  </td>
<td> Used for filtering the Boolean values. </td>
</tr>
<tr>
<td> DateTime </td>
<td> DatePicker </td>
<td> </td>
<td> Used for filtering the DateTime values. </td>
</tr>
</table>

## Filter options

Based on the editor type, FilterRowCell displays the filter conditions in dropdown where you can easily switch between the conditions to filter the data. You can disable filter options by setting GridColumn.FilterRowOptionsVisibility property.

{% tabs %}
{% highlight XAML %}

<syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                            MappingName="CustomerID"
                                            FilterRowOptionsVisibility="False" />

{% endhighlight %}
{% highlight c# %}

this.dataGrid.Columns[0].FilterRowOptionsVisibility = false;

{% endhighlight %}
{% endtabs %}

Below are the filter conditions supported by different filter row editors in SfDataGrid.

<table>
<tr>
<th> Numeric Editor </th>
<th> TextBox Editor </th>
<th> DateTime Editor </th>
<th> CheckBox Editor </th>
<th> ComboBox, MultiSelectComboBox  Editor </th>
</tr>
<tr>
<td> When integer, double, short, decimal, byte or long are bound to the GridColumn , the Numeric editor type are loaded in FilterRowCell . </td>
<td> When string value is bounded to the GridColumn or the items is dynamic, then TextBox editor type are loaded in FilterRowCell . </td>
<td> When DateTime type is bounded to the GridColumn , then DateTime editor is loaded in FilterRowCell . </td>
<td> When Boolean type is bounded to the GridColumn , then CheckBox editor is loaded in FilterRowCell . </td>
<td> If we need the ComboBox and MultiSelectComboBox we have to set the FilterRowEditorType . </td>
</tr>
<tr>
<td>The default filter condition is Equals, the below filter conditions are available in numeric filter.
Equals
Does Not Equal
Null
Not Null
Less Than
Less Than or Equal
Greater Than
Greater Than or Equal</td>
<td>The default filter condition is Begins With, the below filter conditions are available in text filter.
Equals
Does Not Equal
Null
Not Null
Begins With
Does Not Begin With
Ends With
Does Not End With
Contains
Does Not Contain
Empty
Not Empty</td>
<td>The default filter condition is Equals, the below filter conditions are available in date time filter.
Equals
Does Not Equal
Null
Not Null
Before
Before or Equal
After
After or Equal</td>
<td>Always equals filter condition will be applied for filtering the CheckBox value.</td>
<td></td>
</tr>
</table>

You can change the default FilterRow condition for a corresponding column by using GridColumn.FilterRowCondition property.

{% tabs %}
{% highlight XAML %}

<syncfusion:DataGridNumericColumn HeaderText="Order ID" 
                                  MappingName="OrderID" FilterRowCondition="LessThan"/>


{% endhighlight %}
{% highlight c# %}

this.dataGrid.Columns[0].FilterRowCondition =  FilterRowCondition.LessThan;

{% endhighlight %}
{% endtabs %}





## Filtering null values

You can enable or disable filtering of null values by setting GridColumn.AllowBlankFilters property. The default value is true.
When null value filtering is enabled, the filter options loaded with two additional options (“Null” and “Not Null”) to filter the null values. ComboBox and MultiSelectComboBox editors, loads with “Blanks” item in drop down to filter the null values.

{% tabs %}
{% highlight XAML %}
<syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                            MappingName="CustomerID"
                            AllowBlankFilters="False"/>
{% endhighlight %}
{% highlight c# %}

this.dataGrid.Columns[0].AllowBlankFilters = false;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight XAML %}
<syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                MappingName="CustomerID"
                                AllowBlankFilters="True"
                                FilterRowEditorType="MultiSelectComboBox"/>
{% endhighlight %}
{% highlight c# %}

this.dataGrid.Columns[0].AllowBlankFilters = true;

{% endhighlight %}
{% endtabs %}



## Instant Filtering
By default, filters are applied to the columns when moving to other cells or pressing enter key. You can apply filter when typing or selecting in editor itself by setting [GridColumn.ImmediateUpdateColumnFilter](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridColumn.html#Syncfusion_UI_Xaml_Grid_GridColumn_ImmediateUpdateColumnFilter) as `true`. 
{% tabs %}
{% highlight xaml %}
<syncfusion:GridTextColumn MappingName="CustomerName"
                           FilterRowEditorType="MultiSelectComboBox"
                           ImmediateUpdateColumnFilter="True"/>
{% endhighlight %}
{% highlight c# %}
this.dataGrid.Columns[2].ImmediateUpdateColumnFilter = true;
{% endhighlight %}
{% endtabs %}


## Disable filtering for a particular FilterRowCell
By default, you can filter the records by editing filter row cell. You can disable this editing by using [CurrentCellBeginEdit](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html) event.
{% tabs %}
{% highlight c# %}
this.dataGrid.CurrentCellBeginEdit += DataGrid_CurrentCellBeginEdit;

private void DataGrid_CurrentCellBeginEdit(object? sender, DataGridCurrentCellBeginEditEventArgs e)
        {
            if (e?.Column?.MappingName == "CustomerID" && dataGrid.IsFilterRowIndex(e.RowColumnIndex.RowIndex))
                e.Cancel = true;
        }
{% endhighlight %}
{% endtabs %}

## Styling

### Filter row style
You can customize the style of filter row by writing style of TargetType [FilterRowControl](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.RowFilter.FilterRowControl.html).
{% tabs %}
{% highlight xaml %}
<Window.Resources>
    <Style TargetType="syncfusion:FilterRowControl">
        <Setter Property="Background" Value="BlanchedAlmond"/>
    </Style>
</Window.Resources>
{% endhighlight %}
{% endtabs %}
![Customizing Filter Row Style in WPF DataGrid](FilterRow_images/wpf-datagrid-filter-row-style.png)

### Filter row - cell style
You can customize the style of filter row cell by writing style of TargetType [DataGridFilterRowView]().

{% tabs %}
{% highlight xaml %}
    <ContentPage.Resources>
        <Style TargetType="syncfusion:DataGridFilterRowView">
            <Setter Property="Background" Value="BlanchedAlmond"/>
        </Style>
    </ContentPage.Resources>
{% endhighlight %}
{% highlight c# %}

public class FilterRowCellStyleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        var filterRowCell = value as GridFilterRowCell;
        if (filterRowCell == null) return null;

        if (filterRowCell.DataColumn.GridColumn.MappingName == "OrderID" ||
            filterRowCell.DataColumn.GridColumn.MappingName == "CustomerName")
            return new SolidColorBrush(Colors.LightBlue);

        return new SolidColorBrush(Colors.Honeydew);
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value;
    }
}
{% endhighlight %}
{% endtabs %}

## Customizing filter row cell
You can customize the filter row cell by FilterRowCellStyle.

{% tabs %}
{% highlight xaml %}

<syncfusion:DataGridNumericColumn HeaderText="Order ID" MappingName="OrderID" >
                    <syncfusion:DataGridNumericColumn.FilterRowCellStyle>
                        <Style TargetType="syncfusion:SfDataGridFilterRowLabel">
                            <Setter Property="TextColor" Value="Red" />
                        </Style>
                    </syncfusion:DataGridNumericColumn.FilterRowCellStyle>
                </syncfusion:DataGridNumericColumn>

{% endhighlight %}
{% endtabs %}

### Customizing filter options for particular columns 



## Customizing Filter row editors

### Customizing the filter row renderer 


### Filter based on numeric interval by using the multi select combobox filter


### Numeric filter row conditions for string typed column

## Customizing GridFilterRowMultiSelectRenderer 

By default, in SfDataGrid ComboBox is loaded while enter into edit mode in FilterRow but you can customize the [GridFilterRowMultiSelectRenderer](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.RowFilter.GridFilterRowMultiSelectRenderer.html) for display the combobox while FilterRow loading itself.

{% tabs %}
{% highlight xaml %}
<syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                                MappingName="CustomerID"
                                                FilterRowEditorType="MultiSelectComboBox"/>
{% endhighlight %}
{% highlight c# %}

            dataGrid.FilterRowCellRenderers.Remove("MultiSelectComboBox");
            dataGrid.FilterRowCellRenderers.Add("MultiSelectComboBox", new DataGridMultiSelectComboBoxRendererExt());

                public class DataGridMultiSelectComboBoxRendererExt : DataGridFilterRowMultiSelectRenderer
    {

        public DataGridMultiSelectComboBoxRendererExt() 
        {
            SupportsRenderOptimization = false;
            IsEditable = true;
        }


        /// <summary>
        /// Initialize the filter-row display with a live MultiSelect ComboBox instead of a label.
        /// </summary>
        protected override void OnInitializeDisplayView(DataColumnBase dataColumn, SfDataGridContentView? view)
        {
            InitializeComboBoxView(dataColumn, view);
        }
    }

{% endhighlight %}
{% endtabs %}

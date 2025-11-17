---
layout: post
title: Filter Row in .NET MAUI DataGrid | Syncfusion
description: Learn here all about FilterRow support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui filterrow, maui filterrow
---

# Filter Row in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) includes a built-in Filter Row designed for efficient record filtering. You can enable the FilterRow by specifying the position where it should be displayed by setting [SfDataGrid.FilterRowPosition]() property.

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

<img alt="MAUI DataGrid with Filter Row" src="Images\filterrow\maui-datagrid-filterrow-basic.png" width="404" />   

Retrieve the row index of the FilterRow using the [SfDataGrid.GetFilterRowIndex]() method.

{% tabs %}
{% highlight c# %}
int filterRowIndex = this.dataGrid.GetFilterRowIndex();
{% endhighlight %}
{% endtabs %}

Verify if a given row index corresponds to the FilterRow by utilizing the [SfDataGrid.IsFilterRowIndex]() helper method.

{% tabs %}
{% highlight c# %}
bool isFilterRowIndex = this.dataGrid.IsFilterRowIndex(1);
{% endhighlight %}
{% endtabs %}

## Built-in editors

The FilterRow automatically initializes editors that correspond to the underlying property type, simplifying data filtering. Customize these default editors by setting the `DataGridColumn.FilterRowEditorType` property.

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

<img alt="MAUI DataGrid Filter Row Cell with MultiSelect ComboBox" src="Images\filterrow\maui-datagrid-filterrow-multiselectcombobox.png" width="404" />   

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
<td> DataGridFilterRowTextBoxRenderer </td>
<td> Enables filtering for string data. </td>
</tr>
<tr>
<td> Numeric</td>
<td> SfNumericEntry </td>
<td> DataGridFilterRowNumericBoxRenderer </td>
<td> Facilitates filtering for numeric data.</td>
</tr>
<tr>
<td> ComboBox </td>
<td> SfComboBox </td>
<td> DataGridFilterRowComboBoxRenderer </td>
<td> Allows selection of a single value for filtering from a dropdown. </td>
</tr>
<tr>
<td> MultiSelectComboBox </td>
<td> SfComboBox </td>
<td> DataGridFilterRowMultiSelectRenderer </td>
<td> Permits selection of multiple values for filtering from a dropdown. </td>
</tr>
<tr>
<td> CheckBox </td>
<td> SfCheckBox </td>
<td> DataGridFilterRowCheckBoxRenderer </td>
<td> Supports filtering of Boolean data. </td>
</tr>
<tr>
<td> DateTime </td>
<td> DatePicker </td>
<td> DataGridFilterRowDateRenderer </td>
<td> Provides filtering capabilities for DateTime data. </td>
</tr>
</table>

## Filter options

The FilterRowCell presents filter conditions in a dropdown menu, categorized by editor type, allowing for easy switching between conditions to refine data. To disable these filter options, set the `DataGridColumn.FilterRowOptionsVisibility` property.

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

<img alt="MAUI DataGrid with Filter Row" src="Images\filterrow\maui-datagrid-filterrow-style-filterrowoptionsvisibility.png" width="404" />   

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
<td> The numeric editor is utilized in <code>DataGridFilterRowCell</code> when integer, double, short, decimal, byte, or long data types are bound to the <code>DataGridColumn.FilterRowEditorType</code>. </td>
<td> The text editor is employed in <code>DataGridFilterRowCell</code> for string-bound <code>DataGridColumn</code> values or dynamic item sources. </td>
<td> For <code>DataGridColumn</code> entries with datetime data types, the datetime editor is loaded into the <code>DataGridFilterRowCell</code>. </td>
<td> When a boolean type is bound to the <code>DataGridColumn</code>, the checkbox editor is automatically loaded in the <code>DataGridFilterRowCell</code>. </td>
<td> To use comboBox and MultiSelectComboBox editors, the FilterRowEditorType property must be explicitly set. </td>
</tr>
<tr>
<td>The default numeric filter condition is <code>Equals</code>. Additional available conditions include:
<ol>
<li>Equals</li>
<li>Does Not Equal</li> 
<li>Null</li> 
<li>Not Null</li> 
<li>Less Than</li>
<li>Less Than or Equal</li>
<li>Greater Than</li>
<li>Greater Than or Equal</li>
</ol></td>
<td>The default text filter condition is <code>Contains</code>. Other available conditions include:
<ol>
<li>Equals</li>
<li>Does Not Equal</li> 
<li>Null</li> 
<li>Not Null</li> 
<li>Begins With</li>
<li>Does Not Begin With</li>
<li>Ends With</li>
<li>Does Not End With</li>
<li>Contains</li>
<li>Does Not Contain</li>
<li>Empty</li>
<li>Not Empty</li> 
</ol></td>
<td>The default <code>DateTime</code> filter condition is <code>Equal</code>. Additional conditions provided are:
<ol>
<li>Equals</li>
<li>Does Not Equal</li>
<li>Null</li>
<li>Not Null</li>
<li>Before</li>
<li>Before or Equal</li>
<li>After</li>
<li>After or Equal</li>
</ol></td>
<td>For checkbox values, the <code>Equals</code> filter condition is always applied.</td>
<td></td>
</tr>
</table>

Modify the default FilterRow condition for any specific column using the `DataGridColumn.FilterRowCondition` property.

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

Control the inclusion of null values in filtering by configuring the `DataGridColumn.AllowBlankFilters` property, which is true by default. When active, filter options display `Null` and `Not Null` choices, and ComboBox editors include a `Blanks` option for null value filtering.

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

<img alt="Filter Row without Null option in MAUI DataGrid" src="Images\filterrow\maui-datagrid-filterrow-allowblankfilters.png" width="404" />   

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

<img alt="Filter Row with Null option in MAUI DataGrid" src="Images\filterrow\maui-datagrid-filterrow-multiselectblankfilters.png" width="404" />   

## Instant filtering
Filters are typically applied to columns upon cell navigation or pressing the Enter key. However, by setting [DataGridColumn.ImmediateUpdateColumnFilter]() to `true`, you can enable instant filtering as you type within the editor.
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


## Disable filtering for a particular cell
While filter row cells are editable by default for record filtering, you can prevent editing for a specific cell using the [CurrentCellBeginEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentCellBeginEdit) event.
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

### Apply default style

You can customize the basic styling of the FilterRow in SfDataGrid using the DefaultStyle property. This approach allows you to modify attributes such as `FilterRowFontAttributes`, `FilterIconHoverBackground`, `FilterRowBackground`, `FilterRowFontFamily`, `FilterRowFontSize`, and `FilterRowTextColor`.

{% tabs %}
{% highlight xaml %}

            <syncfusion:SfDataGrid.DefaultStyle>
                <syncfusion:DataGridStyle FilterRowFontAttributes="Bold" FilterIconHoverBackground="AliceBlue" FilterRowBackground="Yellow" FilterRowTextColor="CadetBlue" FilterRowFontSize="10" />
            </syncfusion:SfDataGrid.DefaultStyle>
{% endhighlight %}
{% endtabs %}

### Filter row style
Customize the appearance of the filter row by defining a style with TargetType [DataGridFilterRowView].
{% tabs %}
{% highlight xaml %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:DataGridFilterRowView">
        <Setter Property="Background" Value="Red"/>
    </Style>
</ContentPage.Resources>
{% endhighlight %}
{% endtabs %}

<img alt="Customizing Filter Row Style in MAUI DataGrid" src="Images\filterrow\maui-datagrid-filterrow-style.png" width="404" />  

### Customizing filter row cell
Further customize the filter row cell's appearance through the `FilterRowCellStyle` property.

{% tabs %}
{% highlight xaml %}

<syncfusion:DataGridNumericColumn HeaderText="Order ID" MappingName="OrderID" >
                    <syncfusion:DataGridNumericColumn.FilterRowCellStyle>
                            <Style TargetType="syncfusion:DataGridFilterRowCell">
                                <Setter Property="Background" Value="CornflowerBlue" />
    </Style>
                    </syncfusion:DataGridNumericColumn.FilterRowCellStyle>
                </syncfusion:DataGridNumericColumn>

{% endhighlight %}
{% endtabs %}

<img alt="Customizing Filter Row Cell Style in MAUI DataGrid" src="Images\filterrow\maui-datagrid-filterrow-cellstyle.png" width="404" />  

## Customizing filter row editors

### Customizing the filter row renderer

[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) allows you to customize the filter row renderer behavior by overriding the corresponding renderer associated with the filter row cell. Each renderer have a set of virtual methods for handling the filter row behaviors. You can also create new renderers instead of overriding the existing renderer.
You can customize the default TextBox editor behavior by overriding `DataGridFilterRowTextBoxRenderer` class and add the custom renderer to `FilterRowCellRenderers`.

{% tabs %}
{% highlight xaml %}
                <syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                                MappingName="CustomerID" FilterRowEditorType="CustomTextBox"/>
{% endhighlight %}
{% highlight c# %}
        public MainPage()
        {
            InitializeComponent();

            this.dataGrid.FilterRowCellRenderers.Add("CustomTextBox", new CustomDataGridFilterRowTextBoxRenderer());
        }

            public class CustomDataGridFilterRowTextBoxRenderer : DataGridFilterRowTextBoxRenderer
    {
        public CustomDataGridFilterRowTextBoxRenderer(): base() 
        {
        }
    }
{% endhighlight %}
{% endtabs %}

### Filter based on numeric interval by using the multi select combobox filter

By default, columns support filtering multiple values using the MultiSelectComboBox filter editor type. To filter data based on a range of numeric values, you can override the PopulateComboBoxItems and GetFilterPredicates methods within the DataGridFilterRowComboBoxRenderer class, as demonstrated in the code below.

{% tabs %}
{% highlight xaml %}
                <syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                                MappingName="CustomerID" FilterRowEditorType="CustomComboBox"/>
{% endhighlight %}
{% highlight c# %}
        public MainPage()
        {
            InitializeComponent();

            this.dataGrid.FilterRowCellRenderers.Add("CustomComboBox", new CustomDataGridFilterRowComboBoxRenderer());
        }

        public class CustomDataGridFilterRowComboBoxRenderer : DataGridFilterRowComboBoxRenderer , INotifyPropertyChanged
{
    private List<string>? numericComboBoxItems;

    public event PropertyChangedEventHandler? PropertyChanged;

    private string selectedText = string.Empty;

    public CustomDataGridFilterRowComboBoxRenderer() 
    {
        SetNumericComboBoxItemsList();
    }

    /// <summary>
    /// Generate the Items for NumericComboBox
    /// </summary>
    /// <returns></returns>

    public void SetNumericComboBoxItemsList()
    {
        numericComboBoxItems = new List<string>();
        numericComboBoxItems.Add("Between 1 and 5");
        numericComboBoxItems.Add("Between 5 and 10");
        numericComboBoxItems.Add("Between 10 and 20");
        numericComboBoxItems.Add("Between 1000 and 1005");
        numericComboBoxItems.Add(">40");
    }

    /// <summary>
    /// Gets filter predicates based on selected values.
    /// </summary>
    public override List<FilterPredicate> GetFilterPredicates(object? filterValue)
    {
        var predicates = new List<FilterPredicate>();
        var filterMode = ColumnFilter.Value;

        if (filterValue == null)
            return predicates;

        if (filterValue is string text)
        {
            selectedText = text;

            text = text.Trim();

            if (text.StartsWith("Between", StringComparison.OrdinalIgnoreCase))
            {
                var remainder = text.Substring(7).Trim(); 

                var parts = remainder.Split(new[] { "and" }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2 && TryParseDouble(parts[0], out var minVal) &&  TryParseDouble(parts[1], out var maxVal))
                {
                    predicates.Add(new FilterPredicate
                    {
                        FilterType = FilterType.GreaterThanOrEqual,
                        PredicateType = PredicateType.And,
                        FilterMode = filterMode,
                        FilterValue = minVal
                    });
                    predicates.Add(new FilterPredicate
                    {
                        FilterType = FilterType.LessThanOrEqual,
                        PredicateType = PredicateType.And,
                        FilterMode = filterMode,
                        FilterValue = maxVal
                    });
                    return predicates;
                }
            }

            if ((text.StartsWith(">=") || text.StartsWith(">") || text.StartsWith("<=") || text.StartsWith("<")))
            {
                FilterType? type = null;
                string numberPart = string.Empty;

                if (text.StartsWith(">="))
                {
                    type = FilterType.GreaterThanOrEqual;
                    numberPart = text.Substring(2);
                }
                else if (text.StartsWith(">"))
                {
                    type = FilterType.GreaterThan;
                    numberPart = text.Substring(1);
                }
                else if (text.StartsWith("<="))
                {
                    type = FilterType.LessThanOrEqual;
                    numberPart = text.Substring(2);
                }
                else if (text.StartsWith("<"))
                {
                    type = FilterType.LessThan;
                    numberPart = text.Substring(1);
                }

                if (type.HasValue && TryParseDouble(numberPart, out var value))
                {
                    predicates.Add(new FilterPredicate
                    {
                        FilterType = type.Value,
                        PredicateType = PredicateType.And,
                        FilterMode = filterMode,
                        FilterValue = value
                    });
                    return predicates;
                }
            }

            predicates.Add(new FilterPredicate
            {
                FilterType = FilterType.Equals,
                PredicateType = PredicateType.And,
                FilterMode = filterMode,
                FilterValue = text
            });
            return predicates;
        }

        predicates.Add(new FilterPredicate
        {
            FilterType = FilterType.Equals,
            PredicateType = PredicateType.And,
            FilterMode = filterMode,
            FilterValue = filterValue
        });
        return predicates;
    }

    private static bool TryParseDouble(string input, out double value)
    {
        input = (input ?? string.Empty).Trim();
        return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out value) ||
               double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out value);
    }

    protected override void PopulateComboBoxItems(SfComboBox comboBox, DataGridColumn column) 
    {
        var modifiedItemsSource = new ObservableCollection<object>();

        foreach (var item in numericComboBoxItems)
        {
            modifiedItemsSource.Add(item);
        }
        comboBox.ItemsSource = modifiedItemsSource;
    }

    protected override void UpdateDisplayText(SfDataGridFilterRowLabel label, DataGridColumn column)
    {
        base.UpdateDisplayText(label, column);

        label.Text = selectedText;
    }

}

{% endhighlight %}
{% endtabs %}

<img alt="Customizing Filter Row in MAUI DataGrid" src="Images\filterrow\maui-datagrid-filterrow-customnumericrenderer.png" width="404" />  

## Customizing DataGridFilterRowMultiSelectRenderer

By default, the `SfDataGrid` loads a `ComboBox` when the `FilterRow` enters edit mode. However, you can tailor the `DataGridFilterRowMultiSelectRenderer` to ensure the `ComboBox` is visible immediately upon `FilterRow` initialization.

{% tabs %}
{% highlight xaml %}
<syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                                MappingName="CustomerID"
                                                FilterRowEditorType="MultiSelectComboBox"/>
{% endhighlight %}
{% highlight c# %}

            dataGrid.FilterRowCellRenderers.Remove("MultiSelectComboBox");
            dataGrid.FilterRowCellRenderers.Add("MultiSelectComboBox", new CustomDataGridMultiSelectComboBoxRenderer());

                public class CustomDataGridMultiSelectComboBoxRenderer : DataGridFilterRowMultiSelectRenderer
    {

        public CustomDataGridMultiSelectComboBoxRenderer() 
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

<img alt="Customizing Filter Row in MAUI DataGrid" src="Images\filterrow\maui-datagrid-filterrow-custommultiselect.png" width="404" />  
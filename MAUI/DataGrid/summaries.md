---
layout: post
title: Summaries in MAUI DataGrid control | Syncfusion
description: Learn here all about Summaries support in Syncfusion MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Summaries in MAUI DataGrid (SfDataGrid)

The data grid supports to display the concise information about the bound data objects using summaries. The control provides the following summary types:

* **Table Summary** - Used to display the summary information at top and/or bottom in SfDataGrid.


![DataGrid with summary rows](Images\Table-Summary\ShowSummaryInRow.png) 

Summary rows are represented by using the [DataGridSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html) that hold summary information of columns in the [SummaryColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_SummaryColumns) property . The `SummaryColumns` contains the collection of [DataGridSummaryColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html) which carries name, format, and summary aggregate type of the column.

Derive additional information from the data like sum, average, maximum, minimum, and count using summaries in the data grid. These summary values can be computed for groups or for the entire control using `DataGridSummaryRow` and `DataGridSummaryColumn` that implements [ISummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISummaryRow.html) and [ISummaryColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISummaryColumn.html) interfaces.

N> The Summary does not refresh with data. To update the summary for the newly added row, or for the modified summary column, set the [SfDataGrid.View.LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.LiveDataUpdateMode.html) to `LiveDataUpdateMode.AllowDataShaping` or `LiveDataUpdateMode.AllowSummaryUpdate`.

## Table summaries

The data grid provides built-in support for table summaries. The table summary value is calculated based on all records in the control.

You can add table summary row in the data grid by adding the [DataGridTableSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryRow.html) to the [SfDataGrid.TableSummaryRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_TableSummaryRows) collection.

The following screenshot illustrates table summary rows in the data grid:

![DataGrid with table summary](Images\Table-Summary\Summary.png)

{% tabs %}
{% highlight xaml%}
<sfGrid:SfDataGrid.TableSummaryRows>
    <sfGrid:DataGridTableSummaryRow Title="Total Salary :{TotalSalary} for {ProductCount} members"
                                Position="Top"
                                ShowSummaryInRow="True">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TotalSalary"
                                      Format="{}{Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
            <sfGrid:DataGridSummaryColumn Name="ProductCount"
                                      Format="{}{Count}"
                                      MappingName="Salary"
                                      SummaryType="CountAggregate" />
            </sfGrid:DataGridTableSummaryRow.SummaryColumns>
        </sfGrid:DataGridTableSummaryRow>
    <sfGrid:DataGridTableSummaryRow Position="Top" ShowSummaryInRow="False">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TotalSalary"
                                      Format="{}{Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
            </sfGrid:DataGridTableSummaryRow.SummaryColumns>
        </sfGrid:DataGridTableSummaryRow>
</sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c#%}
DataGridTableSummaryRow summaryRow1 = new DataGridTableSummaryRow();
summaryRow1.Title = "Total Salary:{TotalSalary} for {ProductCount} members";
summaryRow1.ShowSummaryInRow = true;
summaryRow1.Position = Position.Top;
summaryRow1.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TotalSalary",
    MappingName = "Salary",
    Format = "{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
summaryRow1.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "ProductCount",
    MappingName = "Salary",
    Format = "{Count}",
    SummaryType = SummaryType.CountAggregate
});
sfGrid.TableSummaryRows.Add(summaryRow1);

DataGridTableSummaryRow summaryRow2 = new DataGridTableSummaryRow();
summaryRow2.ShowSummaryInRow = false;
summaryRow2.Position = Position.Top;
summaryRow2.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TotalSalary",
    MappingName = "Salary",
    Format = "{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
sfGrid.TableSummaryRows.Add(summaryRow2);
{% endhighlight %}
{% endtabs %}

![DataGrid with table summary](Images\Table-Summary\TableSummary.png)

### Displaying summary in a row

Display summary information in a row by setting the [DataGridTableSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) to `true` and define summary columns. You have to define the [DataGridTableSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) based on the [DataGridSummaryColumn.Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Name) property to format summary columns values in a row.

{% tabs %}
{% highlight xaml%}
<sfGrid:SfDataGrid.TableSummaryRows>
    <sfGrid:DataGridTableSummaryRow Title="Total Salary :{TotalSalary} for {ProductCount} members"
                                ShowSummaryInRow="True">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TotalSalary"
                                      Format="{}{Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
            <sfGrid:DataGridSummaryColumn Name="ProductCount"
                                      Format="{}{Count}"
                                      MappingName="Salary"
                                      SummaryType="CountAggregate" />
            </sfGrid:DataGridTableSummaryRow.SummaryColumns>
        </sfGrid:DataGridTableSummaryRow>
</sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c#%}
DataGridTableSummaryRow summaryRow = new DataGridTableSummaryRow();
summaryRow.Title = "Total Salary:{TotalSalary} for {ProductCount} members";
summaryRow.ShowSummaryInRow = true;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TotalSalary",
    MappingName = "Salary",
    Format = "{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "ProductCount",
    MappingName = "Salary",
    Format = "{Count}",
    SummaryType = SummaryType.CountAggregate
});
sfGrid.TableSummaryRows.Add(summaryRow);
{% endhighlight %}
{% endtabs %}

The following screenshot shows the table summary row if `ShowSummaryInRow` is `true`:

![DataGrid with customized table summary for entire row](Images\Table-Summary\ShowSummaryInRow.png)

### Displaying summary in a column

Display summary information in a column by setting `DataGridTableSummaryRow.ShowSummaryInRow` to `false` and defining summary columns. `DataGridSummaryColumn` is the object of [DataGridTableSummaryRow.SummaryColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_SummaryColumns) collection that contains the following important properties:

* [Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_Name): Defines name of the `DataGridSummaryColumn` to denote the `DataGridSummaryColumn` in `DataGridTableSummaryRow` with title.
* [MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_MappingName): Defines the corresponding column name for the summary calculation.
* [SummaryType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_SummaryType): Defines the `SummaryType` (enum) property to define the aggregate type for the summary calculation. 

The data grid control provides the following predefined aggregates:

  * CountAggregate
  * Int32Aggregate
  * DoubleAggregate

[CustomAggregate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_CustomAggregate) defines the `CustomAggregate` class object when the summary type is set as `Custom` that calculates custom summaries.

The [Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_Format) defines the `string` property that formats the summary value and displays it. The `Format` property may contains two parts that are separated by a colon (:). First part denotes the aggregate function name, and second part denotes display format of the summary value.

Refer to the [Formatting Summary](#_Formatting_Summary) section to know more about how to format summary and [Aggregate Types](#_Aggregate_Types) section to know about different summary types.

In the following code snippet, summary is defined for `Salary` column:

{% tabs %}
{% highlight xaml%}
<sfGrid:SfDataGrid.TableSummaryRows>
    <sfGrid:DataGridTableSummaryRow Name="TableSummary" ShowSummaryInRow="False">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TableSummary"
                                      Format="{}{Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
        </sfGrid:DataGridTableSummaryRow.SummaryColumns>
    </sfGrid:DataGridTableSummaryRow>
</sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c#%}
DataGridTableSummaryRow summaryRow = new DataGridTableSummaryRow();
summaryRow.ShowSummaryInRow = false;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TableSummary",
    MappingName = "Salary",
    Format = "{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
sfGrid.TableSummaryRows.Add(summaryRow);
{% endhighlight c#%}
{% endtabs %}

The following screenshot shows the table summary row if `ShowSummaryInRow` is `false`.

![DataGrid with customized table summary for individual cells](Images\Table-Summary\ShowSummaryInColumn.png)

### Positioning TableSummaryRows

The data grid add table summary rows either at top or bottom positions using the [DataGridTableSummaryRow.Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridTableSummaryRow_Position) property.

{% tabs %}
{% highlight xaml%}
<sfGrid:SfDataGrid.TableSummaryRows>
    <sfGrid:DataGridTableSummaryRow Position="Top"
                                ShowSummaryInRow="False">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TotalSalary"
                                      Format="{}{Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
            </sfGrid:DataGridTableSummaryRow.SummaryColumns>
        </sfGrid:DataGridTableSummaryRow>
    <sfGrid:DataGridTableSummaryRow Position="Bottom"
                                ShowSummaryInRow="True"
                                Title="Total Salary :{TotalSalary} for {ProductCount} members">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TotalSalary"
                                      Format="{}{Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
            <sfGrid:DataGridSummaryColumn Name="ProductCount"
                                      Format="{}{Count}"
                                      MappingName="Salary"
                                      SummaryType="CountAggregate" />
        </sfGrid:DataGridTableSummaryRow.SummaryColumns>
    </sfGrid:DataGridTableSummaryRow>
</sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c#%}
DataGridTableSummaryRow topSummaryRow = new DataGridTableSummaryRow();
topSummaryRow.Position = Position.Top;
topSummaryRow.ShowSummaryInRow = false;
topSummaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TotalSalary",
    MappingName = "Salary",
    Format = "{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
sfGrid.TableSummaryRows.Add(topSummaryRow);

DataGridTableSummaryRow bottomSummaryRow = new DataGridTableSummaryRow();
bottomSummaryRow.Position = Position.Bottom;
bottomSummaryRow.Title = "Total Salary:{TotalSalary} for {ProductCount} members";
bottomSummaryRow.ShowSummaryInRow = true;
bottomSummaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TotalSalary",
    MappingName = "Salary",
    Format = "{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
bottomSummaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "ProductCount",
    MappingName = "Salary",
    Format = "{Count}",
    SummaryType = SummaryType.CountAggregate
});
sfGrid.TableSummaryRows.Add(bottomSummaryRow);
{% endhighlight %}
{% endtabs %}

The below screenshot illustrates the positioning of table summary rows in SfDataGrid.

![Customizing table summary row position in a DataGrid](Images\Table-Summary\Summary.png)

## Table summary template

The data grid hosts any view(s) inside a table summary for the entire row or for individual columns by loading a template.

### Displaying template for a row

The template for a table summary row can be set by using [SfDataGrid.TableSummaryTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_TableSummaryTemplate) and it can be customized based on the requirement.

Refer the below code example in which a label is loaded in the table summary template of table summary row.

{% tabs %}
{% highlight xaml %}

 <ContentPage.Resources>
        <ResourceDictionary>
            <local:TableSummaryConverter x:Key="SummaryConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <StackLayout>
        <sfgrid:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrdersInfo}"
                           AutoGenerateColumns="False"
                           AllowEditing="True"
                           NavigationMode="Cell"
                           SelectionMode="Single"
                           ColumnSizer="Star">
            <sfgrid:SfDataGrid.Columns>
                <sfgrid:GridNumericColumn MappingName="OrderID" />
                <sfgrid:GridTextColumn MappingName="EmployeeID" />
                <sfgrid:GridTextColumn MappingName="FirstName"  />
                <sfgrid:GridTextColumn MappingName="LastName"  />
            </sfgrid:SfDataGrid.Columns>
            <sfgrid:SfDataGrid.TableSummaryTemplate>
                <DataTemplate>
                        <StackLayout Orientation="Horizontal" BackgroundColor="Gray">
                            <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter = {x:Reference dataGrid} }"
                                   TextColor="White"
                                   FontSize="Large"
                                   VerticalTextAlignment="Center"
                                   HorizontalTextAlignment="Start"
                                   LineBreakMode="NoWrap"
                                   HorizontalOptions="FillAndExpand"
                                   VerticalOptions="FillAndExpand">
                                <Label.Style>
                                    <Style TargetType="Label">
                                        <Setter Property="FontAttributes" Value="Italic" />
                                    </Style>
                                </Label.Style>
                            </Label>
                        </StackLayout>
                </DataTemplate>
            </sfgrid:SfDataGrid.TableSummaryTemplate>
            <sfgrid:SfDataGrid.TableSummaryRows>
                <sfgrid:DataGridTableSummaryRow Title="Total Salary :{TotalSalary} for {ProductCount} members"
                                            Position="Bottom"
                                            ShowSummaryInRow="True">
                    <sfgrid:DataGridTableSummaryRow.SummaryColumns>
                        <sfgrid:DataGridSummaryColumn Name="TotalSalary"
                                                  Format="{}{Sum:C0}"
                                                  MappingName="Salary"
                                                  SummaryType="DoubleAggregate" />
                    </sfgrid:DataGridTableSummaryRow.SummaryColumns>
                </sfgrid:DataGridTableSummaryRow>
            </sfgrid:SfDataGrid.TableSummaryRows>
        </sfgrid:SfDataGrid>
    </StackLayout>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

 public class TableSummaryConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var data = value != null ? value as SummaryRecordEntry : null;
        if (data != null)
        {
            SfDataGrid dataGrid = (SfDataGrid)parameter;
            var summaryText = SummaryCreator.GetSummaryDisplayText(data, "Salary", dataGrid.View);
            return "Total Value:" + " " + summaryText.ToString();
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}

{% endhighlight %}
{% endtabs %}

![Table summary template in a row](Images\Table-Summary\TemplateRow.png)

### Displaying template for a column

The template for a table summary column can be set by using `DataGridSummaryColumn.Template` and it can be customized based on the requirement.

Refer the below code example in which a label is loaded in the template of table summary column.

{% tabs %}
{% highlight xaml%}

<ContentPage.Resources>
        <ResourceDictionary>
            <local:TableSummaryConverter x:Key="SummaryConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <StackLayout>
        <sfgrid:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrdersInfo}"
                           AutoGenerateColumns="False"
                           AllowEditing="True"
                           NavigationMode="Cell"
                           SelectionMode="Single"
                           ColumnSizer="Star">
            <sfgrid:SfDataGrid.Columns>
                <sfgrid:GridNumericColumn MappingName="OrderID" />
                <sfgrid:GridTextColumn MappingName="EmployeeID" />
                <sfgrid:GridTextColumn MappingName="FirstName" />
                <sfgrid:GridTextColumn MappingName="LastName" />
            </sfgrid:SfDataGrid.Columns>
            <sfgrid:SfDataGrid.TableSummaryRows>
                <sfgrid:DataGridTableSummaryRow Title="Total Salary :{TotalSalary} for {ProductCount} members"
                                            Position="Bottom"
                                            ShowSummaryInRow="False">
                        <sfgrid:DataGridTableSummaryRow.SummaryColumns>
                            <sfgrid:DataGridSummaryColumn Name="TotalSalary"
                                                      Format="{}{Sum:C0}"
                                                      MappingName="Salary"
                                                      SummaryType="DoubleAggregate" >
                                <sfgrid:DataGridSummaryColumn.Template>
                                 <DataTemplate>
                                    <StackLayout Orientation="Horizontal" BackgroundColor="Gray">
                                        <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter = {x:Reference dataGrid} }"
                                               TextColor="White"
                                               FontSize="Medium"
                                               VerticalTextAlignment="Center"
                                               HorizontalTextAlignment="Start"
                                               LineBreakMode="NoWrap"
                                               HorizontalOptions="FillAndExpand"
                                               VerticalOptions="FillAndExpand">
                                            <Label.Style>
                                                <Style TargetType="Label">
                                                    <Setter Property="FontAttributes" Value="Italic" />
                                                </Style>
                                            </Label.Style>
                                        </Label>
                                    </StackLayout>
                                 </DataTemplate>
                                </sfgrid:DataGridSummaryColumn.Template>
                            </sfgrid:DataGridSummaryColumn>
                        </sfgrid:DataGridTableSummaryRow.SummaryColumns>
                    </sfgrid:DataGridTableSummaryRow>
            </sfgrid:SfDataGrid.TableSummaryRows>            
        </sfgrid:SfDataGrid>
    </StackLayout>

{% endhighlight%}
{% endtabs %}

{% tabs %}
{% highlight c# %}

// To write a converter, follow the code example:

  public class TableSummaryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value != null ? value as SummaryRecordEntry : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                var summaryText = SummaryCreator.GetSummaryDisplayText(data, "Salary", dataGrid.View);

                return summaryText.ToString();
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }    
    }
{% endhighlight %}
{% endtabs %}

![Table summary template in a column](Images\Table-Summary\TemplateColumn.png)

N> The `DataTemplateSelector` can also be directly assigned to the `SfDataGrid.TableSummaryTemplate`.

## Formatting summary

In the following sections, the formatting is explained using the `TableSummary`.

### Formatting summary value

Format the summary value by setting the appropriate format after the aggregate function followed by a colon(:) in the `DataGridSummaryColumn.Format` property.

In the following code snippet `Salary` column summary is formatted using `C0` format specifier. Refer to [here](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings?redirectedfrom=MSDN) to know about how to set different formats.

{% tabs %}
{% highlight xaml%}
<sfGrid:SfDataGrid.TableSummaryRows>
    <sfGrid:DataGridTableSummaryRow ShowSummaryInRow="False">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TableSummary"
                                      Format="{}{Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
        </sfGrid:DataGridTableSummaryRow.SummaryColumns>
    </sfGrid:DataGridTableSummaryRow>
</sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c#%}
DataGridTableSummaryRow summaryRow = new DataGridTableSummaryRow();
summaryRow.ShowSummaryInRow = false;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TableSummary",
    MappingName = "Salary",
    Format = "{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
sfGrid.TableSummaryRows= summaryRow;
{% endhighlight %}
{% endtabs %}

![Formatting summary value in a DataGrid](Images\Table-Summary\ShowSummaryInColumn.png)


### Displaying additional content in summary

Append additional content with summary value using the `DataGridSummaryColumn.Format` property.

In the following code snippet `Total:` text is appended before summary value:

{% tabs %}
{% highlight xaml%}
<sfGrid:SfDataGrid.TableSummaryRows>
    <sfGrid:DataGridTableSummaryRow ShowSummaryInRow="False">
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TableSummary"
                                      Format="Total: {Sum:C0}"
                                      MappingName="Salary"
                                      SummaryType="DoubleAggregate" />
        </sfGrid:DataGridTableSummaryRow.SummaryColumns>
    </sfGrid:DataGridTableSummaryRow>
</sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c#%}
DataGridTableSummaryRow summaryRow = new DataGridTableSummaryRow();
summaryRow.ShowSummaryInRow = false;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TableSummary",
    MappingName = "Salary",
    Format = "Total:{Sum:C0}",
    SummaryType = SummaryType.DoubleAggregate
});
sfGrid.TableSummaryRows= summaryRow;
{% endhighlight %}
{% endtabs %}

![Displaying additional content in summary in a DataGrid](Images\Table-Summary\AdditionalContent.png)

## Aggregate types

Specify different summary aggregate types by using the [DataGridSummaryColumn.SummaryType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_SummaryType) property, and use the built-in function in [DataGridSummaryColumn.Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_Format).

List of predefined aggregate types and its built-in functions are as follows:

<table>
<tr>
<th>
Aggregate Type
</th>
<th>
Built-in function
</th>
</tr>
<tr>
<td>
CountAggregate
</td>
<td>
Count
</td>
</tr>
<tr>
<td>
Int32Aggregate
</td>
<td>
Count, max, min, average, and sum.
</td>
</tr>
<tr>
<td>
DoubleAggregate
</td>
<td>
Count, max, min, average, and sum.
</td>
</tr>
<tr>
<td>
Custom
</td>
<td>
Used for custom summaries
</td>
</tr>
</table>

N> The above aggregate types can be applied for `TableSummaries`.

## Custom summaries

The data grid implements your own aggregate functions when the built-in aggregate functions do not meet your requirement.

Summary values can be calculated based on custom logic using the [DataGridSummaryColumn.CustomAggregate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_CustomAggregate) property.

### Implementing custom aggregate

1. Create a custom aggregate class by deriving from [ISummaryAggregate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISummaryAggregate.html) interface.
2. In the `CalculateAggregateFunc()` method, you have to calculate the summary and assign it to the property.

In the following code snippet, `Standard Deviation` is calculated for quantity of products:

{% tabs %}
{% highlight c#%}
public class CustomAggregate : ISummaryAggregate
{
    public CustomAggregate()
    {
    }
    public double StdDev { get; set; }
    public Action<System.Collections.IEnumerable, string, System.ComponentModel.PropertyDescriptor> CalculateAggregateFunc()
    {
        return (items, property, pd) =>
        {
            var enumerableItems = items as IEnumerable<OrderInfo>;
            if (pd.Name == "StdDev")
            {
                this.StdDev = enumerableItems.StdDev<OrderInfo>(q => q.OrderID);
            }
        };
    }
}

public static class LinqExtensions
{
    public static double StdDev<T>(this IEnumerable<T> values, Func<T, double?> selector)
    {
        double value = 0;
        var count = values.Count();
        if (count > 0)
        {
            double? avg = values.Average(selector);
            double sum = values.Select(selector).Sum(d =>
            {
                if (d.HasValue)
                {
                    return Math.Pow(d.Value - avg.Value, 2);
                }
                return 0.0;
            });
            value = Math.Sqrt((sum) / (count - 1));
        }
        return value;
    }
}
{% endhighlight %}
{% endtabs %}

Assign the custom aggregate to `DataGridSummaryColumn.CustomAggregate` property and set the `SummaryType` as `Custom`. `DataGridSummaryColumn.Format` property is defined based on property name in custom aggregate `StdDev`.

{% tabs %}
{% highlight xaml%}
<sfGrid:SfDataGrid.TableSummaryRows>
    <sfGrid:DataGridTableSummaryRow Title="Standard Deviation:{TableSummary}" ShowSummaryInRow = "True">                                                     
        <sfGrid:DataGridTableSummaryRow.SummaryColumns>
            <sfGrid:DataGridSummaryColumn Name="TableSummary"
                                      CustomAggregate="{StaticResource customAggregate}"
                                      Format="{}{StdDev}"
                                      MappingName="OrderID"
                                      SummaryType="Custom" />
        </sfGrid:DataGridTableSummaryRow.SummaryColumns>
    </sfGrid:DataGridTableSummaryRow>
</sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c#%}
DataGridTableSummaryRow summaryRow = new DataGridTableSummaryRow();
summaryRow.Title = "Standard Deviation:{TableSummary}";
summaryRow.ShowSummaryInRow = true;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn
{
    Name = "TableSummary",
    CustomAggregate  = new CustomAggregate(),
    MappingName = "OrderID",
    Format = "{StdDev}",
    SummaryType = Syncfusion.Data.SummaryType.Custom
});
dataGrid.TableSummaryRows = summaryRow;
{% endhighlight %}
{% endtabs %}

![DataGrid with custom aggregate](Images\Table-Summary\CustomAggregate.png)

N> The above custom summaries section is explained using `TableSummary`.

## Overriding summary renderer

Each summary cell in the data grid is associated with its own cell renderer. The data grid allows to extend this renderer to customize the grid cells based on your requirement. Customization can be applied by overriding the available virtual methods in the each cell renderer.

Each summary has a specific key using which the custom summary renderer can be registered to the [SfDataGrid.CellRenderers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellRenderers) collection. Remove the key from collection and add a new entry with the same key along with the instance of custom renderer to register.

<table>

<tr>
<th>Types of summary</th>
<th>Renderer</th>
<th>Key</th>
</tr>

<tr>
<td>Table summary</td>
<td><a href="">DataDataGridTableSummaryCellRenderer</a> </td>
<td>TableSummary</td>
</tr>


</table>

### Customizing table summary

The data grid allows customizing the table summary by extending the [DataGridTableSummaryCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryCellRenderer.html) class.


To customize the table summary, follow the code example:

{% tabs %}
{% highlight c#%}

// To remove default summary and Add custom summary.

public class Summary : ContentPage
{
    public Summary()
    {
        InitializeComponent();
        dataGrid.CellRenderers.Remove("TableSummary");
        dataGrid.CellRenderers.Add("TableSummary", new DataDataGridTableSummaryCellRendererExt());
    }
}

public class DataDataGridTableSummaryCellRendererExt : DataDataGridTableSummaryCellRenderer
{
    public DataDataGridTableSummaryCellRendererExt()
    {
    }

    protected override void OnInitializeDisplayView(DataColumnBase dataColumn, Label view)
    {
        base.OnInitializeDisplayView(dataColumn, view);
        view.HorizontalTextAlignment = TextAlignment.Start;
        view.BackgroundColor = Color.DarkCyan;
        view.FontSize = 16;
        view.TextColor = Color.White;

    }
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the final outcome upon execution of the above code.

![Customize table summary using custom cell renderer](Images\Table-Summary\CustomizingTableSummary.png)
---
layout: post
title: Summaries in MAUI DataGrid control | Syncfusion®
description: Learn here all about Summaries support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui summaries, maui summaries
---

# Summaries in MAUI DataGrid (SfDataGrid)

The data grid supports to display the concise information about the bound data objects using summaries. The control provides the following summary types:

* **Caption Summary** - Used to display the summary information in the caption of the group.
* **Group Summary** - Used to display summary information of data objects in each group.
* **Table Summary** - Used to display the summary information at top and/or bottom in SfDataGrid.


![DataGrid with summary rows](Images\caption-summary\maui-datagrid-summaries.png) 

Summary rows are represented by using the [DataGridSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html) that hold summary information of columns in the [SummaryColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_SummaryColumns) property . The `SummaryColumns` contains the collection of [DataGridSummaryColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html) which carries name, format, and summary aggregate type of the column.

Derive additional information from the data like sum, average, maximum, minimum, and count using summaries in the data grid. These summary values can be computed for groups or for the entire control using `DataGridSummaryRow` and `DataGridSummaryColumn` that implements [ISummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISummaryRow.html) and [ISummaryColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISummaryColumn.html) interfaces.

N> The Summary does not refresh with data. To update the summary for the newly added row, or for the modified summary column, set the [SfDataGrid.View.LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.LiveDataUpdateMode.html) to `LiveDataUpdateMode.AllowDataShaping` or `LiveDataUpdateMode.AllowSummaryUpdate`.

## Caption summaries

The data grid provides built-in support for caption summaries. The caption summary value calculated based on the records in a group. The summary information will be displayed in the caption of group.

### Formatting built-in caption summary

By default, the caption summary rows in the data grid are displayed using the [SfDataGrid.GroupCaptionTextFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupCaptionTextFormatProperty) property.

Default group caption format is `{ColumnName}: {Key} - {ItemsCount} Items`.

* **ColumnName**: Displays the name of the currently grouped column.
* **Key**: Displays the key value of the group.
* **ItemsCount**: Displays the number of items in a group.

![DataGrid with formatting in caption summary row](Images\caption-summary\maui-datagrid-default.png)

You can customize the group caption text format by setting the `SfDataGrid.GroupCaptionTextFormat` property. The code example below illustrates how to customize the `group caption text` in the data grid:

{% tabs %}
{% highlight xaml %}
    <sfGrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       ColumnWidthMode="Fill"
                       GroupCaptionTextFormat="{}{ColumnName}: {Key}">
    <sfgrid:SfDataGrid.GroupColumnDescriptions>
            <sfgrid:GroupColumnDescription ColumnName="Salary" />
        </sfgrid:SfDataGrid.GroupColumnDescriptions>
    </sfGrid:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
// Customized group caption text
dataGrid.GroupCaptionTextFormat = "{ColumnName}: {Key}";
{% endhighlight %}
{% endtabs %}

The following screenshot shows the outcome of the previous code:

![DataGrid with formatting in caption summary row](Images\caption-summary\maui-datagrid-formatting-show-summary-in-row.png)

### Customize the column name in the group caption summary

The column name in the group caption summary text can be customized using the [DisplayName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupColumnDescription.html#Syncfusion_Maui_DataGrid_GroupColumnDescription_DisplayName) property.

If the `DisplayName` property is set, the specified display name will appear in the group caption summary text. If it is null, the column name will be displayed instead.

{% tabs %}
{% highlight xaml %}
    <sfGrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       ColumnWidthMode="Fill">
        <sfGrid:SfDataGrid.GroupColumnDescriptions>
            <sfGrid:GroupColumnDescription ColumnName="Salary" DisplayName="Income" />
        </sfGrid:SfDataGrid.GroupColumnDescriptions>
    </sfGrid:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
GroupColumnDescription groupColumnDescription = new GroupColumnDescription
{
    ColumnName = "Salary",
    DisplayName = "Income"
};
dataGrid.GroupColumnDescriptions.Add(groupColumnDescription);
{% endhighlight %}
{% endtabs %}

The following screenshot shows the outcome of the previous code:

<img src="Images\group-summary\maui-datagrid-display-name.png" width="404" alt="DataGrid with DisplayName in group caption summary text">

### Displaying summary for a row

Display summary information in a row by setting the [DataGridSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) property to `true` and define summary columns. You have to define the [DataGridSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) based on the [DataGridSummaryColumn.Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_Name) property in order to format the values of the summary columns in the row.

{% tabs %}
{% highlight xaml %}
    <sfGrid:SfDataGrid.CaptionSummaryRow>
        <sfGrid:DataGridSummaryRow Title="Total Salary :{TotalSalary} for {ProductCount} members"
                                   ShowSummaryInRow="True">
            <sfGrid:DataGridSummaryRow.SummaryColumns>
                <sfGrid:DataGridSummaryColumn Name="TotalSalary"
                                              Format="{}{Sum:C0}"
                                              MappingName="Salary"
                                              SummaryType="Int32Aggregate" />
                <sfGrid:DataGridSummaryColumn Name="ProductCount"
                                              Format="{}{Count}"
                                              MappingName="Salary"
                                              SummaryType="CountAggregate" />
            </sfGrid:DataGridSummaryRow.SummaryColumns>
        </sfGrid:DataGridSummaryRow>
    </sfGrid:SfDataGrid.CaptionSummaryRow>
{% endhighlight %}

{% highlight c# %}
DataGridSummaryRow summaryRow = new DataGridSummaryRow();
summaryRow.Title = "Total Salary:{TotalSalary} for {ProductCount} members";
summaryRow.ShowSummaryInRow = true;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "TotalSalary",
    MappingName = "Salary",
    Format = "{Sum:c}",
    SummaryType = SummaryType.DoubleAggregate
});
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "ProductCount",
    MappingName = "Salary",
    Format = "{Count}",
    SummaryType = SummaryType.CountAggregate
});
sfGrid.CaptionSummaryRow= summaryRow;
{% endhighlight %}
{% endtabs %}

The following screenshot shows the outcome for both values of `ShowSummaryInRow` to `true`:

![DataGrid with customized caption summary row](Images\caption-summary\maui-datagrid-show-summary-in-row.png)


### Displaying summary for column

To display summary information in a column, you need to set the `DataGridSummaryRow.ShowSummaryInRow` to `false` and define summary columns using the `SfDataGrid.DataGridSummaryColumn` object. The `DataGridSummaryColumn` object has several important properties:

* [Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_Name): This property defines the name of the `DataGridSummaryColumn`, which is used to identify the column in the `DataGridSummaryRow` and provide a title for it.
* [MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_MappingName): This property defines the corresponding column name used for the summary calculation.
* [SummaryType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_SummaryType):  This property defines the `SummaryType` enum property, which determines the type of aggregate function used for the summary calculation. 

The DataGrid control provides several predefined aggregates, such as `CountAggregate`, `Int32Aggregate`, and `DoubleAggregate`. When the summary type is set as `Custom`, you can define a `CustomAggregate` class object to calculate custom summaries.

The [Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_Format) property defines a string property that formats the summary value and displays it. The Format property can have two parts separated by a colon (:). The first part denotes the aggregate function name, and the second part denotes the display format of the summary value.

Please refer to the [Formatting Summary](#_Formatting_Summary) section for more information on how to format the summary, and the `Aggregate Types` section to learn about the different summary types.

In the following code snippet, a summary is defined for the `Salary` column:

{% tabs %}
{% highlight xaml %}
    <sfGrid:SfDataGrid.CaptionSummaryRow>
        <sfGrid:DataGridSummaryRow Name="CaptionSummary"
                                   ShowSummaryInRow="False">
            <sfGrid:DataGridSummaryRow.SummaryColumns>
                <sfGrid:DataGridSummaryColumn Name="CaptionSummary"
                                              Format="{}{Sum:C0}"
                                              MappingName="Salary"
                                              SummaryType="DoubleAggregate" />
            </sfGrid:DataGridSummaryRow.SummaryColumns>
        </sfGrid:DataGridSummaryRow>
    </sfGrid:SfDataGrid.CaptionSummaryRow>
{% endhighlight %}

{% highlight c# %}
DataGridSummaryRow summaryRow = new DataGridSummaryRow();
summaryRow.ShowSummaryInRow = false;
summaryRow.SummaryColumns.Add(new DataGridSummaryColumn()
{
    Name = "CaptionSummary",
    MappingName = "Salary",
    Format = "{Sum:c}",
    SummaryType = SummaryType.DoubleAggregate
});
sfGrid.CaptionSummaryRow= summaryRow;
{% endhighlight %}
{% endtabs %}

![DataGrid with caption summary cells customized](Images\caption-summary\maui-datagrid-show-summary-in-column.png)

N> The `CaptionSummaryColumn` text will be aligned based on the `DataGridColumn.TextAlignment`.

### Caption summary template

The data grid allows you to host any view(s) inside a caption summary for the entire row or for individual columns by loading a template. 

### Displaying template for a row

The template for a caption summary row can be customized by using the [SfDataGrid.CaptionSummaryTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CaptionSummaryTemplate) property. This allows you to define a custom template according to your requirements.

Please refer to the code example below, where a label is loaded in the `caption summary template` of the `caption summary row`:

{% tabs %}
{% highlight xaml %}
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:GroupCaptionConverter x:Key="SummaryConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <sfgrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
        <sfgrid:SfDataGrid.CaptionSummaryTemplate>
            <DataTemplate>
                <StackLayout Orientation="Horizontal">
                    <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter = {x:Reference dataGrid} }"
                           FontSize="Default"
                           VerticalTextAlignment="Center"
                           HorizontalTextAlignment="Start"
                           LineBreakMode="NoWrap"
                           HorizontalOptions="FillAndExpand"
                           VerticalOptions="FillAndExpand">
                        <Label.Style>
                            <Style TargetType="Label">
                                <Setter Property="FontAttributes"
                                        Value="Bold, Italic" />
                            </Style>
                        </Label.Style>
                    </Label>
                </StackLayout>
            </DataTemplate>
        </sfgrid:SfDataGrid.CaptionSummaryTemplate>
        <sfgrid:SfDataGrid.CaptionSummaryRow>
            <sfgrid:DataGridSummaryRow Name="CaptionSummary"
                                       ShowSummaryInRow="True"
                                       Title="Total Salary: {CaptionSummary}">
                <sfgrid:DataGridSummaryRow.SummaryColumns>
                    <sfgrid:DataGridSummaryColumn Name="CaptionSummary"
                                                  Format="{}{Sum:C0}"
                                                  MappingName="Salary"
                                                  SummaryType="DoubleAggregate" />
                </sfgrid:DataGridSummaryRow.SummaryColumns>
            </sfgrid:DataGridSummaryRow>
        </sfgrid:SfDataGrid.CaptionSummaryRow>
    </sfgrid:SfDataGrid>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
// To write a converter, follow the code example:
public class GroupCaptionConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var data = value != null ? value as Group : null;
        if (data != null)
        {
            SfDataGrid dataGrid = (SfDataGrid)parameter;
            var summaryText = SummaryCreator.GetSummaryDisplayTextForRow((value as Group).SummaryDetails, dataGrid.View);

            return summaryText;
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

![DataGrid with template loaded for entire caption summary row](Images\caption-summary\maui-datagrid-template-row.png)

N> The `DataTemplateSelector` can also be directly assigned to the `CaptionSummaryTemplate`. When using data template selector, performance issues occur as the conversion template views take time within the framework.


### Displaying template for a column

The template for a caption summary column can be customized by using the `DataGridSummaryColumn.Template` property. This allows you to define a custom template according to your requirements.

Here's an example code snippet that demonstrates how to load a label in the template of a `caption summary column`:

{% tabs %}
{% highlight xaml %}
     <ContentPage.Resources>
         <ResourceDictionary>
             <local:GroupCaptionConverter x:Key="SummaryConverter" />
         </ResourceDictionary>
     </ContentPage.Resources>
     <sfgrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AllowResizingColumn="True"
                       ColumnWidthMode="Fill"
                       >
        <sfgrid:SfDataGrid.Columns>
            <sfgrid:DataGridTextColumn MappingName="OrderID" />
            <sfgrid:DataGridTextColumn MappingName="Salary" />
            <sfgrid:DataGridTextColumn MappingName="CustomerID" />
        </sfgrid:SfDataGrid.Columns>
        <sfgrid:SfDataGrid.CaptionSummaryRow>
            <sfgrid:DataGridSummaryRow Name="CaptionSummary"
                                       ShowSummaryInRow="False"
                                       Title="Salary: {CaptionSummary}">
                <sfgrid:DataGridSummaryRow.SummaryColumns>
                    <sfgrid:DataGridSummaryColumn Name="CaptionSummary"
                                                  Format="{}{Sum:C0}"
                                                  MappingName="Salary"
                                                  SummaryType="DoubleAggregate">
                        <sfgrid:DataGridSummaryColumn.Template>
                            <DataTemplate>
                                <StackLayout Orientation="Horizontal"
                                             BackgroundColor="Gray">
                                    <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter {x:Reference dataGrid} }"
                                           VerticalOptions="CenterAndExpand"
                                           TextColor="White"
                                           FontSize="Default"
                                           VerticalTextAlignment="Center"
                                           HorizontalTextAlignment="Start"
                                           LineBreakMode="NoWrap"
                                           HorizontalOptions="FillAndExpand">
                                        <Label.Style>
                                            <Style TargetType="Label">
                                                <Setter Property="FontAttributes"
                                                        Value="Italic" />
                                            </Style>
                                        </Label.Style>
                                    </Label>
                                </StackLayout>
                            </DataTemplate>
                        </sfgrid:DataGridSummaryColumn.Template>
                    </sfgrid:DataGridSummaryColumn>
                </sfgrid:DataGridSummaryRow.SummaryColumns>
            </sfgrid:DataGridSummaryRow>
        </sfgrid:SfDataGrid.CaptionSummaryRow>
     </sfgrid:SfDataGrid>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
// To write a converter, follow the code example:
public class GroupCaptionConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var data = value != null ? value as Group : null;
        if (data != null)
        {
            SfDataGrid dataGrid = (SfDataGrid)parameter;
            var summaryText = SummaryCreator.GetSummaryDisplayTextForRow((value as Group).SummaryDetails, dataGrid.View);
            return summaryText;
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

![DataGrid with template loaded for individual caption summary column](Images\caption-summary\maui-datagrid-template-column.png)

### Displaying column summary with title

SfDataGrid supports displaying both column summaries and title summaries simultaneously. You can show column summary along with title by defining the [DataGridSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) and DataGridSummaryRow.TitleColumnCount property, along with defining summary columns. Showing column summary along with title can be only supported if [DataGridSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) is disabled.

In the code snippet below, DataGridSummaryRow.TitleColumnCount is set as 2, and [DataGridSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) is defined along with summary columns.

### Limitations

The following are the limitations of displaying column summary along with title at same time for DataGridSummaryRow:

* If FrozenColumnCount is defined as less than DataGridSummaryRow.TitleColumnCount, the title summary will span the range of FrozenColumnCount, since the spanned range and frozen range cannot vary.

## Group summary

`Group summary` values are calculated based on the records within each group. The summary information will be displayed at the bottom of each group. You can view the group summary row by expanding the corresponding group header. The data grid allows for the addition of any number of group summary rows.

To add group summary rows in the data grid, you can add the [DataGridSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html) objects to the [SfDataGrid.GroupSummaryRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupSummaryRowsProperty) collection.

### Displaying summary in the row

Summary information can be displayed in the entire row by setting the [DataGridSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) property to `true` and defining summary columns. The [DataGridSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) property needs to be defined based on the [DataGridSummaryRow.Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Name) property in order to format the values of the summary columns in a row.

Please refer to the [Formatting Summary](#formatting-summary)  section to learn more about how to format the summary.

{% tabs %}

{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       ColumnWidthMode="Fill"
                       AllowGroupExpandCollapse="True"
                       >
        <sfgrid:SfDataGrid.GroupColumnDescriptions>
            <sfgrid:GroupColumnDescription ColumnName="Salary" />
        </sfgrid:SfDataGrid.GroupColumnDescriptions>
        <sfgrid:SfDataGrid.GroupSummaryRows>
            <sfgrid:DataGridSummaryRow ShowSummaryInRow="True"
                                       Title="Total Salary: {Salary} for {customerID} members">
                <sfgrid:DataGridSummaryRow.SummaryColumns>
                    <sfgrid:DataGridSummaryColumn Name="Salary"
                                                  MappingName="Salary"
                                                  Format="{}{Sum:C0}"
                                                  SummaryType="DoubleAggregate">
                    </sfgrid:DataGridSummaryColumn>
                    <sfgrid:DataGridSummaryColumn Name="customerID"
                                                  MappingName="CustomerID"
                                                  Format="{}{Count}"
                                                  SummaryType="CountAggregate">
                    </sfgrid:DataGridSummaryColumn>
                </sfgrid:DataGridSummaryRow.SummaryColumns>
            </sfgrid:DataGridSummaryRow>
        </sfgrid:SfDataGrid.GroupSummaryRows>
    </sfgrid:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
this.dataGrid.GroupSummaryRows.Add(new DataGridSummaryRow()
{
    ShowSummaryInRow = true,
    Title = "Total Salary: {Salary} for {customerID} members",
    SummaryColumns = new ObservableCollection<ISummaryColumn>()
    {
        new DataGridSummaryColumn()
        {
            Name="Salary",
            MappingName="Salary",
            SummaryType=SummaryType.DoubleAggregate,
            Format="{Sum}"
        },
        new DataGridSummaryColumn()
        {
            Name="customerID",
            MappingName="customerID",
            Format="{Count}",
            SummaryType=SummaryType.CountAggregate
        }
    }
});
{% endhighlight %}
{% endtabs %}


![DataGrid with group summary](Images\group-summary\maui-datagrid-show-summary-in-row.png)

### Displaying summary in the column

The summary information can be displayed in a column by setting the [DataGridSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) property to `false` and defining summary columns. To calculate the summary based on a column, you need to specify the following properties:

[DataGridSummaryColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_MappingName): This property provides the MappingName of the column (the property name of the data object) for which you want to calculate the summary.
[DataGridSummaryColumn.SummaryType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_SummaryType): This property provides different built-in summary calculation functions for various types.
[DataGridSummaryColumn.Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_Format): This property allows you to specify a format string for the summary based on the supported function name in the specified SummaryType.

Please refer to the [Formatting Summary](#formatting-summary) section to learn more about how to format the summary, and the [Aggregate Types](#aggregate-types) section to understand the different Summary Types.

In the following code snippet, a summary is defined for the `Salary` and `CustomerID` columns:

{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       ColumnWidthMode="Fill"
                       AllowGroupExpandCollapse="True">
        <sfgrid:SfDataGrid.GroupSummaryRows>
            <sfgrid:DataGridSummaryRow ShowSummaryInRow="False">
                <sfgrid:DataGridSummaryRow.SummaryColumns>
                    <sfgrid:DataGridSummaryColumn Name="Salary"
                                                  MappingName="Salary"
                                                  Format="{}{Sum:C0}"
                                                  SummaryType="DoubleAggregate">
                    </sfgrid:DataGridSummaryColumn>
                </sfgrid:DataGridSummaryRow.SummaryColumns>
            </sfgrid:DataGridSummaryRow>
        </sfgrid:SfDataGrid.GroupSummaryRows>
    </sfgrid:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
this.dataGrid.GroupSummaryRows.Add(new DataGridSummaryRow()
{
    ShowSummaryInRow = false,
    SummaryColumns = new ObservableCollection<ISummaryColumn>()
    {
        new DataGridSummaryColumn()
        {
            Name="Salary",
            MappingName="Salary",
            SummaryType=SummaryType.DoubleAggregate,
            Format="{Sum}"
        },
    }
});
{% endhighlight %}
{% endtabs %}


![DataGrid with customized summary for group summary cells](Images\group-summary\maui-datagrid-show-summary-in-column.png)

### Group summary template

The data grid allows you to host any view(s) inside a group summary for the entire row or individual columns by loading a template. 

### Displaying template for a row

The template for a group summary row can be customized by using the `SfDataGrid.GroupSummaryTemplate` property.

Refer to the code example below, which demonstrates how to load a label in the group summary template of a group summary row:

{% tabs %}
{% highlight xaml %}
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:GroupSummaryConverter x:Key="SummaryConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <sfgrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
        <sfgrid:SfDataGrid.GroupSummaryTemplate>
            <DataTemplate>
                <StackLayout Orientation="Horizontal">
                    <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter = {x:Reference dataGrid} }"
                           FontSize="Default"
                           VerticalTextAlignment="Center"
                           HorizontalTextAlignment="Start"
                           LineBreakMode="NoWrap"
                           HorizontalOptions="FillAndExpand"
                           VerticalOptions="FillAndExpand">
                        <Label.Style>
                            <Style TargetType="Label">
                                <Setter Property="FontAttributes"
                                        Value="Bold, Italic" />
                            </Style>
                        </Label.Style>
                    </Label>
                </StackLayout>
            </DataTemplate>
        </sfgrid:SfDataGrid.GroupSummaryTemplate>
        <sfgrid:SfDataGrid.GroupSummaryRows>
            <sfgrid:DataGridSummaryRow Title="salary {Salary}"
                                       ShowSummaryInRow="True">
                <sfgrid:DataGridSummaryRow.SummaryColumns>
                    <sfgrid:DataGridSummaryColumn Name="Salary"
                                                  MappingName="Salary"
                                                  Format="{}{Sum:C0}"
                                                  SummaryType="DoubleAggregate">
                    </sfgrid:DataGridSummaryColumn>
                </sfgrid:DataGridSummaryRow.SummaryColumns>
            </sfgrid:DataGridSummaryRow>
        </sfgrid:SfDataGrid.GroupSummaryRows>
    </sfgrid:SfDataGrid>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
// To write a converter, follow the code example:
public class GroupSummaryConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var data = value != null ? value as SummaryRecordEntry : null;
        if (data != null)
        {
            SfDataGrid dataGrid = (SfDataGrid)parameter;
            var summaryText = SummaryCreator.GetSummaryDisplayText(data,"Salary",dataGrid.View);
            return "Total Salary:" + " " + summaryText.ToString();
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

![DataGrid with template loaded for entire group summary row](Images\group-summary\maui-datagrid-row-template.png)

N> The `DataTemplateSelector` can also be directly assigned to the `SfDataGrid.GroupSummaryTemplate`. When using data template selector, performance issues occur as the conversion template views take time within the framework.

### Displaying template for a column

The template for a group summary column can be customized by using the `GridSummaryColumn.Template`  property. This allows you to define a custom template according to your requirements.

Please refer to the code example below, which demonstrates how to load a label in the template of a group summary column:

{% tabs %}
{% highlight xaml %}
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:GroupSummaryConverter x:Key="SummaryConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <sfgrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                        ColumnWidthMode="Fill"
                       >
        <sfgrid:SfDataGrid.Columns>
            <sfgrid:DataGridTextColumn MappingName="OrderID" />
            <sfgrid:DataGridTextColumn MappingName="Salary" />
            <sfgrid:DataGridTextColumn MappingName="CustomerID" />
            <sfgrid:DataGridTextColumn MappingName="Country" />
        </sfgrid:SfDataGrid.Columns>
        <sfgrid:SfDataGrid.GroupSummaryRows>
            <sfgrid:DataGridSummaryRow ShowSummaryInRow="False">
                <sfgrid:DataGridSummaryRow.SummaryColumns>
                    <sfgrid:DataGridSummaryColumn Name="Salary"
                                                  MappingName="Salary"
                                                  Format="{}{Sum:C0}"
                                                  SummaryType="DoubleAggregate">
                        <sfgrid:DataGridSummaryColumn.Template>
                            <DataTemplate>
                                <StackLayout Orientation="Horizontal"
                                             BackgroundColor="Gray">
                                    <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter {x:Reference dataGrid} }"
                                           VerticalOptions="CenterAndExpand"
                                           TextColor="White"
                                           FontSize="Medium"
                                           VerticalTextAlignment="Center"
                                           HorizontalTextAlignment="Start"
                                           LineBreakMode="NoWrap"
                                           HorizontalOptions="FillAndExpand">
                                        <Label.Style>
                                            <Style TargetType="Label">
                                                <Setter Property="FontAttributes"
                                                        Value="Italic" />
                                            </Style>
                                        </Label.Style>
                                    </Label>
                                </StackLayout>
                            </DataTemplate>
                        </sfgrid:DataGridSummaryColumn.Template>
                    </sfgrid:DataGridSummaryColumn>
                </sfgrid:DataGridSummaryRow.SummaryColumns>
            </sfgrid:DataGridSummaryRow>
        </sfgrid:SfDataGrid.GroupSummaryRows>
    </sfgrid:SfDataGrid>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
// To write a converter, follow the code example:
public class GroupSummaryConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var data = value != null ? value as SummaryRecordEntry : null;
        if (data != null)
        {
            SfDataGrid dataGrid = (SfDataGrid)parameter;
            var summaryText = SummaryCreator.GetSummaryDisplayText(data,"Salary",dataGrid.View);
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

![DataGrid with template loaded for individual group summary cell](Images\group-summary\maui-datagrid-column-template.png)

### Displaying column summary with title

SfDataGrid supports displaying both column summaries and title summaries simultaneously. You can show column summary along with title by defining the [DataGridSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) and DataGridSummaryRow.TitleColumnCount property, along with defining summary columns. Showing column summary along with title can be only supported if [DataGridSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) is disabled.

In the code snippet below, DataGridSummaryRow.TitleColumnCount is set as 2, and [DataGridSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) is defined along with summary columns.

### Limitations

The following are the limitations of displaying column summary along with title at same time for DataGridSummaryRow:

* If FrozenColumnCount is defined as less than DataGridSummaryRow.TitleColumnCount, the title summary will span the range of FrozenColumnCount, since the spanned range and frozen range cannot vary.

## Table summaries

The data grid provides built-in support for table summaries. The table summary value is calculated based on all records in the control.

You can add table summary row in the data grid by adding the [DataGridTableSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryRow.html) to the [SfDataGrid.TableSummaryRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_TableSummaryRows) collection.

The following screenshot illustrates table summary rows in the data grid:

![DataGrid with table summary](Images\table-summary\maui-datagrid-table-summary-position.png)

{% tabs %}
{% highlight xaml %}
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
        <sfGrid:DataGridTableSummaryRow Position="Top"
                                        ShowSummaryInRow="False">
            <sfGrid:DataGridTableSummaryRow.SummaryColumns>
                <sfGrid:DataGridSummaryColumn Name="TotalSalary"
                                              Format="{}{Sum:C0}"
                                              MappingName="Salary"
                                              SummaryType="DoubleAggregate" />
            </sfGrid:DataGridTableSummaryRow.SummaryColumns>
        </sfGrid:DataGridTableSummaryRow>
    </sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c# %}
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


![DataGrid with table summary](Images\table-summary\maui-datagrid-table-summary.png)

### Displaying summary in a row

Display summary information in a row by setting the [DataGridTableSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) to `true` and define summary columns. You have to define the [DataGridTableSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) based on the [DataGridSummaryColumn.Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Name) property to format summary columns values in a row.

{% tabs %}
{% highlight xaml %}
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

{% highlight c# %}
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

![DataGrid with customized table summary for entire row](Images\table-summary\maui-datagrid-show-summary-in-row.png)

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
{% highlight xaml %}
    <sfGrid:SfDataGrid.TableSummaryRows>
        <sfGrid:DataGridTableSummaryRow Name="TableSummary"
                                        ShowSummaryInRow="False">
            <sfGrid:DataGridTableSummaryRow.SummaryColumns>
                <sfGrid:DataGridSummaryColumn Name="TableSummary"
                                              Format="{}{Sum:C0}"
                                              MappingName="Salary"
                                              SummaryType="DoubleAggregate" />
            </sfGrid:DataGridTableSummaryRow.SummaryColumns>
        </sfGrid:DataGridTableSummaryRow>
    </sfGrid:SfDataGrid.TableSummaryRows>
{% endhighlight %}

{% highlight c# %}
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
{% endhighlight %}
{% endtabs %}

The following screenshot shows the table summary row if `ShowSummaryInRow` is `false`.

![DataGrid with customized table summary for individual cells](Images\table-summary\maui-datagrid-show-summary-in-column.png)

### Positioning TableSummaryRows

The data grid add table summary rows either at top or bottom positions using the [DataGridTableSummaryRow.Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridTableSummaryRow_Position) property.

{% tabs %}
{% highlight xaml %}
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

{% highlight c# %}
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

![Customizing table summary row position in a DataGrid](Images\table-summary\maui-datagrid-table-summary-position.png)

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
                           ItemsSource="{Binding OrderInfoCollection}"
                           AutoGenerateColumnsMode="None"
                           ColumnWidthMode="Fill"
                           AllowEditing="True"
                           NavigationMode="Cell"
                           SelectionMode="Single"
                           >
            <sfgrid:SfDataGrid.Columns>
                <sfgrid:DataGridNumericColumn MappingName="OrderID" />
                <sfgrid:DataGridTextColumn MappingName="EmployeeID" />
                <sfgrid:DataGridTextColumn MappingName="FirstName" />
                <sfgrid:DataGridTextColumn MappingName="LastName" />
            </sfgrid:SfDataGrid.Columns>
            <sfgrid:SfDataGrid.TableSummaryTemplate>
                <DataTemplate>
                    <StackLayout Orientation="Horizontal"
                                 BackgroundColor="Gray">
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
                                    <Setter Property="FontAttributes"
                                            Value="Italic" />
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

![Table summary template in a row](Images\table-summary\maui-datagrid-template-row.png)

### Displaying template for a column

The template for a table summary column can be set by using `DataGridSummaryColumn.Template` and it can be customized based on the requirement.

Refer the below code example in which a label is loaded in the template of table summary column.

{% tabs %}
{% highlight xaml %}
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:TableSummaryConverter x:Key="SummaryConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    <StackLayout>
        <sfgrid:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AutoGenerateColumnsMode="None"
                            AllowEditing="True"
                            NavigationMode="Cell"
                            SelectionMode="Single"
                            ColumnWidthMode="Fill">
            <sfgrid:SfDataGrid.Columns>
                <sfgrid:DataGridNumericColumn MappingName="OrderID" />
                <sfgrid:DataGridTextColumn MappingName="EmployeeID" />
                <sfgrid:DataGridTextColumn MappingName="FirstName" />
                <sfgrid:DataGridTextColumn MappingName="LastName" />
            </sfgrid:SfDataGrid.Columns>
            <sfgrid:SfDataGrid.TableSummaryRows>
                <sfgrid:DataGridTableSummaryRow Title="Total Salary :{TotalSalary} for {ProductCount} members"
                                                Position="Bottom"
                                                ShowSummaryInRow="False">
                    <sfgrid:DataGridTableSummaryRow.SummaryColumns>
                        <sfgrid:DataGridSummaryColumn Name="TotalSalary"
                                                      Format="{}{Sum:C0}"
                                                      MappingName="Salary"
                                                      SummaryType="DoubleAggregate">
                            <sfgrid:DataGridSummaryColumn.Template>
                                <DataTemplate>
                                    <StackLayout Orientation="Horizontal"
                                                 BackgroundColor="Gray">
                                        <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter ={x:Reference dataGrid} }"
                                               TextColor="White"
                                               FontSize="Medium"
                                               VerticalTextAlignment="Center"
                                               HorizontalTextAlignment="Start"
                                               LineBreakMode="NoWrap"
                                               HorizontalOptions="FillAndExpand"
                                               VerticalOptions="FillAndExpand">
                                            <Label.Style>
                                                <Style TargetType="Label">
                                                    <Setter Property="FontAttributes"
                                                            Value="Italic" />
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
{% endhighlight %}
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

![Table summary template in a column](Images\table-summary\maui-datagrid-template-column.png)

N> The `DataTemplateSelector` can also be directly assigned to the `SfDataGrid.TableSummaryTemplate`. When using data template selector, performance issues occur as the conversion template views take time within the framework.

### Displaying column summary with title

SfDataGrid supports displaying both column summaries and title summaries simultaneously. You can show column summary along with title by defining the [DataGridTableSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) and DataGridTableSummaryRow.TitleColumnCount property, along with defining summary columns. Showing column summary along with title can be only supported if [DataGridTableSummaryRow.ShowSummaryInRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_ShowSummaryInRow) is disabled.

In the code snippet below, DataGridTableSummaryRow.TitleColumnCount is set as 2, and [DataGridTableSummaryRow.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html#Syncfusion_Maui_DataGrid_DataGridSummaryRow_Title) is defined along with summary columns.

### Limitations

The following are the limitations of displaying column summary along with title at same time for DataGridTableSummaryRow:

* If FrozenColumnCount is defined as less than DataGridTableSummaryRow.TitleColumnCount, the title summary will span the range of FrozenColumnCount, since the spanned range and frozen range cannot vary.

## Formatting summary

In the following sections, the formatting is explained using the `TableSummary`.

### Formatting summary value

Format the summary value by setting the appropriate format after the aggregate function followed by a colon(:) in the `DataGridSummaryColumn.Format` property.

In the following code snippet `Salary` column summary is formatted using `C0` format specifier. Refer to [here](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings?redirectedfrom=MSDN) to know about how to set different formats.

{% tabs %}
{% highlight xaml %}
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

{% highlight c# %}
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

![Formatting summary value in a DataGrid](Images\table-summary\maui-datagrid-show-summary-in-column.png)


### Displaying additional content in summary

Append additional content with summary value using the `DataGridSummaryColumn.Format` property.

In the following code snippet `Total:` text is appended before summary value:

{% tabs %}
{% highlight xaml %}
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

{% highlight c# %}
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

![Displaying additional content in summary in a DataGrid](Images\table-summary\maui-datagrid-additional-content.png)

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

## Custom summaries

The data grid implements your own aggregate functions when the built-in aggregate functions do not meet your requirement.

Summary values can be calculated based on custom logic using the [DataGridSummaryColumn.CustomAggregate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryColumn.html#Syncfusion_Maui_DataGrid_DataGridSummaryColumn_CustomAggregate) property.

### Implementing custom aggregate

1. Create a custom aggregate class by deriving from [ISummaryAggregate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ISummaryAggregate.html) interface.
2. In the `CalculateAggregateFunc()` method, you have to calculate the summary and assign it to the property.

In the following code snippet, `Standard Deviation` is calculated for quantity of products:

{% tabs %}
{% highlight c# %}
public class CustomAggregate : ISummaryAggregate
{
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
{% highlight xaml %}
    <sfGrid:SfDataGrid.TableSummaryRows>
        <sfGrid:DataGridTableSummaryRow Title="Standard Deviation:{TableSummary}"
                                        ShowSummaryInRow="True">
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

{% highlight c# %}
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

![DataGrid with custom aggregate](Images\table-summary\maui-datagrid-custom-aggregate.png)

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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryCellRenderer.html">DataGridTableSummaryCellRenderer </a> </td>
<td>TableSummary</td>
</tr>


</table>

### Customizing table summary

The data grid allows customizing the table summary by extending the [DataGridTableSummaryCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryCellRenderer.html) class.


To customize the table summary, follow the code example:

{% tabs %}
{% highlight c# %}
// To remove default summary and Add custom summary.
public class Summary : ContentPage
{
    public Summary()
    {
        InitializeComponent();
        dataGrid.CellRenderers.Remove("TableSummary");
        dataGrid.CellRenderers.Add("TableSummary", new DataGridTableSummaryCellRendererExt());
    }
}

public class DataGridTableSummaryCellRendererExt : DataGridTableSummaryCellRenderer
{
    protected override void OnSetCellStyle(DataColumnBase dataColumn)
    {
        base.OnSetCellStyle(dataColumn);

        if (dataColumn.ColumnElement != null && dataColumn.ColumnElement.Content is SfDataGridLabel label)
        {
            dataColumn.ColumnElement.Background = Colors.Green;

            label.HorizontalTextAlignment = TextAlignment.Start;
            label.FontSize = 16;
            label.FontAttributes = FontAttributes.Bold;
            label.TextColor = Colors.White;
        }
    }
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the final outcome upon execution of the above code.

![Customize table summary using custom cell renderer](Images\table-summary\maui-datagrid-customizing-table-summary.png)

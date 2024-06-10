---
layout: post
title: Column Types in .NET MAUI DataGrid control | Syncfusion
description: Learn all about Column Types support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Column Types in .NET MAUI DataGrid (SfDataGrid)

The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) contains different types of columns. The functionalities of the columns can be implied by their names. Any of the columns can be used depending on the requirements.

To get start quickly with column types in .NET MAUI DataGrid, you can check on this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src="https://www.youtube.com/embed/tLNua3iGnGE"></iframe>

The following table describes the types of columns and their usage:

<table>
<tr>
<th>Column Type</th>
<th>Renderer</th>
<th>Key</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[DataGridTextColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTextColumn.html)'| markdownify }}</td>
<td>{{'[DataGridTextBoxRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTextBoxCellRenderer.html)' | markdownify }}</td>
<td>Text</td>
<td>To display a string or numbers in each row.</td>
</tr>
<tr>
<td>{{'[DataGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxColumn.html)'| markdownify }}</td>
<td>{{'[DataGridCheckBoxRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxCellRenderer.html)'| markdownify }}</td>
<td>CheckBox</td>
<td>To display CheckBox in each row.</td>
</tr>
<tr>
<td>{{'[DataGridImageColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html)'| markdownify }}</td>
<td>{{'[DataGridImageCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageCellRenderer.html)'| markdownify }}</td>
<td>Image</td>
<td>To display an image in each row.</td>
</tr>
<tr>
<td>{{'[DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html)'| markdownify }}</td>
<td>{{'[DataGridCellTemplateRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTemplateRenderer.html)'| markdownify }}</td>
<td>Template</td>
<td>To customize a column based on the requirements.</td>
</tr>
<tr>
<td>{{'[DataGridNumericColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridNumericColumn.html)'| markdownify }}</td>
<td>{{'[DataGridNumericCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridNumericCellRenderer.html)'| markdownify }}</td>
<td>Numeric</td>
<td>To display numeric data.</td>
</tr>
<tr>
<td>{{'[DataGridDateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDateColumn.html)'| markdownify }}</td>
<td>{{'[DataGridDateCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDateCellRenderer.html)'| markdownify }}</td>
<td>DateTime</td>
<td>To display the date and time value.</td>
</tr>
<tr>
<td>{{'[DataGridComboBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html)'| markdownify }}</td>
<td>{{'[DataGridComboBoxRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxRenderer.html)'| markdownify }}</td>
<td>ComboBox</td>
<td>To display the date and time value.</td>
</tr>
<tr>
<td>{{'[DataGridUnboundColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumn.html)'| markdownify }}</td>
<td>{{'[DataGridUnboundCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundCellRenderer.html)'| markdownify }}</td>
<td>Unbound</td>
<td>To add additional columns that are not bound with data object from the underlying data source.</td>
</tr>
</table>

## DataGridColumn

The [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html) is the base column type of all columns, hence its properties are used by all the columns. The following sub-sections explain the properties and customizations of DataGridColumn:

### Binding options

The display content of the DataGridColumn is determined by the [DataGridColumn.DisplayBinding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_DisplayBinding) property. It gets or sets display binding that associates the DataGridColumn with a property in the data source.

#### Mapping column to particular property

The [DataGridColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MappingName) associates the DataGridColumn with a property available in the underlying data source. While setting MappingName alone to the SfDataGrid, the `DataGridColumn.DisplayBinding` will be automatically generated based on the MappingName. Data manipulation operations like sorting and filtering will be done based on the MappingName property.

To format cell contents, use the converter of the `DataGridColumn.DisplayBinding` to customize the cell contents.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <ResourceDictionary>
        <local:DisplayBindingConverter x:Key="displayBindingConverter" />
    </ResourceDictionary>
</ContentPage.Resources> 

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="CustomerID" 
                                   DisplayBinding="{Binding CustomerID, 
                                   Converter={StaticResource displayBindingConverter}}" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid> 
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="Converter.cs" %}
public class DisplayBindingConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
            return "Customer : " + value.ToString();
        return null;
    }
}
{% endhighlight %}
{% endtabs %}

### TextAlignment

In order to set the TextAlignment of the header cell and data row cell , use the [DataGridColumn.HeaderTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderTextAlignment) and [DataGridColumn.CellTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellTextAlignment) property. The default text alignment is based on the type of the columns. The header and data rows are right aligned for numeric, date columns and left aligned for text column.

### Header customizations

#### HeaderText

To customize the display content of the header cell, use the [DataGridColumn.HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderText) property. It specifies the text displayed in the column header. If the header text is not defined, then `DataGridColumn.MappingName` will be assigned to the header text and will be displayed as a column header.

#### Header template

Based on the requirement, the header cell can be customized using the [DataGridColumn.HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderTemplate) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID">
            <syncfusion:DataGridTextColumn.HeaderTemplate>
                <DataTemplate>
                    <Label x:Name="OrderID"
                           Text="Order ID"
                           TextColor="Black"
                           BackgroundColor="Yellow" />
                </DataTemplate>
            </syncfusion:DataGridTextColumn.HeaderTemplate>
        </syncfusion:DataGridTextColumn>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

### Setting manual column width

The SfDataGrid allows you to customize the width of each DataGridColumn in the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) collection. To customize the column width, use the [DataGridColumn.Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Width) property. By default, this property will not be assigned any value. The DataGridColumn renders in a view based on the value of the [DefaultColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultColumnWidth) property.
SfDataGrid allows you to customize the width of each DataGridColumn in the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) collection. To customize column width, use the `DataGridColumn.Width` property. By default, this property will not be assigned any value. The DataGridColumn renders in view based on the value of the `DefaultColumnWidth` property.

N> Set the [Visible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Visible) property to `True` instead of setting the column width as `0` to hide a column.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AutoGenerateColumnsMode="None"
                       DefaultColumnWidth="120">
    <syncfusion:SfDataGrid.Columns x:TypeArguments="sfgrid:Columns">
        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                       HeaderText="Order ID"
                                       Width="100" />
    </syncfusion:SfDataGrid.Columns >
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs"%}
// AutoGenerated Column

dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;

private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "OrderID")
    {
        e.Column.Width = 100;
    }
}

// Manually generated column

dataGrid.Columns.Add(new DataGridTextColumn() { MappingName = "OrderID" ,Width = 100 });

{% endhighlight %}
{% endtabs %}

### Hiding a column 

To hide a particular column, use the `DataGridColumn.Visible` property. The default value of the `Visible` property is `True`. 

N> Set the `Visible` property to `False` instead of setting column width as `0` to hide a column.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}   
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AutoGenerateColumnsMode="None"
                       DefaultColumnWidth="120">
    <syncfusion:SfDataGrid.Columns>
    <syncfusion:DataGridTextColumn MappingName="OrderID"
                                   Visible="False" />
    </syncfusion:SfDataGrid.Columns >
</syncfusion:SfDataGrid> 
    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs"%}
// AutoGenerate Column

dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;

private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "OrderID")
    {
        e.Column.Visible = false;
    }
}

// Manually generated column
dataGrid.Columns.Add(new DataGridTextColumn() { MappingName = "OrderID", Visible = false});
{% endhighlight %}
{% endtabs %}

### Padding

The SfDataGrid allows users to set padding for the Header and cells in display mode by using the property [DataGridColumn.HeaderPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderPadding) and [DataGridColumn.CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellPadding). 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}    
    <syncfusion:DataGridTextColumn MappingName="OrderID"
                               CellTextAlignment="Start"
                               CellPadding="10,0,0,0"
                               HeaderPadding="10,0,0,0" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

DataGridTextColumn orderID = new DataGridTextColumn();
orderID.MappingName = "OrderID";
orderID.CellTextAlignment = TextAlignment.Start;
orderID.CellPadding = new Thickness(10, 0, 0, 0);
orderID.HeaderPadding = new Thickness(10, 0, 0, 0);

{% endhighlight %}
{% endtabs %}

### Formatting

To format values displayed in the DataGridColumn, use the [DataGridColumn.Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Format) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid.Columns>
    <syncfusion:DataGridTextColumn MappingName="Freight"
                                   Format="C" />
    <syncfusion:DataGridTextColumn MappingName="ShippingDate"
                                   Format="dd/MM/yyyy" />
</syncfusion:SfDataGrid.Columns>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs"%}
dataGrid.Columns.Add(new DataGridTextColumn()
{
    MappingName = "Freight",
    Format = "C"
});

dataGrid.Columns.Add(new DataGridTextColumn()
{
    MappingName = "ShippedDate",
    Format = "dd/MM/yyyy"
});
{% endhighlight %}
{% endtabs %}

#### Format column using converter

We can customize the format of a particular column using converter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.Resources>
    <local:SummaryConverter x:Key="summaryConverter"/>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn HeaderText="Freight"
                                       MappingName="Freight"
                                       DisplayBinding="{Binding Freight, Converter={StaticResource summaryConverter}}" />
    </syncfusion:SfDataGrid.Columns >
</syncfusion:SfDataGrid>
{% endhighlight%}
{% endtabs %}

{% tabs %}
{% highlight C# tabtitle="Converter.cs" %}
Public class SummaryConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var formattedString = string.Format("$ {0}", value);
        return formattedString;
    }
}
{% endhighlight%}
{% endtabs %}

N> For AutoGenerated columns, formatting can be applied by handling the [SfDataGrid.AutoGeneratingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingColumn) event.

## DataGridTextColumn

The DataGridTextColumn inherits all the properties of the DataGridColumn. It is used to host the textual content in the record cells. Each of the record cells displays text based on the  `MappingName` that associates the column with a property in the data source.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:DataGridTextColumn MappingName ="OrderID" /> 
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs"%}
dataGrid.Columns.Add( new DataGridTextColumn()
{ 
    MappingName = "OrderID"
});
{% endhighlight %}
{% endtabs %}

## DataGridCheckBoxColumn

The `DataGridCheckBoxColumn` inherits all the properties of the `DataGridColumn`. It loads a [CheckBox](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox) as the content of record cells in the column and responds to value changes in it. The underlying data source can be changed so that it toggles the values shown in the CheckBox. The `SfDataGrid` automatically generates `DataGridCheckBoxColumn` the property in the underlying collection of the type is set to bool.
 
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridCheckBoxColumn MappingName="IsOnline"
                                           HeaderText="Is Online" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

![DataGrid with CheckBox column](Images\column-types\maui-datagrid-column-checkbox.png)

## DataGridImageColumn

The `DataGridImageColumn` is derived from the `DataGridColumn`. Hence, it inherits all the properties of the `DataGridColumn`. It displays an image as the cell content of a column. To create a `DataGridImageColumn`, the property corresponding to the column in the underlying collection must be `ImageSource` type.

It is possible to load images in any of the following four ways:

 * **FromFile**: Required to specify the path of the file.
 * **FromResource**: Required to set an image as an embedded resource.
 * **FromStream**: Required to load an image from the byte[] array.
 * **FromURI**: Required to set an image from a web service or website.

{% tabs %} 
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       ColumnWidthMode="Fill"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridImageColumn  MappingName="DealerImage"
                                         HeaderText="Dealer Image" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

![DataGrid with image column](Images\column-types\maui-datagrid-column-imagecolumn.png)

### Aspect

The SfDataGrid allows you to set the [Aspect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html#Syncfusion_Maui_DataGrid_DataGridImageColumn_Aspect) to size the loaded images within the bounds of the grid cell (whether to stretch, crop or letterbox) using the `DataGridImageColumn.Aspect` property. The default value is `AspectFit`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <sfGrid:DataGridImageColumn MappingName="DealerImage"
                                    Aspect="AspectFit" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

## DataGridTemplateColumn

The `DataGridTemplateColumn` is derived from the `DataGridColumn`, hence, it inherits all the properties of the `DataGridColumn`. It allows you to extend the functionality of the `DataGridColumn` with your own view by creating the [CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html#Syncfusion_Maui_DataGrid_DataGridTemplateColumn_CellTemplate).

Underlying records will be the BindingContext for the `CellTemplate`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:DataGridTemplateColumn MappingName="CustomerID"
                                   HeaderText="Customer ID">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <StackLayout>
                <Label Text="{Binding CustomerID}"
                       TextColor="Blue" />
            </StackLayout>
        </DataTemplate>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>
{% endhighlight %}
{% endtabs %}

### Edit template

The `SfDataGrid` allows you to load any custom view in edit mode using the [EditTemplate]() property.

{% highlight xaml %}
    <ContentPage.Content>
        <syncfusion:SfDataGrid x:Name="dataGrid"
                               ItemsSource="{Binding OrderInfoCollection}"
                               SelectionMode="Multiple"
                               NavigationMode="Cell"
                               AllowEditing="True"
                               AutoGenerateColumnsMode="None">
            <syncfusion:SfDataGrid.Columns>
                <syncfusion:DataGridNumericColumn Format="#"
                                                  MappingName="OrderID"
                                                  HeaderText="Order ID" />
                <syncfusion:DataGridTextColumn ColumnWidthMode="FitByHeader"
                                               MappingName="Name"
                                               HeaderText="Customer ID" />
                <syncfusion:DataGridTextColumn  MappingName="ShipCountry"
                                                HeaderText="Ship Country" />
                <syncfusion:DataGridTemplateColumn HeaderText="Is Confirmed"
                                                   MappingName="IsOnline"
                                                   Width="100">
                    <syncfusion:DataGridTemplateColumn.CellTemplate>
                        <DataTemplate>
                            <Grid>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="Auto" />
                                    <ColumnDefinition Width="*" />
                                </Grid.ColumnDefinitions>
                                <Label x:Name="changeValue"
                                       Grid.Column="1"
                                       HorizontalTextAlignment="Center"
                                       VerticalTextAlignment="Center"
                                       Text="{Binding IsOnline}"
                                       TextColor="Black" />
                            </Grid>
                        </DataTemplate>
                    </syncfusion:DataGridTemplateColumn.CellTemplate>
                    <syncfusion:DataGridTemplateColumn.EditTemplate>
                        <DataTemplate>
                            <Grid>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="Auto" />
                                    <ColumnDefinition Width="*" />
                                </Grid.ColumnDefinitions>
                                <CheckBox Grid.Column="1"
                                          IsChecked="{Binding IsOnline}">
                                </CheckBox>
                            </Grid>
                        </DataTemplate>
                    </syncfusion:DataGridTemplateColumn.EditTemplate>
                </syncfusion:DataGridTemplateColumn>
            </syncfusion:SfDataGrid.Columns>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
{% endhighlight %}

### Load view through template selector

You can load any view to the cells through the `CellTemplate` by assigning the `TemplateSelector`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="low" >
            <Label Text="{Binding Freight}"
                   TextColor="White" 
                   BackgroundColor="Red" 
                   HorizontalTextAlignment="Center" 
                   VerticalTextAlignment="Center" />
        </DataTemplate>
        <DataTemplate x:Key="average" >
            <Label Text="{Binding Freight}"
                   TextColor="Black" 
                   BackgroundColor="Yellow" 
                   HorizontalTextAlignment="Center" 
                   VerticalTextAlignment="Center" />
        </DataTemplate>
        <DataTemplate x:Key="high" >
            <Label Text="{Binding Freight}" 
                   TextColor="White" 
                   BackgroundColor="Green" 
                   HorizontalTextAlignment="Center" 
                   VerticalTextAlignment="Center" />
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:DataGridTemplateColumn MappingName="Freight"
                                   HeaderText="Freight">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <local:FreightTemplateSelector High="{StaticResource high}"
                                       Average="{StaticResource average}"
                                       Low="{StaticResource low}" />
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="TemplateSelector.cs"%}
// FreightTemplateSelector implementation
public class FreightTemplateSelector : DataTemplateSelector
{
    public DataTemplate Low { get; set; }

    public DataTemplate Average { get; set; }

    public DataTemplate High { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var value = double.Parse((item as OrderInfo).Freight);
        if (value > 750)
            return High;
        else if (value > 500)
            return Average;
        else
            return Low;
    }
}
{% endhighlight %}
{% endtabs %}

![DataGrid with Template column contain cell Template selector](Images\column-types\maui-datagrid-templatecolumn-celltemplate-celltemplateselector.png)

### Loading DatePicker
You can load the `DatePicker` control in cells using the `DataGridTemplateColumn`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:DataGridTemplateColumn MappingName="ShippingDate"
                                   HeaderText="Shipping Date">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <StackLayout  Margin="10">
                <DatePicker Date="{Binding ShippedDate}"
                            TextColor="Black" />
            </StackLayout>
        </DataTemplate>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>
{% endhighlight %}
{% endtabs %}

## DataGridDateColumn

The `DataGridDateColumn` inherits all the properties of the `DataGridColumn`.It displays the date information as the content of a column. To create the  `DataGridDateColumn`, the property corresponding to the column in the underlying collection must be of the type DateTime. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel x:Name ="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridDateColumn Format="d"
                                       HeaderText="Date"
                                       MappingName="ShippedDate" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs"%}
dataGrid = new SfDataGrid();
DataGridDateColumn dateColumn = new DataGridDateColumn()
{
    MappingName = "ShippedDate",
    HeaderText = "Date",
    Format = "d"
};
dataGrid.Columns.Add(dateColumn);
{% endhighlight %}
{% endtabs %}

## DataGridComboBoxColumn

The [DataGridComboBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html) inherits all the properties of the [SfDataGrid.DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html). It displays a list of items in the form of a [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) as the content of a column. To enable or disable editing for a particular column, set the [DataGridColumn.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_AllowEditing) property to true or false. When in editing mode, it displays a `SfComboBox` element. The data source for the `SfComboBox` can be set using the [DataGridComboBoxColumn.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html#Syncfusion_Maui_DataGrid_DataGridComboBoxColumn_ItemsSource) property. The combobox column can be populated with data in the following ways:

* Collection of primitive types
* Collection of user-defined types (custom objects)

![DataGrid with editing in comboBox column](Images\column-types\maui-datagrid-comboBox-column.png)

### Collection of primitive types

To display the collection of items in the ComboBox drop-down, create a `DataGridComboBoxColumn` and set its `ItemsSource` property to a simple collection.

To load the `DataGridComboBoxColumn` with a simple string collection, you can refer to the code example below:

{% tabs %}
{% highlight xaml %}
    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <sfGrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
        <sfGrid:SfDataGrid.Columns>
            <sfgrid:DataGridComboBoxColumn BindingContext="{x:Reference viewModel}"
                                           HeaderText="Name"
                                           ItemsSource="{Binding CustomerNames}"
                                           MappingName="DealerName" />
        </sfGrid:SfDataGrid.Columns>
    </sfGrid:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid = new SfDataGrid();
DataGridComboBoxColumn comboBoxColumn = new DataGridComboBoxColumn()
{
    BindingContext = viewModel,
    MappingName = "DealerName",
    ItemsSource = viewModel.CustomerNames,
    HeaderText = "Name"

};
dataGrid.Columns.Add(comboBoxColumn);
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

public class ViewModel
{
    public ObservableCollection<string> CustomerNames { get; set; }

    public ViewModel()
    {
        this.CustomerNames = Customers.ToObservableCollection();
    }

    internal string[] Customers = new string[] {"Adams","Crowley","Ellis","Gable","Irvine","Keefe","Mendoza","Owens","Rooney","Wadded",};
    
}
{% endhighlight %}
{% endtabs %}

### Collection of user-defined types

To display a list of user-defined items in the drop-down of a combo box, create a `DataGridComboBoxColumn` and set its `ItemsSource` property to a user-defined collection. By default, if the [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html#Syncfusion_Maui_DataGrid_DataGridComboBoxColumn_DisplayMemberPath) is not set, the combo box column will display the values from the `MappingName` property of the column.

### Loading different ItemSource for each row of DataGridComboBoxColumn

To load different ItemSources for each row of a DataGridComboBoxColumn, you can utilize the [DataGridComboBoxColumn.ItemsSourceSelector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html#Syncfusion_Maui_DataGrid_DataGridComboBoxColumn_ItemsSourceSelector) property.

### Implementing IItemsSourceSelector

`DataGridComboBoxColumn.ItemsSourceSelector` needs to implement the IItemsSourceSelector interface, which requires you to implement the GetItemsSource method. This method receives the following parameters:

* Record: This is the data object associated with the row.
* Data Context: This is the binding context of the data grid.

In the provided code, the ItemsSource for the ShipCity column is returned based on the value of the ShipCountry column. This is done by using the record and the binding context of the data grid, which are passed to the GetItemsSource method.

{% tabs %}
{% highlight xaml %}
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:ItemSourceSelector x:Key="converter" />
        </ResourceDictionary>
    </ContentPage.Resources>

    <sfgrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding DealerInformation}"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None"
                       NavigationMode="Cell"
                       EditTapAction="OnDoubleTap"
                       SelectionMode="Single">
        <sfgrid:SfDataGrid.Columns>
            <sfgrid:DataGridComboBoxColumn BindingContext="{x:Reference viewModel}"
                                           ItemsSource="{Binding CountryList}"
                                           MappingName="ShipCountry"
                                           LoadUIView="True">
            </sfgrid:DataGridComboBoxColumn>

            <sfgrid:DataGridComboBoxColumn ItemsSourceSelector="{StaticResource converter}"
                                           MappingName="ShipCity"
                                           LoadUIView="True">
            </sfgrid:DataGridComboBoxColumn>
        </sfgrid:SfDataGrid.Columns>
    </sfgrid:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
public class ItemSourceSelector : IItemsSourceSelector
{
    public IEnumerable GetItemsSource(object record, object dataContext)
    {
        if (record == null)
        {
            return null;
        }

        var orderinfo = record as DealerInfo;
        var countryName = orderinfo.ShipCountry;
        var viewModel = dataContext as EditingViewModel;

        // Returns ShipCity collection based on ShipCountry.
        if (viewModel.ShipCities.ContainsKey(countryName))
        {
            string[] shipcities = null;
            viewModel.ShipCities.TryGetValue(countryName, out shipcities);
            return shipcities.ToList();
        }

        return null;
    }
}
{% endhighlight %}
{% endtabs %}

![DataGrid with ItemSourceSelector comboBox column](Images\column-types\maui-datagrid-comboBox-column-itemsourceselector.png)
![DataGrid with ItemSourceSelector comboBox column](Images\column-types\maui-datagrid-comboBox-column-itemsourceselector2.png)

### Editing the combo box

The `DataGridComboBoxColumn` supports both editable and non-editable text boxes for selecting items from a given data source. Users can choose one item from the suggestion list.

The [IsEditableMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html#Syncfusion_Maui_DataGrid_DataGridComboBoxColumn_IsEditableMode) property is used to enable the user input in `DataGridComboBoxColumn`. Its default value is `false`.

{% tabs %}
{% highlight xaml %}
    <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <sfGrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
        <sfGrid:SfDataGrid.Columns>
            <sfgrid:DataGridComboBoxColumn BindingContext="{x:Reference viewModel}"
                                           HeaderText="Name"
                                           IsEditableMode="True"
                                           ItemsSource="{Binding CustomerNames}"
                                           MappingName="DealerName" />
        </sfGrid:SfDataGrid.Columns>
    </sfGrid:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid = new SfDataGrid();
DataGridComboBoxColumn comboBoxColumn = new DataGridComboBoxColumn()
{
    BindingContext = viewModel,
    MappingName = "DealerName",
    ItemsSource = viewModel.CustomerNames,
    IsEditableMode = True,
    HeaderText = "Name"

};
dataGrid.Columns.Add(comboBoxColumn);
{% endhighlight %}
{% endtabs %}

![DataGrid with Edited comboBox column](Images\column-types\maui-datagrid-combobox-column-editing.png)

### Auto suggesting on edit mode

By default, the auto-suggestion in the dropdown will display values based on the [StartsWith](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_StartsWith) filter condition. However, you can change this behavior by utilizing the [SuggestionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html#Syncfusion_Maui_DataGrid_DataGridComboBoxColumn_SuggestionMode) property to retrieve matches using the `Contains` condition.

{% tabs %}
{% highlight xaml %}
    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <sfGrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
        <sfGrid:SfDataGrid.Columns>
            <sfgrid:DataGridComboBoxColumn BindingContext="{x:Reference viewModel}"
                                           HeaderText="Name"
                                           IsEditableMode="True"
                                           SuggestionMode="Contains"
                                           ItemsSource="{Binding CustomerNames}"
                                           MappingName="DealerName" />
        </sfGrid:SfDataGrid.Columns>
    </sfGrid:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid = new SfDataGrid();
DataGridComboBoxColumn comboBoxColumn = new DataGridComboBoxColumn()
{
    BindingContext = viewModel,
    MappingName = "DealerName",
    ItemsSource = viewModel.CustomerNames,
    IsEditableMode = True,
    SuggestionMode = SuggestionMode.Contains,
    HeaderText = "Name"

};
dataGrid.Columns.Add(comboBoxColumn);
{% endhighlight %}
{% endtabs %}

![DataGrid with Suggesting comboBox column](Images\column-types\maui-datagrid-combobox-column-editing.png)

### Change clear button visibility

The ComboBox control includes a clear button that allows users to easily remove the entered input. The visibility of the clear button can be adjusted using the [ShowClearButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html#Syncfusion_Maui_DataGrid_DataGridComboBoxColumn_ShowClearButton) property. By default, the `ShowClearButton` property is set to true.

{% tabs %}
{% highlight xaml %}
    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <sfGrid:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
        <sfGrid:SfDataGrid.Columns>
            <sfgrid:DataGridComboBoxColumn BindingContext="{x:Reference viewModel}"
                                           HeaderText="Name"
                                           IsEditableMode="True"
                                           ShowClearButton="False"
                                           ItemsSource="{Binding CustomerNames}"
                                           MappingName="DealerName" />
        </sfGrid:SfDataGrid.Columns>
    </sfGrid:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid = new SfDataGrid();
DataGridComboBoxColumn comboBoxColumn = new DataGridComboBoxColumn()
{
    BindingContext = viewModel,
    MappingName = "DealerName",
    IsEditableMode= true,
    ItemsSource = viewModel.CustomerNames,
    HeaderText = "Name",
    ShowClearButton= false,

};
dataGrid.Columns.Add(comboBoxColumn);
{% endhighlight %}
{% endtabs %}

N> The `ShowClearButton` property has no effect in non-editable mode..

## DataGridNumericColumn

The `DataGridNumericColumn` inherits all the properties of the `DataGridColumn`. It is used to display numeric data. To create a  `DataGridNumericColumn`, the property corresponding to the column in the underlying collection must be a numeric type (int, double, float, etc.). 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel  x:Name ="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn Format="C"
                                          HeaderText="ID"
                                          MappingName="OrderID" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs"%}
dataGrid = new SfDataGrid();
            
DataGridNumericColumn numericColumn = new DataGridNumericColumn()
{
    MappingName = "OrderID",
    HeaderText = "OrderID",
};
dataGrid.Columns.Add(numericColumn);
{% endhighlight %}
{% endtabs %}

## Row header

The row header is a type of column that is placed as the first cell of each row and remains frozen. To enable the row header, set `SfDataGrid.ShowRowHeader` to `true` Additionally, the `SfDataGrid` allows you to customize the row header width using the `SfDataGrid.RowHeaderWidth` property. The default value is 30.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                  ShowRowHeader="True"
                  ItemsSource="{Binding OrderInfoCollection}"
                  GridLinesVisibility="Both"
                  HeaderGridLinesVisibility="Both">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Row header .NET MAUI DataGrid" src="Images\column-types\maui-datagrid-show-row-header.png" width="404"/>

### Load template in row header

The data template can be loaded to the row header by setting the `SfDataGrid.RowHeaderTemplate` property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                  ShowRowHeader="True"
                  ItemsSource="{Binding OrderInfoCollection}"
                  GridLinesVisibility="Both"
                  HeaderGridLinesVisibility="Both">                 
        <syncfusion:SfDataGrid.RowHeaderTemplate>
                <DataTemplate>
                    <Label Text="{Binding ID}" HorizontalTextAlignment = "Center" VerticalTextAlignment = "Center"/>
                </DataTemplate>
        </syncfusion:SfDataGrid.RowHeaderTemplate>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

<img alt="Row header in .NET MAUI DataGrid" src="Images\column-types\maui-datagrid-show-row-header-load-template.png" width="404"/>

## Allow Null Value

The `DataGridNumericColumn.AllowNull` property allows you to commit a null value to the respective cell during the end edit. 

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AutoGenerateColumnsMode="None"
                       AllowEditing="True"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       ItemsSource="{Binding OrderInfoCollection}">
     <syncfusion:SfDataGrid.Columns>
         <syncfusion:DataGridNumericColumn HeaderText="Order ID" 
                                           MappingName="OrderID" 
                                           AllowNull="True" />   
     </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>

{% endhighlight %}

{% highlight c# %}
dataGrid = new SfDataGrid();
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
DataGridNumericColumn numericColumn = new DataGridNumericColumn()
{
    MappingName = "OrderID",
    HeaderText = "OrderID",
    AllowNull = true,
};
dataGrid.Columns.Add(numericColumn);

{% endhighlight %}

{% endtabs %}

## Bind a view model property inside header template

The SfDataGrid allows binding the view model property to the `HeaderTemplate` by setting the BindingContext of the `DataGridColumn` as `ViewModel`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID">
            <syncfusion:DataGridColumn.HeaderTemplate>
                <DataTemplate>
                    <StackLayout>
                        <Label BindingContext="{StaticResource viewModel}"
                               Text="{Binding Headertext}"
                               VerticalOptions="CenterAndExpand"
                               HorizontalOptions="CenterAndExpand"
                               TextColor="Blue"
                               IsVisible="{Binding Visibility}" />
                    </StackLayout>
                </DataTemplate>
            </syncfusion:DataGridColumn.HeaderTemplate>
        </syncfusion:DataGridTextColumn>
        <syncfusion:DataGridTextColumn  MappingName="CustomerID"
                                        HeaderText="Customer" />
        <syncfusion:DataGridTextColumn MappingName="ShipCountry"
                                       HeaderText="Country" />
        <syncfusion:DataGridTextColumn MappingName="ShipCity"
                                       HeaderText="City" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% endtabs %}

![DataGrid with header template bind to view model](Images\column-types\maui-datagrid-header-template-view-model.png)

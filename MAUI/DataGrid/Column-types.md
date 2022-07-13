---
layout: post
title: Column Types in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Column Types support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Column Types in .NET MAUI DataGrid (SfDataGrid)

The SfDataGrid contains different types of columns. The functionalities of the column can be implied by its name. Based on the requirements any column can be used. 

The following table describes the types of columns and its usage:

<table>
<tr>
<th>Column Type</th>
<th>Renderer</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[DataGridTextColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTextColumn.html)'| markdownify }}</td>
<td>{{'[DataGridTextBoxRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTextBoxCellRenderer.html)' | markdownify }}</td>
<td>To display string or numbers in each row.</td>
</tr>
<tr>
<td>{{'[DataGridCheckBoxColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxColumn.html)'| markdownify }}</td>
<td>{{'[DataGridCheckBoxRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCheckBoxCellRenderer.html)'| markdownify }}</td>
<td>To display CheckBox in each row.</td>
</tr>
<tr>
<td>{{'[DataGridImageColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html)'| markdownify }}</td>
<td>{{'[DataGridImageCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageCellRenderer.html)'| markdownify }}</td>
<td>To display an image in each row.</td>
</tr>
<tr>
<td>{{'[DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html)'| markdownify }}</td>
<td>{{'[DataGridCellTemplateRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTemplateRenderer.html)'| markdownify }}</td>
<td>To customize the column based on the requirements.</td>
</tr>
<tr>
<td>{{'[DataGridNumericColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridNumericColumn.html)'| markdownify }}</td>
<td>{{'[DataGridNumericCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridNumericCellRenderer.html)'| markdownify }}</td>
<td>To display a numeric data.</td>
</tr>
<tr>
<td>{{'[DataGridDateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDateColumn.html)'| markdownify }}</td>
<td>{{'[DataGridDateCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDateCellRenderer.html)'| markdownify }}</td>
<td>To display the date and time value.</td>
</tr>
</table>


## DataGridColumn

The [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html) is the base column types of all columns. Hence its properties are used by all the columns. The following sub-sections explain the properties and customizations of DataGridColumn.

### Binding options

Display content of the DataGridColumn is determined from the [DataGridColumn.DisplayBinding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_DisplayBinding) property. It gets or sets display binding that associates the DataGridColumn with a property in the data source. 

#### Mapping column to particular property

The [DataGridColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MappingName) associates the DataGridColumn with a property available in the underlying data source. While setting MappingName alone to the SfDataGrid, the `DataGridColumn.DisplayBinding` will be automatically generated based on the MappingName. Data manipulation operations like sorting and filtering will be done based on the MappingName property.

To format cell content, use the converter of the `DataGridColumn.DisplayBinding` to customize the cell content.


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

{% highlight c# tabtitle="MainPage.xaml.cs" %}
//Customizing row height in SfDataGrid
dataGrid.HeaderRowHeight = 60;
{% endhighlight %}

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

### TextAlignment

In order to set the TextAlignment of the header cell and data row cell , use the [DataGridColumn.HeaderTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderTextAlignment) and [DataGridColumn.cellTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellTextAlignment) property. The default text alignment is based on the type of the columns. The header and data rows are right aligned for numeric, date columns and left aligned for text column.

### Header customizations

#### HeaderText

To customize the display content of the header cell, use the [DataGridColumn.HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderText) property. It specifies the text displayed in the column header. If header text is not defined, then `DataGridColumn.MappingName` will be assigned to the header text and will be displayed as column header.

#### Header template

Based on the requirement, the header cell can be customized using the [DataGridColumn.HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderTemplate) property.

{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid.Columns>
    <syncfusion:DataGridTextColumn MappingName="OrderID">
        <syncfusion:DataGridTextColumn.HeaderTemplate>
            <DataTemplate>
                <Label x:Name="OrderID" Text="OrderID" TextColor="Black" 
                BackgroundColor="Yellow"  />
            </DataTemplate>
        </syncfusion:DataGridTextColumn.HeaderTemplate>
    </syncfusion:DataGridTextColumn>
</syncfusion:SfDataGrid.Columns> 
{% endhighlight %}

### Setting manual column width

SfDataGrid allows you to customize the width of each DataGridColumn in the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) collection. To customize column width, use the [DataGridColumn.Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Width) property. By default, this property will not be assigned any value. The DataGridColumn renders in view based on the value of the [DefaultColumnWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultColumnWidth) property.
SfDataGrid allows you to customize the width of each DataGridColumn in the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) collection. To customize column width, use the [DataGridColumn.Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Width) property. By default, this property will not be assigned any value. The DataGridColumn renders in view based on the value of the `DefaultColumnWidth` property.

N> Set the [Visible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Visible) property to `True` instead of setting column width as `0` to hide a column.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}" AutoGenerateColumnsMode="None">
        <syncfusion:SfDataGrid.Columns x:TypeArguments="sfgrid:Columns">
        <syncfusion:DataGridTextColumn MappingName="OrderID" HeaderText="Order ID"
                             Width="100"/>
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
    <syncfusion:DataGridTextColumn MappingName="OrderID" Visible = "False"/>
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

SfDataGrid allows the users to set padding for the Header and cells in display mode by using the property [DataGridColumn.HeaderPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderPadding) and [DataGridColumn.CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellPadding). 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}    
    <syncfusion:DataGridTextColumn MappingName="OrderID" CellTextAlignment="Start" CellPadding="10,0,0,0"  HeaderPadding="10,0,0,0"/>
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
    <syncfusion:DataGridTextColumn MappingName="Freight" Format="C" />
    <syncfusion:DataGridTextColumn MappingName="ShippingDate" Format="dd/MM/yyyy" />
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

We can customise the format of a particular column using converter.

{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.Resources>
    <local:SummaryConverter x:Key="summaryConverter"/>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns >
        <syncfusion:DataGridTextColumn HeaderText="Freight" MappingName="Freight" DisplayBinding="{Binding Freight, Converter={StaticResource summaryConverter}}" />
    </syncfusion:SfDataGrid.Columns >
</syncfusion:SfDataGrid>
{% endhighlight%}

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

N> For AutoGenerated columns formatting can be applied by handling the [SfDataGrid.AutoGeneratingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingColumn) event.

## DataGridTextColumn

DataGridTextColumn inherits all the properties of DataGridColumn. It is used to host the textual content in the record cells. Each of the record cell displays text based on the `MappingName` that associates the column with a property in the data source.

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

DataGridCheckBoxColumn inherits all the properties of `DataGridColumn`. It loads a [CheckBox](https://docs.microsoft.com/en-us/dotnet/maui/user-interface/controls/checkbox) as the content of record cells in the column and responds to value changes in it. The underlying data source can be changed that it toggles the values shown in the CheckBox. The SfDataGrid automatically generates DataGridCheckBoxColumn if the property in the underlying collection of type set to bool.
 
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                   ItemsSource="{Binding OrdersInfo}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridCheckBoxColumn MappingName="IsOnline" HeaderText="Is Online" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid> 
{% endhighlight %}

![DataGrid with CheckBox column](Images\column-types\maui-datagrid-column-checkbox.png)


## DataGridImageColumn

DataGridImageColumn is derived from DataGridColumn. Hence, it inherits all the properties of DataGridColumn. It displays image as cell content of a column. To create DataGridImageColumn, the property corresponding to the column in the underlying collection must be `ImageSource` type.

It is possible to load images in any of the following four ways:

 * **FromFile**: Required to specify the path of the file.
 * **FromResource**: Required to set image as embedded resource.
 * **FromStream**: Required to load image from byte[] array.
 * **FromURI**: Required to set image from a web service or website.
 
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}"  ColumnWidthMode="Fill" utoGenerateColumnsMode="None">
    <syncfusion:SfDataGrid.Columns >
        <syncfusion:DataGridImageColumn  MappingName="DealerImage" HeaderText="Dealer Image" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

![DataGrid with image column](Images\column-types\maui-datagrid-column-imagecolumn.png)
### Aspect

SfDataGrid allows you to set the [Aspect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html#Syncfusion_Maui_DataGrid_DataGridImageColumn_Aspect) to size the loaded images within the bounds of the grid cell (whether to stretch, crop or letterbox) using the `DataGridImageColumn.Aspect` property. The supported aspects are described below, the default value is AspectFit.

The supported aspects are described below,

* **AspectFill**: Clips the image so that it fills the display area while preserving the aspect (no distortion).

* **AspectFit**: Letterboxes the image (if required) so that the entire image fits into the display area, with blank space added to the top/bottom or sides depending on whether the image is wide or tall.

* **Fill**: Stretches the image to completely and exactly fill the display area. This may result in the image being distorted.

* **Center**: Places the image to the center of the cell.

To set `Aspect` to images loaded inside `DataGridImageColumn`, refer the below code snippet.

{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                   AutoGenerateColumnsMode="None"
                   ItemsSource="{Binding OrdersInfo}">
    <syncfusion:SfDataGrid.Columns>
        <sfGrid:DataGridImageColumn MappingName="DealerImage" Aspect="AspectFit"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

## DataGridTemplateColumn

The DataGridTemplateColumn is derived from DataGridColumn. Hence, it inherits all the properties of DataGridColumn. It allows you to extend the functionality of DataGridColumn with own view by creating the [CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html#Syncfusion_Maui_DataGrid_DataGridTemplateColumn_CellTemplate).

Underlying records will be the BindingContext for the `CellTemplate`. The following code example shows templating of DataGridTemplateColumn:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:DataGridTemplateColumn MappingName="CustomerID" HeaderText="Customer ID">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <StackLayout>
                <Label Text="{Binding CustomerID}" TextColor="Blue" />
            </StackLayout>
        </DataTemplate>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>

### Load view through template selector

You can load any view to the cells through the `CellTemplate` by assigning the `TemplateSelector`.

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

<syncfusion:DataGridTemplateColumn MappingName="Freight" HeaderText="Freight">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
            <local:FreightTemplateSelector High="{StaticResource high}" Average="{StaticResource average}" Low="{StaticResource low}"/>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>
{% endhighlight %}

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

![DataGrid with Template column contain cell Template selector](Images\column-types\maui-datagrid-templatecolumn-celltemplate-celltemplateselector.png)

### Loading DatePicker
You can load the `DatePicker` control in cells using the `DataGridTemplateColumn`.

{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:DataGridTemplateColumn MappingName="ShippingDate" HeaderText="Shipping Date">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <StackLayout  Margin="10">
                <DatePicker Date="{Binding ShippedDate}" TextColor="Black"/>
            </StackLayout>
        </DataTemplate>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>
{% endhighlight %}

## DataGridDateColumn

The DataGridDateColumn inherits all the properties of the `DataGridColumn`. It displays the date information as the content of a column. To create the `SfDataGrid.DataGridDateColumn`, the property corresponding to the column in the underlying collection must be of type DateTime. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel x:Name ="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="DataGrid" ItemsSource="{Binding OrderInfoCollection}" AutoGenerateColumnsMode="None">
        <syncfusion:SfDataGrid.Columns >
           <syncfusion:DataGridDateColumn Format="d"  HeaderText="Date" MappingName="ShippedDate" />
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

## DataGridNumericColumn

The `DataGridNumericColumn` inherits all the properties of `DataGridColumn`. It is used to display numeric data. To create `DataGridNumericColumn`, the property corresponding to the column in the underlying collection must be a numeric type(int, double, float, etc.).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<ContentPage.BindingContext>
    <local:ViewModel  x:Name ="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"           
                   ItemsSource="{Binding OrdersInfo}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn Format="C" HeaderText="ID" MappingName="OrderID"/>
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

## Bind a view model property inside header template

The SfDataGrid allows binding the view model property to the `HeaderTemplate` by setting the BindingContext of the `DataGridColumn` as `ViewModel`.

{% highlight xaml tabtitle="MainPage.xaml" %}

<syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}" AutoGenerateColumnsMode="None">
            <syncfusion:SfDataGrid.Columns >
                <syncfusion:DataGridTextColumn MappingName="OrderID"  >
                    <syncfusion:DataGridColumn.HeaderTemplate>
                        <DataTemplate>
                            <StackLayout>
                                <Label BindingContext="{StaticResource viewModel}" Text="{Binding Headertext}" VerticalOptions="CenterAndExpand" HorizontalOptions="CenterAndExpand" TextColor="Blue" IsVisible="{Binding Visibility}"/>
                            </StackLayout>
                        </DataTemplate>
                    </syncfusion:DataGridColumn.HeaderTemplate>
                </syncfusion:DataGridTextColumn>
                <syncfusion:DataGridTextColumn  MappingName="CustomerID" HeaderText="Customer" />
                <syncfusion:DataGridTextColumn MappingName="ShipCountry" HeaderText="Country" />
                <syncfusion:DataGridTextColumn MappingName="ShipCity" HeaderText="City" />
            </syncfusion:SfDataGrid.Columns>
        </syncfusion:SfDataGrid>

{% endhighlight %}

![DataGrid with header template bind to view model](Images\column-types\maui-datagrid-header-template-view-model.png)
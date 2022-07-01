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
<td>To display Checkbox in each row.</td>
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

The actual bound value of the DataGridColumn is determined from `DataGridColumn.ValueBinding` property. It gets or sets value binding that associates the DataGridColumn with a property in the data source.  

#### Mapping column to particular property

The [DataGridColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MappingName) associates the DataGridColumn with a property available in the underlying data source. While setting MappingName alone to the SfDataGrid, the `DataGridColumn.DisplayBinding` will be automatically generated based on the MappingName. Data manipulation operations like sorting, filtering, and grouping will be done based on the MappingName property.

To format cell content, use the converter of the `DataGridColumn.DisplayBinding` to customize the cell content. The following code example appends the text “Customer” along with the Customer ID:

{% highlight xaml %}
<ContentPage.Resources>
    <ResourceDictionary>
        <local:DisplayBindingConverter x:Key="displayBindingConverter" />
    </ResourceDictionary>
</ContentPage.Resources> 

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrdersInfo}">

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="CustomerID" 
                                   DisplayBinding="{Binding CustomerID, 
                                   Converter={StaticResource displayBindingConverter}}" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid> 
{% endhighlight %}

{% highlight c# %}
public class DisplayBindingConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
            return "Customer : " + value.ToString();
        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value.ToString().Substring(9);
    }
}
{% endhighlight %}



### TextAlignment

To get or set the TextAlignment of the header cell and data row cell , use the [DataGridColumn.HeaderTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderTextAlignment) and [DataGridColumn.cellTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellTextAlignment) property. The default alignment is `Center`. It can be customized as `Start` or `End`.

### Header customizations

#### HeaderText

To customize the display content of the header cell, use the [DataGridColumn.HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderText) property. It specifies the text displayed in the column header. If header text is not defined, then `DataGridColumn.MappingName` will be assigned to the header text and will be displayed as column header.

#### HeaderTemplate

Based on the requirement, the header cell can be customized using the [DataGridColumn.HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_HeaderTemplate) property. To customize header cell by loading a template in the header cell, follow the code example:

{% highlight xaml %}
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

SfDataGrid allows you to customize the width of each DataGridColumn in the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) collection. To customize column width, use the [DataGridColumn.Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Width) property. By default, this property will not be assigned any value. The DataGridColumn renders in view based on the value of the {DefaultColumnWidth` property.
SfDataGrid allows you to customize the width of each DataGridColumn in the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) collection. To customize column width, use the [DataGridColumn.Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Width) property. By default, this property will not be assigned any value. The DataGridColumn renders in view based on the value of the [DefaultColumnWidth]() property.

N> Set the [Visible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Visible) property to `True` instead of setting column width as `0` to hide a column.

Customize the width for auto generated columns in both XAML and code as follows:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}" AutoGenerateColumnsMode="None">
        <syncfusion:SfDataGrid.Columns x:TypeArguments="sfgrid:Columns">
        <syncfusion:DataGridTextColumn MappingName="OrderID" HeaderText="Order ID"
                             Width="100"/>
        </syncfusion:SfDataGrid.Columns >
    </syncfusion:SfDataGrid>
  
{% endhighlight %}
{% highlight c# %}
// AutoGenerated Column

dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;

void dataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e){
if (e.Column.MappingName == "OrderID") {
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

To hide column using the `Visible` property, follow the code example:

{% tabs %}
{% highlight xaml %}    
    <syncfusion:DataGridTextColumn MappingName="OrderID" Visible = "False"/>
{% endhighlight %}
{% highlight c# %}
// AutoGenerate Column

dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;

void dataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e){
if (e.Column.MappingName == "OrderID") {
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
{% highlight xaml %}    
    <syncfusion:DataGridTextColumn MappingName="OrderID" CellTextAlignment="Start" CellPadding="10,0,0,0"  HeaderPadding="10,0,0,0"/>
{% endhighlight %}

{% highlight c# %}

DataGridTextColumn orderID = new DataGridTextColumn();
orderID.MappingName = "OrderID";
orderID.CellTextAlignment = TextAlignment.Start;
orderID.CellPadding = new Thickness(10, 0, 0, 0);
orderID.HeaderPadding = new Thickness(10, 0, 0, 0);

{% endhighlight %}
{% endtabs %}

### Formatting

To format values displayed in the DataGridColumn, use the [DataGridColumn.Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Format) property.

#### Format column using StringFormat

Assign the format of string to the `DataGridColumn.Format` property based on the bound data type of the property, the DataGridColumn is associated to format the value. You can use different `StringFormats` to customize values displayed in the record cells.

To apply formatting for a DataGridTextColumn, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid.Columns>
    <syncfusion:DataGridTextColumn MappingName="Freight" Format="C" />
    <syncfusion:DataGridTextColumn MappingName="ShippingDate" Format="dd/MM/yyyy" />
</syncfusion:SfDataGrid.Columns> 
{% endhighlight %}
{% highlight c# %}
dataGrid.Columns.Add (new GridTextColumn () { 
    MappingName = "Freight",
    Format = "C"
});

dataGrid.Columns.Add (new GridTextColumn () { 
    MappingName = "ShippingDate",
    Format = "dd/MM/yyyy"
});
{% endhighlight %}
{% endtabs %}

## DataGridTextColumn

DataGridTextColumn inherits all the properties of DataGridColumn. It is used to host the textual content in the record cells. Each of the record cell displays text based on the `MappingName` that associates the column with a property in the data source.

The following code example creates DataGridTextColumn:

{% tabs %}
{% highlight xaml %}
<syncfusion:DataGridTextColumn MappingName ="OrderID" /> 
{% endhighlight %}
{% highlight c# %}
dataGrid.Columns.Add(DataGridTextColumn() { MappingName = "OrderID" });
{% endhighlight %}
{% endtabs %}

The following topics explain the customizations done in the DataGridTextColumn:

### Formatting

To format values displayed in the DataGridColumn, use the `DataGridColumn.Format` property.

#### Format column using StringFormat

Assign the format of string to the `DataGridColumn.Format` property based on the bound data type of the property, the DataGridColumn is associated to format the value. You can use different  `StringFormats` to customize values displayed in the record cells.

To apply formatting for a DataGridTextColumn, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid.Columns>
    <syncfusion:DataGridTextColumn  MappingName="Freight" Format="C" />
    <syncfusion:DataGridTextColumn  MappingName="ShippingDate" Format="dd/MM/yyyy" />
</syncfusion:SfDataGrid.Columns> 
{% endhighlight %}
{% highlight c# %}
dataGrid.Columns.Add (DataGridTextColumn() { 
    MappingName = "Customer",
    Format = "C"
});

dataGrid.Columns.Add (DataGridTextColumn() { 
    MappingName = "ShippingDate",
    Format = "dd/MM/yyyy"
});
{% endhighlight %}
{% endtabs %}

#### Format column using converter

Using converter, set the format of the column.

To set the format using converter, follow the code example:

 {% highlight xaml%}
 <sfgrid:SfDataGrid.Columns>
    <sfgrid:DataGridTextColumn MappingName="Salary" DisplayBinding="{Binding Salary, Converter={StaticResource SummaryConverter}}" />
</sfgrid:SfDataGrid.Columns>  
 {% endhighlight%}

 {% highlight C#%}

public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
{
        var formattedString = string.Format("$ {0}", value);
        return formattedString;
}

 {% endhighlight%}

N> For AutoGenerated columns formatting can be applied by handling the [SfDataGrid.AutoGeneratingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingColumn) event.

### Font and alignment options

#### TextAlignment

To get or set TextAlignment of the header cell and Grid Cell , use the `DataGridColumn.HeaderTextAlignment` and `DataGridColumn.CellTextAlignment` property. The default alignment of the record cell is `Center`. It can be customized as `Start` or `End`.

## DataGridCheckBoxColumn

DataGridCheckBoxColumn inherits all the properties of DataGridColumn. It loads a switch as the content of record cells in the column and responds to value changes in it. The underlying data source can be changed that it toggles the values shown in the switch. The SfDataGrid automatically generates DataGridCheckBoxColumn if the property in the underlying collection of type set to bool.

To use DataGridCheckBoxColumn, follow the code example:
 
{% highlight xaml %}
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

{% highlight c# %}
// Model class
public class Model
{
    private bool _isOnline;

    public bool IsOnline
    {
        get { return _isOnline; }
        set
        {
            this._isOnline = value;
        }
    }
}

// ViewModel class
public class ViewModel
{
    public ViewModel()
    {
        GetOrderDetails(50);
    }

    #region ItemsSource

    private ObservableCollection<OrderInfo> ordersInfo;

    public ObservableCollection<OrderInfo> OrderInfoCollection
    {
        get { return ordersInfo; }
        set { this.ordersInfo = value; }
    }

    #endregion

    #region ItemSource Generator

    public void GetOrderDetails(int count)
    {
        var orderDetails = new ObservableCollection<OrderInfo>();
        for (int i = 1; i <= count; i++)
        {
            var order = new OrderInfo()
            {
                IsOnline = (i % 2) == 0 ? true : false
            };
            orderDetails.Add(order);
        }
        ordersInfo = orderDetails;
    }

    #endregion
} 
{% endhighlight %}

![DataGrid with checkbox column](Images\column-types\maui-datagrid-column-checkbox.png)


## DataGridImageColumn

DataGridImageColumn is derived from DataGridColumn. Hence, it inherits all the properties of DataGridColumn. It displays image as cell content of a column. To create DataGridImageColumn, the property corresponding to the column in the underlying collection must be `ImageSource` type.

In DataGridImageColumn, it is possible to load images in any of the following four ways:

 * **FromFile**: Required to specify the path of the file.
 * **FromResource**: Required to set image as embedded resource.
 * **FromStream**: Required to load image from byte[] array.
 * **FromURI**: Required to set image from a web service or website.

To load image (embedded resource) in DataGridImageColumn, follow the code example:
 
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}"  ColumnWidthMode="Fill" utoGenerateColumnsMode="None">
    <syncfusion:SfDataGrid.Columns >
        <syncfusion:DataGridImageColumn  MappingName="DealerImage" HeaderText="Dealer Image" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
// Model class
public class Model
{
    private ImageSource _dealer;

    public ImageSource DealerImage
    {
        get { return _dealer; }
        set
        {
            this._dealer = value;
        }
    }
}

// ViewModel class
public class ViewModel
{
    public ViewModel()
    {
        GetOrderDetails(50);
    }

    #region ItemsSource

    private ObservableCollection<OrderInfo> ordersInfo;

    public ObservableCollection<OrderInfo> OrderInfoCollection
    {
        get { return ordersInfo; }
        set { this.ordersInfo = value; }
    }

    #endregion

    #region ItemSource Generator

    public void GetOrderDetails(int count)
    {
        var orderDetails = new ObservableCollection<OrderInfo>();
        for (int i = 1; i <= count; i++)
        {
            var order = new OrderInfo()
            {
                DealerImage = ImageSource.FromResource("DataGridDemo.Buchanan.png") // Need to give the image path properly. Here, DataGridDemo denotes the project name and Buchanan denotes the image name.
            };
            orderDetails.Add(order);
        }
        ordersInfo = orderDetails;
    }

    #endregion
}
{% endhighlight %}

![DataGrid with image column](Images\column-types\maui-datagrid-column-imagecolumn.png)
### Aspect

SfDataGrid allows you to set the [Aspect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html#Syncfusion_Maui_DataGrid_DataGridImageColumn_Aspect) to size the loaded images within the bounds of the grid cell (whether to stretch, crop or letterbox) using the `DataGridImageColumn.Aspect` property. The supported aspects are described below, the default value is AspectFit.

AspectFill: Clips the image so that it fills the display area while preserving the aspect (no distortion).

AspectFit:  Letterboxes the image (if required) so that the entire image fits into the display area, with blank space added to the top/bottom or sides depending on whether the image is wide or tall.

Fill: Stretches the image to completely and exactly fill the display area. This may result in the image being distorted.

To set `Aspect` to images loaded inside `DataGridImageColumn`, refer the below code snippet.

{% highlight xaml %}
<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<sfGrid:SfDataGrid x:Name="dataGrid"
                   AutoGenerateColumnsMode="None"
                   ItemsSource="{Binding OrdersInfo}">
    <sfGrid:SfDataGrid.Columns>
        <sfGrid:DataGridImageColumn MappingName="DealerImage" Aspect="AspectFit"/>
    </sfGrid:SfDataGrid.Columns>
</sfGrid:SfDataGrid>
{% endhighlight %}

## DataGridTemplateColumn

The DataGridTemplateColumn is derived from DataGridColumn. Hence, it inherits all the properties of DataGridColumn. It allows you to extend the functionality of DataGridColumn with own view by creating the [CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html#Syncfusion_Maui_DataGrid_DataGridTemplateColumn_CellTemplate).

The following table provides the list of properties in DataGridTemplateColumn:

<table>
<tr>
<th>Property</th>
<th>Type</th>
<th>Description</th>
<th>Default Value</th>
</tr>
<tr>
<td>CellTemplate</td>
<td>DataTemplate</td>
<td>Gets or sets the template that is used to display the contents of the record cells.</td>
<td>Null</td>
</tr>
</table>

### Cell template

Underlying records will be the BindingContext for the `CellTemplate`. The following code example shows templating of DataGridTemplateColumn:

{% tabs %}
{% highlight xaml %}
<syncfusion:DataGridTemplateColumn MappingName="CustomerID" HeaderText="Customer ID">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <StackLayout>
                <Label Text="{Binding CustomerID}" TextColor="Blue" />
            </StackLayout>
        </DataTemplate>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>
{% endhighlight %}
{% highlight c# %}
DataGridTemplateColumn templateColumn = new DataGridTemplateColumn()
{
    MappingName = "CustomerID",
    Width = 50,
};
var dataTemplate = new DataTemplate(() =>
{
var label = new Label()
{
    TextColor = Color.Blue,
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center
};
label.SetBinding(Label.TextProperty, "CustomerID");
return label;
});
templateColumn.CellTemplate = dataTemplate;
{% endhighlight %}
{% endtabs %}



### CellTemplateSelector

Load the underlying records through the `CellTemplate` to use CellTemplateSelector. The following code example shows templating of the DataGridTemplateColumn using the `CellTemplate` property:

{% highlight xaml %}
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

{% highlight c# %}
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

### Getting row index of a row in GridTemplateColumn

We can get the row data of the specified row using a button inside the DataGridTemplateColumn .

{% tabs %}
{% highlight xaml %}
// MainPage.Xaml

<syncfusion:DataGridTemplateColumn HeaderText="ShipCity" MappingName="ShipCity">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <Button Clicked="Button_Clicked" WidthRequest="120" Text="{Binding ShipCity}"/>
        </DataTemplate>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>

{% endhighlight %}

{% highlight c# %}
// MainPage.cs 
public partial class MainPage : ContentPage
{
     public MainPage()
     {
         InitializeComponent();
     }
     private void button_Clicked(object sender, EventArgs e)
     {
          var button = sender as Button;
          var record = button.BindingContext as OrderInfo;
          var recordRowIndex = viewModel.OrderInfoCollection.IndexOf(record);
     }
}
{% endhighlight %}
{% endtabs %}

### Loading DatePicker
We can load DatePicker inside a `DataGridTemplateColumn`.

To load `DatePicker` , follow the code example:

{% highlight xaml %}
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
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:ViewModel x:Name ="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="DataGrid" ItemsSource="{Binding OrderInfoCollection}" AutoGenerateColumnsMode="None">
        <syncfusion:SfDataGrid.Columns >
           <syncfusion:DataGridDateColumn Format="d"  HeaderText="Date" MappingName="ShippedDate" />
        </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
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

{% highlight c# %}
// Model class
public class Model
{
    private DateTime shippedDate;

    public DateTime ShippedDate
    {
        get { return shippedDate; }
        set
        {
            shippedDate = value;
            RaisePropertyChanged("ShippedDate");
        }
    }
}

// ViewModel class
public class ViewModel
{
    private List<DateTime> OrderedDates;

    public ViewModel()
    {
        GetOrderDetails(50);
    }

    #region ItemsSource

    private ObservableCollection<OrderInfo> ordersInfo;

    public ObservableCollection<OrderInfo> OrderInfoCollection
    {
        get { return ordersInfo; }
        set { this.ordersInfo = value; }
    }

    #endregion

    #region ItemSource Generator

     private List<DateTime> GetDateBetween(int startYear, int endYear, int count)
     {
        List<DateTime> date = new List<DateTime>();
        Random d = new Random(1);
        Random m = new Random(2);
        Random y = new Random(startYear);
        for (int i = 0; i < count; i++)
        {
            int year = y.Next(startYear, endYear);
            int month = m.Next(3, 13);
            int day = d.Next(1, 31);

            date.Add(new DateTime(year, month, day));
        }
        return date;
     }

    public void GetOrderDetails(int count)
    {
        var orderDetails= new ObservableCollection<OrderInfo>();
        this.OrderedDates = GetDateBetween(2000, 2014, count);
        for (int i = 1; i <= count; i++)
        {
            var order = new OrderInfo()
            {
                ShippedDate = this.OrderedDates[i - 1],
            };
            orderDetails.Add(order);
        }
        ordersInfo = orderDetails;
    }

    #endregion
}
{% endhighlight %}

## DataGridNumericColumn

The `DataGridNumericColumn` inherits all the properties of `DataGridColumn`. It is used to display numeric data. To create `DataGridNumericColumn`, the property corresponding to the column in the underlying collection must be a numeric type(int, double, float, etc.). To create a `GridNumericColumn`, follow the code example:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:ViewModel  x:Name ="viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"           
                   ItemsSource="{Binding OrdersInfo}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn Format="C" HeaderText="ID"
                                  MappingName="OrderID"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid = new SfDataGrid();
            
DataGridNumericColumn numericColumn = new DataGridNumericColumn()
{
    MappingName = "OrderID",
    HeaderText = "OrderID",
};
dataGrid.Columns.Add(numericColumn);
{% endhighlight %}
{% endtabs %}

## Bind a view model property inside header template?

The SfDataGrid allows binding the view model property to the `HeaderTemplate` by setting the BindingContext of the `DataGridColumn` as `ViewModel`.

To bind a view model property inside `HeaderTemplate`, follow the code example:

{% highlight xaml %}

<syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}" AutoGenerateColumnsMode="None">
            <syncfusion:SfDataGrid.Columns >
                <syncfusion:DataGridTextColumn MappingName="OrderID"  >
                    <syncfusion:DataGridColumn.HeaderTemplate>
                        <DataTemplate>
                            <StackLayout>
                                <Label BindingContext="{StaticResource viewModel}" Text="{Binding Headertext}" VerticalOptions="CenterAndExpand" HorizontalOptions="CenterAndExpand" TextColor="Blue" IsVisible="{Binding _Visibility}"/>
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
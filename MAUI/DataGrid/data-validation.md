---
layout: post
title: Data Validation in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about Data Validation support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui data validation, maui data validation
---

# Data Validation in MAUI DataGrid (SfDataGrid)

[.NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) allows you to validate the data and display hints in case of validation is not passed. In case of invalid data, error icon is displayed at the top right corner of DataGridCell. When mouse over the error icon, error information will be displayed in error tip.

## Built-in Validation

Built-in validations through `IDataErrorInfo` and `INotifyDataErrorInfo`, can be enabled by setting [SfDataGrid.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ValidationMode) or [DataGridColumn.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_ValidationMode) properties.

`DataGridColumn.ValidationMode` takes priority than `SfDataGrid.ValidationMode`.

* DataGridValidationMode.InEdit - display error icon & tips and also doesn’t allow the users to commit the invalid data by not allowing users to edit other cells.
* DataGridValidationMode.InView - displays error icons and tips alone.
* DataGridValidationMode.None - disables built-in validation support.

## Built-in validation using IDataErrorInfo / INotifyDataErrorInfo

.NET MAUI DataGrid (SfDataGrid) provides support to validate the data based on [IDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.idataerrorinfo?view=net-9.0) / [INotifyDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifydataerrorinfo?view=net-9.0).

### Using IDataErrorInfo

You can validate the data by inheriting the [IDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.idataerrorinfo?view=net-9.0) interface in model class.

{% tabs %}
{% highlight C# %}
public class OrderInfo : IDataErrorInfo
{
    private string country;

    public int OrderID { get; set; }
    public string Customer { get; set; }
    public string City { get; set; }
    public string Product { get; set; }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    [Display(AutoGenerateField = false)]
    public string Error
    {
        get
        {
            return string.Empty;
        }
    }

    public string this[string columnName]
    {
        get
        {
            if (!columnName.Equals("Country"))
                return string.Empty;

            if (this.Country == "Germany" || this.Country == "France")
                return "Delivery not available for " + this.Country;

            return string.Empty;
        }
    }
}
{% endhighlight %}
{% endtabs %}

Enable built-in validation support by setting [SfDataGrid.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ValidationMode) or [DataGridColumn.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_ValidationMode) property to `InEdit` or `InView`.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView"/>

{% endhighlight %}
{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.ValidationMode = DataGridValidationMode.InView;
this.Content = dataGrid;                  
{% endhighlight %}
{% endtabs %}

<img alt="data-validation-with-IDataErrorInfo" src="Images\data-validation\maui-datagrid-datavalidation-idataerrorinfo.png" width="464" height="396"/>

### Using INotifyDataErrorInfo

The data can be validated by inheriting the [INotifyDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifydataerrorinfo?view=net-9.0) interface in model class.

{% tabs %}
{% highlight C# %}
public class OrderInfo : INotifyDataErrorInfo
{
    private List<string> errors = new List<string>();

    private string country;

    public int OrderID { get; set; }
    public string Customer { get; set; }
    public string City { get; set; }
    public string Product { get; set; }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public System.Collections.IEnumerable GetErrors(string propertyName)
    {

        if (!propertyName.Equals("City"))
            return null;

        if (this.City.Contains("Berlin") || this.City.Contains("Madrid"))
            errors.Add("Delivery not available for " + this.City);
        return errors;
    }

    [Display(AutoGenerateField = false)]
    public bool HasErrors
    {
        get
        {
            return false;
        }
    }

    public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
}
{% endhighlight %}
{% endtabs %}

Enable built-in validation support by setting [SfDataGrid.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ValidationMode) or [DataGridColumn.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_ValidationMode) property to `InEdit` or `InView`.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView"/>
{% endhighlight %}
{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.ValidationMode = DataGridValidationMode.InView;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="data-validation-with-INotifyDataErrorInfo" src="Images\data-validation\maui-datagrid-datavalidation-inotifydataerrorinfo.png" width="464" height="396"/>

## Built-in validation using Data Annotation

You can validate the data using **data annotation attributes** by setting 
[SfDataGrid.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ValidationMode) or [DataGridColumn.ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_ValidationMode) property to `InEdit` or `InView`.

### Using different annotations

The numeric type like int, double, decimal properties can be validated using [Range attributes](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.rangeattribute?view=net-5.0).

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    private int orderID;

    [Range(10001, 10005, ErrorMessage = "OrderID between 10001 and 10005 alone processed")]
    public int OrderID
    {
        get { return orderID; }
        set { orderID = value; }
    }
    public string Customer { get; set; }
    public string City { get; set; }

    public string Country { get; set; }
    public string Product { get; set; }
}
{% endhighlight %}
{% endtabs %}

The string type property can be validated using [Required](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.requiredattribute?view=net-5.0), [String Length attributes](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.stringlengthattribute?view=net-5.0)

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    private string _city;
    private string _customerName;

    public int OrderID { get; set; }

    [StringLength(5)]
    public string Customer
    {
        get { return _customerName; }
        set { _customerName = value; }
    }

    [Required]
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string Country { get; set; }
    public string Product { get; set; }
}
{% endhighlight %}
{% endtabs %}

The data that has heterogeneous type (combination of number, special character) can be validated using [RegularExpressions](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.regularexpressionattribute?view=net-5.0).

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    private string _customerName;

    public int OrderID { get; set; }

    [RegularExpressionAttribute(@"^[a-zA-Z]{1,40}$", ErrorMessage = "Numbers and special characters not allowed")]
    public string Customer
    {
        get { return _customerName; }
        set { _customerName = value; }
    }

    public string City { get; set; }
    public string Country { get; set; }
    public string Product { get; set; }
}
{% endhighlight %}
{% endtabs %}

## Cell Validation

A cell can be validated using [CellValidating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellValidating) event when the cell is edited. `CellValidating` event occurs when the edited cells tries to commit the data or lose the focus. DataGrid will not allow user to edit other cells if validation failed.

[DataGridCellValidatingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellValidatingEventArgs.html) provides information to `CellValidating` event for validating the cell. `DataGridCellValidatingEventArgs.OriginalSource` returns the DataGrid fired this event for DetailsView.

`DataGridCellValidatingEventArgs.NewValue` returns the edited value and you can set the validation status using `DataGridCellValidatingEventArgs.IsValid` property.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView"
                        CellValidating="dataGrid_CellValidating"/>
{% endhighlight %}
{% highlight C# %}
private void dataGrid_CellValidating(object sender, DataGridCellValidatingEventArgs e)
{
    if (e.NewValue.ToString().Equals("Berlin"))
    {
        e.IsValid = false;
        e.ErrorMessage = "Berlin cannot be passed";
    }
}
{% endhighlight %}
{% endtabs %}

[SfDataGrid.CellValidated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellValidated) event triggered when the cell has finished validating with valid data.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView"
                        CellValidated="dataGrid_CellValidated"/>
{% endhighlight %}
{% highlight C# %}
private void dataGrid_CellValidated(object sender, DataGridCellValidatedEventArgs e)
{
    // Handle cell validation results here
}
{% endhighlight %}
{% endtabs %}

## Row Validation

A Row can be validated using [RowValidating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowValidating) event when the cell is edited. The `RowValidating` event occurs when the edited cells tries to commit the row data or lose the focus. DataGrid will not allow user to edit other rows if validation failed.

[DataGridRowValidatingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRowValidatingEventArgs.html) provides information to `RowValidating` event for validating row. `DataGridRowValidatingEventArgs.OriginalSource` returns the DataGrid fired this event for DetailsView.

`DataGridRowValidatingEventArgs.RowData` returns the edited value and you can set the validation status using `DataGridRowValidatingEventArgs.IsValid` property.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView"
                        RowValidating="dataGrid_RowValidating"/>
{% endhighlight %}
{% highlight C# %}
private void dataGrid_RowValidating(object sender, DataGridRowValidatingEventArgs e)
{
    var data = e.RowData.GetType().GetProperty("Country").GetValue(e.RowData);

    if (data != null && data.ToString().Equals("Spain"))
    {
        e.IsValid = false;
        e.ErrorMessages.Add("Country", "Spain cannot be passed");
    }
}
{% endhighlight %}
{% endtabs %}

[SfDataGrid.RowValidated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowValidated) event triggered when the row has finished validating with valid row data.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView"
                        RowValidated="dataGrid_RowValidated"/>
{% endhighlight %}
{% highlight C# %}
private void dataGrid_RowValidated(object sender, DataGridRowValidatedEventArgs e)
{
    // Handle row validation logic here
}
{% endhighlight %}
{% endtabs %}

## Error Icon Customization

### Change Error Icon Color

The default error icon color can be customized by setting the [DataGridStyle.ErrorIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ErrorIconColor) property.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle ErrorIconColor="Orange"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.ValidationMode = DataGridValidationMode.InView;
dataGrid.DefaultStyle.ErrorIconColor = Colors.Orange;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="data-validation-error-icon-customization" src="Images\data-validation\maui-datagrid-datavalidation-erroriconcustomization.png" width="464" height="396"/>

### Load Error Icon through Template

The SfDataGrid uses an icon to indicate if a cell has error. You can personalize the error icon by using the [SfDataGrid.ErrorIconTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ErrorIconTemplate) property.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView">
    <syncfusion:SfDataGrid.ErrorIconTemplate>
        <DataTemplate>
            <Image Source="error_icon.png"/>
        </DataTemplate>
    </syncfusion:SfDataGrid.ErrorIconTemplate>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.ValidationMode = DataGridValidationMode.InView;
dataGrid.ErrorIconTemplate = new DataTemplate(() =>
{
    var image = new Image()
    {
        Source = "error_icon.png",
    };
    return image;
});
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="data-validation-error-icon-template" src="Images\data-validation\maui-datagrid-datavalidation-erroricontemplate.png" width="464" height="396"/>

### Load Error Icon through Template Selector

When choosing a ErrorIconTemplate as a DataTemplateSelector, you have the option to supply distinct templates for different invalid values.

{% tabs %}
{% highlight XAML %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key = "BelgiumTemplate">
            <Image Source = "error_icon.png"/>
        </DataTemplate>
    <DataTemplate x:Key = "CanadaTemplate">
            <Image Source = "error_triangle.png"/>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding OrderInfoCollection}"
                       SelectionMode = "Single"
                       NavigationMode = "Cell"
                       AllowEditing = "True"                           
                       ValidationMode = "InView">
        <syncfusion:SfDataGrid.ErrorIconTemplate>
                <local:ErrorIconTemplateSelector BelgiumTemplate = "{StaticResource BelgiumTemplate}" CanadaTemplate = "{StaticResource CanadaTemplate}" />
        </syncfusion:SfDataGrid.ErrorIconTemplate>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight C# %}

public class ErrorIconTemplateSelector: DataTemplateSelector
{
    public DataTemplate BelgiumTemplate { get; set; }
    public DataTemplate CanadaTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is Orders order)
        {
            if (order.ShipCountry == "Belgium")
            {
                return BelgiumTemplate;
            }
            else
            {
                return CanadaTemplate;
            }
        }

        return CanadaTemplate;
    }
}

{% endhighlight %}
{% endtabs %}

<img alt="data-validation-error-icon-template-selector" src="Images\data-validation\maui-datagrid-datavalidation-erroricontemplateselector.png" width="464" height="396"/>

## Error Tip Customization

### Change Error Tip Background and Text Color

The background of the error tip can be changed by setting [DataGridStyle.ErrorTipBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ErrorTipBackground) property. The error tip text color can be changed by setting [DataGridStyle.ErrorTipTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ErrorTipTextColor) property.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle ErrorTipBackground="LightBlue"
                                    ErrorTipTextColor="Black"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.ValidationMode = DataGridValidationMode.InView;
dataGrid.DefaultStyle.ErrorTipBackground = Colors.LightBlue;
dataGrid.DefaultStyle.ErrorTipTextColor = Colors.Black;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="data-validation-error-tip-customization" src="Images\data-validation\maui-datagrid-datavalidation-errortipcustomization.png" width="464" height="396"/>

### Load Error Tip through Template

The SfDataGrid uses a tool tip to showcase an error message if a cell has error. You can personalize the error tip by using the [SfDataGrid.ErrorTipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ErrorTipTemplate) property.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        SelectionMode="Single"
                        NavigationMode="Cell"
                        AllowEditing="True"
                        ValidationMode="InView">
    <syncfusion:SfDataGrid.ErrorTipTemplate>
        <DataTemplate>
            <Label Text="Delivery not available"
                    Background="Orange"
                    TextColor="Black"
                    Padding="2"/>
        </DataTemplate>
    </syncfusion:SfDataGrid.ErrorTipTemplate>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.ValidationMode = DataGridValidationMode.InView;
dataGrid.ErrorTipTemplate = new DataTemplate(() =>
{
    var label = new Label()
    {
        Text = "Delivery Not available",
        Background = Colors.Orange,
        TextColor = Colors.Black,
        Padding = new Thickness(2),
    };
    return label;
});
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="data-validation-error-tip-template" src="Images\data-validation\maui-datagrid-datavalidation-errortiptemplate.gif" width="464" height="396"/>

### Load Error Tip through Template Selector

When choosing a ErrorTipTemplate as a DataTemplateSelector, you have the option to supply distinct templates for different invalid values.

{% tabs %}
{% highlight XAML %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key = "BelgiumTemplate">
            <Label Text = "Delivery not available for Belgium" Background = "Orange" TextColor = "Black" Padding = "2"/>
        </DataTemplate>
    <DataTemplate x:Key = "CanadaTemplate">
            <Label Text = "Delivery not available for Canada" Background = "LightBlue" TextColor = "Black" Padding = "2"/>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding OrderInfoCollection}"
                       SelectionMode = "Single"
                       NavigationMode = "Cell"
                       AllowEditing = "True"                           
                       ValidationMode = "InView">
        <syncfusion:SfDataGrid.ErrorTipTemplate>
                <local:ErrorTipTemplateSelector BelgiumTemplate = "{StaticResource BelgiumTemplate}" CanadaTemplate = "{StaticResource CanadaTemplate}" />
        </syncfusion:SfDataGrid.ErrorTipTemplate>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight C# %}

public class ErrorTipTemplateSelector: DataTemplateSelector
{
    public DataTemplate BelgiumTemplate { get; set; }
    public DataTemplate CanadaTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is Orders order)
        {
            if (order.ShipCountry == "Belgium")
            {
                return BelgiumTemplate;
            }
            else
            {
                return CanadaTemplate;
            }
        }

        return CanadaTemplate;
    }
}

{% endhighlight %}
{% endtabs %}

<img alt="data-validation-error-tip-template-selector" src="Images\data-validation\maui-datagrid-datavalidation-errortiptemplateselector.gif" width="464" height="396"/>

## Data Validation with Master-Details View

The data bound based on [IDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.idataerrorinfo?view=net-9.0) or [INotifyDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifydataerrorinfo?view=net-9.0) can be validated by setting [ValidationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ValidationMode) property of [DataGridViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridViewDefinition.html).

{% tabs %}
{% highlight XAML %}

<syncfuion:SfDataGrid x:Name = "dataGrid" 
                      ItemsSource = "{Binding OrderList}" 
                      SelectionMode = "Single" 
                      NavigationMode = "Cell" 
                      GridLinesVisibility = "Both">
        <syncfuion:SfDataGrid.DetailsViewDefinition>
                <syncfuion:DataGridViewDefinition RelationalColumn = "OrdersList">
                        <syncfuion:DataGridViewDefinition.DataGrid>
                                <syncfuion:SfDataGrid  x:Name = "FirstLevelNestedGrid" 
                                                       ValidationMode = "InView"
                                                       AllowEditing = "True" 
                                                       GridLinesVisibility = "Both"/>
                        </syncfuion:DataGridViewDefinition.DataGrid>
                </syncfuion:DataGridViewDefinition>
        </syncfuion:SfDataGrid.DetailsViewDefinition>
</syncfuion:SfDataGrid>

{% endhighlight %}
{% endtabs %}

When the relation is auto-generated, the data can be validated by setting ValidationMode property to `AutoGeneratingRelations.DataGridViewDefinition.DataGrid` in [AutoGeneratingRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingRelations) event handler.

{% tabs %}
{% highlight C# %}

dataGrid.AutoGenerateRelations = true;

dataGrid.AutoGeneratingRelations += dataGrid_AutoGeneratingRelations;

void dataGrid_AutoGeneratingRelations(object sender, AutoGeneratingRelationsArgs e)
{
    e.DataGridViewDefinition.DataGrid.ValidationMode = DataGridValidationMode.InView;
}
                       
{% endhighlight %}
{% endtabs %}

<img alt="data-validation-with-master-details-view" src="Images\data-validation\maui-datagrid-datavalidation-with-masterdetailsview.png" width="464" height="396"/>

### Custom validation through events

Master-Details View support to validate the cells and rows using [CellValidating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellValidated) and [RowValidating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowValidating) events.

#### Cell Validation

The cells can be validated using [CellValidating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellValidating) event of [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) when the cell is edited. `CellValidating` event occurs when the edited cells tries to commit the data or lose the focus.

{% tabs %}
{% highlight XAML %}

<syncfuion:SfDataGrid x:Name = "dataGrid" 
                      ItemsSource = "{Binding OrderList}" 
                      SelectionMode = "Single" 
                      NavigationMode = "Cell" 
                      GridLinesVisibility = "Both">
        <syncfuion:SfDataGrid.DetailsViewDefinition>
                <syncfuion:DataGridViewDefinition RelationalColumn = "OrdersList">
                        <syncfuion:DataGridViewDefinition.DataGrid>
                                <syncfuion:SfDataGrid  x:Name = "FirstLevelNestedGrid" 
                                                       AllowEditing = "True"
                                                       ValidationMode = "InView" 
                                                       GridLinesVisibility = "Both"/>
                        </syncfuion:DataGridViewDefinition.DataGrid>
                </syncfuion:DataGridViewDefinition>
        </syncfuion:SfDataGrid.DetailsViewDefinition>
</syncfuion:SfDataGrid>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

this.FirstLevelNestedGrid.CellValidating += FirstLevelNestedGrid_CellValidating;

private void FirstLevelNestedGrid_CellValidating(object sender, DataGridCellValidatingEventArgs args)
{

    if (args.NewValue.ToString().Equals("SIMOB"))
    {
        args.IsValid = false;
        args.ErrorMessage = "SIMOB cannot be passed";
    }
}

{% endhighlight %}
{% endtabs %}

[CellValidated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellValidated) event of [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) triggered when the cell has finished validating with valid data.

{% tabs %}
{% highlight C# %}

this.FirstLevelNestedGrid.CellValidated += FirstLevelNestedGrid_CellValidated;

private void FirstLevelNestedGrid_CellValidated(object sender, DataGridCellValidatedEventArgs args)
{

}

{% endhighlight %}
{% endtabs %}

When the relation is auto-generated, you can wire the `CellValidating` and `CellValidated` events for `AutoGeneratingRelations.DataGridViewDefinition.DataGrid` in [AutoGeneratingRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingRelations) event handler.

{% tabs %}
{% highlight C# %}

dataGrid.AutoGenerateRelations = true;
dataGrid.AutoGeneratingRelations += dataGrid_AutoGeneratingRelations;

private void dataGrid_AutoGeneratingRelations(object sender, AutoGeneratingRelationsArgs e)
{
    e.DataGridViewDefinition.DataGrid.CellValidating += FirstLevelNestedGrid_CurrentCellValidating;
    e.DataGridViewDefinition.DataGrid.CellValidated += FirstLevelNestedGrid_CurrentCellValidated;
}

{% endhighlight %}
{% endtabs %}

#### Row Validation

The row can be validated using [RowValidating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowValidating) event of [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) when the cell is edited.

The `RowValidating` event occurs when edited cells tries to commit the row data or lose the focus.

{% tabs %}
{% highlight XAML %}

<syncfuion:SfDataGrid x:Name = "dataGrid" 
                      ItemsSource = "{Binding OrderList}" 
                      SelectionMode = "Single" 
                      NavigationMode = "Cell" 
                      GridLinesVisibility = "Both">
        <syncfuion:SfDataGrid.DetailsViewDefinition>
                <syncfuion:DataGridViewDefinition RelationalColumn = "OrdersList">
                        <syncfuion:DataGridViewDefinition.DataGrid>
                                <syncfuion:SfDataGrid  x:Name = "FirstLevelNestedGrid" 
                                                       AllowEditing = "True"
                                                       ValidationMode = "InView" 
                                                       GridLinesVisibility = "Both"/>
                        </syncfuion:DataGridViewDefinition.DataGrid>
                </syncfuion:DataGridViewDefinition>
        </syncfuion:SfDataGrid.DetailsViewDefinition>
</syncfuion:SfDataGrid>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}

this.FirstLevelNestedGrid.RowValidating += FirstLevelNestedGrid_RowValidating;

private void FirstLevelNestedGrid_RowValidating(object sender, DataGridRowValidatingEventArgs args)
{
    var data = args.RowData.GetType().GetProperty("CustomerID").GetValue(args.RowData);

    if (data.ToString().Equals("MEREP"))
    {
        args.IsValid = false;
        args.ErrorMessages.Add("CustomerID", "MEREP cannot be passed");
    }
}

{% endhighlight %}
{% endtabs %}

[RowValidated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowValidated) of [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html) event triggered when the row has finished validating with valid row data.

{% tabs %}
{% highlight C# %}

this.FirstLevelNestedGrid.RowValidated += FirstLevelNestedGrid_RowValidated;

private void FirstLevelNestedGrid_RowValidated(object sender, DataGridRowValidatedEventArgs args)
{

}

{% endhighlight %}
{% endtabs %}

When the relation is auto-generated, you can wire the `RowValidating` and `RowValidated` events for `AutoGeneratingRelations.DataGridViewDefinition.DataGrid` in [AutoGeneratingRelations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingRelations) event handler.

{% tabs %}
{% highlight C# %}

dataGrid.AutoGenerateRelations = true;
dataGrid.AutoGeneratingRelations += dataGrid_AutoGeneratingRelations;

private void dataGrid_AutoGeneratingRelations(object sender, AutoGeneratingRelationsArgs e)
{
    e.DataGridViewDefinition.DataGrid.RowValidating += FirstLevelNestedGrid_RowValidating;
    e.DataGridViewDefinition.DataGrid.RowValidated += FirstLevelNestedGrid_RowValidated;
}

{% endhighlight %}
{% endtabs %}

## Limitations

1. Non editable columns will not support custom validation.

---
layout: post
title: AddNewRow in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about how to add new row in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui addnewrow, maui add new row
---

# Add New Row in MAUI DataGrid (SfDataGrid)

DataGrid provides built-in row (called AddNewRow) that allows user to add new records to underlying collection. Built-in add new row can be enabled or disabled by setting [SfDataGrid.AddNewRowPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowPosition) property. AddNewRowPosition also denotes the position of add new row in DataGrid.

When you start editing in AddNewRow, the SfDataGrid control creates an instance for the underlying data object and adds it to underlying collection when editing completed.

N>
1. The underlying data object must be defined with default constructor.
2. Selection and Editing must be enabled.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn HeaderText="Order ID" Format="#" 
                                            MappingName="OrderID" />
            <syncfusion:DataGridTextColumn  HeaderText="Customer ID" 
                                            MappingName="CustomerID.CustomerID" />
            <syncfusion:DataGridTextColumn  HeaderText="Ship City" 
                                            MappingName="ShipCity" />
            <syncfusion:DataGridTextColumn  HeaderText="Ship Country" 
                                            MappingName="ShipCountry" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.SelectionMode = DataGridSelectionMode.Single;
        dataGrid.NavigationMode = DataGridNavigationMode.Cell;
        dataGrid.AllowEditing = true;
        dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="addnewRowpositon-top" src="Images\addnewrow\maui-dataGrid-AddNewRowPosition-top.png" width="404"/>  

## Changing the AddNewRow position

The position of the AddNewRow in SfDataGrid can be customized using the `SfDataGrid.AddNewRowPosition` property. By default, this property is set to Top.
The following code snippet demonstrates how to change the AddNewRow position to Bottom in SfDataGrid:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Bottom"
                       AddNewRowText="Click here to add new row in datagrid"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.SelectionMode = DataGridSelectionMode.Single;
        dataGrid.NavigationMode = DataGridNavigationMode.Cell;
        dataGrid.AllowEditing = true;
        dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Bottom;
        dataGrid.AddNewRowText = "Click here to add new row in datagrid";
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="addnewRowpositon-bottom" src="Images\addnewrow\maui-dataGrid-AddNewRowPosition-bottom.png" width="404"/>

## Customize the newly added row position

SfDataGrid adds new data item from AddNewRow at the end of collection. When data operations (sorting, grouping) performed, the new item added based on data operations. You can customize the newly added data item position by setting [SfDataGrid.NewItemPlaceHolderPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_NewItemPlaceholderPosition).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       NewItemPlaceholderPosition="AtBeginning"
                       ItemsSource="{Binding OrderInfoCollection}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.SelectionMode = DataGridSelectionMode.Single;
        dataGrid.NavigationMode = DataGridNavigationMode.Cell;
        dataGrid.AllowEditing = true;
        dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
        dataGrid.NewItemPlaceholderPosition = Syncfusion.Maui.Data.NewItemPlaceholderPosition.AtBeginning;
    }
}
{% endhighlight %}
{% endtabs %}

## Changing the AddNewRow default text

You can change the default static string of AddNewRow in datagrid by using the [SfDataGrid.AddNewRowText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowText) property. The `AddNewRowText` property has higher priority than the text that is localized in resx file.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       AddNewRowText="Click here to add new row in datagrid"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.SelectionMode = DataGridSelectionMode.Single;
        dataGrid.NavigationMode = DataGridNavigationMode.Cell;
        dataGrid.AllowEditing = true;
        dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
        dataGrid.AddNewRowText = "Click here to add new row in datagrid";
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-text" src="Images\addnewrow\maui-dataGrid-AddNewRowText.png" width="404"/>  

## Initializing default values for AddNewRow

SfDataGrid allows you to set the default values for AddNewRow while initiating, through [DataGridAddNewRowInitiatingEventArgs.Object](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowInitiatingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridAddNewRowInitiatingEventArgs_Object) property in [SfDataGrid.AddNewRowInitiating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowInitiating) event.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       AddNewRowInitiating="DataGrid_AddNewRowInitiating"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       ItemsSource="{Binding OrderInfoCollection}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AddNewRowInitiating += DataGrid_AddNewRowInitiating;

private void dataGrid_AddNewRowInitiating(object? sender, DataGridAddNewRowInitiatingEventArgs e)
{
    var data = e.Object as OrderInfo;
    if(data != null)
    {
        data.OrderID = 101;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-DefaultValue" src="Images\addnewrow\maui-dataGrid-DefaultValues.png" width="404"/>  

## Working with complex properties in AddNewRow

SfDataGrid control does not initiate values for complex properties defined in the data object. Hence, you need to initiate the default values for the complex properties externally by using the `SfDataGrid.AddNewRowInitiating` event.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       AutoGenerateColumnsMode="None"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AddNewRowInitiating="DataGrid_AddNewRowInitiating"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn HeaderText="Order ID" Format="#" 
                                          MappingName="OrderID" />
        <syncfusion:DataGridTextColumn  HeaderText="Customer ID" 
                                        MappingName="CustomerID.CustomerID" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship City" 
                                        MappingName="ShipCity" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship Country" 
                                        MappingName="ShipCountry" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
this.dataGrid.AddNewRowInitiating += DataGrid_AddNewRowInitiating;

private void DataGrid_AddNewRowInitiating(object? sender, DataGridAddNewRowInitiatingEventArgs e)
{
    var data = e.Object as OrderInfo;
    if(data != null)
    {
        data.OrderID = 101;
        data.CustomerID = new CustomerInfo();
    }
}
{% endhighlight %}
{% endtabs %}

## Add row programmatically

You can commit or cancel the new record in AddNewRow by pressing the Enter and Esc key respectively. AddNewRow operations can be performed programmatically by using [DataGridAddNewRowController.CommitAddNew](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowController.html#Syncfusion_Maui_DataGrid_DataGridAddNewRowController_CommitAddNew_Syncfusion_Maui_DataGrid_SfDataGrid_System_Boolean_) and [DataGridAddNewRowController.CancelAddNew](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowController.html#Syncfusion_Maui_DataGrid_DataGridAddNewRowController_CancelAddNew) methods at runtime.

### Cancel AddNewRow

{% tabs %}
{% highlight c# %}
if (this.dataGrid.View.IsAddingNew)
{
    //Which end edit the current cell and revert the entered value.

    if (this.dataGrid.CurrentCellManager.DataColumn.IsEditing)
        this.dataGrid.EndEdit();

    var addNewRowController = this.dataGrid.AddNewRowController;

    addNewRowController.CancelAddNew();
}
{% endhighlight %}
{% endtabs %}

### Commit AddNewRow

{% tabs %}
{% highlight c# %}
if (this.dataGrid.View.IsAddingNew)
{

    if (this.dataGrid.CurrentCellManager.DataColumn.IsEditing)
        this.dataGrid.EndEdit();

   RowColumnIndex rowColumnIndex = this.dataGrid.CurrentCellManager.RowColumnIndex;

    //Process the commit operation in AddNewRow.
    var addNewRowController = this.dataGrid.AddNewRowController;
    addNewRowController.CommitAddNew(dataGrid);

    //Gets the row index of AddNewRow 
    rowColumnIndex.RowIndex = addNewRowController.GetAddNewRowIndex(dataGrid);
    this.dataGrid.SelectedRows.Clear();

    //If the AddNewRowPosition is Top need to move the current cell to next row 
    if (this.dataGrid.AddNewRowPosition == DataGridAddNewRowPosition.Top)
        rowColumnIndex.RowIndex = rowColumnIndex.RowIndex + 1;

    //Which retains the current cell border in the row after canceling AddNewRow as you press ESC key operation.
    this.dataGrid.MoveCurrentCellTo(rowColumnIndex);
}
{% endhighlight %}
{% endtabs %}

## Customizing AddNewRow text using default resource file

SfDataGrid enables you to customize the watermark text of AddNewRow by changing value of AddNewRowText in Resource Designer.

To customize the AddNewRowText, add the default Syncfusion.SfDataGrid.WPF.resx file in Resources folder and then customize the value of AddNewRowText. Refer [here](https://help.syncfusion.com/maui/datagrid/localization) to learn more about localization.

<img alt="addnewRow-resxfile" src="Images\addnewrow\maui-dataGrid-AddNewRow_resxfile.png" width="404"/>  

<img alt="addnewRow-Localization" src="Images\addnewrow\maui-dataGrid-AddNewRow_Localization.png" width="404"/> 

## Customizing AddNewRow

### Apply implicit style

DataGridAddNewRow can be customized by writing style for [DataGridAddNewRowView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowView.html) TargetType.

{% tabs %}
{% highlight xaml %}
 <ContentPage.Resources>
     <Style TargetType="syncfusion:DataGridAddNewRowView">
         <Setter Property="Background"
                 Value="#0074E3" />
         <Setter Property="TextColor"
                 Value="White" />
         <Setter Property="FontAttributes"
                 Value="Italic" />
         <Setter Property="FontSize"
                 Value="24" />
         <Setter Property="FontFamily"
                 Value="TimesNewRoman" />
     </Style>
 </ContentPage.Resources>
{% endhighlight %}
{% endtabs %}

### Apply default style

You can customize the AddNewRow's Background, TextColor, FontAttribute, FontFamily by using [SfDataGrid.DefaultStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultStyle).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       SelectionUnit="Row"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
     <syncfusion:SfDataGrid.DefaultStyle>
         <syncfusion:DataGridStyle AddNewRowBackground="#0074E3"
                                   AddNewRowTextColor="White"
                                   AddNewRowFontAttributes="Italic"
                                   AddNewRowFontSize="24"
                                   AddNewRowFontFamily="TimesNewRoman" />
     </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-ImplicitStyle" src="Images\addnewrow\maui-dataGrid-AddNewRow_ImplicitStyle.png" width="404"/>  

## AddNewRow support in Master-Details View

You can enable the AddNewRow in `DetailsViewDataGrid` by specifying the position to `SfDataGrid.AddNewRowPosition` property in [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       AutoGenerateRelations="False"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn HeaderText="Order ID" Format="#" 
                                          MappingName="OrderID" />
        <syncfusion:DataGridTextColumn  HeaderText="Customer ID" 
                                        MappingName="CustomerID.CustomerID" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship City" 
                                        MappingName="ShipCity" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship Country" 
                                        MappingName="ShipCountry" />
    </syncfusion:SfDataGrid.Columns>
    <syncfusion:SfDataGrid.DetailsViewDefinition>
    <syncfusion:DataGridViewDefinition RelationalColumn="Customers">
        <syncfusion:DataGridViewDefinition.DataGrid>
            <syncfusion:SfDataGrid x:Name="firstLevelNestedGrid"
                                   AutoGenerateColumnsMode="None"
                                   AddNewRowPosition="Top">
                <syncfusion:SfDataGrid.Columns>
                    <syncfusion:DataGridTextColumn MappingName="OrderID"
                                                   HeaderText="Order ID"
                                                   Format="#" />
                    <syncfusion:DataGridTextColumn MappingName="Quantity"
                                                   HeaderText="Quantity" />
                    <syncfusion:DataGridTextColumn MappingName="Status"
                                                   HeaderText="Status" />
                </syncfusion:SfDataGrid.Columns>
            </syncfusion:SfDataGrid>
        </syncfusion:DataGridViewDefinition.DataGrid>
    </syncfusion:DataGridViewDefinition>
</syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
this.firstLevelNestedGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
{% endhighlight %}
{% endtabs %}

Similarly, you can wire `AddNewRowInitiating` event for `ViewDefinition.DataGrid`.

{% tabs %}
{% highlight c# %}
this.firstLevelNestedGrid.AddNewRowInitiating += FirstLevelNestedGrid_AddNewRowInitiating;

private void FirstLevelNestedGrid_AddNewRowInitiating(object? sender, DataGridAddNewRowInitiatingEventArgs e)
{
    
}
{% endhighlight %}
{% endtabs %}

For auto-generated relation (when the AutoGenerateRelations is set to true), the AddNewRow can be enabled by specifying the position to AddNewRowPosition property in AutoGeneratingRelations event.

{% tabs %}
{% highlight c# %}
this.dataGrid.AutoGeneratingRelations += DataGrid_AutoGeneratingRelations;

private void DataGrid_AutoGeneratingRelations(object? sender, DataGridAutoGeneratingRelationsArgs e)
{
    e.DataGridViewDefinition.DataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
}
{% endhighlight %}
{% endtabs %}

In the same way, you can wire `AddNewRowInitiating` event in the `AutoGeneratingRelations` event.

{% tabs %}
{% highlight c# %}
this.dataGrid.AutoGeneratingRelations += DataGrid_AutoGeneratingRelations;

private void DataGrid_AutoGeneratingRelations(object? sender, DataGridAutoGeneratingRelationsArgs e)
{
    e.DataGridViewDefinition.DataGrid.AddNewRowInitiating += DataGrid_AddNewRowInitiating;
}

private void DataGrid_AddNewRowInitiating(object? sender, DataGridAddNewRowInitiatingEventArgs e)
{
    
}
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-MasterdetailsView" src="Images\addnewrow\maui-dataGrid-AddNewRow_MasterDetailsView.png" width="404"/> 

### Changing the AddNewRow default text in details view grid

You can change the default static string of AddNewRow in details view grid by using the `SfDataGrid.AddNewRowText` property in `ViewDefinition.DataGrid`. The `AddNewRowText` property has higher priority than the text that is localized in resx file.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AddNewRowPosition="Top"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AutoGenerateRelations="False"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn HeaderText="Order ID" Format="#" 
                                          MappingName="OrderID" />
        <syncfusion:DataGridTextColumn  HeaderText="Customer ID" 
                                        MappingName="CustomerID.CustomerID" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship City" 
                                        MappingName="ShipCity" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship Country" 
                                        MappingName="ShipCountry" />
    </syncfusion:SfDataGrid.Columns>
    <syncfusion:SfDataGrid.DetailsViewDefinition>
    <syncfusion:DataGridViewDefinition RelationalColumn="Customers">
        <syncfusion:DataGridViewDefinition.DataGrid>
            <syncfusion:SfDataGrid x:Name="firstLevelNestedGrid"
                                   AddNewRowPosition="Top"
                                   AddNewRowText="Click here to add new row in child grid"
                                   AutoGenerateColumnsMode="None"
                                   AddNewRowPosition="Top">
                <syncfusion:SfDataGrid.Columns>
                    <syncfusion:DataGridTextColumn MappingName="OrderID"
                                                   HeaderText="Order ID"
                                                   Format="#" />
                    <syncfusion:DataGridTextColumn MappingName="Quantity"
                                                   HeaderText="Quantity" />
                    <syncfusion:DataGridTextColumn MappingName="Status"
                                                   HeaderText="Status" />
                </syncfusion:SfDataGrid.Columns>
            </syncfusion:SfDataGrid>
        </syncfusion:DataGridViewDefinition.DataGrid>
    </syncfusion:DataGridViewDefinition>
</syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
this.firstLevelNestedGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
this.firstLevelNestedGrid.AddNewRowText = "Click here to add new row in child grid";
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-MasterdetailsView-childtext" src="Images\addnewrow\maui-dataGrid-AddNewRow_ChildText.png" width="404"/> 
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

The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) provides a built-in row (called AddNewRow) that allows users to add new records to the underlying collection. The built-in add new row can be enabled or disabled by setting the [SfDataGrid.AddNewRowPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowPosition) property. The AddNewRowPosition property also denotes the position of the add new row in the DataGrid.

When you start editing in AddNewRow, the SfDataGrid control creates an instance of the underlying data object and adds it to the underlying collection when editing is completed.

> **Note:**
> 1. The underlying data object must be defined with a default (parameterless) constructor. If omitted, an error will occur when initiating a new row.
> 2. Selection must be enabled (set `SelectionMode` to any value other than `None`).
> 3. Editing must be enabled by setting `AllowEditing` to `true`.
> 4. `NavigationMode` should be set to allow cell-level editing (typically `DataGridNavigationMode.Cell`).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AutoGenerateColumnsMode="None"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AddNewRowPosition="Top">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                       HeaderText="Order ID" />
        <syncfusion:DataGridTextColumn MappingName="Customer"
                                       HeaderText="Customer" />
        <syncfusion:DataGridTextColumn MappingName="City"
                                       HeaderText="Ship City"/>
        <syncfusion:DataGridTextColumn MappingName="Country"
                                       HeaderText="Ship Country" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
OrderInfoViewModel viewModel = new OrderInfoViewModel();
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.AllowEditing = true;
dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="addnewRowpositon-top" src="Images\addnewrow\maui-dataGrid-AddNewRowPosition-top.png" width="404"/>  

## Changing the AddNewRow position

The position of the AddNewRow in SfDataGrid can be customized using the `SfDataGrid.AddNewRowPosition` property. By default, this property is set to `Top`. Valid values are:
- `DataGridAddNewRowPosition.Top` — Places the add new row at the top of the grid
- `DataGridAddNewRowPosition.Bottom` — Places the add new row at the bottom of the grid
- `DataGridAddNewRowPosition.FixedTop` — Places the add new row at the top of the grid and keeps it fixed
- `DataGridAddNewRowPosition.None` — Disables the add new row

The following code snippet demonstrates how to change the AddNewRow position to Bottom in SfDataGrid:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AutoGenerateColumnsMode="None"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AddNewRowPosition="Bottom">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                       HeaderText="Order ID" />
        <syncfusion:DataGridTextColumn MappingName="Customer"
                                       HeaderText="Customer" />
        <syncfusion:DataGridTextColumn MappingName="City"
                                       HeaderText="Ship City"/>
        <syncfusion:DataGridTextColumn MappingName="Country"
                                       HeaderText="Ship Country" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
OrderInfoViewModel viewModel = new OrderInfoViewModel();
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.AllowEditing = true;
dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Bottom;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="addnewRowpositon-bottom" src="Images\addnewrow\maui-dataGrid-AddNewRowPosition-bottom.png" width="404"/>

## Customize the newly added row position

By default, SfDataGrid adds a new data item from AddNewRow at the end of the collection. When data operations such as sorting or grouping are applied, the new item is positioned based on those operations. You can customize where the newly added data item appears by setting the [SfDataGrid.NewItemPlaceholderPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_NewItemPlaceholderPosition) property. Valid values include:
- `NewItemPlaceholderPosition.AtBeginning` — Places the new row at the beginning of the collection
- `NewItemPlaceholderPosition.AtEnd` — Places the new row at the end of the collection (default)
- `NewItemPlaceholderPosition.None` — Disables the new row placeholder

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AddNewRowPosition="Top"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       NewItemPlaceholderPosition="AtBeginning">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
OrderInfoViewModel viewModel = new OrderInfoViewModel();
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.AllowEditing = true;
dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
dataGrid.NewItemPlaceholderPosition = Syncfusion.Maui.Data.NewItemPlaceholderPosition.AtBeginning;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

## Changing the AddNewRow default text

You can change the default static string of AddNewRow in datagrid by using the [SfDataGrid.AddNewRowText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowText) property. The `AddNewRowText` property has higher priority than the text that is localized in resx file.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AutoGenerateColumnsMode="None"
                       AddNewRowText="Click here to add new row in datagrid"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AddNewRowPosition="Top">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                       HeaderText="Order ID" />
        <syncfusion:DataGridTextColumn MappingName="Customer"
                                       HeaderText="Customer" />
        <syncfusion:DataGridTextColumn MappingName="City"
                                       HeaderText="Ship City"/>
        <syncfusion:DataGridTextColumn MappingName="Country"
                                       HeaderText="Ship Country" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
OrderInfoViewModel viewModel = new OrderInfoViewModel();
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.AllowEditing = true;
dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
dataGrid.AddNewRowText = "Click here to add new row in datagrid";
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-text" src="Images\addnewrow\maui-dataGrid-AddNewRowText.png" width="404"/>  

## Initializing default values for AddNewRow

SfDataGrid allows you to set the default values for AddNewRow when it is initiated through the [DataGridAddNewRowInitiatingEventArgs.Object](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowInitiatingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridAddNewRowInitiatingEventArgs_Object) property in the [SfDataGrid.AddNewRowInitiating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowInitiating) event. This event fires when a new row is about to be added and allows you to initialize default values before the user begins editing.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AddNewRowPosition="Top"
                       AddNewRowInitiating="DataGrid_AddNewRowInitiating">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGrid.AddNewRowInitiating += DataGrid_AddNewRowInitiating;

private void DataGrid_AddNewRowInitiating(object? sender, DataGridAddNewRowInitiatingEventArgs e)
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
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True"
                       AddNewRowPosition="Top"
                       AddNewRowInitiating="DataGrid_AddNewRowInitiating">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
DataGrid.AddNewRowInitiating += DataGrid_AddNewRowInitiating;

private void DataGrid_AddNewRowInitiating(object? sender, DataGridAddNewRowInitiatingEventArgs e)
{
    var data = e.Object as OrderInfo;
    if(data != null)
    {
        data.OrderID = 101;
        data.Customer = new CustomerInfo();
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
    // This ends the edit of the current cell and reverts the entered value.
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

    // Process the commit operation in AddNewRow.
    var addNewRowController = this.dataGrid.AddNewRowController;
    addNewRowController.CommitAddNew(dataGrid);

    // Gets the row index of AddNewRow 
    rowColumnIndex.RowIndex = addNewRowController.GetAddNewRowIndex(dataGrid);
    this.dataGrid.SelectedRows.Clear();

    // If the AddNewRowPosition is Top, move the current cell to the next row 
    if (this.dataGrid.AddNewRowPosition == DataGridAddNewRowPosition.Top)
        rowColumnIndex.RowIndex = rowColumnIndex.RowIndex + 1;

    // This maintains the current cell border in the row after committing the AddNewRow.
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

DataGridAddNewRow can be customized in two ways:
- **Implicit Style**: Use a resource style when working with XAML-only pages. This approach applies globally to all `DataGridAddNewRowView` instances on the page.
- **DefaultStyle Property**: Use the `DefaultStyle` property when you need programmatic control or to apply a style from code-behind or when using XAML with C#.

### Apply implicit style

DataGridAddNewRow can be customized by writing a style for the [DataGridAddNewRowView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowView.html) TargetType. This approach is useful when defining styles in your page's resources.

{% tabs %}
{% highlight xaml %}
<ContentPage.Resources>
    <Style TargetType="syncfusion:DataGridAddNewRowView">
        <Setter Property="Background"
                Value="#1976D2" />
        <Setter Property="TextColor"
                Value="White" />
        <Setter Property="FontAttributes"
                Value="Bold" />
        <Setter Property="FontSize"
                Value="16" />
        <Setter Property="FontFamily"
                Value="Segoe UI" />
    </Style>
</ContentPage.Resources>
{% endhighlight %}
{% endtabs %}

### Apply default style

You can customize the AddNewRow's background, text color, font attributes, and font family using the [SfDataGrid.DefaultStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultStyle) property. This approach works with both XAML and code-behind.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AddNewRowPosition="Top"
                       SelectionUnit="Row"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       AllowEditing="True">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle  AddNewRowBackground="#1976D2"
                                   AddNewRowTextColor="White"
                                   AddNewRowFontAttributes="Bold"
                                   AddNewRowFontSize="16"
                                   AddNewRowFontFamily="Segoe UI" />
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
// Code-behind approach
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.AllowEditing = true;
dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;

// Create and apply the default style
DataGridStyle style = new DataGridStyle
{
    AddNewRowBackground = Color.FromArgb("#1976D2"),
    AddNewRowTextColor = Colors.White,
    AddNewRowFontAttributes = FontAttributes.Bold,
    AddNewRowFontSize = 16,
    AddNewRowFontFamily = "Segoe UI"
};
dataGrid.DefaultStyle = style;
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-ImplicitStyle" src="Images\addnewrow\maui-dataGrid-AddNewRow_ImplicitStyle.png" width="404"/>

## AddNewRow support in Master-Details View

You can enable the AddNewRow in the child `DetailsViewDataGrid` by setting the [SfDataGrid.AddNewRowPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowPosition) property in [ViewDefinition.DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ViewDefinition.html). The same prerequisites (selection enabled, editing enabled, and navigation mode set to Cell) apply to details view grids.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AutoGenerateColumnsMode="None"
                       AllowEditing="True"
                       AddNewRowPosition="Top"
                       SelectionMode="Single"
                       NavigationMode="Cell">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                       HeaderText="Order ID" />
        <syncfusion:DataGridTextColumn MappingName="Customer"
                                       HeaderText="Customer" />
        <syncfusion:DataGridTextColumn MappingName="City"
                                       HeaderText="Ship City" />
        <syncfusion:DataGridTextColumn MappingName="Country"
                                       HeaderText="Ship Country" />
    </syncfusion:SfDataGrid.Columns>
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:DataGridViewDefinition RelationalColumn="Orders">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid x:Name="firstLevelNestedGrid"
                                       AddNewRowPosition="Top">
                    <syncfusion:SfDataGrid.Columns>
                        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                                       HeaderText="Order ID" />
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
OrderInfoViewModel viewModel = new OrderInfoViewModel();

// Parent DataGrid
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;

// Child (DetailsView) DataGrid
SfDataGrid detailsGrid = new SfDataGrid();
detailsGrid.AllowEditing = true;
detailsGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
detailsGrid.NavigationMode = DataGridNavigationMode.Cell;
detailsGrid.SelectionMode = DataGridSelectionMode.Single;

// DetailsView definition
DataGridViewDefinition viewDefinition = new DataGridViewDefinition();
viewDefinition.RelationalColumn = "Orders";
viewDefinition.DataGrid = detailsGrid;

// Assign DetailsView to parent grid
dataGrid.DetailsViewDefinition.Add(viewDefinition);

// Set content
this.Content = dataGrid;
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

### Customizing AddNewRow in details view grid

You can customize the AddNewRow in the details view grid by setting the `SfDataGrid.AddNewRowText` property in `ViewDefinition.DataGrid`. The `AddNewRowText` property has higher priority than any localized text.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowEditing="True"
                       AddNewRowPosition="Top"
                       SelectionMode="Single"
                       NavigationMode="Cell">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                       HeaderText="Order ID" />
        <syncfusion:DataGridTextColumn MappingName="Customer"
                                       HeaderText="Customer" />
        <syncfusion:DataGridTextColumn MappingName="City"
                                       HeaderText="Ship City" />
        <syncfusion:DataGridTextColumn MappingName="Country"
                                       HeaderText="Ship Country" />
    </syncfusion:SfDataGrid.Columns>
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:DataGridViewDefinition RelationalColumn="Orders">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid x:Name="firstLevelNestedGrid"
                                       AddNewRowText="Click here to add new row in child grid"
                                       AddNewRowPosition="Top">
                    <syncfusion:SfDataGrid.Columns>
                        <syncfusion:DataGridTextColumn MappingName="OrderID"
                                                       HeaderText="Order ID" />
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
OrderInfoViewModel viewModel = new OrderInfoViewModel();

// Parent DataGrid
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;

// Child (DetailsView) DataGrid
SfDataGrid detailsGrid = new SfDataGrid();
detailsGrid.AllowEditing = true;
detailsGrid.AddNewRowPosition = DataGridAddNewRowPosition.Top;
detailsGrid.NavigationMode = DataGridNavigationMode.Cell;
detailsGrid.SelectionMode = DataGridSelectionMode.Single;
detailsGrid.AddNewRowText = "Click here to add new row in child grid";

// DetailsView definition
DataGridViewDefinition viewDefinition = new DataGridViewDefinition();
viewDefinition.RelationalColumn = "Orders";
viewDefinition.DataGrid = detailsGrid;

// Assign DetailsView to parent grid
dataGrid.DetailsViewDefinition.Add(viewDefinition);

// Set content
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="addnewRow-MasterdetailsView-childtext" src="Images\addnewrow\maui-dataGrid-AddNewRow_ChildText.png" width="404"/> 
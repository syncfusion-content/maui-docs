---
layout: post
title: Editing in MAUI DataGrid control | Syncfusion®
description: Learn here all about Editing support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui editing, maui editing
---

# Editing in MAUI DataGrid (SfDataGrid)

The Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) (SfDataGrid) control supports editing cell values by setting the [SfDataGrid.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowEditing) property to `true`, the [SfDataGrid.NavigationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_NavigationMode) to `Cell`, and the [SfDataGrid.SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionMode) to any value other than `None`.

To enable editing, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowEditing="True"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       ItemsSource="{Binding Orders}"/>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Multiple;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid with editing" src="Images\editing\maui-datagrid-editing.png">

## Column editing

To enable or disable editing for a specific column, you can simply set the [DataGridColumn.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_AllowEditing) property to `true` or `false`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       ItemsSource="{Binding Orders}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn AllowEditing="True"
                                       MappingName="OrderID"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.SelectionMode = DataGridSelectionMode.Multiple;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
DataGridTextColumn column = new DataGridTextColumn();
column.MappingName = "OrderID";
column.AllowEditing = true;
dataGrid.Columns.Add(column);
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

N>The `DataGridColumn.AllowEditing` takes higher priority than the `SfDataGrid.AllowEditing`.

## Entering into edit mode

To enter the edit mode, you can simply tap or double-tap the grid cell. The behavior of the edit mode tapping is controlled by the [SfDataGrid.EditTapAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EditTapAction) property, with the default value being `EditTapAction.DoubleTap`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowEditing="True"
                       NavigationMode="Cell"
                       SelectionMode="Multiple"
                       ItemsSource="{Binding Orders}"
                       EditTapAction="OnTap"/>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Multiple;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.EditTapAction = DataGridTapAction.OnTap; // For double tap , use DataGridTapAction.OnDoubleTap
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

N> The keyboard will collapse when the editing grid cell loses focus.

## Lost focus behavior

By default, when focus moves from the data grid to another control, the current cell value is not committed. To change this behavior and commit the current cell's value when focus moves, set the [SfDataGrid.LostFocusBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LostFocusBehavior) property to `EndEditCurrentCell`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid AllowEditing="True"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       LostFocusBehavior="EndEditCurrentCell"
                       ItemsSource="{Binding Orders}"/>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Multiple;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.LostFocusBehavior = DataGridLostFocusBehavior.EndEditCurrentCell;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

N> This behavior applies only to `DataGridNumericColumn` and `DataGridTextColumn`.

## Support for IEditableObject

The SfDataGrid supports committing and rolling back changes at the row level when the underlying data object implements the [IEditableObject](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ieditableobject?view=net-6.0) interface.

Editing changes in a row will be committed only when tapping on next row.

The `IEditableObject` interface provides the following methods to capture editing:

 * [BeginEdit](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ieditableobject.beginedit?view=net-6.0): Called to begin editing on the underlying data object when cells in a row enter edit mode.
 * [CancelEdit](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ieditableobject.canceledit?view=net-6.0): Called when you cancel editing to discard the changes in a row since the last BeginEdit call.
 * [EndEdit](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ieditableobject.endedit?view=net-6.0): Called when you move to the next row, tapping to commit changes in the underlying data object since the last `BeginEdit` call.

The following code snippet demonstrates a simple implementation of the `IEditableObject` interface:

{% tabs %}
{% highlight c# %}
public class OrderInfo : INotifyPropertyChanged, IEditableObject
{
    public OrderInfo()
    {
    }

    #region private variables

    private int _orderID;
    private string _customerID;
    private string _city;
    private string _country;
    private string _product;

    #endregion

    #region Public Properties

    public int OrderID
    {
        get { return _orderID; }
        set
        {
            this._orderID = value;
            RaisePropertyChanged("OrderID");
        }
    }

    public string Customer
    {
        get { return _customerID; }
        set
        {
            this._customerID = value;
            RaisePropertyChanged("Customer");
        }
    }

    public string City
    {
        get { return _city; }
        set
        {
            this._city = value;
            RaisePropertyChanged("City");
        }
    }

    public string Country
    {
        get { return _country; }
        set
        {
            this._country = value;
            RaisePropertyChanged("Country");
        }
    }

    public string Product
    {
        get { return _product; }
        set
        {
            this._product = value;
            RaisePropertyChanged("Product");
        }
    }

    #endregion

    #region INotifyPropertyChanged implementation

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged(String Name)
    {
        if (PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
    }

    private Dictionary<string, object> storedValues;


    public void BeginEdit()
    {
        this.storedValues = this.BackUp();
    }

    public void CancelEdit()
    {
        if (this.storedValues == null)
            return;

        foreach (var item in this.storedValues)
        {
            var itemProperties = this.GetType().GetTypeInfo().DeclaredProperties;
            var pDesc = itemProperties.FirstOrDefault(p => p.Name == item.Key);
            if (pDesc != null)
                pDesc.SetValue(this, item.Value);
        }
    }

    public void EndEdit()
    {
        if (this.storedValues != null)
        {
            this.storedValues.Clear();
            this.storedValues = null;
        }
        Debug.WriteLine("End Edit Called");
    }

    protected Dictionary<string, object> BackUp()
    {
        var dictionary = new Dictionary<string, object>();
        var itemProperties = this.GetType().GetTypeInfo().DeclaredProperties;
        foreach (var pDescriptor in itemProperties)
        {
            if (pDescriptor.CanWrite)
                dictionary.Add(pDescriptor.Name, pDescriptor.GetValue(this));
        }
        return dictionary;
    }

    #endregion
}
{% endhighlight %}
{% endtabs %}


## Editing events

The SfDataGrid invokes the following events during editing:

### CurrentCellBeginEdit

The [SfDataGrid.CurrentCellBeginEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentCellBeginEdit) event occurs when the CurrentCell enters into edit mode. The [DataGridCurrentCellBeginEditEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCurrentCellBeginEditEventArgs.html) has the following members that provides information for `SfDataGrid.CurrentCellBeginEdit` event:

 * [Cancel](): When this member set to `true`, the event is canceled and the CurrentCell does not enter into the edit mode.
 * [RowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCurrentCellBeginEditEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCurrentCellBeginEditEventArgs_RowColumnIndex): Gets the current row and column index of the DataGrid.
 * [Column](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCurrentCellBeginEditEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCurrentCellBeginEditEventArgs_Column): Gets the Grid Column of the SfDataGrid.

To hook the `SfDataGrid.CurrentCellBeginEdit` event, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowEditing="True"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       CurrentCellBeginEdit="dataGrid_CurrentCellBeginEdit"
                       ItemsSource="{Binding Orders}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
private void dataGrid_CurrentCellBeginEdit(object sender, DataGridCurrentCellBeginEditEventArgs e)
{
    // Editing prevented for the cell at RowColumnIndex(2,2).
    if (e.RowColumnIndex == new Syncfusion.Maui.GridCommon.ScrollAxis.RowColumnIndex(2, 2))
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### CurrentCellEndEdit

The [CurrentCellEndEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentCellEndEdit) event occurs when the CurrentCell exits the edit mode. The [DataGridCurrentCellEndEditEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCurrentCellEndEditEventArgs.html) has following members that provides information for `SfDataGrid.CurrentCellEndEdit` event:

 * [RowColumnIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCurrentCellEndEditEventArgs.html#Syncfusion_Maui_DataGrid_DataGridCurrentCellEndEditEventArgs_RowColumnIndex): Gets the current row and column index of the DataGrid.
 * [Cancel](): When this member set to `true`, the event is canceled and the edited value is not committed in the underlying collection.

To hook the `SfDataGrid.CurrentCellEndEdit` event, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowEditing="True"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       CurrentCellEndEdit="dataGrid_CurrentCellEndEdit"
                       ItemsSource="{Binding Orders}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
private void dataGrid_CurrentCellEndEdit(object sender, DataGridCurrentCellEndEditEventArgs e)
{
    // Editing prevented for the cell at RowColumnIndex(1,3).
    if (e.RowColumnIndex == new Syncfusion.Maui.GridCommon.ScrollAxis.RowColumnIndex(1, 3))
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Programmatic editing

### Begin editing

The SfDataGrid allows you to programmatically edit a cell by calling the [SfDataGrid.BeginEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_BeginEdit_System_Int32_System_Int32_) method. This method enters the particular cell into edit mode, enabling the editing of data programmatically. To programmatically edit a cell, refer to the code example below:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowEditing="True"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       Loaded="dataGrid_Loaded"
                       ItemsSource="{Binding Orders}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
private void dataGrid_Loaded(object sender, EventArgs e)
{
    //Edit the cell at 2nd row,2nd column programmatically
    this.dataGrid.BeginEdit(2, 2);
}
{% endhighlight %}
{% endtabs %}

### End editing

The [SfDataGrid.EndEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EndEdit) method allows you to programmatically conclude the editing process. When called, it commits the edited value of a cell to the underlying collection and exits the edit mode. To programmatically end the editing process, you can refer to the following code example

{% tabs %}
{% highlight c# %}
this.dataGrid.EndEdit();
{% endhighlight %}
{% endtabs %}

### Cancel editing

The [SfDataGrid.CancelEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CancelEdit) method allows you to programmatically cancel the editing process. When called, this method exits the edit mode of a cell without committing the edited value to the underlying collection. To programmatically cancel the editing process, use the code example provided:

{% tabs %}
{% highlight c# %}
this.dataGrid.CancelEdit();
{% endhighlight %}
{% endtabs %}

### Cancel editing for a particular Cell

The `SfDataGrid.CurrentCellBeginEdit` event can be used to cancel the editing operation for the corresponding cell. To cancel the editing operation using the `SfDataGrid.CurrentCellBeginEdit` event, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowEditing="True"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       CurrentCellBeginEdit="dataGrid_CurrentCellBeginEdit"
                       ItemsSource="{Binding Orders}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
private void dataGrid_CurrentCellBeginEdit(object sender, DataGridCurrentCellBeginEditEventArgs e)
{
    if (e.Column.MappingName == "OrderID" || e.RowColumnIndex.RowIndex == 2)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### Cancel edited value from being committed

To prevent the edited value from being committed, use the `CurrentCellEndEdit` event. This event prevents the edited values from being committed to the underlying collection. Refer to the code example below:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowEditing="True"
                       SelectionMode="Multiple"
                       NavigationMode="Cell"
                       CurrentCellEndEdit="dataGrid_CurrentCellEndEdit"
                       ItemsSource="{Binding Orders}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
private void dataGrid_CurrentCellEndEdit(object sender, DataGridCurrentCellEndEditEventArgs e)
{
    if (e.RowColumnIndex.RowIndex == 2)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Undo Redo an edit

The SfDataGrid allows you to undo or redo edits by setting the [SfDataGrid.AllowUndoRedo]() as `true`. When set as true, `Ctrl + z` in windows and `Cmd + z` in Mac Catalyst will undo an edit while `Ctrl + y` in windows and `Cmd + y` in Mac Catalyst will redo an edit. Refer to the following example to enable undo and redo actions:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}"
                       AllowEditing = "True"
                       SelectionMode = "Single"
                       AllowUndoRedo = "True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

### MaxUndoRedoActions

The [SfDataGrid.MAxUndoRedoActions]() property allows users to adjust the number of undo and redo actions in the datagrid. Refer to the following example to set `MaxUndoRedoActions`: 

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}"
                       AllowEditing = "True"
                       SelectionMode = "Single"
                       AllowUndoRedo = "True"
                       MaxUndoRedoActions = "10">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;
dataGrid.MaxUndoRedoActions = 10;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

### Undo Programmatically

The [Undo]() method can be used to undo an edit in the datagrid. To undo an edit using the `Undo` method, refer to the example below:

{% tabs %}
{% highlight xaml %}
<Grid RowDefinitions="*,50">
    <syncfusion:SfDataGrid x:Name = "dataGrid"
                           Grid.Row ="0"
                           ItemsSource = "{Binding Orders}"
                           AllowEditing = "True"
                           SelectionMode = "Single"
                           AllowUndoRedo = "True">
    </syncfusion:SfDataGrid>
    <Button Grid.Row="1"
            Text="Undo"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            Clicked="Button_Clicked"/>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;

Button button = new Button();
button.Text = "Undo";
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Clicked += Button_Clicked;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
grid.Children.Add(dataGrid);
grid.Children.Add(button);
grid.SetRow(dataGrid, 0);
grid.SetRow(button, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Button_Clicked(object sender, EventArgs e)
{
    dataGrid.UndoRedoController.Undo();
}
{% endhighlight %}
{% endtabs %}

### Redo Programmatically

The [Redo]() method can be used to redo an edit in the datagrid. To redo an edit using the `Redo` method, refer to the example below:

{% tabs %}
{% highlight xaml %}
<Grid RowDefinitions="*,50">
    <syncfusion:SfDataGrid x:Name = "dataGrid"
                           Grid.Row ="0"
                           ItemsSource = "{Binding Orders}"
                           AllowEditing = "True"
                           SelectionMode = "Single"
                           AllowUndoRedo = "True">
    </syncfusion:SfDataGrid>
    <Button Grid.Row="1"
            Text="Redo"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            Clicked="Button_Clicked"/>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;

Button button = new Button();
button.Text = "Redo";
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Clicked += Button_Clicked;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
grid.Children.Add(dataGrid);
grid.Children.Add(button);
grid.SetRow(dataGrid, 0);
grid.SetRow(button, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Button_Clicked(object sender, EventArgs e)
{
    dataGrid.UndoRedoController.Redo();
}
{% endhighlight %}
{% endtabs %}

### Clear History

The [ClearHistory]() method can be used to clear the history of undo and redo stored in the respective stacks. To clear the history using the `ClearHistory` method, refer to the example below:

{% tabs %}
{% highlight xaml %}
<Grid RowDefinitions="*,50">
    <syncfusion:SfDataGrid x:Name = "dataGrid"
                           Grid.Row ="0"
                           ItemsSource = "{Binding Orders}"
                           AllowEditing = "True"
                           SelectionMode = "Single"
                           AllowUndoRedo = "True">
    </syncfusion:SfDataGrid>
    <Button Grid.Row="1"
            Text="Clear History"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            Clicked="Button_Clicked"/>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;

Button button = new Button();
button.Text = "Clear History";
button.HorizontalOptions = LayoutOptions.Center;
button.VerticalOptions = LayoutOptions.Center;
button.Clicked += Button_Clicked;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
grid.Children.Add(dataGrid);
grid.Children.Add(button);
grid.SetRow(dataGrid, 0);
grid.SetRow(button, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Button_Clicked(object sender, EventArgs e)
{
    dataGrid.UndoRedoController.ClearHistory();
}
{% endhighlight %}
{% endtabs %}

### Undo and Redo Count

The number of undo and redo actions can be retrieved using [UndoCount]() and [RedoCount]().Refer to the code below to set `UndoCount` and `RedoCount`:

{% tabs %}
{% highlight xaml %}
<Grid RowDefinitions="50,*" ColumnDefinitions="*,*">
    <HorizontalStackLayout Grid.Row="0" Grid.Column="0" VerticalOptions="Center" HorizontalOptions="End">
        <Label Text="Undo Count"
               FontSize="16"
               FontAttributes="Bold"
               Margin="10,0"/>
        <Label x:Name="undoCountLabel"
               Text="{Binding Source={x:Reference dataGrid}, Path=UndoRedoController.UndoCount, StringFormat='{0}'}"
               FontSize="16"
               FontAttributes="Bold"
               Margin="10,0"/>
    </HorizontalStackLayout>
    <HorizontalStackLayout Grid.Row="0" Grid.Column="1" VerticalOptions="Center" HorizontalOptions="Start">
        <Label Text="Redo Count"
               FontSize="16"
               FontAttributes="Bold"
               Margin="10,0"/>
        <Label x:Name="redoCountLabel"
               Text="{Binding Source={x:Reference dataGrid}, Path=UndoRedoController.RedoCount, StringFormat='{0}'}"
               FontSize="16"
               FontAttributes="Bold"
               Margin="10,0"/>
    </HorizontalStackLayout>
    <syncfusion:SfDataGrid x:Name = "dataGrid"
                           Grid.Row="1"
                           Grid.ColumnSpan="2"
                           ItemsSource = "{Binding Orders}"
                           AllowEditing = "True"
                           SelectionMode = "Single"
                           AllowUndoRedo = "True">
    </syncfusion:SfDataGrid>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;

var undoLabelTitle = new Label();
undoLabelTitle.Text = "Undo Count";
undoLabelTitle.FontSize = 16;
undoLabelTitle.FontAttributes = FontAttributes.Bold;
undoLabelTitle.Margin = new Thickness(10, 0);

var undoCountLabel = new Label();
undoCountLabel.FontSize = 16;
undoCountLabel.FontAttributes = FontAttributes.Bold;
undoCountLabel.Margin = new Thickness(10, 0);
undoCountLabel.SetBinding(Label.TextProperty, new Binding(path: "UndoRedoController.UndoCount", source: dataGrid, stringFormat: "{0}"));

var undoLayout = new HorizontalStackLayout();
undoLayout.VerticalOptions = LayoutOptions.Center;
undoLayout.HorizontalOptions = LayoutOptions.End;
undoLayout.Children.Add(undoLabelTitle);
undoLayout.Children.Add(undoCountLabel);


var redoLabelTitle = new Label();
redoLabelTitle.Text = "Redo Count";
redoLabelTitle.FontSize = 16;
redoLabelTitle.FontAttributes = FontAttributes.Bold;
redoLabelTitle.Margin = new Thickness(10, 0);

var redoCountLabel = new Label();
redoCountLabel.FontSize = 16;
redoCountLabel.FontAttributes = FontAttributes.Bold;
redoCountLabel.Margin = new Thickness(10, 0);
redoCountLabel.SetBinding(Label.TextProperty, new Binding(path: "UndoRedoController.RedoCount", source: dataGrid, stringFormat: "{0}"));

var redoLayout = new HorizontalStackLayout();
redoLayout.VerticalOptions = LayoutOptions.Center;
redoLayout.HorizontalOptions = LayoutOptions.Start;
redoLayout.Children.Add(redoLabelTitle);
redoLayout.Children.Add(redoCountLabel);


Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
grid.Children.Add(dataGrid);
grid.Children.Add(undoLayout);
grid.Children.Add(redoLayout);
grid.SetRow(undoLayout, 0);
grid.SetColumn(undoLayout, 0);
grid.SetRow(redoLayout, 0);
grid.SetColumn(redoLayout, 1);
grid.SetRow(dataGrid, 1);
grid.SetColumnSpan(dataGrid, 2);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

### Events in Undo Redo

#### Cell Undoing
The [SfDataGrid.CellUndoing]() event occurs when the undo action is in progress for a cell. The [DataGridUndoRedoEventArgs]() has the following members that provides information for `SfDataGrid.CellUndoing` event:

 * [Cancel](): When this member is set to `true`, the event is canceled and the undo action for the cell does not happen.
 * [RowIndex](): Gets the row index of the undoing cell in the DataGrid.
 * [ColumnIndex](): Gets the column index of the undoing cell in the DataGrid.
 * [Column](): Gets the Grid Column of the DataGrid.
 * [OldValue](): Gets the old value of the undoing cell in the DataGrid.
 * [NewValue](): Gets the new value of the undoing cell in the DataGrid.

To hook the `SfDataGrid.CellUndoing` event, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}"
                       AllowEditing = "True"
                       SelectionMode = "Single"
                       AllowUndoRedo = "True"
                       CellUndoing = "DataGrid_CellUndoing">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;
dataGrid.CellUndoing += DataGrid_CellUndoing;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void DataGrid_CellUndoing(object sender, DataGridUndoRedoEventArgs e)
{
    if (e.ColumnIndex == 0)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

#### Cell Redoing

The [SfDataGrid.CellRedoing]() event occurs when the redo action is in progress for a cell. To hook the `SfDataGrid.CellRedoing` event, follow the code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}"
                       AllowEditing = "True"
                       SelectionMode = "Single"
                       AllowUndoRedo = "True"
                       CellRedoing = "DataGrid_CellRedoing">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
dataGrid.AllowUndoRedo = true;
dataGrid.CellRedoing += DataGrid_CellRedoing;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void DataGrid_CellRedoing(object sender, DataGridUndoRedoEventArgs e)
{
    if (e.ColumnIndex == 0)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}
---
layout: post
title: Editing in MAUI DataGrid control | Syncfusion
description: Learn here all about Editing support in Syncfusion MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Editing in MAUI DataGrid (SfDataGrid)

The [Syncfusion .NET MAUI DataGrid]() (SfDataGrid) control supports editing cell values by setting the [SfDataGrid.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowEditing) property to true, [SfDataGrid.NavigationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_NavigationMode) to Cell, and setting the [SfDataGrid.SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionMode) to any value other than None.

To enable editing, follow the code example:

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           AllowEditing="True"
                           SelectionMode="Multiple"    
                           NavigationMode="Cell" 
                           ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}

{% highlight c# %}
dataGrid.AllowEditing = true;
dataGrid.SelectionMode = SelectionMode.Multiple;
dataGrid.NavigationMode = NavigationMode.Cell;
{% endhighlight %}
{% endtabs %}

![DataGrid with editing](Images\editing\maui-datagrid-editing.png)

## Column editing

To enable or disable editing for a specific column, you can simply set the [DataGridColumn.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_AllowEditing) property to `true` or `false`.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           SelectionMode="Multiple"    
                           NavigationMode="Cell" 
                           ItemsSource="{Binding OrderInfoCollection}">

    <syncfusion:DataGridTextColumn AllowEditing="True"
                                   MappingName="OrderID" />
    </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.SelectionMode = SelectionMode.Multiple;
dataGrid.NavigationMode = NavigationMode.Cell;
DataGridTextColumn column = new DataGridTextColumn();
column.MappingName="OrderID";
column.AllowEditing = false;
{% endhighlight %}
{% endtabs %}

N>The `DataGridColumn.AllowEditing` takes higher priority than the `SfDataGrid.AllowEditing`.

## Entering into edit mode

To enter the edit mode, you can simply tap or double-tap the grid cell. The behavior of the edit mode tapping is controlled by the [SfDataGrid.EditTapAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EditTapAction) property, with the default value being `EditTapAction.DoubleTap`.

{% tabs %}
{% highlight xaml %}
    <sfgrid:SfDataGrid x:Name="dataGrid"
                               AllowEditing="True"
                               ItemsSource="{Binding OrderInfoCollection}"
                               EditTapAction="OnTap">
{% endhighlight %}
{% highlight c# %}
//Enter edit mode in single tap
this.dataGrid.EditTapAction = TapAction.OnTap;
//Enter edit mode in double tap
this.dataGrid.EditTapAction = TapAction.OnDoubleTap;
{% endhighlight %}
{% endtabs %}

N>The keyboard will collapse when the editing grid cell loses focus.

## Lost focus behavior

By default, when focus moves from the data grid to another control, the current cell value is not committed. To change this behavior and commit the current cell's value when focus moves, set the `SfDataGrid.LostFocusBehavior` property to `EndEditCurrentCell`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid AllowEditing="True"
                       SelectionMode="Multiple"    
                       NavigationMode="Cell"
                       LostFocusBehavior="EndEditCurrentCell"
                       ItemsSource="{Binding OrderInfoCollection}" />
{% endhighlight %}
{% endtabs %}

N>This behavior applies only to `DataGridNumericColumn` and `DataGridTextColumn`.

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
    private int _employeeID;
    private int _customerID;
    private bool _isClosed;
    private string _firstName;
    private string _lastName;
    private string _gender;
    private string _shipCity;
    private string _shipCountry;
    private string _freight;
    private DateTime _shippingDate;

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

    public int EmployeeID
    {
        get { return _employeeID; }
        set
        {
            this._employeeID = value;
            RaisePropertyChanged("EmployeeID");
        }
    }

    public int CustomerID
    {
        get { return _customerID; }
        set
        {
            this._customerID = value;
            RaisePropertyChanged("CustomerID");
        }
    }

    public bool IsClosed
    {
        get { return _isClosed; }
        set
        {
            this._isClosed = value;
            RaisePropertyChanged("IsClosed");
        }
    }

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            this._firstName = value;
            RaisePropertyChanged("FirstName");
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            this._lastName = value;
            RaisePropertyChanged("LastName");
        }
    }

    public string Gender
    {
        get { return _gender; }
        set
        {
            this._gender = value;
            RaisePropertyChanged("Gender");
        }
    }

    public string ShipCity
    {
        get { return _shipCity; }
        set
        {
            this._shipCity = value;
            RaisePropertyChanged("ShipCity");
        }
    }

    public string ShipCountry
    {
        get { return _shipCountry; }
        set
        {
            this._shipCountry = value;
            RaisePropertyChanged("ShipCountry");
        }
    }

    public string Freight
    {
        get { return _freight; }
        set
        {
            this._freight = value;
            RaisePropertyChanged("Freight");
        }
    }

    public DateTime ShippingDate
    {
        get { return _shippingDate; }
        set
        {
            this._shippingDate = value;
            RaisePropertyChanged("ShippingDate");
        }
    }

    #endregion

    #region INotifyPropertyChanged implementation

    public event PropertyChangedEventHandler PropertyChanged;

	private void RaisePropertyChanged (String Name)
	{
		if (PropertyChanged != null)
			this.PropertyChanged (this, new PropertyChangedEventArgs (Name));
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
 * [RowColumnIndex](): Gets the current row and column index of the DataGrid.
 * [Column](): Gets the Grid Column of the SfDataGrid.

To hook the `SfDataGrid.CurrentCellBeginEdit` event, follow the code example:

{% tabs %}
{% highlight c# %}
this.dataGrid.CurrentCellBeginEdit += DataGrid_CurrentCellBeginEdit;

private void DataGrid_CurrentCellBeginEdit(object sender, DataGridCurrentCellBeginEditEventArgs e)
{
    // Editing prevented for the cell at RowColumnIndex(2,2).
    if (e.RowColumnIndex == new Syncfusion.Maui.GridCommon.ScrollAxis.RowColumnIndex(2, 2)) 
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### CurrentCellEndEdit

The [CurrentCellEndEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentCellEndEdit) event occurs when the CurrentCell exits the edit mode. The [DataGridCurrentCellEndEditEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCurrentCellEndEditEventArgs.html) has following members that provides information for `SfDataGrid.CurrentCellEndEdit` event:

 * [RowColumnIndex](): Gets the current row and column index of the DataGrid.
 * [Cancel](): When this member set to `true`, the event is canceled and the edited value is not committed in the underlying collection.

To hook the `SfDataGrid.CurrentCellEndEdit` event, follow the code example:

{% tabs %}
{% highlight c# %}
this.dataGrid.CurrentCellEndEdit += DataGrid_CurrentCellEndEdit;

private void DataGrid_CurrentCellEndEdit(object sender, DataGridCurrentCellEndEditEventArgs e)
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
{% highlight c# %}
this.dataGrid.Loaded += DataGrid_Loaded;

private void DataGrid_Loaded(object sender, EventArgs e)
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
{% highlight c# %}
this.dataGrid.CurrentCellBeginEdit += DataGrid_CurrentCellBeginEdit;

private void DataGrid_CurrentCellBeginEdit(object sender, DataGridCurrentCellBeginEditEventArgs e)
{
    if (e.Column.MappingName == "OrderID" || e.RowColumnIndex.RowIndex == 2)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### Cancel edited value from being committed

To prevent the edited value from being committed, use the `CurrentCellEndEdit` event. This event prevents the edited values from being committed to the underlying collection. Refer to the code example below:

{% tabs %}
{% highlight c# %}
this.dataGrid.CurrentCellEndEdit += DataGrid_CurrentCellEndEdit;

private void DataGrid_CurrentCellEndEdit(object sender, DataGridCurrentCellEndEditEventArgs e)
{
    if (e.RowColumnIndex.RowIndex == 2)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}
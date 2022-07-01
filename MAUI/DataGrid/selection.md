---
layout: post
title: Selection in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Selection support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Selection in .NET MAUI DataGrid (SfDataGrid)

MAUI DataGrid (SfDataGrid) allows you to select one or more rows based on the SelectionMode.

## 	Current Cell Navigation
Keyboard navigation through the cells and rows is determined based on the NavigationMode property. NavigationMode.Cell allows you to navigate between the cells in a row as well as between rows. NavigationMode.Row allows you to navigate only between rows. 

## Selection Modes
<table>
<tr>
<th> Modes </th>
<th> Description </th>
</tr>
<tr>
<td> {{None| markdownify }} </td>
<td>Disables selection, and no rows or cells can be selected. This is the default value.</td>
</tr>
<tr>
<td> {{ Single | markdownify }} </td>
<td> Allows selection of a single row or cell only. Upon selecting the next row or cell, the selection in the previous row or cell is cleared. </td>
</tr>
<tr>
<td> {{ Multiple | markdownify }}  </td>
<td> Allows selection of more than one row or cell. Selection is not cleared when selecting more than one row or cell. When you click on an already selected row or cell for the second time, the selection is cleared. </td>
</tr>
<tr>
<td>  {{ SingleDeselect | markdownify }}  </td>
<td> Allows selection of a single row or cell only. However, upon tapping the row or cell again, the selection is cleared. Similar to single mode, upon selecting the next row or cell, the selection in the previous row or cell is cleared. </td>
</tr>
</table>

## Disable selection for rows and columns
You can disable selection in a particular row or cell or column by handling the CurrentCellActivating event.

## Getting selected rows
SfDataGrid provides SelectedIndex, SelectedRow, and CurrentRow properties to get details of the selected rows when the selection mode is Single, Multiple, and SingleDeselect.

SfDataGrid.SelectedRow: Provides the underlying data object of the selected row. Denotes the underlying data object of the first selected row in multiple selection.
SfDataGrid.SelectedIndex: Provides the row index of SfDataGrid.SelectedItem. Denotes the index of first selected row in multiple selection.
SfDataGrid.CurrentRow: Provides the underlying data object of the currently selected row in the data grid. Denotes the underlying data object of lastly selected row in multiple selection.
SfDataGrid.SelectedRows: Provides all the selected records of the selected items when multiple selection is enabled.

## CurrentRow vs SelectedRow 
Both the SelectedRow and CurrentRow returns the same data object when the selection mode is single. When multiple selection is enabled, the initially selected record will be maintained in the SelectedRow and the currently selected record will be maintained in the CurrentRow.

## Programmatic selection

### Process selection using properties
When the selection mode is set a value other than None, programmatically select a row in two ways either by setting the row index to the SfDataGrid.SelectedIndex property or by setting the underlying object to be selected to the SfDataGrid.SelectedRow property.
When SelectionMode is set as Multiple, select more than one row by setting the SfDataGrid.SelectedRows property. 

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        //Perform selection using selected index
        this.dataGrid.SelectedIndex = 3;

        //Perform selection using selected row
        this.dataGrid.SelectedRow = new ViewModel().OrderInfoCollection[3];
    }
}
{% endhighlight %}
{% endtabs %}

When the selection mode is multiple, programmatically select more than one row by adding the underlying object to be selected to the SfDataGrid.SelectedRows property.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        ////Perform multiple selection using selected roes
        
        var viewModel = new ViewModel();
        dataGrid.SelectedRows.Add(viewModel.OrderInfoCollection[4]);
        dataGrid.SelectedRows.Add(viewModel.OrderInfoCollection[6]);
        dataGrid.SelectedRows.Add(viewModel.OrderInfoCollection[9]);
        dataGrid.SelectedRows.Add(viewModel.OrderInfoCollection[11]);
    }
}
{% endhighlight %}
{% endtabs %}


![Multiple Selection in .NET MAUI DataGrid](Images/selection/maui-datagrid-multiple-selection.png)

### Process selection using methods
You can select all the rows in the datagrid using SfDataGrid.SelectAll() method.
{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.SelectAll();
    }
}
{% endhighlight %}
{% endtabs %}

![SelectionAll in .NET MAUI DataGrid](Images/selection/maui-datagrid-selectall.png)

## Keyboard behavior
<table>
<tr>
<th>
Key or KeyCombinations
</th>
<th>
Description
</th>
</tr>
<tr>
<td>
<kbd>DownArrow</kbd>
</td>
<td>
Moves CurrentCell directly below the active current cell. If the CurrentCell is in last row, pressing <kbd>DownArrow</kbd> does nothing.
</td>
</tr>
<tr>
<td>
<kbd>UpArrow</kbd>
</td>
<td>
Moves the CurrentCell directly above the active current cell. If the CurrentCell is in first row, pressing <kbd>UpArrow</kbd> does nothing.
</td>
</tr>
<tr>
<td>
<kbd>LeftArrow</kbd>
</td>
<td>
Moves the current cell to previous to the active current cell. If the CurrentCell is in first cell, pressing <kbd>LeftArrow</kbd> does nothing. 
</td>
</tr>
<tr>
<td>
<kbd>RightArrow</kbd>
</td>
<td>
Moves the current cell to next to the active current cell. If the CurrentCell is in last cell, pressing <kbd>RightArrow</kbd> does nothing. 
</td>
</tr>
<tr>
<td>
<kbd>Home</kbd> / <kbd> Ctrl</kbd> + <kbd>LeftArrow</kbd>
</td>
<td>
Moves the current cell to the first cell of the current row.
</td>
</tr>
<tr>
<td>
<kbd>End</kbd> / <kbd>Ctrl</kbd> + <kbd>RightArrow</kbd>
</td>
<td>
Moves the current cell to the last cell of the current row.
</td>
</tr>
<tr>
<td>
<kbd>PageDown</kbd>
</td>
<td>
The SfDataGrid will be scrolled to next set of rows that are not displayed in view, including the row that are partially displayed and the current cell is set to last row.
</td>
</tr>
<tr>
<td>
<kbd>PageUp</kbd>
</td>
<td>
The SfDataGrid will be scrolled to previous set of rows that are not displayed in view, including the row that are partially displayed and the current cell is set to the first row.
</td>
</tr>
<tr>
<td>
<kbd>Tab</kbd>
</td>
<td>
Moves the current cell to next to the active current cell. If the active current cell is the last cell of the current row, the focus will moved to first cell of the row next to the current row.If the active current cell is the last cell of the last row, the focus will be moved to next control in the tab order of the parent container.
</td>
</tr>
<tr>
<td>
<kbd>Shift</kbd> + <kbd>Tab</kbd>
</td>
<td>
Moves the current cell to previous to the active current cell. If the active current cell is the first cell of the current row, the current cell will moved to last cell of the row previous to the current row.If the active current cell is the first cell of the first row, the focus will be moved to previous control in the tab order of the parent container.
</td>
</tr>
<tr>
<td>
<kbd>Ctrl</kbd> + <kbd>DownArrow</kbd>
</td>
<td>
Moves the current cell to the current column of the last row.
</td>
</tr>
<tr>
<td>
<kbd>Ctrl</kbd> + <kbd>UpArrow</kbd>
</td>
<td>
Moves the current cell to the current column of the first row.
</td>
</tr>
<tr>
<td>
<kbd>Ctrl</kbd> + <kbd>Home</kbd>
</td>
<td>
Moves the current cell to the first cell of the first row.
</td>
</tr>
<tr>
<td>
<kbd>Ctrl</kbd> + <kbd>End</kbd>
</td>
<td>
Moves the current cell to the last cell of the last row.
</td>
</tr>
<tr>
<td>
<kbd>Enter</kbd>
</td>
<td>
If the active current cell is in edit mode, the changes will committed and moves the current cell to below the active current cell. If the active current cell is in last row, commits changes only and retains in the same cell.
</td>
</tr>
<tr>
<td>
<kbd>Ctrl</kbd> + <kbd>A</kbd>
</td>
<td>
All rows or cells will be selected.
</td>
</tr>
</table>

## Move Current Cell
The CurrentCell can be moved to a particular RowColumnIndex by using the SfDataGrid.MoveCurrentCellTo() method. This method is not applicable when the SfDataGrid.SelectionMode is None or NavigationMode is Row.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.MoveCurrentCellTo(new RowColumnIndex(3, 3), false);
    }
}
{% endhighlight %}
{% endtabs %}

![Move current cell in .NET MAUI DataGrid](Images/selection/maui-datagrid-movecurrentcell.png)

## Clear selection
Data grid allows you to clear the selection applied in the grid rows and columns either by setting the SfDataGrid.SelectionMode to None or by calling the SfDataGrid.SelectionController.ClearSelection() method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        //Clear selection using selection mode
        dataGrid.SelectionMode = Syncfusion.Maui.DataGrid.DataGridSelectionMode.None;

        //Clear selection using clear selection method.
        dataGrid.ClearSelection();
    }
}
{% endhighlight %}
{% endtabs %}

## Events in selection
The data grid provides the following events for selection:

SelectionChanging: This event is raised while selecting a row at the execution time before the row is selected. So it allows canceling the selection action by setting the Cancel property of DataGridSelectionChangingEventArgs.
SelectionChanged: This event is raised after a row is selected.
These two events are triggered with DataGridSelectionChangingEventArgs and DataGridSelectionChangedEventArgs that contain the following properties:

AddedRows: Gets collection of the underlying data objects added for selection.
RemovedRows: Gets collection of the underlying data objects removed from selection.

To hook the SelectionChanging event and cancel the selection in following code example:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.SelectionChanging += DataGrid_SelectionChanging;
    }

    private void DataGrid_SelectionChanging(object sender, Syncfusion.Maui.DataGrid.DataGridSelectionChangingEventArgs e)
    {
        e.Cancel = true;
    }
}
{% enhighlight %}
{% endtabs %}

To get the selected item in code-behind using the SelectionChanged event, follow the code example:
{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.SelectionChanged += DataGrid_SelectionChanged;
    }

    private void DataGrid_SelectionChanged(object sender, Syncfusion.Maui.DataGrid.DataGridSelectionChangedEventArgs e)
    {
        var selectedItem = e.AddedRows[0];
    }
}
{% endhighlight %}
{% endtabs %}

## CurrentRow

The SfDataGrid.CurrentRow property holds the underlying data of the last selected row in data grid.

Get the current row in the SfDataGrid.SelectionChanged event by setting the SfDataGrid.SelectionMode as Multiple or SingleDeselect. If the SelectionMode is Single, the current item and selected item are same.

## 	Customizing Selection Appearance
You can change the selection back color and text color by using SelectionBackground and SelectedRowTextColor in SfDataGrid.DefaultStyle.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle SelectedRowTextColor="White" SelectionBackground="Brown"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.SelectedRowTextColor = Colors.White;
        this.dataGrid.DefaultStyle.SelectionBackground = Colors.Brown;
    }
}
{% endhighlight %}
{% endtabs %}

![Selection style in .NET MAUI DataGrid](Images/selection/maui-datagrid-selection-style.png)

## 	Changing current cell border color and width
You can change the current cell border color and width by using CurrentCellBorderColor and CurrentCellBorderWidth in SfDataGrid.DefaultStyle.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle CurrentCellBorderColor="Brown" CurrentCellBorderWidth="4"/>
    </syncfusion:SfDataGrid.DefaultStyle>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.dataGrid.DefaultStyle.CurrentCellBorderColor = Colors.Brown;
        this.dataGrid.DefaultStyle.CurrentCellBorderWidth = 4;
    }
}
{% endhighlight %}
{% endtabs %}

![Current cell style in .NET MAUI DataGrid](Images/selection/maui-datagrid-currentcell-style.png)

## Binding selection properties
The SfDataGrid allows you to bind the selection properties such as SelectedIndex and SelectedRow to the properties in the ViewModel directly.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}
<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}"
                       SelectedIndex="{Binding DataGridSelectedIndex}"
                       SelectedRow="{Binding DataGridSelectedRow}"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
 private int dataGridSelectedIndex;

 private object dataGridSelectedRow;

 public int DataGridSelectedIndex
 {
     get
     {
         return dataGridSelectedIndex;
     }
     set
     {
         this.dataGridSelectedIndex = value;
         RaisePropertyChanged("DataGridSelectedIndex");
     }
 }

 public object DataGridSelectedRow
 {
     get
     {
         return dataGridSelectedRow;
     }
     set
     {
         this.dataGridSelectedRow = value;
         RaisePropertyChanged("DataGridSelectedRow");
     }
 }

 public ViewModel()
 {
     DataGridSelectedIndex = 2;
     DataGridSelectedRow = OrderInfoCollection[5];
 }
{% endhighlight %}
{% endtabs %}





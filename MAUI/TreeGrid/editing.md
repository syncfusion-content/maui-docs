---
layout: post
title: Editing in .NET MAUI TreeGrid | Syncfusion®
description: Configure .NET MAUI TreeGrid cell editing, including edit modes, events, programmatic editing, and IEditableObject support.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords: maui treegrid, .net maui treegrid, treegrid editing, maui tree grid editing, allow editing, begin edit, end edit, cancel edit
---

# Editing in .NET MAUI TreeGrid (SfTreeGrid)

The Syncfusion® [.NET MAUI TreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) (SfTreeGrid) supports editing cell values. Set the [SfTreeGrid.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowEditing) property to `true` to enable editing. The default value is `false`. Editing works at cell level, so [SfTreeGrid.NavigationMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_NavigationMode) must be `Cell` (the default value).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeGrid;assembly=Syncfusion.Maui.TreeGrid"
             xmlns:local="clr-namespace:TreeGridMAUI"
             x:Class="TreeGridMAUI.MainPage">

    <ContentPage.BindingContext>
        <local:EmployeeViewModel />
    </ContentPage.BindingContext>

    <syncfusion:SfTreeGrid x:Name="treeGrid"
                           ItemsSource="{Binding Employees}"
                           ChildPropertyName="Children"
                           AllowEditing="True"
                           NavigationMode="Cell" />
</ContentPage>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.TreeGrid;

SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeViewModel viewModel = new EmployeeViewModel();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowEditing = true;
treeGrid.NavigationMode = TreeGridNavigationMode.Cell;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Column editing

To enable or disable editing for a particular column, set the [TreeGridColumn.AllowEditing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_AllowEditing) property. Until it is set explicitly, the column uses the `SfTreeGrid.AllowEditing` value.

The following column types can be edited:

* `TreeGridTextColumn`
* `TreeGridNumericColumn`
* `TreeGridDateColumn`
* `TreeGridComboBoxColumn`
* `TreeGridPickerColumn`
* `TreeGridTemplateColumn`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="Children"
                       AutoGenerateColumnsMode="None"
                       AllowEditing="True">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="EmployeeName"
                                       HeaderText="Name"
                                       AllowEditing="True" />
        <syncfusion:TreeGridNumericColumn MappingName="EmployeeID"
                                          HeaderText="ID"
                                          AllowEditing="False" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.Employees;
treeGrid.ChildPropertyName = "Children";
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.AllowEditing = true;

treeGrid.Columns.Add(new TreeGridTextColumn()
{
    MappingName = "EmployeeName",
    HeaderText = "Name",
    AllowEditing = true
});
treeGrid.Columns.Add(new TreeGridNumericColumn()
{
    MappingName = "EmployeeID",
    HeaderText = "ID",
    AllowEditing = false
});
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

N> The `TreeGridColumn.AllowEditing` property takes priority over `SfTreeGrid.AllowEditing`.

N> For `TreeGridCheckBoxColumn`, setting `AllowEditing` to `false` makes the check box read-only, and user interaction does not update the underlying data source.

## Entering into edit mode

The edit mode is entered by tapping the current cell, or by pressing the `F2` key on the current cell. The gesture is controlled by the [SfTreeGrid.EditTapAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_EditTapAction) property of type [TreeGridTapAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTapAction.html). The supported values are:

* `TreeGridTapAction.OnTap` – Enters edit mode on a single tap.
* `TreeGridTapAction.OnDoubleTap` – Enters edit mode on a double tap. This is the default value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="Children"
                       AllowEditing="True"
                       EditTapAction="OnTap" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.AllowEditing = true;
treeGrid.EditTapAction = TreeGridTapAction.OnTap; // For double tap, use TreeGridTapAction.OnDoubleTap
{% endhighlight %}
{% endtabs %}

## Editor selection behavior

The [SfTreeGrid.EditorSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_EditorSelectionBehavior) property controls how the text is selected in the editor when a cell enters edit mode. The supported [TreeGridEditorSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridEditorSelectionBehavior.html) values are:

* `SelectAll` – Selects the entire text in the editor. This is the default value.
* `MoveLast` – Moves the cursor to the end of the text without selecting it.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="Children"
                       AllowEditing="True"
                       EditorSelectionBehavior="MoveLast" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.AllowEditing = true;
treeGrid.EditorSelectionBehavior = TreeGridEditorSelectionBehavior.MoveLast;
{% endhighlight %}
{% endtabs %}

## Lost focus behavior

The [SfTreeGrid.LostFocusBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_LostFocusBehavior) property decides what happens when the editor loses focus. The supported [TreeGridLostFocusBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridLostFocusBehavior.html) values are:

* `Default` – The edit mode is kept. The edit is ended by pressing `Enter` or `Escape`, or by changing the current cell. This is the default value.
* `EndEditCurrentCell` – The edit mode ends and the edited value is committed when the editor loses focus.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="Children"
                       AllowEditing="True"
                       LostFocusBehavior="EndEditCurrentCell" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.AllowEditing = true;
treeGrid.LostFocusBehavior = TreeGridLostFocusBehavior.EndEditCurrentCell;
{% endhighlight %}
{% endtabs %}

N> The `LostFocusBehavior` property is applied by `TreeGridTextColumn` and `TreeGridNumericColumn`. Other column types end the edit through the key actions, a current cell change, or the programmatic methods.

## Keyboard support

| Key | Action |
|---|---|
| `F2` | Enters edit mode on the current cell. |
| `Enter` | Commits the edit and moves to the next row. |
| `Escape` | Cancels the edit and restores the old value. |
| `Tab` / `Shift+Tab` | Moves to the next or previous cell. |

N> Keyboard actions require [SfTreeGrid.AllowKeyboardNavigation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) to be enabled and `SelectionMode` not to be `None`. While a `TreeGridComboBoxColumn` cell is being edited, `Enter` ends the edit and moves to the next column.

## Support for IEditableObject

When the underlying data object implements [IEditableObject](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ieditableobject), the TreeGrid calls its methods during editing:

* `BeginEdit` – Called when the item enters an edit transaction.
* `EndEdit` – Called when the edit is committed.
* `CancelEdit` – Called when the edit is canceled, so the item can restore its values.

{% tabs %}
{% highlight c# tabtitle="EmployeeInfo.cs" %}
using System.ComponentModel;

public class EmployeeInfo : INotifyPropertyChanged, IEditableObject
{
    private string? name;
    private string? backupName;

    public string? Name
    {
        get => name;
        set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name))); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void BeginEdit() => backupName = name;

    public void CancelEdit() => Name = backupName;

    public void EndEdit() => backupName = null;
}
{% endhighlight %}
{% endtabs %}

The [TreeGridView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridView.html) exposes the state of this transaction through `IsEditingItem`, `CurrentEditItem`, and `CanCancelEdit`. `CanCancelEdit` is `true` only when the item being edited implements `IEditableObject`.

## Editing events

### CurrentCellBeginEdit

The [SfTreeGrid.CurrentCellBeginEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CurrentCellBeginEdit) event occurs when the current cell enters edit mode. The [TreeGridCurrentCellBeginEditEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridCurrentCellBeginEditEventArgs.html) provides the following members:

* `Cancel` – When set to `true`, the current cell does not enter edit mode.
* `RowColumnIndex` – Gets the row and column index of the cell being edited.
* `Column` – Gets the `TreeGridColumn` of the cell being edited.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="Children"
                       AllowEditing="True"
                       CurrentCellBeginEdit="treeGrid_CurrentCellBeginEdit" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void treeGrid_CurrentCellBeginEdit(object? sender, TreeGridCurrentCellBeginEditEventArgs e)
{
    // Prevent editing of the EmployeeID column.
    if (e.Column != null && e.Column.MappingName == "EmployeeID")
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### CurrentCellEndEdit

The [SfTreeGrid.CurrentCellEndEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CurrentCellEndEdit) event occurs when the current cell exits edit mode. The [TreeGridCurrentCellEndEditEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridCurrentCellEndEditEventArgs.html) provides the following members:

* `Cancel` – When set to `true`, the edited value is not committed and the underlying data is rolled back to the old value.
* `RowColumnIndex` – Gets the row and column index of the cell.
* `OldValue` – Gets the value before editing.
* `NewValue` – Gets the edited value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Employees}"
                       ChildPropertyName="Children"
                       AllowEditing="True"
                       CurrentCellEndEdit="treeGrid_CurrentCellEndEdit" />
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void treeGrid_CurrentCellEndEdit(object? sender, TreeGridCurrentCellEndEditEventArgs e)
{
    // Discard empty values.
    if (e.NewValue == null || string.IsNullOrWhiteSpace(e.NewValue.ToString()))
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### CellValueChanged

The [SfTreeGrid.CellValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CellValueChanged) event occurs when the value of the current cell changes, either through the editor or through direct interaction such as a check box toggle. The [TreeGridCurrentCellValueChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridCurrentCellValueChangedEventArgs.html) provides `TreeGridColumn`, `RowColumnIndex`, `RowData`, `OldValue`, and `NewValue`.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.CellValueChanged += (sender, e) =>
{
    System.Diagnostics.Debug.WriteLine($"{e.TreeGridColumn?.MappingName}: {e.OldValue} -> {e.NewValue}");
};
{% endhighlight %}
{% endtabs %}

### CurrentCellDropDownSelectionChanged

The [SfTreeGrid.CurrentCellDropDownSelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CurrentCellDropDownSelectionChanged) event occurs when the selected item changes in the drop-down of a `TreeGridComboBoxColumn`. See [TreeGridComboBoxColumn](https://help.syncfusion.com/maui/treegrid/column-types#treegridcomboboxcolumn) for details.

## Programmatic editing

### Begin editing

Call the [SfTreeGrid.BeginEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_BeginEdit_System_Int32_System_Int32_) method with the row and column index to move the current cell and enter edit mode.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.TreeGridLoaded += (s, e) =>
{
    // Edit the cell at the 2nd row and 2nd column.
    treeGrid.BeginEdit(2, 2);
};
{% endhighlight %}
{% endtabs %}

N> `BeginEdit` has no effect when `AllowEditing` is `false`, when `NavigationMode` is `Row`, when a cell is already being edited, or when the row index is the header row (index 0 or less) or is not visible.

### End editing

The [SfTreeGrid.EndEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_EndEdit) method commits the edited value of the current cell and exits edit mode.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.EndEdit();
{% endhighlight %}
{% endtabs %}

### Cancel editing

The [SfTreeGrid.CancelEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_CancelEdit) method exits edit mode without committing the edited value; the underlying data is rolled back to the old value.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.CancelEdit();
{% endhighlight %}
{% endtabs %}

## Public API summary

| API | Type | Description |
|---|---|---|
| `SfTreeGrid.AllowEditing` | Property | Enables editing. Default `false`. |
| `TreeGridColumn.AllowEditing` | Property | Enables or disables editing for a column. Takes priority over the grid value. |
| `SfTreeGrid.EditTapAction` | Property | Gesture that begins editing (`TreeGridTapAction`). Default `OnDoubleTap`. |
| `SfTreeGrid.EditorSelectionBehavior` | Property | Text selection when editing begins (`TreeGridEditorSelectionBehavior`). Default `SelectAll`. |
| `SfTreeGrid.LostFocusBehavior` | Property | Behavior when the editor loses focus (`TreeGridLostFocusBehavior`). Default `Default`. |
| `SfTreeGrid.BeginEdit(int, int)` | Method | Begins editing the cell at the given row and column index. |
| `SfTreeGrid.EndEdit()` | Method | Commits and ends editing. |
| `SfTreeGrid.CancelEdit()` | Method | Cancels editing. |
| `SfTreeGrid.CurrentCellBeginEdit` | Event | Occurs before a cell enters edit mode (`TreeGridCurrentCellBeginEditEventArgs`). |
| `SfTreeGrid.CurrentCellEndEdit` | Event | Occurs when a cell exits edit mode (`TreeGridCurrentCellEndEditEventArgs`). |
| `SfTreeGrid.CellValueChanged` | Event | Occurs when a cell value changes (`TreeGridCurrentCellValueChangedEventArgs`). |
| `SfTreeGrid.CurrentCellDropDownSelectionChanged` | Event | Occurs when a combo box drop-down selection changes (`CurrentCellDropDownSelectionChangedEventArgs`). |
| `TreeGridTapAction` | Enum | `OnTap`, `OnDoubleTap`. |
| `TreeGridEditorSelectionBehavior` | Enum | `SelectAll`, `MoveLast`. |
| `TreeGridLostFocusBehavior` | Enum | `EndEditCurrentCell`, `Default`. |
| `TreeGridView.IsEditingItem`, `CurrentEditItem`, `CanCancelEdit` | Properties | State of the `IEditableObject` edit transaction. |

## TreeGrid-specific behavior

* The TreeGrid has no undo and redo support, so there is no `AllowUndoRedo` or `MaxUndoRedoActions`, unlike the DataGrid.
* Verification Required: editing of the expander column, editing of dynamic data objects, and editing combined with sorting, filtering, or searching.

## See also

* [Column Types](https://help.syncfusion.com/maui/treegrid/column-types)
* [Selection](https://help.syncfusion.com/maui/treegrid/selection)
* [Data Binding](https://help.syncfusion.com/maui/treegrid/data-binding)

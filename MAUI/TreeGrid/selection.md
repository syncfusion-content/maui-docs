---
layout: post
title: Selection in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to use selection features in Syncfusion® .NET MAUI Tree Grid including row, and multiple selection modes with customization options.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, maui gridview, grid in maui, .net maui treegrid, .net maui grid, .net grid maui
---

# Selection in .NET MAUI TreeGrid

The MAUI TreeGrid `SfTreeGrid` allows you to select one or more rows based on the `SelectionMode` property.

## Selection Modes

<table>
<tr>
<th>Modes</th>
<th>Description</th>
</tr>
<tr>
<td>None</td>
<td>Disables selection entirely. No rows can be selected. This is the default value.</td>
</tr>
<tr>
<td>Single</td>
<td>Allows selection of a single row. Previous selection is cleared when selecting a different row.</td>
</tr>
<tr>
<td>Multiple</td>
<td>Allows selection of more than one row. Selection is not cleared when selecting additional rows. Click an already selected row a second time to deselect it.</td>
</tr>
<tr>
<td>SingleDeselect</td>
<td>Allows selection of a single row only. Tap the row again to deselect it. Previous selection is cleared when selecting a different row.</td>
</tr>
</table>

{% tabs %}
{% highlight xaml %}
<treeGrid:SfTreeGrid x:Name="treeGrid"
                     ItemsSource="{Binding PersonDetails}"
                     ChildPropertyName="Children"
                     SelectionMode="Multiple">
</treeGrid:SfTreeGrid>
{% endhighlight %}

{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.SelectionMode = TreeGridSelectionMode.Multiple;
treeGrid.ChildPropertyName = "Children";
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

## Getting selected rows

The `SfTreeGrid` provides `SelectedIndex`, `SelectedRow`, and `SelectedRows` properties to get details of selected rows when the selection mode is Single, Multiple, and SingleDeselect.

`SfTreeGrid.SelectedIndex` : Provides the row index of `SfTreeGrid.SelectedRow`. Denotes the index of the first selected row in multiple selections.

`SfTreeGrid.SelectedRow` : Provides the underlying data object of the selected row. Denotes the underlying data object of the first selected row in multiple selections.

`SfTreeGrid.SelectedRows` : Provides all selected records when multiple selection is enabled.

## Programmatic Selection

### Process selection using properties

When the selection mode is set to a value other than None, you can programmatically select a row by setting the row index to the `SelectedIndex` property or by setting the underlying data object to the `SelectedRow` property.

When `SelectionMode` is set to Multiple, select more than one row by adding the underlying data objects to the `SelectedRows` collection.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Perform selection using the selected index
        this.treeGrid.SelectedIndex = 3;

        // Perform selection using the selected row
        this.treeGrid.SelectedRow = viewModel.PersonDetails[3];
    }
}
{% endhighlight %}
{% endtabs %}

### Multiple Selection

When the selection mode is multiple, programmatically select more than one row by adding the underlying data objects to the `SelectedRows` collection.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        treeGrid.SelectedRows.Add(viewModel.PersonDetails[2]);
        treeGrid.SelectedRows.Add(viewModel.PersonDetails[4]);
        treeGrid.SelectedRows.Add(viewModel.PersonDetails[6]);
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="MAUI Tree Grid Row Selection" src="Images/selection/maui_treegrid_rowselection.png" width="404"/>

### Select All Rows

Select all rows in the TreeGrid using the `SelectAll()` method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        treeGrid.TreeGridLoaded += TreeGrid_TreeGridLoaded;
    }

    private void TreeGrid_TreeGridLoaded(object? sender, EventArgs e)
    {
        treeGrid.SelectAll();
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="MAUI Tree Grid Select all" src="Images/selection/maui_treegrid_selectall.png" width="404"/>

## Clear Selection

The TreeGrid allows you to clear selection either by setting the `SelectionMode` to None or by calling the `ClearSelection()` method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Clear selection using selection mode
        treeGrid.SelectionMode = TreeGridSelectionMode.None;

        // Clear selection using method
        treeGrid.ClearSelection();
    }
}
{% endhighlight %}
{% endtabs %}

## Events in Selection

The TreeGrid provides the following events for selection:

### SelectionChanging

This event is raised before the selection is changed. It allows you to cancel the selection operation by setting the `Cancel` property of `TreeGridSelectionChangingEventArgs`.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        treeGrid.SelectionChanging += TreeGrid_SelectionChanging;
    }

    private void TreeGrid_SelectionChanging(object sender, TreeGridSelectionChangingEventArgs e)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### SelectionChanged

This event is raised after a row is selected.

The `TreeGridSelectionChangedEventArgs` contains the following properties:

- `AddedRows` : Gets the collection of rows added to the selection.
- `RemovedRows` : Gets the collection of rows removed from the selection.

To get the selected item in the `SelectionChanged` event:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        treeGrid.SelectionChanged += TreeGrid_SelectionChanged;
    }

    private void TreeGrid_SelectionChanged(object sender, TreeGridSelectionChangedEventArgs e)
    {
        if (e.AddedRows.Count > 0)
        {
            var selectedItem = e.AddedRows[0];
        }
    }
}
{% endhighlight %}
{% endtabs %}

## Customizing Selection Appearance

### Selected Row Styling

Change the selection background color and text color of selected rows using the `SelectionBackground` and `SelectedRowTextColor` properties.

{% tabs %}
{% highlight xaml %}
<treeGrid:SfTreeGrid ItemsSource="{Binding PersonDetails}"
                     SelectionMode="Multiple">
    <treeGrid:SfTreeGrid.DefaultStyle>
        <treeGrid:TreeGridStyle SelectionBackground="#E3F2FD"
                                SelectedRowTextColor="Black"/>
    </treeGrid:SfTreeGrid.DefaultStyle>
</treeGrid:SfTreeGrid>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
treeGrid.DefaultStyle.SelectionBackground = Color.FromArgb("#E3F2FD");
treeGrid.DefaultStyle.SelectedRowTextColor = Colors.Black;
{% endhighlight %}
{% endtabs %}

<img alt="MAUI Tree Grid Selected Row Styling" src="Images/selection/maui_treegrid_rowselection_style.png" width="404"/>

## Binding Selection Properties

The `SfTreeGrid` allows binding selection-related properties such as `SelectedIndex` and `SelectedRow` directly to properties in the ViewModel.

{% tabs %}
{% highlight xaml %}
<treeGrid:SfTreeGrid ItemsSource="{Binding PersonDetails}"
                     SelectedIndex="{Binding TreeGridSelectedIndex}"
                     SelectedRow="{Binding TreeGridSelectedRow}" />
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class ViewModel : INotifyPropertyChanged
{
    private int treeGridSelectedIndex;

    private object treeGridSelectedRow;

    public int TreeGridSelectedIndex
    {
        get => treeGridSelectedIndex;
        set
        {
            treeGridSelectedIndex = value;
            RaisePropertyChanged(nameof(TreeGridSelectedIndex));
        }
    }

    public object TreeGridSelectedRow
    {
        get => treeGridSelectedRow;
        set
        {
            treeGridSelectedRow = value;
            RaisePropertyChanged(nameof(TreeGridSelectedRow));
        }
    }

    public ViewModel()
    {
        TreeGridSelectedIndex = 2;
        TreeGridSelectedRow = PersonDetails[5];
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
{% endhighlight %}
{% endtabs %}
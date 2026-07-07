---
layout: post
title: Row Drag and Drop in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Row Drag and Drop support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui row drag and drop, maui row drag and drop
---

# Row Drag and Drop in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) control allows you to drag and drop rows by setting the [SfDataGrid.AllowDraggingRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDraggingRow) property to `true`. Dragging is enabled by long pressing and dragging a row on mobile platforms and by clicking and dragging on desktop platforms. A row drag view is displayed during the drag operation. You can handle drag-and-drop operations based on your requirements by using the [SfDataGrid.QueryRowDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowDragging) event.

To quickly get started with row drag and drop in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid), watch this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/qwkDwCgo_jo'></iframe>

To enable row drag and drop functionality, refer to the code example below:

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"  
                       AllowDraggingRow="True">
 </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowDraggingRow = true;
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid row drag and drop" src="Images\rowdragdrop\maui-datagrid-dragging.gif" width="404"/>

## Dragging scenarios

The SfDataGrid supports drag-and-drop operations for both data rows and groups in the following scenarios:

* **Records reordering with auto-scrolling**: Rows can be reordered to any position in the grid. Auto-scrolling is enabled by default, allowing continuous scrolling when dragging near grid boundaries.
* **Group reordering**: Group headers can be reordered using drag and drop. Note that groups cannot be nested within other groups.
* **Cross-group row movement**: Data rows can be reordered within the same group or moved to different groups by dragging.

**Note:** Reordering changes are made only in the [SfDataGrid.View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_View), not in the underlying data. As a result, these changes will be reverted when performing sorting, grouping, or any other operation that refreshes the view. To persist reordering changes in the underlying data, handle the [QueryRowDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowDragging) event as explained below in [Reordering underlying data](#Reordering underlying data).

## Row drag-and-drop template

The [SfDataGrid.RowDragDropTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowDragDropTemplate) allows you to load specific content during row drag-and-drop operations. This template can be defined in XAML or code-behind.

### Default template

The default template will be used for row drag-and-drop operations unless another template is explicitly assigned.

<img alt="DataGrid row drag and drop" src="Images\rowdragdrop\maui-datagrid-dragging.gif" width="404"/>

### Customizing row drag-and-drop template

Any type of custom view can be loaded inside the [SfDataGrid.RowDragDropTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowDragDropTemplate).

Refer to the following code example that demonstrates how to load a custom view in a template:

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid>
    <syncfusion:SfDataGrid.RowDragDropTemplate>
        <DataTemplate>
            <Grid BackgroundColor="LightBlue">
                <Label Text="Drag View"       
                       TextColor="Black"           
                       HorizontalTextAlignment="Center" 
                    VerticalTextAlignment="Center"/>
            </Grid>
        </DataTemplate>
    </syncfusion:SfDataGrid.RowDragDropTemplate>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% endtabs %}

<img alt="Default drag and drop" src="Images\rowdragdrop\maui-datagrid-labeltemp.gif" Width="404" />

## Events in row drag-and-drop

The [SfDataGrid.QueryRowDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowDragging) event is triggered when a row begins to be dragged and fires continuously as the row is dragged (typically on each pointer movement). By handling this event, you can customize behavior and cancel dragging operations.

The `QueryRowDragging` event provides the following properties through the [DataGridQueryRowDraggingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html):

* [From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowDraggingEventArgs_From): Returns the index of the row that is currently being dragged.
* [To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowDraggingEventArgs_To): Returns the index of the row where you are attempting to drop the dragged item.
* [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowDraggingEventArgs_Position): Returns the current x and y coordinates of the RowDragView.
* [DraggingAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowDraggingEventArgs_DraggingAction): Returns the current drag state as [DataGridDragAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDragAction.html).
* [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowDraggingEventArgs_RowData): Returns the underlying data object associated with the dragged row.
* [CurrentRowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowDraggingEventArgs_CurrentRowData): Returns the data object corresponding to the current drop position of the `RowDragView`.
* [CanAutoScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowDraggingEventArgs_CanAutoScroll): Gets or sets a value indicating whether auto-scrolling should occur when the `RowDragView` reaches the top or bottom of the `SfDataGrid`.
* `Cancel`: Gets or sets a Boolean value indicating whether the event should be canceled.


## Cancel dragging of a particular row

Dragging a specific row can be canceled by using the `DataGridDragAction` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    //e.From returns the index of the dragged row.
    //e.DataGridDragAction returns the dragging status of the row.
    if (e.From == 1 && e.DraggingAction == DataGridDragAction.DragStarted)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping when dragging over particular rows

The action of dropping while dragging over specific rows can be canceled using the `DataGridDragAction` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    if ((e.To > 5 || e.To < 10) && (e.DraggingAction == DataGridDragAction.DragEnded || e.DraggingAction == DataGridDragAction.Dragging))
    e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping of a particular row

The dropping of a specific row can be canceled using the `DataGridDragAction` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    if (e.From == 1 && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping at a particular position

Dropping at a specific position can be canceled by using the `DataGridDragAction` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    if ((e.To == 5 || e.To == 7) && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping of a particular row in a position

The dropping of a particular row at a position can be canceled using the `DataGridDragAction` and `Position` arguments in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

 private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
 {
     if ((e.To == 3) && e.Position == new Point(927, 1167) && e.DraggingAction == DataGridDragAction.DragEnded)
         e.Cancel = true;
 }

{% endhighlight %}
{% endtabs %}   

## Cancel drag and drop between frozen and non-frozen rows

### Cancel dragging between frozen and non-frozen rows

To prevent rows from being dragged out of the frozen row area, check whether the dragged row is a frozen row using the `From` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

dataGrid.FrozenRowCount = 4;

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    // Cancel if dragging from a frozen row (index > header + frozen row count boundary)
    if (e.From > dataGrid.GetHeaderIndex() && e.From <= dataGrid.FrozenRowCount && e.DraggingAction == DataGridDragAction.DragStarted)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

### Cancel dropping between frozen and non-frozen rows

To prevent rows from being dropped into frozen row areas from non-frozen areas, check the drop target using the `From` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

dataGrid.FrozenRowCount = 4;

dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private async void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    // Cancel if dropping into frozen rows area
    if (e.From > dataGrid.GetHeaderIndex() && e.From <= dataGrid.FrozenRowCount && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

**Note**: The `FrozenRowCount` value must be less than the total number of rows in the grid view.

## Reorder the underlying data

Reordering changes made directly to the underlying data can be done using the `DataGridDragAction` argument in the `QueryRowDragging` event handler. Please refer to the following code sample to implement permanent reordering changes:

{% tabs %}
{% highlight c# %}

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction == DataGridDragAction.DragEnded)
    {
        var collection = (sender as SfDataGrid).ItemsSource as IList;
        if (collection != null)
        {
            collection.RemoveAt(e.From - 1);
            collection.Insert(e.To - 1, e.RowData);
            // Cancel the default operation to prevent duplicate reordering
            e.Cancel = true;
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Drop a grid row in the last position

The `To` property of the `DataGridQueryRowDraggingEventArgs` indicates the current drop index of the dragged row when it is being dragged over the grid rows. It returns the same index when dragging a row over the last position or the second-to-last position. To programmatically determine whether the dragged row is dropped in the last position or the second-to-last position, use the `Position` property in `DataGridQueryRowDraggingEventArgs`, which indicates the current screen coordinates of the RowDragView.

Refer to the following code example in which the `Position` property is used to determine whether the row is dropped in the last position:

{% tabs %}
{% highlight c# %}

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    var totalHeight = dataGrid.RowColumnIndexToPoint(new RowColumnIndex(viewModel.Orders.Count, 0)).Y + this.dataGrid.RowHeight;
    if (e.DraggingAction == DataGridDragAction.DragEnded)
    {
        if (Math.Ceiling(e.Position.Y + (dataGrid.RowHeight / 2)) > totalHeight && e.To == viewModel.Orders.Count)
        {
            //Will hit if the row is dropped at the last position                 
            DisplayAlert("RowDragAndDrop info", "The row is dropped at the last position", "OK");
        }
    }
}

{% endhighlight %}
{% endtabs %}


## Updating summaries when dragging and dropping a row between groups

Grouping and summarization of items in the data grid are determined by the group key. When an item is dragged from one group to another, the group key of the dragged item will differ from the group key of the items in the dropped group. Therefore, by default, the summaries will not be updated. This reflects the actual behavior of this control.

Therefore, to update the summaries when a row is dragged and dropped between groups, call the `UpdateCaptionSummaries` and `Refresh` methods in the `QueryRowDragging` event.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    private SfDataGrid dataGrid;
    private ViewModel viewModel;
    public MainPage()
    {
         InitializeComponent();
         dataGrid = new SfDataGrid();
         viewModel = new OrderRepo();
         dataGrid.ItemsSource = viewModel.Orders;
         dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;
         this.Content = dataGrid;
    }
   private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
    {
         if (e.DraggingAction == DataGridDragAction.DragEnded)
         {
             // Delay allows the view to process the drag operation before refresh
             await Task.Delay(100);                
             this.dataGrid.View.TopLevelGroup.UpdateCaptionSummaries();
             this.dataGrid.View.Refresh();
         }
    }
}
{% endhighlight %}
{% endtabs %}


## Disable auto scrolling 

By default, the grid automatically scrolls when the drag view reaches the top or bottom boundaries during row drag operations. To disable this behavior, set the `CanAutoScroll` property to `false` in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
   // Disable automatic scrolling during drag operations
   e.CanAutoScroll = false;
}

{% endhighlight %}
{% endtabs %}


## Customization of row drag view

The row drag view’s background color, text color, and indicator color can be customized using the [RowDragViewBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_RowDragViewBackgroundColor), [RowDragViewTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_RowDragViewTextColor), and [RowDraggingIndicatorLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_RowDraggingIndicatorLineColor) properties.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"  
                       AllowDraggingRow="True">

    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle RowDraggingIndicatorLineColor="Blue"
                                  RowDragViewBackgroundColor="LightCyan"
                                  RowDragViewTextColor="Maroon"/>
    </syncfusion:SfDataGrid.DefaultStyle>
 </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}

dataGrid.DefaultStyle.RowDraggingIndicatorLineColor = Colors.Blue;
dataGrid.DefaultStyle.RowDragViewBackgroundColor = Colors.LightCyan;
dataGrid.DefaultStyle.RowDragViewTextColor = Colors.Maroon;

{% endhighlight %}
{% endtabs %}

<img alt="Customization of row drag view" src="Images\rowdragdrop\maui-datagrid-dragindicator.gif" width="400"/>

## Multi-Row Drag and Drop

The `SfDataGrid` control supports dragging and dropping multiple rows simultaneously. This functionality can be enabled by setting [SfDataGrid.AllowDraggingRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDraggingRow) to `true`, [SfDataGrid.SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionMode.html) to `Multiple`, and [SfDataGrid.SelectionUnit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionUnit.html) to `Row` (the default value of SelectionUnit is Row).

Once enabled, users can select the required rows and perform drag-and-drop operations in the same manner as standard row drag and drop.

The multi-row drag-and-drop operation preserves the selection order. Upon dropping, the rows are arranged according to the order in which they were selected. During the drag operation, the number of selected rows is indicated through a badge view on the drag indicator.

**Note:** The badge view is not displayed when a custom view is defined using the [SfDataGrid.RowDragDropTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html?tabs=tabid-1#Syncfusion_Maui_DataGrid_SfDataGrid_RowDragDropTemplate).

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowDraggingRow="True"
                       SelectionMode="Multiple"
                       SelectionUnit="Row">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AllowDraggingRow = true;
dataGrid.SelectionMode = DataGridSelectionMode.Multiple;
dataGrid.SelectionUnit = DataGridSelectionUnit.Row;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="DataGrid multi row drag and drop" src="Images\rowdragdrop\maui-datagrid-multi-dragging.gif" width="404">

---
layout: post
title: Row Drag and Drop in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Row Drag and Drop support in Syncfusion MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui row drag and drop, maui row drag and drop
---

# Row Drag and Drop in MAUI DataGrid (SfDataGrid)

The `SfDataGrid` control allows you to drag and drop rows by setting the `SfDataGrid.AllowDraggingRow` property to `true`. Dragging is enabled by long pressing and dragging a row on mobile platforms and by clicking and dragging on desktop platforms. A row drag view is displayed during the drag operation. You can handle drag-and-drop operations based on your requirements by using the `SfDataGrid.QueryRowDragging` event.

To enable row drag and drop functionality, please follow the code example below:

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

* Records can be reordered to any position using auto-scrolling.
* Group positions can be reordered using drag and drop; however, groups cannot be nested within other groups.
* Data rows can be reordered within the same group or moved to different groups.

N> Reordering changes are made only in the `SfDataGrid.View`, not in the underlying data. As a result, these changes will be reverted when performing sorting, grouping, or any other operation that refreshes the view. To persist reordering changes in the underlying data, handle the `QueryRowDragging` event as explained below in [Reordering underlying data](#Reordering underlying data).

## Row drag-and-drop template

The SfDataGrid allows you to load specific content during row drag-and-drop operations using the `SfDataGrid.RowDragDropTemplate`. This template can be defined either in code or XAML.

### Default template

The default template will be used for row drag-and-drop operations unless another template is explicitly assigned.

<img alt="DataGrid row drag and drop" src="Images\rowdragdrop\maui-datagrid-dragging.gif" width="404"/>

### Customizing row drag-and-drop template

Any type of custom view can be loaded inside the `SfDataGrid.RowDragDropTemplate`.

Please refer to the following code example that demonstrates how to load a view in a template:

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

The `QueryRowDragging` event is triggered when a row begins to be dragged and continues to fire until the dragging ends. By handling the `SfDataGrid.QueryRowDragging` event, you can also cancel the dragging of a specific row.

The `QueryRowDragging` event provides the following properties through the `QueryRowDraggingEventArgs`:

* `From`: Returns the index of the row that is currently being dragged.
* `To`: Returns the index of the row where you are attempting to drop the dragged item.
* `Position`: Returns the current x and y coordinates of the RowDragView.
* `DraggingAction`: Returns details of the row dragging as a `DataGridDragAction`.
* `RowData`: Returns the underlying data associated with the dragged row.
* `CurrentRowData`: Returns the data corresponding to the current position of the `RowDragView`.
* `CanAutoScroll`: Returns a value indicating whether auto-scrolling should occur when the `RowDragView` reaches the top or bottom of the `SfDataGrid`.
* `Cancel`: Returns a Boolean value that indicates whether the event should be canceled.


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

Dragging between frozen and non-frozen rows can be canceled using the `DataGridDragAction` and `From` arguments of the `QueryRowDragging` event handler by checking whether the value of the `From` argument is an index of a frozen row.

{% tabs %}
{% highlight c# %}

dataGrid.FrozenRowCount = 4;

this.dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

 private void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
 {
     if (e.From > dataGrid.GetHeaderIndex() && e.From <= dataGrid.FrozenRowCount && e.DraggingAction == DataGridDragAction.DragStarted)
         e.Cancel = true;
 }

{% endhighlight %}
{% endtabs %}

### Cancel dropping between frozen and non-frozen rows

Dropping between frozen and non-frozen rows can be canceled using the `DataGridDragAction` and `From` arguments of the `QueryRowDragging` event handler by checking whether the value of the `From` argument is an index of a frozen row.

{% tabs %}
{% highlight c# %}

dataGrid.FrozenRowCount = 4;

dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private async void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
    if (e.From > dataGrid.GetHeaderIndex() && e.From <= dataGrid.FrozenRowCount && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

N> FrozenRowCount must be less than rows in view.

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
        collection.RemoveAt(e.From - 1);
        collection.Insert(e.To - 1, e.RowData);
        //To skip default collection change inside the SfDataGrid source for a successful drag and drop operation.
        e.Cancel = true;
    }
}

{% endhighlight %}
{% endtabs %}

## Drop a grid row in the last position

The `To` property of the `DataGridQueryRowDraggingEventArgs` indicates the current drop index of the dragged row when it is being dragged over the grid rows. It returns the same index when dragging a row over the last position or the second-to-last position. To programmatically track whether the dragged row is dropped in the last position or the second-to-last position, the data grid provides the `Position` property in `DataGridQueryRowDraggingEventArgs`, which indicates the position of the RowDragView.

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
{% highlight c#%}
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
             // Delay is given for refreshing the view.
             await Task.Delay(100);                
             this.dataGrid.View.TopLevelGroup.UpdateCaptionSummaries();
             this.dataGrid.View.Refresh();
         }
    }
}
{% endhighlight %}
{% endtabs %}


## Cancel auto scrolling 

The vertical auto-scrolling of the `SfDataGrid` during row drag-and-drop can be canceled using the `CanAutoScroll` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;

private async void DataGrid_QueryRowDragging(object? sender, Syncfusion.Maui.DataGrid.DataGridQueryRowDraggingEventArgs e)
{
   e.CanAutoScroll = true;
}

{% endhighlight %}
{% endtabs %}


## Customization of row drag view

The row drag view’s background color, text color, and indicator color can be customized using the `RowDragViewBackgroundColor`, `RowDragViewTextColor`, and `RowDraggingIndicatorLineColor` properties.

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

<img alt="Customization of row drag view" src="Images\rowdragdrop\maui-datagrid-draggingindicator.gif" width="400"/>
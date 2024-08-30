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

The SfDataGrid allows you to drag and drop a row by setting the `SfDataGrid.AllowDraggingRow` property to `true`. A customizable row drag and drop template is displayed while a row is being dragged.  Based on the requirements, drag and drop operations can be handled by using the `SfDataGrid.QueryRowDragging` event. 

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

<img alt="DataGrid row drag and drop" src="Images\row-drag-and-drop\RowDragAndDrop.gif"/>

## Dragging scenarios

The SfDataGrid supports drag and drop operations for both data rows and groups in the following scenarios:

 * Records can be reordered to any position using auto-scrolling.
 * Group positions can be reordered using drag and drop. However, no groups can be added within other groups.
 * Data rows can be reordered within the same group or moved to other groups as well.

N> Reordering changes are made only in the `SfDataGrid.View`, and not in the underlying data. Thus, the changes will be reverted when performing sorting, grouping, or any other operation refreshing the view. Reordering changes in the underlying data can be achieved by handling a `QueryRowDragging` event in the sample side as explained below in [Reordering underlying data](# Reordering underlying data ).

N> Now you can drag and drop the grid rows using your mouse in the UWP (Desktop) platform.

## Row drag-and-drop template

The data grid allows you to load desired content when performing row drag-and-drop operations using the `SfDataGrid.RowDragDropTemplate`. The template can be defined either in code or XAML.  

## Default template

The default template will be used if no other template is explicitly assigned for row drag-and-drop operations.

<img alt="Default drag and drop" src="Images\row-drag-and-drop\DefaultDragAndDrop.gif" />

## Customizing row drag-and-drop template

Any type of custom view can be loaded inside the `SfDataGrid.RowDragDropTemplate`.

Please refer to the following code example that demonstrates how to load a view in a template:

{% tabs %}
{% highlight xaml %}
<sfgrid:SfDataGrid.RowDragDropTemplate>
    <DataTemplate>
        <sfgrid:BorderView BackgroundColor="White" BorderColor="Black">
            <sfgrid:BorderView.Content>
                <local:RowTemplate />
            </sfgrid:BorderView.Content>
        </sfgrid:BorderView>
    </DataTemplate>
</sfgrid:SfDataGrid.RowDragDropTemplate>
{% endhighlight %}
{% endtabs %}



N> Currently, the row drag-and-drop features cannot be used if different row sets with varying heights are specified using the `QueryRowHeight` event.



## Events in row drag-and-drop

The `QueryRowDragging` event is triggered when a row begins to be dragged and continues to be triggered until the dragging ends. By handling the `SfDataGrid.QueryRowDragging` event, you can also cancel the dragging of a specific row.

The `QueryRowDragging` event provides the following properties in the `QueryRowDraggingEventArgs`:

 * `From`: Returns the index of the row that is currently being dragged.
 * `To`: Returns the index of the row where you attempt to drop the dragged item.
 * `Position`: Returns the current x and y coordinates of the RowDragView.
 * `DraggingAction`: Returns the details of row dragging as `DataGridDragAction`.
 * `RowData`: Returns the underlying data associated with the row that was dragged.
 * `CurrentRowData`: Returns the row data corresponding to the current position of the row drag view.
 * `CanAutoScroll`: Returns whether auto-scrolling should occur when the row drag view reaches the top or bottom of the `SfDataGrid`.
 * `Cancel`: Returns a Boolean value that indicates whether to cancel the event.

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


## RowDragAndDrop Style
### RowDraggingIndicatorLineColor

The `RowDraggingIndicatorLineColor` property in the `SfDataGrid` is used to customize the color of the line that appears during a drag-and-drop operation when you move rows within the dataGrid. This line serves as a visual indicator, showing where the row will be dropped if the user releases the drag at that point.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"  
                       AllowDraggingRow="True">

    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle RowDraggingIndicatorLineColor="Blue"/>
    </syncfusion:SfDataGrid.DefaultStyle>
 </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}

dataGrid.DefaultStyle.RowDraggingIndicatorLineColor = Colors.Blue;

{% endhighlight %}
{% endtabs %}

### RowDragViewBackgroundColor
The `RowDragViewBackgroundColor` property in the `SfDataGrid` control is used to set the background color of the row that is being dragged during a drag-and-drop operation. 

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"  
                       AllowDraggingRow="True">

     <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle RowDragViewBackgroundColor="Blue"/>
    </syncfusion:SfDataGrid.DefaultStyle>
 </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}

dataGrid.DefaultStyle.RowDragViewBackgroundColor = Colors.Blue;

{% endhighlight %}
{% endtabs %}

### RowDragViewTextColor
The `RowDragViewTextColor` property in the `SfDataGrid` is used to set the text color of the row that is being dragged during a drag-and-drop operation. This property allows you to customize the color of the text that appears on the drag view.

{% tabs %}
{% highlight XAML %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"  
                       AllowDraggingRow="True">

    <syncfusion:SfDataGrid.DefaultStyle>
        <syncfusion:DataGridStyle RowDragViewTextColor="Blue"/>
    </syncfusion:SfDataGrid.DefaultStyle>
 </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}

dataGrid.DefaultStyle.RowDragViewTextColor = Colors.Blue;

{% endhighlight %}
{% endtabs %}



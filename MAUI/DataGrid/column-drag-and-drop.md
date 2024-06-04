---
layout: post
title: Column Drag and Drop in .NET MAUI DataGrid control | Syncfusion
description: Learn all about column drag and drop support in Syncfusion MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Column Drag and Drop in MAUI DataGrid (SfDataGrid)

The SfDataGrid allows dragging and dropping a column header by setting the `SfDataGrid.AllowDraggingColumn` property to `true.` The drag view is displayed while dragging a column header. Based on the requirements, drag and drop operations can be handled by using the `SfDataGrid.QueryColumnDragging` event.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AllowDraggingColumn="True">
    </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
 dataGrid.AllowDraggingColumn = true;
{% endhighlight %}
{% endtabs %}

## Column drag and drop events

The `QueryColumnDragging` event is fired continuously while dragging a column and ends when the dragging ends. By handling the `SfDataGrid.QueryColumnDragging` event, the dragging of a particular column header can be canceled.

The `QueryColumnDragging` event provides the following properties in the `DataGridQueryColumnDraggingEventArgs`:

- `From`: Returns the index of the currently dragging column.
- `To`: Returns the index where you are trying to drop the column.
- `DraggingAction`: Returns the column dragging details as a `DataGridDragAction`.
- `DraggingPosition`: Returns the position of the drag view during column drag and drop operations.
- `CanAutoScroll`: Returns whether auto-scrolling should happen when the column drag view reaches the left or right ends of the `SfDataGrid`.
- `Cancel`: Returns a boolean property to cancel the event.

## Cancel dragging of a particular column

Dragging of a particular column can be canceled using `DataGridDragAction` argument of the `QueryColumnDragging` event handler.

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    //e.From returns the index of the dragged column.
    //e.DraggingAction returns the dragging status of the column.
    if (e.From == 1 && e.DraggingAction == DataGridDragAction.DragStarted) 
    {
        e.Cancel = true;
    }
} 
{% endhighlight %}

## Cancel dropping when dragging for a particular column

Dropping when dragging a particular column can be canceled using the `DataGridDragAction` argument of the `QueryColumnDragging` event handler.

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    //e.To returns the index of the current column.
    //e.DraggingAction returns the dragging status of the column.
    if ((e.To > 3 && e.To < 6) &&
    (e.DraggingAction == DataGridDragAction.DragEnded || e.DraggingAction == DataGridDragAction.Dragging))
    {
        e.Cancel = true;
    }
}
{% endhighlight %}

## Cancel dropping for a particular column

The dropping of a particular column can be canceled using the `DataGridDragAction` argument of the `QueryColumnDragging` event handler.

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    //e.From returns the index of the dragged column.
    //e.DraggingAction returns the dragging status of the column.
    if (e.From == 1 && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}
{% endhighlight %}

## Cancel dropping at a particular position

Dropping at a particular position can be canceled using the `DataGridDragAction` argument of the `QueryColumnDragging` event handler.

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    //e.From returns the index of the dragged column.
    //e.DraggingAction returns the dragging status of the column.
    if ((e.To == 3 || e.To == 5) && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}
{% endhighlight %}

## Cancel dropping of a particular column in a position

Dropping of a particular column in a position can be canceled using the `DataGridDragAction` and `DraggingPosition` arguments of the `QueryColumnDragging` event handler.

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    //e.From returns the index of the dragged column.
    //e.DraggingPosition returns the x and y position of the current column
    if (e.DraggingPosition == new Point(100, 100) && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}
{% endhighlight %}

## Cancel drag and drop between frozen and non-frozen columns

### Cancel dragging between frozen and non-frozen columns

Dragging between frozen and non-frozen columns can be canceled using the `DataGridDragAction` and `From` arguments of the `QueryColumnDragging` event handler, by checking whether the value of the `From` argument is a frozen column index.

{% highlight c# %}
dataGrid.FrozenColumnCount = 2;

dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    //e.From returns the index of the dragged column.
    //e.To returns the index of the current column.
    if (e.From < 2 && e.DraggingAction == DataGridDragAction.DragStarted)
        e.Cancel = true;
}
{% endhighlight %}

### Cancel dropping between frozen and non-frozen columns

Dropping between frozen and non-frozen columns can be canceled using the `DataGridDragAction` and `From` arguments of the `QueryColumnDragging` event handler by checking whether the `e.From` value is a frozen column index.

{% highlight c# %}
dataGrid.FrozenColumnCount = 2;

dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    //e.From returns the index of the dragged column.
    //e.To returns the index of the current column.
    if (e.From < 2 && e.DraggingAction == DataGridDragAction.DragEnded)
        e.Cancel = true;
}
{% endhighlight %}

## Customize the appearance

### Customize column drag and drop indicator color

The SfDataGrid allows customizing the column drag and drop indicators using the `SfDataGrid.DefaultStyle.ColumnDraggingIndicatorLineColor` property.

{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AllowDraggingColumn="True">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle ColumnDraggingIndicatorLineColor="DeepPink"/>
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
{% endhighlight %}

### Customize drag view text color

The SfDataGrid allows customizing the drag view text color using the `SfDataGrid.DefaultStyle.ColumnDragViewTextColor` property.

{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AllowDraggingColumn="True">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle ColumnDragViewTextColor="Red"/>
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
{% endhighlight %}

### Customize drag view background color

The SfDataGrid allows customizing the drag view background color using the `SfDataGrid.DefaultStyle.ColumnDragViewBackgroundColor` property.

{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AllowDraggingColumn="True">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle ColumnDragViewBackgroundColor="GreenYellow"/>
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
{% endhighlight %}

## Cancel auto scrolling

Horizontal auto-scrolling of the SfDataGrid during column drag and drop can be canceled using the `CanAutoScroll` argument of the `QueryColumnDragging` event handler.

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    // Disable scroll while dragging the columns.   
    e.CanAutoScroll = false;
}
{% endhighlight %}

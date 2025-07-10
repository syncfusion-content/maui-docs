---
layout: post
title: Column Drag and Drop in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about column drag and drop support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui column drag and drop, maui column drag and drop
---

# Column Drag and Drop in MAUI DataGrid (SfDataGrid)

The SfDataGrid allows you to drag and drop a column header by setting the [SfDataGrid.AllowDraggingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDraggingColumn) property to `true.` A drag view is displayed while dragging a column header. You can handle drag and drop operations based on your requirements by using the [SfDataGrid.QueryColumnDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryColumnDragging) event.

To quickly get started with column drag and drop in .NET MAUI DataGrid, watch this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/qwkDwCgo_jo'></iframe>

To enable column drag and drop functionality, please follow the code example below:

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

<img alt="DataGrid column drag and drop" src="Images\column-drag-and-drop\maui-datagrid-column-drag-and-drop.gif" width="404"/>

## Column drag and drop events

The `QueryColumnDragging` event is fired continuously while dragging and dropping a column. By handling this event, you can cancel the dragging of a particular column header.

The `QueryColumnDragging` event provides the following properties in the [DataGridQueryColumnDraggingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html):

- [From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_From): Returns the index of the currently dragging column.
- [To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_To): Returns the index where you are trying to drop the column.
- [DraggingAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_DraggingAction): Returns the column dragging details as a `DataGridDragAction`.
- [DraggingPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_DraggingPosition): Returns the position of the drag view during column drag and drop operations.
- [CanAutoScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_CanAutoScroll): Returns whether auto-scrolling should happen when the column drag view reaches the left or right ends of the `SfDataGrid`.
- `Cancel`: Returns a boolean property to cancel the event.

## Cancel dragging of a particular column

The dragging of a particular column can be canceled using the `DataGridDragAction` argument in the `QueryColumnDragging` event.

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

The dropping of a particular column when dragging can be canceled using the `DataGridDragAction` argument in the `QueryColumnDragging` event.

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

The dropping of a particular column can be canceled using the `DataGridDragAction` argument in the `QueryColumnDragging` event.

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

The dropping at a particular position can be canceled using the `DataGridDragAction` argument in the `QueryColumnDragging` event.

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

The dropping of a particular column in a position can be canceled using the `DataGridDragAction` and `DraggingPosition` arguments of the `QueryColumnDragging` event.

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

The dragging between frozen and non-frozen columns can be canceled using the `DataGridDragAction` and `From` arguments of the `QueryColumnDragging` event, by checking whether the value of the `From` argument is a frozen column index.

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

The dropping between frozen and non-frozen columns can be canceled using the `DataGridDragAction` and `From` arguments of the `QueryColumnDragging` event by checking whether the `DataGridQueryColumnDraggingEventArgs.From` value is a frozen column index.

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

The SfDataGrid allows customizing the column drag and drop indicators using the [SfDataGrid.DefaultStyle.ColumnDraggingIndicatorLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ColumnDraggingIndicatorLineColor) property.

{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AllowDraggingColumn="True">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle ColumnDraggingIndicatorLineColor="DeepPink"/>
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
{% endhighlight %}

<img alt="DataGrid column drag indicator color" src="Images\column-drag-and-drop\maui-datagrid-column-drag-indicator-color.png" width="450"/>

### Customize drag view text and background color

The SfDataGrid allows customizing the drag view text and background color using the [SfDataGrid.DefaultStyle.ColumnDragViewTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ColumnDragViewTextColor) and [SfDataGrid.DefaultStyle.ColumnDragViewBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ColumnDragViewBackgroundColor) properties, respectively.

{% highlight xaml %}
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           AllowDraggingColumn="True">
        <syncfusion:SfDataGrid.DefaultStyle>
            <syncfusion:DataGridStyle ColumnDragViewTextColor="#FFFFFF"
                              ColumnDragViewBackgroundColor="#FFBF69"/>
        </syncfusion:SfDataGrid.DefaultStyle>
    </syncfusion:SfDataGrid>
{% endhighlight %}

<img alt="DataGrid column drag view background and text color" src="Images\column-drag-and-drop\maui-datagrid-drag-view-background-and-text-color.png" width="450"/>

### Column drag-and-drop template

The SfDataGrid allows you to load specific content into the column drag-and-drop template using the [SfDataGrid.ColumnDragDropTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnDragDropTemplate). The content can be provided through either a [DataTemplate](https://learn.microsoft.com/en-us/dotnet/api/system.windows.datatemplate?view=windowsdesktop-9.0) or a [DataTemplateSelector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datatemplateselector?view=windowsdesktop-9.0).

The following code snippet demonstrates how to load a data template into the column drag-and-drop view:

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid>
    <syncfusion:SfDataGrid.ColumnDragDropTemplate>
        <DataTemplate>
            <Grid BackgroundColor="LightBlue">
                <Label  Text="Drag View"
                        TextColor="Orange"
                        HorizontalTextAlignment="Center"
                        VerticalTextAlignment="Center" />
            </Grid>
        </DataTemplate>
    </syncfusion:SfDataGrid.ColumnDragDropTemplate>
</syncfusion:SfDataGrid>

{% endhighlight %}
{% endtabs %}

<img alt="Column drag and drop template" src="Images\column-drag-and-drop\maui-datagrid-column-drag-and-drop-template.gif" Width="404" />

## Cancel auto scrolling

Auto-scrolling during column dragging can be disabled using the `CanAutoScroll` argument in the `QueryColumnDragging` event.

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    // Disable scroll while dragging the columns.   
    e.CanAutoScroll = false;
}
{% endhighlight %}

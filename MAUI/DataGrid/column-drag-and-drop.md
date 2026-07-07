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

To quickly get started with column drag and drop in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid), watch this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/qwkDwCgo_jo'></iframe>

To enable column drag and drop functionality, use the following code example:

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
- [DraggingAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_DraggingAction): Returns the column dragging status as a [DataGridDragAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDragAction.html) enum value. Possible values are `DragStarted`, `Dragging`, and `DragEnded`.
- [DraggingPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_DraggingPosition): Returns the position (as a `Point`) of the drag view relative to the SfDataGrid during column drag and drop operations.
- [CanAutoScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_CanAutoScroll): Returns whether auto-scrolling should happen when the column drag view reaches the left or right ends of the `SfDataGrid`.
- `Cancel`: Set to `true` to cancel the current drag or drop action. When set during `DragStarted`, it prevents the column from being dragged. When set during `Dragging` or `DragEnded`, it prevents the column from being dropped at the target position.

## Control drag and drop behavior

Use the `QueryColumnDragging` event to restrict or modify column drag and drop operations. The following table shows common scenarios and how to implement them:

| Scenario | Condition | Code Example |
|----------|-----------|--------------|
| **Prevent dragging a specific column** | Check `DragStarted` action and column index | `if (e.From == 1 && e.DraggingAction == DataGridDragAction.DragStarted) e.Cancel = true;` |
| **Prevent dropping in a specific range** | Check `Dragging` or `DragEnded` and target index | `if ((e.To > 3 && e.To < 6) && (e.DraggingAction == DataGridDragAction.DragEnded)) e.Cancel = true;` |
| **Prevent dropping of a specific column** | Check `DragEnded` action and source column | `if (e.From == 1 && e.DraggingAction == DataGridDragAction.DragEnded) e.Cancel = true;` |
| **Prevent dropping at specific positions** | Check target index | `if ((e.To == 3 \|\| e.To == 5) && e.DraggingAction == DataGridDragAction.DragEnded) e.Cancel = true;` |
| **Prevent dropping at specific coordinates** | Check `DraggingPosition` | `if (e.DraggingPosition == new Point(100, 100) && e.DraggingAction == DataGridDragAction.DragEnded) e.Cancel = true;` |

The following code example demonstrates implementing drag and drop restrictions:

{% highlight c# %}
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    // Prevent dragging the column at index 1
    if (e.From == 1 && e.DraggingAction == DataGridDragAction.DragStarted)
    {
        e.Cancel = true;
    }
    
    // Prevent dropping in the range between indices 3 and 5
    if ((e.To > 3 && e.To < 6) && e.DraggingAction == DataGridDragAction.DragEnded)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}

## Restrict drag and drop between frozen and non-frozen columns

Frozen columns can be restricted from being dragged to non-frozen areas or vice versa. The following code example demonstrates how to prevent dragging and dropping between frozen and non-frozen column regions:

{% highlight c# %}
dataGrid.FrozenColumnCount = 2;  // First 2 columns are frozen
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

private void SfDataGrid_QueryColumnDragging(object? sender, DataGridQueryColumnDraggingEventArgs e)
{
    int frozenCount = dataGrid.FrozenColumnCount;
    
    // Prevent dragging frozen columns out of the frozen region
    if (e.From < frozenCount && e.To >= frozenCount && 
        e.DraggingAction == DataGridDragAction.DragStarted)
    {
        e.Cancel = true;
    }
    
    // Prevent dragging non-frozen columns into the frozen region
    if (e.From >= frozenCount && e.To < frozenCount && 
        e.DraggingAction == DataGridDragAction.DragStarted)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}

**Note:** Frozen columns can be reordered among themselves, and non-frozen columns can be reordered among themselves, but dragging between the two regions is prevented by the code above.

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

The template's data context provides access to the dragged column information through the [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html) binding context, allowing you to display the column header text or other properties.

The following code snippet demonstrates how to load a data template into the column drag-and-drop view:

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AllowDraggingColumn="True">
    <syncfusion:SfDataGrid.ColumnDragDropTemplate>
        <DataTemplate>
            <Grid BackgroundColor="LightBlue" Padding="10">
                <Label Text="{Binding HeaderText}"
                       TextColor="Orange"
                       FontAttributes="Bold"
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

## Event cleanup

To prevent memory leaks, always unsubscribe from the `QueryColumnDragging` event when the page or view is destroyed:

{% highlight c# %}
// Subscribe to the event
dataGrid.QueryColumnDragging += SfDataGrid_QueryColumnDragging;

// Unsubscribe in your page's cleanup or disposal
dataGrid.QueryColumnDragging -= SfDataGrid_QueryColumnDragging;
{% endhighlight %}

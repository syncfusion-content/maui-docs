---
layout: post
title: Column Drag and Drop in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to enable column drag and drop in Syncfusion® .NET MAUI Tree Grid to reorder columns, customize the drag view, and handle drag events.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid column drag and drop, maui treegrid column drag and drop, treegrid reorder columns
---

# Column Drag and Drop in .NET MAUI Tree Grid

The [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) control allows you to reorder columns by dragging a column header and dropping it at a new position. To enable this feature, set the [AllowDraggingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowDraggingColumn) property to `true`. A drag view is displayed while the column header is dragged, and a drop indicator line shows where the column will be placed. You can handle drag-and-drop operations based on your requirements by using the [QueryColumnDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryColumnDragging) event.

To enable column drag and drop, refer to the following code example:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Projects}"
                       ChildPropertyName="Tasks"
                       AllowDraggingColumn="True" />
{% endhighlight %}
{% highlight c# %}
treeGrid.AllowDraggingColumn = true;
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid column drag and drop" src="Images\column-drag-and-drop\maui-treegrid-column-drag-and-drop.gif" width="404"/>

## How column dragging works

* Press the header cell of a column and drag it horizontally. A drag view that shows the header text of the column follows the pointer.
* A drop indicator line is displayed at the position where the column will be placed. The indicator is not displayed when the column is over its own position, or immediately after it, because the drop does not change the column order.
* When the drag view reaches the left or right edge of the TreeGrid, the grid scrolls horizontally and the drop indicator is updated while new columns scroll into view.
* When the drag view is released, the column is moved to the new position in the [Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_Columns) collection. The drop is not applied when no drop indicator is displayed or when the drop is canceled in the `QueryColumnDragging` event.
* Right-to-left [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.visualelement.flowdirection) is supported.

Since the TreeGrid displays hierarchical data, only the columns are reordered. The hierarchy of the rows, and the expand and collapse states of the nodes, are not changed by a column drag.

## Column drag and drop events

The [QueryColumnDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryColumnDragging) event is an `EventHandler<TreeGridQueryColumnDraggingEventArgs>`. It is raised at each stage of the drag operation. By handling this event, you can cancel the dragging of a column, cancel the drop at a position, or disable auto-scrolling.

| Stage ([TreeGridDragAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDragAction.html)) | When it occurs | Effect of setting `Cancel` to `true` |
|---|---|---|
| `DragStarted` | When the drag of a column header begins. | The column is not dragged. No drag view is displayed. |
| `Dragging` | Continuously while the drag view moves over the header, and while the grid auto-scrolls. | The drop indicator is hidden for the current position, so the column cannot be dropped there. |
| `DragEnded` | When the drag view is released, if a drop indicator is displayed. | The drop is canceled and the column order is not changed. |

N> The event is not raised in the `Dragging` action while the drag view is over the original position of the dragged column.

### TreeGridQueryColumnDraggingEventArgs

`TreeGridQueryColumnDraggingEventArgs` derives from `System.ComponentModel.CancelEventArgs`.

| Property | Type | Access | Description |
|---|---|---|---|
| [From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryColumnDraggingEventArgs_From) | `int` | Get | The index of the column that is being dragged. |
| [To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryColumnDraggingEventArgs_To) | `int` | Get | The index of the column over which the drag view is currently placed, or at which the column is dropped. |
| [DraggingPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryColumnDraggingEventArgs_DraggingPosition) | `Point` | Get | The position of the drag view during the drag-and-drop operation. |
| [DraggingAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryColumnDraggingEventArgs_DraggingAction) | `TreeGridDragAction` | Get | The current stage: `DragStarted`, `Dragging`, or `DragEnded`. |
| [CanAutoScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryColumnDraggingEventArgs_CanAutoScroll) | `bool` | Get/Set | Indicates whether the grid auto-scrolls when the drag view reaches the left or right end of the TreeGrid. The default value is `true`. |
| `Cancel` | `bool` | Get/Set | Set to `true` to cancel the current drag or drop action. The effect depends on `DraggingAction`. |

### TreeGridDragAction

| Value | Description |
|---|---|
| `DragStarted` | A drag begins. |
| `Dragging` | A drag is in progress. |
| `DragEnded` | The drag ends and the drop is about to be applied. |

## Control drag and drop behavior

Use the `QueryColumnDragging` event to restrict or modify column drag-and-drop operations. The `From` and `To` values are indices in the `SfTreeGrid.Columns` collection, so you can use them to read the dragged column, for example `treeGrid.Columns[e.From].MappingName`.

| Scenario | Condition | Code example |
|---|---|---|
| Prevent dragging a specific column | `DragStarted` action and the column index | `if (e.From == 1 && e.DraggingAction == TreeGridDragAction.DragStarted) e.Cancel = true;` |
| Prevent dropping in a specific range | `Dragging` or `DragEnded` action and the target index | `if (e.To > 3 && e.To < 6 && e.DraggingAction != TreeGridDragAction.DragStarted) e.Cancel = true;` |
| Prevent dropping of a specific column | `DragEnded` action and the source index | `if (e.From == 1 && e.DraggingAction == TreeGridDragAction.DragEnded) e.Cancel = true;` |
| Prevent dropping at specific positions | `DragEnded` action and the target index | `if ((e.To == 3 \|\| e.To == 5) && e.DraggingAction == TreeGridDragAction.DragEnded) e.Cancel = true;` |

The following code example demonstrates how to implement drag-and-drop restrictions:

{% tabs %}
{% highlight c# %}
treeGrid.QueryColumnDragging += TreeGrid_QueryColumnDragging;

private void TreeGrid_QueryColumnDragging(object? sender, TreeGridQueryColumnDraggingEventArgs e)
{
    // Prevent dragging the column at index 1.
    if (e.From == 1 && e.DraggingAction == TreeGridDragAction.DragStarted)
    {
        e.Cancel = true;
    }

    // Prevent dropping between the indices 3 and 5.
    if (e.To > 3 && e.To < 6 && e.DraggingAction != TreeGridDragAction.DragStarted)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Prevent dragging a column by its mapping name

The following example locks the column that is mapped to the `Name` property. The column cannot be dragged, and other columns cannot be dropped at the first position.

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryColumnDragging(object? sender, TreeGridQueryColumnDraggingEventArgs e)
{
    if (e.DraggingAction == TreeGridDragAction.DragStarted
        && treeGrid.Columns[e.From].MappingName == "Name")
    {
        e.Cancel = true;
    }

    // Keep the first column in place.
    if (e.To == 0 && e.DraggingAction != TreeGridDragAction.DragStarted)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

N> Set the same condition for the `Dragging` and `DragEnded` actions so that the drop indicator and the drop result are consistent.

## Restrict drag and drop between frozen and non-frozen columns

The TreeGrid freezes columns using the [FrozenColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_FrozenColumnCount) and [FooterFrozenColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_FooterFrozenColumnCount) properties. Verification Required – the column drag-and-drop implementation does not contain separate handling for frozen columns, so the behavior of dragging between the frozen and non-frozen regions is not confirmed. To prevent such moves explicitly, compare the `From` and `To` indices with the frozen column count in the `QueryColumnDragging` event.

{% tabs %}
{% highlight c# %}
treeGrid.FrozenColumnCount = 2; // The first 2 columns are frozen.
treeGrid.QueryColumnDragging += TreeGrid_QueryColumnDragging;

private void TreeGrid_QueryColumnDragging(object? sender, TreeGridQueryColumnDraggingEventArgs e)
{
    if (e.DraggingAction == TreeGridDragAction.DragStarted)
        return;

    bool isFromFrozen = e.From < treeGrid.FrozenColumnCount;
    bool isToFrozen = e.To < treeGrid.FrozenColumnCount;

    // Prevent dropping a column across the boundary of the frozen region.
    if (isFromFrozen != isToFrozen)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

N> Frozen columns can be reordered among themselves and non-frozen columns can be reordered among themselves, but dropping between the two regions is prevented by the code above.

## Customize the appearance

The appearance of the column drag view and the drop indicator can be customized using the following properties of the [TreeGridStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html) class, which is available through the `SfTreeGrid.DefaultStyle` property.

| Property | Type | Description |
|---|---|---|
| [ColumnDraggingIndicatorLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_ColumnDraggingIndicatorLineColor) | `Color` | Color of the drop indicator line. |
| [ColumnDragViewBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_ColumnDragViewBackgroundColor) | `Color` | Background color of the drag view. |
| [ColumnDragViewTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_ColumnDragViewTextColor) | `Color` | Text color of the drag view. |

### Customize the column drag and drop indicator color

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Projects}"
                       ChildPropertyName="Tasks"
                       AllowDraggingColumn="True">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle ColumnDraggingIndicatorLineColor="DeepPink" />
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.DefaultStyle.ColumnDraggingIndicatorLineColor = Colors.DeepPink;
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid column drag indicator color" src="Images\column-drag-and-drop\maui-treegrid-column-drag-indicator-color.png" width="450"/>

### Customize the drag view text and background color

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Projects}"
                       ChildPropertyName="Tasks"
                       AllowDraggingColumn="True">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle ColumnDragViewTextColor="#FFFFFF"
                                  ColumnDragViewBackgroundColor="#FFBF69" />
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.DefaultStyle.ColumnDragViewTextColor = Colors.White;
treeGrid.DefaultStyle.ColumnDragViewBackgroundColor = Color.FromArgb("#FFBF69");
{% endhighlight %}
{% endtabs %}

<img alt="TreeGrid column drag view background and text color" src="Images\column-drag-and-drop\maui-treegrid-drag-view-background-and-text-color.png" width="450"/>

### Column drag-and-drop template

The [ColumnDragDropTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_ColumnDragDropTemplate) property allows you to load custom content in the column drag view. The content can be provided through a `DataTemplate` or a `DataTemplateSelector`.

When a `DataTemplate` is used, the binding context of the template is the [TreeGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html) that is being dragged, so you can bind its properties such as `HeaderText`. When a `DataTemplateSelector` is used, the dragged `TreeGridColumn` is passed as the item to its `SelectTemplate` method.

The size of the drag view is the size of the dragged header cell. If the content of the template has `WidthRequest` or `HeightRequest` set, those values are used instead.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Projects}"
                       ChildPropertyName="Tasks"
                       AllowDraggingColumn="True">
    <syncfusion:SfTreeGrid.ColumnDragDropTemplate>
        <DataTemplate>
            <Grid BackgroundColor="LightBlue" Padding="10">
                <Label Text="{Binding HeaderText}"
                       TextColor="Orange"
                       FontAttributes="Bold"
                       HorizontalTextAlignment="Center"
                       VerticalTextAlignment="Center" />
            </Grid>
        </DataTemplate>
    </syncfusion:SfTreeGrid.ColumnDragDropTemplate>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
treeGrid.AllowDraggingColumn = true;
treeGrid.ColumnDragDropTemplate = new DataTemplate(() =>
{
    var label = new Label
    {
        TextColor = Colors.Orange,
        FontAttributes = FontAttributes.Bold,
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    };
    label.SetBinding(Label.TextProperty, nameof(TreeGridColumn.HeaderText));

    return new Grid
    {
        BackgroundColor = Colors.LightBlue,
        Padding = 10,
        Children = { label }
    };
});
{% endhighlight %}
{% endtabs %}

<img alt="Column drag and drop template" src="Images\column-drag-and-drop\maui-treegrid-column-drag-and-drop-template.gif" Width="404" />

## Cancel auto scrolling

Auto-scrolling during column dragging can be disabled using the `CanAutoScroll` argument.

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryColumnDragging(object? sender, TreeGridQueryColumnDraggingEventArgs e)
{
    // Disable scrolling while dragging the columns.
    e.CanAutoScroll = false;
}
{% endhighlight %}
{% endtabs %}
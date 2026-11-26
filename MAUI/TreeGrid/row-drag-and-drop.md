---
layout: post
title: Row Drag and Drop in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to enable and customize row drag and drop in Syncfusion® .NET MAUI Tree Grid to reorder rows or move them to another parent in the hierarchy.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid row drag and drop, maui treegrid row drag and drop, treegrid reorder rows
---

# Row Drag and Drop in .NET MAUI Tree Grid

The [SfTreeGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html) control allows users to drag and drop rows by setting the [SfTreeGrid.AllowDraggingRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowDraggingRow) property to `true`. On touch devices, users can drag a row by long-pressing and dragging it while by clicking and dragging on desktop platforms. A row drag view is displayed during the drag operation. You can handle drag-and-drop operations based on your requirements by using the [SfTreeGrid.QueryRowDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowDragging) event.

Unlike a flat grid, every row in the TreeGrid is a node in a hierarchy. A row can be dropped **above** a row, **below** a row, or **as a child** of a row, and the dragged row always moves together with all of its descendant rows.

To enable row drag and drop functionality, refer to the following code example:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name = "treeGrid"
                       ItemsSource = "{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       AllowDraggingRow = "True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowDraggingRow = true;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Row Drag and Drop in .NET MAUI TreeGrid" src="Images\row-drag-and-drop\maui-treegrid-row-drag-and-drop.gif" width="404"/>

## Dragging scenarios

The SfTreeGrid supports drag-and-drop operations in the following scenarios:

* **Records reordering with auto-scrolling**: Rows can be reordered to any position in the grid. Auto-scrolling is enabled by default, allowing continuous scrolling when dragging near the top or bottom boundary of the grid.
* **Reorder sibling rows**: Drop a row above or below another row that has the same parent to change its order.
* **Move a row to another parent**: Drop a row above or below a row that is at a different level to make it a sibling of that row, or drop it as a child to make it the last child of the target row.
* **Move a row to the root level**: Drop a row above or below a root-level row to make it a root node.
* **Move a subtree**: When a row that has child rows is dragged, all of its descendants move with it. Their relative order and expand state are preserved.
* **Multiple row drag**: Select multiple rows and drag them together. Refer to [Multiple row drag and drop](#multiple-row-drag-and-drop).
* **Auto-expand**: A collapsed row that is hovered in its drop-as-child area for a specified duration expands automatically. Refer to [Auto-expand the target row](#auto-expand-the-target-row).

### Drop position

While a row is dragged, the drop position is resolved from the vertical position of the drag view over the target row. The height of the target row is divided into three areas:

| Area of the target row | Resolved [TreeGridDropPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDropPosition.html) | Result |
|---|---|---|
| Top 25% | `DropAbove` | The dragged rows are inserted before the target row, as its preceding sibling. |
| Middle 50% | `DropAsChild` | The dragged rows are inserted as the last child of the target row. |
| Bottom 25% | `DropBelow` | The dragged rows are inserted after the target row, as its following sibling. |

A drop indicator line is displayed at the top edge, middle, or bottom edge of the target row to show the resolved drop position.

### Drop rules

* A row cannot be dropped onto itself or onto one of its own descendants. The drop is ignored and the hierarchy is not changed.
* When a row is dropped as a child of a collapsed row, the target row is expanded and the dragged rows are added as its last children, if [CanAutoExpand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridRowDragDropController.html#Syncfusion_Maui_TreeGrid_TreeGridRowDragDropController_CanAutoExpand) is `true`.
* After the drop, the selection follows the moved data and not the row indices.

### Effect on the underlying data

* For [self-relational data](https://help.syncfusion.com/maui/treegrid/data-binding), dropping a row updates the child property (the property specified in `ChildPropertyName`) of the dragged item to the parent value of its new parent. When a row is dropped at the root level, the property is set to [SelfRelationRootValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_SelfRelationRootValue) when it is specified.
* For hierarchical data that is bound with a child collection property, the row is moved in the TreeGrid hierarchy. Verification Required – whether the child collections of the data objects are modified by the drop is not confirmed in the source. To keep your own data model in sync, use the `DragEnded` action of the [QueryRowDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowDragging) event as explained in [Reorder the underlying data](#reorder-the-underlying-data).

## Row drag-and-drop template

The [SfTreeGrid.RowDragDropTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_RowDragDropTemplate) allows you to load specific content during row drag-and-drop operations. This template can be defined in XAML or code-behind, and a `DataTemplateSelector` can also be assigned to choose the template based on the dragged row data.

### Default template

The default template is used for row drag-and-drop operations unless another template is explicitly assigned. It displays the cell values of the dragged row. When multiple rows are dragged, a badge that shows the number of dragged rows is displayed on the drag view.

<img alt="Default Row Drag Template" src="Images\row-drag-and-drop\maui-treegrid-row-drag-and-drop.gif" width="404"/>

### Customizing row drag-and-drop template

Any type of custom view can be loaded inside the `RowDragDropTemplate`. Refer to the following code example that demonstrates how to load a custom view in a template:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name = "treeGrid"
                       ItemsSource = "{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       AllowDraggingRow = "True">
    <syncfusion:SfTreeGrid.RowDragDropTemplate>
        <DataTemplate>
            <Label Text = "Drag View"
                   TextColor = "Black"
                   HorizontalTextAlignment = "Center"
                   VerticalTextAlignment = "Center" />
        </DataTemplate>
    </syncfusion:SfTreeGrid.RowDragDropTemplate>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowDraggingRow = true;
treeGrid.RowDragDropTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "Drag View",
        TextColor = Colors.Black,
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    };
});
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Custom Template for Row Drag View" src="Images\row-drag-and-drop\maui-treegrid-row-drag-and-drop-rowdragdroptemplate.gif" width="404"/>

## Auto-expand the target row

When the drag view stays in the drop-as-child area (the middle 50%) of a collapsed row that has child rows, the row expands after a delay. This behavior is controlled by the [TreeGridRowDragDropController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridRowDragDropController.html), which is available through the [SfTreeGrid.RowDragDropController](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_RowDragDropController) property.

| Property | Type | Default | Description |
|---|---|---|---|
| [CanAutoExpand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridRowDragDropController.html#Syncfusion_Maui_TreeGrid_TreeGridRowDragDropController_CanAutoExpand) | `bool` | `true` | Indicates whether a collapsed drop target expands after the drag view stays in its drop-as-child area for the `AutoExpandDelay`. It also decides whether a collapsed row is expanded when a row is dropped as its child. |
| [AutoExpandDelay](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridRowDragDropController.html#Syncfusion_Maui_TreeGrid_TreeGridRowDragDropController_AutoExpandDelay) | `TimeSpan` | 3 seconds | The duration after which a collapsed drop target expands when `CanAutoExpand` is enabled. |

{% tabs %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowDraggingRow = true;

// Expand a collapsed target after 1 second of hovering in its child area.
treeGrid.RowDragDropController.AutoExpandDelay = TimeSpan.FromSeconds(1);

// Or turn off auto-expand.
treeGrid.RowDragDropController.CanAutoExpand = false;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Auto expand a row with Delay" src="Images\row-drag-and-drop\maui-treegrid-row-drag-and-drop-canautoexpand.gif" width="404"/>

## Multiple row drag and drop

The `SfTreeGrid` control supports dragging and dropping multiple rows simultaneously. This functionality can be enabled by setting [SfTreeGrid.AllowDraggingRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowDraggingRow) to `true`, `SfTreeGrid.SelectionMode` to `Multiple` or `Extended`, and `SfTreeGrid.SelectionUnit` to `Row` (the default value of `SelectionUnit`).

Once enabled, users can select the required rows and perform drag-and-drop operations in the same manner as standard row drag and drop. During the drag operation, the number of selected rows is indicated through a badge view on the drag view.

The multiple row drag follows these rules:

* The selected rows are dragged together only when the pressed row is one of the selected rows. Otherwise, only the pressed row is dragged.
* If a selected row is a descendant of another selected row, it is not added separately because it already moves with its ancestor.
* In the `QueryRowDragging` event, `DraggingNodes` and `DraggingRecords` contain all the dragged rows.

N> The badge view is not displayed when a custom view is defined using the [SfTreeGrid.RowDragDropTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_RowDragDropTemplate).

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name = "treeGrid"
                       ItemsSource = "{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       AllowDraggingRow = "True"
                       SelectionMode = "Multiple"
                       SelectionUnit = "Row">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowDraggingRow = true;
treeGrid.SelectionMode = TreeGridSelectionMode.Multiple;
treeGrid.SelectionUnit = TreeGridSelectionUnit.Row;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Multiple Row Dragging" src="Images\row-drag-and-drop\maui-treegrid-row-drag-and-drop-multi-row-dragging.gif" width="404"/>

## Row drag animation

When the [AllowDraggingRowAnimation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_AllowDraggingRowAnimation) property is enabled, `SfTreeGrid` displays a drag animation that allows users to visually move the selected row during the drag operation. The row follows the pointer as it is dragged, and the other rows move to create a gap at the drop position. This provides a smoother and more intuitive drag-and-drop experience.

Unlike the default drag behavior that uses a drag view, the row itself is animated and moved during the drag operation, making it easier to identify the row being reordered.

The default value of the `AllowDraggingRowAnimation` property is `false`.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       AllowDraggingRow="True"
                       AllowDraggingRowAnimation="True">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
SfTreeGrid treeGrid = new SfTreeGrid();
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowDraggingRow = true;
treeGrid.AllowDraggingRowAnimation = true;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Row Drag Animation" src="Images\row-drag-and-drop\maui-treegrid-row-drag-and-drop-rowdraganimation.gif" width="404"/>

N> The row animation is not used when the row heights are customized by handling the [QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowHeight) event. In this case, the default drag view is used.

## Events in row drag-and-drop

The [SfTreeGrid.QueryRowDragging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowDragging) event is an `EventHandler<TreeGridQueryRowDraggingEventArgs>`. It is triggered when a row begins to be dragged and fires continuously as the row is dragged. By handling this event, you can customize the behavior and cancel the drag or drop operations.

| Stage ([TreeGridDragAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDragAction.html)) | When it occurs | Effect of setting `Cancel` to `true` |
|---|---|---|
| `DragStarted` | When a row drag begins, before the drag view is displayed. | The drag is canceled. No drag view is shown and the hierarchy is not changed. |
| `Dragging` | Continuously while the drag view moves over the rows. | The current target is marked as invalid. The drop indicator is hidden and the row cannot be dropped at this target. |
| `DragEnded` | When the drag view is released over a valid target, before the rows are moved. | The drop is canceled and the hierarchy is left unchanged. |

N> The `DragEnded` action is not raised when the drop target is the dragged row itself or one of its descendants, because the drop is ignored.

The `QueryRowDragging` event provides the following properties through the [TreeGridQueryRowDraggingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html):

* [From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_From): Returns the index of the row where the drag operation started.
* [To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_To): Returns the index of the row where you are attempting to drop the dragged row. This is a view index and changes when the visible tree changes through expand, collapse, sort, or filter operations.
* [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_Position): Returns the current x and y coordinates of the row drag view.
* [DraggingAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_DraggingAction): Returns the current drag state as [TreeGridDragAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDragAction.html). Possible values are `DragStarted`, `Dragging`, and `DragEnded`.
* [RowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_RowData): Returns the data object of the dragged row (the first dragged record).
* [CurrentRowData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_CurrentRowData): Returns the data object of the row under the drag view (the target row).
* [CanAutoScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_CanAutoScroll): Gets or sets a value indicating whether auto-scrolling should occur when the drag view reaches the top or bottom of the `SfTreeGrid`. The default value is `true`.
* [Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_Cancel): Gets or sets a Boolean value indicating whether the operation should be canceled. The effect depends on `DraggingAction`.

The following properties are specific to the TreeGrid, because the dragged rows are nodes of a hierarchy:

* [DraggingNodes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_DraggingNodes): Returns the `IList<TreeNode>` of the tree nodes that are being dragged. Each node carries its descendant subtree.
* [DraggingRecords](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_DraggingRecords): Returns the `IList<object>` of the underlying data records that are being dragged.
* [SourceNode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_SourceNode): Returns the first dragged node.
* [SourceLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_SourceLevel): Returns the level of the first dragged node, or `-1` when there is no dragged node.
* [TargetNode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_TargetNode): Returns the tree node under the drag view.
* [DropPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_DropPosition): Returns the resolved [TreeGridDropPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridDropPosition.html) relative to the `TargetNode`: `DropAbove`, `DropBelow`, or `DropAsChild`.
* [DestinationParentNode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_DestinationParentNode): Returns the node that becomes the parent of the dragged nodes after the drop. `null` indicates the root level.
* [DropLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowDraggingEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowDraggingEventArgs_DropLevel): Returns the level at which the dragged nodes land after the drop.

The `DestinationParentNode` and `DropLevel` values are resolved by the TreeGrid, so you do not need to recompute the tree in the handler to validate a level change.

The event arguments class also provides a public constructor, `TreeGridQueryRowDraggingEventArgs(int from, int to, IList<TreeNode> draggingNodes, IList<object> draggingRecords, TreeNode? targetNode, TreeGridDropPosition dropPosition, Point position, TreeGridDragAction dragAction, bool canAutoScroll, bool cancel, object? rowData, object? currentRowData)`, which is intended for unit testing scenarios.

## Cancel dragging of a particular row

Dragging a specific row can be canceled by using the `TreeGridDragAction` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name = "treeGrid"
                       ItemsSource = "{Binding PersonDetails}"
                       ChildPropertyName = "Children"
                       AllowDraggingRow = "True"
                       QueryRowDragging = "TreeGrid_QueryRowDragging">
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowDraggingRow = true;
this.treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    // e.From returns the index of the dragged row.
    // e.DraggingAction returns the dragging status of the row.
    if (e.From == 1 && e.DraggingAction == TreeGridDragAction.DragStarted)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Cancel dragging based on the level or data of the row

The dragged row can be identified by its level in the hierarchy or by its data. The following example prevents dragging of root-level rows and locked records:

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction != TreeGridDragAction.DragStarted)
        return;

    // SourceLevel is 0 for root-level rows.
    if (e.SourceLevel == 0)
    {
        e.Cancel = true;
    }

    if (e.RowData is EmployeeInfo employee && employee.IsAvailable)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Cancel dropping when dragging over particular rows

The action of dropping while dragging over specific rows can be canceled using the `TreeGridDragAction` argument in the `QueryRowDragging` event handler. When `Cancel` is set in the `Dragging` action, the drop indicator is hidden for that target. Apply the same condition to the `DragEnded` action so that the drop indicator and the drop result are consistent.

{% tabs %}
{% highlight c# %}
this.treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;

private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    // Rows from index 5 to 10 cannot be used as drop targets.
    if (e.To >= 5 && e.To <= 10 && e.DraggingAction != TreeGridDragAction.DragStarted)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Cancel dropping of a particular row

The dropping of a specific row can be canceled using the `TreeGridDragAction` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}
this.treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;

private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.From == 1 && e.DraggingAction == TreeGridDragAction.DragEnded)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Cancel dropping at a particular position

Dropping at a specific position can be canceled by using the `To` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}
this.treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;

private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if ((e.To == 5 || e.To == 7) && e.DraggingAction == TreeGridDragAction.DragEnded)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Cancel dropping of a particular row in a position

The dropping of a particular row at a position can be canceled using the `TreeGridDragAction`, `From`, and `To` arguments in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}
this.treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;

private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.From == 1 && e.To == 3 && e.DraggingAction == TreeGridDragAction.DragEnded)
        e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Restrict drops in the hierarchy

The following sections describe the TreeGrid-specific restrictions that use the resolved `DropPosition`, `DropLevel`, and `DestinationParentNode` values. Use the same condition for the `Dragging` and `DragEnded` actions.

### Disallow dropping as a child

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction != TreeGridDragAction.DragStarted
        && e.DropPosition == TreeGridDropPosition.DropAsChild)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### Restrict the level of the drop

The following example prevents dropping rows deeper than the second level. Levels start at `0` for root rows.

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction != TreeGridDragAction.DragStarted && e.DropLevel > 1)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### Allow reordering only within the same parent

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction != TreeGridDragAction.DragStarted
        && e.DestinationParentNode != e.SourceNode?.ParentNode)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### Restrict dropping based on the data of the target row

The following example allows rows to be dropped as a child only on rows that can have children:

{% tabs %}
{% highlight c# %}
private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction != TreeGridDragAction.DragStarted
        && e.DropPosition == TreeGridDropPosition.DropAsChild
        && e.CurrentRowData is ProjectInfo target && !target.CanHaveChildren)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Reorder the underlying data

The TreeGrid moves the dragged nodes in its own hierarchy when a row is dropped. For self-relational data, the child property of the dragged item is also updated. Refer to [Effect on the underlying data](#effect-on-the-underlying-data).

To persist the change in your own store, such as a database or a service, use the `DragEnded` action of the `QueryRowDragging` event. The event is raised before the rows are moved, so the arguments describe the drop that is about to be applied.

{% tabs %}
{% highlight c# %}
this.treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;

private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction != TreeGridDragAction.DragEnded)
        return;

    var movedRecords = e.DraggingRecords.OfType<ProjectInfo>().ToList();
    var newParent = e.DestinationParentNode?.Item as ProjectInfo;

    // Save the change in your own store. Do not modify the bound collection here,
    // because the TreeGrid applies the move after the event.
    repository.MoveProjects(movedRecords, newParent, e.DropPosition);
}
{% endhighlight %}
{% endtabs %}

N> If you need to run code after the TreeGrid moves the rows, post it to the dispatcher, for example `Dispatcher.Dispatch(() => { ... })`.

## Drop a row in the last position

A row is dropped as the last sibling when `DropPosition` is `DropBelow` and the `TargetNode` is the last child of its parent. For a drop as the last child of a row, `DropPosition` is `DropAsChild`. The following example checks whether the row is dropped as the last child of its parent:

{% tabs %}
{% highlight c# %}
this.treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;

private async void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    if (e.DraggingAction != TreeGridDragAction.DragEnded || e.TargetNode == null)
        return;

    bool isLastChildDrop = e.DropPosition == TreeGridDropPosition.DropAsChild;

    if (e.DropPosition == TreeGridDropPosition.DropBelow && e.TargetNode.ParentNode != null)
    {
        var siblings = e.TargetNode.ParentNode.ChildNodes;
        isLastChildDrop = siblings[siblings.Count - 1] == e.TargetNode;
    }

    if (isLastChildDrop)
    {
        await DisplayAlert("Row drag and drop", "The row is dropped at the last position.", "OK");
    }
}
{% endhighlight %}
{% endtabs %}

## Disable auto scrolling

By default, the grid automatically scrolls when the drag view reaches the top or bottom boundaries during row drag operations. To disable this behavior, set the `CanAutoScroll` property to `false` in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}
treeGrid.QueryRowDragging += TreeGrid_QueryRowDragging;

private void TreeGrid_QueryRowDragging(object? sender, TreeGridQueryRowDraggingEventArgs e)
{
    // Disable automatic scrolling during drag operations.
    e.CanAutoScroll = false;
}
{% endhighlight %}
{% endtabs %}

## Customization of row drag view

The row drag view's background color, border color, text color, badge colors, and the drop indicator color can be customized using the following properties of the [TreeGridStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html) class, which is available through the `SfTreeGrid.DefaultStyle` property.

| Property | Type | Default | Description |
|---|---|---|---|
| [RowDragViewBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_RowDragViewBackgroundColor) | `Brush` | `#F7F2FB` | Background of the row drag view. |
| [RowDragViewBorderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_RowDragViewBorderColor) | `Color` | `#CAC4D0` | Border color of the row drag view. |
| [RowDragViewTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_RowDragViewTextColor) | `Color` | `#1C1B1F` | Text color of the row drag view. |
| [RowDragViewBadgeBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_RowDragViewBadgeBackgroundColor) | `Color` | `#6750A4` | Background color of the badge that shows the number of dragged rows. |
| [RowDragViewBadgeTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_RowDragViewBadgeTextColor) | `Color` | `#FFFFFF` | Text color of the badge. |
| [RowDraggingIndicatorLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridStyle.html#Syncfusion_Maui_TreeGrid_TreeGridStyle_RowDraggingIndicatorLineColor) | `Color` | `#6750A4` | Color of the drop indicator line. |

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:EmployeeInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding PersonDetails}"
                       ChildPropertyName="Children"
                       AllowDraggingRow="True">
    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle RowDraggingIndicatorLineColor="Blue"
                                  RowDragViewBackgroundColor="LightCyan"
                                  RowDragViewBorderColor="DarkCyan"
                                  RowDragViewTextColor="Maroon"
                                  RowDragViewBadgeBackgroundColor="Red"
                                  RowDragViewBadgeTextColor="White" />
    </syncfusion:SfTreeGrid.DefaultStyle>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# %}
EmployeeInfoViewModel viewModel = new EmployeeInfoViewModel();
SfTreeGrid treeGrid = new SfTreeGrid();
treeGrid.ItemsSource = viewModel.PersonDetails;
treeGrid.ChildPropertyName = "Children";
treeGrid.AllowDraggingRow = true;
var style = new TreeGridStyle
{
    RowDraggingIndicatorLineColor = Colors.Blue;
    RowDragViewBackgroundColor = new SolidColorBrush(Colors.LightCyan);
    RowDragViewBorderColor = Colors.DarkCyan;
    RowDragViewTextColor = Colors.Maroon;
    RowDragViewBadgeBackgroundColor = Colors.Red;
    RowDragViewBadgeTextColor = Colors.White;
};
treeGrid.DefaultStyle = style;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Styling for Row Drag View" src="Images\row-drag-and-drop\maui-treegrid-row-drag-and-drop-styling.gif" width="404"/>

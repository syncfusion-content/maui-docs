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
                       AllowDraggingRow="True"
 </syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowDraggingRow = true;
{% endhighlight %}
{% endtabs %}

![DataGrid with row drag and drop](SfDataGrid_images/RowDragandDrop.gif)

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

![Drag and drop pop-up with default apperance](SfDataGrid_images/DefaultTemplate.jpg)

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

{% tabs %}
{% highlight c# %}
//Row template with a custom view representing rows.

public class RowTemplate : Grid
{        
    #region Constructor

    public RowTemplate()
    {
        this.BackgroundColor = Color.White;
        this.Children.Add(CreateLabel("OrderID"));
        this.Children.Add(new BoxView() { Color = Color.Gray, WidthRequest = 1 });
        this.Children.Add(CreateLabel("EmployeeID"));
        this.Children.Add(new BoxView() { Color = Color.Gray, WidthRequest = 1 });
        this.Children.Add(CreateLabel("CustomerID"));
        this.Children.Add(new BoxView() { Color = Color.Gray, WidthRequest = 1 });
        this.Children.Add(CreateLabel("FirstName"));
        this.Children.Add(new BoxView() { Color = Color.Gray, WidthRequest = 1 });
        this.Children.Add(CreateLabel("LastName"));
    }

    #endregion

    #region Private Method

    private ContentView CreateLabel(string Property)
    {
        var label = new Label();
        label.TextColor = Color.Black;
        label.LineBreakMode = LineBreakMode.NoWrap;
        label.FontSize = 12;
        label.HorizontalTextAlignment = TextAlignment.Center;
        label.VerticalTextAlignment = TextAlignment.Center;
        label.SetBinding(Label.TextProperty, Property);
        return new ContentView() { Content = label };
    }

    #endregion

    #region Override Method

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        foreach (var child in Children)
        {
            if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
            {
                if (child is ContentView)
                    child.Layout(new Rectangle(x, y, (width / ((Children.Count + 1) / 2)) - 0.5, height));
                else
                    child.Layout(new Rectangle(x, y, 0.5, height));
            }
            else
            {
                if (child is ContentView)
                    child.Layout(new Rectangle(x, y, (width / ((Children.Count + 1) / 2)) - 1, height));
                else
                    child.Layout(new Rectangle(x, y, 1, height));

            }
            x += child.Width;
        }
    }

    #endregion
}

{% endhighlight %}
{% endtabs %}

![Drag and drop pop-up with customized apperance](SfDataGrid_images/CustomizedTemplate.jpg)

N> Currently, the row drag-and-drop features cannot be used if different row sets with varying heights are specified using the `QueryRowHeight` event.

You can download the customizing row drag-and-drop template sample [here](https://www.syncfusion.com/downloads/support/directtrac/general/ze/RowDragandDrop865318434).

## Events in row drag-and-drop

The `QueryRowDragging` event is triggered when a row begins to be dragged and continues to be triggered until the dragging ends. By handling the `SfDataGrid.QueryRowDragging` event, you can also cancel the dragging of a specific row.

The `QueryRowDragging` event provides the following properties in the `QueryRowDraggingEventArgs`:

 * `From`: Returns the index of the row that is currently being dragged.
 * `To`: Returns the index of the row where you attempt to drop the dragged item.
 * `Position`: Returns the current x and y coordinates of the RowDragView.
 * `Reason`: Returns the details of row dragging as `QueryRowDraggingReason`.
 * `RowData`: Returns the underlying data associated with the row that was dragged.
 * `CurrentRowData`: Returns the row data corresponding to the current position of the row drag view.
 * `CanAutoScroll`: Returns whether auto-scrolling should occur when the row drag view reaches the top or bottom of the `SfDataGrid`.
 * `Cancel`: Returns a Boolean value that indicates whether to cancel the event.

## Cancel dragging of a particular row

Dragging a specific row can be canceled by using the `QueryRowDraggingReason` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
    //e.From returns the index of the dragged row.
    //e.Reason returns the dragging status of the row.
    if (e.From == 1 && e.Reason == QueryRowDraggingReason.DragStarted)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping when dragging over particular rows

The action of dropping while dragging over specific rows can be canceled using the `QueryRowDraggingReason` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
    //e.To returns the index of the current row.
    //e.Reason returns the dragging status of the row.
    if ((e.To > 5 || e.To < 10) &&
    (e.Reason == QueryRowDraggingReason.DragEnded || e.Reason == QueryRowDraggingReason.Dragging))
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping of a particular row

The dropping of a specific row can be canceled using the `QueryRowDraggingReason` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
    //e.From returns the index of the dragged row.
    //e.Reason returns the dragging status of the row.
    if (e.From == 1 && e.Reason == QueryRowDraggingReason.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping at a particular position

Dropping at a specific position can be canceled by using the `QueryRowDraggingReason` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
    //e.To returns the index of the current row.
    //e.Reason returns the dragging status of the row.
    if ((e.To == 5 || e.To == 7) && e.Reason == QueryRowDraggingReason.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## Cancel dropping of a particular row in a position

The dropping of a particular row at a position can be canceled using the `QueryRowDraggingReason` and `Position` arguments in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
     //e.To returns the index of the current row.
     //e.Position returns the x and y position of the current row
      if ((e.To == 3) && e.Position == new Point(927,1167) && e.Reason == QueryRowDraggingReason.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}   

## Cancel drag and drop between frozen and non-frozen rows

### Cancel dragging between frozen and non-frozen rows

Dragging between frozen and non-frozen rows can be canceled using the `QueryRowDraggingReason` and `From` arguments of the `QueryRowDragging` event handler by checking whether the value of the `From` argument is an index of a frozen row.

{% tabs %}
{% highlight c# %}

SfGrid.FrozenRowsCount = 4;

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
     //e.From returns the index of the dragged frozen row.
     //e.To returns the index of the current row.
      if    (e.From > sfGrid.GetHeaderIndex() && e.From <= sfGrid.FrozenRowsCount && e.Reason == QueryRowDraggingReason.DragStarted)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

### Cancel dropping between frozen and non-frozen rows

Dropping between frozen and non-frozen rows can be canceled using the `QueryRowDraggingReason` and `From` arguments of the `QueryRowDragging` event handler by checking whether the value of the `From` argument is an index of a frozen row.

{% tabs %}
{% highlight c# %}

SfGrid.FrozenRowsCount = 4;

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
      //e.From returns the index of the dragged frozen row.
      //e.To returns the index of the current row.
      if (e.From > sfGrid.GetHeaderIndex() && e.From <= sfGrid.FrozenRowsCount && e.Reason == QueryRowDraggingReason.DragEnded)
        e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

N> FrozenRowsCount must be less than rows in view.

## Reorder the underlying data

Reordering changes made directly to the underlying data can be done using the `QueryRowDraggingReason` argument in the `QueryRowDragging` event handler. Please refer to the following code sample to implement permanent reordering changes:

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
    //e.To returns the index of the current row.
    //e.From returns the index of the dragged row.
    if (e.Reason == QueryRowDraggingReason.DragEnded)
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

The `To` property of the `QueryRowDraggingEventArgs` indicates the current drop index of the dragged row when it is being dragged over the grid rows. It returns the same index when dragging a row over the last position or the second-to-last position. To programmatically track whether the dragged row is dropped in the last position or the second-to-last position, the data grid provides the `Position` property in `QueryRowDraggingEventArgs`, which indicates the position of the RowDragView.

Refer to the following code example in which the `Position` property is used to determine whether the row is dropped in the last position:

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{
    var totalHeight = dataGrid.RowColumnIndexToPoint(new RowColumnIndex(viewModel.OrdersInfo.Count, 0)).Y + this.dataGrid.RowHeight;
    if (e.Reason == QueryRowDraggingReason.DragEnded)
    {
        if (Math.Ceiling(e.Position.Y + (dataGrid.RowHeight / 2)) > totalHeight && e.To == viewModel.OrdersInfo.Count)
        {
            //Will hit if the row is dropped at the last position                 
            DisplayAlert("RowDragAndDrop info", "The row is dropped at the last position", "OK");
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Customizing row drag-and-drop indicators

The data grid allows you to customize the row drag-and-drop indicators by creating a custom grid style that derives from `DataGridStyle` and assigning it to the `SfDataGrid.GridStyle` property.

{% tabs %}
{% highlight c#%}

dataGrid.GridStyle = new CustomGridStyle();

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c#%}

// Custom style class
public class CustomGridStyle : DataGridStyle
{
    public CustomGridStyle()
    {

    }

    public override ImageSource GetRowDragUpIndicator()
    {
        return ImageSource.FromResource("DataGridDemo.icons.RedUp.png");
    }

    public override ImageSource GetRowDragDownIndicator()
    {
        return ImageSource.FromResource("DataGridDemo.icons.RedDown.png");
    }
}

{% endhighlight %}
{% endtabs %}

![DataGrid with row drag and drop indicators customized](SfDataGrid_images/CustomizedIndicators_Row.jpg)

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
         viewModel = new ViewModel();
         dataGrid.ItemsSource = viewModel.OrdersInfo;
         dataGrid.QueryRowDragging += DataGrid_QueryRowDragging;
         this.Content = dataGrid;
    }
    private async void DataGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
    {
         if (e.Reason == QueryRowDraggingReason.DragEnded)
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

The following screenshot displays the output generated when executing the code example above.

![DataGrid with summary update after drag and drop](SfDataGrid_images/UpdatedSummary.png)

## Cancel auto scrolling 

The vertical auto-scrolling of the `SfDataGrid` during row drag-and-drop can be canceled using the `CanAutoScroll` argument in the `QueryRowDragging` event handler.

{% tabs %}
{% highlight c# %}

this.SfGrid.QueryRowDragging += SfGrid_QueryRowDragging;

private void SfGrid_QueryRowDragging(object sender, QueryRowDraggingEventArgs e)
{  
    // Disable scroll while dragging the Rows.    
    e.CanAutoScroll = false;
}

{% endhighlight %}
{% endtabs %}

N> You can refer to our [Xamarin DataGrid](https://www.syncfusion.com/xamarin-ui-controls/xamarin-datagrid) feature tour page for its groundbreaking feature representations. You can also explore our [Xamarin.Forms DataGrid example](https://github.com/syncfusion/xamarin-demos/tree/master/Forms/DataGrid) to knows various chart types and how to easily configured with built-in support for creating stunning visual effects.

## See also

[How to update the summaries when a row is dragged and dropped between groups](https://support.syncfusion.com/kb/article/7046/how-to-update-the-summaries-when-a-row-is-dragged-and-dropped-between-groups-in-xamarinforms-)


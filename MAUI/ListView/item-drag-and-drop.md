---
layout: post
title: Item Reordering in .NET MAUI ListView control | Syncfusion
description: Learn here all about Item Reordering support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Item Reordering in .NET MAUI ListView (SfListView)

The `SfListView` allows reordering by dragging and dropping items. It supports displaying the customized view in a template while dragging the item. It can be enabled by setting the `SfListView.DragStartMode` property to `OnHold`. The drag and drop options are listed as follows:

 * `None`: Disables drag and drop. This is the default value.
 * `OnHold`: Allows dragging and dropping by holding the item.
 * `OnDragIndicator`: Allows dragging and dropping by loading the `DragIndicatorView` within `SfListView.ItemTemplate`.

N> The `GridLayout` does not support drag and drop. 

The drag and drop scenarios are as follows:

 * Items can be reordered to any position by auto-scrolling.
 * Items can be reordered in same group or in other groups but, no groups can be added to other groups.
 * Groups, header, and footer cannot be reordered.

To enable drag and drop using 'OnHold', follow the code example:

{% tabs %}
{% highlight xaml %}
<ContentPage  xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                   ItemsSource="{Binding ToDoList}"
                   DragStartMode="OnHold"
                   BackgroundColor="#FFE8E8EC"
                   ItemSize="60" />
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.DragStartMode = DragStartMode.OnHold; 
{% endhighlight %}
{% endtabs %}

To enable drag and drop using both 'OnHold' and 'OnDragIndicator', follow the code example:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                   ItemsSource="{Binding ToDoList}"
                   DragStartMode="OnHold, OnDragIndicator"
                   BackgroundColor="#FFE8E8EC"
                   ItemSize="60" />
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.DragStartMode = DragStartMode.OnHold | DragStartMode.OnDragIndicator; 
{% endhighlight %}
{% endtabs %}

N> Reordering changes made only in view, and not in underlying collection. Thus, the changes will be reverted when performing sorting, grouping, or any other operation that refreshes view. You can update underlying collection by setting `UpdateSource` to `true`.

## Drag indicator view

To drag and drop the items by `DragIndicatorView`, set the `SfListView.DragStartMode` property to `OnDragIndicator`. To display the dragging item, define any custom user interface(UI) in `DragIndicatorView`.

N> You must set the SfListView instance as reference to the `ListView` property in `DragIndicatorView`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                   ItemsSource="{Binding ToDoList}"
                   DragStartMode="OnDragIndicator"
                   BackgroundColor="#FFE8E8EC"
                   ItemSize="60">
  <syncfusion:SfListView.ItemTemplate>
    <DataTemplate>
      <Grid Padding="10">
          <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="60" />
          </Grid.ColumnDefinitions>
          <Label x:Name="textLabel" Text="{Binding Name}" Grid.Column="1" FontSize="15" TextColor="#333333" />
          <syncfusion:DragIndicatorView Grid.Column="2" ListView="{x:Reference listView}" 
                    HorizontalOptions="Center" 
                    VerticalOptions="Center">
            <Grid Padding="10, 20, 20, 20">
              <Image Source="dragindicator.png" />
            </Grid>
          </syncfusion:DragIndicatorView>
        </Grid>
      </Grid>
    </DataTemplate>
  </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>                
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.ItemTemplate = new DataTemplate(() =>
{
  var grid = new Grid();
  var name = new Label
  {
    FontSize = 15,
    VerticalOptions = LayoutOptions.Center
  };
  name.SetBinding(Label.TextProperty, new Binding("Name"));

  var indicatorGrid = new Grid()
  {
    Padding = new Thickness(10, 20, 20, 20),
    HorizontalOptions = LayoutOptions.End,
    VerticalOptions = LayoutOptions.Center
  };
  var dragIndicatorView = new DragIndicatorView() { ListView = this.listView };
  var indicator = new Image() { Source = "dragindicator.png" };

  indicatorGrid.Children.Add(indicator);
  dragIndicatorView.Content = indicatorGrid;

  grid.Children.Add(name);
  grid.Children.Add(dragIndicatorView);
  grid.SetRow(dragIndicatorView, 1);
  grid.SetColumn(dragIndicatorView, 0);
  return grid;
});
{% endhighlight %}
{% endtabs %}

The screenshot shows the output of the reordering items by drag and drop. 

![Item reordering by drag and drop](Images/item-drag-and-drop/maui-listview-dragviewindicator.gif)

## Drag item customization

By defining the `SfListView.DragItemTemplate` property of the `SfListView`, you can display a custom user interface (UI) when performing drag and drop operations. The template can be defined either in code or XAML.

N> If the `BackgroundColor` is set for the `DragItemTemplate` or `DragIndicatorView`, make sure to set `InputTransparent` to `true`. This is necessary because dragging does not occur when using the `DragIndicatorView` in UWP.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                   ItemsSource="{Binding ToDoList}"
                   DragStartMode="OnHold"
                   BackgroundColor="#FFE8E8EC"
                   ItemSize="60">
  <syncfusion:SfListView.DragItemTemplate>
    <DataTemplate>
      <Grid Padding="10">
        <Label x:Name="textLabel" Text="{Binding Name}" FontSize="15" />
      </Grid>
    </DataTemplate>
  </syncfusion:SfListView.DragItemTemplate>
</syncfusion:SfListView>                
</ContentPage>
{% endhighlight %}
{% highlight c# %}
listView.DragItemTemplate = new DataTemplate(() => {
  var grid = new Grid();
  var name = new Label { FontSize = 15 };
  name.SetBinding(Label.TextProperty, new Binding("Name"));
  grid.Children.Add(name);
  return grid;
});
{% endhighlight %}
{% endtabs %}

## Event

The `ItemDragging` event is raised while dragging and dropping the item in the `SfListView`. The `ItemDraggingEventArgs` has the following members which provides the information for the `ItemDragging` event:

 * `Action`: Returns the drag `Action` such as start, dragging, and drop.
 * `Bounds`: Return bounds of drag item when dragging and dropping.
 * `Handled`: If this member is set to `true`, dragging can be handled. It is applicable only if `Action` is `Dragging`.
 * `DataItem`: Returns the underlying data of the dragging item. 
 * `NewIndex`: Returns the item index of the `DataSource.DisplayItems` where dragging item is going to be dropped.
 * `OldIndex`: Returns the item index of the `DataSource.DisplayItems` where dragging item started. The OldIndex and NewIndex will be same if `Action` is `Start`.
 * `Position`: Returns the touch position of the drag item from screen coordinates.

## Auto scroll options

### Auto scroll margin

To adjust auto scroll margin, set a value to the `ScrollMargin` property of `AutoScroller` to enable auto-scrolling while dragging. The default value is `15`. Auto-scrolling will be enabled when reaching `ScrollMargin` from view bounds while dragging.

To disable auto-scrolling, set the value to `0` for `ScrollMargin`.

{% tabs %}
{% highlight c# %}
this.listView.AutoScroller.ScrollMargin = 20;
{% endhighlight %}
{% endtabs %}

### Auto scroll interval

To adjust auto-scroll interval while dragging, set the `Interval` property of `AutoScroller`. The default value is `150 milliseconds`.

{% tabs %}
{% highlight c# %}
this.listView.AutoScroller.Interval = new TimeSpan(0, 0, 0, 0, 200);
{% endhighlight %}
{% endtabs %}

### Disable outside scroll

To disable auto-scroll when dragging item moves outside the `SfListView` while dragging, set the `AllowOutsideScroll` property of `AutoScroller` to `false`. The default value is `true`.

{% tabs %}
{% highlight c# %}
this.listView.AutoScroller.AllowOutsideScroll = false;
{% endhighlight %}
{% endtabs %}

## Disable dragging for particular item

To disable dragging for a particular item, handle the `ItemDragging` event based on the conditions of `Action` event argument.

You can cancel the dragging action for a particular item by setting the `Cancel` property of the `ItemDraggingEventArgs`.

{% tabs %}
{% highlight c# %}
private void ListView_ItemDragging(object sender, ItemDraggingEventArgs e)
{
  // Disable the dragging for 4th item.
  if (e.Action == DragAction.Start && e.NewIndex == 3)
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Cancel dropping for the dragged item

To cancel dropping for the dragged item, handle the `ItemDragging` event based on the conditions of `Action` event argument. 

You can cancel the dropping action for a particular item by setting the `Cancel` property of the `ItemDraggingEventArgs`.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.ListView.Helpers;
private void ListView_ItemDragging(object sender, ItemDraggingEventArgs e)
{
  // Cancel the dropping if drop the drag item into out of view.
  var listView = sender as ListView;
  var totalExtent = this.listView.GetVisualContainer().Bounds.Bottom;
  if (e.Action == DragAction.Drop && (e.Bounds.Y < -30 || e.Bounds.Bottom > totalExtent + 40))
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## Reorder the underlying collection

The underlying collection can be reordered directly by setting the `UpdateSource` property to `true`. The default value is `false`. 

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" 
                   ItemsSource="{Binding ToDoList}"
                   DragStartMode="OnHold"
                   BackgroundColor="#FFE8E8EC"
                   ItemSize="60">
  <syncfusion:SfListView.DragDropController>
                <syncfusion:DragDropController
                    UpdateSource="True">
                </syncfusion:DragDropController>
   </syncfusion:SfListView.DragDropController>
</syncfusion:SfListView>                
</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.listView.DragDropController.UpdateSource = true;
{% endhighlight %}
{% endtabs %}

We can able to update collection even when `UpdateSource` is `false`. Like, user can decide where dragged item should be dropped actually by handling the `ItemDragging` event with `DragAction.Drop`.

{% tabs %}
{% highlight c# %}
private void ListView_ItemDragging(object sender, ItemDraggingEventArgs e)
{
   if (e.Action == DragAction.Drop)
      {
        viewModel.ToDoList.MoveTo(1, 5);
      }
}
{% endhighlight %}
{% endtabs %}

N> Underlying collection will not be updated when any data operation like sorting or grouping is performed. The order will be maintained only in `DisplayItems` of data source. When drag and drop an item between groups, the value of the property in which grouping is performed is updated in data object. 

## Delete item when dropping in particular view

To delete the dragged item when dropping into a particular view, handle the `ItemDragging` event based on the conditions of `Action` and `Bounds` event arguments. 

To delete the dragged item from the underlying collection when dropping into delete icon, follow the code example. It will enable or disable whenever drag started, and dropped by `IsVisible` property in ViewModel.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
<Grid>
  <Grid.RowDefinitions>
    <RowDefinition Height="40" />
    <RowDefinition Height="*" />
  </Grid.RowDefinitions>

  <Grid BackgroundColor="#2196F3">
    <Label Text="To Do Items" x:Name="headerLabel"  TextColor="White" FontAttributes="Bold" VerticalOptions="Center" HorizontalOptions="Center" />
    <StackLayout x:Name="stackLayout" IsVisible="{Binding IsVisible}" Orientation="Horizontal" VerticalOptions="Center" HorizontalOptions="Center">
          <Image Source="delete.png" HeightRequest="30" WidthRequest="30" VerticalOptions="Center" HorizontalOptions="Center" />
          <Label x:Name="deleteLabel" Text="Delete Item" FontAttributes="Bold" TextColor="White" VerticalTextAlignment="Center" />
    </StackLayout>
  </Grid>
  <syncfusion:SfListView x:Name="listView" Grid.Row="1"
                   ItemsSource="{Binding ToDoList}"
                   DragStartMode="OnHold"
                   BackgroundColor="#FFE8E8EC"
                   ItemSize="60" />
</Grid>            
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();
    var maingrid = new Grid();
    maingrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
    maingrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
    var grid = new Grid();
    var headerLabel = new Label()
    {
        Text = "To Do Items"
    };
    var stackLayout = new StackLayout();
    stackLayout.SetBinding(StackLayout.IsVisibleProperty, new Binding("IsVisible"));
    var image = new Image() { Source = "delete.png" };
    var deleteLabel = new Label() { Text = "DeleteItem" };
    stackLayout.Children.Add(image);
    stackLayout.Children.Add(deleteLabel);
    grid.Children.Add(headerLabel);
    grid.Children.Add(stackLayout);
    var listView = new SfListView()
    {
        DragStartMode = DragStartMode.OnHold,
        ItemSize = 60,
        SelectionMode = Syncfusion.Maui.ListView.SelectionMode.None,
        BackgroundColor = Color.FromHex("#FFE8E8EC")
    };
    listView.ItemsSource = viewModel.ToDoList;
    maingrid.Children.Add(grid);
    maingrid.SetRow(grid, 0);
    maingrid.Children.Add(listView);
    maingrid.SetRow(listView, 1);
    this.Content = maingrid;
  }
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private async void ListView_ItemDragging(object sender, ItemDraggingEventArgs e)
{
  var viewModel = this.listView.BindingContext as ViewModel;

  if (e.Action == DragAction.Start)
  {
    viewModel.IsVisible = true;
    this.headerLabel.IsVisible = false;
  }

  if(e.Action == DragAction.Dragging)
  {
    var position = new Point(e.Position.X - this.ListView.Bounds.X, Math.Abs(e.Position.Y - this.ListView.Bounds.Y));
    if ((this.Stack.Bounds.Y < position.Y) && (this.Stack.Bounds.Y + this.Stack.Height) > position.Y)
    {
      viewModel.IsVisible = true;
      this.deleteLabel.TextColor = Colors.Red;
    }
    else
      this.deleteLabel.TextColor = Colors.White;
  }

  if(e.Action == DragAction.Drop)
  {
    var position = new Point(e.Position.X - this.ListView.Bounds.X, Math.Abs(e.Position.Y - this.ListView.Bounds.Y));
    if ((this.Stack.Bounds.Y < position.Y) && (this.Stack.Bounds.Y + this.Stack.Height) > position.Y)
    {
      await Task.Delay(100);
      viewModel.ToDoList.Remove(e.DataItem as ToDoItem);
    }
    viewModel.IsVisible = false;
    this.deleteLabel.TextColor = Colors.White;
    this.headerLabel.IsVisible = true;
  }
}
{% endhighlight %}
{% endtabs %}

![Delete item while drop in listview](Images/item-drag-and-drop/maui-listview-draganddel.gif)

## Skip dragging item into another group

To skip dragging from one group to another group, handle the `ItemDragging` event based on the conditions of `Action` and `Bounds` event arguments.

N> While auto-scrolling, dragging item cannot be skipped.

Skip the dragging item by bounds of dragging item, and bounds of current and next group item.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.ListView.Helpers;
private async void ListView_ItemDragging(object sender, ItemDraggingEventArgs e)
{
  if (e.Action == DragAction.Dragging)
  {
    var currentGroup = this.GetGroup(e.DataItem);
    var container = this.ListView.GetVisualContainer();
    var groupIndex = this.ListView.DataSource.Groups.IndexOf(currentGroup);
    var nextGroup = (groupIndex + 1 < this.ListView.DataSource.Groups.Count) ? this.ListView.DataSource.Groups[groupIndex + 1] : null;
    ListViewItem groupItem = null;
    ListViewItem nextGroupItem = null;

    foreach (ListViewItem item in container.Children)
    {
      if (item.BindingContext == null || !item.Visibility)
        continue;

      if (item.BindingContext.Equals(currentGroup))
        groupItem = item;

      if (nextGroup != null && item.BindingContext.Equals(nextGroup))
        nextGroupItem = item;
      }

      if (groupItem != null && e.Bounds.Y <= groupItem.Y + groupItem.Height || nextGroupItem != null && (e.Bounds.Y + e.Bounds.Height >= nextGroupItem.Y))
        e.Handled = true;
  }
}

private GroupResult GetGroup(object itemData)
{
  GroupResult itemGroup = null;

  foreach (var item in this.listView.DataSource.DisplayItems)
  {
    if (item is GroupResult)
      itemGroup = item as GroupResult;

    if (item == itemData)
      break;
  }
  return itemGroup;
}
{% endhighlight %}
{% endtabs %}

![Skip dragging item into another group](Images/item-drag-and-drop/maui-listview-draganddrop.gif)

## Drag and drop customization

### Adjust drag item axis

To adjust the X and Y coordinates of the drag item while dragging, you can set the `CanAdjustDragItemAxis` property of the `DragDropController` class to true. By default, the Y coordinates can be adjusted if the `SfListView.Orientation` is set to `Vertical`, and the X coordinates can be adjusted if the `Orientation` is set to `Horizontal`.

{% tabs %}
{% highlight c# %}
this.listView.DragDropController = new DragDropControllerExt(this.listView);

public class DragDropControllerExt : DragDropController
{
  public DragDropControllerExt(SfListView listView) : base(listView)
  {
    CanAdjustDragItemAxis = true;
  }
}
{% endhighlight %}
{% endtabs %}





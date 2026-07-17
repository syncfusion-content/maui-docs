---
layout: post
title: Selection in .NET MAUI ListView control | Syncfusion®
description: Learn here all about Selection support in Syncfusion® .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Selection in .NET MAUI ListView (SfListView)

This section explains how to perform selection and related operations in the `.NET MAUI ListView` (SfListView).

## UI selection

The [.NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview) (SfListView) allows you to select items either programmatically or through touch interactions by setting the [SfListView.SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionMode) property to a value other than `None`. The control has different selection modes to perform selection operations listed as follows:

 * [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SelectionMode.html#Syncfusion_Maui_ListView_SelectionMode_None): Allows disabling selection.
 * [Single](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SelectionMode.html#Syncfusion_Maui_ListView_SelectionMode_Single): Allows selecting single item only. When clicking the selected item, selection will not be cleared. This is the default value for `SelectionMode`.
 * [SingleDeselect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SelectionMode.html#Syncfusion_Maui_ListView_SelectionMode_SingleDeselect): Allows selecting single item only. When clicking the selected item, selection gets cleared.
 * [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SelectionMode.html#Syncfusion_Maui_ListView_SelectionMode_Multiple): Allows selecting more than one item. Selection is not cleared when selecting more than one item. When clicking the selected item, selection gets cleared.
 * [Extended](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SelectionMode.html#Syncfusion_Maui_ListView_SelectionMode_Extended): Allows selecting multiple items with advanced keyboard and mouse interactions. Use Shift to select ranges and use Ctrl on Windows or Command on macOS to toggle items. Available only on Windows and macOS.

The `SfListView` allows selecting items on different gestures such as tap, double tap, and hold by setting the [SfListView.SelectionGesture](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionGesture). The default value for the `SelectionGesture` is [TouchGesture.Tap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.TouchGesture.html#Syncfusion_Maui_ListView_TouchGesture_Tap).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 6" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView"
                        ItemsSource="{Binding MusicInfo}"
                        SelectionMode="Multiple"
                        SelectionGesture="LongPress"/>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.ListView;
// ...

listView.SelectionMode = Syncfusion.Maui.ListView.SelectionMode.Multiple;
listView.SelectionGesture = TouchGesture.LongPress;
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView UI selection](Images/selection/maui-listview-ui-selection.jpg)

## Programmatic selection

When the [SfListView.SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionMode) is other than `None`, the item or items in the `SfListView` can be selected from the code by setting the [SfListView.SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem), or adding items to the [SfListView.SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItems) property based on the `SelectionMode`.

When the selection mode is `Single`, programmatically select an item by setting the underlying object to the `SfListView.SelectedItem` property. 

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
//Perform selection using selected item
listView.SelectedItem = viewModel.Items[5];
{% endhighlight %}
{% endtabs %}

When the selection mode is `Multiple`, programmatically select more than one item by adding the underlying object to the `SfListView.SelectedItems` property. 

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

//Perform multiple selection using selected items
public class SelectionViewModel : INotifyPropertyChanged
{
    private ObservableCollection<object> selectedItems;
    private ObservableCollection<MusicInfo> musicInfo;

    // Sample data. Replace with your own data source as needed.
    private readonly string[] SongsNames = new[] { "Song 1", "Song 2", "Song 3" };
    private readonly string[] SongAuthers = new[] { "Author 1", "Author 2", "Author 3" };

    public SelectionViewModel()
    {
        GenerateSource();
        SelectedItems = new ObservableCollection<object>();
    }

    public ObservableCollection<MusicInfo> MusicInfo
    {
        get { return musicInfo; }
        set { this.musicInfo = value; }
    }

    public ObservableCollection<object> SelectedItems
    {
        get { return selectedItems; }
        set { this.selectedItems = value; }
    }
    private async void GenerateSource()
    {
        var random = new Random();
        for (int i = 0; i < SongsNames.Count(); i++)
        {
            var info = new MusicInfo()
            {
                SongTitle = SongsNames[i],
                SongAuther = SongAuthers[i],
                SongSize = random.Next(50, 600).ToString() + "." + (random.Next(1, 10) / 2.0).ToString("0.0") + "KB",
                SongThumbnail = ImageSource.FromResource("ListViewMaui.Images.SongThumbnail.png"),
            };
            musicInfo.Add(info);
        }
        SelectedItems.Add(MusicInfo[0]);
    }
}
{% endhighlight %}
{% endtabs %}

N> The `SfListView.SelectedItems` property is of type `ObservableCollection<Object>`. Therefore, it is recommended to use a ViewModel collection property of type `ObservableCollection<Object>` to ensure proper functioning of the `SelectedItems` property.

To programmatically select more than one item at runtime, add the underlying objects to the `SfListView.SelectedItems` collection. The following example performs the selection inside a button click handler, after the page's `BindingContext` has been set, so that `viewModel` is available:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<Button Text="Select items" Clicked="OnSelectItemsClicked"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void OnSelectItemsClicked(object sender, EventArgs e)
{
  // Ensure the BindingContext (ViewModel) is set before this runs,
  // and that the SfListView is fully initialized.
  listView.SelectedItems.Add(viewModel.MusicInfo[4]);
  listView.SelectedItems.Add(viewModel.MusicInfo[5]);
}
{% endhighlight %}
{% endtabs %}

N> Adding to `SelectedItems` directly is only valid when `SelectionMode` is `Multiple` or `Extended`. In `Single` mode, set `listView.SelectedItem = viewModel.MusicInfo[4];` instead. The calls must be made after the page's `BindingContext` is set (typically after `InitializeComponent()`) and after the list has been loaded, otherwise `viewModel.MusicInfo` may be null.

To bind the `SelectedItems` property to a ViewModel, use `Mode=TwoWay` so the ViewModel is updated when the user changes the selection through the UI:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfListView x:Name="listView"
                       ItemsSource="{Binding MusicInfo}"
                       SelectedItems="{Binding SelectedItems, Mode=TwoWay}">
</syncfusion:SfListView>
{% endhighlight %}
{% endtabs %}

N> Use `Mode=TwoWay` (the default for `SelectedItems`) so that selection changes performed by the user through UI interactions push the updated collection back into the ViewModel. One-way binding will not reflect UI selection changes in the bound ViewModel property.

All items of the `SfListView` can be selected using the [SelectAll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectAll) method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %} 
listView.SelectAll();
{% endhighlight %}
{% endtabs %}

N>When you programmatically select an item, then the selection-related `events` are not triggered. It is triggered only by UI interactions.
However, get the notification from the SelectedItems collection changed event, which will be triggered when you add an item at runtime.

## Selected items

### Get selected items

The `SfListView` gets all the selected items using the [SfListView.SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItems) property and gets the single item by using the [SfListView.SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem) property.

### Clear selected items

The selected items can be cleared by calling the `SelectedItems.Clear()` method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.SelectedItems.Clear();
{% endhighlight %}
{% endtabs %}

### CurrentItem vs SelectedItem

The `SfListView` gets the selected item by using the [SfListView.SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem) and [SfListView.CurrentItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CurrentItem) properties. Both `SfListView.SelectedItem` and `SfListView.CurrentItem` return the same data object when selecting a single item. When selecting more than one item, the `SfListView.SelectedItem` property returns the first selected item, and the `SfListView.CurrentItem` property returns the last selected item.

W> If you select an item when [SfListView.SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionMode) is `None` or if you select multiple items when `SfListView.SelectionMode` is `Single`, exception will be thrown.

## Selected item customization 

The .NET MAUI ListView (SfListView) supports customizing the selection background color for the selected items by using the [SfListView.SelectedItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItemTemplate), if the background color is set to view loaded in the [SfListView.ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate).

N> `SelectedItemTemplate` is a separate `DataTemplate` that is applied **only to the currently selected item(s)** in addition to (not in place of) the `ItemTemplate`. The `ItemTemplate` continues to render the unselected items, so the selected item is rendered using `SelectedItemTemplate` and the rest are rendered using `ItemTemplate`. This means the selected template must be self-contained; it does not inherit the layout or bindings from `ItemTemplate`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6 7 8 9 10 11 12 13 14 15 16" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding MusicInfo}">
   <syncfusion:SfListView.SelectedItemTemplate>
    <DataTemplate>
     <Grid x:Name="grid" BackgroundColor="RoyalBlue">
      <Grid.RowDefinitions>
         <RowDefinition Height="*" />
         <RowDefinition Height="*" />
         <RowDefinition Height="1" />
      </Grid.RowDefinitions>
      <Label Text="{Binding SongTitle}" />
      <Label Text="{Binding SongAuther}" Grid.Row="1"/>
      <Border Grid.Row="2" HeightRequest="1"/>
     </Grid>
    </DataTemplate>
   </syncfusion:SfListView.SelectedItemTemplate>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
 listView.SelectedItemTemplate = new DataTemplate(() =>
{
  var grid = new Grid();
  grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
  grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
  grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1) });
  grid.BackgroundColor = Colors.RoyalBlue;
  var songTitle = new Label();
  songTitle.SetBinding(Label.TextProperty, new Binding("SongTitle"));
  var songAuthor = new Label();
  songAuthor.SetBinding(Label.TextProperty, new Binding("SongAuther"));
  var border = new Border()
  {
    HeightRequest = 1,
  };
  grid.SetRow(songTitle, 0);
  grid.SetRow(songAuthor, 1);
  grid.SetRow(border, 2);
  grid.Children.Add(songTitle);
  grid.Children.Add(songAuthor);
  grid.Children.Add(border);
  return grid;
});
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView selected item customization](Images/selection/maui-listview-selected-item-customization.jpg)

### Showing a checked icon on selected items 

To customize the appearance of the selected item or items, use the appearance of [SfListView.SelectedItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItemTemplate). The following customizations should give you an idea to customize the appearance of selected items in the control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding MusicInfo}">
   <syncfusion:SfListView.SelectedItemTemplate>
    <DataTemplate>
     <Grid x:Name="grid">
      <Grid.ColumnDefinitions>
       <ColumnDefinition Width="40" />
       <ColumnDefinition Width="*" />    
       <ColumnDefinition Width="Auto" />
      </Grid.ColumnDefinitions>
      <Image Source="{Binding SongThumbnail}"/>
      <Grid Grid.Column="1">
       <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="*" />
       </Grid.RowDefinitions>
       <Label Text="{Binding SongTitle}" />
       <Grid Grid.Row="1">
        <Grid.ColumnDefinitions>
         <ColumnDefinition Width="*" />
         <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        <Label Text="{Binding SongAuther}" />
        <Label Grid.Column="1" Text="{Binding SongSize}"/>
       </Grid>
      </Grid>
      <Image Grid.Column="2" x:Name="selectionImage" IsVisible="True" Source="Selected.png"/>
     </Grid>
    </DataTemplate>
   </syncfusion:SfListView.SelectedItemTemplate>
  </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.SelectedItemTemplate = new DataTemplate(() =>
{
  var grid1 = new Grid();
  grid1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(40) });
  grid1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
  grid1.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
  var songThumbnail = new Image();
  songThumbnail.SetBinding(Image.SourceProperty, new Binding("SongThumbnail"));
  var grid2 = new Grid();
  grid2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
  grid2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
  grid2.Padding = new Thickness(15, 0, 0, 0);
  var songTitle = new Label();
  songTitle.SetBinding(Label.TextProperty, new Binding("SongTitle"));
  var grid3 = new Grid();
  grid3.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
  grid3.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
  var songAuthor = new Label();
  songAuthor.SetBinding(Label.TextProperty, new Binding("SongAuther"));
  var songSize = new Label();
  songSize.SetBinding(Label.TextProperty, new Binding("SongSize"));
  grid3.Children.Add(songAuthor);
  grid3.Children.Add(songSize, 1, 0);
  grid2.Children.Add(songTitle);
  grid2.Children.Add(grid3, 0, 1);
  var selectionImage = new Image()
  {
    IsVisible = true,
    Source = "Selected.png"
  };
  grid1.Children.Add(songThumbnail);
  grid1.Children.Add(grid2, 1, 0);
  grid1.Children.Add(selectionImage, 2, 0);
  return grid1;
});
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView show checked circle on selected items](Images/selection/maui-listview-show-checked-circle-on-selected-items.jpg)

## Selected item style

### Selection background

The `SfListView` allows you to change the selection background color for the selected items by using the [SfListView.SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionBackground) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
 <syncfusion:SfListView x:Name="listView" 
                        ItemsSource="{Binding MusicInfo}"
                        SelectionBackground="Khaki"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.SelectionBackground = Colors.Khaki;
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView selection background](Images/selection/maui-listview-selection-background.jpg)

### Programmatic animation

The SfListView allows programmatic animation of the selection at runtime by overriding the virtual method `AnimateSelectedItem` of the `SelectionController` class.

**Prerequisites:**
- `SelectionController` and `ListViewItem` are part of the `Syncfusion.Maui.ListView` namespace. Add a corresponding `using Syncfusion.Maui.ListView;` directive to the file that defines your custom controller.
- `SelectionController` and `ListViewItem` are exposed as public types starting with Syncfusion MAUI ListView v21.1.35. In earlier versions these types may be marked `internal`; if you target a version where they are not publicly accessible, you will not be able to subclass `SelectionController` and you will need to either upgrade the NuGet package or use a different mechanism such as the [`SfListView.SelectionBackground`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionBackground) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
 <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding Items}"
             SelectionBackground="#f5e8d5">
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.ListView;
// ...

listView.SelectionController = new SelectionControllerExt(listView);

public class SelectionControllerExt : SelectionController
{
   public SelectionControllerExt(SfListView listView) : base(listView)
   {
   }

   protected override void AnimateSelectedItem(ListViewItem selectedListViewItem)
   {
      base.AnimateSelectedItem(selectedListViewItem);
      if (selectedListViewItem is VisualElement visual)
      {
          visual.Opacity = 0;
          visual.FadeTo(1, 3000, Easing.SinInOut);
      }
   }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView programmatic animation](Images/selection/maui-listview-programmatic-animation.gif)

## Events

### SelectionChanging event

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging) event is triggered when an item is selected at the execution time. [ItemSelectionChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs.html) contains the following members, which provide the information for `SelectionChanging` event:

 * [AddedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs.html#Syncfusion_Maui_ListView_ItemSelectionChangingEventArgs_AddedItems): Gets collection of the underlying data objects where the selection is processed.
 * [RemovedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs.html#Syncfusion_Maui_ListView_ItemSelectionChangingEventArgs_RemovedItems): Gets collection of the underlying data objects where the selection is removed.

You can cancel the selection process within this event by setting the [ItemSelectionChangingEventArgs.Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs.html#Syncfusion_Maui_ListView_ItemSelectionChangingEventArgs_Cancel) property to `true`.

The `SelectionChanging` event is used for the following use case:

 * Disable selection for a particular item based on the underlying data.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.SelectionChanging += ListView_SelectionChanging;  

private void ListView_SelectionChanging(object sender, ItemSelectionChangingEventArgs e)
{
  if (e.AddedItems.Count > 0 && e.AddedItems[0] == ViewModel.Items[0])
      e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### SelectionChanged event

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged) event will occur once selection process is completed for the selected item in the `SfListView`. [ItemSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangedEventArgs.html) contains the following members, which provides information for `SelectionChanged` event:

 * [AddedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangedEventArgs.html#Syncfusion_Maui_ListView_ItemSelectionChangedEventArgs_AddedItems): Gets collection of the underlying data objects where the selection has been processed.
 * [RemovedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangedEventArgs.html#Syncfusion_Maui_ListView_ItemSelectionChangedEventArgs_RemovedItems): Gets collection of the underlying data objects where the selection has been removed.

The `SelectionChanged` event is used for the following use cases:
 
  * Clears all the selected item.
  * Removes the particular selected item.
  * Gets the index of the selected item.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.SelectionChanged += ListView_OnSelectionChanged;  

private void ListView_OnSelectionChanged(object sender, ItemSelectionChangedEventArgs e)
{
   listView.SelectedItems.Clear();
}
{% endhighlight %}
{% endtabs %}

N> [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging) and [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged) events will be triggered only on UI interactions.

## Commands

### SelectionChangedCommand

The [SelectionChangedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChangedCommand) will be triggered when the selection is changed and the [SelectionChangedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChangedCommandParameterProperty) is passed as a parameter. The default value of `SelectionChangedCommandParameter` is `null`. If `SelectionChangedCommandParameter` is not defined then `ItemSelectionChangedEventArgs` will be passed as argument.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4" %}

<ContentPage  xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView"
   SelectionChangedCommand="{Binding ListViewSelectionChangedCommand}"
   SelectionChangedCommandParameter="{x:Reference listView}"
   ItemsSource="{Binding BookInfo}"
   ItemSize="100">
  </syncfusion:SfListView>  
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

public class CommandViewModel
{
  private Command<Object> selectionChangedCommand;
  public Command<object> ListViewSelectionChangedCommand
  {
    get { return selectionChangedCommand; }
    set { selectionChangedCommand = value; }
  }
  public CommandViewModel()
  {
    ListViewSelectionChangedCommand = new Command<object>(SelectionChangedCommandMethod);
  }
  private async void SelectionChangedCommandMethod(object obj)
  {
    var listView = obj as SfListView;
    var contact = listView.SelectedItem as Contacts;
    if (contact != null)
    {
        // Note: DisplayAlert is a Page method. Invoke this from a page
        // code-behind, or use a navigation/dialog service from the ViewModel.
        await Application.Current.MainPage.DisplayAlert("Message", contact.ContactName + " is selected", "OK");
    }
  }
}

{% endhighlight %}
{% endtabs %}

## How to

### Disable selection on a particular item 

The selection of a particular set of items can be disabled based on the [SfListView.SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItems) of the underlying collections. 

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
  public MainPage()
  {
      InitializeComponent();
      // Wire the handler after InitializeComponent so that listView is resolved from XAML.
      listView.SelectionChanging += listView_SelectionChanging;
  }

  private void listView_SelectionChanging(object sender, ItemSelectionChangingEventArgs e)
  {
      if (e.AddedItems.Count > 0)
      {
          var contact = e.AddedItems[0] as Contacts;
          if (contact != null && contact.Category == "Non-Selectable items")
              e.Cancel = true;
      }
  }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView disable selection on a particular item](Images/selection/maui-listview-disable-selection-on-a-particular-item.jpg)

### Automatically scroll to bring a selected item into the view

To bring the [SfListView.SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem) automatically into the view when it changes at runtime by calling the [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html#Syncfusion_Maui_ListView_ListViewLayout_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_) method.  

In linear layout, you can get the row index of `SfListView.SelectedItem` and  resolve if header and group header are used.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="16" %}
public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();
    listView.PropertyChanged += listView_PropertyChanged;
  }

  private void listView_PropertyChanged(object sender, PropertyChangedEventArgs e)
  {
    if (e.PropertyName == "SelectedItem")
    {
       var selectedItemIndex = listView.DataSource.DisplayItems.IndexOf(listView.SelectedItem);
       selectedItemIndex += (listView.HeaderTemplate != null && !listView.IsStickyHeader || !listView.IsStickyGroupHeader) ? 1 : 0;
       selectedItemIndex -= (listView.GroupHeaderTemplate != null && listView.IsStickyGroupHeader) ? 1 : 0;
       (listView.ItemsLayout as LinearItemsLayout).ScrollToRowIndex(selectedItemIndex);
    }
  }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView automatically scroll to bring a selected item into the view](Images/selection/maui-listview-automatically-scroll-to-bring-a-selected-item.jpg)

### Get the index of the selected item

When performing selection, you can get the index of the selected item by using the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged) event from the [DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DisplayItems.html). 

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 10 11 12 13 14" %}
public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();
    listView.SelectionChanged += ListView_SelectionChanged;
  }

  private void ListView_SelectionChanged(object sender, ItemSelectionChangedEventArgs e)
  {
    if (e.AddedItems != null && e.AddedItems.Count > 0)
    {
        var index = listView.DataSource.DisplayItems.IndexOf(e.AddedItems[0]);
        if (index >= 0)
            entry.Text = index.ToString();
    }
  }
}
{% endhighlight %}
{% endtabs %}

### Display selection when the ItemTemplate contains an image

When [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) contains only images, then the selection color will not be visible in the view when an image is selected. To see selection, add any layout such as `Grid` or `StackLayout` above the image, and set margin or padding to it.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7 8 9" %}
<ContentPage  xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView
   ItemsSource="{Binding BookInfo}"
   ItemSize="100">  
    <syncfusion:SfListView.ItemTemplate>  
        <DataTemplate>  
            <Grid Margin="10">  
                <Image Source="{Binding Image}" Aspect="Fill"/>  
            </Grid>  
        </DataTemplate>  
    </syncfusion:SfListView.ItemTemplate>  
</syncfusion:SfListView>  
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12 13 14 15 16" %}
public partial class MainPage : ContentPage
{
    SfListView listView;
    public MainPage()
    {
      InitializeComponent();
      listView = new SfListView();
      listView.ItemSize = 100;
      listView.ItemsSource = viewModel.BookInfo;
      listView.ItemTemplate = new DataTemplate(() =>
      {
          var grid = new Grid() { Margin = 10 };
          var image = new Image() { Aspect = Aspect.Fill};
          image.SetBinding(Image.SourceProperty, new Binding("Image"));
          grid.Children.Add(image);
          return grid;
      });
      this.Content = listView;
    }
}
{% endhighlight %}
{% endtabs %}

## Limitation

* When a `Grid` is loaded inside the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) with a background color, the [SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionBackground) will not display. Because, it overlaps the `SelectionBackground`. In this case, set the background color on the `SfListView` instead of `ItemTemplate`.
* When the `SfListView` contains duplicated items in the collection, only the first instance that was created initially will be selected or deselected.

## See also 

[How to change selected image in .NET MAUI ListView (SfListView)](https://support.syncfusion.com/kb/article/11586/how-to-change-selected-image-in-net-maui-listview-sflistview)
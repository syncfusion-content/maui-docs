---
layout: post
title: Working with ListView in .NET MAUI ListView control | Syncfusion
description: Learn here all about Working with ListView support in Syncfusion .NET MAUI ListView control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Working with ListView in .NET MAUI ListView (SfListView)

## Interacting with ListView Items

### Loaded event

The [Loaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded) event is raised when the `SfListView` is loading in view for the first time.

{% tabs %}
{% highlight c# %}

listView.Loaded += ListView_Loaded;

private void ListView_Loaded(object sender, Syncfusion.Maui.ListView.ListViewLoadedEventArgs e)
{
   listView.SelectedItems.Add(viewModel.Customers[2]);
}

{% endhighlight %}
{% endtabs %}

The `Loaded` event used for the following use cases:

* To scroll the desired position or index by using the [ScrollTo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_) or [ScrollToRowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html#Syncfusion_Maui_ListView_ListViewLayout_ScrollToRowIndex_System_Int32_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_).
* To collapse all the groups.
* To find the sorted or grouped [DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_DisplayItems) of underlying bound data to `SfListView`.

### Tapped event

The [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event will be triggered whenever tapping the item. Here, [TapCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommandParameter) property sets the parameter for [SfListView.TapCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommand) and its default value is [ItemTappedEventArgs](). `ItemTappedEventArgs` has the following members which provides the information for `ItemTapped` event:

 * [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html#Syncfusion_Maui_ListView_ItemTappedEventArgs_ItemType): It gets the type of the tapped item.
 * [ItemData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html#Syncfusion_Maui_ListView_ItemTappedEventArgs_ItemData): The underlying data associated with the tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html#Syncfusion_Maui_ListView_ItemTappedEventArgs_Position): Gets the touch position in the tapped item.

{% tabs %}
{% highlight c# %}

listView.ItemTapped += ListView_ItemTapped;

private void ListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
{
    if (e.ItemData == viewModel.InboxInfo[0])
      viewModel.InboxInfo.Remove(e.ItemData as ListViewInboxInfo);  
}

{% endhighlight %}
{% endtabs %}

The [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event is used for the following use cases:

* To show the context menu.
* To navigate to another page.
* To delete the item in the list view at runtime.
* To display the item details into another view.
* To expand the view like, accordion.
* To change the underlying bound data.
* To skip other events like selection events if the Handled property set to `true`.

### ItemDoubleTapped event

The [ItemDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped) event will be triggered whenever double tapping the item. The [ItemDoubleTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html) has the following members providing information for the `ItemDoubleTapped` event:

 * [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_ListView_ItemDoubleTappedEventArgs_ItemType): It gets the type of double tapped item.
 * [ItemData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_ListView_ItemDoubleTappedEventArgs_ItemData): The underlying data associated with the double tapped item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_ListView_ItemDoubleTappedEventArgs_Position): Gets the touch position in the double tapped item.

{% tabs %}
{% highlight c# %}

listView.ItemDoubleTapped += ListView_ItemDoubleTapped;

private void ListView_ItemDoubleTapped(object sender, Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs e)
{
    var listViewInboxInfo = new ListViewInboxInfo();
    listViewInboxInfo.Title = "Bryce Thomas";
    listViewInboxInfo.Subject = "Congratulations on the move!";
    viewModel.InboxInfo.Add(listViewInboxInfo);
}

{% endhighlight %}
{% endtabs %}

The [ItemDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped) event is used for the following use cases:

* To show the context menu.
* To delete the item in the list view at runtime.
* To change the underlying bound data.

### ItemLongPress event

The [ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress) event will be triggered whenever long pressing the item. Here, [LongPressCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommandParameter) sets the parameter for [SfListView.LongPressCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommand) and its default value is [ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html). `ItemLongPressEventArgs` has the following members which provides the information for `ItemLongPress` event:

 * [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html#Syncfusion_Maui_ListView_ItemLongPressEventArgs_ItemType): It gets the type of the long pressed item.
 * [ItemData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html#Syncfusion_Maui_ListView_ItemLongPressEventArgs_ItemData): The underlying data associated with the holding item as its arguments.
 * [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html#Syncfusion_Maui_ListView_ItemLongPressEventArgs_Position): Gets the touch position in the holding item.

{% tabs %}
{% highlight c# %}

listView.ItemLongPress += ListView_ItemLongPress;

private void ListView_ItemLongPress(object sender, Syncfusion.Maui.ListView.ItemLongPressEventArgs e)
{
   if (e.ItemData == viewModel.InboxInfo[3])
      viewModel.InboxInfo.Remove(e.ItemData as ListViewInboxInfo);         
}

{% endhighlight %}
{% endtabs%}

The [ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress) event is used for the following use cases:

* To show the context menu.

N> Interaction events of the `SfListView` will be triggered for all the `ListViewItems` like `HeaderItem`, `FooterItem`, `GroupHeaderItem`, `LoadMoreItem`, and `RecordItem`. You can handle the interaction actions based on the `ItemType` of the event args. 

### ItemAppearing

The [ItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing) event is raised when the items are appearing in the view on scrolling, loading, and navigating from one page to another page. The [ItemAppearingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html) has the following member which provides the information of appearing Items.

* [ItemData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html#Syncfusion_Maui_ListView_ItemAppearingEventArgs_ItemData): The underlying data associated with the appearing item.

{% tabs %}
{% highlight c# %}

listView.ItemAppearing += listView_ItemAppearing;

private void listView_ItemAppearing(object sender,  Syncfusion.Maui.ListView.ItemAppearingEventArgs e)
{
    if (e.ItemData == viewModel.BookInfo[0])
        Debug.WriteLine((e.ItemData as BookInfo).BookName);

    // If the ItemData value is "Header", then it's a header item.
    if (e.ItemData == "Header")
        Debug.WriteLine("Header is Appeared");
}

{% endhighlight %}
{% endtabs %}

The [ItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing) event used for the following use cases:

* To find the item appears in the view.
* To customize the appearing item to change the background color using converter.

### ItemDisappearing

The [ItemDisappearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing) event is raised when the items disappearing in the view on scrolling, disposing, and navigating from one page to another page. The [ItemDisappearingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html) has the following member which provides the information on disappearing Items:

* [ItemData](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html#Syncfusion_Maui_ListView_ItemDisappearingEventArgs_ItemData): The underlying data associated with the disappearing item.

{% tabs %}
{% highlight c# %}

listView.ItemDisappearing += listView_ItemDisappearing;

private void listView_ItemDisappearing(object sender, Syncfusion.Maui.ListView.ItemDisappearingEventArgs e)
{
    if (e.ItemData == viewModel.BookInfo[0])
        Debug.WriteLine((e.ItemData as BookInfo).BookName);

    // If the ItemData value is "Footer" then it's a Footer item.
    if (e.ItemData == "Footer")
        Debug.WriteLine("Footer is Disappeared");
}

{% endhighlight %}
{% endtabs %}

The [ItemDisappearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing) event used for the following use cases:

* To find the item disappears in the view.

## Loading data from SQLite online database

The .NET MAUI (SfListView) allows binding the data from online database with the help of `Azure App Service`. To perform this, follow the steps:

Step 1: Get URL to store the data online.
Step 2: Create table using `AppServiceHelpers`.
Step 3: Populate the data into the table using the ObservableCollection `Items`.
Step 4: Bind it to SfListView using [SfListView.ItemSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource) property.
Step 5: Refer to the following link to know more about working with `Azure App Service`.
        https://blog.xamarin.com/add-a-backend-to-your-app-in-10-minutes/ 

N> Install the following NuGet packages to successfully run the application:

* Microsoft.Azure.Mobile.Client(v.2.1.1)
* Microsoft.Azure.Mobile.Client.SQLiteStore(v.2.1.1)
* AppService.Helpers (Does not support UWP platform)
* AppService.Helpers.Forms (Does not support UWP platform)

Refer to the following code which illustrates, how to initialize the library with the URL of the `Azure` Mobile App and registering the Model with the client to create a table.

{% tabs %}
{% highlight c# %}
public App()
{
    InitializeComponent();
    IEasyMobileServiceClient client = new EasyMobileServiceClient();
    client.Initialize("http://xamarin-todo-sample.azurewebsites.net");
    client.RegisterTable<ToDo>();
    client.FinalizeSchema();
    MainPage = new NavigationPage(new Pages.ToDoListPage(client));
}
{% endhighlight %}
{% endtabs %}

Refer to the following code which illustrates, how to create a table using `AppServiceHelpers` and insert items in it.

{% tabs %}
{% highlight c# %}
using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Models;
public class BaseAzureViewModel<T> : INotifyPropertyChanged where T : EntityData
{
    IEasyMobileServiceClient client;
    ITableDataStore<T> table;

    public BaseAzureViewModel(IEasyMobileServiceClient client)
    {
        this.client = client;
        table = client.Table<T>();
    }

    // Returns an ObservableCollection of all the items in the table
    ObservableCollection<T> items = new ObservableCollection<T>();
    public ObservableCollection<T> Items
    {
        get { return items; }
        set
        {
            items = value;
            OnPropertyChanged("items");
        }
    }

    // Adds an item to the table.
    public async Task AddItemAsync(T item)
    {
        await table.AddAsync(item);
    }

    // Deletes an item from the table.
    public async Task DeleteItemAsync(T item)
    {
        await table.DeleteAsync(item);
    }

    // Updates an item in the table.
    public async Task UpdateItemAsync(T item)
    {
        await table.UpdateAsync(item);
    }

    // Refresh the table and synchronize data with Azure.
    Command refreshCommand;
    public Command RefreshCommand
    {
        get { return refreshCommand ?? (refreshCommand = new Command(async () => await ExecuteRefreshCommand())); }
    }

    async Task ExecuteRefreshCommand()
    {
        if (IsBusy)
            return;

        IsBusy = true;

        try
        {
            var _items = await table.GetItemsAsync();
            Items.Clear();
            foreach (var item in _items)
            {
                Items.Add(item);
            }
            IsBusy = false;
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged == null)
            return;

        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}
{% endhighlight %}
{% endtabs %}

Refer to the following code which illustrates, how to bind the table contents into the `SfListView`.

{% tabs %}
{% highlight c# %}
public partial class ToDoListPage : ContentPage
{
  public ToDoListPage(IEasyMobileServiceClient client)
  {
    InitializeComponent();
    var viewModel = new ViewModels.ToDosViewModel(client);
    BindingContext = viewModel;
    listView.ItemsSource = viewModel.Items;
  }
  
  private void FetchButton_Clicked(object sender, EventArgs e)
  {
    var viewModel1 = (ToDosViewModel)BindingContext;
    viewModel1.RefreshCommand.Execute(null);
  }
}
{% endhighlight %}

{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.SfListView">
<ContentPage.Content>
        <StackLayout>
            <syncfusion:SfListView x:Name="listView" SelectedItem="{Binding SelectedToDoItem, Mode=TwoWay}" ItemSize="50">
            <syncfusion:SfListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <StackLayout Orientation="Horizontal" HorizontalOptions="FillAndExpand" VerticalOptions="CenterAndExpand">
                                <Label Text="{Binding Text}"/>
                                <Switch IsToggled="{Binding Completed}"/>
                            </StackLayout>
                        </ViewCell>
                    </DataTemplate>
                </syncfusion:SfListView.ItemTemplate>
            </syncfusion:SfListView>
            <Button Text="Add New" Command="{Binding AddNewItemCommand}"/>
            <Button Text="Fetch" Command="{Binding FetchItemCommand}" />
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}

## Loading data from SQLite offline database

The `SfListView` allows binding the data from local database by using `SQLite`. To perform this, follow the steps:

Step 1: Create a `SQLite database table`
Step 2: Populate the data into the table
Step 3: Store them as an `IEnumerable` collection
Step 4: Bind it to SfListView using [SfListView.ItemSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource) property
Step 5: Refer to the following link to know how to create `SQLiteConnection`,
http://developer.xamarin.com/guides/xamarin-forms/working-with/databases/

N> To run this sample in UWP, install [sqLite.Net.Pcl](https://www.nuget.org/packages/sqlite-net-pcl), version v1.0.10 (Only this version of SQLite supports UWP platform, later versions don’t support UWP).

{% tabs %}
{% highlight c# %}
using SQLite;

public class OrderItem
{
    public int ID { get; set; }
    public string Name { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
using SQLite;
  
public class ViewModel
{
    SQLiteConnection database;
    IEnumerable<OrderItem> orderItemCollection;
    public IEnumerable<OrderItem> OrderItemCollection
    {
        get
        {
            if (orderItemCollection == null)
                orderItemCollection = GetItems();
            return orderItemCollection;
        }
    }
    public ViewModel()
    {
        database = DependencyService.Get<ISQLite>().GetConnection();
        // Create the table
        database.CreateTable<OrderItem>();
  
        // Insert items into table
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1001,'Antony')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1002,'Blake')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1003,'Catherine')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1004,'Jude')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1005,'Mark')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1006,'Anderson')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1007,'Wilson')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1008,'Jade')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1009,'Zachery')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1010,'Dhotis')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1011,'Trunks')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1012,'Kevin')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1013,'Mathew')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1014,'Watson')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1015,'Chris')");
        database.Query<OrderItem>("INSERT INTO OrderItem (ID,Name)values (1016,'Phantom')");
    }
  
    public IEnumerable<OrderItem> GetItems()
    {
        // Changing the database table items as ObservableCollection
        var table = (from i in database.Table<OrderItem>() select i);
        ObservableCollection<OrderItem> OrderList = new ObservableCollection<OrderItem>();
        foreach (var order in table)
        {
            OrderList.Add(new OrderItem()
            {
                ID = order.ID,
                Name = order.Name
            });
        }
        return OrderList;
    }
}
{% endhighlight %}
{% endtabs %}

Refer to the following code which illustrates, how to bind the data from the `SQLite` database to `SfListView`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.SfListView">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <Grid>
            <listView:SfListView x:Name="listView" ItemSize="70" 
                                BackgroundColor="Teal"
                        ItemsSource="{Binding OrderItemCollection}">
                <listView:SfListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <ViewCell.View>
                                <Grid>
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="*" />
                                        <RowDefinition Height="1" />
                                    </Grid.RowDefinitions>
                                    <Grid>
                                        <Grid.ColumnDefinitions>
                                            <ColumnDefinition Width="*" />
                                            <ColumnDefinition Width="*" />
                                        </Grid.ColumnDefinitions>
                                        <Label LineBreakMode="NoWrap" Text="{Binding ID}" VerticalOptions="Center"/>
                                        <Label LineBreakMode="NoWrap" Text="{Binding Name}" Grid.Column="1" VerticalOptions="Center" />
                                    </Grid>
                                    <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                                </Grid>
                            </ViewCell.View>
                        </ViewCell>
                    </DataTemplate>
                </listView:SfListView.ItemTemplate>
            </listView:SfListView>
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% endtabs %}

## ListView with Prism Framework

The `SfListView` allows the user to work with prism for MVVM Framework. Steps to be followed:

1. Replace your application to prism application in App.xaml file.
2. Inherit App.xaml.cs from `Prism` application instead of your application.
3. Create a prism namespace library reference in xaml file of the `ContentPage`.
4. Connect view and view model instead of binding context by registering them.

{% tabs %}
{% highlight c# %}
public partial class App : PrismApplication
{
    public App(IPlatformInitializer initializer = null) : base(initializer) { }

    protected override void OnInitialized()
    {
        InitializeComponent();

    }

    protected override void RegisterTypes()
    {
        Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>();
    }
}

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<prism:PrismApplication xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                        xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                        xmlns:prism="clr-namespace:Prism.Unity;assembly=Prism.Unity.Forms"
                        x:Class="ListViewPrism.App">
</prism:PrismApplication>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:prism="clr-namespace:Prism.Mvvm;assembly=Prism.Forms"
             xmlns:local="clr-namespace:ListViewPrism;assembly=ListViewPrism"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             x:Class="ListViewPrism.Views.MainPage"
             Title="MainPage">
    <StackLayout HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
        <syncfusion:SfListView x:Name="listView" ItemSize="70" ItemSpacing="0,0,5,0"
                             AutoFitMode="Height"
                             ItemsSource="{Binding ContactsInfo,}" IsStickyHeader="True" 
                             AllowSwiping="True" IsStickyGroupHeader="True" GroupHeaderSize="50">
        </syncfusion:SfListView>
    </StackLayout>
</ContentPage>    
{% endhighlight %}
{% endtabs %}

## Improving ListView performance

The .Net MAUI ListView (SfListView) has been built from the ground up with an optimized view reuse strategy for the best possible performance on the .Net MAUI platform even when loading large data sets. Following techniques are used to improve performance of the `SfListView`:

 * Bind the `ItemsSource` property to an IList<T> collection instead of an IEnumerable<T> collection because IEnumerable<T> collection do not support random access.
 * The `SfListView` gets refreshed each and every time a new item added into the underlying collection. Because, when adding items at runtime, the `DataSource` gets refreshed. To avoid this behavior, use [BeginInit()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_BeginInit) to stop the `RefreshView()` calling in each time, and use [EndInit()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_EndInit) to start the `RefreshView()` calling when adding number of finished items.
 * Avoid loading complex layout in template of listview. For example, loading large-size images or nested containers degrades the scrolling performance. This practice commonly degrades performance in all platforms, and particularly more in Android version API level 19. So, use fewer elements and images with small size and resolution to achieve the maximum performance.
 * Avoid placing the `SfListView` inside `ScrollView` for the following reasons:
    * The `SfListView` implement its own scrolling.
    * The `SfListView` will not receive any gestures as it will be handled by the parent `ScrollView`.
    * Should define size to the `SfListView` if it loads inside `ScrollView`.
 * Avoid changing the cell layout based on the `BindingContext`. This incurs large layout and initialization costs.
 * Implement a model class inherited with `INotifyPropertyChanged` interface to notify the property changes at runtime.

 ## Scrolling ListView without virtualization

`SfListView` allows you to scroll by loading the entire collection of items inside the `ScrollView` and defining the total extend of its container to `HeightRequest` in the [Loaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded) event.

{% tabs %}
{% highlight xaml %}
<ScrollView>
   <sync:SfListView x:Name="listView" ItemsSource="{Binding BookInfo}" Loaded="listView_Loaded"/>
</ScrollView>
{% endhighlight %}
{% highlight C# %}
using Syncfusion.ListView.Control.Helpers;
public partial class MainPage : ContentPage
{ 
	public MainPage()
	{
		InitializeComponent();
	}
 
	private void listView_Loaded(object sender,  e)
	{
		var container = listView.GetVisualContainer();
		var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(container);
		listView.HeightRequest = extent;
	}
}
{% endhighlight %}
{% endtabs %}


When `SfListView` is in [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode) as `Height`, the extend of the ListView will be updated only while scrolling. So you can resize the ListView in [VisualContainer]((https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.VisualContainer.html)) `PropertyChanged` method as like below.

{% tabs %}
{% highlight xaml %}
<ScrollView>
   <sync:SfListView x:Name="listView" AutoFitMode="Height" ItemsSource="{Binding BookInfo}" Loaded="listView_Loaded"/>
</ScrollView>
{% endhighlight %}
{% highlight C# %}
using Syncfusion.ListView.Control.Helpers;
public partial class MainPage : ContentPage
{
    VisualContainer visualContainer;
    bool loaded;

    public MainPage()
    {
        InitializeComponent();
        visualContainer = listView.GetVisualContainer();
        visualContainer.PropertyChanged += VisualContainer_PropertyChanged;
    }

    private void VisualContainer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Height" && listView.HeightRequest != visualContainer.Height && loaded)
            listView.HeightRequest = visualContainer.Height;
    }

    private void listView_Loaded(object sender, ListViewLoadedEventArgs e)
    {
        var extent = (double)visualContainer.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "TotalExtent").GetValue(visualContainer);
        listView.HeightRequest = extent;
        loaded = true;
    }
}
{% endhighlight %}
{% endtabs %}


N> While loading in `AutoFitMode` make sure that the [ItemSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSize) property value is not specified, to avoid extra space below the list. Update the size of the container after `ListView` loaded to render all the list items in the view.

The following limitations should be noted when using the previous approaches:

* As the entire list items are loaded inside the parent `ScrollView` element, the [ItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing) and [ItemDisappearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing) events will not be fired when scrolling.
* When performing keyboard navigation, the view cannot be scrolled automatically while navigating out of view.
* Scrolling through the touch action will be handled in all platforms and `SfListView` scrolling will be handled by the parent `ScrollView`.


## Working with nested ListView
 
`ListView` allows you to load another `ListView` inside its [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate). When the [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode) of the outer ListView is `Height`, the size of the inner ListView will be allocated from the maximum screen size. Since the exact size for the inner list cannot be obtained before loading the view. 
 
To get a fixed height for the inner ListView, define a value in its `HeightRequest`. If the items inside the inner ListView are less, allocate the total extend of the inner list to its `HeightRequest`.
 
Follow the steps to set the size for the outer ListView based on the extend of inner ListView:

1. Define a property in the Model class and bind it to the `HeightRequest` of inner ListView, as the height for various inner ListView has to be identified while scrolling.
2. Hook the [Container](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.VisualContainer.html) `PropertyChanged` event. When the height of the container changes, set the value of `TotalExtent` to the property bound to the `HeightRequest`.
3. Call the `RefreshView` method asynchronously with few seconds delay in the `Loaded` event of the outer `SfListView`. The height requested for each inner `SfListView` will be set but the outer `SfListView` will not get any notification regarding the size change. So, call the RefreshView method asynchronously after loading the view.

{% tabs %}
{% highlight xaml %}
 <listView:SfListView x:Name="listView"  ItemsSource="{Binding ContactInfo}" AutoFitMode="Height" Loaded="listView_Loaded" AllowGroupExpandCollapse="True">
    <listView:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <Grid>
                        <local:ExtendedListView x:Name="list1" HeightRequest="{Binding InnerListHeight}" ItemsSource="{Binding ContactDetails}" ItemSize="75">
                            <local:ExtendedListView.ItemTemplate>
                                <DataTemplate>
                                    <StackLayout>
                                        <Image Source="{Binding Image}" />
                                        <Label Text="{Binding Name}" />
                                        <Label Text="{Binding Number}" />
                                    </StackLayout>
                                </DataTemplate>
                            </local:ExtendedListView.ItemTemplate>
                        </local:ExtendedListView>
                    </Grid>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </listView:SfListView.ItemTemplate>
</listView:SfListView>
{% endhighlight %}
{% highlight C# %}
 public partial class NestedListView : ContentPage
{
    public NestedListView()
    {
        InitializeComponent();
    }

    private async void listView_Loaded(object sender, Syncfusion.Maui.ListView.ListViewLoadedEventArgs e)
    {
        await Task.Delay(2000);
        listView.RefreshView();
    }
}
{% endhighlight %}
{% endtabs %}

{% highlight C# %}
using Syncfusion.Maui.ListView.Control.Helpers;
public class ExtendedListView : SfListView
{
    VisualContainer container;
    public ExtendedListView()
    {
        container = this.GetVisualContainer();
        container.PropertyChanged += Container_PropertyChanged;
    }
    
    private void Container_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        Device.BeginInvokeOnMainThread(async () =>
        {
            var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(container => container.Name == "TotalExtent").GetValue(container);
            if (e.PropertyName == "Height")
                (this.BindingContext as ContactInfo_NestedListView).InnerListHeight = extent;
        });
    }
}
{% endhighlight %}

 
## Rendering ListView when loading in different layouts

The options are as follows:

* Creates the measurement and layout similar to .Net MAUI ListView, when the ListView is loaded inside the layouts such as `StackLayout`, `ScrollView`, and `Grid`, in which the `RowDefinition` or `ColumnDefinition` is set to `Auto`. In all other layouts, the ListView size will be allocated from the framework.
* Sets the value of total extend to the `HeightRequest` of ListView, since the scrolling will be handled by the parent `ScrollView`, when ListView is loaded inside the `StackLayout` with base parent as `ScrollView` having multiple elements inside the `StackLayout`.

## Refresh view

You can refresh the view by using the [RefreshView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshView) method. It will be used to refresh the items in the listview at runtime while updating the view.

{% tabs %}
{% highlight c# %} 
   listview.RefreshView();   
{% endhighlight %}
{% endtabs %}

## How to

### Filter listview items based on another listview selection

To filter the listview items based on the item selection in another listview, use the [SfListView.DataSource.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_Filter) property.

{% tabs %}
{% highlight c# %}
private void ItemTapped(Syncfusion.Maui.ListView.ItemTappedEventArgs e)
{
    tappedPinedInfo = e.ItemData as PinnedInfo;
    if (tappedPinedInfo.IsFavorite)
    {
        secondLV.DataSource.Filter = FilterDepartures;
        tappedPinedInfo.IsFavorite = false;
    }
    else
    {
        secondLV.DataSource.Filter = null;
        tappedPinedInfo.IsFavorite = true;
    }
    secondLV.DataSource.RefreshFilter();
}

private bool FilterDepartures(object obj)
{
    var departureInfo = obj as DepartureInfo;
    if (tappedPinedInfo == null)
        return true;

    if (departureInfo.Name.ToLower().Contains(tappedPinedInfo.Name.ToLower())
            || departureInfo.RouteName.ToLower().Contains(tappedPinedInfo.RouteName.ToLower()))
        return true;
    else
        return false;
}
{% endhighlight %}
{% endtabs %}
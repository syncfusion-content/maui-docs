---
layout: post
title: Working with MVVM in .NET MAUI ListView control | Syncfusion
description: Learn here all about Working with MVVM support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Working with MVVM in .NET MAUI ListView (SfListView)

## Commands

### Tap command

The [TapCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommand) will be triggered when you tap the item and pass the [ItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html) as a parameter.

{% tabs %}
{% highlight c# tabtitle="CommandViewModel.cs" hl_lines="18 19 20 21 22" %}

listView.TapCommand = viewModel.TappedCommand;

public class CommandViewModel
{
    private Command<Object> tappedCommand;

    public Command<object> TappedCommand
    {
        get { return tappedCommand; }
        set { tappedCommand = value; }
    }

    public CommandViewModel()
    {            
        TappedCommand = new Command<object>(TappedCommandMethod);
    }

    private void TappedCommandMethod(object obj)
    {
        if ((obj as Syncfusion.Maui.ListView.ItemTappedEventArgs).DataItem == viewModel.InboxInfo[0])
            viewModel.InboxInfo.Remove((obj as Syncfusion.Maui.ListView.ItemTappedEventArgs).DataItem as ListViewInboxInfo)
    }   
}

{% endhighlight %}
{% endtabs %}

### RightTapCommand

The [RightTapCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RightTapCommand) will be triggered when you right tap the item and pass the [ItemRightTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html) as a parameter.

{% tabs %}
{% highlight c# tabtitle="CommandViewModel.cs" hl_lines="18 19 20 21" %}

listView.RightTapCommand = viewModel.RightTapCommand;

public class CommandViewModel
{
    private Command<Object> rightTapCommand;

    public Command<object> RightTapCommand
    {
        get { return rightTapCommand; }
        set { rightTapCommand = value; }
    }

    public CommandViewModel()
    {
        RightTapCommand = new Command<object>(RightTapCommandMethod);
    }

    private void RightTapCommandMethod(object obj)
    {
        DisplayAlert("Item Right Tapped", "ListView item right tapped", "Close");
    }
}

{% endhighlight %}
{% endtabs %}

### LongPress command

The [LongPressCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommand) will be triggered when you long press the item and pass the [ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html) as a parameter.

{% tabs %}
{% highlight c# tabtitle="CommandViewModel.cs" hl_lines="18 19 20 21 22" %}

listView.LongPressCommand = viewModel.LongPressCommand;

public class CommandViewModel
{
    private Command<Object> longPressCommand;

    public Command<object> LongPressCommand
    {
        get { return longPressCommand; }
        set { longPressCommand = value; }
    }

    public CommandViewModel()
    {
        LongPressCommand = new Command<object>(LongPressCommandMethod);
    }

    private void LongPressCommandMethod(object obj)
    {
        if ((obj as Syncfusion.Maui.ListView.ItemLongPressEventArgs).DataItem == viewModel.InboxInfo[3])
            viewModel.InboxInfo.Remove((obj as Syncfusion.Maui.ListView.ItemLongPressEventArgs).DataItem as ListViewInboxInfo);
    }
}

{% endhighlight %}
{% endtabs %}

N> When a command is bound to `ItemTemplate`, it must also define `Source` property with its root element as reference. The property in the ViewModel of type Command is only then it executed.

## Event to command

The ListView event can be converted into commands using `Behaviors`. To achieve this, create a command in the ViewModel class and associate it to the ListView event using `Behaviors`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6" %}
<listView:SfListView x:Name="listView"
     ItemsSource="{Binding contactsinfo}">
    <listView:SfListView.Behaviors>
        <local:EventToCommandBehavior EventName="SelectionChanged" 
        Command="{Binding SelectionChangedCommand}"/>
    </listView:SfListView.Behaviors>
</listView:SfListView>
{% endhighlight %}
{% highlight c# tabtitle="ContactsViewModel.cs" hl_lines="13" %}
public class ContactsViewModel
{
    public Command<ItemSelectionChangedEventArgs> selectionChangedCommand;

    public Command<ItemSelectionChangedEventArgs> SelectionChangedCommand
    {
        get { return selectionChangedCommand; }
        set { selectionChangedCommand = value; }
    }

    public ContactsViewModel()
    {
        SelectionChangedCommand = new Command<Syncfusion.Maui.ListView.ItemSelectionChangedEventArgs>(OnSelectionChanged);
    }

    private void OnSelectionChanged(ItemSelectionChangedEventArgs obj)
    {
        App.Current.MainPage.DisplayAlert("Alert", (obj.AddedItems[0] as Contacts).ContactName + " is selected", "OK");
    }
}
{% endhighlight %}
{% endtabs %}

## Binding command of inner ListView to Model Command

You can bind a command for a `Button` inside `ItemTemplate` to the command in Model by specifying `Source` property with its root element as reference to execute the binded property of type command.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7" %}
<listView:SfListView x:Name="listView" ItemsSource="{Binding ContactInfo}">
     <listView:SfListView.ItemTemplate>
        <DataTemplate>
                   <StackLayout>
                        <listView:SfListView x:Name="list1" ItemsSource="{Binding ContactDetails}"TapCommand="{Binding Path=BindingContext.NavigateToSelectModelsCommand, Source={x:Reference listView}}" TapCommandParameter="{Binding}">
                            <listView:SfListView.ItemTemplate>
                                 <DataTemplate>
                                               <StackLayout BackgroundColor="Teal" >
                                                    <Label Text="{Binding ContactName} "/>
                                                    <Label Text="{Binding ContactNumber}"/>
                                                    <StackLayout HeightRequest="1" BackgroundColor="Gray"/>
                                                </StackLayout>
                                 </DataTemplate>
                            </listView:SfListView.ItemTemplate>
                        </listView:SfListView>
                    </StackLayout>
        </DataTemplate>
    </listView:SfListView.ItemTemplate>
</listView:SfListView>

{% endhighlight %}
{% highlight c# tabtitle="ContactInfo.cs" %}

public class ContactInfo_NestedListView
{
    public Command<Object> NavigateToSelectModelsCommand { get; private set; }

    public ContactInfo_NestedListView()
    {
       NavigateToSelectModelsCommand = new Command<Object>(NavigateToSelectModels, CanNavigate);
    }
    private bool CanNavigate(object argument)
    {
            return true;
    }
    private void NavigateToSelectModels(object model)
    {
       var customer = model as ContactInfo_NestedListView;
            
       App.Current.MainPage.DisplayAlert("Message", "Tapped customer group value :" + customer.location, "OK");
    }
}
{% endhighlight %}
{% endtabs %}

## Binding command of Button inside the ItemTemplate of .NET MAUI ListView to ViewModel Command

You can bind command of `Button` inside `ItemTemplate` to the command in ViewModel by specifying `Source` property with its root element as reference to execute the binded property of type command.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6 7 8" %}
<Syncfusion:SfListView x:Name="listView" ItemsSource="{Binding contactsinfo}" >
    <Syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
                <Grid >
                    <Button Text="Delete" 
                    Command="{Binding Path=BindingContext.DeleteCommand, Source={x:Reference listView}}" 
                    CommandParameter="{x:Reference listView}"/>
                </Grid>
        </DataTemplate>
    </Syncfusion:SfListView.ItemTemplate>
</Syncfusion:SfListView>
{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}
namespace ListViewSample 
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        public Command<object> DeleteCommand { get; set; }
         
        public ContactsViewModel()
        {
            DeleteCommand = new Command<object>(OnTapped);
        }

        private void OnTapped(object obj)
        {
            var contact = obj as Contacts;
            contactsInfo.Remove(contact);
            App.Current.MainPage.DisplayAlert("Message","Item Deleted :" +contact.ContactName,"Ok");
        }
    }
}        
{% endhighlight %}
{% endtabs %}

## Binding properties in MVVM pattern

### Binding ItemsSource

`SfListView` allows you to bind the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource) property to populate the list view items from ViewModel.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="7 8 9 11 12" %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:MVVM"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             x:Class="MVVM.MainPage">
    <ContentPage.BindingContext>
        <local:BookInfoRepository/>
    </ContentPage.BindingContext>
</ContentPage>
<syncfusion:SfListView x:Name="listView" 
ItemsSource="{Binding BookInfoCollection}"/>
{% endhighlight %}
{% highlight c# %}
listView.SetBinding(SfListView.ItemsSourceProperty, new Binding("BookInfoCollection", BindingMode.OneWay));
{% endhighlight %}
{% endtabs %}


{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class BookInfoRepository : INotifyPropertyChanged
{
    private ObservableCollection<BookInfo> bookInfoCollection;
    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<BookInfo> BookInfoCollection
    {
        get { return bookInfoCollection; }
        set 
             { 
                 this.bookInfoCollection = value;
         this.OnPropertyChanged("BookInfoCollection");
              }
    }

    public void OnPropertyChanged(string name)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    public BookInfoRepository()
    {
        GenerateNewBookInfo();
    }

    private void GenerateNewBookInfo()
    {
        BookInfoCollection = new ObservableCollection<BookInfo>();
        BookInfoCollection.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You'll learn several different approaches to applying machine learning"});
        BookInfoCollection.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm"});
        BookInfoCollection.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions"});
    }
}
{% endhighlight %}
{% endtabs %}

### Binding SelectedItem

`SfListView` supports selecting the items by binding the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem) property from the ViewModel by implementing the `INotifyPropertyChanged` interface, which gives the call back notification to the UI.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
<syncfusion:SfListView x:Name="listView" 
                       SelectedItem="{Binding SelectedItem}"
                       ItemsSource="{Binding BookInfoCollection}"/>
{% endhighlight %}
{% highlight c# %}
listView.SetBinding(SfListView.SelectedItemProperty, new Binding("SelectedItem", BindingMode.TwoWay));
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class BookInfoRepository : INotifyPropertyChanged
{
    private object selectedItem;
    public object SelectedItem
    {
        get { return this.selectedItem; }
        set
        {
            this.selectedItem = value;
            this.OnPropertyChanged("SelectedItem");
        }
    }
    public BookInfoRepository()
    {
        SelectedItem = BookInfoCollection[2];
    }
}
{% endhighlight %}
{% endtabs %}

### Binding SelectedItems

`sfListView` supports selecting multiple items by binding the [SelectedItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItems) property from the ViewModel with ObservableCollection type. Set the [SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionMode) property as `Multiple`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 3" %}
<syncfusion:SfListView x:Name="listView"
                        SelectionMode="Multiple"
                        SelectedItems="{Binding SelectedItems}"
                        ItemsSource="{Binding BookInfoCollection}"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.SelectionMode = SelectionMode.Multiple;
listView.SetBinding(SfListView.SelectedItemsProperty, new Binding("SelectedItems", BindingMode.TwoWay));
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="24 25 26" %}
public class BookInfoRepository : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private ObservableCollection<object> selectedItems;

    public ObservableCollection<object> SelectedItems
    {
        get { return this.selectedItems; }
        set
        {
            this.selectedItems = value;
            this.OnPropertyChanged("SelectedItems");
        }
    }

    public void OnPropertyChanged(string name)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    public BookInfoRepository()
    {
        SelectedItems = new ObservableCollection<object>();
        SelectedItems.Add(BookInfoCollection[1]);
        SelectedItems.Add(BookInfoCollection[2]);
    }
}
{% endhighlight %}
{% endtabs %}

### Binding SelectionChanged event

In `SfListView`, the [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged) event is raised once the selection process has been completed. MVVM for the `SelectionChanged` event can be achieved by binding the event to command converter. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6 7" %}
<syncfusion:SfListView x:Name="listView" 
                       ItemsSource="{Binding BookInfoCollection}">
    <syncfusion:SfListView.Behaviors>
        <local:EventToCommandBehavior EventName="SelectionChanged" 
        Command="{Binding SelectedItem}"
        Converter="{StaticResource EventArgs}"/> 
    </syncfusion:SfListView.Behaviors>
</syncfusion:SfListView>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="23 24 25 26 27 28" %}

public class BookInfoRepository : INotifyPropertyChanged
{
    private Command<ItemSelectionChangedEventArgs> selectedItem;

    public Command<ItemSelectionChangedEventArgs> SelectedItem
    {
        get { return this.selectedItem; }
        set
        {
            this.selectedItem = value;
            this.OnPropertyChanged("SelectedItem");
        }
    }

    public BookInfoRepository()
    {
        selectedItem = new Command<ItemSelectionChangedEventArgs>(OnSelectionChanged);
    }

    ///<summary>
    ///Remove the selected item
    ///</summary>
    public void OnSelectionChanged(ItemSelectionChangedEventArgs obj)
    {
        var eventArgs = obj as ItemSelectionChangedEventArgs;
        var item= eventArgs.AddedItems[0];
        this.bookInfoCollection.Remove(this.BookInfoCollection.FirstOrDefault(x => x == item));
    }
}
{% endhighlight %}
{% endtabs %}

### Binding SelectionChanging event

In ListView, the [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging) event will be raised when selecting an item at the execution time. MVVM for the `SelectionChanging` event can be achieved by binding the event to command converter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6 7" %}
<syncfusion:SfListView x:Name="listView" 
                       ItemsSource="{Binding BookInfoCollection}">
    <syncfusion:SfListView.Behaviors>
        <local:EventToCommandBehavior EventName="SelectionChanging" 
        Command="{Binding SelectedItem}" 
        Converter="{StaticResource EventArgs}"/>
    </syncfusion:SfListView.Behaviors>
</syncfusion:SfListView>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="23 24 25 26 27 28" %}
public class BookInfoRepository : INotifyPropertyChanged
{
    private Command<ItemSelectionChangingEventArgs> selectedItem;

    public Command<ItemSelectionChangingEventArgs> SelectedItem
    {
        get { return this.selectedItem; }
        set
        {
            this.selectedItem = value;
            this.OnPropertyChanged("SelectedItem");
        }
    }

    public BookInfoRepository()
    {
        selectedItem = new Command<ItemSelectionChangingEventArgs>(OnSelectionChanging);
    }

    ///<summary>
    ///To disable the selection for particular item
    ///</summary>
    public void OnSelectionChanging(ItemSelectionChangingEventArgs obj)
    {
        var eventArgs = obj as ItemSelectionChangingEventArgs;
        if (eventArgs.AddedItems.Count > 0 && eventArgs.AddedItems[0] == this.BookInfoCollection[0])
            eventArgs.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}


N> Similarly, you can bind the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped), [ItemDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped), and [ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress) event.

### Handling ItemTapped action

`SfListView` supports binding the [TapCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommand) property with the item taped action from the ViewModel, where you can write navigation or any other action code in the execution. When defining the command, [ItemTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html) will be passed as command parameter that contains item information during execution. 

You can define the command parameter for `TapCommand` using [TappedCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommandParameter), where you can get the element reference passed in ViewModel.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
<syncfusion:SfListView x:Name="listView" 
                    TapCommand="{Binding TapCommand}"
                    ItemsSource="{Binding BookInfoCollection}"/>
{% endhighlight %}
{% highlight c# %}
listView.SetBinding(SfListView.TapCommandProperty, new Binding("TapCommand", BindingMode.OneWay));
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="19 20 21 22 23 24 25" %}
public class BookInfoRepository : INotifyPropertyChanged
{
    private Command tapCommand;

    public Command TapCommand
    {
        get { return tapCommand; }
        protected set { tapCommand = value; }
    }

    public BookInfoRepository()
    {
        tapCommand = new Command(OnItemTapped);
    }

    ///<summary>
    ///To display tapped item content
    ///</summary>
    public void OnItemTapped(object obj)
    {
        var eventArgs = obj as Syncfusion.Maui.ListView.ItemTappedEventArgs;
        var bookName = (eventArgs.DataItem as BookInfo).BookName;
        var bookDescription = (eventArgs.DataItem as BookInfo).BookDescription;
        var display = Application.Current.MainPage.DisplayAlert(bookName, "Description:" + bookDescription, "Ok");
    }
}
{% endhighlight %}
{% endtabs %}

### Handling ItemLongPress action

`SfListView` supports binding the [LongPressCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommand) property with the item holding action from the ViewModel, where you can write navigation or any other action code in the execution. When defining the command, [ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html) will be passed as command parameter that contains item information in execution.

You can define the command parameter for the `LongPressCommand` using [LongPressCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommandParameter), where you can get the element reference passed in ViewModel.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
<syncfusion:SfListView x:Name="listView"                     
                       LongPressCommand="{Binding LongPressCommand}"
                       ItemsSource="{Binding BookInfoCollection}"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.SetBinding(SfListView.LongPressCommandProperty, new Binding("LongPressCommand", BindingMode.OneWay));
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="19 20 21 22 23" %}
public class BookInfoRepository : INotifyPropertyChanged
{
    private Command longPressCommand;

    public Command LongPressCommand
    {
        get { return longPressCommand; }
        protected set { longPressCommand = value; }
    }

    public BookInfoRepository()
    {
        longPressCommand = new Command(OnlongPress);
    }

    ///<summary>
    /// Displays the item long press content
    ///</summary>
    public void OnlongPress(object obj)
    {
        var eventArgs = obj as Syncfusion.Maui.ListView.ItemLongPressEventArgs;           
        Application.Current.MainPage.DisplayAlert("Type Of Item :" + eventArgs.ItemType, "Item Long Press Position : + " +eventArgs.Position , "Ok");
    }
}
{% endhighlight %}
{% endtabs %}

### Binding button command

The contents loaded in the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) can be bound from the ViewModel using their commands or gestures, where you can customize the loaded content or any other action code needed in the call back. When defining the command button, you will get the `BindingContext` of [ListViewItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewItem.html) as the parameter in execution. 

You can also get the reference of element bound as parameter by using command parameter of loaded elements.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 12 13" %}
<syncfusion:SfListView x:Name="listView" AutoFitMode="Height"
                SelectedItem="{Binding SelectedItem}"                      
                ItemsSource="{Binding BookInfoCollection}">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <Border Margin="5,5,5,5" >
                <Grid Padding="5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*" />
                        <RowDefinition Height="2*" />
                    </Grid.RowDefinitions>
                    <Button x:Name="bookName" Text="{Binding BookName}" Command="{Binding Path=BindingContext.BackgroundColorCommand, Source={x:Reference listView}}" CommandParameter="{x:Reference bookName}}" BackgroundColor="Transparent" FontAttributes="Bold" FontSize="19"/>
                    <Label Grid.Row="1" Text="{Binding BookDescription}" FontSize="15" />
                </Grid>
            </Border>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="10 11 12 13 14 15 16 17" %}
 listView.ItemTemplate = new DataTemplate(() =>
 {
    var border = new Border();
    border.Margin = 5;
    var grid = new Grid();
    grid.RowDefinitions.Add(new RowDefinition());
    grid.RowDefinitions.Add(new RowDefinition());
    grid.Padding = 5;
    var button = new Button();
    Binding binding = new Binding();
    binding.Path = "BookName";
    button.SetBinding(Button.TextProperty, binding);
    button.Command = this.viewModel.BackgroundColorCommand;
    button.BackgroundColor = Colors.Transparent;
    button.FontAttributes = FontAttributes.Bold;
    button.FontSize = 19;
    var label = new Label{ TextColor = Colors.Black };
    Binding bind = new Binding();
    bind.Path = "BookDescription";
    label.SetBinding(Label.TextProperty, bind);
    label.FontSize = 15;
    grid.Children.Add(button);
    grid.Children.Add(label);
    grid.SetRow(button, 0);
    grid.SetRow(label, 1);
    border.Content = grid;
    return border;
 });
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="BookInfoRepository.cs" hl_lines="19 20 21 22 23" %}
public class BookInfoRepository : INotifyPropertyChanged
{
    private Command backgroundColorCommand;

    public Command BackgroundColorCommand
    {
        get { return backgroundColorCommand; }
        protected set { backgroundColorCommand = value; }
    }

    public BookInfoRepository()
    {
        backgroundColorCommand = new Command(OnButtonTapped);
    }

    ///<summary>
    ///To display tapped item content
    ///</summary>
    public void OnButtonTapped(object obj)
    {
        var firstButton = obj as Button;
        firstButton.BackgroundColor = Colors.AliceBlue;            
    }
}
{% endhighlight %}
{% endtabs %}

### Processing LoadMore

`SfListView` supports binding the [LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreOption), [LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommand), and [IsLazyLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading) properties from ViewModel to load more number of items at runtime. `LoadMoreOption` enables load more manually or automatically the items when loading the items at runtime. `LoadMoreCommand` executes to load the items form ViewModel. The `IsLazyLoading` property notifies that the items are populating from ViewModel to show or hide the load more view. 

The `IsLazyLoading` property in ViewModel shows the busy indicator when populating the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 3 4 5" %}
<syncfusion:SfListView x:Name="listView"                            
                        LoadMoreOption="Auto"
                        LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                        LoadMoreCommandParameter="{Binding Source={x:Reference Name=listView}}"
                        IsLazyLoading="{Binding IsLazyLoading}"
                        ItemsSource="{Binding BookInfoCollection}">
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.LoadMoreOption = LoadMoreOption.Auto;
listView.SetBinding(SfListView.LoadMoreCommandProperty, new Binding("LoadMoreItemsCommand", BindingMode.OneWay));
listView.LoadMoreCommandParameter = listView;
listView.SetBinding(SfListView.IsLazyLoadingProperty, new Binding("isLazyLoading", BindingMode.OneWay));
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
public class ViewModel:INotifyPropertyChanged
{
    private bool isLazyLoading;
    public bool IsLazyLoading
    {
        get { return isLazyLoading; }
        set
        {
            this.isLazyLoading = value;
            RaisePropertyChanged("IsLazyLoading");
        }
    }
    private int totalItems = 22;
    public Command<object> LoadMoreItemsCommand { get; set; }

    public ViewModel()
    {
        BookInfoCollection = new ObservableCollection<BookInfo>();
        AddBookInfos(0, 3);
        LoadMoreItemsCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);
    }

    private bool CanLoadMoreItems(object obj)
    {
        if (BookInfoCollection.Count >= totalItems)
            return false;
        return true;
    }

    private async void LoadMoreItems(object obj)
    {
        var listview = obj as Syncfusion.Maui.ListView.SfListView;
        try
        {
            IsLazyLoading = true;

            await Task.Delay(1000);

            var index = BookInfoCollection.Count;
            var count = index + 3 >= totalItems ? totalItems - index : 3;
            AddBookInfos(index, 3);

        }
        catch
        {

        }
        finally
        {
            IsLazyLoading = false;
        }
    }

    private void AddBookInfos(int index, int count)
    {
        int bookNameCount = 0;
        int bookDescriptionCount = 0;
        for (int i = index; i < index + count; i++)
        {
            if (bookNameCount == 11)
                bookNameCount = 0;
            if (bookDescriptionCount == 11)
                bookDescriptionCount = 0;
            BookInfoCollection.Add(new BookInfo() { BookName = bookNames[bookNameCount] , BookDescription =  bookDescription[bookDescriptionCount] });
            bookNameCount++;
            bookDescriptionCount++;
        }
    }
}
{% endhighlight %}
{% endtabs %}

## See also 

[How to filter the items in .NET MAUI ListView (SfListView) using MVVM](https://support.syncfusion.com/kb/article/11354/how-to-filter-the-items-in-net-maui-listview-sflistview-using-mvvm)                                                                                                            
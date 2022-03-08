---
layout: post
title: Appearance in .NET MAUI ListView control | Syncfusion
description: Learn here all about Appearance support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Appearance in .NET MAUI ListView (SfListView)

The `SfListView` allows customizing the appearance of the underlying data, and provides different functionalities to the end-user.

## Item template

A template can be used to present the data in a way that makes sense for the application by using different controls. `SfListView` allows customizing the appearance of the view by setting the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) property.

## Data template selector

The `SfListView` allows customizing the appearance of each item with different templates based on specific constraints by using the `DataTemplateSelector`. You can choose a `DataTemplate` for each item at runtime based on the value of data-bound property using `DataTemplateSelector`.

Here, an [ItemsCacheLimit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html#Syncfusion_Maui_ListView_ListViewLayout_ItemsCacheLimit) property is used to maintain the number of items that can be reused in the view. This cache limit is used to create and reuse the [ListViewItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewItem.html) if different templates are used in `DataTemplateSelector` for better scrolling performance. Based on this value,. Based on this value, `SfListView` creates a number of `ListViewItem` for different templates in the view, if a new template is created while scrolling, and reuses them, if the same template is used to improve the scrolling performance.

### Create a data template selector

Create a custom class that inherits from `DataTemplateSelector`, and override the `OnSelectTemplate` method to return the `DataTemplate` for that item. At runtime, the SfListView invokes the `OnSelectTemplate` method for each item and passes the data object as parameter.

{% tabs %}
{% highlight c# %}

class MyDataTemplateSelector : DataTemplateSelector
{

   private readonly DataTemplate incomingDataTemplate;
   private readonly DataTemplate outgoingDataTemplate;

   public MyDataTemplateSelector()
   {
      this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
      this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));      
   }

   protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
   {
      var message = item as Message;
      if (message == null)
         return null;
      return message.IsIncoming ? this.incomingDataTemplate : this.outgoingDataTemplate;
   }

}

{% endhighlight %}
{% endtabs %}

### Applying the data template selector

Assign custom `DataTemplateSelector` to the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) of the `SfListView` in XAML or C#.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="DataTemplateSelector.MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:local="clr-namespace:DataTemplateSelector;assembly=DataTemplateSelector">
  <ContentPage.Resources>
    <ResourceDictionary>
      <local:MyDataTemplateSelector x:Key="MessageTemplateSelector" />
    </ResourceDictionary>
  </ContentPage.Resources>
  <Grid>
    <syncfusion:SfListView x:Name="ListView"
                           ItemTemplate="{StaticResource MessageTemplateSelector}"
                           ItemsSource="{Binding Messages}"
                           ItemSize="100">
    </syncfusion:SfListView>
  </Grid>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public class MainPageCs : ContentPage
{
   public MainPageCs()
   {
      var viewModel = new MainPageViewModel();
      BindingContext = viewModel;
      Content = new SfListView()
      {
          ItemSize = 100,
          ItemsSource = viewModel.Messages,
          ItemTemplate = new MyDataTemplateSelector()
      };
   }
}
{% endhighlight %}
{% endtabs %}

## Horizontal ListView

The SfListView allows you to layout every item in the [SfListView.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource) property either in `Vertical` or `Horizontal` orientation by setting the [SfListView.Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Orientation). The default orientation is `Vertical`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" Orientation="Horizontal" />
{% endhighlight %}
{% highlight c# %}
listView.Orientation = Orientation.Horizontal;
{% endhighlight %}
{% endtabs %}

### Navigate across views (like TabView)

The `SfListView` allows you to layout the items like `TabView` in the horizontal direction by setting the [Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Orientation) property as `Horizontal` using the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event. It brings any desired view above the horizontal list as follows.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Content>
        <Grid x:Name="GridView">
            <Label Text="Tap image to expand"/>
            <Grid>
                <Image Source="{Binding ContactImage}" />
                <Label Text="{Binding ContactName}" />
                <Label Text="{Binding ContactNumber}" />
            </Grid>
            <syncfusion:SfListView x:Name="listView" ItemTapped="list_ItemTapped" ItemSize="70" ItemsSource="{Binding ContactsInfo}">
                <syncfusion:SfListView.ItemTemplate>
                    <DataTemplate x:Name="ItemTemplate"  x:Key="ItemTemplate" >
                        <ViewCell>
                            <ViewCell.View>
                                    <Image Source="{Binding ContactImage}" />
                            </ViewCell.View>
                        </ViewCell>
                    </DataTemplate>
                </syncfusion:SfListView.ItemTemplate>
            </syncfusion:SfListView>
        </Grid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        list.BindingContext = new ContactsViewModel();

        var grid = new Grid();
        var label = new Label();
        label.Text = "Tap image to expand";
        var grid1 = new Grid();
        var image = new Image();
        image.SetBinding(Image.SourceProperty, new Binding("ContactImage"));
        var label1 = new Label();
        label.SetBinding(Label.TextProperty, new Binding("ContactName"));
        var label2 = new Label();
        label1.SetBinding(Label.TextProperty, new Binding("ContactNumber"));
        grid1.Children.Add(image);
        grid1.Children.Add(label1);
        grid1.Children.Add(label2);

        var listView = new SfListView();
        ContactsViewModel contactsViewModel = new ContactsViewModel();
        listView.ItemsSource = contactsViewModel.ContactsInfo;
        listView.ItemSize = 70;
        listView.ItemTapped += ListView_ItemTapped;
        listView.ItemTemplate = new DataTemplate(() =>
        {
            var viewCell = new ViewCell();
            var image1 = new Image();
            image1.SetBinding(Image.SourceProperty, new Binding("ContactImage"));
            viewCell.View = image1;
            return viewCell;
        });

        grid.Children.Add(label);
        grid.Children.Add(grid1);
        grid.Children.Add(listView);

    }

    private void ListView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
    {
            GridView.BindingContext = e.ItemData;
    }
}
{% endhighlight %}
{% endtabs %}

## Horizontal list inside vertical list

The `SfListView` allows you to layout the items in a horizontal list within a vertical list. You can load the nested `SfListView` by customizing the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) of outer `SfListView`. 

You should either define the size for each inner `SfListView` or set the [AutoFitMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitModeProperty) of the inner SfListView to `Height`, and define the [ItemSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSize) for outer `SfListView`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <ContentPage.BindingContext>
    <local:ListViewModel x:Name="viewModel"/>
  </ContentPage.BindingContext>
    <Grid>
        <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding OuterList}" ItemSize="100">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Grid>
                        <Label Text="{Binding Label}" />
                        <syncfusion:SfListView ItemsSource="{Binding InnerList}" ItemSize="100" Orientation="Horizontal">
                            <syncfusion:SfListView.ItemTemplate>
                                <DataTemplate>
                                    <Grid>
                                        <Image Source="{Binding Image}"/>
                                    </Grid>
                                </DataTemplate>
                            </syncfusion:SfListView.ItemTemplate>
                        </syncfusion:SfListView>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
    </Grid>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var grid = new Grid();
        var label1 = new Label();
        label1.SetBinding(Label.TextProperty, new Binding("Label"));
        var listView = new SfListView();
        listView.ItemsSource = OuterList;
        listView.ItemSize = 100;
        listView.ItemTemplate = new DataTemplate(() =>
        {
            var InnerListView = new SfListView();
            InnerListView.ItemSize = 100;
            InnerListView.ItemsSource = InnerList;
            InnerListView.Orientation = ItemsLayoutOrientation.Horizontal;
            listView.ItemTemplate = new DataTemplate(() =>
            {
                var grid1 = new Grid();
                var image = new Image();
                image.SetBinding(Image.SourceProperty, new Binding("Image"));
                grid1.Children.Add(image);
            }
            
            return InnerListView;
        });

        grid.Children.Add(label1);
        grid.Children.Add(listView);
    }

}
{% endhighlight %}
{% endtabs %}

## Item size

The `SfListView` allows customizing the size of items by setting the [ItemSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSize) property. The default value of this property is `48d`. This property can be customized at runtime.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" ItemSize="60" />
{% endhighlight %}
{% highlight c# %}
listView.ItemSize = 60;
{% endhighlight %}
{% endtabs %}

## Item spacing

The `SfListView` allows specifying space between each item in the list by setting the [ItemSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSpacing) property. Generate the space around the item. The default value of this property is `0`. This property can be customized at runtime.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" ItemSpacing="5,0,0,0" />
{% endhighlight %}
{% highlight c# %}
listView.ItemSpacing = new Thickness(5, 0, 0, 0)
{% endhighlight %}
{% endtabs %}

## Alternate row styling

The `SfListView` allows applying alternate row styling for items by using the `IValueConverter` to find the index of the underlying object.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:IndexToColorConverter x:Key="IndexToColorConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.Content>
        <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding Items}" ItemSize="50">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Grid BackgroundColor="{Binding .,Converter={StaticResource IndexToColorConverter},ConverterParameter={x:Reference Name=listView}}">
                        <Label Text="{Binding ContactName}" />
                        <Label Text="{Binding ContactNumber}" />
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        ContactsViewModel viewModel = new ContactsViewModel();
        var listView = new SfListView();
        listView.ItemsSource = viewModel.Items;
        listView.ItemSize = 50;
        listView.ItemTemplate = new DataTemplate(() =>
        {
            var grid = new Grid();
            var label1 = new Label();
            label1.SetBinding(Label.TextProperty, new Binding("ContactName"));
            var label2 = new Label();
            label2.SetBinding(Label.TextProperty, new Binding("ContactNumber"));
            grid.SetBinding(Grid.BackgroundColorProperty, new Binding(".", BindingMode.Default, new IndexToColorConverter(), listView));

            return grid;
        });
    }
}
{% endhighlight %}
{% endtabs %}

{% highlight c# %}
public class IndexToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var listview = parameter as SfListView;
        var index = listview.DataSource.DisplayItems.IndexOf(value);

        if (index % 2 == 0)
            return Color.LightGray;
        return Color.Aquamarine;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
    }
}
{% endhighlight %}

## Rounded corner on items

The `SfListView` allows customizing the item appearance, such as rounded corners, by using the `Frame` layout in the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) property. By defining the `CornerRadius` property of frame layout, you can perform rounded corner for items. 

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
    <ContentPage.Content>
        <syncfusion:SfListView x:Name="listView" ItemSize="60" ItemsSource="{Binding customerDetails}">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Frame x:Name="frame" CornerRadius="10" HasShadow="False">
                        <StackLayout>
                            <Label Text="{Binding ContactName}" />
                            <Label Text="{Binding ContactNumber}" />
                            <Label Text="{Binding ContactType}" />
                        </StackLayout>
                    </Frame>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var listView = new SfListView();
        listView.ItemsSource = customerDetails;
        listView.ItemSize = 60;
        listView.ItemTemplate = new DataTemplate(() =>
        {
            var frame = new Frame();
            frame.CornerRadius = 10;
            var stackLayout = new StackLayout();
            var label1 = new Label();
            label.SetBinding(Label.TextProperty, new Binding("ContactName"));
            var label2 = new Label();
            label.SetBinding(Label.TextProperty, new Binding("ContactName"));
            var label3 = new Label();
            label1.SetBinding(Label.TextProperty, new Binding("ContactType"));
            stackLayout.Children.Add(label1);
            stackLayout.Children.Add(label2);
            stackLayout.Children.Add(label3);
            frame.Children.Add(stackLayout);

            return frame;
        });
    }
}
{% endhighlight %}
{% endtabs %}

## Drop shadow effect on items

The `SfListView` allows customizing the item appearance like shadow effect for items by setting the shadow property of frame as true in [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) property.

N> Define the frame within any view inside `ItemTemplate` with some margin around it. 

{% tabs %}
{% highlight xaml %}
<ContentPage  xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
    <ContentPage.Content>
        <syncfusion:SfListView x:Name="listView" ItemSize="60" ItemsSource="{Binding customerDetails}">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Grid Padding="2" Margin="2" >
                        <Frame x:Name="frame" HasShadow="True" Padding="2" Margin="2">
                            <StackLayout>
                                <Label Text="{Binding ContactName}" /> 
                                <Label Text="{Binding ContactNumber}" />
                                <Label Text="{Binding ContactType}" />
                            </StackLayout>
                        </Frame>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var listView = new SfListView();
        listView.ItemsSource = customerDetails;
        listView.ItemSize = 60;
        listView.ItemTemplate = new DataTemplate(() =>
        {
            var grid = new Grid();
            grid.Padding = 2;
            grid.Margin = 2;
            var frame = new Frame();
            frame.Padding = 2;
            frame.Margin = 2;
            frame.HasShadow = "True";
            var stackLayout = new StackLayout();
            var label1 = new Label();
            label.SetBinding(Label.TextProperty, new Binding("ContactName"));
            var label2 = new Label();
            label.SetBinding(Label.TextProperty, new Binding("ContactName"));
            var label3 = new Label();
            label1.SetBinding(Label.TextProperty, new Binding("ContactType"));
            stackLayout.Children.Add(label1);
            stackLayout.Children.Add(label2);
            stackLayout.Children.Add(label3);
            frame.Children.Add(stackLayout);
            grid.Children.Add(frame);

            return grid;
        });
    }
}
{% endhighlight %}
{% endtabs %}

## ListViewItem customization

The `SfListView` allows customizing the [ListViewItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewItem.html) based on the [ItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemType.html). Follow the code example to customize the Header, Footer, GroupHeader, LoadMore, and ListViewItem.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.listView.ItemGenerator = new ItemGeneratorExt(this.listView);
    }
}
{% endhighlight %}
{% endtabs %}

### Extension class for ItemGenerator

{% tabs %}
{% highlight c# %}
public class ItemGeneratorExt : ItemGenerator
{
    public SfListView listView;
	
    public ItemGeneratorExt(SfListView listView) : base(listView)
    {
        this.listView = listView;
    }

    protected override ListViewItem OnCreateListViewItem(int itemIndex, ItemType type, object data = null)
    {
        if (type == ItemType.Header)
            return new HeaderItemExt(this.listView);
        else if (type == ItemType.Footer)
            return new FooterItemExt(this.listView);
        else if (type == ItemType.GroupHeader)
            return new GroupHeaderItemExt(this.listView);
        else if (type == ItemType.LoadMore)
            return new LoadMoreItemExt(this.listView);
        else if (type == ItemType.Record)
            return new ListViewItemExt(this.listView);
        return base.OnCreateListViewItem(itemIndex, type, data);
    }
}
{% endhighlight %}
{% endtabs %}

### Extension class for HeaderItem

{% tabs %}
{% highlight c# %}
public class HeaderItemExt : HeaderItem
{
    private SfListView listView;

    public HeaderItemExt(SfListView listView)
    {
        this.listView = listView
    }

    protected override void OnItemAppearing()
    {
        base.OnItemAppearing();
        this.BackgroundColor = Color.Yellow;
    }
}
{% endhighlight %}
{% endtabs %}

### Extension class for FooterItem

{% tabs %}
{% highlight c# %}
public class FooterItemExt : FooterItem
{
    private SfListView listView;

    public FooterItemExt(SfListView listView)
    {
        this.listView = listView
    }

    protected override void OnItemAppearing()
    {
        base.OnItemAppearing();
        this.BackgroundColor = Color.Yellow;
    }
}
{% endhighlight %}
{% endtabs %}

### Extension class for GroupHeaderItem

{% tabs %}
{% highlight c# %}
public class GroupHeaderItemExt : GroupHeaderItem
{
    private SfListView listView;

    public GroupHeaderItemExt(SfListView listView)
    {
        this.listView = listView
    }

    protected override void OnItemAppearing()
    {
        base.OnItemAppearing();
        this.BackgroundColor = Color.Yellow;
    }
}
{% endhighlight %}
{% endtabs %}

### Extension class for LoadMoreItem

{% tabs %}
{% highlight c# %}
public class LoadMoreItemExt : LoadMoreItem
{
    private SfListView listView;

    public LoadMoreItemExt(SfListView listView)
    {
        this.listView = listView
    }

    protected override void OnItemAppearing()
    {
        base.OnItemAppearing();
        this.BackgroundColor = Color.Yellow;
    }
}
{% endhighlight %}
{% endtabs %}

### Extension class for ListViewItem

{% tabs %}
{% highlight c# %}
public class ListViewItemExt : ListViewItem
{
    private SfListView listView;

    public ListViewItemExt(SfListView listView)
    {
        this.listView = listView
    }

    protected override void OnItemAppearing()
    {
        base.OnItemAppearing();
        this.BackgroundColor = Color.Yellow;
    }
}
{% endhighlight %}
{% endtabs %}

## Accordion view

The `SfListView` supports accordion view to display a list of items. Each item can be expanded or stretched to reveal the content associated with that item. There can be zero expanded items, exactly one item, or more than one item can be expanded at a time depending on the configuration.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
  <ContentPage.Behaviors>
    <local:SfListViewAccordionBehavior />
  </ContentPage.Behaviors>
  <ContentPage.Content>
    <Grid x:Name="mainGrid" BackgroundColor="#F0F0F0" Padding="4">
      <syncfusion:SfListView x:Name="listView" AutoFitMode="DynamicHeight" SelectionMode ="None" IsScrollBarVisible="False" ItemSpacing="0">
        <syncfusion:SfListView.ItemTemplate>
          <DataTemplate>
            <ViewCell>
              <ViewCell.View>
                <Grid Padding="2" Margin="1" BackgroundColor="#F0F0F0" >
                  <Frame x:Name="frame" CornerRadius="2" Padding="1" Margin="1" OutlineColor="White">
                    <Grid VerticalOptions="FillAndExpand" BackgroundColor="White" HorizontalOptions="FillAndExpand">
                      <Grid.RowDefinitions>
                        <RowDefinition Height="Auto" />
                      </Grid.RowDefinitions>
                      <Grid x:Name="grid" >
                        <Grid.RowDefinitions>
                          <RowDefinition Height="60" />
                        </Grid.RowDefinitions>
                        <Grid RowSpacing="0">
                          <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="60" />
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="50" />
                          </Grid.ColumnDefinitions>
                          <Image Grid.Row="0" Grid.Column="0" Source="{Binding ContactImage}" VerticalOptions="Center"/>
                          <Grid Grid.Row="0" Grid.Column="1" VerticalOptions="CenterAndExpand">
                            <Grid.RowDefinitions>
                              <RowDefinition Height="*" />
                              <RowDefinition Height="*" />
                            </Grid.RowDefinitions>
                            <Label Grid.Row="0" LineBreakMode="NoWrap" TextColor="#474747" Text="{Binding ContactName}" />
                            <Label Grid.Row="1" TextColor="#474747" LineBreakMode="NoWrap" Text="{Binding CallTime}" />
                          </Grid>
                          <Grid Grid.Row="0" Grid.Column="2" HorizontalOptions="Center" VerticalOptions="Center">
                            <Image Source="{Binding PhoneImage}" HeightRequest="20" WidthRequest="20" HorizontalOptions="Center" VerticalOptions="Center" />
                          </Grid>
                        </Grid>
                      </Grid>
                      <Grid IsVisible="{Binding IsVisible, Mode=TwoWay}" ColumnSpacing="0" RowSpacing="0" Grid.Row="1" BackgroundColor="White"
                            HorizontalOptions="FillAndExpand" Padding="5" VerticalOptions="FillAndExpand">
                        <Grid.RowDefinitions>
                          <RowDefinition Height="1" />
                          <RowDefinition Height="40" />
                          <RowDefinition Height="40" />
                          <RowDefinition Height="40" />
                          <RowDefinition Height="40" />
                          <RowDefinition Height="40" />
                        </Grid.RowDefinitions>
                        <Grid.ColumnDefinitions >
                          <ColumnDefinition Width="50" />
                          <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>
                        <BoxView Grid.Row="0" Grid.Column="0" BackgroundColor="LightGray" />
                        <Image Grid.Row="1" Grid.Column="0" Source="{Binding NewContact}"  />
                        <Image Grid.Row="2" Grid.Column="0" Source="{Binding AddContact}" />
                        <Image Grid.Row="3" Grid.Column="0" Source="{Binding SendMessage}"  />
                        <Image Grid.Row="4" Grid.Column="0" Source="{Binding BlockSpan}"  />
                        <Image Grid.Row="5" Grid.Column="0" Source="{Binding CallDetails}" />
                        <BoxView Grid.Row="0" Grid.Column="1" BackgroundColor="LightGray" />
                        <Label Grid.Row="1" Grid.Column="1" Text="Create new contact" TextColor="#000000" />
                        <Label Grid.Row="2" Grid.Column="1" Text="Add to a contact" TextColor="#000000"/>
                        <Label Grid.Row="3" Grid.Column="1" Text="Send a message" TextColor="#000000" />
                        <Label Grid.Row="4" Grid.Column="1" Text="Block/report Spam" TextColor="#000000" />
                        <Label Grid.Row="5" Grid.Column="1" Text="Call details" TextColor="#000000" />
                      </Grid>
                    </Grid>
                  </Frame>
                </Grid>
              </ViewCell.View>
            </ViewCell>
          </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
      </syncfusion:SfListView>
    </Grid>
  </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% endtabs %}

`Accordion` view can be displayed by defining two different ItemTemplates. The ItemTemplates can be enabled or disabled in the [ItemTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped) event.

{% tabs %}
{% highlight c# %}
internal class SfListViewAccordionBehavior : Behavior<ContentPage>
{
    #region Fields

    private Contact tappedItem;
    private Syncfusion.ListView.XForms.SfListView listview;
    private AccordionViewModel AccordionViewModel;

    #endregion

    #region Properties
    public SfListViewAccordionBehavior()
    {
        AccordionViewModel = new AccordionViewModel();
    }

    #endregion

    #region Override Methods

    protected override void OnAttachedTo(ContentPage bindable)
    {
        listview = bindable.FindByName<Syncfusion.ListView.XForms.SfListView>("listView");
        listview.ItemsSource = AccordionViewModel.ContactsInfo;
        listview.ItemTapped += ListView_ItemTapped;
    }

    #endregion

    #region Private Methods
    using Syncfusion.ListView.XForms.Control.Helpers;
    private void ListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
    {
        var tappedItemData = obj as Contact;
        if (tappedItem != null && tappedItem.IsVisible)
        {
            tappedItem.IsVisible = false;
        }

        if (tappedItem == tappedItemData)
        {
            tappedItem = null;
            return;
        }

        tappedItem = tappedItemData;
        tappedItem.IsVisible = true;
    }

    #endregion

    protected override void OnDetachingFrom(ContentPage bindable)
    {
        listview.ItemTapped -= ListView_ItemTapped;           
    }
}

{% endhighlight %}
{% endtabs %}

The `IsVisible` model property, which is bound to the second template, will be enabled when the item is tapped and disabled when the item is tapped again.

## Show busy indicator on list view

The `SfListView` allows displaying the `SfBusyIndicator` when loading the bounded items. The busy indicator can be enabled and disabled by using the `IsBusy` property.

Create a `IsLoading` boolean property in view model and bind it to the `IsBusy` property. By setting the value to `IsLoading` property, the busy indicator will be enabled and disabled into the view till the items loaded in the `SfListView`.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms"
             xmlns:busyIndicator="clr-namespace:Syncfusion.SfBusyIndicator.XForms;assembly=Syncfusion.SfBusyIndicator.XForms">
    <Grid>
        <syncfusion:SfListView x:Name="listView" 
                             ItemsSource="{Binding ContactInfo}" 
                             AutoFitMode="Height">
        </syncfusion:SfListView>
        <busyIndicator:SfBusyIndicator x:Name="busyIndicator" InputTransparent="True"
                                       AnimationType="SingleCircle" 
                                       IsBusy="{Binding IsLoading, Mode=TwoWay}" 
                                       TextColor="Magenta"
                                       ViewBoxWidth="50"
                                       ViewBoxHeight="50"/>
    </Grid>
</ContentPage>
{% endhighlight %}

{% highlight c# %}
public class ViewModel : INotifyPropertyChanged
{
    private bool isLoading = false;

    public bool IsLoading
    {
        get { return isLoading; }
        set
        {
            this.isLoading = value;
            OnPropertyChanged("IsLoading");
        }
    }

    private async void GenerateItems()
    {
        IsLoading = true;
        await Task.Delay(5000);
        for (int i = 0; i < 30; i++)
        {
            var contact = new Model(CustomerNames[i], ContactNumber[i]);
            ContactInfo.Add(contact);
        }
        IsLoading = false;
    }
}
{% endhighlight %}
{% endtabs %}

N> When both `SfBusyIndicator` and `SfListView` are loaded with the same row and column, you need to set `InputTransparent` as `True` to `SfBusyIndicator` in order to pass touch interaction to `SfListView` in the iOS platform.

## Show busy indicator on list view items

The `SfListView` allows displaying an activity indicator for an item when its data is being loaded in the background. To perform this, load both `ActivityIndicator` and a `Button` in the same row of a `Grid` element inside the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) of the `SfListView`. The busy indicator and button can be enabled and disabled by using the `IsButtonVisible` and `IsIndicatorVisible` properties respectively in the model class.

{% tabs %}
{% highlight c# %}
public class BookInfo : INotifyPropertyChanged
{
    private string bookName;
    private string bookDescription;
    public bool isDescriptionVisible;
    public bool isButtonVisible;
    public bool isIndicatorVisible;

    public BookInfo()
    {
    }

    public string BookName
    {
        get { return bookName; }
        set
        {
            bookName = value;
            OnPropertyChanged("BookName");
        }
    }

    public bool IsDescriptionVisible
    {
        get { return isDescriptionVisible; }
        set
        {
            isDescriptionVisible = value;
            OnPropertyChanged("IsDescriptionVisible");
        }
    }

    public string BookDescription
    {
        get { return bookDescription; }
        set
        {
            bookDescription = value;
            OnPropertyChanged("BookDescription");
        }
    }

    public bool IsButtonVisible
    {
        get { return isButtonVisible; }
        set
        {
            isButtonVisible = value;
            OnPropertyChanged("IsButtonVisible");
        }
    }

    public bool IsIndicatorVisible
    {
        get { return isIndicatorVisible; }
        set
        {
            isIndicatorVisible = value;
            OnPropertyChanged("IsIndicatorVisible");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}
{% endhighlight %}
{% endtabs %}

Initially, disable the visibility of description and  `ActivityIndicator` when adding items to a collection.

{% tabs %}
{% highlight c# %}
public class BookInfoRepository : INotifyPropertyChanged
{
    private ObservableCollection<BookInfo> newBookInfo;
    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<BookInfo> NewBookInfo
    {
        get { return newBookInfo; }
        set { this.newBookInfo = value; }
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
        NewBookInfo = new ObservableCollection<BookInfo>();
        NewBookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning", IsIndicatorVisible = false, IsButtonVisible = true, IsDescriptionVisible = false });
        NewBookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm", IsIndicatorVisible = false, IsButtonVisible = true, IsDescriptionVisible = false });
        NewBookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions", IsIndicatorVisible = false, IsButtonVisible = true, IsDescriptionVisible = false });
    }
}
{% endhighlight %}
{% endtabs %}

Bind the bool values for the `IsVisible` properties to switch between indicator and button while loading the description.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">  
    <ContentPage.BindingContext>
        <local:BookInfoRepository x:Name="ViewModel" />
    </ContentPage.BindingContext>
    <sync:SfListView x:Name="listView" AutoFitMode="Height" BackgroundColor="#d3d3d3" SelectionMode="None" ItemsSource="{Binding NewBookInfo}">
        <sync:SfListView.ItemTemplate>
            <DataTemplate>
                <Frame HasShadow="True" Margin="5,5,5,0">
                <Grid Padding="5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*" />
                        <RowDefinition Height="2*" />
                    </Grid.RowDefinitions>
                    <Label Text="{Binding BookName}" FontAttributes="Bold" FontSize="19" />
                    <Button Grid.Row="1" Clicked="Button_Clicked" Text="Load Description" IsVisible="{Binding IsButtonVisible}" HorizontalOptions="Center" VerticalOptions="Center"/>
                    <Label Grid.Row="1" Text="{Binding BookDescription}" FontSize="15" IsVisible="{Binding IsDescriptionVisible}" />
                    <ActivityIndicator Grid.Row="1" IsEnabled="True" IsRunning="True" IsVisible="{Binding IsIndicatorVisible}" />
                </Grid>
                </Frame>
            </DataTemplate>
        </sync:SfListView.ItemTemplate>
    </sync:SfListView>
</ContentPage>
{% endhighlight %}
{% endtabs %}

In the `Clicked` event of the button, get the row data from its `BindingContext` and alter the bool values accordingly.

{% tabs %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var model = ((sender as Button).BindingContext as BookInfo);
        model.IsIndicatorVisible = true;
        model.IsButtonVisible = false;
        await Task.Delay(2000);
        model.IsDescriptionVisible = true;
        model.IsIndicatorVisible = false;
    }
}

{% endhighlight %}
{% endtabs %}

## Show busy indicator on list view items using toggle switch

The `SfListView` allows to display `ActivityIndicator` for an item when loading its data in the background. To do this, load both `ActivityIndicator` and a toggle switch in the same row of a `Grid` element inside the `ItemTemplate` of `SfListView`. The busy indicator and toggle switch can be enabled and disabled by using the `IsButtonVisible` and `IsIndicatorVisible` properties respectively in the model class. The `ActivityIndicator` remains visible when the toggle switch is enabled. 

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
    <ContentPage.BindingContext>
        <local:ContactInfoRepository x:Name="ViewModel" />
    </ContentPage.BindingContext>
    <syncfusion:SfListView x:Name="listView" AutoFitMode="Height" BackgroundColor="#d3d3d3" SelectionMode="None" ItemsSource="{Binding NewContactInfo}">
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <Frame HasShadow="True" Margin="5,5,5,0">
                <Grid Padding="5">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*" />
                        <RowDefinition Height="*" />
                    </Grid.RowDefinitions>
                    <Label Text="{Binding ContactName}" FontAttributes="Bold" FontSize="19" />
                  <Switch Grid.Row="1" Grid.Column="1" IsVisible="{Binding IsButtonVisible}" IsToggled="{Binding IsChecked}" Toggled="Switch_Toggled"/>

                  <Label Grid.Row="1" Text="{Binding ContactNo}" FontSize="15" IsVisible="{Binding IsDescriptionVisible}" />
                    <ActivityIndicator Grid.Row="1" IsEnabled="True" IsRunning="True" IsVisible="{Binding IsIndicatorVisible}" />
                </Grid>
                </Frame>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% endtabs %}

In the `Toggled` event of the switch, get the row data from its `BindingContext` and alter the Bool values accordingly. 

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
  private Random random = new Random();
  public MainPage()
  {
     InitializeComponent();
  }

  private async void Switch_Toggled(object sender, ToggledEventArgs e)
  {
    var model = ((sender as Switch).BindingContext as ContactInfo);
    if (model.IsChecked == true)
    {
        model.ContactNo = random.Next(100, 400).ToString() + "-" + random.Next(500, 800).ToString() + "-" + random.Next(1000, 2000).ToString();
        model.IsDescriptionVisible = false;
        model.IsIndicatorVisible = true;
        await Task.Delay(2000);
        model.IsDescriptionVisible = true;
        model.IsIndicatorVisible = false;
        model.IsChecked = false;
    }
    else
    {
        model.IsIndicatorVisible = false;
    }
  }
}
{% endhighlight %}
{% endtabs %}

## Item animation on appearing

The `SfListView` supports animating the items by using an [OnItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewItem.html#Syncfusion_Maui_ListView_ListViewItem_OnItemAppearing) virtual method. It is raised when the items appearing in the view on scrolling, loading, and navigating from one page to another page. To apply the animation effect for items, follow these steps:

### Extension of ItemGenerator

{% tabs %}
{% highlight c# %}

public class ItemGeneratorExt : ItemGenerator
{
    public SfListView listView;
	
    public ItemGeneratorExt(SfListView listView) : base(listView)
    {
        this.listView = listView;
    }

    protected override ListViewItem OnCreateListViewItem(int itemIndex, ItemType type, object data = null)
    {
        if (type == ItemType.Record)
            return new ListViewItemExt(this.listView);
        return base.OnCreateListViewItem(itemIndex, type, data);
    }
}

{% endhighlight %}
{% endtabs %}

Initialize and assign ItemGenerator extension to ListView

{% tabs %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.listView.ItemGenerator = new ItemGeneratorExt(this.listView);
    }
}

{% endhighlight %}
{% endtabs %}

### Extension of ListViewItem
 
To apply the animation for items while appearing, override the [OnItemAppearing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewItem.html#Syncfusion_Maui_ListView_ListViewItem_OnItemAppearing) method.

{% tabs %}
{% highlight c# %}

public class ListViewItemExt : ListViewItem
{
    private SfListView listView;

    public ListViewItemExt(SfListView listView)
    {
        this.listView = listView;
    }

    protected override void OnItemAppearing()
    {
        this.Opacity = 0;
        this.FadeTo(1, 400, Easing.SinInOut);
        base.OnItemAppearing();
    }
}

{% endhighlight %}
{% endtabs %}

Here `FadeTo` animation is applied for [ListViewItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewItem.html), when comes in the view. 

### Right to left(RTL)

`SfListView` supports to change the flow of text to the right-to-left direction by setting the `FlowDirection` property. 
{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
  <syncfusion:SfListView x:Name="listView"
                 ItemsSource="{Binding Products}"
                 FlowDirection="RightToLeft"/>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
this.FlowDirection = FlowDirection.RightToLeft;
{% endhighlight %}
{% endtabs %}

In UWP platform, the `ScrollView` is not changed when RTL is enabled (framework issue). To overcome this issue, set the `FlowDirection` property in constructor of `MainPage` in UWP renderer as demonstrated in the following code example.

{% tabs %}
{% highlight c# %}
public MainPage()
{
    …
    SfListViewRenderer.Init();
    this.FlowDirection = FlowDirection.RightToLeft;
    LoadApplication (new App ());
    …
}
{% endhighlight %} 
{% endtabs %}

N> When a label is loaded in the `ItemTemplate`, the right-to-left direction is not applied due to the framework issue. It has been reported to the Xamarin team; for more details about this, refer to this [link](https://github.com/xamarin/Xamarin.Forms/issues/3611). To overcome this issue, set the `HorizontalOptions` to `StartAndExpand` in Label.

### Limitations

* `SfListView` does not support the right-to-left(RTL) direction when `SfListView.Orientation` is `Horizontal`.


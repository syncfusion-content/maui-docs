---
layout: post
title: Header and Footer in .NET MAUI ListView control | Syncfusion
description: Learn here all about Header and Footer support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Header and Footer in .NET MAUI ListView (SfListView)

This section explains how to define and customize the header and footer in the SfListView.

## Header and footer customization

The 'SfListView' allows adding and customizing appearance of the header and footer by setting the `SfListView.HeaderTemplate` and `SfListView.FooterTemplate` properties.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <syncfusion:SfListView x:Name="listView"
                    ItemsSource="{Binding BookInfo}"
                    ItemSize="100">
        <syncfusion:SfListView.HeaderTemplate>
            <DataTemplate>
            <Grid BackgroundColor="Blue" HeightRequest="45">
                <Label LineBreakMode="NoWrap"
                    Margin="10,0,0,0" Text="Book Information" FontAttributes="Bold"
                    FontSize="18" TextColor="White" HorizontalOptions="Center"
                    VerticalOptions="Center"/>
            </Grid>
            </DataTemplate>
        </syncfusion:SfListView.HeaderTemplate>
    </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
viewModel = new ViewModel ();
listView = new SfListView();
listView.ItemsSource = viewModel.BookInfo;
listView.HeaderTemplate = new DataTemplate(() =>
{
   var grid = new Grid();
   grid.BackgroundColor = Colors.Blue;
   var headerLabel = new Label
   {
       TextColor = Colors.White,
       FontSize = 18,
       FontAttributes = FontAttributes.Bold,
       Text = "Book Information"
   };

   grid.Children.Add(headerLabel);

   return grid;
});
{% endhighlight %}
{% endtabs %}

## Header and footer items appearance

The `SfListView` allows customizing size of the header and footer items by setting the `SfListView.HeaderSize` and SfListView.FooterSize` properties. The default value is 40. These properties can be customized at runtime.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" HeaderSize="70" FooterSize="60" />
{% endhighlight %}
{% highlight c# %}
listView.HeaderSize = 70;
listView.FooterSize = 60;
{% endhighlight %}
{% endtabs %}

N> For vertical orientation, the header and footer size are considered as height. For horizontal orientation, that will be considered as width.

## Sticky header and footer

The `SfListView` allows sticking the header and footer items to view by enabling the `SfListView.IsStickyHeader` and `SfListView.IsStickyFooter` properties. If the `SfListView.IsStickyHeader` is `true`, the header item will stick to the top of the view. If the `SfListView.IsStickyFooter` is `true`, the footer item will stick to the bottom of the view.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" IsStickyHeader="True" 
                     IsStickyFooter="True" />          
{% endhighlight %}
{% highlight c# %}
listView.IsStickyHeader = true;
listView.IsStickyFooter = true;
{% endhighlight %}
{% endtabs %}

## Sticky footer position

The `SfListView` allows to position the footer item by using the `StickyFooterPosition` property. 

The `StickyFooterPosition` property has two options:

* `Body`: The footer item will be positioned inside the body of the ListView when the items are less than the view size.
* `Default`: The footer item will be positioned at the bottom of the ListView.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfListView x:Name="listView" StickyFooterPosition="Body"/>          
{% endhighlight %}
{% highlight c# %}
listView.StickyFooterPosition = FooterPosition.Body;
{% endhighlight %}
{% endtabs %}

## How to

### TabView appearance using listview header

The `SfListView` allows performing tab view structure by customizing the `HeaderTemplate` to load any view.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.BindingContext>
        <local:BookInfoRepository />
    </ContentPage.BindingContext>
    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="template">
                <ViewCell>
                    <ViewCell.View>
                        <Grid x:Name="grid" RowSpacing="0" Margin="5">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*" />
                                <RowDefinition Height="1" />
                            </Grid.RowDefinitions>
                            <Grid RowSpacing="0" Grid.Row="0">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="*" />
                                    <RowDefinition Height="*" />
                                </Grid.RowDefinitions>
                                <Label Grid.Row="0" Text="{Binding BookName}" FontAttributes="Bold" TextColor="Teal" FontSize="21" />
                                <Label Grid.Row="1" Text="{Binding BookDescription}" TextColor="Teal" FontSize="15"/>
                            </Grid>
                            <StackLayout Grid.Row="1" BackgroundColor="#E4E4E4" HeightRequest="1"/>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
    <syncfusion:SfListView x:Name="listView" IsStickyHeader="True" IsStickyFooter="True"
                               HeaderSize="80" FooterSize="60" SelectionBackgroundColor="LightBlue" 
                               ItemSize="90" SelectionMode="Single" ItemTemplate="{StaticResource template}">
        <syncfusion:SfListView.HeaderTemplate>
            <DataTemplate>
                <Grid BackgroundColor="#4CA1FE" HeightRequest="60">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="2" />
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="2" />
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="2" />
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="2" />
                    </Grid.ColumnDefinitions>
                    <Grid Grid.Column="1" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                        <Label x:Name="info" BackgroundColor="Transparent" Text="Informations" FontAttributes="Bold" FontSize="18" TextColor="White" 
                              HorizontalTextAlignment="Center" VerticalTextAlignment="Center"  />
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Tapped="InfoTapGestureRecognizerTapped" NumberOfTapsRequired="1"/>
                        </Grid.GestureRecognizers>
                    </Grid>
                    <Grid Grid.Column="3" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                        <Label x:Name="status" BackgroundColor="Transparent" Text="Status" FontAttributes="Bold" FontSize="18" TextColor="White"  
                                HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Tapped="StatusTapGestureRecognizerTapped" NumberOfTapsRequired="1"/>
                        </Grid.GestureRecognizers>
                    </Grid>
                    <Grid Grid.Column="5" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                        <Label x:Name="contacts" BackgroundColor="Transparent" Text="Contacts" FontAttributes="Bold" FontSize="18" TextColor="White" 
                               HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Tapped="ContactsTapGestureRecognizerTapped" NumberOfTapsRequired="1"/>
                        </Grid.GestureRecognizers>
                    </Grid>
                    <BoxView Grid.Column="0" BackgroundColor="White" />
                    <BoxView Grid.Column="2" BackgroundColor="White" />
                    <BoxView Grid.Column="4" BackgroundColor="White" />
                    <BoxView Grid.Column="6" BackgroundColor="White" />
                </Grid>
            </DataTemplate>
        </syncfusion:SfListView.HeaderTemplate>
    </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}

{% highlight c# %}
public partial class MainPage : ContentPage
{
    BookInfoRepository viewModel = new BookInfoRepository();
    BookInfoRepository1 viewModel1 = new BookInfoRepository1();
    EmployeeViewModel viewModel2 = new EmployeeViewModel();

    public MainPage()
    {
        InitializeComponent();
        this.listView.ItemsSource = viewModel.BookInfo;
    }

    public void InfoTapGestureRecognizerTapped(object sender, EventArgs e)
    {
        this.listView.ItemsSource = viewModel.BookInfo;
        this.listView.ItemTemplate = this.Resources["template"] as DataTemplate;
    }

    public void StatusTapGestureRecognizerTapped(object sender, EventArgs e)
    {
        this.listView.ItemsSource = viewModel1.BookInfo1;
        this.listView.ItemTemplate = this.Resources["template"] as DataTemplate;
    }

    public void ContactsTapGestureRecognizerTapped(object sender, EventArgs e)
    {
        this.listView.ItemsSource = viewModel2.EmployeeInfo;
        InitializeTemplate();
    }

    private void InitializeTemplate()
    {
        listView.ItemTemplate = new DataTemplate(() => { return CreateItemTemplate(); });
        listView.ItemSize = 70;
        listView.GroupHeaderSize = 60;
        listView.IsStickyGroupHeader = true;
        listView.AllowGroupExpandCollapse = true;
        listView.ItemSpacing = new Thickness(0, 0, 5, 0);
        listView.IsStickyHeader = true;
        listView.GroupHeaderTemplate = new DataTemplate(() =>
        {
            var grid = new Grid { BackgroundColor = Color.FromHex("#E4E4E4") };
            var label = new Label
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 22,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start,
                Margin = new Thickness(20, 0, 0, 0),
            };
            label.SetBinding(Label.TextProperty, new Binding("Key"));
            grid.Children.Add(label);
            return grid;
        });
    }

    private Grid CreateItemTemplate()
    {
        var gridView = new Grid();
        gridView.RowSpacing = 1;
        var row0 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
        var row1 = new RowDefinition { Height = 1 };
        gridView.RowDefinitions.Add(row0);
        gridView.RowDefinitions.Add(row1);

        var grid = new Grid();

        var column0 = new ColumnDefinition { Width = 50 };
        var column1 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
        var column2 = new ColumnDefinition { Width = 70 };
        grid.ColumnDefinitions.Add(column0);
        grid.ColumnDefinitions.Add(column1);
        grid.ColumnDefinitions.Add(column2);

        var contactImage = new Image();
        contactImage.SetBinding(Image.SourceProperty, new Binding("EmployeeImage"));
        contactImage.HeightRequest = 50;
        contactImage.VerticalOptions = LayoutOptions.Center;
        contactImage.HorizontalOptions = LayoutOptions.Center;

        var gridView = new Grid();

        gridView.RowSpacing = 1;
        gridView.Padding = new Thickness(10, 0, 0, 0);
        gridView.VerticalOptions = LayoutOptions.Center;
        var rowdefinition0 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
        var rowdefinition1 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
        gridView.RowDefinitions.Add(rowdefinition0);
        gridView.RowDefinitions.Add(rowdefinition1);

        var contactName = new Label();
        contactName.SetBinding(Label.TextProperty, new Binding("EmployeeName"));
        contactName.LineBreakMode = LineBreakMode.NoWrap;
        contactName.TextColor = Color.FromHex("#474747");
        contactName.FontSize = 20;

        var contactNumber = new Label();
        contactNumber.FontAttributes = FontAttributes.None;
        contactNumber.FontSize = 18;
        contactNumber.LineBreakMode = LineBreakMode.NoWrap;
        contactNumber.SetBinding(Label.TextProperty, new Binding("ContactNumber"));
        contactNumber.TextColor = Color.FromHex("#474747");

        var contactType = new Label();
        contactType.Margin = new Thickness(5);
        contactType.FontAttributes = FontAttributes.None;
        contactType.LineBreakMode = LineBreakMode.NoWrap;
        contactType.VerticalOptions = LayoutOptions.End;
        contactType.VerticalTextAlignment = TextAlignment.End;
        contactType.HorizontalOptions = LayoutOptions.End;
        contactType.SetBinding(Label.TextProperty, new Binding("Designation"));
        contactType.TextColor = Color.FromHex("#474747");
        contactType.FontSize = 12;

        var stackLayout = new StackLayout();
        stackLayout.HeightRequest = 1;
        stackLayout.BackgroundColor = Color.Gray;

        gridView.Children.Add(contactName, 0, 0);
        gridView.Children.Add(contactNumber, 0, 1);

        grid.Children.Add(contactImage);
        grid.Children.Add(gridView, 1, 0);

        gridView.Children.Add(grid);
        gridView.Children.Add(stackLayout, 0, 1);

        return gridView;
    }
}

{% endhighlight %}
{% endtabs %}

### Header and footer in vertical mode when listview in horizontal mode

By customizing the `SfListView`, layout the header and footer items in `Vertical` mode with listview items in `Horizontal` mode.

{% tabs %}
{% highlight xaml %}

<ContentPage >

    <ContentPage.BindingContext>
        <local:ListViewAutoFitContentViewModel x:Name="ViewModel"/>
    </ContentPage.BindingContext>
   
    <local:SfListViewExt x:Name="listView" ItemSize="180" GroupHeaderSize="80"
                         ItemSpacing="2" Orientation="Horizontal"
                         ItemsSource="{Binding BookInfo}"
                         SelectionMode="None"
                         IsStickyGroupHeader="False"
                         SelectionBackgroundColor="#d3d3d3">
        <local:SfListViewExt.ItemTemplate>
                <DataTemplate>
                    <Grid RowSpacing="0">
                        <Grid.RowDefinitions>
                            <RowDefinition Height="Auto" />
                            <RowDefinition Height="Auto" />
                            <RowDefinition Height="1" />
                        </Grid.RowDefinitions>
                        <Grid Grid.Row="0" RowSpacing="0" Padding="5,10,5,5">
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="Auto" />
                                <ColumnDefinition Width="Auto" />
                            </Grid.ColumnDefinitions>
                            <StackLayout Padding="10,0,0,0" Orientation="Vertical" Grid.Column="1">
                                <Label Text="{Binding BookName}" FontAttributes="Bold" FontSize="18" TextColor="#474747" VerticalTextAlignment="Center"/>
                                <Label Text="By Syncfusion Software" FontSize="12" TextColor="#474747" VerticalTextAlignment="Center"/>
                                <Label Text="Published on: March 22, 2017" FontSize="12" TextColor="#474747" VerticalTextAlignment="Center"/>
                            </StackLayout>
                        </Grid>
                        <StackLayout Padding="5,10,0,5" Grid.Row="1" Orientation="Vertical">
                            <Label Text="Description" FontSize="15" FontAttributes="Bold"  TextColor="#474747" VerticalTextAlignment="Center"/>
                            <Label Text="{Binding BookDescription}" TextColor="#474747" FontSize="14" VerticalTextAlignment="Center"/>
                        </StackLayout>
                        <BoxView Grid.Row="2" HeightRequest="1" BackgroundColor="#474747" />
                    </Grid>
                </DataTemplate>
            </local:SfListViewExt.ItemTemplate>
        </local:SfListViewExt>
</ContentPage> 

{% endhighlight %}

{% highlight c# %}

public class SfListViewExt : SfListView
{
    Grid headerGrid;
    Grid footerGrid;

    public SfListViewExt()
    {
        headerGrid = new Grid();
        headerGrid.BackgroundColor = Color.Teal;
        Label headerLabel = new Label();
        headerLabel.Text = "Header Item";
        headerLabel.FontSize = 18;
        headerLabel.TextColor = Color.White;
        headerLabel.HorizontalOptions = LayoutOptions.Center;
        headerLabel.VerticalOptions = LayoutOptions.Center;
        headerGrid.Children.Add(headerLabel);

        footerGrid = new Grid();
        footerGrid.BackgroundColor = Color.Teal;
        Label footerLabel = new Label();
        footerLabel.Text = "Footer Item";
        footerLabel.FontSize = 18;
        footerLabel.TextColor = Color.White;
        footerLabel.HorizontalOptions = LayoutOptions.Center;
        footerLabel.VerticalOptions = LayoutOptions.Center;
        footerGrid.Children.Add(footerLabel);

        this.Children.Add(headerGrid);
        this.Children.Add(footerGrid);
    }

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        headerGrid.Layout(new Rectangle(0, 0, width, 70));
        footerGrid.Layout(new Rectangle(0, height - 70, width, 70));
        base.LayoutChildren(0, 70, width, height);
    }
}

{% endhighlight %}
{% endtabs %}


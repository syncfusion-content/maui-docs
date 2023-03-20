---
layout: post
title: Popup Size in MAUI Popup control | Syncfusion
description: Learn here all about Popup Size support in Syncfusion MAUI Popup (SfPopup) control and more.
platform: MAUI
control: SfPopup
documentation: ug
---

# Popup Size in Maui Popup (SfPopup)

SfPopup allows displaying the Popup at any desired width and height by setting the `SfPopup.WidthRequest` and `SfPopup.HeightRequest`. The Popup size can also be changed by setting width request and height request to the views loaded inside the templates of the Popup.

In the following code snippet the Popup is loaded in 320x320 pixels, where width request is set for the ListView that is loaded as template content and height request is set for the `PopupView`.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PopupMaui.HeightWidthPage"
             xmlns:local="clr-namespace:PopupMaui"
             xmlns:listView="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:popup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup">
    <ContentPage.BindingContext>
        <local:ContactsViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <StackLayout Padding="20">
            <Button x:Name="heightWidth" Text="HeightWidth" Clicked="heightWidth_Clicked" WidthRequest="300"/>
            <popup:SfPopup x:Name="popup" HeaderTitle="ListView" HeightRequest="320" ShowCloseButton="True" ShowFooter="True">
                <popup:SfPopup.ContentTemplate>
                    <DataTemplate>
                        <listView:SfListView  x:Name="listView"  ScrollBarVisibility="Never" ItemSpacing="5" WidthRequest="320" 
                          ItemsSource="{Binding contactsinfo}" 
                          >
                            <listView:SfListView.ItemTemplate>
                                <DataTemplate>
                                    <ViewCell>
                                        <ViewCell.View>
                                            <Grid x:Name="grid" RowSpacing="1">
                                                <Grid.RowDefinitions>
                                                    <RowDefinition Height="Auto" />
                                                </Grid.RowDefinitions>
                                                <Grid.ColumnDefinitions>
                                                    <ColumnDefinition Width="60" />
                                                    <ColumnDefinition Width="200" />
                                                    <ColumnDefinition Width="20" />
                                                </Grid.ColumnDefinitions>

                                                <Image Source="{Binding ContactImage}"
                                       VerticalOptions="Center"
                                       HorizontalOptions="End"
                                       HeightRequest="40"/>

                                                <Label Grid.Column="1" VerticalTextAlignment="Center"
                                        HorizontalTextAlignment="Center"
                                        LineBreakMode="NoWrap"
                                        Text="{Binding ContactName}" 
                                        FontSize="16" />

                                                <Image Grid.Column="2" 
                                       Source="{Binding ContactType}"
                                       VerticalOptions="Center"
                                       HorizontalOptions="End"
                                       HeightRequest="15"/>

                                            </Grid>
                                        </ViewCell.View>
                                    </ViewCell>
                                </DataTemplate>
                            </listView:SfListView.ItemTemplate>
                        </listView:SfListView>
                    </DataTemplate>
                </popup:SfPopup.ContentTemplate>
            </popup:SfPopup>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.ListView;
using Syncfusion.Maui.Popup;

namespace PopupMaui
{
    public partial class MainPage : ContentPage
    {
         SfListView listView;
        ContactsViewModel viewModel;
        SfPopup popup;

        public MainPage()
        {
            InitializeComponent();
            listView = new SfListView() { ItemSpacing = 5 };
            listView.WidthRequest = 350;
            listView.ScrollBarVisibility = ScrollBarVisibility.Never;
            listView.ItemTemplate = new DataTemplate(() =>
            {
                ViewCell viewCell = new ViewCell();
                var grid = new Grid() { RowSpacing = 1 };
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 60 });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 200 });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 20 });
                var contactImage = new Image()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.End,
                    HeightRequest = 40
                };
                contactImage.SetBinding(Image.SourceProperty, new Binding("ContactImage"));
                var contactName = new Label()
                {
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    LineBreakMode = LineBreakMode.NoWrap,
                    FontSize = 16,
                };
                contactName.SetBinding(Label.TextProperty, new Binding("ContactName"));
                var contactType = new Image()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.End,
                    HeightRequest = 15,
                };
                contactType.SetBinding(Image.SourceProperty, new Binding("ContactType"));
                grid.Children.Add(contactImage);
                Grid.SetColumn(grid, 0);
                grid.Children.Add(contactName);
                Grid.SetColumn(grid, 1);
                grid.Children.Add(contactType);
                Grid.SetColumn(grid, 2);
                viewCell.View = grid;
                return viewCell;
            });
            viewModel = new ContactsViewModel();
            listView.ItemsSource = viewModel.contactsinfo;
            popup = new SfPopup();
            popup.HeaderTitle = "ListView";
            popup.HeightRequest = 320;
            popup.ContentTemplate = new DataTemplate(() =>
            {
                return listView;
            });
            StackLayout stackLayout = new StackLayout();
            Button isOpenButton = new Button();
            isOpenButton.Clicked += heightWidth_Clicked;
            isOpenButton.Text = "Click to show popup";
            stackLayout.Children.Add(isOpenButton);
            this.Content = popup;
        }

        private void heightWidth_Clicked(object sender, EventArgs e)
        {
			popup.Show();
        }
    }
}

{% endhighlight %}
{% endtabs %}

![Popup with HeightRequest and WidthRequest](Images/popup-size//maui-popup-with-heightrequest-and-widthrequest.png)

## Full Screen

SfPopup can be shown in full width and height of the screen using,

  * `SfPopup.IsFullScreen`
  * `SfPopup.Show(bool)`

Refer the below code example to open the popup in full screen.

{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PopupMaui.FullScreenPage"
             xmlns:local="clr-namespace:PopupMaui"
             xmlns:inputLayout="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
             xmlns:popup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup"
             >
    <ContentPage.Content>
        <StackLayout Padding="20">
            <Button x:Name="show" Text="Show Popup" Clicked="show_Clicked"/>
            <popup:SfPopup x:Name="popup" AppearanceMode="TwoButton" AcceptButtonText="SAVE"  DeclineButtonText="CANCEL" HeaderHeight="60" FooterHeight="70" ShowCloseButton="True" ShowFooter="True">
                <popup:SfPopup.HeaderTemplate>
                    <DataTemplate>
                        <Label Text="ADD EVENT" Padding="3,0,0,0" VerticalTextAlignment="Center" FontSize="18" HorizontalTextAlignment="Start" FontAttributes="Bold"/>
                    </DataTemplate>
                </popup:SfPopup.HeaderTemplate>
                <popup:SfPopup.ContentTemplate>
                    <DataTemplate>
                        <Grid BackgroundColor="White" Padding="15,20,15,0">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="50"/>
                                <RowDefinition Height="50"/>
                                <RowDefinition Height="50"/>
                                <RowDefinition Height="50"/>
                                <RowDefinition Height="55"/>
                            </Grid.RowDefinitions>

                            <Grid Grid.Row="0" BackgroundColor="#F3F3F9" Margin="0,5,0,0">
                                <inputLayout:SfTextInputLayout VerticalOptions="Start" HeightRequest="60" Hint="Event name" ContainerType="Outlined" BackgroundColor="Transparent">
                                    <Entry BackgroundColor="Transparent"/>
                                    <inputLayout:SfTextInputLayout.HintLabelStyle>
                                        <inputLayout:LabelStyle FontSize="14" />
                                    </inputLayout:SfTextInputLayout.HintLabelStyle>
                                </inputLayout:SfTextInputLayout>
                            </Grid>

                            <Grid Grid.Row="1" BackgroundColor="#F3F3F9" Margin="0,5,0,0">
                                <inputLayout:SfTextInputLayout Hint="Location" VerticalOptions="Start" HeightRequest="60" ContainerType="Outlined" BackgroundColor="Transparent">
                                    <Entry BackgroundColor="Transparent"/>
                                    <inputLayout:SfTextInputLayout.HintLabelStyle>
                                        <inputLayout:LabelStyle FontSize="14" />
                                    </inputLayout:SfTextInputLayout.HintLabelStyle>
                                </inputLayout:SfTextInputLayout>
                            </Grid>

                            <Grid Grid.Row="2" Margin="0,15,0,0">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="3*"/>
                                    <ColumnDefinition Width="7*"/>
                                </Grid.ColumnDefinitions>
                                <Label Grid.Row="0" FontSize="14" VerticalTextAlignment="Center" Text="From"/>
                                <DatePicker Grid.Column="1" HeightRequest="40" WidthRequest="220" FontSize="12"/>
                            </Grid>

                            <Grid Grid.Row="3" Margin="0,15,0,0">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="3*"/>
                                    <ColumnDefinition Width="7*"/>
                                </Grid.ColumnDefinitions>
                                <Label Grid.Row="0" Text="To" VerticalTextAlignment="Center" FontSize="14"/>
                                <DatePicker Grid.Column="1" HeightRequest="40" WidthRequest="220" FontSize="12"/>
                            </Grid>
                            <Grid Grid.Row="4" Margin="0,15,0,0">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="3*"/>
                                    <ColumnDefinition Width="7*"/>
                                </Grid.ColumnDefinitions>
                                <Switch Grid.Column="0"/>
                                <Label Grid.Column="1" FontSize="14" VerticalTextAlignment="Center" Text="All-day"/>
                            </Grid>
                        </Grid>
                    </DataTemplate>
                </popup:SfPopup.ContentTemplate>
                <popup:SfPopup.PopupStyle>
                    <popup:PopupStyle CornerRadius="0"/>
                </popup:SfPopup.PopupStyle>
            </popup:SfPopup>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}
using Syncfusion.Maui.Popup;

namespace PopupMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void show_Clicked(object sender, EventArgs e)
        {
            popup.Show();
        }
    }
}
{% endhighlight %}

Executing the above codes renders the following output in windows.

![Popup with Full Screen](Images/popup-size//maui-popup-with-fullscreen.png)


## Auto-size Popup

The `SfPopup` can auto-size the popup view based on the contents loaded inside its `SfPopup.ContentTemplate` property using the `SfPopup.AutoSizeMode` property. The default value is `AutoSizeMode.None`. You can choose to auto-size the Popup in height, width or in both height and width of its contents. By default, the `HeightRequest` and `WidthRequest` set to the `SfPopup` or the views loaded inside the template is given higher priority than the `AutoSizeMode`.

In the following code snippet the Popup is auto-sized in height based on the content loaded inside the `SfPopup.ContentTemplate` property.

{% tabs %}

{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PopupMaui.AutoSizePage"
              xmlns:popup="clr-namespace:Syncfusion.Maui.Popup;assembly=Syncfusion.Maui.Popup">
    <ContentPage.Content>
        <StackLayout Padding="20">
            <Button x:Name="show" Text="Show" WidthRequest="300" Clicked="show_Clicked"/>
            <popup:SfPopup x:Name="popup" AutoSizeMode="Height">
                <popup:SfPopup.ContentTemplate>
                    <DataTemplate>
                        <StackLayout Padding="5,5,5,0">
                            <Label Text="Window loads under the parent window surrounded by an overlay which prevents clicking anywhere else on the screen apart from the control of the modal. Modal opens in the same window. It also does not require any user action to open, and give callbacks when closing or opening the modal."
                                   FontSize="14"
                            LineBreakMode="WordWrap"
                           />
                        </StackLayout>
                    </DataTemplate>
                </popup:SfPopup.ContentTemplate>
            </popup:SfPopup>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}

{% highlight c# %}

popup.AutoSizeMode = PopupAutoSizeMode.Height;

{% endhighlight %}

{% endtabs %}

Executing the above codes renders the following output in windows.

![Popup with AutoSize](Images/popup-size//maui-popup-with-autosizemode.png)

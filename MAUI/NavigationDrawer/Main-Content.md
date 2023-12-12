---
layout: post
title: Setting Main Content in .NET MAUI Navigation Drawer control | Syncfusion
description: Learn here all about Setting Main Content support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---


# Setting Main Content in .NET MAUI Navigation Drawer (SfNavigationDrawer)

The main content of the NavigationDrawer is always visible and can be set using the `ContentView` property. In the following code example, the `ContentView` is switched when the selection changes in the ListView. In short, this allows for easy navigation and switching of content.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerWidth="250"
                                         DrawerHeaderHeight="160">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#1aa1d6" RowDefinitions="120,40">
                    <Image Source="user.png"
                           HeightRequest="110"
                           Margin="0,10,0,0"
                           BackgroundColor="#1aa1d6"
                           VerticalOptions="Center"
                           HorizontalOptions="Center"/>
                    <Label Text="James Pollock"
                           Grid.Row="1"
                           HorizontalTextAlignment="Center"
                           HorizontalOptions="Center"
                           FontSize="20"
                           TextColor="White"/>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <ListView x:Name="listView"
                          ItemSelected="listView_ItemSelected">
                    <ListView.ItemTemplate>
                        <DataTemplate>
                            <ViewCell>
                                <VerticalStackLayout HeightRequest="40">
                                    <Label Margin="10,7,0,0"
                                           Text="{Binding}"
                                           FontSize="16"/>
                                </VerticalStackLayout>
                            </ViewCell>
                        </DataTemplate>
                    </ListView.ItemTemplate>
                </ListView>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <Grid x:Name="mainContentView" 
          BackgroundColor="White" RowDefinitions="Auto,*">
            <HorizontalStackLayout BackgroundColor="#1aa1d6" Spacing="10" Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
                <Label x:Name="headerLabel" 
                   HeightRequest="50" 
                   HorizontalTextAlignment="Center" 
                   VerticalTextAlignment="Center" 
                   Text="Home" FontSize="16" 
                   TextColor="White" 
                   BackgroundColor="#1aa1d6"/>
            </HorizontalStackLayout>
            <Label Grid.Row="1" 
              x:Name="contentviewLabel" 
              VerticalOptions="Center" 
              HorizontalOptions="Center" 
              Text="Content View" 
              FontSize="14" 
              TextColor="Black"/>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerPage : ContentPage
{
    SfNavigationDrawer navigationDrawer;
    Label contentviewLabel;
    public NavigationDrawerPage()
	{
		InitializeComponent();
        navigationDrawer = new SfNavigationDrawer();
        Grid grid = new Grid()
        {
            RowDefinitions =
            {
                new RowDefinition {Height=new GridLength(1,GridUnitType.Auto)},
                new RowDefinition(),
            },
            BackgroundColor = Colors.White,
        };

        HorizontalStackLayout layout = new HorizontalStackLayout()
        { 
            BackgroundColor = Color.FromArgb("#1aa1d6"),
            Spacing = 10,
            Padding = new Thickness(5,0,0,0),
        };

        var hamburgerButton = new ImageButton
        {
            HeightRequest = 50,
            WidthRequest = 50,
            HorizontalOptions = LayoutOptions.Start,
            BackgroundColor = Color.FromArgb("#1aa1d6"),
            Source = "hamburgericon.png",
        };
        hamburgerButton.Clicked += hamburgerButton_Clicked;

        var label = new Label
        {
            HeightRequest = 50,
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center,
            Text = "Home",
            FontSize = 16,
            TextColor = Colors.White,
            BackgroundColor = Color.FromArgb("#1aa1d6")
        };
        layout.Children.Add(hamburgerButton);
        layout.Children.Add(label);

        contentviewLabel = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Text = "Content View",
            FontSize = 14,
            TextColor = Colors.Black
        };
        grid.SetRow(layout, 0);
        grid.SetRow(contentviewLabel, 1);
        grid.Children.Add(layout);
        grid.Children.Add(contentviewLabel);
        navigationDrawer.ContentView = grid;

        Grid headerGrid = new Grid()
        {
            RowDefinitions =
            {
                new RowDefinition { Height = 120 },
                new RowDefinition { Height = 40 },
            },
            BackgroundColor = Color.FromArgb("#1aa1d6"),
        };

        var image = new Image
        {
            Source = "user.png",
            HeightRequest = 110,
            Margin = new Thickness(0, 10, 0, 0),
            BackgroundColor = Color.FromArgb("#1aa1d6"),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        var headerlabel = new Label
        {
            Text = "James Pollock",
            HorizontalTextAlignment = TextAlignment.Center,
            HorizontalOptions = LayoutOptions.Center,
            FontSize = 20,
            TextColor = Colors.White
        };
        headerGrid.SetRow(image, 0);
        headerGrid.SetRow(headerlabel, 1);
        headerGrid.Children.Add(image);
        headerGrid.Children.Add(headerlabel);

        ListView listView = new ListView();
        listView.ItemSelected += listView_ItemSelected;
        List<string> list = new List<string>();
        list.Add("Home");
        list.Add("Profile");
        list.Add("Inbox");
        list.Add("Out box");
        list.Add("Sent");
        list.Add("Draft");
        listView.ItemsSource = list;

        navigationDrawer.DrawerSettings = new DrawerSettings()
        {
            DrawerHeaderView = headerGrid,
            DrawerContentView = listView,
            DrawerHeaderHeight = 160,
            DrawerWidth = 250,
        };
        this.Content = navigationDrawer;
    }

    private void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }

    private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem.ToString() == "Home")
            contentviewLabel.Text = "Home";
        else if (e.SelectedItem.ToString() == "Profile")
            contentviewLabel.Text = "Profile";
        else if (e.SelectedItem.ToString() == "Inbox")
            contentviewLabel.Text = "Inbox";
        else if (e.SelectedItem.ToString() == "Out box")
            contentviewLabel.Text = "Out box";
        else if (e.SelectedItem.ToString() == "Sent")
            contentviewLabel.Text = "Sent";
        else if (e.SelectedItem.ToString() == "Draft")
            contentviewLabel.Text = "The folder is empty";
        navigationDrawer.ToggleDrawer();
    }
}
  
{% endhighlight %}

{% endtabs %}

N> It is mandatory to set `ContentView` for `SfNavigationDrawer` when initializing.

![contentview]()

You can find the complete Sample from this [`link.`](https://github.com/SyncfusionExamples/.NET-MAUI-NavigationDrawer-MainContent)

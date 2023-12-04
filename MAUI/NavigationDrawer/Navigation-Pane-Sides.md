---
layout: post
title: Configuring The Drawer In .NET MAUI Navigation Drawer | Syncfusion
description: Learn here all about Configuring The Drawer In Different Sides support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---
# Configuring The Drawer In Different Sides in .NET MAUI Navigation Drawer

The supplemental pane can be drawn in and out from all four sides. [`Position`]() property is used to change the side of the pane and the values are

*	[`Left`]()

*	[`Right`]()

*	[`Top`]()

*	[`Bottom`]()

N> The default position is [`Left`]().

## Left

The navigation pane draws in and out from the [`Left`]() side. It can be set as shown below:

{% tabs %}	

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings Position="Left"
                                         DrawerHeaderHeight="0">
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <Grid>
                    <ListView x:Name="listView"
                              ItemSelected="listView_ItemSelected"
                              SeparatorColor="Transparent">
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <VerticalStackLayout HeightRequest="40">
                                        <Label Margin="10,7,0,0"
                                               Text="{Binding}"
                                               TextColor="Black"
                                               FontSize="16"/>
                                    </VerticalStackLayout>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <Grid x:Name="mainContentView"
              BackgroundColor="White"
              RowDefinitions="Auto,*">
            <HorizontalStackLayout BackgroundColor="#1aa1d6"
                                   Spacing="10"
                                   Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}
	
{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerPosition : ContentPage
{
	public NavigationDrawerPosition()
	{
		InitializeComponent();
        navigationDrawer.DrawerSettings.Position = Position.Left;
        navigationDrawer.DrawerSettings.DrawerHeaderHeight = 0;
        List<string> list = new List<string>();
        list.Add("Web");
        list.Add("Images");
        list.Add("Videos");
        list.Add("Maps");
        list.Add("News");
        listView.ItemsSource = list;
    }

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }

    private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //    Your codes here
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Left]()

## Right

The navigation pane draws in and out from the [`Right`]() side. It can be set as shown below:

{% tabs %}	

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings Position="Right"
                                         DrawerHeaderHeight="0">
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <Grid>
                    <ListView x:Name="listView"
                              ItemSelected="listView_ItemSelected"
                              SeparatorColor="Transparent">
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <VerticalStackLayout HeightRequest="40">
                                        <Label Margin="10,7,0,0"
                                               Text="{Binding}"
                                               TextColor="Black"
                                               FontSize="16"/>
                                    </VerticalStackLayout>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <Grid x:Name="mainContentView"
              BackgroundColor="White"
              RowDefinitions="Auto,*">
            <HorizontalStackLayout BackgroundColor="#1aa1d6"
                                   Spacing="10"
                                   Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}
	
{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerPosition : ContentPage
{
	public NavigationDrawerPosition()
	{
		InitializeComponent();
         navigationDrawer.DrawerSettings.Position = Position.Right;
         navigationDrawer.DrawerSettings.DrawerHeaderHeight = 0;
        List<string> list = new List<string>();
        list.Add("Web");
        list.Add("Images");
        list.Add("Videos");
        list.Add("Maps");
        list.Add("News");
        listView.ItemsSource = list;
    }

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }

    private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //    Your codes here
        navigationDrawer.ToggleDrawer();
    }
}


{% endhighlight %}

{% endtabs %}

![Right]()
	
## Top

The navigation pane draws in and out from the [`Top`]() side. It can be set as shown below:

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings Position="Top"
                                         DrawerHeaderHeight="0"
                                         DrawerHeight="300">
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <Grid>
                    <ListView x:Name="listView"
                              ItemSelected="listView_ItemSelected"
                              SeparatorColor="Transparent">
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <VerticalStackLayout HeightRequest="40">
                                        <Label Margin="10,7,0,0"
                                               Text="{Binding}"
                                               TextColor="Black"
                                               FontSize="16"/>
                                    </VerticalStackLayout>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <Grid x:Name="mainContentView"
              BackgroundColor="White"
              RowDefinitions="Auto,*">
            <HorizontalStackLayout BackgroundColor="#1aa1d6"
                                   Spacing="10"
                                   Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>

	
{% endhighlight %}	
	
{% highlight c# %}
	
using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerPosition : ContentPage
{
	public NavigationDrawerPosition()
	{
		InitializeComponent();
        navigationDrawer.DrawerSettings.Position = Position.Top;
        navigationDrawer.DrawerSettings.DrawerHeaderHeight = 0;
        navigationDrawer.DrawerSettings.DrawerHeight = 300;
        List<string> list = new List<string>();
        list.Add("Web");
        list.Add("Images");
        list.Add("Videos");
        list.Add("Maps");
        list.Add("News");
        listView.ItemsSource = list;
    }

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }

    private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //    Your codes here
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Top]()

## Bottom

The navigation pane draws in and out from the [`Bottom`]() side. It can be set as shown below:

{% tabs %}	

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings Position="Bottom"
                                         DrawerHeaderHeight="0"
                                         DrawerHeight="300">
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <Grid>
                    <ListView x:Name="listView"
                              ItemSelected="listView_ItemSelected"
                              SeparatorColor="Transparent">
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <VerticalStackLayout HeightRequest="40">
                                        <Label Margin="10,7,0,0"
                                               Text="{Binding}"
                                               TextColor="Black"
                                               FontSize="16"/>
                                    </VerticalStackLayout>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <Grid x:Name="mainContentView"
              BackgroundColor="White"
              RowDefinitions="Auto,*">
            <HorizontalStackLayout BackgroundColor="#1aa1d6"
                                   Spacing="10"
                                   Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}
	
{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerPosition : ContentPage
{
	public NavigationDrawerPosition()
	{
		InitializeComponent();
        navigationDrawer.DrawerSettings.Position = Position.Bottom;
        navigationDrawer.DrawerSettings.DrawerHeaderHeight = 0;
        navigationDrawer.DrawerSettings.DrawerHeight = 300;
        List<string> list = new List<string>();
        list.Add("Web");
        list.Add("Images");
        list.Add("Videos");
        list.Add("Maps");
        list.Add("News");
        listView.ItemsSource = list;
    }

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }

    private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //    Your codes here
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Bottom]()
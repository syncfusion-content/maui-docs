---
layout: post
title: Setting Sliding Panel size in .NET MAUI Navigation Drawer | Syncfusion
description: Learn here all about Setting Sliding Panel size support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---
# Setting Sliding Panel size in .NET MAUI Navigation Drawer

The size of the side pane can be adjusted using the [`DrawerHeight`]() and [`DrawerWidth`]() properties.

## Drawer Height

The [`DrawerHeight`]() property is used to change the height of the side pane when the [`Position`]() is set to [`Top`]() or [`Bottom`]().

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings Position="Top"
                                         DrawerHeight="50">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Label Text="This is a brief content used to demonstrate the DrawerHeight property."/>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
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
                             HeightRequest="45"
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

public partial class NavigationDrawerSize : ContentPage
{
    SfNavigationDrawer navigationDrawer;
    
    public NavigationDrawerSize()
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
            Padding = new Thickness(5, 0, 0, 0),
        };

        var hamburgerButton = new ImageButton
        {
            HeightRequest = 45,
            WidthRequest = 50,
            HorizontalOptions = LayoutOptions.Start,
            BackgroundColor = Color.FromArgb("#1aa1d6"),
            Source = "hamburgericon.png",
        };
        hamburgerButton.Clicked += hamburgerButton_Clicked;

        var label = new Label
        {
            HeightRequest = 45,
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center,
            Text = "Home",
            FontSize = 16,
            TextColor = Colors.White,
            BackgroundColor = Color.FromArgb("#1aa1d6")
        };
        layout.Children.Add(hamburgerButton);
        layout.Children.Add(label);

        grid.SetRow(layout, 0);
        grid.Children.Add(layout);
        
        navigationDrawer.ContentView = grid;

        navigationDrawer.DrawerSettings = new DrawerSettings()
        {
            Position = Position.Top,
            DrawerHeight = 50,
            DrawerHeaderView = new Label()
            {
                Text = "This is a brief content used to demonstrate the DrawerHeight property."
            },
        };
        this.Content = navigationDrawer;
    }

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Drawer height]()

## Drawer Width

The [`DrawerWidth`]() property is used to change the width of the side pane when the [`Position`]() is set to [`Left`]() or [`Right`]().

{% tabs %}

{% highlight xaml %}

 <navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
     <navigationdrawer:SfNavigationDrawer.DrawerSettings>
         <navigationdrawer:DrawerSettings Position="Left"
                                          DrawerWidth="250"
                                          DrawerHeaderHeight="75">
             <navigationdrawer:DrawerSettings.DrawerHeaderView>
                 <Label Text="This is a brief content used to demonstrate the DrawerWidth property."/>
             </navigationdrawer:DrawerSettings.DrawerHeaderView>
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
                              HeightRequest="45"
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

public partial class NavigationDrawerSize : ContentPage
{
    SfNavigationDrawer navigationDrawer;
    
    public NavigationDrawerSize()
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
            Padding = new Thickness(5, 0, 0, 0),
        };

        var hamburgerButton = new ImageButton
        {
            HeightRequest = 45,
            WidthRequest = 50,
            HorizontalOptions = LayoutOptions.Start,
            BackgroundColor = Color.FromArgb("#1aa1d6"),
            Source = "hamburgericon.png",
        };
        hamburgerButton.Clicked += hamburgerButton_Clicked;

        var label = new Label
        {
            HeightRequest = 45,
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center,
            Text = "Home",
            FontSize = 16,
            TextColor = Colors.White,
            BackgroundColor = Color.FromArgb("#1aa1d6")
        };
        layout.Children.Add(hamburgerButton);
        layout.Children.Add(label);

        grid.SetRow(layout, 0);
        grid.Children.Add(layout);
        
        navigationDrawer.ContentView = grid;

        navigationDrawer.DrawerSettings = new DrawerSettings()
        {
            Position = Position.Left,
            DrawerWidth = 250,
            DrawerHeaderHeight = 75,
            DrawerHeaderView = new Label()
            {
                Text = "This is a brief content used to demonstrate the DrawerWidth property."
            },
        };
        this.Content = navigationDrawer;
    }

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Drawer width]()

---
layout: post
title: Setting Toggle Animations in .NET MAUI Navigation Drawer | Syncfusion
description: Learn here all about Setting Toggle Animations support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---
# Setting Toggle Animations in .NET MAUI Navigation Drawer

The drawer toggling animation can be changed using [`Transition`]() property and it can be set to three different values. They are

* [`SlideOnTop`]()

* [`Push`]()

* [`Reveal`]()

N> The default animation is [`SlideOnTop`]().

## SlideOnTop

The navigation pane overlays the main content area when it is opened. It can be set as shown below:

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerWidth="250"
                                         Transition="SlideOnTop">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#1aa1d6">
                    <Label Text="Header View"
                       HorizontalTextAlignment="Center"
                       HorizontalOptions="Center"
                       FontSize="20"
                       TextColor="White"/>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
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
            </HorizontalStackLayout>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}	
	
{% highlight c# %} 

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerAnimation : ContentPage
{
	public NavigationDrawerAnimation()
	{
		InitializeComponent();
        navigationDrawer.DrawerSettings.Transition = Transition.SlideOnTop;
	}

    private void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![SlideOnTop]()

## Push

The navigation pane is hidden. When it is opened, it will push the main content area on the opposite side up to the width of the drawer. It can be set as shown below:

{% tabs %}	

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerWidth="250"
                                         Transition="Push">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#1aa1d6">
                    <Label Text="Header View"
                       HorizontalTextAlignment="Center"
                       HorizontalOptions="Center"
                       FontSize="20"
                       TextColor="White"/>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
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
            </HorizontalStackLayout>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}
	
{% highlight c# %} 

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerAnimation : ContentPage
{
	public NavigationDrawerAnimation()
	{
		InitializeComponent();
        navigationDrawer.DrawerSettings.Transition = Transition.Push;
	}

    private void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Push]()

## Reveal

The navigation pane is hidden behind the main content. The main content moves away on the opposite side up to the drawer width to show the drawer content. It can be set as shown below:

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerWidth="250"
                                         Transition="Reveal">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#1aa1d6">
                    <Label Text="Header View"
                       HorizontalTextAlignment="Center"
                       HorizontalOptions="Center"
                       FontSize="20"
                       TextColor="White"/>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
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
            </HorizontalStackLayout>
        </Grid>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}	
	
{% highlight c# %} 

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerAnimation : ContentPage
{
	public NavigationDrawerAnimation()
	{
		InitializeComponent();
        navigationDrawer.DrawerSettings.Transition = Transition.Reveal;
	}

    private void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Reveal]()

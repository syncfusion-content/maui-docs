---
layout: post
title: Setting Sliding Panel Content in .NET MAUI NavigationDrawer | Syncfusion
description: Learn here all about Setting Sliding Panel Content support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---


# Setting Sliding Panel Content in .NET MAUI Navigation Drawer

The drawer pane content is viewable only if the drawer is in the open state. Its content can be set as

*	Header Content

*	Drawer Content

*	Footer Content

N> Header and Footer content are optional but Drawer content is mandatory to allocate space for the drawer.
		
## Header Content

As the name suggests it is displayed at the top of drawer. [`DrawerHeaderView`]() property is used to set the header content of drawer. 

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#1aa1d6">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Header View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <VerticalStackLayout>
            <HorizontalStackLayout BackgroundColor="#1aa1d6" 
                  HeightRequest="50" 
                  VerticalOptions="Start"
                  Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </VerticalStackLayout>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>


{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerView : ContentPage
{
	public NavigationDrawerView()
	{
		InitializeComponent();
		navigationDrawer.DrawerSettings = new DrawerSettings()
		{
			DrawerWidth = 250,
		};
	}

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}
  
{% endhighlight %}

{% endtabs %}

![Header](Images/Header.png)

## Header Height

The height of the drawer header content can be adjusted using the [`DrawerHeaderHeight`]() property.

N> [`DrawerHeaderView`]() will be disabled by setting the [`DrawerHeaderHeight`]() to zero.

{% tabs %}

{% highlight xaml %}
    
<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerHeaderHeight="150">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#1aa1d6">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Header View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <VerticalStackLayout>
            <HorizontalStackLayout BackgroundColor="#1aa1d6" 
                  HeightRequest="50" 
                  VerticalOptions="Start"
                  Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </VerticalStackLayout>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerView : ContentPage
{
	public NavigationDrawerView()
	{
		InitializeComponent();
		navigationDrawer.DrawerSettings = new DrawerSettings()
		{
			DrawerWidth = 250,
			DrawerHeaderHeight = 150,
		};
	}

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Header height]()

## Footer Content

As the name suggests it is displayed at the bottom of the drawer. The  [`DrawerFooterView`]() property is used to set the footer content of the drawer. 

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerFooterView>
                <Grid BackgroundColor="#1aa1d6">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Footer View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerFooterView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <VerticalStackLayout>
            <HorizontalStackLayout BackgroundColor="#1aa1d6" 
                  HeightRequest="50" 
                  VerticalOptions="Start"
                  Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </VerticalStackLayout>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerView : ContentPage
{
	public NavigationDrawerView()
	{
		InitializeComponent();
		navigationDrawer.DrawerSettings = new DrawerSettings()
		{
			DrawerWidth = 250,
		};
	}

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}

{% endhighlight %}

{% endtabs %}

![Footer]()

## Footer Height

The height of the drawer footer content can be adjusted using the [`DrawerFooterHeight`]() property.

N> [`DrawerFooterView`]() will be disabled by setting the [`DrawerFooterHeight`]() to zero 

{% tabs %}

{% highlight xaml %} 

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerFooterHeight="150">
            <navigationdrawer:DrawerSettings.DrawerFooterView>
                <Grid BackgroundColor="#1aa1d6">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Footer View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerFooterView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <VerticalStackLayout>
            <HorizontalStackLayout BackgroundColor="#1aa1d6" 
                  HeightRequest="50" 
                  VerticalOptions="Start"
                  Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </VerticalStackLayout>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}

{% highlight c# %}
        
using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerView : ContentPage
{
	public NavigationDrawerView()
	{
		InitializeComponent();
		navigationDrawer.DrawerSettings = new DrawerSettings()
		{
			DrawerWidth = 250,
			DrawerFooterHeight = 150,
		};
	}

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}
  
{% endhighlight %}

{% endtabs %}

![Footer hight]()

## Main Content

Drawer main content is displayed in between header and footer content. It can be set using the [`DrawerContentView`]() property. Content view occupies the remaining space left by header and footer content.

{% tabs %}

{% highlight xaml %} 

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <Grid BackgroundColor="#1aa1d6">
                    <VerticalStackLayout VerticalOptions="Center"
                     HorizontalOptions="Center">
                        <Label Text="Content View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    <navigationdrawer:SfNavigationDrawer.ContentView>
        <VerticalStackLayout>
            <HorizontalStackLayout BackgroundColor="#1aa1d6" 
                  HeightRequest="50" 
                  VerticalOptions="Start"
                  Padding="5,0,0,0">
                <ImageButton x:Name="hamburgerButton"
                             HeightRequest="50"
                             WidthRequest="50"
                             HorizontalOptions="Start"
                             Source="hamburgericon.png"
                             BackgroundColor="#1aa1d6"
                             Clicked="hamburgerButton_Clicked"/>
            </HorizontalStackLayout>
        </VerticalStackLayout>
    </navigationdrawer:SfNavigationDrawer.ContentView>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}

{% highlight c# %}
        
using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerView : ContentPage
{
	public NavigationDrawerView()
	{
		InitializeComponent();
		navigationDrawer.DrawerSettings = new DrawerSettings()
		{
			DrawerWidth = 250,
		};
	}

    void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}
  
{% endhighlight %}

{% endtabs %}

![content]()

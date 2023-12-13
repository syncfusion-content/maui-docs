---
layout: post
title: Setting Sliding Panel Content in .NET MAUI NavigationDrawer | Syncfusion
description: Learn here all about Setting Sliding Panel Content support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---


# Setting Sliding Panel Content in .NET MAUI Navigation Drawer

The drawer pane content is only viewable when the drawer is in the open state. Its content can be set as:

*	Header Content

*	Drawer Content

*	Footer Content

N> Header and Footer content is optional, but the Drawer content is mandatory to allocate space for the drawer.
		
## Header Content

As the name suggests, it is displayed at the top of the drawer. The `DrawerHeaderView` property is used to set the header content of the drawer.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#6750A4">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Header View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>


{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
DrawerSettings drawerSettings = new DrawerSettings()
{
    DrawerWidth = 250,
};
navigationDrawer.DrawerSettings = drawerSettings;
this.Content = navigationDrawer;
  
{% endhighlight %}

{% endtabs %}

![Header]()

## Header Height

The height of the drawer header content can be adjusted using the `DrawerHeaderHeight` property.

N> The `DrawerHeaderView` can be removed by setting the `DrawerHeaderHeight` to zero.

{% tabs %}

{% highlight xaml %}
    
<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerHeaderHeight="150">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#6750A4">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Header View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
DrawerSettings drawerSettings = new DrawerSettings()
{
    DrawerHeaderHeight = 150,
    DrawerWidth = 250,
};
navigationDrawer.DrawerSettings = drawerSettings;
this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}

![Header height]()

## Footer Content

As the name suggests, it is displayed at the bottom of the drawer. The `DrawerFooterView` property is used to set the footer content of the drawer.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerFooterView>
                <Grid BackgroundColor="#6750A4">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Footer View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerFooterView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
DrawerSettings drawerSettings = new DrawerSettings()
{
    DrawerWidth = 250,
};
navigationDrawer.DrawerSettings = drawerSettings;
this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}

![Footer]()

## Footer Height

The height of the drawer footer content can be adjusted using the `DrawerFooterHeight` property.

N> The `DrawerFooterView` can be removed by setting the `DrawerFooterHeight` to zero.

{% tabs %}

{% highlight xaml %} 

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerFooterHeight="150">
            <navigationdrawer:DrawerSettings.DrawerFooterView>
                <Grid BackgroundColor="#6750A4">
                    <VerticalStackLayout VerticalOptions="Center"
                                         HorizontalOptions="Center">
                        <Label Text="Footer View"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerFooterView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}

{% highlight c# %}
        
SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
DrawerSettings drawerSettings = new DrawerSettings()
{
    DrawerFooterHeight = 150,
    DrawerWidth = 250,
};  
navigationDrawer.DrawerSettings = drawerSettings;
this.Content = navigationDrawer;
  
{% endhighlight %}

{% endtabs %}

![Footer height]()

## Drawer Content

The main content of the drawer is displayed between the header and footer content. It can be set using the `DrawerContentView` property. The content view occupies the remaining space left by the header and footer content.

{% tabs %}

{% highlight xaml %} 

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <Grid BackgroundColor="#6750A4">
                    <VerticalStackLayout VerticalOptions="Center"
                     HorizontalOptions="Center">
                        <Label Text="Drawer Content"/>
                    </VerticalStackLayout>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}

{% highlight c# %}
        
SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
DrawerSettings drawerSettings = new DrawerSettings()
{
    DrawerWidth = 250,
};
navigationDrawer.DrawerSettings = drawerSettings;
this.Content = navigationDrawer;
  
{% endhighlight %}

{% endtabs %}

![content]()

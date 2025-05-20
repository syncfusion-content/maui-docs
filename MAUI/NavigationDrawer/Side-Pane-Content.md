---
layout: post
title: Set Sliding Panel Content in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn about setting sliding panel content support in the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Set Sliding Panel Content in .NET MAUI Navigation Drawer

The drawer pane content is only viewable when the drawer is in the open state. Content can be set as:

*	Header Content

*	Drawer Content

*	Footer Content

N> Header and Footer content is optional, but the Drawer content is mandatory to allocate space for the drawer.
		
## Header Content

The header is displayed at the top of the drawer. Use the [DrawerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView) property to set the header content:

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

![Header](Images/panel-content/navigation_drawer_header.png)

## Header Height

Adjust the height of the drawer header content using the [DrawerHeaderHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderHeight) property.

N> The [DrawerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView) can be removed by setting the [DrawerHeaderHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderHeight) to zero.

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

![Header height](Images/panel-content/navigation_drawer_header_height.png)

## Footer Content

The footer is displayed at the bottom of the drawer. Use the [DrawerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView) property to set the footer content:

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

![Footer](Images/panel-content/navigation_drawer_footer.png)

## Footer Height

Adjust the height of the drawer footer content using the [DrawerFooterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterHeight) property.

N> The [DrawerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView) can be removed by setting the [DrawerFooterHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterHeight) to zero.

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

![Footer height](Images/panel-content/navigation_drawer_footer_height.png)

## Drawer Content

The main content of the drawer is displayed between the header and footer content. It can be set using the [DrawerContentView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerContentView) property. The content view occupies the space left by the header and footer content.

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

![content](Images/panel-content/navigation_drawer_content.png)

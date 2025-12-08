---
layout: post
title: Multi Drawer in .NET MAUI Navigation Drawer | Syncfusion®
description: The navigation drawer allows users to open drawers on multiple sides with different toggle methods.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Multi Drawer in MAUI Navigation Drawer (SfNavigationDrawer)

The navigation drawer allows users to open the drawer on multiple sides with different toggle methods. The [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class and its properties need to be used when users need to provide multiple drawers. The multiple drawers can be implemented using the following drawer settings.

* DrawerSettings
* SecondaryDrawerSettings

![Multi Drawer](Images/multi-drawer/multi-drawer.gif)

### DrawerSettings

Implement the primary drawer using the drawer settings class. The following code sample demonstrates how to set the drawer settings’s properties inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class.

{% tabs %}

{% highlight xaml %}

    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.DrawerSettings>
            <navigationdrawer:DrawerSettings DrawerWidth="250"
                                             Transition="SlideOnTop"
                                             ContentBackground="LightGray"
                                             Position="Left">
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    </navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}


    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings drawerSettings = new DrawerSettings();
    drawerSettings.DrawerWidth = 250;
    drawerSettings.Transition = Syncfusion.Maui.NavigationDrawer.Transition.SlideOnTop;
    drawerSettings.ContentBackground = Colors.LightGray;
    drawerSettings.Position = Syncfusion.Maui.NavigationDrawer.Position.Left;
    navigationDrawer.DrawerSettings = drawerSettings;
    this.Content = navigationDrawer;


{% endhighlight %}

{% endtabs %}

### Drawer header view

The header content can be provided to the primary drawer using the [DrawerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView)  property inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class. The following code demonstrates how to set the header content to the primary drawer.

{% tabs %}

{% highlight xaml %}

    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.DrawerSettings>
            <navigationdrawer:DrawerSettings Position="Left"
                                             DrawerHeaderHeight="150">
                <navigationdrawer:DrawerSettings.DrawerHeaderView>
                    <Grid BackgroundColor="#007DE6">
                        <Label Text="Header"
                               TextColor="White"
                               FontSize="20"
                               HorizontalOptions="Center"
                               VerticalOptions="Center" />
                    </Grid>
                </navigationdrawer:DrawerSettings.DrawerHeaderView>
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    </navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings drawerSettings = new DrawerSettings();
    drawerSettings.DrawerHeaderHeight = 150;
    drawerSettings.Position = Syncfusion.Maui.NavigationDrawer.Position.Left;
    Grid headerContent = new Grid();
    headerContent.BackgroundColor = Colors.Beige;
    Label header = new Label();
    header.Text = "Header";
    header.TextColor = Colors.White;
    header.FontSize = 20;
    header.HorizontalOptions = LayoutOptions.Center;
    header.VerticalOptions = LayoutOptions.Center;
    headerContent.Children.Add(header);
    drawerSettings.DrawerHeaderView = headerContent;
    navigationDrawer.DrawerSettings = drawerSettings;
    this.Content = navigationDrawer;
       
{% endhighlight %}

{% endtabs %}

### Drawer content view

The drawer content can be provided to the primary drawer using the [DrawerContentView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerContentView) property inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class. The following code demonstrates how to set the drawer content to the primary drawer.

{% tabs %}

{% highlight xaml %}

    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.DrawerSettings>
            <navigationdrawer:DrawerSettings Position="Left"
                                             DrawerWidth="250">
                <navigationdrawer:DrawerSettings.DrawerContentView>
                    <Grid BackgroundColor="#D4F1F4">
                        <Label Text="Drawer Content"
                               TextColor="Black"
                               FontSize="18"
                               HorizontalOptions="Center"
                               VerticalOptions="Center" />
                    </Grid>
                </navigationdrawer:DrawerSettings.DrawerContentView>
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    </navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings drawerSettings = new DrawerSettings();
    drawerSettings.Position = Syncfusion.Maui.NavigationDrawer.Position.Left;
    drawerSettings.DrawerWidth = 250;
    Grid drawerContent = new Grid();
    drawerContent.BackgroundColor = Colors.Blue;
    Label content = new Label();
    content.Text = "Drawer Content";
    content.TextColor = Colors.Black;
    content.FontSize = 18;
    content.HorizontalOptions = LayoutOptions.Center;
    content.VerticalOptions = LayoutOptions.Center;
    drawerContent.Children.Add(content);
    drawerSettings.DrawerContentView = drawerContent;
    navigationDrawer.DrawerSettings = drawerSettings;
    this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}

### Drawer footer view

The footer content can be provided to the primary drawer using the [DrawerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView) property inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class. The following code demonstrates how to set the footer content to the primary drawer.

{% tabs %}

{% highlight xaml %}
    
    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.DrawerSettings>
            <navigationdrawer:DrawerSettings Position="Left"
                                             DrawerFooterHeight="150">
                <navigationdrawer:DrawerSettings.DrawerFooterView>
                    <Grid BackgroundColor="#007DE6">
                        <Label Text="Footer"
                               TextColor="White"
                               FontSize="20"
                               HorizontalOptions="Center"
                               VerticalOptions="Center" />
                    </Grid>
                </navigationdrawer:DrawerSettings.DrawerFooterView>
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    </navigationdrawer:SfNavigationDrawer>


{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings drawerSettings = new DrawerSettings();
    drawerSettings.DrawerFooterHeight = 150;
    drawerSettings.Position = Syncfusion.Maui.NavigationDrawer.Position.Left;
    Grid footerContent = new Grid();
    footerContent.BackgroundColor = Colors.LightBlue;
    Label footer = new Label();
    footer.Text = "Footer";
    footer.TextColor = Colors.White;
    footer.FontSize = 20;
    footer.HorizontalOptions = LayoutOptions.Center;
    footer.VerticalOptions = LayoutOptions.Center;
    footerContent.Children.Add(footer);
    drawerSettings.DrawerFooterView = footerContent;
    navigationDrawer.DrawerSettings = drawerSettings;
    this.Content = navigationDrawer;
        
{% endhighlight %}

{% endtabs %}   

### SecondaryDrawerSettings

Implement the secondary drawer using the secondary drawer settings class. Its properties and functionalities are same as the primary drawer. The secondary drawer can be set to different positions similar to the primary drawer. The following code demonstrates how to set the secondary drawer settings's properties in XAML and C#.

{% tabs %}

{% highlight xaml %}

    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
            <navigationdrawer:DrawerSettings x:Name="secondaryDrawer"
                                    DrawerHeaderHeight="40"
                                    DrawerFooterHeight="40"
                                    ContentBackground="Blue"
                                    DrawerHeight="250"
                                    DrawerWidth= "250"
                                    Duration="400" 
                                    Position="Right"
                                    Transition="SlideOnTop">
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationdrawer:SfNavigationDrawer>
               
{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    secondaryDrawer.DrawerHeight = 250;
    secondaryDrawer.Position = Syncfusion.Maui.NavigationDrawer.Position.Right;
    secondaryDrawer.Transition = Syncfusion.Maui.NavigationDrawer.Transition.SlideOnTop;
    secondaryDrawer.ContentBackground = Colors.Blue;
    secondaryDrawer.DrawerWidth = 250;
    secondaryDrawer.DrawerHeaderHeight = 40;
    secondaryDrawer.DrawerFooterHeight = 40;
    navigationDrawer.SecondaryDrawerSettings = secondaryDrawer;
    this.Content = navigationDrawer;
  
{% endhighlight %}

{% endtabs %}

N> When the primary drawer and the secondary drawer are set to the same position, the primary drawer will open on swiping.

### Secondary drawer header view

The header content can be provided to the secondary drawer using the [DrawerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView)  property inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class of `SecondaryDrawerSettings`. The following code demonstrates how to set the header content to the secondary drawer.

{% tabs %}

{% highlight xaml %}
    
    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
                <navigationdrawer:DrawerSettings>
                    <navigationdrawer:DrawerSettings.DrawerHeaderView>
                        <Grid BackgroundColor="#007DE6">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="120"/>
                            </Grid.RowDefinitions>
                            <Label Text="Secondary Header" 
                                Grid.Row="0" 
                                HorizontalTextAlignment="Center" 
                                HorizontalOptions="Center" 
                                FontSize="20" 
                                TextColor="White"/>
                        </Grid>
                    </navigationdrawer:DrawerSettings.DrawerHeaderView>
                </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    Grid secondaryHeader = new Grid();
    secondaryHeader.BackgroundColor = Colors.LightBlue;
    Label header = new Label();
    header.Text = "Secondary Header";
    header.FontSize = 20;
    header.TextColor = Colors.White;
    header.HorizontalTextAlignment = TextAlignment.Center;
    secondaryHeader.Children.Add(header);
    secondaryDrawer.DrawerHeaderView = secondaryHeader;
    navigationDrawer.SecondaryDrawerSettings = secondaryDrawer;
    this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}      

### Secondary drawer content view

The drawer content can be provided to the secondary drawer using the [DrawerContentView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerContentView)  property inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class of `SecondaryDrawerSettings`. The following code demonstrates how to set the drawer content to the secondary drawer.

{% tabs %}

{% highlight xaml %}
    
    <navigationdrawer:SfNavigationDrawer>
    <navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
        <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <Grid BackgroundColor="#D4F1F4">
                    <Label Text="Secondary Drawer Content"  
                           HorizontalTextAlignment="Center" 
                           HorizontalOptions="Center" 
                           FontSize="20" 
                           TextColor="Black"/>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>   
    </navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationdrawer:SfNavigationDrawer>
      
{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    Grid secondaryContent = new Grid();
    secondaryContent.BackgroundColor = Color.FromHex("#D4F1F4");
    Label content = new Label();
    content.Text = "Secondary Drawer Content";
    content.FontSize = 20;
    content.TextColor = Colors.Black;
    content.HorizontalTextAlignment = TextAlignment.Center;
    secondaryContent.Children.Add(content);
    secondaryDrawer.DrawerContentView = secondaryContent;
    this.Content = navigationDrawer;
       

{% endhighlight %}

{% endtabs %}   

### Secondary drawer footer view

The footer content can be provided to the secondary drawer using the [DrawerFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView) property inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class of `SecondaryDrawerSettings`. The following code demonstrates how to set footer content to the secondary drawer.

{% tabs %}

{% highlight xaml %}
    
    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
            <navigationdrawer:DrawerSettings>
            <navigationdrawer:DrawerSettings.DrawerFooterView>
                <Grid BackgroundColor="#007DE6">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="120"/>
                    </Grid.RowDefinitions>
                    <Label Text="Secondary Footer" 
                        Grid.Row="0" 
                        HorizontalTextAlignment="Center" 
                        HorizontalOptions="Center" 
                        FontSize="20" 
                        TextColor="White"/>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerFooterView>
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    Grid secondaryFooter = new Grid();
    secondaryFooter.BackgroundColor = Colors.LightBlue;
    Label footer = new Label();
    footer.Text = "Secondary Footer";
    footer.FontSize = 20;
    footer.TextColor = Colors.White;
    footer.HorizontalTextAlignment = TextAlignment.Center;
    secondaryFooter.Children.Add(footer);
    secondaryDrawer.DrawerFooterView = secondaryFooter;
    navigationDrawer.SecondaryDrawerSettings = secondaryDrawer;
    this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}   

## Toggling method

Users can toggle the secondary drawer using the `ToggleSecondaryDrawer` method. 

{% highlight c# %} 

navigationDrawer.ToggleSecondaryDrawer();

{% endhighlight %}

### Opening the drawer programmatically

The `IsOpen` property in the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) of `SecondaryDrawerSettings` is used to open or close the drawer programmatically.

N> Users can open only one drawer at a time.



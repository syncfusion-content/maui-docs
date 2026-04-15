---
layout: post
title: Placing and Dragging in .NET MAUI Radial Menu Control | Syncfusion®
description: Learn all about placing and dragging support in Syncfusion® .NET MAUI Radial Menu (SfRadialMenu) control and more.
platform: MAUI
control: SfRadialMenu
documentation: UG
---

# Placing and Dragging in MAUI Radial Menu (SfRadialMenu)

You can place Radial Menu anywhere on its parent layout and drag it within the parent layout. 

## Dragging Radial Menu

You can enable or disable dragging by using the [`IsDragEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_IsDragEnabled) property.

{% tabs %}

{% highlight xaml %}
        <syncfusion:SfRadialMenu x:Name="radialMenu" 
                                 IsDragEnabled="true" >
        </syncfusion:SfRadialMenu>

{% endhighlight %}

{% highlight c# %}

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                IsDragEnabled = true,
            };
            this.Content = radialMenu;

{% endhighlight %}

{% endtabs %}

![Dragging Radial Menu](images/placing-dragging/maui-radialmenu-dragging.png)


## Rotation

You can enable or disable the rotation behavior of the Radial Menu by using the [`EnableRotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_EnableRotation) property.

{% tabs %}

{% highlight xaml %}
        <syncfusion:SfRadialMenu x:Name="radialMenu" 
                                  EnableRotation ="False">
        </syncfusion:SfRadialMenu>

{% endhighlight %}

{% highlight c# %}

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                EnableRotation = false
            };
            this.Content = radialMenu;
    
{% endhighlight %}

{% endtabs %}


## Drag events

[`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html) provides an event for [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) that is triggered when the Radial Menu begins to be dragged.

### DragBegin event

This event is triggered when the Radial Menu starts to drag, using [`DragBeginEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html).

* [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html#Syncfusion_Maui_RadialMenu_DragBeginEventArgs_Position) - Gets the starting position of the Radial Menu.

* [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html#Syncfusion_Maui_RadialMenu_DragBeginEventArgs_Handled) - Gets and sets a boolean value for enabling or disabling the dragging of the Radial Menu.

To hook the [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) event to obtain the start position and restrict dragging, follow the code example:

{% tabs %}

{% highlight xaml %}

    <radialMenu:SfRadialMenu x:Name="radialMenu"
                             DragBegin="RadialMenu_DragBegin"
                             IsDragEnabled = "True">
    </radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight c# %}

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                IsDragEnabled = true,
            };

            radialMenu.DragBegin += RadialMenu_DragBegin;
            this.Content = radialMenu;
        }

        private void RadialMenu_DragBegin(object sender, DragBeginEventArgs e)
        {
            e.Handled = true;
        }
    }

{% endhighlight %}
{% endtabs %}

### DragEnd event

This event is triggered when dragging ends in the Radial Menu, using [`DragEndEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html).

* [`OldValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html#Syncfusion_Maui_RadialMenu_DragEndEventArgs_OldValue) - Gets the start position of the Radial Menu.

* [`NewValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html#Syncfusion_Maui_RadialMenu_DragEndEventArgs_NewValue) - Gets the end position of the Radial Menu.

* [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html#Syncfusion_Maui_RadialMenu_DragEndEventArgs_Handled) - Gets and sets a boolean value to restrict the Radial Menu from moving to another position.

To hook the [`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragEnd) event and obtain start position, end position, and restrict movement, follow the code example:

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
    <radialMenu:SfRadialMenu x:Name="radialMenu" 
                             IsDragEnabled="true" 
                             DragEnd="radialMenu_DragEnd">
    </radialMenu:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight c# %}
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                IsDragEnabled = true,
            };

            radialMenu.DragEnd += radialMenu_DragEnd;
            this.Content = radialMenu;
        }

        private void radialMenu_DragEnd(object sender, DragEndEventArgs e)
        {
            e.Handled = true;
        }
    }

{% endhighlight %}
{% endtabs %}

## Placing Radial Menu

You can place the Radial Menu anywhere on its parent layout. The position of the Radial Menu is calculated based on the parent layout's center point.

{% tabs %}

{% highlight xaml %}
    <radialMenu:SfRadialMenu x:Name="radialMenu" 
                             Point="100, 150">
    </radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight c# %}

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                Point = new Point(100, 150)
            };

            this.Content = radialMenu;
            
{% endhighlight %}
{% endtabs %}
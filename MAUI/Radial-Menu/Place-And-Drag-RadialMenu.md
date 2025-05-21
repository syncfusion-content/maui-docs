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

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfRadialMenu x:Name="radialMenu" 
                                 IsDragEnabled="true" 
                                 CenterButtonText="&#xe710;"
                                 CenterButtonFontFamily="Maui Material Assets" 
                                 CenterButtonRadius="30"
                                 CenterButtonFontSize="26"
                                 CenterButtonBorderThickness="3">
        </syncfusion:SfRadialMenu>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                IsDragEnabled = true,
                CenterButtonText="&#xe710;",
                CenterButtonFontFamily="Maui Material Assets" ,
                CenterButtonRadius = 30,
                CenterButtonFontSize = 26,
                CenterButtonBorderThickness = 3
            };
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Dragging Radial Menu](images/placing-dragging/maui-radialmenu-dragging.png)

## Drag events

[`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html) provides an event for [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) that is triggered when the Radial Menu begins to be dragged.

### DragBegin event

This event is triggered when the Radial Menu starts to drag, using [`DragBeginEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html).

* [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html#Syncfusion_Maui_RadialMenu_DragBeginEventArgs_Position) - Gets the starting position of the Radial Menu.

* [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html#Syncfusion_Maui_RadialMenu_DragBeginEventArgs_Handled) - Gets and sets a boolean value for enabling or disabling the dragging of the Radial Menu.

To hook the [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) event to obtain the start position and restrict dragging, follow the code example:

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <radialMenu:SfRadialMenu x:Name="radialMenu"
                             DragBegin="RadialMenu_DragBegin"
                             IsDragEnabled = "True",
                             CenterButtonText="&#xe710;",
                             CenterButtonFontFamily="Maui Material Assets" ,
                             CenterButtonRadius = "30",
                             CenterButtonFontSize = "26",
                             CenterButtonBorderThickness = "3">
    </radialMenu:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                IsDragEnabled = true,
                CenterButtonText="&#xe710;",
                CenterButtonFontFamily="Maui Material Assets" ,
                CenterButtonRadius = 30,
                CenterButtonFontSize = 26,
                CenterButtonBorderThickness = 3
            };

            radialMenu.DragBegin += RadialMenu_DragBegin;
            this.Content = radialMenu;
        }

        private void RadialMenu_DragBegin(object sender, DragBeginEventArgs e)
        {
            e.Handled = true;
        }
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
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <radialMenu:SfRadialMenu x:Name="radialMenu" 
                             IsDragEnabled="true" 
                             DragEnd="radialMenu_DragEnd"
                             CenterButtonText="&#xe713;"
                             CenterButtonFontFamily="{StaticResource customfontfamily}" 
                             CenterButtonRadius="30"
                             CenterButtonFontSize="26" 
                             CenterButtonTextColor="White"
                             CenterButtonBorderColor="White" 
                             CenterButtonBorderThickness="3">
    </radialMenu:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                IsDragEnabled = true,
                CenterButtonText="&#xe710;",
                CenterButtonFontFamily="Maui Material Assets",
                CenterButtonRadius = 30,
                CenterButtonFontSize = 26,
                CenterButtonBorderThickness = 3
            };

            radialMenu.DragEnd += radialMenu_DragEnd;
            this.Content = radialMenu;
        }

        private void radialMenu_DragEnd(object sender, DragEndEventArgs e)
        {
            e.Handled = true;
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Placing Radial Menu

You can place the Radial Menu anywhere on its parent layout. The position of the Radial Menu is calculated based on the parent layout's center point.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <radialMenu:SfRadialMenu x:Name="radialMenu" 
                             Point="100, 150"
                             CenterButtonText="&#xe710;"
                             CenterButtonFontFamily="Maui Material Assets"
                             CenterButtonRadius="30"
                             CenterButtonFontSize="26" 
                             CenterButtonTextColor="White"
                             CenterButtonBorderColor="White" 
                             CenterButtonBorderThickness="3">
    </radialMenu:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonText="&#xe710;",
                CenterButtonFontFamily="Maui Material Assets",
                CenterButtonRadius = 30,
                CenterButtonFontSize = 26,
                CenterButtonBorderThickness = 3,
                Point = new Point(100, 150)
            };

            this.Content = radialMenu;
        }
    }
}
            
{% endhighlight %}
{% endtabs %}
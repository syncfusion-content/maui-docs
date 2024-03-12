---
layout: post
title: Placing and Dragging RadialMenu in MAUI Radial Menu | Syncfusion
description: Learn here all about Placing and Dragging RadialMenu support in Syncfusion MAUI Radial Menu (SfRadialMenu) control and more.
platform: .NET MAUI
control: RadialMenu (SfRadialMenu)
documentation: ug
---

# Placing and Dragging RadialMenu in MAUI Radial Menu (SfRadialMenu)

You can place radial menu anywhere on its parent layout, and drag it with in the parent layout. 

## Dragging RadialMenu

You can enable/disable dragging by using the [`IsDragEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_IsDragEnabled) property.

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

![Image for dragging](images/placing-dragging/maui-radialmenu-dragging.png)

## DragEvents

[`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) provides for event for [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_DragBegin) and [`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_DragEnd) in which the event get hooked when the RadialMenu is get dragged.

### DragBegin event

This event get triggered when RadialMenu is start to drag with [`DragBeginEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.DragBeginEventArgs.html).

* [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.DragBeginEventArgs.html#Syncfusion_Maui__SfRadialMenu_DragBeginEventArgs_Position) - Gets the Start position of the RadialMenu

* [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.DragBeginEventArgs.html#Syncfusion_Maui_SfRadialMenu_DragBeginEventArgs_Handled) - Gets and Sets the boolean value for enabling and disabling the dragging of RadialMenu.

To hook the [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_DragBegin) event, and to get the start position and restricts the dragging, follow the code example:

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

### Drag End

This event get triggered when dragging is ended in RadialMenu with [`DragEndEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.DragEndEventArgs.html).

* [`OldValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.DragEndEventArgs.html#Syncfusion_Maui_SfRadialMenu_DragEndEventArgs_OldValue) - Gets the Start position of the RadialMenu

* [`NewValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.DragEndEventArgs.html#Syncfusion_Maui_SfRadialMenu_DragEndEventArgs_NewValue) - Gets the ens position of the RadialMenu

* [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.DragEndEventArgs.html#Syncfusion_Maui_SfRadialMenu_DragEndEventArgs_Handled) - Gets and Sets the boolean value for restricting the RadialMenu to move another position.

To hook the [`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_SfRadialMenu_DragEnd) event, and to get the start position, end position and restricts the movement of the RadialMenu, follow the code example:

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

## Placing RadialMenu

You can place radial menu anywhere on its parent layout. Radial Menu's position is calculated based on parent layout's center point.

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
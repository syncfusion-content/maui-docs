---
layout: post
title: Events in MAUI Radial Menu Control | Syncfusion
description: Learn here all about Events support in Syncfusion MAUI Radial Menu control and more.
platform: MAUI
control: RadialMenu (SfRadialMenu)
documentation: ug
---

# Events in MAUI Radial Menu (SfRadialMenu)

## Perform an action while navigating to next level

In radial menu, you can perform an action while navigating from one level to another level. The [`Navigating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) event occurs when navigating from one level to another level and the [`Navigated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) event occurs after navigating to another level.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu Navigating="SfRadialMenu_Navigating" 
                             Navigated="SfRadialMenu_Navigated">
        <syncfusion:SfRadialMenu.Items>
            <syncfusion:SfRadialMenuItem Text="Bold" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Color" FontSize="12"/>
        </syncfusion:SfRadialMenu.Items>
    </syncfusion:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu();

            RadialMenuItemsCollection itemCollection = new RadialMenuItemsCollection()
            {
                new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            };
            
            radialMenu.Items = itemCollection;

            radialMenu.Navigating += SfRadialMenu_Navigating;
            radialMenu.Navigated += SfRadialMenu_Navigated;

            this.Content = radialMenu;
        }

        private async void SfRadialMenu_Navigating(object sender, NavigatingEventArgs e)
        {
           await DisplayAlert("Alert", "ItemNavigating", "Ok");
        }

        private async void SfRadialMenu_Navigated(object sender, NavigatedEventArgs e)
        {
           await DisplayAlert("Alert", "ItemNavigated", "Ok");
        }
    }
}

{% endhighlight %}

{% endtabs %}

N> You can cancel navigation using the `Cancel` event argument.

## Perform an action while opening the radial menu

You can perform an action while opening the radial menu. The [`Opening`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) event occurs when opening the radial menu and the [`Opened`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) event occurs after opening the radial menu.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu Opening ="SfRadialMenu_Opening" 
                             Opened="SfRadialMenu_Opened">
        <syncfusion:SfRadialMenu.Items>
            <syncfusion:SfRadialMenuItem Text="Bold" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Color" FontSize="12"/>
        </syncfusion:SfRadialMenu.Items>
    </syncfusion:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu();

            RadialMenuItemsCollection itemCollection = new RadialMenuItemsCollection()
            {
                new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            };
            
            radialMenu.Items = itemCollection;
            
            radialMenu.Opening += SfRadialMenu_Opening;
            radialMenu.Opened += SfRadialMenu_Opened;

            this.Content = radialMenu;
        }

        private async void SfRadialMenu_Opening(object sender, OpeningEventArgs e)
        {
           await DisplayAlert("Alert", "ItemOpening", "Ok");
        }

        private async void SfRadialMenu_Opened(object sender, OpenedEventArgs e)
        {
           await DisplayAlert("Alert", "ItemOpened", "Ok");
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Perform an action while closing the radial menu

You can perform an action when closing the radial menu. The [`Closing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) event occurs when closing the radial menu and the [`Closed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) event occurs after closing the radial menu.


{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu  Closing ="SfRadialMenu_Closing" 
                              Closed="SfRadialMenu_Closed">
        <syncfusion:SfRadialMenu.Items>
            <syncfusion:SfRadialMenuItem Text="Bold" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Color" FontSize="12"/>
        </syncfusion:SfRadialMenu.Items>
    </syncfusion:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu();

            RadialMenuItemsCollection itemCollection = RadialMenuItemsCollection()
            {
                new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            };
            
            radialMenu.Items = itemCollection;

            radialMenu.Closing += SfRadialMenu_Closing;
            radialMenu.Closed += SfRadialMenu_Closed;

            this.Content = radialMenu;
        }

        private async void SfRadialMenu_Closing(object sender, ClosingEventArgs e)
        {
           await DisplayAlert("Alert", "ItemClosing", "Ok");
        }

        private async void SfRadialMenu_Closed(object sender, ClosedEventArgs e)
        {
           await DisplayAlert("Alert", "ItemClosed", "Ok");
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Perform an action while tapping the center back button

You can perform an action when tapping the center back button of the radial menu. The [`CenterButtonBackTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html) event occurs when tapping the center button of the radial menu.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu CenterButtonBackTapped="SfRadialMenu_CenterButtonBackTapped">
        <syncfusion:SfRadialMenu.Items>
            <syncfusion:SfRadialMenuItem Text="Bold" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Color" FontSize="12"/>
        </syncfusion:SfRadialMenu.Items>
    </syncfusion:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu();

            RadialMenuItemsCollection itemCollection = RadialMenuItemsCollection()
            {
                new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            };
            
            radialMenu.Items = itemCollection;

            radialMenu.CenterButtonBackTapped += SfRadialMenu_CenterButtonBackTapped;
            this.Content = radialMenu;
        }

        private async void SfRadialMenu_CenterButtonBackTapped(object sender, CenterButtonBackTappedEventArgs e)
        {
           await DisplayAlert("Alert", "CenterButtonTapped", "Ok");
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Perform an action while tapping the radial menu item

You can perform an action when tapping the radial menu item of the radial menu. The [`ItemTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.SfRadialMenuItem.html) event occurs when tapping the items of the radial menu.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu>
        <syncfusion:SfRadialMenu.Items>
            <syncfusion:SfRadialMenuItem Text="Bold" FontSize="12" ItemTapped="SfRadialMenuItem_ItemTapped"/>
            <syncfusion:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <syncfusion:SfRadialMenuItem Text="Color" FontSize="12"/>
        </syncfusion:SfRadialMenu.Items>
    </syncfusion:SfRadialMenu>
</ContentPage>
 
 {% endhighlight %}

 {% highlight C# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu();

            RadialMenuItemsCollection itemCollection = new RadialMenuItemsCollection()
            {
                new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            };
            
            radialMenu.Items = itemCollection;

            radialMenu.Items[0].ItemTapped += SfRadialMenuItem_ItemTapped;
            this.Content = radialMenu;
        }

        private async void SfRadialMenuItem_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           await DisplayAlert("Alert", "ItemTapped", "Ok");
        }
    }
}

{% endhighlight %}

{% endtabs %}

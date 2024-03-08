---
layout: post
title: SfRadialMenuItems Customization in MAUI Radial Menu | Syncfusion
description: Learn here all about SfRadialMenuItems Customization support in Syncfusion MAUI Radial Menu (SfRadialMenu) control and more.
platform: .NET MAUI
control: RadialMenu (SfRadialMenu)
documentation: ug
---

# SfRadialMenuItems Customization in MAUI Radial Menu (SfRadialMenu)

The [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html) class provides various options to customize the items by giving `Custom Views`, `FontIcons`, and `Images`. You can add radial menu items by hierarchy. To add a [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html) with [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html), create an instance of [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html), and add it to the [`Items`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_ItemsProperty) property, which is available in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

## Items

The [`Items`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_ItemsProperty) property populates the items to the inner rim of [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html) when tapping the items of outer rim.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
             <syncfusion:SfRadialMenu CenterButtonText="Edit" 
                             CenterButtonFontSize="12">
                <syncfusion:SfRadialMenu.Items>
                    <syncfusion:SfRadialMenuItem Text="Bold" 
                                                 FontSize="12"/>
                    <syncfusion:SfRadialMenuItem Text="Copy" 
                                                 FontSize="12"/>
                    <syncfusion:SfRadialMenuItem Text="Undo" 
                                                 FontSize="12"/>
                    <syncfusion:SfRadialMenuItem Text="Paste" 
                                                 FontSize="12"/>
                    <syncfusion:SfRadialMenuItem Text="Color" FontSize="12">
                        <syncfusion:SfRadialMenuItem.Items>
                            <syncfusion:SfRadialMenuItem Text="Font" 
                                                         FontSize="12" 
                                                         ItemWidth="50"/>
                            <syncfusion:SfRadialMenuItem Text="Gradient" 
                                                         FontSize="12" 
                                                         ItemWidth="50"/>
                            <syncfusion:SfRadialMenuItem Text="Highlight" 
                                                         FontSize="12" 
                                                         ItemWidth="50"/>
                        </syncfusion:SfRadialMenuItem.Items>
                    </syncfusion:SfRadialMenuItem>
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
             string[] mainItem = new string[] { "Bold", "Copy", "Paste", "Undo", "Color" };
            string[] colorItem = new string[] { "Font", "Gradient", "Highlight" };

            SfRadialMenu radialMenu = new SfRadialMenu();

            // Adding radial menu outer rim items.

            for (int i = 0; i < 5; i++)
            {
                SfRadialMenuItem mainMenuItems = new SfRadialMenuItem();
                mainMenuItems.Text = mainItem[i];
                mainMenuItems.FontSize = 12;
                syncfusion.Items.Add(mainMenuItems);
            }

            // Adding inner rim items.

            for (int i = 0; i < 3; i++)
            {
                SfRadialMenuItem colorSubMenuItem = new SfRadialMenuItem();
                colorSubMenuItem.Text = colorItem[i];
                colorSubMenuItem.FontSize = 12;
                colorSubMenuItem.ItemWidth = 50;
                radialMenu.Items[4].Items.Add(colorSubMenuItem);
            }

            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Text

The [`Text`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_TextProperty) property provides text to the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

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
            RadialMenuItemsCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { Text = "Bold", FontSize = 12 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Copy", FontSize = 12 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Paste", FontSize = 12 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Undo", FontSize = 12 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Color", FontSize = 12 });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## ItemHeight and ItemWidth

The [`ItemHeight`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_ItemHeightProperty) changes the height of the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html) and The [`ItemWidth`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_ItemWidthProperty) property changes the width of the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

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
            <syncfusion:SfRadialMenuItem ItemHeight="60" ItemWidth="60" Text="John"  Image="johnson.png"/>
            <syncfusion:SfRadialMenuItem ItemHeight="60" ItemWidth="60" Text="Krish" Image="krish.png"/>
            <syncfusion:SfRadialMenuItem ItemHeight="60" ItemWidth="60" Text="Ram"   Image="ram.png"/>
            <syncfusion:SfRadialMenuItem ItemHeight="60" ItemWidth="60" Text="Kather"  Image="kather.png"/>
            <syncfusion:SfRadialMenuItem ItemHeight="60" ItemWidth="60" Text="Joe"  Image="joe.png"/>
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
            RadialMenuItemsCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { Text="John",  Image="johnson.png", ItemHeight=60, ItemWidth=60 });
            itemCollection.Add(new SfRadialMenuItem() { Text="Krish", Image="krish.png", ItemHeight=60, ItemWidth=60 });
            itemCollection.Add(new SfRadialMenuItem() { Text="Ram",   Image="ram.png", ItemHeight=60, ItemWidth=60 });
            itemCollection.Add(new SfRadialMenuItem() { Text="Kather",  Image="kather.png", ItemHeight=60, ItemWidth=60 });
            itemCollection.Add(new SfRadialMenuItem() { Text="Joe",  Image="joe.png", ItemHeight=60, ItemWidth=60 });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## BackgroundColor

The [`BackgroundColor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_BackgroundColorProperty) property changes the background color of the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <radialMenu:SfRadialMenu>
        <radialMenu:SfRadialMenuItem.Items>
            <radialMenu:SfRadialMenuItem BackgroundColor="#00cc1d" />
            <radialMenu:SfRadialMenuItem BackgroundColor="#c65619" />
            <radialMenu:SfRadialMenuItem BackgroundColor="#F17525" />
            <radialMenu:SfRadialMenuItem BackgroundColor="#0bb4c3" />
            <radialMenu:SfRadialMenuItem BackgroundColor="#0051d4" />
        </radialMenu:SfRadialMenuItem.Items>
    </radialMenu:SfRadialMenu>
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
            RadialMenuItemsCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { BackgroundColor= Color.FromArgb("#00cc1d") });
            itemCollection.Add(new SfRadialMenuItem() { BackgroundColor= Color.FromArgb("#c65619") });
            itemCollection.Add(new SfRadialMenuItem() { BackgroundColor= Color.FromArgb("#F17525") });
            itemCollection.Add(new SfRadialMenuItem() { BackgroundColor= Color.FromArgb("#0bb4c3") });
            itemCollection.Add(new SfRadialMenuItem() { BackgroundColor= Color.FromArgb("#0051d4") });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## FontFamily

The [`FontFamily`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_FontFamilyProperty) property changes the font family of text in [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

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
            <syncfusion:SfRadialMenuItem Text="John" FontFamily="Times New Roman"/>
            <syncfusion:SfRadialMenuItem Text="Krish" FontFamily="Times New Roman"/>
            <syncfusion:SfRadialMenuItem Text="Ram" FontFamily="Times New Roman"/>
            <syncfusion:SfRadialMenuItem Text="Kather" FontFamily="Times New Roman"/>
            <syncfusion:SfRadialMenuItem Text="Joe" FontFamily="Times New Roman"/>
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
            RadialMenuItemsCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { Text = "Bold", FontFamily="Times New Roman" });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Copy", FontFamily="Times New Roman" });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Paste", FontFamily="Times New Roman" });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Undo", FontFamily="Times New Roman" });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Color", FontFamily="Times New Roman" });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## FontSize

The [`FontSize`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_FontSizeProperty) property changes the text size in the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

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
            <syncfusion:SfRadialMenuItem Text="John" FontSize="16"/>
            <syncfusion:SfRadialMenuItem Text="Krish" FontSize="18"/>
            <syncfusion:SfRadialMenuItem Text="Ram" FontSize="20"/>
            <syncfusion:SfRadialMenuItem Text="Kather" FontSize="22"/>
            <syncfusion:SfRadialMenuItem Text="Joe" FontSize="24"/>
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
            RadialMenuItemsCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { Text = "Bold",  FontSize=16 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Copy", FontSize=18 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Paste", FontSize=20 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Undo", FontSize=22 });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Color", FontSize=24 });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## FontAttributes

The [`FontAttributes`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_FontAttributesProperty) property changes the font attributes of text in [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

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
            <syncfusion:SfRadialMenuItem Text="John" FontAttributes="None"/>
            <syncfusion:SfRadialMenuItem Text="Krish" FontAttributes="Bold"/>
            <syncfusion:SfRadialMenuItem Text="Ram" FontAttributes="Italic"/>
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
            RadialMenuItemsCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { Text = "Bold",  FontAttributes = FontAttributes.None });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Copy", FontAttributes = FontAttributes.Bold });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Paste", FontAttributes = FontAttributes.Italic });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Image

The [`Image`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_ImageProperty) property provides image to the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

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
            <syncfusion:SfRadialMenuItem Image="johnson.png"/>
            <syncfusion:SfRadialMenuItem Image="krish.png"/>
            <syncfusion:SfRadialMenuItem Image="ram.png"/>
            <syncfusion:SfRadialMenuItem Image="kather.png"/>
            <syncfusion:SfRadialMenuItem Image="joe.png"/>
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
            RadialMenuItemsCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { Image="johnson.png" });
            itemCollection.Add(new SfRadialMenuItem() { Image="krish.png" });
            itemCollection.Add(new SfRadialMenuItem() { Image="ram.png" });
            itemCollection.Add(new SfRadialMenuItem() { Image="kather.png" });
            itemCollection.Add(new SfRadialMenuItem() { Image="joe.png" });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## View

The [`View`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenuItem_ViewProperty) provides custom view to the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <radialMenu:SfRadialMenu>
        <radialMenu:SfRadialMenu.Items>
            <radialMenu:SfRadialMenuItem>
                <radialMenu:SfRadialMenuItem.View>
                    <Label Text="Cut"
                               HorizontalTextAlignment="Center"
                               VerticalTextAlignment="Center"/>
                </radialMenu:SfRadialMenuItem.View>
            </radialMenu:SfRadialMenuItem>
             <radialMenu:SfRadialMenuItem>
                <radialMenu:SfRadialMenuItem.View>
                    <Label Text="Copy"
                               HorizontalTextAlignment="Center"
                               VerticalTextAlignment="Center"/>
                </radialMenu:SfRadialMenuItem.View>
            </radialMenu:SfRadialMenuItem>
             <radialMenu:SfRadialMenuItem>
                <radialMenu:SfRadialMenuItem.View>
                    <Label Text="Paste"
                               HorizontalTextAlignment="Center"
                               VerticalTextAlignment="Center"/>
                </radialMenu:SfRadialMenuItem.View>
            </radialMenu:SfRadialMenuItem>
        </radialMenu:SfRadialMenu.Items>
    </radialMenu:SfRadialMenu>
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
            radialMenu.Items.Add(new SfRadialMenuItem()
            {
                View = new Label()
                {
                    Text = "Cut",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                }
            });
            radialMenu.Items.Add(new SfRadialMenuItem()
            {
                View = new Label()
                {
                    Text = "Copy",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                }
            });
            radialMenu.Items.Add(new SfRadialMenuItem()
            {
                View = new Label()
                {
                    Text = "Paste",
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                }
            });

            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Command for SfRadialMenuItem

The [`Command`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_Command) property is used to associate a command with an instance of [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html). This property is most often set with MVVM pattern to bind callbacks back into the ViewModel.

When clicking the [`SfRadialMenuItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenuItem.html), the tapped item will be displayed. The following example shows how the command should be used.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage"
             mc:Ignorable="d"
             x:Class="RadialCommandSample.MainPage">
    <ContentPage.Content>
        <Grid>
            <radialMenu:SfRadialMenu x:Name="radialMenu"                              
                             CenterButtonText="Edit"
                             CenterButtonFontSize="15">
                <radialMenu:SfRadialMenu.Items>
                    <radialMenu:SfRadialMenuItem  Command="{Binding Item1Command}" CommandParameter="Bold is tapped"  Text="Bold"
                                         FontSize="15"/>
                    <radialMenu:SfRadialMenuItem Command="{Binding Item2Command}" CommandParameter="Copy is tapped"  Text="Copy"
                                         FontSize="15"/>
                    <radialMenu:SfRadialMenuItem Command="{Binding Item3Command}" CommandParameter="Paste is tapped" Text="Paste"
                                         FontSize="15"/>
                    <radialMenu:SfRadialMenuItem Command="{Binding Item4Command}" CommandParameter="Crop is tapped" Text="Crop"
                                         FontSize="15"/>
                    <radialMenu:SfRadialMenuItem Command="{Binding Item5Command}" CommandParameter="Paint is tapped" Text="Paint"
                                         FontSize="15"/>
                </radialMenu:SfRadialMenu.Items>
            </radialMenu:SfRadialMenu>
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c#%}

using Syncfusion.Maui.RadialMenu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RadialCommandSample
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel= new ViewModel(this);
            SfRadialMenu radialMenu = new SfRadialMenu();
            ObservableCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            itemCollection.Add(new SfRadialMenuItem() { Text = "Bold", FontSize = 12 , Command = viewModel.Item1Command , CommandParameter = "Bold is tapped"});
            itemCollection.Add(new SfRadialMenuItem() { Text = "Copy", FontSize = 12 , Command =viewModel.Item2Command, CommandParameter = "Copy is tapped" });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Paste", FontSize = 12, Command = viewModel.Item3Command , CommandParameter = "Paste is tapped" });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Crop", FontSize = 12, Command = viewModel.Item4Command, CommandParameter = "Crop is tapped" });
            itemCollection.Add(new SfRadialMenuItem() { Text = "Paint", FontSize = 12, Command = viewModel.Item5Command, CommandParameter = "Paint is tapped" });
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}
{% endtabs %}

Define the [`Command`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_Command) in the RadialMenuItem, and then populate the action in ViewModel.

{% highlight c#%}

using Syncfusion.Maui.RadialMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace RadialCommandSample
{

     // View Model
 public  class ViewModel : INotifyPropertyChanged
    { 
        private ICommand item1Command;
        public ICommand Item1Command
        {
            get { return item1Command; }
            set
            {
                item1Command = value;
                OnPropertyRaised("Item1Command");
            }
        }

        private ICommand item2Command;
        public ICommand Item2Command
        {
            get { return item2Command; }
            set
            {
                item2Command = value;
                OnPropertyRaised("Item2Command");
            }
        }

        private ICommand item3Command;
        public ICommand Item3Command
        {
            get { return item3Command; }
            set
            {
                item3Command = value;
                OnPropertyRaised("Item3Command");
            }
        }

        private ICommand item4Command;
        public ICommand Item4Command
        {
            get { return item4Command; }
            set
            {
                item4Command = value;
                OnPropertyRaised("Item4Command");
            }
        }

        private ICommand item5Command;
        public ICommand Item5Command
        {
            get { return item5Command; }
            set
            {
                item5Command = value;
                OnPropertyRaised("Item5Command");
            }
        }

        Page page;

        public ViewModel(Page page)
        {
            this.page = page;
            Item1Command = new Command(ButtonClicked);
            Item2Command = new Command(ButtonClicked);
            Item3Command = new Command(ButtonClicked);
            Item4Command = new Command(ButtonClicked);
            Item5Command = new Command(ButtonClicked);
        }

        private async void ButtonClicked(object sender)
        {
            var text = (sender as string).ToString();
            await page.DisplayAlert("Alert", text, "OK");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }

        }
    }
}

{% endhighlight %}

N> View [sample](https://github.com/SyncfusionExamples/xamarin-sfradialmenu-examples/tree/main/Samples/CommandSample)  in GitHub

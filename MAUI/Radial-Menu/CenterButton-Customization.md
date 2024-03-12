---
layout: post
title: CenterButton Customization in MAUI Radial Menu Control | Syncfusion
description: Learn CenterButton Customization in Syncfusion MAUI Radial Menu & more.
platform: MAUI
control: RadialMenu (SfRadialMenu)
documentation: ug
---

# CenterButton Customization in MAUI Radial Menu (SfRadialMenu)

The CenterButton or BackButton in radial menu is a view in the center of the radial menu. It performs the operations such as opening and closing the rim and navigating to the next level items. The radial menu allows you customize the CenterButton/BackButton with `FontIcon`, `Custom View`, and `Caption`.

## CenterButtonText and CenterButtonBackText

The [`CenterButtonText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_CenterButtonTextProperty) changes the text of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html), and the [`CenterButtonBackText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_CenterButtonBackTextProperty) changes the text of the center back button in [`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu
                    CenterButtonText="Edit"
                    CenterButtonBackText="Back">
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

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
               CenterButtonText = "Edit",
               CenterButtonBackText = "Back",
            };

            for (int i = 0; i < 5; i++)
            {
                SfRadialMenuItem mainMenuItems = new SfRadialMenuItem();
                mainMenuItems.Text = mainItem[i];
                mainMenuItems.FontSize = 12;
                syncfusion.Items.Add(mainMenuItems);
            }

            for (int i = 0; i < 3; i++)
            {
                SfRadialMenuItem colorSubMenuItem = new SfRadialMenuItem();
                colorSubMenuItem.Text = colorItem[i];
                colorSubMenuItem.FontSize = 12;
                colorSubMenuItem.ItemWidth = 50;
                radialMenu.Items[4].Items.Add(colorSubMenuItem);
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonTextColor and CenterButtonBackTextColor

The [`CenterButtonTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMen_CenterButtonTextColorProperty) changes the text color of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html), and the [`CenterButtonBackTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html#Syncfusion_Maui_SfRadialMenu_CenterButtonBackTextColorProperty) changes the text color of the center back button in [`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu
                    CenterButtonTextColor="Blue"
                    CenterButtonText="Edit"
                    CenterButtonBackTextColor="Yellow"
                    CenterButtonBackText="Back">
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

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonText = "Edit",
                CenterButtonBackText = "Back",
                CenterButtonTextColor = Colors.Blue,
                CenterButtonBackTextColor = Colors.Yellow,
            };
            
            for (int i = 0; i < 5; i++)
            {
                SfRadialMenuItem mainMenuItems = new SfRadialMenuItem();
                mainMenuItems.Text = mainItem[i];
                mainMenuItems.FontSize = 12;
                syncfusion.Items.Add(mainMenuItems);
            }

            for (int i = 0; i < 3; i++)
            {
                SfRadialMenuItem colorSubMenuItem = new SfRadialMenuItem();
                colorSubMenuItem.Text = colorItem[i];
                colorSubMenuItem.FontSize = 12;
                colorSubMenuItem.ItemWidth = 50;
                radialMenu.Items[4].Items.Add(colorSubMenuItem);
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonBackgroundColor

The [`CenterButtonBackgroundColor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBackgroundColorProperty) changes the background color of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu  CenterButtonBackgroundColor="#000000">
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
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonBackgroundColor = Color.FromArgb("#000000")
            };

            RadialMenuItemsCollection itemCollection =  new RadialMenuItemsCollection()
            {
                new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
                new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            };
           
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonRadius

The [`CenterButtonRadius`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonRadiusProperty) changes the radius of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu  CenterButtonRadius="5">
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
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonRadius = 5
            };

            RadialMenuItemsCollection itemCollection =  new RadialMenuItemsCollection()
            new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonFontFamily and CenterButtonBackFontFamily

The [`CenterButtonFontFamily`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonFontFamilyProperty) changes the font family of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html), and the [`CenterButtonBackFontFamily`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBackFontFamilyProperty) changes the font family of the center back button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu CenterButtonBackFontFamily="Maui Material Assets"
                    CenterButtonBackText="&#xe72d;"
                    CenterButtonFontFamily="Maui Material Assets"
                    CenterButtonText="&#xe710;">
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
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonBackFontFamily="Maui Material Assets",
                CenterButtonBackText="&#xe72d;",
                CenterButtonFontFamily="Maui Material Assets",
                CenterButtonText="&#xe710;",
            };

            for (int i = 0; i < 5; i++)
            {
                SfRadialMenuItem mainMenuItems = new SfRadialMenuItem();
                mainMenuItems.Text = mainItem[i];
                mainMenuItems.FontSize = 12;
                syncfusion.Items.Add(mainMenuItems);
            }

            for (int i = 0; i < 3; i++)
            {
                SfRadialMenuItem colorSubMenuItem = new SfRadialMenuItem();
                colorSubMenuItem.Text = colorItem[i];
                colorSubMenuItem.FontSize = 12;
                colorSubMenuItem.ItemWidth = 50;
                radialMenu.Items[4].Items.Add(colorSubMenuItem);
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonFontSize and CenterButtonBackFontSize

The [`CenterButtonFontSize`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonFontSizeProperty) changes the font size of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html), and the [`CenterButtonBackFontSize`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBackFontSizeProperty) changes the font size of the center back button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu CenterButtonBackFontFamily="Maui Material Assets"
                    CenterButtonBackFontSize="28"
                    CenterButtonBackText="&#xe72d;"
                    CenterButtonFontFamily="Maui Material Assets"
                    CenterButtonFontSize="20"
                    CenterButtonText="&#xe710;">
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
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonBackFontFamily="Maui Material Assets",
                CenterButtonBackFontSize=28,
                CenterButtonBackText="&#xe72d;",
                CenterButtonFontFamily="Maui Material Assets",
                CenterButtonFontSize=20,
                CenterButtonText="&#xe710;",
            };

            for (int i = 0; i < 5; i++)
            {
                SfRadialMenuItem mainMenuItems = new SfRadialMenuItem();
                mainMenuItems.Text = mainItem[i];
                mainMenuItems.FontSize = 12;
                syncfusion.Items.Add(mainMenuItems);
            }

            for (int i = 0; i < 3; i++)
            {
                SfRadialMenuItem colorSubMenuItem = new SfRadialMenuItem();
                colorSubMenuItem.Text = colorItem[i];
                colorSubMenuItem.FontSize = 12;
                colorSubMenuItem.ItemWidth = 50;
                radialMenu.Items[4].Items.Add(colorSubMenuItem);
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonFontAttributes and CenterButtonBackFontAttributes

The [`CenterButtonFontAttributes`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonFontAttributesProperty) changes the font attributes of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu CenterButtonText="Edit"
                             CenterButtonBackText="Back
                             CenterButtonFontAttributes="Bold"
                             CenterButtonBackFontAttributes="Bold">
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
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonText = "Edit",
                CenterButtonBackText = "Back",
                CenterButtonFontAttributes = FontAttributes.Bold,
                CenterButtonBackFontAttributes = FontAttributes.Bold,
            };

             for (int i = 0; i < 5; i++)
            {
                SfRadialMenuItem mainMenuItems = new SfRadialMenuItem();
                mainMenuItems.Text = mainItem[i];
                mainMenuItems.FontSize = 12;
                syncfusion.Items.Add(mainMenuItems);
            }

            for (int i = 0; i < 3; i++)
            {
                SfRadialMenuItem colorSubMenuItem = new SfRadialMenuItem();
                colorSubMenuItem.Text = colorItem[i];
                colorSubMenuItem.FontSize = 12;
                colorSubMenuItem.ItemWidth = 50;
                radialMenu.Items[4].Items.Add(colorSubMenuItem);
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonBorderColor

The [`CenterButtonBorderColor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBorderColorProperty) changes the border color of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu CenterButtonBorderColor="Black">
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
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonBorderColor = Color.Black
            };

            RadialMenuItemsCollection itemCollection =  new RadialMenuItemsCollection()
            new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## CenterButtonBorderThickness

The [`CenterButtonBorderThickness`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBorderThicknessProperty) changes the border thickness of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu 
                             CenterButtonBorderColor="Black"
                             CenterButtonBorderThickness="5">
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
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonBorderColor = Color.Black,
                CenterButtonBorderThickness = 5,
            };

            RadialMenuItemsCollection itemCollection =  new RadialMenuItemsCollection()
            new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Center button view and center back button view

You can customize the center button using [`CenterButtonView`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonViewProperty)and center back button using [`CenterButtonBackView`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_CenterButtonBackViewProperty) in  [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu x:Name="radialMenu">
        <syncfusion:SfRadialMenu.CenterButtonView>
            <Grid>
                <StackLayout VerticalOptions="Center">
                    <Image Source="Beverage1.png"/>
                </StackLayout>
            </Grid>
        </syncfusion:SfRadialMenu.CenterButtonView>
        <syncfusion:SfRadialMenu.CenterButtonBackView>
            <Grid>
                <StackLayout VerticalOptions="Center">
                    <Image Source="Beverage2.png"/>
                </StackLayout>
            </Grid>
        </syncfusion:SfRadialMenu.CenterButtonBackView>
    </syncfusion:SfRadialMenu>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.RadialMenu;
using System.Collections.ObjectModel;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Grid centerButtonGrid = new Grid();
            Grid centerButtonBackGrid = new Grid();
            StackLayout centerButtonLayout = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center
            };
            StackLayout centerButtonBackLayout = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center
            };

            centerButtonLayout.Children.Add(new Image() { Source = "Beverage1.png" });
            centerButtonGrid.Children.Add(centerButtonLayout);
            centerButtonBackLayout.Children.Add(new Image() { Source = "Beverage2.png" });
            centerButtonBackGrid.Children.Add(centerButtonBackLayout);

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonView = centerButtonGrid,
                CenterButtonBackView = centerButtonBackGrid
            };

            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## EnableCenterButtonAnimation

The [`EnableCenterButtonAnimation`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html#Syncfusion_SfRadialMenu_XForms_SfRadialMenu_EnableCenterButtonAnimationProperty) is used to either enable or disable animation of the center button in [`SfRadialMenu`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRadialMenu.XForms.SfRadialMenu.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:RadialSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="RadialSample.MainPage">
    <syncfusion:SfRadialMenu  EnableCenterButtonAnimation="True">
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
using System.Collections.ObjectModel;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                EnableCenterButtonAnimation = true
            };

            RadialMenuItemsCollection itemCollection =  new RadialMenuItemsCollection()
            new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
            new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
            radialMenu.Items = itemCollection;
            this.Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

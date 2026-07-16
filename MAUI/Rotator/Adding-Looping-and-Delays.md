---
layout: post
title: Adding Looping and Delays in .NET MAUI Rotator control | Syncfusion®
description: Learn about adding looping and delay support in the Syncfusion® .NET MAUI Rotator (SfRotator) control.
platform: maui 
control: Rotator
documentation: ug
---

# Adding Looping and Delays in .NET MAUI Rotator (SfRotator)

Looping and delay can be enabled in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1) control in .NET MAUI.

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install the [Syncfusion.Maui.Rotator](https://www.nuget.org/packages/Syncfusion.Maui.Rotator) NuGet package in your .NET MAUI project.
2. Register the Rotator handler in `MauiProgram.cs`:

    ```csharp
    builder.ConfigureSyncfusionRotator();
    ```

3. Add the required image assets (e.g., `image1.png` through `image5.png`) to the `Resources/Images` folder of your project.
4. Define a `RotatorModel` and a `RotatorViewModel` to supply the image collection. For example:

    ```csharp
    using System.Collections.ObjectModel;

    namespace Rotator
    {
        public class RotatorModel
        {
            public RotatorModel(string imageString)
            {
                Image = imageString;
            }
            private string _image;
            public string Image
            {
                get { return _image; }
                set { _image = value; }
            }
        }

        public class RotatorViewModel
        {
            public ObservableCollection<RotatorModel> ImageCollection { get; set; }

            public RotatorViewModel()
            {
                ImageCollection = new ObservableCollection<RotatorModel>
                {
                    new RotatorModel("image1.png"),
                    new RotatorModel("image2.png"),
                    new RotatorModel("image3.png"),
                    new RotatorModel("image4.png"),
                    new RotatorModel("image5.png")
                };
            }
        }
    }
    ```

> **Note:** For complete setup steps, refer to the [Getting Started with .NET MAUI Rotator](https://help.syncfusion.com/maui/Rotator/getting-started) documentation.

## Properties Reference

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `EnableAutoPlay` | `bool` | `false` | Specifies whether the items should navigate automatically. |
| `NavigationDelay` | `double` | `2000` | Specifies the delay (in milliseconds) before switching to the next item. Effective only when `EnableAutoPlay` is `true`. |
| `EnableLooping` | `bool` | `false` | Specifies whether the items should loop back to the first item after reaching the last item. |
| `EnableSwiping` | `bool` | `true` | Specifies whether the user can swipe between items. |

## Enable AutoPlay

The [`EnableAutoPlay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableAutoPlay) property specifies whether the items should navigate automatically based on the [`NavigationDelay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDelay) property when `EnableAutoPlay` is set to `true`.

N> By default, the property value is set to `false`.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
            xmlns:local="clr-namespace:Rotator"
            x:Class="Rotator.RotatorPage">
    <ContentPage.BindingContext>
        <local:RotatorViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <rotator:SfRotator x:Name="rotator" 
                        ItemsSource="{Binding ImageCollection}" 
                        SelectedIndex="2"
                        NavigationDirection="Horizontal"
                        NavigationStripMode="Thumbnail" 
                        BackgroundColor="#ececec"
                        EnableAutoPlay="true"
                        NavigationStripPosition="Bottom">
            <rotator:SfRotator.ItemTemplate>
                <DataTemplate>
                    <Image  Source="{Binding Image}"/>
                </DataTemplate>
            </rotator:SfRotator.ItemTemplate>
        </rotator:SfRotator>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}
    
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Rotator;

namespace Rotator
{
    public partial class RotatorPage : ContentPage
    {
        public RotatorPage()
        {
            InitializeComponent();
            SfRotator rotator = new SfRotator();
            var ImageCollection = new List<RotatorModel> {
            new RotatorModel ("image1.png"),
            new RotatorModel ("image2.png"),
            new RotatorModel ("image3.png"),
            new RotatorModel ("image4.png"),
            new RotatorModel ("image5.png")
            };
            var itemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                var nameLabel = new Image();
                nameLabel.SetBinding(Image.SourceProperty, "Image");
                grid.Children.Add(nameLabel);
                return grid;
            });
            rotator.ItemTemplate = itemTemplate;
            rotator.EnableAutoPlay = true;
            rotator.NavigationDelay = 2000;
            rotator.ItemsSource = ImageCollection;
            this.Content = rotator;
        }
    }
    public class RotatorModel
    {
        public RotatorModel(string imageString)
        {
            Image = imageString;
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Setting Navigation Delay

The [`NavigationDelay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDelay) property specifies the delay duration before switching to the next item when [`EnableAutoPlay`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableAutoPlay) is enabled.

N> The property value should be in milliseconds. If `EnableAutoPlay` is `false`, the `NavigationDelay` value has no effect.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?> 
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
            xmlns:local="clr-namespace:Rotator"
            x:Class="Rotator.RotatorPage">
    <ContentPage.BindingContext>
        <local:RotatorViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <rotator:SfRotator x:Name="rotator" 
                        NavigationDelay="2000" 
                        ItemsSource="{Binding ImageCollection}" 
                        SelectedIndex="2"
                        NavigationDirection="Horizontal"
                        NavigationStripMode="Thumbnail" 
                        BackgroundColor="#ececec"
                        EnableAutoPlay="true"
                        NavigationStripPosition="Bottom">
            <rotator:SfRotator.ItemTemplate>
                <DataTemplate>
                    <Image  Source="{Binding Image}"/>
                </DataTemplate>
            </rotator:SfRotator.ItemTemplate>
        </rotator:SfRotator>
    </ContentPage.Content>
</ContentPage>
	
{% endhighlight %}

{% highlight C# %}

using System.Collections.Generic;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Rotator;

namespace Rotator
{
    public partial class RotatorPage : ContentPage
    {
        public RotatorPage()
        {
            InitializeComponent();
            SfRotator rotator = new SfRotator();
            var ImageCollection = new List<RotatorModel> {
            new RotatorModel ("image1.png"),
            new RotatorModel ("image2.png"),
            new RotatorModel ("image3.png"),
            new RotatorModel ("image4.png"),
            new RotatorModel ("image5.png")
            };
            var itemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                var nameLabel = new Image();
                nameLabel.SetBinding(Image.SourceProperty, "Image");
                grid.Children.Add(nameLabel);
                return grid;
            });
            rotator.ItemTemplate = itemTemplate;
            rotator.EnableAutoPlay = true;
            rotator.NavigationDelay = 2000;
            rotator.ItemsSource = ImageCollection;
            this.Content = rotator;
        }
    }
    public class RotatorModel
    {
        public RotatorModel(string imageString)
        {
            Image = imageString;
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Looping Items

The [`EnableLooping`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableLooping) property specifies whether the items should navigate to the first item once they reach the last item and vice-versa.

N> By default, the property value is set to `false`.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?> 
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
            xmlns:local="clr-namespace:Rotator"
            x:Class="Rotator.RotatorPage">
    <ContentPage.BindingContext>
        <local:RotatorViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <rotator:SfRotator x:Name="rotator" 
                        NavigationDelay="2000" 
                        ItemsSource="{Binding ImageCollection}" 
                        SelectedIndex="2"
                        NavigationDirection="Horizontal"
                        NavigationStripMode="Thumbnail" 
                        BackgroundColor="#ececec"
                        EnableAutoPlay="true"
                        EnableLooping="true"
                        NavigationStripPosition="Bottom">
            <rotator:SfRotator.ItemTemplate>
                <DataTemplate>
                    <Image  Source="{Binding Image}"/>
                </DataTemplate>
            </rotator:SfRotator.ItemTemplate>
        </rotator:SfRotator>
    </ContentPage.Content>
</ContentPage>
	
{% endhighlight %}

{% highlight C# %}

using System.Collections.Generic;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Rotator;

namespace Rotator
{
    public partial class RotatorPage : ContentPage
    {
        public RotatorPage()
        {
            InitializeComponent();
            SfRotator rotator = new SfRotator();
            var ImageCollection = new List<RotatorModel> {
            new RotatorModel ("image1.png"),
            new RotatorModel ("image2.png"),
            new RotatorModel ("image3.png"),
            new RotatorModel ("image4.png"),
            new RotatorModel ("image5.png")
            };
            var itemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                var nameLabel = new Image();
                nameLabel.SetBinding(Image.SourceProperty, "Image");
                grid.Children.Add(nameLabel);
                return grid;
            });
            rotator.ItemTemplate = itemTemplate;
            rotator.EnableAutoPlay = true;
            rotator.NavigationDelay = 2000;
            rotator.EnableLooping = true;
            rotator.ItemsSource = ImageCollection;
            this.Content = rotator;
        }
    }
    public class RotatorModel
    {
        public RotatorModel(string imageString)
        {
            Image = imageString;
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## See Also

- [Getting Started with .NET MAUI Rotator (SfRotator)](https://help.syncfusion.com/maui/Rotator/getting-started)
- [Navigation Direction in .NET MAUI Rotator](https://help.syncfusion.com/maui/Rotator/navigation)
- [Navigation Strip Mode in .NET MAUI Rotator](https://help.syncfusion.com/maui/Rotator/navigation-strip)
- [.NET MAUI Rotator Release Notes](https://help.syncfusion.com/maui/Rotator/release-notes)

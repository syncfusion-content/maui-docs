---
layout: post
title: Sliding Direction in .NET MAUI Rotator control | Syncfusion®
description: Learn here all about Sliding Direction support in Syncfusion® .NET MAUI Rotator (SfRotator) control and more.
platform: maui 
control: Rotator
documentation: ug
---

# Sliding Direction in .NET MAUI Rotator (SfRotator)

There are six available positions:

* [`Horizontal`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html#Syncfusion_Maui_Core_Rotator_NavigationDirection_Horizontal) - Navigate rotator items in the horizontal direction.
* [`Vertical`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html#Syncfusion_Maui_Core_Rotator_NavigationDirection_Vertical) - Navigate rotator items in the vertical direction.
* [`LeftToRight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html#Syncfusion_Maui_Core_Rotator_NavigationDirection_LeftToRight) - Navigate rotator items from left to right only.
* [`RightToLeft`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html#Syncfusion_Maui_Core_Rotator_NavigationDirection_RightToLeft) - Navigate rotator items from right to left only.
* [`TopToBottom`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html#Syncfusion_Maui_Core_Rotator_NavigationDirection_TopToBottom) - Navigate rotator items from top to bottom only.
* [`BottomToTop`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html#Syncfusion_Maui_Core_Rotator_NavigationDirection_BottomToTop) - Navigate rotator items from bottom to top only.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
            xmlns:local="clr-namespace:Rotator"
            x:Class="Rotator.Rotator">
    <ContentPage.BindingContext>
        <local:RotatorViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfRotator x:Name="rotator" 
                        NavigationDelay="2000" 
                        ItemsSource="{Binding ImageCollection}" 
                        SelectedIndex="2"
                        NavigationDirection="BottomToTop"
                        NavigationStripMode="Thumbnail" 
                        BackgroundColor="#ececec"
                        EnableAutoPlay="true"
                        EnableLooping="true"
                        NavigationStripPosition="Bottom">
            <syncfusion:SfRotator.ItemTemplate>
                <DataTemplate>
                    <Image  Source="{Binding Image}"/>
                </DataTemplate>
            </syncfusion:SfRotator.ItemTemplate>
        </syncfusion:SfRotator>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core.Rotator;
using Syncfusion.Maui.Rotator;

namespace Rotator
{
    public partial class Rotator : ContentPage
    {
        public Rotator()
        {
            InitializeComponent ();
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
            rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
            rotator.NavigationDirection = NavigationDirection.BottomToTop;
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
        private String _image;
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}

{% endhighlight %}

{% endtabs %}

![NavigationStripPosition gif](images/NavigationStripPosition.gif)

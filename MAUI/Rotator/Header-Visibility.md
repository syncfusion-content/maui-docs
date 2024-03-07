---
layout: post
title: Header Visibility in .NET MAUI Rotator control | Syncfusion
description: Learn here all about Header Visibility support in Syncfusion .NET MAUI Rotator (SfRotator) control and more.
platform: maui 
control: Rotator
documentation: ug
---

# Header Visibility in .NET MAUI Rotator (SfRotator)

The [`IsTextVisible`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRotator.XForms.SfRotator.html#Syncfusion_SfRotator_XForms_SfRotator_IsTextVisible) property can be used to enable the text area visibility in bottom area of [`SfRotator`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRotator.XForms.SfRotator.html) for providing additional information of items. [`IsTextVisible`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRotator.XForms.SfRotator.html#Syncfusion_SfRotator_XForms_SfRotator_IsTextVisible) property is used to change the visibility of the Text panel that is displayed when [`SfRotatorItem`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRotator.XForms.SfRotatorItem.html) collection is set and will have no effect when setting Item template.

N> By default, the property value is false.

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
                            BackgroundColor="#ececec"
                            IsTextVisible="True"
                            ItemsSource="{Binding ImageCollection}" 
                            VerticalOptions="Start">
                    <syncfusion:SfRotator.ItemTemplate>
                        <DataTemplate>
                                <Image Source="{Binding Image}" />
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
            SfRotator rotator = new SfRotator();
            StackLayout stackLayout = new StackLayout();
            public Rotator()
            {
                InitializeComponent();
                stackLayout.HeightRequest = 300;
                List<SfRotatorItem> collectionOfItems = new List<SfRotatorItem>();
                collectionOfItems.Add(new SfRotatorItem() { Image = "image1.png", ItemText = "Bird 1" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image2.png", ItemText = "Bird 2" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image3.png", ItemText = "Bird 3" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image4.png", ItemText = "Bird 4" });
                collectionOfItems.Add(new SfRotatorItem() { Image = "image5.png", ItemText = "Bird 5" });
                rotator.ItemsSource = collectionOfItems;
                rotator.IsTextVisible = true;
                rotator.DotPlacement = DotsPlacement.OutSide;
                stackLayout.Children.Add(rotator);
                this.Content = stackLayout;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

![IsTextVisible](images/IsTextVisible.png)

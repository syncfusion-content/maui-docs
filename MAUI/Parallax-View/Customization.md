---
layout: post
title: Customization in .NET MAUI Parallax View control | Syncfusion
description: Learn about Customization support in Syncfusion .NET MAUI Parallax View (SfParallaxView) control and more.
platform: MAUI
control: SfParallaxView
documentation: ug
---

# Customization in .NET MAUI Parallax View

## Speed Customization

The [`Speed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Speed) value denotes the scrolling speed of the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Content) added as a background view. Based on the speed value, the background view will scroll along with the foreground view.

{% tabs %}

{% highlight xaml %}

<parallax:SfParallaxView Source="{x:Reference Name = listview}" x:Name="parallaxview" Speed="0.5" >
    <parallax:SfParallaxView.Content>
        <Image BackgroundColor="Transparent" Source="{Binding Image}" HorizontalOptions="Fill" VerticalOptions="Fill" Aspect="AspectFill" />
    </parallax:SfParallaxView.Content>
</parallax:SfParallaxView>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.ParallaxView;

namespace ParallaxViewGettingStarted
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            ParallaxViewModel view = new ParallaxViewModel();
            BindingContext = view;
            SfParallaxView parallax = new SfParallaxView();
            SfListView listview = new SfListView();
            Image image = new Image();
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            image.Source = ImageSource.FromResource("ParallaxViewGettingStarted.parallax.jpg", assembly);
            image.BackgroundColor = Colors.Transparent,
            image.HorizontalOptions = LayoutOptions.Fill,
            image.VerticalOptions = LayoutOptions.Fill,
            image.Aspect = Aspect.AspectFill
            parallax.Content = image;
            parallax.Speed = 0.5;
            listview.ItemsSource = view.Items;
            parallax.Source = listview;
            this.Content = parallax;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Orientation 

The orientation of the content scrolling can be customized to vertical or horizontal using the value of the [`Orientation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Orientation) property.

{% tabs %}

{% highlight xaml %}

<Grid>
    <parallax:SfParallaxView Source="{x:Reference Name = listview}" x:Name="parallaxview" Orientation="Horizontal" >
        <parallax:SfParallaxView.Content>
        . . .
        </parallax:SfParallaxView.Content>
    </parallax:SfParallaxView>

    <SfListView x:Name="listview" Orientation="Horizontal" ItemsSource="{Binding Items}" BackgroundColor="Transparent" ItemSize="100">
        . . .
    <SfListView>
</Grid>
        
{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.ParallaxView;

namespace ParallaxViewGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ParallaxViewModel view = new ParallaxViewModel();
            BindingContext = view;
            SfParallaxView parallax = new SfParallaxView();
            ListView listview = new ListView();
            Image image = new Image();
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            image.Source = ImageSource.FromResource("ParallaxViewGettingStarted.parallax.jpg", assembly);
            parallax.Content = image;
            parallax.Orientation = Syncfusion.Maui.ParallaxView.Orientation.Horizontal;
            listview.ItemsSource = view.Items;
            listview.Orientation = ItemsLayoutOrientation.Horizontal;
            listview.BackgroundColor = Colors.Transparent,
            listview.ItemSize = 100
            parallax.Source = listview;
            this.Content = parallax;
        }
    }
}

{% endhighlight %}

{% endtabs %}
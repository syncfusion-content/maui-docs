---
layout: post
title: Dots Customization in .NET MAUI Rotator control | Syncfusion
description: Learn about Navigation Customization support in Syncfusion .NET MAUI Rotator (SfRotator) control and more.
platform: maui 
control: Rotator 
documentation: ug
---

# Navigation Customization in .NET MAUI Rotator (SfRotator)

The Rotator control supports customizing dots, thumbnails and navigation buttons.

## Dots Customization

In Dot Customization we can customise the  dots' stroke, selected and unselected dots' color.

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
                                ItemsSource="{Binding ImageCollection}" 
                                SelectedIndex="2"
                                BackgroundColor="#ececec"
                                NavigationStripPosition="Bottom"
                                DotsStroke="Aqua" 
                                SelectedDotColor="Blue"
                                UnselectedDotColor="Gray"
                                WidthRequest="550"
                                HeightRequest="550">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image  Source="{Binding Image}"/>
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# %}

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
                rotator.DotsStroke = Color.Aqua;
                rotator.SelectedDotColor = Color.Blue;
                rotator.UnselectedDotColor = Color.Gray;
                rotator.ItemsSource = ImageCollection;
                rotator.WidthRequest=550;
                rotator.HeightRequest=550;
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

![SfRotator with unselected dot color](images/DotsCustomization.png)


## Thumbnails Customization

In Thumbnail Customization we can customise the  selected and unselected thumbnail's stroke.

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
                     ItemsSource="{Binding ImageCollection}" 
                     SelectedIndex="2"
                     BackgroundColor="#ececec"
                     NavigationStripPosition="Bottom"
                     NavigationStripMode="Thumbnail"
                     SelectedThumbnailStroke="Green"
                     UnselectedThumbnailStroke="Red"
                     WidthRequest="550"
                     HeightRequest="550">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image  Source="{Binding Image}"/>
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# %}

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
                rotator.UnselectedThumbnailStroke = Colors.Red;
                rotator.SelectedThumbnailStroke = Colors.Green;
                rotator.ItemsSource = ImageCollection;
                rotator.WidthRequest=550;
                rotator.HeightRequest=550;
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

![SfRotator with thumbnail customization](images/ThumbnailsCustomization.png)

## Navigation Button Customization

In Navigation Button Customization we can customise the  navigation button's icon and Background color.

{% tabs %}
{% highlight xaml %}

    <ContentPage.Content>
          <syncfusion:SfRotator x:Name="rotator" 
                      ItemsSource="{Binding ImageCollection}" 
                      SelectedIndex="2"
                      BackgroundColor="#ececec"
                       NavigationStripMode="Thumbnail"
                        NavigationButtonBackgroundColor="Pink"
                        NavigationButtonIconColor="Blue"
                      WidthRequest="550"
                      HeightRequest="550">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image  Source="{Binding Image}"/>
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </ContentPage.Content>

{% endhighlight %}
{% highlight c# %}

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
    rotator.NavigationButtonBackgroundColor = Colors.Pink;
    rotator.NavigationButtonIconColor = Colors.Blue;
    rotator.ItemsSource = ImageCollection;
    rotator.WidthRequest=550;
    rotator.HeightRequest=550;
    this.Content = rotator;

{% endhighlight %}
{% endtabs %}

![SfRotator with navigation button customization](images/NavigationButton.png)

## Navigation Visibility

We can show or hide  Navigation Button using `ShowNavigationButton` property.

{% tabs %}
{% highlight xaml %}

    <ContentPage.Content>
          <syncfusion:SfRotator x:Name="rotator" 
                      ItemsSource="{Binding ImageCollection}" 
                      SelectedIndex="2"
                      BackgroundColor="#ececec"
                       NavigationStripMode="Thumbnail"
                      ShowNavigationButton="False"
                      WidthRequest="550"
                      HeightRequest="550">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image  Source="{Binding Image}"/>
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </ContentPage.Content>

{% endhighlight %}
{% highlight c# %}

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
    rotator.NavigationStripMode = NavigationStripMode.Thumbnail;rotator.ShowNavigationButton = false;
    rotator.ItemsSource = ImageCollection;
    rotator.WidthRequest=550;
    rotator.HeightRequest=550;
    this.Content = rotator;

{% endhighlight %}
{% endtabs %}

![SfRotator with ShowNavigationButton property](images/ShowNavigationButton.png)


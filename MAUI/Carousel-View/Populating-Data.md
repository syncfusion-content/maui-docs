---
layout : post
title: Populating Data in .NET MAUI Carousel View control | Syncfusion
description: Learn here all about Populating Data support in Syncfusion .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Populating Data in .NET MAUI Carousel View (SfCarousel)

`SfCarousel` control supports binding to different data sources such as IList Data Source and Observable Collection Data Source.

## Through Binding

Items can be populated in the `SfCarousel` control through data source and applying a custom template, as explained in the following.

### Create a Model with Data

`SfCarousel` items can be populated with a collection of image data. For example, a user may want to create a `SfCarousel` control, which will display a list of images.

The `SfCarousel` model looks as follows.

{% highlight C# %}

namespace CarouselSample
{
    public class CarouselModel
    {
        public CarouselModel(string imageString)
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

Populate carousel items collection in View model with the image data. 

{% highlight C# %}

using System.Collections.Generic;

namespace CarouselSample
{
    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("carousel_person1.png"));
            ImageCollection.Add(new CarouselModel("carousel_person2.png"));
            ImageCollection.Add(new CarouselModel("carousel_person3.png"));
            ImageCollection.Add(new CarouselModel("carousel_person4.png"));
            ImageCollection.Add(new CarouselModel("carousel_person5.png"));
        }
        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}

{% endhighlight %}

N> Images can also be referred to in PCL and from the website URL as `instructed`.


### Binding the Data with Custom Template

`SfCarousel` provides support to add a custom view as carousel items by designing a view inside its `ItemTemplate`. This template will be applied for all its items, and its data will be bound.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
             xmlns:local="clr-namespace:CarouselSample"
             x:Class="CarouselSample.MainPage">
    <ContentPage.BindingContext>
        <local:CarouselViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="itemTemplate">
                <Image Source="{Binding Image}" 
                       Aspect="AspectFit"/>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.Content>
        <carousel:SfCarousel x:Name="carousel"  
                             ItemTemplate="{StaticResource itemTemplate}" 
                             ItemsSource="{Binding ImageCollection}" 
                             HeightRequest="400" 
                             WidthRequest="800" />
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCarousel.XForms;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CarouselViewModel carouselViewModel = new CarouselViewModel();

            SfCarousel carousel = new SfCarousel()
            {
                HeightRequest = 400,
                WidthRequest = 800
            };

            var itemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                var nameLabel = new Image();
                nameLabel.SetBinding(Image.SourceProperty, "Image");
                grid.Children.Add(nameLabel);
                return grid;
            });

            carousel.ItemTemplate = itemTemplate;
            carousel.ItemsSource = carouselViewModel.ImageCollection;

            this.Content = carousel;
        }
    }

    public class CarouselModel
    {
        public CarouselModel(string imageString)
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

    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("carousel_person1.png"));
            ImageCollection.Add(new CarouselModel("carousel_person2.png"));
            ImageCollection.Add(new CarouselModel("carousel_person3.png"));
            ImageCollection.Add(new CarouselModel("carousel_person4.png"));
            ImageCollection.Add(new CarouselModel("carousel_person5.png"));
        }

        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}

{% endhighlight %}
{% endtabs %}

* Now, set the `BindingContext` for the items collection in the code behind.

{% highlight C# %}

	carousel.BindingContext = new CarouselViewModel();

{% endhighlight %}

## Through Carousel Item

Different views can be provided to every item through the `ItemContent` property in the `SfCarouselItem` class.

{% highlight C# %}

using Syncfusion.Maui.Carousel;
using System.Collections.ObjectModel;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfCarousel carousel = new SfCarousel()
            {
                ItemWidth = 170,
                ItemHeight = 250
            };

            ObservableCollection<SfCarouselItem> carouselItems = new ObservableCollection<SfCarouselItem>();

            carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person1.png", Aspect = Aspect.Fill } });
            carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person2.png", Aspect = Aspect.Fill } });
            carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person3.png", Aspect = Aspect.Fill } });
            carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person4.png", Aspect = Aspect.Fill } });
            carouselItems.Add(new SfCarouselItem() { ItemContent = new Image() { Source = "carousel_person5.png", Aspect = Aspect.Fill } });

            carousel.ItemsSource = carouselItems;

            this.Content = carousel;
        }
    }
}

{% endhighlight %}

and also carousel provides a support to display only the Image data with `Image` property in `SfCarouselItem` class.

{% highlight C# %}

using Syncfusion.Maui.Carousel;
using System.Collections.ObjectModel;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfCarousel carousel = new SfCarousel()
            {
                ItemWidth = 170,
                ItemHeight = 250
            };

            ObservableCollection<SfCarouselItem> carouselItems = new ObservableCollection<SfCarouselItem>();
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person1.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person2.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person3.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person4.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person5.png" });

            carousel.ItemsSource = carouselItems;

            this.Content = carousel;
        }
    }
}

{% endhighlight %}


Similarly, every item can be created and customized in case a different carousel item view is needed.



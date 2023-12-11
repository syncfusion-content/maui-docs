---
layout : post
title: Load More in .NET MAUI Carousel View control | Syncfusion
description: Learn here all about Load More support in Syncfusion .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Load More in .NET MAUI Carousel View (SfCarousel)

Virtualization can be achieved by using the Load More concept. This support is used to handle the numerous items in the carousel control. Items are maintained in the viewport based on the `LoadMoreItemsCount` property. The LoadMore view is added after the last item in the collection of the carousel view. When tapping the LoadMore view, the next set of items in the collection can be added to the carousel.

The following properties are used to achieve this support:

*	`AllowLoadMore`

*	`LoadMoreItemsCount`

*	`LoadMoreView`

## AllowLoadMore

By enabling the `AllowLoadMore` property, the LoadMore support works in the carousel view. 

N>The default value of the `AllowLoadMore` property is false.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
             xmlns:local="clr-namespace:CarouselSample"
             x:Class="CarouselSample.MainPage">
    <ContentPage.BindingContext>
        <local:CarouselViewModel />
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
			ItemHeight="200"
			ItemWidth="200"
			ItemSpacing="2"
			AllowLoadMore="True"
			ViewMode="Linear">
        </carousel:SfCarousel>
    </ContentPage.Content>
</ContentPage>
	
{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Carousel;
using System.Collections.Generic;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new CarouselViewModel();
            SfCarousel carousel = new SfCarousel()
            {
                ItemHeight = 200,
                ItemWidth = 200,
                ItemSpacing = 2,
                AllowLoadMore = true,
                ViewMode = ViewMode.Linear
            };

            carousel.ItemTemplate = new DataTemplate(() =>
            {
                Image image = new Image();
                image.SetBinding(Image.SourceProperty, "Image");
                image.Aspect = Aspect.AspectFit;
                return image;
            });

            carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
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

## LoadMoreItemsCount

Number of items can be maintained in the carousel control using the `LoadMoreItemsCount` property. By using the `LoadMoreItemsCount` property, numerous items can be separated. 

N>The default value of the `LoadMoreItemsCount` property is 3.

{% tabs %}

{% highlight xaml %}


<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
             xmlns:local="clr-namespace:CarouselSample"
             x:Class="CarouselSample.MainPage">
    <ContentPage.BindingContext>
        <local:CarouselViewModel />
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
			ItemHeight="200"
			ItemWidth="200"
			ItemSpacing="2"
			AllowLoadMore="True"
			ViewMode="Linear"
            LoadMoreItemsCount="2">
        </carousel:SfCarousel>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Carousel;
using System.Collections.Generic;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new CarouselViewModel();
            SfCarousel carousel = new SfCarousel()
            {
                ItemHeight = 200,
                ItemWidth = 200,
                ItemSpacing = 2,
                AllowLoadMore = true,
                LoadMoreItemsCount = 2,
                ViewMode = ViewMode.Linear
            };

            carousel.ItemTemplate = new DataTemplate(() =>
            {
                Image image = new Image();
                image.SetBinding(Image.SourceProperty, "Image");
                image.Aspect = Aspect.AspectFit;
                return image;
            });

            carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
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

## LoadMoreView

Custom view can be passed instead of the `LoadMore` label using the `LoadMoreView` property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
             xmlns:local="clr-namespace:CarouselSample"
             x:Class="CarouselSample.MainPage">
    <ContentPage.BindingContext>
        <local:CarouselViewModel />
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
			ItemHeight="200"
			ItemWidth="200"
			ItemSpacing="2"
			AllowLoadMore="True"
			ViewMode="Linear"
            LoadMoreItemsCount="2">
            <carousel:SfCarousel.LoadMoreView>
                <Grid BackgroundColor="#FFFFFFFF">
                    <Label
                        Text="Load More..."
                        FontSize="14"
                        TextColor="#FF000000"
                        FontAttributes="Bold"
                        HorizontalTextAlignment="Center"
                        VerticalTextAlignment="Center"
                        HorizontalOptions="Center"
                        VerticalOptions="Center"/>
                </Grid>
            </carousel:SfCarousel.LoadMoreView>
        </carousel:SfCarousel>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Carousel;
using System.Collections.Generic;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new CarouselViewModel();
            SfCarousel carousel = new SfCarousel()
            {
                ItemHeight = 200,
                ItemWidth = 200,
                ItemSpacing = 2,
                AllowLoadMore = true,
                LoadMoreItemsCount = 2,
                ViewMode = ViewMode.Linear
            };

            carousel.ItemTemplate = new DataTemplate(() =>
            {
                Image image = new Image();
                image.SetBinding(Image.SourceProperty, "Image");
                image.Aspect = Aspect.AspectFit;
                return image;
            });

            carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

            Grid grid = new Grid()
            {
                BackgroundColor = Color.White
            };

            Label label = new Label()
            {
                Text = "Load More...",
                FontSize = 14,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            grid.Children.Add(label);

            carousel.LoadMoreView = grid;

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
            ImageCollection.Add(new CarouselModel("cart.png"));
            ImageCollection.Add(new CarouselModel("cart.png"));
            ImageCollection.Add(new CarouselModel("cart.png"));
            ImageCollection.Add(new CarouselModel("cart.png"));
            ImageCollection.Add(new CarouselModel("cart.png"));
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

![Load more](images/LoadMore.png)

You can find the complete Load More sample from this `link.`

## LoadMore method

To load more items programmatically, the `LoadMore` method can be called, which loads the items dynamically to the UI based on the `LoadMoreItemsCount` API value.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:CarouselSample"
             xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"
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
        <StackLayout>
            <carousel:SfCarousel x:Name="carousel"
                                 ItemTemplate="{StaticResource itemTemplate}"
                                 ItemsSource="{Binding ImageCollection}"
                                 ItemWidth="150"
                                 ViewMode="Default"
                                 LoadMoreItemsCount="2"
                                 ItemHeight="150"
                              />
            <Button Text="LoadMore Method" 
                    Clicked="Button_Clicked"/>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
	
{% endhighlight %}

{% highlight c# %}

using System;
using System.Collections.Generic;

namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            carousel.LoadMore();
        }
    }

    public class CarouselModel
    {
        public CarouselModel(string imagestr)
        {
            Image = imagestr;
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
            ImageCollection.Add(new CarouselModel("image1.png"));
            ImageCollection.Add(new CarouselModel("image2.png"));
            ImageCollection.Add(new CarouselModel("image3.png"));
            ImageCollection.Add(new CarouselModel("image4.png"));
            ImageCollection.Add(new CarouselModel("image5.png"));
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



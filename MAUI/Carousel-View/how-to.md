---
layout : post
title: Interaction in Syncfusion Carousel Control in .NET MAUI.
description: Learn how to perform an operation while changing the carouselItem or Collection in Carousel for .NET MAUI.
platform : maui
control : Carousel
documentation : ug
---

# How to perform an operation while changing the carouselItem?

We can perform the operation while changing the carouselItem using the `SelectionChanged` event. The `SelectionChanged` event returns the OldItem and selected NewItem.

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
            SelectionChanged="Carousel_SelectionChanged"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

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
                ItemWidth = 200
            };

            carousel.ItemTemplate = new DataTemplate(() =>
            {
                Image image = new Image();
                image.SetBinding(Image.SourceProperty, "Image");
                image.Aspect = Aspect.AspectFit;
                return image;
            });

            carousel.SelectionChanged += Carousel_SelectionChanged;
            carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");
            this.Content = carousel;
        }

        private void Carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = (sender as SfCarousel).SelectedIndex + 1;
            DisplayAlert("SelectionChanged", "Carousel item:" + count + " has Selected", "Ok");
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



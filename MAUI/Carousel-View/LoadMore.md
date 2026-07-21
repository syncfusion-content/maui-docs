---
layout : post
title: Load More in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Load More support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Load More in .NET MAUI Carousel View (SfCarousel)

## Overview

Watch this video to get started quickly with the Load More feature in .NET MAUI Carousel:

{% youtube "https://www.youtube.com/watch?v=Q3eNppgpQ2Y" %}

Use the Load More feature to load items incrementally as the user requests more data. [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) defines how many items are displayed in the viewport at a time. The LoadMore view is added after the last item in the collection. When the user taps the LoadMore view, the next set of items is added to the carousel.

The following properties are used to achieve this support:

| Property | Type | Description |
| --- | --- | --- |
| [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore) | `bool` | Enables or disables the LoadMore support. Default is `false`. |
| [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) | `int` | Number of items displayed in the viewport at a time. Default is `3`. |
| [LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreView) | `View` | Custom view displayed in place of the default `LoadMore` label. |
| [LoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMore) | `void` | Method that loads the next set of items programmatically. |

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Allow Load More

Enable the [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore) property to activate `LoadMore` support in the Carousel View. The default value of the `AllowLoadMore` property is `false`.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     AllowLoadMore="True"
                     ItemHeight="170"
                     ItemWidth="270"
                     ViewMode="Linear">
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
    <carousel:SfCarousel.ItemTemplate>
        <DataTemplate >
            <Image Source="{Binding Image}" 
                   Aspect="AspectFit"/>
        </DataTemplate>
    </carousel:SfCarousel.ItemTemplate>
</carousel:SfCarousel>
    
{% endhighlight %}
{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    AllowLoadMore = true,
    ViewMode = ViewMode.Linear,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
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

//View Model
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

{% endhighlight %}
{% endtabs %}


## Load More Items Count

The number of items displayed in the Carousel can be controlled using the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property. Use it to split a large collection into smaller, viewable chunks. The default value of the `LoadMoreItemsCount` property is `3`. The value should be a positive integer.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemHeight = "170"
                     ItemWidth = "270"
                     AllowLoadMore="True"
                     LoadMoreItemsCount="2"
                     ViewMode="Linear">
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
    <carousel:SfCarousel.ItemTemplate>
        <DataTemplate >
            <Image Source="{Binding Image}" 
                   Aspect="AspectFit"/>
        </DataTemplate>
    </carousel:SfCarousel.ItemTemplate>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    AllowLoadMore = true,
    ViewMode = ViewMode.Linear,
    LoadMoreItemsCount = 2,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
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

//View Model
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

{% endhighlight %}
{% endtabs %}


## Load More View

Use the [LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreView) property to provide a custom view instead of the default `LoadMore` label. The custom view is rendered after the last visible item in the collection.

{% tabs %}

{% highlight xaml %}


<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     AllowLoadMore="True"
                     ViewMode="Linear"
                     LoadMoreItemsCount="2">
    <carousel:SfCarousel.LoadMoreView>
        <Grid BackgroundColor="#FFFFFF">
            <Label Text="Load More..."
                   FontSize="14"
                   TextColor="#000000"
                   FontAttributes="Bold"
                   HorizontalTextAlignment="Center"
                   VerticalTextAlignment="Center"
                   HorizontalOptions="Center"
                   VerticalOptions="Center"/>
        </Grid>
    </carousel:SfCarousel.LoadMoreView>
    <carousel:SfCarousel.BindingContext>
        <local:CarouselViewModel/>
    </carousel:SfCarousel.BindingContext>
    <carousel:SfCarousel.ItemTemplate>
        <DataTemplate>
            <Image Source="{Binding Image}" 
                   Aspect="AspectFit"/>
        </DataTemplate>
    </carousel:SfCarousel.ItemTemplate>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    AllowLoadMore = true,
    LoadMoreItemsCount = 2,
    ViewMode = ViewMode.Linear,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
    LoadMoreView = new Grid()
    {
        BackgroundColor = Color.FromArgb("#FFFFFF"),
        Children =
        {
            new Label()
            {
                Text = "Load More...",
                FontSize = 14,
                TextColor = Color.FromArgb("#000000"),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }
        }
    }
};

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
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

//View Model
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

{% endhighlight %}
{% endtabs %}


The following image shows the custom LoadMore view rendered after the last carousel item.

![Load more](images/LoadMore.png)

## Load More Method

Call the [LoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMore) method to load the next set of items programmatically. The number of items loaded is determined by `LoadMoreItemsCount`.

### XAML

{% tabs %}

{% highlight xaml %}

<Grid>
    <carousel:SfCarousel x:Name="carousel"
                        ItemsSource="{Binding ImageCollection}"
                        AllowLoadMore="True"
                        ViewMode="Default"
                        LoadMoreItemsCount="2">
        <carousel:SfCarousel.BindingContext>
            <local:CarouselViewModel/>
        </carousel:SfCarousel.BindingContext>
        <carousel:SfCarousel.ItemTemplate>
            <DataTemplate >
                <Image Source="{Binding Image}" Aspect="AspectFit"/>
            </DataTemplate>
        </carousel:SfCarousel.ItemTemplate>
    </carousel:SfCarousel>
    <Button Text="Load More" Clicked="Button_Clicked"/>
</Grid>

{% endhighlight %}

### C#

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    AllowLoadMore = true,
    ViewMode = ViewMode.Default,
    LoadMoreItemsCount = 2,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    })
};

Button button = new Button()
{
    Text = "Load More"
};
button.Clicked += Button_Clicked;

this.Content = new StackLayout()
{
    Children =
    {
        carousel,
        button
    }
};

{% endhighlight %}

{% highlight c# tabtitle="ViewModel" %}

// Model
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

//View Model
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

{% endhighlight %}
{% endtabs %}

The `Button_Clicked` event can be handled in C# as follows:

{% tabs %}
{% highlight C# %}

private void Button_Clicked(object sender, EventArgs e)
{
    carousel.LoadMore();
}
    
{% endhighlight %}
{% endtabs %}


Find the complete Load More sample on [GitHub](https://github.com/SyncfusionExamples/maui-carousel-samples/tree/master/LoadMore/LoadMoreSample).


## See also

- [Populating Items in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/populating-data)
- [UI Virtualization in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/uivirtualization)
- [Transformation in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/transformation)

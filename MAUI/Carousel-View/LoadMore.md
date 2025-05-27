---
layout: post
title: "Load More in .NET MAUI Carousel View Control | Syncfusion®"
description: "Learn about Load More support in the Syncfusion® .NET MAUI Carousel View (SfCarousel) control."
platform: maui
control: Carousel
documentation: ug
---

# Load More in .NET MAUI Carousel View (SfCarousel)

To quickly get started with customizing the appearance of the .NET MAUI Carousel, you can watch this video:

{% youtube "https://www.youtube.com/watch?v=Q3eNppgpQ2Y" %}

Virtualization can be achieved using the Load More concept, allowing you to handle numerous items in the carousel control. Items are maintained in the viewport based on the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property. The Load More view is added after the last item in the collection of the carousel view. Tapping the Load More view adds the next set of items to the carousel.

The following properties are used to enable this feature:

- [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore)
- [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount)
- [LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreView)

## Allow Load More

Enable the [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore) property to activate the Load More feature in the carousel view.

> **Note:** The default value of the [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore) property is `false`.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     AllowLoadMore="True"
                     ViewMode="Linear">
</carousel:SfCarousel>
	
{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    AllowLoadMore = true,
    ViewMode = ViewMode.Linear
};
carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

## Load More Items Count

Use the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property to specify the number of items maintained in the carousel control, allowing separation for a large number of items.
> **Note:** The default value of the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property is `3`.

N>The default value of the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property is 3.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     AllowLoadMore="True"
                     LoadMoreItemsCount="2" 
                     ViewMode="Linear"/>

{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    AllowLoadMore = true,
    LoadMoreItemsCount = 2,
    ViewMode = ViewMode.Linear
};

carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

## Load More View

You can provide a custom view for the Load More label using the [LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreView) property.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     AllowLoadMore="True"
                     ViewMode="Linear"
                     LoadMoreItemsCount="2" />
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
                VerticalOptions="Center" />
        </Grid>
    </carousel:SfCarousel.LoadMoreView>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    AllowLoadMore = true,
    LoadMoreItemsCount = 2,
    ViewMode = ViewMode.Linear
};

carousel.ItemTemplate = itemTemplate;
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

{% endhighlight %}

{% endtabs %}

![Load more](images/LoadMore.png)

## Load More Method

To programmatically load more items, use the [LoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMore) method, which dynamically loads items to the UI based on the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) API value.

{% tabs %}

{% highlight xaml %}

    <carousel:SfCarousel x:Name="carousel"
                         ItemsSource="{Binding ImageCollection}"
                         ItemTemplate="{StaticResource itemTemplate}"
                         AllowLoadMore="True"
                         ViewMode="Default"
                         LoadMoreItemsCount="2" />
    <Button Text="LoadMore Method" 
            Clicked="Button_Clicked"/>
	
{% endhighlight %}

{% highlight c# %}


SfCarousel carousel = new SfCarousel()
{
    AllowLoadMore = true,
    ViewMode = ViewMode.Default,
    LoadMoreItemsCount = 2
};

carousel.ItemTemplate = itemTemplate;
carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

Button button = new Button();
button.Text = "LoadMore Method";
button.Clicked += Button_Clicked;


private void Button_Clicked(object sender, EventArgs e)
{
    carousel.LoadMore();
}

{% endhighlight %}

{% endtabs %}

Find the complete Load More sample from this [link](https://github.com/SyncfusionExamples/maui-carousel-samples/tree/master/LoadMore/LoadMoreSample).

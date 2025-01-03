---
layout : post
title: Load More in .NET MAUI Carousel View control | Syncfusion®
description: Learn here all about Load More support in Syncfusion® .NET MAUI Carousel View (SfCarousel) control and more.
platform : maui
control : Carousel
documentation : ug
---

# Load More in .NET MAUI Carousel View (SfCarousel)

To get start quickly to customize the Appearance of .NET MAUI Carousel, you can check on this video:

{% youtube "https://www.youtube.com/watch?v=Q3eNppgpQ2Y" %}

Virtualization can be achieved by using the Load More concept. This support is used to handle the numerous items in the carousel control. Items are maintained in the viewport based on the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property. The LoadMore view is added after the last item in the collection of the carousel view. When tapping the LoadMore view, the next set of items in the collection can be added to the carousel.

The following properties are used to achieve this support:

*	[AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore)

*	[LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount)

*	[LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreView)

## Allow Load More

By enabling the [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore) property, the LoadMore support works in the carousel view. 

N>The default value of the [AllowLoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore) property is false.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     AllowLoadMore="True"
                     ViewMode="Linear">
</carousel:SfCarousel>
	
{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    ItemSpacing = 2,
    AllowLoadMore = true,
    ViewMode = ViewMode.Linear
};

carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

## Load More Items Count

Number of items can be maintained in the carousel control using the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property. By using the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property, numerous items can be separated. 

N>The default value of the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) property is 3.

{% tabs %}

{% highlight xaml %}

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemSpacing="2"
                     AllowLoadMore="True"
                     ViewMode="Linear"
                     LoadMoreItemsCount="2" />

{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 200,
    ItemWidth = 200,
    ItemSpacing = 2,
    AllowLoadMore = true,
    LoadMoreItemsCount = 2,
    ViewMode = ViewMode.Linear
};

carousel.SetBinding(SfCarousel.ItemsSourceProperty, "ImageCollection");

{% endhighlight %}

{% endtabs %}

## Load More View

Custom view can be passed instead of the [LoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMore) label using the [LoadMoreView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreView) property.

{% tabs %}

{% highlight xaml %}

<ContentPage.Content>
<carousel:SfCarousel x:Name="carousel"
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
                VerticalOptions="Center" />
        </Grid>
    </carousel:SfCarousel.LoadMoreView>
</carousel:SfCarousel>

{% endhighlight %}

{% highlight c# %}

SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 200,
    ItemWidth = 200,
    ItemSpacing = 2,
    AllowLoadMore = true,
    LoadMoreItemsCount = 2,
    ViewMode = ViewMode.Linear
};

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

## Load More method

To load more items programmatically, the [LoadMore](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMore) method can be called, which loads the items dynamically to the UI based on the [LoadMoreItemsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount) API value.

{% tabs %}

{% highlight xaml %}

<StackLayout>
    <carousel:SfCarousel x:Name="carousel"
                         ItemsSource="{Binding ImageCollection}"
                         ViewMode="Default"
                         LoadMoreItemsCount="2" />
    <Button Text="LoadMore Method" 
            Clicked="Button_Clicked"/>
</StackLayout>
	
{% endhighlight %}

{% highlight c# %}

private void Button_Clicked(object sender, EventArgs e)
{
    carousel.LoadMore();
}

{% endhighlight %}

{% endtabs %}

Find the complete Load More sample from this [link](https://github.com/SyncfusionExamples/maui-carousel-samples/tree/master/LoadMore/LoadMoreSample).
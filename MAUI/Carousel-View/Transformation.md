---
layout: post
title: Transformation in .NET MAUI Carousel View control | Syncfusion®
description: Learn about the transformation options available in the Syncfusion® .NET MAUI Carousel View (SfCarousel) control.
platform: maui
control: Carousel
documentation: ug
---

# Transformation in .NET MAUI Carousel View (SfCarousel)

## Prerequisites

Before using the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Carousel`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/carousel-view/getting-started) documentation.

## Overview

The [.NET MAUI Carousel View (SfCarousel)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) provides several transformation options to customize the appearance and layout of its items. You can tilt the unselected items, adjust the spacing between the selected and unselected items, and scale items to a specified value. Most of these properties apply in the [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Default) [ViewMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html); spacing in the `Linear` mode is configured using a dedicated property.


## View Modes

The transformation behavior depends on the [ViewMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html) of `SfCarousel`:

| ViewMode | Description |
|----------|-------------|
| `Default` | Items are arranged in a 3D-like stack. Supports `RotationAngle`, `Offset`, `SelectedItemOffset`, and `ScaleOffset`. |
| `Linear`  | Items are arranged in a flat, linear layout. Supports `ItemSpacing`. |

> **Note:** Transformation properties other than `ItemSpacing` apply only in the `Default` ViewMode.

## Properties Overview

| Property | Type | Default Value | Applies To | Description |
|----------|------|---------------|------------|-------------|
| `RotationAngle` | `double` | 0 | Default | Angle (in degrees) used to tilt unselected items. |
| `Offset` | `double` | 40 (desktop), 18 (mobile) | Default | Distance between unselected items. |
| `SelectedItemOffset` | `double` | 40 | Default | Distance between the selected item and other items. |
| `ScaleOffset` | `float` | 0 | Default | Scale factor applied to items (range: 0 to 1). |
| `ItemSpacing` | `double` | 0 | Linear | Spacing between items in Linear mode. |

> **Note:** All transformation properties are available from the initial release of `Syncfusion.Maui.Carousel`.

## Tilt Non-Selected Items

The [RotationAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_RotationAngle) property in the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control is used to tilt all unselected items at a specified angle in the [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Carousel.ViewMode.html#Syncfusion_Maui_Core_Carousel_ViewMode_Default) mode. The default value is `0`.

> **Note:** If the angle value is positive, the rotation is in the clockwise direction. If the angle value is negative, the rotation is in the counterclockwise direction.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Grid>
                <Image Source="{Binding Image}" Aspect="AspectFit"/>
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     ItemHeight="170"
                     ItemWidth="270"
                     RotationAngle="30"/>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    RotationAngle = 30,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var grid = new Grid();
        var nameLabel = new Image();
        nameLabel.SetBinding(Image.SourceProperty, "Image");
        grid.Children.Add(nameLabel);
        return grid;
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


![Rotation angle in .NET MAUI Carousel View.](Images/net-maui-carousel-view-rotationangle.png)

## Set Gap between the Selected Item and Other Items

The distance between the selected item and other items can be customized by using the [SelectedItemOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedItemOffset) property of the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control in the Default mode. The default value is `40`.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Grid>
                <Image Source="{Binding Image}" Aspect="AspectFit"/>
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     ItemHeight="170"
                     ItemWidth="270"
                     SelectedItemOffset="60"/>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    SelectedItemOffset = 60,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var grid = new Grid();
        var nameLabel = new Image();
        nameLabel.SetBinding(Image.SourceProperty, "Image");
        grid.Children.Add(nameLabel);
        return grid;
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


![SelectedItemOffset in .NET MAUI Carousel View.](Images/net-maui-carousel-view-selectedoffset.png)

## Set Gap between Unselected Items

The [Offset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_Offset) property is used to define the distance between unselected items in the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) panel in the Default mode.

> **Note:** The default value is `40` for desktop platforms and `18` for mobile platforms.

{% tabs %}

{% highlight xaml %}
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Grid>
                <Image Source="{Binding Image}" Aspect="AspectFit"/>
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     ItemHeight="170"
                     ItemWidth="270"
                     Offset="60"/>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    Offset = 60.0,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var grid = new Grid();
        var nameLabel = new Image();
        nameLabel.SetBinding(Image.SourceProperty, "Image");
        grid.Children.Add(nameLabel);
        return grid;
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


![Offset in .NET MAUI Carousel View.](Images/net-maui-carousel-view-offset.png)

## Set Scaling for Carousel Items

The [ScaleOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ScaleOffset) property in the [SfCarousel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html) control is used to scale all items to the specified scale value in the Default mode. The valid range is from `0` to `1` and the default value is `0`.

{% tabs %}

{% highlight xaml %}
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Grid>
                <Image Source="{Binding Image}" Aspect="AspectFit"/>
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     ItemHeight="170"
                     ItemWidth="270"
                     ScaleOffset="0.5"/>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    ScaleOffset = 0.5f,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var grid = new Grid();
        var nameLabel = new Image();
        nameLabel.SetBinding(Image.SourceProperty, "Image");
        grid.Children.Add(nameLabel);
        return grid;
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


![Scale offset in .NET MAUI Carousel View.](Images/net-maui-carousel-view-scaleoffset.png)

## Set Item Spacing in Linear Mode

The spacing of all items in Linear mode can be configured by using the [ItemSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemSpacing) property. The default value is `0`.

{% tabs %}

{% highlight xaml %}
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="itemTemplate">
            <Grid>
                <Image Source="{Binding Image}" Aspect="AspectFit"/>
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<carousel:SfCarousel x:Name="carousel"
                     ItemsSource="{Binding ImageCollection}"
                     ItemTemplate="{StaticResource itemTemplate}"
                     ItemHeight="170"
                     ItemWidth="270"
                     ItemSpacing="60"
                     ViewMode="Linear"/>

{% endhighlight %}

{% highlight C# %}

CarouselViewModel carouselViewModel = new CarouselViewModel();
SfCarousel carousel = new SfCarousel()
{
    ItemHeight = 170,
    ItemWidth = 270,
    ItemSpacing = 60,
    ViewMode = ViewMode.Linear,
    BindingContext = carouselViewModel,
    ItemsSource = carouselViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var grid = new Grid();
        var nameLabel = new Image();
        nameLabel.SetBinding(Image.SourceProperty, "Image");
        grid.Children.Add(nameLabel);
        return grid;
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


![ItemSpacing in .NET MAUI Carousel View.](Images/net-maui-carousel-view-itemspacing.png)

## Troubleshooting

| Issue | Possible Cause | Suggested Fix |
|-------|----------------|---------------|
| `Offset`, `RotationAngle`, `SelectedItemOffset`, or `ScaleOffset` has no visible effect. | The carousel is in `Linear` ViewMode. | Switch to `ViewMode="Default"` (or `ViewMode = ViewMode.Default` in C#). |
| `ItemSpacing` has no effect. | The carousel is in `Default` ViewMode. | Switch to `ViewMode="Linear"` (or `ViewMode = ViewMode.Linear` in C#). |
| Items disappear when `ScaleOffset` is set. | A value close to `0` makes items invisible. | Use a value closer to `1` (e.g., `0.5` or `0.8`). |
| XAML build error about the `carousel:` namespace. | The `Syncfusion.Maui.Carousel` namespace and assembly are not declared. | Add `xmlns:carousel="clr-namespace:Syncfusion.Maui.Carousel;assembly=Syncfusion.Maui.Carousel"` to the page root. |

## See Also

- [Getting Started with .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/getting-started)
- [Populating Items in .NET MAUI Carousel View](https://help.syncfusion.com/maui/carousel-view/populating-data)

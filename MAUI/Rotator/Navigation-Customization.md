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

### DotsStroke Color

The `DotsStroke` property is used to customize the color of the dots stroke in the `SfRotator`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfRotator x:Name="rotator" 
            ItemsSource="{Binding ImageCollection}" 
            SelectedIndex="2"
            BackgroundColor="#ececec"
            NavigationStripPosition="Bottom"
            DotsStroke="Aqua"
            WidthRequest="550"
            HeightRequest="550">

{% endhighlight %}
{% highlight c# %}

rotator.DotsStroke = Colors.Aqua;

{% endhighlight %}
{% endtabs %}

![SfRotator with dots stroke color](images/DotsStroke.png)

### Selected Dot Color

The `SelectedDotColor` property is used to customize the color of selected dot in the `SfRotator`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfRotator x:Name="rotator" 
            ItemsSource="{Binding ImageCollection}" 
            SelectedIndex="2"
            BackgroundColor="#ececec"
            NavigationStripPosition="Bottom"
            DotsStroke="Aqua" 
            SelectedDotColor="Blue"
            WidthRequest="550"
            HeightRequest="550">

{% endhighlight %}
{% highlight c# %}

rotator.DotsStroke = Color.Aqua;
rotator.SelectedDotColor = Color.Blue;
 
{% endhighlight %}
{% endtabs %}

![SfRotator with selected dot color](images/SelectedDotColor.png)

### Unselected Dot Color

The `UnselectedDotColor` property is used to customize the color of unselected dots in the `SfRotator`.

{% tabs %}
{% highlight xaml %}

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

{% endhighlight %}
{% highlight c# %}

rotator.DotsStroke = Color.Aqua;
rotator.SelectedDotColor = Color.Blue;
rotator.UnselectedDotColor = Color.Gray;

{% endhighlight %}
{% endtabs %}

![SfRotator with unselected dot color](images/UnselectedDotColor.png)

## Thumbnails Customization

In Thumbnail Customization we can customise the  selected and unselected thumbnail's stroke.

### Selected Thumbnail Stroke

The `SelectedThumbnailStroke` property is used to customize the color of the selected thumbnail stroke in the `SfRotator`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfRotator x:Name="rotator" 
            ItemsSource="{Binding ImageCollection}" 
            SelectedIndex="2"
            BackgroundColor="#ececec"
            NavigationStripPosition="Bottom"
            NavigationStripMode="Thumbnail"
            SelectedThumbnailStroke="Green"
            WidthRequest="550"
            HeightRequest="550">

{% endhighlight %}
{% highlight c# %}

rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
rotator.SelectedThumbnailStroke = Colors.Green;

{% endhighlight %}
{% endtabs %}

![SfRotator with selected thumbnail stroke](images/SelectedThumbnailStroke.png)

### UnSelected Thumbnail Stroke

The `UnSelectedThumbnailStroke` property is used to customize the color of the unselected thumbnails stroke in the `SfRotator`.

{% tabs %}
{% highlight xaml %}

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

{% endhighlight %}
{% highlight c# %}

rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
rotator.SelectedThumbnailStroke = Colors.Green;
rotator.UnSelectedThumbnailStroke = Colors.Red;

{% endhighlight %}
{% endtabs %}

![SfRotator with unselected thumbnail stroke](images/UnSelectedThumbnailStroke.png)

## Navigation Button Customization

In Navigation Button Customization we can customise the  navigation button's icon and Background color.

### Navigation Button Icon Color

The `NavigationButtonIconColor` property is used to customize the color of the navigation buttons icon in the `SfRotator`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfRotator x:Name="rotator" 
            ItemsSource="{Binding ImageCollection}" 
            SelectedIndex="2"
            BackgroundColor="#ececec"
            NavigationStripMode="Thumbnail"
            NavigationButtonIconColor="Blue"
            WidthRequest="550"
            HeightRequest="550">
 
{% endhighlight %}
{% highlight c# %}

rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
rotator.NavigationButtonIconColor = Colors.Blue;

{% endhighlight %}
{% endtabs %}

![SfRotator with navigation button's icon Color](images/NavigationButtonIconColor.png)

### Navigation Button Background Color

The `NavigationButtonBackgroundColor` property is used to customize the color of the navigation buttons background in the `SfRotator`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfRotator x:Name="rotator" 
            ItemsSource="{Binding ImageCollection}" 
            SelectedIndex="2"
            BackgroundColor="#ececec"
            NavigationStripMode="Thumbnail"
            NavigationButtonBackgroundColor="Pink"
            NavigationButtonIconColor="Blue"
            WidthRequest="550"
            HeightRequest="550">
 
{% endhighlight %}
{% highlight c# %}

rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
rotator.NavigationButtonBackgroundColor = Colors.Pink;
rotator.NavigationButtonIconColor = Colors.Blue;

{% endhighlight %}
{% endtabs %}

![SfRotator with navigation button's Background Color](images/NavigationButtonBackgroundColor.png)

## Navigation Visibility

We can show or hide  Navigation Button using `ShowNavigationButton` property.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfRotator x:Name="rotator" 
            ItemsSource="{Binding ImageCollection}" 
            SelectedIndex="2"
            BackgroundColor="#ececec"
            NavigationStripMode="Thumbnail"
            ShowNavigationButton="False"
            WidthRequest="550"
            HeightRequest="550">
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


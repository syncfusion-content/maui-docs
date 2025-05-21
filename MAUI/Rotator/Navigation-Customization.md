---
layout: post
title: Navigation Customization in .NET MAUI Rotator control | Syncfusion®
description: Learn about navigation customization support in the Syncfusion® .NET MAUI Rotator (SfRotator) control.
platform: maui 
control: Rotator 
documentation: ug
---

# Navigation Customization in .NET MAUI Rotator (SfRotator)

The Rotator control supports customizing dots, thumbnails, and navigation buttons to enhance the user interface.

## Dots Customization

You can customize the dots' stroke, as well as the colors for selected and unselected dots.
### Dots Stroke Color

Use the [`DotsStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_DotsStroke) property to customize the color of the dot strokes in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1).

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

The [`SelectedDotColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedDotColor) property is used to customize the color of selected dot in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1).

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

The [`UnselectedDotColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_UnselectedDotColor) property is used to customize the color of unselected dots in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1).

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

Customize the strokes of selected and unselected thumbnails.

### Selected Thumbnail Stroke

The [`SelectedThumbnailStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedThumbnailStroke) property is used to customize the color of the selected thumbnail stroke in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1).

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

### Unselected Thumbnail Stroke

The [`UnSelectedThumbnailStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_UnselectedThumbnailStroke) property is used to customize the color of the unselected thumbnails stroke in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1).

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

Customize the icon and background color of navigation buttons.
### Navigation Button Icon Color

The [`NavigationButtonIconColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationButtonIconColor) property is used to customize the color of the navigation buttons icon in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1).

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

![SfRotator with navigation button icon color](images/NavigationButtonIconColor.png)

### Navigation Button Background Color

The [`NavigationButtonBackgroundColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationButtonBackgroundColor) property is used to customize the color of the navigation buttons background in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1).

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

![SfRotator with navigation button background color](images/NavigationButtonBackgroundColor.png)

## Navigation Visibility

Show or hide the navigation buttons using the [`ShowNavigationButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ShowNavigationButton) property.

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

rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
rotator.ShowNavigationButton = false;
    
{% endhighlight %}
{% endtabs %}

![SfRotator with Show Navigation Button property](images/ShowNavigationButton.png)

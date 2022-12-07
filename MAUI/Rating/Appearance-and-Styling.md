---

layout: post
title: Appearance and Styling in .NET MAUI Rating control | Syncfusion
description: Learn here all about Appearance and Styling support in Syncfusion .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Appearance and Styling in .NET MAUI Rating (SfRating)

When the default view is not needed, you can customize the view of .NET MAUI [`SfRating`] control. The [`SfRating`] control provides support to customize the size, item count, and space between rating items.

## Set Size

The [`ItemSize`] property sets the size of the rating items. 

N> By default, property value is 50.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating ItemSize="20" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.ItemSize = 20;
}

{% endhighlight %}

{% endtabs %}

![SfRating layout customization](images/layoutSize.jpg)

## Set Number of Items

The [`ItemCount`] property sets the number of rating items to be displayed. 

N> The default property value is 5.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating ItemCount="4" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.ItemCount = 4;
}

{% endhighlight %}

{% endtabs %}

![Set number of rating items](images/fourstar.jpg)
 
## Set Space between Items

The [`ItemSpacing`] property sets the spacing between the rating items. 

N> By default, property value is 5.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating ItemSpacing="20" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    rating.ItemSpacing = 20;
}

{% endhighlight %}

{% endtabs %}

![Space between rating items](images/layoutSpace.jpg) 

## Rating Settings

This section explains about various rating settings available in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

     <rating:SfRating  Value="3">
        <rating:SfRating.RatingSettings>
            <rating:SfRatingSettings RatedFill="Red" UnRatedFill="Blue" RatedStrokeWidth="3" UnRatedStrokeWidth="2" />
        </rating:SfRating.RatingSettings>
     </rating:SfRating>

{% endhighlight %}

{% highlight c# %}

SfRating rating;
SfRatingSettings ratingSettings;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    ratingSettings = new SfRatingSettings();
    ratingSettings.RatedFill = Color.Red;
    ratingSettings.UnRatedFill = Color.Blue;
    ratingSettings.RatedStrokeWidth = 3;
    ratingSettings.UnRatedStrokeWidth = 2;
    rating.RatingSettings = ratingSettings;
}

{% endhighlight %}

{% endtabs %}

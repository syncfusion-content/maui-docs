---

layout: post
title: Appearance Customization in .NET MAUI Rating control | Syncfusion
description: Learn here all about Appearance Customization support in Syncfusion .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Appearance Customization in .NET MAUI Rating (SfRating)

We can customize the rated and unrated fill Color, Stroke and Stroke thickness using the following properties of [`SfRatingSettings`].

* [`RatedFill`]
* [`UnratedFill`]
* [`RatedStroke`]
* [`UnratedStroke`]
* [`RatedStrokeThickness`]
* [`UnratedStrokeThickness`]
 
## Set Fill Color

[`SfRating`] control has support to set the fill color for the rated and unrated items.

### Selected Items

The [`RatedFill`] property fills the rated item with the specified solid color in the [`SfRating`]

{% tabs %}

{% highlight xaml %}

    <rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
    <rating:RatingSettings RatedFill="Red"/>
    </rating:SfRating.RatingSettings>
    </rating:SfRating>
	
{% endhighlight %}

{% highlight C# %}

    SfRating rating= new SfRating();
    rating.Value = 3;
    SfRatingSettings ratingSettings = new SfRatingSettings();
    ratingSettings.RatedFill = Color.Red;
    rating.RatingSettings = ratingSettings;
           
{% endhighlight %}

{% endtabs %}

![Rated item fill color](images/ratedFill.jpg)

### Unrated Items

The [`UnratedFill`] property fills the unrated item with the specified solid color in the [`SfRating`].

{% tabs %}

{% highlight xaml %}

    <rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
    <rating:SfRatingSettings UnRatedFill="Gray"/>
    </rating:SfRating.RatingSettings>
    </rating:SfRating>

{% endhighlight %}

{% highlight C# %}

    SfRating rating= new SfRating();
    rating.Value = 3;
    SfRatingSettings ratingSettings = new SfRatingSettings();
    ratingSettings.UnRatedFill = Color.Gray;
    rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Unrated item fill color](images/unRatedFill.jpg)

## Set Stroke

[`SfRating`] control has support to set the stroke color for the selected and unselected items.

### Rated Items

The [`RatedStroke`] property sets the stroke for the rated item with the specified solid color for the rated items in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

    <rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
    <rating:SfRatingSettings RatedStroke="Black"/>
    </rating:SfRating.RatingSettings>
    </rating:SfRating>
	
{% endhighlight %}

{% highlight C# %}

    SfRating rating= new SfRating();
    rating.Value = 3;
    SfRatingSettings ratingSettings = new SfRatingSettings();
    ratingSettings.RatedStroke=Color.Black;
    rating.RatingSettings = ratingSettings;	

{% endhighlight %}

{% endtabs %}

![Rated item stroke color](images/ratedStroke.jpg)

### Unrated Items

The [`UnratedStroke`] property sets the stroke for the unrated area with the specified solid color in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

    <rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
    <rating:SfRatingSettings UnRatedStroke="Black"/>
    </rating:SfRating.RatingSettings>
    </rating:SfRating>

{% endhighlight %}

{% highlight C# %}

    SfRating rating= new SfRating();
    rating.Value = 3;
    SfRatingSettings ratingSettings = new SfRatingSettings();
    ratingSettings.UnRatedStroke = Color.Black;
    rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Unrated item stroke color](images/unRatedStroke.jpg)
 
## Set Stroke Thickness

[`SfRating`] control has support to set the stroke thickness for the rated and unrated items.

### Rated Items

The [`RatedStrokeThickness`] property sets the stroke width for the rated item with the specified value in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

    <rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
    <rating:SfRatingSettings RatedStrokeWidth="3"/>
    </rating:SfRating.RatingSettings>
    </rating:SfRating>

{% endhighlight %}

{% highlight C# %}

    SfRating rating= new SfRating();
    rating.Value = 3;
    SfRatingSettings ratingSettings = new SfRatingSettings();
    ratingSettings.RatedStrokeWidth=3;
    rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Rated item stroke thickness](images/ratedStrokeThickness.jpg)

### Unrated Items

The [`UnratedStrokeThickness`] property sets the stroke width for the unrated item with the specified value in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

    <rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
    <rating:SfRatingSettings UnRatedStrokeWidth="3"/>
    </rating:SfRating.RatingSettings>
    </rating:SfRating>
	
{% endhighlight %}

{% highlight C# %}

    SfRating rating= new SfRating();
    rating.Value = 3;
    SfRatingSettings ratingSettings = new SfRatingSettings();
    ratingSettings.UnRatedStrokeWidth=3;
    rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Unrated item stroke thickness](images/unRatedStrokeThickness.jpg)

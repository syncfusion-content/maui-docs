---

layout: post
title: Appearance Customization in .NET MAUI Rating control | Syncfusion
description: Learn here all about Appearance Customization support in Syncfusion .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Appearance Customization in .NET MAUI Rating (SfRating)

We can customize the rated and unrated fill color, stroke and stroke thickness using the following properties of [`SfRatingSettings`].

* [`RatedFill`]
* [`UnratedFill`]
* [`RatedStroke`]
* [`UnratedStroke`]
* [`RatedStrokeThickness`]
* [`UnratedStrokeThickness`]
 
## Set Fill Color

[`SfRating`] control has support to set the fill color for the rated and unrated items.

### Rated Items

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
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.RatedFill = Colors.Red;
rating.RatingSettings = ratingSettings;
           
{% endhighlight %}

{% endtabs %}

![Rated item fill color](images/rated-fill.png)

### Unrated Items

The [`UnratedFill`] property fills the unrated item with the specified solid color in the [`SfRating`].

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings UnratedFill="Gray"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating= new SfRating();
rating.Value = 3;
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.UnratedFill = Colors.Gray;
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Unrated item fill color](images/unrated-fill.png)

## Set Stroke

[`SfRating`] control has support to set the stroke color for the selected and unselected items.

### Rated Items

The [`RatedStroke`] property sets the stroke for the rated item with the specified solid color for the rated items in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings RatedStroke="Black"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>
	
{% endhighlight %}

{% highlight C# %}

SfRating rating= new SfRating();
rating.Value = 3;
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.RatedStroke = Colors.Black;
rating.RatingSettings = ratingSettings;	

{% endhighlight %}

{% endtabs %}

![Rated item stroke](images/rated-stroke.png)

### Unrated Items

The [`UnratedStroke`] property sets the stroke for the unrated area with the specified solid color in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings UnratedStroke="Black"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating= new SfRating();
rating.Value = 3;
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.UnratedStroke = Colors.Black;
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Unrated item stroke](images/unrated-stroke.png)
 
## Set Stroke Thickness

[`SfRating`] control has support to set the stroke thickness for the rated and unrated items.

### Rated Items

The [`RatedStrokeThickness`] property sets the stroke thickness for the rated item with the specified value in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings RatedStrokeThickness="3"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating= new SfRating();
rating.Value = 3;
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.RatedStrokeThickness=3;
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Rated item stroke thickness](images/rated-stroke-thickness.png)

### Unrated Items

The [`UnratedStrokeThickness`] property sets the stroke thickness for the unrated item with the specified value in the [`SfRating`] control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings UnratedStrokeThickness="3"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>
	
{% endhighlight %}

{% highlight C# %}

SfRating rating= new SfRating();
rating.Value = 3;
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.UnratedStrokeThickness=3;
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Unrated item stroke thickness](images/unrated-stroke-thickness.png)

---

layout: post
title: Appearance Customization in .NET MAUI Rating control | Syncfusion
description: Learn here all about Appearance Customization support in Syncfusion .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Appearance Customization in .NET MAUI Rating (SfRating)

You can customize the rated and unrated fill color, stroke and stroke thickness using the following properties of [`RatingSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html).

* [`RatedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedFill)
* [`UnratedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedFill)
* [`RatedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStroke)
* [`UnratedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStroke)
* [`RatedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness)
* [`UnratedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStrokeThickness)
 
## Set Fill Color

[`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control has support to set the fill color for the rated and unrated items.

### Rated items

The [`RatedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedFill) property fills the rated items with the specified solid color in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html).

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
Content = rating;
           
{% endhighlight %}

{% endtabs %}

![Rated item fill color](images/rated-fill.png)

### Unrated items

The [`UnratedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedFill) property fills the unrated items with the specified solid color in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html).

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
Content = rating;

{% endhighlight %}

{% endtabs %}

![Unrated item fill color](images/unrated-fill.png)

## Set Stroke

[`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control has support to set the stroke color for the rated and unrated items.

### Rated items

The [`RatedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStroke) property sets the stroke for the rated items with the specified solid color in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control.

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
Content = rating;

{% endhighlight %}

{% endtabs %}

![Rated item stroke](images/rated-stroke.png)

### Unrated items

The [`UnratedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStroke) property sets the stroke for the unrated area with the specified solid color in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control.

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
Content = rating;

{% endhighlight %}

{% endtabs %}

![Unrated item stroke](images/unrated-stroke.png)
 
## Set Stroke Thickness

[`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control has support to set the stroke thickness for the rated and unrated items.

### Rated items

The [`RatedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness) property sets the stroke thickness for the rated items with the specified value in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings RatedStroke="Black" RatedStrokeThickness="3"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight C# %}

SfRating rating= new SfRating();
rating.Value = 3;
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.RatedStrokeThickness=3;
rating.RatingSettings = ratingSettings;
Content = rating;

{% endhighlight %}

{% endtabs %}

![Rated item stroke thickness](images/rated-stroke-thickness.png)

### Unrated items

The [`UnratedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStrokeThickness) property sets the stroke thickness for the unrated items with the specified value in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating Value="3">
    <rating:SfRating.RatingSettings>
        <rating:RatingSettings UnratedStroke="Black" UnratedStrokeThickness="3"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>
	
{% endhighlight %}

{% highlight C# %}

SfRating rating= new SfRating();
rating.Value = 3;
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.UnratedStrokeThickness=3;
rating.RatingSettings = ratingSettings;
Content = rating;

{% endhighlight %}

{% endtabs %}

![Unrated item stroke thickness](images/unrated-stroke-thickness.png)

---

layout: post
title: Appearance Customization in .NET MAUI Rating Control | Syncfusion®
description: Learn about Appearance Customization support in the Syncfusion® .NET MAUI Rating (SfRating) control.
platform: maui
control: Rating
documentation: ug

---

# Appearance Customization in .NET MAUI Rating (SfRating)

Customize the rated and unrated fill colors, strokes, and stroke thickness using properties from the [`RatingSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html) class.

- [`RatedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedFill)
- [`UnratedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedFill)
- [`RatedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStroke)
- [`UnratedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStroke)
- [`RatedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness)
- [`UnratedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStrokeThickness)
 
## Set Fill Color

The [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control allows you to set fill colors for rated and unrated items.

### Rated Items

The [`RatedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedFill) property fills rated items with a specified solid color.

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

The [`UnratedFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedFill) property fills unrated items with a specified solid color.

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

The [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control allows you to set stroke colors for rated and unrated items.

### Rated Items

The [`RatedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStroke) property sets the stroke for rated items with a specified solid color.

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

The [`UnratedStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStroke) property sets the stroke for unrated items with a specified solid color.

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

The [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control allows you to set stroke thickness for rated and unrated items.

### Rated Items

The [`RatedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness) property sets the stroke thickness for rated items with a specified value.

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
ratingSettings.RatedStroke = Colors.Black;
ratingSettings.RatedStrokeThickness=3;
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Rated item stroke thickness](images/rated-stroke-thickness.png)

### Unrated Items

The [`UnratedStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_UnratedStrokeThickness) property sets the stroke thickness for unrated items with a specified value.

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
ratingSettings.UnratedStroke = Colors.Black;
ratingSettings.UnratedStrokeThickness=3;
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Unrated item stroke thickness](images/unrated-stroke-thickness.png)

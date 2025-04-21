---

layout: post
title: Appearance and Styling in .NET MAUI Rating control | Syncfusion®
description: Learn here all about Appearance and Styling support in Syncfusion® .NET MAUI Rating (SfRating) control and more.
platform: maui
control: Rating
documentation: ug

---

# Appearance and Styling in .NET MAUI Rating (SfRating)

When the default view is not needed, you can customize the view of [.NET MAUI SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. The [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control provides support to customize the item size, item count, and space between rating items.

## Set Size

The [`ItemSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSize) property sets the size of the rating items. 

N> By default, property value is 50.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating ItemSize="20" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating();
rating.ItemSize = 20;

{% endhighlight %}

{% endtabs %}

![SfRating Item Size customization](images/item-size.png)

## Set Number of Items

The [`ItemCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount) property sets the number of rating items to be displayed. 

N> The default property value is 5.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating ItemCount="4" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating();
rating.ItemCount = 4;

{% endhighlight %}

{% endtabs %}

![Set number of rating items](images/item-count.png)
 
## Set Space between Items

The [`ItemSpacing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSpacing) property sets the spacing between the rating items. 

N> By default, property value is 5.

{% tabs %}

{% highlight xaml %}

	<rating:SfRating ItemSpacing="20" />
	
{% endhighlight %}

{% highlight C# %}

SfRating rating = new SfRating();
rating.ItemSpacing = 20;

{% endhighlight %}

{% endtabs %}

![Space between rating items](images/item-spacing.png) 

## Rating Settings

This section explains about various rating settings available in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control.

{% tabs %}

{% highlight xaml %}

<rating:SfRating  Value="3">
<rating:SfRating.RatingSettings>
    <rating:RatingSettings RatedFill="Red" UnratedFill="Gray" 
                           UnratedStroke="Blue" RatedStrokeThickness="2" UnratedStrokeThickness="2"/>
    </rating:SfRating.RatingSettings>
</rating:SfRating>

{% endhighlight %}

{% highlight c# %}


SfRating rating = new SfRating();
RatingSettings ratingSettings = new RatingSettings();
ratingSettings.RatedFill = Colors.Red;
ratingSettings.UnratedFill = Colors.Gray;
ratingSettings.UnratedStroke = Colors.Blue;
ratingSettings.RatedStrokeThickness = 2;
ratingSettings.UnratedStrokeThickness = 2;
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Rating Settings](images/rating-settings.png) 

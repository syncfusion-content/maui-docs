---

layout: post
title: Appearance and Styling in .NET MAUI Rating Control | Syncfusion®
description: Learn about the Appearance and Styling support in Syncfusion® .NET MAUI Rating (SfRating) control.
platform: maui
control: Rating
documentation: ug

---

# Appearance and Styling in .NET MAUI Rating (SfRating)

When the default view is not desired, you can customize the view of the [.NET MAUI SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. The [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control provides options to customize item size, item count, and spacing between rating items.

## Set Size

Use the [`ItemSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSize) property to set the size of the rating items.

> Note: The default property value is 50.

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

Use the [`ItemCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount) property to set the number of rating items to be displayed.

> Note: The default property value is 5.

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
 
## Set Space Between Items

Use the [`ItemSpacing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSpacing) property to set the spacing between rating items.

> Note: The default property value is 5.

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

This section explains various rating settings available in the [`SfRating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control.

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
RatingSettings ratingSettings = new RatingSettings()
{
    RatedFill = Colors.Red,
    UnratedFill = Colors.Gray,
    UnratedStroke = Colors.Blue,
    RatedStrokeThickness = 2,
    UnratedStrokeThickness = 2
};
rating.RatingSettings = ratingSettings;

{% endhighlight %}

{% endtabs %}

![Rating Settings](images/rating-settings.png) 

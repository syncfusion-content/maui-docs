---
layout: post
title: Migrate from Syncfusion Xamarin SfShimmer to .NET MAUI SfShimmer
description: Learn here all about Migrating from Syncfusion Xamarin Shimmer to Syncfusion .NET MAUI Shimmer control.
platform: maui
control: SfShimmer
documentation: ug
---  

# Migrate from Xamarin.Forms SfShimmer to .NET MAUI SfShimmer 

To make the migration from the [Xamarin SfShimmer](https://www.syncfusion.com/xamarin-ui-controls/xamarin-shimmer) to [.NET MAUI SfShimmer] easier, most of the APIs from the Xamarin SfShimmer were kept in the.NET MAUI SfShimmer. However, to maintain the consistency of API naming in the .NET MAUI SfShimmer, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th></tr>
<tr>
<td>Syncfusion.XForms.Shimmer</td>
<td>Syncfusion.Maui.Shimmer</td></tr>
</table>

N> The selection-based `.NET MAUI SfShimmer` does not manage appointments like the `Xamarin SfShimmer` does. If you require appointment/events management use `.NET MAUI SfShimmer`.

## Initialize control

To initialize the control, import the shimmer namespace and initialize `SfShimmer` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:shimmer="clr-namespace:Syncfusion.XForms.Shimmer;assembly=Syncfusion.Core.XForms">

    <shimmer:SfShimmer />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.Shimmer;
...

SfShimmer shimmer = new SfShimmer();
this.Content = shimmer;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:shimmer="clr-namespace:Syncfusion.Maui.Shimmer;assembly=Syncfusion.Maui.Core">

    <shimmer:SfShimmer />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Shimmer;
...

SfShimmer shimmer = new SfShimmer();
this.Content = shimmer;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th>
<th>Description</th></tr>
<tr>
<td>{{'[SfTemplateStyle ]'| markdownify }}</td>
<td>Nil</td>
<td>Not supported.</td>
</tr> 
<tr>
<td>{{'[ShimmerView ]' | markdownify }}</td>
<td>{{'[ShimmerView ]' | markdownify }}</td>
<td>Represents a view used to achieve shimmer custom view.</td>
</tr> 
<tr>
<td>Nil</td>
<td>{{'[ShimmerShapeType]' | markdownify }}</td>
<td>Represents a class which defines the shape for the Shimmer view.</td>
</tr>
</table>

## Properties 

### SfShimmer

The following code example, explains how to initialize the properties of the `Xamarin SfShimmer` and `.NET MAUI SfShimmer` class.

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:shimmer="clr-namespace:Syncfusion.XForms.Shimmer;assembly=Syncfusion.Core.XForms">
    
<shimmer:SfShimmer x:Name="shimmer" VerticalOptions="Fill"
                           IsActive="{Binding IsActive}">
                        <shimmer:SfShimmer.Content>
                            <StackLayout>
                                <Label Text="Content is loaded!" HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand"/>
                            </StackLayout>
                        </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfShimmer.XForms;
...

SfShimmer shimmer = new SfShimmer();
this.Content = shimmer;
shimmer.VerticalOptions = LayoutOptions.Fill;
shimmer.SetBinding(SfShimmer.IsActiveProperty, "IsActive");

var stackLayout = new StackLayout();

var label = new Label();
label.Text = "Content is loaded!";
label.HorizontalOptions = LayoutOptions.CenterAndExpand;
label.VerticalOptions = LayoutOptions.CenterAndExpand;

stackLayout.Children.Add(label);
shimmer.Content = stackLayout;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:shimmer="clr-namespace:Syncfusion.Maui.Shimmer;assembly=Syncfusion.Maui.Core">

<shimmer:SfShimmer />
<shimmer:SfShimmer x:Name="shimmer" VerticalOptions="Fill"
                           IsActive="{Binding IsActive}">
                        <shimmer:SfShimmer.Content>
                            <StackLayout>
                                <Label Text="Content is loaded!" HorizontalOptions="Fill" VerticalOptions="Fill"/>
                            </StackLayout>
                        </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Shimmer;
...

SfShimmer shimmer = new SfShimmer();
this.Content = shimmer;
shimmer.VerticalOptions = LayoutOptions.Fill;
shimmer.SetBinding(SfShimmer.IsActiveProperty, "IsActive");

var stackLayout = new StackLayout();

var label = new Label();
label.Text = "Content is loaded!";
label.HorizontalOptions = LayoutOptions.Fill;
label.VerticalOptions = LayoutOptions.Fill;

stackLayout.Children.Add(label);

shimmer.Content = stackLayout;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[Content]'| markdownify }}</td>
<td>{{'[Content]'| markdownify }}</td>
<td>Gets or sets the content of the Shimmer.</td>
</tr>
<tr>
<td>{{'[CustomView]'| markdownify }}</td>
<td>{{'[CustomView]'| markdownify }}</td>
<td>Gets or sets the custom view that is used for loading view in the Shimmer.</td>
</tr>
<tr>
<td>{{'[WaveDirection]'| markdownify }}</td>
<td>{{'[WaveDirection]'| markdownify }}</td>
<td>Gets or sets the animation direction for Shimmer.</td>
</tr>
<tr>
<td>{{'[Type]'| markdownify }}</td>
<td>{{'[Type]'| markdownify }}</td>
<td>Gets or sets the built-in shimmer view type.</td>
</tr>
<tr>
<td>{{'[Color]'| markdownify }}</td>
<td>{{'[Fill]'| markdownify }}</td>
<td>Gets or sets the background color of shimmer view.</td>
</tr>
<tr>
<td>{{'[WaveColor]'| markdownify }}</td>
<td>{{'[WaveColor]'| markdownify }}</td>
<td>Gets or sets the shimmer wave color.</td>
</tr>
<tr>
<td>{{'[WaveWidth]'| markdownify }}</td>
<td>{{'[WaveWidth]'| markdownify }}</td>
<td>Gets or sets the width of the shimmer wave.</td>
</tr>
<tr>
<td>{{'[AnimationDuration]'| markdownify }}</td>
<td>{{'[AnimationDuration]'| markdownify }}</td>
<td>Gets or sets the duration of the wave animation in milliseconds.</td>
</tr>
<tr>
<td>{{'[IsActive]'| markdownify }}</td>
<td>{{'[[IsActive]'| markdownify }}</td>
<td>Gets or sets a value indicating whether to load actual content of shimmer.</td>
</tr>
<tr>
<td>{{'[PersonaStyle]'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ProfileStyle]'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ArticleStyle]'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[VideoStyle]'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[FeedStyle]'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ShoppingStyle]'| markdownify }}</td>
<td>{{'[MaximumDate]'| markdownify }}</td>
<td>Gets or sets the maximum display date to restrict the visible dates in the SfShimmer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[RepeatCount]'| markdownify }}</td>
<td>Gets or sets the number of times the built-in view should be repeated.</td>
</tr>
</table>

### ShimmerView

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[BackgroundColor]'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CornerRadius]'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ShapeType]'| markdownify }}</td>
<td>Gets or sets the shape for the shimmer view.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[WaveDirection ]'| markdownify }}</td>
<td>{{'[ShimmerWaveDirection ]'| markdownify }}</td>
<td>Defines the wave direction for the Shimmer.</td>
</tr>
<tr>
<td>{{'[ShimmerTypes]'| markdownify }}</td>
<td>{{'[ShimmerType]'| markdownify }}</td>
<td>Defines the type of the Shimmer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ShimmerShapeType ]'| markdownify }}</td>
<td>Defines the shape for the Shimmer view.</td>
</tr>
</table>
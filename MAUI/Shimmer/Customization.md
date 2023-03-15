---
layout: post
title: About .NET MAUI Shimmer control | Syncfusion
description: Learn here about the Customization of Syncfusion .NET MAUI Shimmer (SfShimmer) control, its basic features, elements and more.
platform: maui
control: SfShimmer
documentation: ug
---

# Customization of .NET MAUI Shimmer (SfShimmer)

The `SfShimmer` control provides the following properties to customize the Shimmer,

* `Fill` - To customize the background color of Shimmer view. 
* `WaveColor` - To customize the Shimmer wave color.
* `WaveWidth` - To customize the Shimmer wave width.
* `WaveDirection` - To customize the Shimmer wave direction.
* `RepeatCount` - To customize the repeat count for the Shimmer.
* `AnimationDuration` - To customize the animation duration of the wave.

This section explains how to customize the Shimmer control.

## Fill

The background color of the `SfShimmer` view can be customized by using the `Fill` property. The default value of the `Fill` property is `#F3EDF7`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill" Type="Article" Fill="Pink">
   <shimmer:SfShimmer.Content>
      <StackLayout>
         <Label 
            Text="Content is loaded!!">
         </Label>
      </StackLayout>
   </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfShimmer Shimmer = new SfShimmer()
{
      Type = ShimmerType.Article,
      Fill = Colors.Pink,
      Content = new Label
      {
         Text = "Content is loaded!"              
      }
};

this.Content = Shimmer;

{% endhighlight %}
{% endtabs %}

## WaveColor

The wave color in the `SfShimmer` view can be customized using the `WaveColor` property. The default value of `WaveColor` is the `#F3EDF7` Color.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill" Type="Article" WaveColor="#9A4EAE">
   <shimmer:SfShimmer.Content>
      <StackLayout>
         <Label 
            Text="Content is loaded!!">
         </Label>
      </StackLayout>
   </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfShimmer Shimmer = new SfShimmer()
{
      Type = ShimmerType.Article,
      WaveColor = Color.FromRgba("#9A4EAE"),
      Content = new Label
      {
         Text = "Content is loaded!"              
      }
};

this.Content = Shimmer;

{% endhighlight %}
{% endtabs %}

## WaveWidth

The width of the wave in the `SfShimmer` view can be customized using the `WaveWidth` property. The default value of `WaveWidth` is `200`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill" Type="Article" Fill="Pink" WaveColor="#9A4EAE"  WaveWidth="100">
   <shimmer:SfShimmer.Content>
      <StackLayout>
         <Label 
            Text="Content is loaded!!">
         </Label>
      </StackLayout>
   </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfShimmer Shimmer = new SfShimmer()
{
      Type = ShimmerType.Article,
      Fill = Colors.Pink,
      WaveColor = Color.FromRgba("#9A4EAE"),
      WaveWidth = 100,
      Content = new Label
      {
         Text = "Content is loaded!"              
      }
};

this.Content = Shimmer;

{% endhighlight %}
{% endtabs %}

## WaveDirection

The direction of the wave in the `SfShimmer` view can be customized by using the `WaveDirection` property. By default, wave direction is rendered by the `Default` wave. The following wave directions are available in SfShimmer:

* `Default` - Default enum of the animation direction allows the animation from left top to right bottom.
* `LeftToRight` - LeftToRight enum of the animation direction allows the animation from left to right.
* `RightToLeft` - RightToLeft enum of the animation direction allows the animation from right to left.
* `TopToBottom` - TopToBottom enum of the animation direction allows the animation from top to bottom.
* `BottomToTop` - BottomToTop enum of the animation direction allows the animation from bottom to top.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill" Type="Article" WaveDirection="TopToBottom">
   <shimmer:SfShimmer.Content>
      <StackLayout>
         <Label 
            Text="Content is loaded!!">
         </Label>
      </StackLayout>
   </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfShimmer Shimmer = new SfShimmer()
{
      Type = ShimmerType.Article,
      WaveDirection = ShimmerWaveDirection.TopToBottom,
      Content = new Label
      {
         Text = "Content is loaded!"              
      }
};

this.Content = Shimmer;

{% endhighlight %}
{% endtabs %}

## RepeatCount

The `RepeatCount` of the shimmer refers to the number of times a shimmer cycle repeats within a given wave period in the `SfShimmer` view. The default value of `RepeatCount` is `1`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill" Type="Article" RepeatCount="4">
   <shimmer:SfShimmer.Content>
      <StackLayout>
         <Label 
            Text="Content is loaded!!">
         </Label>
      </StackLayout>
   </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfShimmer Shimmer = new SfShimmer()
{
      Type = ShimmerType.Article,
      RepeatCount = 4,
      Content = new Label
      {
         Text = "Content is loaded!"              
      }
};

this.Content = Shimmer;

{% endhighlight %}
{% endtabs %}

## AnimationDuration

The duration of the animation in the `SfShimmer` view can be customized using the `AnimationDuration` property. The default value of `AnimationDuration` is `1000 ms`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill" Type="Article" AnimationDuration="4000">
   <shimmer:SfShimmer.Content>
      <StackLayout>
         <Label 
            Text="Content is loaded!!">
         </Label>
      </StackLayout>
   </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfShimmer Shimmer = new SfShimmer()
{
      Type = ShimmerType.Article,
      AnimationDuration = 4000,
      Content = new Label
      {
         Text = "Content is loaded!"              
      }
};

this.Content = Shimmer;

{% endhighlight %}
{% endtabs %}
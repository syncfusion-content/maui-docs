---
layout: post
title: About .NET MAUI Shimmer control | Syncfusion
description: Learn here about the Built-in types support of Syncfusion .NET MAUI Shimmer (SfShimmer) control and more.
platform: maui
control: SfShimmer
documentation: ug
---

# Built-in Views of .NET MAUI Shimmer (SfShimmer)

## Built-in types

Syncfusion .NET MAUI Shimmer (SfShimmer) control provides seven built-in shimmer view types.

* `CirclePersona`
* `SquarePersona`
* `Profile`
* `Article`
* `Video`
* `Feed`
* `Shopping`

The built-in shimmer types can be used by setting the `Type` of `SfShimmer`. By default, the `CirclePersona` is initially rendered.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="Fill" Type="CirclePersona">
   <shimmer:SfShimmer.Content>
      <StackLayout>
         <Label 
            Text="Content is loaded!!"
            HorizontalOptions="CenterAndExpand"
            VerticalOptions="CenterAndExpand">
         </Label>
      </StackLayout>
   </shimmer:SfShimmer.Content>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfShimmer shimmer = new SfShimmer()
   {
      Type = ShimmerType.CirclePersona,
      VerticalOptions = LayoutOptions.Fill,
      Content = new Label
      {
         Text = "Content is loaded!!"
      }
   };

   this.Content = shimmer;

{% endhighlight %}
{% endtabs %}
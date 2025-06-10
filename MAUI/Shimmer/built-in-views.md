---
layout: post
title: About .NET MAUI Shimmer control | Syncfusion<sup>&reg;</sup>
description: Learn about the built-in types supported by the Syncfusion<sup>&reg;</sup> .NET MAUI Shimmer (SfShimmer) control and more.
platform: maui
control: SfShimmer
documentation: ug
---

# Built-in views of .NET MAUI Shimmer (SfShimmer)

## Built-in types

The Syncfusion [.NET MAUI Shimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html) (SfShimmer) control provides seven built-in shimmer view types: CirclePersona, SquarePersona, Profile, Article, Video, Feed, and Shopping.

   ![Multiple Shimmer View in .NET MAUI.](images/overview/maui-multiple-shimmer-views.gif)

These built-in shimmer types can be applied by setting the [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_Type) property of `SfShimmer`. By default, the [CirclePersona](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerType.html#Syncfusion_Maui_Shimmer_ShimmerType_CirclePersona) type is initially rendered.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<shimmer:SfShimmer x:Name="shimmer" VerticalOptions="FillAndExpand" 
                   Type="CirclePersona">
      <StackLayout>
         <Label 
            Text="Content is loaded!"
            HorizontalOptions="CenterAndExpand"
            VerticalOptions="CenterAndExpand">
         </Label>
      </StackLayout>
</shimmer:SfShimmer>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

SfShimmer shimmer = new SfShimmer()
{
    Type = ShimmerType.CirclePersona,
    VerticalOptions = LayoutOptions.Fill,
    Content = new Label
    {
        Text = "Content is loaded!"
    }
};

this.Content = shimmer;

{% endhighlight %}
{% endtabs %}
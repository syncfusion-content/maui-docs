---
layout: post
title: About .NET MAUI Shimmer control | Syncfusion
description: Learn here about the Built-in types support of Syncfusion .NET MAUI Shimmer (SfShimmer) control and more.
platform: maui
control: SfShimmer
documentation: ug
---

# Built-in views of .NET MAUI Shimmer (SfShimmer)

## Built-in types

Syncfusion [.NET MAUI Shimmer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html) (SfShimmer) control provides seven built-in shimmer view types such as CirclePersona, SquarePersona, Profile, Article, Video, Feed, and Shopping.

   ![Multiple Shimmer View in .NET MAUI.](images/overview/maui-multiple-shimmer-views.gif)

The built-in shimmer types can be used by setting the [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_Type) of `SfShimmer`. By default, the [CirclePersona](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerType.html#Syncfusion_Maui_Shimmer_ShimmerType_CirclePersona) is initially rendered.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<shimmer:SfShimmer x:Name="shimmer" VerticalOptions="FillAndExpand" 
                   Type="CirclePersona">
      <StackLayout>
         <Label 
            Text="Content is loaded!!"
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
         Text = "Content is loaded!!"
      }
   };

   this.Content = shimmer;

{% endhighlight %}
{% endtabs %}
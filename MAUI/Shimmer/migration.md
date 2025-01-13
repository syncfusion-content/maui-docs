---
layout: post
title: Migrate from Syncfusion<sup>&reg;</sup> Xamarin SfShimmer to .NET MAUI SfShimmer
description: Learn here all about Migrating from Syncfusion<sup>&reg;</sup> Xamarin Shimmer to Syncfusion<sup>&reg;</sup> .NET MAUI Shimmer control.
platform: maui
control: SfShimmer
documentation: ug
---  

# Migrate from Xamarin.Forms SfShimmer to .NET MAUI SfShimmer 

To make the migration from the [Xamarin SfShimmer](https://www.syncfusion.com/xamarin-ui-controls/xamarin-shimmer) to [.NET MAUI SfShimmer](https://www.syncfusion.com/maui-controls/maui-shimmer) easier, most of the APIs from the Xamarin SfShimmer were kept in the .NET MAUI SfShimmer. However, to maintain the consistency of API naming in the .NET MAUI SfShimmer, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfShimmer</th>
<th>.NET MAUI SfShimmer</th></tr>
<tr>
<td>Syncfusion.XForms.Shimmer</td>
<td>Syncfusion.Maui.Shimmer</td></tr>
</table>

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
<td>{{'[ShimmerView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.ShimmerView.html)'| markdownify }}</td>
<td>{{'[ShimmerView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerView.html)'| markdownify }}</td>
<td>Represents a view used to achieve shimmer custom view.</td>
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
                            <StackLayout>
                                <Label Text="Content is loaded!" HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand"/>
                            </StackLayout>
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

<shimmer:SfShimmer x:Name="Shimmer" VerticalOptions="FillAndExpand">
   <StackLayout>
      <Label 
         Text="Content is loaded!!"
         HorizontalOptions="CenterAndExpand"
         VerticalOptions="CenterAndExpand">
      </Label>
   </StackLayout>
</shimmer:SfShimmer>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Shimmer;
...

SfShimmer shimmer = new SfShimmer();
this.Content = shimmer;
shimmer.VerticalOptions = LayoutOptions.FillAndExpand;
var stackLayout = new StackLayout();
var label = new Label();
label.Text = "Content is loaded!";
label.HorizontalOptions = LayoutOptions.Fill;
label.VerticalOptions = LayoutOptions.Fill;

stackLayout.Children.Add(label);

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
<td>{{'[Content](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_Content)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CustomView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_CustomView)'| markdownify }}</td>
<td>{{'[CustomView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_CustomView)'| markdownify }}</td>
<td>Gets or sets the custom view that is used for loading view in the Shimmer.</td>
</tr>
<tr>
<td>{{'[WaveDirection](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_WaveDirection)'| markdownify }}</td>
<td>{{'[WaveDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_WaveDirection)'| markdownify }}</td>
<td>Gets or sets the animation direction for Shimmer.</td>
</tr>
<tr>
<td>{{'[Type](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_Type)'| markdownify }}</td>
<td>{{'[Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_Type)'| markdownify }}</td>
<td>Gets or sets the built-in shimmer view type.</td>
</tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_Color)'| markdownify }}</td>
<td>{{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_Fill)'| markdownify }}</td>
<td>Gets or sets the background color of shimmer view.</td>
</tr>
<tr>
<td>{{'[WaveColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_WaveColor)'| markdownify }}</td>
<td>{{'[WaveColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_WaveColor)'| markdownify }}</td>
<td>Gets or sets the shimmer wave color.</td>
</tr>
<tr>
<td>{{'[WaveWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_WaveWidth)'| markdownify }}</td>
<td>{{'[WaveWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_WaveWidth)'| markdownify }}</td>
<td>Gets or sets the width of the shimmer wave.</td>
</tr>
<tr>
<td>{{'[AnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_AnimationDuration)'| markdownify }}</td>
<td>{{'[AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_AnimationDuration)'| markdownify }}</td>
<td>Gets or sets the duration of the wave animation in milliseconds.</td>
</tr>
<tr>
<td>{{'[IsActive](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.SfShimmer.html#Syncfusion_XForms_Shimmer_SfShimmer_IsActive)'| markdownify }}</td>
<td>{{'[IsActive](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_IsActive)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to load actual content of shimmer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[RepeatCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.SfShimmer.html#Syncfusion_Maui_Shimmer_SfShimmer_RepeatCount)'| markdownify }}</td>
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

<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.ShimmerView.html#Syncfusion_XForms_Shimmer_ShimmerView_BackgroundColor)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.ShimmerView.html#Syncfusion_XForms_Shimmer_ShimmerView_CornerRadius)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerView.html#Syncfusion_Maui_Shimmer_ShimmerView_ShapeType)'| markdownify }}</td>
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
<td>{{'[WaveDirection](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.WaveDirection.html)'| markdownify }}</td>
<td>{{'[ShimmerWaveDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerWaveDirection.html)'| markdownify }}</td>
<td>Defines the wave direction for the Shimmer.</td>
</tr>
<tr>
<td>{{'[ShimmerTypes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Shimmer.ShimmerTypes.html)'| markdownify }}</td>
<td>{{'[ShimmerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerType.html)'| markdownify }}</td>
<td>Defines the type of the Shimmer.</td>
</tr>
<tr>
<td>Nil</td>
<td>{{'[ShimmerShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Shimmer.ShimmerShapeType.html)'| markdownify }}</td>
<td>Defines the shape for the Shimmer view.</td>
</tr>
</table>
---
layout: post
title: Migrate from Xamarin to .NET MAUI  ProgressBar | Syncfusion
description: Learn here all about Migrating from Syncfusion Xamarin SfProgressBar to Syncfusion .NET MAUI SfProgressBar control and more.
platform: MAUI
control: ProgressBar
documentation: ug
---  

# Migrate from Xamarin.Forms SfProgressBar to .NET MAUI SfProgressBar

To make the migration from the [Xamarin SfProgressBar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-progressbar) to `.NET MAUI SfProgressBar` easier, most of the APIs from the Xamarin SfProgressBar were kept in the.NET MAUI SfProgressBar. However, to maintain the consistency of API naming in the .NET MAUI SfProgressBar, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the ProgressBar namespace and initialize SfProgressBar as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfProgressBar</th>
<th>.NET MAUI SfProgressBar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

    ...     
    <progressBar:SfLinearProgressBar />

    <progressBar:SfCircularProgressBar />
    ...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();

...

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar">

    ...
    <progressBar:SfLinearProgressBar />

    <progressBar:SfCircularProgressBar />
    ...

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();

...

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Common Properties

<table> 
<tr>
<th>Xamarin SfProgressBar</th>
<th>.NET MAUI SfProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[EasingEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_EasingEffect)'| markdownify }}</td>
<td>{{'AnimationEasing'| markdownify }}</td>
<td>Gets or sets a value that specifies the easing effect for progress animation.</td></tr>
<tr>
<td>{{'[GapWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_GapWidth)'| markdownify }}</td>
<td>{{'SegmentGapWidth'| markdownify }}</td>
<td>Gets or sets the value that determine the gap between the segments.</td></tr>
<tr>
<td>{{'[IndeterminateEasingEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateEasingEffect)'| markdownify }}</td>
<td>{{'IndeterminateAnimationEasing'| markdownify }}</td>
<td>Gets or sets a value that specifies the easing effect for indeterminate animation.</td></tr>
<tr>
<td>{{'[IndeterminateIndicatorWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidth)'| markdownify }}</td>
<td>{{'IndeterminateIndicatorWidthFactor'| markdownify }}</td>
<td>Gets or sets the value that specifies width of the indeterminate indicator.</td></tr>
<tr>
<td>{{'[ProgressColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressColor)'| markdownify }}</td>
<td>{{'ProgressFill'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the progress.</td></tr>
<tr>
<td>{{'[RangeColors](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_RangeColors)'| markdownify }}</td>
<td>{{'GradientStops'| markdownify }}</td>
<td>Gets or sets a collection of ProgressGradientStop to fill the gradient brush to the progress.</td></tr>
<tr>
<td>{{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_TrackColor)'| markdownify }}</td>
<td>{{'TrackFill'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the track.</td></tr>
</table> 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

    ...     
<!--Snippet for the linear progress bar-->
<progressBar:SfLinearProgressBar EasingEffect="CubicOut"
                                 GapWidth="5"
                                 SegmentCount="4"
                                 IndeterminateEasingEffect="BounceIn"
                                 IndeterminateIndicatorWidth="0.7"
                                 ProgressColor="Blue"
                                 TrackColor="Violet"
                                 Progress="75">
    <progressBar:SfLinearProgressBar.RangeColors>
        <progressBar:RangeColorCollection>
            <progressBar:RangeColor IsGradient="True" Color="#00bdaf" Start="0" End="25"/>
            <progressBar:RangeColor IsGradient="True" Color="#2f7ecc" Start="25" End="50"/>
        </progressBar:RangeColorCollection>
    </progressBar:SfLinearProgressBar.RangeColors>
</progressBar:SfLinearProgressBar>

<!--Snippet for the circular progress bar-->
<progressBar:SfCircularProgressBar EasingEffect="CubicOut"
                                   GapWidth="5"
                                   SegmentCount="4"
                                   IndeterminateEasingEffect="BounceIn"
                                   IndeterminateIndicatorWidth="0.7"
                                   ProgressColor="Blue"
                                   TrackColor="Violet"
                                   Progress="75">
    <progressBar:SfCircularProgressBar.RangeColors>
        <progressBar:RangeColorCollection>
            <progressBar:RangeColor IsGradient="True" Color="#00bdaf" Start="0" End="25"/>
            <progressBar:RangeColor IsGradient="True" Color="#2f7ecc" Start="25" End="50"/>
        </progressBar:RangeColorCollection>
    </progressBar:SfCircularProgressBar.RangeColors>
</progressBar:SfCircularProgressBar>
    ...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

//Snippet for the linear progress bar

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 75;
linearProgressBar.EasingEffect = EasingEffects.CubicOut;
linearProgressBar.GapWidth = 5;
linearProgressBar.SegmentCount = 4;
linearProgressBar.IndeterminateEasingEffect = IndeterminateEasingEffects.BounceIn;
linearProgressBar.ProgressColor = Color.Red;
linearProgressBar.TrackColor = Color.Yellow;
linearProgressBar.RangeColors.Add(
    new RangeColor
    {
        Color = Color.FromHex("00bdaf"),
        Start = 0,
        End = 50,
        IsGradient = true
    });
linearProgressBar.RangeColors.Add(
    new RangeColor
    {
        Color = Color.FromHex("2f7ecc"),
        Start = 50,
        End = 100,
        IsGradient = true
    });
this.Content = linearProgressBar;

//Snippet for circular progress bar

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 75;
circularProgressBar.EasingEffect = EasingEffects.CubicOut;
circularProgressBar.GapWidth = 5;
circularProgressBar.SegmentCount = 4;
circularProgressBar.IndeterminateEasingEffect = IndeterminateEasingEffects.BounceIn;
circularProgressBar.ProgressColor = Color.Red;
circularProgressBar.TrackColor = Color.Yellow;
circularProgressBar.RangeColors.Add(
    new RangeColor
    {
        Color = Color.FromHex("00bdaf"),
        Start = 0,
        End = 50,
        IsGradient = true
    });
circularProgressBar.RangeColors.Add(
    new RangeColor
    {
        Color = Color.FromHex("2f7ecc"),
        Start = 50,
        End = 100,
        IsGradient = true
    });
this.Content = circularProgressBar;

...
{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar">

...
<!--Snippet for the linear progress bar-->
<progressBar:SfLinearProgressBar AnimationEasing="{x:Static Easing.CubicOut}"
                                 SegmentGapWidth="5"
                                 SegmentCount="4"
                                 IndeterminateAnimationEasing="{x:Static Easing.BounceIn}"
                                 IndeterminateIndicatorWidthFactor="0.7"
                                 ProgressFill="Blue"
                                 TrackFill="Violet"
                                 Progress="75">
    <progressBar:SfLinearProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="50"/>
    </progressBar:SfLinearProgressBar.GradientStops>
    
</progressBar:SfLinearProgressBar>

<!--Snippet for the circular progress bar-->
<progressBar:SfCircularProgressBar AnimationEasing="{x:Static Easing.CubicOut}"
                                   SegmentGapWidth="5"
                                   SegmentCount="4"
                                   IndeterminateAnimationEasing="{x:Static Easing.BounceIn}"
                                   IndeterminateIndicatorWidthFactor="0.7"
                                   ProgressFill="Blue"
                                   TrackFill="Violet"
                                   Progress="75">
    <progressBar:SfCircularProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="50"/>
    </progressBar:SfCircularProgressBar.GradientStops>
    
</progressBar:SfCircularProgressBar>

...

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...
//Snippet for the linear progress bar

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.AnimationEasing = Easing.CubicOut;
linearProgressBar.Progress = 75;
linearProgressBar.SegmentGapWidth = 5;
linearProgressBar.SegmentCount = 4;
linearProgressBar.IndeterminateAnimationEasing = Easing.BounceIn;
linearProgressBar.ProgressFill = Colors.Blue;
linearProgressBar.TrackFill = Colors.Violet;
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 0 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 50 });
this.Content = linearProgressBar;

//Snippet for the circular progress bar

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.AnimationEasing = Easing.CubicOut;
circularProgressBar.Progress = 75;
circularProgressBar.SegmentGapWidth = 5;
circularProgressBar.SegmentCount = 4;
circularProgressBar.IndeterminateAnimationEasing = Easing.BounceIn;
circularProgressBar.ProgressFill = Colors.Blue;
circularProgressBar.TrackFill = Colors.Violet;
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 0 });
circularProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 50 });
this.Content = circularProgressBar;
...

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>


## SfLinearProgressBar

<table> 
<tr>
<th>Xamarin SfProgressBar</th>
<th>.NET MAUI SfProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[SecondaryProgressColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryProgressColor)'| markdownify }}</td>
<td>{{'SecondaryProgressFill'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the secondary progress.</td></tr>
<tr>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_CornerRadius)'| markdownify }}</td>
<td>Divided into {{'TrackCornerRadius'| markdownify }}, {{'ProgressCornerRadius'| markdownify }} and {{'SecondaryProgressCornerRadius'| markdownify }}</td>
<td>Gets or sets a value to determine the corner radius of the track, progress and secondary progress.</td></tr>
</table> 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}
<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

...     
<progressBar:SfLinearProgressBar CornerRadius="5"
                                 SecondaryProgressColor="Yellow"
                                 SecondaryProgress="50"
                                 >

</progressBar:SfLinearProgressBar>

...
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.CornerRadius = 5;
linearProgressBar.SecondaryProgressColor = Color.Yellow;
linearProgressBar.SecondaryProgress = 50;
this.Content = linearProgressBar;

...
{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar">

...
<progressBar:SfLinearProgressBar ProgressCornerRadius="5,5,5,5"
                                 TrackCornerRadius="5,5,5,5"
                                 SecondaryProgressCornerRadius="5,5,5,5"
                                 SecondaryProgressFill="Red"
                                 SecondaryProgress="50"
                                 >
    
</progressBar:SfLinearProgressBar>
...

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.ProgressCornerRadius = new CornerRadius(5, 5, 5, 5);
linearProgressBar.TrackCornerRadius = new CornerRadius(5, 5, 5, 5);
linearProgressBar.SecondaryProgressCornerRadius = new CornerRadius(5, 5, 5, 5);
linearProgressBar.SecondaryProgressFill = Colors.Red;
linearProgressBar.SecondaryProgress = 50;
this.Content = linearProgressBar;
... 

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## SfCircularProgressBar

<table> 
<tr>
<th>Xamarin SfProgressBar</th>
<th>.NET MAUI SfProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[IndicatorInnerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorInnerRadius)'| markdownify }}</td>
<td>{{'ProgressThickness'| markdownify }}</td>
<td>Gets or sets a value that specifies the thickness for the progress. You can specify value either in logical pixel or radius factor using the ThicknessUnit property.</td></tr>
<tr>
<td>{{'[IndicatorOuterRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorOuterRadius)'| markdownify }}</td>
<td>{{'ProgressRadiusFactor'| markdownify }}</td>
<td>Gets or sets a value that specifies the outer radius factor of the progress.</td></tr>
<tr>
<td>{{'[ShowProgressValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_ShowProgressValue)'| markdownify }}</td>
<td>{{'-'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show progress value label or not in SfCircularProgressBar.</td></tr>
<tr>
<td>{{'[TrackInnerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackInnerRadius)'| markdownify }}</td>
<td>{{'TrackThickness'| markdownify }}</td>
<td>Gets or sets a value that specifies the thickness of track in circular progress bar. You can specify value either in logical pixel or radius factor using the ThicknessUnit property.</td></tr>
<tr>
<td>{{'[TrackOuterRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackOuterRadius)'| markdownify }}</td>
<td>{{'TrackRadiusFactor'| markdownify }}</td>
<td>Gets or sets a value that specifies the outer radius factor of the track.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'ProgressCornerStyle'| markdownify }}</td>
<td>Gets or sets the value that specifies the corner style of the progress.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'TrackCornerStyle'| markdownify }}</td>
<td>Gets or sets the value that specifies the corner style of the track.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'ThicknessUnit'| markdownify }}</td>
<td>Gets or sets enum value that indicates to calculate the track and progress thickness either in logical pixel or radius factor.</td></tr>
</table> 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

...     
<progressBar:SfCircularProgressBar IndicatorInnerRadius="0.9"
                                   IndicatorOuterRadius="1"
                                   TrackInnerRadius="0.9"
                                   TrackOuterRadius="1"
                                   Progress="50">

</progressBar:SfCircularProgressBar>

...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.IndicatorInnerRadius = 0.9;
circularProgressBar.IndicatorOuterRadius = 1;
circularProgressBar.TrackInnerRadius = 0.9;
circularProgressBar.TrackOuterRadius = 1;
circularProgressBar.Progress = 50;
this.Content = circularProgressBar;

...

{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar">

...
<progressBar:SfCircularProgressBar ProgressThickness="10"
                                   ProgressRadiusFactor="1"
                                   TrackThickness="10"
                                   TrackRadiusFactor="1"
                                   ProgressCornerStyle="BothCurve"
                                   TrackCornerStyle="BothCurve"
                                   ThicknessUnit="Pixel"
                                   Progress="50">
    
</progressBar:SfCircularProgressBar>
...

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.ProgressThickness = 10;
circularProgressBar.ProgressRadiusFactor = 1;
circularProgressBar.TrackThickness = 10;
circularProgressBar.TrackRadiusFactor = 1;
circularProgressBar.ProgressCornerStyle = CornerStyle.BothCurve;
circularProgressBar.TrackCornerStyle = CornerStyle.BothCurve;
circularProgressBar.ThicknessUnit = SizeUnit.Pixel;
circularProgressBar.Progress = 50;
this.Content = circularProgressBar;
...
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Unsupported features from Xamarin.Forms

* [`ShowProgressValue`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_ShowProgressValue) support has not been provided in the SfCircularProgressBar. Instead, you can achieve it using the `Content` property. Please visit Custom Content page for more details about the `Content` property.

* [`Padding`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_Padding) support has not been provided in the SfLinearProgressBar.
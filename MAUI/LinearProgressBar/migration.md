---
layout: post
title: Migrate from Xamarin to .NET MAUI  Linear ProgressBar | Syncfusion<sup>&reg;</sup>
description: Learn here all about Migrating from Syncfusion<sup>&reg;</sup> Xamarin Linear ProgressBar to Syncfusion .NET MAUI Linear ProgressBar control and more.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---  

# Migrate from Xamarin.Forms to .NET MAUI SfLinearProgressBar

To make the migration from the [Xamarin SfLinearProgressBar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-progressbar) to [.NET MAUI SfLinearProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) easier, most of the APIs from the Xamarin SfLinearProgressBar were kept in the .NET MAUI SfLinearProgressBar. However, to maintain the consistency of API naming in the .NET MAUI SfLinearProgressBar, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the ProgressBar namespace and initialize the SfLinearProgressBar as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfLinearProgressBar</th>
<th>.NET MAUI SfLinearProgressBar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

    ...     
    <progressBar:SfLinearProgressBar />
    ...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

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
    ...

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();

...

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfLinearProgressBar</th>
<th>.NET MAUI SfLinearProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[Progress](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_Progress)'| markdownify }}</td>
<td>{{'[Progress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress)'| markdownify }}</td>
<td>Gets or sets the value that specifies the current value for the progress.</td></tr>
<tr>
<td>{{'[SecondaryProgress](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryProgress)'| markdownify }}</td>
<td>{{'[SecondaryProgress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgress)'| markdownify }}</td>
<td>Gets or sets the secondary progress value for the SfLinearProgressBar.</td></tr>
<tr>
<td>{{'[IsIndeterminate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IsIndeterminate)'| markdownify }}</td>
<td>{{'[IsIndeterminate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the progress bar is in indeterminate state or not.</td></tr>
<tr>
<td>{{'[Minimum](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_Minimum)'| markdownify }}</td>
<td>{{'[Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Minimum)'| markdownify }}</td>
<td>Gets or sets the minimum possible value of the progress bar. The progress bar range starts from this value.</td></tr>
<tr>
<td>{{'[Maximum](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_Maximum)'| markdownify }}</td>
<td>{{'[Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Maximum)'| markdownify }}</td>
<td>Gets or sets the maximum possible value of the progress bar. The progress bar ends at this value.</td></tr>
<tr>
<td>{{'[ProgressColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressColor)'| markdownify }}</td>
<td>{{'[*ProgressFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the progress.</td></tr>
<tr>
<td>{{'[SecondaryProgressColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryProgressColor)'| markdownify }}</td>
<td>{{'[*SecondaryProgressFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressFill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the secondary progress.</td></tr>
<tr>
<td>{{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_TrackColor)'| markdownify }}</td>
<td>{{'[*TrackFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the track.</td></tr>
<tr>
<td>{{'[SegmentCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_SegmentCount)'| markdownify }}</td>
<td>{{'[SegmentCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount)'| markdownify }}</td>
<td>Gets or sets the value that determine the segments count of progress bar.</td></tr>
<tr>
<td>{{'[GapWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_GapWidth)'| markdownify }}</td>
<td>{{'[*SegmentGapWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth)'| markdownify }}</td>
<td>Gets or sets the value that determines the gap between the segments.</td></tr>
<tr>
<td>{{'[RangeColors](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_RangeColors)'| markdownify }}</td>
<td>{{'[*GradientStops](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops)'| markdownify }}</td>
<td>Gets or sets a collection of ProgressGradientStop to fill the gradient brush to the progress.</td></tr>
<tr>
<td>{{'[AnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_AnimationDuration)'| markdownify }}</td>
<td>{{'[AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationDuration)'| markdownify }}</td>
<td>Gets or sets a value that specifies the progress animation duration in milliseconds.</td></tr>
<tr>
<td>{{'[SecondaryAnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryAnimationDuration)'| markdownify }}</td>
<td>{{'[SecondaryAnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryAnimationDuration)'| markdownify }}</td>
<td>Gets or sets a value that specifies the secondary progress animation duration in milliseconds.</td></tr>
<tr>
<td>{{'[IndeterminateAnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateAnimationDuration)'| markdownify }}</td>
<td>{{'[IndeterminateAnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationDuration)'| markdownify }}</td>
<td>Gets or sets a value that specifies the indeterminate animation duration in milliseconds.</td></tr>
<tr>
<td>{{'[EasingEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_EasingEffect)'| markdownify }}</td>
<td>{{'[*AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationEasing)'| markdownify }}</td>
<td>Gets or sets a value that specifies the easing effect for progress animation.</td></tr>
<tr>
<td>{{'[IndeterminateEasingEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateEasingEffect)'| markdownify }}</td>
<td>{{'[*IndeterminateAnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationEasing)'| markdownify }}</td>
<td>Gets or sets a value that specifies the easing effect for indeterminate animation.</td></tr>
<tr>
<td>{{'[IndeterminateIndicatorWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidth)'| markdownify }}</td>
<td>{{'[*IndeterminateIndicatorWidthFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidthFactor)'| markdownify }}</td>
<td>Gets or sets the value that specifies width of the indeterminate indicator.</td></tr>
<tr>
<td>{{'[TrackHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_TrackHeight)'| markdownify }}</td>
<td>Divided into {{'[*TrackHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackHeight)'| markdownify }}, {{'[*ProgressHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressHeight)'| markdownify }} and {{'[*SecondaryProgressHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressHeight)'| markdownify }}</td>
<td>Gets or sets a value to determine the height of track, progress and secondary progress.</td></tr>
<tr>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_CornerRadius)'| markdownify }}</td>
<td>Divided into {{'[*TrackCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackCornerRadius)'| markdownify }}, {{'[*ProgressCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressCornerRadius)'| markdownify }} and {{'[*SecondaryProgressCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressCornerRadius)'| markdownify }}</td>
<td>Gets or sets a value to determine the corner radius of the track, progress, and secondary progress.</td></tr>
<tr>
<td>{{'[ValueChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ValueChanged)'| markdownify }}</td>
<td>{{'[*ProgressChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressChanged)'| markdownify }}</td>
<td>The value change event occurs when the Progress is changed.</td></tr>
<tr>
<td>{{'[ProgressCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressCompleted)'| markdownify }}</td>
<td>{{'[ProgressCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressCompleted)'| markdownify }}</td>
<td>The progress completed event occurs when Progress value attains Maximum value in ProgressBar.</td></tr>

</table> 

N> All the (*) marked APIs are renamed from Xamarin SfLinearProgressBar to maintain the consistency of API naming in the .NET MAUI SfLinearProgressBar.

The following code example explains how to use the properties in the Xamarin linear progress bar and the .NET MAUI linear progress bar.

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
<progressBar:SfLinearProgressBar x:Name="linearProgressBar" 
                                 EasingEffect="CubicOut"
                                 GapWidth="5"
                                 SegmentCount="4"
                                 IndeterminateEasingEffect="BounceIn"
                                 IndeterminateIndicatorWidth="0.7"
                                 ProgressColor="Red"
                                 TrackColor="Violet"
                                 ValueChanged="LinearProgressBar_ValueChanged"
                                 ProgressCompleted="LinearProgressBar_ProgressCompleted"
                                 Progress="100"
                                 IsIndeterminate="False"
                                 Minimum="10"
                                 Maximum="90"
                                 AnimationDuration="1500"
                                 IndeterminateAnimationDuration="2000"
                                 CornerRadius="5"
                                 SecondaryProgressColor="Yellow"
                                 SecondaryProgress="50"
                                 TrackHeight="10"
                                 SecondaryAnimationDuration="2000">
    <progressBar:SfLinearProgressBar.RangeColors>
        <progressBar:RangeColorCollection>
            <progressBar:RangeColor IsGradient="True" Color="#00bdaf" Start="0" End="25"/>
            <progressBar:RangeColor IsGradient="True" Color="#2f7ecc" Start="25" End="50"/>
        </progressBar:RangeColorCollection>
    </progressBar:SfLinearProgressBar.RangeColors>
</progressBar:SfLinearProgressBar>
    ...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

 private void LinearProgressBar_ValueChanged(object sender, ProgressValueEventArgs e)
 {
     var value = e.Progress;
 }

 private void LinearProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
 {
     var value = e.Progress;
 }

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
 
 <progressBar:SfLinearProgressBar x:Name="linearProgressBar" 
                                  AnimationEasing="{x:Static Easing.CubicOut}"
                                  SegmentGapWidth="5"
                                  SegmentCount="4"
                                  IndeterminateAnimationEasing="{x:Static Easing.BounceIn}"
                                  IndeterminateIndicatorWidthFactor="0.7"
                                  ProgressFill="Red"
                                  TrackFill="Violet"
                                  ProgressChanged="LinearProgressBar_ProgressChanged"
                                  ProgressCompleted="LinearProgressBar_ProgressCompleted"
                                  Progress="100"
                                  IsIndeterminate="False"
                                  Minimum="10"
                                  Maximum="90"
                                  AnimationDuration="1500"
                                  IndeterminateAnimationDuration="2000"
                                  ProgressCornerRadius="5"
                                  TrackCornerRadius="5"
                                  SecondaryProgressCornerRadius="5"
                                  SecondaryProgressFill="Yellow"
                                  SecondaryProgress="50"
                                  TrackHeight="10"
                                  ProgressHeight="10"
                                  SecondaryProgressHeight="10"
                                  SecondaryAnimationDuration="2000">
    <progressBar:SfLinearProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="50"/>
    </progressBar:SfLinearProgressBar.GradientStops>

</progressBar:SfLinearProgressBar>

...

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

private void LinearProgressBar_ProgressChanged(object sender, ProgressValueEventArgs e)
{
    var value = e.Progress;
}

private void LinearProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
{
    var value = e.Progress;
}

...

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Unsupported features from Xamarin.Forms

* In Xamarin, the [`Padding`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_Padding) is used to adjust the padding of the progress and secondary progress at all the four (left, top, right, and bottom) sides. But in .NET MAUI, it can be achieved with the [`ProgressPadding`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressPadding), [`ProgressHeight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressHeight), and [`SecondaryProgressHeight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html?tabs=tabid-1#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressHeight) properties. Please refer to these [`thickness`](https://help.syncfusion.com/maui/linearprogressbar/appearance#thickness) and [`padding`](https://help.syncfusion.com/maui/linearprogressbar/appearance#padding) documentation for details.

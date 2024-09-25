---
layout: post
title: Migrate from Xamarin to .NET MAUI  Circular ProgressBar | Syncfusion
description: Learn here all about Migrating from Syncfusion Xamarin Circular ProgressBar to Syncfusion .NET MAUI Circular ProgressBar control and more.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---  

# Migrate from Xamarin.Forms to .NET MAUI SfCircularProgressBar

To make the migration from the [Xamarin SfCircularProgressBar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-progressbar) to [.NET MAUI SfCircularProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) easier, most of the APIs from the Xamarin SfCircularProgressBar were kept in the .NET MAUI SfCircularProgressBar. However, to maintain the consistency of API naming in the .NET MAUI SfCircularProgressBar, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the ProgressBar namespace and initialize the SfCircularProgressBar as shown in the following code sample.

<table>
<tr>
<th>Xamarin ProgressBar</th>
<th>.NET MAUI ProgressBar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

    ...     
    <progressBar:SfCircularProgressBar />
    ...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

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

    <progressBar:SfCircularProgressBar />
    ...

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();

...

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfCircularProgressBar</th>
<th>.NET MAUI SfCircularProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[Progress](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_Progress)'| markdownify }}</td>
<td>{{'[Progress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress)'| markdownify }}</td>
<td>Gets or sets the value that specifies the current value for the progress.</td></tr>
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
<td>{{'[StartAngle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_StartAngle)'| markdownify }}</td>
<td>{{'[StartAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_StartAngle)'| markdownify }}</td>
<td>Gets or sets a value that specifies the StartAngle of the progress bar.</td></tr>
<tr>
<td>{{'[EndAngle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_EndAngle)'| markdownify }}</td>
<td>{{'[EndAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_EndAngle)'| markdownify }}</td>
<td>Gets or sets a value that specifies the EndAngle of the progress bar.</td></tr>
<tr>
<td>{{'[Content](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_Content)'| markdownify }}</td>
<td>{{'[Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_Content)'| markdownify }}</td>
<td>Gets or sets a any view to display in the center of circular progress bar.</td></tr>
<tr>
<td>{{'[ProgressColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressColor)'| markdownify }}</td>
<td>{{'[*ProgressFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the progress.</td></tr>
<tr>
<td>{{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_TrackColor)'| markdownify }}</td>
<td>{{'[*TrackFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill)'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the track.</td></tr>
<tr>
<td>{{'[RangeColors](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_RangeColors)'| markdownify }}</td>
<td>{{'[*GradientStops](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops)'| markdownify }}</td>
<td>Gets or sets a collection of ProgressGradientStop to fill the gradient brush to the progress.</td></tr>
<tr>
<td>{{'[SegmentCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_SegmentCount)'| markdownify }}</td>
<td>{{'[SegmentCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount)'| markdownify }}</td>
<td>Gets or sets the value that determine the segments count of progress bar.</td></tr>
<tr>
<td>{{'[GapWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_GapWidth)'| markdownify }}</td>
<td>{{'[*SegmentGapWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth)'| markdownify }}</td>
<td>Gets or sets the value that determines the gap between the segments.</td></tr>
<tr>
<td>{{'[AnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_AnimationDuration)'| markdownify }}</td>
<td>{{'[AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationDuration)'| markdownify }}</td>
<td>Gets or sets a value that specifies the progress animation duration in milliseconds.</td></tr>
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
<td>{{'[IndicatorInnerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorInnerRadius)'| markdownify }}</td>
<td>{{'[*ProgressThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressThickness)'| markdownify }}</td>
<td>Gets or sets a value that specifies the thickness of the progress. You can specify the value either in logical pixel or radius factor using the ThicknessUnit property.</td></tr>
<tr>
<td>{{'[IndicatorOuterRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorOuterRadius)'| markdownify }}</td>
<td>{{'[*ProgressRadiusFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressRadiusFactor)'| markdownify }}</td>
<td>Gets or sets a value that specifies the outer radius factor of the progress.</td></tr>
<tr>
<td>{{'[TrackInnerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackInnerRadius)'| markdownify }}</td>
<td>{{'[*TrackThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackThickness)'| markdownify }}</td>
<td>Gets or sets a value that specifies the thickness of the track in the circular progress bar. You can specify value either in logical pixel or radius factor using the ThicknessUnit property.</td></tr>
<tr>
<td>{{'[TrackOuterRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackOuterRadius)'| markdownify }}</td>
<td>{{'[*TrackRadiusFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackRadiusFactor)'| markdownify }}</td>
<td>Gets or sets a value that specifies the outer radius factor of the track.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'[ThicknessUnit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ThicknessUnit)'| markdownify }}</td>
<td>Gets or sets the enum value that indicates to calculate the track and progress thickness either in logical pixel or radius factor.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'[ProgressCornerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressCornerStyle)'| markdownify }}</td>
<td>Gets or sets the value that specifies the corner style of the progress.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'[TrackCornerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackCornerStyle)'| markdownify }}</td>
<td>Gets or sets the value that specifies the corner style of the track.</td></tr>
<tr>
<td>{{'[ShowProgressValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_ShowProgressValue)'| markdownify }}</td>
<td>{{'-'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show the progress value label or not in SfCircularProgressBar.</td></tr>
<tr>
<td>{{'[ValueChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ValueChanged)'| markdownify }}</td>
<td>{{'[*ProgressChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressChanged)'| markdownify }}</td>
<td>The value change event occurs when the Progress is changed.</td></tr>
<tr>
<td>{{'[ProgressCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressCompleted)'| markdownify }}</td>
<td>{{'[ProgressCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressCompleted)'| markdownify }}</td>
<td>The progress completed event occurs when Progress value attains Maximum value in ProgressBar.</td></tr>
</table> 

N> All the (*) marked APIs are renamed from Xamarin SfCircularProgressBar to maintain the consistency of API naming in the .NET MAUI SfCircularProgressBar.

The following code example explains how to use the properties in the Xamarin circular progress bar and the .NET MAUI circular progress bar.

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
<progressBar:SfCircularProgressBar x:Name="circularProgressBar"
                                   EasingEffect="CubicOut"
                                   GapWidth="5"
                                   SegmentCount="4"
                                   IndeterminateEasingEffect="BounceIn"
                                   IndeterminateIndicatorWidth="0.7"
                                   ProgressColor="Red"
                                   TrackColor="Violet"
                                   Progress="100"
                                   IsIndeterminate="False"
                                   Minimum="10"
                                   Maximum="90"
                                   AnimationDuration="1500"
                                   IndeterminateAnimationDuration="2000"
                                   IndicatorInnerRadius="0.9"
                                   IndicatorOuterRadius="1"
                                   TrackInnerRadius="0.9"
                                   TrackOuterRadius="1"
                                   StartAngle="180"
                                   EndAngle="360"
                                   ShowProgressValue="False"
                                   ValueChanged="SfCircularProgressBar_ValueChanged"
                                   ProgressCompleted="SfCircularProgressBar_ProgressCompleted">
    <progressBar:SfCircularProgressBar.RangeColors>
        <progressBar:RangeColorCollection>
            <progressBar:RangeColor IsGradient="True" Color="#00bdaf" Start="0" End="25"/>
            <progressBar:RangeColor IsGradient="True" Color="#2f7ecc" Start="25" End="50"/>
        </progressBar:RangeColorCollection>
    </progressBar:SfCircularProgressBar.RangeColors>
    <progressBar:SfCircularProgressBar.Content>
        <Label x:Name="Label" Text="{Binding Source={x:Reference CircularProgressBar},Path=Progress,Mode=TwoWay}"/>
    </progressBar:SfCircularProgressBar.Content>
</progressBar:SfCircularProgressBar>
    ...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...
private void SfCircularProgressBar_ValueChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.Label.TextColor = Color.Red;
    }
    else
    {
        this.Label.TextColor = Color.Blue;
    }
}

private void SfCircularProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
{
    this.Label.TextColor = Color.Green;
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
<progressBar:SfCircularProgressBar x:Name="circularProgressBar"
                                   AnimationEasing="{x:Static Easing.CubicOut}"
                                   SegmentGapWidth="5"
                                   SegmentCount="4"
                                   IndeterminateAnimationEasing="{x:Static Easing.BounceIn}"
                                   IndeterminateIndicatorWidthFactor="0.7"
                                   ProgressFill="Red"
                                   TrackFill="Violet"
                                   ProgressChanged="CircularProgressBar_ProgressChanged"
                                   ProgressCompleted="CircularProgressBar_ProgressCompleted"
                                   Progress="100"
                                   IsIndeterminate="False"
                                   Minimum="10"
                                   Maximum="90"
                                   AnimationDuration="1500"
                                   IndeterminateAnimationDuration="2000"
                                   ProgressThickness="10"
                                   ProgressRadiusFactor="1"
                                   TrackThickness="10"
                                   TrackRadiusFactor="1"
                                   ProgressCornerStyle="BothCurve"
                                   TrackCornerStyle="BothCurve"
                                   ThicknessUnit="Pixel"
                                   StartAngle="180"
                                   EndAngle="360">
    <progressBar:SfCircularProgressBar.GradientStops>
        <progressBar:ProgressGradientStop Color="#00bdaf" Value="0"/>
        <progressBar:ProgressGradientStop Color="#2f7ecc" Value="50"/>
    </progressBar:SfCircularProgressBar.GradientStops>

    <progressBar:SfCircularProgressBar.Content>
        <Label x:Name="Label" Text="{Binding Source={x:Reference CircularProgressBar},Path=Progress,Mode=TwoWay}"/>
    </progressBar:SfCircularProgressBar.Content>
</progressBar:SfCircularProgressBar>
...

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

private void CircularProgressBar_ProgressChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.Label.TextColor = Colors.Red;
    }
    else if (e.Progress >= 50)
    {
        this.Label.TextColor = Colors.Blue;
    }
}

private void CircularProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
{
    this.Label.TextColor = Colors.Green;
}

...

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Unsupported features from Xamarin.Forms

* [`ShowProgressValue`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_ShowProgressValue) support has not been provided in the SfCircularProgressBar. Instead, you can achieve it using the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_Content) property. Please visit the Custom Content page for more details about the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_Content) property.

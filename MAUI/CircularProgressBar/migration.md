---
layout: post
title: Migrate from Xamarin to .NET MAUI  ProgressBar | Syncfusion
description: Learn here all about Migrating from Syncfusion Xamarin ProgressBar to Syncfusion .NET MAUI ProgressBar control and more.
platform: MAUI
control: ProgressBar
documentation: ug
---  

# Migrate from Xamarin.Forms SfCircularProgressBar to .NET MAUI SfCircularProgressBar

To make the migration from the [Xamarin SfCircularProgressBar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-progressbar) to `.NET MAUI SfCircularProgressBar` easier, most of the APIs from the Xamarin ProgressBar were kept in the .NET MAUI ProgressBar. However, to maintain the consistency of API naming in the .NET MAUI ProgressBar, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the ProgressBar namespace and initialize the ProgressBar as shown in the following code sample.

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

## Common Properties

<table> 
<tr>
<th>Xamarin ProgressBar</th>
<th>.NET MAUI ProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[Progress](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_Progress)'| markdownify }}</td>
<td>{{'Progress'| markdownify }}</td>
<td>Gets or sets the value that specifies the current value for the progress.</td></tr>
<tr>
<td>{{'[IsIndeterminate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IsIndeterminate)'| markdownify }}</td>
<td>{{'IsIndeterminate'| markdownify }}</td>
<td>Gets or sets a value indicating whether the progress bar is in indeterminate state or not.</td></tr>
<tr>
<td>{{'[Minimum](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_Minimum)'| markdownify }}</td>
<td>{{'Minimum'| markdownify }}</td>
<td>Gets or sets the minimum possible value of the progress bar. The progress bar range starts from this value.</td></tr>
<tr>
<td>{{'[Maximum](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_Maximum)'| markdownify }}</td>
<td>{{'Maximum'| markdownify }}</td>
<td>Gets or sets the maximum possible value of the progress bar. The progress bar ends at this value.</td></tr>
<tr>
<td>{{'[ProgressColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressColor)'| markdownify }}</td>
<td>{{'ProgressFill'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the progress.</td></tr>
<tr>
<td>{{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_TrackColor)'| markdownify }}</td>
<td>{{'TrackFill'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the track.</td></tr>
<tr>
<td>{{'[SegmentCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_SegmentCount)'| markdownify }}</td>
<td>{{'SegmentCount'| markdownify }}</td>
<td>Gets or sets the value that determine the segments count of progress bar.</td></tr>
<tr>
<td>{{'[GapWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_GapWidth)'| markdownify }}</td>
<td>{{'SegmentGapWidth'| markdownify }}</td>
<td>Gets or sets the value that determines the gap between the segments.</td></tr>
<tr>
<td>{{'[RangeColors](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_RangeColors)'| markdownify }}</td>
<td>{{'GradientStops'| markdownify }}</td>
<td>Gets or sets a collection of ProgressGradientStop to fill the gradient brush to the progress.</td></tr>
<tr>
<td>{{'[AnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_AnimationDuration)'| markdownify }}</td>
<td>{{'AnimationDuration'| markdownify }}</td>
<td>Gets or sets a value that specifies the progress animation duration in milliseconds.</td></tr>
<tr>
<td>{{'[IndeterminateAnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateAnimationDuration)'| markdownify }}</td>
<td>{{'IndeterminateAnimationDuration'| markdownify }}</td>
<td>Gets or sets a value that specifies the indeterminate animation duration in milliseconds.</td></tr>
<tr>
<td>{{'[EasingEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_EasingEffect)'| markdownify }}</td>
<td>{{'AnimationEasing'| markdownify }}</td>
<td>Gets or sets a value that specifies the easing effect for progress animation.</td></tr>
<tr>
<td>{{'[IndeterminateEasingEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateEasingEffect)'| markdownify }}</td>
<td>{{'IndeterminateAnimationEasing'| markdownify }}</td>
<td>Gets or sets a value that specifies the easing effect for indeterminate animation.</td></tr>
<tr>
<td>{{'[IndeterminateIndicatorWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidth)'| markdownify }}</td>
<td>{{'IndeterminateIndicatorWidthFactor'| markdownify }}</td>
<td>Gets or sets the value that specifies width of the indeterminate indicator.</td></tr>
</table> 

The following code example explains how to use the common properties in the Xamarin progress bar and the .NET MAUI progress bar.

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
<progressBar:SfCircularProgressBar EasingEffect="CubicOut"
                                   GapWidth="5"
                                   SegmentCount="4"
                                   IndeterminateEasingEffect="BounceIn"
                                   IndeterminateIndicatorWidth="0.7"
                                   ProgressColor="Red"
                                   TrackColor="Violet"
                                   Progress="75"
                                   IsIndeterminate="False"
                                   Minimum="10"
                                   Maximum="90"
                                   AnimationDuration="1500"
                                   IndeterminateAnimationDuration="2000">
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

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.Progress = 75;
circularProgressBar.EasingEffect = EasingEffects.CubicOut;
circularProgressBar.GapWidth = 5;
circularProgressBar.SegmentCount = 4;
circularProgressBar.IndeterminateEasingEffect = IndeterminateEasingEffects.BounceIn;
circularProgressBar.IndeterminateIndicatorWidth = 0.7;
circularProgressBar.ProgressColor = Color.Red;
circularProgressBar.TrackColor = Color.Violet;
circularProgressBar.IsIndeterminate = false;
circularProgressBar.Minimum = 10;
circularProgressBar.Maximum = 90;
circularProgressBar.AnimationDuration = 1500;
circularProgressBar.IndeterminateAnimationDuration = 2000;
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
<progressBar:SfCircularProgressBar AnimationEasing="{x:Static Easing.CubicOut}"
                                   SegmentGapWidth="5"
                                   SegmentCount="4"
                                   IndeterminateAnimationEasing="{x:Static Easing.BounceIn}"
                                   IndeterminateIndicatorWidthFactor="0.7"
                                   ProgressFill="Red"
                                   TrackFill="Violet"
                                   Progress="75"
                                   IsIndeterminate="False"
                                   Minimum="10"
                                   Maximum="90"
                                   AnimationDuration="1500"
                                   IndeterminateAnimationDuration="2000">
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

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
circularProgressBar.AnimationEasing = Easing.CubicOut;
circularProgressBar.Progress = 75;
circularProgressBar.Minimum = 10;
circularProgressBar.Maximum = 90;
circularProgressBar.SegmentGapWidth = 5;
circularProgressBar.SegmentCount = 4;
circularProgressBar.IndeterminateAnimationEasing = Easing.BounceIn;
circularProgressBar.IndeterminateIndicatorWidthFactor = 0.7;
circularProgressBar.AnimationDuration = 1500;
circularProgressBar.IndeterminateAnimationDuration = 2000;
circularProgressBar.IsIndeterminate = false;
circularProgressBar.ProgressFill = Colors.Red;
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

## SfCircularProgressBar

<table> 
<tr>
<th>Xamarin ProgressBar</th>
<th>.NET MAUI ProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[StartAngle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_StartAngle)'| markdownify }}</td>
<td>{{'StartAngle'| markdownify }}</td>
<td>Gets or sets a value that specifies the StartAngle of the progress bar.</td></tr>
<tr>
<td>{{'[EndAngle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_EndAngle)'| markdownify }}</td>
<td>{{'EndAngle'| markdownify }}</td>
<td>Gets or sets a value that specifies the EndAngle of the progress bar.</td></tr>
<tr>
<td>{{'[Content](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_Content)'| markdownify }}</td>
<td>{{'Content'| markdownify }}</td>
<td>Gets or sets a any view to display in the center of circular progress bar.</td></tr>
<tr>
<td>{{'[IndicatorInnerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorInnerRadius)'| markdownify }}</td>
<td>{{'ProgressThickness'| markdownify }}</td>
<td>Gets or sets a value that specifies the thickness of the progress. You can specify the value either in logical pixel or radius factor using the ThicknessUnit property.</td></tr>
<tr>
<td>{{'[IndicatorOuterRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_IndicatorOuterRadius)'| markdownify }}</td>
<td>{{'ProgressRadiusFactor'| markdownify }}</td>
<td>Gets or sets a value that specifies the outer radius factor of the progress.</td></tr>
<tr>
<td>{{'[TrackInnerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackInnerRadius)'| markdownify }}</td>
<td>{{'TrackThickness'| markdownify }}</td>
<td>Gets or sets a value that specifies the thickness of the track in the circular progress bar. You can specify value either in logical pixel or radius factor using the ThicknessUnit property.</td></tr>
<tr>
<td>{{'[TrackOuterRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_TrackOuterRadius)'| markdownify }}</td>
<td>{{'TrackRadiusFactor'| markdownify }}</td>
<td>Gets or sets a value that specifies the outer radius factor of the track.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'ThicknessUnit'| markdownify }}</td>
<td>Gets or sets the enum value that indicates to calculate the track and progress thickness either in logical pixel or radius factor.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'ProgressCornerStyle'| markdownify }}</td>
<td>Gets or sets the value that specifies the corner style of the progress.</td></tr>
<tr>
<td>{{'-'| markdownify }}</td>
<td>{{'TrackCornerStyle'| markdownify }}</td>
<td>Gets or sets the value that specifies the corner style of the track.</td></tr>
<tr>
<td>{{'[ShowProgressValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_ShowProgressValue)'| markdownify }}</td>
<td>{{'-'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show the progress value label or not in SfCircularProgressBar.</td></tr>

</table> 

The following code example explains how to initialize the Xamarin SfCircularProgressBar and the .NET MAUI SfCircularProgressBar along with its properties.

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
                                   IndicatorInnerRadius="0.9"
                                   IndicatorOuterRadius="1"
                                   TrackInnerRadius="0.9"
                                   TrackOuterRadius="1"
                                   Progress="50"
                                   StartAngle="180"
                                   EndAngle="360"
                                   ShowProgressValue="False"
                                   >
<progressBar:SfCircularProgressBar.Content>
    <Label Text="{Binding Source={x:Reference circularProgressBar},Path=Progress,Mode=TwoWay}"/>
</progressBar:SfCircularProgressBar.Content>

</progressBar:SfCircularProgressBar>

...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
Label label = new Label();
circularProgressBar.IndicatorInnerRadius = 0.9;
circularProgressBar.IndicatorOuterRadius = 1;
circularProgressBar.TrackInnerRadius = 0.9;
circularProgressBar.TrackOuterRadius = 1;
circularProgressBar.Progress = 50;
circularProgressBar.StartAngle = 180;
circularProgressBar.EndAngle = 360;
circularProgressBar.ShowProgressValue = false;
label.SetBinding(Label.TextProperty, new Binding("Progress", source: circularProgressBar));
circularProgressBar.Content = label;
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

<progressBar:SfCircularProgressBar x:Name="circularProgressBar"
                                   ProgressThickness="10"
                                   ProgressRadiusFactor="1"
                                   TrackThickness="10"
                                   TrackRadiusFactor="1"
                                   ProgressCornerStyle="BothCurve"
                                   TrackCornerStyle="BothCurve"
                                   ThicknessUnit="Pixel"
                                   Progress="50"
                                   StartAngle="180"
                                   EndAngle="360">
    <progressBar:SfCircularProgressBar.Content>
        <Label Text="{Binding Source={x:Reference circularProgressBar},Path=Progress,Mode=TwoWay}"/>
    </progressBar:SfCircularProgressBar.Content>
    
</progressBar:SfCircularProgressBar>

...

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar();
Label label = new Label();
circularProgressBar.ProgressThickness = 10;
circularProgressBar.ProgressRadiusFactor = 1;
circularProgressBar.TrackThickness = 10;
circularProgressBar.TrackRadiusFactor = 1;
circularProgressBar.ProgressCornerStyle = CornerStyle.BothCurve;
circularProgressBar.TrackCornerStyle = CornerStyle.BothCurve;
circularProgressBar.ThicknessUnit = SizeUnit.Pixel;
circularProgressBar.Progress = 50;
circularProgressBar.StartAngle = 180;
circularProgressBar.EndAngle = 360;
label.SetBinding(Label.TextProperty, new Binding("Progress", source: circularProgressBar));
circularProgressBar.Content = label;
this.Content = circularProgressBar;

...
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Events

<table> 
<tr>
<th>Xamarin ProgressBar</th>
<th>.NET MAUI ProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[ValueChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ValueChanged)'| markdownify }}</td>
<td>{{'ProgressChanged'| markdownify }}</td>
<td>The value change event occurs when the Progress is changed.</td></tr>
<tr>
<td>{{'[ProgressCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.ProgressBarBase.html#Syncfusion_XForms_ProgressBar_ProgressBarBase_ProgressCompleted)'| markdownify }}</td>
<td>{{'ProgressCompleted'| markdownify }}</td>
<td>The progress completed event occurs when Progress value attains Maximum value in ProgressBar.</td></tr>
</table> 

The following code example explains how to utilize the Xamarin progress bar and the .NET MAUI progress bar progress changed and progress completed event.

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

<!--Snippet for the value changed event-->

<progressBar:SfLinearProgressBar x:Name="LinearProgressBar" 
                                 ValueChanged="LinearProgressBar_ValueChanged" 
                                 Progress="100" />

<!--Snippet for the progress completed event-->

<progressBar:SfCircularProgressBar Minimum="100" 
                                   Maximum="500" 
                                   ProgressCompleted="SfCircularProgressBar_ProgressCompleted" 
                                   Progress="500">
    <progressBar:SfCircularProgressBar.Content>
        <Grid WidthRequest="150">
            <Label x:Name="Label" 
               Text="Start" 
               FontSize="15"
               HorizontalTextAlignment="Center" 
               VerticalTextAlignment="Center" />
        </Grid>
</progressBar:SfCircularProgressBar.Content>


...
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;

...

private void LinearProgressBar_ValueChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.LinearProgressBar.ProgressColor = Color.Red;
    }
    else if (e.Progress >= 50)
    {
        this.LinearProgressBar.ProgressColor = Color.Green;
    }
}

private void SfCircularProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
{
    this.Label.Text = "Completed";
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

<!--Snippet for the progress changed event-->

<progressBar:SfLinearProgressBar x:Name="LinearProgressBar" 
                                 ProgressChanged="LinearProgressBar_ProgressChanged" 
                                 Progress="100" />

<!--Snippet for the progress completed event-->

<progressBar:SfCircularProgressBar Minimum="100" 
                                   Maximum="500" 
                                   ProgressCompleted="CircularProgressBar_ProgressCompleted" 
                                   Progress="500">
    <progressBar:SfCircularProgressBar.Content>
        <Grid WidthRequest="150">
            <Label x:Name="Label" 
                   Text="Start" 
                   FontSize="15"
                   HorizontalTextAlignment="Center" 
                   VerticalTextAlignment="Center" />
        </Grid>
    </progressBar:SfCircularProgressBar.Content>
</progressBar:SfCircularProgressBar>

...

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

private void LinearProgressBar_ProgressChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.LinearProgressBar.ProgressFill = Colors.Red;
    }
    else if (e.Progress >= 50)
    {
        this.LinearProgressBar.ProgressFill = Colors.Green;
    }
}

private void CircularProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
{
    this.Label.Text = "Completed";
}
...
{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Unsupported features from Xamarin.Forms

* [`ShowProgressValue`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfCircularProgressBar.html#Syncfusion_XForms_ProgressBar_SfCircularProgressBar_ShowProgressValue) support has not been provided in the SfCircularProgressBar. Instead, you can achieve it using the `Content` property. Please visit the Custom Content page for more details about the `Content` property.

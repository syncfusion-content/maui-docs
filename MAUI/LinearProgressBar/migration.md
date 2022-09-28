---
layout: post
title: Migrate from Xamarin to .NET MAUI  ProgressBar | Syncfusion
description: Learn here all about Migrating from Syncfusion Xamarin ProgressBar to Syncfusion .NET MAUI ProgressBar control and more.
platform: MAUI
control: ProgressBar
documentation: ug
---  

# Migrate from Xamarin.Forms SfLinearProgressBar to .NET MAUI SfLinearProgressBar

To make the migration from the [Xamarin SfLinearProgressBar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-progressbar) to `.NET MAUI SfLinearProgressBar` easier, most of the APIs from the Xamarin ProgressBar were kept in the .NET MAUI ProgressBar. However, to maintain the consistency of API naming in the .NET MAUI ProgressBar, some of the APIs have been renamed. Please find the difference in the following topics.

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
    <progressBar:SfLinearProgressBar />
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
<progressBar:SfLinearProgressBar EasingEffect="CubicOut"
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

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.Progress = 75;
linearProgressBar.EasingEffect = EasingEffects.CubicOut;
linearProgressBar.GapWidth = 5;
linearProgressBar.SegmentCount = 4;
linearProgressBar.IndeterminateEasingEffect = IndeterminateEasingEffects.BounceIn;
linearProgressBar.IndeterminateIndicatorWidth = 0.7;
linearProgressBar.ProgressColor = Color.Red;
linearProgressBar.TrackColor = Color.Violet;
linearProgressBar.IsIndeterminate = false;
linearProgressBar.Minimum = 10;
linearProgressBar.Maximum = 90;
linearProgressBar.AnimationDuration = 1500;
linearProgressBar.IndeterminateAnimationDuration = 2000;
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
 <progressBar:SfLinearProgressBar AnimationEasing="{x:Static Easing.CubicOut}"
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
//Snippet for the linear progress bar

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar();
linearProgressBar.AnimationEasing = Easing.CubicOut;
linearProgressBar.Progress = 75;
linearProgressBar.Minimum = 10;
linearProgressBar.Maximum = 90;
linearProgressBar.SegmentGapWidth = 5;
linearProgressBar.SegmentCount = 4;
linearProgressBar.IndeterminateAnimationEasing = Easing.BounceIn;
linearProgressBar.IndeterminateIndicatorWidthFactor = 0.7;
linearProgressBar.AnimationDuration = 1500;
linearProgressBar.IndeterminateAnimationDuration = 2000;
linearProgressBar.IsIndeterminate = false;
linearProgressBar.ProgressFill = Colors.Red;
linearProgressBar.TrackFill = Colors.Violet;
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("00bdaf"), Value = 0 });
linearProgressBar.GradientStops.Add(new ProgressGradientStop { Color = Color.FromArgb("2f7ecc"), Value = 50 });
this.Content = linearProgressBar;

...

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>


## SfLinearProgressBar

<table> 
<tr>
<th>Xamarin ProgressBar</th>
<th>.NET MAUI ProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[SecondaryProgress](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryProgress)'| markdownify }}</td>
<td>{{'SecondaryProgress'| markdownify }}</td>
<td>Gets or sets the secondary progress value for the SfLinearProgressBar.</td></tr>
<tr>
<td>{{'[SecondaryProgressColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryProgressColor)'| markdownify }}</td>
<td>{{'SecondaryProgressFill'| markdownify }}</td>
<td>Gets or sets the brush that paints the interior area of the secondary progress.</td></tr>
<tr>
<td>{{'[TrackHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_TrackHeight)'| markdownify }}</td>
<td>Divided into {{'TrackHeight'| markdownify }}, {{'ProgressHeight'| markdownify }} and {{'SecondaryProgressHeight'| markdownify }}</td>
<td>Gets or sets a value to determine the height of track, progress and secondary progress.</td></tr>
<tr>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_CornerRadius)'| markdownify }}</td>
<td>Divided into {{'TrackCornerRadius'| markdownify }}, {{'ProgressCornerRadius'| markdownify }} and {{'SecondaryProgressCornerRadius'| markdownify }}</td>
<td>Gets or sets a value to determine the corner radius of the track, progress, and secondary progress.</td></tr>
<tr>
<td>{{'[SecondaryAnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_SecondaryAnimationDuration)'| markdownify }}</td>
<td>{{'SecondaryAnimationDuration'| markdownify }}</td>
<td>Gets or sets a value that specifies the secondary progress animation duration in milliseconds.</td></tr>

</table> 

The following code example explains how to initialize the Xamarin SfLinearProgressBar and the .NET MAUI SfLinearProgressBar along with its properties.

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
                                 TrackHeight="10"
                                 SecondaryAnimationDuration="2000"
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
linearProgressBar.TrackHeight = 10;
linearProgressBar.SecondaryAnimationDuration = 2000;
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
                                 SecondaryProgressFill="Yellow"
                                 SecondaryProgress="50"
                                 TrackHeight="10"
                                 ProgressHeight="10"
                                 SecondaryProgressHeight="10"
                                 SecondaryAnimationDuration="2000"
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
linearProgressBar.SecondaryProgressFill = Colors.Yellow;
linearProgressBar.SecondaryProgress = 50;
linearProgressBar.TrackHeight = 10;
linearProgressBar.ProgressHeight = 10;
linearProgressBar.SecondaryProgressHeight = 10;
linearProgressBar.SecondaryAnimationDuration = 2000;
this.Content = linearProgressBar;

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

* [`Padding`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfLinearProgressBar.html#Syncfusion_XForms_ProgressBar_SfLinearProgressBar_Padding) support has not been provided in the SfLinearProgressBar.
---
layout: post
title: Migrate from Syncfusion Xamarin Step ProgressBar to .NET MAUI Step ProgressBar
description: Learn here all about Migrating from Syncfusion Xamarin step progressbar to Syncfusion .NET MAUI SfStepProgressBar control.
platform: maui
control: SfStepProgressBar
documentation: ug
---  

# Migrate from Xamarin.Forms SfStepProgressBar to MAUI SfStepProgressBar

To make the migration from the [Xamarin SfStepProgressBar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-stepprogressbar) to [.NET MAUI SfStepProgressBar]() easier, most of the APIs from the Xamarin SfStepProgressBar were kept in the.NET MAUI SfStepProgressBar. However, to maintain the consistency of API naming in the .NET MAUI SfStepProgressBar, some of the APIs have been renamed. Find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th></tr>
<tr>
<td>Syncfusion.XForms.ProgressBar</td>
<td>Syncfusion.Maui.ProgressBar</td></tr>
</table>

## Initialize control

To initialize the control, import the step progressbar namespace and initialize `SfStepProgressBar` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

    <progressBar:SfStepProgressBar />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;
...

SfStepProgressBar sfStepProgressBar = new SfStepProgressBar ();
this.Content = sfStepProgressBar ;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar">

    <progressBar:SfStepProgressBar />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
this.Content = stepProgressBar ;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th>
<th>Description</th></tr>
<tr>
<td>{{'[SfStepProgressBar]()'| markdownify }}</td>
<td>{{'[SfStepProgressBar]()'| markdownify }}</td>
<td>Represents a class which holds the step progressbar common properties in SfStepProgressBar.</td>
</tr> 
<tr>
<td>{{'[StepView ]()' | markdownify }}</td>
<td>{{'[StepProgressBarItem]()' | markdownify }}</td>
<td>Represents a class which is used to customize the step progress bar item.</td>
</tr> 
<tr>
<td>{{'[IStepStyle]()' | markdownify }}</td>
<td>{{'[StepSettings]()' | markdownify }}</td>
<td>Represents a class which is used to customize the style of the step view.</td>
</tr>
<tr>
<td>{{'[StepTappedEventArgs ]()' | markdownify }}</td>
<td>{{'[StepTappedEventArgs]()' | markdownify }}</td>
<td>Represents a class which is used to hold the step tapped event arguments.</td>
</tr> 
<tr>
<td>{{'[StatusChangedEventArgs ]()' | markdownify }}</td>
<td>{{'[StepStatusChangedEventArgs]()' | markdownify }}</td>
<td>Represents a class which is used to hold the status changed event arguments.</td>
</tr>
</table>

## Properties 

### SfStepProgressBar

The following code example, explains how to initialize the properties of the `Xamarin SfStepProgressBar` and `.NET MAUI SfStepProgressBar` class.

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:progressBar="clr-namespace:Syncfusion.XForms.ProgressBar;assembly=Syncfusion.SfProgressBar.XForms">

    <progressBar:SfStepProgressBar />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.ProgressBar;
...

SfStepProgressBar sfStepProgressBar = new SfStepProgressBar ();
this.Content = sfStepProgressBar ;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar">

    <progressBar:SfStepProgressBar />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ProgressBar;
...

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
this.Content = stepProgressBar ;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[CompletedStepStyle]()'| markdownify }}</td>
<td>{{'[CompletedStepSettings]()'| markdownify }}</td>
<td>Gets or sets the completed step settings for the step progressbar.</td>
</tr>
<tr>
<td>{{'[InProgressStepStyle]()'| markdownify }}</td>
<td>{{'[InProgressStepSettings]()'| markdownify }}</td>
<td>Gets or sets the in progress step settings for the step progressbar.</td>
</tr>
<tr>
<td>{{'[NotStartedStepStyle]()'| markdownify }}</td>
<td>{{'[NotStartedStepSettings]()'| markdownify }}</td>
<td>Gets or sets the not started step settings for the step progressbar.</td>
</tr>
<tr>
<td>{{'[Orientation]()'| markdownify }}</td>
<td>{{'[Orientation]()'| markdownify }}</td>
<td>Gets or sets the orientation.</td>
</tr>
<tr>
<td>{{'[ProgressAnimationDuration]()'| markdownify }}</td>
<td>{{'[ProgressAnimationDuration]()'| markdownify }}</td>
<td>Gets or sets the progress animation duration.</td>
</tr>
<tr>
<td>{{'[TitleAlignment]()'| markdownify }}</td>
<td>{{'[LabelPosition]()'| markdownify }}</td>
<td> Gets or sets the label position for the step progress bar.</td>
</tr>
<tr>
<td>{{'[TitleSpace]()'| markdownify }}</td>
<td>{{'[LabelSpacing]()'| markdownify }}</td>
<td>Gets or sets the label spacing.</td>
</tr>
<tr>
<td>{{'[LayoutOption]()'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[MarkerSize]()'| markdownify }}</td>
<td>{{'[StepSize]()'| markdownify }}</td>
<td>Gets or sets the size of the step.</td>
</tr>
<tr>
<td>{{'[MarkerStrokeWidth]()'| markdownify }}</td>
<td>{{'[StepStrokeWidth]()'| markdownify }}</td>
<td>Gets or sets the stroke width of the step.</td>
</tr>
</table>

### StepSettings

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[FontAttributes]()'| markdownify }}</td>
<td>{{'[[FontAttributes]()(From [TextStyle]() property of [StepSettings]() class)]()'| markdownify }}</td>
<td>Gets or sets the font attributes of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[FontColor]()'| markdownify }}</td>
<td>{{'[[TextColor]()(From [TextStyle]() property of [StepSettings]() class)]()'| markdownify }}</td>
<td>Gets or sets the text color of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[FontFamily]()'| markdownify }}</td>
<td>{{'[[FontFamily]()(From [TextStyle]() property of [StepSettings]() class)]()'| markdownify }}</td>
<td>Gets or sets the font family of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[FontSize]()'| markdownify }}</td>
<td>{{'[[FontSize]()(From [TextStyle]() property of [StepSettings]() class)]()'| markdownify }}</td>
<td>Gets or sets the font size of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[GapWidth]()'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[MarkerContentFillColor]()'| markdownify }}</td>
<td>{{'[ContentFillColor]()'| markdownify }}</td>
<td>Gets or sets the content fill color of the step.</td>
</tr>
<tr>
<td>{{'[MarkerContentSize]()'| markdownify }}</td>
<td>{{'[[StepContentSize]()(From [SfStepProgressBar]() class)]()'| markdownify }}</td>
<td>Gets or sets the content size of the step.</td>
</tr>
<tr>
<td>{{'[MarkerContentType]()'| markdownify }}</td>
<td>{{'[ContentType]()'| markdownify }}</td>
<td>Gets or sets the content type of the step.</td>
</tr>
<tr>
<td>{{'[MarkerFillColor]()'| markdownify }}</td>
<td>{{'[Background]()'| markdownify }}</td>
<td>Gets or sets the background color of the step.</td>
</tr>
<tr>
<td>{{'[MarkerShapeType]()'| markdownify }}</td>
<td>{{'[ShapeType]()'| markdownify }}</td>
<td>Gets or sets the shape type of the step.</td>
</tr>
<tr>
<td>{{'[MarkerStrokeColor]()'| markdownify }}</td>
<td>{{'[Stroke]()'| markdownify }}</td>
<td>Gets or sets the stroke color of the step.</td>
</tr>
<tr>
<td>{{'[ProgressLineColor]()'| markdownify }}</td>
<td>{{'[ProgressColor]()'| markdownify }}</td>
<td>Gets or sets the track color of the progress line.</td>
</tr>
<tr>
<td>{{'[TrackColor]()'| markdownify }}</td>
<td>{{'[ProgressBarBackground]()'| markdownify }}</td>
<td>Gets or sets the progress background color of the progress line.</td>
</tr>
</table>

### StepProgressBarItem

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[ImageSource]()'| markdownify }}</td>
<td>{{'[ImageSource]()'| markdownify }}</td>
<td>Gets or sets the image source of the step.</td>
</tr>
<tr>
<td>{{'[PrimaryText]()'| markdownify }}</td>
<td>{{'[PrimaryText]()'| markdownify }}</td>
<td>Gets or sets the primary text of the step.</td>
</tr>
<tr>
<td>{{'[SecondaryText]()'| markdownify }}</td>
<td>{{'[SecondaryText]()'| markdownify }}</td>
<td>Gets or sets the secondary text of the step.</td>
</tr>
<tr>
<td>{{'[PrimaryFormattedText]()'| markdownify }}</td>
<td>{{'[PrimaryFormattedText]()'| markdownify }}</td>
<td>Gets or sets the primary formatted text of the step.</td>
</tr>
<tr>
<td>{{'[SecondaryFormattedText]()'| markdownify }}</td>
<td>{{'[SecondaryFormattedText]()'| markdownify }}</td>
<td>Gets or sets the secondary formatted text of the step.</td>
</tr>
<tr>
<td>{{'[ProgressValue]()'| markdownify }}</td>
<td>{{'[ActiveStepProgressValue]()'| markdownify }}</td>
<td>Gets or sets the progress value of the step.</td>
</tr>
<tr>
<td>{{'[Status]()'| markdownify }}</td>
<td>Nil</td>
<td>By using '[ActiveStepIndex]()' and '[ActiveStepProgressValue]()' property, we can acheive the desired step status.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[StepTitleAlignment]()'| markdownify }}</td>
<td>{{'[LabelPosition]()'| markdownify }}</td>
<td>Defines the label text alignment for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepContentType ]()'| markdownify }}</td>
<td>{{'[StepContentType ]()'| markdownify }}</td>
<td>Defines the step content type for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepOrientation ]()'| markdownify }}</td>
<td>{{'[StepProgressBarOrientation ]()'| markdownify }}</td>
<td>Defines the step progressbar layout orientation for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepShapeType ]()'| markdownify }}</td>
<td>{{'[StepShapeType ]()'| markdownify }}</td>
<td>Defines the step shape type for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepStatus ]()'| markdownify }}</td>
<td>{{'[StepStatus]()'| markdownify }}</td>
<td>Defines the step status for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepLayoutOptions ]()'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[StepTapped]()'| markdownify }}</td>
<td>{{'[StepTapped]()'| markdownify }}</td>
<td>Occurs whenever the progressbar step is tapped.</td>
</tr>
<tr>
<td>{{'[StatusChanged]()'| markdownify }}</td>
<td>{{'[StepStatusChanged]()'| markdownify }}</td>
<td>Occurs whenever the step status is changed.</td>
</tr>
</table>

## Upcoming Features

* Mapping support
* RTL support
* Template support
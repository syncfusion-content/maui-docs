---
layout: post
title: Migrate from Xamarin to .NET MAUI StepProgressBar | Syncfusion
description: Learn here all about Migrating from Syncfusion Xamarin step progressbar to Syncfusion .NET MAUI SfStepProgressBar control.
platform: maui
control: SfStepProgressBar
documentation: ug
---  

# Migrate from Xamarin.Forms SfStepProgressBar to MAUI SfStepProgressBar

To make the migration from the [Xamarin SfStepProgressBar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-stepprogressbar) to [.NET MAUI SfStepProgressBar](https://www.syncfusion.com/maui-controls/maui-stepprogressbar) easier, most of the APIs from the `Xamarin SfStepProgressBar` were kept in the `.NET MAUI SfStepProgressBar`. However, to maintain the consistency of API naming in the `.NET MAUI SfStepProgressBar`, some of the APIs have been renamed. Find the difference in the following topics.

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
<td>{{'[SfStepProgressBar](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html)'| markdownify }}</td>
<td>{{'[SfStepProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html)'| markdownify }}</td>
<td>Represents a class which holds the step progressbar common properties in SfStepProgressBar.</td>
</tr> 
<tr>
<td>{{'[StepView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html)' | markdownify }}</td>
<td>{{'[StepProgressBarItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html)' | markdownify }}</td>
<td>Represents a class which is used to customize the step progress bar item.</td>
</tr> 
<tr>
<td>{{'[IStepStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html)' | markdownify }}</td>
<td>{{'[StepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html)' | markdownify }}</td>
<td>Represents a class which is used to customize the style of the step view.</td>
</tr>
<tr>
<td>{{'[StepTappedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepTappedEventArgs.html)' | markdownify }}</td>
<td>{{'[StepTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTappedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the step tapped event arguments.</td>
</tr> 
<tr>
<td>{{'[StatusChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StatusChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[StepStatusChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepStatusChangedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the status changed event arguments.</td>
</tr>
</table>

## Properties 

### SfStepProgressBar

The following code example, explains how to initialize the properties of the `Xamarin SfStepProgressBar` and `.NET MAUI SfStepProgressBar` class.

<table>
<tr>
<th>Xamarin SfStepProgressBar</th>
<th>.NET MAUI SfStepProgressBar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[CompletedStepStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_CompletedStepStyle)'| markdownify }}</td>
<td>{{'[CompletedStepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_CompletedStepSettings)'| markdownify }}</td>
<td>Gets or sets the completed step settings for the step progressbar.</td>
</tr>
<tr>
<td>{{'[InProgressStepStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_InProgressStepStyle)'| markdownify }}</td>
<td>{{'[InProgressStepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_InProgressStepSettings)'| markdownify }}</td>
<td>Gets or sets the in progress step settings for the step progressbar.</td>
</tr>
<tr>
<td>{{'[NotStartedStepStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_NotStartedStepStyle)'| markdownify }}</td>
<td>{{'[NotStartedStepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_NotStartedStepSettings)'| markdownify }}</td>
<td>Gets or sets the not started step settings for the step progressbar.</td>
</tr>
<tr>
<td>{{'[Orientation](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_Orientation)'| markdownify }}</td>
<td>{{'[Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_Orientation)'| markdownify }}</td>
<td>Gets or sets the orientation.</td>
</tr>
<tr>
<td>{{'[ProgressAnimationDuration](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_ProgressAnimationDuration)'| markdownify }}</td>
<td>{{'[ProgressAnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ProgressAnimationDuration)'| markdownify }}</td>
<td>Gets or sets the progress animation duration.</td>
</tr>
<tr>
<td>{{'[TitleAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_TitleAlignment)'| markdownify }}</td>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_LabelPosition)'| markdownify }}</td>
<td> Gets or sets the label position for the step progress bar.</td>
</tr>
<tr>
<td>{{'[TitleSpace](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_TitleSpace)'| markdownify }}</td>
<td>{{'[LabelSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_LabelSpacing)'| markdownify }}</td>
<td>Gets or sets the label spacing.</td>
</tr>
<tr>
<td>{{'[LayoutOption](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_LayoutOption)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[MarkerSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerSize)'| markdownify }}</td>
<td>{{'[StepSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepSize)'| markdownify }}</td>
<td>Gets or sets the size of the step.</td>
</tr>
<tr>
<td>{{'[MarkerStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerStrokeWidth)'| markdownify }}</td>
<td>{{'[StepStrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepStrokeWidth)'| markdownify }}</td>
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
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTextStyle.html#Syncfusion_Maui_ProgressBar_StepTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_TextStyle) property of [StepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html) class)'| markdownify }}</td>
<td>Gets or sets the font attributes of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[FontColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_FontColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTextStyle.html#Syncfusion_Maui_ProgressBar_StepTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_TextStyle) property of [StepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html) class)'| markdownify }}</td>
<td>Gets or sets the text color of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTextStyle.html#Syncfusion_Maui_ProgressBar_StepTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_TextStyle) property of [StepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html) class)'| markdownify }}</td>
<td>Gets or sets the font family of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTextStyle.html#Syncfusion_Maui_ProgressBar_StepTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_TextStyle) property of [StepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html) class)'| markdownify }}</td>
<td>Gets or sets the font size of the text style which is used to customize the primary and secondary text.</td>
</tr>
<tr>
<td>{{'[GapWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_GapWidth)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[MarkerContentFillColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerContentFillColor)'| markdownify }}</td>
<td>{{'[ContentFillColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ContentFillColor)'| markdownify }}</td>
<td>Gets or sets the content fill color of the step.</td>
</tr>
<tr>
<td>{{'[MarkerContentSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerContentSize)'| markdownify }}</td>
<td>{{'[StepContentSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepContentSize)(From [SfStepProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html) class)'| markdownify }}</td>
<td>Gets or sets the content size of the step.</td>
</tr>
<tr>
<td>{{'[MarkerContentType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerContentType)'| markdownify }}</td>
<td>{{'[ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ContentType)'| markdownify }}</td>
<td>Gets or sets the content type of the step.</td>
</tr>
<tr>
<td>{{'[MarkerFillColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerFillColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_Background)'| markdownify }}</td>
<td>Gets or sets the background color of the step.</td>
</tr>
<tr>
<td>{{'[MarkerShapeType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerShapeType)'| markdownify }}</td>
<td>{{'[ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ShapeType)'| markdownify }}</td>
<td>Gets or sets the shape type of the step.</td>
</tr>
<tr>
<td>{{'[MarkerStrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_MarkerStrokeColor)'| markdownify }}</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_Stroke)'| markdownify }}</td>
<td>Gets or sets the stroke color of the step.</td>
</tr>
<tr>
<td>{{'[ProgressLineColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_ProgressLineColor)'| markdownify }}</td>
<td>{{'[ProgressColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ProgressColor)'| markdownify }}</td>
<td>Gets or sets the track color of the progress line.</td>
</tr>
<tr>
<td>{{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.IStepStyle.html#Syncfusion_XForms_ProgressBar_IStepStyle_TrackColor)'| markdownify }}</td>
<td>{{'[ProgressBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ProgressBarBackground)'| markdownify }}</td>
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
<td>{{'[ImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html#Syncfusion_XForms_ProgressBar_StepView_ImageSource)'| markdownify }}</td>
<td>{{'[ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_ImageSource)'| markdownify }}</td>
<td>Gets or sets the image source of the step.</td>
</tr>
<tr>
<td>{{'[PrimaryText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html#Syncfusion_XForms_ProgressBar_StepView_PrimaryText)'| markdownify }}</td>
<td>{{'[PrimaryText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_PrimaryText)'| markdownify }}</td>
<td>Gets or sets the primary text of the step.</td>
</tr>
<tr>
<td>{{'[SecondaryText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html#Syncfusion_XForms_ProgressBar_StepView_SecondaryText)'| markdownify }}</td>
<td>{{'[SecondaryText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_SecondaryText)'| markdownify }}</td>
<td>Gets or sets the secondary text of the step.</td>
</tr>
<tr>
<td>{{'[PrimaryFormattedText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html#Syncfusion_XForms_ProgressBar_StepView_PrimaryFormattedText)'| markdownify }}</td>
<td>{{'[PrimaryFormattedText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_PrimaryFormattedText)'| markdownify }}</td>
<td>Gets or sets the primary formatted text of the step.</td>
</tr>
<tr>
<td>{{'[SecondaryFormattedText](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html#Syncfusion_XForms_ProgressBar_StepView_SecondaryFormattedText)'| markdownify }}</td>
<td>{{'[SecondaryFormattedText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_SecondaryFormattedText)'| markdownify }}</td>
<td>Gets or sets the secondary formatted text of the step.</td>
</tr>
<tr>
<td>{{'[ProgressValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html#Syncfusion_XForms_ProgressBar_StepView_ProgressValue)'| markdownify }}</td>
<td>{{'[ActiveStepProgressValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ActiveStepProgressValue)'| markdownify }}</td>
<td>Gets or sets the progress value of the step.</td>
</tr>
<tr>
<td>{{'[Status](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepView.html#Syncfusion_XForms_ProgressBar_StepView_Status)'| markdownify }}</td>
<td>Nil</td>
<td>By using ActiveStepIndex and ActiveStepProgressValue property, we can acheive the desired step status.</td>
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
<td>{{'[StepTitleAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepTitleAlignment.html)'| markdownify }}</td>
<td>{{'[LabelPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.LabelPosition.html)'| markdownify }}</td>
<td>Defines the label text alignment for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepContentType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepContentType.html)'| markdownify }}</td>
<td>{{'[StepContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepContentType.html)'| markdownify }}</td>
<td>Defines the step content type for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepOrientation](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepOrientation.html)'| markdownify }}</td>
<td>{{'[StepProgressBarOrientation ](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarOrientation.html)'| markdownify }}</td>
<td>Defines the step progressbar layout orientation for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepShapeType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepShapeType.html)'| markdownify }}</td>
<td>{{'[StepShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepShapeType.html)'| markdownify }}</td>
<td>Defines the step shape type for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepStatus](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepStatus.html)'| markdownify }}</td>
<td>{{'[StepStatus](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepStatus.html)'| markdownify }}</td>
<td>Defines the step status for the SfStepProgressBar.</td>
</tr>
<tr>
<td>{{'[StepLayoutOptions](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.StepLayoutOptions.html)'| markdownify }}</td>
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
<td>{{'[StepTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_StepTapped)'| markdownify }}</td>
<td>{{'[StepTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepTapped)'| markdownify }}</td>
<td>Occurs whenever the progressbar step is tapped.</td>
</tr>
<tr>
<td>{{'[StatusChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.ProgressBar.SfStepProgressBar.html#Syncfusion_XForms_ProgressBar_SfStepProgressBar_StatusChanged)'| markdownify }}</td>
<td>{{'[StepStatusChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepStatusChanged)'| markdownify }}</td>
<td>Occurs whenever the step status is changed.</td>
</tr>
</table>

## Upcoming Features

* Mapping support
* RTL support
* Template support

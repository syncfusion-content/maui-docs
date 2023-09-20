---
layout: post
title: Migrate from Xamarin to .NET MAUI Segmented Control (SfSegmentedControl) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms Segmented control to .NET MAUI Segmented control.
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Migrate from Xamarin.Forms Segmented Control to .NET MAUI Segmented Control (SfSegmentedControl)

To make the migration from the [Xamarin SfSegmented Control](https://www.syncfusion.com/xamarin-ui-controls/xamarin-segmented-control) to the [.NET MAUI SfSegmented Control](https://www.syncfusion.com/maui-controls/maui-segmented-control) easier, most of the APIs from the `Xamarin SfSegmented Control` were kept in the `.NET MAUI SfSegmented Control`. However, to maintain the consistency of API naming in the `.NET MAUI SfSegmented Control`, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th></tr>
<tr>
<td>Syncfusion.Xamarin.Buttons</td>
<td>Syncfusion.Maui.Buttons</td></tr>
</table>

## Initialize Control

To initialize the control, import the segmented control namespace and initialize the [SfSegmentedControl](https://www.syncfusion.com/maui-controls/maui-segmented-control) as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th></tr>
<tr>
<td>

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms">
     <buttons:SfSegmentedControl x:Name="segmentedControl"/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.XForms.Buttons;
...

SfSegmentedControl segmentedControl = new SfSegmentedControl();
this.Content = segmentedControl;

{% endhighlight %}
{% endtabs %}

</td>
<td>

{% tabs %}
{% highlight XAML %}

<ContentPage 
...
xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl"/>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Buttons;
…

SfSegmentedControl segmentedControl = new SfSegmentedControl();
this.Content = segmentedControl;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[SfSegmentedControl](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html)'| markdownify }}</td>
<td>{{'[SfSegmentedControl](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html)'| markdownify}}</td>
<td>The SegmentedControl allows users explore and switch among different views. It provides a simple way to choose from a linear set of two or more segments, each of which functions as a mutually exclusive button.</td>
</tr>

<tr>
<td>{{'[SfSegmentItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html)'| markdownify }}</td>
<td>{{'[SfSegmentItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html)'| markdownify}}</td>
<td>Represents a single element in SfSegmentedControl control. It contains the properties to configure title and content region.</td>
</tr>

<tr>
<td>{{'[SelectionIndicatorSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SelectionIndicatorSettings.html)'| markdownify }}</td>
<td>{{'[SelectionIndicatorSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionIndicatorSettings.html)'| markdownify}}</td>
<td>Provides a set of properties to customize the selection indicator in the SfSegmentedControl control.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[SegmentTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTextStyle.html)'| markdownify}}</td>
<td>Gets or sets properties which allows to customize the segment item text style of the SfSegmentedControl.</td>
</tr>

</table> 


## Properties

### SfSegmentedControl

<table> 
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th></tr>

{% tabs %}
{% highlight XAML %}
<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    SelectedIndex="1"
                                    VisibleSegmentsCount="4"
                                    ItemsSource="{Binding SegmentItems}">
    </buttons:SfSegmentedControl>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

ViewModel viewModel = new ViewModel();
SfSegmentedControl segmentedControl = new SfSegmentedControl();
segmentedControl.SelectedIndex = 1;
segmentedControl.VisibleSegmentsCount = 4;
segmentedControl.ItemsSource = viewModel.SegmentItems;
this.Content = segmentedControl;

{% endhighlight %}

{% highlight c# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week"},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

<tr>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_ItemsSource)'| markdownify }}</td>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_ItemsSource)'| markdownify}}</td>
<td>Gets or sets a collection used to generate the SfSegmentItem in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[SelectedIndex](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_SelectedIndex)'| markdownify }}</td>
<td>{{'[SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SelectedIndex)'| markdownify}}</td>
<td>Gets or sets the index of the currently selected item in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[SegmentHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_SegmentHeight)'| markdownify }}</td>
<td>{{'[SegmentHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SegmentHeight)'| markdownify}}</td>
<td>Gets or sets the height of the segments in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[SegmentWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_SegmentWidth)'| markdownify }}</td>
<td>{{'[SegmentWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SegmentWidth)'| markdownify}}</td>
<td>Gets or sets the width of the segments in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[VisibleSegmentsCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_VisibleSegmentsCount)'| markdownify }}</td>
<td>{{'[VisibleSegmentsCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_VisibleSegmentsCount)'| markdownify}}</td>
<td>Gets or sets the number of visible segments to be displayed in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[SelectionIndicatorSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_SelectionIndicatorSettings)'| markdownify }}</td>
<td>{{'[SelectionIndicatorSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SelectionIndicatorSettings)'| markdownify}}</td>
<td>Gets or sets the settings for the segment selection indicator, which is used to highlight the selected item in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[DisabledTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_DisabledTextColor)'| markdownify }}</td>
<td>{{'[DisabledSegmentTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_DisabledSegmentTextColor)'| markdownify}}</td>
<td>Gets or sets the text color of the disabled segment items in the SfSegmentedControl.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[DisabledSegmentBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_DisabledSegmentBackground)'| markdownify}}</td>
<td>Gets or sets the background brush of the disabled segment items in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[FontColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_FontColor)'| markdownify }}</td>
<td>{{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_TextStyle)'| markdownify}}</td>
<td>Gets or sets the style of segment item text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>

<tr>
<td>{{'[SegmentBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_SegmentBackgroundColor)'| markdownify }}</td>
<td>{{'[SegmentBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SegmentBackground)'| markdownify}}</td>
<td>Gets or sets the background brush for the segments in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_BorderColor)'| markdownify }}</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_Stroke)'| markdownify}}</td>
<td>Gets or sets the stroke brush for the segments in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[BorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_BorderThickness)'| markdownify }}</td>
<td>{{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_StrokeThickness)'| markdownify}}</td>
<td>Gets or sets the thickness of the segment stroke in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_CornerRadius)'| markdownify }}</td>
<td>{{'[CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_CornerRadius)'| markdownify}}</td>
<td>Gets or sets the corner radius for the border of the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[SegmentCornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_SegmentCornerRadius)'| markdownify }}</td>
<td>{{'[SegmentCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SegmentCornerRadius)'| markdownify}}</td>
<td>Gets or sets the segment corner radius for the segment items of the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[AutoScrollSelectedItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_AutoScrollSelectedItem)'| markdownify }}</td>
<td>{{'[AutoScrollToSelectedSegment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_AutoScrollToSelectedSegment)'| markdownify}}</td>
<td>Gets or sets a value indicating whether to enable auto-scrolling when the selected index is changed in the SfSegmentedControl.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[SegmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SegmentTemplate)'| markdownify}}</td>
<td>Gets or sets the data template to use for customizing the appearance of individual segments in the SfSegmentedControl.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ShowSeparator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_ShowSeparator)'| markdownify}}</td>
<td>Gets or sets a value indicating whether to show separators between segments in the SfSegmentedControl.</td>
</tr>
</table>

#### SfSegmentItem

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_BackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_Background)'| markdownify}}</td>
<td>Gets or sets the background color of the segment item.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_Width)'| markdownify}}</td>
<td>Gets or sets the width of the segment item.</td>
</tr>

<tr>
<td>{{'[IconFont](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_IconFont)'| markdownify }}</td>
<td>{{'[ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_ImageSource)'| markdownify}}</td>
<td>Gets or sets the image displayed in the segment item.</td>
</tr>

<tr>
<td>{{'[SelectionTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_SelectionTextColor)'| markdownify }}</td>
<td>{{'[SelectedSegmentTextColorhttps://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_SelectedSegmentTextColor]()'| markdownify}}</td>
<td>Gets or sets the text color of the segment item when it is selected.</td>
</tr>

<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_SelectionBackgroundColor)'| markdownify }}</td>
<td>{{'[SelectedSegmentBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_SelectedSegmentBackground)'| markdownify}}</td>
<td>Gets or sets the background color of the segment item when it is selected.</td>
</tr>

<tr>
<td>{{'[FontColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_FontColor)'| markdownify }}</td>
<td>{{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_TextStyle)'| markdownify}}</td>
<td>Gets or sets the text style of the segment item.</td>
</tr>

<tr>
<td>{{'[FontIconFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_FontIconFontSize)'| markdownify }}</td>
<td>{{'[ImageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_ImageSize)'| markdownify}}</td>
<td>Gets or sets the image size of the segment item.</td>
</tr>

<tr>
<td>{{'[IsEnabled](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_IsEnabled)'| markdownify }}</td>
<td>{{'[IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_IsEnabled)'| markdownify}}</td>
<td>Gets or sets a value indicating whether the segment item is enabled.</td>
</tr>

<tr>
<td>{{'[Text](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentItem.html#Syncfusion_XForms_Buttons_SfSegmentItem_Text)'| markdownify }}</td>
<td>{{'[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html#Syncfusion_Maui_Buttons_SfSegmentItem_Text)'| markdownify}}</td>
<td>Gets or sets the text of the segment item.</td>
</tr>

</table>

### SelectionIndicatorSettings

{% tabs %}
{% highlight XAML %}
<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                ItemsSource="{Binding SegmentItems}">
        <buttons:SfSegmentedControl.SelectionIndicatorSettings>
            <buttons:SelectionIndicatorSettings SelectionIndicatorPlacement="Border" 
                                                        Background="#6200EE"/>
        </buttons:SfSegmentedControl.SelectionIndicatorSettings>
    </buttons:SfSegmentedControl>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

ViewModel viewModel = new ViewModel();
SfSegmentedControl segmentedControl = new SfSegmentedControl();
segmentedControl.ItemsSource = viewModel.SegmentItems;
segmentedControl.SelectionIndicatorSettings = new SelectionIndicatorSettings() 
{
    SelectionIndicatorPlacement = SelectionIndicatorPlacement.Border,
    Background = Colors.Transparent,
};
this.Content = segmentedControl;

{% endhighlight %}

{% highlight c# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week"},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th></tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SelectionIndicatorSettings.html#Syncfusion_XForms_Buttons_SelectionIndicatorSettings_Color)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionIndicatorSettings.html#Syncfusion_Maui_Buttons_SelectionIndicatorSettings_Background)'| markdownify}}</td>
<td>Gets or sets the background brush for the selection indicator in the SfSegmentedControl.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionIndicatorSettings.html#Syncfusion_Maui_Buttons_SelectionIndicatorSettings_TextColor)'| markdownify}}</td>
<td>Gets or sets the text color for the selection indicator in the SfSegmentedControl.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionIndicatorSettings.html#Syncfusion_Maui_Buttons_SelectionIndicatorSettings_Stroke)'| markdownify}}</td>
<td>Gets or sets the stroke color for the selection indicator in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[Position](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SelectionIndicatorSettings.html#Syncfusion_XForms_Buttons_SelectionIndicatorSettings_Position)'| markdownify }}</td>
<td>{{'[SelectionIndicatorPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionIndicatorSettings.html#Syncfusion_Maui_Buttons_SelectionIndicatorSettings_SelectionIndicatorPlacement)'| markdownify}}</td>
<td>Gets or sets the selection mode for the selection indicator in the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[BorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_BorderThickness)'| markdownify }}</td>
<td>{{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionIndicatorSettings.html#Syncfusion_Maui_Buttons_SelectionIndicatorSettings_StrokeThickness)'| markdownify}}</td>
<td>Gets or sets the stroke thickness for the selection indicator in the SfSegmentedControl.</td>
</tr>

</table>

### SegmentTextStyle
The `FontColor`, `FontSize`, `FontFamily`, and `FontAttributes` properties of the [SfSegmentedControl](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html) is grouped to [SegmentTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTextStyle.html).

{% tabs %}
{% highlight XAML %}
<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                ItemsSource="{Binding SegmentItems}">
    <buttons:SfSegmentedControl.TextStyle>
        <buttons:SegmentTextStyle FontSize="14" FontFamily="Roboto" />
    </buttons:SfSegmentedControl.TextStyle>
    </buttons:SfSegmentedControl>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

ViewModel viewModel = new ViewModel();
SfSegmentedControl segmentedControl = new SfSegmentedControl();
segmentedControl.ItemsSource = viewModel.SegmentItems;
segmentedControl.TextStyle = new SegmentTextStyle()
{
    FontSize = 14,
    FontFamily = "Roboto",
};
this.Content = segmentedControl;

{% endhighlight %}

{% highlight c# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week"},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[FontColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_FontColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTextStyle.html#Syncfusion_Maui_Buttons_SegmentTextStyle_TextColor)'| markdownify}}</td>
<td>Gets or sets the text color for the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTextStyle.html#Syncfusion_Maui_Buttons_SegmentTextStyle_FontSize)'| markdownify}}</td>
<td>Gets or sets the double value that represents the font size of the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTextStyle.html#Syncfusion_Maui_Buttons_SegmentTextStyle_FontFamily)'| markdownify}}</td>
<td>Gets or sets the string, that represents font family of the SfSegmentedControl.</td>
</tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SegmentTextStyle.html#Syncfusion_Maui_Buttons_SegmentTextStyle_FontAttributes)'| markdownify}}</td>
<td>Gets or sets the FontAttributes of the SfSegmentedControl.</td>
</tr>

</table>

## Enum

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[SelectionIndicatorPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SelectionIndicatorPosition.html)'| markdownify }}</td>
<td>{{'[SelectionIndicatorPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SelectionIndicatorPlacement.html)'| markdownify}}</td>
<td>Describes the possible values for the position of the selection strip in SfSegmentedControl View.</td>
</tr>

</table>

## Event

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_SelectionChanged)'| markdownify }}</td>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SelectionChanged)'| markdownify}}</td>
<td>Occurs when the selection within the segment item is changed.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfSegmented control</th>
<th>.NET MAUI SfSegmented control</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[ScrollTo](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfSegmentedControl.html#Syncfusion_XForms_Buttons_SfSegmentedControl_ScrollTo_System_Int32_Syncfusion_XForms_Buttons_ScrollToPosition_)'| markdownify }}</td>
<td>{{'[ScrollTo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_ScrollTo_System_Int32_)'| markdownify}}</td>
<td>Method to scroll the scroll viewer to the specified index.
</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[SetSegmentEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_SetSegmentEnabled_System_Int32_System_Boolean_)'| markdownify}}</td>
<td>Sets the enabled state of a specific segment at the specified index.</td>
</tr>
</table>

## Upcoming features

* Multi selection for segment items.
* Theme support.
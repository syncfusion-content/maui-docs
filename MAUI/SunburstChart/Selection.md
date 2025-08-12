---
layout: post
title: Selection in .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains how to enable and customize selection in the Syncfusion<sup>®</sup> .NET MAUI Sunburst Chart control.
platform: maui
control: SfSunburstChart
documentation: ug
---
# Selection in .NET MAUI Sunburst Chart 

The sunburst chart provides support to select or highlight the segments.

## Type

The SelectionType property allows you to select a segment based on the following categories:
* Child: Highlights the selected segment along with its children in all levels.
* Group: Highlights the entire group of the selected segment in a hierarchy.
* Parent: Highlights the parent of the selected segment in the hierarchy.
* Single: Highlights the selected segment alone.

The following code shows the `Child` selection type.

{% tabs %}

{% highlight xaml %}

<chart:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.SelectionSettings>
        <chart:SunburstSelectionSettings Type="Child"/>
    </chart:SfSunburstChart.SelectionSettings>
</chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburstChart = new SfSunburstChart();
. . .
SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings
{
    Type = SunburstSelectionType.Child
};
sunburstChart.SelectionSettings = selectionSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Child selection in MAUI Sunburst Chart.]()

The following code shows the `Group` selection type.

{% tabs %}

{% highlight xaml %}

<chart:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.SelectionSettings>
        <chart:SunburstSelectionSettings Type="Group"/>
    </chart:SfSunburstChart.SelectionSettings>
</chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburstChart = new SfSunburstChart();
. . .
SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings
{
    Type = SunburstSelectionType.Group
};
sunburstChart.SelectionSettings = selectionSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Group selection in MAUI Sunburst Chart.]()

The following code shows the `Parent` selection type.

{% tabs %}

{% highlight xaml %}

<chart:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.SelectionSettings>
        <chart:SunburstSelectionSettings Type="Parent"/>
    </chart:SfSunburstChart.SelectionSettings>
</chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburstChart = new SfSunburstChart();
. . .
SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings
{
    Type = SunburstSelectionType.Parent
};
sunburstChart.SelectionSettings = selectionSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![Parent selection in MAUI Sunburst Chart.]()

## DisplayMode

The `DisplayMode` property provides the following selection options to highlight the segments:

* By Brush
* By opacity
* By stroke

# Brush 

This mode highlights the selected segment using the brush specified in the `Fill` property.

{% tabs %}

{% highlight xaml %}

<chart:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.SelectionSettings>
        <chart:SunburstSelectionSettings Fill="Pink" DisplayMode="HighlightByBrush" Type="Child"/>
    </chart:SfSunburstChart.SelectionSettings>
</chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburstChart = new SfSunburstChart();
. . .
SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings
{
    Fill = Colors.Pink,
    DisplayMode = SunburstSelectionDisplayMode.HighlightByBrush,
    Type = SunburstSelectionType.Child,
};
sunburstChart.SelectionSettings = selectionSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![ DisplayMode HighlightByBrush.]()

# Opacity

This mode highlights the selected segment with the opacity specified in the `Opacity` property.

{% tabs %}

{% highlight xaml %}

<chart:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.SelectionSettings>
        <chart:SunburstSelectionSettings Opacity="0.6" DisplayMode="HighlightByOpacity" Type="Child"/>
    </chart:SfSunburstChart.SelectionSettings>
</chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburstChart = new SfSunburstChart();
. . .
SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings
{
    Opacity = 0.6,
    DisplayMode = SunburstSelectionDisplayMode.HighlightByOpacity,
    Type = SunburstSelectionType.Child,
};
sunburstChart.SelectionSettings = selectionSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![DisplayMode HighlightByOpacity.]()

# Stoke 

This mode highlights the selected segment by applying stroke to it. The color and thickness of the stroke can be customized using the `Stroke` and `StrokeWidth` properties.

{% tabs %}

{% highlight xaml %}

<chart:SfSunburstChart>
    . . .
    <chart:SfSunburstChart.SelectionSettings>
        <chart:SunburstSelectionSettings Stroke="Black" StrokeWidth="3" DisplayMode="HighlightByStroke" Type="Child"/>
    </chart:SfSunburstChart.SelectionSettings>
</chart:SfSunburstChart>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart sunburstChart = new SfSunburstChart();
. . .
SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings
{
    Stroke = Colors.Black,
    StrokeWidth = 3,
    DisplayMode = SunburstSelectionDisplayMode.HighlightByStroke,
    Type = SunburstSelectionType.Child,
};
sunburstChart.SelectionSettings = selectionSettings;
this.Content = sunburst;

{% endhighlight %}

{% endtabs %}

![DisplayMode HighlightByStroke.]()

## Events 

# SelectionChanging

The `SelectionChanging` occurs when a segment in the Sunburst chart is being selected.
This is a cancelable event. The following properties are contained in the event arguments:

* `NewSegment`: Gets the new segment that was selected. 
* `OldSegment`: Gets the old segment that was selected or deselected.
* `Cancel` - Gets or sets the value whether to continue selection or not.


# Selection Changed

The `SelectionChanged` event occurs when a segment in the Sunburst chart is selected or deselected. The following properties are contained in the event arguments:

* `IsSelected`: Indicates whether a segment is selected.
* `NewSegment`: Gets the new segment that was selected. 
* `OldSegment`: Gets the old segment that was selected or deselected.
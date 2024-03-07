---
layout: post
title: Applying themes for Syncfusion controls
description: This section explains about theming in Syncfusion controls and how to override the key values for further customization
platform: maui
control: General
documentation: ug
---

# Applying Themes in Maui Controls

Syncfusion themes allow you apply colors across all the Syncfusion controls with a uniform approach and provide consistent look and feel to your applications. This section covers the following topics: 

* Applying light and dark themes
* Overriding the default theme
* Creating your own theme

## Applying light and dark themes

By default, Syncfusion provides support for light and dark themes. As names suggest, these themes will have colors with light and dark color contrasts, respectively.

To apply themes to your application, merge the following items:

* Theme resource dictionary

#### Theme resource dictionary

This resource dictionary contains *keys* and their respective color codes for all the Syncfusion controls. Currently, the following two theme resource dictionaries are available:

1. Light theme resource dictionary
2. Dark theme resource dictionary

#### Automatic merging

When using more number of Syncfusion controls in an application, to make the process easier for merging the control style dictionaries of the controls, the SyncfusionThemeDictionary class has been provided for automatic merging. When the theme resource dictionary is merged to this dictionary, control style resource dictionaries will be merged automatically. However, only the styles for the controls used in the application will be merged.

{% highlight xaml %}

<Application xmlns:base="clr-namespace:SampleBrowser.Maui.Base;assembly=SampleBrowser.Maui.Base"
             xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             x:Class="SampleBrowser.Maui.App"
             ...>
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!-- Theme resource dictionary -->
                <syncTheme:SyncfusionThemeResourceDictionary SfVisualTheme="LightDefault"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
</Application.Resources>

....

</Application>

{% endhighlight %}

![DarkThemeImage](Images/DarkTheme.png)

## Overriding the default theme

The theme resource dictionary contains a set of keys that are mapped to the style in control style dictionaries. The default appearance of themes can be customized by overriding the key values.

The following section explains how to override both the primary and control specific keys.

### Overriding the control specific keys

In addition to the primary keys, the theme resource dictionary also contains the keys that are specific to each controls; these keys can also be overridden. You can find the keys and the UI elements to which they are mapped to all the controls in this `documentation`.

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary SfVisualTheme="DarkDefault"/>
            <ResourceDictionary>
                <Color x:Key="SfRadialGaugeNeedlePointerNeedleFillColor">LimeGreen</Color>
                <Color x:Key="SfRadialGaugeNeedlePointerKnobFillColor">LimeGreen</Color>
                <Color x:Key="SfRadialGaugeNeedlePointerTailFillColor">Black</Color>
                <Color x:Key="SfRadialGaugeAxisLineFillColor">Green</Color>
                <Color x:Key="SfRadialGaugeRangePointerFillColor">LimeGreen</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>

....

</Application>

{% endhighlight %}

![OverridingControlSpecificColors](Images/DarkTheme_ControlSpecific.png)

## Creating your own theme

As an alternative approach to the above methods, you can also create your own theme. To create own theme, first, you need to merge the resource, whose key name should be "ControlName" + "Theme" based on the controls, e.g., SfChartTheme and SfTextInputLayoutTheme. You can find this key for each control in this `documentation` . After merging this resource, you need to merge the required color resources based on the UI elements that need to be customized. You can find the keys and the UI elements to which they are mapped to all the controls in this `documentation`.
Using this approach, you can create your own theme to all the controls or for specific controls you need. 

{% highlight xaml %}

<Application xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core"
             ...>
 <Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <syncTheme:SyncfusionThemeResourceDictionary SfVisualTheme="DarkDefault"/>
            <ResourceDictionary>
                <x:String x:Key="SfRadialGaugeTheme">CommonTheme</x:String>
                <Color x:Key="SfRadialGaugeNeedlePointerNeedleFillColor">LimeGreen</Color>
                <Color x:Key="SfRadialGaugeNeedlePointerKnobFillColor">LimeGreen</Color>
                <Color x:Key="SfRadialGaugeNeedlePointerTailFillColor">Black</Color>
                <Color x:Key="SfRadialGaugeAxisLineFillColor">Green</Color>
                <Color x:Key="SfRadialGaugeRangePointerFillColor">LimeGreen</Color>
            </ResourceDictionary>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>

....

</Application>

{% endhighlight %}

 

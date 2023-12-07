---
layout: post
title: Customization in .NET MAUI Switch control | Syncfusion
description: Learn here all about Customization support in Syncfusion .NET MAUI Switch (SfSwitch) control and more.
platform: .NET MAUI
control: SfSwitch
documentation: ug
---

# Customization in .NET MAUI Switch (SfSwitch)

The switch control provides options to customize the color based on the states. The following code example demonstrates how to customize the switch control.

## Colors

The following properties are used to apply solid colors to the thumb, track, and border, respectively:

* [`TrackColor`]: Represents the color for the track.
* [`ThumbBackground`]: Represents the color for the thumb.
* [`TrackStroke`]: Represents the color for the border of the track.
* [`ThumbStroke`]: Represents the border color for the thumb.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch IsOn="False" AllowIndeterminateState="false"> 
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup  x:Name="CommonStates">
            <VisualState x:Name="On">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                 ThumbBackground="#FF029BFF"
                                 ThumbStroke="#FF029BFF"
                                 TrackBackground="#22029BFF"
                                 TrackStroke="#FF029BFF"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Off">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#FFFF0199"
                                ThumbStroke="#FFFF0199"
                                TrackBackground="#22FF0199"
                                TrackStroke="#FFFF0199"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Indeterminate">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                 ThumbBackground="#9ACB0D"
                                 ThumbStroke="#9ACB0D"
                                 TrackBackground="#DEF991"
                                 TrackStroke="#9ACB0D"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfSwitch>

{% endhighlight %}

{% endtabs %}

![switch conrol with visual state customization](images/customization/Colors.png)

## Sizing

In the switch control, sizing of the thumb and the track can be controlled by using the following properties:

* [`TrackCornerRadius`]: Represents a CornerRadius value to create curved corner of the track.
* [`TrackStrokeThickness`]: Represents a double value for defining the track border width.
* [`TrackWidthRequest`]: Represents a double value for defining the track width.
* [`TrackHeightRequest`]: Represents double value for defining the track height.
* [`ThumbCornerRadius`]: Represents a CornerRadius value to create curved corner of the thumb.
* [`ThumbStrokeThickness`]: Represents a double value for defining the thumb border width.
* [`ThumbWidthRequest`]: Represents double value for defining the thumb width.
* [`ThumbHeightRequest`]: Represents double value for defining the thumb height.

The following code example demonstrates how to customize the size of the track and thumb.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch> 
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup  x:Name="CommonStates">
            <VisualState x:Name="On">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbStrokeThickness="2"
                                TrackStrokeThickness="2"  
                                TrackHeightRequest="25" 
                                TrackWidthRequest="75" 
                                TrackCornerRadius="4"
                                ThumbCornerRadius="4" 
                                ThumbHeightRequest="10" 
                                ThumbWidthRequest="10"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Off">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbStrokeThickness="2"
                                TrackStrokeThickness="2"  
                                TrackHeightRequest="25" 
                                TrackWidthRequest="75" 
                                TrackCornerRadius="4"
                                ThumbCornerRadius="4" 
                                ThumbHeightRequest="10" 
                                ThumbWidthRequest="10"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfSwitch>

{% endhighlight %}

{% endtabs %}

![switch conrol with sizing](images/customization/Sizing.png)


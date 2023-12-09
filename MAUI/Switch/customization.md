---
layout: post
title: Customization in .NET MAUI Switch Control | Syncfusion
description: Learn here all about Customization support in Syncfusion .NET MAUI Switch (SfSwitch) control, and more.
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
* [`IconColor`]: Represents the border color for the thumb's Icon.

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

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
SwitchSettings onStyle = new SwitchSettings();
onStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#22029BFF"));
onStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#FF029BFF"));
onStyle.TrackStroke = Color.FromRgba("#FF029BFF");
onStyle.ThumbStroke = Color.FromRgba("#FF029BFF");

SwitchSettings offStyle = new SwitchSettings();
offStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#22FF0199"));
offStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#FFFF0199"));
offStyle.TrackStroke = Color.FromRgba("#FFFF0199");
offStyle.ThumbStroke = Color.FromRgba("#FFFF0199");

SwitchSettings indeterminateStyle = new SwitchSettings();
indeterminateStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#DEF991"));
indeterminateStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#9ACB0D"));
indeterminateStyle.TrackStroke = Color.FromRgba("#9ACB0D");
indeterminateStyle.ThumbStroke = Color.FromRgba("#9ACB0D");

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState onState = new VisualState { Name = "On" };
onState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onStyle});

VisualState offState = new VisualState { Name = "Off" };
offState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offStyle});

VisualState indeterminateState = new VisualState { Name = "Indeterminate" };
indeterminateState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= indeterminateStyle});

commonStateGroup.States.Add(onState);
commonStateGroup.States.Add(offState);
commonStateGroup.States.Add(indeterminateState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(sfSwitch, visualStateGroupList);
this.Content = sfSwitch;

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

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
SwitchSettings onStyle = new SwitchSettings();
onStyle.TrackWidthRequest = 75;
nStyle.TrackHeightRequest = 25;
onStyle.ThumbWidthRequest = 10;
onStyle.ThumbHeightRequest = 10;
onStyle.TrackStrokeThickness = 2;
onStyle.ThumbStrokeThickness = 2;
onStyle.TrackCornerRadius = 4;
onStyle.ThumbCornerRadius = 4;

SwitchSettings offStyle = new SwitchSettings();
offStyle.TrackWidthRequest = 75;
offStyle.TrackHeightRequest = 25;
offStyle.ThumbWidthRequest = 10;
offStyle.ThumbHeightRequest = 10;
offStyle.TrackStrokeThickness = 2;
offStyle.ThumbStrokeThickness = 2;
offStyle.TrackCornerRadius = 4;
 offStyle.ThumbCornerRadius = 4;

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState onState = new VisualState { Name = "On" };
onState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onStyle});

VisualState offState = new VisualState { Name = "Off" };
offState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offStyle});

commonStateGroup.States.Add(onState);
commonStateGroup.States.Add(offState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(sfSwitch, visualStateGroupList);
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![switch conrol with sizing](images/customization/Sizing.png)


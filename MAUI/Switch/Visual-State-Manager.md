---
layout: post
title: Visual state manager in .NET MAUI Switch (SfSwitch) | Syncfusion
description: Learn here all about handling of visual state manager in Syncfusion .NET MAUI Switch (SfSwitch) control, and more.
platform: .NET MAUI
control: Switch
documentation: ug
---

# Visual State Manager in .NET MAUI Switch (SfSwitch)

Use the visual state manager to change the .NET MAUI Switch properties based on the visual states, set from code. The applicable visual states are,

* On
* Off
* Indeterminate
* OnHovered
* OffHovered
* IndeterminateHovered
* OnPressed
* OffPressed
* IndeterminatePressed
* OnDisabled
* OffDisabled
* IndeterminateDisabled

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch IsEnabled="True" IsOn="True">
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup x:Name="CommonStates">
            <VisualState x:Name="On">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#F57B31"
                                ThumbCornerRadius="20"
                                ThumbHeightRequest="35"
                                ThumbStroke="#F78F50"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="35"
                                TrackBackground="#F7D40D"
                                TrackHeightRequest="50"
                                TrackStroke="#DABA04"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Off">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#F0F5F8"
                                ThumbCornerRadius="20"
                                ThumbHeightRequest="35"
                                ThumbStroke="#C7C9C9"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="35"
                                TrackBackground="#4FCFF7"
                                TrackHeightRequest="50"
                                TrackStroke="#359EBF"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="OnHovered">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#F57B31"
                                ThumbCornerRadius="20"
                                ThumbHeightRequest="35"
                                ThumbStroke="#E7600F"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="35"
                                TrackBackground="#F7D40D"
                                TrackHeightRequest="50"
                                TrackStroke="#DABA04"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="OffHovered">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#FFFFFF"
                                ThumbCornerRadius="20"
                                ThumbHeightRequest="35"
                                ThumbStroke="#959595"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="35"
                                TrackBackground="#72D4F3"
                                TrackHeightRequest="50"
                                TrackStroke="#359EBF"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="OnPressed">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#F57B31"
                                ThumbCornerRadius="24"
                                ThumbHeightRequest="48"
                                ThumbStroke="#E7600F"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="48"
                                TrackBackground="#F7D40D"
                                TrackHeightRequest="50"
                                TrackStroke="#DABA04"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="OffPressed">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#FFFFFF"
                                ThumbCornerRadius="24"
                                ThumbHeightRequest="48"
                                ThumbStroke="#959595"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="48"
                                TrackBackground="#72D4F3"
                                TrackHeightRequest="50"
                                TrackStroke="#359EBF"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="OnDisabled">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#B0AFB2"
                                ThumbCornerRadius="20"
                                ThumbHeightRequest="35"
                                ThumbStroke="#B0AFB2"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="35"
                                TrackBackground="#FEF7FF"
                                TrackHeightRequest="50"
                                TrackStroke="#B0AFB2"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
                        </Setter.Value>
                    </Setter>
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="OffDisabled">
                <VisualState.Setters>
                    <Setter Property="SwitchSettings">
                        <Setter.Value>
                            <syncfusion:SwitchSettings
                                ThumbBackground="#B0AFB2"
                                ThumbCornerRadius="20"
                                ThumbHeightRequest="35"
                                ThumbStroke="#B0AFB2"
                                ThumbStrokeThickness="1"
                                ThumbWidthRequest="35"
                                TrackBackground="#FEF7FF"
                                TrackHeightRequest="50"
                                TrackStroke="#B0AFB2"
                                TrackCornerRadius="25"
                                TrackStrokeThickness="1"
                                TrackWidthRequest="90"/>
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
onStyle.TrackWidthRequest = 90;
onStyle.TrackHeightRequest = 50;
onStyle.ThumbWidthRequest = 35;
onStyle.ThumbHeightRequest = 35;
onStyle.TrackStrokeThickness = 1;
onStyle.ThumbStrokeThickness = 1;
onStyle.TrackCornerRadius = 25;
onStyle.ThumbCornerRadius = 20;
onStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#F7D40D"));
onStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#F57B31"));
onStyle.TrackStroke = Color.FromRgba("#DABA04");
onStyle.ThumbStroke = Color.FromRgba("#F78F50");

SwitchSettings onHoveredStyle = new SwitchSettings();
onHoveredStyle.TrackWidthRequest = 90;
onHoveredStyle.TrackHeightRequest = 50;
onHoveredStyle.ThumbWidthRequest = 35;
onHoveredStyle.ThumbHeightRequest = 35;
onHoveredStyle.TrackStrokeThickness = 1;
onHoveredStyle.ThumbStrokeThickness = 1;
onHoveredStyle.TrackCornerRadius = 25;
onHoveredStyle.ThumbCornerRadius = 20;
onHoveredStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#F7D40D"));
onHoveredStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#F57B31"));
onHoveredStyle.TrackStroke = Color.FromRgba("#DABA04");
onHoveredStyle.ThumbStroke = Color.FromRgba("#E7600F");

SwitchSettings onPressedStyle = new SwitchSettings();
onPressedStyle.TrackWidthRequest = 90;
onPressedStyle.TrackHeightRequest = 50;
onPressedStyle.ThumbWidthRequest = 48;
onPressedStyle.ThumbHeightRequest = 48;
onPressedStyle.TrackStrokeThickness = 1;
onPressedStyle.ThumbStrokeThickness = 1;
onPressedStyle.TrackCornerRadius = 25;
onPressedStyle.ThumbCornerRadius = 24;
onPressedStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#F7D40D"));
onPressedStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#F57B31"));
onPressedStyle.TrackStroke = Color.FromRgba("#DABA04");
onPressedStyle.ThumbStroke = Color.FromRgba("#E7600F");

SwitchSettings onDisabledStyle = new SwitchSettings();
onDisabledStyle.TrackWidthRequest = 90;
onDisabledStyle.TrackHeightRequest = 50;
onDisabledStyle.ThumbWidthRequest = 35;
onDisabledStyle.ThumbHeightRequest = 35;
onDisabledStyle.TrackStrokeThickness = 1;
onDisabledStyle.ThumbStrokeThickness = 1;
onDisabledStyle.TrackCornerRadius = 25;
onDisabledStyle.ThumbCornerRadius = 20;
onDisabledStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#FEF7FF"));
onDisabledStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#B0AFB2"));
onDisabledStyle.TrackStroke = Color.FromRgba("#B0AFB2");
onDisabledStyle.ThumbStroke = Color.FromRgba("#B0AFB2");

SwitchSettings offStyle = new SwitchSettings();
offStyle.TrackWidthRequest = 90;
offStyle.TrackHeightRequest = 50;
offStyle.ThumbWidthRequest = 35;
offStyle.ThumbHeightRequest = 35;
offStyle.TrackStrokeThickness = 1;
offStyle.ThumbStrokeThickness = 1;
offStyle.TrackCornerRadius = 25;
offStyle.ThumbCornerRadius = 20;
offStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#4FCFF7"));
offStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#F0F5F8"));
offStyle.TrackStroke = Color.FromRgba("#359EBF");
offStyle.ThumbStroke = Color.FromRgba("#C7C9C9");

SwitchSettings offHoveredStyle = new SwitchSettings();
offHoveredStyle.TrackWidthRequest = 90;
offHoveredStyle.TrackHeightRequest = 50;
offHoveredStyle.ThumbWidthRequest = 35;
offHoveredStyle.ThumbHeightRequest = 35;
offHoveredStyle.TrackStrokeThickness = 1;
offHoveredStyle.ThumbStrokeThickness = 1;
offHoveredStyle.TrackCornerRadius = 25;
offHoveredStyle.ThumbCornerRadius = 20;
offHoveredStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#72D4F3"));
offHoveredStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#FFFFFF"));
offHoveredStyle.TrackStroke = Color.FromRgba("#359EBF");
offHoveredStyle.ThumbStroke = Color.FromRgba("#959595");

SwitchSettings offPressedStyle = new SwitchSettings();
offPressedStyle.TrackWidthRequest = 90;
offPressedStyle.TrackHeightRequest = 50;
offPressedStyle.ThumbWidthRequest = 48;
offPressedStyle.ThumbHeightRequest = 48;
offPressedStyle.TrackStrokeThickness = 1;
offPressedStyle.ThumbStrokeThickness = 1;
offPressedStyle.TrackCornerRadius = 25;
offPressedStyle.ThumbCornerRadius = 24;
offPressedStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#72D4F3"));
offPressedStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#FFFFFF"));
offPressedStyle.TrackStroke = Color.FromRgba("#359EBF");
offPressedStyle.ThumbStroke = Color.FromRgba("#959595");

SwitchSettings offDisabledStyle = new SwitchSettings();
offDisabledStyle.TrackWidthRequest = 90;
offDisabledStyle.TrackHeightRequest = 50;
offDisabledStyle.ThumbWidthRequest = 35;
offDisabledStyle.ThumbHeightRequest = 35;
offDisabledStyle.TrackStrokeThickness = 1;
offDisabledStyle.ThumbStrokeThickness = 1;
offDisabledStyle.TrackCornerRadius = 25;
offDisabledStyle.ThumbCornerRadius = 20;
offDisabledStyle.TrackBackground = new SolidColorBrush(Color.FromRgba("#FEF7FF"));
offDisabledStyle.ThumbBackground = new SolidColorBrush(Color.FromRgba("#B0AFB2"));
offDisabledStyle.TrackStroke = Color.FromRgba("#B0AFB2");
offDisabledStyle.ThumbStroke = Color.FromRgba("#B0AFB2");

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState onState = new VisualState { Name = "On" };
onState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onStyle});

VisualState onHoveredState = new VisualState { Name = "OnHovered" };
onHoveredState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onHoveredStyle});

VisualState onPressedState = new VisualState { Name = "OnPressed" };
onPressedState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onPressedStyle});

VisualState onDisabledState = new VisualState { Name = "OnDisabled" };
onDisabledState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= onDisabledStyle});

VisualState offState = new VisualState { Name = "Off" };
offState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offStyle});

VisualState offHoveredState = new VisualState { Name = "OffHovered" };
offHoveredState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offHoveredStyle});

VisualState offPressedState = new VisualState { Name = "OffPressed" };
offPressedState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offPressedStyle});

VisualState offDisabledState = new VisualState { Name = "OffDisabled" };
offDisabledState.Setters.Add(new Setter { Property = SfSwitch.SwitchSettingsProperty, Value= offDisabledStyle});

commonStateGroup.States.Add(onState);
commonStateGroup.States.Add(onHoveredState);
commonStateGroup.States.Add(onPressedState);
commonStateGroup.States.Add(onDisabledState);
commonStateGroup.States.Add(offState);
commonStateGroup.States.Add(offHoveredState);
commonStateGroup.States.Add(offPressedState);
commonStateGroup.States.Add(offDisabledState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(sfSwitch, visualStateGroupList);
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

![Visual state manager](images/VSM/VSM.gif)
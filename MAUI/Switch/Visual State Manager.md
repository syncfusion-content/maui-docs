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
                                ThumbBackground="White"
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
                                ThumbBackground="White"
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

![Visual state manager](images/VSM/VSM.gif)
---
layout: post
title: Track in .NET MAUI Range Slider control | Syncfusion<sup>®</sup>
description: Learn here all about adding the track feature of .NET MAUI Range Slider (SfDateTimeRangeSlider) control and more.
platform: maui
control: SfDateTimeRangeSlider
documentation: ug
---

# Track in .NET MAUI DateTime Range Slider (SfDateTimeRangeSlider)

This section helps to learn about how to customize the track in the DateTime Range Slider.

## Minimum

The minimum value that the user can select. The default value of the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_Minimum) property is null. The [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_Minimum) value must be less than the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_Maximum) value.

## Maximum

The maximum value that the user can select. The default value of the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_Maximum) property is null. The [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_Maximum) value must be greater than the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_Minimum) value.

## Range values

It represents the values currently selected in the DateTime Range Slider. The thumb is drawn corresponding to this [`RangeStart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart) and [`RangeEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd) values.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider Minimum="2010-01-01" 
                               Maximum="2020-01-01" 
                               RangeStart="2012-01-01" 
                               RangeEnd="2018-01-01" 
                               ShowLabels="True">
</sliders:SfDateTimeRangeSlider>
 
{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSlider rangeSlider = new SfDateTimeRangeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2020, 01, 01);
rangeSlider.RangeStart = new DateTime(2012, 01, 01);
rangeSlider.RangeEnd = new DateTime(2018, 01, 01);
rangeSlider.ShowLabels = true;

{% endhighlight %}

{% endtabs %}

![RangeSlider date label](images/track/date-labels.png)

## Track color

Change the active and inactive track color of the DateTime range slider using the [`ActiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveFill) and [`InactiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveFill) properties of the [`TrackStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle) class.

The active side of the DateTime Range Slider is between the start and end thumbs.

The inactive side of the DateTime Range Slider is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) value and the left thumb and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) value.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider Minimum="2010-01-01" 
                               Maximum="2018-01-01" 
                               RangeStart="2012-01-01" 
                               RangeEnd="2016-01-01">
  
  <sliders:SfDateTimeRangeSlider.TrackStyle>
      <sliders:SliderTrackStyle ActiveFill="#EE3F3F" InactiveFill="#F7B1AE" />
  </sliders:SfDateTimeRangeSlider.TrackStyle>

</sliders:SfDateTimeRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSlider rangeSlider = new SfDateTimeRangeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2018, 01, 01);
rangeSlider.RangeStart = new DateTime(2012, 01, 01);
rangeSlider.RangeEnd = new DateTime(2016, 01, 01);
rangeSlider.TrackStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.TrackStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![RangeSlider track color](images/track/track-color.png)

## Track height

Change the active and inactive track height using the [`ActiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveSize) and [`InactiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveSize) properties of the [`TrackStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle) class. The default value of the [`ActiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveSize) and the [`InactiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveSize) properties are `8.0` and `6.0` respectively.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider Minimum="2010-01-01" 
                               Maximum="2018-01-01" 
                               RangeStart="2012-01-01" 
                               RangeEnd="2016-01-01">
   
   <sliders:SfDateTimeRangeSlider.TrackStyle>
      <sliders:SliderTrackStyle ActiveSize="10" InactiveSize="8" />
   </sliders:SfDateTimeRangeSlider.TrackStyle>

</sliders:SfDateTimeRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSlider rangeSlider = new SfDateTimeRangeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2018, 01, 01);
rangeSlider.RangeStart = new DateTime(2012, 01, 01);
rangeSlider.RangeEnd = new DateTime(2016, 01, 01);
rangeSlider.TrackStyle.ActiveSize = 10;
rangeSlider.TrackStyle.InactiveSize = 8;

{% endhighlight %}

{% endtabs %}

![RangeSlider track size](images/track/track-size.png)

## Track extent

You can extend the track at the edges using the [`TrackExtent`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent) property. The default value is `0`, and it should be in pixels.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider  Minimum="2010-01-01"
                                Maximum="2018-01-01"
                                RangeStart="2012-01-01"
                                RangeEnd="2016-01-01"
                                Interval="2"
                                ShowTicks="True"
                                TrackExtent="25" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider rangeSlider = new SfDateTimeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2018, 01, 01);
rangeSlider.RangeStart = new DateTime(2012, 01, 01);
rangeSlider.RangeEnd = new DateTime(2016, 01, 01);
rangeSlider.Interval = 2;
rangeSlider.ShowTicks = true;
rangeSlider.TrackExtent = 25;

{% endhighlight %}

{% endtabs %}

**Without track extent**

![RangeSlider track extent before](images/track/track-extent-before-image.png)

**With track extent**

![RangeSlider track extent after](images/track/track-extent-after-image.png)

## Disabled track

Change the state of the DateTime Range Slider to disabled by setting `false` to the `IsEnabled` property. Using the Visual State Manager (VSM), customize the range slider track properties based on the visual states. The applicable visual states are enabled(default) and disabled.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <Style TargetType="sliders:SfDateTimeRangeSlider">
        <Setter Property="Minimum"
                Value="2010-01-01" />
        <Setter Property="Maximum"
                Value="2018-01-01" />
        <Setter Property="RangeStart"
                Value="2012-01-01" />
        <Setter Property="RangeEnd"
                Value="2016-01-01" />
        <Setter Property="ThumbStyle">
            <sliders:SliderThumbStyle Radius="0" />
        </Setter>
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup>
                    <VisualState x:Name="Default">
                        <VisualState.Setters>
                            <Setter Property="TrackStyle">
                                <Setter.Value>
                                    <sliders:SliderTrackStyle ActiveSize="8"
                                                              InactiveSize="6"
                                                              ActiveFill="#EE3F3F"
                                                              InactiveFill="#F7B1AE" />
                                </Setter.Value>
                            </Setter>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TrackStyle">
                                <Setter.Value>
                                    <sliders:SliderTrackStyle ActiveSize="10"
                                                              InactiveSize="8"
                                                              ActiveFill="Gray"
                                                              InactiveFill="LightGray" />
                                </Setter.Value>
                            </Setter>
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>
</ContentPage.Resources>

<ContentPage.Content>
    <VerticalStackLayout>
        <Label Text="Enabled"
               Padding="24,10" />
        <sliders:SfDateTimeRangeSlider />
        <Label Text="Disabled"
               Padding="24,10" />
        <sliders:SfDateTimeRangeSlider IsEnabled="False" />
    </VerticalStackLayout>
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

VerticalStackLayout stackLayout = new();
SfDateTimeRangeSlider defaultRangeSlider = new()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2018, 01, 01),
    RangeStart = new DateTime(2012, 01, 01),
    RangeEnd = new DateTime(2016, 01, 01),
};
SfDateTimeRangeSlider disabledRangeSlider = new()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2018, 01, 01),
    RangeStart = new DateTime(2012, 01, 01),
    RangeEnd = new DateTime(2016, 01, 01),
    IsEnabled = false,
};

VisualStateGroupList visualStateGroupList = new();
VisualStateGroup commonStateGroup = new();
// Default State.
VisualState defaultState = new() { Name = "Default" };
defaultState.Setters.Add(new Setter
{
    Property = SfDateTimeRangeSlider.TrackStyleProperty,
    Value = new SliderTrackStyle
    {
        ActiveFill = Color.FromArgb("#EE3F3F"),
        InactiveFill = Color.FromArgb("#F7B1AE"),
        ActiveSize = 8,
        InactiveSize = 6,
    }
});
// Disabled State.
VisualState disabledState = new() { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfDateTimeRangeSlider.TrackStyleProperty,
    Value = new SliderTrackStyle
    {
        ActiveFill = Colors.Gray,
        InactiveFill = Colors.LightGray,
        ActiveSize = 10,
        InactiveSize = 8,
    }
});

commonStateGroup.States.Add(defaultState);
commonStateGroup.States.Add(disabledState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(defaultRangeSlider, visualStateGroupList);
VisualStateManager.SetVisualStateGroups(disabledRangeSlider, visualStateGroupList);

stackLayout.Children.Add(new Label() { Text = "Enabled", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(defaultRangeSlider);
stackLayout.Children.Add(new Label() { Text = "Disabled Range Slider", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(disabledRangeSlider);
this.Content = stackLayout;

{% endhighlight %}

{% endtabs %}

![RangeSlider track disabled state](images/track/track-disabled.png)
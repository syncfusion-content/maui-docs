---
layout: post
title: Dividers in .NET MAUI Range Slider control | Syncfusion<sup>®</sup>
description: Learn here all about the Dividers feature of .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Dividers in .NET MAUI Range Slider (SfRangeSlider)

This section explains how to add the dividers in the range slider.

## Show dividers

The [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers) property is used to render the dividers on the track. The default value of the [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers) property is `False`. It is a shape used to represent the major interval points of the track.

For example, if the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) is 0.0, the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) is 10.0, and [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval) is 2.0, the range slider will render the dividers at 0.0, 2.0, 4.0, and so on.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider RangeStart="0.2"
                       RangeEnd="0.8"
                       Interval="0.2"
                       ShowDividers="True" />

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.RangeStart = 0.2;
rangeSlider.RangeEnd = 0.8;
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;

{% endhighlight %}

{% endtabs %}

![RangeSlider divider](images/labels-and-dividers/divider.png)

## Divider radius

Change the active and inactive divider radius of the range slider using the [`ActiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveRadius) and the [`InactiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveRadius) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider RangeStart="0.2"
                       RangeEnd="0.8"
                       Interval="0.2"
                       ShowDividers="True">

    <sliders:SfRangeSlider.DividerStyle>
        <sliders:SliderDividerStyle ActiveRadius="3"
                                    InactiveRadius="5" />
    </sliders:SfRangeSlider.DividerStyle>

</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.RangeStart = 0.2;
rangeSlider.RangeEnd = 0.8;
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;
rangeSlider.DividerStyle.ActiveRadius = 3;
rangeSlider.DividerStyle.InactiveRadius = 5;

{% endhighlight %}

{% endtabs %}

![RangeSlider divider radius](images/labels-and-dividers/divider-radius.png)

## Divider color

Change the active and inactive divider color of the range slider using the [`ActiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveFill) and [`InactiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveFill) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider RangeStart="0.2"
                       RangeEnd="0.8"
                       Interval="0.2"
                       ShowDividers="True">

    <sliders:SfRangeSlider.DividerStyle>
        <sliders:SliderDividerStyle ActiveRadius="7"
                                    InactiveRadius="7"
                                    ActiveFill="#EE3F3F"
                                    InactiveFill="#F7B1AE" />
    </sliders:SfRangeSlider.DividerStyle>

</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.RangeStart = 0.2;
rangeSlider.RangeEnd = 0.8;
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;
rangeSlider.DividerStyle.ActiveRadius = 7;
rangeSlider.DividerStyle.InactiveRadius = 7;
rangeSlider.DividerStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.DividerStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![RangeSlider divider color](images/labels-and-dividers/divider-color.png)

## Divider stroke width and stroke color

Change the active and inactive divider stroke width of the range slider using the [`ActiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStrokeThickness) and the [`InactiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStrokeThickness) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

Also, change the active and inactive divider stroke color of the range slider using the [`ActiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStroke) and the [`InactiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStroke) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider RangeStart="0.2"
                       RangeEnd="0.8"
                       Interval="0.2"
                       ShowDividers="True">

    <sliders:SfRangeSlider.DividerStyle>
        <sliders:SliderDividerStyle ActiveRadius="7"
                                    InactiveRadius="7"
                                    ActiveFill="#EE3F3F"
                                    InactiveFill="#F7B1AE"
                                    ActiveStrokeThickness="2"
                                    InactiveStrokeThickness="2"
                                    ActiveStroke="#FFD700"
                                    InactiveStroke="#FFD700" />
    </sliders:SfRangeSlider.DividerStyle>

</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.RangeStart = 0.2;
rangeSlider.RangeEnd = 0.8;
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;
rangeSlider.DividerStyle.ActiveRadius = 7;
rangeSlider.DividerStyle.InactiveRadius = 7;
rangeSlider.DividerStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.DividerStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
rangeSlider.DividerStyle.ActiveStroke = new SolidColorBrush(Color.FromArgb("#FFD700"));
rangeSlider.DividerStyle.InactiveStroke = new SolidColorBrush(Color.FromArgb("#FFD700"));
rangeSlider.DividerStyle.ActiveStrokeThickness = 2;
rangeSlider.DividerStyle.InactiveStrokeThickness = 2;

{% endhighlight %}

{% endtabs %}

![RangeSlider divider stroke color](images/labels-and-dividers/divider-stroke-color.png)

## Disabled divider

Change the state of the range slider to disabled by setting `false` to the `IsEnabled` property. Using the Visual State Manager (VSM), customize the range slider divider properties based on the visual states. The applicable visual states are enabled(default) and disabled.

{% tabs %}

{% highlight xaml %}
<ContentPage.Resources>
    <Style TargetType="sliders:SfRangeSlider">
        <Setter Property="Interval"
                Value="0.25" />
        <Setter Property="ShowDividers"
                Value="True" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup>
                    <VisualState x:Name="Default">
                        <VisualState.Setters>
                            <Setter Property="DividerStyle">
                                <Setter.Value>
                                    <sliders:SliderDividerStyle ActiveFill="#EE3F3F"
                                                                InactiveFill="#88EE3F3F"
                                                                ActiveRadius="5"
                                                                InactiveRadius="4" />
                                </Setter.Value>
                            </Setter>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="DividerStyle">
                                <Setter.Value>
                                    <sliders:SliderDividerStyle ActiveFill="Gray"
                                                                InactiveFill="LightGray"
                                                                ActiveRadius="5"
                                                                InactiveRadius="4" />
                                </Setter.Value>
                            </Setter>
                            <Setter Property="TrackStyle">
                                <Setter.Value>
                                    <sliders:SliderTrackStyle ActiveFill="Gray"
                                                              InactiveFill="LightGray" />
                                </Setter.Value>
                            </Setter>
                            <Setter Property="ThumbStyle">
                                <Setter.Value>
                                    <sliders:SliderThumbStyle Fill="Gray" />
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
        <sliders:SfRangeSlider />
        <Label Text="Disabled"
               Padding="24,10" />
        <sliders:SfRangeSlider IsEnabled="False" />
    </VerticalStackLayout>
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

VerticalStackLayout stackLayout = new();
SfRangeSlider enabledRangeSlider = new()
{
    Interval = 0.25,
    ShowDividers = true
};
SfRangeSlider disabledRangeSlider = new()
{
    IsEnabled = false,
    Interval = 0.25,
    ShowDividers = true
};

VisualStateGroupList visualStateGroupList = new();
VisualStateGroup commonStateGroup = new();
// Default State.
VisualState enabledState = new() { Name = "Default" };
enabledState.Setters.Add(new Setter
{
    Property = SfRangeSlider.DividerStyleProperty,
    Value = new SliderDividerStyle
    {
        ActiveFill = Color.FromArgb("#EE3F3F"),
        InactiveFill = Color.FromArgb("#88EE3F3F"),
        ActiveRadius = 5,
        InactiveRadius = 4,
    }
});
// Disabled State.
VisualState disabledState = new() { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfRangeSlider.DividerStyleProperty,
    Value = new SliderDividerStyle
    {
        ActiveFill = Colors.Gray,
        InactiveFill = Colors.LightGray,
        ActiveRadius = 5,
        InactiveRadius = 4,
    }
});
disabledState.Setters.Add(new Setter
{
    Property = SfRangeSlider.TrackStyleProperty,
    Value = new SliderTrackStyle
    {
        ActiveFill = Colors.Gray,
        InactiveFill = Colors.LightGray,
    }
});
disabledState.Setters.Add(new Setter
{
    Property = SfRangeSlider.ThumbStyleProperty,
    Value = new SliderThumbStyle
    {
        Fill = Colors.Gray,
    }
});

commonStateGroup.States.Add(enabledState);
commonStateGroup.States.Add(disabledState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(enabledRangeSlider, visualStateGroupList);
VisualStateManager.SetVisualStateGroups(disabledRangeSlider, visualStateGroupList);

stackLayout.Children.Add(new Label() { Text = "Enabled", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(enabledRangeSlider);
stackLayout.Children.Add(new Label() { Text = "Disabled", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(disabledRangeSlider);
this.Content = stackLayout;

{% endhighlight %}

{% endtabs %}

![RangeSlider divider disabled state](images/labels-and-dividers/divider-disabled.png)
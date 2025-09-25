---
layout: post
title: Labels in .NET MAUI Slider Control | Syncfusion®
description: Learn about the Label customization feature of the .NET MAUI Slider (SfSlider) control.
platform: maui
control: SfSlider
documentation: ug
---

# Labels in .NET MAUI Slider (SfSlider)

This section explains how to add labels to the slider.

## Show Labels

The [`ShowLabels`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels) property is used to render labels at specified intervals. The default value of `ShowLabels` is `False`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="2"
                  Maximum="10"
                  Value="6"
                  Interval="2"
                  ShowLabels="True"
                  ShowTicks="True" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 2,
    Maximum = 10,
    Value = 6,
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
};

{% endhighlight %}

{% endtabs %}

![Slider labels](images/labels-and-dividers/labels.png)

## Number Format

The [`NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_NumberFormat) property formats numeric labels. The default value is `0.##`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="2"
                  Maximum="10"
                  Value="6"
                  Interval="2"
                  NumberFormat="$##"
                  ShowLabels="True"
                  ShowTicks="True" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 2,
    Maximum = 10,
    Value = 6,
    Interval = 2,
    NumberFormat = "$##",
    ShowLabels = true,
    ShowTicks = true,
};

{% endhighlight %}

{% endtabs %}

![Slider number format](images/labels-and-dividers/number-format.png)

## Label Placement

The [`LabelsPlacement`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement) property positions labels either between major ticks or directly on them. The default setting is [`SliderLabelsPlacement.OnTicks`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelsPlacement.html#Syncfusion_Maui_Sliders_SliderLabelsPlacement_OnTicks).

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="0"
                  Maximum="10"
                  Value="5"
                  Interval="2"
                  LabelsPlacement="BetweenTicks"
                  ShowLabels="True"
                  ShowTicks="True" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 0,
    Maximum = 10,
    Value = 5,
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
    LabelsPlacement = SliderLabelsPlacement.BetweenTicks,
};

{% endhighlight %}

{% endtabs %}

![Slider label placement](images/labels-and-dividers/label-placement.png)

> Note: Refer [here](https://help.syncfusion.com/maui/slider/events) to customize the label text format through slider events.

## Edge Labels Placement

The [`EdgeLabelsPlacement`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement) property adjusts the position of the first and last labels either inside the track bounds or based on intervals. The default configuration is [`SliderEdgeLabelsPlacement.Default`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html#Syncfusion_Maui_Sliders_SliderEdgeLabelsPlacement_Default).

If the [`TrackExtent`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent) > 0 and the [`EdgeLabelsPlacement`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement) is set to [`SliderEdgeLabelsPlacement.Inside`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html#Syncfusion_Maui_Sliders_SliderEdgeLabelsPlacement_Inside), labels will be placed inside the extended track edges.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="100"
                  Maximum="1000"
                  Value="550"
                  Interval="225"
                  ShowLabels="True"
                  ShowTicks="True"
                  NumberFormat="$##"
                  EdgeLabelsPlacement="Inside" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 100,
    Maximum = 100,
    Value = 550,
    Interval = 225,
    ShowTicks = true,
    ShowLabels = true,
    ShowDividers = true,
    NumberFormat = "$##",
    EdgeLabelsPlacement = SliderEdgeLabelsPlacement.Inside
};

{% endhighlight %}

{% endtabs %}

![Slider edge labels placement](images/labels-and-dividers/edge-labels-placement.gif)

## Label Style

You can alter the active and inactive label appearance of the slider using the [`ActiveTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveTextColor), [`ActiveFontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontSize), [`ActiveFontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontFamily), [`ActiveFontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontAttributes), [`InactiveTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveTextColor), [`InactiveFontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontSize), [`InactiveFontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontFamily), [`InactiveFontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontAttributes), and [`Offset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_Offset) properties of the [`LabelStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html) class.

The active side of the slider is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Minimum) value and the thumb, while the inactive side is between the thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Maximum) value.
{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="2"
                  Maximum="10"
                  Value="6"
                  Interval="2"
                  ShowTicks="True"
                  ShowLabels="True">
    
    <sliders:SfSlider.LabelStyle>
        <sliders:SliderLabelStyle ActiveTextColor="#EE3F3F"
                                  InactiveTextColor="#F7B1AE"
                                  ActiveFontAttributes="Italic"
                                  InactiveFontAttributes="Italic"
                                  ActiveFontSize="16"
                                  InactiveFontSize="16" />
    </sliders:SfSlider.LabelStyle>
    
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 2,
    Maximum = 10,
    Value = 6,
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
};
slider.LabelStyle.ActiveTextColor = Color.FromArgb("#EE3F3F");
slider.LabelStyle.InactiveTextColor = Color.FromArgb("#F7B1AE");
slider.LabelStyle.ActiveFontSize = 16;
slider.LabelStyle.InactiveFontSize = 16;
slider.LabelStyle.ActiveFontAttributes = FontAttributes.Italic;
slider.LabelStyle.InactiveFontAttributes = FontAttributes.Italic;

{% endhighlight %}

{% endtabs %}

![Slider label style](images/labels-and-dividers/label-style.png)

## Label Offset

Adjust the space between ticks and labels of the slider using the [`Offset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_OffsetProperty) property. The default value is `5.0` when [`ShowTicks`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks) is enabled; otherwise, it defaults to `15.0`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="2"
                  Maximum="10"
                  Value="6"
                  Interval="2"
                  ShowTicks="True"
                  ShowLabels="True">

    <sliders:SfSlider.LabelStyle>
        <sliders:SliderLabelStyle Offset="10" />
    </sliders:SfSlider.LabelStyle>

</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 2,
    Maximum = 10,
    Value = 6,
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
};
slider.LabelStyle.Offset = 10;

{% endhighlight %}

{% endtabs %}

![Slider label offset](images/labels-and-dividers/label-offset.png)

## Disabled Labels

Change the state of the slider to disabled by setting the `IsEnabled` property to `false`. With the Visual State Manager (VSM), you can customize slider label properties based on the visual states: enabled (default) and disabled.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <Style TargetType="sliders:SfSlider">
        <Setter Property="Interval"
                Value="0.25" />
        <Setter Property="ShowTicks"
                Value="True" />
        <Setter Property="ShowLabels"
                Value="True" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup>
                    <VisualState x:Name="Default">
                        <VisualState.Setters>
                            <Setter Property="LabelStyle">
                                <Setter.Value>
                                    <sliders:SliderLabelStyle ActiveTextColor="#EE3F3F"
                                                              InactiveTextColor="#F7B1AE"
                                                              ActiveFontSize="16"
                                                              InactiveFontSize="14"
                                                              ActiveFontAttributes="Bold"
                                                              InactiveFontAttributes="Italic" />
                                </Setter.Value>
                            </Setter>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="LabelStyle">
                                <Setter.Value>
                                    <sliders:SliderLabelStyle ActiveTextColor="Gray"
                                                              InactiveTextColor="LightGray"
                                                              ActiveFontSize="14"
                                                              InactiveFontSize="16"
                                                              ActiveFontAttributes="Italic"
                                                              InactiveFontAttributes="Bold" />
                                </Setter.Value>
                            </Setter>
                            <Setter Property="ThumbStyle">
                                <Setter.Value>
                                    <sliders:SliderThumbStyle Fill="Gray" />
                                </Setter.Value>
                            </Setter>
                            <Setter Property="TrackStyle">
                                <Setter.Value>
                                    <sliders:SliderTrackStyle ActiveFill="Gray"
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
        <sliders:SfSlider />
        <Label Text="Disabled"
               Padding="24,10" />
        <sliders:SfSlider IsEnabled="False" />
    </VerticalStackLayout>
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

VerticalStackLayout stackLayout = new VerticalStackLayout();
SfSlider defaultSlider = new()
{
    Interval = 0.25,
    ShowTicks = true,
    ShowLabels = true
};
SfSlider disabledSlider = new()
{
    IsEnabled = false,
    Interval = 0.25,
    ShowTicks = true,
    ShowLabels = true
};

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();
// Default State.
VisualState defaultState = new VisualState { Name = "Default" };
defaultState.Setters.Add(new Setter
{
    Property = SfSlider.LabelStyleProperty,
    Value = new SliderLabelStyle
    {
        ActiveFontSize = 16,
        InactiveFontSize = 14,
        ActiveTextColor = Color.FromArgb("#EE3F3F"),
        InactiveTextColor = Color.FromArgb("#F7B1AE"),
        ActiveFontAttributes = FontAttributes.Bold,
        InactiveFontAttributes = FontAttributes.Italic,
    }
});
// Disabled State.
VisualState disabledState = new VisualState { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfSlider.LabelStyleProperty,
    Value = new SliderLabelStyle
    {
        ActiveFontSize = 14,
        InactiveFontSize = 16,
        ActiveTextColor = Colors.Gray,
        InactiveTextColor = Colors.LightGray,
        ActiveFontAttributes = FontAttributes.Italic,
        InactiveFontAttributes = FontAttributes.Bold,
    }
});
disabledState.Setters.Add(new Setter
{
    Property = SfSlider.ThumbStyleProperty,
    Value = new SliderThumbStyle
    {
        Fill = Colors.Gray,
    }
});
disabledState.Setters.Add(new Setter
{
    Property = SfSlider.TrackStyleProperty,
    Value = new SliderTrackStyle
    {
        ActiveFill = Colors.Gray,
        InactiveFill = Colors.LightGray,
    }
});

commonStateGroup.States.Add(defaultState);
commonStateGroup.States.Add(disabledState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(defaultSlider, visualStateGroupList);
VisualStateManager.SetVisualStateGroups(disabledSlider, visualStateGroupList);

stackLayout.Children.Add(new Label() { Text = "Enabled", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(defaultSlider);
stackLayout.Children.Add(new Label() { Text = "Disabled", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(disabledSlider);
this.Content = stackLayout;

{% endhighlight %}

{% endtabs %}

![Slider labels disabled state](images/labels-and-dividers/labels-disabled.png)
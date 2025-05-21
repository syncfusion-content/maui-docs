---
layout: post
title: Thumb and Thumb Overlay in .NET MAUI Range Slider control | Syncfusion®
description: Learn all about the Thumb and Thumb Overlay features of the Syncfusion® .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Thumb and Overlay in .NET MAUI Range Slider (SfRangeSlider)

This section explains how to customize the thumb and thumb overlay in the range slider.

- **Thumb**: A component of the slider that can be used to drag and change the selected value of the range slider.
- **Thumb Overlay**: Renders around the thumb while interacting with it.

## Thumb Size

Change the size of the thumb in the range slider using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class. The default value of the `Radius` property is `10.0`.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
    <sliders:SfRangeSlider.ThumbStyle>
        <sliders:SliderThumbStyle Radius="15" />
    </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Radius = 15;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb size](images/thumb-and-thumb-overlay/thumb-radius.png)

## Thumb Color

Change the color of the thumb using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Fill) property of the `ThumbStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
   <sliders:SfRangeSlider.ThumbStyle>
       <sliders:SliderThumbStyle Fill="#EE3F3F" />
   </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Fill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb color](images/thumb-and-thumb-overlay/thumb-color.png)

## Thumb Stroke Thickness and Stroke

Modify the thumb stroke width using the [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_StrokeThickness) property, and change the stroke color using the [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Stroke) property of the `ThumbStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
    <sliders:SfRangeSlider.ThumbStyle>
        <sliders:SliderThumbStyle StrokeThickness="2"
                                  Stroke="#EE3F3F" />
    </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.ThumbStyle.StrokeThickness = 2;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb stroke color](images/thumb-and-thumb-overlay/thumb-stroke-color.png)

## Thumb Overlapping Stroke Color

Modify the stroke color of overlapping thumbs using the [`OverlapStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_OverlapStroke) property of the `ThumbStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
  <sliders:SfRangeSlider.ThumbStyle>
      <sliders:SliderThumbStyle OverlapStroke="#FFD700" />
  </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.OverlapStroke = new SolidColorBrush(Color.FromArgb("#FFD700"));

{% endhighlight %}

{% endtabs %}

![RangeSlider thumb overlapping stroke color](images/thumb-and-thumb-overlay/thumb-overlapstrokecolor.gif)

## Thumb Overlay Size

Adjust the size of the thumb overlay using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class. The default value of the `Radius` is `24.0`.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
   <sliders:SfRangeSlider.ThumbOverlayStyle>
      <sliders:SliderThumbOverlayStyle Radius="18"/>
   </sliders:SfRangeSlider.ThumbOverlayStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbOverlayStyle.Radius = 18;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb overlay size](images/thumb-and-thumb-overlay/thumb-overlay-radius.png)

## Thumb overlay color

Change the thumb overlay color using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Fill) property of the `ThumbOverlayStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
   <sliders:SfRangeSlider.ThumbOverlayStyle>
      <sliders:SliderThumbOverlayStyle Fill="#66FFD700"/>
   </sliders:SfRangeSlider.ThumbOverlayStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbOverlayStyle.Fill = new SolidColorBrush(Color.FromArgb("#66FFD700"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb overlay color](images/thumb-and-thumb-overlay/thumb-overlay-color.png)

## Disabled Thumb

Disable the range slider by setting the `IsEnabled` property to `false`. Use the Visual State Manager (VSM) to customize thumb properties based on visual states (enabled or disabled).

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <Style TargetType="sliders:SfRangeSlider">
        <Setter Property="Interval"
                Value="0.25" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup>
                    <VisualState x:Name="Default">
                        <VisualState.Setters>
                            <Setter Property="ThumbStyle">
                                <Setter.Value>
                                    <sliders:SliderThumbStyle Radius="13"
                                                              Fill="Red"
                                                              Stroke="Yellow"
                                                              StrokeThickness="3" />
                                </Setter.Value>
                            </Setter>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="ThumbStyle">
                                <Setter.Value>
                                    <sliders:SliderThumbStyle Radius="13"
                                                              Fill="Gray"
                                                              Stroke="LightGray"
                                                              StrokeThickness="3" />
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
        <sliders:SfRangeSlider />
        <Label Text="Disabled"
               Padding="24,10" />
        <sliders:SfRangeSlider IsEnabled="False" />
    </VerticalStackLayout>
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

VerticalStackLayout stackLayout = new();
SfRangeSlider defaultRangeSlider = new();
SfRangeSlider disabledRangeSlider = new() { IsEnabled = false };

VisualStateGroupList visualStateGroupList = new();
VisualStateGroup commonStateGroup = new();
// Default State.
VisualState defaultState = new() { Name = "Default" };
defaultState.Setters.Add(new Setter
{
    Property = SfRangeSlider.ThumbStyleProperty,
    Value = new SliderThumbStyle
    {
        Radius = 13,
        Fill = Colors.Red,
        Stroke = Colors.Yellow,
        StrokeThickness = 3,
    }
});
// Disabled State.
VisualState disabledState = new() { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfRangeSlider.ThumbStyleProperty,
    Value = new SliderThumbStyle
    {
        Radius = 13,
        Fill = Colors.Gray,
        Stroke = Colors.LightGray,
        StrokeThickness = 3,
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

commonStateGroup.States.Add(defaultState);
commonStateGroup.States.Add(disabledState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(defaultRangeSlider, visualStateGroupList);
VisualStateManager.SetVisualStateGroups(disabledRangeSlider, visualStateGroupList);

stackLayout.Children.Add(new Label() { Text = "Enabled", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(defaultRangeSlider);
stackLayout.Children.Add(new Label() { Text = "Disabled", Padding = new Thickness(24, 10) });
stackLayout.Children.Add(disabledRangeSlider);
this.Content = stackLayout;

{% endhighlight %}

{% endtabs %}

![RangeSlider thumb disabled state](images/thumb-and-thumb-overlay/thumb-disabled.png)
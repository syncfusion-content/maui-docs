---
layout: post
title: Labels in .NET MAUI Slider control | Syncfusion
description: Learn here all about the Labels and its customization feature of .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Labels in .NET MAUI Slider (SfSlider)

This section explains about how to add the labels in the slider.

## Show labels

The [`ShowLabels`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ShowLabels) property is used to render the labels on given interval. The default value of [`ShowLabels`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ShowLabels) property is `False`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="0" 
                  Maximum="10"
                  Value="6"
                  Interval="2"
                  ShowLabels="True"
                  ShowTicks="True">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Minimum = 2;
slider.Maximum = 10;
slider.Value = 6;
slider.Interval = 2;
slider.ShowTicks = true;
slider.ShowLabels = true;

{% endhighlight %}

{% endtabs %}

![Slider labels](images/labels-and-dividers/labels.png)

## Number format

The [`NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_NumberFormat) property is used to format the numeric labels. The default value of [`NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_NumberFormat) property is `0.##`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="2" 
                  Maximum="10"
                  Value="6"
		          Interval="2"  
		          NumberFormat="$##" 
		          ShowLabels="True"
                  ShowTicks="True">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Minimum = 2;
slider.Maximum = 10;
slider.Value = 6;
slider.Interval = 2;
slider.NumberFormat = "$##";
slider.ShowLabels = true;

{% endhighlight %}

{% endtabs %}

![Slider number format](images/labels-and-dividers/number-format.png)

## Date format

The [`DateFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_DateFormat) property is used to format the date labels. It is mandatory for date [`SfDateTimeSlider`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html). For date values, the slider does not have auto interval support. So, it is mandatory to set [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Interval), [`IntervalType`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_IntervalType), and [`DateFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_DateFormat) for date values. The default value of [`DateFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_DateFormat) property is `yyyy`.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2000-01-01T09:00:00" 
                          Maximum="2000-01-01T17:00:00" 
                          Value="2000-01-01T13:00:00" 
          	              ShowLabels="True"  
		                  IntervalType="Hours" 
		                  Interval="2" 
		                  DateFormat="h tt">
</sliders:SfDateTimeSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Minimum = new DateTime(2000, 01, 01, 09, 00, 00);
slider.Maximum = new DateTime(2000, 01, 01, 17, 00, 00);
slider.Value = new DateTime(2000, 01, 01, 13, 00, 00);
slider.Interval = 2;
slider.IntervalType = SliderDateIntervalType.Hours;
slider.DateFormat = "h tt";
slider.ShowLabels = true;
    
{% endhighlight %}

{% endtabs %}

![Slider date format](images/labels-and-dividers/date-format.png)

## Label placement

The [`LabelsPlacement`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_LabelsPlacement) property is used to place the labels either between the major ticks or on the major ticks. The default value of the [`LabelsPlacement`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_LabelsPlacement) property is [`SliderLabelsPlacement.OnTicks`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelsPlacement.html#Syncfusion_Maui_Sliders_SliderLabelsPlacement_OnTicks).

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="0" 
                  Maximum="10"
                  Value="5"
		          Interval="2"  
		          LabelsPlacement="BetweenTicks" 
		          ShowLabels="True" 
		          ShowTicks="True">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Minimum = 0;
slider.Maximum = 10;
slider.Value = 5;
slider.Interval = 2;
slider.LabelsPlacement = SliderLabelsPlacement.BetweenTicks;
slider.ShowLabels = true;
slider.ShowTicks = true;

{% endhighlight %}

{% endtabs %}

![Slider label placement](images/labels-and-dividers/label-placement.png)

N> Refer [here](https://help.syncfusion.com/maui/slider/events) to customize the label text format through slider events.

## Edge labels placement

The `EdgeLabelsPlacement` property is used to move the first and last label either inside the track bounds or based on the intervals. The default value of the `EdgeLabelsPlacement` property is `SliderEdgeLabelPlacement.Default`.

If the `TrackExtent` > 0 and `EdgeLabelsPlacement` is `SliderEdgeLabelsPlacement.Inside`, the labels get placed inside the extended track edges. 

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="100"
                  Maximum="10000"
                  Value="5050"
                  Interval="2475"
                  NumberFormat="$##.#"
                  EdgeLabelsPlacement="Inside"
                  ShowLabels="True"
                  ShowTicks="True" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Minimum = 100;
slider.Maximum = 10000;
slider.Value = 5050;
slider.Interval = 2475;
slider.NumberFormat = "$##.#";
slider.EdgeLabelsPlacement = SliderEdgeLabelsPlacement.Inside;
slider.ShowLabels = true;
slider.ShowTicks = true;

{% endhighlight %}

{% endtabs %}

![Slider edge labels placement](images/labels-and-dividers/edge-labels-placement.gif)

## Label style

You can change the active and inactive label appearance of the slider using the [`ActiveTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveTextColor), [`ActiveFontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontSize), [`ActiveFontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontFamily), [`ActiveFontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontAttributes), [`InactiveTextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveTextColor), [`InactiveFontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontSize), [`InactiveFontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontFamily), [`InactiveFontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontAttributes) and [`Offset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_Offset)  properties of the [`LabelStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html) class.

The active side of the slider is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Minimum) value and the thumb.

The inactive side of the slider is between the thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Maximum) value.

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

SfSlider slider = new SfSlider();
slider.Minimum = 2;
slider.Maximum = 10;
slider.Value = 6;
slider.Interval = 2;
slider.ShowLabels = true;
slider.ShowTicks = true;
slider.LabelStyle.ActiveTextColor = Color.FromArgb("#EE3F3F");
slider.LabelStyle.InactiveTextColor = Color.FromArgb("#F7B1AE");
slider.LabelStyle.ActiveFontSize = 16;
slider.LabelStyle.InactiveFontSize = 16;
slider.LabelStyle.ActiveFontAttributes = FontAttributes.Italic;
slider.LabelStyle.InactiveFontAttributes = FontAttributes.Italic;

{% endhighlight %}

{% endtabs %}

![Slider label style](images/labels-and-dividers/label-style.png)

## Label offset

You can adjust the space between ticks and labels of the slider using the [`Offset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_OffsetProperty) property. The default value of the [`Offset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_OffsetProperty) property is 5.0 when [`ShowTicks`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ShowTicks) enabled, otherwise it is `15.0` by default.

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

SfSlider slider = new SfSlider();
slider.Minimum = 2;
slider.Maximum = 10;
slider.Value = 6;
slider.Interval = 2;
slider.ShowLabels = true;
slider.ShowTicks = true;
slider.LabelStyle.Offset = 10;

{% endhighlight %}

{% endtabs %}

![Slider label offset](images/labels-and-dividers/label-offset.png)

## Disabled labels

You can change the state of the slider to disabled by setting `false` to the `IsEnabled` property. Using the Visual State Manager (VSM), You can customize the slider labels properties based on the visual states. The applicable visual states are enabled(default) and disabled.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <Style TargetType="sliders:SfSlider">
        <Setter Property="Interval" Value="0.25" />
        <Setter Property="ShowTicks" Value="True" />
        <Setter Property="ShowLabels" Value="True" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup>
                    <VisualState x:Name="Default">
                        <VisualState.Setters>
                            <Setter Property="LabelStyle">
                                <Setter.Value>
                                    <sliders:SliderLabelStyle ActiveTextColor = "#EE3F3F"
                                                                  InactiveTextColor="#F7B1AE"
                                                                  ActiveFontSize="16"
                                                                  InactiveFontSize="14"
                                                                  ActiveFontAttributes="Bold"
                                                                  InactiveFontAttributes="Italic"/>
                                </Setter.Value>
                            </Setter>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="LabelStyle">
                                <Setter.Value>
                                    <sliders:SliderLabelStyle ActiveTextColor = "Grey"
                                                                  InactiveTextColor="LightGrey"
                                                                  ActiveFontSize="14"
                                                                  InactiveFontSize="16"
                                                                  ActiveFontAttributes="Italic"
                                                                  InactiveFontAttributes="Bold"/>
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
        <Label Text="Enabled Slider" Padding="0,10"/>
        <sliders:SfSlider/>
        <Label Text="Disabled Slider" Padding="0,10"/>
        <sliders:SfSlider IsEnabled="False"/>
    </VerticalStackLayout>
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

VerticalStackLayout stackLayout = new VerticalStackLayout();
SfSlider defaultSlider = new SfSlider { Interval = 0.25, ShowTicks = true, ShowLabels = true };
SfSlider disabledSlider = new SfSlider { IsEnabled = false, Interval = 0.25, ShowTicks = true, ShowLabels = true };

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
    }
});
// Disabled State.
VisualState disabledState = new VisualState { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfSlider.LabelStyleProperty,
    Value = new SliderLabelStyle
    {
        ActiveFontSize = 16,
        InactiveFontSize = 14,
        ActiveTextColor = Color.FromArgb("#EE3F3F"),
        InactiveTextColor = Color.FromArgb("#F7B1AE"),
        ActiveFontAttributes = FontAttributes.Bold,
    }
});

commonStateGroup.States.Add(defaultState);
commonStateGroup.States.Add(disabledState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(defaultSlider, visualStateGroupList);
VisualStateManager.SetVisualStateGroups(disabledSlider, visualStateGroupList);

stackLayout.Children.Add(new Label() { Text = "Default Slider", Padding = new Thickness(0, 10) });
stackLayout.Children.Add(defaultSlider);
stackLayout.Children.Add(new Label() { Text = "Disabled Slider", Padding = new Thickness(0, 10) });
stackLayout.Children.Add(disabledSlider);
this.Content = stackLayout;

{% endhighlight %}

{% endtabs %}

![Slider labels disabled state](images/labels-and-dividers/labels-disabled.png)
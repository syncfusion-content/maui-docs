---
layout: post
title: Dividers in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding and customizing the slider divider feature in .NET MAUI Slider (SfDateTimeSlider) control and more.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# Dividers in .NET MAUI DateTime Slider (SfDateTimeSlider)

This section explains about how to add dividers to the date-time slider.

## Show dividers

The [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ShowDividers) property is used to render the dividers on the track. The default value of the [`ShowDividers`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ShowDividers) property is `False`. It is a shape which is used to represent the major interval points of the track.

For example, if [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Minimum) is 0.0 and [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Maximum) is 10.0 and [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Interval) is 2.0, the slider will render the dividers at 0.0, 2.0, 4.0 and so on.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2018-01-01"
                          Value="2014-01-01"
                          Interval="2"
                          ShowDividers="True" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider();
slider.Minimum = new DateTime(2010, 01, 01);
slider.Maximum = new DateTime(2018, 01, 01);
slider.Value = new DateTime(2014, 01, 01);
slider.Interval = 2;
slider.ShowDividers = true;

{% endhighlight %}

{% endtabs %}

![Slider divider](images/labels-and-dividers/divider.png)

## Divider radius

You can change the active and inactive divider radius of the slider using the [`ActiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveRadius) and the [`InactiveRadius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveRadius) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2020-01-01"
                          Value="2016-01-01"
                          Interval="2"
                          ShowDividers="True">

    <sliders:SfDateTimeSlider.DividerStyle>
        <sliders:SliderDividerStyle ActiveRadius="7"
                                    InactiveRadius="7" />
    </sliders:SfDateTimeSlider.DividerStyle>

</sliders:SfDateTimeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider();
slider.Minimum = new DateTime(2010, 01, 01);
slider.Maximum = new DateTime(2020, 01, 01);
slider.Value = new DateTime(2016, 01, 01);
slider.Interval = 2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;

{% endhighlight %}

{% endtabs %}

![Slider divider radius](images/labels-and-dividers/divider-radius.png)

## Divider stroke width and stroke color

You can change the active and inactive divider stroke width of the slider using the [`ActiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStrokeThickness) and the [`InactiveStrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStrokeThickness) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

Also, you can change the active and inactive divider stroke color of the slider using the [`ActiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveStroke) and the [`InactiveStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveStroke) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2020-01-01"
                          Value="2016-01-01"
                          Interval="2"
                          ShowDividers="True">

    <sliders:SfSlider.DividerStyle>
         <sliders:SliderDividerStyle ActiveRadius="7" 
                                     InactiveRadius="7" 
            			             ActiveStrokeThickness="2" 
				                     InactiveStrokeThickness="2" 
				                     ActiveStroke="#EE3F3F" 
				                     InactiveStroke="#F7B1AE"/>
     </sliders:SfSlider.DividerStyle>

</sliders:SfDateTimeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider();
slider.Minimum = new DateTime(2010, 01, 01);
slider.Maximum = new DateTime(2020, 01, 01);
slider.Value = new DateTime(2016, 01, 01);
slider.Interval = 2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;
slider.DividerStyle.ActiveStroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.DividerStyle.InactiveStroke = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
slider.DividerStyle.ActiveStrokeThickness = 2;
slider.DividerStyle.InactiveStrokeThickness = 2;

{% endhighlight %}

{% endtabs %}

![Slider divider stroke color](images/labels-and-dividers/divider-stroke-color.png)

## Divider color

You can change the active and inactive divider color of the slider using the [`ActiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_ActiveFill) and [`InactiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html#Syncfusion_Maui_Sliders_SliderDividerStyle_InactiveFill) properties of the [`DividerStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2010-01-01"
                          Maximum="2020-01-01"
                          Value="2016-01-01"
                          Interval="2"
                          ShowDividers="True">

    <sliders:SfSlider.DividerStyle>
       <sliders:SliderDividerStyle ActiveRadius="7" 
                                   InactiveRadius="7" 
				                   ActiveFill="#EE3F3F" 
				                   InactiveFill="#F7B1AE"/>
      </sliders:SfSlider.DividerStyle>

</sliders:SfDateTimeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider();
slider.Minimum = new DateTime(2010, 01, 01);
slider.Maximum = new DateTime(2020, 01, 01);
slider.Value = new DateTime(2016, 01, 01);
slider.Interval = 2;
slider.ShowDividers = true;
slider.DividerStyle.ActiveRadius = 7;
slider.DividerStyle.InactiveRadius = 7;
slider.DividerStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.DividerStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![Slider divider color](images/labels-and-dividers/divider-color.png)

## Disabled divider

You can change the state of the slider to disabled by setting `false` to the `IsEnabled` property. Using the Visual State Manager (VSM), you can customize the slider divider properties based on the visual states. The applicable visual states are enabled(default) and disabled.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <Style TargetType="sliders:SfDateTimeSlider">
        <Setter Property="Minimum"
                Value="2010-01-01" />
        <Setter Property="Maximum"
                Value="2018-01-01" />
        <Setter Property="Value"
                Value="2014-01-01" />
        <Setter Property="Interval" Value="2" />
        <Setter Property="ShowDividers" Value="True" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup>
                    <VisualState x:Name="Default">
                        <VisualState.Setters>
                            <Setter Property="DividerStyle">
                                <Setter.Value>
                                    <sliders:SliderDividerStyle ActiveFill = "#F7B1AE"
                                                                    InactiveFill="#EE3F3F"
                                                                    ActiveRadius="5"
                                                                    InactiveRadius="4"/>
                                </Setter.Value>
                            </Setter>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="DividerStyle">
                                <Setter.Value>
                                    <sliders:SliderDividerStyle ActiveFill = "grey"
                                                                    InactiveFill="LightGrey"
                                                                    ActiveRadius="5"
                                                                    InactiveRadius="4"/>
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
        <sliders:SfDateTimeSlider/>
        <Label Text="Disabled Slider" Padding="0,10"/>
        <sliders:SfDateTimeSlider IsEnabled="False"/>
    </VerticalStackLayout>
</ContentPage.Content>

{% endhighlight %}

{% highlight C# %}

VerticalStackLayout stackLayout = new VerticalStackLayout();
SfDateTimeSlider defaultSlider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2020, 01, 01),
    Value = new DateTime(2014, 01, 01),
    Interval = 2, 
    ShowDividers = true
};
SfDateTimeSlider disabledSlider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2010, 01, 01),
    Maximum = new DateTime(2020, 01, 01),
    Value = new DateTime(2014, 01, 01),
    IsEnabled = false, 
    Interval = 2, 
    ShowDividers = true
};

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();
// Default State.
VisualState defaultState = new VisualState { Name = "Default" };
defaultState.Setters.Add(new Setter
{
    Property = SfDateTimeSlider.DividerStyleProperty,
    Value = new SliderDividerStyle
    {
        ActiveFill = Color.FromArgb("#F7B1AE"),
        InactiveFill = Color.FromArgb("#EE3F3F"),
        ActiveRadius = 5,
        InactiveRadius = 4,
    }
});
// Disabled State.
VisualState disabledState = new VisualState { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfDateTimeSlider.DividerStyleProperty,
    Value = new SliderDividerStyle
    {
        ActiveFill = Colors.Grey,
        InactiveFill = Colors.LightGrey,
        ActiveRadius = 5,
        InactiveRadius = 4,
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

![Slider divider disabled state](images/labels-and-dividers/divider-disabled.png)
---
layout: post
title: Visual States in .NET MAUI Button Control | Syncfusion®
description: Learn about visual states support in the Syncfusion® .NET MAUI Button (SfButton) control and how to customize each state.
platform: maui
control: SfButton
documentation: ug
---

# Visual States in .NET MAUI Button (SfButton)

Visual states let you change the appearance of [.NET MAUI Button](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) in response to user interaction. Use them to apply different colors, borders, or other properties for each state without writing code-behind handlers.

`SfButton` supports the following visual states through the [`VisualStateManager`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/visual-states?view=net-maui-10.0):

* `Normal` - The default resting state of the button.
* `Hovered` - The pointer is over the button (desktop platforms).
* `Pressed` - The button is being tapped or clicked.
* `Checked` - The button is in the checked state. Only applied when [`IsCheckable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_IsCheckable) is `true`.
* `Disabled` - The button is disabled (`IsEnabled` is `false`).

N> The `Checked` and `Unchecked` states are only applied when the `IsCheckable` property is set to `true`. The [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_IsChecked) property controls the current check state. Listen for the `CheckedChanged` event to react to state changes.

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

## Defining visual states

`SfButton` exposes its states through a single `VisualStateGroup` named `CommonStates`. Each `VisualState` contains a list of `Setter` objects that target bindable properties on the Button. Common target properties are `Background`, `TextColor`, `Stroke`, `StrokeThickness`, and `CornerRadius`.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                  Text="SfButton"
                  HeightRequest="50"
                  WidthRequest="200"
                  TextColor="White"
                  IsEnabled="True"
                  IsCheckable="True"
                  IsChecked="True">
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup x:Name="CommonStates">
            <VisualState x:Name="Normal">
                <VisualState.Setters>
                    <Setter Property="Background" 
                            Value="#6A4C9C" />
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Checked">
                <VisualState.Setters>
                    <Setter Property="Background" 
                            Value="#008000" />
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Hovered">
                <VisualState.Setters>
                    <Setter Property="Background" 
                            Value="DeepSkyBlue" />
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Pressed">
                <VisualState.Setters>
                    <Setter Property="Background" 
                            Value="MediumVioletRed" />
                </VisualState.Setters>
            </VisualState>
            <VisualState x:Name="Disabled">
                <VisualState.Setters>
                    <Setter Property="Background" 
                            Value="#BFC3C7" />
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</buttons:SfButton>

{% endhighlight %}
{% highlight c# %}

InitializeComponent();
SfButton button = new SfButton
{
    Text = "SfButton",
    HeightRequest = 50,
    WidthRequest = 200,
    TextColor = Colors.White,
    IsEnabled = true,
    IsCheckable = true,
    IsChecked = true,
};
VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState normalState = new VisualState { Name = "Normal" };
normalState.Setters.Add(new Setter
{
    Property = SfButton.BackgroundProperty,
    Value = Color.FromArgb("#6A4C9C")
});

VisualState checkedState = new VisualState { Name = "Checked" };
checkedState.Setters.Add(new Setter
{
    Property = SfButton.BackgroundProperty,
    Value = Colors.Green
});

VisualState hoveredState = new VisualState { Name = "Hovered" };
hoveredState.Setters.Add(new Setter
{
    Property = SfButton.BackgroundProperty,
    Value = Colors.DeepSkyBlue
});

VisualState pressedState = new VisualState { Name = "Pressed" };
pressedState.Setters.Add(new Setter
{
    Property = SfButton.BackgroundProperty,
    Value = Colors.MediumVioletRed
});

VisualState disabledState = new VisualState { Name = "Disabled" };
disabledState.Setters.Add(new Setter
{
    Property = SfButton.BackgroundProperty,
    Value = Color.FromArgb("#BFC3C7")
});

commonStateGroup.States.Add(normalState);
commonStateGroup.States.Add(checkedState);
commonStateGroup.States.Add(hoveredState);
commonStateGroup.States.Add(pressedState);
commonStateGroup.States.Add(disabledState);
visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(button, visualStateGroupList);
Content = button;

{% endhighlight %}
{% endtabs %}

The following image shows the `Button` with the visual states applied:

![SfButton visual states](Images/visual-states/VisualStates.png)

## See Also

- [Customization](https://help.syncfusion.com/maui/button/customization)
- [Right-to-Left](https://help.syncfusion.com/maui/button/right-to-left)
- [Liquid Glass Effect](https://help.syncfusion.com/maui/button/liquidglasssupport)
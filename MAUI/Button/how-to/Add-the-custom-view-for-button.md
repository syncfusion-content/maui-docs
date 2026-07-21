---
layout: post
title: How to Add a Custom View to a .NET MAUI Button (SfButton)
description: Learn how to add a custom view to the Syncfusion® .NET MAUI Button (SfButton) control.
platform: maui
control: SfButton
documentation: ug
---

# How to Add a Custom View to a Button (SfButton)

You can replace the default text of [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) with any custom view by setting the [`Content`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_Content) property. This is useful for adding spinners, icons, or any composite layout inside the button. This page shows how to add a Syncfusion `SfBusyIndicator` and a label as a custom view.

N> When the `Content` property is set, the `Text`, `ImageSource`, and `ShowIcon` properties are not rendered. To toggle between a loading state and a normal state, swap the `Content` at runtime or use a `Grid` with overlapping views and toggle their `IsVisible`.

## Prerequisites

Before using the [SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/button/getting-started) documentation.

## Add a Custom View with a Busy Indicator

The following code samples show how to set the `Content` of `SfButton` to a horizontal layout that contains a `SfBusyIndicator` and a `Label`.

### XAML

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <buttons:SfButton CornerRadius="10" 
                      Text="SfButton" 
                      Background="#4125BC">
        <buttons:SfButton.Content>
            <DataTemplate>
                <HorizontalStackLayout Spacing = "8" Padding="5">
                    <ActivityIndicator Color = "White" IsRunning="True"/>
                    <Label Text = "Loading..." 
                            VerticalOptions="Center" 
                            TextColor="White"/>
                </HorizontalStackLayout>
            </DataTemplate>
        </buttons:SfButton.Content>
    </buttons:SfButton>
</VerticalStackLayout>

{% endhighlight %}
{% highlight c# %}

var customTemplate = new DataTemplate(() =>
{
    var activityIndicator = new ActivityIndicator
    {
        Color = Colors.White,
        IsRunning = true
    };
    var label = new Label
    {
        Text = "Loading...",
        TextColor = Colors.White,
        VerticalOptions = LayoutOptions.Center
    };
    var stackLayout = new HorizontalStackLayout
    {
        Spacing = 8,
        Padding = new Thickness(5)
    };
    stackLayout.Children.Add(activityIndicator);
    stackLayout.Children.Add(label);
    return stackLayout;
});
SfButton button = new SfButton
{
    Text = "SfButton",
    Background = Color.FromArgb("#4125BC"),
    CornerRadius= 10,
    Content = customTemplate
};

Content = new VerticalStackLayout
{
    Children = { button }
};

{% endhighlight %}
{% endtabs %}

![SfButton with custom view](images/button-content.png)

N> Setting `Content = null` restores the default behavior of the button (rendering `Text`, `ImageSource`, and `ShowIcon` if they are set).

## Compatibility

| Platform | Notes |
|----------|-------|
| .NET MAUI | Requires .NET MAUI 7.0 or later. |
| iOS, macOS, Android, Windows | Custom views are supported on all .NET MAUI target platforms. |

## Troubleshooting

| Issue | Possible cause | Fix |
|------|---------------|-----|
| The custom view is not visible after setting `Content`. | The `Text` property is still set, which is rendered instead of the custom view. | Clear the `Text` property (or do not set it) when assigning `Content`. |
| The `SfBusyIndicator` does not animate. | `IsRunning` is `false`, or the handler is not registered. | Set `IsRunning="True"` and ensure `Syncfusion.Maui.Core` is registered in `MauiProgram.CreateMauiApp`. |
| The button is not clickable when the custom view is set. | The custom view consumed the tap gesture. | Wrap the content in a container that does not intercept input (such as a `HorizontalStackLayout` without a `TapGestureRecognizer`). |
| `Content` assignment does not compile. | You assigned a `DataTemplate` to a `View`-typed property. | Assign a `View` (for example, a `Layout`) directly to `Content`, or use a `ControlTemplate` if you need template-based behavior. |

## See Also

- [Getting Started](https://help.syncfusion.com/maui/button/getting-started)
- [Customization](https://help.syncfusion.com/maui/button/customization)

---
layout: post
title: Customize Stroke Thickness in .NET MAUI SfTextInputLayout | Syncfusion®
description: Learn how to customize the focused and unfocused stroke thickness of the Syncfusion® .NET MAUI SfTextInputLayout control for each container type.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui textinputlayout stroke thickness, syncfusion text input layout focused stroke maui, sftextinputlayout unfocused stroke thickness maui, .net maui text input layout border width, sftextinputlayout outlined stroke maui
---

# Customize the stroke thickness in .NET MAUI SfTextInputLayout

The stroke thickness of the [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) container changes based on the focus state of the input view. Use the [FocusedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_FocusedStrokeThickness) and [UnfocusedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_UnfocusedStrokeThickness) properties to control the thickness in each state.

## Prerequisites

Before using the [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/textinputlayout/getting-started) documentation.

## Property Reference

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `FocusedStrokeThickness` | `double` | `2` | Stroke thickness in device-independent units when the input view is focused. |
| `UnfocusedStrokeThickness` | `double` | `1` | Stroke thickness in device-independent units when the input view is not focused. |

The property names are the same for every container type, but the visual effect differs:

| Container Type | Visual Effect |
|----------------|---------------|
| [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined) | Controls the width of the rounded border around the input view. |
| [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled) | Controls the thickness of the bottom line of the container. |
| [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_None) | Controls the thickness of the bottom line. |

## Set the stroke thickness

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <inputLayout:SfTextInputLayout Hint="Name"
                                   ContainerType="Outlined"
                                   FocusedStrokeThickness="4"
                                   UnfocusedStrokeThickness="2">
        <Entry />
    </inputLayout:SfTextInputLayout>
</VerticalStackLayout>

{% endhighlight %}
{% highlight C# %}

var inputLayout = new SfTextInputLayout
{
    Hint = "Name",
    ContainerType = ContainerType.Outlined,
    FocusedStrokeThickness = 4,
    UnfocusedStrokeThickness = 2,
    Content = new Entry()
};
Content = new VerticalStackLayout
{
    Children =
    {
        inputLayout
    }
};

{% endhighlight %}
{% endtabs %}

![Outlined SfTextInputLayout with a 4-unit focused stroke and a 2-unit unfocused stroke](images/HowTo/StrokeThickness.png)

## Troubleshooting

| Issue | Possible Cause | Recommended Action |
|-------|----------------|--------------------|
| The stroke thickness has no effect. | The control is not in the expected container type, or the property is set to `0` and is being clamped to a minimum. | Verify `ContainerType` is `Outlined`, `Filled`, or `None`, and set a positive value. |
| The focused stroke looks the same as the unfocused stroke. | `FocusedStrokeThickness` equals `UnfocusedStrokeThickness`, or the input view never receives focus. | Set distinct values (for example, `4` and `2`) and verify focus by tapping the input view. |
| The stroke is too thick and overlaps the hint label. | `FocusedStrokeThickness` is set to a value larger than the container padding. | Reduce `FocusedStrokeThickness` or increase the container padding. |

## See Also

- [Getting Started with .NET MAUI SfTextInputLayout](https://help.syncfusion.com/maui/textinputlayout/getting-started)
- [Container Types](https://help.syncfusion.com/maui/textinputlayout/container-type)
- [Assistive Label](https://help.syncfusion.com/maui/textinputlayout/assistive-labels)

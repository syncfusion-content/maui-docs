---
layout: post
title: Fixed Hint Position in .NET MAUI SfTextInputLayout | Syncfusion®
description: Learn how to keep the hint label always at the top (always-floated) position in the Syncfusion® .NET MAUI SfTextInputLayout control.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui textinputlayout ishintalwaysfloated, syncfusion text input layout fixed hint maui, sftextinputlayout always floated hint maui, .net maui text input layout hint position, sftextinputlayout hint floating maui
---

# Fixed Hint Position in .NET MAUI SfTextInputLayout

By default, the hint label in [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) floats to the top of the input line only when the input view is focused or contains a value. When the input is empty and unfocused, the hint sits in the input line as a placeholder. Set the [IsHintAlwaysFloated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsHintAlwaysFloated) property to `true` to keep the hint label permanently at the top, regardless of focus or value state.

## Prerequisites

Before using the [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/textinputlayout/getting-started) documentation.

N> The default value of `IsHintAlwaysFloated` is `false`.

## Behavior Summary

| `IsHintAlwaysFloated` | Hint Position When Empty and Unfocused | Hint Position When Focused or Has Value |
|----------------------|----------------------------------------|----------------------------------------|
| `false` (default) | Inside the input line as a placeholder. | Floated at the top. |
| `true` | Floated at the top. | Floated at the top. |

The floated-hint behavior applies to all three container types (Filled, Outlined, and None). The following examples show the same configuration applied to each.

## Always-floated hint with Filled container

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Name"
                                IsHintAlwaysFloated="True"
                                ContainerType="Filled">
    <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

SfTextInputLayout inputLayout = new SfTextInputLayout
{
    Hint = "Name",
    IsHintAlwaysFloated = true,
    ContainerType = ContainerType.Filled,
    Content = new Entry()
};

{% endhighlight %}
{% endtabs %}

![Filled SfTextInputLayout with the hint label always floated at the top](images/FixedHintPosition/HintPositionFilled.png)

## Always-floated hint with Outlined container

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Name"
                                IsHintAlwaysFloated="True"
                                ContainerType="Outlined">
    <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

SfTextInputLayout inputLayout = new SfTextInputLayout
{
    Hint = "Name",
    IsHintAlwaysFloated = true,
    ContainerType = ContainerType.Outlined,
    Content = new Entry()
};

{% endhighlight %}
{% endtabs %}

![Outlined SfTextInputLayout with the hint label always floated at the top](images/FixedHintPosition/HintPositionOutlined.png)

## Always-floated hint with None container

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Name"
                                IsHintAlwaysFloated="True"
                                ContainerType="None">
    <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

SfTextInputLayout inputLayout = new SfTextInputLayout
{
    Hint = "Name",
    IsHintAlwaysFloated = true,
    ContainerType = ContainerType.None,
    Content = new Entry()
};

{% endhighlight %}
{% endtabs %}

![None-container SfTextInputLayout with the hint label always floated at the top](images/FixedHintPosition/HintPositionNone.png)

## Troubleshooting

| Issue | Possible Cause | Recommended Action |
|-------|----------------|--------------------|
| The hint is not staying at the top. | `IsHintAlwaysFloated` is `false` (the default), so the hint returns to the input line when the input is empty and unfocused. | Set `IsHintAlwaysFloated = true`. |
| The hint overlaps the input value. | The font size of the hint and the input value is too large for the container height. | Reduce the `FontSize` of the hint via `HintLabelStyle` or increase the container height. |
| The floated hint is clipped. | The container type does not reserve space for the floated hint. | Switch to `Outlined` or `Filled`, or use a larger `ContainerBackground`. |

## See Also

- [Container Types](https://help.syncfusion.com/maui/textinputlayout/container-type)
- [Assistive Labels](https://help.syncfusion.com/maui/textinputlayout/assistive-labels)
- [Custom Font](https://help.syncfusion.com/maui/textinputlayout/custom-font)
- [IsHintAlwaysFloated API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsHintAlwaysFloated)
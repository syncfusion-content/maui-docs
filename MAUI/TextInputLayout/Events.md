---
layout: post
title: Events in .NET MAUI SfTextInputLayout | Syncfusion®
description: Learn about the events raised by the Syncfusion® .NET MAUI SfTextInputLayout control, including the PasswordVisibilityToggled event.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui textinputlayout events, syncfusion text input layout password toggled maui, sftextinputlayout passwordvisibilitytoggled maui, .net maui text input layout eventargs, sftextinputlayout ispasswordvisible maui
---

# Events in .NET MAUI SfTextInputLayout

[SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) raises events to notify your application when the user interacts with the control. This page documents the events exposed directly by `SfTextInputLayout`. For events on the inner input view (such as `TextChanged`, `Focused`, and `Unfocused`), refer to the [MAUI Entry documentation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry).

## Prerequisites

Before using the [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/textinputlayout/getting-started) documentation.

## Supported Events

| Event | Trigger | EventArgs |
|-------|---------|-----------|
| [PasswordVisibilityToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_PasswordVisibilityToggled) | Raised when the user taps the password visibility toggle icon. | [PasswordVisibilityToggledEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.PasswordVisibilityToggledEventArgs.html) |

N> The `PasswordVisibilityToggled` event fires only when [EnablePasswordVisibilityToggle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_EnablePasswordVisibilityToggle) is `true`. If the toggle is disabled, the icon is not rendered and the event is never raised.

## Password visibility toggled event

The `PasswordVisibilityToggled` event fires when the user taps the password visibility toggle icon. The handler receives the `SfTextInputLayout` instance as the `sender` and a `PasswordVisibilityToggledEventArgs` instance.

### Event Arguments

| Property | Type | Description |
|----------|------|-------------|
| [IsPasswordVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.PasswordVisibilityToggledEventArgs.html#Syncfusion_Maui_Core_PasswordVisibilityToggledEventArgs_IsPasswordVisible) | `bool` | `true` when the password is currently visible (shown in plain text); `false` when the password is hidden. The event fires after the visibility state has changed, so the value reflects the new state. |

{% tabs %}
{% highlight xaml %}

<VerticalStackLayout>
    <inputLayout:SfTextInputLayout Hint="Password"
                                   EnablePasswordVisibilityToggle="True"
                                   PasswordVisibilityToggled="OnPasswordVisibilityToggled">
        <Entry />
    </inputLayout:SfTextInputLayout>
</VerticalStackLayout>

{% endhighlight %}
{% highlight C# %}

var inputLayout = new SfTextInputLayout
{
    Hint = "Password",
    EnablePasswordVisibilityToggle = true,
    Content = new Entry { IsPassword = true }
};
Content = new VerticalStackLayout
{
    Children =
    {
        inputLayout
    }
};

inputLayout.PasswordVisibilityToggled += OnPasswordVisibilityToggled;

void OnPasswordVisibilityToggled(object? sender, PasswordVisibilityToggledEventArgs e)
{
    bool isPasswordVisible = e.IsPasswordVisible;
    if (sender is SfTextInputLayout layout)
    {
        layout.ShowHint = !isPasswordVisible;
    }
}

{% endhighlight %}
{% endtabs %}

## Troubleshooting

| Issue | Possible Cause | Recommended Action |
|-------|----------------|--------------------|
| The `PasswordVisibilityToggled` event never fires. | `EnablePasswordVisibilityToggle` is `false`, or the inner control is not an `Entry`. | Set `EnablePasswordVisibilityToggle = true` and ensure the inner control is `Entry`. |
| `e.IsPasswordVisible` always reports the same value. | The handler is caching the value, or the visibility state did not change. | Read the value from `e.IsPasswordVisible` inside the handler; do not store it across invocations. |
| The handler is not invoked from XAML. | The event handler name in the XAML attribute does not match the method name in the code-behind. | Verify the `PasswordVisibilityToggled="OnPasswordVisibilityToggled"` attribute matches the method signature `void OnPasswordVisibilityToggled(object? sender, PasswordVisibilityToggledEventArgs e)`. |

## See Also

- [Assistive Labels](https://help.syncfusion.com/maui/textinputlayout/assistive-labels)
- [Container Types](https://help.syncfusion.com/maui/textinputlayout/container-type)
- [Custom Icons](https://help.syncfusion.com/maui/textinputlayout/custom-icons)
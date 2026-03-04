---
layout: post
title: Liquid glass effect in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about liquid glass effect in Syncfusion® .NET MAUI Tab View (SfTabView) control, its elements, and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Platform Specifics - Liquid Glass Effect

This page documents `SfTabView` behavior or properties that are explicitly platform-scoped in the source.

## Members involved

| Member | Kind | Type | Default/Mode | Purpose |
|---|---|---|---|---|
| `SfTabView.EnableLiquidGlassEffect` | Bindable property | `bool` | Default: `false` | Enables the “liquid glass” effect on Apple platforms only. |

## Scenario: Enable liquid glass effect (iOS/macOS only)

The `EnableLiquidGlassEffect` property is documented in the control source as supported only on **iOS** and **macOS (MacCatalyst)**.

### XAML

```xml
<tabView:SfTabView
    xmlns:tabView="http://schemas.syncfusion.com/maui"
    EnableLiquidGlassEffect="{OnPlatform iOS=true, MacCatalyst=true, Default=false}">

    <tabView:SfTabItem Header="One">
        <tabView:SfTabItem.Content>
            <Label Padding="16" Text="One" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>

</tabView:SfTabView>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

var tabView = new SfTabView();

#if IOS || MACCATALYST
tabView.EnableLiquidGlassEffect = true;
#else
tabView.EnableLiquidGlassEffect = false;
#endif
```

> **Important:** Keep the property disabled on unsupported platforms.

## See also

- Customization & Theming: `customization-theming.md`
- API reference: `../api/api-reference.md`

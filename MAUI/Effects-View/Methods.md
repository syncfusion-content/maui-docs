---
layout: post
title: Methods in .NET MAUI Effects View Control | Syncfusion®
description: Learn here all about methods support in Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Methods in .NET MAUI Effects View (SfEffectsView)

Effects can be applied and removed programmatically using the [ApplyEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ApplyEffects_Syncfusion_Maui_Core_SfEffects_Syncfusion_Maui_Core_RippleStartPosition_System_Nullable_System_Drawing_Point__System_Boolean_) or [Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset) methods.

## ApplyEffects

The [ApplyEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ApplyEffects_Syncfusion_Maui_Core_SfEffects_Syncfusion_Maui_Core_RippleStartPosition_System_Nullable_System_Drawing_Point__System_Boolean_) method triggers effects rendering with or without repetition. The following are the optional parameters:

* `effects` - [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html) to be applied. By default, [SfEffects.Ripple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Ripple) will be applied.
* `rippleStartPosition` - [RippleStartPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.RippleStartPosition.html) can be left, top, right, bottom, top left, top right, bottom left, bottom right or default. By default, the ripple starts from the center.
* `rippleStartPoint` - Point at which ripple animation starts. The default value is null.
* `repeat` - Boolean value used to set whether to repeat the applied effect. The default value is false. Only [SfEffects.Ripple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Ripple) can be repeated.

N> The [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html) applied using the [ApplyEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ApplyEffects_Syncfusion_Maui_Core_SfEffects_Syncfusion_Maui_Core_RippleStartPosition_System_Nullable_System_Drawing_Point__System_Boolean_) method will not be removed automatically.

## Reset

The [Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset) method is used to reset the [SfEffects.Highlight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Highlight) and [SfEffects.Ripple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Ripple) effects, which are applied using the `ApplyEffects` method.

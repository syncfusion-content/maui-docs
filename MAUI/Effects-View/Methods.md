---
layout: post
title: Methods in .NET MAUI Effects View control | Syncfusion
description: Learn here all about Methods support in Syncfusion .NET MAUI Effects View (SfEffectsView) control and more.
platform: maui
control: Effects View
documentation: ug
---

# Methods in .NET MAUI Effects View (SfEffectsView)

Effects can be applied and removed programmatically using the `ApplyEffects` or `Reset` method.

## ApplyEffects

The `ApplyEffects` method is used to trigger the effects rendering with or without repetition. The following are the optional parameters to be passed:

* `effects` - `SfEffects` to be applied. By default, `SfEffects.Ripple` will be applied.
* `rippleStartPosition` - `RippleStartPosition` can be left, top, right, bottom, top left, top right, bottom left, bottom right or default. By default, ripple starts from the center.
* `rippleStartPoint` - point at which ripple animation starts. The default value is null.
* `repeat` - bool value used to set whether to repeat the applied effect. The default value is false. Only `SfEffects.Ripple` can be repeated.

N> The `SfEffects` applied using `ApplyEffects` method will not be removed automatically.

## Reset

The `Reset` method is used to reset the `SfEffects.Highlight` and `SfEffects.Ripple` effects, which are applied using the `ApplyEffects` method.

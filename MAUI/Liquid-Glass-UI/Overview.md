---
layout: post
title: Applying Liquid Glass UI to Syncfusion® Controls
description: This section explains liquid glass effect in Syncfusion® controls.
platform: MAUI
control: General
documentation: UG
---

# Overview of Liquid Glass Visual Effect in Syncfusion Controls

Syncfusion provides Liquid Glass visual effect support to their .NET MAUI controls. This feature introduces a modern translucent appearance that enhances the user interface by creating a smooth, frosted-glass look which blends seamlessly with background content.

## Ways to Apply Liquid Glass Effect

**Built-in support**: Some Syncfusion MAUI controls include built-in Liquid Glass effect support. To enable, simply set the property `EnableLiquidGlassEffect` to true on the respective control.

**Sample-level customization**: For other controls, the effect can be achieved by wrapping them with the SfGlassEffectsView container.
* The view provides two effect types:
    *  `Clear`: Produces a sharper, more transparent glass-like appearance.
    *  `Regular`: Creates a softer, frosted look with subtle diffusion.

## Supported Platforms

* Liquid Glass UI support is currently available only on macOS and iOS platforms.
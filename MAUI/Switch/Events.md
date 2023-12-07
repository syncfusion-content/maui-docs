---
layout: post
title: Events in .NET MAUI Switch Control | Syncfusion
description: Learn about Event support in the Syncfusion .NET MAUI Switch control, its elements and more.
platform: .NET MAUI
control: SfSwitch
documentation: ug
---

# Events in .NET MAUI Switch

This section provides information about the events available in the .NET MAUI Switch control.

## StateChanged event

The StateChanged event occurs when the value or state of [`IsOn`] property is changed by tapping the switch button or setting a value to [`IsOn`] property. The [`SwitchStateChangedEventArgs`] provides the following properties:

* [`NewValue`] : Gets the current value of the Switch control.
* [`OldValue`] : Gets the previous value of the Switch control.

## StateChanging event

The StateChanging event occurs when the state of [`IsOn`] property is about to change in the Switch control. The [`SwitchStateChangingEventArgs`] provides the following properties:

* [`NewValue`] : Gets the current value of the Switch control.
* [`OldValue`] : Gets the previous value of the Switch control.
* [`Cancel`] : Gets or sets a value indicating whether the event should be canceled.

![.NET MAUI Switch]
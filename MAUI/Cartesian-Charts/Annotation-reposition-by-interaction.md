---
layout: post
title: Annotation Drag and Drop (Reposition) by interaction in .NET MAUI Cartesian Chart | Syncfusion
description: Learn how to enable annotation interaction in Syncfusion® .NET MAUI Chart (SfCartesianChart) control to drag, reposition, and customize annotations dynamically.
platform: maui
control: SfCartesianChart
documentation: ug
Keywords: .net maui chart annotation interaction, .net maui chart annotation drag and drop, sfCartesianChart annotation interaction in .net maui, .net maui chart annotation customization.
---

# Annotation Drag and Drop (Reposition) by interaction in .NET MAUI Cartesian Chart

The annotation interaction feature in the .NET MAUI Cartesian Chart allows users to **drag and reposition annotations** such as **Text annotation**, **Shape annotations**, and **View annotation** within the chart area, making data visualization more interactive and dynamic.

To enable drag-and-drop functionality, implement a custom annotation class that inherits from Syncfusion annotation types and override the following touch interaction methods:

* **OnTouchDown** – Triggered when touch starts on the annotation. Converts the screen pixel coordinates to axis values using the chart’s `PointToValue` method to prepare for repositioning.

* **OnTouchMove** – Triggered when moving (dragging) the finger or mouse across the annotation. Calculates the difference between the current and previous touch positions and applies these changes to the annotation’s position properties (`X1`, `Y1`, `X2`, `Y2`). The position is clamped within the chart bounds to prevent moving outside the visible area.

* **OnTouchUp** – Triggered when touch ends by lifting the finger or releasing the mouse from* **OnTouchUp** – Triggered when touch ends by lifting the finger or releasing the mouse from the annotation. Completes the drag operation and finalizes the annotation’s new position.

These methods together provide smooth drag-and-drop repositioning for annotations.

![Annotation Drag and Drop (Reposition) by interaction in .NET MAUI Cartesian Chart](How-to_images/MAUI_Annotation_Drag_And_Drop.gif)

## See also

[How to drag and drop the annotation in .NET MAUI Cartesian Chart?](https://support.syncfusion.com/agent/kb/22185)
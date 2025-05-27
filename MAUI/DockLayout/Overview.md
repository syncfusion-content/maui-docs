---
layout: post
title: About .NET MAUI DockLayout control | Syncfusion
description: Learn about the introduction of Syncfusion .NET MAUI SfDockLayout control and its key features.
platform: MAUI
control: SfDockLayout
documentation: ug
---

# .NET MAUI SfDockLayout Overview

The [SfDockLayout]() control in .NET MAUI is a flexible and powerful layout panel that arranges its child elements by docking them to the edges of the container — top, bottom, left, right or none.

Child elements are docked in the order they are declared, and the layout automatically arranges them accordingly. The [ShouldLastChildFill]() property allows the last child to occupy any remaining space, making it easier to create responsive and adaptive UIs.

This layout is ideal for creating structured UIs such as toolbars, navigation drawers, headers and footers, side panels, and main content regions. It helps you build adaptive layouts by aligning elements to specific sides while optionally allowing the remaining space to be filled by a central view.

## Key features

### DockPosition
With the `SfDockLayout.Dock` attached property, child elements can be precisely positioned along the desired edges—top, bottom, left, right or none. This feature provides unparalleled control over element alignment, essential for creating well-structured UIs.

### Adaptive Expansion of Last Child
Through the `[ShouldLastChildFill]` property, the layout can automatically expand the last child element to occupy any unutilized area within the container. This feature is crucial for dynamic layout designs that require fluid adaptability across different screen sizes and orientations.

### Customizable Spacing
The control also supports customizable spacing between docked elements, allowing developers to manage the layout's aesthetic by adjusting horizontal and vertical spaces as needed.
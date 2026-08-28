---
layout: post
title: Annotation API in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members for Annotations in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Annotations API Reference for .NET MAUI Cartesian Chart

This page lists the public properties, methods, and events of shape, line, text, and view annotations.

<table>
<tr>
    <th>Class</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAnnotation.html" aria-label="View ChartAnnotation class in API reference">ChartAnnotation</a></td>
    <td>Members declared by <code>ChartAnnotation</code>, the <code>abstract base class</code> for every annotation. Covers the common <code>placement options</code> shared by all annotations: <code>X1</code>, <code>Y1</code> (primary coordinates when not specified as a label), <code>X2</code>, <code>Y2</code> (secondary coordinates for lines and arrows), <code>CoordinateUnit</code> (pixel or axis), <code>AnnotationLayer</code> (rendering order below or above series), <code>horizontal</code> and <code>vertical alignment</code>, <code>stroke</code> and <code>fill brushes</code>, <code>stroke dash pattern</code>, <code>stroke width</code>, <code>margin</code>, and <code>visibility-related properties</code>. <code>Specific-extent coordinates</code> allow pinning to an <code>axis value</code> or to a <code>screen pixel</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EllipseAnnotation.html" aria-label="View EllipseAnnotation class in API reference">EllipseAnnotation</a></td>
    <td>Members declared by <code>EllipseAnnotation</code>, the <code>circle-specific shape annotation</code>. Typically extends <code>ShapeAnnotation</code> with just the inherited <code>fill</code>, <code>stroke</code>, and <code>bounds</code>, because the ellipse is fully defined by its <code>bounding box</code>. Use to highlight a single <code>x-y point</code> on the plot with a <code>circular overlay</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.HorizontalLineAnnotation.html" aria-label="View HorizontalLineAnnotation class in API reference">HorizontalLineAnnotation</a></td>
    <td>Members declared by <code>HorizontalLineAnnotation</code>, a <code>horizontal line</code> at a <code>y-axis value</code> that spans the <code>plot area</code>. Typically adds an <code>Y</code> (or <code>Y1</code>) coordinate property and may add a <code>label position</code> or <code>text alignment</code>. Use to draw <code>threshold</code> or <code>reference lines</code> along the y-axis.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LineAnnotation.html" aria-label="View LineAnnotation class in API reference">LineAnnotation</a></td>
    <td>Members declared by <code>LineAnnotation</code>, covering <code>line-specific stroke customization</code> and <code>label customization</code>, including <code>Stroke</code>, <code>StrokeThickness</code>, <code>StrokeDashArray</code>, optional <code>arrowheads</code> (such as <code>StartArrow</code>, <code>EndArrow</code>), and the <code>text label positioning</code>. Use to draw a <code>line</code> between two coordinates (<code>X1</code>, <code>Y1</code>) and (<code>X2</code>, <code>Y2</code>) on the <code>plot area</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ShapeAnnotation.html" aria-label="View ShapeAnnotation class in API reference">ShapeAnnotation</a></td>
    <td>Members declared by <code>ShapeAnnotation</code>, the <code>abstract base class</code> for <code>filled shape annotations</code> such as <code>EllipseAnnotation</code>, <code>RectangleAnnotation</code>, and <code>ViewAnnotation</code>. Covers the common <code>shape options</code>: <code>Fill</code>, <code>Stroke</code>, <code>StrokeThickness</code>, <code>width</code>, <code>height</code>, <code>alignment</code>, and <code>view bounds</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TextAnnotation.html" aria-label="View TextAnnotation class in API reference">TextAnnotation</a></td>
    <td>Members declared by <code>TextAnnotation</code>, covering <code>text-specific options</code>: <code>text content</code>, <code>label style</code> (font, color, size, background, padding), <code>text alignment</code>, and <code>label position</code> relative to a coordinate. Use to overlay a <code>text callout</code> at a single <code>x-y point</code> on the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.VerticalLineAnnotation.html" aria-label="View VerticalLineAnnotation class in API reference">VerticalLineAnnotation</a></td>
    <td>Members declared by <code>VerticalLineAnnotation</code>, a <code>vertical line</code> at an <code>x-axis value</code> that spans the <code>plot area</code>. Typically adds an <code>X</code> (or <code>X1</code>) coordinate property and may add a <code>label position</code> or <code>text alignment</code>. Use to draw <code>threshold</code>, <code>signal</code>, or <code>divider lines</code> along the x-axis.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ViewAnnotation.html" aria-label="View ViewAnnotation class in API reference">ViewAnnotation</a></td>
    <td>Members declared by <code>ViewAnnotation</code>, which embeds an arbitrary MAUI <code>View</code> (such as a <code>layout</code>, <code>button</code>, <code>image</code>, or <code>custom control</code>) inside the chart at a coordinate. Covers the <code>View content property</code> and a <code>binding</code> or <code>content template</code>. Use to attach <code>rich interactive pieces</code>, such as <code>buttons</code> or <code>images</code>, at a <code>chart location</code>.</td>
</tr>
</table>

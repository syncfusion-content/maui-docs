---
layout: post
title: Trendlines in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members of the control, grouped into focused reference pages available in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) API.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Trendlines API in .NET MAUI Cartesian Chart

This page lists the public properties, methods, and events of trendlines and the individual trendline types.

## Classes on this page

<table>
<tr>
    <th>Class</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ExponentialTrendline.html" aria-label="View ExponentialTrendline class in API reference">ExponentialTrendline</a></td>
    <td>Members of the <code>exponential trendline</code>, including the inherited properties from <code>ChartTrendline</code> (such as <code>BackwardForecast</code>, <code>ForwardForecast</code>, <code>Stroke</code>, <code>StrokeWidth</code>, <code>MarkerSettings</code>, <code>ShowMarkers</code>, <code>Label</code>, and <code>tooltip</code>/<code>trackball</code> properties) plus the type-specific <code>Intercept</code> property that exposes the calculated <code>y-axis intercept</code> of the fitted <code>exponential curve</code>. Use this trendline for data that <code>grows</code> or <code>decays</code> at a constant percentage rate.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LinearTrendline.html" aria-label="View LinearTrendline class in API reference">LinearTrendline</a></td>
    <td>Members of the <code>linear trendline</code>, including the inherited properties from <code>ChartTrendline</code> plus the type-specific <code>Intercept</code> property that exposes the calculated <code>y-axis intercept</code> of the fitted <code>straight line</code>. Use this trendline for data that follows a roughly <code>constant rate of change</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MovingAverageTrendline.html" aria-label="View MovingAverageTrendline class in API reference">MovingAverageTrendline</a></td>
    <td>Members of the <code>moving average trendline</code>, including the inherited properties from <code>ChartTrendline</code> plus the type-specific <code>Period</code> property that controls how many <code>preceding data points</code> are averaged to <code>smooth</code> the curve. Use this trendline to reduce <code>short-term fluctuations</code> and highlight <code>longer-term trends</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolynomialTrendline.html" aria-label="View PolynomialTrendline class in API reference">PolynomialTrendline</a></td>
    <td>Members of the <code>polynomial trendline</code>, including the inherited properties from <code>ChartTrendline</code> plus the type-specific <code>Order</code> property that controls the <code>polynomial degree</code> (<code>curve complexity</code>). Use this trendline for data that follows a <code>curved trend</code> with multiple bends.</td>
</tr>
</table>

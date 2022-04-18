---
layout: post
title: Missing Features .NET MAUI Chart control from Xamarin| Syncfusion
description: This section explains about the list of missing features in the .NET MAUI Chart (SfCartesianChart) control from Xamarin.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Missing Features from Xamarin.Forms

* Data marker support for chart series.
* Data label created event support was not provided in series, instead of that event you can use the `DrawDataLabel` override method in `ChartSeries` class.
* `OpposedPosition` property was not exposed in axis, instead of that you can move to axis opposed position by setting the `CrossesAt` value as `double.MaxValue`.
* `RangeStyle` support was not provided in axis, instead of that you can use `DrawMajorTick`, `DrawMinorTick`, and `DrawGridLine` override methods provided in axis class. 

### Support and feedback

If you need an alternate solution for the above mentioned missing features, we will try to achieve your requirements by customizing the chart, please contact us by creating a [support ticket](https://www.syncfusion.com/support/directtrac/incidents).
Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).

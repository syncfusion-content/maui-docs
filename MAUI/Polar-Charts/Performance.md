---
layout: post
title: Performance in .NET MAUI Polar Charts | Syncfusion
description: Learn about Performance in Syncfusion® .NET MAUI Chart (SfPolarChart), its elements and more details.
platform: maui
control: SfPolarChart
documentation: ug
---

# Performance in .NET MAUI Charts

* If your underlying data object implements `INotifyPropertyChanged`, you can enable the `ListenPropertyChange` property on the series to make the chart listen to the property changes of your data objects.

* However, enabling the `ListenPropertyChange` property registers the `PropertyChanged` event for every object in the data source.

* When dealing with a large number of data points, registering these events can slow down the chart's loading time.

* To optimize performance and avoid unnecessary event registration, the `ListenPropertyChange` property is set to `false`.

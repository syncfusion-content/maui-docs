---
layout: post
title: Right to Left in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about the layouting Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control in right-to-left.
platform: MAUI
control: SfPdfViewer
documentation: ug
keywords: .net maui pdf viewer, .net maui view pdf, pdf viewer in .net maui, .net maui open pdf, maui pdf viewer, maui pdf view
---

# Right to left in .NET MAUI PDF Viewer (SfPdfViewer)

By default, the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) control is laid out in the left-to-right flow direction. For the convenience of right-to-left language users, it enables changing the flow direction to right-to-left (RTL). This can be achieved by setting the [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.iview.flowdirection?view=net-maui-7.0) property to `RightToLeft`. 
Setting the [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.iview.flowdirection?view=net-maui-7.0) property to `RightToLeft` on the SfPdfViewer sets the alignment to the right, and layouts the built-in controls used in the SfPdfViewer to flow from right-to-left. Refer to the following code example to apply the same.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfPdfViewer
	x:Name="PdfViewer"
	FlowDirection="RightToLeft"/>

{% endhighlight %}
{% highlight C# %}

PdfViewer.FlowDirection = FlowDirection.RightToLeft;

{% endhighlight %}
{% endtabs %}

N> Right-to-Left language users can also refer to this [section](https://help.syncfusion.com/maui/pdf-viewer/migration#upcoming-features) for information on how to localize the static text used in the PDF reader to other languages.
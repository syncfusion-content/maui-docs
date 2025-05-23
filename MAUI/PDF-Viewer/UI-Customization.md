---
layout: post
title: UI Customization in .NET MAUI PDF Viewer control | Syncfusion
description: Learn here all about the UI customization options in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# UI Customization in .NET MAUI PDF Viewer (SfPdfViewer)

This section walks you through the UI customization options supported in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html).

## Show or hide the scroll head

You can scroll through the pages by simply dragging the scroll head in the UI. The [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) allows you to show or hide the scroll head thumb displayed using the [ShowScrollHead](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_ShowScrollHead) property. Refer to the following code example.

{% tabs %}
{% highlight c# %}
// Hide the scroll head thumb
PdfViewer.ShowScrollHead = false;
{% endhighlight %}
{% endtabs %}

## Customize the loading indicator

You can customize the loading indicator’s properties by applying a style with the `TargetType` property to `ActivityIndicator`. You may also need to set the [ApplyToDerivedTypes](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/styles/xaml?view=net-maui-7.0#apply-a-style-to-derived-types) property to `True` to get the style applied to the derived classes. See the following code example to customize the color of the loading indicator.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfPdfViewer>
	<syncfusion:SfPdfViewer.Resources>
		<Style TargetType="ActivityIndicator" 
			   ApplyToDerivedTypes="True">
				<Setter Property="Color" Value="Red" />
			</Style>
	</syncfusion:SfPdfViewer.Resources>
</syncfusion:SfPdfViewer>

{% endhighlight %} 
{% endtabs %}

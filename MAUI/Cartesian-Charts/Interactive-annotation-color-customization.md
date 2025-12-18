---
layout: post
title: Interactive Annotation Color Customization in .NET MAUI Cartesian Chart | Syncfusion
description: Learn how to customize annotation colors interactively in Syncfusion® .NET MAUI Chart (SfCartesianChart) control using the AnnotationTapped event for dynamic color selection.
platform: maui
control: SfCartesianChart
documentation: ug
Keywords: .net maui chart annotation interaction, .net maui chart annotation color customization, .net maui chart annotation color selection, .net maui chart dynamic annotation styling.
---

# Interactive Annotation Color Customization

The .NET MAUI Cartesian Chart enables **dynamic annotation color customization** through interactive color selection dialogs. By leveraging the [AnnotationTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AnnotationTapped) event, annotations can be captured on tap interactions and color changes applied to various annotation types including [TextAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TextAnnotation.html), [ShapeAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ShapeAnnotation.html), and [ViewAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ViewAnnotation.html) in real-time, enhancing chart interactivity.

## AnnotationTapped Event

The [AnnotationTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AnnotationTapped) event is fired when an annotation receives a tap interaction. The event handler receives [AnnotationTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AnnotationTappedEventArgs.html) which contains a reference to the tapped annotation object, allowing you to identify and modify the annotation's properties.

**[XAML]**

```xml
<ContentPage>
    <chart:SfCartesianChart x:Name="Chart" AnnotationTapped="Chart_AnnotationTapped">
        .....
        <chart:SfCartesianChart.Annotations>
            .........
        </chart:SfCartesianChart.Annotations>    
    </chart:SfCartesianChart>
</ContentPage>
```

**[C#]**

```csharp
private void Chart_AnnotationTapped(object sender, AnnotationTappedEventArgs e)
{
    // Apply selected color to annotation.
}
```

![Customize Annotation Colors Interactively in .NET MAUI Cartesian Chart](How-to_images/MAUI_Annotation_Color_Customization.gif)

## See also

[How to customize annotation colors interactively in .NET MAUI Cartesian Chart?](https://support.syncfusion.com/agent/kb/22184)

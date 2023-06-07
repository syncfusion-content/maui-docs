---
layout: post
title: Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the annotation feature of Syncfusion .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Annotation in .NET MAUI ImageEditor (SfImageEditor)

The Image Editor has multiple annotations support including text, freehand drawings, and shapes such as rectangles, circles, ellipses, lines and arrows.

The annotations can be customized by following properties.

* [`Bounds`](): Specifies the annotation view bounds.
* [`AllowDrag`](): Enable or disable the dragging for annotations.
* [`AllowResize`](): Enable or disable the resizing for annotations.
* [`Opacity`](): Specifies the opacity of annotations.

## Text

The Text annotation can be inserted and customized by changing its color, font family, font size, and font styles such as bold and italic. The text annotation can be made by either using a toolbar or [`AddText`]() method.

In [`AddText`]() method, the text annotation can be inserted by specifying the text, font family, font size, and font styles. The [`AddText`]() method has the following parameters.

The [`ImageEditorTextSettings`]() consists of the following properties:

* [`RotationAngle`](): Changes the angle of text.
* [`IsEditable`](): Enable or disable the text editing.
* [`IsRotatable`](): Enable or disable the text rotation.
* [`TextAlignment`](): Specifies the alignment of the text.
* [`TextStyle`](): Change the text appearance such as [`TextColor`](), [`FontSize`](), [`FontAttributes`](), and [`FontFamily`]() in image editor using the ImageEditorTextSettings.TextStyle property.

{% tabs %}

{% highlight C# %}

    imageEditor.AddText("Good Day", new ImageEditorTextSettings() { RotationAngle=90, IsRotatable=true, IsEditable=true, TextAlignment=TextAlignment.Start, TextStyle= new ImageEditorTextStyle() { FontSize=14, TextColor=Colors.Black, FontFamily="Arial", FontAttributes=FontAttributes.Italic } }); 

{% endhighlight %}

{% endtabs %}

## Freehand Draw

This annotation can be customized by changing the pen color and stroke thickness and it can be made by either using a toolbar or the [`AddShape`]() method.

*  StrokeThickness - Specifies the stroke width of the pen.
*  Color - Specifies the stroke color of the pen.

In the toolbar, the freehand draw annotation can be inserted by clicking the pen button Once the freehand draw is enabled, the contextual toolbar will be enabled.

In the following example, the [`AddShape`]() method is used to toggle the freehand drawings.

{% tabs %}

{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Pen, new ImageEditorShapeSettings() {Color=Colors.Blue, StrokeThickness=5});

{% endhighlight %}

{% endtabs %}

## Shape

You can annotate any shapes over an image. The following shapes are available in image editor:

* Circle
* Rectangle
* Arrow
* Pen
* Line
* Dotted
* DoubleArrow
* DottedArrow
* DottedDoubleArrow

## Selecting a shape type

The [`AnnotationShape`]() is an enum property with values of [`Rectangle`](), [`Circle`](), [`Arrow`](), [`Pen`](), [`Line`](), [`Dotted`](), [`DoubleArrow`](), [`DottedArrow`](), and [`DottedDoubleArrow`](). You can give the desired shape type as an argument to the [`AddShape`]() method.

{% highlight C# %}

    imageEditor.AddShape(ShapeType.Circle);

{% endhighlight %}

## Customizing a shape

The shapes can be inserted and customized by changing its stroke color, fill color, and stroke thickness. The shapes can be made by either using a toolbar or the [`AddShape`] method.

In the [`AddShape`] method, the shapes can be inserted by specifying fillcolor, stroke color and stroke thickness. The [`AddShape`] method has the following parameters.

*  StrokeThickness - Specifies the stroke width of the shapes.
*  Color - Specifies the stroke color of the shapes.    
*  IsFilled - Enable or disble the fill color of the shapes.
*  FillColor - The fill color of the shapes.

{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Rectangle, new ImageEditorShapeSettings() { Color = Colors.Blue, StrokeThickness = 5, IsFilled =false });

{% endhighlight %}


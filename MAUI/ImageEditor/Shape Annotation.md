---
layout: post
title: Shape Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the shape annotation feature of Syncfusion .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Shape Annotation in .NET MAUI ImageEditor (SfImageEditor)

The image editor control allows you to adding various shapes with customizable settings.

## Shape types

* Circle
* Rectangle
* Arrow
* Pen
* Line
* Dotted
* DoubleArrow
* DottedArrow
* DottedDoubleArrow

## Customize shape settings

The shape annotations can be customized by following common annotation customizing properties.

* `Bounds`: Specifies the annotation view bounds.
* `AllowDrag`: Enable or disable the dragging for annotations.
* `AllowResize`: Enable or disable the resizing for annotations.
* `Opacity`: Specifies the opacity of annotations.

The shapes can be inserted and customized by changing its stroke color, fill color, and stroke thickness. The shapes can be made by either using a toolbar or the `AddShape` method.

In the `AddShape` method, the shapes can be inserted by specifying fillcolor, stroke color and stroke thickness. The [`AddShape`] method has the following parameters.

*  `StrokeThickness` - Specifies the stroke width of the shapes.
*  `Color` - Specifies the stroke color of the shapes.    
*  `IsFilled` - Enable or disble the fill color of the shapes.
*  `FillColor` - The fill color of the shapes.

{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Rectangle, new ImageEditorShapeSettings() { Color = Colors.Blue, StrokeThickness = 5, IsFilled =false });

{% endhighlight %}

## Delete the selected shape

You can delete the selected shape by either using the toolbar or the `DeleteAnnotation` method.

{% highlight C# %}

    imageEditor.DeleteAnnotation();

{% endhighlight %}

## Clear all annotations

You can remove all the annotations using `ClearAnnotations` method.

{% highlight C# %}

    imageEditor.ClearAnnotations();

{% endhighlight %}

## AnnotationSelected event

This event Occurs when the annotation is selected.

{% tabs %}

{% highlight xaml %}

    <imageEditor:SfImageEditor Source="{Binding Image}" AnnotationSelected = "imageEditor_AnnotationSelected" />

{% endhighlight %}

{% highlight C# %}

    this.imageEditor.AnnotationSelected += this.OnAnnotationSelected;
    private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
    {
        if (e.AnnotationSettings is ImageEditorShapeSettings shapeSettings)
        {
            shapeSettings.Color = Colors.Black;
        }
    }

{% endhighlight %}

{% endtabs %}

## Add shape using ImageLoaded event

This event Occurs when the image is loaded.

{% tabs %}

{% highlight xaml %}

    <imageEditor:SfImageEditor Source="{Binding Image}" ImageLoaded="imageEditor_ImageLoaded" />

{% endhighlight %}

{% highlight C# %}

    imageEditor.ImageLoaded += imageEditor_ImageLoaded;
    private void imageEditor_ImageLoaded(object sender, EventArgs e)
    {
        editor1.AddShape(AnnotationShape.Circle);
    }

{% endhighlight %}

{% endtabs %}

## Add shape with manual bounds

The shape can be added by user defined view bounds.

{% highlight C# %}

   imageEditor.AddShape(AnnotationShape.Arrow, new ImageEditorShapeSettings() { Bounds=new Rect(0.1,0.1,0.5,0.5)});

{% endhighlight %}

## Freehand draw

The image editor control allows you to create freehand drawings with customizable settings.

{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Pen);

{% endhighlight %}


## Customize the pen settings

This annotation can be customized by changing the pen color and stroke thickness and it can be made by either using a toolbar or the `AddShape` method.

*  `StrokeThickness` - Specifies the stroke width of the pen.
*  `Color` - Specifies the stroke color of the pen.

In the following example, the `AddShape` method is used to toggle the freehand drawings.

{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Pen, new ImageEditorShapeSettings() {Color=Colors.Blue, StrokeThickness=5});

{% endhighlight %}






---
layout: post
title: Shape Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the shape annotation feature of Syncfusion .NET MAUI ImageEditor(SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Shape Annotation in .NET MAUI ImageEditor (SfImageEditor)

The image editor control allows you to add various shapes with customizable settings

## Shape types

* Circle
* Rectangle
* Arrow
* Line
* Dotted
* DoubleArrow
* DottedArrow
* DottedDoubleArrow

## Customize shape settings

The shape annotations can be customized using common annotation customization properties.

* `Bounds`: Specifies the bounds of the annotation view.
* `AllowDrag`:  Enables or disables the dragging for annotations.
* `AllowResize`: Enables or disables the resizing for annotations.
* `Opacity`: Specifies the opacity of annotations.

Shapes can be inserted and customized by changing their stroke color, fill color, and stroke thickness. You can create shapes using either a toolbar or the `AddShape` method.

In the `AddShape` method, you can insert shapes by specifying the fill color, stroke color, and stroke thickness. The [`AddShape`] method has the following parameters.

*  `StrokeThickness` - Specifies the stroke width of the shapes.
*  `Color` - Specifies the stroke color of the shapes.    
*  `IsFilled` - Enables or disbles the fill color of the shapes.
*  `FillColor` - The fill color of the shapes.

{% tabs %}
{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Rectangle, new ImageEditorShapeSettings() { Color = Colors.Blue, StrokeThickness = 5, IsFilled =false });

{% endhighlight %}
{% endtabs %}

## Delete the selected shape

You can delete the selected shape using either the toolbar or the `DeleteAnnotation` method.

{% tabs %}
{% highlight C# %}

    imageEditor.DeleteAnnotation();

{% endhighlight %}
{% endtabs %}

## Clear all annotations

You can remove all the annotations using the `ClearAnnotations` method.

{% tabs %}
{% highlight C# %}

    imageEditor.ClearAnnotations();

{% endhighlight %}
{% endtabs %}

## AnnotationSelected event

The `AnnotationSelected` event occurs when an annotation is selected.

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

The `ImageLoaded` event occurs when the image is loaded.

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

Shapes can be added by user-defined view bounds.

{% tabs %}
{% highlight C# %}

   imageEditor.AddShape(AnnotationShape.Arrow, new ImageEditorShapeSettings() { Bounds=new Rect(0.1,0.1,0.5,0.5)});

{% endhighlight %}
{% endtabs %}

## Freehand draw

The image editor control allows you to create freehand drawings with customizable settings.

{% tabs %}
{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Pen);

{% endhighlight %}
{% endtabs %}

## Customize the pen settings

The annotation can be customized by changing the pen color and stroke thickness and it can be created using either a toolbar or the `AddShape` method.

*  `StrokeThickness` - Specifies the stroke width of the pen.
*  `Color` - Specifies the stroke color of the pen.

In the following example, the `AddShape` method is used to toggle the freehand drawings.

{% tabs %}
{% highlight C# %}

    imageEditor.AddShape(AnnotationShape.Pen, new ImageEditorShapeSettings() {Color=Colors.Blue, StrokeThickness=5});

{% endhighlight %}
{% endtabs %}
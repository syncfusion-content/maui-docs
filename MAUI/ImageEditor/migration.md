---
layout: post
title: Migrate from Xamarin to .NET MAUI ImageEditor (SfImageEditor) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms ImageEditor to Syncfusion .NET MAUI ImageEditor control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---  

# Migrate from Xamarin.Forms SfImageEditor to .NET MAUI SfImageEditor

To make the migration from the `[Xamarin SfImageEditor]` to the `[.NET MAUI SfImageEditor]` easier, most of the APIs from the Xamarin SfImageEditor are kept in the `.NET MAUI SfImageEditor`. However, to maintain the consistency of API naming in the `.NET MAUI SfImageEditor`, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th></tr>
<tr>
<td>Syncfusion.SfImageEditor.XForms</td>
<td>Syncfusion.Maui.ImageEditor</td></tr>
</table>

## Initialize control

To initialize the control, import the ImageEditor namespace and initialize the `SfImageEditor` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th></tr>
<tr>
<td>

{% tabs %}
{% highlight XAML %}

<ContentPage 
...
xmlns:imageEditor="clr-namespace:Syncfusion.XForms.ImageEditor;assembly=Syncfusion.SfImageEditor.XForms">
    <imageEditor:SfImageEditor x:Name="imageEditor"/>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.XForms.ImageEditor;
...

SfImageEditor imageEditor = new SfImageEditor();
this.Content = imageEditor;

{% endhighlight %}
{% endtabs %}

</td>
<td>

{% tabs %}
{% highlight XAML %}

<ContentPage
...
xmlns:imageEditor="clr-namespace:Syncfusion.Maui.ImageEditor;assembly=Syncfusion.Maui.ImageEditor">
    <imageEditor:SfImageEditor x:Name="imageEditor"/>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ImageEditor;
…

SfImageEditor imageEditor = new SfImageEditor();
this.Content = imageEditor;

{% endhighlight %}
{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th>
</tr>

<tr>
<td>SfImageEditor</td>
<td>SfImageEditor</td>
<td>The image editor is used to crop, flip, rotate, annotate an image with freehand drawing, and built-in shapes.</td>
</tr>

<tr>
<td>PenSettings</td>
<td>ImageEditorAnnotationSettings</td>
<td>Represents a class that contains common settings for annotation views.</td>
</tr>

<tr>
<td>PenSettings</td>
<td>ImageEditorShapeSettings</td>
<td>Represents a class that contains the settings for shape annotation view.</td>
</tr>

<tr>
<td>TextSettings</td>
<td>ImageEditorTextSettings</td>
<td>Represents a class that contains the settings for text annotation view.</td>
</tr>

<tr>
<td>TextSettings </td>
<td>ImageEditorTextStyle</td>
<td>Represents a class that contains the style for text annotation view.</td>
</tr>
</table> 

## Properties

#### SfImageEditor

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
xmlns:imageEditor="clr-namespace:Syncfusion.Maui.ImageEditor;assembly=Syncfusion.Maui.ImageEditor">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                       Source="syncfusion.png"/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.ImageEditor;
...

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("syncfusion.png");
this.Content = imageEditor;

{% endhighlight %}
{% endtabs %}
<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th></tr>

<tr>
<td>Source</td>
<td>Source</td>
<td>Gets or sets the source of image.</td>
</tr>

<tr>
<td>ZoomLevel</td>
<td>ZoomLevel</td>
<td>Gets or sets the initial zoom level.</td>
</tr>

<tr>
<td>EnableZooming</td>
<td>AllowZoom</td>
<td>Gets or sets the value indicating whether to enable the zoom.</td>
</tr>

<tr>
<td>MaximumZoomLevel</td>
<td>MaximumZoomLevel</td>
<td>Gets or sets the maximum zoom level.</td>
</tr>

<tr>
<td>ActualImageRenderedBounds </td>
<td>ImageRenderedSize</td>
<td>Gets the image rendered size.</td>
</tr>

<tr>
<td>OriginalImageSize</td>
<td>OriginalImageSize</td>
<td>Gets the original image size.</td>
</tr>

<tr>
<td>IsImageEdited</td>
<td>IsImageEdited</td>
<td>Gets the value indicating whether the image is edited or not.</td>
</tr>

<tr>
<td>ToolbarSettings.IsVisible</td>
<td>ShowToolbar</td>
<td>Gets or sets the value indicating whether to enable or disable default toolbar.</td>
</tr>

<tr>
<td>Nil</td>
<td>SelectionStroke</td>
<td>Gets or sets the selection highlight stroke.
Applicable for crop view selection, shape and text annotation selection.
</td>
</tr>

</table>

#### ImageEditorAnnotationSettings 

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th></tr>
<tr>
<td>Bounds</td>
<td>Bounds</td>
<td>Gets or sets the annotation view bounds.</td>
</tr>

<tr>
<td>EnableDrag</td>
<td>AllowDrag</td>
<td>Gets or sets a value indicating whether to enable drag action for annotation.</td>
</tr>

<tr>
<td>IsResizable</td>
<td>AllowResize</td>
<td>Gets or sets a value indicating whether the resizing action is enabled or not for annotation.</td>
</tr>

<tr>
<td>Opacity</td>
<td>Opacity</td>
<td>Gets or sets the opacity value. It ranges from 0 to 1.</td>
</tr>
</table>

#### ImageEditorShapeSettings 

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th></tr>
<tr>
<td>Color</td>
<td>Color</td>
<td>Gets or sets the shape annotation color.</td>
</tr>

<tr>
<td>StrokeWidth</td>
<td>StrokeThickness</td>
<td>Gets or sets the shape annotation stroke thickness.</td>
</tr>

<tr>
<td>FillColor</td>
<td>IsFilled</td>
<td>Gets or sets a value indicating whether the color should be applied to the shape fill or stroke.</td>
</tr>
</table>

#### ImageEditorTextSettings 

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th></tr>
<tr>
<td>Angle</td>
<td>RotationAngle</td>
<td>Gets or sets the initial rotation angle for text.</td>
</tr>

<tr>
<td>Nil</td>
<td>TextStyle</td>
<td>Gets or sets the text style for text.</td>
</tr>

<tr>
<td>RotatableElement</td>
<td>IsRotatable</td>
<td>Gets or sets a value indicating whether the text is rotatable or not.</td>
</tr>

<tr>
<td>TextAlignment</td>
<td>TextAlignment</td>
<td>Gets or sets the TextAlignment for the text.</td>
</tr>

<tr>
<td>IsEditable</td>
<td>IsEditable</td>
<td>Gets or sets a value indicating whether the text is editable or not.</td>
</tr>
</table>

#### ImageEditorTextStyle

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th></tr>
<tr>
<td>Color</td>
<td>TextColor</td>
<td>Gets or sets the color for the text.</td>
</tr>

<tr>
<td>FontSize</td>
<td>FontSize</td>
<td>Gets or sets the font size of the text.</td>
</tr>

<tr>
<td>FontFamily</td>
<td>FontFamily</td>
<td>Gets or sets the font family for the text.</td>
</tr>

<tr>
<td>TextEffects</td>
<td>FontAttribute</td>
<td>Gets or sets the font attribute for the text.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th>
</tr>

<tr>
<td>ShapeType</td>
<td>AnnotationShape</td>
<td>Specifies the annotation shapes in image editor.</td>
</tr>

<tr>
<td>FlipDirection</td>
<td>ImageFlipDirection</td>
<td>Specifies the direction to flip an image.</td>
</tr>

<tr>
<td>ImageEffect</td>
<td>ImageEffect</td>
<td>Specifies the image effect.</td>
</tr>

<tr>
<td>Nil</td>
<td>ImageFileType</td>
<td>Specifies the image file type.</td>
</tr>

<tr>
<td>Nil</td>
<td>ImageCropType</td>
<td>Specifies the image crop types.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th></tr>

<tr>
<td>BeginReset</td>
<td>BeginReset</td>
<td>Occurs when the image reset action.</td>
</tr>

<tr>
<td>ImageSaving</td>
<td>ImageSaving</td>
<td>Occurs when the image saving.</td>
</tr>

<tr>
<td>ImageSaved</td>
<td>ImageSaved</td>
<td>Occurs when the image saved in local storage.</td>
</tr>

<tr>
<td>ItemSelected</td>
<td>AnnotationSelected</td>
<td>Occurs when an annotation view selected.</td>
</tr>

<tr>
<td>ImageLoaded</td>
<td>ImageLoaded</td>
<td>Occurs when image loaded into view initially.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfImageEditor</th>
<th>.NET MAUI SfImageEditor</th>
<th>Description</th></tr>

<tr>
<td>Rotate</td>
<td>Rotate</td>
<td>Method to rotate image 90 degrees in clockwise direction.</td>
</tr>

<tr>
<td>Flip</td>
<td>Flip</td>
<td>Method to reverse the image along its horizontal or vertical axis. </td>
</tr>

<tr>
<td>Crop</td>
<td>Crop</td>
<td>Method to select and remove a portion of the image.</td>
</tr>

<tr>
<td>AddText</td>
<td>AddText</td>
<td>Method to add text to the image.</td>
</tr>

<tr>
<td>AddShape</td>
<td>AddShape</td>
<td>Method to add shapes such as rectangles, circles, and lines to the image.</td>
</tr>

<tr>
<td>Save</td>
<td>Save</td>
<td>Method to save the edited image.</td>
</tr>

<tr>
<td>SaveEdits</td>
<td>SaveEdits</td>
<td>Method to save the current editing actions.</td>
</tr>

<tr>
<td>CancelEdits</td>
<td>CancelEdits</td>
<td>Method to cancel the editing actions.</td>
</tr>

<tr>
<td>ClearAnnotations</td>
<td>ClearAnnotations</td>
<td>Method to remove all the annotations.</td>
</tr>

<tr>
<td>Reset</td>
<td>Reset</td>
<td>Method to reset the edited image to its initial stage.</td>
</tr>

<tr>
<td>Undo</td>
<td>Undo</td>
<td>Method to reverse or undo the last action or a series of actions.</td>
</tr>

<tr>
<td>Redo</td>
<td>Redo</td>
<td>Method to replay or redo an action or a series of actions that were previously undone using the "Undo" command.</td>
</tr>

<tr>
<td>Delete</td>
<td>DeleteAnnotation</td>
<td>Method to remove the current selected annotations.</td>
</tr>

<tr>
<td>GetStream</td>
<td>GetImageStream</td>
<td>Method to get the edited image stream</td>
</tr>

<tr>
<td>ApplyImageEffect</td>
<td>ImageEffect</td>
<td>Method to apply various visual effects to the image, such as adjusted brightness, blur, contrast, exposure, saturation, sharpen, hue, and opacity.</td>
</tr>
</table>
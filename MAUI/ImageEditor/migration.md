---
layout: post
title: Migrate from Xamarin to .NET MAUI Image Editor (SfImageEditor) | Syncfusion
description: Learn about Migrating from Syncfusion Xamarin.Forms ImageEditor to the Syncfusion .NET MAUI ImageEditor control.
platform: maui
control: SfImageEditor
documentation: ug
--- 

# Migrate from Xamarin.Forms SfImageEditor to .NET MAUI SfImageEditor

To make the migration from the [Xamarin SfImageEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.html) to the [.NET MAUI SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.html) easier, most of the APIs from the Xamarin SfImageEditor are kept in the [.NET MAUI SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.html). However, to maintain the consistency of API naming in the [.NET MAUI SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.html), some of the APIs have been renamed. Please find the difference in the following topics.

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
<td>{{'[SfImageEditor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html)'| markdownify }}</td>
<td>{{'[SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html)'| markdownify }}</td>
<td>The image editor is used to crop, flip, rotate, annotate an image with freehand drawing, and built-in shapes.</td>
</tr>

<tr>
<td>{{'[PenSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html)'| markdownify }}</td>
<td>{{'[ImageEditorAnnotationSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html)'| markdownify }}</td>
<td>Represents a class that contains common settings for annotation views.</td>
</tr>

<tr>
<td>{{'[PenSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html)'| markdownify }}</td>
<td>{{'[ImageEditorShapeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorShapeSettings.html)'| markdownify }}</td>
<td>Represents a class that contains the settings for shape annotation view.</td>
</tr>

<tr>
<td>{{'[TextSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html)'| markdownify }}</td>
<td>{{'[ImageEditorTextSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html)'| markdownify }}</td>
<td>Represents a class that contains the settings for text annotation view.</td>
</tr>

<tr>
<td>{{'[TextSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html)'| markdownify }}</td>
<td>{{'[ImageEditorTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html)'| markdownify }}</td>
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
<td>{{'[Source](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Source)'| markdownify }}</td>
<td>{{'[Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Source)'| markdownify }}</td>
<td>Gets or sets the source of image.</td>
</tr>

<tr>
<td>{{'[ZoomLevel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ZoomLevel)'| markdownify }}</td>
<td>{{'[ZoomLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ZoomLevel)'| markdownify }}</td>
<td>Gets or sets the initial zoom level.</td>
</tr>

<tr>
<td>{{'[EnableZooming](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_EnableZooming)'| markdownify }}</td>
<td>{{'[AllowZoom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AllowZoom)'| markdownify }}</td>
<td>Gets or sets the value indicating whether to enable the zoom.</td>
</tr>

<tr>
<td>{{'[MaximumZoomLevel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_MaximumZoomLevel)'| markdownify }}</td>
<td>{{'[MaximumZoomLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_MaximumZoomLevel)'| markdownify }}</td>
<td>Gets or sets the maximum zoom level.</td>
</tr>

<tr>
<td>{{'[ActualImageRenderedBounds](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ActualImageRenderedBounds)'| markdownify }}</td>
<td>{{'[ImageRenderedSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageRenderedSize)'| markdownify }}</td>
<td>Gets the image rendered size.</td>
</tr>

<tr>
<td>{{'[OriginalImageSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_OriginalImageSize)'| markdownify }}</td>
<td>{{'[OriginalImageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_OriginalImageSize)'| markdownify }}</td>
<td>Gets the original image size.</td>
</tr>

<tr>
<td>{{'[IsImageEdited](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_IsImageEdited)'| markdownify }}</td>
<td>{{'[IsImageEdited](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_IsImageEdited)'| markdownify }}</td>
<td>Gets the value indicating whether the image is edited or not.</td>
</tr>

<tr>
<td>{{'[ToolbarSettings.IsVisible](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.ToolbarSettings.html#Syncfusion_SfImageEditor_XForms_ToolbarSettings_IsVisible)'| markdownify }}</td>
<td>{{'[ShowToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ShowToolbar)'| markdownify }}</td>
<td>Gets or sets the value indicating whether to enable or disable default toolbar.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[SelectionStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_SelectionStroke)'| markdownify }}</td>
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
<td>{{'[Bounds](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html#Syncfusion_SfImageEditor_XForms_PenSettings_Bounds)'| markdownify }}</td>
<td>{{'[Bounds](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds)'| markdownify }}</td>
<td>Gets or sets the annotation view bounds.</td>
</tr>

<tr>
<td>{{'[EnableDrag](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html#Syncfusion_SfImageEditor_XForms_PenSettings_EnableDrag)'| markdownify }}</td>
<td>{{'[AllowDrag](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowDrag)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to enable drag action for annotation.</td>
</tr>

<tr>
<td>{{'[IsResizable](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html#Syncfusion_SfImageEditor_XForms_PenSettings_IsResizable)'| markdownify }}</td>
<td>{{'[AllowResize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowResize)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the resizing action is enabled or not for annotation.</td>
</tr>

<tr>
<td>{{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html#Syncfusion_SfImageEditor_XForms_PenSettings_Opacity)'| markdownify }}</td>
<td>{{'[Opacity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Opacity)'| markdownify }}</td>
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
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html#Syncfusion_SfImageEditor_XForms_PenSettings_Color)'| markdownify }}</td>
<td>{{'[Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorShapeSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorShapeSettings_Color)'| markdownify }}</td>
<td>Gets or sets the shape annotation color.</td>
</tr>

<tr>
<td>{{'[StrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html#Syncfusion_SfImageEditor_XForms_PenSettings_StrokeWidth)'| markdownify }}</td>
<td>{{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorShapeSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorShapeSettings_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the shape annotation stroke thickness.</td>
</tr>

<tr>
<td>{{'[FillColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.PenSettings.html#Syncfusion_SfImageEditor_XForms_PenSettings_FillColor)'| markdownify }}</td>
<td>{{'[IsFilled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorShapeSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorShapeSettings_IsFilled)'| markdownify }}</td>
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
<td>{{'[Angle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html#Syncfusion_SfImageEditor_XForms_TextSettings_Angle)'| markdownify }}</td>
<td>{{'[RotationAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_RotationAngle)'| markdownify }}</td>
<td>Gets or sets the initial rotation angle for text.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextStyle)'| markdownify }}</td>
<td>Gets or sets the text style for text.</td>
</tr>

<tr>
<td>{{'[RotatableElement](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_RotatableElements)'| markdownify }}</td>
<td>{{'[IsRotatable](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsRotatable)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the text is rotatable or not.</td>
</tr>

<tr>
<td>{{'[TextAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html#Syncfusion_SfImageEditor_XForms_TextSettings_TextAlignment)'| markdownify }}</td>
<td>{{'[TextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextAlignment)'| markdownify }}</td>
<td>Gets or sets the TextAlignment for the text.</td>
</tr>

<tr>
<td>{{'[IsEditable](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html#Syncfusion_SfImageEditor_XForms_TextSettings_IsEditable)'| markdownify }}</td>
<td>{{'[IsEditable](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsEditable)'| markdownify }}</td>
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
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html#Syncfusion_SfImageEditor_XForms_TextSettings_Color)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_TextColor)'| markdownify }}</td>
<td>Gets or sets the color for the text.</td>
</tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html#Syncfusion_SfImageEditor_XForms_TextSettings_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontSize)'| markdownify }}</td>
<td>Gets or sets the font size of the text.</td>
</tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html#Syncfusion_SfImageEditor_XForms_TextSettings_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontFamily)'| markdownify }}</td>
<td>Gets or sets the font family for the text.</td>
</tr>

<tr>
<td>{{'[TextEffects](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.TextSettings.html#Syncfusion_SfImageEditor_XForms_TextSettings_TextEffects)'| markdownify }}</td>
<td>{{'[FontAttribute](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontAttributes)'| markdownify }}</td>
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
<td>{{'[ShapeType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.ShapeType.html)'| markdownify }}</td>
<td>{{'[AnnotationShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.AnnotationShape.html)'| markdownify }}</td>
<td>Specifies the annotation shapes in image editor.</td>
</tr>

<tr>
<td>{{'[FlipDirection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.FlipDirection.html)'| markdownify }}</td>
<td>{{'[ImageFlipDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFlipDirection.html)'| markdownify }}</td>
<td>Specifies the direction to flip an image.</td>
</tr>

<tr>
<td>{{'[ImageEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.ImageEffect.html)'| markdownify }}</td>
<td>{{'[ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEffect.html)'| markdownify }}</td>
<td>Specifies the image effect.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ImageFileType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html)'| markdownify }}</td>
<td>Specifies the image file type.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[ImageCropType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageCropType.html)'| markdownify }}</td>
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
<td>{{'[BeginReset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_BeginReset)'| markdownify }}</td>
<td>{{'[BeginReset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_BeginReset)'| markdownify }}</td>
<td>Occurs when the image reset action.</td>
</tr>

<tr>
<td>{{'[ImageSaving](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ImageSaving)'| markdownify }}</td>
<td>{{'[ImageSaving](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaving)'| markdownify }}</td>
<td>Occurs when the image saving.</td>
</tr>

<tr>
<td>{{'[ImageSaved](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ImageSaved)'| markdownify }}</td>
<td>{{'[ImageSaved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaved)'| markdownify }}</td>
<td>Occurs when the image saved in local storage.</td>
</tr>

<tr>
<td>{{'[ItemSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ItemSelected)'| markdownify }}</td>
<td>{{'[AnnotationSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected)'| markdownify }}</td>
<td>Occurs when an annotation view selected.</td>
</tr>

<tr>
<td>{{'[ImageLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ImageLoaded)'| markdownify }}</td>
<td>{{'[ImageLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded)'| markdownify }}</td>
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
<td>{{'[Rotate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Rotate)'| markdownify }}</td>
<td>{{'[Rotate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Rotate)'| markdownify }}</td>
<td>Method to rotate image 90 degrees in clockwise direction.</td>
</tr>

<tr>
<td>{{'[Flip](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Flip_Syncfusion_SfImageEditor_XForms_FlipDirection_)'| markdownify }}</td>
<td>{{'[Flip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Flip_Syncfusion_Maui_ImageEditor_ImageFlipDirection_)'| markdownify }}</td>
<td>Method to reverse the image along its horizontal or vertical axis. </td>
</tr>

<tr>
<td>{{'[Crop](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Crop_Xamarin_Forms_Rectangle_System_Boolean_)'| markdownify }}</td>
<td>{{'[Crop](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Crop_Syncfusion_Maui_ImageEditor_ImageCropType_)'| markdownify }}</td>
<td>Method to select and remove a portion of the image.</td>
</tr>

<tr>
<td>{{'[AddText](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_AddText_System_String_Syncfusion_SfImageEditor_XForms_TextSettings_)'| markdownify }}</td>
<td>{{'[AddText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AddText_System_String_Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_)'| markdownify }}</td>
<td>Method to add text to the image.</td>
</tr>

<tr>
<td>{{'[AddShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_AddShape_Syncfusion_SfImageEditor_XForms_ShapeType_Syncfusion_SfImageEditor_XForms_PenSettings_)'| markdownify }}</td>
<td>{{'[AddShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AddShape_Syncfusion_Maui_ImageEditor_AnnotationShape_Syncfusion_Maui_ImageEditor_ImageEditorShapeSettings_)'| markdownify }}</td>
<td>Method to add shapes such as rectangles, circles, and lines to the image.</td>
</tr>

<tr>
<td>{{'[Save](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Save_System_String_Xamarin_Forms_Size_)'| markdownify }}</td>
<td>{{'[Save](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Save_System_Nullable_Syncfusion_Maui_ImageEditor_ImageFileType__System_String_System_String_System_Nullable_Microsoft_Maui_Graphics_Size__)'| markdownify }}</td>
<td>Method to save the edited image.</td>
</tr>

<tr>
<td>{{'[SaveEdits](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_SaveEdits)'| markdownify }}</td>
<td>{{'[SaveEdits](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_SaveEdits)'| markdownify }}</td>
<td>Method to save the current editing actions.</td>
</tr>

<tr>
<td>Nil</td>
<td>{{'[CancelEdits](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_CancelEdits)'| markdownify }}</td>
<td>Method to cancel the editing actions.</td>
</tr>

<tr>
<td>{{'[ClearAnnotations](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ClearAnnotations)'| markdownify }}</td>
<td>{{'[ClearAnnotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ClearAnnotations)'| markdownify }}</td>
<td>Method to remove all the annotations.</td>
</tr>

<tr>
<td>{{'[Reset](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Reset)'| markdownify }}</td>
<td>{{'[Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Reset)'| markdownify }}</td>
<td>Method to reset the edited image to its initial stage.</td>
</tr>

<tr>
<td>{{'[Undo](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Undo)'| markdownify }}</td>
<td>{{'[Undo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Undo)'| markdownify }}</td>
<td>Method to reverse or undo the last action or a series of actions.</td>
</tr>

<tr>
<td>{{'[Redo](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Redo)'| markdownify }}</td>
<td>{{'[Redo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Redo)'| markdownify }}</td>
<td>Method to replay or redo an action or a series of actions that were previously undone using the "Undo" command.</td>
</tr>

<tr>
<td>{{'[Delete](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_Delete)'| markdownify }}</td>
<td>{{'[DeleteAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_DeleteAnnotation)'| markdownify }}</td>
<td>Method to remove the current selected annotations.</td>
</tr>

<tr>
<td>{{'[GetStream](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_GetStream)'| markdownify }}</td>
<td>{{'[GetImageStream](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_GetImageStream)'| markdownify }}</td>
<td>Method to get the edited image stream</td>
</tr>

<tr>
<td>{{'[ApplyImageEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms.SfImageEditor.html#Syncfusion_SfImageEditor_XForms_SfImageEditor_ApplyImageEffect_Syncfusion_SfImageEditor_XForms_ImageEffect_System_Int32_)'| markdownify }}</td>
<td>{{'[ImageEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageEffect_Syncfusion_Maui_ImageEditor_ImageEffect_System_Nullable_System_Double__)'| markdownify }}</td>
<td>Method to apply various visual effects to the image, such as adjusted brightness, blur, contrast, exposure, saturation, sharpen, hue, and opacity.</td>
</tr>
</table>

## Upcoming features

* Support for annotations Z ordering.
* Support for serialize and deserialize the annotations.
* Support to add custom shapes or views.
* Support for pan and zoom improvements while performing the crop action on the images.

## Known issues in .Net MAUI ImageEditor
* [Mac, iOS]The image is not loading correctly from the stream or URI binding source.
* Rotation not working for text annotation.
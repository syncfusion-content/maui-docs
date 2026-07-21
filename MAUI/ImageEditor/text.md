---
layout: post
title: Text annotation in .NET MAUI Image Editor control | Syncfusion®
description: Learn here all about the text annotation feature of Syncfusion® .NET MAUI Image Editor (SfImageEditor) control.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Text annotation in .NET MAUI Image Editor (SfImageEditor)

The .NET MAUI Image Editor allows you to add text using the [`AddText`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AddText_System_String_Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_) method with customizable settings.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="AddText"
            Clicked="OnAddTextClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.ImageEditor;

private void OnAddTextClicked(object sender, EventArgs e)
{
    this.imageEditor.AddText("Good morning");
}

{% endhighlight %}
{% endtabs %}

![Text annotation in .NET MAUI Image Editor](images/text/net-maui-image-editor-text-annotation.png)

## Customize text appearance

Use the [`ImageEditorTextSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#) to customize the appearance of text annotations.

* [`Id`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Id) - A unique ID generated for a text annotation when it is added to the image editor. You can retrieve this ID from the `AnnotationSelected` event arguments or from the serialized JSON.
* [`AllowDrag`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowDrag) - Enables or disables dragging of the text annotation. The default value is `true`.
* [`AllowResize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowResize) - Enables or disables resizing of the text annotation. The default value is `true`.
* [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds) - Specifies the bounds of the text view. The value should range from 0 to 1.
* [`Opacity`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Opacity) - Specifies the opacity of the text annotation, applied to the background color of the text. The value should range from 0 to 1.
* [`RotationAngle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_RotationAngle) - Specifies the initial rotation angle of the text. The value ranges from 0 to 360.
* [`IsEditable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsEditable) - Enables or disables text editing. The default value is `true`.
* [`IsRotatable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsRotatable) - Enables or disables rotation of the text. The default value is `true`.
* [`TextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextAlignment) - Specifies the start, center, or end alignment of the text. The default value is `TextAlignment.Center`.
* [`Background`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_Background) - Specifies the background color of the text annotation. The default value is `Colors.Transparent`.
* [`TextStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_TextStyle) - Changes the text appearance, such as [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_TextColor), [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontSize), [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontAttributes), and [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextStyle.html#Syncfusion_Maui_ImageEditor_ImageEditorTextStyle_FontFamily).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="AddText"
            Clicked="OnAddTextClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

private void OnAddTextClicked(object sender, EventArgs e)
{
    this.imageEditor.AddText("Good Day",
        new ImageEditorTextSettings()
        {
            RotationAngle = 90,
            IsRotatable = true,
            IsEditable = true,
            TextAlignment = TextAlignment.Start,
            TextStyle = new ImageEditorTextStyle()
            {
                FontSize = 14,
                TextColor = Colors.Black.WithAlpha(0.5f),
                FontFamily = "Arial",
                FontAttributes = FontAttributes.Italic
            }
        });
}

{% endhighlight %}
{% endtabs %}

![Text annotation customization in .NET MAUI Image Editor](images/text/net-maui-image-editor-text-customization.png)

## Select an annotation programmatically

You can select an annotation programmatically by passing the unique `ID` of the annotation to the [SelectAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_SelectAnnotation_System_Object_) method of `SfImageEditor`.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.png"
                               ImageLoaded="imageEditor_ImageLoaded" />
    <StackLayout Grid.Row="1" Margin="10"
                 Orientation="Horizontal">
        <Label Text="ShapeID :" VerticalOptions="Center" />
        <Entry x:Name="shapeID" WidthRequest="50" />
        <Button Text="SelectShape" Margin="25,0,0,0"
                Clicked="SelectShape_Clicked" WidthRequest="150" />
    </StackLayout>
</Grid>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

private void SelectShape_Clicked(object sender, EventArgs e)
{
    if (int.TryParse(this.shapeID.Text, out int shapeId))
    {
        this.imageEditor.SelectAnnotation(shapeId);
    }
}

private void imageEditor_ImageLoaded(object sender, EventArgs e)
{
    imageEditor.AddText("Syncfusion", new ImageEditorTextSettings() { Id = 1, Background = Colors.Blue });
    imageEditor.SaveEdits();
}

{% endhighlight %}

{% endtabs %}

## Customize the background

Customize the background color of the text annotation using the [`Background`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_Background) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="TextBackground"
            Clicked="OnTextBackgroundClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

private void OnTextBackgroundClicked(object sender, EventArgs e)
{
    this.imageEditor.AddText("Good Day",
        new ImageEditorTextSettings()
        {
            Background = Colors.White,
            Opacity = 0.5f
        });
}

{% endhighlight %}
{% endtabs %}

![Text annotation customization in .NET MAUI Image Editor](images/text/net-maui-image-editor-background.jpg)

## Delete the text

Delete the selected text using the toolbar or the [`DeleteAnnotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_DeleteAnnotation) method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="DeleteAnnotation"
            Clicked="OnDeleteAnnotationClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void OnDeleteAnnotationClicked(object sender, EventArgs e)
{
    this.imageEditor.DeleteAnnotation();
}

{% endhighlight %}
{% endtabs %}

## Clear all annotations

Remove all the text annotations using the [`ClearAnnotations`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ClearAnnotations) method.

N> This also removes shape, pen, and custom view annotations.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="ClearAnnotations"
            Clicked="OnClearAnnotationsClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void OnClearAnnotationsClicked(object sender, EventArgs e)
{
    this.imageEditor.ClearAnnotations();
}

{% endhighlight %}
{% endtabs %}

## Annotation selected event

Occurs when an annotation is selected.

N> This is common for Shape, Text, and CustomView annotations.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.png" AnnotationSelected="OnAnnotationSelected" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
{
    if (e.AnnotationSettings is ImageEditorTextSettings textSettings)
    {
        textSettings.RotationAngle = 90;
    }
}

{% endhighlight %}

{% endtabs %}

## Annotation unselected event

Occurs when an annotation is unselected.

N> This is common for Shape, Text, and CustomView annotations.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor Source="image.png" AnnotationUnselected="OnAnnotationUnSelected" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

private void OnAnnotationUnSelected(object sender, AnnotationUnselectedEventArgs e)
{
    if (e.AnnotationSettings is ImageEditorTextSettings text)
    {
        text.Background = Colors.Black;
    }
}

{% endhighlight %}

{% endtabs %}


## Add text on initial loading

Add text on image loading using the [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageLoaded="OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

private void OnImageLoaded(object sender, EventArgs e)
{
    this.imageEditor.AddText("Good morning");
}

{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/ImageLoadedSample)

## Add text with manual bounds

The text can be added with user-defined view bounds. The [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds) are treated as ratio values of the image width and height, so specify the bounds' rectangle values ranging from 0 to 1.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageLoaded="OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ImageEditor;

private void OnImageLoaded(object sender, EventArgs e)
{
    imageEditor.AddText("Good morning", new ImageEditorTextSettings() { Bounds = new Rect(0.1, 0.1, 0.5, 0.5) });
}

{% endhighlight %}
{% endtabs %}

N> To edit a text annotation, double-tap inside the text view.
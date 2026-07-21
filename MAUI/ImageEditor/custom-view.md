---
layout: post
title: Custom view annotation in .NET MAUI Image Editor control | Syncfusion®
description: Learn here all about the custom view annotation feature of Syncfusion® .NET MAUI Image Editor (SfImageEditor) control.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Custom view annotation in .NET MAUI Image Editor (SfImageEditor)

The .NET MAUI Image Editor allows you to add a custom view using the [AddCustomAnnotationView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AddCustomAnnotationView_Microsoft_Maui_Controls_View_Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_) method with customizable settings.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Clicked="OnAddCustomAnnotationViewClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;

private void OnAddCustomAnnotationViewClicked(object sender, EventArgs e)
{
    Image customImage = new Image() { HeightRequest = 100, WidthRequest = 100, Aspect = Aspect.Fill };
    customImage.Source = ImageSource.FromFile("emoji.png");
    imageEditor.AddCustomAnnotationView(customImage);
}

{% endhighlight %}
{% endtabs %}

![Custom view annotation in .NET MAUI Image Editor](images/custom-view/imageeditor-customview.gif)

## Customize the appearance

Use the [`ImageEditorAnnotationSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html) to customize the appearance of custom view annotations.

* [`Id`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Id) - A unique ID generated for a custom view annotation when it is added to the image editor. You can retrieve this ID from the `AnnotationSelected` event arguments or from the serialized JSON.
* [`AllowDrag`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowDrag) - Enables or disables dragging of the custom view annotation. The default value is `true`.
* [`AllowResize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowResize) - Enables or disables resizing of the custom view annotation. The default value is `true`.
* [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds) - Specifies the bounds of the custom view. The value should range from 0 to 1.
* [`RotationAngle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_RotationAngle) - Specifies the initial rotation angle of the custom view. The value ranges from 0 to 360.
* [`IsRotatable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsRotatable) - Enables or disables rotation of the custom view. The default value is `true`.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Clicked="OnAddCustomAnnotationViewClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ImageEditor;

private void OnAddCustomAnnotationViewClicked(object sender, EventArgs e)
{
    Image customImage = new Image() { HeightRequest = 100, WidthRequest = 100, Aspect = Aspect.Fill };
    customImage.Source = ImageSource.FromFile("emoji.png");
    this.imageEditor.AddCustomAnnotationView(customImage,
    new ImageEditorAnnotationSettings
    {
        Bounds = new Rect(0.2, 0.2, 0.5, 0.1),
        RotationAngle = 45,
        AllowResize = true,
        AllowDrag = false
    });
}

{% endhighlight %}
{% endtabs %}

## Select an annotation programmatically

You can select an annotation programmatically by passing the unique `ID` of the annotation to the [SelectAnnotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_SelectAnnotation_System_Object_) method of `SfImageEditor`.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

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

{% highlight C# tabtitle="C#" %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
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
    Image customImage = new Image() { HeightRequest = 100, WidthRequest = 100, Aspect = Aspect.Fill };
    customImage.Source = ImageSource.FromFile("emoji.png");
    this.imageEditor.AddCustomAnnotationView(customImage,
    new ImageEditorAnnotationSettings
    {
        Id = 1,
        Bounds = new Rect(0.2, 0.2, 0.5, 0.1),
        RotationAngle = 45,
        AllowResize = true,
        AllowDrag = false
    });
    imageEditor.SaveEdits();
}

{% endhighlight %}

{% endtabs %}

## Delete the custom view

Delete the selected custom view using the [`DeleteAnnotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_DeleteAnnotation) method.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="DeleteAnnotation"
            Clicked="OnDeleteAnnotationClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

private void OnDeleteAnnotationClicked(object sender, EventArgs e)
{
    this.imageEditor.DeleteAnnotation();
}

{% endhighlight %}
{% endtabs %}

## Clear all annotations

Remove all the custom view annotations using the [`ClearAnnotations`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ClearAnnotations) method.

N> This is common for Shape, Text, and CustomView annotations.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="ClearAnnotations"
            Clicked="OnClearAnnotationsClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

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

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor Source="image.png" 
                           AnnotationSelected="OnAnnotationSelected" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
{
    if (e.AnnotationSettings is ImageEditorAnnotationSettings annotationSettings)
    {
        annotationSettings.RotationAngle = 90;
    }
}

{% endhighlight %}

{% endtabs %}

## Annotation unselected event

Occurs when an annotation is unselected.

N> This is common for Shape, Text, and CustomView annotations.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor Source="image.png" 
                           AnnotationUnselected="OnAnnotationUnSelected" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnAnnotationUnSelected(object sender, AnnotationUnselectedEventArgs e)
{
    if (e.AnnotationSettings is ImageEditorAnnotationSettings annotationSettings)
    {
        annotationSettings.RotationAngle = 90;
    }
}

{% endhighlight %}

{% endtabs %}

## Add custom view on initial loading

Add a custom view on image loading using the [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor x:Name="imageEditor"   
                           Source="image.png" 
                           ImageLoaded="OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

private void OnImageLoaded(object sender, EventArgs e)
{
    this.imageEditor.AddCustomAnnotationView(new Label { Text = "Hello Syncfusion", WidthRequest = 150, HeightRequest = 40 });
}

{% endhighlight %}

{% endtabs %}


## Add custom view with manual bounds

Add a custom view with user-defined view bounds. The [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds) are treated as ratio values of the image width and height, so specify the bounds' rectangle values ranging from 0 to 1.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor x:Name="imageEditor" 
                           Source="image.png" 
                           ImageLoaded="OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ImageEditor;

private void OnImageLoaded(object sender, EventArgs e)
{
    Image image = new Image() { HeightRequest = 50, WidthRequest = 50, Aspect = Aspect.Fill };
    image.Source = ImageSource.FromFile("images.jpg");
    this.imageEditor.AddCustomAnnotationView(image,
        new ImageEditorAnnotationSettings
        {
            Bounds = new Rect(0.2, 0.2, 0.5, 0.5)
        });
}

{% endhighlight %}
{% endtabs %}
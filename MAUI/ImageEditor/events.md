---
layout: post
title: Events in .NET MAUI Image Editor Control | Syncfusion
description: Learn here all about the Events support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Events in the .NET MAUI Image Editor (SfImageEditor)

The SfImageEditor supports the [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) and [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) events to interact with [.NET MAUI Image Editor](https://help.syncfusion.com/maui/imageeditor/overview).

## Image loaded event

This [`ImageLoaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event will be triggered after the image has been loaded. By this event, you can add any shapes or text over an image or crop an image while initially loading the image.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" ImageLoaded = "OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
    private void OnImageLoaded(object sender, EventArgs e)
    {
        this.imageEditor.Rotate();
    }

{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/ImageLoadedSample)

## Annotation selected event

This [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) event occurs when the annotation is selected.

N> This is common for Shape and Text annotations.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" AnnotationSelected = "OnAnnotationSelected" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

    private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
    {
        if (e.AnnotationSettings is ImageEditorShapeSettings shapeSettings)
        {
            shapeSettings.Color = Colors.Black;
        }
    }

{% endhighlight %}

{% endtabs %}

## ID Support for annotation

In ImageEditor, a unique ID is generated for all annotations (Text, Shapes, Paths, and CustomViews) when they are added to the image editor. You can retrieve this unique ID from the ItemsSelected event arguments or from the serialized JSON.

## Select a particular annotation programmatically using annotation ID

By passing the unique ID of an annotation to the SelectAnnotation method of SfImageEditor, you can select the particular annotation programmatically.

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
        <Entry x:Name="shapeID" WidthRequest ="50"/>
        <Button Text="SelectShape" Margin="25,0,0,0"
                Clicked="SelectShape_Clicked" WidthRequest="150" />
    </StackLayout>
</Grid>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

private void SelectShape_Clicked(object sender, EventArgs e)
{
    int shapeId;
    if (int.TryParse(this.shapeID.Text, out shapeId))
    {
        this.imageEditor.SelectAnnotation(shapeId);
    }
}
 
private void imageEditor_ImageLoaded(object sender, EventArgs e)
{
    imageEditor.AddText("Syncfusion", new ImageEditorTextSettings() { Id = 1, Background = Colors.Blue });
    imageEditor.AddShape(AnnotationShape.Rectangle, new ImageEditorShapeSettings() { Id = 2, Color = Colors.Violet, Bounds = new Rect(0, 0, 0.3, 0.3) });
    imageEditor.AddShape(AnnotationShape.Circle, new ImageEditorShapeSettings() { Id = 3, Color = Colors.Orange, Bounds = new Rect(0, 0.4, 0.4, 0.4) });
    imageEditor.SaveEdits();
}

{% endhighlight %}

{% endtabs %}

## Browse image event

The [`BrowseImage`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_BrowseImage) event occurs when you click the browse icon in the toolbar while browsing the image source.
`Cancel`: Restrict the default image browse picker opening by setting the `Cancel` argument `true`.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" BrowseImage = "OnImageBrowse" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
    private void OnImageBrowse(object sender, CancelEventArgs e)
    {
        e.Cancel = true;
    }

{% endhighlight %}

{% endtabs %}

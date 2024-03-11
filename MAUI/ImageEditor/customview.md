---
layout: post
title: Custom view Annotation in .NET MAUI Image Editor control | Syncfusion
description: Learn about the custom view annotation feature of Syncfusion .NET MAUI Image Editor(SfImageEditor) control.
platform: maui
control: SfImageEditor
documentation: ug
---

# Custom view Annotation in .NET MAUI Image Editor (SfImageEditor)

The ImageEditor control in .NET MAUI allows you to add custom view using the `AddCustomAnnotationView` method with customizable settings.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Clicked="OnAddCustomAnnotationViewClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnAddCustomAnnotationViewClicked(object sender, EventArgs e)
    {
        Image customImage = new Image() { HeightRequest = 100, WidthRequest = 100, Aspect= Aspect.Fill};
        customImage.Source = ImageSource.FromFile("emoji.png");
        imageEditor.AddCustomAnnotationView(customImage);
    }

{% endhighlight %}
{% endtabs %}


## Customize the custom view appearance

Customize the appearance of Custom view annotation using the [`ImageEditorAnnotationSettings`].

* [`AllowDrag`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowDrag): Enables or disables the dragging of custom view annotation. The default value is `true`.
* [`AllowResize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_AllowResize): Enables or disables the resizing of custom view annotation. The default value is `true`.
* [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds): Specifies the bounds of the custom view. Position the custom view wherever you want on the image. The value of the text bounds should fall between 0 and 1.
* [`RotationAngle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_RotationAngle): Specifies the initial rotation angle of the custom view. The value should fall between 0 to 360.
* [`IsRotatable`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorTextSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorTextSettings_IsRotatable): Enables or disables the custom view rotation. The default value is `true`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Clicked="OnAddCustomAnnotationViewClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnAddCustomAnnotationViewClicked(object sender, EventArgs e)
    {
        Image customImage = new Image() { HeightRequest = 100, WidthRequest = 100, Aspect= Aspect.Fill};
        customImage.Source = ImageSource.FromFile("emoji.png");
        this.imageEditor.AddCustomAnnotationView(customImage, 
            new Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings 
            { 
                Bounds = new Rect(0.2, 0.2, 0.5, 0.1), 
                RotationAngle = 45,
                AllowResize = true,
                AllowDrag = false
            });
    }

{% endhighlight %}
{% endtabs %}

## Delete the custom view

Delete the selected custom view using the [`DeleteAnnotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_DeleteAnnotation) method.

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

## Clear all custom view

Remove all the custom view annotations using the [`ClearAnnotations`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ClearAnnotations) method.

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

This [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) event occurs when the annotation is selected.

N> This is common for Shape, Text and CustomView annotations.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" AnnotationSelected = "OnAnnotationSelected" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

    private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
    {
        if (e.AnnotationSettings is ImageEditorAnnotationSettings annotationSettings)
        {
            annotationSettings.RotationAngle = 90;
        }
    }

{% endhighlight %}

{% endtabs %}

## Add custom view on initial loading

Add a custom view on image loading using the [`Imageloaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageLoaded = "OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

    private void OnImageLoaded(object sender, EventArgs e)
    {
        this.imageEditor.AddCustomAnnotationView(new Label { Text = "Hello Syncfusion", WidthRequest = 150, HeightRequest = 40 });
    }

{% endhighlight %}

{% endtabs %}


### Add custom view with manual bounds

The custom view can be added with user-defined view bounds. The [`Bounds`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings.html#Syncfusion_Maui_ImageEditor_ImageEditorAnnotationSettings_Bounds) are treated as ratio values of image width and height, so you have to specify bound's rectangle values in the range of 0 to 1.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageLoaded = "OnImageLoaded" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

    private void OnImageLoaded(object sender, EventArgs e)
    {
        Image image = new Image() { HeightRequest = 50, WidthRequest = 50, Aspect = Aspect.Fill };
        customImage.Source = ImageSource.FromFile("images.jpg");
        this.imageEditor.AddCustomAnnotationView(image, 
            new Syncfusion.Maui.ImageEditor.ImageEditorAnnotationSettings 
            { 
                Bounds = new Rect(0.2, 0.2, 0.5, 0.5) 
            });
    }

{% endhighlight %}
{% endtabs %}

---
layout: post
title: Events in .NET MAUI Image Editor Control | Syncfusion
description: Learn here all about the Events support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Events in the .NET MAUI Image Editor (SfImageEditor)

The SfImageEditor supports the [`Imageloaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) and [`AnnotationSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_AnnotationSelected) events to interact with [.NET MAUI Image Editor](https://help.syncfusion.com/maui/imageeditor/overview).

## Image loaded event

This [`Imageloaded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageLoaded) event will be triggered after the image has been loaded. By this event, you can add any shapes or text over an image or crop an image while initially loading the image.

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

## ID Support for annotation event

In ImageEditor, the Unique ID is generated for all annotations (Text, Shapes, Paths, and CustomViews) when they are added to the image editor and you can get this Unique ID from the ItemsSelected event arguments or from the serialized JSON. By passing this Unique ID to the SelectShape method of SfImageEditor, you can select the particular annotation programmatically.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

 <Grid>
     <Grid.RowDefinitions>
         <RowDefinition Height="*" />
         <RowDefinition Height="Auto" />
     </Grid.RowDefinitions>
     <imageEditor:SfImageEditor x:Name="imageEditor"
                                Source="image.png"
                                AnnotationSelected="imageEditor_AnnotationSelected" />
     <StackLayout Grid.Row="1" Margin="10"
                  Orientation="Horizontal">
         <Label Text="ShapeID :" VerticalOptions="Center" />
         <Entry x:Name="shapeID" WidthRequest ="50"/>
         <Button Text="SelectShape" Margin="25,0,0,0"
                 Clicked="SelectShape_Clicked" WidthRequest="150" />
         <Button Text="ChangeID"
                 Margin="25,0,0,0"
                 Clicked="ChangeID_Clicked"
                 WidthRequest="150" />
         <Button Text="EditShape"
                 Margin="25,0,0,0"
                 Clicked="EditShape_Clicked"
                 WidthRequest="150" />
         <Button Text="DeleteShape"
                 Margin="25,0,0,0"
                 Clicked="DeleteShape_Clicked"
                 WidthRequest="150" />
     </StackLayout>
 </Grid>

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}

        public MainPage()
    {
        InitializeComponent();
        imageEditor.AddShape(AnnotationShape.Rectangle, new ImageEditorShapeSettings() { Id = 222 });
        imageEditor.SaveEdits();
        imageEditor.SelectAnnotation(222);
        imageEditor.ToolbarItemSelected += ImageEditor_ToolbarItemSelected;
        ImageEditorToolbar footerToolbar = imageEditor.Toolbars[1];
        footerToolbar.ToolbarItems.Add(new ImageEditorToolbarItem() { Name = "Text1", Text = "Text1" });
        footerToolbar.ToolbarItems.Add(new ImageEditorToolbarItem() { Name = "Shapes", Text = "Shapes" });
        footerToolbar.ToolbarItems.Add(new ImageEditorToolbarItem() { Name = "CustomView", Text = "CustomView" });

        ImageEditorToolbar headerToolbar = imageEditor.Toolbars[0];
        ImageEditorToolbarGroupItem browseGroup = (ImageEditorToolbarGroupItem)headerToolbar.ToolbarItems[0];
        browseGroup.Items.Add(new ImageEditorToolbarItem() { Name = "Serialize", Text = "Serialize" });
        browseGroup.Items.Add(new ImageEditorToolbarItem() { Name = "Deserialize", Text = "Deserialize" });

    }

    private void ImageEditor_ToolbarItemSelected(object? sender, ToolbarItemSelectedEventArgs e)
    {
        if (e.ToolbarItem.Name == "Text1")
        {
            imageEditor.AddText("Syncfusion", new ImageEditorTextSettings() { Id = 111, Background = Colors.Blue, Bounds = new Rect(0.4, .8, 0.2, 0.2) });
        }
        else if(e.ToolbarItem.Name == "Shapes")
        {
            imageEditor.AddShape(AnnotationShape.Rectangle, new ImageEditorShapeSettings() { Id = 222, Color = Colors.Violet, IsFilled = true, Bounds = new Rect(0, 0, 0.3, 0.3) });
            imageEditor.AddShape(AnnotationShape.Circle, new ImageEditorShapeSettings() { Id = 333, Color = Colors.Orange, StrokeThickness = 5, Bounds = new Rect(0, 0.4, 0.4, 0.4) });
        }
        else if (e.ToolbarItem.Name == "CustomView")
        {
            Image customImage = new Image() { HeightRequest = 100, WidthRequest = 100 };
            customImage.Source = ImageSource.FromResource("ImageEditorSample.Resources.Images.dotnet_bot.png");
            imageEditor.AddCustomAnnotationView(customImage, new ImageEditorAnnotationSettings() { Id = 444, Bounds = new Rect(0.4, 0.2, 0.4, 0.4) });
            
            Button button = new Button() { Text = "Click"};
            imageEditor.AddCustomAnnotationView(button, new ImageEditorAnnotationSettings() { Id = 555 });
        }
        else if(e.ToolbarItem.Name == "Serialize")
        {
            if (stream == null)
            {
                stream = new MemoryStream();
            }
            
            this.imageEditor.Serialize(stream);
        }
        else if (e.ToolbarItem.Name == "Deserialize")
        {
            if (stream != null)
            {
                this.imageEditor.Deserialize(stream);
            }
        }
    }

    private void imageEditor_AnnotationSelected(object sender, Syncfusion.Maui.ImageEditor.AnnotationSelectedEventArgs args)
    {
        object uniqueID;
        ImageEditorShapeSettings shapeSettings = args.AnnotationSettings as ImageEditorShapeSettings;
        ImageEditorTextSettings textSettings = args.AnnotationSettings as ImageEditorTextSettings;
        if (shapeSettings != null)
        {
            uniqueID = shapeSettings.Id;
            ShapeSettings = shapeSettings;
        }
        else if (textSettings != null)
        {
            uniqueID = textSettings.Id;
        }
        else
        {
            uniqueID = args.AnnotationSettings.Id;
        }
    }

    private void SelectShape_Clicked(object sender, EventArgs e)
    {
        int shapeId;
        if (int.TryParse(this.shapeID.Text, out shapeId))
        {
            this.imageEditor.SelectAnnotation(shapeId);
        }
    }

    private void ChangeID_Clicked(object sender, EventArgs e)
    {
        if (ShapeSettings is ImageEditorAnnotationSettings shapeSettings)
        {
            shapeSettings.AllowDrag = false;
            ShapeSettings.Id = 5;
            ShapeID = 5;
        }
    }

    private void EditShape_Clicked(object sender, EventArgs e)
    {
        if (this.ShapeSettings.Id == "333")
        {
            if (ShapeSettings is ImageEditorShapeSettings shapeSettings)
            {
                shapeSettings.AllowDrag = false;
                shapeSettings.IsFilled = false;
                shapeSettings.Color = Colors.Yellow;
                shapeSettings.StrokeThickness = 5;
            }
        }
    }

    private void DeleteShape_Clicked(object sender, EventArgs e)
    {
        if (this.shapeID.Text == "444")
        {
            this.imageEditor.DeleteAnnotation();
        }
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

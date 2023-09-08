---
layout: post
title: Toolbar Customization in .NET MAUI Image Editor Control | Syncfusion
description: Learn here all about toolbar customization support in the Syncfusion .NET MAUI ImageEditor (SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Toolbar Customization in .NET MAUI Image Editor (SfImageEditor)

You can customize the existing toolbar appearance, visibility, position, and orientation of each toolbar and can include new toolbars.

## Toolbar style customization

You can customize the appearance of the toolbar by using the `ToolbarSettings` property. Below are some of the properties you can customize:

* `Background`: Specifies background color of the toolbar.
* `IconColor`: Specifies the color of the icons in the toolbar.
* `IconSize`: Specifies the size of the icons in the toolbar. The default value is 48.
* `DisabledColor`: Specifies the color of the disabled icons in the toolbar.

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="image.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings Background="LightGreen"
                                                IconColor="Tomato"
                                                DisabledColor="Lavender"
                                                IconSize="50, 50" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>
      
{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
imageEditor.ToolbarSettings.Background = Brush.LightGreen;
imageEditor.ToolbarSettings.IconColor = Colors.Tomato;
imageEditor.ToolbarSettings.DisabledColor = Colors.Lavender;
imageEditor.ToolbarSettings.IconSize = new Size(50, 50);

{% endhighlight %}

{% endtabs %}

## Toolbar Orientation

The toolbar orientation can be changed to achieve the desired design by using the `Orientation` property in the `ImageEditorToolbar` class. The default value is `ToolbarOrientation.Horizontal`.

For example, you can set the toolbar to a vertical orientation:

{% tabs %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
ImageEditorToolbar headerToolbar = imageEditor.Toolbars[0];
headerToolbar.Orientaion = ToolbarOrientation.Vertical;
    
{% endhighlight %}

{% endtabs %}

## Toolbar Position

The toolbar can be positioned before or after the image of the ImageEditor by using the `Position` property in the `ImageEditorToolbar` class. The default value is `ToolbarPosition.Start`.

{% tabs %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
ImageEditorToolbar footerToolbar = imageEditor.Toolbars[1];
footerToolbar.Position = ToolbarPosition.Start;
    
{% endhighlight %}

{% endtabs %}

### Toolbar size customization

The size of the toolbar can be adjusted by using the `Size` property in the `ImageEditorToolbar` class.

For horizontal orientation, the size will be considered as width, and for vertical orientation, it will be considered as height.

{% highlight C# %}

    SfImageEditor imageEditor = new SfImageEditor();
    imageEditor.Source = ImageSource.FromFile("image.png");
    imageEditor.Toolbars[0].Size = 80;
    imageEditor.Toolbars[1].Size = 50;

{% endhighlight %}

## Customize default crop option

You can show the required crop types alone in the crop types toolbar by using the `CropTypes` property in the `ImageEditorToolbarSettings` class.

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="image.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings CropTypes="Circle, Square, Free" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>

      
{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
imageEditor.ToolbarSettings.CropTypes = ImageCropType.Circle | ImageCropType.Square | ImageCropType.Free;

{% endhighlight %}

{% endtabs %}

## Customize default Effects option

You can show the required effect types alone in the effects toolbar by using the `EffectTypes` property in the `ImageEditorToolbarSettings` class.

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="image.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings EffectTypes="Hue, Blur, Brightness" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>
      
{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
imageEditor.ToolbarSettings.EffectTypes = ImageEffect.Hue | ImageEffect.Blur | ImageEffect.Brightness;

{% endhighlight %}

{% endtabs %}

## Customize default shape option

You can show the required shape types alone in the shapes toolbar by using the `Shapes` property in the `ImageEditorToolbarSettings` class.

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="image.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings Shapes="Circle, Line, DottedArrow, DoubleArrow" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>

{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
imageEditor.ToolbarSettings.Shapes = AnnotationShape.Circle | AnnotationShape.Line | AnnotationShape.DottedArrow | AnnotationShape.DoubleArrow;

{% endhighlight %}

{% endtabs %}

## To customize the ColorPalette

You can change the default colors of the `ColorPalette` in toolbar.

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="image.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings>
            <imageEditor:ImageEditorToolbarSettings.ColorPalette>
                <Color>Yellow</Color>
                <Color>Pink</Color>
                <Color>Violet</Color>
            </imageEditor:ImageEditorToolbarSettings.ColorPalette>
        </imageEditor:ImageEditorToolbarSettings>
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>
      
{% endhighlight %}

{% highlight C# %}

    SfImageEditor imageEditor = new SfImageEditor();
    imageEditor.Source = ImageSource.FromFile("image.png");
    imageEditor.ToolbarSettings.ColorPalette.Add(Colors.Yellow);
    imageEditor.ToolbarSettings.ColorPalette.Add(Colors.Pink);
    imageEditor.ToolbarSettings.ColorPalette.Add(Colors.Violet);

{% endhighlight %}

{% endtabs %}

N> Color palette colors are common for Text, Shape and Pen.

## Default Toolbar items

### Toolbar item

You can customize each toolbar item using the `Name` and `View` properties.

### Name

You can get or set the names of built-in toolbar and dynamically added toolbar items using the `Name` property.

{% highlight C# %}

public MainPage()
{			
    InitializeComponent();
    SfImageEditor imageEditor = new SfImageEditor();
    imageEditor.Source = ImageSource.FromFile("image.png");
    string itemName = imageEditor.Toolbars[1].ToolbarItems[0].Name;
}

{% endhighlight %}

N> The following built-in toolbar item names are available in image editor: `Browse`, `Undo`, `Redo`, `ZoomOut`, `ZoomIn`, `Reset`, `Save`, `SaveEdit`, `Crop`, `Shape`, `Text`, `Pen`, `Effects`, `Rotate`, `FlipHorizontal`, `FlipVertical`, `custom`, `original`, `ellipse`, `circle`, `square`, `3:1`, `3:2`, `4:3`, `5:4`, `7:5`, `16:9`, `Rectangle`, `Circle`, `Arrow`, `Line`, `Dotted`, `DoubleArrow`, `DottedArrow`, `DottedDoubleArrow`, `ShapeStrokeThickness`, `ShapeStrokeColor`, `ShapeFill`, `ShapeStroke`, `AddText`, `StrokeThickness`, `Delete`, `FontFamily`, `TextAlignment`, `FontAttributes`, `TextColor`, `Start`, `Center`, `End`, `DefaultText`, `Handlee`, `Pinyon Script`, `Kaushan Script`, `Boogaloo`, `Bold`, `Italic`, `Color`, `ShapeStrokeOpacity`, `PenStrokeOpacity`, `TextColorOpacity`, `PenStrokeThickness`, `PenStrokeColor`, `Back`, `Blur`, `Contrast`, `Sharpen`, `Brightness`, `Saturation`, `Hue`, `Opacity`,  and `Exposure`.

N> You cannot modify the names of existing built-in toolbar items and cannot create toolbar item with these list.

## Get an item from default top toolbar

The default top toolbar contains 3 groups and each group contains its own items. You can get the `ImageEditorToolbarItem` and customize the properties.

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");

ImageEditorToolbar headerToolbar = imageEditor.Toolbars[0];
ImageEditorToolbarGroupItem browseGroup = (ImageEditorToolbarGroupItem) headerToolbar.ToolbarItems[0];
ImageEditorToolbarItem browseItem = browseGroup.Items.FirstOrDefault();
ImageEditorToolbarGroupItem saveGroup = (ImageEditorToolbarGroupItem) headerToolbar.ToolbarItems[2];
ImageEditorToolbarItem saveItem = saveGroup.Items.FirstOrDefault(i => i.Name == "Save");

{% endhighlight %}

## Get an item from default bottom toolbar

The default bottom toolbar contains `ToolbarItems` and each item has the `SubToolbars`. You can get the required `ImageEditorToolbarItem` using the `Name` and customize the default settings.

Refer to the following code snippet to customize footer toolbar item.

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
ImageEditorToolbar footerToolbar = imageEditor.Toolbars[1];
ImageEditorToolbarItem textItem = (ImageEditorToolbarItem)footerToolbar.ToolbarItems.FirstOrDefault(i => i.Name == "Text");

{% endhighlight %}

## Get an item from sub toolbar

The sub-toolbars contains it's own items and it can be retried as below.

Refer to the following code snippet to customize sub items of bottom toolbar item.

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
ImageEditorToolbar footerToolbar = imageEditor.Toolbars[1];
ImageEditorToolbarItem shapeItem = (ImageEditorToolbarItem)footerToolbar.ToolbarItems.FirstOrDefault(i => i.Name == "Shape");
ImageEditorToolbar subtoolbar = shapeItem.SubToolbars[0];
ImageEditorToolbarItem arrowItem = (ImageEditorToolbarItem)subtoolbar.ToolbarItems.FirstOrDefault(i => i.Name == "Arrow");

{% endhighlight %}

N> You can remove the existing toolbar items `Name` from image editor toolbarItems collection based on the index value and change the icon and text values dynamically for any of the already added toolbar item based on the index.

## To change item visibility

You can hide or show the toolbar items by specifying their icon names and setting the boolean values to true or false.

N> You can customize an icon by specifying its `Name`.

{% tabs %}

{% highlight C# %}

        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromFile("image.png");
        imageEditor.SetToolbarItemVisibility("Shape", false);

{% endhighlight %}

{% endtabs %}

## To change item enable state

You can enable or disable the toolbar items by using `IsEnabled` property in `ImageEditorToolbarItem` class. Specifying their icon names and setting the boolean values to true or false.

{% tabs %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");

ImageEditorToolbar headerToolbar = imageEditor.Toolbars[0];
ImageEditorToolbarGroupItem browseGroup = (ImageEditorToolbarGroupItem) headerToolbar.ToolbarItems[0];
ImageEditorToolbarItem browseItem = browseGroup.Items.FirstOrDefault();
browseItem.IsEnabled = false;

ImageEditorToolbarGroupItem saveGroup = (ImageEditorToolbarGroupItem) headerToolbar.ToolbarItems[2];
ImageEditorToolbarItem saveItem = saveGroup.Items.FirstOrDefault(i => i.Name == "Save");
saveItem.IsEnabled = false;

{% endhighlight %}

{% endtabs %}

## To change item view

To Customize the toolbar items view by specifying their icon names and setting the view using `View` property in `ImageEditorToolbarItem`.

{% tabs %}

{% highlight C# %}

Image image = new Image();
image.Source = ImageSource.FromResource("MyProject.Resources.Images.zoom.jpg");

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");

ImageEditorToolbar headerToolbar = imageEditor.Toolbars[0];
ImageEditorToolbarGroupItem zoomGroup = (ImageEditorToolbarGroupItem)headerToolbar.ToolbarItems[1];
ImageEditorToolbarItem zoomItem = (zoomGroup).Items.FirstOrDefault(i => i.Name == "ZoomIn");
zoomItem.View = image;

{% endhighlight %}

{% endtabs %}

## Add a new sub toolbar by clearing existing sub toolbar 

You can create `SubToolbars` within your toolbar items to organize related actions.

{% tabs %}

{% highlight XAML %}

<imageEditor:SfImageEditor Source="image.png"
                           AutoGenerateToolbarItems="False">
    <imageEditor:SfImageEditor.Toolbars>
        <imageEditor:ImageEditorToolbar Orientaion="Vertical"
                                        Position="End">
            <imageEditor:ImageEditorToolbar.ToolbarItems>
                <imageEditor:ImageEditorToolbarItem Name="Text">
                    <imageEditor:ImageEditorToolbarItem.SubToolbars>
                        <imageEditor:ImageEditorToolbar>
                            <imageEditor:ImageEditorToolbar.ToolbarItems>
                                <imageEditor:ImageEditorToolbarItem Name="AddText" />
                                <imageEditor:ImageEditorToolbarItem Name="TextColor" />
                                <imageEditor:ImageEditorToolbarItem Name="Delete" />
                            </imageEditor:ImageEditorToolbar.ToolbarItems>
                        </imageEditor:ImageEditorToolbar>
                    </imageEditor:ImageEditorToolbarItem.SubToolbars>
                </imageEditor:ImageEditorToolbarItem>
                <imageEditor:ImageEditorToolbarItem Name="Shape" />
                <imageEditor:ImageEditorToolbarItem Name="Pen" />
            </imageEditor:ImageEditorToolbar.ToolbarItems>
        </imageEditor:ImageEditorToolbar>
    </imageEditor:SfImageEditor.Toolbars>
</imageEditor:SfImageEditor>

{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
imageEditor.AutoGenerateToolbarItems = false;
ImageEditorToolbar editorToolbar = new ();
editorToolbar.Orientaion = ToolbarOrientation.Vertical;
editorToolbar.Position = ToolbarPosition.End;
editorToolbar.ToolbarItems = new List<IImageEditorToolbarItem>()
{
    new ImageEditorToolbarItem(){ Name = "Text",
        SubToolbars = new List<ImageEditorToolbar>()
        {
            new ImageEditorToolbar()
            {
                ToolbarItems = new List<IImageEditorToolbarItem>()
                {
                   new ImageEditorToolbarItem(){ Name = "AddText"},
                   new ImageEditorToolbarItem(){ Name = "TextColor"},
                   new ImageEditorToolbarItem(){ Name = "Delete"}
                },
            }
        }
    },
    new ImageEditorToolbarItem(){ Name = "Shape"},
    new ImageEditorToolbarItem(){ Name = "Pen"}
};

imageEditor.Toolbars.Add(editorToolbar);

{% endhighlight %}

{% endtabs %}

## Add an item with the existing toolbar.

Creating custom toolbars in SfImageEditor provides you with complete control over the layout and content of your app's toolbar.

{% tabs %}

{% highlight XAML %}

<imageEditor:SfImageEditor Source="image.png">
    <imageEditor:SfImageEditor.Toolbars>
        <imageEditor:ImageEditorToolbar>
            <imageEditor:ImageEditorToolbar.ToolbarItems>
                <imageEditor:ImageEditorToolbarItem Name="Browse" />
                <imageEditor:ImageEditorToolbarItem Name="Save" />
            </imageEditor:ImageEditorToolbar.ToolbarItems>
        </imageEditor:ImageEditorToolbar>
        <imageEditor:ImageEditorToolbar>
            <imageEditor:ImageEditorToolbar.ToolbarItems>
                <imageEditor:ImageEditorToolbarItem Name="Text" />
                <imageEditor:ImageEditorToolbarItem Name="Shape" />
                <imageEditor:ImageEditorToolbarItem Name="Pen" />
            </imageEditor:ImageEditorToolbar.ToolbarItems>
        </imageEditor:ImageEditorToolbar>
    </imageEditor:SfImageEditor.Toolbars>
</imageEditor:SfImageEditor>

{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
ImageEditorToolbar editorToolbar = new ();
editorToolbar.ToolbarItems = new List<IImageEditorToolbarItem>()
{
    new ImageEditorToolbarItem(){ Name = "Browse"},
    new ImageEditorToolbarItem(){ Name = "Save"}
};

ImageEditorToolbar annotationToolbar = new ();
editorToolbar1.ToolbarItems = new List<IImageEditorToolbarItem>()
{
    new ImageEditorToolbarItem(){ Name = "Text"},
    new ImageEditorToolbarItem(){ Name = "Shape"},
    new ImageEditorToolbarItem(){ Name = "Pen"}
};

imageEditor.Toolbars.Add(editorToolbar);
imageEditor.Toolbars.Add(annotationToolbar);
    
{% endhighlight %}

{% endtabs %}

## Explicitly create Toolbars

The ImageEditor auto-generates the toolbars, You can explicitly add the Toolbars by adding the Toolbars manually and you need to change the `AutoGenerateToolbarItems` property to `false`.

{% tabs %}

{% highlight XAML %}

<imageEditor:SfImageEditor Source="image.png"
                           AutoGenerateToolbarItems="False">
    <imageEditor:SfImageEditor.Toolbars>
        <imageEditor:ImageEditorToolbar Position="End">
            <imageEditor:ImageEditorToolbar.ToolbarItems>
                <imageEditor:ImageEditorToolbarGroupItem Alignment="Start">
                    <imageEditor:ImageEditorToolbarGroupItem.Items>
                        <imageEditor:ImageEditorToolbarItem Name="Browse" />
                        <imageEditor:ImageEditorToolbarItem Name="Save" />
                    </imageEditor:ImageEditorToolbarGroupItem.Items>
                </imageEditor:ImageEditorToolbarGroupItem>
                <imageEditor:ImageEditorToolbarGroupItem Alignment="End">
                    <imageEditor:ImageEditorToolbarGroupItem.Items>
                        <imageEditor:ImageEditorToolbarItem Name="Reset" />
                        <imageEditor:ImageEditorToolbarItem Name="SaveEdit" />
                    </imageEditor:ImageEditorToolbarGroupItem.Items>
                </imageEditor:ImageEditorToolbarGroupItem>
            </imageEditor:ImageEditorToolbar.ToolbarItems>
        </imageEditor:ImageEditorToolbar>
    </imageEditor:SfImageEditor.Toolbars>
</imageEditor:SfImageEditor>

{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
imageEditor.AutoGenerateToolbarItems = false;
ImageEditorToolbar editorToolbar = new ();
editorToolbar.Position = ToolbarPosition.End;

ImageEditorToolbarGroupItem browseGroup = new ()
{
    Alignment = ToolbarGroupItemAlignment.Start,
    Items = new List<ImageEditorToolbarItem>()
        {
            new ImageEditorToolbarItem(){ Name ="Browse"},
            new ImageEditorToolbarItem(){ Name ="Reset"  }
        }
};

ImageEditorToolbarGroupItem saveGroup = new ()
{
    Alignment = ToolbarGroupItemAlignment.End,
    Items = new List<ImageEditorToolbarItem>()
        {
            new ImageEditorToolbarItem(){ Name ="Save"},
            new ImageEditorToolbarItem(){ Name ="SaveEdit"}
        }
};

editorToolbar.ToolbarItems.Add(browseGroup);
editorToolbar.ToolbarItems.Add(saveGroup);
imageEditor.Toolbars.Add(editorToolbar);
    
{% endhighlight %}

{% endtabs %}

## SubToolbar with explicit toolbars

You can create `SubToolbars` within our default toolbar items to organize related actions.

{% tabs %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image.png");
ImageEditorToolbar footerToolbar = imageEditor.Toolbars[1];
ImageEditorToolbarItem shapeItem = (ImageEditorToolbarItem)footerToolbar.ToolbarItems.FirstOrDefault(i => i.Name == "Shape");
shapeItem.SubToolbars = new List<ImageEditorToolbar>()
{
    new ImageEditorToolbar()
    {
        ToolbarItems = new List<IImageEditorToolbarItem>()
        {
           new ImageEditorToolbarItem(){ Name = "Circle"},
           new ImageEditorToolbarItem(){ Name = "Pen"},
           new ImageEditorToolbarItem(){ Name = "AddText"}
        },
    }
};

{% endhighlight %}

{% endtabs %}

## ToolbarItemSelected event 

Whenever you tap the toolbar menu item, the `ToolbarItemSelected` event will be triggered, and you can get the respective tapped toolbar item as an argument as shown in the following code snippet. 

Default toolbar item action can be restricted by setting `e.cancel` to `true`.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" ToolbarItemSelected = "OnImageEditorToolbarItemSelected" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
    private void OnImageEditorToolbarItemSelected(object sender, ToolbarItemSelectedEventArgs e)
    {
        DisplayAlert("Selected ToolbarItem is  " + e.ToolbarItem.Name, "Ok", "Cancel");
    }

{% endhighlight %}

{% endtabs %}
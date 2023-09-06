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

customize the appearance of the toolbar by using the `ToolbarSettings` property. Below are some of the properties you can customize:

* `Background`: Specifies background color of the toolbar.
* `IconColor`: Specifies the color of the icons in the toolbar.
* `IconSize`: Specifies the size of the icons in the toolbar. The default value is 44.
* `DisabledColor`: Specifies the color of the disabled icons in the toolbar.

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="table.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings Background="LightGreen"
                                                IconColor="Tomato"
                                                DisabledColor="Lavender"
                                                IconSize="50" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>
      
{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image4.png");
imageEditor.ToolbarSettings.Background = Brush.LightGreen;
imageEditor.ToolbarSettings.IconColor = Colors.Tomato;
imageEditor.ToolbarSettings.DisabledColor = Colors.Lavender;
imageEditor.ToolbarSettings.IconSize = new Size(50, 50);

{% endhighlight %}

{% endtabs %}

## Toolbar Orientation

To customize the layout of toolbars to achieve the desired design by using the `Orientation` property in the `ImageEditorToolbar` class. The default value is `ToolbarOrientation.Horizontal`.

For example, you can set the header toolbar to a vertical orientation:

{% tabs %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image4.png");
var headerToolbar = imageEditor.Toolbars[0];
headerToolbar.Orientaion = ToolbarOrientation.Vertical;
    
{% endhighlight %}

{% endtabs %}

## Toolbar Position

To adjust the alignment of the toolbar by using the `Position` property in the `ImageEditorToolbar` class. The default value is `ToolbarPosition.Start`.

{% tabs %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image4.png");
var footerToolbar = imageEditor.Toolbars[1];
footerToolbar.Position = ToolbarPosition.Start;
    
{% endhighlight %}

{% endtabs %}

### Toolbar size customization

The toolbar items will be resized based on the size. size will be considered as width for origentation is horizontal and height for orientation is vertical. To change the height of the toolbar, refer to the following code snippet.

{% highlight C# %}

    SfImageEditor imageEditor = new SfImageEditor();
    imageEditor.Source = ImageSource.FromFile("image4.png");
    imageEditor.Toolbars[0].Size = 80;
    imageEditor.Toolbars[1].Size = 50;

{% endhighlight %}

## Customize default crop option

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="table.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings CropTypes="Circle,Square,Free" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>

      
{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image4.png");
imageEditor.ToolbarSettings.CropTypes = ImageCropType.Square;

{% endhighlight %}

{% endtabs %}

## Customize default Effects option

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="table.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings EffectTypes="Hue, Blur" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>
      
{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image4.png");
imageEditor.ToolbarSettings.EffectTypes = ImageEffect.Blur;

{% endhighlight %}

{% endtabs %}

## Customize default shape option

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="table.png">
    <imageEditor:SfImageEditor.ToolbarSettings>
        <imageEditor:ImageEditorToolbarSettings Shapes="Circle, Line" />
    </imageEditor:SfImageEditor.ToolbarSettings>
</imageEditor:SfImageEditor>

{% endhighlight %}

{% highlight C# %}

SfImageEditor imageEditor = new SfImageEditor();
imageEditor.Source = ImageSource.FromFile("image4.png");
imageEditor.ToolbarSettings.Shapes = AnnotationShape.Line;

{% endhighlight %}

{% endtabs %}

## To customize the ColorPalette

You can change the default colors of the `ColorPalette` in toolbar.

{% tabs %}

{% highlight XAML %}
  
<imageEditor:SfImageEditor Source="table.png">
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
    imageEditor.Source = ImageSource.FromFile("image4.png");
    imageEditor.ToolbarSettings.ColorPalette.Add(Colors.Yellow);
    imageEditor.ToolbarSettings.ColorPalette.Add(Colors.Pink);
    imageEditor.ToolbarSettings.ColorPalette.Add(Colors.Violet);

{% endhighlight %}

{% endtabs %}

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
                imageEditor.Source = ImageSource.FromFile("image4.png");
                string itemName = imageEditor.Toolbars[1].ToolbarItems[0].Name;
            }

{% endhighlight %}

N> The following built-in toolbar item names are available in image editor: `Browse`, `Undo`, `Redo`, `ZoomOut`, `ZoomIn`, `Reset`, `Save`, `SaveEdit`, `Crop`, `Shape`, `Text`, `Pen`, `Effects`, `Rotate`, `FlipHorizontal`, `FlipVertical`, `custom`, `original`, `ellipse`, `circle`, `square`, `3:1`, `3:2`, `4:3`, `5:4`, `7:5`, `16:9`, `Rectangle`, `Circle`, `Arrow`, `Line`, `Dotted`, `DoubleArrow`, `DottedArrow`, `DottedDoubleArrow`, `ShapeStrokeThickness`, `ShapeStrokeColor`, `ShapeFill`, `ShapeStroke`, `AddText`, `StrokeThickness`, `Delete`, `FontFamily`, `TextAlignment`, `FontAttributes`, `TextColor`, `Start`, `Center`, `End`, `DefaultText`, `Handlee`, `Pinyon Script`, `Kaushan Script`, `Boogaloo`, `Bold`, `Italic`, `Color`, `ShapeStrokeOpacity`, `PenStrokeOpacity`, `TextColorOpacity`, `PenStrokeThickness`, `PenStrokeColor`, `Back`, `Blur`, `Contrast`, `Sharpen`, `Brightness`, `Saturation`, `Hue`, `Opacity`,  and `Exposure`.

N> You cannot modify the names of existing built-in toolbar items and cannot create toolbar item with these list.

## To get an item from inbuilt top toolbar

The `ImageEditorToolbarItem` is placed on the top of the image editor, and you can customize the header toolbar item using the `View` and `Name` properties:

{% highlight C# %}

        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromFile("image4.png");
        var headerToolbar = imageEditor.Toolbars[0].ToolbarItems[0] as ImageEditorToolbarGroupItem;
        headerToolbar.Items.Add(new ImageEditorToolbarItem { Name = "Share", View = new Image { Source = ImageSource.FromFile("share.png") }});

{% endhighlight %}

## To get an item from inbuilt bottom toolbar

The `ImageEditorToolbarItem` is placed on the bottom of the image editor, and you can customize the footer toolbar item using the `View` and `Name` properties.

Refer to the following code snippet to customize footer toolbar item.

{% highlight C# %}

        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromFile("image4.png");
        var footerToolbar = imageEditor.Toolbars[1];
        footerToolbar.ToolbarItems.Add(new ImageEditorToolbarItem { Name = "Share", View = new Image { Source = ImageSource.FromFile("image4.png") }});

{% endhighlight %}

## To get an item from sub toolbar

The `SubItems` is only applicable for `FooterToolbarItem`, and it represents grouped action of respective footer toolbar item. The SubItems will be placed above the footer toolbar item layout, and you can also customize the appearance of sub items as main toolbar items.

Refer to the following code snippet to customize sub items of footer toolbar item.

{% highlight C# %}

 	editor.ToolbarSettings.ToolbarItems.Add(new FooterToolbarItem()
            {
                Text = "More",
                Icon = ImageSource.FromResource("ImageEditor.Image.more.png"),
                SubItems = new ObservableCollection<ToolbarItem>()
                {
                   new ToolbarItem() {
                Icon = ImageSource.FromResource("ImageEditor.Image.download.png")
                },
                   new ToolbarItem() {
                Icon = ImageSource.FromResource("ImageEditor.Image.share.png")
                } }
            });

{% endhighlight %}

N> You can remove the existing toolbar items `Name` from image editor toolbarItems collection based on the index value and change the icon and text values dynamically for any of the already added toolbar item based on the index as shown in the following code snippet.

{% highlight C# %}

editor.ToolbarSettings.ToolbarItems[5].Text = "new item";
editor.ToolbarSettings.ToolbarItems[3].Icon = ImageSource.FromResource("ImageEditor.Image.jpg");

{% endhighlight %}

## To change item visibility

You can hide or show the toolbar items by specifying their icon names and setting the boolean values to true or false.

N> You can customize an icon by specifying its `Name`.

{% tabs %}

{% highlight C# %}

        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromFile("image4.png");
        imageEditor.SetToolbarItemVisibility("Shape", false);

{% endhighlight %}

{% endtabs %}

## To change item enable state

You can hide or show the toolbar items by specifying their icon names and setting the boolean values to true or false.

N> You can customize an icon by specifying its `Name`.

{% tabs %}

{% highlight C# %}

        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromFile("image4.png");
        imageEditor.SetToolbarItemVisibility("Shape", false);

{% endhighlight %}

{% endtabs %}

## To change item view

You can hide or show the toolbar items by specifying their icon names and setting the boolean values to true or false.

N> You can customize an icon by specifying its `Name`.

{% tabs %}

{% highlight C# %}

        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromFile("image4.png");
        imageEditor.SetToolbarItemVisibility("Shape", false);

{% endhighlight %}

{% endtabs %}

## Custom Toolbar

Creating custom toolbars in SfImageEditor provides you with complete control over the layout and content of your app's toolbar. 

{% tabs %}

{% highlight XAML %}

<imageEditor:SfImageEditor Source="table.png"
                           AutoGenerateToolbarItems="False">
    <imageEditor:SfImageEditor.Toolbars>
        <imageEditor:ImageEditorToolbar Orientaion="Vertical">
            <imageEditor:ImageEditorToolbar.ToolbarItems>
                <imageEditor:ImageEditorToolbarItem Name="Browse" />
                <imageEditor:ImageEditorToolbarItem Name="Save" />
            </imageEditor:ImageEditorToolbar.ToolbarItems>
        </imageEditor:ImageEditorToolbar>
        <imageEditor:ImageEditorToolbar Orientaion="Vertical"
                                        Position="End">
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
imageEditor.Source = ImageSource.FromFile("image4.png");
imageEditor.AutoGenerateToolbarItems = false;
var editorToolbar = new ImageEditorToolbar();
editorToolbar.Orientaion = ToolbarOrientation.Vertical;
editorToolbar.ToolbarItems = new List<IImageEditorToolbarItem>()
{
    new ImageEditorToolbarItem(){ Name = "Browse"},
    new ImageEditorToolbarItem(){ Name = "Save"}
};
var editorToolbar1 = new ImageEditorToolbar();
editorToolbar1.Orientaion = ToolbarOrientation.Vertical;
editorToolbar1.Position = ToolbarPosition.End;
editorToolbar1.ToolbarItems = new List<IImageEditorToolbarItem>()
{
    new ImageEditorToolbarItem(){ Name = "Text"},
    new ImageEditorToolbarItem(){ Name = "Shape"},
    new ImageEditorToolbarItem(){ Name = "Pen"}
};

imageEditor.Toolbars.Add(editorToolbar);
imageEditor.Toolbars.Add(editorToolbar1);
    
{% endhighlight %}

{% endtabs %}

## Custom sub toolbar

You can create sub toolbars within your toolbar items to organize related actions.

{% tabs %}

{% highlight XAML %}

<imageEditor:SfImageEditor Source="table.png"
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
imageEditor.Source = ImageSource.FromFile("image4.png");
imageEditor.AutoGenerateToolbarItems = false;
var editorToolbar = new ImageEditorToolbar();
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

## Custom group item toolbar

Grouping toolbar items allows you to organize actions efficiently. You can place items in various alignments to suit your app's design.

{% tabs %}

{% highlight XAML %}

<imageEditor:SfImageEditor Source="table.png"
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
imageEditor.Source = ImageSource.FromFile("image4.png");
imageEditor.AutoGenerateToolbarItems = false;
var editorToolbar = new ImageEditorToolbar();
editorToolbar.Position = ToolbarPosition.End;

var groupItem = new ImageEditorToolbarGroupItem()
{
    Alignment = ToolbarGroupItemAlignment.Start,
    Items = new List<ImageEditorToolbarItem>()
        {
            new ImageEditorToolbarItem(){ Name ="Browse"},
            new ImageEditorToolbarItem(){ Name ="Save"  }
        }
};

var groupItem1 = new ImageEditorToolbarGroupItem()
{
    Alignment = ToolbarGroupItemAlignment.End,
    Items = new List<ImageEditorToolbarItem>()
        {
            new ImageEditorToolbarItem(){ Name ="Reset"},
            new ImageEditorToolbarItem(){ Name ="SaveEdit"}
        }
};

editorToolbar.ToolbarItems.Add(groupItem);
editorToolbar.ToolbarItems.Add(groupItem1);
imageEditor.Toolbars.Add(editorToolbar);
    
{% endhighlight %}

{% endtabs %}

## ToolbarItemSelected event 

Whenever you tap the toolbar menu item, the `ToolbarItemSelected` event will be triggered, and you can get the respective tapped toolbar item as an argument as shown in the following code snippet. 

Default toolbar item action can be restricted by setting `e.cancel` to `true`.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" ToolbarItemSelected = "imageEditor_ToolbarItemSelected" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
    private void imageEditor_ToolbarItemSelected(object sender, ToolbarItemSelectedEventArgs e)
    {
        DisplayAlert("Selected ToolbarItem is  " + e.ToolbarItem.Name, "Ok", "Cancel");
    }

{% endhighlight %}

{% endtabs %}
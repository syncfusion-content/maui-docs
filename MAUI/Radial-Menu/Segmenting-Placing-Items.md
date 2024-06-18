---
layout: post
title: Segmenting and Placing the Items in .NET MAUI Radial Menu | Syncfusion
description: Learn about Segmenting and Placing the Items in .NET MAUI Radio Menu control, its elements and more.
platform: MAUI
control: RadialMenu (SfRadialMenu)
documentation: ug
---

# Segmenting and Placing the Items in .NET MAUI Radial Menu

There are two different layout types available for radial menu:

*  `Default`
*  `Custom`

Both the layout types divide the available space equally among all the children in the circular panel.

## Default

Number of segments in the panel is determined by children count in the level. Hence, segment count in each hierarchical level differs, radial menu items are arranged in the sequential order as added in the radial menu.

{% tabs %}

{% highlight xaml %}

 <radialMenu:SfRadialMenu LayoutType="Default">
        <radialMenu:SfRadialMenu.Items>
            <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
        </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

 SfRadialMenu radialMenu = new SfRadialMenu() 
 {
     LayoutType = LayoutType.Default
 };

{% endhighlight %}

{% endtabs %}

## Custom

The number of segments in the panel is determined using the `VisibleSegmentsCount` property. Since the segment count in all the hierarchical levels are same, radial menu items are arranged in any order based on the `SegmentIndex` property.

{% tabs %}

{% highlight xaml %}

    <radialMenu:SfRadialMenu LayoutType="Custom">
        <radialMenu:SfRadialMenu.Items>
            <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
        </radialMenu:SfRadialMenu.Items>
    </radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

 SfRadialMenu radialMenu = new SfRadialMenu() 
 {
     LayoutType = LayoutType.Custom
 };

{% endhighlight %}

{% endtabs %}

### VisibleSegmentsCount

The `VisibleSegmentsCount` property is used to specify the number of segments available in circular panel. When children count is greater than the value given in the `VisibleSegmentsCount` property, the overflowing children are not arranged in the panel. When children count is lesser than the `VisibleSegmentsCount` property, then remaining segments are left free. If number of item count is higher than VisibleItemCount, excessive items will not be shown.

### SegmentIndex

`SegmentIndex` property is used to specify the index of the radial menu item in circular panel. Based on the index, the radial menu items are inserted in the segment. When the `SegmentIndex` is not specified for a RadialMenuItem the menu item is arranged in the next available free segment.

## Code snippet for VisibleSegmentCount and SegmentIndex

{% tabs %}

{% highlight xaml %}

     <radialMenu:SfRadialMenu x:Name="radial_Menu"
                              CenterButtonFontFamily="MauiSampleFontIcon"
                              CenterButtonFontSize="30"
                              CenterButtonStrokeThickness="3"
                              CenterButtonText="&#xe770;"
                              LayoutType="Custom"
                              RimColor="Transparent"
                              RimRadius="300"
                              SeparatorThickness="0"
                              VisibleSegmentsCount="12">
                                <radialMenu:SfRadialMenu.Items>
                                    <radialMenu:SfRadialMenuItem
                                        x:Name="Linkedin"
                                        BackgroundColor="Transparent"
                                        FontFamily="MauiSampleFontIcon"
                                        FontSize="40"
                                        ItemHeight="40"
                                        ItemWidth="40"
                                        SegmentIndex="0"
                                        Text="&#xe79c;" />
                                    <radialMenu:SfRadialMenuItem
                                        x:Name="Facebook"
                                        BackgroundColor="Transparent"
                                        FontFamily="MauiSampleFontIcon"
                                        FontSize="40"
                                        ItemHeight="40"
                                        ItemWidth="40"
                                        SegmentIndex="1"
                                        Text="&#xe799;" />
                                    <radialMenu:SfRadialMenuItem
                                        x:Name="pinterest"
                                        BackgroundColor="Transparent"
                                        FontFamily="MauiSampleFontIcon"
                                        FontSize="40"
                                        ItemHeight="40"
                                        ItemWidth="40"
                                        SegmentIndex="2"
                                        Text="&#xe79b;" />
                                    <radialMenu:SfRadialMenuItem
                                        x:Name="twitter"
                                        BackgroundColor="Transparent"
                                        FontFamily="MauiSampleFontIcon"
                                        FontSize="40"
                                        ItemHeight="40"
                                        ItemWidth="40"
                                        SegmentIndex="3"
                                        Text="&#xe79a;" />
                                </radialMenu:SfRadialMenu.Items>
     </radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.RadialMenu;

namespace RadialSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SfRadialMenu radialMenu = new SfRadialMenu()
            {
                CenterButtonFontFamily = "MauiSampleFontIcon",
                CenterButtonFontSize = 30,
                CenterButtonStrokeThickness = 3,
                CenterButtonText = "&#xe770;",
                LayoutType = RadialMenuLayoutType.Custom,
                RimColor = Colors.Transparent,
                RimRadius = 300,
                SeparatorThickness = 0,
                VisibleSegmentsCount = 12
            };

            SfRadialMenuItem linkedinItem = new SfRadialMenuItem
            {
                BackgroundColor = Colors.Transparent,
                FontFamily = "MauiSampleFontIcon",
                FontSize = 40,
                ItemHeight = 40,
                ItemWidth = 40,
                SegmentIndex = 0,
                Text = "&#xe79c"
            };

            SfRadialMenuItem facebookItem = new SfRadialMenuItem
            {
                BackgroundColor = Colors.Transparent,
                FontFamily = "MauiSampleFontIcon",
                FontSize = 40,
                ItemHeight = 40,
                ItemWidth = 40,
                SegmentIndex = 1,
                Text = "&#xe799;"
            };

            SfRadialMenuItem pinterestItem = new SfRadialMenuItem
            {
                BackgroundColor = Colors.Transparent,
                FontFamily = "MauiSampleFontIcon",
                FontSize = 40,
                ItemHeight = 40,
                ItemWidth = 40,
                SegmentIndex = 2,
                Text = "&#xe79b;" 
            };

            SfRadialMenuItem twitterItem = new SfRadialMenuItem
            {
                BackgroundColor = Colors.Transparent,
                FontFamily = "MauiSampleFontIcon",
                FontSize = 40,
                ItemHeight = 40,
                ItemWidth = 40,
                SegmentIndex = 3,
                Text = "&#xe79a;"
            };

            radialMenu.Items.Add(linkedinItem);
            radialMenu.Items.Add(facebookItem);
            radialMenu.Items.Add(pinterestItem);
            radialMenu.Items.Add(twitterItem);

            Content = radialMenu;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![VisibleSegment.](images/segmentation/maui-radialmenu-segmentation-segmentIndex.png)

N> The `VisibleSegmentsCount` property is only applicable for `Custom` layout.
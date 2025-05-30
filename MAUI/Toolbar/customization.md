---
layout: post
title: Customization in .NET .NET MAUI Toolbar Control | Syncfusion®
description: Learn here all about Customization support in Syncfusion® .NET .NET MAUI Toolbar (SfToolbar) Control and more.
platform: .NET MAUI
Control: Toolbar (SfToolbar)
documentation: ug
---

# Customization in .NET MAUI Toolbar (SfToolbar)

This section explains the ways about support for customization in Syncfusion .NET .NET MAUI Toolbar (SfToolbar) Control.

## Toolbar Item Customization

The Toolbar Control supports customization of Toolbar Items using Properties [IsEnabled](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbarItem.html#Syncfusion_Maui_Toolbar_SfToolbarItem_IsEnabled),[TextStyle](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbarItem.html#Syncfusion_Maui_Toolbar_SfToolbarItem_TextStyle) and `Color`.

* **IsEnabled** : This Property is used to enable or disable the Toolbar Item.
* **TextStyle** : This Property is used to customize the text style of the Toolbar Item.
* **Color** : This Property is used to set Color for the Icon in the Toolbar.

The following code sample demonstrates how to create a Toolbar Control with Toolbar Items customization.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout  VerticalOptions="Center">
    <Toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="850">
        <Toolbar:SfToolbar.Items>
            <Toolbar:SfToolbarItem Name="Bold"
                        Text="Bold"
                        TextPosition="Right"
                        ToolTipText="Bold"
                        Size="60,56">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
 FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
                <Toolbar:SfToolbarItem.TextStyle>
                    <Toolbar:ToolbarTextStyle TextColor="Red"
                  FontSize="14"
                  FontAttributes="Bold"
                  FontFamily="OpenSansSemibold"
                  FontAutoScalingEnabled="True"/>
                </Toolbar:SfToolbarItem.TextStyle>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="Italic"
                       Text="Italic"
                       TextPosition="Right"
                       ToolTipText="Italic"
                       Size="60,56">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
 FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
                <Toolbar:SfToolbarItem.TextStyle>
                    <Toolbar:ToolbarTextStyle TextColor="Green"
                  FontSize="16"
                  FontAttributes="Italic"
                  FontFamily="OpenSansRegular"
                  FontAutoScalingEnabled="False"/>
                </Toolbar:SfToolbarItem.TextStyle>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Text="Underline" 
        TextPosition="Right" Size="100,56" IsEnabled="False"
                ToolTipText="Underline">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
            FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Text="AlignLeft" TextPosition="Right" Size="100,56" IsEnabled="False"
                        ToolTipText="Align-Left">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
            FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Text="AlignRight" TextPosition="Right" Size="100,56"
                        ToolTipText="Align-Right">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;" Color="Black"
            FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Text="AlignCenter" TextPosition="Right" Size="120,56"
                        ToolTipText="Align-Center">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;" Color="Blue"
            FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Text="AlignJustify" TextPosition="Right" Size="110,56"
                        ToolTipText="Align-Justify">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Color="Red" Glyph="&#xE74F;"
            FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
        </Toolbar:SfToolbar.Items>
    </Toolbar:SfToolbar>
</VerticalStackLayout> 

{% endhighlight %}

{% highlight c# %}

 public partial class MainPage : ContentPage
 {
     public MainPage()
     {
         InitializeComponent();
         SfToolbar Toolbar = new SfToolbar();
         Toolbar.HeightRequest = 56;
         ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
         {
             new SfToolbarItem
             {
                 Name = "Bold",
                 Text = "Bold",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Bold",
                 Size = new Size(60, 56),
                 Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" },
                 TextStyle = new ToolbarTextStyle
                 {
                     TextColor = Colors.Red,
                     FontSize = 14,
                     FontAttributes = FontAttributes.Bold,
                     FontFamily = "OpenSansSemibold",
                     FontAutoScalingEnabled = true
                 }
             },
             new SfToolbarItem
             {
                 Name = "Italic",
                 Text = "Italic",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Italic",
                 Size = new Size(60, 56),
                 Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" },
                 TextStyle = new ToolbarTextStyle
                 {
                     TextColor = Colors.Green,
                     FontSize = 16,
                     FontAttributes = FontAttributes.Italic,
                     FontFamily = "OpenSansRegular",
                     FontAutoScalingEnabled = false
                 }
             },
             new SfToolbarItem
             {
                 Text = "Underline",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Underline",
                 Size = new Size(100, 56),
                 Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" },
             },
             new SfToolbarItem
             {
                 Text = "Italic",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Italic",
                 Size = new Size(60, 56),
                 Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" },
             },
             new SfToolbarItem
             {
                 Text = "AlignLeft",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Align-Left",
                 Size = new Size(100, 56),
                 Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" },
             },
             new SfToolbarItem
             {
                 Text = "AlignRight",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Align-Right",
                 Size = new Size(100, 56),
                 Icon = new FontImageSource { Color="Black", Glyph = "\uE753", FontFamily = "MauiMaterialAssets" },
             },
             new SfToolbarItem
             {
                 Text = "AlignCenter",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Align-Center",
                 Size = new Size(120, 56),
                 Icon = new FontImageSource { Color="Blue", Glyph = "\uE752", FontFamily = "MauiMaterialAssets" },
             },
             new SfToolbarItem
             {
                 Text = "AlignJustify",
                 TextPosition = ToolbarItemTextPosition.Right,
                 ToolTipText = "Align-Justify",
                 Size = new Size(110, 56),
                 Icon = new FontImageSource { Color="Red", Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" },
             }
         };

         Toolbar.Items = itemCollection;
         this.Content = Toolbar;
     }
 }

{% endhighlight %}

{% endtabs %}

![Toolbar-Items-customization](Images/toolbaritem-customization.png)

## Separator Item Customization

The Toolbar Control supports customization of separator Item using Properties [Stroke](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SeparatorToolbarItem.html#Syncfusion_Maui_Toolbar_SeparatorToolbarItem_Stroke) and [StrokeThickness](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SeparatorToolbarItem.html#Syncfusion_Maui_Toolbar_SeparatorToolbarItem_StrokeThickness).


* **Stroke** : This Property is used to customize the Stroke Color of the separator Item.
* **StrokeThickness** : This Property is used to customize the Stroke thickness of the separator Item.

The following code sample demonstrates how to create a Toolbar Control with separator Item customization.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout>
    <Toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="450">
        <Toolbar:SfToolbar.Items>
            <Toolbar:SfToolbarItem Name="Bold"
            ToolTipText="Bold">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                         FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="Underline"
            ToolTipText="Underline">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                         FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="Italic"
            ToolTipText="Italic">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                         FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SeparatorToolbarItem Stroke="Red" StrokeThickness="3"/>
            <Toolbar:SfToolbarItem Name="AlignLeft"
                       ToolTipText="Align-Left">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                         FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="AlignRight"
                       ToolTipText="Align-Right">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
             FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="AlignCenter"
                       ToolTipText="Align-Center">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
             FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="AlignJustify"
                       ToolTipText="Align-Justify">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE74F;"
             FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
        </Toolbar:SfToolbar.Items>
    </Toolbar:SfToolbar>
</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfToolbar Toolbar = new SfToolbar();
        Toolbar.HeightRequest = 56;

        ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
        {
            new SfToolbarItem
            {
                Name = "Bold",
                ToolTipText = "Bold",
                Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "Underline",
                ToolTipText = "Underline",
                Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "Italic",
                ToolTipText = "Italic",
                Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
            },
            new SeparatorToolbarItem
            {
                Stroke = Colors.Red,
                StrokeThickness = 3
            },
            new SfToolbarItem
            {
                Name = "AlignLeft",
                ToolTipText = "Align-Left",
                Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "AlignRight",
                ToolTipText = "Align-Right",
                Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "AlignCenter",
                ToolTipText = "Align-Center",
                Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
            },
            new SfToolbarItem
            {
                Name = "AlignJustify",
                ToolTipText = "Align-Justify",
                Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
            }
        };

        Toolbar.Items = itemCollection;
        this.Content = Toolbar;
    }
}

{% endhighlight %}

{% endtabs %}

![separator-Item-customization](Images/separator-customization.png)

## Navigation Button Customization

The Toolbar Control supports customization of navigation buttons using Properties [ForwardButtonIconColor](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ForwardButtonIconColor), [BackwardButtonIconColor](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_BackwardButtonIconColor), [ForwardButtonBackground](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_ForwardButtonBackground), [BackwardButtonBackground](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_BackwardButtonBackground).

* **ForwardButtonIconColor** : This Property is used to customize the Icon Color of the forward button.
* **BackwardButtonIconColor** : This Property is used to customize the Icon Color of the backward button.
* **ForwardButtonBackground** : This Property is used to customize the Background Color of the forward button.
* **BackwardButtonBackground** : This Property is used to customize the Background Color of the backward button.

The following code sample demonstrates how to create a Toolbar Control with navigation button customization.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout>
     <Toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="270" OverflowMode="NavigationButtons" ForwardButtonIconColor="Red" BackwardButtonIconColor="Red" ForwardButtonBackground="Aqua" BackwardButtonBackground="Aqua">
         <Toolbar:SfToolbar.Items>
             <Toolbar:SfToolbarItem Name="Bold"
             ToolTipText="Bold">
                 <Toolbar:SfToolbarItem.Icon>
                     <FontImageSource Glyph="&#xE770;"
                          FontFamily="MauiMaterialAssets" />
                 </Toolbar:SfToolbarItem.Icon>
             </Toolbar:SfToolbarItem>
             <Toolbar:SfToolbarItem Name="Underline"
             ToolTipText="Underline">
                 <Toolbar:SfToolbarItem.Icon>
                     <FontImageSource Glyph="&#xE762;"
                          FontFamily="MauiMaterialAssets" />
                 </Toolbar:SfToolbarItem.Icon>
             </Toolbar:SfToolbarItem>
             <Toolbar:SfToolbarItem Name="Italic"
             ToolTipText="Italic">
                 <Toolbar:SfToolbarItem.Icon>
                     <FontImageSource Glyph="&#xE771;"
                          FontFamily="MauiMaterialAssets" />
                 </Toolbar:SfToolbarItem.Icon>
             </Toolbar:SfToolbarItem>
             <Toolbar:SfToolbarItem Name="AlignLeft"
                        ToolTipText="Align-Left">
                 <Toolbar:SfToolbarItem.Icon>
                     <FontImageSource Glyph="&#xE751;"
                          FontFamily="MauiMaterialAssets" />
                 </Toolbar:SfToolbarItem.Icon>
             </Toolbar:SfToolbarItem>
             <Toolbar:SfToolbarItem Name="AlignRight"
                        ToolTipText="Align-Right">
                 <Toolbar:SfToolbarItem.Icon>
                     <FontImageSource Glyph="&#xE753;"
              FontFamily="MauiMaterialAssets" />
                 </Toolbar:SfToolbarItem.Icon>
             </Toolbar:SfToolbarItem>
             <Toolbar:SfToolbarItem Name="AlignCenter"
                        ToolTipText="Align-Center">
                 <Toolbar:SfToolbarItem.Icon>
                     <FontImageSource Glyph="&#xE752;"
              FontFamily="MauiMaterialAssets" />
                 </Toolbar:SfToolbarItem.Icon>
             </Toolbar:SfToolbarItem>
             <Toolbar:SfToolbarItem Name="AlignJustify"
                        ToolTipText="Align-Justify">
                 <Toolbar:SfToolbarItem.Icon>
                     <FontImageSource Glyph="&#xE74F;"
              FontFamily="MauiMaterialAssets" />
                 </Toolbar:SfToolbarItem.Icon>
             </Toolbar:SfToolbarItem>
         </Toolbar:SfToolbar.Items>
     </Toolbar:SfToolbar>
 </VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

 public partial class MainPage : ContentPage
 {
     public MainPage()
     {
         InitializeComponent();
         SfToolbar Toolbar = new SfToolbar();
         Toolbar.HeightRequest = 56;
         Toolbar.WidthRequest = 270;
         Toolbar.OverflowMode = ToolbarItemOverflowMode.NavigationButtons;
         Toolbar.ForwardButtonIconColor = Colors.Red;
         Toolbar.BackwardButtonIconColor = Colors.Red;
         Toolbar.ForwardButtonBackground = Colors.Aqua;
         Toolbar.BackwardButtonBackground = Colors.Aqua;

         ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>();

         itemCollection.Add(new SfToolbarItem
         {
             Name = "Bold",
             ToolTipText = "Bold",
             Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
         });

         itemCollection.Add(new SfToolbarItem
         {
             Name = "Underline",
             ToolTipText = "Underline",
             Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
         });

         itemCollection.Add(new SfToolbarItem
         {
             Name = "Italic",
             ToolTipText = "Italic",
             Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
         });

         itemCollection.Add(new SfToolbarItem
         {
             Name = "AlignLeft",
             ToolTipText = "Align-Left",
             Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
         });

         itemCollection.Add(new SfToolbarItem
         {
             Name = "AlignRight",
             ToolTipText = "Align-Right",
             Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
         });

         itemCollection.Add(new SfToolbarItem
         {
             Name = "AlignCenter",
             ToolTipText = "Align-Center",
             Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
         });

         itemCollection.Add(new SfToolbarItem
         {
             Name = "AlignJustify",
             ToolTipText = "Align-Justify",
             Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
         });

         Toolbar.Items = itemCollection;
         this.Content = Toolbar;
     }
 }


{% endhighlight %}

{% endtabs %}

![navigation-button-customization](Images/navigation-button-customization.png)

## More Button Customization

The Toolbar Control supports customization of more button using Properties [MoreButtonIconColor](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreButtonIconColor), [MoreButtonBackground](https://help.Syncfusion.com/cr/.NET MAUI/Syncfusion..NET MAUI.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_MoreButtonBackground).

* **MoreButtonIconColor** : This Property is used to customize the Icon Color of the more button.
* **MoreButtonBackground** : This Property is used to customize the Background Color of the more button.

The following code sample demonstrates how to create a Toolbar Control with more button customization.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout>
    <Toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="270" OverflowMode="MoreButton" MoreButtonIconColor="Red" MoreButtonBackground="Yellow">
        <Toolbar:SfToolbar.Items>
            <Toolbar:SfToolbarItem Name="Bold"
         ToolTipText="Bold">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                      FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="Underline"
         ToolTipText="Underline">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                      FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="Italic"
         ToolTipText="Italic">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                      FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="AlignLeft"
                    ToolTipText="Align-Left">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                      FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="AlignRight"
                    ToolTipText="Align-Right">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
          FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="AlignCenter"
                    ToolTipText="Align-Center">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
          FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
            <Toolbar:SfToolbarItem Name="AlignJustify"
                    ToolTipText="Align-Justify">
                <Toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE74F;"
          FontFamily="MauiMaterialAssets" />
                </Toolbar:SfToolbarItem.Icon>
            </Toolbar:SfToolbarItem>
        </Toolbar:SfToolbar.Items>
    </Toolbar:SfToolbar>
 </VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfToolbar Toolbar = new SfToolbar();
        Toolbar.HeightRequest = 56;
        Toolbar.WidthRequest = 270;
        Toolbar.OverflowMode = ToolbarItemOverflowMode.MoreButton;
        Toolbar.MoreButtonIconColor = Colors.Red;
        Toolbar.MoreButtonBackground = Colors.Red;
        

        ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>();

        itemCollection.Add(new SfToolbarItem
        {
            Name = "Bold",
            ToolTipText = "Bold",
            Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
        });

        itemCollection.Add(new SfToolbarItem
        {
            Name = "Underline",
            ToolTipText = "Underline",
            Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
        });

        itemCollection.Add(new SfToolbarItem
        {
            Name = "Italic",
            ToolTipText = "Italic",
            Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
        });

        itemCollection.Add(new SfToolbarItem
        {
            Name = "AlignLeft",
            ToolTipText = "Align-Left",
            Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
        });

        itemCollection.Add(new SfToolbarItem
        {
            Name = "AlignRight",
            ToolTipText = "Align-Right",
            Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
        });

        itemCollection.Add(new SfToolbarItem
        {
            Name = "AlignCenter",
            ToolTipText = "Align-Center",
            Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
        });

        itemCollection.Add(new SfToolbarItem
        {
            Name = "AlignJustify",
            ToolTipText = "Align-Justify",
            Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
        });

        Toolbar.Items = itemCollection;
        this.Content = Toolbar;
    }
}

{% endhighlight %}

{% endtabs %}

![more-button-customization](Images/more-button-customization.png)
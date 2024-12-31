---
layout: post
title: Use UpDown Button in .NET MAUI NumericEntry | Syncfusion
description: Learn here all about how to use UpDown Button (SpinButton) in Syncfusion .NET MAUI NumericEntry (SfNumericEntry) control and more.
platform: MAUI
control:  SfNumericEntry
documentation: ug
---

# UpDown Button in .NET MAUI NumericEntry

This section describes how to change the value in the [NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control using keys, mouse scrolling, and the up-down button

## Increase or decrease value

You can increment or decrement the value in the `NumericEntry` control using the **UpArrow**, **DownArrow**, **PageUp**, and **PageDown** keys. You can change the increment or decrement value when the Arrow keys are pressed using the [SmallChange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_SmallChange) property and Page keys using the [LargeChange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_LargeChange) property. By default, the value of the `SmallChange` property is **1**, and the `LargeChange` property is **10**. 

N> The value in the `NumericEntry` can also be changed by mouse scrolling. The mouse scrolling increases or decreases the value based on the `SmallChange` property.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry HorizontalOptions="Center"
                        VerticalOptions="Center" 
                        SmallChange="5"
                        Value="10"
                        LargeChange="10" />

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry= new SfNumericEntry();
sfNumericEntry.Value=10;
sfNumericEntry.SmallChange=5;
sfNumericEntry.LargeChange=10;
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry Placeholder Text](GettingStarted_images/valuechange-bykeys.gif)

## UpDown button placement

You can increase or decrease the value of the `NumericEntry` control using the up-down button. By default, the value of the [UpDownPlacementMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownPlacementMode) property is **Hidden**. You can adjust the position of the up-down buttons by setting the `UpDownPlacementMode` property to **Inline** for horizontal orientation and **InlineVertical** for vertical orientation.

N> When using the up-down button, the `NumericEntry` control value changes based on the value of the `SmallChange` property.

### UpDown button placement: Inline

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry HorizontalOptions="Center"
                        VerticalOptions="Center"
                        Value="360";
                        UpDownPlacementMode="Inline" />
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.Value=360;
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline;

{% endhighlight %}
{% endtabs %}

![UpDown Placement in .NET MAUI NumericEntry](UpDownButton_images/UpDownButtonPlacement.gif)

### UpDown button placement: InlineVertical

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry Value="360"
                        VerticalOptions="Center"
                        HorizontalOptions="Center"
                        UpDownPlacementMode="InlineVertical"/>
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HorizontalOptions = LayoutOptions.Center;
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.Value=360;
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.InlineVertical;

{% endhighlight %}
{% endtabs %}

![UpDown Vertical Placement in .NET MAUI NumericEntry](UpDownButton_images/UpDownButtonPlacementVertical.png)

## UpDown button alignment

You can adjust the alignment of the UpDown buttons in the [NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control using the [UpDownButtonAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownButtonAlignment) property. Set its value to **Left**, **Right**, or **Both** to position the buttons on the left, right, or both sides of the entry field, respectively.

N> By default, the `UpDownButtonAlignment` property is set to **Right**.  

### UpDown button alignment: Left

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry Value="123" HorizontalTextAlignment="End" 
                        UpDownPlacementMode="Inline" 
                        UpDownButtonAlignment="Left"/>
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.Value = 123;
sfNumericEntry.HorizontalTextAlignment=TextAlignment.End;
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline;
sfNumericEntry.UpDownButtonAlignment = UpDownButtonAlignment.Left;

{% endhighlight %}
{% endtabs %}

![UpDown Alignment is left in .NET MAUI NumericEntry](UpDownButton_images/UpDownButtonAlignmentLeft.png)

### UpDown button alignment: Both

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry Value="123" HorizontalTextAlignment="Center" 
                        UpDownPlacementMode="Inline" 
                        UpDownButtonAlignment="Both"/>
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.Value = 123;
sfNumericEntry.HorizontalTextAlignment=TextAlignment.Center;
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline;
sfNumericEntry.UpDownButtonAlignment = UpDownButtonAlignment.Both;

{% endhighlight %}
{% endtabs %}

![UpDown Alignment is Both in .NET MAUI NumericEntry](UpDownButton_images/UpDownButtonAlignmentBoth.png)

## UpDown button customization

## UpDown button color

Customize the `NumericEntry` control button color by using the [UpDownButtonColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownButtonColor) property.

{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry HeightRequest="50"
                        WidthRequest="200"
                        HorizontalOptions="Center"
                        VerticalOptions="Center"
                        Value="360"
                        UpDownPlacementMode="Inline"
                        UpDownButtonColor="Blue"/>
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.HeightRequest= 50;
sfNumericEntry.WidthRequest = 200;
sfNumericEntry.HorizontalOptions = LayoutOptions.Center
sfNumericEntry.VerticalOptions = LayoutOptions.Center;
sfNumericEntry.Value = 360;
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline;
sfNumericEntry.UpDownButtonColor = Colors.Blue;

{% endhighlight %}
{% endtabs %}

![UpDownButtonColor support in .NET MAUI NumericEntry](UpDownButton_images/UpDownButtonColor.png)

## UpDown button template

The `NumericEntry` control supports customization of the UpDownButton's appearance through the use of the [UpButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpButtonTemplate) and [DownButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_DownButtonTemplate) properties.
{% tabs %}
{% highlight XAML %}

<VerticalStackLayout Spacing="10" VerticalOptions="Center">
    <editors:SfNumericEntry x:Name="numericEntry"
                            WidthRequest="200"
                            HeightRequest="40" 
                            VerticalOptions="Center"
                            UpDownPlacementMode="Inline"
                            Value="50">
        <editors:SfNumericEntry.UpButtonTemplate>
            <DataTemplate>
                <Grid>
                    <Label Padding="0,6.5,0,0" 
                           Rotation="90"
                           FontFamily="FontIcons"
                           HorizontalOptions="Center"
                           Text="&#xe74a;"
                           TextColor="Green"
                           FontSize="20"/>
                </Grid>
            </DataTemplate>
        </editors:SfNumericEntry.UpButtonTemplate>
        <editors:SfNumericEntry.DownButtonTemplate>
            <DataTemplate>
                <Grid>
                    <Label Padding="0,5,0,0" 
                           Rotation="270"
                           FontFamily="FontIcons"
                           HorizontalOptions="Center"
                           Text="&#xe74a;"
                           TextColor="Red"
                           FontSize="20"/>
                </Grid>
            </DataTemplate>
        </editors:SfNumericEntry.DownButtonTemplate>
    </editors:SfNumericEntry>
</VerticalStackLayout>
                     
{% endhighlight %}
{% highlight c# %}

 public partial class MainPage : ContentPage
 {
     public MainPage()
     {
         InitializeComponent();
         var verticalStackLayout = new StackLayout
         {
             Spacing = 10,
             VerticalOptions = LayoutOptions.Center
         };
         var numericEntry = new SfNumericEntry
         {
             WidthRequest = 200,
             HeightRequest = 40,
             VerticalOptions = LayoutOptions.Center,
             UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline,
             Value = 50
         };
         var upButtonTemplate = new DataTemplate(() =>
         {
             var grid = new Grid();
             var label = new Label
             {
                 Padding = new Thickness(0, 6.5, 0, 0),
                 Rotation = 90,
                 FontFamily = "FontIcons",
                 HorizontalOptions = LayoutOptions.Center,
                 Text = "\ue74a", // Use Unicode directly for the icon
                 TextColor = Colors.Green,
                 FontSize = 20
             };
             grid.Children.Add(label);
             return grid;
         });
         var downButtonTemplate = new DataTemplate(() =>
         {
             var grid = new Grid();
             var label = new Label
             {
                 Padding = new Thickness(0, 5, 0, 0),
                 Rotation = 270,
                 FontFamily = "FontIcons",
                 HorizontalOptions = LayoutOptions.Center,
                 Text = "\ue74a",
                 TextColor = Colors.Red,
                 FontSize = 20
             };
             grid.Children.Add(label);
             return grid;
         });
         numericEntry.UpButtonTemplate = upButtonTemplate;
         numericEntry.DownButtonTemplate = downButtonTemplate;
         verticalStackLayout.Children.Add(numericEntry);
         Content = verticalStackLayout;
     }
 }

{% endhighlight %}
{% endtabs %}

![UpDownButtonTemplate support in .NET MAUI NumericEntry](UpDownButton_images/UpDownButtonTemplate.png)

## Auto reverse in SfNumericEntry

[Auto-reverse](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_AutoReverse) in NumericEntry allows the control to automatically switch direction when reaching its [Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Minimum) or [Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Maximum) value. When incrementing, it starts at the `Minimum` and progresses to the `Maximum`, and conversely.

N> The default value of this property is `false.`
{% tabs %}
{% highlight XAML %}

<editors:SfNumericEntry UpDownPlacementMode="Inline"
                        AutoReverse="True"
                        Minimum="0"
                        Maximum="10"/>
                        
                     
{% endhighlight %}
{% highlight c# %}

SfNumericEntry sfNumericEntry = new SfNumericEntry();
sfNumericEntry.UpDownPlacementMode = NumericEntryUpDownPlacementMode.Inline;
sfNumericEntry.AutoReverse = true;
sfNumericEntry.Minimum=0;
sfNumericEntry.Maximum=10;

{% endhighlight %}
{% endtabs %}

![AutoReverse support in .NET MAUI NumericEntry](UpDownButton_images/AutoReverseSupport.gif)


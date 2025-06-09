---
layout: post
title: Customize Display View in .NET MAUI Color Picker | Syncfusion®
description: Learn how to customize the selected color icon, selected color template, and drop-down icon in the Syncfusion® .NET MAUI Color Picker control.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, .net maui color picker control, maui color picker control, .net maui color picker customization, maui color picker customization, drop-down button, drop-down, drop-down icon, selected color, palette, spectrum, color palette.
---

# Display View Customization

## Selected color icon

You can customize the selected color icon in the Color Picker using the `SelectedColorIcon` property.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker">
    <inputs:SfColorPicker.SelectedColorIcon>
        <FontImageSource FontFamily="MauiMaterialAssets" Glyph="&#xe748;" Color="DodgerBlue" />
    </inputs:SfColorPicker.SelectedColorIcon>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

var iconSource = new FontImageSource
{
    FontFamily = "MauiMaterialAssets",
    Glyph = "\ue748",
    Color = Colors.DodgerBlue
};

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectedColorIcon = iconSource
};

Content = colorPicker;

{% endhighlight %}

{% endtabs %}

![SelectedColorIcon](Images/DisplayView/Icon.png)

## Selected color template

To customize the appearance of the selected color, use the `SelectedColorTemplate` property to define a custom template.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker">
    <inputs:SfColorPicker.SelectedColorTemplate>
        <DataTemplate>
            <Label Text="Selected color.." VerticalTextAlignment="Center" HorizontalTextAlignment="Center" 
                   Background="Pink"/>
        </DataTemplate>
    </inputs:SfColorPicker.SelectedColorTemplate>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

var selectedColorTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "Selected color..",
        BackgroundColor = Colors.Pink,
        VerticalTextAlignment="Center",
        HorizontalTextAlignment="Center" 
    };
});

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectedColorTemplate = selectedColorTemplate
};
    
Content = colorPicker;    

{% endhighlight %}

{% endtabs %}

![SelectedColorTemplate](Images/DisplayView/Template.png)

## Drop-down icon

The drop-down icon of the Color Picker can be customized using the `DropDownButtonTemplate` property.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker">
    <inputs:SfColorPicker.DropDownButtonTemplate>
        <DataTemplate>
            <Label Text="&#xe767;" FontFamily="MauiMaterialAssets" FontSize="14" TextColor="Blue" VerticalTextAlignment="Center" HorizontalTextAlignment="Center" />
        </DataTemplate>
    </inputs:SfColorPicker.DropDownButtonTemplate>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

var dropDownTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "\ue767", 
        FontFamily = "MauiMaterialAssets",
        TextColor = Colors.Black,
        FontSize = 14,
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    };
});

SfColorPicker colorPicker = new SfColorPicker
{
    DropDownButtonTemplate = dropDownTemplate
};

Content = colorPicker;
    
{% endhighlight %}

{% endtabs %}

![DropDownButtonTemplate](Images/DisplayView/DropDown.png)
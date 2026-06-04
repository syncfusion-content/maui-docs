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

## Selected color customization

### Selected color icon

You can customize the selected color icon in the Color Picker using the [SelectedColorIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectedColorIcon) property.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker">
    <inputs:SfColorPicker.SelectedColorIcon>
        <FontImageSource FontFamily="MauiMaterialAssets" Glyph="&#xe760;" Color="{Binding Source={x:Reference colorPicker},Path=SelectedColor}"/>
    </inputs:SfColorPicker.SelectedColorIcon>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

var fontIcon = new FontImageSource
{
    FontFamily = "MauiMaterialAssets",
    Glyph = "\ue760", 
    Color = colorPicker.SelectedColor 
};

colorPicker.SelectedColorIcon = fontIcon;

colorPicker.ColorChanged += (s, e) =>
{
    fontIcon.Color = e.NewColor;
};

{% endhighlight %}

{% endtabs %}

![SelectedColorIcon](Images/DisplayView/Icon.png)

## Selected color icon size

You can customize the size of the selected color icon displayed in the Color Picker using the [SelectedColorIconSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectedColorIconSize) property.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker SelectedColorIconSize="32" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    SelectedColorIconSize = 32
};

{% endhighlight %}

{% endtabs %}

### Selected color template

To customize the appearance of the selected color, use the [SelectedColorTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_SelectedColorTemplate) property to define a custom template.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker">
    <inputs:SfColorPicker.SelectedColorTemplate>
        <DataTemplate>
            <VerticalStackLayout WidthRequest="70" Background="White">
                <Label Text="A" HorizontalOptions="Center" TextColor="Black"/>
                <BoxView HeightRequest="5" WidthRequest="30" Background="{Binding Source={x:Reference colorPicker},Path=SelectedColor}" />
            </VerticalStackLayout>
        </DataTemplate>
    </inputs:SfColorPicker.SelectedColorTemplate>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

colorPicker.SelectedColorTemplate = new DataTemplate(() =>
{
    var label = new Label
    {
        Text = "A",
        HorizontalOptions = LayoutOptions.Center,
        TextColor = Colors.Black
    };

    // Create the box view and bind its Background to colorPicker.SelectedColor
    var boxView = new BoxView
    {
        HeightRequest = 5,
        WidthRequest = 30
    };

    boxView.SetBinding(BoxView.BackgroundProperty, new Binding
    {
        Source = colorPicker,
        Path = "SelectedColor",
        Mode = BindingMode.OneWay
    });

    // Create the layout
    var stackLayout = new VerticalStackLayout
    {
        WidthRequest = 70,
        BackgroundColor = Colors.White,
        Children = { label, boxView }
    };

    return stackLayout;
});

Content = colorPicker;    

{% endhighlight %}

{% endtabs %}

![SelectedColorTemplate](Images/DisplayView/Template.png)

## Drop-down icon

The drop-down icon of the Color Picker can be customized using the [DropDownButtonTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_DropDownButtonTemplate) property.

{% tabs %}

{% highlight xaml %}

<inputs:SfColorPicker x:Name="colorPicker">
    <inputs:SfColorPicker.DropDownButtonTemplate>
        <DataTemplate>
            <Label Text="&#xe705;" FontFamily="MauiMaterialAssets" FontSize="14" TextColor="Black" VerticalTextAlignment="Center" HorizontalTextAlignment="Center" />
        </DataTemplate>
    </inputs:SfColorPicker.DropDownButtonTemplate>
</inputs:SfColorPicker>

{% endhighlight %}

{% highlight c# %}

var dropDownTemplate = new DataTemplate(() =>
{
    return new Label
    {
        Text = "\ue705", 
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

## DisplayViewHeight

You can control the height of the display view shown in the Color Picker using the [DisplayViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_DisplayViewHeight) property.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker DisplayViewHeight="48" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    DisplayViewHeight = 48
};

{% endhighlight %}

{% endtabs %}

## DisplayViewStroke

You can customize the border color of the display view in the Color Picker using the [DisplayViewStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_DisplayViewStroke) property.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker DisplayViewStroke="Red" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    DisplayViewStroke = Colors.Red
};

{% endhighlight %}

{% endtabs %}

## DisplayViewStrokeThickness

You can define the thickness of the display view border using the [DisplayViewStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_DisplayViewStrokeThickness) property.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker DisplayViewStrokeThickness="3" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    DisplayViewStrokeThickness = 3
};

{% endhighlight %}

{% endtabs %}

## DropDownWidth

You can set the width of the drop-down button displayed in the Color Picker using the [DropDownWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_DropDownWidth) property.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfColorPicker DropDownWidth="48" />

{% endhighlight %}

{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker()
{
    DropDownWidth = 48
};

{% endhighlight %}

{% endtabs %}
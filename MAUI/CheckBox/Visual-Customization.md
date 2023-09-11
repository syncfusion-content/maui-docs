---
layout: post
title: Customization in .NET MAUI CheckBox control | Syncfusion
description: Learn about Customization support in Syncfusion Essential Studio .NET MAUI CheckBox control, its elements and more.
platform: .NET MAUI
control: CheckBox
documentation: ug
---

# Visual Customization in .NET MAUI CheckBox (SfCheckBox)

## Customizing a shape

The check box shape can be customized using the [`CornerRadius`] property. This property specifies the uniform radius value to the every corner of the check box.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfCheckBox x:Name="checkBox" Text="CheckBox" IsChecked="True" CornerRadius="5.0"/>            
{% endhighlight %}
{% highlight c# %}
SfCheckBox checkBox = new SfCheckBox();
checkBox.Text = "CheckBox";
checkBox.IsChecked = true;
checkBox.CornerRadius = 5.0f;
{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Visual-Customization/checkboxradii.png)

## Customizing a state color

The default state colors can be customized using the [`CheckedColor`] and [`UncheckedColor`] properties. The checked or indeterminate state color is updated to the [`CheckedColor`] property value when the state is changed to the checked or indeterminate.The unchecked state color is updated to [`UncheckedColor`] property value when the state is changed to unchecked. 
{% tabs %}
{% highlight xaml %}
<syncfusion:SfCheckBox x:Name="check" Text="CheckBox" IsChecked="True" CheckedColor="Green"/>
<syncfusion:SfCheckBox x:Name="unCheck" Text="CheckBox" UncheckedColor="Violet"/>
<syncfusion:SfCheckBox x:Name="indeterminate " Text="CheckBox" IsThreeState="True" IsChecked="{x:Null}" CheckedColor="Purple"/> 
{% endhighlight %}
{% highlight c# %}
SfCheckBox check= new SfCheckBox();
check.Text = "CheckBox";
check.IsChecked = true;
check.CheckedColor = Color.Green;
SfCheckBox uncheck = new SfCheckBox();
uncheck.Text = "CheckBox";
uncheck.UncheckedColor = Color.Violet;
SfCheckBox indeterminate = new SfCheckBox();
indeterminate.IsChecked = null;
indeterminate.IsThreeState = true;
indeterminate.Text = "CheckBox";
indeterminate.CheckedColor = Color.Purple;
{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Visual-Customization/statecolor.png)

## StrokeThickness

The tick box stroke thickness of the checkbox control can be customized using the [`StrokeThickness`] property.  

{% tabs %}
{% highlight xaml %}
<syncfusion:SfCheckBox Text="Hello" StrokeThickness="2" UncheckedColor="Blue" FontSize="20"/>
<syncfusion:SfCheckBox Text="Hello" StrokeThickness="4" UncheckedColor="Blue" FontSize="25"/>
<syncfusion:SfCheckBox Text="Hello" StrokeThickness="6" UncheckedColor="Blue" FontSize="30"/>            
{% endhighlight %}
{% highlight c# %}
SfCheckBox check1= new SfCheckBox();
check1.Text = "Hello";
check1.StrokeThickness = 2;
check1.FontSize = 20;
check1.UncheckedColor = Color.Blue;
SfCheckBox check2 = new SfCheckBox();
check2.Text = "Hello";
check2.StrokeThickness = 4;
check2.FontSize = 25;
check2.UncheckedColor = Color.Blue;
SfCheckBox check3 = new SfCheckBox();
check3.Text = "Hello";
check3.StrokeThickness = 6;
check3.FontSize = 30;
check3.UncheckedColor = Color.Blue;
{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Visual-Customization/strokethickness.png)

## Setting a caption text appearance

You can customize the display text appearance of the [`SfCheckBox`] control using the following properties:

* [`TextColor`]: Changes the color of the text.
* [`HorizontalTextAlignment`]: Changes the horizontal alignment of the caption text.
* [`FontFamily`]: Changes the font family of the caption text.
* [`FontAttributes`]: Sets font attributes(bold/italic/none) of the caption text.
* [`FontSize`]: Sets font size of the caption text.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfCheckBox x:Name="caption" Text="CheckBox" IsChecked="True" TextColor="Violet" HorizontalTextAlignment="Center" FontFamily="Arial" FontAttributes="Bold" FontSize="20"/>           
{% endhighlight %}
{% highlight c# %}
SfCheckBox caption = new SfCheckBox();
caption.IsChecked = true;
caption.Text = "CheckBox";
caption.TextColor = Color.Violet;
caption.HorizontalTextAlignment = TextAlignment.Center;
caption.FontFamily = "Arial";
caption.FontAttributes = FontAttributes.Bold;
caption.FontSize = 20;
{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Iamges/Visual-Customization/textappearance.png)
 
## TickColor Customization

The [`TickColor`] property customizes the color of the tick in [`SfCheckBox`] control using the following properties:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons" 
             x:Class="CheckBoxCustomization.checkbox">
     <ContentPage.Content>
            <StackLayout>
                <syncfusion:SfCheckBox x:Name="checkBox" IsChecked="True" CheckedColor="Aqua" TickColor="Fuchsia" Text="CheckBox" />
            </StackLayout>
        </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
using System;
using Syncfusion.Maui.Buttons;

namespace CheckBoxCustomization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout();
            SfCheckBox checkBox = new SfCheckBox();
            checkBox.IsChecked = true;
            checkBox.Text = "CheckBox";
            checkBox.CheckedColor = Color.Aqua;
            checkBox.TickColor = Color.Fuchsia;
            stackLayout.Children.Add(checkBox);
            this.Content = stackLayout;
{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Visual-Customization/tickcolor.png)

## See also

[How to get the values of selected checkboxes in a group using .NET MAUI]

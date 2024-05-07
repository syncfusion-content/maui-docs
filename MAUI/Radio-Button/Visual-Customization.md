---
layout: post
title: Visual Customization in .NET MAUI Radio Button Control | Syncfusion
description: Learn here all about Visual Customization support in Syncfusion .NET MAUI Radio Button (SfRadioButton) control and more.
platform: .NET MAUI
control: SfRadioButton
documentation: ug 
---

# Visual Customization in .NET MAUI Radio Button (SfRadioButton)

## Customizing a state color

The default state colors can be customized using the CheckedColor and UncheckedColor properties. The checked state color is updated to the value of the CheckedColor property when the state changes to check. The unchecked state color is updated to the value of the UncheckedColor property when the state changes to unchecked.

{% tabs %}
{% highlight xaml %}

	<syncfusion:SfRadioGroup x:Name="radioGroup">
		<syncfusion:SfRadioButton x:Name="check" Text="Radio Button" IsChecked="True" CheckedColor="Green"/>
		<syncfusion:SfRadioButton x:Name="uncheck" Text="Radio Button" UncheckedColor="Violet"/>
	</syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

	SfRadioGroup radioGroup = new SfRadioGroup();
	SfRadioButton check = new SfRadioButton();
	check.Text = "Radio Button";
	check.IsChecked = true;
	check.CheckedColor = Color.Green;
	SfRadioButton uncheck = new SfRadioButton();
	uncheck.Text = "Radio Button";
	uncheck.UncheckedColor = Colors.Violet;
	radioGroup.Children.Add(check);
	radioGroup.Children.Add(uncheck);
	this.Content = radioGroup;

{% endhighlight %}
{% endtabs %}

![CheckedColor and UncheckedColor in Radio Button](Images/VisualCustomization/statecolor.png)

## StrokeThickness

The stroke thickness of the circle in the Radio Button control can be customized using the [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_StrokeThickness) property.  

{% tabs %}
{% highlight xaml %}

	<syncfusion:SfRadioGroup>
		<syncfusion:SfRadioButton Text="Checked state" IsChecked="True" StrokeThickness="3"/>
		<syncfusion:SfRadioButton Text="Unchecked state" StrokeThickness="3"/>
	</syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

	SfRadioGroup radioGroup = new SfRadioGroup();
	SfRadioButton check = new SfRadioButton();
	check.Text = "Checked State";
	check.IsChecked = true;
	check.StrokeThickness = 3;
	SfRadioButton uncheck = new SfRadioButton();
	uncheck.Text = "Unchecked State";
	uncheck.StrokeThickness = 3;
	radioGroup.Children.Add(check);
	radioGroup.Children.Add(uncheck);
	this.Content = radioGroup;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Radio Button StrokeThickness](Images/VisualCustomization/radiostrokethickness.png)

N> StrokeThickness support has not been provided for Android Platform.

## Setting a caption text appearance 

You can customize the display text appearance of the [`SfRadioButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) control using the following properties:

* [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_TextColor) : Changes the color of the text.
* [`HorizontalTextAlignment`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_HorizontalTextAlignment) : Changes the horizontal alignment of the caption text.
* [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_FontFamily) : Changes the font family of the caption text.
* [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_FontAttributes) : Sets font attributes(bold/italic/none) of the caption text.
* [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_FontSize) : Sets font size of the caption text.


{% tabs %}
{% highlight xaml %}

	<syncfusion:SfRadioButton x:Name="radioButton" Text="Radio Button" IsChecked="True" TextColor="Blue" HorizontalTextAlignment="Center" FontFamily="Arial" FontAttributes="Bold" FontSize="20"/>

{% endhighlight %}
{% highlight c# %}

	SfRadioButton radioButton = new SfRadioButton();
	radioButton.Text = "Radio Button";
	radioButton.IsChecked = true;
	radioButton.TextColor = Colors.Blue;
	radioButton.HorizontalTextAlignment = TextAlignment.Center;
	radioButton.FontFamily = "Arial";
	radioButton.FontAttributes = FontAttributes.Bold;
	radioButton.FontSize = 20;
	this.Content = radioButton;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Radio Button TextAppereance](Images/VisualCustomization/textappearance.png)

## Size customization

The [`ControlSize`] property is used to customize the [`RadioButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) control size. 

{% tabs %}
{% highlight xaml %}

<StackLayout>
    <syncfusion:SfRadioButton Text="RadioButton" ControlSize="40"/>
</StackLayout>

{% endhighlight %}
{% highlight c# %}

	StackLayout stackLayout = new StackLayout();
	SfRadioButton radioButton = new SfRadioButton();
	radioButton.Text = "Radio Button";
	radioButton.ControlSize = 40;
	stackLayout.Children.Add(radioButton);

{% endhighlight %}
{% endtabs %}
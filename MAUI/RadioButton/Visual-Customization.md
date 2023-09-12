---
layout: post
title: Visual Customization in .NET MAUI Radio Button control | Syncfusion
description: Learn here all about Visual Customization support in Syncfusion .NET MAUI Radio Button (SfRadioButton) control and more.
platform: .NET MAUI
control: SfRadioButton
documentation: ug 
---

# Visual Customization in .NET MAUI Radio Button (SfRadioButton)

## Customizing a state color

The default state colors can be customized using the [`CheckedColor`] and [`UncheckedColor`] properties. The checked state color is updated to the [`CheckedColor`] property value when the state is changed to the checked. The unchecked state color is updated to the [`UncheckedColor`] property value when the state is changed to unchecked.

{% tabs %}
{% highlight xaml %}

	<syncfusion:SfRadioGroup x:Name="radioGroup">
	<syncfusion:SfRadioButton x:Name="check" Text="RadioButton" IsChecked="True" CheckedColor="Green"/>
	<syncfusion:SfRadioButton x:Name="uncheck" Text="RadioButton" UncheckedColor="Violet"/>
	</syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

	SfRadioGroup radioGroup = new SfRadioGroup();
	SfRadioButton check = new SfRadioButton();
	check.Text = "RadioButton";
	check.IsChecked = true;
	check.CheckedColor = Color.Green;
	SfRadioButton uncheck = new SfRadioButton();
	uncheck.Text = "RadioButton";
	uncheck.UncheckedColor = Color.Violet;
	radioGroup.Children.Add(check);
	radioGroup.Children.Add(uncheck);

{% endhighlight %}
{% endtabs %}

![CheckedColor and UncheckedColor in RadioButton](Images/VisualCustomization/radiostatecolor.png)

## StrokeThickness

The stroke thickness of the circle in the RadioButton control can be customized using the [`StrokeThickness`] property.  

{% tabs %}
{% highlight xaml %}

	<syncfusion:SfRadioGroup>
	<syncfusion:SfRadioButton Text="Checked State" IsChecked="True" StrokeThickness="3"/>
	<syncfusion:SfRadioButton Text="UnChecked State" StrokeThickness="3"/>
	</syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

	SfRadioGroup radioGroup = new SfRadioGroup();
	SfRadioButton check = new SfRadioButton();
	check.Text = "Checked State";
	check.IsChecked = true;
	check.StrokeThickness = 3;
	SfRadioButton uncheck = new SfRadioButton();
	uncheck.Text = "UnChecked State";
	uncheck.StrokeThickness = 3;
	radioGroup.Children.Add(check);
	radioGroup.Children.Add(uncheck);

{% endhighlight %}
{% endtabs %}

![RadioButton StrokeThickness](Images/VisualCustomization/radiostrokethickness.png)

N> StrokeThickness support has not been provided for Android Platform.

## Setting a caption text appearance 

You can customize the display text appearance of the [`SfRadioButton`] control using the following properties:

* [`TextColor`] : Changes the color of the text.
* [`HorizontalTextAlignment`] : Changes the horizontal alignment of the caption text.
* [`FontFamily`] : Changes the font family of the caption text.
* [`FontAttributes`] : Sets font attributes(bold/italic/none) of the caption text.
* [`FontSize`] : Sets font size of the caption text.


{% tabs %}
{% highlight xaml %}

	<syncfusion:SfRadioButton x:Name="radioButton" Text="RadioButton" IsChecked="True" TextColor="Violet" HorizontalTextAlignment="Center" FontFamily="Arial" FontAttributes="Bold" FontSize="20"/>

{% endhighlight %}
{% highlight c# %}

	SfRadioButton radioButton = new SfRadioButton();
	radioButton.Text = "RadioButton";
	radioButton.IsChecked = true;
	radioButton.TextColor = Color.Violet;
	radioButton.HorizontalTextAlignment = TextAlignment.Center;
	radioButton.FontFamily = "Arial";
	radioButton.FontAttributes = FontAttributes.Bold;
	radioButton.FontSize = 20;

{% endhighlight %}
{% endtabs %}

![RadioButton TextAppereance](Images/VisualCustomization/radioappearance.png)

## See also

[How to get the selected .NET MAUI radio button (SfRadioButton)]

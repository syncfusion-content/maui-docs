---
layout: post
title: Visual states in .NET MAUI Button Control | Syncfusion
description: Learn here about visual states support in the Syncfusion .NET MAUI Button (SfButton) control, its elements and more.
platform: maui
control: SfButton
documentation: ug 

---

# Visual States in .NET MAUI Button (SfButton)

The visual of the Button can be customized using `VisualStates`. The `SfButton `control contains the following four visual states:

* Normal
* Pressed
* Checked
* Diabled

N> The visual states Checked and Unchecked are only updated when enabling the IsCheckable property in SfButton.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button" 
                Text="Button" 
                Clicked="Button_Clicked" />

{% endhighlight %}
{% highlight c# %}

    SfButton button = new SfButton();
    button.Text = "Button";
    button.Clicked += Button_Clicked;
	
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

    private void Button_Clicked(object sender, EventArgs e)
    {
        button.TextColor = Colors.Blue;
    }

{% endhighlight %}
{% endtabs %}


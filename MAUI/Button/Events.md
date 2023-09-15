---
layout: post
title: Event in .NET MAUI Button Control | Syncfusion
description: Learn here about Event support in the Syncfusion .NET MAUI Button (SfButton) control, its elements and more.
platform: maui
control: SfButton
documentation: ug 

---

# Event in .NET MAUI Button (SfButton)

## Clicked event

The click event occurs when the [`SfButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) is clicked. The event argument is of type `EventArgs`.

{% tabs %}
{% highlight xaml %}

    <buttons:SfButton x:Name="button" Text="Button" Clicked="Button_Clicked"/>
{% endhighlight %}
{% highlight c# %}

    SfButton button = new SfButton();
    button.Text = "SfButton";
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


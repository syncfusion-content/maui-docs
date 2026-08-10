---
layout: post
title: Reset in .NET MAUI Image Editor | Syncfusion®
description: Learn about the reset support in Syncfusion® .NET MAUI Image Editor control to revert edited images to their original state.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Reset in .NET MAUI Image Editor

The .NET MAUI Image Editor allows you to reset the edited image to the originally loaded image.

## Reset method

The [`Reset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Reset) method resets an image to its original state by discarding the changes performed on it.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="Reset"
            Clicked="OnResetClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnResetClicked(object sender, EventArgs e)
{
    this.imageEditor.Reset();
}

{% endhighlight %}
{% endtabs %}

![Reset image in .NET MAUI Image Editor](images/reset/imageeditor-reset-image.gif)

## Reset action event

Occurs before resetting the changes made to an image.

You can control the reset functionality using the `Cancel` argument.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor Source="image.png" BeginReset="OnBeginReset" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

using System.ComponentModel;
using Syncfusion.Maui.ImageEditor;

private void OnBeginReset(object sender, CancelEventArgs e)
{
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

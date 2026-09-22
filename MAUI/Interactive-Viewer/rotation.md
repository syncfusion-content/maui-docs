---
layout: post
title: Rotate in .NET MAUI Interactive Viewer | Syncfusion®
description: Learn about rotation support in the Syncfusion® .NET MAUI Interactive Viewer control, including how to rotate content and improve viewing flexibility.
platform: MAUI
control: SfInteractiveViewer
documentation: ug
---

# Rotation in .NET MAUI Interactive Viewer

The `Rotate` method enables rotating the content hosted in the Interactive Viewer control. Each invocation rotates the content by 90 degrees clockwise and cycles through the available orientations.

{% tabs %}
{% highlight XAML %}

<Grid RowDefinitions="0.9*, 0.1*">
    <interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer">
        <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
    </interactiveViewer:SfInteractiveViewer>

    <Button Text="Rotate" Grid.Row="1" Clicked="OnRotateImageClicked"/>
</Grid>

{% endhighlight %}

{% highlight C# hl_lines="5" %}

using Syncfusion.Maui.InteractiveViewer;

private void OnRotateImageClicked(object sender, EventArgs e)
{
    this.interactiveViewer.Rotate();
}

{% endhighlight %}
{% endtabs %}

N> The `Rotate` method supports only 90-degree clockwise rotations. Custom rotation angles are not supported.

![Rotate-in.net-maui-interactive-viewer](images\Rotate\Rotate-in.net-maui-interactive-viewer.gif){:width="313" height="444" .lazy .shadow-effect}
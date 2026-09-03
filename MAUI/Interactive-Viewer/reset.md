---
layout: post
title: Reset in .NET MAUI Interactive Viewer | Syncfusion®
description: Learn about the reset support in Syncfusion® .NET MAUI Interactive Viewer control to revert edited content to their original state.
platform: MAUI
control: SfInteractiveViewer
documentation: ug
---

# Reset in .NET MAUI Interactive Viewer

The `.NET MAUI Interactive Viewer` provides a built-in reset capability that allows users to quickly restore the content view to its original state after performing zoom and pan operations.

## Reset method

The `Reset` method restores the content to its initial zoom level and pan position.

{% tabs %}
{% highlight XAML %}

<Grid RowDefinitions="0.9*, 0.1*">
    <interactiveViewer:SfInteractiveViewer x:Name="interactiveViewer">
        <Image Source="interactiveviewerimage.png" Aspect="AspectFit" />
    </interactiveViewer:SfInteractiveViewer>

    <Button Text="Reset" Grid.Row="1" Clicked="OnResetImageClicked"/>
</Grid>

{% endhighlight %}

{% highlight C# hl_lines="5" %}

using Syncfusion.Maui.InteractiveViewer;

private void OnResetImageClicked(object sender, EventArgs e)
{
    this.interactiveViewer.Reset();
}

{% endhighlight %}
{% endtabs %}

![Reset-in.net-maui-interactive-viewer](images\Reset\Reset-in.net-maui-interactive-viewer.gif){:width="313" height="500" .lazy .shadow-effect}
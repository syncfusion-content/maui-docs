---
layout: post
title: AutoSize in .NET MAUI Rich Text Editor control | Syncfusion®
description: Learn here all about AutoSize support in Syncfusion® .NET MAUI Rich Text Editor (SfRichTextEditor) control and more.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# AutoSize in .NET MAUI Rich Text Editor (SfRichTextEditor)

The .NET MAUI Rich Text Editor control supports dynamically changing its height based on the content. This feature can be enabled by setting the `EnableAutoSize` property to `True`. When enabled, the editor will automatically resize to fit its content, eliminating the need for scroll bars within the control. By default, the `EnableAutoSize` property is `False`.

The following code example shows how to enable `EnableAutoSize` in the Rich Text Editor control.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor EnableAutoSize="True" />

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.EnableAutoSize = true;

{% endhighlight %}
{% endtabs %}

When `EnableAutoSize` is active, the editor’s height will grow or shrink as content is added or removed.

![.NET MAUI Rich Text Editor with AutoSize enabled](images/richtexteditor-autosize.gif)

N> When using `EnableAutoSize`, it is recommended not to set the `HeightRequest` property on the `SfRichTextEditor`, as this may interfere with the automatic resizing behavior. For the best results, place the editor within a layout that can accommodate its changing height, such as a `VerticalStackLayout` inside a `ScrollView`.

The following example demonstrates how to place an auto-sizing `SfRichTextEditor` within a `ScrollView`.

{% tabs %}
{% highlight xaml %}
<ScrollView>
    <VerticalStackLayout>
        <Label Text="User Feedback" FontSize="Title" Padding="10"/>
        <rte:SfRichTextEditor x:Name="richTextEditor"
                              EnableAutoSize="True"
                              Placeholder="Please provide your detailed feedback here..."/>
        <Button Text="Submit" Margin="10"/>
    </VerticalStackLayout>
</ScrollView>
{% endhighlight %}
{% endtabs %}

---
layout: post
title: FlowDirection in .NET MAUI Image Editor | Syncfusion
description: Learn about Right To Left support in Syncfusion .NET MAUI Image Editor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---
 
# Right To Left Flow Direction in .NET MAUI Image Editor (SfImageEditor)

The [SfImageEditor](https://www.syncfusion.com/maui-controls/maui-image-editor) supports changing the flow direction of items rendering in the right-to-left order by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}

{% highlight XAML %}
  <ContentPage 
            . . .
            <imageEditor:SfImageEditor Source="image.jpeg" FlowDirection="RightToLeft"/>

   </ContentPage>
     
{% endhighlight %}

{% highlight C# %}
   
     SfImageEditor imageEditor = new SfImageEditor();
     imageEditor.Source = "image.jpeg";
     imageEditor.FlowDirection = RightToLeft;
     this.content = imageEditor;

{% endhighlight %}

{% endtabs %}

![Right to left in .NET MAUI Image Editor](images/right-to-left/right-to-left.png)

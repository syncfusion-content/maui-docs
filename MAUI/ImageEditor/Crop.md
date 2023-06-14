---
layout: post
title: Selection and Cropping in ##Platform_Name## ImageEditor Control | Syncfusion
description: Learn here all about Selection and Cropping in Syncfusion ##Platform_Name## ImageEditor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection and Cropping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Selection and Cropping

The Image Editor control has multiple selection options including custom, square, circle, and customized to various aspects ratios. The selection region can be dragged and resized for cropping an image. The selection can be made by either using a toolbar or the `select` method.  

In the `select` method, the selection type needs to be specified as a custom, square, circle, and aspect ratios such as 3:2, 4:3, 5:4, 7:5, 16:9.

In the toolbar, the selection can be made by clicking the crop dropdown button and picking the selection option such as custom, square, circle, and aspect ratios.

## Custom

The selection region can be customized by dragging and resizing an image.

In the toolbar, the custom selection can be done by clicking the crop dropdown button and picking the `Custom` option from that popup.

In the following example, the `select` method is used in the button click to the custom selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/custom/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/custom/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-custom.jpg)

## Square

The selection region can be customized as a square. That square can be dragged and resized. In the toolbar, the square selection can be done by clicking the crop dropdown button and picking the `Square` option from that popup.

In the following example, the `select` method is used in the button click to the square selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/square/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/square/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/square/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/square/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-square.jpg)

## Circle

The selection region can be customized as a circle. That circle can be moved and resized. In the toolbar, the circle selection can be done by clicking the crop dropdown button and picking the `Circle` option from that popup.

In the following example, the `select` method is used in the button click to the circle selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/circle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/circle/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/circle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/circle/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-circle.jpg)

## Ratio

The selection region can be customized according to the predefined ratios including 4:3, 7:5, 16:9, and more. In the toolbar, the Ratio selection can be done by clicking the crop dropdown button and picking the 4:3, 7:5, or 16:9 option from that popup.

In the following example, the `select` method is used in the button click to the ratio selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/ratio/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/ratio/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/ratio/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/ratio/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-ratio.jpg)

## Cropping

The Image Editor control crops the image based on the selection. The cropping can be made by either using a toolbar or the crop method.

In the toolbar, cropping can be made by clicking the OK button which is enabled only after performing the selection.

In the following example, the `select` and `crop` method is used in the button click event to perform selection and cropping.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/cropping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/cropping/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/selection-cropping/cropping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/selection-cropping/cropping/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-cropping.jpg)

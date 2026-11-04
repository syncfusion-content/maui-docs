---
layout: post
title: Organizational Chart in MAUI Diagram | Syncfusion®
description: Render .NET MAUI Diagram organizational charts from a DataSource or explicit nodes, with assistant and getLayoutInfo.
platform: maui
control: SfDiagram 
documentation: ug
appliesto: UI Component Suite, Diagram SDK
---

# Organizational Chart in .NET MAUI Diagram

An organizational chart is a diagram that displays the structure of an organization and relationships. To create an organizational chart, the [`type`](../../api/diagram/layoutModel#type) of layout should be set as an `OrganizationalChart`.

## Prerequisites

Refer to the [Getting started](https://help.syncfusion.com/maui/diagram/getting-started) page to create a project, install the package, and register the handler.

---

## Organizational chart with DataSource

The following code example illustrates how to create an organizational chart with DataSource.

{% tabs %}
{% highlight ts tabtitle="index.ts" %}
{% include code-snippet/diagram/AutomaticLayout-cs3/index.ts %}
{% endhighlight %}
{% highlight html tabtitle="index.html" %}
{% include code-snippet/diagram/AutomaticLayout-cs3/index.html %}
{% endhighlight %}
{% endtabs %}
        
{% previewsample "page.domainurl/code-snippet/diagram/AutomaticLayout-cs3" %}

N> If you want to use Organizational chart layout in diagram, you need to inject HierarchicalTree module along with DataBinding module in the diagram.

## Organizational chart with nodes and connectors

You can render an org-chart layout without using DataSource. The following code demonstrates how to render an org-chart layout without using data source.

{% tabs %}
{% highlight ts tabtitle="index.ts" %}
{% include code-snippet/diagram/AutomaticLayout-orgChart/index.ts %}
{% endhighlight %}
{% highlight html tabtitle="index.html" %}
{% include code-snippet/diagram/AutomaticLayout-orgChart/index.html %}
{% endhighlight %}
{% endtabs %}
        
{% previewsample "page.domainurl/code-snippet/diagram/AutomaticLayout-orgChart" %}

![Organizational chart](../images//org-chart.png)

## GetLayout info

Organizational chart layout starts parsing from root and iterate through all its child elements. The [`getLayoutInfo`](../../api/diagram/layoutModel#getlayoutinfo) method provides necessary information of a node’s children and the way to arrange (direction, orientation, offsets, etc.) them. The arrangements can be customized by overriding this function as explained.

Set chart orientations, chart types, and offset to be left between parent and child nodes by overriding the `getLayoutInfo` method. The `getLayoutInfo` method is called to configure every subtree of the organizational chart. It takes the following arguments.

    * node: Parent node to that options are to be customized.
    * options: Object to set the customizable properties.


The following table illustrates the properties that `options` argument takes.

| Property | Description | Default Value |
| -------- | ----------- | ------------- |
|options.assistants|By default, the collection is empty. When any of the child nodes have to be set as **Assistant**, you can remove from children collection and have to insert into assistants collection.|Empty array|
|options.orientation|Gets or sets the organizational chart orientation.|SubTreeOrientation.Vertical|
|options.type|Gets or sets the chart organizational chart type.|For horizontal chart orientation:SubTreeAlignments.Center and for vertical chart orientation:SubTreeAlignments.Alternate|
|options.offset|Offset is the horizontal space to be left between parent and child nodes.|20 pixels applicable only for vertical chart orientations.|
|options.hasSubTree|Gets whether the node contains subtrees.|Boolean|
|options.level|Gets the depth of the node from layout root.|Number|
|options.enableRouting|By default, connections are routed based on the chart type and orientations. This property gets or sets whether default routing is to be enabled or disabled.|true|
|options.rows|Sets the number of rows on which the child nodes will be arranged. Applicable only for balanced type horizontal tree.|Number|

The following table illustrates the different chart orientations and chart types.

|Orientation|Type|Description|Example|
| -------- | ----------- | ------------- |------|
|Horizontal|Left|Arranges the child nodes horizontally at the left side of the parent.|![Horizontal Left](../images//hleft.JPG)|
|Horizontal|Right|Arranges the child nodes horizontally at the right side of the parent.|![Horizontal Right](../images//hright.JPG)|
|Horizontal|Center|Arranges the children like standard tree layout orientation.|![Horizontal Center](../images//hcenter.JPG)|
|Horizontal|Balanced|Arranges the leaf level child nodes in multiple rows.|![Horizontal Balanced](../images//hbalanced.JPG)|
|Vertical|Left|Arranges the children vertically at the left side of the parent.|![Vertical Left](../images//vleft.JPG)|
|Vertical|Right|Arranges the children vertically at the right side of the parent.|![Vertical Right](../images//vright.JPG)|
|Vertical|Alternate|Arranges the children vertically at both left and right sides of the parent.|![Vertical Alternate](../images//vAlternate.JPG)|

### SubTree horizontal orientation

The following example shows how to utilize the `getLayoutInfo` function to customize the sub tree alignment in horizontal orientation.

{% tabs %}
{% highlight ts tabtitle="index.ts" %}
{% include code-snippet/diagram/AutomaticLayout-cs4/index.ts %}
{% endhighlight %}
{% highlight html tabtitle="index.html" %}
{% include code-snippet/diagram/AutomaticLayout-cs4/index.html %}
{% endhighlight %}
{% endtabs %}
        
{% previewsample "page.domainurl/code-snippet/diagram/AutomaticLayout-cs4" %}

### SubTree vertical orientation 

The following code example illustrates how to set the vertical arrangement to the leaf level trees.

{% tabs %}
{% highlight ts tabtitle="index.ts" %}
{% include code-snippet/diagram/AutomaticLayout-cs5/index.ts %}
{% endhighlight %}
{% highlight html tabtitle="index.html" %}
{% include code-snippet/diagram/AutomaticLayout-cs5/index.html %}
{% endhighlight %}
{% endtabs %}
        
{% previewsample "page.domainurl/code-snippet/diagram/AutomaticLayout-cs5" %}


### Assistant

Assistants are child item that have a different relationship with the parent node. They are laid out in a dedicated part of the tree. A node can be specified as an assistant of its parent by adding it to the `assistants` property of the argument `options`.

The following code example illustrates how to add assistants to layout.

{% tabs %}
{% highlight ts tabtitle="index.ts" %}
{% include code-snippet/diagram/AutomaticLayout-cs6/index.ts %}
{% endhighlight %}
{% highlight html tabtitle="index.html" %}
{% include code-snippet/diagram/AutomaticLayout-cs6/index.html %}
{% endhighlight %}
{% endtabs %}
        
{% previewsample "page.domainurl/code-snippet/diagram/AutomaticLayout-cs6" %}

![Assistant](../images//assistant.png)

N> An Assistant node cannot have any child nodes

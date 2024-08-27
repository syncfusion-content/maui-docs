---
layout: post
title: Placeholder in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Placeholder support in Syncfusion .NET MAUI Kanban Board (SfKanban) control and more.
platform: maui
control: Kanban
documentation: ug
---

# Placeholder in .NET MAUI Kanban Board (SfKanban)

The placeholder is to denote a card's new position in the [`KanbanColumn`](). It will appear while dragging a card over the column.

### Placeholder style

[`PlaceholderStyle`]() property is used to customize the placeholder. Following [`KanbanPlaceholderStyle`]() properties are used to customize its appearance.

* [`Fill`]() - This property is used to change the background color of the placeholder.
* [`Stroke`]() - This property is used to change the border color of the placeholder.
* [`StrokeWidth`]() - This property is used to change the border width of the placeholder.
* [`StrokeDashArray`]() - This property is used to change the dashes of the placeholder border.
* [`FontSize`]() - This is used to change the text size of the placeholder.
* [`TextColor`]() - This property is used to change the text color of the placeholder.

Following properties are used to customize the selected category when you have more than one category in a column.

* [`SelectedFill`]() - This property is used to change the background color of the selected placeholder.
* [`SelectedStroke`]() - This property is used to change the border color of the selected placeholder.
* [`SelectedStrokeWidth`]() - This property is used to change the border width of the selected placeholder.
* [`SelectedStrokeDashArray`]() - This property is used to change the dashes of the selected placeholder.
* [`SelectedFontSize`]() - This is used to change the font size of the text in selected placeholder.
* [`SelectedTextColor`]() - This property is used to change the color of the text in selected placeholder.

The following code example describes the above behavior.

{% tabs %}

{% highlight xaml %}

    <kanban:SfKanban.PlaceholderStyle >

        <kanban:KanbanPlaceholderStyle FontSize="16"
        TextColor="Green"
        Fill="Fuchsia"
        Stroke="Fuchsia"
        StrokeWidth="2"
        SelectedFontSize="16"
        SelectedTextColor="Red"
        SelectedStroke="Yellow"
        SelectedStrokeWidth="2"
        SelectedFill="Green">
        </kanban:KanbanPlaceholderStyle>

    </kanban:SfKanban.PlaceholderStyle>

{% endhighlight %}

{% highlight C# %}

    KanbanPlaceholderStyle style = new KanbanPlaceholderStyle();

    style.FontSize = 20;
    style.TextColor = Colors.Red;
    style.Fill = Colors.Fuchsia;
    style.Stroke = Colors.Blue;
    style.StrokeWidth = 2;
    style.StrokeDashArray = new double[] { 1, 1 };

    style.SelectedFontSize = 20;
    style.SelectedTextColor = Colors.Red;
    style.SelectedFill = Colors.Yellow;
    style.SelectedFill = Colors.Green;
    style.SelectedStrokeWidth = 2;
    style.SelectedStrokeDashArray = new double[] { 2, 1 };

    kanban.PlaceholderStyle = style;

{% endhighlight %}

{% endtabs %}

The following output demonstrates the above code example.
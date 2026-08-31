---
layout: post
title: Methods in .NET MAUI Grid Splitter | Syncfusion®
description: Learn about the methods available in the Syncfusion® .NET MAUI Grid Splitter control for managing panes programmatically.
platform: MAUI
control: SfGridSplitter
documentation: UG
---

# Methods in .NET MAUI Grid Splitter

The [.NET MAUI Grid Splitter] control provides methods to add, remove, collapse, and expand panes programmatically. These methods enable you to dynamically modify the splitter layout at runtime based on user actions or application requirements.

## AddPane

The `AddPane` method adds a new pane to the `SplitterPanes` collection after the last existing pane.

The following example adds a new pane after the last existing pane.

{% tabs %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane pane1 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "New Pane",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "New Pane",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);
Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

N>
* If the specified index equals the current pane count, the pane is appended to the end of the collection.
* When a pane is added, the Grid Splitter automatically rebuilds its internal layout and separators.
* If the index is outside the valid range, the operation is ignored.

---

## RemovePane

The `RemovePane` method removes the pane at the specified index.

{% tabs %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane pane1 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "Pane 1",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "Pane 2",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane3 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "Pane 3",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);
gridSplitter.AddPane(pane3);

// Remove Pane
gridSplitter.RemovePane(1);

Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

* The layout is automatically updated after the pane is removed.
* Associated separators are recreated as needed.
* If fewer than two panes remain, separators are removed automatically.
* Invalid indexes are ignored.

---

## CollapsePane

The `CollapsePane` method collapses the pane at the specified index.

{% tabs %}
{% highlight c# %}

void CollapsePane(int index)

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();
SplitterPane pane1 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "New Pane",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "New Pane",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);
Content = gridSplitter;

gridSplitter.CollapsePane(0);

{% endhighlight %}
{% endtabs %}

* The pane size is reduced to zero.
* The pane's `IsCollapsed` property becomes `true`.
* The `Collapsing` and `Collapsed` events are raised.
* If the pane is already collapsed, the method has no effect.
* If the pane is not collapsible, the method is ignored.

---

## ExpandPane

The `ExpandPane` method restores a previously collapsed pane.

{% tabs %}
{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();
SplitterPane pane1 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "New Pane",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

SplitterPane pane2 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "New Pane",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center
    }
};

gridSplitter.AddPane(pane1);
gridSplitter.AddPane(pane2);
Content = gridSplitter;

gridSplitter.CollapsePane(0);

// Later

gridSplitter.ExpandPane(0);

{% endhighlight %}
{% endtabs %}

* The pane is restored to its previous size.
* The pane's `IsCollapsed` property becomes `false`.
* The `Expanding` and `Expanded` events are raised.
* If the pane is already expanded, the method has no effect.
* If the pane is not collapsible, the method is ignored.

---

## Add and remove panes dynamically

The following example demonstrates dynamically modifying the Grid Splitter layout.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout Spacing="12" Padding="16">

    <gridSplitter:SfGridSplitter x:Name="gridSplitter" HeightRequest="300">
        <gridSplitter:SfGridSplitter.SplitterPanes>
            <gridSplitter:SplitterPane>
                <Label Text="Pane 1" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
            </gridSplitter:SplitterPane>

            <gridSplitter:SplitterPane>
                <Label Text="Pane 2" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
            </gridSplitter:SplitterPane>

            <gridSplitter:SplitterPane>
                <Label Text="Pane 3" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
            </gridSplitter:SplitterPane>
        </gridSplitter:SfGridSplitter.SplitterPanes>
    </gridSplitter:SfGridSplitter>

    <Button Text="Add Pane" Clicked="AddPaneClicked" />

    <Button Text="Remove Pane" Clicked="RemovePaneClicked" />

</VerticalStackLayout>

{% endhighlight %}
{% highlight c# %}

private void AddPaneClicked(object sender, EventArgs e)
{
    SplitterPane pane = new SplitterPane()
    {
        Size = "1*",
        Content = new Label()
        {
            Text = "Dynamically Added Pane",
            VerticalTextAlignment = TextAlignment.Center,
            HorizontalTextAlignment = TextAlignment.Center
        }
    };

    gridSplitter.AddPane(pane);
}

private void RemovePaneClicked(object sender, EventArgs e)
{
    gridSplitter.RemovePane(2);
}

{% endhighlight %}
{% endtabs %}

This approach is useful when creating customizable dashboards, workspace layouts, and document editors.

---

## Collapse and expand panes dynamically

The following example shows how to control pane visibility programmatically.

{% tabs %}
{% highlight c# %}

private async void CollapseNavigationPane()
{
    await gridSplitter.CollapsePane(0);
}

private async void ExpandNavigationPane()
{
    await gridSplitter.ExpandPane(0);
}

{% endhighlight %}
{% endtabs %}

This scenario is commonly used to create navigation drawers, explorer panels, or tool windows that can be hidden to maximize workspace area.

---

## Complete example

The following example demonstrates all Grid Splitter methods.

{% tabs %}
{% highlight c# %}

SfGridSplitter splitter = new SfGridSplitter();

SplitterPane pane1 = new SplitterPane()
{
    Size = "1*",
    IsCollapsible = true,
    Content = new Label()
    {
        Text = "Pane 1",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center,
    }
};

SplitterPane pane2 = new SplitterPane()
{
    Size = "1*",
    Content = new Label()
    {
        Text = "Pane 2",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center,
    }
};

splitter.SplitterPanes.Add(pane1);
splitter.SplitterPanes.Add(pane2);

// Add a pane.
splitter.AddPane( new SplitterPane()
{
    Content = new Label()
    {
        Text = "Pane 3",
        VerticalTextAlignment = TextAlignment.Center,
        HorizontalTextAlignment = TextAlignment.Center,
    }
});

// Collapse a pane.
splitter.CollapsePane(0);

// Expand a pane.
splitter.ExpandPane(0);

// Remove a pane.
splitter.RemovePane(2);

Content = splitter;
{% endhighlight %}
{% endtabs %}

## Use cases

The Grid Splitter methods are useful for the following scenarios:

* Dynamically adding dashboard panels.
* Removing workspace sections at runtime.
* Showing and hiding navigation regions.
* Building IDE-style layouts with collapsible tool windows.
* Creating customizable reporting and analytics interfaces
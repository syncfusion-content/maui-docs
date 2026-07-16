---
layout: post
title: Liquid Glass Effect for .NET MAUI ListView | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI ListView (SfListView) control.
platform: MAUI
control: SfListView
documentation: ug
---

# Liquid Glass Effect in .NET MAUI ListView (SfListView)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI ListView (SfListView) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the ListView control:

### Step 1: Wrap the control inside SfGlassEffectView

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `ListView` control, wrap it inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html).

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the Liquid Glass Effect on `SfListView`

Set the `EnableLiquidGlassEffect` property to `true` in the `SfListView` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls, such as the scrollbar and item template visuals, and provides responsive interaction for a smooth and engaging user experience.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfListView` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}
<Grid>
      <core:SfGlassEffectView x:Name="glassview" EffectType="Regular">
          <ListView:SfListView x:Name="listView"
                           EnableLiquidGlassEffect="True"
                           SelectionMode="None"
                           DragStartMode="OnHold">

              <ListView:SfListView.ItemTemplate>
                  <DataTemplate>
                      <Grid Padding="8">
                          <Label Text="{Binding .}" />
                      </Grid>
                  </DataTemplate>
              </ListView:SfListView.ItemTemplate>

          </ListView:SfListView>
      </core:SfGlassEffectView>
  </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="18" %}


using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;
using Syncfusion.Maui.ListView;
using System.Collections.Generic;

public class MainPage : ContentPage
{
    public MainPage()
    {
        // Create list using for loop
        var items = new List<string>();
        for (int i = 1; i <= 10; i++)
        {
            items.Add($"ListView Item {i}");
        }

        // Create controls
        var glassView = new SfGlassEffectView { EffectType = GlassEffectType.Regular };

        var listView = new SfListView
        {
            ItemsSource = items,
            EnableLiquidGlassEffect = true,
            SelectionMode = Syncfusion.Maui.ListView.SelectionMode.None,
            DragStartMode = DragStartMode.OnHold,
            ItemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid { Padding = 8 };
                var label = new Label();
                // Bind to current item (string)
                label.SetBinding(Label.TextProperty, ".");
                grid.Add(label);
                return grid;
            })
        };

        glassView.Content = listView;
        Content = new Grid { Children = { glassView } };
    }
}

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
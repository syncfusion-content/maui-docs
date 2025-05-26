---
layout: post
title: How to Customize Theming in Syncfusion® Controls
description: Learn how to switch between light and dark themes in Syncfusion® MAUI controls, along with additional details on this feature.
platform: MAUI
control: General
documentation: UG
---

# Switching Between Light Theme and Dark Theme

Refer to the following example code to switch between light and dark themes in Syncfusion<sup>®</sup> MAUI controls.

{% highlight C# %} 
void UpdateTheme(object sender, System.EventArgs e)
{
    ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
    if (mergedDictionaries != null)
    {
        var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
        if (theme != null)
        {
            if (theme.VisualTheme is SfVisuals.MaterialDark)
            {
                theme.VisualTheme = SfVisuals.MaterialLight;
            }
            else
            {
                theme.VisualTheme = SfVisuals.MaterialDark;
            }
        }
     }
}

{% endhighlight %}

The complete theme switch sample is available in this [link](https://github.com/SyncfusionExamples/Switching-between-light-and-dark-themes-in-.NET-Maui).
---
layout: post
title: How to customize theming in Syncfusion controls
description: Learn here all about how to switch between light and dark themes in Syncfusion Maui controls, along with additional details on this feature.
platform: maui
control: General
documentation: ug
---

# Switching between light theme and dark theme

Refer to the following example code to switch between light and dark themes in Syncfusion Maui controls.

{% highlight C# %} 
void UpdateTheme(object sender, System.EventArgs e)
{
    ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
    if (mergedDictionaries != null)
    {
        var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
        if (theme != null)
        {
            if (theme.SfVisualTheme is SfVisuals.MaterialDark)
            {
                theme.SfVisualTheme = SfVisuals.MaterialLight;
            }
            else
            {
                theme.SfVisualTheme = SfVisuals.MaterialDark;
            }
        }
     }
}

{% endhighlight %}

The complete theme switch sample is available in `this` link.
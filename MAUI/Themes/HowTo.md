---
layout: post
title: How to customize theming in Syncfusion controls
description: Learn here about how to switch between light and dark themes in Syncfusion Maui controls and more details.
platform: maui
control: General
documentation: ug
---

# Switching between light theme and dark theme

To switch to light theme from dark theme, use the following code snippet.

{% highlight C# %} 
void UpdateTheme(object sender, System.EventArgs e)
{
    ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
    if (mergedDictionaries != null)
    {
        var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
        if (theme != null)
        {
            if (theme.SfVisualTheme is SfVisuals.DarkDefault)
            {
                theme.SfVisualTheme = SfVisuals.LightDefault;
                Application.Current.UserAppTheme = AppTheme.Light;
            }
            else
            {
                theme.SfVisualTheme = SfVisuals.DarkDefault;
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
        }
     }
}

{% endhighlight %}

Similarly, to switch to dark theme from light theme, remove the light theme resource, and add the dark theme resource dictionary.

The complete Theme switch sample is available in `this` link.
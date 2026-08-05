---
layout: post
title: Combining Effects in .NET MAUI Effects View | Syncfusion®
description: Learn all about the combination of effects support in Syncfusion® .NET MAUI Effects View control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Combining Effects in .NET MAUI Effects View

The `.NET MAUI Effects View` control supports applying multiple [SfEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html) in combination on a single view.

The examples below use the XAML and C# tab pair to demonstrate each valid combination.

## Highlight and Ripple on TouchDown

{% tabs %} 

{% highlight xaml hl_lines="4" %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownEffects="Highlight,Ripple">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="25" %} 

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchDownEffects = SfEffects.Highlight | SfEffects.Ripple
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Highlight on TouchDown with Selection on LongPress

{% tabs %} 

{% highlight xaml hl_lines="4 5" %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressEffects="Selection"
                               TouchDownEffects="Highlight">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="25 26" %} 

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    LongPressEffects = SfEffects.Selection,
    TouchDownEffects = SfEffects.Highlight
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Ripple on TouchDown with Selection on TouchUp

{% tabs %} 

{% highlight xaml hl_lines="4 5" %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownEffects="Ripple"
                               TouchUpEffects="Selection">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="25 26" %} 

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    TouchDownEffects = SfEffects.Ripple,
    TouchUpEffects = SfEffects.Selection
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Highlight, Ripple on TouchDown with Selection on LongPress

{% tabs %} 

{% highlight xaml hl_lines="4 5" %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressEffects="Selection"
                               TouchDownEffects="Highlight,Ripple">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="25 26" %} 

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    LongPressEffects = SfEffects.Selection,
    TouchDownEffects = SfEffects.Highlight | SfEffects.Ripple
};

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## Scale and Selection on LongPress

{% tabs %} 

{% highlight xaml hl_lines="4" %} 

<syncEffectsView:SfEffectsView HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressEffects="Scale,Selection">
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" 
                              Offset="0.0" />
                <GradientStop Color="#4ECDC4" 
                              Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# hl_lines="25" %} 

var grid = new Grid
{
    Padding = new Thickness(12),
    WidthRequest = 350,
    HeightRequest = 150,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Background = new LinearGradientBrush
    {
        EndPoint = new Point(1, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop(Color.FromArgb("#FF6B6B"), 0.0f),
            new GradientStop(Color.FromArgb("#4ECDC4"), 1.0f)
        }
    }
};

var effectsView = new SfEffectsView
{
    Content = grid,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    LongPressEffects = SfEffects.Scale | SfEffects.Selection
};

this.Content = effectsView;

{% endhighlight %}
{% endtabs %}

## See also

- [Highlight](https://help.syncfusion.com/maui/effects-view/effects/highlight)
- [Ripple](https://help.syncfusion.com/maui/effects-view/effects/ripple)
- [Selection](https://help.syncfusion.com/maui/effects-view/effects/selection)
- [Scale](https://help.syncfusion.com/maui/effects-view/effects/scale)
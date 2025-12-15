---
layout: post
title: Liquid Glass Support for .NET MAUI Step ProgressBar | Syncfusion®
description: Learn how to enable liquid glass support for the Syncfusion® .NET MAUI Step ProgressBar (SfStepProgressBar) control using SfGlassEffectsView.
platform: MAUI
control: SfStepProgressBar
documentation: ug
---

# Liquid Glass Support

The [SfStepProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html) supports a liquid glass appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when the step progressbar is placed over images or colorful layouts.

N> This feature is supported only on `.NET 10`

## Supported Platforms

* macOS 26 or higher
* iOS 26 or higher

## Prerequisites

* Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package (for SfGlassEffectsView).
* Add the [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar/) package (for SfStepProgressBar).

## Apply Liquid Glass Effect to SfStepProgressBar

{% tabs %}
{% highlight xaml %}

...
xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
xmlns:stepProgressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar"

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<stepProgressBar:SfStepProgressBar x:Name="stepProgress"
                                   VerticalOptions="Center"
                                   HorizontalOptions="Center"
                                   Orientation="Horizontal"
                                   LabelSpacing="12"
                                   ActiveStepIndex="2"
                                   ActiveStepProgressValue="60"
                                   ProgressAnimationDuration="2500"
                                   ItemsSource="{Binding StepProgressItem}">
    <stepProgressBar:SfStepProgressBar.StepTemplate>
        <DataTemplate>
            <Grid>
                <core:SfGlassEffectView WidthRequest="32"
                                        HeightRequest="32"
                                        CornerRadius="16"
                                        Background="#007AFF">
                    <Border Background="Transparent"
                            Margin="0.5">
                        <Border.StrokeShape>
                            <RoundRectangle CornerRadius="15" />
                        </Border.StrokeShape>
                        <Label Text="&#xe70c;"
                               FontFamily="MauiMaterialAssets"
                               HorizontalOptions="Center"
                               VerticalOptions="Center"
                               TextColor="White"
                               FontSize="20" />
                    </Border>
                </core:SfGlassEffectView>
            </Grid>
        </DataTemplate>
    </stepProgressBar:SfStepProgressBar.StepTemplate>
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.ProgressBar;

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StepProgressBarOrientation.Horizontal,
    LabelSpacing = 12,
    ActiveStepIndex = 2,
    ActiveStepProgressValue = 60,
    ProgressAnimationDuration = 2500,
    ItemsSource = viewModel.StepProgressItem,
};

var stepTemplate = new DataTemplate(() =>
{
    var grid = new Grid();

    var glassVeiew = new SfGlassEffectView
    {
        WidthRequest = 32,
        HeightRequest = 32,
        CornerRadius = 16,
        Background = Color.FromArgb("#007AFF")
    };

    var border = new Border
    {
        Background = Colors.Transparent,
        Margin = new Thickness(0.5),
        StrokeShape = new RoundRectangle
        {
            CornerRadius = new CornerRadius(15)
        }
    };

    var iconLabel = new Label
    {
        Text = "\ue70c",
        FontFamily = "MauiMaterialAssets",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        TextColor = Colors.White,
        FontSize = 20
    };

    border.Content = iconLabel;
    glassVeiew.Content = border;
    grid.Add(glassVeiew);

    return grid;
});

stepProgressBar.StepTemplate = stepTemplate;
this.Content = stepProgressBar;

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    /// <summary>
    /// The Step progress bar item collection.
    /// </summary>
    private ObservableCollection<StepProgressBarItem> stepProgressItem;

    /// <summary>
    /// The Step progress bar item collection.
    /// </summary>
    public ObservableCollection<StepProgressBarItem> StepProgressItem
    {
        get
        {
            return stepProgressItem;
        }
        set
        {
            stepProgressItem = value;
        }
    }

    public ViewModel()
    {
        stepProgressItem = new ObservableCollection<StepProgressBarItem>();
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Cart" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Address" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Delivery" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Ordered" });
    }
}

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.
* Use EffectType="Regular" for a blurrier look and "Clear" for a glassy look.

## Key Properties

* [EffectType](): Choose between Regular (blurry) and Clear (glassy) effects.
* [EnableShadowEffect](): Enables a soft shadow around the acrylic container.
* [CornerRadius](): Rounds the corners of the acrylic container.
* Padding/Height/Width: Adjust layout around the embedded step progressbar.

## Best Practices and Tips

* Hosting the step progressbar inside [SfGlassEffectsView]() gives the step progressbar body an acrylic look.
* For the most noticeable effect, place the control over images or vibrant backgrounds.
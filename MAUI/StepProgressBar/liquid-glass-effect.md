---
layout: post
title: Liquid Glass Support for .NET MAUI Step Progress Bar | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Step Progress Bar (SfStepProgressBar) control.
platform: MAUI
control: SfStepProgressBar
documentation: ug
---

# Liquid Glass Support for Step Progress Bar

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Step Progress Bar (SfStepProgressBar) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Step Progress Bar control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to the Syncfusion® .NET MAUI [StepProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html) control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the [Liquid Glass Getting Started documentation](https://help.syncfusion.com/maui/liquid-glass-ui/getting-started).

### Step 2: Customize the background

To achieve a glass like background in the Step Progress Bar, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the [SfStepProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html) control:

{% tabs %}
{% highlight xaml %}

...
xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
xmlns:stepProgressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar"

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75"
                          Offset="0.0" />
            <GradientStop Color="#3282B8"
                          Offset="0.5" />
            <GradientStop Color="#1B262C"
                          Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
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
</Grid>

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
grid.Children.Add(stepProgressBar);
this.Content = grid;

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
* Supported on `macOS 26 or higher` and `iOS 16 or higher`.
* This feature is available only in `.NET 10.`
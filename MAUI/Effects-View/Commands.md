---
layout: post
title: Commands in .NET MAUI Effects View Control | Syncfusion®
description: Learn about the commands available in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Commands and CommandParameter

## Prerequisites

Before using the [`SfEffectsView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/effects-view/getting-started) documentation.

The `SfEffectsView` exposes `ICommand` properties for each touch interaction, letting you bind view-model logic directly to the view. Each command is paired with an `object`-typed `CommandParameter` property so you can pass context to the bound logic.


## Defining the ICommand

The examples below use a simple `RelayCommand` helper. Add this class to your project or replace it with your preferred MVVM toolkit (for example, `CommunityToolkit.Mvvm.Input.RelayCommand`).

{% tabs %} 

{% highlight c# %}

using System.Windows.Input;

namespace MyApp;

public class RelayCommand : ICommand
{
    private readonly Action<object?> execute;
    private readonly Func<object?, bool>? canExecute;

    public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public bool CanExecute(object? parameter) => canExecute?.Invoke(parameter) ?? true;

    public void Execute(object? parameter) => execute(parameter);

    public event EventHandler? CanExecuteChanged;
}

{% endhighlight %}

{% endtabs %}

## TouchDownCommand

The [TouchDownCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownCommand) property fires when the user presses the view.

#{% tabs %} 

{% highlight xaml %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownCommand="{Binding TouchDownCommand}"
                               TouchDownCommandParameter="{x:Reference effectsView}">
    <syncEffectsView:SfEffectsView.BindingContext>
        <local:EffectsViewModel/>
    </syncEffectsView:SfEffectsView.BindingContext>
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# %}

var viewModel = new EffectsViewModel();
this.BindingContext = viewModel; 

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
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Content = grid
};

effectsView.TouchDownCommand = viewModel.TouchDownCommand;
effectsView.TouchDownCommandParameter = effectsView;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## TouchUpCommand

The [TouchUpCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpCommand) property fires when the user releases the press.

#{% tabs %} 

{% highlight xaml %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchUpCommand="{Binding TouchUpCommand}"
                               TouchUpCommandParameter="{x:Reference effectsView}">
    <syncEffectsView:SfEffectsView.BindingContext>
        <local:EffectsViewModel/>
    </syncEffectsView:SfEffectsView.BindingContext>
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# %}

var viewModel = new EffectsViewModel();
this.BindingContext = viewModel; 

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
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Content = grid
};

effectsView.TouchUpCommand = viewModel.TouchUpCommand;
effectsView.TouchUpCommandParameter = effectsView;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## LongPressedCommand

The [LongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressedCommand) property fires when the user long-presses the view.

#{% tabs %} 

{% highlight xaml %}
<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               LongPressedCommand="{Binding LongPressedCommand}"
                               LongPressedCommandParameter="{x:Reference effectsView}" >
    <syncEffectsView:SfEffectsView.BindingContext>
        <local:EffectsViewModel/>
    </syncEffectsView:SfEffectsView.BindingContext>
    <Grid Padding="12" 
          WidthRequest="350" 
          HeightRequest="150"
          HorizontalOptions="Center" 
          VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% highlight c# %}

var viewModel = new EffectsViewModel();
this.BindingContext = viewModel; 

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
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    Content = grid
};

effectsView.LongPressedCommand = viewModel.LongPressedCommand;
effectsView.LongPressedCommandParameter = effectsView;

this.Content = effectsView;

{% endhighlight %}

{% endtabs %}

## End-to-End Example

The example below wires a complete view model and a XAML page together so the commands fire when the user interacts with the `SfEffectsView`.

### ViewModel

{% tabs %} 

{% highlight c# tabtitle="ViewModel" %}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MyApp;

public class EffectsViewModel : INotifyPropertyChanged
{
    public ICommand TouchDownCommand { get; }
    public ICommand TouchUpCommand { get; }
    public ICommand LongPressedCommand { get; }

    public EffectsViewModel()
    {
        TouchDownCommand = new RelayCommand(p => OnTouchDown(p));
        TouchUpCommand = new RelayCommand(p => OnTouchUp(p));
        LongPressedCommand = new RelayCommand(p => OnLongPressed(p));
    }

    private void OnTouchDown(object? parameter)
    {
        // React to the touch-down here.
    }

    private void OnTouchUp(object? parameter)
    {
        // React to the touch-up here.
    }

    private void OnLongPressed(object? parameter)
    {
        // React to the long-press here.
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}

{% endhighlight %}

{% highlight xaml %}

<syncEffectsView:SfEffectsView x:Name="effectsView"
                               HorizontalOptions="Center" 
                               VerticalOptions="Center"
                               TouchDownCommand="{Binding TouchDownCommand}"
                               TouchUpCommand="{Binding TouchUpCommand}"
                               LongPressedCommand="{Binding LongPressedCommand}"
                               TouchDownCommandParameter="{x:Reference effectsView}"
                               TouchUpCommandParameter="{x:Reference effectsView}"
                               LongPressedCommandParameter="{x:Reference effectsView}" >
    <syncEffectsView:SfEffectsView.BindingContext>
        <local:EffectsViewModel/>
    </syncEffectsView:SfEffectsView.BindingContext>
    <Grid Padding="12" 
        WidthRequest="350" 
        HeightRequest="150"
        HorizontalOptions="Center" 
        VerticalOptions="Center">
        <Grid.Background>
            <LinearGradientBrush EndPoint="1,1">
                <GradientStop Color="#FF6B6B" Offset="0.0" />
                <GradientStop Color="#4ECDC4" Offset="1.0" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
</syncEffectsView:SfEffectsView>

{% endhighlight %}

{% endtabs %}

## Commands vs. Trigger Properties

The command properties and the trigger properties (`TouchDownEffects`, `TouchUpEffects`, `LongPressEffects`, `Effects`) are independent. Commands fire alongside any visual effect you have configured, so you can use a trigger property to play the visual feedback and a command to run your view-model logic at the same time.
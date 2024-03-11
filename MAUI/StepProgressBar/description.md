---
layout: post
title: Description in .NET MAUI Step ProgressBar control | Syncfusion
description: Learn here all about Description support in Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar) control and more.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Description in .NET MAUI StepProgressBar (Step Progress Bar)
Each step in a multi-step process has a different operation. To display information about a step's status can be shown on either side. A primary description will be on the right or bottom of the step, and a secondary description will be on the left or top of the step.

## StepProgressBar overview
The following overview image illustrates the major elements presented in StepProgressBar.

## Text 
The primary and secondary description for a step view can be set using the [PrimaryText]() and [SecondaryText]() properties as demonstrated in the following code example.

* Create a simple Observable Collection of item for the step progressbar,

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="25 26 27 28" %}

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
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Completed", SecondaryText = "Task" });
    }
}

{% endhighlight %}
{% endtabs %}

* Bind the Collection to step progressbar

The Step progressbar control allows you to bind item collection by setting the [ItemsSource]() property from the [SfStepProgressBar](). Bind item collection in both XAML and C#.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="6" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgressBar"
                    Margin="24,10,0,0"
                    LabelSpacing="12"
                    Orientation="Horizontal"  
                    ItemsSource="{Binding StepProgressItem}">
</stepProgressBar:SfStepProgressBar>

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="7" %}

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    Margin = new Thickness(24, 10, 0, 0),
    LabelSpacing = 12,
    Orientation = StepProgressBarOrientation.Horizontal,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

## Formatted text
To customize the description with different formatting style, [PrimaryFormattedText]() and [SecondaryFormattedText]() can be used. The following code example explains how to set `PrimaryFormattedText` and `SecondaryFormattedText` to a step view.

* Create a simple Observable Collection of item for the step progressbar,

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="34" %}

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
        FormattedString primaryFormattedText = new FormattedString();
        primaryFormattedText.Spans.Add(new Span { Text = "Ordered and Approved", FontSize = 13 });
        primaryFormattedText.Spans.Add(new Span { Text = "&#Your Order has been placed", FontSize = 12 });

        FormattedString secondaryFormattedText = new FormattedString();
        secondaryFormattedText.Spans.Add(new Span { Text = "Friday", FontSize = 13 });
        secondaryFormattedText.Spans.Add(new Span { Text = "&#September 22, 2023 ", FontSize = 12 });

        stepProgressItem = new ObservableCollection<StepProgressBarItem>();
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryFormattedText = primaryFormattedText, SecondaryFormattedText = secondaryFormattedText  });
    }
}

{% endhighlight %}
{% endtabs %}

* Bind the Collection to step progressbar

The Step progressbar control allows you to bind item collection by setting the [ItemsSource]() property from the [SfStepProgressBar](). Bind item collection in both XAML and C#.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="6" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgressBar"
                    Margin="24,10,0,0"
                    LabelSpacing="12"
                    Orientation="Horizontal"  
                    ItemsSource="{Binding StepProgressItem}">
</stepProgressBar:SfStepProgressBar>                                                                                              

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="7" %}

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    Margin = new Thickness(24, 10, 0, 0),
    LabelSpacing = 12,
    Orientation = StepProgressBarOrientation.Horizontal,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

N> If both `PrimaryText` and `PrimaryFormattedText` is provided, then PrimaryFormattedText will be displayed.

## Customize description
Using [LabelPosition]() and [LabelSpacing]() property, the description alignment and space between the description and step can be customized, respectively. The following code example explains how to customize the LabelPosition and LabelSpacing properties.
{% tabs %}

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5 6" %}

<stepProgressBar:SfStepProgressBar
                           x:Name="stepProgress"
                           Margin="24,10,0,0"                                             
                           Orientation="Horizontal"                                                                                       
                           LabelSpacing="25"
                           LabelPosition="Start">
</stepProgressBar:SfStepProgressBar> 

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="5 6" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    Margin = new Thickness(24, 10, 0, 0),
    Orientation = StepProgressBarOrientation.Horizontal,
    LabelSpacing = 25,
    LabelPosition = LabelPosition.Start,   
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

## StepProgressBar Image Customization
The [StepProgressBar]() control provides support for customizing the image in [StepView](). The following code example explains how to set an image in step view.

### Initialize view model

* Create a simple Observable Collection of item with image source for the step progressbar,

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="26 27 28" %}

 public class ViewModel
 {
    /// <summary>
    /// The shiffement collection
    /// </summary>
    private ObservableCollection<StepProgressBarItem> stepProgressItem;

    /// <summary>
    /// The shiffement collection
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
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Ordered", ImageSource = "ordered.png" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Packed", ImageSource = "packed.png" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Shipped", ImageSource = "delivered.png" });
    }
 }

{% endhighlight %}
{% endtabs %}

* Bind the Collection to step progressbar

The Step progressbar control allows you to bind item collection by setting the [ItemsSource]() property from the [SfStepProgressBar](). Bind item collection in both XAML and C#.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="8" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgressBar"
                    Margin="24,10,0,0"
                    LabelSpacing="12"
                    Orientation="Horizontal"
                    ActiveStepIndex="2"
                    ActiveStepProgressValue="60" 
                    ItemsSource="{Binding StepProgressItem}">
</stepProgressBar:SfStepProgressBar>                                                                                              

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    Margin = new Thickness(24, 10, 0, 0),
    LabelSpacing = 12,
    Orientation = StepProgressBarOrientation.Horizontal,
    ActiveStepIndex = 2,
    ActiveStepProgressValue = 60,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}
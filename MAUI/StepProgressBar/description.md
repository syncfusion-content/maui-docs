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
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Ordered", SecondaryText = "December 1, 2023" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Packed", SecondaryText = "December 4, 2023" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Shipped", SecondaryText = "December 6, 2023" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Delivered", SecondaryText = "December 8, 2023" });
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
                    VerticalOptions="Center"
                    HorizontalOptions="Center"
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
{% highlight c# tabtitle="C#" hl_lines="7" %}

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{f
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
        FormattedString primaryFormattedText1 = new FormattedString();
        primaryFormattedText1.Spans.Add(new Span { Text = "Ordered Confirmed", FontSize = 13 });
        primaryFormattedText1.Spans.Add(new Span { Text = "\nYour Order has been placed", FontSize = 12 });

        FormattedString primaryFormattedText2 = new FormattedString();
        primaryFormattedText2.Spans.Add(new Span { Text = "Shipped", FontSize = 13 });
        primaryFormattedText2.Spans.Add(new Span { Text = "\nYour item has been shipped", FontSize = 12 });

        FormattedString primaryFormattedText3 = new FormattedString();
        primaryFormattedText3.Spans.Add(new Span { Text = "Delivered", FontSize = 13 });
        primaryFormattedText3.Spans.Add(new Span { Text = "\nYour item has been delivered", FontSize = 12 });

        FormattedString secondaryFormattedText1 = new FormattedString();
        secondaryFormattedText1.Spans.Add(new Span { Text = "Sunday", FontSize = 13 });
        secondaryFormattedText1.Spans.Add(new Span { Text = "\nMarch 03, 2024 ", FontSize = 12 });

        FormattedString secondaryFormattedText2 = new FormattedString();
        secondaryFormattedText2.Spans.Add(new Span { Text = "Monday", FontSize = 13 });
        secondaryFormattedText2.Spans.Add(new Span { Text = "\nMarch 4, 2024 ", FontSize = 12 });

        FormattedString secondaryFormattedText3 = new FormattedString();
        secondaryFormattedText3.Spans.Add(new Span { Text = "Wednesday", FontSize = 13 });
        secondaryFormattedText3.Spans.Add(new Span { Text = "\nMarch 6, 2023 ", FontSize = 12 });

        stepProgressItem = new ObservableCollection<StepProgressBarItem>();
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryFormattedText = primaryFormattedText1, SecondaryFormattedText = secondaryFormattedText1 });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryFormattedText = primaryFormattedText2, SecondaryFormattedText = secondaryFormattedText2 });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryFormattedText = primaryFormattedText3, SecondaryFormattedText = secondaryFormattedText3 });
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
                    VerticalOptions="Center"
                    HorizontalOptions="Center"
                    ActiveStepIndex="1"
                    ActiveStepProgressValue="60"
                    LabelSpacing="12"
                    Orientation="Vertical"  
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
    LabelSpacing = 12,
    Orientation = StepProgressBarOrientation.Vertical,
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
                        VerticalOptions="Center"
                        HorizontalOptions="Center"                                        
                        Orientation="Vertical"
                        ActiveStepIndex="1"
                        ActiveStepProgressValue="60"                                                                                     
                        LabelSpacing="28"
                        LabelPosition="Start">
</stepProgressBar:SfStepProgressBar> 

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="5 6" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    Orientation = StepProgressBarOrientation.Vertical,
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
                    VerticalOptions="Center"
                    HorizontalOptions="Center"
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
    LabelSpacing = 12,
    Orientation = StepProgressBarOrientation.Horizontal,
    ActiveStepIndex = 2,
    ActiveStepProgressValue = 60,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}
---
layout: post
title: Description in .NET MAUI Step ProgressBar Control | Syncfusion
description: Learn here all about Description support in Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar) control and more.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Description in .NET MAUI StepProgressBar (Step Progress Bar)
Each step in a multi-step process has a different operation. To display information about a step's status can be shown on either side. A primary description will be on the right or bottom of the step, and a secondary description will be on the left or top of the step.

## Text 
The primary and secondary descriptions for a step view can be set using the [PrimaryText]() and [SecondaryText]() properties, as demonstrated in the following code example.

* Create a simple Observable Collection of item for the step progressbar.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="26 27 28 29 30" %}

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
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Requirement Gathering", SecondaryText = "Jan 10, 2024" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Design Phase", SecondaryText = "Jan 20, 2024" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Development", SecondaryText = "Feb 5, 2024" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Testing", SecondaryText = "Feb 20, 2024" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Deployment", SecondaryText = "Mar 5, 2024" });
    }
}

{% endhighlight %}
{% endtabs %}

* Bind the Collection to the step progressbar

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="9" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgress"
                    VerticalOptions="Center"
                    HorizontalOptions="Center"                                        
                    Orientation="Vertical"                                                                                       
                    LabelSpacing="12"
                    ActiveStepIndex="3"
                    ActiveStepProgressValue="50"
                    ItemsSource="{Binding StepProgressItem}">
</stepProgressBar:SfStepProgressBar>

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="10" %}

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StepProgressBarOrientation.Vertical,
    LabelSpacing = 12,
    ActiveStepIndex = 3,
    ActiveStepProgressValue = 50,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

## Formatted text
[PrimaryFormattedText]() and [SecondaryFormattedText]() can be used to customize the description with different formatting style. The following code example explains how to set `PrimaryFormattedText` and `SecondaryFormattedText` to a step view.

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
        primaryFormattedText1.Spans.Add(new Span { Text = "Step 1: Introduction", FontSize = 14, FontAttributes = FontAttributes.Bold });
        primaryFormattedText1.Spans.Add(new Span { Text = "\nWelcome to our", FontSize = 12, TextColor = Colors.Gray });
        primaryFormattedText1.Spans.Add(new Span { Text = "\nplatform!", FontSize = 12, TextColor = Colors.Gray });

        FormattedString primaryFormattedText2 = new FormattedString();
        primaryFormattedText2.Spans.Add(new Span { Text = "Step 2: Registration", FontSize = 14, FontAttributes = FontAttributes.Bold });
        primaryFormattedText2.Spans.Add(new Span { Text = "\nCreate your account", FontSize = 12, TextColor = Colors.Gray });
        primaryFormattedText2.Spans.Add(new Span { Text = "\nto access exclusive features", FontSize = 12, TextColor = Colors.Gray });

        FormattedString primaryFormattedText3 = new FormattedString();
        primaryFormattedText3.Spans.Add(new Span { Text = "Step 3: Profile Setup", FontSize = 14, FontAttributes = FontAttributes.Bold });
        primaryFormattedText3.Spans.Add(new Span { Text = "\nComplete your profile", FontSize = 12, TextColor = Colors.Gray });
        primaryFormattedText3.Spans.Add(new Span { Text = "\nto personalize your experience", FontSize = 12, TextColor = Colors.Gray });

        FormattedString secondaryFormattedText1 = new FormattedString();
        secondaryFormattedText1.Spans.Add(new Span { Text = "Join us and explore!", FontSize = 12, TextColor = Colors.Gray });

        FormattedString secondaryFormattedText2 = new FormattedString();
        secondaryFormattedText2.Spans.Add(new Span { Text = "Unlock all features", FontSize = 12, TextColor = Colors.Gray });

        FormattedString secondaryFormattedText3 = new FormattedString();
        secondaryFormattedText3.Spans.Add(new Span { Text = "Personalize your journey", FontSize = 12, TextColor = Colors.Gray });

        stepProgressItem = new ObservableCollection<StepProgressBarItem>();
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryFormattedText = primaryFormattedText1, SecondaryFormattedText = secondaryFormattedText1 });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryFormattedText = primaryFormattedText2, SecondaryFormattedText = secondaryFormattedText2 });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryFormattedText = primaryFormattedText3, SecondaryFormattedText = secondaryFormattedText3 });
    }
}

{% endhighlight %}
{% endtabs %}

* Bind the Collection to step progressbar.

The Step progressbar control allows you to bind item collection by setting the [ItemsSource]() property from the [SfStepProgressBar](). Bind item collection in both XAML and C#.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="9" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgress"
                    VerticalOptions="Center"
                    HorizontalOptions="Center"                                        
                    Orientation="Vertical"                                                                                       
                    LabelSpacing="12"
                    ActiveStepIndex="1"
                    ActiveStepProgressValue="50"
                    ItemsSource="{Binding StepProgressItem}">
</stepProgressBar:SfStepProgressBar>                                                                                             

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="10" %}

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StepProgressBarOrientation.Vertical,
    LabelSpacing = 12,
    ActiveStepIndex = 1,
    ActiveStepProgressValue = 50,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

N> If both `PrimaryText` and `PrimaryFormattedText` are provided, then `PrimaryFormattedText` will be displayed. This precedence is same as for the `SecondaryText` and `SecondaryFormattedText`.

## Customize description
Using [LabelPosition]() and [LabelSpacing]() property, the description alignment and space between the description and step can be customized, respectively. The following code example explains how to customize the LabelPosition and LabelSpacing properties.
{% tabs %}

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="6 7" %}

<stepProgressBar:SfStepProgressBar
                        x:Name="stepProgress"
                        VerticalOptions="Center"
                        HorizontalOptions="Center"                                        
                        Orientation="Vertical"                                                                                   
                        LabelSpacing="28"
                        LabelPosition="Bottom">
</stepProgressBar:SfStepProgressBar> 

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="6 7" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StepProgressBarOrientation.Vertical,
    LabelSpacing = 28,
    LabelPosition = LabelPosition.Bottom,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

## StepProgressBar Image Customization

The [StepProgressBar]() control provides support for adding images as the content of the step. You can add the images by giving an image path and font icons.

### Customization using Image

You can add the images by giving image path to the [ImageSource]() property in `SfStepProgressBar`. The following code example explains how to set an image in step view.

#### Initialize view model

* Create a simple Observable Collection of item with image source for the step progressbar.

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
        stepProgressItem = new ObservableCollection<StepProgressBarItem>();
        stepProgressItem.Add(new StepProgressBarItem() { ImageSource = "ordered.png" });
        stepProgressItem.Add(new StepProgressBarItem() { ImageSource = "transport.png" });
        stepProgressItem.Add(new StepProgressBarItem() { ImageSource = "payment.png" });
        stepProgressItem.Add(new StepProgressBarItem() { ImageSource = "delivered.png" });
    }
 }

{% endhighlight %}
{% endtabs %}

* Bind the Collection to step progressbar.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="8" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgress"
                    VerticalOptions="Center"
                    HorizontalOptions="Center"                                        
                    Orientation="Horizontal"                                                                                       
                    LabelSpacing="12"
                    LabelPosition="Bottom"
                    ActiveStepIndex="2"
                    ActiveStepProgressValue="50"    
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
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StepProgressBarOrientation.Horizontal,
    LabelSpacing = 12,
    LabelPosition = LabelPosition.Bottom,
    ActiveStepIndex = 2,
    ActiveStepProgressValue = 50,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

### Customization using Font icon

You can add the images with font icons to the [ImageSource]() property in `SfStepProgressBar`. The following code example explains how to set an image in step view.

#### Initialize view model

* Create a simple Observable Collection of item with font icons for the step progressbar.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="26 27 28" %}

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
        stepProgressItem.Add(new StepProgressBarItem() { ImageSource = new FontImageSource() { Glyph = "\ue760", Size = 32, FontFamily = "IconFont", Color = Colors.White } });
        stepProgressItem.Add(new StepProgressBarItem() { ImageSource = new FontImageSource() { Glyph = "\ue77f", Size = 32, FontFamily = "IconFont", Color = Colors.White } });
        stepProgressItem.Add(new StepProgressBarItem() { ImageSource = new FontImageSource() { Glyph = "\ue786", Size = 32, FontFamily = "IconFont", Color = Colors.White } });
    }
 }

{% endhighlight %}
{% endtabs %}

* Bind the Collection to step progressbar.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="8" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgress"
                    VerticalOptions="Center"
                    HorizontalOptions="Center"                                        
                    Orientation="Horizontal"
                    ActiveStepIndex="2"
                    ActiveStepProgressValue="50"    
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
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StepProgressBarOrientation.Horizontal,
    ActiveStepIndex = 2,
    ActiveStepProgressValue = 50,
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}
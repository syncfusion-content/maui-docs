---
layout: post
title: Customization with .NET MAUI Step ProgressBar control | Syncfusion
description: Learns about Customization support with Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar)
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Customization in MAUI StepProgressBar

## Step content customization
You can customize the step [ContentType]() with [Numbering](), [Tick](), [Cross](), [Dot]() and [Images]().

{% tabs %}
{% highlight xaml hl_lines="1" %}

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<progressBar:SfStepProgressBar x:Name = "stepProgressBar" ItemsSource="{Binding StepProgressItem}"
                            StepSize="20"
                            StepContentSize="15">

    <progressBar:SfStepProgressBar.InProgressStepSettings>
        <progressBar:StepSettings Background="#ff67579c" ContentType="Dot" ContentFillColor="White"/>
    </progressBar:SfStepProgressBar.InProgressStepSettings>
    <progressBar:SfStepProgressBar.CompletedStepSettings>
        <progressBar:StepSettings Background="#ff67579c" ContentType="Tick" ContentFillColor="White"/>
    </progressBar:SfStepProgressBar.CompletedStepSettings>
    <progressBar:SfStepProgressBar.NotStartedStepSettings>
        <progressBar:StepSettings Background="#ff67579c" ContentType="Cross" ContentFillColor="White"/>
    </progressBar:SfStepProgressBar.NotStartedStepSettings>
</progressBar:SfStepProgressBar>

{% endhighlight %}

{% highlight c# %}

SfStepProgressBar sfstepProgressbar = new SfStepProgressBar()
{
    StepContentSize = 15,
    StepSize = 20
};
          
StepSettings inProgressStepSettings = new StepSettings();
inProgressStepSettings.Background = Color.FromHex("#ff67579c");
inProgressStepSettings.ContentType = StepContentType.Dot;
inProgressStepSettings.ContentFillColor = Colors.White;

StepSettings completedStepSettings = new StepSettings();
completedStepSettings.Background = Color.FromHex("#ff67579c");
completedStepSettings.ContentType = StepContentType.Tick;
completedStepSettings.ContentFillColor = Colors.White;

StepSettings notStartedStepSettings = new StepSettings();
notStartedStepSettings.Background = Color.FromHex("#ff67579c");
notStartedStepSettings.ContentType = StepContentType.Cross;
notStartedStepSettings.ContentFillColor = Colors.White;

sfstepProgressbar.InProgressStepSettings = inProgressStepSettings;
sfstepProgressbar.NotStartedStepSettings = notStartedStepSettings;
sfstepProgressbar.CompletedStepSettings = completedStepSettings;

this.Content = sfstepProgressbar;

{% endhighlight %}
{% endtabs %}

## ProgressBar customization

By using the [ProgressBarBackground](), [ActiveStepProgressValue](), [ActiveStepIndex]() you can customize the step progress bar.

{% tabs %}
{% highlight xaml hl_lines="1" %}

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<progressBar:SfStepProgressBar  ItemsSource="{Binding StepProgressItem}"
                            ProgressBarBackground="Red"
                            ActiveStepProgressValue="50"
                            ActiveStepIndex="1">

{% endhighlight %}

{% highlight c# %}

ViewModel viewModel=new ViewModel();
public MainPage()
{
    InitializeComponent();
    SfStepProgressBar sfstepProgressbar = new SfStepProgressBar()
    {
        ActiveStepIndex = 1,
        ActiveStepProgressValue=50,
		ProgressBarBackground = Colors.Red
    };

    sfstepProgressbar.ItemsSource = viewModel.StepProgressItem;
    this.Content = sfstepProgressbar;
}

{% endhighlight %}
{% endtabs %}

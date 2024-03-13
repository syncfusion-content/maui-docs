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
You can customize the step content type, size, active step index, strole width and acctive step progress value by using these properties, [ContentType]() with [Numbering](), [Tick](), [Cross](), [Dot]() and [Images](), [StepSize](), [StepContentSize](), [ActiveStepIndex](), [StepStrokeWidth](), [ActiveStepProgressValue](). 

{% tabs %}
{% highlight xaml hl_lines="2 3 4 5 6 9 12 15" %}

<progressBar:SfStepProgressBar x:Name = "stepProgressBar"
                            StepSize="20"
                            StepContentSize="15"
							ActiveStepIndex="1"
							StepStrokeWidth="10"    
                            ActiveStepProgressValue="60">

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
Customize the progress animation duration and background by using the [ProgressAnimationDuration](), [ProgressBarBackground]() properties in `SfStepProgressBar`. Please find following code example explains how to use `ProgressAnimationDuration` and `ProgressBarBackground` in step progress bar.

{% tabs %}
{% highlight xaml hl_lines="2 3" %}

<progressBar:SfStepProgressBar x:Name = "stepProgressBar" 
                        ProgressBarBackground="LightBlue" 
						ProgressAnimationDuration="2000"
						ActiveStepIndex="1" 
						ActiveStepProgressValue="40">
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

public MainPage()
{
    InitializeComponent();
    SfStepProgressBar sfstepProgressbar = new SfStepProgressBar()
    {
        ActiveStepIndex = 1,
        ActiveStepProgressValue=50,
        ProgressBarBackground=Colors.LightBlue,
        ProgressAnimationDuration=2000
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
}

{% endhighlight %}
{% endtabs %}

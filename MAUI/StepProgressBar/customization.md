---
layout: post
title: Customization with .NET MAUI Step ProgressBar control | Syncfusion
description: Learn here all about Customization support with Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar).
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Customizations in .NET MAUI StepProgressBar (SfStepProgressBar)
You can highly customize the appearance of the Step progress bar background color, step size, content size, animations, and more.

## Customize step shape
Customize the shape of the step by using the [ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ShapeType) property from `StepSettings`. By default the value of `ShapeType` is `Circle`. 

{% tabs %}
{% highlight xaml hl_lines="4 7 10" %}

<progressBar:SfStepProgressBar x:Name = "stepProgressBar" ItemsSource="{Binding ShipmentInfoCollection}"
                ActiveStepIndex="2" ActiveStepProgressValue="50">
    <progressBar:SfStepProgressBar.InProgressStepSettings>
        <progressBar:StepSettings Background="#ff67579c" ContentType="Dot" ShapeType="Square" ContentFillColor="White"/>
    </progressBar:SfStepProgressBar.InProgressStepSettings>
    <progressBar:SfStepProgressBar.CompletedStepSettings>
        <progressBar:StepSettings Background="#ff67579c" ContentType="Tick" ShapeType="Square" ContentFillColor="White"/>
    </progressBar:SfStepProgressBar.CompletedStepSettings>
    <progressBar:SfStepProgressBar.NotStartedStepSettings>
        <progressBar:StepSettings Background="#ff67579c" ContentType="Cross" ShapeType="Square" ContentFillColor="White"/>
    </progressBar:SfStepProgressBar.NotStartedStepSettings>
</progressBar:SfStepProgressBar>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfStepProgressBar sfstepProgressbar = new SfStepProgressBar()
    {
        ActiveStepIndex = 2,
        ActiveStepProgressValue=50,
    };
          
    StepSettings inProgressStepSettings = new StepSettings();
    inProgressStepSettings.Background = Color.FromHex("#ff67579c");
    inProgressStepSettings.ContentType = StepContentType.Dot;
    inProgressStepSettings.ShapeType = StepShapeType.Square;
    inProgressStepSettings.ContentFillColor = Colors.White;

    StepSettings completedStepSettings = new StepSettings();
    completedStepSettings.Background = Color.FromHex("#ff67579c");
    completedStepSettings.ContentType = StepContentType.Tick;
    completedStepSettings.ShapeType = StepShapeType.Square;
    completedStepSettings.ContentFillColor = Colors.White;

    StepSettings notStartedStepSettings = new StepSettings();
    notStartedStepSettings.Background = Color.FromHex("#ff67579c");
    notStartedStepSettings.ContentType = StepContentType.Cross;
    notStartedStepSettings.ShapeType = StepShapeType.Square;
    notStartedStepSettings.ContentFillColor = Colors.White;

    sfstepProgressbar.InProgressStepSettings = inProgressStepSettings;
    sfstepProgressbar.NotStartedStepSettings = notStartedStepSettings;
    sfstepProgressbar.CompletedStepSettings = completedStepSettings;

    this.Content = sfstepProgressbar;
}

{% endhighlight %}
{% endtabs %}

 ![Step shape in .NET MAUI SfStepProgressBar.](images/customization/maui-stepprogressbar-stepshape.png){:width="286" height="351"}

## Customize step content 
Customize the step content type by using the [ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ContentType) property with [Numbering](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepContentType.html#Syncfusion_Maui_ProgressBar_StepContentType_Numbering), [Tick](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepContentType.html#Syncfusion_Maui_ProgressBar_StepContentType_Tick), [Cross](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepContentType.html#Syncfusion_Maui_ProgressBar_StepContentType_Cross), [Dot](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepContentType.html#Syncfusion_Maui_ProgressBar_StepContentType_Dot) and [Images](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_ImageSource). 

{% tabs %}
{% highlight xaml hl_lines="9 12 15" %}

<progressBar:SfStepProgressBar x:Name = "stepProgressBar"
                        StepSize="40"
                        StepContentSize="25"
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
    StepContentSize = 25,
    StepSize = 40
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

 ![Step content in .NET MAUI SfStepProgressBar.](images/customization/maui-stepprogressbar-stepcontent.png){:width="286" height="351"}
 
## Animation duration
Customize the progress animation duration by using the [ProgressAnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ProgressAnimationDuration) property in `SfStepProgressBar`. By default the value of the animation duration is `1000`.

{% tabs %}
{% highlight xaml hl_lines="3" %}

<progressBar:SfStepProgressBar x:Name = "stepProgressBar" 
                        ProgressBarBackground="LightBlue" 
						ProgressAnimationDuration="2000"
						ActiveStepIndex="1" 
						ActiveStepProgressValue="40">
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
          
    this.Content = sfstepProgressbar;
}

{% endhighlight %}
{% endtabs %}

## Progress bar background
You can customize the progress bar background of the step progress bar by using the [ProgressBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ProgressBarBackground) property in `SfStepProgressBar`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<progressBar:SfStepProgressBar x:Name = "stepProgressBar" 
                        ProgressBarBackground="LightBlue">
</progressBar:SfStepProgressBar>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfStepProgressBar sfstepProgressbar = new SfStepProgressBar()
    {
        ProgressBarBackground=Colors.LightBlue,
    };
          
    this.Content = sfstepProgressbar;
}

{% endhighlight %}
{% endtabs %}

## Customize step appearance
You can customize the appearance of the steps by using the [ShapeType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ShapeType), [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_Background), [ContentType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ContentType), [ContentFillColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ContentFillColor), [ProgressColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_ProgressColor), [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_Stroke), and [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html#Syncfusion_Maui_ProgressBar_StepSettings_TextStyle) properties from the [InProgressStepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_InProgressStepSettings) for the in-progress state, [CompletedStepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_CompletedStepSettings) for the completed state, and [NotStartedStepSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_NotStartedStepSettings) for the not-started state. 

{% tabs %}
{% highlight xaml hl_lines="4 5 6 7 9 11 12 13 14 19 20 21 22" %}

<progressBar:SfStepProgressBar x:Name = "stepProgressBar" ItemsSource="{Binding ShipmentInfoCollection}"
                ActiveStepIndex="2" ActiveStepProgressValue="50">
    <progressBar:SfStepProgressBar.InProgressStepSettings>
            <progressBar:StepSettings Background="#ff67579c" ContentType="Dot" ShapeType="Circle" ProgressColor="Orange" ContentFillColor="White" Stroke="DarkViolet">
                <progressBar:StepSettings.TextStyle>
                    <progressBar:StepTextStyle TextColor="CadetBlue" FontAttributes="Bold"/>
                </progressBar:StepSettings.TextStyle>
            </progressBar:StepSettings>
        </progressBar:SfStepProgressBar.InProgressStepSettings>
    <progressBar:SfStepProgressBar.CompletedStepSettings>
            <progressBar:StepSettings Background="#ff67579c" ContentType="Tick" ShapeType="Circle" ProgressColor="Orange" ContentFillColor="White" Stroke="DarkViolet">
                <progressBar:StepSettings.TextStyle>
                    <progressBar:StepTextStyle TextColor="CadetBlue" FontAttributes="Bold"/>
                </progressBar:StepSettings.TextStyle>
            </progressBar:StepSettings>
        </progressBar:SfStepProgressBar.CompletedStepSettings>
    <progressBar:SfStepProgressBar.NotStartedStepSettings>
            <progressBar:StepSettings Background="#ff67579c" ContentType="Cross" ShapeType="Circle" ProgressColor="Orange" ContentFillColor="White"  Stroke="DarkViolet">
                <progressBar:StepSettings.TextStyle>
                    <progressBar:StepTextStyle TextColor="CadetBlue" FontAttributes="Bold"/>
                </progressBar:StepSettings.TextStyle>
            </progressBar:StepSettings>
        </progressBar:SfStepProgressBar.NotStartedStepSettings>
</progressBar:SfStepProgressBar>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
        SfStepProgressBar sfstepProgressbar = new SfStepProgressBar()
        {
            ActiveStepIndex = 2,
            ActiveStepProgressValue = 50,
    };

    StepTextStyle inprogressTextStyle = new StepTextStyle();
    inprogressTextStyle.TextColor = Colors.CadetBlue;
    inprogressTextStyle.FontAttributes = FontAttributes.Bold;

    StepTextStyle completedTextStyle = new StepTextStyle();
    completedTextStyle.TextColor = Colors.CadetBlue;
    completedTextStyle.FontAttributes = FontAttributes.Bold;

    StepTextStyle notStartedTextStyle = new StepTextStyle();
    notStartedTextStyle.TextColor = Colors.CadetBlue;
    notStartedTextStyle.FontAttributes = FontAttributes.Bold;

    StepSettings inProgressStepSettings = new StepSettings();
    inProgressStepSettings.Background = Color.FromHex("#ff67579c");
    inProgressStepSettings.ContentType = StepContentType.Dot;
    inProgressStepSettings.ShapeType = StepShapeType.Square;
    inProgressStepSettings.ContentFillColor = Colors.White;
    inProgressStepSettings.Stroke= Colors.DarkViolet;
    inProgressStepSettings.TextStyle = inprogressTextStyle;

    StepSettings completedStepSettings = new StepSettings();
    completedStepSettings.Background = Color.FromHex("#ff67579c");
    completedStepSettings.ContentType = StepContentType.Tick;
    completedStepSettings.ShapeType = StepShapeType.Square;
    completedStepSettings.ContentFillColor = Colors.White;
    completedStepSettings.Stroke = Colors.DarkViolet;
    completedStepSettings.TextStyle = completedTextStyle;

    StepSettings notStartedStepSettings = new StepSettings();
    notStartedStepSettings.Background = Color.FromHex("#ff67579c");
    notStartedStepSettings.ContentType = StepContentType.Cross;
    notStartedStepSettings.ShapeType = StepShapeType.Square;
    notStartedStepSettings.ContentFillColor = Colors.White;
    notStartedStepSettings.Stroke = Colors.DarkViolet;
    notStartedStepSettings.TextStyle = notStartedTextStyle;

    sfstepProgressbar.InProgressStepSettings = inProgressStepSettings;
    sfstepProgressbar.NotStartedStepSettings = notStartedStepSettings;
    sfstepProgressbar.CompletedStepSettings = completedStepSettings;

    this.Content = sfstepProgressbar;
}

{% endhighlight %}
{% endtabs %}

 ![Step customization in .NET MAUI SfStepProgressBar.](images/customization/maui-stepprogressbar-customstepprogress.png){:width="286" height="351"}
---
layout: post
title: Working with .NET MAUI Smart Scheduler control | Syncfusion®
description: Learn here all about working with Syncfusion<sup>&reg;</sup> .NET MAUI Smart Scheduler(SfSmartScheduler) control.
platform: maui
control: SfSmartScheduler
documentation: ug
keywords : .net maui smart scheduler  
---

# Working with .NET MAUI Smart Scheduler (SfSmartScheduler)

## Assist Button

You can customize the assist button interaction and the default appearance of assist button by setting the `EnableAssistButton` and `AssistButtonTemplate` properties of `SfSmartScheduler` control.

### Enable assist button

The assist button interaction can be enabled or disabled by setting the `EnableAssistButton` property of the `SfSmartScheduler` control. By default, the `EnableAssistButton` property is set to true.

{% tabs %}
{% highlight XAML hl_lines="2" %}

 <smartScheduler:SfSmartScheduler x:Name="Scheduler" EnableAssistButton="False"/>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler scheduler = new SfSmartScheduler();
smartScheduler.EnableAssistButton = false;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

### Customize assist button appearance using DataTemplate

The assist button appearance can be customized by using the `AssistButtonTemplate` property of `SfSmartScheduler` control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6 7 8 9 10 11 12 13" %}

 <smartScheduler:SfSmartScheduler x:Name="Scheduler">
    <smartScheduler:SfSmartScheduler.AssistButtonTemplate>
     <DataTemplate>
         <Grid BackgroundColor="#6750A4">
             <Label Text="AI"
                FontAttributes="Bold"
                TextColor="#FFFFFF"
                VerticalOptions="Center"
                HorizontalOptions="Center" />
         </Grid>
     </DataTemplate>
 </smartScheduler:SfSmartScheduler.AssistButtonTemplate>
 </scheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistButtonTemplate = new DataTemplate(() =>
{
    var grid = new Grid
    {
        BackgroundColor = Color.FromArgb("#6750A4")
    };

    var label = new Label
    {
        Text = "AI",
        FontAttributes = FontAttributes.Bold,
        TextColor = Color.FromArgb("#FFFFFF"),
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };

    grid.Add(label);
    return grid;
});
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}

## Assist View

You can customize default appearance of the assist button view by setting the `AssistViewHeight`, `AssistViewWidth`, `AssistViewHeaderText`, `Placeholder`, `Prompt`, `SuggestedPrompts` and `ShowAssistViewBanner` properties of `SfSmartScheduler` control.

### Assist view height

The assist view height can be customized by using the `AssistViewHeight` property of the `AssistViewSettings`.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<smartScheduler:SfSmartScheduler  x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings AssistViewHeight="420"/>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler scheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings.AssistViewHeight = 420;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

### Assist view width

The assist view width can be customized by using the `AssistViewWidth` property of the `AssistViewSettings`.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<smartScheduler:SfSmartScheduler  x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings AssistViewWidth="250"/>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler scheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings.AssistViewWidth = 250;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

### Assist view header text

The assist view header text can be customized by using the `AssistViewHeaderText` property of the `AssistViewSettings`. By default, `AI Assistant` text is shown in the assist view header.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<smartScheduler:SfSmartScheduler  x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings AssistViewHeaderText="Smart Scheduler"/>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings.AssistViewHeaderText = "Smart Scheduler";
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}

### Placeholder

The assist view placeholder text can be customized by using the `Placeholder` property of the `AssistViewSettings`. By default, `Type here...` text is shown in the placeholder.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<smartScheduler:SfSmartScheduler  x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings Placeholder="Enter your message..."/>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings.Placeholder = "Enter your message...";
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}

### Prompt

The assist view prompt text can be customized by using the `Prompt` property of the `AssistViewSettings`. By default, the `Prompt` property is set to empty.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<smartScheduler:SfSmartScheduler  x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings Prompt="Find 30-minute slots this week"/>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings.Prompt = "Find 30-minute slots this week";
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}

### Suggested Prompts

The assist view suggested prompts can be customized by using the `SuggestedPrompts` property of the `AssistViewSettings`. By default, the `SuggestedPrompts` property is set to null.

{% tabs %}
{% highlight XAML hl_lines="4" %}

<smartScheduler:SfSmartScheduler x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings >
        <smartScheduler:SchedulerAssistViewSettings ShowAssistViewBanner="True">
            <smartScheduler:SchedulerAssistViewSettings.SuggestedPrompts>
                <x:Array Type="{x:Type x:String}">
                    <x:String>Find free slots</x:String>
                    <x:String>Create a meeting</x:String>
                    <x:String>Summarize today</x:String>
                </x:Array>
            </smartScheduler:SchedulerAssistViewSettings.SuggestedPrompts>
        </smartScheduler:SchedulerAssistViewSettings>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# hl_lines="4 5 6 7 8 9" %}

 SfSmartScheduler smartScheduler = new SfSmartScheduler();
 smartScheduler.AssistViewSettings.ShowAssistViewBanner = true;
 smartScheduler.AssistViewSettings.SuggestedPrompts = new List<string>
 {
     "Schedule meeting",
     "Set reminder",
     "Book appointment"
 };
 this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}

### Show assist view banner

The assist view banner visibility can be customized by using the `ShowAssistViewBanner` property of the `AssistViewSettings`. By default, the `ShowAssistViewBanner` property is set to false.

{% tabs %}
{% highlight XAML tabtitle="MainPage.xaml" hl_lines="4" %}

<smartScheduler:SfSmartScheduler  x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings ShowAssistViewBanner="True"/>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# tabtitle="MainPage.xaml.cs" hl_lines="3" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings = new SchedulerAssistViewSettings();
smartScheduler.AssistViewSettings.ShowAssistViewBanner = true;
smartScheduler.AssistViewSettings.AssistViewBannerTemplate = new DataTemplate(() =>
{
    return new Grid
    {
        Padding = 6,
        BackgroundColor = Color.FromArgb("#EEF2FF"),
        Children =
        {
            new Label
            {
                Text = "Try asking: 'Create a standup at 10 AM'",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromArgb("#1C1B1F")
            }
        }
    };
});
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}

## Template Customization

The `SfSmartScheduler` facilitates the customization of both header and banner templates according to specific requirements. This feature enhances flexibility and provides a higher degree of control over the display of assist view.

### Customize assist view header appearance using DataTemplate

The assist view header appearance can be customized by using the `AssistViewHeaderTemplate` property of the `AssistViewSettings`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 6 7 8 9 10 11" %}

<smartScheduler:SfSmartScheduler x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings>
            <smartScheduler:SchedulerAssistViewSettings.AssistViewHeaderTemplate>
                <DataTemplate>
                    <Grid Padding="8">
                        <Label Text="AI Assistant" FontAttributes="Bold" />
                    </Grid>
                </DataTemplate>
            </smartScheduler:SchedulerAssistViewSettings.AssistViewHeaderTemplate>
        </smartScheduler:SchedulerAssistViewSettings>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings = new SchedulerAssistViewSettings();
smartScheduler.AssistViewSettings.AssistViewHeaderTemplate = new DataTemplate(() =>
{
    return new Grid
    {
        Padding = 8,
        Children =
        {
            new Label
            {
                Text = "AI Assistant",
                FontAttributes = FontAttributes.Bold
            }
        }
    };
});
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}

### Customize assist view banner appearance using DataTemplate

The assist view banner appearance can be customized by using the `AssistViewBannerTemplate` property of the `AssistViewSettings`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 6 7 8 9 10 11 12 13" %}

<smartScheduler:SfSmartScheduler x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings ShowAssistViewBanner="True">
            <smartScheduler:SchedulerAssistViewSettings.AssistViewBannerTemplate>
                <DataTemplate>
                    <Grid Padding="6" BackgroundColor="#EEF2FF">
                        <Label Text="Try asking: 'Create a standup at 10 AM'"
                                    FontAttributes="Bold"
                                    TextColor="#1C1B1F" />
                    </Grid>
                </DataTemplate>
            </smartScheduler:SchedulerAssistViewSettings.AssistViewBannerTemplate>
        </smartScheduler:SchedulerAssistViewSettings>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings = new SchedulerAssistViewSettings();
smartScheduler.AssistViewSettings.ShowAssistViewBanner = true;
smartScheduler.AssistViewSettings.AssistViewBannerTemplate = new DataTemplate(() =>
{
    return new Grid
    {
        Padding = 6,
        BackgroundColor = Color.FromArgb("#EEF2FF"),
        Children =
        {
            new Label
            {
                Text = "Try asking: 'Create a standup at 10 AM'",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromArgb("#1C1B1F")
            }
        }
    };
});
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}